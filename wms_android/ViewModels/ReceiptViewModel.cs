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

namespace wms_android.ViewModels
{
    public class ReceiptViewModel : INotifyPropertyChanged
    {
        private readonly IParcelService _parcelService;
        private PosApiHelper _posApiHelper;
        public ObservableCollection<Parcel> Parcels { get; set; }
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

        public ReceiptViewModel(IParcelService parcelService)
        {
            _parcelService = parcelService;
            PrintReceiptCommand = new Command(async () => await PrintReceipt());

            // Initialize PosApiHelper
            _posApiHelper = PosApiHelper.Instance;
            InitializePrinter();
        }


        private void InitializePrinter()
        {
            // Increase the font height and width for larger text
            int fontHeight = 8;  // Increased font height
            int fontWidth = 8;   // Increased font width
            int density = 2;      // Print density
            int otherOptions = 0x33; // Default options

            // Initialize the printer with the new font size
            int result = _posApiHelper.PrintInit(density, fontHeight, fontWidth, otherOptions);
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
                // Print the receipt using the Parcel details
                _posApiHelper.PrintSetAlign(1);  // Center align
                _posApiHelper.PrintStr("Ficma Home logistics\n");
                _posApiHelper.PrintStr("0707136852\n");
                _posApiHelper.PrintStr("ficmahomelogistics19@gmail.com\n");
                _posApiHelper.PrintStr("---- Receipt ----\n");

                _posApiHelper.PrintSetAlign(0);  // Left align
                _posApiHelper.PrintStr($"Waybill Number: {Parcel.WaybillNumber}\n");
                _posApiHelper.PrintStr($"Sender: {Parcel.Sender}\n");
                _posApiHelper.PrintStr($"Receiver: {Parcel.Receiver}\n");
                _posApiHelper.PrintStr($"Destination: {Parcel.Destination}\n");
                _posApiHelper.PrintStr($"Amount: Ksh {Parcel.Amount:N2}\n");
                _posApiHelper.PrintStr($"Total Amount: Ksh {Parcel.TotalAmount:N2}\n");
                _posApiHelper.PrintStr($"Payment Method: {Parcel.PaymentMethods}\n");

                // Optionally print a QR code based on the Waybill number
                _posApiHelper.PrintQrCode_Cut(Parcel.WaybillNumber, 360, 360, "QR_CODE");

                // Print the receipt using the Parcel details
                _posApiHelper.PrintSetAlign(0);  // Center align
                _posApiHelper.PrintStr("NB\n");
                _posApiHelper.PrintStr("- Contents not checked\n");
                _posApiHelper.PrintStr("- Cutomers are advised to insure their goods if the value exceeds Ksh 500\n");
                _posApiHelper.PrintStr("- All mirrors/boards are carried at owners risk\n");
                _posApiHelper.PrintStr("- Cash is not accepted as a courier and for any loss of cash parcels the company will not be held liable\n");
                _posApiHelper.PrintStr("\n");
                _posApiHelper.PrintStr("\n");
                _posApiHelper.PrintStr("\n");


                // Finish the printing
                _posApiHelper.PrintStart();

                // Show a success alert to the user
                await Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");

                // Navigate back to the root view
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                // Handle errors during printing
                Console.WriteLine($"Printing Error: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to print receipt: {ex.Message}", "OK");
            }
        }
        //private async Task PrintReceipt()
        //{
        //    try
        //    {
        //        // Save parcel to the database
        //        //await _parcelService.CreateParcelAsync(Parcel);

        //        // Check if the parcel was saved successfully
        //        if (_parcelService != null)
        //        {
        //            // Show the success alert and wait for the user to press "OK"
        //            await Application.Current.MainPage.DisplayAlert("Success", "Parcel saved and receipt printed.", "OK");

        //            // After the user presses OK, navigate back to the ParcelView
        //            //if (result)
        //            //{
        //            //    // Reset Parcel after printing, if required
        //            //    // ResetParcel();

        //            //    // Navigate back to the ParcelView (root of the stack)
        //            //    await Application.Current.MainPage.Navigation.PopToRootAsync();
        //            //}
        //            await Application.Current.MainPage.Navigation.PopModalAsync();
        //        }
        //        else
        //        {
        //            throw new Exception("Parcel saving returned null");
        //        }
        //    }
        //    catch (DbUpdateException dbEx)
        //    {
        //        var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : "No inner exception";
        //        System.Diagnostics.Debug.WriteLine($"DbUpdateException: {dbEx.Message}");
        //        await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {dbEx.Message}\nInner Exception: {innerException}", "OK");
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
        //        await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel or print receipt. Error: {ex.Message}", "OK");
        //    }
        //}



        // ResetParcel method
        //private void ResetParcel()
        //{
        //    Parcel = new Parcel
        //    {
        //        CreatedAt = DateTime.UtcNow, // Initialize with default values if needed
        //        Status = ParcelStatus.Pending
        //    };
        //}

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
                PaymentMethod = query["PaymentMethods"].ToString();
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
