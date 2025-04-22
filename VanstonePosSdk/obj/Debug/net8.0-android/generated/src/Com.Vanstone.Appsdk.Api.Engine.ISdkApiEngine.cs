using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Engine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']"
	[Register ("com/vanstone/appsdk/api/engine/SdkApiEngine", "", "Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker")]
	public partial interface ISdkApiEngine : global::Android.OS.IInterface {
		global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? ApnHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getApnHandler' and count(parameter)=0]"
			[Register ("getApnHandler", "()Lcom/vanstone/appsdk/api/common/ApnHandler;", "GetGetApnHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? At24cXXHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getAt24cXXHandler' and count(parameter)=0]"
			[Register ("getAt24cXXHandler", "()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;", "GetGetAt24cXXHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? At88scXXHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getAt88scXXHandler' and count(parameter)=0]"
			[Register ("getAt88scXXHandler", "()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;", "GetGetAt88scXXHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? AuthFaceHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getAuthFaceHandler' and count(parameter)=0]"
			[Register ("getAuthFaceHandler", "()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;", "GetGetAuthFaceHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler? CashBoxHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getCashBoxHandler' and count(parameter)=0]"
			[Register ("getCashBoxHandler", "()Lcom/vanstone/appsdk/api/cashboxdriver/CashBoxHandler;", "GetGetCashBoxHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? CommHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getCommHandler' and count(parameter)=0]"
			[Register ("getCommHandler", "()Lcom/vanstone/appsdk/api/common/CommHandler;", "GetGetCommHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? ContactlessHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getContactlessHandler' and count(parameter)=0]"
			[Register ("getContactlessHandler", "()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;", "GetGetContactlessHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? DesfireHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getDesfireHandler' and count(parameter)=0]"
			[Register ("getDesfireHandler", "()Lcom/vanstone/appsdk/api/cards/DesfireHandler;", "GetGetDesfireHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? DevinformHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getDevinformHandler' and count(parameter)=0]"
			[Register ("getDevinformHandler", "()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;", "GetGetDevinformHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? FingerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getFingerHandler' and count(parameter)=0]"
			[Register ("getFingerHandler", "()Lcom/vanstone/appsdk/api/finger/FingerHandler;", "GetGetFingerHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? FiscalHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getFiscalHandler' and count(parameter)=0]"
			[Register ("getFiscalHandler", "()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;", "GetGetFiscalHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? HsmHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getHsmHandler' and count(parameter)=0]"
			[Register ("getHsmHandler", "()Lcom/vanstone/appsdk/api/hsm/HsmHandler;", "GetGetHsmHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? IDCardHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getIDCardHandler' and count(parameter)=0]"
			[Register ("getIDCardHandler", "()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;", "GetGetIDCardHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? IRThermometerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getIRThermometerHandler' and count(parameter)=0]"
			[Register ("getIRThermometerHandler", "()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;", "GetGetIRThermometerHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? IcHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getIcHandler' and count(parameter)=0]"
			[Register ("getIcHandler", "()Lcom/vanstone/appsdk/api/cards/ICHandler;", "GetGetIcHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? LcdHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getLcdHandler' and count(parameter)=0]"
			[Register ("getLcdHandler", "()Lcom/vanstone/appsdk/api/lcd/LcdHandler;", "GetGetLcdHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? LocationHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getLocationHandler' and count(parameter)=0]"
			[Register ("getLocationHandler", "()Lcom/vanstone/appsdk/api/location/LocationHandler;", "GetGetLocationHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? MagHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getMagHandler' and count(parameter)=0]"
			[Register ("getMagHandler", "()Lcom/vanstone/appsdk/api/cards/MAGHandler;", "GetGetMagHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? MemCardHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getMemCardHandler' and count(parameter)=0]"
			[Register ("getMemCardHandler", "()Lcom/vanstone/appsdk/api/cards/MemCardHandler;", "GetGetMemCardHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? NLDeviceScanHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getNLDeviceScanHandler' and count(parameter)=0]"
			[Register ("getNLDeviceScanHandler", "()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;", "GetGetNLDeviceScanHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? NumKeyBoardHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getNumKeyBoardHandler' and count(parameter)=0]"
			[Register ("getNumKeyBoardHandler", "()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;", "GetGetNumKeyBoardHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? PedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getPedHandler' and count(parameter)=0]"
			[Register ("getPedHandler", "()Lcom/vanstone/appsdk/api/ped/PedHandler;", "GetGetPedHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? PiccHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getPiccHandler' and count(parameter)=0]"
			[Register ("getPiccHandler", "()Lcom/vanstone/appsdk/api/cards/PICCHandler;", "GetGetPiccHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? PrinterHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getPrinterHandler' and count(parameter)=0]"
			[Register ("getPrinterHandler", "()Lcom/vanstone/appsdk/api/printer/PrinterHandler;", "GetGetPrinterHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? Rs232Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getRs232Handler' and count(parameter)=0]"
			[Register ("getRs232Handler", "()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;", "GetGetRs232HandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? ScanExHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getScanExHandler' and count(parameter)=0]"
			[Register ("getScanExHandler", "()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;", "GetGetScanExHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? ScanHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getScanHandler' and count(parameter)=0]"
			[Register ("getScanHandler", "()Lcom/vanstone/appsdk/api/scan/ScanHandler;", "GetGetScanHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? SerialPortHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getSerialPortHandler' and count(parameter)=0]"
			[Register ("getSerialPortHandler", "()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;", "GetGetSerialPortHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? SignHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getSignHandler' and count(parameter)=0]"
			[Register ("getSignHandler", "()Lcom/vanstone/appsdk/api/sign/SignHandler;", "GetGetSignHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? SmHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getSmHandler' and count(parameter)=0]"
			[Register ("getSmHandler", "()Lcom/vanstone/appsdk/api/sm/SmHandler;", "GetGetSmHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? SystemHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getSystemHandler' and count(parameter)=0]"
			[Register ("getSystemHandler", "()Lcom/vanstone/appsdk/api/system/SystemHandler;", "GetGetSystemHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? TaxControlHandle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getTaxControlHandle' and count(parameter)=0]"
			[Register ("getTaxControlHandle", "()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;", "GetGetTaxControlHandleHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? WifiProbeHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/interface[@name='SdkApiEngine']/method[@name='getWifiProbeHandler' and count(parameter)=0]"
			[Register ("getWifiProbeHandler", "()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;", "GetGetWifiProbeHandlerHandler:Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngineInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/engine/SdkApiEngine$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/engine/SdkApiEngine$Default", typeof (Default));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Default (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/constructor[@name='SdkApiEngine.Default' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Default () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_getApnHandler;
#pragma warning disable 0169
			static Delegate GetGetApnHandlerHandler ()
			{
				if (cb_getApnHandler == null)
					cb_getApnHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetApnHandler));
				return cb_getApnHandler;
			}

			static IntPtr n_GetApnHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ApnHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? ApnHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getApnHandler' and count(parameter)=0]"
				[Register ("getApnHandler", "()Lcom/vanstone/appsdk/api/common/ApnHandler;", "GetGetApnHandlerHandler")]
				get {
					const string __id = "getApnHandler.()Lcom/vanstone/appsdk/api/common/ApnHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getAt24cXXHandler;
#pragma warning disable 0169
			static Delegate GetGetAt24cXXHandlerHandler ()
			{
				if (cb_getAt24cXXHandler == null)
					cb_getAt24cXXHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAt24cXXHandler));
				return cb_getAt24cXXHandler;
			}

			static IntPtr n_GetAt24cXXHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.At24cXXHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? At24cXXHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getAt24cXXHandler' and count(parameter)=0]"
				[Register ("getAt24cXXHandler", "()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;", "GetGetAt24cXXHandlerHandler")]
				get {
					const string __id = "getAt24cXXHandler.()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getAt88scXXHandler;
#pragma warning disable 0169
			static Delegate GetGetAt88scXXHandlerHandler ()
			{
				if (cb_getAt88scXXHandler == null)
					cb_getAt88scXXHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAt88scXXHandler));
				return cb_getAt88scXXHandler;
			}

			static IntPtr n_GetAt88scXXHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.At88scXXHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? At88scXXHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getAt88scXXHandler' and count(parameter)=0]"
				[Register ("getAt88scXXHandler", "()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;", "GetGetAt88scXXHandlerHandler")]
				get {
					const string __id = "getAt88scXXHandler.()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getAuthFaceHandler;
#pragma warning disable 0169
			static Delegate GetGetAuthFaceHandlerHandler ()
			{
				if (cb_getAuthFaceHandler == null)
					cb_getAuthFaceHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAuthFaceHandler));
				return cb_getAuthFaceHandler;
			}

			static IntPtr n_GetAuthFaceHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AuthFaceHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? AuthFaceHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getAuthFaceHandler' and count(parameter)=0]"
				[Register ("getAuthFaceHandler", "()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;", "GetGetAuthFaceHandlerHandler")]
				get {
					const string __id = "getAuthFaceHandler.()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getCashBoxHandler;
#pragma warning disable 0169
			static Delegate GetGetCashBoxHandlerHandler ()
			{
				if (cb_getCashBoxHandler == null)
					cb_getCashBoxHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCashBoxHandler));
				return cb_getCashBoxHandler;
			}

			static IntPtr n_GetCashBoxHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.CashBoxHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler? CashBoxHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getCashBoxHandler' and count(parameter)=0]"
				[Register ("getCashBoxHandler", "()Lcom/vanstone/appsdk/api/cashboxdriver/CashBoxHandler;", "GetGetCashBoxHandlerHandler")]
				get {
					const string __id = "getCashBoxHandler.()Lcom/vanstone/appsdk/api/cashboxdriver/CashBoxHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getCommHandler;
#pragma warning disable 0169
			static Delegate GetGetCommHandlerHandler ()
			{
				if (cb_getCommHandler == null)
					cb_getCommHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCommHandler));
				return cb_getCommHandler;
			}

			static IntPtr n_GetCommHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.CommHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? CommHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getCommHandler' and count(parameter)=0]"
				[Register ("getCommHandler", "()Lcom/vanstone/appsdk/api/common/CommHandler;", "GetGetCommHandlerHandler")]
				get {
					const string __id = "getCommHandler.()Lcom/vanstone/appsdk/api/common/CommHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getContactlessHandler;
#pragma warning disable 0169
			static Delegate GetGetContactlessHandlerHandler ()
			{
				if (cb_getContactlessHandler == null)
					cb_getContactlessHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetContactlessHandler));
				return cb_getContactlessHandler;
			}

			static IntPtr n_GetContactlessHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ContactlessHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? ContactlessHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getContactlessHandler' and count(parameter)=0]"
				[Register ("getContactlessHandler", "()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;", "GetGetContactlessHandlerHandler")]
				get {
					const string __id = "getContactlessHandler.()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getDesfireHandler;
#pragma warning disable 0169
			static Delegate GetGetDesfireHandlerHandler ()
			{
				if (cb_getDesfireHandler == null)
					cb_getDesfireHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDesfireHandler));
				return cb_getDesfireHandler;
			}

			static IntPtr n_GetDesfireHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DesfireHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? DesfireHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getDesfireHandler' and count(parameter)=0]"
				[Register ("getDesfireHandler", "()Lcom/vanstone/appsdk/api/cards/DesfireHandler;", "GetGetDesfireHandlerHandler")]
				get {
					const string __id = "getDesfireHandler.()Lcom/vanstone/appsdk/api/cards/DesfireHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getDevinformHandler;
#pragma warning disable 0169
			static Delegate GetGetDevinformHandlerHandler ()
			{
				if (cb_getDevinformHandler == null)
					cb_getDevinformHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDevinformHandler));
				return cb_getDevinformHandler;
			}

			static IntPtr n_GetDevinformHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DevinformHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? DevinformHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getDevinformHandler' and count(parameter)=0]"
				[Register ("getDevinformHandler", "()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;", "GetGetDevinformHandlerHandler")]
				get {
					const string __id = "getDevinformHandler.()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getFingerHandler;
#pragma warning disable 0169
			static Delegate GetGetFingerHandlerHandler ()
			{
				if (cb_getFingerHandler == null)
					cb_getFingerHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFingerHandler));
				return cb_getFingerHandler;
			}

			static IntPtr n_GetFingerHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FingerHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? FingerHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getFingerHandler' and count(parameter)=0]"
				[Register ("getFingerHandler", "()Lcom/vanstone/appsdk/api/finger/FingerHandler;", "GetGetFingerHandlerHandler")]
				get {
					const string __id = "getFingerHandler.()Lcom/vanstone/appsdk/api/finger/FingerHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getFiscalHandler;
#pragma warning disable 0169
			static Delegate GetGetFiscalHandlerHandler ()
			{
				if (cb_getFiscalHandler == null)
					cb_getFiscalHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFiscalHandler));
				return cb_getFiscalHandler;
			}

			static IntPtr n_GetFiscalHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FiscalHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? FiscalHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getFiscalHandler' and count(parameter)=0]"
				[Register ("getFiscalHandler", "()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;", "GetGetFiscalHandlerHandler")]
				get {
					const string __id = "getFiscalHandler.()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getHsmHandler;
#pragma warning disable 0169
			static Delegate GetGetHsmHandlerHandler ()
			{
				if (cb_getHsmHandler == null)
					cb_getHsmHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHsmHandler));
				return cb_getHsmHandler;
			}

			static IntPtr n_GetHsmHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.HsmHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? HsmHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getHsmHandler' and count(parameter)=0]"
				[Register ("getHsmHandler", "()Lcom/vanstone/appsdk/api/hsm/HsmHandler;", "GetGetHsmHandlerHandler")]
				get {
					const string __id = "getHsmHandler.()Lcom/vanstone/appsdk/api/hsm/HsmHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getIDCardHandler;
#pragma warning disable 0169
			static Delegate GetGetIDCardHandlerHandler ()
			{
				if (cb_getIDCardHandler == null)
					cb_getIDCardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIDCardHandler));
				return cb_getIDCardHandler;
			}

			static IntPtr n_GetIDCardHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IDCardHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? IDCardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getIDCardHandler' and count(parameter)=0]"
				[Register ("getIDCardHandler", "()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;", "GetGetIDCardHandlerHandler")]
				get {
					const string __id = "getIDCardHandler.()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getIRThermometerHandler;
#pragma warning disable 0169
			static Delegate GetGetIRThermometerHandlerHandler ()
			{
				if (cb_getIRThermometerHandler == null)
					cb_getIRThermometerHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIRThermometerHandler));
				return cb_getIRThermometerHandler;
			}

			static IntPtr n_GetIRThermometerHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IRThermometerHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? IRThermometerHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getIRThermometerHandler' and count(parameter)=0]"
				[Register ("getIRThermometerHandler", "()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;", "GetGetIRThermometerHandlerHandler")]
				get {
					const string __id = "getIRThermometerHandler.()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getIcHandler;
#pragma warning disable 0169
			static Delegate GetGetIcHandlerHandler ()
			{
				if (cb_getIcHandler == null)
					cb_getIcHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIcHandler));
				return cb_getIcHandler;
			}

			static IntPtr n_GetIcHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IcHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? IcHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getIcHandler' and count(parameter)=0]"
				[Register ("getIcHandler", "()Lcom/vanstone/appsdk/api/cards/ICHandler;", "GetGetIcHandlerHandler")]
				get {
					const string __id = "getIcHandler.()Lcom/vanstone/appsdk/api/cards/ICHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getLcdHandler;
#pragma warning disable 0169
			static Delegate GetGetLcdHandlerHandler ()
			{
				if (cb_getLcdHandler == null)
					cb_getLcdHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLcdHandler));
				return cb_getLcdHandler;
			}

			static IntPtr n_GetLcdHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.LcdHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? LcdHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getLcdHandler' and count(parameter)=0]"
				[Register ("getLcdHandler", "()Lcom/vanstone/appsdk/api/lcd/LcdHandler;", "GetGetLcdHandlerHandler")]
				get {
					const string __id = "getLcdHandler.()Lcom/vanstone/appsdk/api/lcd/LcdHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getLocationHandler;
#pragma warning disable 0169
			static Delegate GetGetLocationHandlerHandler ()
			{
				if (cb_getLocationHandler == null)
					cb_getLocationHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLocationHandler));
				return cb_getLocationHandler;
			}

			static IntPtr n_GetLocationHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.LocationHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? LocationHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getLocationHandler' and count(parameter)=0]"
				[Register ("getLocationHandler", "()Lcom/vanstone/appsdk/api/location/LocationHandler;", "GetGetLocationHandlerHandler")]
				get {
					const string __id = "getLocationHandler.()Lcom/vanstone/appsdk/api/location/LocationHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getMagHandler;
#pragma warning disable 0169
			static Delegate GetGetMagHandlerHandler ()
			{
				if (cb_getMagHandler == null)
					cb_getMagHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMagHandler));
				return cb_getMagHandler;
			}

			static IntPtr n_GetMagHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.MagHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? MagHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getMagHandler' and count(parameter)=0]"
				[Register ("getMagHandler", "()Lcom/vanstone/appsdk/api/cards/MAGHandler;", "GetGetMagHandlerHandler")]
				get {
					const string __id = "getMagHandler.()Lcom/vanstone/appsdk/api/cards/MAGHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getMemCardHandler;
#pragma warning disable 0169
			static Delegate GetGetMemCardHandlerHandler ()
			{
				if (cb_getMemCardHandler == null)
					cb_getMemCardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMemCardHandler));
				return cb_getMemCardHandler;
			}

			static IntPtr n_GetMemCardHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.MemCardHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? MemCardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getMemCardHandler' and count(parameter)=0]"
				[Register ("getMemCardHandler", "()Lcom/vanstone/appsdk/api/cards/MemCardHandler;", "GetGetMemCardHandlerHandler")]
				get {
					const string __id = "getMemCardHandler.()Lcom/vanstone/appsdk/api/cards/MemCardHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getNLDeviceScanHandler;
#pragma warning disable 0169
			static Delegate GetGetNLDeviceScanHandlerHandler ()
			{
				if (cb_getNLDeviceScanHandler == null)
					cb_getNLDeviceScanHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNLDeviceScanHandler));
				return cb_getNLDeviceScanHandler;
			}

			static IntPtr n_GetNLDeviceScanHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.NLDeviceScanHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? NLDeviceScanHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getNLDeviceScanHandler' and count(parameter)=0]"
				[Register ("getNLDeviceScanHandler", "()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;", "GetGetNLDeviceScanHandlerHandler")]
				get {
					const string __id = "getNLDeviceScanHandler.()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getNumKeyBoardHandler;
#pragma warning disable 0169
			static Delegate GetGetNumKeyBoardHandlerHandler ()
			{
				if (cb_getNumKeyBoardHandler == null)
					cb_getNumKeyBoardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNumKeyBoardHandler));
				return cb_getNumKeyBoardHandler;
			}

			static IntPtr n_GetNumKeyBoardHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.NumKeyBoardHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? NumKeyBoardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getNumKeyBoardHandler' and count(parameter)=0]"
				[Register ("getNumKeyBoardHandler", "()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;", "GetGetNumKeyBoardHandlerHandler")]
				get {
					const string __id = "getNumKeyBoardHandler.()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getPedHandler;
#pragma warning disable 0169
			static Delegate GetGetPedHandlerHandler ()
			{
				if (cb_getPedHandler == null)
					cb_getPedHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPedHandler));
				return cb_getPedHandler;
			}

			static IntPtr n_GetPedHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PedHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? PedHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getPedHandler' and count(parameter)=0]"
				[Register ("getPedHandler", "()Lcom/vanstone/appsdk/api/ped/PedHandler;", "GetGetPedHandlerHandler")]
				get {
					const string __id = "getPedHandler.()Lcom/vanstone/appsdk/api/ped/PedHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getPiccHandler;
#pragma warning disable 0169
			static Delegate GetGetPiccHandlerHandler ()
			{
				if (cb_getPiccHandler == null)
					cb_getPiccHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPiccHandler));
				return cb_getPiccHandler;
			}

			static IntPtr n_GetPiccHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PiccHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? PiccHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getPiccHandler' and count(parameter)=0]"
				[Register ("getPiccHandler", "()Lcom/vanstone/appsdk/api/cards/PICCHandler;", "GetGetPiccHandlerHandler")]
				get {
					const string __id = "getPiccHandler.()Lcom/vanstone/appsdk/api/cards/PICCHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getPrinterHandler;
#pragma warning disable 0169
			static Delegate GetGetPrinterHandlerHandler ()
			{
				if (cb_getPrinterHandler == null)
					cb_getPrinterHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPrinterHandler));
				return cb_getPrinterHandler;
			}

			static IntPtr n_GetPrinterHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PrinterHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? PrinterHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getPrinterHandler' and count(parameter)=0]"
				[Register ("getPrinterHandler", "()Lcom/vanstone/appsdk/api/printer/PrinterHandler;", "GetGetPrinterHandlerHandler")]
				get {
					const string __id = "getPrinterHandler.()Lcom/vanstone/appsdk/api/printer/PrinterHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getRs232Handler;
#pragma warning disable 0169
			static Delegate GetGetRs232HandlerHandler ()
			{
				if (cb_getRs232Handler == null)
					cb_getRs232Handler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRs232Handler));
				return cb_getRs232Handler;
			}

			static IntPtr n_GetRs232Handler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Rs232Handler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? Rs232Handler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getRs232Handler' and count(parameter)=0]"
				[Register ("getRs232Handler", "()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;", "GetGetRs232HandlerHandler")]
				get {
					const string __id = "getRs232Handler.()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getScanExHandler;
#pragma warning disable 0169
			static Delegate GetGetScanExHandlerHandler ()
			{
				if (cb_getScanExHandler == null)
					cb_getScanExHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetScanExHandler));
				return cb_getScanExHandler;
			}

			static IntPtr n_GetScanExHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ScanExHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? ScanExHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getScanExHandler' and count(parameter)=0]"
				[Register ("getScanExHandler", "()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;", "GetGetScanExHandlerHandler")]
				get {
					const string __id = "getScanExHandler.()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getScanHandler;
#pragma warning disable 0169
			static Delegate GetGetScanHandlerHandler ()
			{
				if (cb_getScanHandler == null)
					cb_getScanHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetScanHandler));
				return cb_getScanHandler;
			}

			static IntPtr n_GetScanHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ScanHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? ScanHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getScanHandler' and count(parameter)=0]"
				[Register ("getScanHandler", "()Lcom/vanstone/appsdk/api/scan/ScanHandler;", "GetGetScanHandlerHandler")]
				get {
					const string __id = "getScanHandler.()Lcom/vanstone/appsdk/api/scan/ScanHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSerialPortHandler;
#pragma warning disable 0169
			static Delegate GetGetSerialPortHandlerHandler ()
			{
				if (cb_getSerialPortHandler == null)
					cb_getSerialPortHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSerialPortHandler));
				return cb_getSerialPortHandler;
			}

			static IntPtr n_GetSerialPortHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SerialPortHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? SerialPortHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getSerialPortHandler' and count(parameter)=0]"
				[Register ("getSerialPortHandler", "()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;", "GetGetSerialPortHandlerHandler")]
				get {
					const string __id = "getSerialPortHandler.()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSignHandler;
#pragma warning disable 0169
			static Delegate GetGetSignHandlerHandler ()
			{
				if (cb_getSignHandler == null)
					cb_getSignHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignHandler));
				return cb_getSignHandler;
			}

			static IntPtr n_GetSignHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SignHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? SignHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getSignHandler' and count(parameter)=0]"
				[Register ("getSignHandler", "()Lcom/vanstone/appsdk/api/sign/SignHandler;", "GetGetSignHandlerHandler")]
				get {
					const string __id = "getSignHandler.()Lcom/vanstone/appsdk/api/sign/SignHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSmHandler;
#pragma warning disable 0169
			static Delegate GetGetSmHandlerHandler ()
			{
				if (cb_getSmHandler == null)
					cb_getSmHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSmHandler));
				return cb_getSmHandler;
			}

			static IntPtr n_GetSmHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SmHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? SmHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getSmHandler' and count(parameter)=0]"
				[Register ("getSmHandler", "()Lcom/vanstone/appsdk/api/sm/SmHandler;", "GetGetSmHandlerHandler")]
				get {
					const string __id = "getSmHandler.()Lcom/vanstone/appsdk/api/sm/SmHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSystemHandler;
#pragma warning disable 0169
			static Delegate GetGetSystemHandlerHandler ()
			{
				if (cb_getSystemHandler == null)
					cb_getSystemHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSystemHandler));
				return cb_getSystemHandler;
			}

			static IntPtr n_GetSystemHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SystemHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? SystemHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getSystemHandler' and count(parameter)=0]"
				[Register ("getSystemHandler", "()Lcom/vanstone/appsdk/api/system/SystemHandler;", "GetGetSystemHandlerHandler")]
				get {
					const string __id = "getSystemHandler.()Lcom/vanstone/appsdk/api/system/SystemHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getTaxControlHandle;
#pragma warning disable 0169
			static Delegate GetGetTaxControlHandleHandler ()
			{
				if (cb_getTaxControlHandle == null)
					cb_getTaxControlHandle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTaxControlHandle));
				return cb_getTaxControlHandle;
			}

			static IntPtr n_GetTaxControlHandle (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.TaxControlHandle);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? TaxControlHandle {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getTaxControlHandle' and count(parameter)=0]"
				[Register ("getTaxControlHandle", "()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;", "GetGetTaxControlHandleHandler")]
				get {
					const string __id = "getTaxControlHandle.()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getWifiProbeHandler;
#pragma warning disable 0169
			static Delegate GetGetWifiProbeHandlerHandler ()
			{
				if (cb_getWifiProbeHandler == null)
					cb_getWifiProbeHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetWifiProbeHandler));
				return cb_getWifiProbeHandler;
			}

			static IntPtr n_GetWifiProbeHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.WifiProbeHandler);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? WifiProbeHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='getWifiProbeHandler' and count(parameter)=0]"
				[Register ("getWifiProbeHandler", "()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;", "GetGetWifiProbeHandlerHandler")]
				get {
					const string __id = "getWifiProbeHandler.()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Default']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder? AsBinder ()
			{
				const string __id = "asBinder.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/engine/SdkApiEngine$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/engine/SdkApiEngine$Stub", typeof (Stub));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Stub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/constructor[@name='SdkApiEngine.Stub' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Stub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			public static unsafe global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/engine/SdkApiEngine;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/engine/SdkApiEngine;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder? AsBinder ()
			{
				const string __id = "asBinder.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/engine/SdkApiEngine;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/engine/SdkApiEngine;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (obj);
				}
			}

			static Delegate? cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
					cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLI_Z (n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I));
				return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
			}

			static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
			[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
			public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel? data, global::Android.OS.Parcel? reply, int flags)
			{
				const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (code);
					__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
					__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
					__args [3] = new JniArgumentValue (flags);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (data);
					global::System.GC.KeepAlive (reply);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.engine.SdkApiEngine']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/engine/SdkApiEngine;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/engine/SdkApiEngine;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_getApnHandler;
#pragma warning disable 0169
			static Delegate GetGetApnHandlerHandler ()
			{
				if (cb_getApnHandler == null)
					cb_getApnHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetApnHandler));
				return cb_getApnHandler;
			}

			static IntPtr n_GetApnHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ApnHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? ApnHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getApnHandler' and count(parameter)=0]"
				[Register ("getApnHandler", "()Lcom/vanstone/appsdk/api/common/ApnHandler;", "GetGetApnHandlerHandler")]
				get; 
			}

			static Delegate? cb_getAt24cXXHandler;
#pragma warning disable 0169
			static Delegate GetGetAt24cXXHandlerHandler ()
			{
				if (cb_getAt24cXXHandler == null)
					cb_getAt24cXXHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAt24cXXHandler));
				return cb_getAt24cXXHandler;
			}

			static IntPtr n_GetAt24cXXHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.At24cXXHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? At24cXXHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getAt24cXXHandler' and count(parameter)=0]"
				[Register ("getAt24cXXHandler", "()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;", "GetGetAt24cXXHandlerHandler")]
				get; 
			}

			static Delegate? cb_getAt88scXXHandler;
#pragma warning disable 0169
			static Delegate GetGetAt88scXXHandlerHandler ()
			{
				if (cb_getAt88scXXHandler == null)
					cb_getAt88scXXHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAt88scXXHandler));
				return cb_getAt88scXXHandler;
			}

			static IntPtr n_GetAt88scXXHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.At88scXXHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? At88scXXHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getAt88scXXHandler' and count(parameter)=0]"
				[Register ("getAt88scXXHandler", "()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;", "GetGetAt88scXXHandlerHandler")]
				get; 
			}

			static Delegate? cb_getAuthFaceHandler;
#pragma warning disable 0169
			static Delegate GetGetAuthFaceHandlerHandler ()
			{
				if (cb_getAuthFaceHandler == null)
					cb_getAuthFaceHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAuthFaceHandler));
				return cb_getAuthFaceHandler;
			}

			static IntPtr n_GetAuthFaceHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AuthFaceHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? AuthFaceHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getAuthFaceHandler' and count(parameter)=0]"
				[Register ("getAuthFaceHandler", "()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;", "GetGetAuthFaceHandlerHandler")]
				get; 
			}

			static Delegate? cb_getCashBoxHandler;
#pragma warning disable 0169
			static Delegate GetGetCashBoxHandlerHandler ()
			{
				if (cb_getCashBoxHandler == null)
					cb_getCashBoxHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCashBoxHandler));
				return cb_getCashBoxHandler;
			}

			static IntPtr n_GetCashBoxHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.CashBoxHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler? CashBoxHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getCashBoxHandler' and count(parameter)=0]"
				[Register ("getCashBoxHandler", "()Lcom/vanstone/appsdk/api/cashboxdriver/CashBoxHandler;", "GetGetCashBoxHandlerHandler")]
				get; 
			}

			static Delegate? cb_getCommHandler;
#pragma warning disable 0169
			static Delegate GetGetCommHandlerHandler ()
			{
				if (cb_getCommHandler == null)
					cb_getCommHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCommHandler));
				return cb_getCommHandler;
			}

			static IntPtr n_GetCommHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.CommHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? CommHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getCommHandler' and count(parameter)=0]"
				[Register ("getCommHandler", "()Lcom/vanstone/appsdk/api/common/CommHandler;", "GetGetCommHandlerHandler")]
				get; 
			}

			static Delegate? cb_getContactlessHandler;
#pragma warning disable 0169
			static Delegate GetGetContactlessHandlerHandler ()
			{
				if (cb_getContactlessHandler == null)
					cb_getContactlessHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetContactlessHandler));
				return cb_getContactlessHandler;
			}

			static IntPtr n_GetContactlessHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ContactlessHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? ContactlessHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getContactlessHandler' and count(parameter)=0]"
				[Register ("getContactlessHandler", "()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;", "GetGetContactlessHandlerHandler")]
				get; 
			}

			static Delegate? cb_getDesfireHandler;
#pragma warning disable 0169
			static Delegate GetGetDesfireHandlerHandler ()
			{
				if (cb_getDesfireHandler == null)
					cb_getDesfireHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDesfireHandler));
				return cb_getDesfireHandler;
			}

			static IntPtr n_GetDesfireHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DesfireHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? DesfireHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getDesfireHandler' and count(parameter)=0]"
				[Register ("getDesfireHandler", "()Lcom/vanstone/appsdk/api/cards/DesfireHandler;", "GetGetDesfireHandlerHandler")]
				get; 
			}

			static Delegate? cb_getDevinformHandler;
#pragma warning disable 0169
			static Delegate GetGetDevinformHandlerHandler ()
			{
				if (cb_getDevinformHandler == null)
					cb_getDevinformHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDevinformHandler));
				return cb_getDevinformHandler;
			}

			static IntPtr n_GetDevinformHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DevinformHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? DevinformHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getDevinformHandler' and count(parameter)=0]"
				[Register ("getDevinformHandler", "()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;", "GetGetDevinformHandlerHandler")]
				get; 
			}

			static Delegate? cb_getFingerHandler;
#pragma warning disable 0169
			static Delegate GetGetFingerHandlerHandler ()
			{
				if (cb_getFingerHandler == null)
					cb_getFingerHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFingerHandler));
				return cb_getFingerHandler;
			}

			static IntPtr n_GetFingerHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FingerHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? FingerHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getFingerHandler' and count(parameter)=0]"
				[Register ("getFingerHandler", "()Lcom/vanstone/appsdk/api/finger/FingerHandler;", "GetGetFingerHandlerHandler")]
				get; 
			}

			static Delegate? cb_getFiscalHandler;
#pragma warning disable 0169
			static Delegate GetGetFiscalHandlerHandler ()
			{
				if (cb_getFiscalHandler == null)
					cb_getFiscalHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFiscalHandler));
				return cb_getFiscalHandler;
			}

			static IntPtr n_GetFiscalHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FiscalHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? FiscalHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getFiscalHandler' and count(parameter)=0]"
				[Register ("getFiscalHandler", "()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;", "GetGetFiscalHandlerHandler")]
				get; 
			}

			static Delegate? cb_getHsmHandler;
