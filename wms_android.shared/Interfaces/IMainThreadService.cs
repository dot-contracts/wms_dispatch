using System;
using System.Threading.Tasks;

namespace wms_android.shared.Interfaces
{
    public interface IMainThreadService
    {
        void BeginInvokeOnMainThread(Action action);
        Task InvokeOnMainThreadAsync(Action action);
        Task<T> InvokeOnMainThreadAsync<T>(Func<T> func);
    }
} 