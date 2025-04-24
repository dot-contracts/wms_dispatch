using System;
using System.Threading.Tasks;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Com.Vanstone.Utils;
using wms_android.shared.Models;
using Microsoft.Maui.Controls;
using System.Net.Http;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Java.Lang;
using Java.Lang.Reflect;
using Android.App;
using Microsoft.Maui.ApplicationModel;
using Java.Util;
using Java.Interop;
using Com.Vanstone.Appsdk.Api.Interfaces;

namespace wms_android.Services
{
    /// <summary>
    /// Implements QR scanning functionality for Vanstone A90 and other POS devices
    /// </summary>
    public class QRScannerService : Java.Lang.Object, /* REMOVED: Java.Util.IObserver, */ wms_android.shared.Interfaces.IQRScannerService
    {
        private bool _isScanning;
        private readonly PosDeviceType _deviceType;
        private TaskCompletionSource<string> _scanCompletionSource;
        private Java.Lang.Object _apiEngine;
        private readonly Context _context;
        private static readonly string TAG = "QRScannerService";
        private bool _isSystemInitialized = false;
        
        // Debug flag for enabling detailed logging
        private readonly bool _enableDebugLogging = true;

        public bool IsScanning => _isScanning;

        public QRScannerService(HttpClient httpClient = null, IConfiguration configuration = null)
        {
            // Get the Android context
            _context = Android.App.Application.Context;
            _deviceType = DetermineDeviceType();
            
            try
            {
                // Initialize the Vanstone SDK system first
                InitializeVanstoneSystem();
                
                // Initialize the SDK API engine
                InitializeApiEngine();
            }
            catch (System.Exception ex)
            {
                DebugLog($"Error initializing Vanstone SDK: {ex.Message}");
                if (ex.InnerException != null)
                {
                    DebugLog($"Inner exception: {ex.InnerException.Message}");
                }
            }
        }
        
        private void InitializeVanstoneSystem()
        {
            // Reset initialization flag
            _isSystemInitialized = false;

            try
            {
                DebugLog("Initializing Vanstone System API");
                var systemApiClass = Class.ForName("com.vanstone.trans.api.SystemApi");
                
                // Find the SystemInit_Api method with signature (int, byte[], Context)
                Method systemInitMethod = null;
                try
                {
                     DebugLog("Attempting to find SystemInit_Api(int, byte[], Context)...");
                     systemInitMethod = systemApiClass.GetMethod("SystemInit_Api", new Class[] { 
                         Java.Lang.Integer.Type, // Use Integer.Type for primitive int
                         Class.ForName("[B"), // Use "[B" for byte[]
                         Class.FromType(typeof(Android.Content.Context))
                     });
                     DebugLog("Found SystemInit_Api(int, byte[], Context) method signature.");
                }
                catch(NoSuchMethodException ex)
                {
                    DebugLog($"Could not find SystemInit_Api(int, byte[], Context): {ex.Message}");
                    // Optional: Could try the other overload with ISdkStatue here if needed
                    throw; // Re-throw if the primary method isn't found
                }

                if (systemInitMethod != null)
                {
                    // Prepare arguments: argc=0, argr=empty byte array
                    int argc = 0;
                    byte[] argr = new byte[0]; // Use empty array instead of null
                    
                    // Removed manual JNI conversion - Reflection should handle byte[] marshalling
                    // IntPtr native_argr = JNIEnv.NewArray(argr); 
                    // if (native_argr == IntPtr.Zero) { ... }

                    Java.Lang.Object[] args = new Java.Lang.Object[] { 
                        new Java.Lang.Integer(argc),
                        argr, // Pass the C# byte[] directly
                        _context 
                    };
                    // JNIEnv.DeleteLocalRef(native_argr); // Removed cleanup

                    DebugLog("Calling SystemInit_Api(0, byte[0], context) via reflection...");
                    var result = (int)systemInitMethod.Invoke(null, args); // Pass args array
                    
                    DebugLog($"SystemInit_Api result: {result}");
                    
                    if (result == 0) // 0 means success in the SDK
                    {
                        _isSystemInitialized = true;
                        DebugLog("Vanstone System initialized successfully.");
                    }
                    else
                    {
                        DebugLog($"Failed to initialize Vanstone System, error code: {result}");
                    }
                }
                else
                {
                    // This case should ideally not be reached due to the throw in catch block
                    DebugLog("Critical error: SystemInit_Api method was null after check.");
                }
            }
            catch (System.Exception ex) // Catch System.Exception
            {
                 DebugLog($"Error initializing Vanstone System: {ex.Message}{System.Environment.NewLine}Stack Trace: {ex.StackTrace}");
                 // Ensure flag remains false on any exception
                 _isSystemInitialized = false;
                 // Optionally re-throw or handle differently depending on desired app behavior
            }
        }
        
