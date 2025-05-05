using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.shared.Models;
using wms_android.shared.Interfaces;
using System.Collections.ObjectModel;
using wms_android.Interfaces;
using wms_android.Utils;
using wms_android.Services;
using Com.Vanstone.Trans.Api;

namespace wms_android.ViewModels
{
    public class ReceiptViewModel : INotifyPropertyChanged
    {
        private readonly IParcelService _parcelService;
        private IPosApiHelper _posApiHelper;
        private bool _isA90Device; // Flag to indicate if we're using A90 device
        
        private ObservableCollection<Parcel> _parcels = new();
        public ObservableCollection<Parcel> Parcels
        {
            get => _parcels;
            set
            {
                if (_parcels != value)
                {
                    _parcels = value;
                    OnPropertyChanged(nameof(Parcels));
                    OnPropertyChanged(nameof(IsCartMode));
                    OnPropertyChanged(nameof(IsSingleParcelMode));
                }
            }
        }

        public ObservableCollection<string> PaymentMethods { get; set; } = new();

        private string _waybillNumber;
        public string WaybillNumber
        {
            get => _waybillNumber;
            set
            {
                if (_waybillNumber != value)
                {
                    _waybillNumber = value;
                    OnPropertyChanged(nameof(WaybillNumber));
                }
            }
        }

        private decimal _totalAmount;
        public decimal TotalAmount
        {
            get => _totalAmount;
            set
            {
                if (_totalAmount != value)
                {
                    _totalAmount = value;
                    OnPropertyChanged(nameof(TotalAmount));
                }
            }
        }

