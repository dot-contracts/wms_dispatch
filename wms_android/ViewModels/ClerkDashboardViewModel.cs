using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.Runtime.CompilerServices;
using wms_android.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using wms_android.Utils;
using wms_android.shared.Interfaces; // For ILoadingService, IQRScannerService, IPosApiHelper
using CommunityToolkit.Mvvm.Input; // Added for AsyncRelayCommand

// Use data models and interfaces
using IParcelServiceData = wms_android.data.Interfaces.IParcelService; // Alias data interface
using IParcelServiceShared = wms_android.shared.Interfaces.IParcelService; // Alias shared interface
using IUserService = wms_android.data.Interfaces.IUserService;
using IVehicleService = wms_android.data.Interfaces.IVehicleService;
using ParcelData = wms_android.data.Models.Parcel; // Alias data model
using ParcelShared = wms_android.shared.Models.Parcel; // Alias shared model
using VehicleShared = wms_android.shared.Models.Vehicle; // Alias shared model
using DriverShared = wms_android.shared.Models.Drivers; // Alias shared model
using wms_android.Services;
using wms_android.shared.Interfaces; // For ILoadingService, IQRScannerService, IPosApiHelper

namespace wms_android.ViewModels
{
    public class ClerkDashboardViewModel : INotifyPropertyChanged
    {
        private readonly IParcelServiceData _parcelServiceData; // Use data service for DB ops
        private readonly IParcelServiceShared _parcelServiceShared; // Use shared service for API ops like GetByQR
        private readonly IUserService _userService;
        private readonly ILoadingService _loadingService;
        private readonly IVehicleService _vehicleService; // Added for potential future use
        private readonly IQRScannerService _scannerService; // Added scanner service
        private readonly IPosApiHelper _posApiHelper; // Added POS helper
        private INavigation _navigation;

        private int _parcelCount;
        private int _newClientCount;
        private decimal _totalSales;
        private bool _isRefreshing;

        // Command fields
        private AsyncRelayCommand _deliverCommand; // Changed to AsyncRelayCommand or similar
        private Command _refreshCommand;
        private Command _addParcelCommand;
        private Command _homeCommand;
        private Command _testScanCommand;

        public ObservableCollection<ParcelData> PendingOrders { get; set; } = new ObservableCollection<ParcelData>(); // Use data model

        public int ParcelCount
        {
            get => _parcelCount;
            set
            {
                _parcelCount = value;
                OnPropertyChanged();
            }
        }

        public int NewClientCount
        {
            get => _newClientCount;
            set
            {
                _newClientCount = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalSales
        {
            get => _totalSales;
            set
            {
                _totalSales = value;
                OnPropertyChanged();
            }
        }

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand => _refreshCommand;
        public ICommand AddParcelCommand => _addParcelCommand;
        public ICommand HomeCommand => _homeCommand;
        public ICommand DeliverCommand => _deliverCommand;
        public ICommand TestScanCommand => _testScanCommand;

        public INavigation Navigation
        {
            get => _navigation;
            set => _navigation = value;
        }

        // Updated Constructor with all dependencies
        public ClerkDashboardViewModel(
            IParcelServiceData parcelServiceData,
            IParcelServiceShared parcelServiceShared,
            IUserService userService,
            ILoadingService loadingService,
            IVehicleService vehicleService,
            IQRScannerService scannerService,
            IPosApiHelper posApiHelper)
        {
            _parcelServiceData = parcelServiceData;
            _parcelServiceShared = parcelServiceShared;
            _userService = userService;
            _loadingService = loadingService;
            _vehicleService = vehicleService; // Store injected service
            _scannerService = scannerService; // Store injected service
            _posApiHelper = posApiHelper; // Store injected service
            
            InitializeViewModel();
        }

        // Overload for setting navigation (consider passing via method instead?)
        public ClerkDashboardViewModel(
            IParcelServiceData parcelServiceData,
            IParcelServiceShared parcelServiceShared,
            IUserService userService,
            ILoadingService loadingService,
            IVehicleService vehicleService,
            IQRScannerService scannerService,
            IPosApiHelper posApiHelper,
            INavigation navigation) : this(parcelServiceData, parcelServiceShared, userService, loadingService, vehicleService, scannerService, posApiHelper)
        {
            _navigation = navigation;
        }

        private void InitializeViewModel()
        {
            _refreshCommand = new Command(async () => await LoadDashboardData());
            _addParcelCommand = new Command(ExecuteAddParcelCommand);
            _homeCommand = new Command(ExecuteHomeCommand);
            // Initialize DeliverCommand with the async method
            _deliverCommand = new AsyncRelayCommand(ExecuteDeliverCommandAsync); 
            _testScanCommand = new Command(ExecuteTestScanCommand);
            
            Task.Run(async () => await LoadDashboardData());
        }

        public async Task LoadDashboardData()
        {
            try
            {
                IsRefreshing = true;
                await _loadingService.ShowLoadingAsync("Loading dashboard data...");
                
                // Get dashboard data from services
                ParcelCount = await _parcelServiceData.GetParcelCountAsync();
                NewClientCount = await _userService.GetNewClientCountAsync();
                TotalSales = await _parcelServiceData.GetTotalSalesAsync();

                var pendingOrders = await _parcelServiceData.GetPendingParcelsAsync();
                PendingOrders.Clear();
                foreach (var order in pendingOrders)
                {
                    PendingOrders.Add(order);
                }
            }
            catch (Exception ex)
            {
                // Handle error
                System.Diagnostics.Debug.WriteLine($"Error loading dashboard data: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", "Failed to load dashboard data", "OK");
            }
            finally
            {
                IsRefreshing = false;
                await _loadingService.HideLoadingAsync();
            }
        }

        private void ExecuteAddParcelCommand()
        {
            if (_navigation == null)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Navigation is not available", "OK");
                return;
            }
            
            // Get the ParcelsViewModel from the DI container using ServiceHelper
            var parcelsViewModel = ServiceHelper.GetService<ParcelsViewModel>();
            
            if (parcelsViewModel != null)
            {
                _navigation.PushAsync(new ParcelsView(parcelsViewModel));
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Could not create the parcels view", "OK");
            }
        }

        private void ExecuteHomeCommand()
        {
            // Handle home navigation logic
            Task.Run(async () => await LoadDashboardData());
        }

        private void ExecuteTestScanCommand()
        {
            if (_navigation == null)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Navigation is not available", "OK");
                return;
            }
            
            try
            {
                // Get the QR scanner service
                var scannerService = ServiceHelper.GetService<wms_android.shared.Interfaces.IQRScannerService>();
                
                if (scannerService == null)
                {
                    Application.Current.MainPage.DisplayAlert("Error", "Scanner service not available", "OK");
                    return;
                }
                
                // Navigate to the test page
                _navigation.PushAsync(new QRScanTestPage(scannerService));
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", $"Failed to navigate to QR scanner test: {ex.Message}", "OK");
            }
        }

