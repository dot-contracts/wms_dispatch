using wms_android.shared.Models;

namespace wms_android.shared.Interfaces
{
    public interface IPrinterService
    {
        Task<bool> InitializePrinter();
        Task<bool> PrintReceipt(Parcel parcel);
        Task<bool> PrintHeader(string header);
        Task<bool> PrintLine(string line);
        Task<bool> PrintBarcode(string barcode);
        Task<bool> PrintQRCode(string qrCode);
        Task<bool> CutPaper();
        bool IsInitialized { get; }
    }
} 