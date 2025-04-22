using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.data.Models;
using wms_android.data.Interfaces;
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
        public ObservableCollection<Parcel> Parcels { get; set; }
        public ObservableCollection<string> PaymentMethods { get; set; } = new();

        public string WaybillNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }

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
                }
            }
        }

        public ICommand PrintReceiptCommand { get; }
        public ICommand PrintCartReceiptCommand { get; }

        public ReceiptViewModel(IParcelService parcelService)
        {
            _parcelService = parcelService;
            PrintReceiptCommand = new Command(async () => await PrintReceipt());
            PrintCartReceiptCommand = new Command(async () => await PrintCartReceipt());
            Parcels = new ObservableCollection<Parcel>();

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
                
                // Reinitialize printer to ensure it's ready
                PrinterInitializationService.Initialize();
                
                // Set maximum gray level for darkest printing
                try {
                    if (_isA90Device) {
                        var grayResult = PrinterApi.PrnSetGray_Api(10); // Use maximum value for darkest printing
                        Debug.WriteLine($"Set gray level to 10 for A90 device, result: {grayResult}");
                    }
                    else {
                        // CS30 uses a different API for setting gray level
                        // Replace with the appropriate CS30 method
                        Debug.WriteLine("Setting gray level for CS30 device");
                    }
                }
                catch (Exception ex) {
                    Debug.WriteLine($"Error setting gray level: {ex.Message}");
                }
                
                // Center align for header
                _posApiHelper.PrintSetAlign(1);

                // Company name - large bold font
                _posApiHelper.PrintSetFont((sbyte)24, (sbyte)24, (sbyte)0x33);
                _posApiHelper.PrintStr("Ficma Home logistics\n");

                // Contact information - medium font
                _posApiHelper.PrintSetFont((sbyte)12, (sbyte)12, (sbyte)0x01);
                _posApiHelper.PrintStr("0707136852\n");
                _posApiHelper.PrintStr("ficmahomelogistics19@gmail.com\n");
                
                // Section separator - bold
                _posApiHelper.PrintSetFont((sbyte)12, (sbyte)12, (sbyte)0x33);
                _posApiHelper.PrintStr("---- Receipt ----\n\n");

                // Left align for parcel details
                _posApiHelper.PrintSetAlign(0);
                
                // Parcel details - larger font with left alignment
                _posApiHelper.PrintSetFont((sbyte)14, (sbyte)14, (sbyte)0x01);
                _posApiHelper.PrintStr($"Waybill Number: {Parcel.WaybillNumber}\n");
                _posApiHelper.PrintStr($"Sender: {Parcel.Sender}\n");
                _posApiHelper.PrintStr($"Receiver: {Parcel.Receiver}\n");
                _posApiHelper.PrintStr($"Destination: {Parcel.Destination}\n");
                _posApiHelper.PrintStr($"Rate: {Parcel.Rate}\n");
                _posApiHelper.PrintStr($"Payment Method: {Parcel.PaymentMethods}\n");
                
                // Total amount - large bold font
                _posApiHelper.PrintSetFont((sbyte)16, (sbyte)16, (sbyte)0x33);
                _posApiHelper.PrintStr($"Total Amount: Ksh {Parcel.TotalAmount:N2}\n\n");
                
                // Try printing QR code in a separate step with several approaches
                try {
                    // Make sure alignment is centered for QR code
                _posApiHelper.PrintSetAlign(1);
                    
                    // Use the PrintQrCode_Cut helper method which has multiple fallbacks
                    _posApiHelper.PrintQrCode_Cut(Parcel.WaybillNumber, 400, 400, "QR_CODE");
                    Debug.WriteLine("Printed QR code with PrintQrCode_Cut helper method");
                    
                    // Small gap after QR code
                    _posApiHelper.PrintStr("\n");
                }
                catch (Exception ex) {
                    Debug.WriteLine($"Error printing QR code: {ex.Message}");
                    // Fall back to printing the waybill number as text
                    _posApiHelper.PrintSetFont((sbyte)14, (sbyte)14, (sbyte)0x01);
                    _posApiHelper.PrintStr($"Waybill: {Parcel.WaybillNumber}\n");
                }
                
                // Add space before disclaimer
                _posApiHelper.PrintStr("\n");
                
                // Reset to smaller font for disclaimer but still readable
                _posApiHelper.PrintSetFont((sbyte)10, (sbyte)10, (sbyte)0x01);
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintStr("NB:\n");
                _posApiHelper.PrintStr("Contents not checked.\n");
                _posApiHelper.PrintStr("Customers are advised to insure their goods if the value exceeds Ksh 500.\n");
                _posApiHelper.PrintStr("All mirrors/boards are carried at owners risk.\n");
                _posApiHelper.PrintStr("Cash is not accepted as a courier, and the company will not be held liable.\n");

                // Add extra space for cutting the receipt properly
                _posApiHelper.PrintFeedPaper(150);

                // Finish the printing
                Debug.WriteLine("Starting actual printing...");
                int result = _posApiHelper.PrintStart();
                Debug.WriteLine($"Print result: {result}");

                // Show success alert
                await Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");

                // Navigate back to the root view
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Printing Error: {ex.Message}");
                Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to print receipt: {ex.Message}", "OK");
            }
        }

        // Adding a separate method for printing cart receipts
        private async Task PrintCartReceipt()
        {
            try
            {
                // Set maximum gray level for darkest printing
                try {
                    if (_isA90Device) {
                        var grayResult = PrinterApi.PrnSetGray_Api(10); // Use maximum value for darkest printing
                        Debug.WriteLine($"Set gray level to 10 for A90 device, result: {grayResult}");
                    }
                    else {
                        // CS30 uses a different API for setting gray level
                        // Replace with the appropriate CS30 method
                        Debug.WriteLine("Setting gray level for CS30 device");
                    }
                }
                catch (Exception ex) {
                    Debug.WriteLine($"Error setting gray level: {ex.Message}");
                }
                
                // Center align for header
                _posApiHelper.PrintSetAlign(1);
                
                // Company name - large bold font
                _posApiHelper.PrintSetFont((sbyte)24, (sbyte)24, (sbyte)0x33);
                _posApiHelper.PrintStr("Ficma Home Logistics\n");
                
                // Contact information - medium font
                _posApiHelper.PrintSetFont((sbyte)12, (sbyte)12, (sbyte)0x01);
                _posApiHelper.PrintStr("0707136852\n");
                _posApiHelper.PrintStr("ficmahomelogistics19@gmail.com\n");
                
                // Section separator - bold
                _posApiHelper.PrintSetFont((sbyte)12, (sbyte)12, (sbyte)0x33);
                _posApiHelper.PrintStr("---- Cart Receipt ----\n\n");

                // Left align for cart details
                _posApiHelper.PrintSetAlign(0);
                
                // Cart details - larger font with left alignment
                _posApiHelper.PrintSetFont((sbyte)14, (sbyte)14, (sbyte)0x01);
                _posApiHelper.PrintStr($"Waybill Number: {WaybillNumber}\n");
                _posApiHelper.PrintStr($"Payment Method: {PaymentMethod}\n");

                // Total amount - large bold font
                _posApiHelper.PrintSetFont((sbyte)16, (sbyte)16, (sbyte)0x33);
                _posApiHelper.PrintStr($"Total Amount: Ksh {TotalAmount:N2}\n\n");
                
                // Subtitle for parcels
                _posApiHelper.PrintSetFont((sbyte)14, (sbyte)14, (sbyte)0x33);
                _posApiHelper.PrintStr("Parcels in Cart:\n");
                
                // Print each parcel in the cart with good spacing and readable font
                _posApiHelper.PrintSetFont((sbyte)12, (sbyte)12, (sbyte)0x01);
                foreach (var parcel in Parcels)
                {
                    _posApiHelper.PrintStr($"Parcel ID: {parcel.Id}\n");
                    _posApiHelper.PrintStr($"Sender: {parcel.Sender}\n");
                    _posApiHelper.PrintStr($"Receiver: {parcel.Receiver}\n");
                    _posApiHelper.PrintStr($"Destination: {parcel.Destination}\n");
                    _posApiHelper.PrintStr($"Amount: Ksh {parcel.Amount:N2}\n");
                    _posApiHelper.PrintStr("----\n");
                }

                // Try printing QR code in a separate step
                try {
                    // Make sure alignment is centered for QR code
                _posApiHelper.PrintSetAlign(1);
                    
                    // Use the PrintQrCode_Cut helper method which handles device differences
                    _posApiHelper.PrintQrCode_Cut(WaybillNumber, 400, 400, "QR_CODE");
                    Debug.WriteLine("Printed QR code with PrintQrCode_Cut helper method");
                    
                    // Small gap after QR code
                    _posApiHelper.PrintStr("\n");
                }
                catch (Exception ex) {
                    Debug.WriteLine($"Error printing QR code: {ex.Message}");
                    // Fall back to printing the waybill number as text
                    _posApiHelper.PrintSetFont((sbyte)14, (sbyte)14, (sbyte)0x01);
                    _posApiHelper.PrintStr($"Waybill: {WaybillNumber}\n");
                }
                
                // Add space before disclaimer
                _posApiHelper.PrintStr("\n");
                
                // Reset to smaller font for disclaimer but still readable
                _posApiHelper.PrintSetFont((sbyte)10, (sbyte)10, (sbyte)0x01);
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintStr("NB:\n");
                _posApiHelper.PrintStr("Contents not checked.\n");
                _posApiHelper.PrintStr("Customers are advised to insure their goods if the value exceeds Ksh 500.\n");
                _posApiHelper.PrintStr("All mirrors/boards are carried at owners risk.\n");
                _posApiHelper.PrintStr("Cash is not accepted as a courier, and the company will not be held liable.\n");
                
                // Add extra space for cutting the receipt properly
                _posApiHelper.PrintFeedPaper(150);
                
                // Finish the printing
                Debug.WriteLine("Starting actual printing...");
                int result = _posApiHelper.PrintStart();
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
            return $"Waybill Number: {Parcel.WaybillNumber}\n" +
                   $"Sender: {Parcel.Sender}\n" +
                   $"Receiver: {Parcel.Receiver}\n" +
                   $"Destination: {Parcel.Destination}\n" +
                   $"Amount: {Parcel.Amount:C}\n" +
                   $"Total Amount: {Parcel.TotalAmount:C}\n" +
                   $"Payment Method: {Parcel.PaymentMethods}\n" +
                   $"Dispatched At: {Parcel.DispatchedAt:g}";
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("Parcels"))
                Parcels = new ObservableCollection<Parcel>((List<Parcel>)query["Parcels"]);

            if (query.ContainsKey("WaybillNumber"))
                WaybillNumber = query["WaybillNumber"].ToString();

            if (query.ContainsKey("TotalAmount"))
                TotalAmount = (decimal)query["TotalAmount"];

            if (query.ContainsKey("PaymentMethod"))
                PaymentMethod = query["PaymentMethod"].ToString();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
