using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using wms_android.data.Models;
using wms_android.data.Interfaces;
using wms_android.Interfaces;
using wms_android.Utils;
using wms_android.Services;
using Com.Vanstone.Trans.Api;

namespace wms_android.ViewModels
{
    public class ReceiptCartViewModel : BaseViewModel
    {
        private readonly IParcelService _parcelService;
        private IPosApiHelper _posApiHelper;
        
        public ObservableCollection<Parcel> Parcels { get; set; } = new();
        public ObservableCollection<string> PaymentMethods { get; set; } = new();

        private string _waybillNumber;
        public string WaybillNumber
        {
            get => _waybillNumber;
            set => SetProperty(ref _waybillNumber, value);
        }

        private decimal _totalAmount;
        public decimal TotalAmount
        {
            get => _totalAmount;
            set => SetProperty(ref _totalAmount, value);
        }

        private string _paymentMethod;
        public string PaymentMethod
        {
            get => _paymentMethod;
            set => SetProperty(ref _paymentMethod, value);
        }

        public ICommand PrintCartReceiptCommand { get; }

        public ReceiptCartViewModel(IParcelService parcelService)
        {
            _parcelService = parcelService;
            PrintCartReceiptCommand = new Command(async () => await PrintCartReceipt());
            
            // Get printer helper from initialization service
            _posApiHelper = PrinterInitializationService.GetPrinterHelper();
            
            // Make sure printer is initialized
            if (!PrinterInitializationService.IsInitialized)
            {
                Debug.WriteLine("Warning: Printer was not initialized at app startup. Initializing now...");
                PrinterInitializationService.Initialize();
            }
            
            // Initialize PaymentMethods
            PaymentMethods.Add("Cash");
            PaymentMethods.Add("Mobile Money");
            PaymentMethods.Add("Credit Card");
        }

        public ReceiptCartViewModel(
            IParcelService parcelService, 
            ObservableCollection<Parcel> parcels, 
            string waybillNumber, 
            decimal totalAmount, 
            ObservableCollection<string> paymentMethods)
        {
            _parcelService = parcelService;
            Parcels = parcels;
            WaybillNumber = waybillNumber;
            TotalAmount = totalAmount;
            PaymentMethods = paymentMethods;
            PaymentMethod = paymentMethods.FirstOrDefault() ?? "Cash"; // Default to first payment method or "Cash"
            
            PrintCartReceiptCommand = new Command(async () => await PrintCartReceipt());
            
            // Get printer helper from initialization service
            _posApiHelper = PrinterInitializationService.GetPrinterHelper();
            
            // Make sure printer is initialized
            if (!PrinterInitializationService.IsInitialized)
            {
                Debug.WriteLine("Warning: Printer was not initialized at app startup. Initializing now...");
                PrinterInitializationService.Initialize();
            }
        }

        // This method is kept for backward compatibility but is now empty
        // since initialization is handled by PrinterInitializationService
        private void InitializePrinter()
        {
            Debug.WriteLine("ReceiptCartViewModel.InitializePrinter: Using pre-initialized printer");
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
                    PrinterApi.PrnStr_Api($"Quantity: 1\n");
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

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("Parcels"))
                Parcels = new ObservableCollection<Parcel>((List<Parcel>)query["Parcels"]);

            if (query.ContainsKey("WaybillNumber"))
                WaybillNumber = query["WaybillNumber"].ToString();

            if (query.ContainsKey("TotalAmount") && query["TotalAmount"] != null)
                TotalAmount = Convert.ToDecimal(query["TotalAmount"]);

            if (query.ContainsKey("PaymentMethod"))
                PaymentMethod = query["PaymentMethod"].ToString();
        }
    }
} 