#pragma warning disable 0169
			static Delegate GetGetHsmHandlerHandler ()
			{
				if (cb_getHsmHandler == null)
					cb_getHsmHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHsmHandler));
				return cb_getHsmHandler;
			}

			static IntPtr n_GetHsmHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.HsmHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? HsmHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getHsmHandler' and count(parameter)=0]"
				[Register ("getHsmHandler", "()Lcom/vanstone/appsdk/api/hsm/HsmHandler;", "GetGetHsmHandlerHandler")]
				get; 
			}

			static Delegate? cb_getIDCardHandler;
#pragma warning disable 0169
			static Delegate GetGetIDCardHandlerHandler ()
			{
				if (cb_getIDCardHandler == null)
					cb_getIDCardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIDCardHandler));
				return cb_getIDCardHandler;
			}

			static IntPtr n_GetIDCardHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IDCardHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? IDCardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getIDCardHandler' and count(parameter)=0]"
				[Register ("getIDCardHandler", "()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;", "GetGetIDCardHandlerHandler")]
				get; 
			}

			static Delegate? cb_getIRThermometerHandler;
#pragma warning disable 0169
			static Delegate GetGetIRThermometerHandlerHandler ()
			{
				if (cb_getIRThermometerHandler == null)
					cb_getIRThermometerHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIRThermometerHandler));
				return cb_getIRThermometerHandler;
			}

			static IntPtr n_GetIRThermometerHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IRThermometerHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? IRThermometerHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getIRThermometerHandler' and count(parameter)=0]"
				[Register ("getIRThermometerHandler", "()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;", "GetGetIRThermometerHandlerHandler")]
				get; 
			}

			static Delegate? cb_getIcHandler;
