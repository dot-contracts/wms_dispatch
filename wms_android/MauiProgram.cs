using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using wms_android.shared.Data;
using wms_android.data.Services;
using wms_android.data.Interfaces;
using Wms_Android.Services;
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

            // Register AppDbContext with PostgreSQL (using the shared context)
            builder.Services.AddDbContextFactory<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Register the data implementation of IParcelService
            builder.Services.AddTransient<wms_android.data.Services.ParcelService>();
            builder.Services.AddTransient<wms_android.data.Interfaces.IParcelService>(
                sp => sp.GetRequiredService<wms_android.data.Services.ParcelService>());
            
            // Register the shared implementation of IParcelService if remote services are enabled
            var useRemoteService = configuration.GetValue<bool>("UseRemoteServices");
            if (useRemoteService)
            {
                // Create HttpClient directly
                builder.Services.AddTransient<HttpClient>(sp => {
                    var client = new HttpClient();
                    client.BaseAddress = new Uri(configuration["ApiSettings:BaseUrl"]);
                    return client;
                });
                
                builder.Services.AddTransient<wms_android.shared.Services.ParcelService>();
                builder.Services.AddTransient<wms_android.shared.Interfaces.IParcelService>(
                    sp => sp.GetRequiredService<wms_android.shared.Services.ParcelService>());
            }
            
            // Register UserService with fully qualified names
            builder.Services.AddTransient<wms_android.shared.Services.UserService>();
            builder.Services.AddTransient<wms_android.shared.Interfaces.IUserService>(
                sp => sp.GetRequiredService<wms_android.shared.Services.UserService>());
            
            // Register VehicleService with fully qualified names
            builder.Services.AddTransient<wms_android.shared.Services.VehicleService>();
            builder.Services.AddTransient<wms_android.shared.Interfaces.IVehicleService>(
                sp => sp.GetRequiredService<wms_android.shared.Services.VehicleService>());
            
            // Register remaining shared services
            builder.Services.AddTransient<wms_android.shared.Interfaces.ISmsService, wms_android.shared.Services.SmsService>();
            builder.Services.AddTransient<wms_android.shared.Interfaces.IAuthService, wms_android.shared.Services.AuthService>();
            
            // Register device-specific services with fully qualified namespaces
            builder.Services.AddSingleton<wms_android.Interfaces.IDeviceDetectionService, wms_android.Services.DeviceDetectionService>();
            builder.Services.AddSingleton<wms_android.Interfaces.IPrinterServiceFactory, wms_android.Services.PrinterServiceFactory>();
            builder.Services.AddSingleton<wms_android.Interfaces.IScannerService, wms_android.Services.Cs30ScannerService>();
            builder.Services.AddSingleton<wms_android.Interfaces.IDialogService, wms_android.Services.DialogService>();
            builder.Services.AddSingleton<wms_android.Interfaces.IMainThreadService, wms_android.Services.MainThreadService>();

            // Register view models with their dependencies
            builder.Services.AddTransient<ParcelsViewModel>();
            //builder.Services.AddTransient<LoginViewModel>();
            //builder.Services.AddTransient<ConfirmParcelsViewModel>();
            builder.Services.AddTransient<ParcelsView>();
            builder.Services.AddTransient<ListParcelsView>();

            builder.Services.AddTransient<ClerkDashboardViewModel>();
            builder.Services.AddTransient<ClerkDashboardView>();

            // Add registration for Delivery View and ViewModel
            builder.Services.AddTransient<DeliveryViewModel>();
            builder.Services.AddTransient<DeliveryView>();
            
            // Add registration for Report View and ViewModel
            builder.Services.AddTransient<ReportViewModel>();
            builder.Services.AddTransient<ReportView>();

            return builder.Build();
        }
    }
}

