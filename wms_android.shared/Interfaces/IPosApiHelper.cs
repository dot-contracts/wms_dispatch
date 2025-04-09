using System.Threading.Tasks;

namespace wms_android.shared.Interfaces
{
    public interface IPosApiHelper
    {
        bool InitializePrinter();
        void PrintSetAlign(int align);
        void PrintSetFont(sbyte width, sbyte height, sbyte type);
        void PrintStr(string str);
        void PrintQrCode_Cut(string qrCode, int width, int height, string type);
        void PrintFeedPaper(int lines);
        void PrintStart();
        Task StartScanAsync();
    }
} 