#pragma warning disable 0169
			static Delegate GetGetIcHandlerHandler ()
			{
				if (cb_getIcHandler == null)
					cb_getIcHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIcHandler));
				return cb_getIcHandler;
			}

			static IntPtr n_GetIcHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IcHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? IcHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getIcHandler' and count(parameter)=0]"
				[Register ("getIcHandler", "()Lcom/vanstone/appsdk/api/cards/ICHandler;", "GetGetIcHandlerHandler")]
				get; 
			}

			static Delegate? cb_getLcdHandler;
#pragma warning disable 0169
			static Delegate GetGetLcdHandlerHandler ()
			{
				if (cb_getLcdHandler == null)
					cb_getLcdHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLcdHandler));
				return cb_getLcdHandler;
			}

			static IntPtr n_GetLcdHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.LcdHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? LcdHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getLcdHandler' and count(parameter)=0]"
				[Register ("getLcdHandler", "()Lcom/vanstone/appsdk/api/lcd/LcdHandler;", "GetGetLcdHandlerHandler")]
				get; 
			}

			static Delegate? cb_getLocationHandler;
#pragma warning disable 0169
			static Delegate GetGetLocationHandlerHandler ()
			{
				if (cb_getLocationHandler == null)
					cb_getLocationHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLocationHandler));
				return cb_getLocationHandler;
			}

			static IntPtr n_GetLocationHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.LocationHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? LocationHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getLocationHandler' and count(parameter)=0]"
				[Register ("getLocationHandler", "()Lcom/vanstone/appsdk/api/location/LocationHandler;", "GetGetLocationHandlerHandler")]
				get; 
			}

			static Delegate? cb_getMagHandler;
