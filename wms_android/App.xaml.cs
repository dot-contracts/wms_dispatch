using Microsoft.Maui.Controls;
using wms_android.Views;
using wms_android.ViewModels;
using Java.Util;
using wms_android.shared.Interfaces;

namespace wms_android
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Create and configure the AppShell
            var appShell = new AppShell();
            
            // Set the MainPage to the AppShell
            MainPage = appShell;

            // Explicitly navigate to the login page on app startup
            Microsoft.Maui.Controls.Shell.Current.GoToAsync("//LoginPage");

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
