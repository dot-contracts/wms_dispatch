using wms_android.ViewModels;

namespace wms_android.Views;

public partial class QRScanView : ContentPage
{
    public QRScanView()
    {
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        // If the BindingContext is automatically set by Shell navigation, we don't need to set it here.
        // This happens if the ViewModel is registered with the DI container to match this view.
    }
} 