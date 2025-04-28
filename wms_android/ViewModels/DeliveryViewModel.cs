using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;
using wms_android.Interfaces;   // Using the interface namespace
using wms_android.data.Interfaces; // Add this using statement
using System.Diagnostics;

namespace wms_android.ViewModels
{
    public partial class DeliveryViewModel : ObservableObject
    {
        // Inject the interface, not the concrete class
        private readonly IScannerService _scannerService;
        private readonly IParcelService _parcelService; // Assuming you still need this

        [ObservableProperty]
        private string? _scannedResult;

        [ObservableProperty]
        private string? _statusMessage;

        [ObservableProperty]
        private bool _isBusy;

        public DeliveryViewModel(IScannerService scannerService, IParcelService parcelService)
        {
            _scannerService = scannerService;
            _parcelService = parcelService;
            StatusMessage = "Ready to scan delivery QR code.";
        }

        [RelayCommand]
        private async Task ScanQrCodeAsync()
        {
            if (IsBusy) return;

            IsBusy = true;
            ScannedResult = null;
            StatusMessage = "Initializing scanner...";

            bool isScannerInitialized = false;
            try
            {
                // Initialize scanner via the interface
                isScannerInitialized = _scannerService.InitializeScanner();

                if (isScannerInitialized)
                {
                    StatusMessage = "Scanner initialized. Starting scan...";
                    Debug.WriteLine("Attempting to scan...");

                    // Start scanning via the interface
                    var result = await _scannerService.ScanAsync(TimeSpan.FromSeconds(20));

                    if (!string.IsNullOrEmpty(result))
                    {
                        ScannedResult = result;
                        StatusMessage = $"Scan successful: {result}. Updating parcel status...";
                        Debug.WriteLine($"Scan successful: {result}");

                        // --- Add Parcel Update Logic --- 
                        try
                        {
                            // TODO: Add any validation logic for the 'result' string if needed.
                            // Example: if (!IsValidParcelIdentifier(result)) throw new Exception("Invalid QR code format.");

                            // Assuming IParcelService has a method like this:
                            // Since MarkParcelDeliveredAsync doesn't exist, use an alternative approach
                            // First get the parcel by QR code, then dispatch it (which should update its status)
                            var parcel = await _parcelService.GetParcelByQRCodeAsync(ScannedResult);
                            
                            if (parcel != null)
                            {
                                await _parcelService.DispatchParcelAsync(parcel);
                                StatusMessage = $"Parcel {ScannedResult} marked as delivered successfully.";
                                Debug.WriteLine($"Parcel {ScannedResult} updated successfully.");
                                // TODO: Trigger printing here if the update was successful.
                            }
                            else
                            {
                                StatusMessage = $"Failed to find parcel with code {ScannedResult}.";
                                Debug.WriteLine($"ParcelService couldn't find parcel with code {ScannedResult}.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle errors during parcel update (e.g., network issues, validation errors)
                            StatusMessage = $"Error updating parcel status: {ex.Message}";
                            Debug.WriteLine($"Error calling ParcelService: {ex.Message}");
                        }
                        // --- End Parcel Update Logic ---

                        // TODO: Trigger printing.

                    }
                    else
                    {
                        StatusMessage = "Scan timed out or failed. Please try again.";
                        Debug.WriteLine("Scan returned null or empty.");
                    }
                }
                else
                {
                    StatusMessage = "Failed to initialize scanner. Check device connection and permissions.";
                    Debug.WriteLine("Scanner initialization failed.");
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"An error occurred: {ex.Message}";
                Debug.WriteLine($"Error during scan command execution: {ex.Message}");
            }
            finally
            {
                if (isScannerInitialized)
                {
                     // Close scanner via the interface
                     _scannerService.CloseScanner();
                     Debug.WriteLine("Scanner closed after operation.");
                }
                IsBusy = false;
            }
        }

        public void Cleanup()
        {
             Debug.WriteLine("DeliveryViewModel cleanup called.");
        }
    }
} 