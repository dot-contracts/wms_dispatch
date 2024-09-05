using Microsoft.Maui.Controls;
using wms_android.Views;
using wms_android.ViewModels;

namespace wms_android
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            var parcelsViewModel = serviceProvider.GetRequiredService<ParcelsViewModel>();
            MainPage = new NavigationPage(new ParcelsView(parcelsViewModel));
        }
    }
}
