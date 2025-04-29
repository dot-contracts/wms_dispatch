using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using wms_android.shared.Interfaces;
using wms_android.shared.Models;
using wms_android.shared.Models.Auth;
using System.Diagnostics;

namespace wms_android.Services
{
    /// <summary>
    /// Client-side implementation of IUserService that interacts with the Web API.
    /// </summary>
    public class ApiUserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;

        public ApiUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Assuming API uses camelCase
            };
            Debug.WriteLine($"ApiUserService initialized with HttpClient BaseAddress: {_httpClient.BaseAddress}");
        }

        // Note: API endpoints assumed based on REST conventions. Verify with actual API implementation.

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            try
            {
                Debug.WriteLine($"ApiUserService: Authenticating {username} via API at {_httpClient.BaseAddress}api/users/authenticate");
                var credentials = new Credentials { Username = username, Password = password };
                var response = await _httpClient.PostAsJsonAsync("api/users/authenticate", credentials);

                if (response.IsSuccessStatusCode)
                {
                    var user = await response.Content.ReadFromJsonAsync<User>(_serializerOptions);
                    Debug.WriteLine($"ApiUserService: Authentication successful for {username}");
                    return user;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"ApiUserService: Authentication failed. Status: {response.StatusCode}, Reason: {response.ReasonPhrase}, Content: {errorContent}");
                    return null; // Or throw specific exception based on status code
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ApiUserService: Exception during AuthenticateAsync: {ex.Message}");
                // Consider more specific error handling or logging
                return null;
            }
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            try
            {
                Debug.WriteLine($"ApiUserService: Getting user by ID {id} from {_httpClient.BaseAddress}api/users/{id}");
                var response = await _httpClient.GetAsync($"api/users/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<User>(_serializerOptions);
                }
                 Debug.WriteLine($"ApiUserService: GetUserByIdAsync failed. Status: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                return null;
            }
            catch (Exception ex)
            {
                 Debug.WriteLine($"ApiUserService: Exception during GetUserByIdAsync: {ex.Message}");
                 return null;
            }
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
             try
            {
                Debug.WriteLine($"ApiUserService: Getting all users from {_httpClient.BaseAddress}api/users");
                var response = await _httpClient.GetAsync("api/users");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<IEnumerable<User>>(_serializerOptions);
                }
                Debug.WriteLine($"ApiUserService: GetUsersAsync failed. Status: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                return Enumerable.Empty<User>();
            }
            catch (Exception ex)
            {
                 Debug.WriteLine($"ApiUserService: Exception during GetUsersAsync: {ex.Message}");
                 return Enumerable.Empty<User>();
            }
        }

        public async Task<User> CreateUserAsync(User user)
        {
            // Usually client apps might not create users directly, but implement if needed
            Debug.WriteLine("ApiUserService: CreateUserAsync called (potentially needs API endpoint: POST api/users)");
            await Task.CompletedTask; // Placeholder
            // Example:
            // var response = await _httpClient.PostAsJsonAsync("api/users", user);
            // response.EnsureSuccessStatusCode();
            // return await response.Content.ReadFromJsonAsync<User>(_serializerOptions);
            throw new NotImplementedException("Client-side CreateUserAsync via API not fully implemented.");
        }

        public async Task<User> LoginAsync(Credentials credentials)
        {
            // This method is often redundant if AuthenticateAsync exists, but implement if needed
            Debug.WriteLine("ApiUserService: LoginAsync called, delegating to AuthenticateAsync");
            return await AuthenticateAsync(credentials.Username, credentials.Password);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            // Client apps might update their own profile, but perhaps not arbitrary users
            Debug.WriteLine($"ApiUserService: UpdateUserAsync called (potentially needs API endpoint: PUT api/users/{user.Id})");
            await Task.CompletedTask; // Placeholder
            // Example:
            // var response = await _httpClient.PutAsJsonAsync($"api/users/{user.Id}", user);
            // response.EnsureSuccessStatusCode();
            // return await response.Content.ReadFromJsonAsync<User>(_serializerOptions);
            throw new NotImplementedException("Client-side UpdateUserAsync via API not fully implemented.");
        }

        public async Task DeleteUserAsync(int id)
        {
            Debug.WriteLine($"ApiUserService: DeleteUserAsync called (potentially needs API endpoint: DELETE api/users/{id})");
            await Task.CompletedTask; // Placeholder
            // Example:
            // var response = await _httpClient.DeleteAsync($"api/users/{id}");
            // response.EnsureSuccessStatusCode();
             throw new NotImplementedException("Client-side DeleteUserAsync via API not fully implemented.");
        }

        public async Task<int> GetNewClientCountForDateAsync(DateTime date)
        {
             Debug.WriteLine($"ApiUserService: GetNewClientCountForDateAsync called (potentially needs API endpoint: GET api/users/stats/new-clients?date={date:yyyy-MM-dd})");
            // This might be more of an admin/reporting function, less common for client
            await Task.CompletedTask; // Placeholder
            // Example:
            // var response = await _httpClient.GetAsync($"api/users/stats/new-clients?date={date:yyyy-MM-dd}");
            // response.EnsureSuccessStatusCode();
            // var content = await response.Content.ReadAsStringAsync();
            // return int.Parse(content);
             throw new NotImplementedException("Client-side GetNewClientCountForDateAsync via API not fully implemented.");
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            try
            {
                Debug.WriteLine($"ApiUserService: Getting user by username {username} from {_httpClient.BaseAddress}api/users/username/{username}");
                // Note: Ensure API has an endpoint like GET api/users/username/{username}
                var response = await _httpClient.GetAsync($"api/users/username/{Uri.EscapeDataString(username)}"); 
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<User>(_serializerOptions);
                }
                Debug.WriteLine($"ApiUserService: GetUserByUsernameAsync failed. Status: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ApiUserService: Exception during GetUserByUsernameAsync: {ex.Message}");
                return null;
            }
        }
    }
} 