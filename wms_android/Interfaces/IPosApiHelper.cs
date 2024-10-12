using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms_android.Interfaces
{
    public interface IPosApiHelper
    {
        Task<string> StartScanAsync(int timeoutSeconds);
    }
}
