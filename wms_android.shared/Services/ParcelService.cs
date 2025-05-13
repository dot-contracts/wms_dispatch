using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using wms_android.shared.Models;
using wms_android.shared.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Threading;

namespace wms_android.shared.Services
{
    public class ParcelService : IParcelService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ParcelService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["ApiSettings:BaseUrl"] ?? "https://wmsandroidapi-w74du.ondigitalocean.app";
            
            // Configure HttpClient
            _httpClient.BaseAddress = new Uri(_baseUrl);
            _httpClient.Timeout = TimeSpan.FromSeconds(30); // Set default timeout
            
            // Add default headers
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "WMS-Android-App");
            
            System.Diagnostics.Debug.WriteLine($"ParcelService initialized with API URL: {_baseUrl}");
        }

        public async Task<IEnumerable<Parcel>> GetParcelsAsync()
        {
            var response = await _httpClient.GetAsync("/api/parcels");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Parcel>>(content);
        }

        public async Task<Parcel> GetParcelByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"/api/parcels/{id}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Parcel>(content);
        }

        public async Task<Parcel> CreateParcelAsync(Parcel parcel)
        {
            // Maximum number of retries
            const int maxRetries = 3;
            
            // Initial delay in milliseconds (500ms)
            int retryDelay = 500;
            
            // Track retry attempts
            int retryAttempt = 0;
            
            while (true)
            {
                try 
            {
                // Ensure the waybill number is set before sending to the server
                if (string.IsNullOrEmpty(parcel.WaybillNumber))
                {
                    parcel.WaybillNumber = await GenerateWaybillNumberAsync();
                    parcel.QRCode = parcel.WaybillNumber;
                }
                
                // Ensure CreatedAt is current UTC time before sending to the API
                System.Diagnostics.Debug.WriteLine($"[ParcelService] Before override, parcel.CreatedAt: {parcel.CreatedAt}, Kind: {parcel.CreatedAt.Kind}");
                parcel.CreatedAt = DateTime.UtcNow;
                System.Diagnostics.Debug.WriteLine($"[ParcelService] After override, parcel.CreatedAt: {parcel.CreatedAt}, Kind: {parcel.CreatedAt.Kind}");
                
                // Log the parcel data before sending
                System.Diagnostics.Debug.WriteLine($"Sending parcel data: {JsonSerializer.Serialize(parcel)}");

                var json = JsonSerializer.Serialize(parcel);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    
                    // Use a timeout that increases with each retry to give more time on problematic connections
                    var timeoutMs = 10000 + (retryAttempt * 5000); // 10s base + 5s per retry
                    var cancellationToken = new CancellationTokenSource(timeoutMs).Token;
                    
                    var response = await _httpClient.PostAsync("/api/parcels", content, cancellationToken);
                
                var responseContent = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"API Response: {response.StatusCode}, Content: {responseContent}");
                
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error saving parcel: {response.StatusCode}, Content: {responseContent}");
                }
                
                // Configure JsonSerializerOptions to handle camelCase AND preserved references
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
                };
                
                var savedParcel = JsonSerializer.Deserialize<Parcel>(responseContent, options);
                
                // Validate the deserialized object
                if (savedParcel == null)
                {
                    throw new Exception("Failed to deserialize parcel data from API response");
                }

                // Always use our original waybill number and QR code
                // This ensures server-generated values don't override our format
                savedParcel.WaybillNumber = parcel.WaybillNumber;
                savedParcel.QRCode = parcel.WaybillNumber;
                
                // Log the final parcel data
                System.Diagnostics.Debug.WriteLine($"Final parcel data: {JsonSerializer.Serialize(savedParcel)}");
                
                return savedParcel;
            }
            catch (Exception ex)
            {
                    retryAttempt++;
                    
                    bool isTransientError = IsTransientError(ex);
                    bool shouldRetry = isTransientError && retryAttempt < maxRetries;
                    
                System.Diagnostics.Debug.WriteLine($"CreateParcelAsync error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                    
                    if (shouldRetry)
                    {
                        System.Diagnostics.Debug.WriteLine($"Retrying API call (attempt {retryAttempt}/{maxRetries}) after {retryDelay}ms due to transient error: {ex.Message}");
                        
                        // Wait before retrying with exponential backoff
                        await Task.Delay(retryDelay);
                        
                        // Exponential backoff: double the delay for next retry
                        retryDelay *= 2;
                    }
                    else
                    {
                        // If we've exhausted our retries or it's not a transient error, rethrow
                        System.Diagnostics.Debug.WriteLine($"Not retrying: isTransientError={isTransientError}, retryAttempt={retryAttempt}");
                throw;
                    }
                }
            }
        }
        
        // Helper method to determine if an error is transient/temporary
        private bool IsTransientError(Exception ex)
        {
            // Look for common network-related exceptions
            if (ex is HttpRequestException || 
                ex is TaskCanceledException || 
                ex is OperationCanceledException ||
                ex is TimeoutException)
            {
                // Check for common connection reset/network errors in the message
                string errorMsg = ex.Message.ToLowerInvariant();
                if (errorMsg.Contains("reset") || 
                    errorMsg.Contains("connection") || 
                    errorMsg.Contains("network") ||
                    errorMsg.Contains("timeout") ||
                    errorMsg.Contains("ssl") ||
                    errorMsg.Contains("handshake") ||
                    errorMsg.Contains("i/o error"))
                {
                    return true;
                }
            }
            
            // Check inner exception too
            if (ex.InnerException != null)
            {
                string innerMsg = ex.InnerException.Message.ToLowerInvariant();
                if (innerMsg.Contains("reset") || 
                    innerMsg.Contains("connection") || 
                    innerMsg.Contains("network") ||
                    innerMsg.Contains("timeout") ||
                    innerMsg.Contains("ssl") ||
                    innerMsg.Contains("handshake") ||
                    innerMsg.Contains("i/o error"))
                {
                    return true;
                }
            }
            
            return false;
        }

        public async Task<string> GenerateWaybillNumberAsync()
        {
            try
            {
                // Generate a waybill number locally with the format "WB" + 5 random alphanumeric characters
                System.Diagnostics.Debug.WriteLine("Generating local waybill number...");
                
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var random = new Random();
                var randomString = new string(Enumerable.Repeat(chars, 5)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                
                var waybillNumber = $"WB{randomString}";
                
                System.Diagnostics.Debug.WriteLine($"Generated waybill number: {waybillNumber}");
                return waybillNumber;
                
                /* Commented out API call
                System.Diagnostics.Debug.WriteLine("Calling API to generate waybill number...");
                var response = await _httpClient.GetAsync("/api/parcels/waybill/generate");
                var content = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"API response: Status={response.StatusCode}, Content={content}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Failed to generate waybill number. Status: {response.StatusCode}, Content: {content}");
                }

                // Parse the response - remove any quotes that might be present
                var waybillNumber = content.Trim('"');
                System.Diagnostics.Debug.WriteLine($"Generated waybill number: {waybillNumber}");
                return waybillNumber;
                */
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GenerateWaybillNumberAsync: {ex}");
                throw;
            }
        }

        public async Task FinalizeWaybillAsync(Guid parcelId)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Starting FinalizeWaybillAsync for parcel ID: {parcelId}");
                var response = await _httpClient.PostAsync($"/api/parcels/{parcelId}/finalize", null);
                var content = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"Finalize API Response: {response.StatusCode}, Content: {content}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Failed to finalize waybill. Status: {response.StatusCode}, Content: {content}");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FinalizeWaybillAsync: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        public async Task FinalizeWaybillAsync()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Starting parameterless FinalizeWaybillAsync - this is a compatibility wrapper");
                
                // Since no parcel ID is provided, we can't finalize a specific waybill
                // This is provided for backward compatibility only
                // Log a warning but don't throw an exception
                System.Diagnostics.Debug.WriteLine("WARNING: Calling FinalizeWaybillAsync without a parcel ID has no effect in the shared implementation");
                
                // Return completed task
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in parameterless FinalizeWaybillAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<List<Parcel>> CreateCartParcels(List<Parcel> parcels)
        {
            // Maximum number of retries
            const int maxRetries = 3;
            
            // Initial delay in milliseconds (500ms)
            int retryDelay = 500;
            
            // Track retry attempts
            int retryAttempt = 0;
            
            while (true)
            {
                try
            {
                // Ensure all parcels have waybill numbers before sending
                for (int i = 0; i < parcels.Count; i++)
                {
                    if (string.IsNullOrEmpty(parcels[i].WaybillNumber))
                    {
                        parcels[i].WaybillNumber = await GenerateWaybillNumberAsync();
                        parcels[i].QRCode = parcels[i].WaybillNumber;
                    }
                }
                
                // Log the parcels data before sending
                System.Diagnostics.Debug.WriteLine($"Sending batch parcels data, count: {parcels.Count}");
                
                var json = JsonSerializer.Serialize(parcels);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    
                    // Use a timeout that increases with each retry to give more time on problematic connections
                    var timeoutMs = 20000 + (retryAttempt * 10000); // 20s base + 10s per retry for batch operations
                    var cancellationToken = new CancellationTokenSource(timeoutMs).Token;
                    
                    var response = await _httpClient.PostAsync("/api/parcels/batch", content, cancellationToken);
                
                var responseContent = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"Batch API Response: {response.StatusCode}, Content length: {responseContent.Length}");
                
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error saving batch parcels: {response.StatusCode}");
                }
                
                // Configure JsonSerializerOptions to handle camelCase
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                
                var savedParcels = JsonSerializer.Deserialize<List<Parcel>>(responseContent, options);
                
                    if (savedParcels == null || savedParcels.Count == 0)
                    {
                        throw new Exception("Failed to deserialize parcel data or empty result returned");
                    }
                    
                    // Make sure all saved parcels have their waybill numbers set
                    for (int i = 0; i < savedParcels.Count; i++)
                    {
                        if (string.IsNullOrEmpty(savedParcels[i].WaybillNumber) && i < parcels.Count)
                {
                    savedParcels[i].WaybillNumber = parcels[i].WaybillNumber;
                    savedParcels[i].QRCode = parcels[i].WaybillNumber;
                }
                }
                
                    System.Diagnostics.Debug.WriteLine($"Successfully processed {savedParcels.Count} parcels");
                return savedParcels;
            }
            catch (Exception ex)
            {
                    retryAttempt++;
                    
                    bool isTransientError = IsTransientError(ex);
                    bool shouldRetry = isTransientError && retryAttempt < maxRetries;
                    
                System.Diagnostics.Debug.WriteLine($"CreateCartParcels error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                    
                    if (shouldRetry)
                    {
                        System.Diagnostics.Debug.WriteLine($"Retrying batch API call (attempt {retryAttempt}/{maxRetries}) after {retryDelay}ms due to transient error: {ex.Message}");
                        
                        // Wait before retrying with exponential backoff
                        await Task.Delay(retryDelay);
                        
                        // Exponential backoff: double the delay for next retry
                        retryDelay *= 2;
                    }
                    else
                    {
                        // If we've exhausted our retries or it's not a transient error, rethrow
                        System.Diagnostics.Debug.WriteLine($"Not retrying batch: isTransientError={isTransientError}, retryAttempt={retryAttempt}");
                throw;
                    }
                }
            }
        }

        public async Task<decimal> GetTotalSalesForDateAsync(DateTime date)
        {
            var response = await _httpClient.GetAsync($"/api/parcels/sales/{date:yyyy-MM-dd}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return decimal.Parse(content);
        }

        public async Task<IEnumerable<Parcel>> GetPendingOrdersAsync()
        {
            var response = await _httpClient.GetAsync("/api/parcels/pending");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Parcel>>(content);
        }

        public async Task<Parcel> GetParcelByWaybillNumberAsync(string waybillNumber)
        {
            if (string.IsNullOrWhiteSpace(waybillNumber))
            {
                System.Diagnostics.Debug.WriteLine("GetParcelByWaybillNumberAsync called with empty waybill.");
                return null;
            }
            
            try
            {
                System.Diagnostics.Debug.WriteLine($"Fetching parcel with Waybill: {waybillNumber}");
                var response = await _httpClient.GetAsync($"/api/parcels/waybill/{waybillNumber}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    System.Diagnostics.Debug.WriteLine($"Parcel with Waybill {waybillNumber} not found (404).");
                    return null; // Not found is not an error in this context
                }

                // Throw for other non-success codes
                response.EnsureSuccessStatusCode(); 

                var content = await response.Content.ReadAsStringAsync();
                
                // Handle potentially empty content even on success
                 if (string.IsNullOrWhiteSpace(content))
                 {
                     System.Diagnostics.Debug.WriteLine($"API returned success status but empty content for Waybill {waybillNumber}.");
                     return null; // Or throw depending on expected API contract
                 }

                try
                {
                    // Configure JsonSerializerOptions for robustness
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase 
                    };
                    var parcel = JsonSerializer.Deserialize<Parcel>(content, options);
                    System.Diagnostics.Debug.WriteLine($"Successfully deserialized parcel for Waybill {waybillNumber}. ID: {parcel?.Id}");
                    return parcel;
                }
                catch (JsonException jsonEx)
                {
                     System.Diagnostics.Debug.WriteLine($"JSON Deserialization failed for Waybill {waybillNumber}. Content: {content}. Error: {jsonEx.Message}");
                     // Throw a more specific error or return null depending on desired handling
                     throw new Exception($"Failed to parse response from API for Waybill {waybillNumber}.", jsonEx);
                }
            }
            catch (HttpRequestException httpEx)
            {
                 // Log error from EnsureSuccessStatusCode or network issue
                 System.Diagnostics.Debug.WriteLine($"HTTP request failed for Waybill {waybillNumber}: {httpEx.Message} (StatusCode: {httpEx.StatusCode})");
                 // Re-throw or handle specific status codes if needed
                 throw;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Generic error in GetParcelByWaybillNumberAsync for {waybillNumber}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<Parcel>> GetParcelsByQRCodeAsync(string qrCode)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Connecting to API at {_baseUrl}");
                System.Diagnostics.Debug.WriteLine($"Fetching parcels with QR code: {qrCode}");
                
                // API endpoint for fetching parcels by QR code (expected to return a list)
                var response = await _httpClient.GetAsync($"/api/parcels/qr/{qrCode}");
                
                var responseContent = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"QR API Response: {response.StatusCode}, Content: {responseContent}");

                if (!response.IsSuccessStatusCode)
                {
                    // If not found, return empty list, otherwise throw for actual errors.
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        System.Diagnostics.Debug.WriteLine($"No parcels found for QR code {qrCode} (404). Returning empty list.");
                        return Enumerable.Empty<Parcel>();
                    }
                    throw new HttpRequestException($"API error fetching parcels by QR code: {response.StatusCode}, Content: {responseContent}");
                }
                
                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    System.Diagnostics.Debug.WriteLine($"API returned success for QR code {qrCode} but content was empty. Returning empty list.");
                    return Enumerable.Empty<Parcel>();
                }

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                
                // Deserialize into a list of parcels
                var parcels = JsonSerializer.Deserialize<IEnumerable<Parcel>>(responseContent, options);
                
                if (parcels == null)
                {
                     System.Diagnostics.Debug.WriteLine($"Failed to deserialize parcel list for QR {qrCode}. Content: {responseContent}. Returning empty list.");
                    return Enumerable.Empty<Parcel>();
                }
                
                System.Diagnostics.Debug.WriteLine($"Successfully fetched {parcels.Count()} parcels via QR code: {qrCode}");
                return parcels;
            }
            catch (HttpRequestException ex)
            {
                System.Diagnostics.Debug.WriteLine($"HTTP error in GetParcelsByQRCodeAsync: {ex.Message}");
                // Depending on requirements, you might want to return an empty list or rethrow.
                // For now, rethrowing to make issues visible.
                throw; 
            }
            catch (JsonException jsonEx)
            {
                System.Diagnostics.Debug.WriteLine($"JSON Deserialization error in GetParcelsByQRCodeAsync for QR {qrCode}: {jsonEx.Message}");
                // Rethrow or return empty list
                throw;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetParcelsByQRCodeAsync for QR {qrCode}: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }

        public async Task<int> GetParcelCountForDateAsync(DateTime date)
        {
            var response = await _httpClient.GetAsync($"/api/parcels/count/{date:yyyy-MM-dd}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return int.Parse(content);
        }

        public async Task DispatchParcelAsync(Parcel parcel)
        {
            var json = JsonSerializer.Serialize(parcel);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"/api/parcels/{parcel.Id}/dispatch", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateParcelStatusAsync(Guid parcelId, ParcelStatus status)
        {
            var statusUpdate = new { Status = status };
            var json = JsonSerializer.Serialize(statusUpdate);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/parcels/{parcelId}/status", content);
            response.EnsureSuccessStatusCode();
        }

        // Dashboard methods implementation
        public async Task<int> GetParcelCountAsync(DateTime date)
        {
            // Reuse the existing count method
            return await GetParcelCountForDateAsync(date);
        }
        
        public async Task<int> GetDeliveredParcelCountAsync(DateTime date)
        {
            var response = await _httpClient.GetAsync($"/api/parcels/delivered/count/{date:yyyy-MM-dd}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return int.Parse(content);
        }
        
        public async Task<double> GetTotalSalesAsync(DateTime date)
        {
            // Reuse the existing sales method and convert to double
            var total = await GetTotalSalesForDateAsync(date);
            return (double)total;
        }
        
        // Dictionary to track SMS notifications at the service level
        private static readonly HashSet<Guid> _smsNotificationsSent = new HashSet<Guid>();
        
        /// <summary>
        /// Checks if an SMS notification has already been sent for a parcel
        /// </summary>
        /// <param name="parcelId">The ID of the parcel to check</param>
        /// <returns>True if a notification has been sent, false otherwise</returns>
        public Task<bool> CheckSmsNotificationSentAsync(Guid parcelId)
        {
            bool notificationSent = _smsNotificationsSent.Contains(parcelId);
            System.Diagnostics.Debug.WriteLine($"Checking if SMS sent for parcel {parcelId}: {notificationSent}");
            return Task.FromResult(notificationSent);
        }
        
        /// <summary>
        /// Marks that an SMS notification has been sent for a parcel
        /// </summary>
        /// <param name="parcelId">The ID of the parcel to mark</param>
        public Task MarkSmsNotificationSentAsync(Guid parcelId)
        {
            _smsNotificationsSent.Add(parcelId);
            System.Diagnostics.Debug.WriteLine($"Marked SMS as sent for parcel {parcelId}");
            return Task.CompletedTask;
        }
    }
}
