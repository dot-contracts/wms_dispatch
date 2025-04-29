using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using wms_android.shared.Models;
using wms_android.shared.Interfaces;
using Microsoft.Extensions.Configuration;

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
            _httpClient.BaseAddress = new Uri(_baseUrl);
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
            try 
            {
                // Log the parcel data before sending
                System.Diagnostics.Debug.WriteLine($"Sending parcel data: {JsonSerializer.Serialize(parcel)}");

                var json = JsonSerializer.Serialize(parcel);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("/api/parcels", content);
                
                var responseContent = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"API Response: {response.StatusCode}, Content: {responseContent}");
                
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error saving parcel: {response.StatusCode}, Content: {responseContent}");
                }
                
                // Configure JsonSerializerOptions to handle camelCase
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                
                var savedParcel = JsonSerializer.Deserialize<Parcel>(responseContent, options);
                
                // Validate the deserialized object
                if (savedParcel == null)
                {
                    throw new Exception("Failed to deserialize parcel data from API response");
                }

                // Ensure we're using the original waybill number and QR code
                if (!string.IsNullOrEmpty(parcel.WaybillNumber))
                {
                    savedParcel.WaybillNumber = parcel.WaybillNumber;
                    savedParcel.QRCode = parcel.WaybillNumber;
                }
                
                // Log the final parcel data
                System.Diagnostics.Debug.WriteLine($"Final parcel data: {JsonSerializer.Serialize(savedParcel)}");
                
                return savedParcel;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"CreateParcelAsync error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        public async Task<string> GenerateWaybillNumberAsync()
        {
            try
            {
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

        public async Task CreateCartParcels(List<Parcel> parcels)
        {
            var json = JsonSerializer.Serialize(parcels);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/parcels/batch", content);
            response.EnsureSuccessStatusCode();
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
            var response = await _httpClient.GetAsync($"/api/parcels/waybill/{waybillNumber}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Parcel>(content);
        }

        public async Task<Parcel> GetParcelByQRCodeAsync(string qrCode)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Connecting to API at {_baseUrl}");
                System.Diagnostics.Debug.WriteLine($"Fetching parcel with QR code: {qrCode}");
                
                // First try to get it from the QR endpoint
                try 
                {
                    var qrResponse = await _httpClient.GetAsync($"/api/parcels/qr/{qrCode}");
                    
                    if (qrResponse.IsSuccessStatusCode)
                    {
                        var content = await qrResponse.Content.ReadAsStringAsync();
                        System.Diagnostics.Debug.WriteLine($"QR API Response: {qrResponse.StatusCode}, Content: {content}");
                        
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                        };
                        
                        var parcel = JsonSerializer.Deserialize<Parcel>(content, options);
                        
                        if (parcel != null)
                        {
                            System.Diagnostics.Debug.WriteLine($"Successfully deserialized parcel with id {parcel.Id}");
                            return parcel;
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"QR API Response failed: {qrResponse.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error fetching by QR code: {ex.Message}");
                    // Continue to try the waybill endpoint
                }
                
                // If QR lookup fails, try the waybill endpoint as fallback
                System.Diagnostics.Debug.WriteLine($"Trying to fetch parcel using waybill endpoint: {qrCode}");
                var waybillResponse = await _httpClient.GetAsync($"/api/parcels/waybill/{qrCode}");
                
                var waybillContent = await waybillResponse.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"Waybill API Response: {waybillResponse.StatusCode}, Content: {waybillContent}");
                
                if (!waybillResponse.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"API error: {waybillResponse.StatusCode}, Content: {waybillContent}");
                }
                
                var waybillOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                
                var waybillParcel = JsonSerializer.Deserialize<Parcel>(waybillContent, waybillOptions);
                
                if (waybillParcel == null)
                {
                    throw new Exception("Failed to deserialize parcel data from API response");
                }
                
                System.Diagnostics.Debug.WriteLine($"Successfully fetched parcel via waybill endpoint: {waybillParcel.Id}");
                return waybillParcel;
            }
            catch (HttpRequestException ex)
            {
                System.Diagnostics.Debug.WriteLine($"HTTP error in GetParcelByQRCodeAsync: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetParcelByQRCodeAsync: {ex.Message}");
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
    }
}
