using wms_android.Views;

namespace wms_android
{
    public partial class AppShell : Shell
    {
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
        }
    }
}
