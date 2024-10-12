using wms_android.ViewModels;

namespace wms_android.Views
{
    public partial class ClerkDashboardView : ContentPage
    {
        public ClerkDashboardView(ClerkDashboardViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is ClerkDashboardViewModel viewModel)
            {
                viewModel.Navigation = Navigation;
                viewModel.LoadDashboardData();
            }
        }
    }
}