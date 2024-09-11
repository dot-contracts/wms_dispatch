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

namespace wms_android.ViewModels
{
    public class ReceiptViewModel : INotifyPropertyChanged
    {
        private readonly IParcelService _parcelService;

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
        }

        private async Task PrintReceipt()
        {
            try
            {
                // Save parcel to the database
                //await _parcelService.CreateParcelAsync(Parcel);

                // Check if the parcel was saved successfully
                if (_parcelService != null)
                {
                    // Show the success alert and wait for the user to press "OK"
                    await Application.Current.MainPage.DisplayAlert("Success", "Parcel saved and receipt printed.", "OK");

                    // After the user presses OK, navigate back to the ParcelView
                    //if (result)
                    //{
                    //    // Reset Parcel after printing, if required
                    //    // ResetParcel();

                    //    // Navigate back to the ParcelView (root of the stack)
                    //    await Application.Current.MainPage.Navigation.PopToRootAsync();
                    //}
                    await Application.Current.MainPage.Navigation.PopModalAsync();
                }
                else
                {
                    throw new Exception("Parcel saving returned null");
                }
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : "No inner exception";
                System.Diagnostics.Debug.WriteLine($"DbUpdateException: {dbEx.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {dbEx.Message}\nInner Exception: {innerException}", "OK");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel or print receipt. Error: {ex.Message}", "OK");
            }
        }



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

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
