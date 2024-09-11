using System;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using wms_android.data.Models;
using wms_android.data.Services;
using System.Threading.Tasks;
using wms_android.Views;
using wms_android.data.Interfaces;
using System.Diagnostics;

namespace wms_android.ViewModels
{
    public class ParcelsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IParcelService _parcelService; // Injected service
        //private string _waybillNumber;
        public string WaybillNumber { get; set; } // Shared across parcels for a Waybill
        public string Sender { get; set; }
        public string Receiver { get; set; }

        private Parcel _currentParcel;
       
        public Parcel CurrentParcel
        {
            get => _currentParcel;
            set
            {
                if (_currentParcel != value)
                {
                    _currentParcel = value;
                    OnPropertyChanged(nameof(CurrentParcel));
                }
            }
        }

        // Properties
        private string _moduleName = "Parcels";
        public string ModuleName
        {
            get => _moduleName;
            set
            {
                if (_moduleName != value)
                {
                    _moduleName = value;
                    OnPropertyChanged(nameof(ModuleName));
                }
            }
        }

        public ObservableCollection<string> Destinations { get; } = new ObservableCollection<string>
    {
        "Eldoret", "Kisumu", "Nakuru", "Nairobi", "Kakamega", "Kericho", "Kitale"
    };

        public ObservableCollection<string> PaymentMethods { get; } = new ObservableCollection<string>
    {
        "COD", "Paid", "Contract"
    };

        public ObservableCollection<Parcel> Parcels { get; set; } = new ObservableCollection<Parcel>();

        // Commands
        public ICommand ViewParcelsCommand { get; }
        public ICommand DoneCommand { get; }
        public ICommand AddParcelCommand { get; }
        public ICommand PrintReceiptCommand { get; }
        public ICommand ValidateParcelCommand { get; }
        public ICommand BackCommand { get; }


        // Default constructor for XAML instantiation
        public ParcelsViewModel(IParcelService parcelService)
        {
            _parcelService = parcelService;

            // Generate the waybill number using the service
            //_waybillNumber = _parcelService.GenerateWaybillNumber();

            CurrentParcel = new Parcel
            {
                //WaybillNumber = _waybillNumber,
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };

            // Initialize commands
            ViewParcelsCommand = new Command(OnViewParcels);
            DoneCommand = new Command(async () =>
            {
                if (await ValidateParcelAsync())
                {
                    await OnDone();
                }
            });
            AddParcelCommand = new Command(OnAddParcel);
            PrintReceiptCommand = new Command(OnPrintReceipt);
            ValidateParcelCommand = new Command(async () => await ValidateParcelAsync());
            BackCommand = new Command(async () => await BackToParcels());
        }


        // Constructor for dependency injection
        //public ParcelsViewModel(IParcelService iparcelService) : this()
        //{
        //    _iparcelService = iparcelService;
        //}

        private async Task<bool> ValidateParcelAsync()
        {
            if (string.IsNullOrWhiteSpace(CurrentParcel.Sender) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Receiver) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Destination) ||
                string.IsNullOrWhiteSpace(CurrentParcel.PaymentMethods) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Amount.ToString()) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Quantity.ToString()))
            {
                await Application.Current.MainPage.DisplayAlert("Validation Error", "Please fill in all required fields.", "OK");
                return false;
            }
            return true;
        }


        private async Task OnDone()
        {
            if (CurrentParcel == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No parcel data to save", "OK");
                return;
            }

            if (_parcelService == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Parcel service is not initialized.", "OK");
                return;
            }

            try
            {
                // Ensure DispatchedAt is UTC before saving
                if (CurrentParcel.DispatchedAt.HasValue && CurrentParcel.DispatchedAt.Value.Kind != DateTimeKind.Utc)
                {
                    CurrentParcel.DispatchedAt = CurrentParcel.DispatchedAt.Value.ToUniversalTime();
                }

                // Save the current parcel to the database
                await _parcelService.CreateParcelAsync(CurrentParcel);

                // Finalize the waybill, etc.
                await _parcelService.FinalizeWaybillAsync();

                // Create a new instance of ReceiptViewModel with the current parcel
                var receiptViewModel = new ReceiptViewModel(_parcelService)
                {
                    Parcel = CurrentParcel
                };

                // Navigate to the ReceiptView and pass the receiptViewModel
                var receiptView = new ReceiptView(receiptViewModel);
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptView);

                // Reset the form after the user confirms success
                ResetParcel();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {ex.Message}", "OK");
            }
        }


        private void OnPrintReceipt()
        {
            try
            {
                if (!ValidateParcelAsync().Result)
                {
                    return; // Exit if validation fails
                }

                // Implement SDK printing logic here

                // Simulate successful printing and show alert
                Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Print error: {ex.Message}");
                Application.Current.MainPage.DisplayAlert("Error", "Failed to print receipt.", "OK");
            }
        }


        public void ResetParcel()
        {
            // Reset the parcel data for ParcelView
            CurrentParcel = new Parcel
            {
                //WaybillNumber = _waybillNumber,
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };
        }

        

        private async void OnViewParcels()
        {
            var viewParcelsPage = new ListParcelsView(this); // Pass the current ViewModel
            await Application.Current.MainPage.Navigation.PushAsync(viewParcelsPage);
        }

        private async Task BackToParcels()
        {
            await Application.Current.MainPage.Navigation.PopAsync(); // Navigate back to the ParcelView
        }

        private async void OnAddParcel()
        {
            // Implement add parcel logic
            if (await ValidateParcelAsync()) // Check if current parcel data is valid
            {
                Parcels.Add(CurrentParcel); // Add current parcel to the collection

                ResetAddParcel(); // Clear fields for the next parcel input

                await Application.Current.MainPage.DisplayAlert("Success", "Parcel added to cart. You can now add another one.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill in all required fields.", "OK");
            }
        }

        public void ResetAddParcel()
        {
            // Preserve the Sender, Receiver details and WaybillNumber
            var sender = CurrentParcel.Sender;
            var senderTelephone = CurrentParcel.SenderTelephone;
            var receiver = CurrentParcel.Receiver;
            var receiverTelephone = CurrentParcel.ReceiverTelephone;
            var waybillNumber = CurrentParcel.WaybillNumber;

            // Reset the other fields for the next parcel
            CurrentParcel = new Parcel
            {
                Sender = sender,
                SenderTelephone = senderTelephone,
                Receiver = receiver,
                ReceiverTelephone = receiverTelephone,
                WaybillNumber = waybillNumber, // Keep the same waybill number
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
