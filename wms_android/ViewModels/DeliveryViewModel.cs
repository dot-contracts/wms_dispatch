using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;
using wms_android.Interfaces;   // Using the interface namespace
using System.Diagnostics;
using wms_android.shared.Interfaces;
using wms_android.Views; // Added for navigation to ReceiptView
using System.Collections.Generic; // Added for navigation parameters
using wms_android.shared.Models; // Added for Parcel type

namespace wms_android.ViewModels
{
    public partial class DeliveryViewModel : ObservableObject
    {
        // Inject the interface, not the concrete class
        private readonly IScannerService _scannerService;
        private readonly IParcelService _parcelService;

        [ObservableProperty]
        private string? _scannedResult;

        [ObservableProperty]
        private string? _statusMessage;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string? _manualWaybillNumber; // Added property

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsScannedResultVisible))] // Added Notify attribute
        private bool _showScannedResult = false; // Backing field for visibility

        // Added property to control visibility in XAML
        public bool IsScannedResultVisible => _showScannedResult && !string.IsNullOrEmpty(ScannedResult);


        public DeliveryViewModel(IScannerService scannerService, IParcelService parcelService)
        {
            _scannerService = scannerService;
            _parcelService = parcelService;
            StatusMessage = "Enter Waybill or Scan QR Code.";
        }

        [RelayCommand]
        private async Task ScanQrCodeAsync()
        {
            if (IsBusy) return;

            IsBusy = true;
            ScannedResult = null;
            ShowScannedResult = false; // Reset visibility
            StatusMessage = "Initializing scanner...";

            bool isScannerInitialized = false;
            try
            {
                isScannerInitialized = _scannerService.InitializeScanner();

                if (isScannerInitialized)
                {
                    StatusMessage = "Scanner initialized. Starting scan...";
                    Debug.WriteLine("Attempting to scan...");
                    var result = await _scannerService.ScanAsync(TimeSpan.FromSeconds(20));

                    if (!string.IsNullOrEmpty(result))
                    {
                        ScannedResult = result;
                        ShowScannedResult = true; // Show result area
                        StatusMessage = $"Scan successful: {result}. Looking up parcel...";
                        Debug.WriteLine($"Scan successful: {result}");

                        var parcel = await _parcelService.GetParcelByQRCodeAsync(ScannedResult);

                        if (parcel != null)
                        {
                            // Check if already delivered using the enum
                            if (parcel.Status == ParcelStatus.Delivered)
                            {
                                StatusMessage = $"Parcel {parcel.WaybillNumber} has already been delivered.";
                                Debug.WriteLine($"Parcel {parcel.WaybillNumber} already delivered.");
                            }
                            else
                            {
                                StatusMessage = $"Parcel {parcel.WaybillNumber} found. Navigating to confirmation...";
                                Debug.WriteLine($"Parcel {parcel.WaybillNumber} found via QR. Navigating.");
                                // Navigate to DeliveryConfirmationView, passing the parcel data
                                await GoToDeliveryConfirmationView(parcel);
                            }
                        }
                        else
                        {
                            StatusMessage = $"Failed to find parcel with QR code {ScannedResult}.";
                            Debug.WriteLine($"ParcelService couldn't find parcel with QR code {ScannedResult}.");
                        }
                    }
                    else
                    {
                        StatusMessage = "Scan timed out or failed. Please try again.";
                        ShowScannedResult = false;
                        Debug.WriteLine("Scan returned null or empty.");
                    }
                }
                else
                {
                    StatusMessage = "Failed to initialize scanner.";
                    ShowScannedResult = false;
                    Debug.WriteLine("Scanner initialization failed.");
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"An error occurred during scan: {ex.Message}";
                ShowScannedResult = false;
                Debug.WriteLine($"Error during scan command execution: {ex.Message}");
            }
            finally
            {
                if (isScannerInitialized)
                {
                     _scannerService.CloseScanner();
                     Debug.WriteLine("Scanner closed after operation.");
                }
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task LookupWaybillAsync() // Renamed to match convention
        {
            if (IsBusy || string.IsNullOrWhiteSpace(ManualWaybillNumber))
            {
                StatusMessage = "Please enter a valid Waybill Number.";
                return;
            }

            IsBusy = true;
            ScannedResult = null; // Clear any previous scan result
            ShowScannedResult = false;
            StatusMessage = $"Looking up Waybill: {ManualWaybillNumber}...";
            Debug.WriteLine($"Looking up Waybill: {ManualWaybillNumber}");

            try
            {
                var parcel = await _parcelService.GetParcelByWaybillNumberAsync(ManualWaybillNumber);

                if (parcel != null)
                {
                     // Check if already delivered using the enum
                    if (parcel.Status == ParcelStatus.Delivered)
                    {
                        StatusMessage = $"Parcel {parcel.WaybillNumber} has already been delivered.";
                        Debug.WriteLine($"Parcel {parcel.WaybillNumber} already delivered.");
                    }
                    else
                    {
                        StatusMessage = $"Parcel {parcel.WaybillNumber} found. Navigating to confirmation...";
                        Debug.WriteLine($"Parcel {parcel.WaybillNumber} found via Waybill. Navigating.");
                        // Navigate to DeliveryConfirmationView, passing the parcel data
                        await GoToDeliveryConfirmationView(parcel);
                    }
                }
                else
                {
                    StatusMessage = $"Failed to find parcel with Waybill Number {ManualWaybillNumber}.";
                    Debug.WriteLine($"ParcelService couldn't find parcel with Waybill {ManualWaybillNumber}.");
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"An error occurred during lookup: {ex.Message}";
                Debug.WriteLine($"Error during lookup command execution: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
                // Optionally clear the manual entry field after lookup?
                // ManualWaybillNumber = string.Empty;
            }
        }

        // Helper method for navigation to avoid code duplication
        private async Task GoToDeliveryConfirmationView(Parcel parcel)
        {
             // Reset status before navigating away
            StatusMessage = "Ready";
            ManualWaybillNumber = string.Empty; // Clear entry
            ScannedResult = string.Empty; // Clear scan result
            ShowScannedResult = false;

            await Shell.Current.GoToAsync($"{nameof(DeliveryConfirmationView)}", true, new Dictionary<string, object>
            {
                { "ParcelToDeliver", parcel } // Pass the parcel object
            });
        }


        public void Cleanup()
        {
             Debug.WriteLine("DeliveryViewModel cleanup called.");
             // Consider closing scanner here too if it could be left open on navigation away
             _scannerService?.CloseScanner();
        }
    }
} 