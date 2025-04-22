using System;
using System.Diagnostics;
using System.Threading.Tasks;
using wms_android.Interfaces;
using wms_android.Services;
using Com.Vanstone.Trans.Api;

namespace wms_android.Utils
{
    /// <summary>
    /// Utility class to help with printer diagnostics and troubleshooting
    /// </summary>
    public static class PrinterDiagnostics
    {
        private const string TAG = "PrinterDiagnostics";
        
        /// <summary>
        /// Run a diagnostic test on the printer to verify it's working correctly
        /// </summary>
        /// <returns>Diagnostic result information</returns>
        public static async Task<DiagnosticResult> RunDiagnosticTest()
        {
            var result = new DiagnosticResult();
            result.DeviceModel = Android.OS.Build.Model;
            result.StartedAt = DateTime.Now;
            
            try
            {
                Debug.WriteLine($"{TAG}: Starting printer diagnostic test");
                
                // 1. Check if printer is initialized
                result.InitializationStatus = PrinterInitializationService.IsInitialized;
                Debug.WriteLine($"{TAG}: Printer initialized: {result.InitializationStatus}");
                
                if (!result.InitializationStatus)
                {
                    Debug.WriteLine($"{TAG}: Attempting to initialize printer");
                    PrinterInitializationService.Initialize();
                    await Task.Delay(2000); // Give the printer time to initialize
                    result.InitializationStatus = PrinterInitializationService.IsInitialized;
                    Debug.WriteLine($"{TAG}: Printer initialized after attempt: {result.InitializationStatus}");
                    
                    if (!result.InitializationStatus)
                    {
                        result.ErrorMessage = "Failed to initialize printer";
                        result.CompletedAt = DateTime.Now;
                        result.Success = false;
                        return result;
                    }
                }
                
                // 2. Get printer implementation
                var printer = PrinterInitializationService.GetPrinterHelper();
                result.PrinterType = printer?.GetType().Name;
                Debug.WriteLine($"{TAG}: Printer implementation: {result.PrinterType}");
                
                if (printer == null)
                {
                    result.ErrorMessage = "No printer implementation available";
                    result.CompletedAt = DateTime.Now;
                    result.Success = false;
                    return result;
                }
                
                // Check if the printer hardware is available by checking status
                if (printer is VanstonePosApiHelper vanstonePrinter)
                {
                    int statusResult = PrinterApi.PrnStatus_Api();
                    Debug.WriteLine($"{TAG}: Printer status check: {statusResult}");
                    if (statusResult != 0)
                    {
                        result.ErrorMessage = $"Printer hardware not ready. Status code: {statusResult}";
                        result.CompletedAt = DateTime.Now;
                        result.Success = false;
                        return result;
                    }
                }
                
                // 3. Test basic printer functions with delays between operations
                bool alignSuccess = TestPrinterOperation(() => printer.PrintSetAlign(1));
                result.TestResults.Add("Set Alignment", alignSuccess);
                if (!alignSuccess) result.FailedTests.Add("Set Alignment");
                await Task.Delay(200);
                
                bool fontSuccess = TestPrinterOperation(() => printer.PrintSetFont(8, 8, 0));
                result.TestResults.Add("Set Font", fontSuccess);
                if (!fontSuccess) result.FailedTests.Add("Set Font");
                await Task.Delay(200);
                
                bool printSuccess = TestPrinterOperation(() => printer.PrintStr("Printer Diagnostic Test\n"));
                result.TestResults.Add("Print Text", printSuccess);
                if (!printSuccess) result.FailedTests.Add("Print Text");
                await Task.Delay(200);
                
                bool feedSuccess = TestPrinterOperation(() => printer.PrintFeedPaper(50));
                result.TestResults.Add("Feed Paper", feedSuccess);
                if (!feedSuccess) result.FailedTests.Add("Feed Paper");
                await Task.Delay(200);
                
                // 4. Start printing
                bool startSuccess = TestPrinterOperation(() => printer.PrintStart());
                result.TestResults.Add("Print Start", startSuccess);
                if (!startSuccess) result.FailedTests.Add("Print Start");
                
                result.Success = !result.TestResults.ContainsValue(false);
                result.CompletedAt = DateTime.Now;
                
                if (!result.Success)
                {
                    result.ErrorMessage = $"Failed tests: {string.Join(", ", result.FailedTests)}";
                }
                
                Debug.WriteLine($"{TAG}: Diagnostic test completed. Success: {result.Success}");
                if (!result.Success)
                {
                    Debug.WriteLine($"{TAG}: Failed tests: {string.Join(", ", result.FailedTests)}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{TAG}: Error during diagnostic test: {ex.Message}");
                Debug.WriteLine($"{TAG}: Stack trace: {ex.StackTrace}");
                result.Success = false;
                result.ErrorMessage = $"Exception: {ex.Message}";
                result.CompletedAt = DateTime.Now;
            }
            
            return result;
        }
        
        /// <summary>
        /// Reset the printer in case of problems
        /// </summary>
        /// <returns>True if reset was successful</returns>
        public static bool ResetPrinter()
        {
            try
            {
                Debug.WriteLine($"{TAG}: Resetting printer");
                return PrinterInitializationService.ResetPrinter();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{TAG}: Error resetting printer: {ex.Message}");
                Debug.WriteLine($"{TAG}: Stack trace: {ex.StackTrace}");
                return false;
            }
        }
        
        /// <summary>
        /// Print a test page to verify basic printer functionality
        /// </summary>
        /// <returns>True if successful</returns>
        public static async Task<bool> PrintTestPage()
        {
            try
            {
                Debug.WriteLine($"{TAG}: Printing test page");
                
                // Get printer implementation
                var printer = PrinterInitializationService.GetPrinterHelper();
                
                if (printer == null)
                {
                    Debug.WriteLine($"{TAG}: No printer implementation available");
                    return false;
                }
                
                // Set alignment for header
                printer.PrintSetAlign(1);
                
                // Set font
                printer.PrintSetFont(8, 8, 0x33);
                
                // Print header
                printer.PrintStr("Printer Test Page\n");
                
                // Normal font
                printer.PrintSetFont(8, 8, 0);
                
                // Print system info
                printer.PrintStr($"Date: {DateTime.Now}\n");
                printer.PrintStr($"Device Model: {Android.OS.Build.Model}\n");
                printer.PrintStr($"Android Version: {Android.OS.Build.VERSION.Release}\n");
                printer.PrintStr($"Printer Type: {printer.GetType().Name}\n");
                
                // Left alignment
                printer.PrintSetAlign(0);
                
                // Print test patterns
                printer.PrintStr("--- Text Formatting Test ---\n");
                
                // Font sizes
                printer.PrintSetFont(8, 8, 0);
                printer.PrintStr("Normal Text\n");
                
                printer.PrintSetFont(8, 8, 0x33);
                printer.PrintStr("Bold Text\n");
                
                printer.PrintSetFont(16, 16, 0);
                printer.PrintStr("Large Text\n");
                
                printer.PrintSetFont(8, 8, 0);
                
                // Alignments
                printer.PrintStr("--- Alignment Test ---\n");
                
                printer.PrintSetAlign(0);
                printer.PrintStr("Left aligned\n");
                
                printer.PrintSetAlign(1);
                printer.PrintStr("Center aligned\n");
                
                printer.PrintSetAlign(2);
                printer.PrintStr("Right aligned\n");
                
                // QR code
                printer.PrintSetAlign(1);
                printer.PrintStr("--- QR Code Test ---\n");
                printer.PrintQrCode_Cut("https://ficmalogistics.com", 200, 200, "QR_CODE");
                
                // Feed paper
                printer.PrintFeedPaper(100);
                
                // Start printing
                int result = printer.PrintStart();
                
                Debug.WriteLine($"{TAG}: Test page print result: {result}");
                return result == 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{TAG}: Error printing test page: {ex.Message}");
                Debug.WriteLine($"{TAG}: Stack trace: {ex.StackTrace}");
                return false;
            }
        }
        
        /// <summary>
        /// Test a printer operation and return success/failure
        /// </summary>
        private static bool TestPrinterOperation(Func<int> operation)
        {
            try
            {
                int result = operation();
                Debug.WriteLine($"{TAG}: Operation result code: {result}");
                if (result != 0)
                {
                    Debug.WriteLine($"{TAG}: Operation failed with code: {result}");
                    if (result == -100)
                    {
                        Debug.WriteLine($"{TAG}: Printer not initialized properly");
                    }
                    else if (result < 0)
                    {
                        Debug.WriteLine($"{TAG}: Error code indicates hardware/communication issue");
                    }
                }
                return result == 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{TAG}: Exception during printer operation: {ex.Message}");
                Debug.WriteLine($"{TAG}: Stack trace: {ex.StackTrace}");
                return false;
            }
        }
    }
    
    /// <summary>
    /// Result of printer diagnostic test
    /// </summary>
    public class DiagnosticResult
    {
        public DiagnosticResult()
        {
            TestResults = new System.Collections.Generic.Dictionary<string, bool>();
            FailedTests = new System.Collections.Generic.List<string>();
        }
        
        // Basic information
        public string DeviceModel { get; set; }
        public string PrinterType { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        
        // Test results
        public bool InitializationStatus { get; set; }
        public System.Collections.Generic.Dictionary<string, bool> TestResults { get; set; }
        public System.Collections.Generic.List<string> FailedTests { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        
        public override string ToString()
        {
            return $"Diagnostic Result:\n" +
                   $"Device: {DeviceModel}\n" +
                   $"Printer: {PrinterType}\n" +
                   $"Initialized: {InitializationStatus}\n" +
                   $"Success: {Success}\n" +
                   $"Error: {ErrorMessage ?? "None"}\n" +
                   $"Failed Tests: {(FailedTests.Count > 0 ? string.Join(", ", FailedTests) : "None")}\n" +
                   $"Started: {StartedAt}\n" +
                   $"Completed: {CompletedAt}\n" +
                   $"Duration: {(CompletedAt - StartedAt).TotalSeconds:0.00}s";
        }
    }
} 