        private void InitializeApiEngine()
        {
            try
            {
                // Initialize the Vanstone SDK API engine using reflection
                DebugLog("Initializing Vanstone SDK API engine");
                var engineType = Class.ForName("com.vanstone.appsdk.api.engine.SdkApiEngine");
                var instanceMethod = engineType.GetMethod("getInstance");
                _apiEngine = instanceMethod.Invoke(null, new Java.Lang.Object[0]);
                
                // Initialize the SDK with the Android context
                var initMethod = engineType.GetMethod("initAPIs", new Class[] { Class.FromType(typeof(Context)) });
                var result = (bool)initMethod.Invoke(_apiEngine, new Java.Lang.Object[] { _context });
                
                if (result)
                {
                    DebugLog("Vanstone SDK API engine initialized successfully");
                }
                else
                {
                    DebugLog("Failed to initialize Vanstone SDK API engine");
                }
            }
            catch (System.Exception ex)
            {
                DebugLog($"Error initializing Vanstone SDK API engine: {ex.Message}");
                if (ex.InnerException != null)
                {
                    DebugLog($"Inner exception: {ex.InnerException.Message}");
                }
            }
        }

        public Task<string> StartScanAsync()
        {
            // Check if already scanning
            if (_isScanning)
            {
                DebugLog("Scan already in progress.");
                // Return a completed task with empty string or throw?
                // Let's return empty for now, consistent with previous logic.
                return Task.FromResult(string.Empty); 
            }
            
            // Check if system is initialized
            if (!_isSystemInitialized)
            {
                DebugLog("System not initialized. Cannot start scan.");
                // Attempt re-initialization or fail fast
                // InitializeVanstoneSystem(); // Option: Try again? Might be risky if it failed badly before.
                // if (!_isSystemInitialized) 
                // { ... }
                return Task.FromException<string>(new InvalidOperationException("Vanstone System is not initialized."));
            }
            
            _isScanning = true;
            _scanCompletionSource = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
            DebugLog("Starting Vanstone QR code scan...");

            // Use BeginInvokeOnMainThread if the SDK requires UI thread interaction, 
            // but often SDK init calls like this are okay on background threads.
            // For safety, let's wrap the SDK call itself.
            MainThread.BeginInvokeOnMainThread(() => 
            {
                try
                {
                    // --- Vanstone ScanApi Call --- 
                    DebugLog("Preparing ScanApi call on main thread.");
                    var scanApiClass = Class.ForName("com.vanstone.trans.api.ScanApi");

                    // Define the parameter types for ScanOpen_Api
                    // It expects Bundle and com.vanstone.appsdk.api.interfaces.IScanResult or maybe Java.Util.IObserver
                    // **Let's prioritize the IScanResult callback since the class implements it.**

                    Method scanOpenMethod = null;
                    Java.Lang.Object callbackObject = null; // Will hold 'this' or a specific callback instance

                    try
                    {
                        // Attempt 1: Find method ScanOpen_Api(Bundle, IScanResult)
                        DebugLog("Attempting to find ScanOpen_Api(Bundle, IScanResult)...");
                        var scanResultInterface = Class.ForName("com.vanstone.appsdk.api.interfaces.IScanResult"); // Check this namespace
                        scanOpenMethod = scanApiClass.GetMethod("ScanOpen_Api", new Class[] {
                            Class.FromType(typeof(Android.OS.Bundle)),
                            scanResultInterface
                        });
                        // Instantiate our callback class
                        callbackObject = new VanstoneScanCallback(_scanCompletionSource);
                        DebugLog("Found ScanOpen_Api(Bundle, IScanResult). Using VanstoneScanCallback instance.");
                    }
                    catch (System.Exception ex) when (ex is NoSuchMethodException || ex is Java.Lang.ClassNotFoundException)
                    {
                        DebugLog($"Could not find ScanOpen_Api(Bundle, IScanResult) method: {ex.Message}");
                        throw new InvalidOperationException("Required ScanOpen_Api(Bundle, IScanResult) method not found via reflection.", ex);
                    }

                    if (scanOpenMethod == null)
                    {
                        throw new InvalidOperationException("Could not find suitable ScanOpen_Api method via reflection (checked IScanResult variant).");
                    }

                    // Create Bundle with parameters
                    var bundle = new Android.OS.Bundle();
                    bundle.PutString("scan_layout_title", "Scan Parcel QR"); // Title for scan UI
                    bundle.PutString("scan_layout_escbtn_text", "Cancel"); // Cancel button text
                    bundle.PutBoolean("scan_buzzer", true); // Beep on scan
                    bundle.PutBoolean("scan_vibrate", true); // Vibrate on scan
                    // Optional parameters - uncomment and adjust if needed
                    // bundle.PutBoolean("scan_flash", false); // Flashlight
                    // bundle.PutInt("scan_timeouts", 30000); // Scan timeout in ms (e.g., 30 seconds) - Handle timeout via StartScanTimeout instead?
                    // Set mode (e.g., QR only) - Check SDK constants from binding or previous inspection
                    // bundle.PutInt("scan_barcode_mode", 2); // BDL_SCAN_CODE_ONLY_QRCODE = 2 (from previous inspection)

                    DebugLog("Calling ScanOpen_Api...");

                    // Invoke the method: ScanOpen_Api(bundle, callback) -> returns int
                    // Important: Invoke takes 'null' as first arg for static methods
                    var result = (int)scanOpenMethod.Invoke(null, new Java.Lang.Object[] { bundle, callbackObject });

                    DebugLog($"ScanOpen_Api invocation result code: {result}");

                    if (result != 0) // 0 usually means success in these SDKs
                    {
                        // Map common error codes if possible (consult SDK docs)
                        string errorMessage = $"Failed to open Vanstone scanner, SDK error code: {result}";
                        DebugLog(errorMessage);
                        throw new System.Exception(errorMessage); // Qualify Exception
                    }

                    // Scanner opened successfully, start the timeout mechanism
                    DebugLog("Scan opened successfully. Starting timeout timer.");
                    StartScanTimeout(60); // Start a 60-second timeout watcher

                }
                catch (System.Exception ex) // Qualify Exception
                {
                    DebugLog($"Error initiating scan via SDK: {ex.Message}{System.Environment.NewLine}Stack Trace: {ex.StackTrace}"); // Use System.Environment
                    _isScanning = false;
                    // Set exception on the TaskCompletionSource so the caller knows it failed
                    _scanCompletionSource?.TrySetException(ex);
                }
            });

            // Return the task that will complete when the scan result is received (or times out)
            return _scanCompletionSource.Task;
        }

