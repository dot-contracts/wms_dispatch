using Microsoft.EntityFrameworkCore;
using wms_android.shared.Data;
using wms_android.shared.Models;
using wms_android.shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace wms_android.api.Services
{
    public class ApiParcelService : IParcelService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ApiParcelService> _logger;

        public ApiParcelService(AppDbContext context, ILogger<ApiParcelService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Parcel>> GetParcelsAsync()
        {
            return await _context.Parcels.ToListAsync();
        }

        public async Task<Parcel> GetParcelByIdAsync(Guid id)
        {
            return await _context.Parcels.FindAsync(id);
        }

        public async Task<Parcel> CreateParcelAsync(Parcel parcel)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Starting CreateParcelAsync with parcel: {JsonSerializer.Serialize(parcel)}");

                // Check if parcel with this ID already exists
                var existingParcel = await _context.Parcels.FindAsync(parcel.Id);
                if (existingParcel != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Parcel with ID {parcel.Id} already exists, updating...");
                    // Update existing parcel
                    _context.Entry(existingParcel).CurrentValues.SetValues(parcel);
                    await _context.SaveChangesAsync();
                    return existingParcel;
                }

                // Create new parcel with all data
                var newParcel = new Parcel
                {
                    Id = parcel.Id,
                    CreatedAt = parcel.CreatedAt,
                    WaybillNumber = parcel.WaybillNumber,
                    QRCode = parcel.QRCode,
                    DispatchedAt = parcel.DispatchedAt,
                    DispatchTrackingCode = parcel.DispatchTrackingCode,
                    Sender = parcel.Sender,
                    SenderTelephone = parcel.SenderTelephone,
                    Receiver = parcel.Receiver,
                    ReceiverTelephone = parcel.ReceiverTelephone,
                    Destination = parcel.Destination,
                    Quantity = parcel.Quantity,
                    Description = parcel.Description,
                    Amount = parcel.Amount,
                    Rate = parcel.Rate,
                    PaymentMethods = parcel.PaymentMethods,
                    TotalAmount = parcel.TotalAmount,
                    TotalRate = parcel.TotalRate,
                    Status = parcel.Status
                };

                // Only generate waybill number if not provided
                if (string.IsNullOrEmpty(newParcel.WaybillNumber))
                {
                    newParcel.WaybillNumber = await GenerateWaybillNumberAsync();
                }
                
                // Ensure QR code is set
                if (string.IsNullOrEmpty(newParcel.QRCode))
                {
                    newParcel.QRCode = newParcel.WaybillNumber;
                }

                // Ensure CreatedAt is set
                if (newParcel.CreatedAt == default)
                {
                    newParcel.CreatedAt = DateTime.UtcNow;
                }

                // Ensure Status is set
                if (newParcel.Status == 0)
                {
                    newParcel.Status = ParcelStatus.Pending;
                }

                // Add the new parcel to the context
                System.Diagnostics.Debug.WriteLine($"Adding new parcel to context with ID: {newParcel.Id}");
                System.Diagnostics.Debug.WriteLine($"Parcel data before save: {JsonSerializer.Serialize(newParcel)}");
                
                _context.Parcels.Add(newParcel);

                System.Diagnostics.Debug.WriteLine("Saving changes to database...");
                var result = await _context.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine($"SaveChangesAsync result: {result}");

                // Reload the parcel to ensure we have the latest data
                System.Diagnostics.Debug.WriteLine($"Reloading parcel with ID: {newParcel.Id}");
                var savedParcel = await _context.Parcels
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.Id == newParcel.Id);

                if (savedParcel == null)
                {
                    throw new Exception($"Failed to retrieve saved parcel with ID {newParcel.Id}");
                }

                System.Diagnostics.Debug.WriteLine($"Retrieved saved parcel: {JsonSerializer.Serialize(savedParcel)}");

                // Verify the saved parcel has the correct data
                if (savedParcel.WaybillNumber != newParcel.WaybillNumber ||
                    savedParcel.QRCode != newParcel.QRCode ||
                    savedParcel.Sender != newParcel.Sender ||
                    savedParcel.Receiver != newParcel.Receiver)
                {
                    throw new Exception($"Saved parcel data does not match input data. Saved: {JsonSerializer.Serialize(savedParcel)}");
                }

                System.Diagnostics.Debug.WriteLine($"Successfully saved parcel: {JsonSerializer.Serialize(savedParcel)}");
                return savedParcel;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CreateParcelAsync: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        public async Task<string> GenerateWaybillNumberAsync()
        {
            // Generate a waybill number with format WB followed by 5 random alphanumeric characters
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomChars = new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
                
            string waybillNumber = "WB" + randomChars;
            
            // Check if this waybill number already exists to avoid duplicates
            bool exists = await _context.Parcels.AnyAsync(p => p.WaybillNumber == waybillNumber);
            if (exists)
            {
                // If it exists, recursively try again
                return await GenerateWaybillNumberAsync();
            }
            
            return waybillNumber;
        }

        public async Task FinalizeWaybillAsync(Guid parcelId)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Starting FinalizeWaybillAsync for parcel ID: {parcelId}");

                // Find the parcel with tracking
                var parcel = await _context.Parcels
                    .FirstOrDefaultAsync(p => p.Id == parcelId);

                if (parcel == null)
                {
                    System.Diagnostics.Debug.WriteLine($"Parcel with ID {parcelId} not found");
                    throw new Exception($"Parcel with ID {parcelId} not found");
                }

                System.Diagnostics.Debug.WriteLine($"Found parcel: {JsonSerializer.Serialize(parcel)}");

                // Update the status
                parcel.Status = ParcelStatus.Finalized;

                System.Diagnostics.Debug.WriteLine("Saving changes to database...");
                var result = await _context.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine($"SaveChangesAsync result: {result}");

                // Verify the update
                var updatedParcel = await _context.Parcels
                    .FirstOrDefaultAsync(p => p.Id == parcelId);

                if (updatedParcel?.Status != ParcelStatus.Finalized)
                {
                    System.Diagnostics.Debug.WriteLine($"Failed to verify parcel finalization. Current status: {updatedParcel?.Status}");
                    throw new Exception($"Failed to finalize parcel with ID {parcelId}");
                }

                System.Diagnostics.Debug.WriteLine($"Successfully finalized parcel: {JsonSerializer.Serialize(updatedParcel)}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FinalizeWaybillAsync: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        public async Task CreateCartParcels(List<Parcel> parcels)
        {
            foreach (var parcel in parcels)
            {
                parcel.CreatedAt = DateTime.UtcNow;
            }
            _context.Parcels.AddRange(parcels);
            await _context.SaveChangesAsync();
        }

        public async Task<decimal> GetTotalSalesForDateAsync(DateTime date)
        {
            return await _context.Parcels
                .Where(p => p.CreatedAt.Date == date.Date)
                .SumAsync(p => p.TotalAmount);
        }

        public async Task<IEnumerable<Parcel>> GetPendingOrdersAsync()
        {
            return await _context.Parcels
                .Where(p => p.Status == ParcelStatus.Pending)
                .ToListAsync();
        }

        public async Task<Parcel> GetParcelByWaybillNumberAsync(string waybillNumber)
        {
            return await _context.Parcels
                .FirstOrDefaultAsync(p => p.WaybillNumber == waybillNumber);
        }

        public async Task<Parcel> GetParcelByQRCodeAsync(string qrCode)
        {
            return await _context.Parcels
                .FirstOrDefaultAsync(p => p.QRCode == qrCode);
        }

        public async Task<int> GetParcelCountForDateAsync(DateTime date)
        {
            return await _context.Parcels
                .CountAsync(p => p.CreatedAt.Date == date.Date);
        }

        public async Task DispatchParcelAsync(Parcel parcel)
        {
            var existingParcel = await _context.Parcels.FindAsync(parcel.Id);
            
            if (existingParcel != null)
            {
                existingParcel.DispatchedAt = DateTime.UtcNow;
                existingParcel.DispatchTrackingCode = parcel.DispatchTrackingCode;
                existingParcel.Status = ParcelStatus.InTransit;
                
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateParcelStatusAsync(Guid parcelId, ParcelStatus status)
        {
            _logger.LogInformation("ApiParcelService: Finding Parcel with ID: {ParcelId}", parcelId);
            var parcel = await _context.Parcels.FindAsync(parcelId);
            
            if (parcel == null)
            {
                _logger.LogWarning("ApiParcelService: Parcel with ID {ParcelId} not found for status update.", parcelId);
                throw new Exception($"Parcel with ID {parcelId} not found");
            }
            
            _logger.LogInformation("ApiParcelService: Found Parcel ID: {ParcelId}. Current Status: {CurrentStatus}. Setting status to: {NewStatus}", parcelId, parcel.Status, status);
            parcel.Status = status;
            
            try
            {
                 _logger.LogInformation("ApiParcelService: Calling SaveChangesAsync for Parcel ID: {ParcelId}", parcelId);
                var changes = await _context.SaveChangesAsync();
                _logger.LogInformation("ApiParcelService: SaveChangesAsync completed for Parcel ID: {ParcelId}. Records affected: {Count}", parcelId, changes);
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError(dbEx, "ApiParcelService: Database error saving status for Parcel ID: {ParcelId}. Error: {ErrorMessage}", parcelId, dbEx.Message);
                // Log inner exception if available
                if (dbEx.InnerException != null)
                {
                    _logger.LogError(dbEx.InnerException, "ApiParcelService: Inner DB Exception for Parcel ID {ParcelId}: {InnerErrorMessage}", parcelId, dbEx.InnerException.Message);
                }
                throw; // Re-throw the original exception
            }
             catch (Exception ex)
            {
                _logger.LogError(ex, "ApiParcelService: Generic error saving status for Parcel ID: {ParcelId}. Error: {ErrorMessage}", parcelId, ex.Message);
                throw; // Re-throw the original exception
            }
        }
    }
} 