using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.data.Models;
using wms_android.data.Interfaces;
using wms_android.data.Services;
using wms_android.Views;
using wms_android.Services;

namespace wms_android.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly IUserService _userService;
        private INavigation _navigation;
        private string _username;
        private string _password;
        private string _errorMessage;
        private bool _hasError;
        public ICommand LoginCommand { get; }
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }
        public string ErrorMessage
        {
            get => _errorMessage;
            set { _errorMessage = value; OnPropertyChanged(nameof(ErrorMessage)); }
        }
        public bool HasError
        {
            get => _hasError;
            set { _hasError = value; OnPropertyChanged(nameof(HasError)); }
        }

        public INavigation Navigation
        {
            get => _navigation;
            set { _navigation = value; OnPropertyChanged(nameof(Navigation)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel(IUserService userService, INavigation navigation)
        {
                _userService = userService;
            _navigation = navigation;
            LoginCommand = new Command(async () => await OnLoginAsync());
        }

        private async Task OnLoginAsync()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Username and password are required.";
                HasError = true;
                return;
            }

            try
            {
                var user = await _userService.AuthenticateAsync(Username, Password);

                if (user != null)
                {
                    await NavigateToRoleBasedPage(user);
                }
                else
                {
                    ErrorMessage = "Invalid username or password.";
                    HasError = true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"An error occurred: {ex.Message}";
                HasError = true;
            }
        }

        private async Task NavigateToRoleBasedPage(User user)
        {
            if (_navigation == null)
            {
                // Handle the case where navigation is still not set
                return;
            }
            if (user.Role.Name == "Admin")
            {
                // Navigate to Admin dashboard
                //Application.Current.MainPage = new AdminDashboardPage();
            }
            else if (user.Role.Name == "Manager")
            {
                // Navigate to Manager dashboard
                //Application.Current.MainPage = new ManagerDashboardPage();
            }
            if (user.Role.Name == "Clerk")
            {
                // Navigate to ClerkDashboardView
                var parcelService = ServiceHelper.GetService<IParcelService>();
                var userService = ServiceHelper.GetService<IUserService>();
                var clerkDashboardViewModel = new ClerkDashboardViewModel(parcelService, userService, _navigation);
                await _navigation.PushAsync(new ClerkDashboardView(clerkDashboardViewModel));
            }
            else
            {
                // Navigate to ClientDashboardView
                //Application.Current.MainPage = new ClientDashboardPage();

            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
