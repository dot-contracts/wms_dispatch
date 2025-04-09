using System.Threading.Tasks;

namespace wms_android.shared.Interfaces
{
    public interface IVanstoneHelper
    {
        bool InitializePrinter();
        void PrintSetAlign(int align);
        void PrintSetFont(int width, int height, int type);
        void PrintStr(string str);
        void PrintQrCode(string qrCode, int width, int height);
        void PrintFeedPaper(int lines);
        void PrintStart();
        Task StartScanAsync();
    }
} 