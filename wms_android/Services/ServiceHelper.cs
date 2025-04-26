using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace wms_android.Services
{
    public static class ServiceHelper
    {
        // Add a static Services property for our temporary workaround
        private static IServiceProvider _services;
        public static IServiceProvider Services
        {
            get => _services;
            set => _services = value;
        }

        public static T GetService<T>() where T : class
        {
            // First try to get from static Services (our workaround)
            if (_services != null)
            {
                var service = _services.GetService<T>();
                if (service != null)
                    return service;
            }
            
            // If not found, use the normal MauiContext approach
            if (Application.Current?.Handler?.MauiContext == null)
                return null;
                
            return Application.Current.Handler.MauiContext.Services.GetService<T>();
        }
    }
}