#pragma warning disable 0169
			static Delegate GetGetMagHandlerHandler ()
			{
				if (cb_getMagHandler == null)
					cb_getMagHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMagHandler));
				return cb_getMagHandler;
			}

			static IntPtr n_GetMagHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.MagHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? MagHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getMagHandler' and count(parameter)=0]"
				[Register ("getMagHandler", "()Lcom/vanstone/appsdk/api/cards/MAGHandler;", "GetGetMagHandlerHandler")]
				get; 
			}

			static Delegate? cb_getMemCardHandler;
#pragma warning disable 0169
			static Delegate GetGetMemCardHandlerHandler ()
			{
				if (cb_getMemCardHandler == null)
					cb_getMemCardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMemCardHandler));
				return cb_getMemCardHandler;
			}

			static IntPtr n_GetMemCardHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.MemCardHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? MemCardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getMemCardHandler' and count(parameter)=0]"
				[Register ("getMemCardHandler", "()Lcom/vanstone/appsdk/api/cards/MemCardHandler;", "GetGetMemCardHandlerHandler")]
				get; 
			}

			static Delegate? cb_getNLDeviceScanHandler;
#pragma warning disable 0169
			static Delegate GetGetNLDeviceScanHandlerHandler ()
			{
				if (cb_getNLDeviceScanHandler == null)
					cb_getNLDeviceScanHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNLDeviceScanHandler));
				return cb_getNLDeviceScanHandler;
			}

			static IntPtr n_GetNLDeviceScanHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.NLDeviceScanHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? NLDeviceScanHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getNLDeviceScanHandler' and count(parameter)=0]"
				[Register ("getNLDeviceScanHandler", "()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;", "GetGetNLDeviceScanHandlerHandler")]
				get; 
			}

			static Delegate? cb_getNumKeyBoardHandler;
