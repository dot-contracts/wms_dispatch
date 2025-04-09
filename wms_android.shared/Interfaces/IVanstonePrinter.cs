using System.Threading.Tasks;

namespace wms_android.shared.Interfaces
{
    public interface IVanstonePrinter
    {
        Task<bool> InitPrinter();
        Task<bool> PrintReceipt(string content);
        Task<bool> PrintLabel(string content);
        Task<bool> ClosePrinter();
        void SetFontSize(int size);
        void PrintText(string text);
        void PrintBarcode(string data, int type, int width, int height);
        void PrintQRCode(string data, int size);
        void CutPaper();
    }
} 