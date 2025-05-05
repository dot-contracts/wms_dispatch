using System;
using System.Text;
using System.Threading.Tasks;
using wms_android.Interfaces; // Ensure this using statement is present

// Required namespaces for the new API approach
#if ANDROID
using Android.App;
using Android.Content;
using Android.OS;
using Com.Vanstone.Trans.Api; // For SystemApi, ScanApi
using Com.Vanstone.Appsdk.Api.Interfaces; // For IScanResult
using Java.Lang; // For Java.Lang.Object when implementing IScanResult
#endif

namespace wms_android.Services
{
    public class VanstoneScannerService : IScannerService
    {
#if ANDROID
        private static TaskCompletionSource<string?>? _scanTcs;
        private static bool _isSystemInitialized = false; // Track system init state
        private static object _initLock = new object(); // Lock for initialization

        // Nested class to handle the asynchronous scan callback
        private class ScanResultCallback : Java.Lang.Object, IScanResult
        {
            private readonly TaskCompletionSource<string?> _tcs;

            public ScanResultCallback(TaskCompletionSource<string?> tcs)
            {
                _tcs = tcs;
            }

            // This method is called by the native SDK when scan completes, fails, or times out
            public void OnScanResult(int status, string? resultData)
            {
                Console.WriteLine($"ScanResultCallback - Status: {status}, Data: {resultData}");
                // Use constants from ScanApi for status check
                if (status == ScanApi.ScansDone)
                {
                    _tcs.TrySetResult(resultData);
                }
                else if (status == ScanApi.ScansTimerout)
                {
                     Console.WriteLine("Scan timed out via callback.");
                    _tcs.TrySetResult(null); // Timeout
                }
                 else if (status == ScanApi.ScansCancel)
                {
                     Console.WriteLine("Scan cancelled via callback.");
                    _tcs.TrySetResult(null); // Cancelled
                }
                else // Includes ScanApi.SCANS_ERROR or other unexpected codes
                {
                     Console.WriteLine($"Scan error via callback. Status code: {status}");
                    _tcs.TrySetResult(null); // Error
                }
            }
        }
#endif

        // Initialize only the System API here. Scanner is opened on demand in ScanAsync.
        public bool InitializeScanner()
        {
#if ANDROID
            lock (_initLock)
            {
                if (_isSystemInitialized)
                {
                     Console.WriteLine("Vanstone System API already initialized.");
                     return true;
                }

                try
                {
                    Console.WriteLine("Initializing Vanstone System API...");
                    // Use SystemApi.SystemInit_Api
                    // Parameters: (argc, argv, context, sdkStatueCallback)
                    // Pass 0, empty byte array, Application.Context, and null callback for now.
                    // Requires Application context
                    Context? context = Application.Context;
                    if (context == null) {
                        Console.WriteLine("Error: Application.Context is null. Cannot initialize SystemApi.");
                        return false;
                    }

                    byte[] initParams = new byte[0];
                    // Check documentation for correct return codes, assuming 0 is success for now.
                    int initResult = SystemApi.SystemInit_Api(0, initParams, context, null);

                    if (initResult == 0)
                    {
                        Console.WriteLine("Vanstone SystemInit_Api Successful.");
                        _isSystemInitialized = true;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Vanstone SystemInit_Api Failed. Code: {initResult}");
                        _isSystemInitialized = false;
                        return false;
                    }
                }
                catch (Java.Lang.Exception jex) // Catch Java exceptions
                {
                    Console.WriteLine($"Java Error initializing Vanstone System API: {jex.Message}");
                    Console.WriteLine($"Stack Trace: {jex.StackTrace}");
                     _isSystemInitialized = false;
                    return false;
                }
                catch (System.Exception ex) // Catch .NET exceptions
                {
                    Console.WriteLine($"System Error initializing Vanstone System API: {ex.Message}");
                    _isSystemInitialized = false;
                    return false;
                }
            }
#else
            Console.WriteLine("InitializeScanner: Not on Android platform.");
            return false; // Not supported on other platforms
#endif
        }

