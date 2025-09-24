using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wms_android.shared.Models;
using wms_android.shared.Data;
// using wms_android.shared.Data;

namespace wms_android.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispatchesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DispatchesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Dispatch>> CreateDispatch([FromBody] Dispatch dispatch)
        {
            try
            {
                // Debug logging
                Console.WriteLine($"[DispatchesController] Received dispatch: {System.Text.Json.JsonSerializer.Serialize(dispatch)}");
                Console.WriteLine($"[DispatchesController] ParcelIds count: {dispatch.ParcelIds?.Count ?? 0}");
                Console.WriteLine($"[DispatchesController] ParcelIds: {string.Join(", ", dispatch.ParcelIds ?? new List<Guid>())}");
                
                // Validate parcel IDs
                if (dispatch.ParcelIds == null || dispatch.ParcelIds.Count == 0)
                    return BadRequest("At least one parcel ID is required");

                // Check if parcels exist
                var existingParcels = await _context.Parcels
                    .Where(p => dispatch.ParcelIds.Contains(p.Id))
                    .ToListAsync();

                if (existingParcels.Count != dispatch.ParcelIds.Count)
                {
                    var missingIds = dispatch.ParcelIds.Except(existingParcels.Select(p => p.Id));
                    return BadRequest($"Some parcels not found: {string.Join(", ", missingIds)}");
                }

                // Generate a new UUID for the database ID (primary key)
                dispatch.Id = Guid.NewGuid();
                // Preserve the DispatchCode sent from client (e.g., "KRC-20250716-DSIF1Y6")
                // If no DispatchCode provided, use the generated UUID as fallback
                if (string.IsNullOrEmpty(dispatch.DispatchCode))
                {
                    dispatch.DispatchCode = dispatch.Id.ToString();
                }
                dispatch.DispatchTime = DateTime.UtcNow;
                dispatch.Status = "in_transit";

                // Update existing parcels with provided data
                foreach (var providedParcel in dispatch.Parcels ?? new List<Parcel>())
                {
                    var existingParcel = existingParcels.FirstOrDefault(p => p.Id == providedParcel.Id);
                    if (existingParcel != null)
                    {
                        // Update required fields to avoid null violations
                        existingParcel.Sender = providedParcel.Sender ?? existingParcel.Sender ?? "Unknown";
                        existingParcel.SenderTelephone = providedParcel.SenderTelephone ?? existingParcel.SenderTelephone ?? "N/A";
                        existingParcel.Receiver = providedParcel.Receiver ?? existingParcel.Receiver ?? "Unknown";
                        existingParcel.ReceiverTelephone = providedParcel.ReceiverTelephone ?? existingParcel.ReceiverTelephone ?? "N/A";
                        existingParcel.Destination = providedParcel.Destination ?? existingParcel.Destination ?? "Unknown";
                        existingParcel.Description = providedParcel.Description ?? existingParcel.Description ?? "";
                        existingParcel.PaymentMethods = providedParcel.PaymentMethods ?? existingParcel.PaymentMethods ?? "COD";
                        existingParcel.Quantity = providedParcel.Quantity ?? existingParcel.Quantity ?? 1;
                        existingParcel.Amount = providedParcel.Amount ?? existingParcel.Amount ?? 0;
                        existingParcel.TotalAmount = providedParcel.TotalAmount != 0 ? providedParcel.TotalAmount : (existingParcel.TotalAmount != 0 ? existingParcel.TotalAmount : (providedParcel.Amount ?? 0));
                        existingParcel.TotalRate = providedParcel.TotalRate != 0 ? providedParcel.TotalRate : (existingParcel.TotalRate != 0 ? existingParcel.TotalRate : (providedParcel.Rate ?? 0));
                        existingParcel.Status = ParcelStatus.InTransit; // Set to InTransit (2)
                        existingParcel.DispatchedAt = dispatch.DispatchTime;
                        // Use the DispatchCode instead of the UUID for tracking
                        existingParcel.DispatchTrackingCode = dispatch.DispatchCode;
                    }
                }

                // Associate parcels with the dispatch
                dispatch.Parcels = existingParcels;

                // Add dispatch to database
                _context.Dispatches.Add(dispatch);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetDispatch), new { id = dispatch.Id }, dispatch);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating dispatch: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                return StatusCode(500, new { error = "Failed to create dispatch", message = ex.Message, innerException = ex.InnerException?.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dispatch>> GetDispatch(Guid id)
        {
            var dispatch = await _context.Dispatches.FindAsync(id);
            if (dispatch == null)
            {
                return NotFound();
            }
            return Ok(dispatch);
        }

        [HttpGet("branch/{branch}")]
        public async Task<ActionResult<IEnumerable<Dispatch>>> GetDispatchesByBranch(string branch)
        {
            var dispatches = await _context.Dispatches
                .Where(d => d.SourceBranch.ToLower() == branch.ToLower())
                .OrderByDescending(d => d.DispatchTime)
                .ToListAsync();

            return Ok(dispatches);
        }

        [HttpGet("{id}/note")]
        public async Task<ActionResult<DispatchNote>> GetDispatchNote(Guid id)
        {
            // Load dispatch with parcel relationships
            var dispatch = await _context.Dispatches
                .Include(d => d.Parcels)  // Eager load parcels
                .FirstOrDefaultAsync(d => d.Id == id);

            if (dispatch == null)
            {
                return NotFound();
            }

            // Explicitly load parcels if not loaded
            if (dispatch.Parcels == null || dispatch.Parcels.Count == 0)
            {
                if (dispatch.ParcelIds != null && dispatch.ParcelIds.Count > 0)
                {
                    dispatch.Parcels = await _context.Parcels
                        .Where(p => dispatch.ParcelIds.Contains(p.Id))
                        .ToListAsync();
                }
                else
                {
                    dispatch.Parcels = new List<Parcel>();
                }
            }

            var note = new DispatchNote
            {
                DispatchId = dispatch.Id,
                DispatchCode = dispatch.DispatchCode, // Include the custom dispatch code
                SourceBranch = dispatch.SourceBranch,
                VehicleNumber = dispatch.VehicleNumber,
                Driver = dispatch.Driver,
                DispatchTime = dispatch.DispatchTime,
                Parcels = dispatch.Parcels
            };

            return Ok(note);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dispatch>>> GetAllDispatches()
        {
            try
            {
                var dispatches = await _context.Dispatches
                    .OrderByDescending(d => d.DispatchTime)
                    .ToListAsync();
                return Ok(dispatches);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Failed to retrieve dispatches", message = ex.Message });
            }
        }
    }

    public class DispatchNote
    {
        public Guid DispatchId { get; set; }
        public string? DispatchCode { get; set; } // Add the custom dispatch code
        public string SourceBranch { get; set; }
        public string VehicleNumber { get; set; }
        public string Driver { get; set; }
        public DateTime DispatchTime { get; set; }
        public List<Parcel> Parcels { get; set; }
    }

    // DTO for creating a dispatch
    public class CreateDispatchDto
    {
        public string? SourceBranch { get; set; }
        public string? VehicleNumber { get; set; }
        public string? Driver { get; set; }
        public string? Destination { get; set; }
        public List<Guid>? Parcels { get; set; }
    }
} 