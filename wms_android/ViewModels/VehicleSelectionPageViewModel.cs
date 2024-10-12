using Com.Ctk.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.data.Interfaces;
using wms_android.data.Models;
using wms_android.data.Services;
using wms_android.Views;

namespace wms_android.ViewModels
{
    public class VehicleSelectionViewModel : INotifyPropertyChanged
    {
        private readonly IVehicleService _vehicleService;
        private readonly IParcelService _parcelService;
        //private readonly QRScanPage _qrScanPage;
        public ObservableCollection<Vehicle> Vehicles { get; set; }
        public ObservableCollection<Drivers> Drivers { get; set; }
        public Vehicle SelectedVehicle { get; set; }
        public Drivers SelectedDriver { get; set; }

        public ICommand ConfirmVehicleAndDriverCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public VehicleSelectionViewModel(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;

            // Load vehicles and drivers from service
            Vehicles = new ObservableCollection<Vehicle>(_vehicleService.GetVehicles());  // Correct type
            Drivers = new ObservableCollection<Drivers>(_vehicleService.GetDrivers());    // Correct type

            // Command to confirm vehicle and driver selection
            ConfirmVehicleAndDriverCommand = new Command(async () => await ConfirmVehicleAndDriver());
        }

        private async Task ConfirmVehicleAndDriver()
        {
            if (SelectedVehicle != null && SelectedDriver != null)
            {
                // Create a new instance of QRScanViewModel
                //var qrScanViewModel = new QRScanViewModel(SelectedVehicle, SelectedDriver, _parcelService, PosApiHelper.Instance);
                // Navigate to QR scanning page after confirmation
                //await Application.Current.MainPage.Navigation.PushAsync(new QRScanPage(SelectedVehicle, SelectedDriver, _parcelService, qrScanViewModel));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please select both vehicle and driver.", "OK");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
