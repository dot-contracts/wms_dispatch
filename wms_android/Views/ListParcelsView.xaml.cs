using wms_android.ViewModels;

namespace wms_android.Views
{
    public partial class ListParcelsView : ContentPage
    {
        private readonly ParcelsViewModel _viewModel;

        public ListParcelsView(ParcelsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = _viewModel = viewModel;
        }
    }
}