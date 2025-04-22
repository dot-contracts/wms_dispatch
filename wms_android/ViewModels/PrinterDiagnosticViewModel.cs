using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.Services;
using wms_android.Utils;
using Microsoft.Maui.Controls;

namespace wms_android.ViewModels
{
    public class PrinterDiagnosticViewModel : BaseViewModel
    {
        public event EventHandler<DiagnosticResult> DiagnosticCompleted;
        public event EventHandler<string> PrinterStatusUpdated;
        
        public ICommand PrinterDiagnosticCommand { get; }
        public ICommand PrintTestPageCommand { get; }
        public ICommand ResetPrinterCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand DirectTestCommand { get; }
        
        private DiagnosticResult _lastResult;
        
        public PrinterDiagnosticViewModel()
        {
            Title = "Printer Diagnostics";
            
            PrinterDiagnosticCommand = new Command(async () => await RunDiagnostic());
            PrintTestPageCommand = new Command(async () => await PrintTestPage());
            ResetPrinterCommand = new Command(async () => await ResetPrinter());
            BackCommand = new Command(async () => await GoBack());
            DirectTestCommand = new Command(async () => await RunDirectTest());
            
            // Update printer status when view model is created
            UpdatePrinterStatus();
        }
        
        private async Task RunDiagnostic()
        {
            if (IsBusy)
                return;
                
            IsBusy = true;
            
            try
            {
                Android.Util.Log.Debug("PrinterDiagnostic", "Starting diagnostic test...");
                OnPrinterStatusUpdated("Running diagnostic test...");
                
                // First, check the .so files are properly extracted
                await CheckNativeLibraries();
                
                // Ensure printer is initialized first
                if (!PrinterInitializationService.IsInitialized)
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", "Printer not initialized, initializing...");
                    PrinterInitializationService.Initialize();
                    await Task.Delay(2000); // Give time for initialization
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Initialization result: {PrinterInitializationService.IsInitialized}");
                    
                    // Check for Vanstone classes
                    try
                    {
                        bool sdkFound = false;
                        bool printerApiFound = false;
                        bool printerHandlerFound = false;
                        
                        try
                        {
                            var engineType = Java.Lang.Class.ForName("com.vanstone.appsdk.api.engine.SdkApiEngine");
                            if (engineType != null)
                            {
                                sdkFound = true;
                                Android.Util.Log.Debug("PrinterDiagnostic", "SdkApiEngine class found");
                            }
                        }
                        catch (Exception ex)
                        {
                            Android.Util.Log.Debug("PrinterDiagnostic", $"SdkApiEngine class not found: {ex.Message}");
                        }
                        
                        try
                        {
                            var printerApi = Java.Lang.Class.ForName("com.vanstone.trans.api.PrinterApi");
                            if (printerApi != null)
                            {
                                printerApiFound = true;
                                Android.Util.Log.Debug("PrinterDiagnostic", "PrinterApi class found");
                            }
                        }
                        catch (Exception ex)
                        {
                            Android.Util.Log.Debug("PrinterDiagnostic", $"PrinterApi class not found: {ex.Message}");
                        }
                        
                        try
                        {
                            var printerHandler = Java.Lang.Class.ForName("com.vanstone.appsdk.api.printer.PrinterHandler");
                            if (printerHandler != null)
                            {
                                printerHandlerFound = true;
                                Android.Util.Log.Debug("PrinterDiagnostic", "PrinterHandler class found");
                            }
                        }
                        catch (Exception ex)
                        {
                            Android.Util.Log.Debug("PrinterDiagnostic", $"PrinterHandler class not found: {ex.Message}");
                        }
                        
                        OnPrinterStatusUpdated($"SDK classes: SDK={sdkFound}, API={printerApiFound}, Handler={printerHandlerFound}");
                    }
                    catch (Exception ex)
                    {
                        Android.Util.Log.Debug("PrinterDiagnostic", $"Error checking SDK classes: {ex.Message}");
                    }
                }
                
                _lastResult = await PrinterDiagnostics.RunDiagnosticTest();
                Android.Util.Log.Debug("PrinterDiagnostic", $"Diagnostic complete: {_lastResult}");
                OnDiagnosticCompleted(_lastResult);
                
                if (_lastResult.Success)
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", "Diagnostic successful");
                    OnPrinterStatusUpdated("Diagnostic completed successfully. Printer is working properly.");
                }
                else
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Diagnostic failed: {_lastResult.ErrorMessage}");
                    OnPrinterStatusUpdated($"Diagnostic failed: {_lastResult.ErrorMessage}");
                    
