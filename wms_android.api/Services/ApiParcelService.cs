using Microsoft.EntityFrameworkCore;
using wms_android.shared.Data;
using wms_android.shared.Models;
using wms_android.shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace wms_android.api.Services
{
    public class ApiParcelService : IParcelService
    {
        private readonly AppDbContext _context;

        public ApiParcelService(AppDbContext context)
        {
            _context = context;
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
                System.Diagnostics.Debug.WriteLine($"CreatedById: {parcel.CreatedById}");

                // Check if parcel with this ID already exists
                var existingParcel = await _context.Parcels.FindAsync(parcel.Id);
                if (existingParcel != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Parcel with ID {parcel.Id} already exists, updating...");
                    
                    // Preserve the CreatedById if it's already set and we're getting null
                    if (existingParcel.CreatedById.HasValue && !parcel.CreatedById.HasValue)
                    {
                        parcel.CreatedById = existingParcel.CreatedById;
                        System.Diagnostics.Debug.WriteLine($"Preserved existing CreatedById: {parcel.CreatedById}");
                    }
                    
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
                    CreatedById = parcel.CreatedById,
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
                System.Diagnostics.Debug.WriteLine($"CreatedById before save: {newParcel.CreatedById}");
                
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
                System.Diagnostics.Debug.WriteLine($"CreatedById after save: {savedParcel.CreatedById}");

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
            var today = DateTime.UtcNow.Date;
            var count = await _context.Parcels.CountAsync(p => p.CreatedAt.Date == today);
            var waybillNumber = $"WB{today:yyyyMMdd}{(count + 1).ToString("D4")}";
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

        // Add parameterless version for interface compatibility (might not be used by API)
        public async Task FinalizeWaybillAsync()
        {
            // This version doesn't make sense in the API context without an ID.
            // Log a warning or throw if it's called unexpectedly.
            System.Diagnostics.Debug.WriteLine("WARN: Parameterless FinalizeWaybillAsync called in API service. This likely indicates a mismatch in client/server interaction logic.");
            // Optionally: throw new NotImplementedException("Parameterless FinalizeWaybillAsync is not supported in the API service.");
            await Task.CompletedTask; // Fulfill interface requirement
        }

        public async Task CreateCartParcels(List<Parcel> parcels)
        {
            try 
            {
                System.Diagnostics.Debug.WriteLine($"Starting CreateCartParcels with {parcels.Count} parcels");
                
                foreach (var parcel in parcels)
                {
                    // Set CreatedAt if not set
                    if (parcel.CreatedAt == default)
                    {
                        parcel.CreatedAt = DateTime.UtcNow;
                    }
                    
                    // Make sure the QR code is set
                    if (string.IsNullOrEmpty(parcel.QRCode))
                    {
                        parcel.QRCode = parcel.WaybillNumber;
                    }
                    
                    // Log CreatedById for debugging
                    System.Diagnostics.Debug.WriteLine($"Parcel {parcel.Id} with waybill {parcel.WaybillNumber} has CreatedById: {parcel.CreatedById}");
                    
                    // For safety, make sure Guid is set
                    if (parcel.Id == Guid.Empty)
                    {
                        parcel.Id = Guid.NewGuid();
                    }
                }
                
                _context.Parcels.AddRange(parcels);
                var result = await _context.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine($"Successfully saved {result} parcels");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CreateCartParcels: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
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
                existingParcel.Status = ParcelStatus.InTransit;
                existingParcel.DispatchedAt = DateTime.UtcNow;
                existingParcel.DispatchTrackingCode = parcel.DispatchTrackingCode;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateParcelStatusAsync(Guid parcelId, ParcelStatus status)
        {
            var parcel = await _context.Parcels.FindAsync(parcelId);
            
            if (parcel == null)
            {
                throw new Exception($"Parcel with ID {parcelId} not found");
            }
            
            parcel.Status = status;
            
            await _context.SaveChangesAsync();
        }

        // Add the missing dashboard methods
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
            var totalSales = await _context.Parcels
                .Where(p => p.CreatedAt.Date == date.Date)
                .SumAsync(p => (double)p.TotalAmount);
            
            return totalSales;
        }
    }
} 