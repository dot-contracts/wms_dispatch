using wms_android.data.Services;
using wms_android.ViewModels;

namespace wms_android.Views;

public partial class ParcelsView : ContentPage
{
    private readonly ParcelsViewModel _viewModel;

    public ParcelsView(ParcelsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = _viewModel = viewModel;  // ViewModel is injected via constructor
    }

    // When using Dependency Injection (if you're using an IoC container like Microsoft.Extensions.DependencyInjection)
    

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Reset the parcel data when the view appears
        if (BindingContext is ParcelsViewModel viewModel)
        {
            viewModel.ResetParcel();
        }
    }

}