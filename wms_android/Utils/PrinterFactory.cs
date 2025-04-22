using System;
using System.Diagnostics;
using wms_android.Interfaces;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace wms_android.Utils
{
    /// <summary>
    /// Factory class for getting the appropriate printer implementation based on device model
    /// </summary>
    public static class PrinterFactory
    {
        private const string TAG = "PrinterFactory";

        /// <summary>
        /// Returns a printer implementation appropriate for the current device
        /// </summary>
        public static IPosApiHelper GetPrinterImplementation()
        {
            string deviceModel = Android.OS.Build.Model;
            System.Diagnostics.Debug.WriteLine($"{TAG}: Detecting printer implementation for device: {deviceModel}");

            // Check if it's an A90 device (Vanstone)
            if (deviceModel.Contains("A90") || deviceModel.Contains("Vanstone"))
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Detected A90/Vanstone device, using VanstonePosApiHelper");
                return VanstonePosApiHelper.Instance;
            }
            // Check if it's a CS30 device
            else if (deviceModel.Contains("CS30") || deviceModel.Contains("Android"))
            {
                System.Diagnostics.Debug.WriteLine($"{TAG}: Detected CS30 device, using CS30PosApiHelper");
                return CS30PosApiHelper.Instance;
            }
            else
            {
                // Default to Vanstone implementation for unknown devices
                System.Diagnostics.Debug.WriteLine($"{TAG}: Unknown device model, defaulting to VanstonePosApiHelper");
                return VanstonePosApiHelper.Instance;
            }
        }

        /// <summary>
        /// Check if the current device supports printing
        /// </summary>
        public static bool DeviceSupportsPrinting()
        {
            string deviceModel = Android.OS.Build.Model;
            
            // Check for known printer-capable devices
            return deviceModel.Contains("A90") || 
                   deviceModel.Contains("Vanstone") || 
                   deviceModel.Contains("CS30") ||
                   deviceModel.Contains("POS");
        }
        
        /// <summary>
        /// Returns the device model name
        /// </summary>
        public static string GetDeviceModel()
        {
            return Android.OS.Build.Model;
        }
        
        /// <summary>
        /// Check if the current device is an A90 model
        /// </summary>
        public static bool IsA90Device()
        {
            string deviceModel = Android.OS.Build.Model;
            return deviceModel.Contains("A90") || deviceModel.Contains("Vanstone");
        }
        
        /// <summary>
        /// Check if the current device is a CS30 model
        /// </summary>
        public static bool IsCS30Device()
        {
            string deviceModel = Android.OS.Build.Model;
            return deviceModel.Contains("CS30");
        }
    }
} 