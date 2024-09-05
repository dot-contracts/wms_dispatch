using wms_android.ViewModels;

namespace wms_android.Views;

public partial class ParcelsView : ContentPage
{
	public ParcelsView()
	{
		InitializeComponent();
		BindingContext = new ParcelsViewModel();
	}

	public ParcelsView(ParcelsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}