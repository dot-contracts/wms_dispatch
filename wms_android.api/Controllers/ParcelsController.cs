using Microsoft.AspNetCore.Mvc;
using wms_android.shared.Models;
using wms_android.shared.Interfaces;
using wms_android.shared.Services;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using wms_android.shared.Data;

namespace wms_android.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParcelsController : ControllerBase
    {
        private readonly IParcelService _parcelService;
        private readonly AppDbContext _context;

        public ParcelsController(IParcelService parcelService, AppDbContext context)
        {
            _parcelService = parcelService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetParcels([FromQuery] string branchName = null)
        {
            try
            {
                var query = _context.Parcels.AsQueryable();
                
                // If branchName is provided, filter by destination column
                if (!string.IsNullOrEmpty(branchName))
                {
                    query = query.Where(p => p.Destination == branchName);
                }
                
                var parcels = await query.ToListAsync();
                return Ok(parcels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("waybill/generate")]
        public async Task<ActionResult<string>> GenerateWaybill()
        {
            try
            {
                // Log the request
                System.Diagnostics.Debug.WriteLine("Generating waybill number...");
                
                // Call the service to generate waybill number
                var waybillNumber = await _parcelService.GenerateWaybillNumberAsync();
                
                // Log the generated number
                System.Diagnostics.Debug.WriteLine($"Successfully generated waybill number: {waybillNumber}");
                
                // Return as a simple string value
                return Ok(waybillNumber);
            }
            catch (Exception ex)
            {
                var errorMessage = $"Error generating waybill: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $" Inner exception: {ex.InnerException.Message}";
                }
                System.Diagnostics.Debug.WriteLine(errorMessage);
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                
                return StatusCode(500, new { 
                    error = "Failed to generate waybill number", 
                    message = ex.Message,
                    innerException = ex.InnerException?.Message,
                    stackTrace = ex.StackTrace 
                });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Parcel>> GetParcel(Guid id)
        {
            var parcel = await _parcelService.GetParcelByIdAsync(id);
            return Ok(parcel);
        }

        [HttpGet("waybill/{waybillNumber}")]
        public async Task<ActionResult<Parcel>> GetParcelByWaybill(string waybillNumber)
        {
            var parcel = await _parcelService.GetParcelByWaybillNumberAsync(waybillNumber);
            return Ok(parcel);
        }

        [HttpGet("qr/{qrCode}")]
        public async Task<ActionResult<IEnumerable<Parcel>>> GetParcelsByQRCode(string qrCode)
        {
            var parcels = await _parcelService.GetParcelsByQRCodeAsync(qrCode);
            return Ok(parcels);
        }

        [HttpGet("pending")]
        public async Task<ActionResult<IEnumerable<Parcel>>> GetPendingOrders([FromQuery] string? branchName)
        {
            var parcelsQuery = _parcelService.GetPendingOrdersAsync().Result.AsQueryable();
            
            if (!string.IsNullOrEmpty(branchName))
            {
                var userIdsInBranch = await (from ub in _context.UserBranches
                                             join b in _context.Branches on ub.BranchId equals b.Id
                                             where b.Name == branchName
                                             select ub.UserId).ToListAsync();
                
                parcelsQuery = parcelsQuery.Where(p => p.CreatedById.HasValue && userIdsInBranch.Contains(p.CreatedById.Value));
            }

            var parcels = parcelsQuery.ToList();
            return Ok(parcels);
        }

        [HttpGet("count")]
        public async Task<ActionResult<object>> GetParcelCount([FromQuery] DateTime date, [FromQuery] string? branchName)
        {
            var parcelsQuery = _context.Parcels.Where(p => p.CreatedAt.Date == date.Date);

            if (!string.IsNullOrEmpty(branchName))
            {
                var userIdsInBranch = await (from ub in _context.UserBranches
                                             join b in _context.Branches on ub.BranchId equals b.Id
                                             where b.Name == branchName
                                             select ub.UserId).ToListAsync();
                
                parcelsQuery = parcelsQuery.Where(p => p.CreatedById.HasValue && userIdsInBranch.Contains(p.CreatedById.Value));
            }

            var count = await parcelsQuery.CountAsync();
            return Ok(new { count });
        }

        [HttpGet("sales")]
        public async Task<ActionResult<object>> GetTotalSales([FromQuery] DateTime date, [FromQuery] string? branchName)
        {
            var parcelsQuery = _context.Parcels.Where(p => p.CreatedAt.Date == date.Date);

            if (!string.IsNullOrEmpty(branchName))
            {
                var userIdsInBranch = await (from ub in _context.UserBranches
                                             join b in _context.Branches on ub.BranchId equals b.Id
                                             where b.Name == branchName
                                             select ub.UserId).ToListAsync();

                parcelsQuery = parcelsQuery.Where(p => p.CreatedById.HasValue && userIdsInBranch.Contains(p.CreatedById.Value));
            }

            var total = await parcelsQuery.SumAsync(p => p.TotalAmount);
            return Ok(new { totalSales = total });
        }

        [HttpPost]
        public async Task<ActionResult<Parcel>> CreateParcel([FromBody] Parcel parcel)
        {
            try
            {
                // Log incoming parcel
                System.Diagnostics.Debug.WriteLine($"Received parcel: {JsonConvert.SerializeObject(parcel)}");

                // Only generate waybill number if not provided
                if (string.IsNullOrEmpty(parcel.WaybillNumber))
                {
                    parcel.WaybillNumber = await _parcelService.GenerateWaybillNumberAsync();
                    parcel.QRCode = parcel.WaybillNumber; // Set QR code to be the same as waybill number
                }

                // Log after generation
                System.Diagnostics.Debug.WriteLine($"Using WaybillNumber: {parcel.WaybillNumber}");

                var validationErrors = ValidateParcel(parcel);
                if (validationErrors.Any())
                {
                    return BadRequest(new { Errors = validationErrors });
                }

                // Ensure CreatedAt is set
                parcel.CreatedAt = DateTime.UtcNow;
                
                // Ensure Status is set
                if (parcel.Status == 0)
                {
                    parcel.Status = ParcelStatus.Pending;
                }

                // Note: CreatedById is now part of the Parcel model and should be passed in the request
                // If it's not set, it will be null in the database, which is allowed

                var created = await _parcelService.CreateParcelAsync(parcel);
                
                if (created == null)
                {
                    throw new Exception("Failed to create parcel - service returned null");
                }

                // Log created parcel
                System.Diagnostics.Debug.WriteLine($"Created parcel: {JsonConvert.SerializeObject(created)}");
                
                return CreatedAtAction(nameof(GetParcel), new { id = created.Id }, created);
            }
            catch (Exception ex)
            {
                var errorMessage = $"Error creating parcel: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $" Inner exception: {ex.InnerException.Message}";
                }
                System.Diagnostics.Debug.WriteLine(errorMessage);
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                
                return StatusCode(500, new { 
                    error = "Internal server error", 
                    message = ex.Message,
                    innerException = ex.InnerException?.Message,
                    stackTrace = ex.StackTrace 
                });
            }
        }

        private List<string> ValidateParcel(Parcel parcel)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(parcel.Sender))
                errors.Add("Sender is required");
            if (string.IsNullOrWhiteSpace(parcel.SenderTelephone))
                errors.Add("Sender telephone is required");
            if (string.IsNullOrWhiteSpace(parcel.Receiver))
                errors.Add("Receiver is required");
            if (string.IsNullOrWhiteSpace(parcel.ReceiverTelephone))
                errors.Add("Receiver telephone is required");
            if (string.IsNullOrWhiteSpace(parcel.Destination))
                errors.Add("Destination is required");
            if (string.IsNullOrWhiteSpace(parcel.PaymentMethods))
                errors.Add("Payment method is required");

            return errors;
        }

        [HttpPost("batch")]
        public async Task<ActionResult<List<Parcel>>> CreateCartParcels([FromBody] List<Parcel> parcels)
        {
            List<Parcel> createdParcels = await _parcelService.CreateCartParcels(parcels);
            return Ok(createdParcels);
        }

        [HttpPost("{id}/finalize")]
        public async Task<ActionResult> FinalizeWaybill(Guid id)
        {
            await _parcelService.FinalizeWaybillAsync(id);
            return Ok();
        }

        [HttpPost("{id}/dispatch")]
        public async Task<ActionResult> DispatchParcel(Guid id, Parcel parcel)
        {
            await _parcelService.DispatchParcelAsync(parcel);
            return Ok();
        }

        [HttpPut("{id}/status")]
        public async Task<ActionResult> UpdateParcelStatus(Guid id, [FromBody] ParcelStatusUpdateDto statusUpdate)
        {
            try
            {
                await _parcelService.UpdateParcelStatusAsync(id, statusUpdate.Status);
                return Ok(new { message = $"Parcel status updated to {statusUpdate.Status}" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { 
                    error = "Failed to update parcel status", 
                    message = ex.Message 
                });
            }
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Parcel>>> GetParcelsByUser(int userId)
        {
            try
            {
                // Query parcels for a specific user
                var parcels = await _context.Parcels
                    .Where(p => p.CreatedById == userId)
                    .ToListAsync();
                
                System.Diagnostics.Debug.WriteLine($"Found {parcels.Count} parcels for user {userId}");
                return Ok(parcels);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting parcels for user {userId}: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpPut("batch/status")]
        public async Task<ActionResult> UpdateParcelsStatus([FromBody] BatchStatusUpdateDto statusUpdate)
        {
            try
            {
                // Convert to InTransit status (value 2)
                var targetStatus = (ParcelStatus)statusUpdate.Status;
                
                var parcels = await _context.Parcels
                    .Where(p => statusUpdate.ParcelIds.Contains(p.Id))
                    .ToListAsync();

                foreach (var parcel in parcels)
                {
                    parcel.Status = targetStatus;
                    parcel.DispatchedAt = DateTime.UtcNow; // Add dispatch timestamp
                }

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { 
                    error = "Failed to update parcel statuses", 
                    message = ex.Message 
                });
            }
        }
    }

    public class ParcelStatusUpdateDto
    {
        public ParcelStatus Status { get; set; }
    }

    public class BatchStatusUpdateDto
    {
        public List<Guid> ParcelIds { get; set; }
        public ParcelStatus Status { get; set; }
    }

    public class UpdateMultipleParcelsDto
    {
        public List<string>? ParcelIds { get; set; }
        public int Status { get; set; }
    }
} 