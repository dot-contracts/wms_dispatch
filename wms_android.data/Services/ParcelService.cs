using wms_android.data.Data;
using Microsoft.EntityFrameworkCore;
using wms_android.data.Models;
using wms_android.data.Interfaces;

namespace wms_android.data.Services
{
    public class ParcelService: IParcelService
    {
        private readonly AppDbContext _context;
        private List<Parcel> _parcels = new List<Parcel>();

        public ParcelService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateParcelAsync(Parcel parcel)
        {
            parcel.WaybillNumber = await GenerateWaybillNumberAsync();
            parcel.QRCode = GenerateQRCode(parcel.WaybillNumber);
            parcel.CreatedAt = DateTime.UtcNow; // Ensure UTC
            parcel.Status = ParcelStatus.Pending;

            _context.Parcels.Add(parcel);
            await _context.SaveChangesAsync();
        }

        public async Task CreateCartParcels(List<Parcel> parcels)
        {
            foreach (var parcel in parcels)
            {
                // Set WaybillNumber for each parcel (assuming parcels already have WaybillNumber assigned)
                parcel.QRCode = GenerateQRCode(parcel.WaybillNumber);
                parcel.CreatedAt = DateTime.UtcNow; // Ensure UTC
                parcel.Status = ParcelStatus.Pending;

                // Add each parcel to the context
                _context.Parcels.Add(parcel);
            }

            // Save all parcels at once
            await _context.SaveChangesAsync();
        }


        //public Task CreateParcelAsync(Parcel parcel)
        //{
        //    if (parcel == null) throw new ArgumentNullException(nameof(parcel));
        //    _parcels.Add(parcel);
        //    return Task.CompletedTask;
        //}

        public async Task<List<Parcel>> GetAllParcelsAsync()
        {
            return await _context.Parcels.ToListAsync();
        }

        public async Task<Parcel> GetParcelByWaybillAsync(string waybillNumber)
        {
            return await _context.Parcels.FirstOrDefaultAsync(p => p.WaybillNumber == waybillNumber);
        }

        public async Task<Parcel> GetParcelByWaybillNumberAsync(string waybillNumber)
        {
            if (string.IsNullOrEmpty(waybillNumber))
            {
                throw new ArgumentException("Waybill number cannot be null or empty.", nameof(waybillNumber));
            }

            var parcel = await _context.Parcels
                .FirstOrDefaultAsync(p => p.WaybillNumber == waybillNumber);

            return parcel;
        }

        public async Task<Parcel> GetParcelByQRCodeAsync(string qrCode)
        {
            if (string.IsNullOrEmpty(qrCode))
            {
                throw new ArgumentException("QR code cannot be null or empty.", nameof(qrCode));
            }

            // Fetch the parcel from the database where the QR code matches
            var parcel = await _context.Parcels
                                       .FirstOrDefaultAsync(p => p.QRCode == qrCode);

            if (parcel == null)
            {
                // Handle the case where no parcel is found
                throw new Exception($"Parcel with QR code {qrCode} not found.");
            }

            return parcel;
        }


        public async Task DispatchParcelAsync(Parcel parcel)
        {
            if (parcel == null)
            {
                throw new ArgumentNullException(nameof(parcel), "Parcel cannot be null.");
            }

            // Update parcel status to InTransit and set the DispatchedAt timestamp
            parcel.Status = ParcelStatus.InTransit;
            parcel.DispatchedAt = DateTime.UtcNow;  // Ensure UTC

            // Update the parcel in the database
            _context.Parcels.Update(parcel);

            // Save the changes
            await _context.SaveChangesAsync();
        }



        public async Task DispatchParcelAsync(string waybillNumber)
        {
            var parcel = await GetParcelByWaybillAsync(waybillNumber);
            if (parcel != null)
            {
                parcel.DispatchTrackingCode = GenerateDispatchTrackingCode();
                parcel.DispatchedAt = DateTime.UtcNow; // Set to UTC
                await _context.SaveChangesAsync();
            }
        }

        //public string GenerateWaybillNumber()
        //{
        //    return "WB" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        //}
        public Task<string> GenerateWaybillNumberAsync()
        {
            // Generate a waybill number similar to GenerateWaybillNumber
            string waybillNumber = "WB" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            return Task.FromResult(waybillNumber);
        }

        private string GenerateQRCode(string waybillNumber)
        {
            // Implement QR code generation
            // For simplicity, we'll just return the waybill number
            return waybillNumber;
        }

        private string GenerateDispatchTrackingCode()
        {
            // Implement dispatch tracking code generation
            return "DT" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }

        public Task FinalizeWaybillAsync()
        {
            // Logic to finalize a waybill and process it
            return Task.CompletedTask;
        }

        public async Task<int> GetParcelCountForDateAsync(DateTime date)
        {
            return await _context.Parcels
                .CountAsync(p => p.CreatedAt.Date == date.Date);
        }

        public async Task<decimal> GetTotalSalesForDateAsync(DateTime date)
        {
            return await _context.Parcels
                .Where(p => p.CreatedAt.Date == date.Date)
                .SumAsync(p => p.Amount);
        }

        public async Task<IEnumerable<Parcel>> GetPendingOrdersAsync()
        {
            return await _context.Parcels
                .Where(p => p.Status == ParcelStatus.Pending)
                .OrderBy(p => p.CreatedAt)
                .ToListAsync();
        }
    }
}
