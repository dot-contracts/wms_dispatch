using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using wms_android.shared.Data;
using wms_android.data.Services;
using wms_android.data.Interfaces;
using wms_android.Services;
using wms_android.ViewModels;
using wms_android.Views;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using wms_android.Services;
using wms_android.Utils;
using wms_android.Interfaces;
using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using wms_android.shared.Interfaces;
using wms_android.shared.Services;
using UraniumUI;
using UraniumUI.Material;
using UraniumUI.Icons.FontAwesome;

namespace wms_android
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseUraniumUI()
                .UseUraniumUIMaterial()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFontAwesomeIconFonts();
                });

            // Load the configuration from embedded appsettings.json in the data project
            var dataAssembly = typeof(AppDbContext).Assembly; // This now points to the shared project
            var resourceNames = dataAssembly.GetManifestResourceNames();

            // Debug: Print out all resource names
            foreach (var name in resourceNames)
            {
                System.Diagnostics.Debug.WriteLine($"Found resource: {name}");
            }

            var resourceName = resourceNames.FirstOrDefault(name => name.EndsWith("appsettings.json", StringComparison.OrdinalIgnoreCase));

            if (resourceName == null)
            {
                throw new FileNotFoundException("Could not find appsettings.json as an embedded resource in the shared project.");
            }

            using var stream = dataAssembly.GetManifestResourceStream(resourceName);

            if (stream == null)
            {
                throw new InvalidOperationException("Failed to load appsettings.json stream from the shared project.");
            }

            var configuration = new ConfigurationBuilder()
                .AddJsonStream(stream)
                .Build();

            builder.Configuration.AddConfiguration(configuration);

            // Create HttpClient for API access
            builder.Services.AddTransient<HttpClient>(sp => {
                var client = new HttpClient();
                var baseUrl = configuration["ApiSettings:BaseUrl"];
                // Ensure baseUrl doesn't include "/api"
                if (baseUrl.EndsWith("/api/")) {
                    baseUrl = baseUrl.Substring(0, baseUrl.Length - 5);
                } else if (baseUrl.EndsWith("/api")) {
                    baseUrl = baseUrl.Substring(0, baseUrl.Length - 4);
                }
                client.BaseAddress = new Uri(baseUrl);
                System.Diagnostics.Debug.WriteLine($"Configured HttpClient with BaseAddress: {baseUrl}");
                return client;
            });
                
            // Register shared services - use these instead of data project equivalents
            builder.Services.AddTransient<wms_android.shared.Services.ParcelService>();
            builder.Services.AddTransient<wms_android.shared.Interfaces.IParcelService, wms_android.shared.Services.ParcelService>();
            
            // Register UserService - Use the client-side API implementation
            builder.Services.AddTransient<wms_android.shared.Interfaces.IUserService, wms_android.Services.ApiUserService>();
            
            // Register VehicleService
            builder.Services.AddTransient<wms_android.shared.Services.VehicleService>();
            builder.Services.AddTransient<wms_android.shared.Interfaces.IVehicleService, wms_android.shared.Services.VehicleService>();
            
            // Register remaining shared services
            builder.Services.AddTransient<wms_android.shared.Interfaces.ISmsService>(sp => {
                var parcelService = sp.GetRequiredService<wms_android.shared.Interfaces.IParcelService>();
                return new wms_android.shared.Services.SmsService(parcelService);
            });
            builder.Services.AddTransient<wms_android.shared.Interfaces.IAuthService, wms_android.shared.Services.AuthService>();
            
            // Register device-specific services
            builder.Services.AddSingleton<wms_android.Interfaces.IDeviceDetectionService, wms_android.Services.DeviceDetectionService>();
            builder.Services.AddSingleton<wms_android.Interfaces.IPrinterServiceFactory, wms_android.Services.PrinterServiceFactory>();
            
            // --- Conditionally register IScannerService based on detected device ---
            // Build temporary provider to resolve IDeviceDetectionService
            var tempServiceProvider = builder.Services.BuildServiceProvider();
            var deviceDetector = tempServiceProvider.GetRequiredService<wms_android.Interfaces.IDeviceDetectionService>();
            var deviceType = deviceDetector.DetectDevice();
            
            System.Diagnostics.Debug.WriteLine($"Detected device type: {deviceType}. Registering appropriate IScannerService.");

            if (deviceType == wms_android.shared.Models.PosDeviceType.A90)
            {
                builder.Services.AddSingleton<wms_android.Interfaces.IScannerService, wms_android.Services.VanstoneScannerService>();
                System.Diagnostics.Debug.WriteLine("Registered VanstoneScannerService for A90 device.");
            }
            else // Default to CS30 (or handle other types if needed)
            {
                builder.Services.AddSingleton<wms_android.Interfaces.IScannerService, wms_android.Services.Cs30ScannerService>();
                System.Diagnostics.Debug.WriteLine("Registered Cs30ScannerService for CS30 or default device.");
            }
            // --- End conditional IScannerService registration ---
            
            // Register other singletons
            builder.Services.AddSingleton<wms_android.Interfaces.IDialogService, wms_android.Services.DialogService>();
            builder.Services.AddSingleton<wms_android.Interfaces.IMainThreadService, wms_android.Services.MainThreadService>();
            
            // Register loading service (using its singleton instance)
            builder.Services.AddSingleton<wms_android.Services.LoadingService>(sp => wms_android.Services.LoadingService.Instance);

            // Register view models with their dependencies
            builder.Services.AddTransient<ParcelsViewModel>();
            builder.Services.AddTransient<LoginViewModel>();
            //builder.Services.AddTransient<ConfirmParcelsViewModel>();
            builder.Services.AddTransient<ParcelsView>();
            builder.Services.AddTransient<ListParcelsView>();
            builder.Services.AddTransient<LoginPage>();
            
            // Register the SplashScreen page
            builder.Services.AddTransient<SplashScreen>();

            builder.Services.AddTransient<ClerkDashboardViewModel>();
            builder.Services.AddTransient<ClerkDashboardView>();

            // Add registration for Delivery View and ViewModel
            builder.Services.AddTransient<DeliveryViewModel>();
            builder.Services.AddTransient<DeliveryView>();
            
            // Add registration for Report View and ViewModel
            builder.Services.AddTransient<ReportViewModel>();
            builder.Services.AddTransient<ReportView>();

            // Add registration for Receipt View and ViewModel
            builder.Services.AddTransient<ReceiptViewModel>();
            builder.Services.AddTransient<ReceiptView>();

            // Add registration for Delivery Confirmation View and ViewModel
            builder.Services.AddTransient<DeliveryConfirmationViewModel>();
            builder.Services.AddTransient<DeliveryConfirmationView>();

            return builder.Build();
        }
    }
}

