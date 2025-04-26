using Microsoft.Maui.Controls;
using wms_android.Views;
using wms_android.ViewModels;
using wms_android.data.Interfaces;
using wms_android.Interfaces;
using wms_android.Services;
using Java.Util;
using Microsoft.Extensions.DependencyInjection;

namespace wms_android
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Register QRScannerService if it's not already registered
            // This is a workaround until we find the proper MauiProgram.cs location
            if (serviceProvider.GetService<IQRScannerService>() == null)
            {
                // In a real app, you'd modify MauiProgram.cs instead
                // This is just to ensure the service is available for now
                ServiceHelper.Services = serviceProvider;
                if (ServiceHelper.GetService<IQRScannerService>() == null)
                {
                    // This is a temporary workaround - in production, register in MauiProgram
                    var services = new ServiceCollection();
                    services.AddSingleton<IQRScannerService, QRScannerService>();
                    ServiceHelper.Services = services.BuildServiceProvider();
                }
            }

            // Use AppShell instead of direct navigation
            MainPage = new AppShell();

            // Commented out previous direct navigation code
            // var parcelsViewModel = serviceProvider.GetRequiredService<ParcelsViewModel>();
            // MainPage = new NavigationPage(new ParcelsView(parcelsViewModel));

            // Set the LoginPage without passing navigation initially
            //var userService = serviceProvider.GetRequiredService<IUserService>();
            //var navigation = new NavigationPage();
            //var loginViewModel = new LoginViewModel(userService, navigation.Navigation);
            //var loginPage = new LoginPage(loginViewModel);

            //navigation.PushAsync(loginPage);
            //MainPage = navigation;  


            //var vehicleService = serviceProvider.GetRequiredService<IVehicleService>();
            //MainPage = new NavigationPage(new VehicleSelectionPage(vehicleService));

            //var confirmparcelsViewModel = serviceProvider.GetRequiredService<ConfirmParcelsViewModel>();
            //MainPage = new NavigationPage(new ConfirmParcelsView(confirmparcelsViewModel));
        }
    }
}
