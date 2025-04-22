using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using wms_android.shared.Interfaces;
using wms_android.shared.Models;
using Newtonsoft.Json;
using System.Text.Json;
using System.Diagnostics;
using Microsoft.Maui.Networking;
using Microsoft.Maui.ApplicationModel;

namespace wms_android.Services
{
    public class SmsService : ISmsService
    {
        private readonly HttpClient _httpClient;
        private readonly string _server;
        private readonly string _userId;
        private readonly string _password;
        private readonly string _senderName;
        private readonly IConnectivity _connectivity;

        public SmsService()
        {
            _httpClient = new HttpClient();
            
            // Load the SMS API credentials from app settings
            _server = "https://smsportal.hostpinnacle.co.ke/SMSApi/send"; // Try more specific endpoint
            _userId = "ficmahome";
            _password = "QjfNg17q";
            _senderName = "Ficma_Home";
            
            // Get the connectivity service
            try
            {
                _connectivity = ServiceHelper.GetService<IConnectivity>();
                if (_connectivity != null)
                {
                    Debug.WriteLine("Successfully obtained connectivity service");
                }
                else
                {
                    Debug.WriteLine("Connectivity service returned null from ServiceHelper");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error obtaining connectivity service: {ex.Message}");
                // Do not throw here, the service will work with reduced functionality
            }
            
            Debug.WriteLine("SMS Service initialized");
        }

        /// <summary>
        /// Checks if the device has internet connectivity
        /// </summary>
        private bool IsConnected()
        {
            // If connectivity service is unavailable, assume we're connected
            // This allows SMS to be sent even if we can't check connectivity
            if (_connectivity == null)
            {
                Debug.WriteLine("Connectivity service is not available, assuming connected");
                return true;
            }
            
            var isConnected = _connectivity.NetworkAccess == NetworkAccess.Internet;
            Debug.WriteLine($"Network status: {_connectivity.NetworkAccess}, Is connected: {isConnected}");
            return isConnected;
        }

        /// <summary>
        /// Sends an SMS message to the specified phone number
        /// </summary>
        public async Task<bool> SendSmsAsync(string phoneNumber, string message)
        {
            try
            {
                Debug.WriteLine($"Attempting to send SMS to {phoneNumber}");
                
                // Check for internet connectivity
                if (!IsConnected())
                {
                    Debug.WriteLine("Cannot send SMS: No internet connectivity");
                    return false;
                }
                
                // Ensure phone number is in the correct format (should start with country code)
                if (!phoneNumber.StartsWith("+"))
                {
                    // Convert to international format
                    if (phoneNumber.StartsWith("0"))
                    {
                        phoneNumber = "+254" + phoneNumber.Substring(1);
                    }
                    else
                    {
                        // Assume it's already without the leading zero but needs country code
                        phoneNumber = "+254" + phoneNumber;
                    }
                }
                
                Debug.WriteLine($"Formatted phone number: {phoneNumber}");
                Debug.WriteLine($"Message to send: {message}");

                // Set shorter timeout for faster feedback
                _httpClient.Timeout = TimeSpan.FromSeconds(10);
                
                // Try the form URL encoded approach first - this is the recommended approach based on API docs
                Debug.WriteLine("Trying the form-encoded approach first (recommended by API docs)");
                if (await TryFormUrlEncodedApproach(phoneNumber, message))
                {
                    return true;
                }
                
                // If form approach didn't work, try JSON
                Debug.WriteLine("Form approach failed, trying JSON approach");
                if (await TryJsonBodyApproach(phoneNumber, message))
                {
                    return true;
                }
                
                // Finally try query parameters as last resort
                Debug.WriteLine("JSON approach failed, trying query parameters approach");
                if (await TryQueryParameterApproach(phoneNumber, message))
                {
                    return true;
                }
                
                // All approaches failed
                Debug.WriteLine("All SMS sending approaches failed");
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in SendSmsAsync: {ex.Message}");
                Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                return false;
            }
        }
        
        /// <summary>
        /// Try sending SMS using query parameters in a GET request
        /// </summary>
        private async Task<bool> TryQueryParameterApproach(string phoneNumber, string message)
        {
            Debug.WriteLine("Trying GET request with query parameters approach");
            var queryString = $"?userid={_userId}&password={_password}&mobile={phoneNumber}&msg={Uri.EscapeDataString(message)}&senderid={_senderName}&msgType=text&sendMethod=quick&output=json";
            
            string[] endpoints = {
                "https://smsportal.hostpinnacle.co.ke/SMSApi/send",
                "https://smsportal.hostpinnacle.co.ke/SMSApi"
            };
            
            foreach (var endpoint in endpoints)
            {
                try
                {
                    Debug.WriteLine($"Trying GET endpoint: {endpoint}");
                    var fullUrl = endpoint + queryString;
                    
                    var response = await _httpClient.GetAsync(fullUrl);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"GET response ({response.StatusCode}): {responseContent}");
                    
                    if (response.IsSuccessStatusCode)
                    {
                        // Check actual API response status (not just HTTP status)
                        try
                        {
                            var apiResponse = JsonConvert.DeserializeObject<dynamic>(responseContent);
                            if (apiResponse != null && apiResponse.status == "success")
                            {
                                Debug.WriteLine("GET request succeeded with API status success");
                                return true;
                            }
                            else
                            {
                                var reason = apiResponse?.reason ?? "Unknown error";
                                Debug.WriteLine($"GET request failed despite HTTP 200: {reason}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Error parsing GET response: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"GET request failed: {ex.Message}");
                }
            }
            
            Debug.WriteLine("All GET attempts failed");
            return false;
        }
        
        /// <summary>
        /// Try sending SMS using form URL encoded data in a POST request
        /// </summary>
        private async Task<bool> TryFormUrlEncodedApproach(string phoneNumber, string message)
        {
            Debug.WriteLine("Trying POST request with form URL encoded data approach");
            
            // According to HostPinnacle SMS API documentation, the correct parameters are:
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("userid", _userId),
                new KeyValuePair<string, string>("password", _password),
                new KeyValuePair<string, string>("mobile", phoneNumber),
                new KeyValuePair<string, string>("msg", message),
                new KeyValuePair<string, string>("senderid", _senderName),
                new KeyValuePair<string, string>("msgType", "text"),
                new KeyValuePair<string, string>("sendMethod", "quick"),
                new KeyValuePair<string, string>("output", "json")
            });
            
            string endpoint = "https://smsportal.hostpinnacle.co.ke/SMSApi/send";
            
            try
            {
                Debug.WriteLine($"Trying form POST endpoint with correct parameters: {endpoint}");
                Debug.WriteLine($"Request parameters: userid={_userId}, mobile={phoneNumber}, senderid={_senderName}, msgType=text, sendMethod=quick");
                
                var response = await _httpClient.PostAsync(endpoint, formContent);
                var responseContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine($"Form POST response ({response.StatusCode}): {responseContent}");
                
                if (response.IsSuccessStatusCode)
                {
                    // Check actual API response status (not just HTTP status)
                    try
                    {
                        var apiResponse = JsonConvert.DeserializeObject<dynamic>(responseContent);
                        if (apiResponse != null && (
                            apiResponse.status == "success" || 
                            apiResponse.statusCode == "200" || 
                            (apiResponse.code != null && apiResponse.code == "ok")))
                        {
                            Debug.WriteLine("Form POST request succeeded with API status success");
                            return true;
                        }
                        else
                        {
                            var reason = apiResponse?.reason ?? "Unknown error";
                            Debug.WriteLine($"Form POST request failed despite HTTP 200: {reason}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error parsing form POST response: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Form POST request failed: {ex.Message}");
            }
            
            Debug.WriteLine("Form POST approach failed");
            return false;
        }
        
        /// <summary>
        /// Try sending SMS using JSON body in a POST request
        /// </summary>
        private async Task<bool> TryJsonBodyApproach(string phoneNumber, string message)
        {
            Debug.WriteLine("Trying POST request with JSON body approach");
            
            var smsPayload = new
            {
                userid = _userId,
                password = _password,
                mobile = phoneNumber,
                msg = message,
                senderid = _senderName,
                msgType = "text",
                sendMethod = "quick",
                output = "json"
            };
            
            var jsonContent = JsonConvert.SerializeObject(smsPayload);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            
            string[] endpoints = {
                "https://smsportal.hostpinnacle.co.ke/SMSApi/send",
                "https://smsportal.hostpinnacle.co.ke/SMSApi"
            };
            
            foreach (var endpoint in endpoints)
            {
                try
                {
                    Debug.WriteLine($"Trying JSON POST endpoint: {endpoint}");
                    
                    var response = await _httpClient.PostAsync(endpoint, content);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"JSON POST response ({response.StatusCode}): {responseContent}");
                    
                    if (response.IsSuccessStatusCode)
                    {
                        // Check actual API response status (not just HTTP status)
                        try
                        {
                            var apiResponse = JsonConvert.DeserializeObject<dynamic>(responseContent);
                            if (apiResponse != null && apiResponse.status == "success")
                            {
                                Debug.WriteLine("JSON POST request succeeded with API status success");
                                return true;
                            }
                            else
                            {
                                var reason = apiResponse?.reason ?? "Unknown error";
                                Debug.WriteLine($"JSON POST request failed despite HTTP 200: {reason}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Error parsing JSON POST response: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"JSON POST request failed: {ex.Message}");
                }
            }
            
            Debug.WriteLine("All JSON POST attempts failed");
            return false;
        }

        /// <summary>
        /// Sends a parcel pickup notification SMS to the specified phone number
        /// </summary>
        public async Task<bool> SendParcelPickupNotificationAsync(
            string receiverPhone,
            string receiverName,
            string senderName,
            string senderPhone,
            int quantity,
            string destination,
            decimal amount,
            string paymentMethod,
            string waybillNumber)
        {
            Debug.WriteLine($"Preparing to send notification SMS to {receiverName} at {receiverPhone}");
            
            // Generate the message using the SmsTemplate
            string message = SmsTemplate.GenerateParcelPickupMessage(
                receiverName,
                senderName,
                senderPhone,
                quantity,
                destination,
                amount,
                paymentMethod,
                waybillNumber);

            // Send the message
            var result = await SendSmsAsync(receiverPhone, message);
            Debug.WriteLine($"SMS notification to {receiverName} send result: {(result ? "SUCCESS" : "FAILED")}");
            
            return result;
        }
    }
} 