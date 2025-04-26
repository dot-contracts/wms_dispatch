using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using wms_android.Interfaces;
using wms_android.Models;

namespace wms_android.ViewModels
{
    [QueryProperty(nameof(ScannerService), "ScannerService")]
    [QueryProperty(nameof(ParcelService), "ParcelService")]
    [QueryProperty(nameof(PosApiHelper), "PosApiHelper")]
    [QueryProperty(nameof(VehicleService), "VehicleService")]
    [QueryProperty(nameof(CurrentVehicle), "CurrentVehicle")]
    [QueryProperty(nameof(CurrentDriver), "CurrentDriver")]
    public partial class QRScanViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string scanStatus = "Ready to scan";

        [ObservableProperty]
        private string scannedValue = string.Empty;

        [ObservableProperty]
        private bool hasValidScan = false;

        public IQRScannerService ScannerService { get; set; }
        public object ParcelService { get; set; }
        public object PosApiHelper { get; set; }
        public object VehicleService { get; set; }
        public VehicleInfo CurrentVehicle { get; set; }
        public DriverInfo CurrentDriver { get; set; }

        // Constructor
        public QRScanViewModel()
        {
        }

        [RelayCommand]
        private async Task StartScan()
        {
            if (ScannerService == null)
            {
                ScanStatus = "Scanner service not available";
                return;
            }

            try
            {
                IsBusy = true;
                ScanStatus = "Scanning...";

                // Call the scanner service to get the QR code
                var result = await ScannerService.ScanQRCodeAsync();

                if (string.IsNullOrEmpty(result))
                {
                    ScanStatus = "Failed to scan. Please try again.";
                    HasValidScan = false;
                }
                else
                {
                    ScannedValue = result;
                    ScanStatus = "Scan successful!";
                    HasValidScan = true;
                }
            }
            catch (Exception ex)
            {
                ScanStatus = $"Error: {ex.Message}";
                HasValidScan = false;
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task Accept()
        {
            if (!HasValidScan)
            {
                await Shell.Current.DisplayAlert("Error", "No valid scan to accept", "OK");
                return;
            }

            // Here you would handle the scanned QR code,
            // e.g., pass it back to the calling page or process it directly
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        private async Task Cancel()
        {
            // Close this page and return to the previous one
            await Shell.Current.GoToAsync("..");
        }
    }
} 