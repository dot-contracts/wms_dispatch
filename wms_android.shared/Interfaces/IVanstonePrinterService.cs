using System.Threading.Tasks;

namespace wms_android.shared.Interfaces
{
    public interface IVanstonePrinterService
    {
        Task<bool> InitializePrinterAsync();
        Task<bool> PrintReceiptAsync(string content);
        Task<bool> PrintLabelAsync(string content);
        Task<bool> CutPaperAsync();
        Task<bool> OpenCashDrawerAsync();
        Task<bool> CloseCashDrawerAsync();
    }
} 