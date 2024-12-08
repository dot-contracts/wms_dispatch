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
using Com.Ctk.Sdk;
using wms_android.Interfaces;

namespace wms_android.ViewModels
{
    public class ReceiptViewModel : INotifyPropertyChanged
    {
        private readonly IParcelService _parcelService;
        private PosApiHelper _posApiHelper;
        public ObservableCollection<Parcel> Parcels { get; set; }
        public ObservableCollection<string> PaymentMethods { get; set; } = new();  // Change the property type

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

            // Initialize PosApiHelper
            _posApiHelper = PosApiHelper.Instance;
            InitializePrinter();
        }


        private void InitializePrinter()
        {
            // Increase the font height and width for larger text
            // int fontHeight = 8;  // Increased font height
            // int fontWidth = 8;   // Increased font width
            int gray = 2;      // Print density
            int density = 2;      // Print density
            int mode = 0;      // Print density
            int otherOptions = 0x00; // Default options

            // Initialize the printer with the new font size
            int result = _posApiHelper.PrintInit(gray, density, mode, otherOptions);
            if (result != 0)
            {
                // Handle printer initialization failure
                Console.WriteLine("Failed to initialize printer.");
            }
        }

        private async Task PrintReceipt()
        {
            try
            {
                // Center align
                _posApiHelper.PrintSetAlign(1);

                // Set font for header (large font, bold)
                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x33);
                _posApiHelper.PrintStr("Ficma Home logistics\n");

                // Set font for contact information (medium font)
                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x00);
                _posApiHelper.PrintStr("0707136852\n");
                _posApiHelper.PrintStr("ficmahomelogistics19@gmail.com\n");
                _posApiHelper.PrintStr("---- Receipt ----\n");

                // Left align for parcel details (normal font size)
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x00);
                _posApiHelper.PrintStr($"Waybill Number: {Parcel.WaybillNumber}\n");
                _posApiHelper.PrintStr($"Sender: {Parcel.Sender}\n");
                _posApiHelper.PrintStr($"Receiver: {Parcel.Receiver}\n");
                _posApiHelper.PrintStr($"Destination: {Parcel.Destination}\n");
                _posApiHelper.PrintStr($"Rate: {Parcel.Rate}\n");
                _posApiHelper.PrintStr($"PAyment Method: {Parcel.PaymentMethods}\n");

                // Set font for amount details (bold)
                _posApiHelper.PrintSetFont((sbyte)9, (sbyte)9, (sbyte)0x33);
                _posApiHelper.PrintStr($"Total Amount: Ksh {Parcel.TotalAmount:N2}\n");

                // Print a QR code
                _posApiHelper.PrintSetAlign(1);
                _posApiHelper.PrintQrCode_Cut(Parcel.WaybillNumber, 360, 360, "QR_CODE");

                // Reset to smaller font for disclaimer
                _posApiHelper.PrintSetFont((sbyte)16, (sbyte)16, (sbyte)0x00);
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintStr("NB:\n");
                _posApiHelper.PrintStr("Contents not checked. \n");
                _posApiHelper.PrintStr("Customers are advised to insure their goods if the value exceeds Ksh 500. \n");
                _posApiHelper.PrintStr("All mirrors/boards are carried at owners risk. \n");
                _posApiHelper.PrintStr("Cash is not accepted as a courier, and the company will not be held liable.\n");

                // Add extra space for cutting the receipt properly
                _posApiHelper.PrintFeedPaper(150); // Adjust the value (e.g., 150) for appropriate spacing

                // Finish the printing
                _posApiHelper.PrintStart();

                // Show success alert
                await Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");

                // Navigate back to the root view
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Printing Error: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to print receipt: {ex.Message}", "OK");
            }
        }

        // Adding a separate method for printing cart receipts
        private async Task PrintCartReceipt()
        {
            try
            {
                // Print header
                _posApiHelper.PrintSetAlign(1);
                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x33);
                _posApiHelper.PrintStr("Ficma Home Logistics - Cart Receipt\n");

                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x00);
                _posApiHelper.PrintStr("0707136852\n");
                _posApiHelper.PrintStr("ficmahomelogistics19@gmail.com\n");
                _posApiHelper.PrintStr("---- Cart Receipt ----\n");

                // Print waybill and total for cart
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x00);
                _posApiHelper.PrintStr($"Waybill Number: {WaybillNumber}\n");
                _posApiHelper.PrintStr($"Total Amount for Cart: Ksh {TotalAmount:N2}\n");
                _posApiHelper.PrintStr($"Payment Method: {PaymentMethod}\n");

                // Print each parcel in the cart
                foreach (var parcel in Parcels)
                {
                    _posApiHelper.PrintStr($"Parcel GUID: {parcel.Id}\n"); // Using GUID instead of ParcelId
                    _posApiHelper.PrintStr($"Sender: {parcel.Sender}\n");
                    _posApiHelper.PrintStr($"Receiver: {parcel.Receiver}\n");
                    _posApiHelper.PrintStr($"Destination: {parcel.Destination}\n");
                    _posApiHelper.PrintStr($"Amount: Ksh {parcel.Amount:N2}\n");
                    _posApiHelper.PrintStr("----\n");
                }

                // Print QR code for the entire cart waybill number
                _posApiHelper.PrintSetAlign(1);
                _posApiHelper.PrintQrCode_Cut(WaybillNumber, 360, 360, "QR_CODE");

                // Print disclaimer
                _posApiHelper.PrintSetFont((sbyte)16, (sbyte)16, (sbyte)0x00);
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintStr("NB:\n");
                _posApiHelper.PrintStr("Contents not checked. \n");
                _posApiHelper.PrintStr("Customers are advised to insure their goods...\n");

                // Add extra space and finish printing
                _posApiHelper.PrintFeedPaper(150);
                _posApiHelper.PrintStart();

                await Application.Current.MainPage.DisplayAlert("Success", "Cart receipt printed successfully.", "OK");

                // Navigate back to the root view
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cart Printing Error: {ex.Message}");
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
