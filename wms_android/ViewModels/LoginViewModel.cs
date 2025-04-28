using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Threading.Tasks;
using wms_android.data.Interfaces; // For IUserService
using Microsoft.Maui.Controls; // For INavigation (Note: Injecting INavigation can sometimes be tricky, consider alternatives if needed)

namespace wms_android.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IUserService _userService;
        private readonly INavigation _navigation; // For navigating after login

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string? _username;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string? _password;

        [ObservableProperty]
        private string? _statusMessage;

        [ObservableProperty]
        private bool _isBusy;

        // Constructor matching the one used in LoginPage.xaml.cs
        public LoginViewModel(IUserService userService, INavigation navigation)
        {
            _userService = userService;
            _navigation = navigation; // Store navigation instance
            Debug.WriteLine("LoginViewModel initialized");
        }

        // Check if username and password are provided
        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(Username) && 
                   !string.IsNullOrWhiteSpace(Password) && 
                   !IsBusy;
        }

        [RelayCommand(CanExecute = nameof(CanLogin))] 
        private async Task LoginAsync()
        {
            IsBusy = true;
            StatusMessage = "Logging in...";
            Debug.WriteLine($"Attempting login for user: {Username}");

            try
            {
                // TODO: Implement actual login logic using _userService
                // bool loginSuccess = await _userService.AuthenticateAsync(Username, Password);
                bool loginSuccess = await Task.Delay(1000).ContinueWith(_ => true); // Simulate successful login

                if (loginSuccess)
                {
                    StatusMessage = "Login Successful!";
                    Debug.WriteLine("Login successful");
                    // Navigate to the main dashboard or appropriate page
                    // Example using Shell navigation (adjust route as needed):
                    await Shell.Current.GoToAsync("//Dashboard", true); 
                    // Clear fields after successful navigation
                    Username = string.Empty;
                    Password = string.Empty;
                    StatusMessage = string.Empty;
                }
                else
                {
                    StatusMessage = "Login failed. Please check username and password.";
                    Debug.WriteLine("Login failed.");
                    Password = string.Empty; // Clear password field on failure
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"An error occurred during login: {ex.Message}";
                Debug.WriteLine($"Login exception: {ex.Message}");
                Password = string.Empty; // Clear password field on error
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
} 