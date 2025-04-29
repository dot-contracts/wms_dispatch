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
        
        Task CreateCartParcels(List<Parcel> parcels);
        Task<decimal> GetTotalSalesForDateAsync(DateTime date);
        Task<IEnumerable<Parcel>> GetPendingOrdersAsync();
        Task<Parcel> GetParcelByWaybillNumberAsync(string waybillNumber);
        Task<Parcel> GetParcelByQRCodeAsync(string qrCode);
        Task<int> GetParcelCountForDateAsync(DateTime date);
        Task DispatchParcelAsync(Parcel parcel);
        Task UpdateParcelStatusAsync(Guid parcelId, ParcelStatus status);
        
        // Dashboard methods
        Task<int> GetParcelCountAsync(DateTime date);
        Task<int> GetDeliveredParcelCountAsync(DateTime date);
        Task<double> GetTotalSalesAsync(DateTime date);
    }
} 