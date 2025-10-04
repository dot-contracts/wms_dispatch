using wms_android.shared.Data;
using wms_android.shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using wms_android.shared.Models.Auth;
using wms_android.shared.Services;
using Microsoft.Extensions.Options;
using wms_android.api.Services;
using wms_android.api.Interfaces;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configuration setup - include crucial settings and prioritize environment variables
        var defaultConfig = new Dictionary<string, string>
        {
            // Logging settings
            {"Logging:LogLevel:Default", "Information"},
            {"Logging:LogLevel:Microsoft.AspNetCore", "Warning"},
            {"Logging:LogLevel:Microsoft.AspNetCore.Hosting", "Trace"},
            {"Logging:LogLevel:Microsoft.AspNetCore.Routing", "Trace"},
            
            // JWT settings
            {"JwtConfig:Secret", "82730899ac72e3f5cf1042079777bf15f4bf34971ff7153e881c62b31e837c78"},
            {"JwtConfig:Issuer", "wms_android.api"},
            {"JwtConfig:Audience", "wms_android.client"},
            {"JwtConfig:ExpiryInDays", "7"},

            // CORS settings
            {"Cors:AllowedOrigins:0", "*"} // Using * for now, can be overridden by environment variables
        };

        builder.Configuration
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddInMemoryCollection(defaultConfig) // Add default configuration first
            .AddEnvironmentVariables(); // Add environment variables to override defaults

        // Debug log configuration sources
        Console.WriteLine("Configuration Sources:");
        foreach (var source in builder.Configuration.Sources)
        {
            Console.WriteLine($"- {source.GetType().Name}");
        }

        // Debug log all configuration values
        Console.WriteLine("\nAll Configuration Values:");
        foreach (var config in builder.Configuration.AsEnumerable().OrderBy(x => x.Key))
        {
            if (!config.Key.Contains("ConnectionStrings", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{config.Key} = {config.Value}");
            }
        }

        // Add services to container
        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
            options.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
        });
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Register services
        builder.Services.AddScoped<IParcelService, ApiParcelService>();

        // Debug log all environment variables
        Console.WriteLine("\nEnvironment Variables:");
        foreach (var env in Environment.GetEnvironmentVariables().Cast<System.Collections.DictionaryEntry>())
        {
            Console.WriteLine($"{env.Key} = {env.Value}");
        }

        // Configure database
        var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? "139.59.12.69";
        var dbPort = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
        var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "ficma_wms";
        var dbUser = Environment.GetEnvironmentVariable("DB_USER") ?? "wms_user";
        var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "2019@_Ficma";

        var connectionString = $"Host={dbHost};Port={dbPort};Database={dbName};Username={dbUser};Password={dbPassword};SSL Mode=Require;Trust Server Certificate=true";

        // Configure Npgsql to use timestamps with time zone by default
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString));

        // Log the connection attempt (without sensitive info)
        Console.WriteLine($"Attempting to connect to database at {dbHost}:{dbPort}/{dbName}");

        // Add Health Checks with the explicit connection string
        builder.Services.AddHealthChecks()
            .AddDbContextCheck<AppDbContext>();

        // Configure JWT
        var jwtConfig = builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>();
        builder.Services.AddSingleton(Options.Create(jwtConfig));

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Secret)),
                    ValidateIssuer = true,
                    ValidIssuer = jwtConfig.Issuer,
                    ValidateAudience = true,
                    ValidAudience = jwtConfig.Audience,
                    ClockSkew = TimeSpan.Zero
                };
            });

        // Configure CORS
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowWebApp",
                builder =>
                {
                    builder.WithOrigins(
                        "https://www.system.ficma.co.ke",
                        "https://wms-dispatch-app-pi36f.ondigitalocean.app"
                    )
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
        });

        // Register services
        builder.Services.AddHttpClient();
        builder.Services.AddScoped<IUserService, wms_android.shared.Services.UserService>();
        builder.Services.AddScoped<IVehicleService, VehicleService>();
        builder.Services.AddScoped<IAuthService, AuthService>();
        builder.Services.AddScoped<ISmsService, wms_android.shared.Services.SmsService>();
        builder.Services.AddScoped<wms_android.api.Interfaces.ITokenService, wms_android.api.Services.TokenService>();

        var app = builder.Build();

        // Apply database migrations on startup
        using (var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

            try
            {
                dbContext.Database.Migrate();
                logger.LogInformation("Database migration completed successfully");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while migrating the database");
                throw;
            }
        }

        // Configure the HTTP request pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Middleware pipeline
        app.UseHttpsRedirection();
        app.UseCors("AllowWebApp");
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        
        // Map health checks endpoint last
        app.MapHealthChecks("/health");

        // Add a diagnostic endpoint to help troubleshoot route issues
        app.MapFallback(async context => {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsJsonAsync(new { 
                error = "Route not found",
                path = context.Request.Path.Value,
                method = context.Request.Method,
                availableRoutes = "Use /swagger to view available API endpoints"
            });
        });

        app.Run();
    }
}
// var builder = WebApplication.CreateBuilder(args);

// // Force Production environment and its configuration
// builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
//     .AddJsonFile("appsettings.Production.json", optional: false, reloadOnChange: true)
//     .AddEnvironmentVariables();

// // Log the current configuration
// Console.WriteLine($"Current environment: {builder.Environment.EnvironmentName}");
// Console.WriteLine($"Using connection string: {builder.Configuration.GetConnectionString("DefaultConnection")}");

// // Add CORS policy
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowMobileApp",
//         builder => builder
//             .AllowAnyOrigin()
//             .AllowAnyMethod()
//             .AllowAnyHeader());
// });

// // Configure database
// builder.Services.AddDbContext<AppDbContext>(options =>
// {
//     var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//     Console.WriteLine($"Attempting to connect with: {connectionString}");
    
//     options.UseNpgsql(connectionString, npgsqlOptions =>
//     {
//         npgsqlOptions.EnableRetryOnFailure(
//             maxRetryCount: 3,
//             maxRetryDelay: TimeSpan.FromSeconds(10),
//             errorCodesToAdd: new[] { "57P01", "57P02", "57P03" });
//         npgsqlOptions.CommandTimeout(30);
//         npgsqlOptions.MigrationsAssembly("wms_android.api");
//     });
    
//     options.EnableDetailedErrors();
//     options.EnableSensitiveDataLogging();
// });

// // Add services
// builder.Services.AddScoped<IParcelService, ParcelService>();
// builder.Services.AddScoped<IUserService, UserService>();
// builder.Services.AddScoped<IVehicleService, VehicleService>();

// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// app.UseCors("AllowMobileApp");

// // Configure the HTTP request pipeline
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();
// app.UseAuthorization();
// app.MapControllers();

// app.Run();