        public async Task<string?> ScanAsync(TimeSpan timeout)
        {
#if ANDROID
            // Ensure system is initialized first
            if (!InitializeScanner()) // This will only run the init logic once
            {
                 Console.WriteLine("ScanAsync failed: System not initialized.");
                 return null;
            }
            
            // Ensure only one scan happens at a time (optional, depends on SDK behavior)
            if (_scanTcs != null && !_scanTcs.Task.IsCompleted)
            {
                 Console.WriteLine("Scan already in progress.");
                 // Optionally: return _scanTcs.Task; // Allow caller to await existing scan
                 return null; // Or return null/throw exception to indicate busy
            }

            _scanTcs = new TaskCompletionSource<string?>();
            var scanCallback = new ScanResultCallback(_scanTcs);

            try
            {
                 Console.WriteLine($"Starting scan with timeout: {(int)timeout.TotalMilliseconds}ms");
                 var bundle = new Bundle();
                 // Configure the scan using ScanApi constants
                 bundle.PutInt(ScanApi.BdlScanCodeMode, ScanApi.BdlScanCodeOnlyQrcode); // 2 = QR Code only
                 bundle.PutInt(ScanApi.BdlScanTimeouts, (int)timeout.TotalMilliseconds);
                 // Add other options as needed:
                 // bundle.PutBoolean(ScanApi.BdlScanBuzzer, true);
                 // bundle.PutBoolean(ScanApi.BdlScanVibrate, true);
                 // bundle.PutBoolean(ScanApi.BDLSCANFlASH, false); // Control flash

                 // Open the scanner and start scanning asynchronously
                 // Check documentation for return codes, assuming 0 is success.
                 int openResult = ScanApi.ScanOpen_Api(bundle, scanCallback);

                 if (openResult == 0)
                 {
                     Console.WriteLine("ScanApi.ScanOpen_Api called successfully. Waiting for callback...");
                     // Wait for the callback to complete the TaskCompletionSource
                     return await _scanTcs.Task;
                 }
                 else
                 {
                     Console.WriteLine($"ScanApi.ScanOpen_Api failed. Code: {openResult}");
                     _scanTcs.TrySetResult(null); // Indicate failure
                         return null; 
                    }
            }
            catch (Java.Lang.Exception jex)
            {
                 Console.WriteLine($"Java Error during ScanAsync: {jex.Message}");
                 Console.WriteLine($"Stack Trace: {jex.StackTrace}");
                _scanTcs?.TrySetResult(null);
                return null;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"System Error during ScanAsync: {ex.Message}");
                _scanTcs?.TrySetResult(null);
                    return null;
                }
#else
            Console.WriteLine("ScanAsync: Not on Android platform.");
            await Task.Delay(100); // Simulate non-functional delay
            return null; // Not supported
#endif
        }

        public void CloseScanner()
        {
#if ANDROID
            try
            {
                 // Close the scanner using ScanApi
                 Console.WriteLine("Closing Vanstone Scanner via ScanApi.ScanClose_Api...");
                 int result = ScanApi.ScanClose_Api();
                 // Check documentation for return codes, assuming 0 is success.
                 Console.WriteLine(result == 0 ? "Vanstone Scanner Closed Successfully." : $"Error closing scanner via ScanApi. Code: {result}");
            }
             catch (Java.Lang.Exception jex)
            {
                 Console.WriteLine($"Java Error closing Vanstone Scanner: {jex.Message}");
                 Console.WriteLine($"Stack Trace: {jex.StackTrace}");
            }
            catch (System.Exception ex)
            {
                 Console.WriteLine($"System Error closing Vanstone Scanner: {ex.Message}");
            }
#else
             Console.WriteLine("CloseScanner: Not on Android platform.");
#endif
        }

        public void CancelScan()
        {
#if ANDROID
            // ScanApi might not have an explicit cancel. Closing might be the only way.
            Console.WriteLine("CancelScan requested. Attempting to close the scanner via ScanClose_Api...");
            CloseScanner(); // Call CloseScanner to attempt cancellation/cleanup
            // Also try to cancel the TaskCompletionSource if it's active
             _scanTcs?.TrySetCanceled();
#else
             Console.WriteLine("CancelScan: Not on Android platform.");
#endif
        }

        #region IDisposable Implementation
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Dispose managed state (managed objects).
                }

                // Free unmanaged resources (unmanaged objects) and override a finalizer below.
                // Ensure scanner is closed when service is disposed.
                Console.WriteLine("VanstoneScannerService Dispose executing CloseScanner...");
                    CloseScanner(); 
                // Note: SystemExit_Api is likely too drastic here. Let the app lifecycle manage the system state.
                
                disposedValue = true;
            }
        }

        // ~VanstoneScannerService()
        // {
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}