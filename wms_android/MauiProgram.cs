using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using wms_android.data.Data;
using wms_android.data.Services;
using wms_android.ViewModels;
using wms_android.Views;

namespace wms_android
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            var connectionString = "Host=localhost;Database=WMS_Ficma;Username=postgres;Password=adminer";

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString, npgsqlOptions =>
                    npgsqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorCodesToAdd: null)));

            builder.Services.AddTransient<ParcelService>();
            builder.Services.AddTransient<ParcelsViewModel>();
            builder.Services.AddTransient<ParcelsView>();

            return builder.Build();
        }
    }
}