        private void StartScanTimeout(int timeoutSeconds)
        {
            Task.Run(async () =>
            {
                await Task.Delay(timeoutSeconds * 1000);
                
                // Check if scan is still ongoing and task hasn't completed yet
                if (_isScanning && _scanCompletionSource != null && !_scanCompletionSource.Task.IsCompleted)
                {
                    DebugLog($"Scan operation timed out after {timeoutSeconds} seconds.");
                     MainThread.BeginInvokeOnMainThread(() => 
                     {
                         _scanCompletionSource?.TrySetResult(string.Empty); // Complete with empty result on timeout
                         _isScanning = false;
                         // Optionally try to close the scanner explicitly on timeout
                         // StopScan(); 
                     });
                }
            });
        }

        public void StopScan()
        {
            if (!_isScanning && (_scanCompletionSource == null || _scanCompletionSource.Task.IsCompleted))
            {
                 DebugLog("StopScan called but not currently scanning or task already completed.");
                return; // Not scanning or already finished
            }
            
            DebugLog("Attempting to stop QR code scan...");
            
            try
            {
                // Try to close the scanner using the ScanApi via reflection
                var scanApiClass = Class.ForName("com.vanstone.trans.api.ScanApi");
                var scanCloseMethod = scanApiClass.GetMethod("ScanClose_Api"); // Assuming no parameters
                
                if (scanCloseMethod != null)
                {
                     DebugLog("Calling ScanClose_Api...");
                    var result = (int)scanCloseMethod.Invoke(null, new Java.Lang.Object[0]);
                    DebugLog($"ScanClose_Api result: {result}");
                }
                else
                {
                    DebugLog("Could not find ScanClose_Api method via reflection.");
                }
            }
            catch (System.Exception ex)
            {
                DebugLog($"Error trying to close Vanstone scanner via SDK: {ex.Message}");
            }
            finally
            {
                // Ensure scanning state is reset and task is completed (if pending)
                 MainThread.BeginInvokeOnMainThread(() => 
                 {
                     if (_scanCompletionSource != null && !_scanCompletionSource.Task.IsCompleted)
                     {
                         DebugLog("Completing scan task with empty result due to StopScan call.");
                         _scanCompletionSource.TrySetResult(string.Empty); // Complete with empty if stopped manually
                     }
                     _isScanning = false;
                 });
            }
        }

