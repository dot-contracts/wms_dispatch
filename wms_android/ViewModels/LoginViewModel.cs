using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Maui.Controls; // For INavigation
using wms_android.shared.Interfaces;
using wms_android.shared.Models;
using wms_android.shared.Models.Auth;
using wms_android.Views;
using Microsoft.Maui.Storage;
using wms_android.Services;
using System.Net.Http; // Add HttpClient namespace
using System.Net.Http.Json; // Add Http.Json namespace
using wms_android.Interfaces;

namespace wms_android.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IUserService _userService; // This should be ApiUserService
        // private readonly IAuthService _authService; // Remove IAuthService
        private readonly INavigation _navigation;
        private readonly HttpClient _httpClient; // Add HttpClient field
        private readonly INotificationService _notificationService;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string? _username;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string? _password;

        [ObservableProperty]
        private string? _errorMessage;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private bool _hasError;

        // Updated Constructor: Inject HttpClient, remove IAuthService
        public LoginViewModel(HttpClient httpClient, IUserService userService, INotificationService notificationService, INavigation navigation = null)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _userService = userService; // Instance of ApiUserService
            _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
            _navigation = navigation;
            Debug.WriteLine($"LoginViewModel initialized with HttpClient: {_httpClient.BaseAddress}");
        }

        // Remove the old constructor that used ServiceHelper and IAuthService
        /*
        public LoginViewModel(IUserService userService, INavigation navigation)
        {
            _userService = userService;
            _authService = ServiceHelper.GetService<IAuthService>(); // Remove this
            _navigation = navigation;
            Debug.WriteLine("LoginViewModel initialized with user service only");
        }
        */

        // Check if username and password are provided
        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(Username) && 
                   !string.IsNullOrWhiteSpace(Password) && 
                   !IsBusy;
        }

        // Updated LoginAsync method to call API endpoint
        [RelayCommand(CanExecute = nameof(CanLogin))] 
        private async Task LoginAsync()
        {
            if (IsBusy) return;

            IsBusy = true;
            ErrorMessage = string.Empty;
            HasError = false;
            Debug.WriteLine($"Attempting login for user: {Username} via API endpoint {_httpClient.BaseAddress}api/auth/login");

            try
            {
                // Test API availability
                Debug.WriteLine("Testing API availability...");
                var healthCheckResponse = await _httpClient.GetAsync("health");
                Debug.WriteLine($"Health check status: {healthCheckResponse.StatusCode}");
                
                // Test root URL
                var rootResponse = await _httpClient.GetAsync("");
                Debug.WriteLine($"Root URL check status: {rootResponse.StatusCode}");

                var credentials = new Credentials { Username = Username, Password = Password };
                
                // Try with lowercase api prefix (this is the fix)
                Debug.WriteLine("Trying login with correct endpoint...");
                
                // Call the API login endpoint with the correct lowercase path
                var response = await _httpClient.PostAsJsonAsync("api/auth/login", credentials);
                
                // If failed, try one variation with different casing as fallback
                if (!response.IsSuccessStatusCode)
                {
                    Debug.WriteLine($"Login attempt failed with status: {response.StatusCode}");
                    Debug.WriteLine("Trying fallback to legacy capitalized Auth...");
                    response = await _httpClient.PostAsJsonAsync("api/Auth/login", credentials);
                }

                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the successful response
                    var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponseDto>();

                    if (loginResponse != null && !string.IsNullOrEmpty(loginResponse.Token))
                    {
                        // Store token and user info from API response
                        Preferences.Set("AuthToken", loginResponse.Token);
                        Preferences.Set("CurrentUsername", loginResponse.Username);
                        Preferences.Set("UserRole", loginResponse.Role);
                        Preferences.Set("CurrentUserId", loginResponse.UserId);

                        Debug.WriteLine($"Login successful - Token received from API for user {loginResponse.Username} (ID: {loginResponse.UserId})");

                        // Use a different navigation approach for the login->dashboard transition
                        // Since this is a shell reset, we can use absolute navigation here
                        Application.Current.MainPage = new AppShell();
                        await Shell.Current.GoToAsync("//ClerkDashboardView");

                        // Show success notification
                        var firstName = !string.IsNullOrWhiteSpace(loginResponse.Username) ? loginResponse.Username : "User";
                        await _notificationService.ShowSuccessNotificationAsync($"Welcome back, {firstName}!");

                        // Clear fields after successful navigation
                        Username = string.Empty;
                        Password = string.Empty;
                    }
                    else
                    {
                         ErrorMessage = "Login failed: Invalid response from server.";
                         HasError = true;
                         Debug.WriteLine("Login failed - Invalid response structure or empty token from API.");
                         Password = string.Empty; // Clear password
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    ErrorMessage = "Invalid username or password";
                    HasError = true;
                    Debug.WriteLine("Login failed - API returned 401 Unauthorized.");
                    Password = string.Empty; // Clear password field on failure
                }
                else
                {
                    // Handle other potential errors (like 400 Bad Request, 500 Internal Server Error)
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ErrorMessage = $"Login error ({response.StatusCode}): Please try again later."; // Generic error for user
                    HasError = true;
                    Debug.WriteLine($"Login failed - API returned {response.StatusCode}. Content: {errorContent}");
                    Password = string.Empty; // Clear password
                }
            }
            catch (HttpRequestException httpEx)
            {
                // Network or API connection error
                ErrorMessage = "Network error. Please check connection and API status.";
                HasError = true;
                Debug.WriteLine($"Login HTTP exception: {httpEx.Message}");
                Password = string.Empty;
            }
            catch (Exception ex)
            {
                // Other unexpected errors
                ErrorMessage = "An unexpected error occurred during login.";
                HasError = true;
                Debug.WriteLine($"Login general exception: {ex.Message}");
                Password = string.Empty;
            }
            finally
            {
                IsBusy = false;
            }
        }

        // Helper class to deserialize the API response
        private class LoginResponseDto
        {
            public string Token { get; set; }
            public string Username { get; set; }
            public string Role { get; set; }
            public int UserId { get; set; }
        }
    }
} 