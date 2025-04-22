using Android.App;
using Android.Content.PM;
using Android.OS;
using wms_android.Services;
using System.Threading.Tasks;
using Java.Lang;
using Android.Util;
using System;

namespace wms_android
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        private const string TAG = "PrinterDirectTest";
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Run printer test in the background to avoid blocking UI
            Task.Run(async () => {
                try
                {
                    // Wait a moment for the app to fully initialize
                    await Task.Delay(2000);
                    
                    // Try to directly access Vanstone SdkApiEngine using reflection
                    Log.Debug(TAG, "Starting printer initialization sequence");
                    
                    // First check if JAR classes are available
                    bool sdkEngineAvailable = IsClassAvailable("com.vanstone.appsdk.api.engine.SdkApiEngine");
                    bool printerApiAvailable = IsClassAvailable("com.vanstone.trans.api.PrinterApi");
                    bool printerHandlerAvailable = IsClassAvailable("com.vanstone.appsdk.api.printer.PrinterHandler");
                    
                    Log.Debug(TAG, $"SDK Classes availability: SdkEngine={sdkEngineAvailable}, PrinterApi={printerApiAvailable}, PrinterHandler={printerHandlerAvailable}");
                    
                    if (!sdkEngineAvailable || !printerApiAvailable)
                    {
                        Log.Error(TAG, "CRITICAL ERROR: Missing required SDK classes. Make sure JAR files are properly included in the project.");
                        return;
                    }
                    
                    // Attempt to ensure the system is ready for printer initialization
                    try 
                    {
                        // Force class loading
                        Class.ForName("com.vanstone.trans.api.PrinterApi");
                        Class.ForName("com.vanstone.appsdk.api.printer.PrinterHandler");
                        Log.Debug(TAG, "PrinterApi and PrinterHandler classes loaded successfully");
                    }
                    catch (System.Exception ex)
                    {
                        Log.Error(TAG, $"Error loading printer classes: {ex.Message}");
                    }
                    
                    // Wait a moment for classes to load
                    await Task.Delay(500);
                    
                    // Attempt direct SDK initialization with reflection
                    try
                    {
                        var engineType = Class.ForName("com.vanstone.appsdk.api.engine.SdkApiEngine");
                        Log.Debug(TAG, "SdkApiEngine class found");
                        
                        var instanceMethod = engineType.GetMethod("getInstance");
                        var apiEngine = instanceMethod.Invoke(null, new Java.Lang.Object[0]);
                        Log.Debug(TAG, "SdkApiEngine instance obtained");
                        
                        // Initialize the APIs
                        var initMethod = engineType.GetMethod("initAPIs", new Class[] { 
                            Class.FromType(typeof(Android.Content.Context)) 
                        });
                        var result = (bool)initMethod.Invoke(apiEngine, new Java.Lang.Object[] { this });
                        Log.Debug(TAG, $"SDK initialization result: {result}");
                        
                        if (result)
                        {
                            // Get the printer handler
                            var getPrinterMethod = engineType.GetMethod("getPrinterHandler");
                            var printer = getPrinterMethod.Invoke(apiEngine, new Java.Lang.Object[0]);
                            
                            if (printer != null)
                            {
                                Log.Debug(TAG, "Printer handler obtained");
                                
                                // Set the handler in PrinterApi
                                try
                                {
                                    var printerField = Class.ForName("com.vanstone.trans.api.PrinterApi")
                                                             .GetDeclaredField("mPrinter");
                                    printerField.Accessible = true;
                                    printerField.Set(null, printer);
                                    Log.Debug(TAG, "Successfully set PrinterHandler in PrinterApi field");
                                }
                                catch (System.Exception ex)
                                {
                                    Log.Error(TAG, $"Error setting printer handler: {ex.Message}");
                                }
                                
                                // Check if printer is available
                                var printerClass = printer.Class;
                                var checkMethod = printerClass.GetMethod("checkPrinter");
                                var checkResult = (int)checkMethod.Invoke(printer, new Java.Lang.Object[0]);
                                Log.Debug(TAG, $"Printer check result: {checkResult}");
                            }
                            else
                            {
                                Log.Error(TAG, "Failed to get printer handler from SDK");
                            }
                        }
                        else
                        {
                            Log.Error(TAG, "SDK initialization failed");
                        }
                    }
                    catch (System.Exception ex) 
                    {
                        Log.Error(TAG, $"Error in SDK initialization: {ex.Message}");
                        Log.Error(TAG, $"Stack trace: {ex.StackTrace}");
                    }
                    
                    // Wait a bit more before trying the service initialization
                    await Task.Delay(1000);
                    
                    // Continue with printer initialization through service, regardless of previous result
                    Log.Debug(TAG, "Now trying regular printer initialization service");
                    
                    // Reset the printer service state in case this is a restart of the app
                    PrinterInitializationService.ResetPrinter();
                    
                    // Initialize printer through the service
                    PrinterInitializationService.Initialize();
                    Log.Debug(TAG, $"PrinterInitializationService result: {PrinterInitializationService.IsInitialized}");
                    Log.Debug(TAG, $"Printer status: {PrinterInitializationService.GetPrinterStatus()}");
                }
                catch (System.Exception ex)
                {
                    Log.Error(TAG, $"Critical error in printer test: {ex.Message}");
                    Log.Error(TAG, $"Stack trace: {ex.StackTrace}");
                }
            });
        }
        
        // Helper method to check if a class is available
        private bool IsClassAvailable(string className)
        {
            try
            {
                var cls = Class.ForName(className);
                return cls != null;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
