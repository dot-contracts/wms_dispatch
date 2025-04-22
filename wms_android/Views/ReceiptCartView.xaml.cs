using wms_android.ViewModels;

namespace wms_android.Views;

public partial class ReceiptCartView : ContentPage
{
	public ReceiptCartView(ReceiptCartViewModel viewModel = null)
	{
        InitializeComponent();
        if (viewModel != null)
        {
            BindingContext = viewModel;
        }
    }
}