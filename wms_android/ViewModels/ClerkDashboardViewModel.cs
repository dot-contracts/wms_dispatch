using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using wms_android.Models;
using wms_android.Services.Interfaces;
using wms_android.Utils;
using wms_android.Views;

namespace wms_android.ViewModels
{
    public partial class ClerkDashboardViewModel : BaseViewModel
    {
        [RelayCommand]
        private async Task ExecuteDeliverCommand()
        {
            IsBusy = true;
            try
            {
                var scannerService = ServiceHelper.GetService<IQRScannerService>();
                if (scannerService == null)
                {
                    await Shell.Current.DisplayAlert("Error", "QR Scanner service is not available.", "OK");
                    return;
                }

                // Temporarily create empty vehicle and driver for testing
                var vehicle = new VehicleInfo(); // Assuming default constructor is sufficient or create as needed
                var driver = new DriverInfo(); // Assuming default constructor is sufficient or create as needed

                // Navigate to QRScanView, passing necessary services and data
                // ParcelService and PosApiHelper are set to null as they are not immediately required for scanning
                var navigationParameters = new Dictionary<string, object>
                {
                    { "ScannerService", scannerService },
                    { "ParcelService", null }, // To be resolved later
                    { "PosApiHelper", null },  // To be resolved later
                    { "VehicleService", null }, // Not needed for scanning initiation
                    { "CurrentVehicle", vehicle },
                    { "CurrentDriver", driver }
                };

                await Shell.Current.GoToAsync(nameof(QRScanView), true, navigationParameters);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to navigate to QR Scan View.");
                await Shell.Current.DisplayAlert("Navigation Error", $"Failed to go to QR Scan page: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
