using System;
using System.Threading.Tasks;
using System.Diagnostics;
using Android.Graphics;
using Android.Content;
using wms_android.Interfaces;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Android.OS;
using Com.Ctk.Sdk;

namespace wms_android.Utils
{
    /// <summary>
    /// Implementation of printer functionality for CS30 device using AndroidPosSdk
    /// </summary>
    public class CS30PosApiHelper : Java.Lang.Object, IPosApiHelper, IServiceConnection
    {
        private static CS30PosApiHelper _instance;
        private bool _isPrinterInitialized = false;
        private Context _context;
        private const string TAG = "CS30PosApiHelper";
        private readonly object _initLock = new object(); // Lock for thread-safe initialization
        private int _initializationAttempts = 0;
        private const int MAX_INIT_ATTEMPTS = 3; // Reduced max attempts slightly
        private Com.Ctk.Sdk.PosApiHelper _sdkHelperInstance;

        public static CS30PosApiHelper Instance => _instance ??= new CS30PosApiHelper();

        private CS30PosApiHelper()
        {
            _context = Android.App.Application.Context;
            // Get the SDK instance
            _sdkHelperInstance = Com.Ctk.Sdk.PosApiHelper.Instance;
            if (_sdkHelperInstance == null)
            {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: CRITICAL - Failed to get Com.Ctk.Sdk.PosApiHelper instance!");
                 // Consider throwing an exception here or handling it more robustly
            }
            System.Diagnostics.Debug.WriteLine($"{TAG}: Instance created, SDK Helper Instance: {(_sdkHelperInstance != null)}");
        }

        public int PrintInit(int gray, int density, int mode, int otherOptions)
        {
            lock (_initLock) // Ensure thread safety during initialization
            {
                if (_isPrinterInitialized)
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: Printer already initialized");
                    return 0;
                }

                if (_sdkHelperInstance == null)
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintInit Error - SDK Helper Instance is null");
                    return -1;
                }

                _initializationAttempts++;
                System.Diagnostics.Debug.WriteLine($"{TAG}: Initialization attempt #{_initializationAttempts}");
                
                if (_initializationAttempts > MAX_INIT_ATTEMPTS)
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: Exceeded maximum initialization attempts ({MAX_INIT_ATTEMPTS})");
                    return -99; // Special error code for too many attempts
                }

                try
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: Initializing CS30 printer with gray={gray}, density={density}, mode={mode}, other={otherOptions}");
                    
                    // Reset state before initialization
                    _isPrinterInitialized = false;
                    
