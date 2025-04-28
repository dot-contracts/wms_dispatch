using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;
using wms_android.shared.Models;
using wms_android.data.Interfaces;
using wms_android.Views;

namespace wms_android.ViewModels
{
    public partial class ClerkDashboardViewModel : ObservableObject
    {
        private readonly wms_android.data.Interfaces.IParcelService _parcelService;
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
        
        public ClerkDashboardViewModel(wms_android.data.Interfaces.IParcelService parcelService, ILogger<ClerkDashboardViewModel> logger)
        {
            _parcelService = parcelService;
            _logger = logger;
            _logger.LogInformation("ClerkDashboardViewModel initialized");
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