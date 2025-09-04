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
        private double _amountOwed;

        [ObservableProperty]
        private double _cashIn;

        [ObservableProperty]
        private double _dailySales;

        [ObservableProperty]
        private double _monthlySales;

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
            
            // Default values - show a more friendly loading message
            UserName = "User";
            UserRole = "";
        }

        [RelayCommand]
        private async Task NavigateToDelivery()
        {
            _logger.LogInformation("Navigate to delivery view");
            await Shell.Current.GoToAsync(nameof(DeliveryView));
        }

        [RelayCommand]
        private async Task NavigateToViewAllParcels()
        {
            _logger.LogInformation("Navigate to view all parcels");
            await Shell.Current.GoToAsync(nameof(AllParcelsView));
        }

        [RelayCommand]
        private async Task NavigateToAddParcel()
        {
            _logger.LogInformation("Navigate to collect parcel");
            await Shell.Current.GoToAsync(nameof(ParcelsView));
        }

        [RelayCommand]
        private async Task GenerateReport()
        {
            _logger.LogInformation("Generate report");
            await Shell.Current.GoToAsync(nameof(ReportView));
        }

        public async Task LoadDashboardData()
        {
            try
            {
                IsLoading = true;
                
                // Get today's date
                var today = DateTime.Today;
                
                // Get current user ID
                var currentUserId = Preferences.Get("CurrentUserId", 0);
                if (currentUserId == 0)
                {
                    _logger.LogWarning("No current user ID found for dashboard metrics");
                    return;
                }
                
                // Get user-specific metrics for today
                AmountOwed = await _parcelService.GetAmountOwedByUserAsync(currentUserId, today);
                CashIn = await _parcelService.GetCashInByUserAsync(currentUserId, today);
                DailySales = await _parcelService.GetDailySalesByUserAsync(currentUserId, today);
                MonthlySales = await _parcelService.GetMonthlySalesByUserAsync(currentUserId, today);
                
                // Try to get current user info from preferences or cache
                var username = Preferences.Get("CurrentUsername", string.Empty);
                if (!string.IsNullOrEmpty(username))
                {
                    var user = await _userService.GetUserByUsernameAsync(username);
                    if (user != null)
                    {
                        // Use FirstName if available, fallback to Username if FirstName is null/empty
                        UserName = !string.IsNullOrWhiteSpace(user.FirstName) ? user.FirstName : user.Username;
                        UserRole = user.Role?.Name ?? "User";
                    }
                }
                
                _logger.LogInformation($"Dashboard data loaded for user {currentUserId}: Amount Owed: Ksh {AmountOwed:N2}, Cash-in: Ksh {CashIn:N2}, Daily Sales: Ksh {DailySales:N2}, Monthly Sales: Ksh {MonthlySales:N2}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading dashboard data");
                Debug.WriteLine($"Error loading dashboard data: {ex.Message}");
                
                // Ensure we have a fallback name even if there's an error
                if (string.IsNullOrWhiteSpace(UserName) || UserName == "User")
                {
                    UserName = "User";
                }
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
} 