                    // Use the SDK's PrintInit method
                    // Choose the appropriate overload. Using the one matching your interface parameters.
                    int result = _sdkHelperInstance.PrintInit(gray, density, mode, otherOptions);
                    // Assuming 0 is success based on typical SDK patterns
                    if (result == 0) 
                    {
                         _isPrinterInitialized = true;
                         System.Diagnostics.Debug.WriteLine($"{TAG}: CS30 printer successfully initialized (Result Code: {result})");
                         return 0;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"{TAG}: CS30 printer initialization failed (Result Code: {result})");
                        return -1; // Indicate failure
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: Error during printer initialization: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"{TAG}: Stack Trace: {ex.StackTrace}");
                    return -1;
                }
            }
        }

        /// <summary>
        /// Sets the default font settings appropriate for the device
        /// </summary>
        /// <returns>0 if successful, -1 if there was an error</returns>
        public int SetDefaultFont()
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: SetDefaultFont Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Setting default font for CS30 device");
                // TODO: Determine the correct default width/height/style for CS30 from docs if needed.
                // Using 8,8,0 as a plausible default for now.
                sbyte width = 8;
                sbyte height = 8;
                sbyte style = 0; 
                int result = _sdkHelperInstance.PrintSetFont(width, height, style); 
                if (result == 0)
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: Default font set successfully.");
                    return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: SetDefaultFont failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: SetDefaultFont Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"{TAG}: Stack trace: {ex.StackTrace}");
                return -1;
            }
        }

        public int PrintSetAlign(int align)
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: PrintSetAlign Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Setting alignment to {align}");
                int result = _sdkHelperInstance.PrintSetAlign(align);
                if (result == 0)
                {
                return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintSetAlign failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: PrintSetAlign Error: {ex.Message}");
                return -1;
            }
        }

        public int PrintSetFont(sbyte width, sbyte height, sbyte style)
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: PrintSetFont Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Setting font - width: {width}, height: {height}, style: {style:X2}");
                int result = _sdkHelperInstance.PrintSetFont(width, height, style);
                 if (result == 0)
                {
                return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintSetFont failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: PrintSetFont Error: {ex.Message}");
                return -1;
            }
        }

        public int PrintStr(string text)
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: PrintStr Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Printing text: {(text?.Length > 30 ? text.Substring(0, 30) + "..." : text ?? "<null>")}");
                int result = _sdkHelperInstance.PrintStr(text); 
                 if (result == 0)
                {
                return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintStr failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: PrintStr Error: {ex.Message}");
                return -1;
            }
        }

        public int PrintQrCode_Cut(string content, int width, int height, string format)
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: PrintQrCode_Cut Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Printing QR code: {content}, width={width}, height={height}, format={format}");
                // Note: The generated SDK has PrintQrCode_Cut(string p0, int p1, int p2, string p3)
                // Assuming parameters match: content, width, height, format
                int result = _sdkHelperInstance.PrintQrCode_Cut(content, width, height, format); 
                 if (result == 0)
                {
                return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintQrCode_Cut failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: PrintQrCode_Cut Error: {ex.Message}");
                return -1;
            }
        }

        public int PrintFeedPaper(int lines)
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: PrintFeedPaper Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Feeding paper: {lines} lines");
                int result = _sdkHelperInstance.PrintFeedPaper(lines);
                 if (result == 0)
                {
                return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintFeedPaper failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: PrintFeedPaper Error: {ex.Message}");
                return -1;
            }
        }

        public int PrintStart()
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: PrintStart Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Starting print job");
                int result = _sdkHelperInstance.PrintStart();
                 if (result == 0)
                {
                return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintStart failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: PrintStart Error: {ex.Message}");
                return -1;
            }
        }

        public int PrintBitmap(Bitmap bitmap)
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: PrintBitmap Error - Printer not initialized or SDK instance null.");
                 return -1;
             }
            try
            {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: Printing bitmap: {bitmap?.Width}x{bitmap?.Height}");
                int result = _sdkHelperInstance.PrintBmp(bitmap);
                 if (result == 0)
                {
                return 0;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"{TAG}: PrintBitmap failed (Result Code: {result})");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: PrintBitmap Error: {ex.Message}");
                return -1;
            }
        }

        public bool IsPaperReady()
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 System.Diagnostics.Debug.WriteLine($"{TAG}: IsPaperReady Error - Printer not initialized or SDK instance null.");
                 return false;
             }
            try
            {
                int status = _sdkHelperInstance.PrintCheckStatus();
                // TODO: Determine the status code for "No Paper" from CS30 documentation.
                // Assuming non-zero might mean error or no paper for now.
                // A specific code for no paper is likely (e.g., 1, 2, -1, etc.)
                bool isReady = (status == 0); 
                System.Diagnostics.Debug.WriteLine($"{TAG}: IsPaperReady Check - Status Code: {status}, IsReady: {isReady}");
                return isReady; 
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: IsPaperReady Error: {ex.Message}");
                return false;
            }
        }

        public string GetStatusMessage()
        {
             if (!_isPrinterInitialized || _sdkHelperInstance == null)
             {
                 return "Printer not initialized or SDK instance null.";
             }
            try
            {
                int status = _sdkHelperInstance.PrintCheckStatus();
                // TODO: Map CS30 status codes to meaningful messages based on documentation.
                string message;
                switch (status)
                {
                    case 0: message = "Printer Ready"; break;
                    // Add cases for other known status codes (No Paper, Overheat, Cover Open, etc.)
                    // case 1: message = "Printer Error: No Paper"; break;
                    // case 2: message = "Printer Error: Overheat"; break;
                    default: message = $"Printer Status Unknown (Code: {status})"; break;
                }
                 System.Diagnostics.Debug.WriteLine($"{TAG}: GetStatusMessage - Code: {status}, Message: {message}");
                return message;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: GetStatusMessage Error: {ex.Message}");
                return $"Error checking printer status: {ex.Message}";
            }
        }

        // This method seems redundant if IsPaperReady is implemented based on status code
        public bool IsPrinterReady()
        {
            if (!_isPrinterInitialized || _sdkHelperInstance == null)
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: IsPrinterReady Error - Printer not initialized or SDK instance null.");
                return false;
            }
            return IsPaperReady(); // Reuse the status check logic
        }

        // IServiceConnection methods - Implement if actually binding to a service is required
        // If PosApiHelper.Instance works directly, these might not be needed.
        public void OnServiceConnected(ComponentName name, IBinder service)
        {
             System.Diagnostics.Debug.WriteLine($"{TAG}: OnServiceConnected - {name?.ClassName}");
             // Handle service binding if necessary
        }

        public void OnServiceDisconnected(ComponentName name)
        {
             System.Diagnostics.Debug.WriteLine($"{TAG}: OnServiceDisconnected - {name?.ClassName}");
             // Handle service unbinding if necessary
        }
    }
}
