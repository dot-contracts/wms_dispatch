using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using wms_android.data.Data;
using wms_android.data.Services;
using wms_android.data.Interfaces;
using wms_android.ViewModels;
using wms_android.Views;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace wms_android
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // .UseBarcodeScannerDefaults()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Load the configuration from embedded appsettings.json in the data project
            var dataAssembly = typeof(AppDbContext).Assembly; // Use a type from your data project
            var resourceNames = dataAssembly.GetManifestResourceNames();

            // Debug: Print out all resource names
            foreach (var name in resourceNames)
            {
                System.Diagnostics.Debug.WriteLine($"Found resource: {name}");
            }

            var resourceName = resourceNames.FirstOrDefault(name => name.EndsWith("appsettings.json", StringComparison.OrdinalIgnoreCase));

            if (resourceName == null)
            {
                throw new FileNotFoundException("Could not find appsettings.json as an embedded resource in the data project.");
            }

            using var stream = dataAssembly.GetManifestResourceStream(resourceName);

            if (stream == null)
            {
                throw new InvalidOperationException("Failed to load appsettings.json stream from the data project.");
            }

            var configuration = new ConfigurationBuilder()
                .AddJsonStream(stream)
                .Build();

            builder.Configuration.AddConfiguration(configuration);

            // Register AppDbContext with PostgreSQL
            builder.Services.AddDbContextFactory<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
                // ServiceLifetime.Scoped);

            // Register services and viewmodels
            builder.Services.AddTransient<IParcelService, ParcelService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IVehicleService, VehicleService>();
            builder.Services.AddTransient<ParcelService>();

            builder.Services.AddTransient<ParcelsViewModel>();
            //builder.Services.AddTransient<LoginViewModel>();
            //builder.Services.AddTransient<ConfirmParcelsViewModel>();
            builder.Services.AddTransient<ParcelsView>();

            builder.Services.AddTransient<ClerkDashboardViewModel>();
builder.Services.AddTransient<ClerkDashboardView>();
            
            return builder.Build();
        }
    }
}

