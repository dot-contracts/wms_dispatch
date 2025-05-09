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
using System.Collections.ObjectModel; // Added for ObservableCollection
using System.Linq; // Added for LINQ methods like Sum

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
        private List<Parcel> _parcelsToDeliverList;

        [ObservableProperty]
        private ObservableCollection<Parcel> _displayParcels = new();

        [ObservableProperty]
        private bool _isMultiParcelMode;
        
        [ObservableProperty]
        private bool _isBusy;
        
        [ObservableProperty]
        private string _statusMessage = "Ready to confirm delivery.";
        
        // Properties derived from ParcelToDeliver for easier binding (optional but can be helpful)
        public string WaybillNumber => IsMultiParcelMode ? DisplayParcels.FirstOrDefault()?.WaybillNumber ?? "N/A" : ParcelToDeliver?.WaybillNumber ?? "N/A";
        public decimal TotalAmount => IsMultiParcelMode ? DisplayParcels.Sum(p => p.TotalAmount) : ParcelToDeliver?.TotalAmount ?? 0;
        private Parcel FirstDisplayParcel => IsMultiParcelMode ? DisplayParcels.FirstOrDefault() : ParcelToDeliver;
        public string PaymentMethod => FirstDisplayParcel?.PaymentMethods ?? "N/A";
        public DateTime CreatedAt => FirstDisplayParcel?.CreatedAt ?? DateTime.MinValue;
        public string Sender => FirstDisplayParcel?.Sender ?? "N/A";
        public string Receiver => FirstDisplayParcel?.Receiver ?? "N/A";
        public string Destination => FirstDisplayParcel?.Destination ?? "N/A";
        public decimal Rate => FirstDisplayParcel?.Rate ?? 0;
        public int Quantity => IsMultiParcelMode ? DisplayParcels.Sum(p => p.Quantity) : FirstDisplayParcel?.Quantity ?? 0;
        public string Description => FirstDisplayParcel?.Description ?? "N/A";
        public decimal Amount => IsMultiParcelMode ? DisplayParcels.Sum(p => p.Amount ?? 0) : FirstDisplayParcel?.Amount ?? 0;

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
            DisplayParcels.Clear(); // Clear previous display items
            IsMultiParcelMode = false;

            if (query.TryGetValue("ParcelsToDeliver", out object parcelsListObject) && parcelsListObject is List<Parcel> parcelsList)
            {
                Debug.WriteLine($"Received List of {parcelsList.Count} Parcels.");
                ParcelsToDeliverList = parcelsList;
                IsMultiParcelMode = true;
                foreach (var p in parcelsList)
                {
                    DisplayParcels.Add(p);
                }
                // ParcelToDeliver can be null or set to the first for convenience if needed by other logic, though DisplayParcels is primary now
                ParcelToDeliver = parcelsList.FirstOrDefault(); 
            }
            else if (query.TryGetValue("ParcelToDeliver", out object parcelObject) && parcelObject is Parcel parcel)
            {
                Debug.WriteLine($"Received Single Parcel Waybill: {parcel.WaybillNumber}");
                ParcelToDeliver = parcel; 
                IsMultiParcelMode = false;
                DisplayParcels.Add(parcel);
                ParcelsToDeliverList = null; // Clear list if we are in single mode
            }
            else
            {
                Debug.WriteLine("ApplyQueryAttributes did not find valid Parcel data.");
                ParcelToDeliver = null;
                ParcelsToDeliverList = null;
                // Handle error? Maybe show an alert or navigate back?
            }

            // Manually notify that all relevant properties have changed
            OnPropertyChanged(nameof(ParcelToDeliver));
            OnPropertyChanged(nameof(ParcelsToDeliverList));
            OnPropertyChanged(nameof(DisplayParcels));
            OnPropertyChanged(nameof(IsMultiParcelMode));
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

        [RelayCommand]
        private async Task ConfirmDeliveryAndPrintAsync()
        {
            if (IsBusy || !DisplayParcels.Any())
            {
                await _dialogService.ShowAlertAsync("Error", "No parcel data available to confirm.");
                return;
            }

            IsBusy = true;
            StatusMessage = "Processing delivery confirmation...";
            
            List<string> successfulDispatches = new List<string>();
            List<string> failedDispatches = new List<string>();
            List<string> successfulPrints = new List<string>();
            List<string> failedPrints = new List<string>();

            // Assuming all parcels in DisplayParcels share the same Waybill if from QR scan
            // For printing, some details like Waybill number might be common.
            // The current print logic is per-parcel, so we will loop and print for each.

            foreach (var parcel in DisplayParcels)
            {
                StatusMessage = $"Processing parcel: {parcel.WaybillNumber} / {parcel.Description?.Substring(0, Math.Min(parcel.Description.Length, 10))}...";
                bool currentParcelPrintSuccess = false;
                bool currentParcelDispatchSuccess = false;

                try
                {
                    Debug.WriteLine($"Starting delivery confirmation for Parcel ID: {parcel.Id}, Waybill: {parcel.WaybillNumber}");
                    
                    // Ensure printer is ready before each print attempt (if not globally initialized)
                    PrinterInitializationService.Initialize();
                    
                    // --- Start Printing Logic for 'parcel' ---
                    PrinterApi.PrnClrBuff_Api();
                    PrinterApi.PrnSetGray_Api(10); 
                    PrinterApi.PrnFontSet_Api(24, 24, 0); 
                    
                    PrinterApi.PrintSetAlign_Api(1); 
                    PrinterApi.PrnFontSet_Api(24, 24, 0x33); 
                    PrinterApi.PrnStr_Api("Ficma Home Logistics\n");
                    PrinterApi.PrnFontSet_Api(24, 24, 0); 
                    PrinterApi.PrnStr_Api("0707136852\n");
                    PrinterApi.PrnStr_Api("ficmahomelogistics19@gmail.com\n");
                    PrinterApi.PrnFontSet_Api(24, 24, 0x33); 
                    PrinterApi.PrnStr_Api("*** DELIVERY RECEIPT ***\n"); 
                    
                    PrinterApi.PrintSetAlign_Api(0); 
                    PrinterApi.PrnFontSet_Api(24, 24, 0); 
                    PrinterApi.PrnStr_Api($"Waybill Number: {parcel.WaybillNumber}\n");
                    PrinterApi.PrnStr_Api($"Delivered At: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n"); 
                    PrinterApi.PrnStr_Api("\n");
                    
                    PrinterApi.PrnStr_Api($"Item: {parcel.Description}\n");
                    PrinterApi.PrnStr_Api($"From: {parcel.Sender}\n");
                    PrinterApi.PrnStr_Api($"To: {parcel.Receiver}\n");
                    PrinterApi.PrnStr_Api($"Destination: {parcel.Destination}\n"); 
                    PrinterApi.PrnStr_Api($"Rate: {parcel.Rate}\n"); 
                    PrinterApi.PrnStr_Api($"Quantity: {parcel.Quantity}\n");
                    PrinterApi.PrnStr_Api($"Amount: Ksh {parcel.Amount:N2}\n"); 
                    
                    PrinterApi.PrnStr_Api("\n");
                    PrinterApi.PrnStr_Api($"Payment Method: {parcel.PaymentMethods}\n");
                    PrinterApi.PrnStr_Api($"Total Amount Paid: Ksh {parcel.TotalAmount:N2}\n"); 
                    
                    PrinterApi.PrnStr_Api("--------------------------------\n");
                    
                    PrinterApi.PrintSetAlign_Api(1); 
                    try
                    {
                        Debug.WriteLine($"Printing QR code for {parcel.WaybillNumber} with BtPrinterApi.PrnQrcode_Api");
                        BtPrinterApi.PrnQrcode_Api(parcel.WaybillNumber); // Use parcel's specific Waybill for QR
                    }
                    catch (Exception qrEx)
                    {
                        Debug.WriteLine($"QR code error: {qrEx.Message}. Printing Waybill as text.");
                        PrinterApi.PrnFontSet_Api(24, 24, 0); 
                        PrinterApi.PrnStr_Api($"Waybill: {parcel.WaybillNumber}\n"); 
                    }
                    
                    PrinterApi.PrintSetAlign_Api(0); 
                    PrinterApi.PrnFontSet_Api(24, 24, 0); 
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

                    PrinterApi.PrnStep_Api(100); 
                    // --- End Printing Logic for 'parcel' ---

                    int printResult = PrinterApi.PrnStart_Api();
                    Debug.WriteLine($"PrinterApi.PrnStart_Api result for {parcel.WaybillNumber}: {printResult}");

                    if (printResult == 0) 
                    {
                        Debug.WriteLine($"Delivery confirmation receipt printed successfully for {parcel.WaybillNumber}.");
                        currentParcelPrintSuccess = true;
                        successfulPrints.Add(parcel.WaybillNumber ?? parcel.Id.ToString());

                        try
                        {
                            Debug.WriteLine($"Attempting to dispatch parcel ID: {parcel.Id}, Waybill: {parcel.WaybillNumber}");
                            await _parcelService.DispatchParcelAsync(parcel); // Dispatch this specific parcel
                            Debug.WriteLine($"Parcel {parcel.WaybillNumber} dispatched successfully via ParcelService.");
                            currentParcelDispatchSuccess = true;
                            successfulDispatches.Add(parcel.WaybillNumber ?? parcel.Id.ToString());
                        }
                        catch (Exception dispatchEx)
                        {
                            Debug.WriteLine($"Error dispatching parcel {parcel.WaybillNumber} after print: {dispatchEx.Message}");
                            failedDispatches.Add($"{parcel.WaybillNumber ?? parcel.Id.ToString()} (Dispatch Error: {dispatchEx.Message})");
                        }
                    }
                    else
                    {
                        Debug.WriteLine($"Error starting print job for {parcel.WaybillNumber}. Code: {printResult}");
                        failedPrints.Add($"{parcel.WaybillNumber ?? parcel.Id.ToString()} (Print Error Code: {printResult})");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error during processing parcel {parcel.WaybillNumber}: {ex.Message}");
                    failedPrints.Add($"{parcel.WaybillNumber ?? parcel.Id.ToString()} (Overall Error: {ex.Message})");
                    // We might also assume dispatch failed if an overall error occurred before dispatch attempt
                    if (!currentParcelDispatchSuccess) // Avoid double-adding if dispatch specific error already caught
                    {
                         failedDispatches.Add($"{parcel.WaybillNumber ?? parcel.Id.ToString()} (Overall Error before dispatch)");
                    }
                }
            } // End foreach parcel

            IsBusy = false;
            StatusMessage = "Confirmation process finished.";

            // Summarize results
            int totalParcelsProcessed = DisplayParcels.Count;
            string summaryMessage = $"Processed {totalParcelsProcessed} parcel(s).\n" +
                                  $"Successfully Printed: {successfulPrints.Count}/{totalParcelsProcessed}\n" +
                                  $"Successfully Dispatched: {successfulDispatches.Count}/{totalParcelsProcessed}\n";

            if (failedPrints.Any())
            {
                summaryMessage += "\nPrint Failures: " + string.Join(", ", failedPrints);
            }
            if (failedDispatches.Any())
            {
                summaryMessage += "\nDispatch Failures: " + string.Join(", ", failedDispatches);
            }

            if (successfulPrints.Count == totalParcelsProcessed && successfulDispatches.Count == totalParcelsProcessed)
            {
                await _dialogService.ShowAlertAsync("Success", "All parcels delivered and receipts printed successfully!");
                await Shell.Current.GoToAsync("//ClerkDashboardView"); 
            }
            else if (successfulPrints.Any() || successfulDispatches.Any()) // Partial success
            {
                 await _dialogService.ShowAlertAsync("Partial Success", summaryMessage);
                 // Decide where to navigate or if to stay
                 // For now, let's go back to dashboard as some action was taken.
                 await Shell.Current.GoToAsync("//ClerkDashboardView"); 
            }
            else // Complete failure for all
            {
                 await _dialogService.ShowAlertAsync("Process Failed", summaryMessage);
                 // Stay on page
            }
        }
    }
} 