        // --- NEW Async Method for Deliver Command ---
        private async Task ExecuteDeliverCommandAsync()
        {
            if (_navigation == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Navigation is not available", "OK");
                return;
            }

            string scanResult = null;
            ParcelShared parcel = null; // Use shared model from scan service
            
            try
            {
                await _loadingService.ShowLoadingAsync("Starting scanner...");

                // 1. Perform Scan
                scanResult = await _scannerService.StartScanAsync();
                
                if (string.IsNullOrEmpty(scanResult))
                {
                    await _loadingService.HideLoadingAsync(); // Hide loading if scan cancelled/failed early
                    await Application.Current.MainPage.DisplayAlert("Scan Failed", "No QR code was scanned or scan was cancelled.", "OK");
                    return;
                }
                
                await _loadingService.ShowLoadingAsync("Fetching parcel details...");

                // 2. Fetch Parcel Details using Shared Service
                parcel = await _parcelServiceShared.GetParcelByQRCodeAsync(scanResult);

                if (parcel == null)
                {
                    await _loadingService.HideLoadingAsync(); // Hide loading if parcel not found
                    await Application.Current.MainPage.DisplayAlert("Not Found", $"No parcel found with QR code: {scanResult}", "OK");
                    return;
                }

                // 3. Get Vehicle/Driver (USING DUMMY DATA FOR NOW)
                // TODO: Implement actual retrieval based on user session or selection
                var vehicle = new VehicleShared { Id = Guid.NewGuid(), VehicleRegistrationNumber = "DUMMY01", BodyType = "Van" };
                var driver = new DriverShared { Id = Guid.NewGuid(), FirstName = "Dummy", LastName = "Driver" };
                
                await _loadingService.HideLoadingAsync(); // Hide before navigation

                // 4. Navigate to Delivery View
                // DeliveryViewModel expects: Parcel (shared), Vehicle (shared), Driver (shared), IPosApiHelper, IParcelService (shared?)
                await _navigation.PushAsync(new DeliveryView(parcel, vehicle, driver, _posApiHelper, _parcelServiceShared));
            
            }
            catch (InvalidOperationException opEx) when (opEx.Message.Contains("Vanstone System"))
            {
                 // Specific error for scanner system not ready
                 await _loadingService.HideLoadingAsync();
                 await Application.Current.MainPage.DisplayAlert("Scanner Error", "Scanner system is not initialized. Please restart the app or check device.", "OK");
            }
            catch (System.Exception ex)
            {
                await _loadingService.HideLoadingAsync();
                System.Diagnostics.Debug.WriteLine($"Error during delivery scan/fetch: {ex.Message}{System.Environment.NewLine}{ex.StackTrace}");
                await Application.Current.MainPage.DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
            finally
            {
                // Ensure loading is hidden even if unexpected errors occur before it's explicitly hidden
                await _loadingService.HideLoadingAsync(); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}