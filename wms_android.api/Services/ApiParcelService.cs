using Microsoft.EntityFrameworkCore;
using wms_android.shared.Data;
using wms_android.shared.Models;
using wms_android.shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Npgsql; // Added for PostgresException

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

        public async Task<Parcel> CreateParcelAsync(Parcel parcelInitialState)
        {
            // Create a mutable copy to work with, ensuring Id is set if empty.
            Parcel parcelToProcess = new Parcel
            {
                Id = parcelInitialState.Id == Guid.Empty ? Guid.NewGuid() : parcelInitialState.Id,
                CreatedAt = parcelInitialState.CreatedAt,
                WaybillNumber = parcelInitialState.WaybillNumber,
                QRCode = parcelInitialState.QRCode,
                DispatchedAt = parcelInitialState.DispatchedAt,
                DispatchTrackingCode = parcelInitialState.DispatchTrackingCode,
                CreatedById = parcelInitialState.CreatedById,
                CreatorLastNameSnapshot = parcelInitialState.CreatorLastNameSnapshot, // Will be overwritten if CreatedById is present
                Sender = parcelInitialState.Sender,
                SenderTelephone = parcelInitialState.SenderTelephone,
                Receiver = parcelInitialState.Receiver,
                ReceiverTelephone = parcelInitialState.ReceiverTelephone,
                Destination = parcelInitialState.Destination,
                Quantity = parcelInitialState.Quantity,
                Description = parcelInitialState.Description,
                Amount = parcelInitialState.Amount,
                Rate = parcelInitialState.Rate,
                PaymentMethods = parcelInitialState.PaymentMethods,
                TotalAmount = parcelInitialState.TotalAmount,
                TotalRate = parcelInitialState.TotalRate,
                Status = parcelInitialState.Status
            };

            System.Diagnostics.Debug.WriteLine($"Starting CreateParcelAsync. Initial Parcel ID: {parcelInitialState.Id}, Process ID: {parcelToProcess.Id}");

            // Populate CreatorLastNameSnapshot
            if (parcelToProcess.CreatedById.HasValue)
            {
                var user = await _context.Users.FindAsync(parcelToProcess.CreatedById.Value);
                if (user != null)
                {
                    parcelToProcess.CreatorLastNameSnapshot = user.LastName;
                    System.Diagnostics.Debug.WriteLine($"Populated CreatorLastNameSnapshot: {user.LastName} for User ID: {parcelToProcess.CreatedById.Value}");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"User with ID {parcelToProcess.CreatedById.Value} not found. CreatorLastNameSnapshot will be '{parcelToProcess.CreatorLastNameSnapshot}'.");
                }
            }

            bool waybillGeneratedByServer = false;
            if (string.IsNullOrEmpty(parcelToProcess.WaybillNumber))
            {
                parcelToProcess.WaybillNumber = await GeneratePotentiallyNonUniqueWaybillNumberAsync();
                waybillGeneratedByServer = true;
                System.Diagnostics.Debug.WriteLine($"Server generated initial WaybillNumber: {parcelToProcess.WaybillNumber}");
            }
            // Ensure QR code is set, typically same as waybill
            if (string.IsNullOrEmpty(parcelToProcess.QRCode))
            {
                parcelToProcess.QRCode = parcelToProcess.WaybillNumber;
            }

            // Ensure CreatedAt is set to UTC Now if not provided
            if (parcelToProcess.CreatedAt == default)
            {
                parcelToProcess.CreatedAt = DateTime.UtcNow;
            }
            // Ensure Status is set to Pending if not provided (or is default enum 0)
            if (parcelToProcess.Status == 0) 
            {
                parcelToProcess.Status = ParcelStatus.Pending;
            }

            int maxRetries = 5;
            for (int attempt = 0; attempt < maxRetries; attempt++)
            {
                try
                {
                    if (attempt > 0 && waybillGeneratedByServer)
                    {
                        System.Diagnostics.Debug.WriteLine($"Retrying waybill generation. Attempt: {attempt + 1}");
                        parcelToProcess.WaybillNumber = await GeneratePotentiallyNonUniqueWaybillNumberAsync(attempt); // Pass attempt as offset
                        parcelToProcess.QRCode = parcelToProcess.WaybillNumber;
                        System.Diagnostics.Debug.WriteLine($"Server regenerated WaybillNumber: {parcelToProcess.WaybillNumber}");
                    }

                    // Detach the instance if it was tracked from a previous failed attempt
                    var existingEntry = _context.ChangeTracker.Entries<Parcel>().FirstOrDefault(e => e.Entity.Id == parcelToProcess.Id);
                    if (existingEntry != null)
                    {
                        existingEntry.State = EntityState.Detached;
                        System.Diagnostics.Debug.WriteLine($"Detached existing tracked entity for Parcel ID: {parcelToProcess.Id} before attempt {attempt + 1}");
                    }
                    
                    // Determine if it's an update or insert based on ID existing *in database*
                    var parcelInDb = await _context.Parcels.AsNoTracking().FirstOrDefaultAsync(p => p.Id == parcelToProcess.Id);

                    if (parcelInDb != null)
                    {
                        System.Diagnostics.Debug.WriteLine($"Parcel with ID {parcelToProcess.Id} found in DB. Attempting to update. (Attempt {attempt + 1})");
                        _context.Parcels.Update(parcelToProcess);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Parcel with ID {parcelToProcess.Id} not in DB. Attempting to add. (Attempt {attempt + 1})");
                         // If Id was Guid.Empty initially, it should have been set by Guid.NewGuid()
                        _context.Parcels.Add(parcelToProcess);
                    }

                    System.Diagnostics.Debug.WriteLine($"Parcel data before SaveChanges (Attempt {attempt + 1}): {JsonSerializer.Serialize(parcelToProcess)}");
                    await _context.SaveChangesAsync();
                    System.Diagnostics.Debug.WriteLine($"Successfully saved/updated parcel ID: {parcelToProcess.Id} on attempt {attempt + 1}");
                    
                    // Return the successfully saved entity. It's already tracked by the context.
                    return parcelToProcess; 
                }
                catch (DbUpdateException ex) when (IsUniqueConstraintViolation(ex))
                {
                    System.Diagnostics.Debug.WriteLine($"Unique constraint violation for WaybillNumber: {parcelToProcess.WaybillNumber}. (Attempt {attempt + 1} of {maxRetries})");

                    if (!waybillGeneratedByServer)
                    {
                        System.Diagnostics.Debug.WriteLine($"WaybillNumber {parcelToProcess.WaybillNumber} was client-provided and is a duplicate. Failing fast.");
                        throw new InvalidOperationException($"Waybill number {parcelToProcess.WaybillNumber} already exists and was client-provided.", ex);
                    }

                    if (attempt == maxRetries - 1)
                    {
                        System.Diagnostics.Debug.WriteLine("Max retries reached for generating unique waybill number due to unique constraint violation.");
                        throw; // Max retries reached, rethrow the last exception
                    }
                    // Loop will continue for another attempt, regenerating waybill if server-generated.
                    // Detaching is handled at the start of the try block now.
            }
            catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Non-DbUpdateException in CreateParcelAsync (Attempt {attempt + 1}): {ex.GetType().Name} - {ex.Message}");
                    if (ex.InnerException != null) System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                    throw; // Rethrow other exceptions immediately
                }
            }
            // This part should ideally not be reached if retry logic is correct and exceptions are rethrown.
            throw new Exception("Failed to create parcel after multiple attempts due to persistent errors. This indicates a problem in the retry loop.");
        }

        // Renamed and added attemptOffset
        public async Task<string> GeneratePotentiallyNonUniqueWaybillNumberAsync(int attemptOffset = 0)
        {
            var today = DateTime.UtcNow.Date;
            var count = await _context.Parcels.CountAsync(p => p.CreatedAt.Date == today && p.WaybillNumber != null);
            var waybillNumber = $"WB{today:yyyyMMdd}{(count + 1 + attemptOffset).ToString("D4")}";
            System.Diagnostics.Debug.WriteLine($"Generated potential WaybillNumber: {waybillNumber} (Attempt offset: {attemptOffset})");
            return waybillNumber;
        }

        // Original GenerateWaybillNumberAsync - now points to the new one for compatibility
        public async Task<string> GenerateWaybillNumberAsync()
        {
            return await GeneratePotentiallyNonUniqueWaybillNumberAsync();
        }

        private bool IsUniqueConstraintViolation(DbUpdateException ex)
        {
            if (ex.InnerException is Npgsql.PostgresException postgresException)
            {
                return postgresException.SqlState == "23505"; // "unique_violation"
            }
            return false;
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

        public async Task FinalizeWaybillAsync()
        {
            // Implement logic if needed, or leave empty if only the Guid version is used server-side.
            await Task.CompletedTask; // Placeholder
        }

        public async Task<List<Parcel>> CreateCartParcels(List<Parcel> parcels)
        {
            if (parcels == null || !parcels.Any())
            {
                return new List<Parcel>();
            }

            var commonWaybill = parcels.FirstOrDefault()?.WaybillNumber;

            if (string.IsNullOrEmpty(commonWaybill))
            {
                System.Diagnostics.Debug.WriteLine("[CreateCartParcels] Error: Batch received with no common WaybillNumber.");
                throw new ArgumentException("Parcels in cart must have a common WaybillNumber assigned by the client.");
            }
            System.Diagnostics.Debug.WriteLine($"[CreateCartParcels] Processing batch with commonWaybill: {commonWaybill}");

            var processedParcels = new List<Parcel>();
            int? commonCreatedById = parcels.FirstOrDefault()?.CreatedById;

            foreach (var parcelInput in parcels)
            {
                Parcel parcelToProcess = parcelInput;
                parcelToProcess.WaybillNumber = commonWaybill;

                if (parcelToProcess.Id == Guid.Empty)
                {
                    parcelToProcess.Id = Guid.NewGuid();
                }
                if (string.IsNullOrEmpty(parcelToProcess.QRCode))
                {
                    parcelToProcess.QRCode = parcelToProcess.WaybillNumber;
                }
                if (parcelToProcess.CreatedAt == default)
                {
                    parcelToProcess.CreatedAt = DateTime.UtcNow;
                }
                if (parcelToProcess.Status == 0)
                {
                    parcelToProcess.Status = ParcelStatus.Pending;
                }

                if (!parcelToProcess.CreatedById.HasValue && commonCreatedById.HasValue)
                {
                    parcelToProcess.CreatedById = commonCreatedById;
                }

                if (parcelToProcess.CreatedById.HasValue && string.IsNullOrEmpty(parcelToProcess.CreatorLastNameSnapshot))
                {
                    var user = await _context.Users.FindAsync(parcelToProcess.CreatedById.Value);
                    if (user != null)
                    {
                        parcelToProcess.CreatorLastNameSnapshot = user.LastName;
                    }
                }
                
                _context.Parcels.Add(parcelToProcess);
                processedParcels.Add(parcelToProcess);
            }

            try
            {
                await _context.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine($"[CreateCartParcels] Successfully saved {processedParcels.Count} parcels with Waybill: {commonWaybill}.");
                return processedParcels;
            }
            catch (DbUpdateException dbEx) when (IsUniqueConstraintViolation(dbEx))
            {
                System.Diagnostics.Debug.WriteLine($"[CreateCartParcels] DbUpdateException: Unique constraint violation for common WaybillNumber: {commonWaybill}. Error: {dbEx.Message}");
                if (dbEx.InnerException != null) System.Diagnostics.Debug.WriteLine($"[CreateCartParcels] Inner Exception: {dbEx.InnerException.Message}");
                throw new InvalidOperationException($"The common WaybillNumber '{commonWaybill}' for the cart already exists. Please try generating a new waybill for the cart.", dbEx);
            }
            catch (DbUpdateException dbEx)
            {
                System.Diagnostics.Debug.WriteLine($"[CreateCartParcels] DbUpdateException (non-unique waybill): {dbEx.Message}");
                if (dbEx.InnerException != null) System.Diagnostics.Debug.WriteLine($"[CreateCartParcels] Inner Exception: {dbEx.InnerException.Message}");
                throw;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[CreateCartParcels] General Exception: {ex.Message}");
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

        // Placeholder implementation - assumes Parcel has an IsSmsSent property
        public async Task<bool> CheckSmsNotificationSentAsync(Guid parcelId)
        {
            var parcel = await _context.Parcels.FindAsync(parcelId);
            // return parcel?.IsSmsSent ?? false; // Requires IsSmsSent property on Parcel model
            return await Task.FromResult(false); // Temporary return until IsSmsSent is added
        }

        // Placeholder implementation - assumes Parcel has an IsSmsSent property
        public async Task MarkSmsNotificationSentAsync(Guid parcelId)
        {
            var parcel = await _context.Parcels.FindAsync(parcelId);
            if (parcel != null)
            {
                // parcel.IsSmsSent = true; // Requires IsSmsSent property on Parcel model
                // _context.Parcels.Update(parcel);
                // await _context.SaveChangesAsync();
            }
            await Task.CompletedTask; // Temporary return until IsSmsSent is added
        }
    }
} 