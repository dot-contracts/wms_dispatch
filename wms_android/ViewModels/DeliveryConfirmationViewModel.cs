using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using wms_android.shared.Interfaces;
using wms_android.shared.Models;
using wms_android.Interfaces;
using wms_android.Services;
using Com.Vanstone.Trans.Api; // Assuming Vanstone printer API namespace
using Microsoft.Maui.Controls; // Needed for IQueryAttributable

namespace wms_android.ViewModels
{
    // REMOVED [QueryProperty] attribute
    public partial class DeliveryConfirmationViewModel : ObservableObject, IQueryAttributable // IMPLEMENT IQueryAttributable
    {
        private readonly IParcelService _parcelService;
        private readonly IDialogService _dialogService; // For showing messages
        // Removed IPosApiHelper and _isA90Device, using static PrinterInitializationService

        [ObservableProperty]
        private Parcel _parcelToDeliver;

        [ObservableProperty]
        private bool _isBusy;
        
        [ObservableProperty]
        private string _statusMessage = "Ready to confirm delivery.";
        
        // Properties derived from ParcelToDeliver for easier binding (optional but can be helpful)
        public string WaybillNumber => ParcelToDeliver?.WaybillNumber ?? "N/A";
        public decimal TotalAmount => ParcelToDeliver?.TotalAmount ?? 0;
        public string PaymentMethod => ParcelToDeliver?.PaymentMethods ?? "N/A";
        public DateTime CreatedAt => ParcelToDeliver?.CreatedAt ?? DateTime.MinValue;
        public string Sender => ParcelToDeliver?.Sender ?? "N/A";
        public string Receiver => ParcelToDeliver?.Receiver ?? "N/A";
        public string Destination => ParcelToDeliver?.Destination ?? "N/A";
        public decimal Rate => ParcelToDeliver?.Rate ?? 0;
        public int Quantity => ParcelToDeliver?.Quantity ?? 0;
        public string Description => ParcelToDeliver?.Description ?? "N/A";
        public decimal Amount => ParcelToDeliver?.Amount ?? 0;

        public DeliveryConfirmationViewModel(IParcelService parcelService, IDialogService dialogService)
        {
            _parcelService = parcelService;
            _dialogService = dialogService;

            // Check printer initialization (might move to command execution)
             if (!PrinterInitializationService.IsInitialized)
             {
                 Debug.WriteLine("Warning: Printer was not initialized at app startup. Initializing now...");
                 PrinterInitializationService.Initialize(); // Consider initializing only when needed
             }
        }

        // REMOVED OnParcelToDeliverChanged partial method

