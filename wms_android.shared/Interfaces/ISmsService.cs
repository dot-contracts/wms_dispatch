using System.Threading.Tasks;

namespace wms_android.shared.Interfaces
{
    public interface ISmsService
    {
        Task<bool> SendSmsAsync(string phoneNumber, string message);
    }
} 