using wms_android.Views;
using wms_android.Services;

namespace wms_android
{
    public partial class AppShell : Shell
    {
        // Reference to loading service to ensure it's initialized
        private readonly LoadingService _loadingService = LoadingService.Instance;
        
        public AppShell()
        {
            InitializeComponent();
            
            // Register routes for navigation
            Routing.RegisterRoute(nameof(ParcelsView), typeof(ParcelsView));
            Routing.RegisterRoute(nameof(ClerkDashboardView), typeof(ClerkDashboardView));
            Routing.RegisterRoute(nameof(ReceiptView), typeof(ReceiptView));
            Routing.RegisterRoute(nameof(ReceiptCartView), typeof(ReceiptCartView));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(ProfileView), typeof(ProfileView));
            Routing.RegisterRoute(nameof(SettingsView), typeof(SettingsView));
            Routing.RegisterRoute(nameof(PrinterDiagnosticView), typeof(PrinterDiagnosticView));
            Routing.RegisterRoute(nameof(ReportView), typeof(ReportView));
            Routing.RegisterRoute(nameof(ListParcelsView), typeof(ListParcelsView));
            
            // Add route for DeliveryView
            Routing.RegisterRoute(nameof(DeliveryView), typeof(DeliveryView));
            // Add route for DeliveryConfirmationView
            Routing.RegisterRoute(nameof(DeliveryConfirmationView), typeof(DeliveryConfirmationView));
        }
    }
}
