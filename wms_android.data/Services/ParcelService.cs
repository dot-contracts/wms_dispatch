using System;
using System.Collections.Generic;
using wms_android.shared.Models;
using wms_android.shared.Data;
using Microsoft.EntityFrameworkCore;
using wms_android.data.Interfaces;
using System.Net.NetworkInformation;
using System.Linq;
using System.Threading.Tasks;

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

        /// <summary>
        /// Checks if the database is accessible
        /// </summary>
        /// <returns>True if connected, false otherwise</returns>
        public async Task<bool> CheckDatabaseConnectionAsync()
        {
            try
            {
                // Try a simple query to test database connectivity
                await _context.Database.CanConnectAsync();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database connection failed: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Checks if network connectivity is available
        /// </summary>
        /// <returns>True if network is available, false otherwise</returns>
        public bool IsNetworkAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var result = ping.Send("8.8.8.8", 3000); // Google's DNS server
                    return result?.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task CreateParcelAsync(Parcel parcel)
        {
            // Check connectivity before attempting database operations
            if (!await CheckDatabaseConnectionAsync())
            {
                throw new InvalidOperationException("Cannot connect to the database. Please check your network connection and try again.");
            }

            parcel.WaybillNumber = await GenerateWaybillNumberAsync();
            parcel.QRCode = GenerateQRCode(parcel.WaybillNumber);
            parcel.CreatedAt = DateTime.UtcNow; // Ensure UTC
            parcel.Status = ParcelStatus.Pending;

            _context.Parcels.Add(parcel);
            await _context.SaveChangesAsync();
        }

        public async Task CreateCartParcels(List<Parcel> parcels)
        {
            // Check connectivity before attempting database operations
            if (!await CheckDatabaseConnectionAsync())
            {
                throw new InvalidOperationException("Cannot connect to the database. Please check your network connection and try again.");
            }

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
            // Generate a waybill number with format WB followed by 5 random alphanumeric characters
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomChars = new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
                
            string waybillNumber = "WB" + randomChars;
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
        
        // Implementation of new dashboard methods
        
        /// <summary>
        /// Gets the total count of parcels in the system
        /// </summary>
        /// <returns>Total parcel count</returns>
        public async Task<int> GetParcelCountAsync()
        {
            try
            {
                return await _context.Parcels.CountAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting parcel count: {ex.Message}");
                return 0;
            }
        }
        
        /// <summary>
        /// Gets the total sales amount across all parcels
        /// </summary>
        /// <returns>Total sales amount</returns>
        public async Task<decimal> GetTotalSalesAsync()
        {
            try
            {
                return await _context.Parcels.SumAsync(p => p.Amount);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting total sales: {ex.Message}");
                return 0;
            }
        }
        
        /// <summary>
        /// Gets all pending parcels
        /// </summary>
        /// <returns>Collection of pending parcels</returns>
        public async Task<IEnumerable<Parcel>> GetPendingParcelsAsync()
        {
            return await _context.Parcels
                .Where(p => p.Status == ParcelStatus.Pending)
                .ToListAsync();
        }

        // Dashboard methods implementation
        public async Task<int> GetParcelCountAsync(DateTime date)
        {
            return await _context.Parcels
                .Where(p => p.CreatedAt.Date == date.Date)
                .CountAsync();
        }
        
        public async Task<int> GetDeliveredParcelCountAsync(DateTime date)
        {
            return await _context.Parcels
                .Where(p => p.CreatedAt.Date == date.Date && p.Status == ParcelStatus.Delivered)
                .CountAsync();
        }
        
        public async Task<double> GetTotalSalesAsync(DateTime date)
        {
            var total = await _context.Parcels
                .Where(p => p.CreatedAt.Date == date.Date)
                .SumAsync(p => p.Amount);
                
            return (double)total;
        }
    }
}
