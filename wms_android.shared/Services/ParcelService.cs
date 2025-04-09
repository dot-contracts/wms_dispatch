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
            var response = await _httpClient.GetAsync($"/api/parcels/qr/{qrCode}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Parcel>(content);
        }

        public async Task<int> GetParcelCountForDateAsync(DateTime date)
        {
            var response = await _httpClient.GetAsync($"count?date={date:yyyy-MM-dd}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return int.Parse(content);
        }

        public async Task DispatchParcelAsync(Parcel parcel)
        {
            var json = JsonSerializer.Serialize(parcel);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{parcel.Id}/dispatch", content);
            response.EnsureSuccessStatusCode();
        }
    }
}