#pragma warning disable 0169
			static Delegate GetGetNumKeyBoardHandlerHandler ()
			{
				if (cb_getNumKeyBoardHandler == null)
					cb_getNumKeyBoardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNumKeyBoardHandler));
				return cb_getNumKeyBoardHandler;
			}

			static IntPtr n_GetNumKeyBoardHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.NumKeyBoardHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? NumKeyBoardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getNumKeyBoardHandler' and count(parameter)=0]"
				[Register ("getNumKeyBoardHandler", "()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;", "GetGetNumKeyBoardHandlerHandler")]
				get; 
			}

			static Delegate? cb_getPedHandler;
#pragma warning disable 0169
			static Delegate GetGetPedHandlerHandler ()
			{
				if (cb_getPedHandler == null)
					cb_getPedHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPedHandler));
				return cb_getPedHandler;
			}

			static IntPtr n_GetPedHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PedHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? PedHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getPedHandler' and count(parameter)=0]"
				[Register ("getPedHandler", "()Lcom/vanstone/appsdk/api/ped/PedHandler;", "GetGetPedHandlerHandler")]
				get; 
			}

			static Delegate? cb_getPiccHandler;
#pragma warning disable 0169
			static Delegate GetGetPiccHandlerHandler ()
			{
				if (cb_getPiccHandler == null)
					cb_getPiccHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPiccHandler));
				return cb_getPiccHandler;
			}

			static IntPtr n_GetPiccHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PiccHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? PiccHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getPiccHandler' and count(parameter)=0]"
				[Register ("getPiccHandler", "()Lcom/vanstone/appsdk/api/cards/PICCHandler;", "GetGetPiccHandlerHandler")]
				get; 
			}

			static Delegate? cb_getPrinterHandler;
#pragma warning disable 0169
			static Delegate GetGetPrinterHandlerHandler ()
			{
				if (cb_getPrinterHandler == null)
					cb_getPrinterHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPrinterHandler));
				return cb_getPrinterHandler;
			}

			static IntPtr n_GetPrinterHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PrinterHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? PrinterHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getPrinterHandler' and count(parameter)=0]"
				[Register ("getPrinterHandler", "()Lcom/vanstone/appsdk/api/printer/PrinterHandler;", "GetGetPrinterHandlerHandler")]
				get; 
			}

			static Delegate? cb_getRs232Handler;
#pragma warning disable 0169
			static Delegate GetGetRs232HandlerHandler ()
			{
				if (cb_getRs232Handler == null)
					cb_getRs232Handler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRs232Handler));
				return cb_getRs232Handler;
			}

			static IntPtr n_GetRs232Handler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Rs232Handler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? Rs232Handler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getRs232Handler' and count(parameter)=0]"
				[Register ("getRs232Handler", "()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;", "GetGetRs232HandlerHandler")]
				get; 
			}

			static Delegate? cb_getScanExHandler;
#pragma warning disable 0169
			static Delegate GetGetScanExHandlerHandler ()
			{
				if (cb_getScanExHandler == null)
					cb_getScanExHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetScanExHandler));
				return cb_getScanExHandler;
			}

			static IntPtr n_GetScanExHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ScanExHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? ScanExHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getScanExHandler' and count(parameter)=0]"
				[Register ("getScanExHandler", "()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;", "GetGetScanExHandlerHandler")]
				get; 
			}

			static Delegate? cb_getScanHandler;
#pragma warning disable 0169
			static Delegate GetGetScanHandlerHandler ()
			{
				if (cb_getScanHandler == null)
					cb_getScanHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetScanHandler));
				return cb_getScanHandler;
			}

			static IntPtr n_GetScanHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ScanHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? ScanHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getScanHandler' and count(parameter)=0]"
				[Register ("getScanHandler", "()Lcom/vanstone/appsdk/api/scan/ScanHandler;", "GetGetScanHandlerHandler")]
				get; 
			}

			static Delegate? cb_getSerialPortHandler;
#pragma warning disable 0169
			static Delegate GetGetSerialPortHandlerHandler ()
			{
				if (cb_getSerialPortHandler == null)
					cb_getSerialPortHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSerialPortHandler));
				return cb_getSerialPortHandler;
			}

			static IntPtr n_GetSerialPortHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SerialPortHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? SerialPortHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSerialPortHandler' and count(parameter)=0]"
				[Register ("getSerialPortHandler", "()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;", "GetGetSerialPortHandlerHandler")]
				get; 
			}

			static Delegate? cb_getSignHandler;
#pragma warning disable 0169
			static Delegate GetGetSignHandlerHandler ()
			{
				if (cb_getSignHandler == null)
					cb_getSignHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignHandler));
				return cb_getSignHandler;
			}

			static IntPtr n_GetSignHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SignHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? SignHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSignHandler' and count(parameter)=0]"
				[Register ("getSignHandler", "()Lcom/vanstone/appsdk/api/sign/SignHandler;", "GetGetSignHandlerHandler")]
				get; 
			}

			static Delegate? cb_getSmHandler;
#pragma warning disable 0169
			static Delegate GetGetSmHandlerHandler ()
			{
				if (cb_getSmHandler == null)
					cb_getSmHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSmHandler));
				return cb_getSmHandler;
			}

			static IntPtr n_GetSmHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SmHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? SmHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSmHandler' and count(parameter)=0]"
				[Register ("getSmHandler", "()Lcom/vanstone/appsdk/api/sm/SmHandler;", "GetGetSmHandlerHandler")]
				get; 
			}

			static Delegate? cb_getSystemHandler;
#pragma warning disable 0169
			static Delegate GetGetSystemHandlerHandler ()
			{
				if (cb_getSystemHandler == null)
					cb_getSystemHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSystemHandler));
				return cb_getSystemHandler;
			}

			static IntPtr n_GetSystemHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SystemHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? SystemHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSystemHandler' and count(parameter)=0]"
				[Register ("getSystemHandler", "()Lcom/vanstone/appsdk/api/system/SystemHandler;", "GetGetSystemHandlerHandler")]
				get; 
			}

			static Delegate? cb_getTaxControlHandle;
#pragma warning disable 0169
			static Delegate GetGetTaxControlHandleHandler ()
			{
				if (cb_getTaxControlHandle == null)
					cb_getTaxControlHandle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTaxControlHandle));
				return cb_getTaxControlHandle;
			}

			static IntPtr n_GetTaxControlHandle (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.TaxControlHandle);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? TaxControlHandle {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getTaxControlHandle' and count(parameter)=0]"
				[Register ("getTaxControlHandle", "()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;", "GetGetTaxControlHandleHandler")]
				get; 
			}

			static Delegate? cb_getWifiProbeHandler;
