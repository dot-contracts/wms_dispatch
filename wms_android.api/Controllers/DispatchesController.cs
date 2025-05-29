using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wms_android.shared.Models;
using wms_android.shared.Data;

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

        [HttpPost]
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
            var dispatch = await _context.Dispatches
                .Include(d => d.Parcels)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (dispatch == null)
            {
                return NotFound();
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