using wms_android.Interfaces;
using wms_android.shared.Models;
using Microsoft.Extensions.Logging;

namespace wms_android.Services
{
    public class PrinterServiceFactory : IPrinterServiceFactory
    {
        private readonly IDeviceDetectionService _deviceDetectionService;
        private readonly ILogger<CS30PrinterService> _logger;
        
        public PrinterServiceFactory(IDeviceDetectionService deviceDetectionService, ILogger<CS30PrinterService> logger)
        {
            _deviceDetectionService = deviceDetectionService;
            _logger = logger;
        }
        
        public IPrinterService GetPrinterService(PosDeviceType deviceType)
        {
            switch (deviceType)
            {
                case PosDeviceType.CS30:
                    return new CS30PrinterService(_logger);
                case PosDeviceType.A90:
                    // Create or get the Vanstone printer service here
                    // This is a placeholder, you should implement the actual service
                    return new CS30PrinterService(_logger); // Temp fallback
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