#pragma warning disable 0169
			static Delegate GetGetWifiProbeHandlerHandler ()
			{
				if (cb_getWifiProbeHandler == null)
					cb_getWifiProbeHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetWifiProbeHandler));
				return cb_getWifiProbeHandler;
			}

			static IntPtr n_GetWifiProbeHandler (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.WifiProbeHandler);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? WifiProbeHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getWifiProbeHandler' and count(parameter)=0]"
				[Register ("getWifiProbeHandler", "()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;", "GetGetWifiProbeHandlerHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/engine/SdkApiEngine$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/engine/SdkApiEngine$Stub", typeof (StubInvoker));

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? ApnHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getApnHandler' and count(parameter)=0]"
				[Register ("getApnHandler", "()Lcom/vanstone/appsdk/api/common/ApnHandler;", "GetGetApnHandlerHandler")]
				get {
					const string __id = "getApnHandler.()Lcom/vanstone/appsdk/api/common/ApnHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? At24cXXHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getAt24cXXHandler' and count(parameter)=0]"
				[Register ("getAt24cXXHandler", "()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;", "GetGetAt24cXXHandlerHandler")]
				get {
					const string __id = "getAt24cXXHandler.()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? At88scXXHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getAt88scXXHandler' and count(parameter)=0]"
				[Register ("getAt88scXXHandler", "()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;", "GetGetAt88scXXHandlerHandler")]
				get {
					const string __id = "getAt88scXXHandler.()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? AuthFaceHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getAuthFaceHandler' and count(parameter)=0]"
				[Register ("getAuthFaceHandler", "()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;", "GetGetAuthFaceHandlerHandler")]
				get {
					const string __id = "getAuthFaceHandler.()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler? CashBoxHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getCashBoxHandler' and count(parameter)=0]"
				[Register ("getCashBoxHandler", "()Lcom/vanstone/appsdk/api/cashboxdriver/CashBoxHandler;", "GetGetCashBoxHandlerHandler")]
				get {
					const string __id = "getCashBoxHandler.()Lcom/vanstone/appsdk/api/cashboxdriver/CashBoxHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? CommHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getCommHandler' and count(parameter)=0]"
				[Register ("getCommHandler", "()Lcom/vanstone/appsdk/api/common/CommHandler;", "GetGetCommHandlerHandler")]
				get {
					const string __id = "getCommHandler.()Lcom/vanstone/appsdk/api/common/CommHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? ContactlessHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getContactlessHandler' and count(parameter)=0]"
				[Register ("getContactlessHandler", "()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;", "GetGetContactlessHandlerHandler")]
				get {
					const string __id = "getContactlessHandler.()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? DesfireHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getDesfireHandler' and count(parameter)=0]"
				[Register ("getDesfireHandler", "()Lcom/vanstone/appsdk/api/cards/DesfireHandler;", "GetGetDesfireHandlerHandler")]
				get {
					const string __id = "getDesfireHandler.()Lcom/vanstone/appsdk/api/cards/DesfireHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? DevinformHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getDevinformHandler' and count(parameter)=0]"
				[Register ("getDevinformHandler", "()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;", "GetGetDevinformHandlerHandler")]
				get {
					const string __id = "getDevinformHandler.()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? FingerHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getFingerHandler' and count(parameter)=0]"
				[Register ("getFingerHandler", "()Lcom/vanstone/appsdk/api/finger/FingerHandler;", "GetGetFingerHandlerHandler")]
				get {
					const string __id = "getFingerHandler.()Lcom/vanstone/appsdk/api/finger/FingerHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? FiscalHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getFiscalHandler' and count(parameter)=0]"
				[Register ("getFiscalHandler", "()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;", "GetGetFiscalHandlerHandler")]
				get {
					const string __id = "getFiscalHandler.()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? HsmHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getHsmHandler' and count(parameter)=0]"
				[Register ("getHsmHandler", "()Lcom/vanstone/appsdk/api/hsm/HsmHandler;", "GetGetHsmHandlerHandler")]
				get {
					const string __id = "getHsmHandler.()Lcom/vanstone/appsdk/api/hsm/HsmHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? IDCardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getIDCardHandler' and count(parameter)=0]"
				[Register ("getIDCardHandler", "()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;", "GetGetIDCardHandlerHandler")]
				get {
					const string __id = "getIDCardHandler.()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? IRThermometerHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getIRThermometerHandler' and count(parameter)=0]"
				[Register ("getIRThermometerHandler", "()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;", "GetGetIRThermometerHandlerHandler")]
				get {
					const string __id = "getIRThermometerHandler.()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? IcHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getIcHandler' and count(parameter)=0]"
				[Register ("getIcHandler", "()Lcom/vanstone/appsdk/api/cards/ICHandler;", "GetGetIcHandlerHandler")]
				get {
					const string __id = "getIcHandler.()Lcom/vanstone/appsdk/api/cards/ICHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? LcdHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getLcdHandler' and count(parameter)=0]"
				[Register ("getLcdHandler", "()Lcom/vanstone/appsdk/api/lcd/LcdHandler;", "GetGetLcdHandlerHandler")]
				get {
					const string __id = "getLcdHandler.()Lcom/vanstone/appsdk/api/lcd/LcdHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? LocationHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getLocationHandler' and count(parameter)=0]"
				[Register ("getLocationHandler", "()Lcom/vanstone/appsdk/api/location/LocationHandler;", "GetGetLocationHandlerHandler")]
				get {
					const string __id = "getLocationHandler.()Lcom/vanstone/appsdk/api/location/LocationHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? MagHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getMagHandler' and count(parameter)=0]"
				[Register ("getMagHandler", "()Lcom/vanstone/appsdk/api/cards/MAGHandler;", "GetGetMagHandlerHandler")]
				get {
					const string __id = "getMagHandler.()Lcom/vanstone/appsdk/api/cards/MAGHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? MemCardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getMemCardHandler' and count(parameter)=0]"
				[Register ("getMemCardHandler", "()Lcom/vanstone/appsdk/api/cards/MemCardHandler;", "GetGetMemCardHandlerHandler")]
				get {
					const string __id = "getMemCardHandler.()Lcom/vanstone/appsdk/api/cards/MemCardHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? NLDeviceScanHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getNLDeviceScanHandler' and count(parameter)=0]"
				[Register ("getNLDeviceScanHandler", "()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;", "GetGetNLDeviceScanHandlerHandler")]
				get {
					const string __id = "getNLDeviceScanHandler.()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? NumKeyBoardHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getNumKeyBoardHandler' and count(parameter)=0]"
				[Register ("getNumKeyBoardHandler", "()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;", "GetGetNumKeyBoardHandlerHandler")]
				get {
					const string __id = "getNumKeyBoardHandler.()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? PedHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getPedHandler' and count(parameter)=0]"
				[Register ("getPedHandler", "()Lcom/vanstone/appsdk/api/ped/PedHandler;", "GetGetPedHandlerHandler")]
				get {
					const string __id = "getPedHandler.()Lcom/vanstone/appsdk/api/ped/PedHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? PiccHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getPiccHandler' and count(parameter)=0]"
				[Register ("getPiccHandler", "()Lcom/vanstone/appsdk/api/cards/PICCHandler;", "GetGetPiccHandlerHandler")]
				get {
					const string __id = "getPiccHandler.()Lcom/vanstone/appsdk/api/cards/PICCHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? PrinterHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getPrinterHandler' and count(parameter)=0]"
				[Register ("getPrinterHandler", "()Lcom/vanstone/appsdk/api/printer/PrinterHandler;", "GetGetPrinterHandlerHandler")]
				get {
					const string __id = "getPrinterHandler.()Lcom/vanstone/appsdk/api/printer/PrinterHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? Rs232Handler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getRs232Handler' and count(parameter)=0]"
				[Register ("getRs232Handler", "()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;", "GetGetRs232HandlerHandler")]
				get {
					const string __id = "getRs232Handler.()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? ScanExHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getScanExHandler' and count(parameter)=0]"
				[Register ("getScanExHandler", "()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;", "GetGetScanExHandlerHandler")]
				get {
					const string __id = "getScanExHandler.()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? ScanHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getScanHandler' and count(parameter)=0]"
				[Register ("getScanHandler", "()Lcom/vanstone/appsdk/api/scan/ScanHandler;", "GetGetScanHandlerHandler")]
				get {
					const string __id = "getScanHandler.()Lcom/vanstone/appsdk/api/scan/ScanHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? SerialPortHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSerialPortHandler' and count(parameter)=0]"
				[Register ("getSerialPortHandler", "()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;", "GetGetSerialPortHandlerHandler")]
				get {
					const string __id = "getSerialPortHandler.()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? SignHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSignHandler' and count(parameter)=0]"
				[Register ("getSignHandler", "()Lcom/vanstone/appsdk/api/sign/SignHandler;", "GetGetSignHandlerHandler")]
				get {
					const string __id = "getSignHandler.()Lcom/vanstone/appsdk/api/sign/SignHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? SmHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSmHandler' and count(parameter)=0]"
				[Register ("getSmHandler", "()Lcom/vanstone/appsdk/api/sm/SmHandler;", "GetGetSmHandlerHandler")]
				get {
					const string __id = "getSmHandler.()Lcom/vanstone/appsdk/api/sm/SmHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? SystemHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getSystemHandler' and count(parameter)=0]"
				[Register ("getSystemHandler", "()Lcom/vanstone/appsdk/api/system/SystemHandler;", "GetGetSystemHandlerHandler")]
				get {
					const string __id = "getSystemHandler.()Lcom/vanstone/appsdk/api/system/SystemHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? TaxControlHandle {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getTaxControlHandle' and count(parameter)=0]"
				[Register ("getTaxControlHandle", "()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;", "GetGetTaxControlHandleHandler")]
				get {
					const string __id = "getTaxControlHandle.()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? WifiProbeHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.engine']/class[@name='SdkApiEngine.Stub']/method[@name='getWifiProbeHandler' and count(parameter)=0]"
				[Register ("getWifiProbeHandler", "()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;", "GetGetWifiProbeHandlerHandler")]
				get {
					const string __id = "getWifiProbeHandler.()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/engine/SdkApiEngine", DoNotGenerateAcw=true)]
	internal partial class ISdkApiEngineInvoker : global::Java.Lang.Object, ISdkApiEngine {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/engine/SdkApiEngine", typeof (ISdkApiEngineInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ISdkApiEngine? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISdkApiEngine> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.engine.SdkApiEngine'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISdkApiEngineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getApnHandler;
#pragma warning disable 0169
		static Delegate GetGetApnHandlerHandler ()
		{
			if (cb_getApnHandler == null)
				cb_getApnHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetApnHandler));
			return cb_getApnHandler;
		}

		static IntPtr n_GetApnHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ApnHandler);
		}
#pragma warning restore 0169

		IntPtr id_getApnHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? ApnHandler {
			get {
				if (id_getApnHandler == IntPtr.Zero)
					id_getApnHandler = JNIEnv.GetMethodID (class_ref, "getApnHandler", "()Lcom/vanstone/appsdk/api/common/ApnHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApnHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getAt24cXXHandler;
#pragma warning disable 0169
		static Delegate GetGetAt24cXXHandlerHandler ()
		{
			if (cb_getAt24cXXHandler == null)
				cb_getAt24cXXHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAt24cXXHandler));
			return cb_getAt24cXXHandler;
		}

		static IntPtr n_GetAt24cXXHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.At24cXXHandler);
		}
#pragma warning restore 0169

		IntPtr id_getAt24cXXHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? At24cXXHandler {
			get {
				if (id_getAt24cXXHandler == IntPtr.Zero)
					id_getAt24cXXHandler = JNIEnv.GetMethodID (class_ref, "getAt24cXXHandler", "()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAt24cXXHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getAt88scXXHandler;
#pragma warning disable 0169
		static Delegate GetGetAt88scXXHandlerHandler ()
		{
			if (cb_getAt88scXXHandler == null)
				cb_getAt88scXXHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAt88scXXHandler));
			return cb_getAt88scXXHandler;
		}

		static IntPtr n_GetAt88scXXHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.At88scXXHandler);
		}
#pragma warning restore 0169

		IntPtr id_getAt88scXXHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? At88scXXHandler {
			get {
				if (id_getAt88scXXHandler == IntPtr.Zero)
					id_getAt88scXXHandler = JNIEnv.GetMethodID (class_ref, "getAt88scXXHandler", "()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAt88scXXHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getAuthFaceHandler;
#pragma warning disable 0169
		static Delegate GetGetAuthFaceHandlerHandler ()
		{
			if (cb_getAuthFaceHandler == null)
				cb_getAuthFaceHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAuthFaceHandler));
			return cb_getAuthFaceHandler;
		}

		static IntPtr n_GetAuthFaceHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AuthFaceHandler);
		}
#pragma warning restore 0169

		IntPtr id_getAuthFaceHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? AuthFaceHandler {
			get {
				if (id_getAuthFaceHandler == IntPtr.Zero)
					id_getAuthFaceHandler = JNIEnv.GetMethodID (class_ref, "getAuthFaceHandler", "()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthFaceHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getCashBoxHandler;
#pragma warning disable 0169
		static Delegate GetGetCashBoxHandlerHandler ()
		{
			if (cb_getCashBoxHandler == null)
				cb_getCashBoxHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCashBoxHandler));
			return cb_getCashBoxHandler;
		}

		static IntPtr n_GetCashBoxHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CashBoxHandler);
		}
#pragma warning restore 0169

		IntPtr id_getCashBoxHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler? CashBoxHandler {
			get {
				if (id_getCashBoxHandler == IntPtr.Zero)
					id_getCashBoxHandler = JNIEnv.GetMethodID (class_ref, "getCashBoxHandler", "()Lcom/vanstone/appsdk/api/cashboxdriver/CashBoxHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cashboxdriver.ICashBoxHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCashBoxHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getCommHandler;
#pragma warning disable 0169
		static Delegate GetGetCommHandlerHandler ()
		{
			if (cb_getCommHandler == null)
				cb_getCommHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCommHandler));
			return cb_getCommHandler;
		}

		static IntPtr n_GetCommHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CommHandler);
		}
#pragma warning restore 0169

		IntPtr id_getCommHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? CommHandler {
			get {
				if (id_getCommHandler == IntPtr.Zero)
					id_getCommHandler = JNIEnv.GetMethodID (class_ref, "getCommHandler", "()Lcom/vanstone/appsdk/api/common/CommHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCommHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getContactlessHandler;
#pragma warning disable 0169
		static Delegate GetGetContactlessHandlerHandler ()
		{
			if (cb_getContactlessHandler == null)
				cb_getContactlessHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetContactlessHandler));
			return cb_getContactlessHandler;
		}

		static IntPtr n_GetContactlessHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ContactlessHandler);
		}
#pragma warning restore 0169

		IntPtr id_getContactlessHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? ContactlessHandler {
			get {
				if (id_getContactlessHandler == IntPtr.Zero)
					id_getContactlessHandler = JNIEnv.GetMethodID (class_ref, "getContactlessHandler", "()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactlessHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getDesfireHandler;
#pragma warning disable 0169
		static Delegate GetGetDesfireHandlerHandler ()
		{
			if (cb_getDesfireHandler == null)
				cb_getDesfireHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDesfireHandler));
			return cb_getDesfireHandler;
		}

		static IntPtr n_GetDesfireHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.DesfireHandler);
		}
#pragma warning restore 0169

		IntPtr id_getDesfireHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? DesfireHandler {
			get {
				if (id_getDesfireHandler == IntPtr.Zero)
					id_getDesfireHandler = JNIEnv.GetMethodID (class_ref, "getDesfireHandler", "()Lcom/vanstone/appsdk/api/cards/DesfireHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDesfireHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getDevinformHandler;
#pragma warning disable 0169
		static Delegate GetGetDevinformHandlerHandler ()
		{
			if (cb_getDevinformHandler == null)
				cb_getDevinformHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDevinformHandler));
			return cb_getDevinformHandler;
		}

		static IntPtr n_GetDevinformHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.DevinformHandler);
		}
#pragma warning restore 0169

		IntPtr id_getDevinformHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? DevinformHandler {
			get {
				if (id_getDevinformHandler == IntPtr.Zero)
					id_getDevinformHandler = JNIEnv.GetMethodID (class_ref, "getDevinformHandler", "()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDevinformHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getFingerHandler;
#pragma warning disable 0169
		static Delegate GetGetFingerHandlerHandler ()
		{
			if (cb_getFingerHandler == null)
				cb_getFingerHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFingerHandler));
			return cb_getFingerHandler;
		}

		static IntPtr n_GetFingerHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.FingerHandler);
		}
#pragma warning restore 0169

		IntPtr id_getFingerHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? FingerHandler {
			get {
				if (id_getFingerHandler == IntPtr.Zero)
					id_getFingerHandler = JNIEnv.GetMethodID (class_ref, "getFingerHandler", "()Lcom/vanstone/appsdk/api/finger/FingerHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFingerHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getFiscalHandler;
#pragma warning disable 0169
		static Delegate GetGetFiscalHandlerHandler ()
		{
			if (cb_getFiscalHandler == null)
				cb_getFiscalHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFiscalHandler));
			return cb_getFiscalHandler;
		}

		static IntPtr n_GetFiscalHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.FiscalHandler);
		}
#pragma warning restore 0169

		IntPtr id_getFiscalHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? FiscalHandler {
			get {
				if (id_getFiscalHandler == IntPtr.Zero)
					id_getFiscalHandler = JNIEnv.GetMethodID (class_ref, "getFiscalHandler", "()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFiscalHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getHsmHandler;
#pragma warning disable 0169
		static Delegate GetGetHsmHandlerHandler ()
		{
			if (cb_getHsmHandler == null)
				cb_getHsmHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHsmHandler));
			return cb_getHsmHandler;
		}

		static IntPtr n_GetHsmHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.HsmHandler);
		}
#pragma warning restore 0169

		IntPtr id_getHsmHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? HsmHandler {
			get {
				if (id_getHsmHandler == IntPtr.Zero)
					id_getHsmHandler = JNIEnv.GetMethodID (class_ref, "getHsmHandler", "()Lcom/vanstone/appsdk/api/hsm/HsmHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHsmHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getIDCardHandler;
#pragma warning disable 0169
		static Delegate GetGetIDCardHandlerHandler ()
		{
			if (cb_getIDCardHandler == null)
				cb_getIDCardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIDCardHandler));
			return cb_getIDCardHandler;
		}

		static IntPtr n_GetIDCardHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IDCardHandler);
		}
#pragma warning restore 0169

		IntPtr id_getIDCardHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? IDCardHandler {
			get {
				if (id_getIDCardHandler == IntPtr.Zero)
					id_getIDCardHandler = JNIEnv.GetMethodID (class_ref, "getIDCardHandler", "()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIDCardHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getIRThermometerHandler;
#pragma warning disable 0169
		static Delegate GetGetIRThermometerHandlerHandler ()
		{
			if (cb_getIRThermometerHandler == null)
				cb_getIRThermometerHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIRThermometerHandler));
			return cb_getIRThermometerHandler;
		}

		static IntPtr n_GetIRThermometerHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IRThermometerHandler);
		}
#pragma warning restore 0169

		IntPtr id_getIRThermometerHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? IRThermometerHandler {
			get {
				if (id_getIRThermometerHandler == IntPtr.Zero)
					id_getIRThermometerHandler = JNIEnv.GetMethodID (class_ref, "getIRThermometerHandler", "()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIRThermometerHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getIcHandler;
#pragma warning disable 0169
		static Delegate GetGetIcHandlerHandler ()
		{
			if (cb_getIcHandler == null)
				cb_getIcHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIcHandler));
			return cb_getIcHandler;
		}

		static IntPtr n_GetIcHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IcHandler);
		}
#pragma warning restore 0169

		IntPtr id_getIcHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? IcHandler {
			get {
				if (id_getIcHandler == IntPtr.Zero)
					id_getIcHandler = JNIEnv.GetMethodID (class_ref, "getIcHandler", "()Lcom/vanstone/appsdk/api/cards/ICHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getLcdHandler;
#pragma warning disable 0169
		static Delegate GetGetLcdHandlerHandler ()
		{
			if (cb_getLcdHandler == null)
				cb_getLcdHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLcdHandler));
			return cb_getLcdHandler;
		}

		static IntPtr n_GetLcdHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LcdHandler);
		}
#pragma warning restore 0169

		IntPtr id_getLcdHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? LcdHandler {
			get {
				if (id_getLcdHandler == IntPtr.Zero)
					id_getLcdHandler = JNIEnv.GetMethodID (class_ref, "getLcdHandler", "()Lcom/vanstone/appsdk/api/lcd/LcdHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLcdHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getLocationHandler;
#pragma warning disable 0169
		static Delegate GetGetLocationHandlerHandler ()
		{
			if (cb_getLocationHandler == null)
				cb_getLocationHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLocationHandler));
			return cb_getLocationHandler;
		}

		static IntPtr n_GetLocationHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LocationHandler);
		}
#pragma warning restore 0169

		IntPtr id_getLocationHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? LocationHandler {
			get {
				if (id_getLocationHandler == IntPtr.Zero)
					id_getLocationHandler = JNIEnv.GetMethodID (class_ref, "getLocationHandler", "()Lcom/vanstone/appsdk/api/location/LocationHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocationHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getMagHandler;
#pragma warning disable 0169
		static Delegate GetGetMagHandlerHandler ()
		{
			if (cb_getMagHandler == null)
				cb_getMagHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMagHandler));
			return cb_getMagHandler;
		}

		static IntPtr n_GetMagHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.MagHandler);
		}
#pragma warning restore 0169

		IntPtr id_getMagHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? MagHandler {
			get {
				if (id_getMagHandler == IntPtr.Zero)
					id_getMagHandler = JNIEnv.GetMethodID (class_ref, "getMagHandler", "()Lcom/vanstone/appsdk/api/cards/MAGHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getMemCardHandler;
#pragma warning disable 0169
		static Delegate GetGetMemCardHandlerHandler ()
		{
			if (cb_getMemCardHandler == null)
				cb_getMemCardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMemCardHandler));
			return cb_getMemCardHandler;
		}

		static IntPtr n_GetMemCardHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.MemCardHandler);
		}
#pragma warning restore 0169

		IntPtr id_getMemCardHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? MemCardHandler {
			get {
				if (id_getMemCardHandler == IntPtr.Zero)
					id_getMemCardHandler = JNIEnv.GetMethodID (class_ref, "getMemCardHandler", "()Lcom/vanstone/appsdk/api/cards/MemCardHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMemCardHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getNLDeviceScanHandler;
#pragma warning disable 0169
		static Delegate GetGetNLDeviceScanHandlerHandler ()
		{
			if (cb_getNLDeviceScanHandler == null)
				cb_getNLDeviceScanHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNLDeviceScanHandler));
			return cb_getNLDeviceScanHandler;
		}

		static IntPtr n_GetNLDeviceScanHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NLDeviceScanHandler);
		}
#pragma warning restore 0169

		IntPtr id_getNLDeviceScanHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? NLDeviceScanHandler {
			get {
				if (id_getNLDeviceScanHandler == IntPtr.Zero)
					id_getNLDeviceScanHandler = JNIEnv.GetMethodID (class_ref, "getNLDeviceScanHandler", "()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNLDeviceScanHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getNumKeyBoardHandler;
#pragma warning disable 0169
		static Delegate GetGetNumKeyBoardHandlerHandler ()
		{
			if (cb_getNumKeyBoardHandler == null)
				cb_getNumKeyBoardHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNumKeyBoardHandler));
			return cb_getNumKeyBoardHandler;
		}

		static IntPtr n_GetNumKeyBoardHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NumKeyBoardHandler);
		}
#pragma warning restore 0169

		IntPtr id_getNumKeyBoardHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? NumKeyBoardHandler {
			get {
				if (id_getNumKeyBoardHandler == IntPtr.Zero)
					id_getNumKeyBoardHandler = JNIEnv.GetMethodID (class_ref, "getNumKeyBoardHandler", "()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNumKeyBoardHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getPedHandler;
#pragma warning disable 0169
		static Delegate GetGetPedHandlerHandler ()
		{
			if (cb_getPedHandler == null)
				cb_getPedHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPedHandler));
			return cb_getPedHandler;
		}

		static IntPtr n_GetPedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PedHandler);
		}
#pragma warning restore 0169

		IntPtr id_getPedHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? PedHandler {
			get {
				if (id_getPedHandler == IntPtr.Zero)
					id_getPedHandler = JNIEnv.GetMethodID (class_ref, "getPedHandler", "()Lcom/vanstone/appsdk/api/ped/PedHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPedHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getPiccHandler;
#pragma warning disable 0169
		static Delegate GetGetPiccHandlerHandler ()
		{
			if (cb_getPiccHandler == null)
				cb_getPiccHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPiccHandler));
			return cb_getPiccHandler;
		}

		static IntPtr n_GetPiccHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PiccHandler);
		}
#pragma warning restore 0169

		IntPtr id_getPiccHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? PiccHandler {
			get {
				if (id_getPiccHandler == IntPtr.Zero)
					id_getPiccHandler = JNIEnv.GetMethodID (class_ref, "getPiccHandler", "()Lcom/vanstone/appsdk/api/cards/PICCHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPiccHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getPrinterHandler;
#pragma warning disable 0169
		static Delegate GetGetPrinterHandlerHandler ()
		{
			if (cb_getPrinterHandler == null)
				cb_getPrinterHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPrinterHandler));
			return cb_getPrinterHandler;
		}

		static IntPtr n_GetPrinterHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PrinterHandler);
		}
#pragma warning restore 0169

		IntPtr id_getPrinterHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? PrinterHandler {
			get {
				if (id_getPrinterHandler == IntPtr.Zero)
					id_getPrinterHandler = JNIEnv.GetMethodID (class_ref, "getPrinterHandler", "()Lcom/vanstone/appsdk/api/printer/PrinterHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrinterHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getRs232Handler;
#pragma warning disable 0169
		static Delegate GetGetRs232HandlerHandler ()
		{
			if (cb_getRs232Handler == null)
				cb_getRs232Handler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRs232Handler));
			return cb_getRs232Handler;
		}

		static IntPtr n_GetRs232Handler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Rs232Handler);
		}
#pragma warning restore 0169

		IntPtr id_getRs232Handler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? Rs232Handler {
			get {
				if (id_getRs232Handler == IntPtr.Zero)
					id_getRs232Handler = JNIEnv.GetMethodID (class_ref, "getRs232Handler", "()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRs232Handler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getScanExHandler;
#pragma warning disable 0169
		static Delegate GetGetScanExHandlerHandler ()
		{
			if (cb_getScanExHandler == null)
				cb_getScanExHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetScanExHandler));
			return cb_getScanExHandler;
		}

		static IntPtr n_GetScanExHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ScanExHandler);
		}
#pragma warning restore 0169

		IntPtr id_getScanExHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? ScanExHandler {
			get {
				if (id_getScanExHandler == IntPtr.Zero)
					id_getScanExHandler = JNIEnv.GetMethodID (class_ref, "getScanExHandler", "()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScanExHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getScanHandler;
#pragma warning disable 0169
		static Delegate GetGetScanHandlerHandler ()
		{
			if (cb_getScanHandler == null)
				cb_getScanHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetScanHandler));
			return cb_getScanHandler;
		}

		static IntPtr n_GetScanHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ScanHandler);
		}
#pragma warning restore 0169

		IntPtr id_getScanHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? ScanHandler {
			get {
				if (id_getScanHandler == IntPtr.Zero)
					id_getScanHandler = JNIEnv.GetMethodID (class_ref, "getScanHandler", "()Lcom/vanstone/appsdk/api/scan/ScanHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScanHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSerialPortHandler;
#pragma warning disable 0169
		static Delegate GetGetSerialPortHandlerHandler ()
		{
			if (cb_getSerialPortHandler == null)
				cb_getSerialPortHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSerialPortHandler));
			return cb_getSerialPortHandler;
		}

		static IntPtr n_GetSerialPortHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SerialPortHandler);
		}
#pragma warning restore 0169

		IntPtr id_getSerialPortHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? SerialPortHandler {
			get {
				if (id_getSerialPortHandler == IntPtr.Zero)
					id_getSerialPortHandler = JNIEnv.GetMethodID (class_ref, "getSerialPortHandler", "()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialPortHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSignHandler;
#pragma warning disable 0169
		static Delegate GetGetSignHandlerHandler ()
		{
			if (cb_getSignHandler == null)
				cb_getSignHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignHandler));
			return cb_getSignHandler;
		}

		static IntPtr n_GetSignHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SignHandler);
		}
#pragma warning restore 0169

		IntPtr id_getSignHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? SignHandler {
			get {
				if (id_getSignHandler == IntPtr.Zero)
					id_getSignHandler = JNIEnv.GetMethodID (class_ref, "getSignHandler", "()Lcom/vanstone/appsdk/api/sign/SignHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSmHandler;
#pragma warning disable 0169
		static Delegate GetGetSmHandlerHandler ()
		{
			if (cb_getSmHandler == null)
				cb_getSmHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSmHandler));
			return cb_getSmHandler;
		}

		static IntPtr n_GetSmHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SmHandler);
		}