        private string _paymentMethod;
        public string PaymentMethod
        {
            get => _paymentMethod;
            set
            {
                if (_paymentMethod != value)
                {
                    _paymentMethod = value;
                    OnPropertyChanged(nameof(PaymentMethod));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Parcel _parcel;
        public Parcel Parcel
        {
            get => _parcel;
            set
            {
                if (_parcel != value)
                {
                    _parcel = value;
                    OnPropertyChanged(nameof(Parcel));
                    OnPropertyChanged(nameof(IsSingleParcelMode));
                    OnPropertyChanged(nameof(IsCartMode));
                    
                    // Update properties from the Parcel
                    if (value != null)
                    {
                        // Set the waybill number from the parcel
                        if (!string.IsNullOrEmpty(value.WaybillNumber))
                        {
                            WaybillNumber = value.WaybillNumber;
                        }
                        
                        // Set the total amount from the parcel's TotalAmount field
                        TotalAmount = value.TotalAmount;
                        
                        // Set the payment method from the parcel
                        if (!string.IsNullOrEmpty(value.PaymentMethods))
                        {
                            PaymentMethod = value.PaymentMethods;
                        }
                    }
                }
            }
        }

        public bool IsSingleParcelMode => Parcel != null;
        public bool IsCartMode => Parcels != null && Parcels.Count > 0;
        public DateTime CurrentDate => DateTime.Now;

        public ICommand PrintReceiptCommand { get; }
        public ICommand PrintCartReceiptCommand { get; }

        // Constructor for single parcel receipt
        public ReceiptViewModel(IParcelService parcelService)
        {
            _parcelService = parcelService;
            PrintReceiptCommand = new Command(async () => await PrintReceipt());
            PrintCartReceiptCommand = new Command(async () => await PrintCartReceipt());
            
            // Initialize collections
            Parcels = new ObservableCollection<Parcel>();
            
            // Initialize PaymentMethods
            PaymentMethods.Add("Cash");
            PaymentMethods.Add("Mobile Money");
            PaymentMethods.Add("Credit Card");

            // Detect the device model to determine which printer SDK to use
            string deviceModel = Android.OS.Build.Model;
            _isA90Device = deviceModel.Contains("A90") || deviceModel.Contains("Vanstone");
            Debug.WriteLine($"Device detected: {deviceModel}, Using A90 SDK: {_isA90Device}");

            // Get printer helper from initialization service
            _posApiHelper = PrinterInitializationService.GetPrinterHelper();
            
            // Make sure printer is initialized
            if (!PrinterInitializationService.IsInitialized)
            {
                Debug.WriteLine("Warning: Printer was not initialized at app startup. Initializing now...");
                PrinterInitializationService.Initialize();
            }
        }
        
        // Constructor for cart receipt (multiple parcels)
        public ReceiptViewModel(IParcelService parcelService, ObservableCollection<Parcel> parcels, string waybillNumber, decimal totalAmount, ObservableCollection<string> paymentMethods) : this(parcelService)
        {
            Parcels = parcels;
            WaybillNumber = waybillNumber;
            TotalAmount = totalAmount;
            PaymentMethods = paymentMethods;
            PaymentMethod = paymentMethods?.FirstOrDefault() ?? "Cash"; // Default to first payment method or "Cash"
            
            // Explicitly trigger mode property notifications
            OnPropertyChanged(nameof(IsCartMode));
            OnPropertyChanged(nameof(IsSingleParcelMode));
        }
        
        // Constructor overload for cart receipt that calculates the total amount
        public ReceiptViewModel(IParcelService parcelService, ObservableCollection<Parcel> parcels, string waybillNumber) : this(parcelService)
        {
            Parcels = parcels;
            WaybillNumber = waybillNumber;
            
            // Calculate the total amount from parcels
            decimal calculatedTotal = 0;
            foreach (var parcel in parcels)
            {
                calculatedTotal += parcel.Amount ?? 0;
            }
            
            // Set the total amount
            TotalAmount = calculatedTotal;
            
            // Also ensure each parcel has the total amount set
            foreach (var parcel in parcels)
            {
                parcel.TotalAmount = calculatedTotal;
            }
            
            // Set default payment methods
            var defaultPaymentMethods = new ObservableCollection<string> { "Cash", "Mobile Money", "Credit Card" };
            PaymentMethods = defaultPaymentMethods;
            PaymentMethod = "Cash";
            
            // Debug the values
            Debug.WriteLine($"ReceiptViewModel created with waybill: {waybillNumber}, totalAmount: {TotalAmount}");
            
            // Explicitly trigger mode property notifications
            OnPropertyChanged(nameof(IsCartMode));
            OnPropertyChanged(nameof(IsSingleParcelMode));
        }

        private void InitializePrinter()
        {
            // This method is kept for backward compatibility but is now empty
            // since initialization is handled by PrinterInitializationService
            Debug.WriteLine("ReceiptViewModel.InitializePrinter: Using pre-initialized printer");
        }

        private async Task PrintReceipt()
        {
            try
            {
                Debug.WriteLine("Starting to print receipt");
                
                // Ensure printer is ready before printing
                PrinterInitializationService.Initialize();
                
                // Clear buffer first for consistent printing
                PrinterApi.PrnClrBuff_Api();
                
                // Set darker print (gray level 10) for better visibility
                PrinterApi.PrnSetGray_Api(10);
                
                // Use larger font (24x24) consistently for all content
                PrinterApi.PrnFontSet_Api(24, 24, 0);
                
                // ===== HEADER (CENTER ALIGNED) =====
                PrinterApi.PrintSetAlign_Api(1); // Center alignment
                
                // Company name - bold
                PrinterApi.PrnFontSet_Api(24, 24, 0x33); // Bold
                PrinterApi.PrnStr_Api("Ficma Home Logistics\n");
                
                // Contact info - normal
                PrinterApi.PrnFontSet_Api(24, 24, 0);
                PrinterApi.PrnStr_Api("0707136852\n");
                PrinterApi.PrnStr_Api("ficmahomelogistics19@gmail.com\n");
                
                // Receipt title - bold
                PrinterApi.PrnFontSet_Api(24, 24, 0x33);
                PrinterApi.PrnStr_Api("WAYBILL RECEIPT\n");
                
                // ===== RECEIPT DETAILS (LEFT ALIGNED) =====
                PrinterApi.PrintSetAlign_Api(0); // Left alignment
                PrinterApi.PrnFontSet_Api(24, 24, 0); // Normal
                
                // Date and waybill
                PrinterApi.PrnStr_Api($"Waybill Number: {WaybillNumber}\n");
                PrinterApi.PrnStr_Api($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\n");
                PrinterApi.PrnStr_Api("\n");
                
                // ===== PARCEL DETAILS =====
                PrinterApi.PrnStr_Api($"Item: {Parcel.Description}\n");
                PrinterApi.PrnStr_Api($"From: {Parcel.Sender}\n");
                PrinterApi.PrnStr_Api($"To: {Parcel.Receiver}\n");
                PrinterApi.PrnStr_Api($"Destination: {Parcel.Destination}\n");
                PrinterApi.PrnStr_Api($"Rate: {Parcel.Rate}\n");
                PrinterApi.PrnStr_Api($"Quantity: {Parcel.Quantity}\n");
                PrinterApi.PrnStr_Api($"Amount: Ksh {Parcel.Amount:N2}\n");
                
                // ===== TOTALS =====
                PrinterApi.PrnStr_Api("\n");
                PrinterApi.PrnStr_Api($"Payment Method: {PaymentMethod}\n");
                PrinterApi.PrnStr_Api($"Total Amount: Ksh {TotalAmount:N2}\n");
                
                // Separator
                PrinterApi.PrnStr_Api("--------------------------------\n");
                
                // ===== QR CODE (CENTER ALIGNED) =====
                PrinterApi.PrintSetAlign_Api(1); // Center alignment
                
                // Print QR code - using direct BtPrinterApi method for better results
                try
                {
                    Debug.WriteLine("Printing QR code with BtPrinterApi.PrnQrcode_Api");
                    BtPrinterApi.PrnQrcode_Api(WaybillNumber);
                }
                catch (Exception qrEx)
                {
                    Debug.WriteLine($"QR code error: {qrEx.Message}. Trying fallback method.");
                    try 
                    {
                        // Fallback to regular QR code method
                        _posApiHelper.PrintQrCode_Cut(WaybillNumber, 300, 300, "QR_CODE");
                    }
                    catch (Exception fallbackEx)
                    {
                        Debug.WriteLine($"Fallback QR code method also failed: {fallbackEx.Message}");
                        // Print waybill as text so it's still scannable
                        PrinterApi.PrnStr_Api($"Waybill: {WaybillNumber}\n");
                    }
                }
                
                // ===== DISCLAIMER =====
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

                // Add extra space
                PrinterApi.PrnStep_Api(100);
                
                // Start the actual print job
                int printResult = PrinterApi.PrnStart_Api();
                Debug.WriteLine($"PrinterApi.PrnStart_Api result: {printResult}");

                if (printResult == 0) // 0 indicates success
                {
                    Debug.WriteLine("Receipt printing initiated successfully.");

                await Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");

                    // Optionally navigate back after success
                    // await Shell.Current.GoToAsync(".."); 
                }
                else
                {
                    // Handle print failure
                    Debug.WriteLine($"Error starting print job. Code: {printResult}");
                    // Inform the user about the printing failure
                    await Application.Current.MainPage.DisplayAlert("Print Error", $"Failed to print receipt. Error code: {printResult}", "OK");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during PrintReceipt method: {ex.Message}");
                // Handle general errors during the process
                await Application.Current.MainPage.DisplayAlert("Error", $"An unexpected error occurred: {ex.Message}", "OK");
            }
        }

        // Method for printing cart receipts
        private async Task PrintCartReceipt()
        {
            try
            {
                Debug.WriteLine("Starting to print cart receipt");
                
                // Ensure printer is ready before printing
                PrinterInitializationService.Initialize();
                
                // Clear buffer first for consistent printing
                PrinterApi.PrnClrBuff_Api();
                
                // Set darker print (gray level 10) for better visibility
                PrinterApi.PrnSetGray_Api(10);
                
                // Use larger font (24x24) consistently for all content
                PrinterApi.PrnFontSet_Api(24, 24, 0);
                
                // ===== HEADER (CENTER ALIGNED) =====
                PrinterApi.PrintSetAlign_Api(1); // Center alignment
                
                // Company name - bold
                PrinterApi.PrnFontSet_Api(24, 24, 0x33); // Bold
                PrinterApi.PrnStr_Api("Ficma Home Logistics\n");
                
                // Contact info - normal
                PrinterApi.PrnFontSet_Api(24, 24, 0);
                PrinterApi.PrnStr_Api("0707136852\n");
                PrinterApi.PrnStr_Api("ficmahomelogistics19@gmail.com\n");
                
                // Receipt title - bold
                PrinterApi.PrnFontSet_Api(24, 24, 0x33);
                PrinterApi.PrnStr_Api("WAYBILL RECEIPT\n");
                
                // ===== RECEIPT DETAILS (LEFT ALIGNED) =====
                PrinterApi.PrintSetAlign_Api(0); // Left alignment
                PrinterApi.PrnFontSet_Api(24, 24, 0); // Normal
                
                // Date and waybill
                PrinterApi.PrnStr_Api($"Waybill Number: {WaybillNumber}\n");
                PrinterApi.PrnStr_Api($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\n");
                PrinterApi.PrnStr_Api("\n");
                
                // ===== PARCEL DETAILS =====
                PrinterApi.PrnStr_Api("Item: parcels\n");

                // Print each parcel in the cart
                foreach (var parcel in Parcels)
                {
                    PrinterApi.PrnStr_Api($"From: {parcel.Sender}\n");
                    PrinterApi.PrnStr_Api($"To: {parcel.Receiver}\n");
                    PrinterApi.PrnStr_Api($"Destination: {parcel.Destination}\n");
                    PrinterApi.PrnStr_Api($"Quantity: {parcel.Quantity}\n");
                    PrinterApi.PrnStr_Api($"Rate: Ksh {parcel.Amount:N2}\n");
                    PrinterApi.PrnStr_Api($"Amount: Ksh {parcel.Amount:N2}\n");
                }
                
                // ===== TOTALS =====
                PrinterApi.PrnStr_Api("\n");
                PrinterApi.PrnStr_Api($"Total Rate: Ksh {TotalAmount:N2}\n");
                PrinterApi.PrnStr_Api($"Total Amount: Ksh {TotalAmount:N2}\n");
                PrinterApi.PrnStr_Api($"Payment Method: {PaymentMethod}\n");
                
                // Separator
                PrinterApi.PrnStr_Api("--------------------------------\n");
                
                // ===== QR CODE (CENTER ALIGNED) =====
                PrinterApi.PrintSetAlign_Api(1); // Center alignment
                
                // Print QR code - using direct BtPrinterApi method for better results
                try
                {
                    Debug.WriteLine("Printing QR code with BtPrinterApi.PrnQrcode_Api");
                    BtPrinterApi.PrnQrcode_Api(WaybillNumber);
                }
                catch (Exception qrEx)
                {
                    Debug.WriteLine($"QR code error: {qrEx.Message}. Trying fallback method.");
                    try 
                    {
                        // Fallback to regular QR code method
                        _posApiHelper.PrintQrCode_Cut(WaybillNumber, 300, 300, "QR_CODE");
                    }
                    catch (Exception fallbackEx)
                    {
                        Debug.WriteLine($"Fallback QR code method also failed: {fallbackEx.Message}");
                        // Print waybill as text so it's still scannable
                        PrinterApi.PrnStr_Api($"Waybill: {WaybillNumber}\n");
                    }
                }
                
                // ===== DISCLAIMER =====
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

                // Add extra space
                PrinterApi.PrnStep_Api(100);
                
                // Execute actual printing
                Debug.WriteLine("Starting print job");
                int result = PrinterApi.PrnStart_Api();
                Debug.WriteLine($"Print result: {result}");
                
                // Show success alert
                await Application.Current.MainPage.DisplayAlert("Success", "Cart receipt printed successfully.", "OK");

                // Navigate back to the root view
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Cart Printing Error: {ex.Message}");
                Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to print cart receipt: {ex.Message}", "OK");
            }
        }

        private string GenerateReceiptContent()
        {
            return $"Waybill Number: {WaybillNumber}\n" +
                   $"Sender: {Parcel.Sender}\n" +
                   $"Receiver: {Parcel.Receiver}\n" +
                   $"Destination: {Parcel.Destination}\n" +
                   $"Amount: {Parcel.Amount:C}\n" +
                   $"Total Amount: {TotalAmount:C}\n" +
                   $"Payment Method: {PaymentMethod}\n" +
                   $"Dispatched At: {Parcel.DispatchedAt:g}";
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            // Handle query parameters passed during navigation
            if (query.TryGetValue("parcels", out var parcelsData) && parcelsData is ObservableCollection<Parcel> parcels)
            {
                // Cart mode
                Parcels = parcels;
                TotalAmount = parcels.Sum(p => p.Amount ?? 0);
                WaybillNumber = query.TryGetValue("waybill", out var waybillData) ? waybillData.ToString() : "N/A";
                PaymentMethods = query.TryGetValue("paymentMethods", out var paymentMethodsData) ? paymentMethodsData as ObservableCollection<string> : new ObservableCollection<string> { "Cash" };
                PaymentMethod = PaymentMethods.FirstOrDefault() ?? "Cash";
                OnPropertyChanged(nameof(IsCartMode));
                OnPropertyChanged(nameof(IsSingleParcelMode));
            }
            else if (query.TryGetValue("ParcelToDeliver", out var parcelData) && parcelData is Parcel parcel) // Handle ParcelToDeliver
            {
                 // Single parcel mode (likely from DeliveryView)
                 Parcel = parcel; // Set the main Parcel property
                 // Properties like WaybillNumber, TotalAmount, PaymentMethod should be set automatically by the Parcel property setter
            }
            else if (query.TryGetValue("parcel", out var singleParcelData) && singleParcelData is Parcel singleParcel) // Keep existing "parcel" handling for compatibility
            {
                // Legacy single parcel mode?
                Parcel = singleParcel;
            }
            else
            {
                Debug.WriteLine("ReceiptViewModel: No valid parcel data received via query attributes.");
                // Handle error or set default state if necessary
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