        // IMPLEMENT ApplyQueryAttributes
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Debug.WriteLine("--- DeliveryConfirmationViewModel: ApplyQueryAttributes Called ---");
            if (query.TryGetValue("ParcelToDeliver", out object parcelObject) && parcelObject is Parcel parcel)
            {
                Debug.WriteLine($"Received Parcel Waybill: {parcel.WaybillNumber}, Sender: {parcel.Sender}, Receiver: {parcel.Receiver}, Amount: {parcel.TotalAmount}");
                ParcelToDeliver = parcel; // Set the property

                // Manually notify that derived properties have changed because ParcelToDeliver changed
                OnPropertyChanged(nameof(WaybillNumber));
                OnPropertyChanged(nameof(TotalAmount));
                OnPropertyChanged(nameof(PaymentMethod));
                OnPropertyChanged(nameof(CreatedAt));
                OnPropertyChanged(nameof(Sender));
                OnPropertyChanged(nameof(Receiver));
                OnPropertyChanged(nameof(Destination));
                OnPropertyChanged(nameof(Rate));
                OnPropertyChanged(nameof(Quantity));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(Amount));
            }
            else
            {
                Debug.WriteLine("ApplyQueryAttributes did not find a valid Parcel object with key 'ParcelToDeliver'.");
                // Handle error? Maybe show an alert or navigate back?
            }
        }

        [RelayCommand]
        private async Task ConfirmDeliveryAndPrintAsync()
        {
            if (IsBusy || ParcelToDeliver == null)
            {
                await _dialogService.ShowAlertAsync("Error", "No parcel data available to confirm.");
                return;
            }

            IsBusy = true;
            StatusMessage = "Printing receipt and confirming delivery...";
            bool printSuccess = false;
            bool dispatchSuccess = false;

            try
            {
                Debug.WriteLine($"Starting delivery confirmation for Waybill: {ParcelToDeliver.WaybillNumber}");
                
                // Ensure printer is ready before printing
                PrinterInitializationService.Initialize();
                
                // --- Start Printing Logic (Matched to ReceiptViewModel) ---
                PrinterApi.PrnClrBuff_Api();
                PrinterApi.PrnSetGray_Api(10); // Darker print
                PrinterApi.PrnFontSet_Api(24, 24, 0); // Normal font size
                
                // 1. Header
                PrinterApi.PrintSetAlign_Api(1); // Center
                PrinterApi.PrnFontSet_Api(24, 24, 0x33); // Bold
                PrinterApi.PrnStr_Api("Ficma Home Logistics\n");
                PrinterApi.PrnFontSet_Api(24, 24, 0); // Normal
                PrinterApi.PrnStr_Api("0707136852\n");
                PrinterApi.PrnStr_Api("ficmahomelogistics19@gmail.com\n");
                PrinterApi.PrnFontSet_Api(24, 24, 0x33); // Bold
                PrinterApi.PrnStr_Api("*** DELIVERY RECEIPT ***\n"); // DELIVERY Title
                
                // 2. Receipt Details (LEFT ALIGNED)
                PrinterApi.PrintSetAlign_Api(0); // Left
                PrinterApi.PrnFontSet_Api(24, 24, 0); // Normal
                PrinterApi.PrnStr_Api($"Waybill Number: {WaybillNumber}\n");
                PrinterApi.PrnStr_Api($"Delivered At: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n"); // Delivery time
                PrinterApi.PrnStr_Api("\n");
                
                // 3. Parcel Details
                // Use derived properties from ViewModel for consistency
                PrinterApi.PrnStr_Api($"Item: {Description}\n");
                PrinterApi.PrnStr_Api($"From: {Sender}\n");
                PrinterApi.PrnStr_Api($"To: {Receiver}\n");
                PrinterApi.PrnStr_Api($"Destination: {Destination}\n"); 
                PrinterApi.PrnStr_Api($"Rate: {Rate}\n"); 
                PrinterApi.PrnStr_Api($"Quantity: {Quantity}\n");
                PrinterApi.PrnStr_Api($"Amount: Ksh {Amount:N2}\n"); // Use Amount here as per original receipt
                
                // 4. Totals
                PrinterApi.PrnStr_Api("\n");
                PrinterApi.PrnStr_Api($"Payment Method: {PaymentMethod}\n");
                PrinterApi.PrnStr_Api($"Total Amount Paid: Ksh {TotalAmount:N2}\n"); // Use TotalAmount here
                
                // 5. Separator
                PrinterApi.PrnStr_Api("--------------------------------\n");
                
                // 6. QR Code (CENTER ALIGNED)
                PrinterApi.PrintSetAlign_Api(1); // Center alignment
                try
                {
                    Debug.WriteLine("Printing QR code with BtPrinterApi.PrnQrcode_Api");
                    BtPrinterApi.PrnQrcode_Api(WaybillNumber);
                }
                catch (Exception qrEx)
                {
                    Debug.WriteLine($"QR code error: {qrEx.Message}. Printing Waybill as text.");
                    // Fallback: Print waybill as text if QR fails
                    PrinterApi.PrnFontSet_Api(24, 24, 0); // Ensure normal font
                    PrinterApi.PrnStr_Api($"Waybill: {WaybillNumber}\n"); 
                }
                
                // 7. Disclaimer (Optional for delivery? Keeping it for consistency for now)
                PrinterApi.PrintSetAlign_Api(0); // Left alignment
                PrinterApi.PrnFontSet_Api(24, 24, 0); // Normal font
                PrinterApi.PrnStr_Api("\nNB:\n");
                PrinterApi.PrnStr_Api("1. Contents not checked.\n");
                PrinterApi.PrnStr_Api("2. Customers are advised to insu\n");
                PrinterApi.PrnStr_Api("   re their goods if the value exce\n");
                PrinterApi.PrnStr_Api("   eds Ksh 500.\n");
                PrinterApi.PrnStr_Api("3. All mirrors/boards are carrie\n");
                PrinterApi.PrnStr_Api("   d at owner's risk.\n");
                PrinterApi.PrnStr_Api("4. Cash is not accepted as a cou\n");
                PrinterApi.PrnStr_Api("   rier, and the company will not b\n");
                PrinterApi.PrnStr_Api("   e held liable.\n");

                // 8. Paper Feed
                PrinterApi.PrnStep_Api(100); // Feed paper
                // --- End Printing Logic ---

                // Start the print job
                int printResult = PrinterApi.PrnStart_Api();
                Debug.WriteLine($"PrinterApi.PrnStart_Api result: {printResult}");

                if (printResult == 0) // Success
                {
                    Debug.WriteLine("Delivery confirmation receipt printed successfully.");
                    printSuccess = true;

                    // --- Dispatch Parcel (Mark as Delivered) --- 
                    try
                    {
                        Debug.WriteLine($"Attempting to dispatch parcel ID: {ParcelToDeliver.Id}, Waybill: {ParcelToDeliver.WaybillNumber}");
                        await _parcelService.DispatchParcelAsync(ParcelToDeliver);
                        Debug.WriteLine($"Parcel {ParcelToDeliver.WaybillNumber} dispatched successfully via ParcelService.");
                        dispatchSuccess = true;
                    }
                    catch (Exception dispatchEx)
                    {
                        Debug.WriteLine($"Error dispatching parcel after print: {dispatchEx.Message}");
                        // Will show combined error message later
                    }
                }
                else
                {
                    Debug.WriteLine($"Error starting print job. Code: {printResult}");
                    // Will show print error message later
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during ConfirmDeliveryAndPrint: {ex.Message}");
                 await _dialogService.ShowAlertAsync("Error", $"An unexpected error occurred during confirmation: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
                StatusMessage = "Confirmation process finished.";

                // Show appropriate final message and navigate
                if (printSuccess && dispatchSuccess)
                {
                    await _dialogService.ShowAlertAsync("Success", "Parcel delivered and receipt printed successfully!");
                    // Navigate back to dashboard or delivery list?
                    await Shell.Current.GoToAsync("//ClerkDashboardView"); // Go back to root dashboard
                }
                else if (printSuccess && !dispatchSuccess)
                {
                     await _dialogService.ShowAlertAsync("Partial Success", "Receipt printed, but failed to update parcel delivery status online. Please sync later or contact support.");
                     // Stay on page? Or navigate back?
                     // await Shell.Current.GoToAsync(".."); 
                }
                else // Print failed
                {
                     await _dialogService.ShowAlertAsync("Print Error", "Failed to print delivery confirmation receipt. Please check the printer.");
                     // Stay on page
                }
            }
        }
    }
} 