#pragma warning restore 0169

		IntPtr id_getSmHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? SmHandler {
			get {
				if (id_getSmHandler == IntPtr.Zero)
					id_getSmHandler = JNIEnv.GetMethodID (class_ref, "getSmHandler", "()Lcom/vanstone/appsdk/api/sm/SmHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSmHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSystemHandler;
#pragma warning disable 0169
		static Delegate GetGetSystemHandlerHandler ()
		{
			if (cb_getSystemHandler == null)
				cb_getSystemHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSystemHandler));
			return cb_getSystemHandler;
		}

		static IntPtr n_GetSystemHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SystemHandler);
		}
#pragma warning restore 0169

		IntPtr id_getSystemHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? SystemHandler {
			get {
				if (id_getSystemHandler == IntPtr.Zero)
					id_getSystemHandler = JNIEnv.GetMethodID (class_ref, "getSystemHandler", "()Lcom/vanstone/appsdk/api/system/SystemHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSystemHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getTaxControlHandle;
#pragma warning disable 0169
		static Delegate GetGetTaxControlHandleHandler ()
		{
			if (cb_getTaxControlHandle == null)
				cb_getTaxControlHandle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTaxControlHandle));
			return cb_getTaxControlHandle;
		}

		static IntPtr n_GetTaxControlHandle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.TaxControlHandle);
		}
#pragma warning restore 0169

		IntPtr id_getTaxControlHandle;
		public unsafe global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? TaxControlHandle {
			get {
				if (id_getTaxControlHandle == IntPtr.Zero)
					id_getTaxControlHandle = JNIEnv.GetMethodID (class_ref, "getTaxControlHandle", "()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxControlHandle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getWifiProbeHandler;
#pragma warning disable 0169
		static Delegate GetGetWifiProbeHandlerHandler ()
		{
			if (cb_getWifiProbeHandler == null)
				cb_getWifiProbeHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetWifiProbeHandler));
			return cb_getWifiProbeHandler;
		}

		static IntPtr n_GetWifiProbeHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.WifiProbeHandler);
		}
#pragma warning restore 0169

		IntPtr id_getWifiProbeHandler;
		public unsafe global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? WifiProbeHandler {
			get {
				if (id_getWifiProbeHandler == IntPtr.Zero)
					id_getWifiProbeHandler = JNIEnv.GetMethodID (class_ref, "getWifiProbeHandler", "()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWifiProbeHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Engine.ISdkApiEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder? AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
