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
using System.Diagnostics;

namespace wms_android.ViewModels
{
    public class ParcelsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly ParcelService _parcelService;

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

        // Commands
        public ICommand ViewParcelsCommand { get; }
        public ICommand DoneCommand { get; }
        public ICommand AddParcelCommand { get; }
        public ICommand PrintReceiptCommand { get; }

        // Default constructor for XAML instantiation
        public ParcelsViewModel()
        {
            CurrentParcel = new Parcel();
            ViewParcelsCommand = new Command(OnViewParcels);
            DoneCommand = new Command(async () => await OnDone());
            AddParcelCommand = new Command(OnAddParcel);
            PrintReceiptCommand = new Command(OnPrintReceipt);
        }

        private void OnPrintReceipt()
        {
            try
            {
                // Implement the SDK printing logic here
                // This will involve using the SDK methods to send the parcel data to the printer.
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during printing
                Debug.WriteLine($"Print error: {ex.Message}");
                Application.Current.MainPage.DisplayAlert("Error", "Failed to print receipt.", "OK");
            }
        }

        // Constructor for dependency injection
        public ParcelsViewModel(ParcelService parcelService) : this()
        {
            _parcelService = parcelService;
        }

        private async Task OnDone()
        {
            if (CurrentParcel == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No parcel data to save", "OK");
                return;
            }

            try
            {
                // Ensure DispatchedAt is UTC before saving
                if (CurrentParcel.DispatchedAt.HasValue && CurrentParcel.DispatchedAt.Value.Kind != DateTimeKind.Utc)
                {
                    CurrentParcel.DispatchedAt = CurrentParcel.DispatchedAt.Value.ToUniversalTime();
                }

                // Create a new instance of ReceiptViewModel with the current parcel
                var receiptViewModel = new ReceiptViewModel
                {
                    Parcel = CurrentParcel
                };

                // Navigate to the ReceiptView and pass the receiptViewModel
                var receiptView = new ReceiptView
                {
                    BindingContext = receiptViewModel
                };
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptView);

                // Optionally, save the current parcel to the database
                var savedParcel = await _parcelService.CreateParcelAsync(CurrentParcel);

                // Reset the form or navigate to a new page
                CurrentParcel = new Parcel();
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptView);
                 //await Application.Current.MainPage.DisplayAlert("Success", "Parcel saved successfully", "OK");
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : "No inner exception";
                System.Diagnostics.Debug.WriteLine($"DbUpdateException: {dbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Inner Exception: {innerException}");

                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {dbEx.Message}\nInner Exception: {innerException}", "OK");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");

                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {ex.Message}", "OK");
            }
        }


        private void OnViewParcels()
        {
            // Implement view parcels logic
        }

        private void OnAddParcel()
        {
            // Implement add parcel logic
            // For example:
            // SaveParcel(CurrentParcel);
            // CurrentParcel = new Parcel();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
