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
        public async Task<ActionResult<IEnumerable<Parcel>>> GetParcels()
        {
            var parcels = await _parcelService.GetParcelsAsync();
            return Ok(parcels);
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
        public async Task<ActionResult<Parcel>> GetParcelByQRCode(string qrCode)
        {
            var parcel = await _parcelService.GetParcelByQRCodeAsync(qrCode);
            return Ok(parcel);
        }

        [HttpGet("pending")]
        public async Task<ActionResult<IEnumerable<Parcel>>> GetPendingOrders()
        {
            var parcels = await _parcelService.GetPendingOrdersAsync();
            return Ok(parcels);
        }

        [HttpGet("count/{date}")]
        public async Task<ActionResult<int>> GetParcelCount(DateTime date)
        {
            var count = await _parcelService.GetParcelCountForDateAsync(date);
            return Ok(count);
        }

        [HttpGet("sales/{date}")]
        public async Task<ActionResult<decimal>> GetTotalSales(DateTime date)
        {
            var total = await _parcelService.GetTotalSalesForDateAsync(date);
            return Ok(total);
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
    }

    public class ParcelStatusUpdateDto
    {
        public ParcelStatus Status { get; set; }
    }
} 