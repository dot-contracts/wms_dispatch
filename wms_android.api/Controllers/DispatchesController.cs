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
                // Set dispatch time to current UTC time
                dispatch.DispatchTime = DateTime.UtcNow;
                dispatch.Status = "in_transit";

                // Add dispatch to database
                _context.Dispatches.Add(dispatch);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetDispatch), new { id = dispatch.Id }, dispatch);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Failed to create dispatch", message = ex.Message });
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
        public string SourceBranch { get; set; }
        public string VehicleNumber { get; set; }
        public string Driver { get; set; }
        public DateTime DispatchTime { get; set; }
        public List<Parcel> Parcels { get; set; }
    }
} 