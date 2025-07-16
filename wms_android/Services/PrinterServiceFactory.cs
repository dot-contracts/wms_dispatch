using wms_android.Interfaces;
using wms_android.shared.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace wms_android.Services
{
    public class PrinterServiceFactory : IPrinterServiceFactory
    {
        private readonly IDeviceDetectionService _deviceDetectionService;
        private readonly ILoggerFactory _loggerFactory;
        
        public PrinterServiceFactory(IDeviceDetectionService deviceDetectionService, ILoggerFactory loggerFactory)
        {
            _deviceDetectionService = deviceDetectionService;
            _loggerFactory = loggerFactory;
        }
        
        public IPrinterService GetPrinterService(PosDeviceType deviceType)
        {
            switch (deviceType)
            {
                case PosDeviceType.CS30:
                    {
                        var logger = _loggerFactory.CreateLogger<CS30PrinterService>();
                        try
                        {
                        return new CS30PrinterService(logger);
                        }
                        catch (Exception ex)
                        {
                            logger.LogError(ex, "Failed to create CS30PrinterService - falling back to Vanstone");
                            // Fall back to Vanstone service if CS30 SDK is not available
                            var vanstoneLooger = _loggerFactory.CreateLogger<VanstonePrinterService>();
                            return new VanstonePrinterService(vanstoneLooger);
                        }
                    }
                case PosDeviceType.A90:
                    {
                        var logger = _loggerFactory.CreateLogger<VanstonePrinterService>();
                        return new VanstonePrinterService(logger);
                    }
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

        public static IPrinterService CreatePrinterService(IServiceProvider serviceProvider)
        {
            var logger = serviceProvider.GetService<ILogger<PrinterServiceFactory>>();
            
            try
            {
                logger?.LogInformation("Attempting to create CS30PrinterService...");
                
                // Try to create CS30PrinterService first
                var cs30Service = serviceProvider.GetService<CS30PrinterService>();
                if (cs30Service != null)
                {
                    logger?.LogInformation("CS30PrinterService created successfully");
                    
                    // Test initialization to see if it actually works
                    try
                    {
                        // Don't wait for full initialization here, just check if service was created properly
                        logger?.LogInformation("CS30PrinterService will be used for printing");
                        return cs30Service;
                    }
                    catch (Exception initEx)
                    {
                        logger?.LogWarning(initEx, "CS30PrinterService created but initialization test failed");
                        // Still return CS30 service - let it handle its own initialization issues
                        return cs30Service;
                    }
                }
                else
                {
                    logger?.LogWarning("CS30PrinterService could not be created - CS30 SDK likely not available");
                }
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, "Failed to create CS30PrinterService, falling back to VanstonePrinterService");
                
                // Log specific information about common CS30 issues
                if (ex.Message.Contains("CS30") || ex.Message.Contains("-4010"))
                {
                    logger?.LogError("CS30 hardware appears to have issues. Common causes:");
                    logger?.LogError("1. Printer cover not properly closed");
                    logger?.LogError("2. Paper not loaded correctly");
                    logger?.LogError("3. Thermal head hardware fault");
                    logger?.LogError("4. Device requires restart");
                }
            }
            
            try
            {
                logger?.LogInformation("Creating VanstonePrinterService as fallback...");
                var vanstoneService = serviceProvider.GetService<VanstonePrinterService>();
                if (vanstoneService != null)
                {
                    logger?.LogInformation("VanstonePrinterService created successfully as fallback");
                    return vanstoneService;
                }
                else
                {
                    logger?.LogError("VanstonePrinterService could not be created");
                }
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, "Failed to create VanstonePrinterService");
            }
            
            logger?.LogError("No printer service could be created - printing will not be available");
            throw new InvalidOperationException("No suitable printer service could be created. Both CS30 and Vanstone printer services failed to initialize.");
        }
    }
} 