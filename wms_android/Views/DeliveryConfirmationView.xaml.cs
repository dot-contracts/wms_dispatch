using wms_android.ViewModels;

namespace wms_android.Views;

public partial class DeliveryConfirmationView : ContentPage
{
	public DeliveryConfirmationView(DeliveryConfirmationViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
} 