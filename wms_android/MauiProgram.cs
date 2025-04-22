using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using wms_android.data.Data;
using wms_android.data.Services;
using wms_android.ViewModels;
using wms_android.Views;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using wms_android.Services;
using IParcelService = wms_android.data.Interfaces.IParcelService;
using ParcelService = wms_android.data.Services.ParcelService;
using IUserService = wms_android.data.Interfaces.IUserService;
using UserService = wms_android.data.Services.UserService;
using IVehicleService = wms_android.data.Interfaces.IVehicleService;
using VehicleService = wms_android.data.Services.VehicleService;
using ISmsService = wms_android.shared.Interfaces.ISmsService;
using SmsService = wms_android.Services.SmsService;

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
                    // Add Material Icons font for tab icons
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
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

            // Debug: Print the connection string that will be used
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            System.Diagnostics.Debug.WriteLine($"Using connection string: {connectionString}");

            // Register AppDbContext with PostgreSQL
            builder.Services.AddDbContextFactory<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), 
                npgsqlOptions => 
                {
                    // Add retry logic for transient failures
                    npgsqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5, 
                        maxRetryDelay: TimeSpan.FromSeconds(30), 
                        errorCodesToAdd: null);
                    
                    // Increase command timeout
                    npgsqlOptions.CommandTimeout(60);
                }));
                // ServiceLifetime.Scoped);

            // Register services and viewmodels
            builder.Services.AddTransient<IParcelService, ParcelService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IVehicleService, VehicleService>();
            builder.Services.AddTransient<ParcelService>();
            
            // Register SMS service
            builder.Services.AddSingleton<ISmsService, SmsService>();

            builder.Services.AddTransient<ParcelsViewModel>();
            //builder.Services.AddTransient<LoginViewModel>();
            //builder.Services.AddTransient<ConfirmParcelsViewModel>();
            builder.Services.AddTransient<ParcelsView>();

            builder.Services.AddTransient<ClerkDashboardViewModel>();
            builder.Services.AddTransient<ClerkDashboardView>();
            
            // Add ReceiptCartViewModel and ReceiptCartView
            builder.Services.AddTransient<ReceiptCartViewModel>();
            builder.Services.AddTransient<ReceiptCartView>();

            // Add ProfileViewModel and SettingsViewModel
            builder.Services.AddTransient<ProfileView>();
            builder.Services.AddTransient<SettingsView>();
            
            // Add PrinterDiagnosticViewModel and PrinterDiagnosticView
            builder.Services.AddTransient<PrinterDiagnosticViewModel>();
            builder.Services.AddTransient<PrinterDiagnosticView>();
            
            // Add database connection services
            builder.Services.AddSingleton<IDatabaseHealthCheck, DatabaseHealthCheck>();
            
            var app = builder.Build();
            
            // Test database connection at startup
            var scope = app.Services.CreateScope();
            var dbHealthCheck = scope.ServiceProvider.GetRequiredService<IDatabaseHealthCheck>();
            
            Task.Run(async () => {
                var isConnected = await dbHealthCheck.CheckConnectionAsync();
                System.Diagnostics.Debug.WriteLine($"Initial database connection test result: {(isConnected ? "CONNECTED" : "FAILED TO CONNECT")}");
                
                // Initialize printer after database check
                System.Diagnostics.Debug.WriteLine("Initializing printer at application startup...");
                PrinterInitializationService.Initialize();
                System.Diagnostics.Debug.WriteLine($"Printer initialization completed. IsInitialized: {PrinterInitializationService.IsInitialized}");
            }).Wait();
            
            return app;
        }
    }
    
    public interface IDatabaseHealthCheck
    {
        Task<bool> CheckConnectionAsync();
    }
    
    public class DatabaseHealthCheck : IDatabaseHealthCheck
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;
        
        public DatabaseHealthCheck(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        
        public async Task<bool> CheckConnectionAsync()
        {
            try
            {
                using (var context = await _contextFactory.CreateDbContextAsync())
                {
                    // Try to connect to the database
                    var canConnect = await context.Database.CanConnectAsync();
                    if (canConnect)
                    {
                        System.Diagnostics.Debug.WriteLine("Successfully connected to the database!");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Database connection test returned false.");
                    }
                    return canConnect;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error connecting to database: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                return false;
            }
        }
    }
}

