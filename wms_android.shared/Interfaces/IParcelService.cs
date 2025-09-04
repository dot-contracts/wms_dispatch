using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using wms_android.shared.Models;

namespace wms_android.shared.Interfaces
{
    public interface IParcelService
    {
        Task<IEnumerable<Parcel>> GetParcelsAsync();
        Task<Parcel> GetParcelByIdAsync(Guid id);
        Task<Parcel> CreateParcelAsync(Parcel parcel);
        Task<string> GenerateWaybillNumberAsync();
        Task FinalizeWaybillAsync(Guid parcelId);
        
        // Add an overload that doesn't require the parcelId (implements compatibility with data version)
        Task FinalizeWaybillAsync();
        
        Task<List<Parcel>> CreateCartParcels(List<Parcel> parcels);
        Task<decimal> GetTotalSalesForDateAsync(DateTime date);
        Task<IEnumerable<Parcel>> GetPendingOrdersAsync(DateTime? dateFilter = null);
        Task<Parcel> GetParcelByWaybillNumberAsync(string waybillNumber);
        Task<IEnumerable<Parcel>> GetParcelsByQRCodeAsync(string qrCode);
        Task<int> GetParcelCountForDateAsync(DateTime date);
        Task DispatchParcelAsync(Parcel parcel);
        Task UpdateParcelStatusAsync(Guid parcelId, ParcelStatus status);
        
        // Dashboard methods
        Task<int> GetParcelCountAsync(DateTime date);
        Task<int> GetDeliveredParcelCountAsync(DateTime date);
        Task<double> GetTotalSalesAsync(DateTime date);
        
        // SMS notification tracking
        Task<bool> CheckSmsNotificationSentAsync(Guid parcelId);
        Task MarkSmsNotificationSentAsync(Guid parcelId);
        
        // User-specific parcels
        Task<IEnumerable<Parcel>> GetParcelsByUserAsync(int userId);
        
        // User-specific dashboard metrics
        Task<double> GetAmountOwedByUserAsync(int userId, DateTime date);
        Task<double> GetCashInByUserAsync(int userId, DateTime date);
        Task<double> GetDailySalesByUserAsync(int userId, DateTime date);
        Task<double> GetMonthlySalesByUserAsync(int userId, DateTime date);
    }
} 