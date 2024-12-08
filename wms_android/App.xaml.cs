using Microsoft.Maui.Controls;
using wms_android.Views;
using wms_android.ViewModels;
using wms_android.data.Interfaces;
using Java.Util;

namespace wms_android
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            var parcelsViewModel = serviceProvider.GetRequiredService<ParcelsViewModel>();
            MainPage = new NavigationPage(new ParcelsView(parcelsViewModel));

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
