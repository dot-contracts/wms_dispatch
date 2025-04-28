using System;
using System.Diagnostics;
using System.Threading.Tasks;
using wms_android.Interfaces;
using wms_android.Utils; // For CS30PosApiHelper

namespace wms_android.Services
{
    /// <summary>
    /// Implementation of IPrinterService specifically for the CS30 device.
    /// Uses the CS30PosApiHelper utility class internally.
    /// </summary>
    public class Cs30PrinterService : IPrinterService
    {
        private const string TAG = "Cs30PrinterService";
        private bool _isInitialized = false;

        // Get the singleton instance of the underlying helper
        private readonly CS30PosApiHelper _helper = CS30PosApiHelper.Instance;

        public async Task<bool> InitializePrinterAsync()
        {
            if (_isInitialized)
            {
                Debug.WriteLine($"{TAG}: Already initialized.");
                return true;
            }

            Debug.WriteLine($"{TAG}: Initializing printer...");
            try
            {
                // Run the synchronous initialization from the helper on a background thread
                int result = await Task.Run(() => _helper.PrintInit(2, 2, 0, 0)); // Using default params, adjust if needed
                
                _isInitialized = (result == 0);
                
                if (_isInitialized)
                {
                     Debug.WriteLine($"{TAG}: Initialization successful.");
                     // Optionally set default font after successful init
                     await Task.Run(() => _helper.SetDefaultFont());
                }
                else
                {
                    Debug.WriteLine($"{TAG}: Initialization failed with code: {result}");
                }
                return _isInitialized;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{TAG}: Initialization exception: {ex.Message}");
                _isInitialized = false;
                return false;
            }
        }

        public async Task<bool> PrintTextAsync(string textContent)
        {
            if (!_isInitialized)
            {
                Debug.WriteLine($"{TAG}: Printer not initialized. Cannot print text.");
                // Optionally attempt initialization here?
                // bool initSuccess = await InitializePrinterAsync();
                // if (!initSuccess) return false;
                return false; 
            }

            Debug.WriteLine($"{TAG}: Printing text (async wrapper)...");
            try
            {
                // Assume PrintStr needs to be called followed by PrintStart
                // This might need adjustment based on how CS30PosApiHelper is intended to be used
                // (e.g., maybe PrintStart is only called once after multiple PrintStr calls)
                int resultStr = await Task.Run(() => _helper.PrintStr(textContent));
                if (resultStr != 0)
                {
                     Debug.WriteLine($"{TAG}: PrintStr failed with code: {resultStr}");
                     return false;
                }
                
                int resultStart = await Task.Run(() => _helper.PrintStart());
                if (resultStart != 0)
                {
                     Debug.WriteLine($"{TAG}: PrintStart failed with code: {resultStart}");
                     return false;
                }
                
                Debug.WriteLine($"{TAG}: Text print command sent successfully.");
                return true; 
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{TAG}: PrintTextAsync exception: {ex.Message}");
                return false;
            }
        }

        public async Task<string> GetPrinterStatusAsync()
        {
             if (!_isInitialized)
            {
                Debug.WriteLine($"{TAG}: Printer not initialized. Cannot get status.");
                return "Not Initialized";
            }
            
            Debug.WriteLine($"{TAG}: Getting printer status (async wrapper)...");
            try
            {
                // Run the synchronous status check from the helper on a background thread
                string status = await Task.Run(() => _helper.GetStatusMessage());
                Debug.WriteLine($"{TAG}: Status retrieved: {status}");
                return status;
            }
            catch (Exception ex)
            {
                 Debug.WriteLine($"{TAG}: GetPrinterStatusAsync exception: {ex.Message}");
                 return "Error Getting Status";
            }
        }

        public void ClosePrinter()
        {
            // The CS30PosApiHelper and underlying SDK might not have an explicit close method.
            // If resources need cleanup, it should be added to CS30PosApiHelper and called here.
            Debug.WriteLine($"{TAG}: ClosePrinter called. (Note: CS30 SDK might not require explicit close). Check CS30PosApiHelper if cleanup is needed.");
            _isInitialized = false; // Mark as not initialized
            // Example if helper had cleanup: Task.Run(() => _helper.CleanupResources());
        }

        // TODO: Implement other IPrinterService methods (PrintBarcodeAsync, PrintImageAsync, etc.)
        // by calling corresponding methods on _helper, wrapped in Task.Run.

    }
} 