using System;
using System.Threading.Tasks;
using Android.Graphics;
using wms_android.Interfaces;
using wms_android.Utils;
using Microsoft.Extensions.Logging;

namespace wms_android.Services
{
    public class CS30PrinterService : IPrinterService
    {
        private readonly ICs30PosApi _printerHelper;
        private bool _isInitialized;
        private readonly ILogger<CS30PrinterService> _logger;

        public CS30PrinterService(ILogger<CS30PrinterService> logger)
        {
            _logger = logger;
            _printerHelper = (ICs30PosApi)CS30PosApiHelper.Instance;
        }

        public async Task<bool> InitializePrinterAsync()
        {
            try
            {
                if (_isInitialized)
                {
                    return true;
                }

                var result = await Task.Run(() => _printerHelper.PrintInit(2, 2, 0, 0));
                _isInitialized = result == 0;
                
                if (_isInitialized)
                {
                    _logger.LogInformation("CS30 printer initialized successfully");
                }
                else
                {
                    _logger.LogError("Failed to initialize CS30 printer");
                }

                return _isInitialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error initializing CS30 printer");
                return false;
            }
        }

        public async Task<bool> PrintTextAsync(string text)
        {
            return await PrintTextAsync(text, 24, false);
        }

        public async Task<bool> PrintTextAsync(string text, int fontSize, bool isBold)
        {
            try
            {
                if (!_isInitialized)
                {
                    var initialized = await InitializePrinterAsync();
                    if (!initialized)
                    {
                        return false;
                    }
                }

                // Set font
                var fontResult = await Task.Run(() => _printerHelper.PrintSetFont((sbyte)fontSize, (sbyte)fontSize, (sbyte)(isBold ? 1 : 0)));
                if (fontResult != 0)
                {
                    _logger.LogError($"Failed to set font: {fontResult}");
                    return false;
                }

                // Print text
                var printResult = await Task.Run(() => _printerHelper.PrintStr(text));
                if (printResult != 0)
                {
                    _logger.LogError($"Failed to print text: {printResult}");
                    return false;
                }

                // Start printing
                var startResult = await Task.Run(() => _printerHelper.PrintStart());
                return startResult == 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error printing text");
                return false;
            }
        }

        public async Task<bool> PrintQRCodeAsync(string content, int width, int height)
        {
            try
            {
                if (!_isInitialized)
                {
                    var initialized = await InitializePrinterAsync();
                    if (!initialized)
                    {
                        return false;
                    }
                }

                // Print QR code with specified dimensions
                var result = await Task.Run(() => _printerHelper.PrintQrCode(content, width, height));
                if (result != 0)
                {
                    _logger.LogError($"Failed to print QR code: {result}");
                    return false;
                }

                // Start printing
                var startResult = await Task.Run(() => _printerHelper.PrintStart());
                return startResult == 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error printing QR code");
                return false;
            }
        }

        public async Task<bool> PrintImageAsync(byte[] imageData, int width)
        {
            try
            {
                if (!await InitializePrinterAsync())
                {
                    return false;
                }

                using var bitmap = await BitmapFactory.DecodeByteArrayAsync(imageData, 0, imageData.Length);
                if (bitmap == null)
                {
                    _logger.LogError("Failed to decode image data");
                    return false;
                }

                // Scale bitmap to printer width while maintaining aspect ratio
                float scale = (float)width / bitmap.Width;
                int height = (int)(bitmap.Height * scale);

                using var scaledBitmap = Bitmap.CreateScaledBitmap(bitmap, width, height, true);
                
                // Convert bitmap to bytes
                using var stream = new System.IO.MemoryStream();
                await scaledBitmap.CompressAsync(Bitmap.CompressFormat.Png, 100, stream);
                var bitmapBytes = stream.ToArray();

                var result = await Task.Run(() => _printerHelper.PrintBitmap(bitmapBytes, width, height));
                if (result != 0)
                {
                    _logger.LogError($"Failed to print image: {result}");
                    return false;
                }

                var startResult = await Task.Run(() => _printerHelper.PrintStart());
                return startResult == 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error printing image on CS30 printer");
                return false;
            }
        }

        public async Task<bool> FeedPaperAsync(int lines)
        {
            try
            {
                if (!await InitializePrinterAsync())
                {
                    return false;
                }

                var result = await Task.Run(() => _printerHelper.PrintFeedPaper(lines));
                return result == 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error feeding paper on CS30 printer");
                return false;
            }
        }

        public async Task<bool> CutPaperAsync()
        {
            try
            {
                if (!_isInitialized)
                {
                    return false;
                }

                // Feed paper before cutting
                var feedResult = await Task.Run(() => _printerHelper.PrintFeedPaper(3));
                if (feedResult != 0)
                {
                    _logger.LogError($"Failed to feed paper: {feedResult}");
                    return false;
                }

                // Start printing to execute the cut
                var startResult = await Task.Run(() => _printerHelper.PrintStart());
                return startResult == 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error cutting paper");
                return false;
            }
        }

        public async Task<string> GetPrinterStatusAsync()
        {
            try
            {
                if (!_isInitialized)
                {
                    return "Printer not initialized";
                }

                var status = await Task.Run(() => _printerHelper.GetPrinterStatus());
                return status switch
                {
                    0 => "Printer is ready",
                    1 => "Printer error",
                    2 => "Paper out",
                    3 => "Printer busy",
                    _ => "Unknown error"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting printer status");
                return $"Error: {ex.Message}";
            }
        }

        public async Task<bool> StartPrintJobAsync()
        {
            try
            {
                if (!_isInitialized)
                {
                    var initialized = await InitializePrinterAsync();
                    if (!initialized)
                    {
                        return false;
                    }
                }

                var result = await Task.Run(() => _printerHelper.PrintStart());
                return result == 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error starting print job");
                return false;
            }
        }

        public void ClosePrinter()
        {
            try
            {
                if (_isInitialized)
                {
                    _printerHelper?.Dispose();
                    _isInitialized = false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error closing CS30 printer");
            }
        }
    }
} 