using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;
using wms_android.shared.Models;
using wms_android.Views;
using wms_android.shared.Interfaces;
using Microsoft.Maui.Storage;

namespace wms_android.ViewModels
{
    public partial class ClerkDashboardViewModel : ObservableObject
    {
        private readonly IParcelService _parcelService;
        private readonly IUserService _userService;
        private readonly ILogger<ClerkDashboardViewModel> _logger;
        public INavigation Navigation { get; set; }

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private int _parcelCount;

        [ObservableProperty]
        private int _deliveredCount;

        [ObservableProperty]
        private double _totalSales;

        [ObservableProperty]
        private int _pendingCount;

        [ObservableProperty]
        private string _userName;

        [ObservableProperty]
        private string _userRole;
        
        public ClerkDashboardViewModel(
            IParcelService parcelService, 
            IUserService userService,
            ILogger<ClerkDashboardViewModel> logger)
        {
            _parcelService = parcelService;
            _userService = userService;
            _logger = logger;
            _logger.LogInformation("ClerkDashboardViewModel initialized");
            
            // Default values
            UserName = "Loading...";
            UserRole = "";
        }

        [RelayCommand]
        private async Task NavigateToScanNewParcel()
        {
            _logger.LogInformation("Navigate to scan/deliver parcel");
            await Shell.Current.GoToAsync($"//{nameof(ParcelsView)}");
        }

        [RelayCommand]
        private async Task NavigateToViewAllParcels()
        {
            _logger.LogInformation("Navigate to view all parcels");
            await Shell.Current.GoToAsync($"//{nameof(ListParcelsView)}");
        }

        [RelayCommand]
        private async Task NavigateToAddParcel()
        {
            _logger.LogInformation("Navigate to collect parcel");
            await Shell.Current.GoToAsync($"//{nameof(ParcelsView)}");
        }

        [RelayCommand]
        private async Task GenerateReport()
        {
            _logger.LogInformation("Generate report");
            await Shell.Current.GoToAsync($"//{nameof(ReportView)}");
        }

        public async Task LoadDashboardData()
        {
            try
            {
                IsLoading = true;
                
                // Get today's date
                var today = DateTime.Today;
                
                // Get parcel metrics for today
                ParcelCount = await _parcelService.GetParcelCountAsync(today);
                DeliveredCount = await _parcelService.GetDeliveredParcelCountAsync(today);
                TotalSales = await _parcelService.GetTotalSalesAsync(today);
                PendingCount = ParcelCount - DeliveredCount;
                
                // Try to get current user info from preferences or cache
                var username = Preferences.Get("CurrentUsername", string.Empty);
                if (!string.IsNullOrEmpty(username))
                {
                    var user = await _userService.GetUserByUsernameAsync(username);
                    if (user != null)
                    {
                        UserName = user.Username;
                        UserRole = user.Role?.Name ?? "User";
                    }
                }
                
                _logger.LogInformation($"Dashboard data loaded: {ParcelCount} parcels, {DeliveredCount} delivered, Ksh {TotalSales} sales");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading dashboard data");
                Debug.WriteLine($"Error loading dashboard data: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
} 