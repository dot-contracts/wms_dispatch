using Android.Content;
using wms_android.Services;
using Microsoft.Maui.ApplicationModel;
using Application = Android.App.Application;
using wms_android.Interfaces;

[assembly: Dependency(typeof(QRScannerService))]
namespace wms_android.Services
{
    public class QRScannerService : IQRScannerService
    {
        public async Task<string> ScanQRCodeAsync()
        {
            //var scanner = new MobileBarcodeScanner
            //{
            //    TopText = "Hold your phone up to the QR code",
            //    BottomText = "Scanning will happen automatically"
            //};

            //var scanResult = await scanner.Scan();

            //if (scanResult != null)
            //{
            //    return scanResult.Text; // Return the scanned QR code
            //}

            return null; // Return null if no QR code is scanned
        }
    }
}
