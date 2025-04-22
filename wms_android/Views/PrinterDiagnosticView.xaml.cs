using System;
using System.Diagnostics;
using System.Threading.Tasks;
using wms_android.Services;
using wms_android.Utils;
using wms_android.ViewModels;

namespace wms_android.Views
{
    public partial class PrinterDiagnosticView : ContentPage
    {
        private PrinterDiagnosticViewModel _viewModel;
        
        public PrinterDiagnosticView()
        {
            InitializeComponent();
            
            _viewModel = new PrinterDiagnosticViewModel();
            BindingContext = _viewModel;
            
            // Subscribe to view model events
            _viewModel.DiagnosticCompleted += OnDiagnosticCompleted;
            _viewModel.PrinterStatusUpdated += OnPrinterStatusUpdated;
            
            // Update printer status when page appears
            this.Appearing += async (sender, e) => 
            {
                await UpdatePrinterStatus();
            };
        }
        
        private async Task UpdatePrinterStatus()
        {
            try
            {
                string status = PrinterInitializationService.GetPrinterStatus();
                PrinterStatusLabel.Text = status;
                
                var printer = PrinterInitializationService.GetPrinterHelper();
                if (printer != null)
                {
                    PrinterTypeLabel.Text = $"Printer Type: {printer.GetType().Name}";
                }
                else
                {
                    PrinterTypeLabel.Text = "No printer available";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating printer status: {ex.Message}");
                PrinterStatusLabel.Text = $"Error: {ex.Message}";
            }
        }
        
        private void OnDiagnosticCompleted(object sender, DiagnosticResult result)
        {
            DiagnosticResultsLabel.Text = result.ToString();
        }
        
        private void OnPrinterStatusUpdated(object sender, string status)
        {
            PrinterStatusLabel.Text = status;
        }
    }
} 