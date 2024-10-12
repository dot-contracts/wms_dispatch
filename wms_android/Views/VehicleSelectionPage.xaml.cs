using wms_android.data.Interfaces;
using wms_android.ViewModels;

namespace wms_android.Views;

public partial class VehicleSelectionPage : ContentPage
{
	public VehicleSelectionPage(IVehicleService vehicleService)
	{
        InitializeComponent();
        BindingContext = new VehicleSelectionViewModel(vehicleService);
    }
}