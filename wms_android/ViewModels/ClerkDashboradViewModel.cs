using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using wms_android.data.Interfaces;
using wms_android.data.Models;
using wms_android.Services;
using wms_android.Views;

namespace wms_android.ViewModels
{
    public class ClerkDashboardViewModel : INotifyPropertyChanged
    {
        private readonly IParcelService _parcelService;
        private readonly IUserService _userService;

        public event PropertyChangedEventHandler PropertyChanged;

        // Add this property
        public INavigation Navigation { get; set; }

        private int _parcelCount;
        public int ParcelCount
        {
            get => _parcelCount;
            set
            {
                _parcelCount = value;
                OnPropertyChanged(nameof(ParcelCount));
            }
        }

        private int _newClientCount;
        public int NewClientCount
        {
            get => _newClientCount;
            set
            {
                _newClientCount = value;
                OnPropertyChanged(nameof(NewClientCount));
            }
        }

        private decimal _totalSales;
        public decimal TotalSales
        {
            get => _totalSales;
            set
            {
                _totalSales = value;
                OnPropertyChanged(nameof(TotalSales));
            }
        }

        public ObservableCollection<Parcel> PendingOrders { get; set; }

        public ICommand RefreshCommand { get; }

        public ICommand AddParcelCommand { get; }
        public ICommand HomeCommand { get; }
        public ICommand OrdersCommand { get; }

        public ClerkDashboardViewModel(IParcelService parcelService, IUserService userService, INavigation navigation)
        {
            _parcelService = parcelService;
            _userService = userService;
            Navigation = navigation;
            PendingOrders = new ObservableCollection<Parcel>();
            RefreshCommand = new Command(async () => await LoadDashboardData());

            AddParcelCommand = new Command(async () => await ExecuteAddParcelCommand());
            HomeCommand = new Command(async () => await ExecuteHomeCommand());
            OrdersCommand = new Command(async () => await ExecuteOrdersCommand());
        }

        public async Task LoadDashboardData()
        {
            var today = DateTime.Today;
            ParcelCount = await _parcelService.GetParcelCountForDateAsync(today);
            NewClientCount = await _userService.GetNewClientCountForDateAsync(today);
            TotalSales = await _parcelService.GetTotalSalesForDateAsync(today);

            var pendingOrders = await _parcelService.GetPendingOrdersAsync();
            PendingOrders.Clear();
            foreach (var order in pendingOrders)
            {
                PendingOrders.Add(order);
            }

            OnPropertyChanged(nameof(PendingOrders));
        }

        private async Task ExecuteAddParcelCommand()
        {
            var parcelService = ServiceHelper.GetService<IParcelService>();
            var parcelsViewModel = new ParcelsViewModel(parcelService);
            await Navigation.PushAsync(new ParcelsView(parcelsViewModel));
        }

        private async Task ExecuteHomeCommand()
        {
            // Since we're already on the home page, we don't need to navigate
            await LoadDashboardData();
        }

        private async Task ExecuteOrdersCommand()
        {
            // Implement navigation to Orders page
            // For now, we'll just show an alert
            await Application.Current.MainPage.DisplayAlert("Orders", "Orders page not implemented yet", "OK");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}