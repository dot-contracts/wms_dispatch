using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wms_android.data.Models;

namespace wms_android.data.Interfaces
{
    public interface IParcelService
    {
        Task<bool> CheckDatabaseConnectionAsync();
        bool IsNetworkAvailable();
        Task CreateParcelAsync(Parcel parcel);
        Task<string> GenerateWaybillNumberAsync();
        Task FinalizeWaybillAsync();
        Task CreateCartParcels(List<Parcel> parcels);
        Task<Parcel> GetParcelByWaybillNumberAsync(string waybillNumber);
        Task<Parcel> GetParcelByQRCodeAsync(string qrCode);
        Task DispatchParcelAsync(Parcel parcel);

        Task<int> GetParcelCountForDateAsync(DateTime date);
        Task<decimal> GetTotalSalesForDateAsync(DateTime date);
        Task<IEnumerable<Parcel>> GetPendingOrdersAsync();
        
        // New methods for dashboard
        Task<int> GetParcelCountAsync();
        Task<decimal> GetTotalSalesAsync();
        Task<IEnumerable<Parcel>> GetPendingParcelsAsync();
    }
}
