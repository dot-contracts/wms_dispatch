//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//#if ANDROID
//using Android.Content;
//using Android.OS;
//using AndroidPosSdk;
//#endif

//namespace wms_android.Services
//{
//    public class PosService
//    {
//#if ANDROID
//        private ICiontekPosService _posService;

//        public PosService(Context context)
//        {
//            var serviceConnection = new PosServiceConnection(this);
//            var intent = new Intent("com.yourpackage.PosService");
//            context.BindService(intent, serviceConnection, Bind.AutoCreate);
//        }

//        public void PrintReceipt(string receiptData)
//        {
//            // Use the _posService object to call methods on the service.
//            _posService?.Print(receiptData);
//        }

//        private class PosServiceConnection : Java.Lang.Object, IServiceConnection
//        {
//            private PosService _service;

//            public PosServiceConnection(PosService service)
//            {
//                _service = service;
//            }

//            public void OnServiceConnected(ComponentName name, IBinder binder)
//            {
//                _service._posService = ICiontekPosServiceStub.AsInterface(binder);
//            }

//            public void OnServiceDisconnected(ComponentName name)
//            {
//                _service._posService = null;
//            }
//        }
//#endif
//    }
//}

