using wms_android.data.Data;
using wms_android.data.Interfaces;
using wms_android.data.Models;

namespace wms_android.data.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly AppDbContext _context;

        public VehicleService(AppDbContext context)
        {
            _context = context;
        }

        // Get the list of available vehicles
        public List<Vehicle> GetVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public List<Drivers> GetDrivers()
        {
            return _context.Drivers.ToList();
        }
    }
}