        private void DebugLog(string message)
        {
            if (_enableDebugLogging)
            {
                System.Diagnostics.Debug.WriteLine($"[{TAG}] {message}");
            }
        }

        private PosDeviceType DetermineDeviceType()
        {
            // Try to determine the device type based on manufacturer or model
            var manufacturer = Android.OS.Build.Manufacturer?.ToLowerInvariant() ?? "";
            var model = Android.OS.Build.Model?.ToLowerInvariant() ?? "";
            
            if (manufacturer.Contains("vanstone") || model.Contains("a90"))
            {
                return PosDeviceType.A90;
            }
            
            // Default to CS30
            return PosDeviceType.CS30;
        }
    }

    public class VanstoneScanCallback : Java.Lang.Object, Com.Vanstone.Appsdk.Api.Interfaces.IScanResult
    {
        private readonly TaskCompletionSource<string> _tcs;
        private static readonly string TAG = "VanstoneScanCallback";
        
        public VanstoneScanCallback(TaskCompletionSource<string> tcs)
        {
            _tcs = tcs ?? throw new ArgumentNullException(nameof(tcs));
        }
        
        // Method called on successful scan
        public void OnScanSuccessed(string? scanCode)
        {
            System.Diagnostics.Debug.WriteLine($"[{TAG}] Scan Success: {scanCode}");
            // Complete the TaskCompletionSource on the main thread
            MainThread.BeginInvokeOnMainThread(() => 
            {
                 _tcs?.TrySetResult(scanCode ?? string.Empty);
            });
        }

        // Method called on scan failure
        public void OnScanFailed(int errorCode, string? errorMessage)
        {
            System.Diagnostics.Debug.WriteLine($"[{TAG}] Scan Failed: Code={errorCode}, Message={errorMessage}");
            // Complete the TaskCompletionSource with an empty string to indicate failure
            MainThread.BeginInvokeOnMainThread(() => 
            {
                 // Consider setting an exception instead? For now, return empty.
                 _tcs?.TrySetResult(string.Empty); 
                 // Alternatively:
                 // _tcs?.TrySetException(new Exception($"Scan failed. Code: {errorCode}, Message: {errorMessage}"));
            });
        }

        // Method called if a custom button on the scan UI is clicked (if any)
        public void OnButtonClick(string? buttonId)
        {
            System.Diagnostics.Debug.WriteLine($"[{TAG}] Scan Button Clicked: {buttonId}");
            // Typically, you might cancel the scan here or handle custom actions.
            // For now, let's treat it as a cancellation/failure.
            MainThread.BeginInvokeOnMainThread(() => 
            {
                 _tcs?.TrySetResult(string.Empty); 
            });
        }

        // Required by IInterface implementation (part of IScanResult inheritance)
        public IBinder? AsBinder() => null; // Can return null if not used across processes
        
        // Dispose method (good practice for Java.Lang.Object)
        protected override void Dispose(bool disposing)
        {
            // Clean up resources if needed
            base.Dispose(disposing);
        }
    }

    public class ScanResultCallback : BroadcastReceiver
    {
        private readonly Action<string> _resultCallback;
        
        public ScanResultCallback(Action<string> resultCallback)
        {
            _resultCallback = resultCallback;
        }
        
        public override void OnReceive(Context context, Intent intent)
        {
            try
            {
                // Check if the intent has the expected action
                string action = intent.Action;
                System.Diagnostics.Debug.WriteLine($"[ScanResultCallback] Received action: {action}");
                
                // Check if the intent contains scan data
                if (intent.HasExtra("SCAN_RESULT"))
                {
                    string scanResult = intent.GetStringExtra("SCAN_RESULT");
                    System.Diagnostics.Debug.WriteLine($"[ScanResultCallback] Scan result: {scanResult}");
                    _resultCallback?.Invoke(scanResult);
                }
                else if (intent.HasExtra("EXTRA_SCAN_DATA"))
                {
                    string scanData = intent.GetStringExtra("EXTRA_SCAN_DATA");
                    System.Diagnostics.Debug.WriteLine($"[ScanResultCallback] Scan data: {scanData}");
                    _resultCallback?.Invoke(scanData);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("[ScanResultCallback] Intent has no scan result data");
                    _resultCallback?.Invoke(string.Empty);
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ScanResultCallback] Error in OnReceive: {ex.Message}");
                _resultCallback?.Invoke(string.Empty);
            }
        }
    }
}
