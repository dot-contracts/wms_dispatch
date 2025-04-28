using Microsoft.Maui.Controls;
using wms_android.shared.Data;
using wms_android.data.Interfaces;
using wms_android.Services;
using wms_android.ViewModels;

namespace wms_android.Views;

public partial class LoginPage : ContentPage
{
    private readonly LoginViewModel _viewModel;

    // Constructor that accepts LoginViewModel
    public LoginPage(LoginViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    // Optional default constructor if needed
    public LoginPage()
    {
        InitializeComponent();

        // Retrieve AppDbContext and UserService from DI container
        var dbContext = ServiceHelper.GetService<AppDbContext>();
        var userService = ServiceHelper.GetService<IUserService>();

        // Set the BindingContext using the resolved services
        BindingContext = new LoginViewModel(userService, this.Navigation);
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (_viewModel != null)
        {
            await _viewModel.LoginCommand.ExecuteAsync(null);
        }
    }
}

