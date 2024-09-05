using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wms_android.data.Data;
using Microsoft.EntityFrameworkCore;
using wms_android.data.Models;

namespace wms_android.data.Services
{
    public class ParcelService
    {
        private readonly AppDbContext _context;

        public ParcelService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Parcel> CreateParcelAsync(Parcel parcel)
        {
            parcel.WaybillNumber = GenerateWaybillNumber();
            parcel.QRCode = GenerateQRCode(parcel.WaybillNumber);
            parcel.CreatedAt = DateTime.UtcNow; // Ensure UTC
            parcel.Status = ParcelStatus.Pending;

            _context.Parcels.Add(parcel);
            await _context.SaveChangesAsync();
            return parcel;
        }

        public async Task<List<Parcel>> GetAllParcelsAsync()
        {
            return await _context.Parcels.ToListAsync();
        }

        public async Task<Parcel> GetParcelByWaybillAsync(string waybillNumber)
        {
            return await _context.Parcels.FirstOrDefaultAsync(p => p.WaybillNumber == waybillNumber);
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

        private string GenerateWaybillNumber()
        {
            return "WB" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
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
    }
}
