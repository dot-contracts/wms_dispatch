using System.Threading.Tasks;

namespace wms_android.shared.Interfaces
{
    public interface IQRScannerService
    {
        Task<string> StartScanAsync();
        void StopScan();
        bool IsScanning { get; }
    }
} 