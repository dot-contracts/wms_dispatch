using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wms_android.shared.Models;

namespace wms_android.shared.Interfaces
{
    public interface IParcelService
    {
        Task<Parcel> CreateParcelAsync(Parcel parcel);
        Task<string> GenerateWaybillNumberAsync();
        Task FinalizeWaybillAsync(Guid parcelId);
        Task CreateCartParcels(List<Parcel> parcels);
        Task<Parcel> GetParcelByWaybillNumberAsync(string waybillNumber);
        Task<Parcel> GetParcelByQRCodeAsync(string qrCode);
        Task DispatchParcelAsync(Parcel parcel);
        Task UpdateParcelStatusAsync(Guid parcelId, ParcelStatus status);

        Task<int> GetParcelCountForDateAsync(DateTime date);
        Task<decimal> GetTotalSalesForDateAsync(DateTime date);
        Task<IEnumerable<Parcel>> GetPendingOrdersAsync();
        Task<IEnumerable<Parcel>> GetParcelsAsync();
        Task<Parcel> GetParcelByIdAsync(Guid id);
    }
}