                    // Add more detailed error info
                    if (_lastResult.ErrorMessage.Contains("Failed to initialize printer"))
                    {
                        await CheckDevicePermissions();
                    }
                }
            }
            catch (Exception ex)
            {
                Android.Util.Log.Debug("PrinterDiagnostic", $"Error in diagnostic: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error in diagnostic: {ex.Message}");
                OnPrinterStatusUpdated($"Error: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }
        
        private async Task CheckNativeLibraries()
        {
            try
            {
                Android.Util.Log.Debug("PrinterDiagnostic", "Checking native libraries...");
                var context = Android.App.Application.Context;
                
                // Check if the native library exists in the application's native library directory
                var libraryPath = $"{context.ApplicationInfo.NativeLibraryDir}/libA90JavahCore.so";
                var libraryFile = new Java.IO.File(libraryPath);
                
                if (!libraryFile.Exists())
                {
                    Android.Util.Log.Error("PrinterDiagnostic", $"Native library not found at {libraryPath}");
                    OnPrinterStatusUpdated($"Native library not found: {libraryPath}");
                    
                    // Try to extract the native library from assets
                    try
                    {
                        string sourceAssetPath = "Platforms/Android/libs/armeabi-v7a/libA90JavahCore.so";
                        Android.Util.Log.Debug("PrinterDiagnostic", $"Attempting to extract native library from assets: {sourceAssetPath}");
                        
                        // Try to copy library from assets to native lib directory
                        var assetManager = context.Assets;
                        using (var inputStream = assetManager.Open(sourceAssetPath))
                        using (var outputStream = new Java.IO.FileOutputStream(libraryPath))
                        {
                            byte[] buffer = new byte[8192];
                            int read;
                            while ((read = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                outputStream.Write(buffer, 0, read);
                            }
                            outputStream.Flush();
                        }
                        
                        Android.Util.Log.Debug("PrinterDiagnostic", "Native library extracted successfully");
                        OnPrinterStatusUpdated("Native library installed. Please restart the app.");
                    }
                    catch (Exception ex)
                    {
                        Android.Util.Log.Error("PrinterDiagnostic", $"Failed to extract native library: {ex.Message}");
                        OnPrinterStatusUpdated($"Failed to extract native library: {ex.Message}");
                    }
                }
                else
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Native library found: {libraryPath}");
                }
                
                // Check for Vanstone Service APK
                try
                {
                    var packageInfo = context.PackageManager.GetPackageInfo("com.vanstone.printer", 0);
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Vanstone printer service found: {packageInfo.PackageName} v{packageInfo.VersionName}");
                    OnPrinterStatusUpdated($"Vanstone service found: {packageInfo.PackageName} v{packageInfo.VersionName}");
                }
                catch (Exception ex)
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Vanstone printer service not found, this may be needed for A90 devices");
                    OnPrinterStatusUpdated("Vanstone service not installed. Contact support for APK installation.");
                }
            }
            catch (Exception ex)
            {
                Android.Util.Log.Error("PrinterDiagnostic", $"Error checking native libraries: {ex.Message}");
                OnPrinterStatusUpdated($"Error checking native libraries: {ex.Message}");
            }
        }
        
        private async Task CheckDevicePermissions()
        {
            try
            {
                Android.Util.Log.Debug("PrinterDiagnostic", "Checking device permissions");
                var context = Android.App.Application.Context;
                
                // Check if printer service is available
                try
                {
                    var packageInfo = context.PackageManager.GetPackageInfo("com.vanstone.printer", 0);
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Printer service found: {packageInfo.PackageName}, version: {packageInfo.VersionName}");
                    OnPrinterStatusUpdated($"Printer service found: {packageInfo.PackageName}, version: {packageInfo.VersionName}");
                }
                catch (Exception ex)
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Printer service not found: {ex.Message}");
                    OnPrinterStatusUpdated("Printer service not found on device. This may indicate missing software.");
                }
                
                // Try to connect to printer service explicitly
                try
                {
                    var intent = new Android.Content.Intent();
                    intent.SetAction("com.vanstone.printer.service");
                    intent.SetPackage("com.vanstone.printer");
                    
                    var serviceConnection = new Services.PrinterServiceConnection();
                    bool serviceConnected = context.BindService(intent, serviceConnection, Android.Content.Bind.AutoCreate);
                    
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Printer service bind result: {serviceConnected}");
                    OnPrinterStatusUpdated($"Printer service bind: {serviceConnected}");
                }
                catch (Exception ex)
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", $"Error binding to printer service: {ex.Message}");
                    OnPrinterStatusUpdated($"Error binding to printer service: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Android.Util.Log.Debug("PrinterDiagnostic", $"Error checking permissions: {ex.Message}");
                OnPrinterStatusUpdated($"Error checking permissions: {ex.Message}");
            }
        }
        
        private async Task PrintTestPage()
        {
            if (IsBusy)
                return;
                
            IsBusy = true;
            
            try
            {
                OnPrinterStatusUpdated("Printing test page...");
                
                bool success = await PrinterDiagnostics.PrintTestPage();
                
                if (success)
                {
                    OnPrinterStatusUpdated("Test page printed successfully.");
                    await ShowAlert("Success", "Test page printed successfully.", "OK");
                }
                else
                {
                    OnPrinterStatusUpdated("Failed to print test page.");
                    await ShowAlert("Error", "Failed to print test page.", "OK");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error printing test page: {ex.Message}");
                OnPrinterStatusUpdated($"Error: {ex.Message}");
                await ShowAlert("Error", $"Error printing test page: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        
        private async Task ResetPrinter()
        {
            if (IsBusy)
                return;
                
            IsBusy = true;
            
            try
            {
                OnPrinterStatusUpdated("Resetting printer...");
                
                bool success = PrinterDiagnostics.ResetPrinter();
                
                if (success)
                {
                    OnPrinterStatusUpdated("Printer reset successfully.");
                    await ShowAlert("Success", "Printer reset successfully.", "OK");
                }
                else
                {
                    OnPrinterStatusUpdated("Failed to reset printer.");
                    await ShowAlert("Error", "Failed to reset printer.", "OK");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error resetting printer: {ex.Message}");
                OnPrinterStatusUpdated($"Error: {ex.Message}");
                await ShowAlert("Error", $"Error resetting printer: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        
        private async Task GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
        
        private void UpdatePrinterStatus()
        {
            try
            {
                string status = PrinterInitializationService.GetPrinterStatus();
                OnPrinterStatusUpdated(status);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating printer status: {ex.Message}");
                OnPrinterStatusUpdated($"Error: {ex.Message}");
            }
        }
        
        private async Task ShowAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }
        
        private void OnDiagnosticCompleted(DiagnosticResult result)
        {
            DiagnosticCompleted?.Invoke(this, result);
        }
        
        private void OnPrinterStatusUpdated(string status)
        {
            PrinterStatusUpdated?.Invoke(this, status);
        }
        
        private async Task RunDirectTest()
        {
            if (IsBusy)
                return;
                
            IsBusy = true;
            
            try
            {
                Android.Util.Log.Debug("PrinterDiagnostic", "Starting direct test (sample project style)...");
                OnPrinterStatusUpdated("Running direct test (sample project style)...");
                
                var result = PrinterInitializationService.TestDirectPrinting();
                
                if (result)
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", "Direct test successful!");
                    OnPrinterStatusUpdated("Direct test successfully printed test page!");
                }
                else
                {
                    Android.Util.Log.Debug("PrinterDiagnostic", "Direct test failed.");
                    OnPrinterStatusUpdated("Direct test failed. See logs for details.");
                }
            }
            catch (Exception ex)
            {
                Android.Util.Log.Debug("PrinterDiagnostic", $"Error in direct test: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error in direct test: {ex.Message}");
                OnPrinterStatusUpdated($"Error in direct test: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
} 