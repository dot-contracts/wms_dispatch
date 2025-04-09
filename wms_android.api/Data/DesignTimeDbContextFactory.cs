using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using wms_android.shared.Data;

namespace wms_android.api.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // Get database configuration from environment variables with fallback values
            var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? "139.59.12.69";
            var dbPort = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
            var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "ficma_wms";
            var dbUser = Environment.GetEnvironmentVariable("DB_USER") ?? "wms_user";
            var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "2019@_Ficma";

            var connectionString = $"Host={dbHost};Port={dbPort};Database={dbName};Username={dbUser};Password={dbPassword};SSL Mode=Require;Trust Server Certificate=true";

            Console.WriteLine($"Using connection string (without password): {connectionString.Replace(dbPassword, "***")}");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql(connectionString, options =>
            {
                options.MigrationsAssembly("wms_android.api");
                options.EnableRetryOnFailure(3);
            });

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}