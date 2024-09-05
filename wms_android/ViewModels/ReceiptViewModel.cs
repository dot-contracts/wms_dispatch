using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.data.Models;

namespace wms_android.ViewModels
{
    public class ReceiptViewModel : INotifyPropertyChanged
    {
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

        public ReceiptViewModel()
        {
            PrintReceiptCommand = new Command(PrintReceipt);
        }

        private void PrintReceipt()
        {
            try
            {
                // Example logic for Bluetooth printing
                // var printer = new BluetoothPrinter(); // Replace with actual printer initialization
                // printer.Connect(); // Connect to the printer

                // Prepare the receipt content
                var receiptContent = $"Waybill Number: {Parcel.WaybillNumber}\n" +
                                    $"Sender: {Parcel.Sender}\n" +
                                    $"Receiver: {Parcel.Receiver}\n" +
                                    $"Destination: {Parcel.Destination}\n" +
                                    $"Amount: {Parcel.Amount:C}\n" +
                                    $"Total Amount: {Parcel.TotalAmount:C}\n" +
                                    $"Payment Method: {Parcel.PaymentMethods}\n";

                // printer.Print(receiptContent); // Send the content to the printer
                // printer.Disconnect(); // Disconnect after printing
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Print error: {ex.Message}");
                Application.Current.MainPage.DisplayAlert("Error", "Failed to print receipt.", "OK");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
