using wms_android.Interfaces;
using wms_android.shared.Models;

namespace wms_android.Services
{
    public class PrinterServiceFactory : IPrinterServiceFactory
    {
        private readonly IDeviceDetectionService _deviceDetectionService;
        
        public PrinterServiceFactory(IDeviceDetectionService deviceDetectionService)
        {
            _deviceDetectionService = deviceDetectionService;
        }
        
        public IPrinterService GetPrinterService(PosDeviceType deviceType)
        {
            switch (deviceType)
            {
                case PosDeviceType.CS30:
                    return new Cs30PrinterService();
                case PosDeviceType.A90:
                    // Create or get the Vanstone printer service here
                    // This is a placeholder, you should implement the actual service
                    return new Cs30PrinterService(); // Temp fallback
                default:
                    return GetDefaultPrinterService();
            }
        }
        
        public IPrinterService GetDefaultPrinterService()
        {
            // Auto-detect the device type
            var deviceType = _deviceDetectionService.DetectDevice();
            return GetPrinterService(deviceType);
        }
    }
} 