using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']"
	[Register ("com/vanstone/appsdk/api/cards/PICCHandler", "", "Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker")]
	public partial interface IPICCHandler : global::Android.OS.IInterface {
		global::Android.Graphics.Bitmap? IDCardImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='getIDCardImage' and count(parameter)=0]"
			[Register ("getIDCardImage", "()Landroid/graphics/Bitmap;", "GetGetIDCardImageHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='CommCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("CommCardCommand_Api", "([BI[B)I", "GetCommCardCommand_Api_arrayBIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int CommCardCommand_Api (byte[]? p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1Authority_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("M1Authority_Api", "(II[B)I", "GetM1Authority_Api_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int M1Authority_Api (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1DecreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("M1DecreaseValue_Api", "(III)I", "GetM1DecreaseValue_Api_IIIHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int M1DecreaseValue_Api (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1IncreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("M1IncreaseValue_Api", "(III)I", "GetM1IncreaseValue_Api_IIIHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int M1IncreaseValue_Api (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1ReadBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("M1ReadBlock_Api", "(I[B)I", "GetM1ReadBlock_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int M1ReadBlock_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1WriteBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("M1WriteBlock_Api", "(I[B)I", "GetM1WriteBlock_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int M1WriteBlock_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCListenStart_Api' and count(parameter)=0]"
		[Register ("NFCListenStart_Api", "()I", "GetNFCListenStart_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NFCListenStart_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCListenStop_Api' and count(parameter)=0]"
		[Register ("NFCListenStop_Api", "()I", "GetNFCListenStop_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NFCListenStop_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCPowerControl_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("NFCPowerControl_Api", "(Z)I", "GetNFCPowerControl_Api_ZHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NFCPowerControl_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCReadUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("NFCReadUriInfo_Api", "([B[B[B)I", "GetNFCReadUriInfo_Api_arrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NFCReadUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCWriteUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("NFCWriteUriInfo_Api", "([B[B[B)I", "GetNFCWriteUriInfo_Api_arrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NFCWriteUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGAuthority_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("NTAGAuthority_Api", "([B[B)I", "GetNTAGAuthority_Api_arrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NTAGAuthority_Api (byte[]? p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGFastReadData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("NTAGFastReadData_Api", "(II[B)I", "GetNTAGFastReadData_Api_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NTAGFastReadData_Api (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGGetCardInfo_Api' and count(parameter)=0]"
		[Register ("NTAGGetCardInfo_Api", "()Landroid/os/Bundle;", "GetNTAGGetCardInfo_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		global::Android.OS.Bundle? NTAGGetCardInfo_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadCount_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("NTAGReadCount_Api", "([B)I", "GetNTAGReadCount_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NTAGReadCount_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("NTAGReadData_Api", "(I[B)I", "GetNTAGReadData_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NTAGReadData_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadSign_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("NTAGReadSign_Api", "([B)I", "GetNTAGReadSign_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NTAGReadSign_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGWriteData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("NTAGWriteData_Api", "(I[B)I", "GetNTAGWriteData_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int NTAGWriteData_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("PiccCheck_Api", "(I[B[B)I", "GetPiccCheck_Api_IarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccCheck_Api (int p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccClose_Api' and count(parameter)=0]"
		[Register ("PiccClose_Api", "()I", "GetPiccClose_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccGetCardInfo_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("PiccGetCardInfo_Api", "([B[B[B[B)I", "GetPiccGetCardInfo_Api_arrayBarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccGetCardInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccHalt_Api' and count(parameter)=0]"
		[Register ("PiccHalt_Api", "()I", "GetPiccHalt_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccHalt_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccIsoCommandType_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("PiccIsoCommandType_Api", "(I[BI[B)I", "GetPiccIsoCommandType_Api_IarrayBIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccIsoCommandType_Api (int p0, byte[]? p1, int p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccIsoCommand_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.Apdu']]"
		[Register ("PiccIsoCommand_Api", "(Lcom/vanstone/appsdk/api/struct/Apdu;)V", "GetPiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_Handler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		void PiccIsoCommand_Api (global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccOpen_Api' and count(parameter)=0]"
		[Register ("PiccOpen_Api", "()I", "GetPiccOpen_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccRemove_Api' and count(parameter)=0]"
		[Register ("PiccRemove_Api", "()I", "GetPiccRemove_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccRemove_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccRest_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("PiccRest_Api", "(I[B)I", "GetPiccRest_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int PiccRest_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='SidCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("SidCardCommand_Api", "([BI[B)I", "GetSidCardCommand_Api_arrayBIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int SidCardCommand_Api (byte[]? p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='getIDCardMsg' and count(parameter)=12 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]'] and parameter[9][@type='byte[]'] and parameter[10][@type='byte[]'] and parameter[11][@type='byte[]'] and parameter[12][@type='byte[]']]"
		[Register ("getIDCardMsg", "([B[B[B[B[B[B[B[B[B[B[B[B)I", "GetGetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IPICCHandlerInvoker, VanstonePosSdk")]
		int GetIDCardMsg (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, byte[]? p7, byte[]? p8, byte[]? p9, byte[]? p10, byte[]? p11);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/PICCHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/PICCHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/constructor[@name='PICCHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_getIDCardImage;
#pragma warning disable 0169
			static Delegate GetGetIDCardImageHandler ()
			{
				if (cb_getIDCardImage == null)
					cb_getIDCardImage = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIDCardImage));
				return cb_getIDCardImage;
			}

			static IntPtr n_GetIDCardImage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IDCardImage);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Bitmap? IDCardImage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='getIDCardImage' and count(parameter)=0]"
				[Register ("getIDCardImage", "()Landroid/graphics/Bitmap;", "GetGetIDCardImageHandler")]
				get {
					const string __id = "getIDCardImage.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_CommCardCommand_Api_arrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetCommCardCommand_Api_arrayBIarrayBHandler ()
			{
				if (cb_CommCardCommand_Api_arrayBIarrayB == null)
					cb_CommCardCommand_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_CommCardCommand_Api_arrayBIarrayB));
				return cb_CommCardCommand_Api_arrayBIarrayB;
			}

			static int n_CommCardCommand_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cmdIn, int cmdLen, IntPtr native_cmdResp)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var cmdIn = (byte[]?) JNIEnv.GetArray (native_cmdIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var cmdResp = (byte[]?) JNIEnv.GetArray (native_cmdResp, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CommCardCommand_Api (cmdIn, cmdLen, cmdResp);
				if (cmdIn != null)
					JNIEnv.CopyArray (cmdIn, native_cmdIn);
				if (cmdResp != null)
					JNIEnv.CopyArray (cmdResp, native_cmdResp);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='CommCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("CommCardCommand_Api", "([BI[B)I", "GetCommCardCommand_Api_arrayBIarrayBHandler")]
			public virtual unsafe int CommCardCommand_Api (byte[]? cmdIn, int cmdLen, byte[]? cmdResp)
			{
				const string __id = "CommCardCommand_Api.([BI[B)I";
				IntPtr native_cmdIn = JNIEnv.NewArray (cmdIn);
				IntPtr native_cmdResp = JNIEnv.NewArray (cmdResp);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_cmdIn);
					__args [1] = new JniArgumentValue (cmdLen);
					__args [2] = new JniArgumentValue (native_cmdResp);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (cmdIn != null) {
						JNIEnv.CopyArray (native_cmdIn, cmdIn);
						JNIEnv.DeleteLocalRef (native_cmdIn);
					}
					if (cmdResp != null) {
						JNIEnv.CopyArray (native_cmdResp, cmdResp);
						JNIEnv.DeleteLocalRef (native_cmdResp);
					}
					global::System.GC.KeepAlive (cmdIn);
					global::System.GC.KeepAlive (cmdResp);
				}
			}

			static Delegate? cb_M1Authority_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetM1Authority_Api_IIarrayBHandler ()
			{
				if (cb_M1Authority_Api_IIarrayB == null)
					cb_M1Authority_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_M1Authority_Api_IIarrayB));
				return cb_M1Authority_Api_IIarrayB;
			}

			static int n_M1Authority_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int Type, int blkNo, IntPtr native_Pwd)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Pwd = (byte[]?) JNIEnv.GetArray (native_Pwd, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.M1Authority_Api (Type, blkNo, Pwd);
				if (Pwd != null)
					JNIEnv.CopyArray (Pwd, native_Pwd);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='M1Authority_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("M1Authority_Api", "(II[B)I", "GetM1Authority_Api_IIarrayBHandler")]
			public virtual unsafe int M1Authority_Api (int Type, int blkNo, byte[]? Pwd)
			{
				const string __id = "M1Authority_Api.(II[B)I";
				IntPtr native_Pwd = JNIEnv.NewArray (Pwd);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (Type);
					__args [1] = new JniArgumentValue (blkNo);
					__args [2] = new JniArgumentValue (native_Pwd);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Pwd != null) {
						JNIEnv.CopyArray (native_Pwd, Pwd);
						JNIEnv.DeleteLocalRef (native_Pwd);
					}
					global::System.GC.KeepAlive (Pwd);
				}
			}

			static Delegate? cb_M1DecreaseValue_Api_III;
#pragma warning disable 0169
			static Delegate GetM1DecreaseValue_Api_IIIHandler ()
			{
				if (cb_M1DecreaseValue_Api_III == null)
					cb_M1DecreaseValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_M1DecreaseValue_Api_III));
				return cb_M1DecreaseValue_Api_III;
			}

			static int n_M1DecreaseValue_Api_III (IntPtr jnienv, IntPtr native__this, int blockNo, int value, int bkBlockNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1DecreaseValue_Api (blockNo, value, bkBlockNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='M1DecreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("M1DecreaseValue_Api", "(III)I", "GetM1DecreaseValue_Api_IIIHandler")]
			public virtual unsafe int M1DecreaseValue_Api (int blockNo, int value, int bkBlockNo)
			{
				const string __id = "M1DecreaseValue_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (blockNo);
					__args [1] = new JniArgumentValue (value);
					__args [2] = new JniArgumentValue (bkBlockNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_M1IncreaseValue_Api_III;
#pragma warning disable 0169
			static Delegate GetM1IncreaseValue_Api_IIIHandler ()
			{
				if (cb_M1IncreaseValue_Api_III == null)
					cb_M1IncreaseValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_M1IncreaseValue_Api_III));
				return cb_M1IncreaseValue_Api_III;
			}

			static int n_M1IncreaseValue_Api_III (IntPtr jnienv, IntPtr native__this, int blockNo, int value, int bkBlockNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1IncreaseValue_Api (blockNo, value, bkBlockNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='M1IncreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("M1IncreaseValue_Api", "(III)I", "GetM1IncreaseValue_Api_IIIHandler")]
			public virtual unsafe int M1IncreaseValue_Api (int blockNo, int value, int bkBlockNo)
			{
				const string __id = "M1IncreaseValue_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (blockNo);
					__args [1] = new JniArgumentValue (value);
					__args [2] = new JniArgumentValue (bkBlockNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_M1ReadBlock_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetM1ReadBlock_Api_IarrayBHandler ()
			{
				if (cb_M1ReadBlock_Api_IarrayB == null)
					cb_M1ReadBlock_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_M1ReadBlock_Api_IarrayB));
				return cb_M1ReadBlock_Api_IarrayB;
			}

			static int n_M1ReadBlock_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int BlkNo, IntPtr native_BlkValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var BlkValue = (byte[]?) JNIEnv.GetArray (native_BlkValue, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.M1ReadBlock_Api (BlkNo, BlkValue);
				if (BlkValue != null)
					JNIEnv.CopyArray (BlkValue, native_BlkValue);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='M1ReadBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("M1ReadBlock_Api", "(I[B)I", "GetM1ReadBlock_Api_IarrayBHandler")]
			public virtual unsafe int M1ReadBlock_Api (int BlkNo, byte[]? BlkValue)
			{
				const string __id = "M1ReadBlock_Api.(I[B)I";
				IntPtr native_BlkValue = JNIEnv.NewArray (BlkValue);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (BlkNo);
					__args [1] = new JniArgumentValue (native_BlkValue);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (BlkValue != null) {
						JNIEnv.CopyArray (native_BlkValue, BlkValue);
						JNIEnv.DeleteLocalRef (native_BlkValue);
					}
					global::System.GC.KeepAlive (BlkValue);
				}
			}

			static Delegate? cb_M1WriteBlock_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetM1WriteBlock_Api_IarrayBHandler ()
			{
				if (cb_M1WriteBlock_Api_IarrayB == null)
					cb_M1WriteBlock_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_M1WriteBlock_Api_IarrayB));
				return cb_M1WriteBlock_Api_IarrayB;
			}

			static int n_M1WriteBlock_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int BlkNo, IntPtr native_BlkValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var BlkValue = (byte[]?) JNIEnv.GetArray (native_BlkValue, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.M1WriteBlock_Api (BlkNo, BlkValue);
				if (BlkValue != null)
					JNIEnv.CopyArray (BlkValue, native_BlkValue);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='M1WriteBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("M1WriteBlock_Api", "(I[B)I", "GetM1WriteBlock_Api_IarrayBHandler")]
			public virtual unsafe int M1WriteBlock_Api (int BlkNo, byte[]? BlkValue)
			{
				const string __id = "M1WriteBlock_Api.(I[B)I";
				IntPtr native_BlkValue = JNIEnv.NewArray (BlkValue);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (BlkNo);
					__args [1] = new JniArgumentValue (native_BlkValue);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (BlkValue != null) {
						JNIEnv.CopyArray (native_BlkValue, BlkValue);
						JNIEnv.DeleteLocalRef (native_BlkValue);
					}
					global::System.GC.KeepAlive (BlkValue);
				}
			}

			static Delegate? cb_NFCListenStart_Api;
#pragma warning disable 0169
			static Delegate GetNFCListenStart_ApiHandler ()
			{
				if (cb_NFCListenStart_Api == null)
					cb_NFCListenStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_NFCListenStart_Api));
				return cb_NFCListenStart_Api;
			}

			static int n_NFCListenStart_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NFCListenStart_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NFCListenStart_Api' and count(parameter)=0]"
			[Register ("NFCListenStart_Api", "()I", "GetNFCListenStart_ApiHandler")]
			public virtual unsafe int NFCListenStart_Api ()
			{
				const string __id = "NFCListenStart_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_NFCListenStop_Api;
#pragma warning disable 0169
			static Delegate GetNFCListenStop_ApiHandler ()
			{
				if (cb_NFCListenStop_Api == null)
					cb_NFCListenStop_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_NFCListenStop_Api));
				return cb_NFCListenStop_Api;
			}

			static int n_NFCListenStop_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NFCListenStop_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NFCListenStop_Api' and count(parameter)=0]"
			[Register ("NFCListenStop_Api", "()I", "GetNFCListenStop_ApiHandler")]
			public virtual unsafe int NFCListenStop_Api ()
			{
				const string __id = "NFCListenStop_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_NFCPowerControl_Api_Z;
#pragma warning disable 0169
			static Delegate GetNFCPowerControl_Api_ZHandler ()
			{
				if (cb_NFCPowerControl_Api_Z == null)
					cb_NFCPowerControl_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_I (n_NFCPowerControl_Api_Z));
				return cb_NFCPowerControl_Api_Z;
			}

			static int n_NFCPowerControl_Api_Z (IntPtr jnienv, IntPtr native__this, bool state)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NFCPowerControl_Api (state);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NFCPowerControl_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("NFCPowerControl_Api", "(Z)I", "GetNFCPowerControl_Api_ZHandler")]
			public virtual unsafe int NFCPowerControl_Api (bool state)
			{
				const string __id = "NFCPowerControl_Api.(Z)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (state);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_NFCReadUriInfo_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetNFCReadUriInfo_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_NFCReadUriInfo_Api_arrayBarrayBarrayB == null)
					cb_NFCReadUriInfo_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_NFCReadUriInfo_Api_arrayBarrayBarrayB));
				return cb_NFCReadUriInfo_Api_arrayBarrayBarrayB;
			}

			static int n_NFCReadUriInfo_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_protocol, IntPtr native_uriMessage, IntPtr native_info)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var protocol = (byte[]?) JNIEnv.GetArray (native_protocol, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var uriMessage = (byte[]?) JNIEnv.GetArray (native_uriMessage, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var info = (byte[]?) JNIEnv.GetArray (native_info, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NFCReadUriInfo_Api (protocol, uriMessage, info);
				if (protocol != null)
					JNIEnv.CopyArray (protocol, native_protocol);
				if (uriMessage != null)
					JNIEnv.CopyArray (uriMessage, native_uriMessage);
				if (info != null)
					JNIEnv.CopyArray (info, native_info);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NFCReadUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("NFCReadUriInfo_Api", "([B[B[B)I", "GetNFCReadUriInfo_Api_arrayBarrayBarrayBHandler")]
			public virtual unsafe int NFCReadUriInfo_Api (byte[]? protocol, byte[]? uriMessage, byte[]? info)
			{
				const string __id = "NFCReadUriInfo_Api.([B[B[B)I";
				IntPtr native_protocol = JNIEnv.NewArray (protocol);
				IntPtr native_uriMessage = JNIEnv.NewArray (uriMessage);
				IntPtr native_info = JNIEnv.NewArray (info);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_protocol);
					__args [1] = new JniArgumentValue (native_uriMessage);
					__args [2] = new JniArgumentValue (native_info);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (protocol != null) {
						JNIEnv.CopyArray (native_protocol, protocol);
						JNIEnv.DeleteLocalRef (native_protocol);
					}
					if (uriMessage != null) {
						JNIEnv.CopyArray (native_uriMessage, uriMessage);
						JNIEnv.DeleteLocalRef (native_uriMessage);
					}
					if (info != null) {
						JNIEnv.CopyArray (native_info, info);
						JNIEnv.DeleteLocalRef (native_info);
					}
					global::System.GC.KeepAlive (protocol);
					global::System.GC.KeepAlive (uriMessage);
					global::System.GC.KeepAlive (info);
				}
			}

			static Delegate? cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetNFCWriteUriInfo_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB == null)
					cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_NFCWriteUriInfo_Api_arrayBarrayBarrayB));
				return cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB;
			}

			static int n_NFCWriteUriInfo_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_protocol, IntPtr native_uriMessage, IntPtr native_info)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var protocol = (byte[]?) JNIEnv.GetArray (native_protocol, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var uriMessage = (byte[]?) JNIEnv.GetArray (native_uriMessage, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var info = (byte[]?) JNIEnv.GetArray (native_info, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NFCWriteUriInfo_Api (protocol, uriMessage, info);
				if (protocol != null)
					JNIEnv.CopyArray (protocol, native_protocol);
				if (uriMessage != null)
					JNIEnv.CopyArray (uriMessage, native_uriMessage);
				if (info != null)
					JNIEnv.CopyArray (info, native_info);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NFCWriteUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("NFCWriteUriInfo_Api", "([B[B[B)I", "GetNFCWriteUriInfo_Api_arrayBarrayBarrayBHandler")]
			public virtual unsafe int NFCWriteUriInfo_Api (byte[]? protocol, byte[]? uriMessage, byte[]? info)
			{
				const string __id = "NFCWriteUriInfo_Api.([B[B[B)I";
				IntPtr native_protocol = JNIEnv.NewArray (protocol);
				IntPtr native_uriMessage = JNIEnv.NewArray (uriMessage);
				IntPtr native_info = JNIEnv.NewArray (info);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_protocol);
					__args [1] = new JniArgumentValue (native_uriMessage);
					__args [2] = new JniArgumentValue (native_info);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (protocol != null) {
						JNIEnv.CopyArray (native_protocol, protocol);
						JNIEnv.DeleteLocalRef (native_protocol);
					}
					if (uriMessage != null) {
						JNIEnv.CopyArray (native_uriMessage, uriMessage);
						JNIEnv.DeleteLocalRef (native_uriMessage);
					}
					if (info != null) {
						JNIEnv.CopyArray (native_info, info);
						JNIEnv.DeleteLocalRef (native_info);
					}
					global::System.GC.KeepAlive (protocol);
					global::System.GC.KeepAlive (uriMessage);
					global::System.GC.KeepAlive (info);
				}
			}

			static Delegate? cb_NTAGAuthority_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGAuthority_Api_arrayBarrayBHandler ()
			{
				if (cb_NTAGAuthority_Api_arrayBarrayB == null)
					cb_NTAGAuthority_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_NTAGAuthority_Api_arrayBarrayB));
				return cb_NTAGAuthority_Api_arrayBarrayB;
			}

			static int n_NTAGAuthority_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pwd, IntPtr native_result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pwd = (byte[]?) JNIEnv.GetArray (native_pwd, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var result = (byte[]?) JNIEnv.GetArray (native_result, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGAuthority_Api (pwd, result);
				if (pwd != null)
					JNIEnv.CopyArray (pwd, native_pwd);
				if (result != null)
					JNIEnv.CopyArray (result, native_result);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NTAGAuthority_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGAuthority_Api", "([B[B)I", "GetNTAGAuthority_Api_arrayBarrayBHandler")]
			public virtual unsafe int NTAGAuthority_Api (byte[]? pwd, byte[]? result)
			{
				const string __id = "NTAGAuthority_Api.([B[B)I";
				IntPtr native_pwd = JNIEnv.NewArray (pwd);
				IntPtr native_result = JNIEnv.NewArray (result);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_pwd);
					__args [1] = new JniArgumentValue (native_result);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pwd != null) {
						JNIEnv.CopyArray (native_pwd, pwd);
						JNIEnv.DeleteLocalRef (native_pwd);
					}
					if (result != null) {
						JNIEnv.CopyArray (native_result, result);
						JNIEnv.DeleteLocalRef (native_result);
					}
					global::System.GC.KeepAlive (pwd);
					global::System.GC.KeepAlive (result);
				}
			}

			static Delegate? cb_NTAGFastReadData_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGFastReadData_Api_IIarrayBHandler ()
			{
				if (cb_NTAGFastReadData_Api_IIarrayB == null)
					cb_NTAGFastReadData_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_NTAGFastReadData_Api_IIarrayB));
				return cb_NTAGFastReadData_Api_IIarrayB;
			}

			static int n_NTAGFastReadData_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int beginPageNum, int endPageNum, IntPtr native_DataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var DataOut = (byte[]?) JNIEnv.GetArray (native_DataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGFastReadData_Api (beginPageNum, endPageNum, DataOut);
				if (DataOut != null)
					JNIEnv.CopyArray (DataOut, native_DataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NTAGFastReadData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("NTAGFastReadData_Api", "(II[B)I", "GetNTAGFastReadData_Api_IIarrayBHandler")]
			public virtual unsafe int NTAGFastReadData_Api (int beginPageNum, int endPageNum, byte[]? DataOut)
			{
				const string __id = "NTAGFastReadData_Api.(II[B)I";
				IntPtr native_DataOut = JNIEnv.NewArray (DataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (beginPageNum);
					__args [1] = new JniArgumentValue (endPageNum);
					__args [2] = new JniArgumentValue (native_DataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (DataOut != null) {
						JNIEnv.CopyArray (native_DataOut, DataOut);
						JNIEnv.DeleteLocalRef (native_DataOut);
					}
					global::System.GC.KeepAlive (DataOut);
				}
			}

			static Delegate? cb_NTAGGetCardInfo_Api;
#pragma warning disable 0169
			static Delegate GetNTAGGetCardInfo_ApiHandler ()
			{
				if (cb_NTAGGetCardInfo_Api == null)
					cb_NTAGGetCardInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NTAGGetCardInfo_Api));
				return cb_NTAGGetCardInfo_Api;
			}

			static IntPtr n_NTAGGetCardInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.NTAGGetCardInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NTAGGetCardInfo_Api' and count(parameter)=0]"
			[Register ("NTAGGetCardInfo_Api", "()Landroid/os/Bundle;", "GetNTAGGetCardInfo_ApiHandler")]
			public virtual unsafe global::Android.OS.Bundle? NTAGGetCardInfo_Api ()
			{
				const string __id = "NTAGGetCardInfo_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_NTAGReadCount_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetNTAGReadCount_Api_arrayBHandler ()
			{
				if (cb_NTAGReadCount_Api_arrayB == null)
					cb_NTAGReadCount_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_NTAGReadCount_Api_arrayB));
				return cb_NTAGReadCount_Api_arrayB;
			}

			static int n_NTAGReadCount_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_Count)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Count = (byte[]?) JNIEnv.GetArray (native_Count, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGReadCount_Api (Count);
				if (Count != null)
					JNIEnv.CopyArray (Count, native_Count);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NTAGReadCount_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("NTAGReadCount_Api", "([B)I", "GetNTAGReadCount_Api_arrayBHandler")]
			public virtual unsafe int NTAGReadCount_Api (byte[]? Count)
			{
				const string __id = "NTAGReadCount_Api.([B)I";
				IntPtr native_Count = JNIEnv.NewArray (Count);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_Count);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Count != null) {
						JNIEnv.CopyArray (native_Count, Count);
						JNIEnv.DeleteLocalRef (native_Count);
					}
					global::System.GC.KeepAlive (Count);
				}
			}

			static Delegate? cb_NTAGReadData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGReadData_Api_IarrayBHandler ()
			{
				if (cb_NTAGReadData_Api_IarrayB == null)
					cb_NTAGReadData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_NTAGReadData_Api_IarrayB));
				return cb_NTAGReadData_Api_IarrayB;
			}

			static int n_NTAGReadData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int pageNum, IntPtr native_DataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var DataOut = (byte[]?) JNIEnv.GetArray (native_DataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGReadData_Api (pageNum, DataOut);
				if (DataOut != null)
					JNIEnv.CopyArray (DataOut, native_DataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NTAGReadData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGReadData_Api", "(I[B)I", "GetNTAGReadData_Api_IarrayBHandler")]
			public virtual unsafe int NTAGReadData_Api (int pageNum, byte[]? DataOut)
			{
				const string __id = "NTAGReadData_Api.(I[B)I";
				IntPtr native_DataOut = JNIEnv.NewArray (DataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (pageNum);
					__args [1] = new JniArgumentValue (native_DataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (DataOut != null) {
						JNIEnv.CopyArray (native_DataOut, DataOut);
						JNIEnv.DeleteLocalRef (native_DataOut);
					}
					global::System.GC.KeepAlive (DataOut);
				}
			}

			static Delegate? cb_NTAGReadSign_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetNTAGReadSign_Api_arrayBHandler ()
			{
				if (cb_NTAGReadSign_Api_arrayB == null)
					cb_NTAGReadSign_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_NTAGReadSign_Api_arrayB));
				return cb_NTAGReadSign_Api_arrayB;
			}

			static int n_NTAGReadSign_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_SignData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var SignData = (byte[]?) JNIEnv.GetArray (native_SignData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGReadSign_Api (SignData);
				if (SignData != null)
					JNIEnv.CopyArray (SignData, native_SignData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NTAGReadSign_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("NTAGReadSign_Api", "([B)I", "GetNTAGReadSign_Api_arrayBHandler")]
			public virtual unsafe int NTAGReadSign_Api (byte[]? SignData)
			{
				const string __id = "NTAGReadSign_Api.([B)I";
				IntPtr native_SignData = JNIEnv.NewArray (SignData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_SignData);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (SignData != null) {
						JNIEnv.CopyArray (native_SignData, SignData);
						JNIEnv.DeleteLocalRef (native_SignData);
					}
					global::System.GC.KeepAlive (SignData);
				}
			}

			static Delegate? cb_NTAGWriteData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGWriteData_Api_IarrayBHandler ()
			{
				if (cb_NTAGWriteData_Api_IarrayB == null)
					cb_NTAGWriteData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_NTAGWriteData_Api_IarrayB));
				return cb_NTAGWriteData_Api_IarrayB;
			}

			static int n_NTAGWriteData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int pageNum, IntPtr native_DataIn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var DataIn = (byte[]?) JNIEnv.GetArray (native_DataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGWriteData_Api (pageNum, DataIn);
				if (DataIn != null)
					JNIEnv.CopyArray (DataIn, native_DataIn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='NTAGWriteData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGWriteData_Api", "(I[B)I", "GetNTAGWriteData_Api_IarrayBHandler")]
			public virtual unsafe int NTAGWriteData_Api (int pageNum, byte[]? DataIn)
			{
				const string __id = "NTAGWriteData_Api.(I[B)I";
				IntPtr native_DataIn = JNIEnv.NewArray (DataIn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (pageNum);
					__args [1] = new JniArgumentValue (native_DataIn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (DataIn != null) {
						JNIEnv.CopyArray (native_DataIn, DataIn);
						JNIEnv.DeleteLocalRef (native_DataIn);
					}
					global::System.GC.KeepAlive (DataIn);
				}
			}

			static Delegate? cb_PiccCheck_Api_IarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetPiccCheck_Api_IarrayBarrayBHandler ()
			{
				if (cb_PiccCheck_Api_IarrayBarrayB == null)
					cb_PiccCheck_Api_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_PiccCheck_Api_IarrayBarrayB));
				return cb_PiccCheck_Api_IarrayBarrayB;
			}

			static int n_PiccCheck_Api_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int Mode, IntPtr native_CardType, IntPtr native_SerialNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var CardType = (byte[]?) JNIEnv.GetArray (native_CardType, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var SerialNo = (byte[]?) JNIEnv.GetArray (native_SerialNo, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccCheck_Api (Mode, CardType, SerialNo);
				if (CardType != null)
					JNIEnv.CopyArray (CardType, native_CardType);
				if (SerialNo != null)
					JNIEnv.CopyArray (SerialNo, native_SerialNo);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("PiccCheck_Api", "(I[B[B)I", "GetPiccCheck_Api_IarrayBarrayBHandler")]
			public virtual unsafe int PiccCheck_Api (int Mode, byte[]? CardType, byte[]? SerialNo)
			{
				const string __id = "PiccCheck_Api.(I[B[B)I";
				IntPtr native_CardType = JNIEnv.NewArray (CardType);
				IntPtr native_SerialNo = JNIEnv.NewArray (SerialNo);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (Mode);
					__args [1] = new JniArgumentValue (native_CardType);
					__args [2] = new JniArgumentValue (native_SerialNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (CardType != null) {
						JNIEnv.CopyArray (native_CardType, CardType);
						JNIEnv.DeleteLocalRef (native_CardType);
					}
					if (SerialNo != null) {
						JNIEnv.CopyArray (native_SerialNo, SerialNo);
						JNIEnv.DeleteLocalRef (native_SerialNo);
					}
					global::System.GC.KeepAlive (CardType);
					global::System.GC.KeepAlive (SerialNo);
				}
			}

			static Delegate? cb_PiccClose_Api;
#pragma warning disable 0169
			static Delegate GetPiccClose_ApiHandler ()
			{
				if (cb_PiccClose_Api == null)
					cb_PiccClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccClose_Api));
				return cb_PiccClose_Api;
			}

			static int n_PiccClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccClose_Api' and count(parameter)=0]"
			[Register ("PiccClose_Api", "()I", "GetPiccClose_ApiHandler")]
			public virtual unsafe int PiccClose_Api ()
			{
				const string __id = "PiccClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetPiccGetCardInfo_Api_arrayBarrayBarrayBarrayBHandler ()
			{
				if (cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB == null)
					cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_I (n_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB));
				return cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB;
			}

			static int n_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_lenArray, IntPtr native_atqa, IntPtr native_ats, IntPtr native_uid)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var lenArray = (byte[]?) JNIEnv.GetArray (native_lenArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var atqa = (byte[]?) JNIEnv.GetArray (native_atqa, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var ats = (byte[]?) JNIEnv.GetArray (native_ats, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var uid = (byte[]?) JNIEnv.GetArray (native_uid, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccGetCardInfo_Api (lenArray, atqa, ats, uid);
				if (lenArray != null)
					JNIEnv.CopyArray (lenArray, native_lenArray);
				if (atqa != null)
					JNIEnv.CopyArray (atqa, native_atqa);
				if (ats != null)
					JNIEnv.CopyArray (ats, native_ats);
				if (uid != null)
					JNIEnv.CopyArray (uid, native_uid);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccGetCardInfo_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("PiccGetCardInfo_Api", "([B[B[B[B)I", "GetPiccGetCardInfo_Api_arrayBarrayBarrayBarrayBHandler")]
			public virtual unsafe int PiccGetCardInfo_Api (byte[]? lenArray, byte[]? atqa, byte[]? ats, byte[]? uid)
			{
				const string __id = "PiccGetCardInfo_Api.([B[B[B[B)I";
				IntPtr native_lenArray = JNIEnv.NewArray (lenArray);
				IntPtr native_atqa = JNIEnv.NewArray (atqa);
				IntPtr native_ats = JNIEnv.NewArray (ats);
				IntPtr native_uid = JNIEnv.NewArray (uid);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_lenArray);
					__args [1] = new JniArgumentValue (native_atqa);
					__args [2] = new JniArgumentValue (native_ats);
					__args [3] = new JniArgumentValue (native_uid);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (lenArray != null) {
						JNIEnv.CopyArray (native_lenArray, lenArray);
						JNIEnv.DeleteLocalRef (native_lenArray);
					}
					if (atqa != null) {
						JNIEnv.CopyArray (native_atqa, atqa);
						JNIEnv.DeleteLocalRef (native_atqa);
					}
					if (ats != null) {
						JNIEnv.CopyArray (native_ats, ats);
						JNIEnv.DeleteLocalRef (native_ats);
					}
					if (uid != null) {
						JNIEnv.CopyArray (native_uid, uid);
						JNIEnv.DeleteLocalRef (native_uid);
					}
					global::System.GC.KeepAlive (lenArray);
					global::System.GC.KeepAlive (atqa);
					global::System.GC.KeepAlive (ats);
					global::System.GC.KeepAlive (uid);
				}
			}

			static Delegate? cb_PiccHalt_Api;
#pragma warning disable 0169
			static Delegate GetPiccHalt_ApiHandler ()
			{
				if (cb_PiccHalt_Api == null)
					cb_PiccHalt_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccHalt_Api));
				return cb_PiccHalt_Api;
			}

			static int n_PiccHalt_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccHalt_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccHalt_Api' and count(parameter)=0]"
			[Register ("PiccHalt_Api", "()I", "GetPiccHalt_ApiHandler")]
			public virtual unsafe int PiccHalt_Api ()
			{
				const string __id = "PiccHalt_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PiccIsoCommandType_Api_IarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetPiccIsoCommandType_Api_IarrayBIarrayBHandler ()
			{
				if (cb_PiccIsoCommandType_Api_IarrayBIarrayB == null)
					cb_PiccIsoCommandType_Api_IarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILIL_I (n_PiccIsoCommandType_Api_IarrayBIarrayB));
				return cb_PiccIsoCommandType_Api_IarrayBIarrayB;
			}

			static int n_PiccIsoCommandType_Api_IarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_apduSend, int sendLen, IntPtr native_apduResp)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var apduSend = (byte[]?) JNIEnv.GetArray (native_apduSend, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var apduResp = (byte[]?) JNIEnv.GetArray (native_apduResp, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccIsoCommandType_Api (type, apduSend, sendLen, apduResp);
				if (apduSend != null)
					JNIEnv.CopyArray (apduSend, native_apduSend);
				if (apduResp != null)
					JNIEnv.CopyArray (apduResp, native_apduResp);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccIsoCommandType_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("PiccIsoCommandType_Api", "(I[BI[B)I", "GetPiccIsoCommandType_Api_IarrayBIarrayBHandler")]
			public virtual unsafe int PiccIsoCommandType_Api (int type, byte[]? apduSend, int sendLen, byte[]? apduResp)
			{
				const string __id = "PiccIsoCommandType_Api.(I[BI[B)I";
				IntPtr native_apduSend = JNIEnv.NewArray (apduSend);
				IntPtr native_apduResp = JNIEnv.NewArray (apduResp);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (type);
					__args [1] = new JniArgumentValue (native_apduSend);
					__args [2] = new JniArgumentValue (sendLen);
					__args [3] = new JniArgumentValue (native_apduResp);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (apduSend != null) {
						JNIEnv.CopyArray (native_apduSend, apduSend);
						JNIEnv.DeleteLocalRef (native_apduSend);
					}
					if (apduResp != null) {
						JNIEnv.CopyArray (native_apduResp, apduResp);
						JNIEnv.DeleteLocalRef (native_apduResp);
					}
					global::System.GC.KeepAlive (apduSend);
					global::System.GC.KeepAlive (apduResp);
				}
			}

			static Delegate? cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_;
#pragma warning disable 0169
			static Delegate GetPiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_Handler ()
			{
				if (cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ == null)
					cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_));
				return cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_;
			}

			static void n_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apdu)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var apdu = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.Apdu> (native_apdu, JniHandleOwnership.DoNotTransfer);
				__this.PiccIsoCommand_Api (apdu);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccIsoCommand_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.Apdu']]"
			[Register ("PiccIsoCommand_Api", "(Lcom/vanstone/appsdk/api/struct/Apdu;)V", "GetPiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_Handler")]
			public virtual unsafe void PiccIsoCommand_Api (global::Com.Vanstone.Appsdk.Api.Struct.Apdu? apdu)
			{
				const string __id = "PiccIsoCommand_Api.(Lcom/vanstone/appsdk/api/struct/Apdu;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((apdu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apdu).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (apdu);
				}
			}

			static Delegate? cb_PiccOpen_Api;
#pragma warning disable 0169
			static Delegate GetPiccOpen_ApiHandler ()
			{
				if (cb_PiccOpen_Api == null)
					cb_PiccOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccOpen_Api));
				return cb_PiccOpen_Api;
			}

			static int n_PiccOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccOpen_Api' and count(parameter)=0]"
			[Register ("PiccOpen_Api", "()I", "GetPiccOpen_ApiHandler")]
			public virtual unsafe int PiccOpen_Api ()
			{
				const string __id = "PiccOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PiccRemove_Api;
#pragma warning disable 0169
			static Delegate GetPiccRemove_ApiHandler ()
			{
				if (cb_PiccRemove_Api == null)
					cb_PiccRemove_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccRemove_Api));
				return cb_PiccRemove_Api;
			}

			static int n_PiccRemove_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccRemove_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccRemove_Api' and count(parameter)=0]"
			[Register ("PiccRemove_Api", "()I", "GetPiccRemove_ApiHandler")]
			public virtual unsafe int PiccRemove_Api ()
			{
				const string __id = "PiccRemove_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PiccRest_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetPiccRest_Api_IarrayBHandler ()
			{
				if (cb_PiccRest_Api_IarrayB == null)
					cb_PiccRest_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_PiccRest_Api_IarrayB));
				return cb_PiccRest_Api_IarrayB;
			}

			static int n_PiccRest_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int mode, IntPtr native_responseBuffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var responseBuffer = (byte[]?) JNIEnv.GetArray (native_responseBuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccRest_Api (mode, responseBuffer);
				if (responseBuffer != null)
					JNIEnv.CopyArray (responseBuffer, native_responseBuffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='PiccRest_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("PiccRest_Api", "(I[B)I", "GetPiccRest_Api_IarrayBHandler")]
			public virtual unsafe int PiccRest_Api (int mode, byte[]? responseBuffer)
			{
				const string __id = "PiccRest_Api.(I[B)I";
				IntPtr native_responseBuffer = JNIEnv.NewArray (responseBuffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (mode);
					__args [1] = new JniArgumentValue (native_responseBuffer);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (responseBuffer != null) {
						JNIEnv.CopyArray (native_responseBuffer, responseBuffer);
						JNIEnv.DeleteLocalRef (native_responseBuffer);
					}
					global::System.GC.KeepAlive (responseBuffer);
				}
			}

			static Delegate? cb_SidCardCommand_Api_arrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetSidCardCommand_Api_arrayBIarrayBHandler ()
			{
				if (cb_SidCardCommand_Api_arrayBIarrayB == null)
					cb_SidCardCommand_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_SidCardCommand_Api_arrayBIarrayB));
				return cb_SidCardCommand_Api_arrayBIarrayB;
			}

			static int n_SidCardCommand_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_apduSend, int sendLen, IntPtr native_apduRecv)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var apduSend = (byte[]?) JNIEnv.GetArray (native_apduSend, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var apduRecv = (byte[]?) JNIEnv.GetArray (native_apduRecv, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SidCardCommand_Api (apduSend, sendLen, apduRecv);
				if (apduSend != null)
					JNIEnv.CopyArray (apduSend, native_apduSend);
				if (apduRecv != null)
					JNIEnv.CopyArray (apduRecv, native_apduRecv);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='SidCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("SidCardCommand_Api", "([BI[B)I", "GetSidCardCommand_Api_arrayBIarrayBHandler")]
			public virtual unsafe int SidCardCommand_Api (byte[]? apduSend, int sendLen, byte[]? apduRecv)
			{
				const string __id = "SidCardCommand_Api.([BI[B)I";
				IntPtr native_apduSend = JNIEnv.NewArray (apduSend);
				IntPtr native_apduRecv = JNIEnv.NewArray (apduRecv);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_apduSend);
					__args [1] = new JniArgumentValue (sendLen);
					__args [2] = new JniArgumentValue (native_apduRecv);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (apduSend != null) {
						JNIEnv.CopyArray (native_apduSend, apduSend);
						JNIEnv.DeleteLocalRef (native_apduSend);
					}
					if (apduRecv != null) {
						JNIEnv.CopyArray (native_apduRecv, apduRecv);
						JNIEnv.DeleteLocalRef (native_apduRecv);
					}
					global::System.GC.KeepAlive (apduSend);
					global::System.GC.KeepAlive (apduRecv);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBHandler ()
			{
				if (cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB == null)
					cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLLLLLLL_I (n_GetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB));
				return cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB;
			}

			static int n_GetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pBmpFile, IntPtr native_pName, IntPtr native_pSex, IntPtr native_pNation, IntPtr native_pBirth, IntPtr native_pAddress, IntPtr native_pIDNo, IntPtr native_pDepartment, IntPtr native_pEffectDate, IntPtr native_pExpireDate, IntPtr native_pFinger, IntPtr native_pErrMsg)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pBmpFile = (byte[]?) JNIEnv.GetArray (native_pBmpFile, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pName = (byte[]?) JNIEnv.GetArray (native_pName, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pSex = (byte[]?) JNIEnv.GetArray (native_pSex, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pNation = (byte[]?) JNIEnv.GetArray (native_pNation, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pBirth = (byte[]?) JNIEnv.GetArray (native_pBirth, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pAddress = (byte[]?) JNIEnv.GetArray (native_pAddress, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pIDNo = (byte[]?) JNIEnv.GetArray (native_pIDNo, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pDepartment = (byte[]?) JNIEnv.GetArray (native_pDepartment, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pEffectDate = (byte[]?) JNIEnv.GetArray (native_pEffectDate, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pExpireDate = (byte[]?) JNIEnv.GetArray (native_pExpireDate, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pFinger = (byte[]?) JNIEnv.GetArray (native_pFinger, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pErrMsg = (byte[]?) JNIEnv.GetArray (native_pErrMsg, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetIDCardMsg (pBmpFile, pName, pSex, pNation, pBirth, pAddress, pIDNo, pDepartment, pEffectDate, pExpireDate, pFinger, pErrMsg);
				if (pBmpFile != null)
					JNIEnv.CopyArray (pBmpFile, native_pBmpFile);
				if (pName != null)
					JNIEnv.CopyArray (pName, native_pName);
				if (pSex != null)
					JNIEnv.CopyArray (pSex, native_pSex);
				if (pNation != null)
					JNIEnv.CopyArray (pNation, native_pNation);
				if (pBirth != null)
					JNIEnv.CopyArray (pBirth, native_pBirth);
				if (pAddress != null)
					JNIEnv.CopyArray (pAddress, native_pAddress);
				if (pIDNo != null)
					JNIEnv.CopyArray (pIDNo, native_pIDNo);
				if (pDepartment != null)
					JNIEnv.CopyArray (pDepartment, native_pDepartment);
				if (pEffectDate != null)
					JNIEnv.CopyArray (pEffectDate, native_pEffectDate);
				if (pExpireDate != null)
					JNIEnv.CopyArray (pExpireDate, native_pExpireDate);
				if (pFinger != null)
					JNIEnv.CopyArray (pFinger, native_pFinger);
				if (pErrMsg != null)
					JNIEnv.CopyArray (pErrMsg, native_pErrMsg);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Default']/method[@name='getIDCardMsg' and count(parameter)=12 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]'] and parameter[9][@type='byte[]'] and parameter[10][@type='byte[]'] and parameter[11][@type='byte[]'] and parameter[12][@type='byte[]']]"
			[Register ("getIDCardMsg", "([B[B[B[B[B[B[B[B[B[B[B[B)I", "GetGetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBHandler")]
			public virtual unsafe int GetIDCardMsg (byte[]? pBmpFile, byte[]? pName, byte[]? pSex, byte[]? pNation, byte[]? pBirth, byte[]? pAddress, byte[]? pIDNo, byte[]? pDepartment, byte[]? pEffectDate, byte[]? pExpireDate, byte[]? pFinger, byte[]? pErrMsg)
			{
				const string __id = "getIDCardMsg.([B[B[B[B[B[B[B[B[B[B[B[B)I";
				IntPtr native_pBmpFile = JNIEnv.NewArray (pBmpFile);
				IntPtr native_pName = JNIEnv.NewArray (pName);
				IntPtr native_pSex = JNIEnv.NewArray (pSex);
				IntPtr native_pNation = JNIEnv.NewArray (pNation);
				IntPtr native_pBirth = JNIEnv.NewArray (pBirth);
				IntPtr native_pAddress = JNIEnv.NewArray (pAddress);
				IntPtr native_pIDNo = JNIEnv.NewArray (pIDNo);
				IntPtr native_pDepartment = JNIEnv.NewArray (pDepartment);
				IntPtr native_pEffectDate = JNIEnv.NewArray (pEffectDate);
				IntPtr native_pExpireDate = JNIEnv.NewArray (pExpireDate);
				IntPtr native_pFinger = JNIEnv.NewArray (pFinger);
				IntPtr native_pErrMsg = JNIEnv.NewArray (pErrMsg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [12];
					__args [0] = new JniArgumentValue (native_pBmpFile);
					__args [1] = new JniArgumentValue (native_pName);
					__args [2] = new JniArgumentValue (native_pSex);
					__args [3] = new JniArgumentValue (native_pNation);
					__args [4] = new JniArgumentValue (native_pBirth);
					__args [5] = new JniArgumentValue (native_pAddress);
					__args [6] = new JniArgumentValue (native_pIDNo);
					__args [7] = new JniArgumentValue (native_pDepartment);
					__args [8] = new JniArgumentValue (native_pEffectDate);
					__args [9] = new JniArgumentValue (native_pExpireDate);
					__args [10] = new JniArgumentValue (native_pFinger);
					__args [11] = new JniArgumentValue (native_pErrMsg);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pBmpFile != null) {
						JNIEnv.CopyArray (native_pBmpFile, pBmpFile);
						JNIEnv.DeleteLocalRef (native_pBmpFile);
					}
					if (pName != null) {
						JNIEnv.CopyArray (native_pName, pName);
						JNIEnv.DeleteLocalRef (native_pName);
					}
					if (pSex != null) {
						JNIEnv.CopyArray (native_pSex, pSex);
						JNIEnv.DeleteLocalRef (native_pSex);
					}
					if (pNation != null) {
						JNIEnv.CopyArray (native_pNation, pNation);
						JNIEnv.DeleteLocalRef (native_pNation);
					}
					if (pBirth != null) {
						JNIEnv.CopyArray (native_pBirth, pBirth);
						JNIEnv.DeleteLocalRef (native_pBirth);
					}
					if (pAddress != null) {
						JNIEnv.CopyArray (native_pAddress, pAddress);
						JNIEnv.DeleteLocalRef (native_pAddress);
					}
					if (pIDNo != null) {
						JNIEnv.CopyArray (native_pIDNo, pIDNo);
						JNIEnv.DeleteLocalRef (native_pIDNo);
					}
					if (pDepartment != null) {
						JNIEnv.CopyArray (native_pDepartment, pDepartment);
						JNIEnv.DeleteLocalRef (native_pDepartment);
					}
					if (pEffectDate != null) {
						JNIEnv.CopyArray (native_pEffectDate, pEffectDate);
						JNIEnv.DeleteLocalRef (native_pEffectDate);
					}
					if (pExpireDate != null) {
						JNIEnv.CopyArray (native_pExpireDate, pExpireDate);
						JNIEnv.DeleteLocalRef (native_pExpireDate);
					}
					if (pFinger != null) {
						JNIEnv.CopyArray (native_pFinger, pFinger);
						JNIEnv.DeleteLocalRef (native_pFinger);
					}
					if (pErrMsg != null) {
						JNIEnv.CopyArray (native_pErrMsg, pErrMsg);
						JNIEnv.DeleteLocalRef (native_pErrMsg);
					}
					global::System.GC.KeepAlive (pBmpFile);
					global::System.GC.KeepAlive (pName);
					global::System.GC.KeepAlive (pSex);
					global::System.GC.KeepAlive (pNation);
					global::System.GC.KeepAlive (pBirth);
					global::System.GC.KeepAlive (pAddress);
					global::System.GC.KeepAlive (pIDNo);
					global::System.GC.KeepAlive (pDepartment);
					global::System.GC.KeepAlive (pEffectDate);
					global::System.GC.KeepAlive (pExpireDate);
					global::System.GC.KeepAlive (pFinger);
					global::System.GC.KeepAlive (pErrMsg);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/PICCHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/PICCHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/constructor[@name='PICCHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/PICCHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/PICCHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/PICCHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/PICCHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.PICCHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/PICCHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/PICCHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_CommCardCommand_Api_arrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetCommCardCommand_Api_arrayBIarrayBHandler ()
			{
				if (cb_CommCardCommand_Api_arrayBIarrayB == null)
					cb_CommCardCommand_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_CommCardCommand_Api_arrayBIarrayB));
				return cb_CommCardCommand_Api_arrayBIarrayB;
			}

			static int n_CommCardCommand_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CommCardCommand_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='CommCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("CommCardCommand_Api", "([BI[B)I", "GetCommCardCommand_Api_arrayBIarrayBHandler")]
			public abstract int CommCardCommand_Api (byte[]? p0, int p1, byte[]? p2);

			static Delegate? cb_M1Authority_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetM1Authority_Api_IIarrayBHandler ()
			{
				if (cb_M1Authority_Api_IIarrayB == null)
					cb_M1Authority_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_M1Authority_Api_IIarrayB));
				return cb_M1Authority_Api_IIarrayB;
			}

			static int n_M1Authority_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.M1Authority_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1Authority_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("M1Authority_Api", "(II[B)I", "GetM1Authority_Api_IIarrayBHandler")]
			public abstract int M1Authority_Api (int p0, int p1, byte[]? p2);

			static Delegate? cb_M1DecreaseValue_Api_III;
#pragma warning disable 0169
			static Delegate GetM1DecreaseValue_Api_IIIHandler ()
			{
				if (cb_M1DecreaseValue_Api_III == null)
					cb_M1DecreaseValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_M1DecreaseValue_Api_III));
				return cb_M1DecreaseValue_Api_III;
			}

			static int n_M1DecreaseValue_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1DecreaseValue_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1DecreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("M1DecreaseValue_Api", "(III)I", "GetM1DecreaseValue_Api_IIIHandler")]
			public abstract int M1DecreaseValue_Api (int p0, int p1, int p2);

			static Delegate? cb_M1IncreaseValue_Api_III;
#pragma warning disable 0169
			static Delegate GetM1IncreaseValue_Api_IIIHandler ()
			{
				if (cb_M1IncreaseValue_Api_III == null)
					cb_M1IncreaseValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_M1IncreaseValue_Api_III));
				return cb_M1IncreaseValue_Api_III;
			}

			static int n_M1IncreaseValue_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1IncreaseValue_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1IncreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("M1IncreaseValue_Api", "(III)I", "GetM1IncreaseValue_Api_IIIHandler")]
			public abstract int M1IncreaseValue_Api (int p0, int p1, int p2);

			static Delegate? cb_M1ReadBlock_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetM1ReadBlock_Api_IarrayBHandler ()
			{
				if (cb_M1ReadBlock_Api_IarrayB == null)
					cb_M1ReadBlock_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_M1ReadBlock_Api_IarrayB));
				return cb_M1ReadBlock_Api_IarrayB;
			}

			static int n_M1ReadBlock_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.M1ReadBlock_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1ReadBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("M1ReadBlock_Api", "(I[B)I", "GetM1ReadBlock_Api_IarrayBHandler")]
			public abstract int M1ReadBlock_Api (int p0, byte[]? p1);

			static Delegate? cb_M1WriteBlock_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetM1WriteBlock_Api_IarrayBHandler ()
			{
				if (cb_M1WriteBlock_Api_IarrayB == null)
					cb_M1WriteBlock_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_M1WriteBlock_Api_IarrayB));
				return cb_M1WriteBlock_Api_IarrayB;
			}

			static int n_M1WriteBlock_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.M1WriteBlock_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1WriteBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("M1WriteBlock_Api", "(I[B)I", "GetM1WriteBlock_Api_IarrayBHandler")]
			public abstract int M1WriteBlock_Api (int p0, byte[]? p1);

			static Delegate? cb_NFCListenStart_Api;
#pragma warning disable 0169
			static Delegate GetNFCListenStart_ApiHandler ()
			{
				if (cb_NFCListenStart_Api == null)
					cb_NFCListenStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_NFCListenStart_Api));
				return cb_NFCListenStart_Api;
			}

			static int n_NFCListenStart_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NFCListenStart_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCListenStart_Api' and count(parameter)=0]"
			[Register ("NFCListenStart_Api", "()I", "GetNFCListenStart_ApiHandler")]
			public abstract int NFCListenStart_Api ();

			static Delegate? cb_NFCListenStop_Api;
#pragma warning disable 0169
			static Delegate GetNFCListenStop_ApiHandler ()
			{
				if (cb_NFCListenStop_Api == null)
					cb_NFCListenStop_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_NFCListenStop_Api));
				return cb_NFCListenStop_Api;
			}

			static int n_NFCListenStop_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NFCListenStop_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCListenStop_Api' and count(parameter)=0]"
			[Register ("NFCListenStop_Api", "()I", "GetNFCListenStop_ApiHandler")]
			public abstract int NFCListenStop_Api ();

			static Delegate? cb_NFCPowerControl_Api_Z;
#pragma warning disable 0169
			static Delegate GetNFCPowerControl_Api_ZHandler ()
			{
				if (cb_NFCPowerControl_Api_Z == null)
					cb_NFCPowerControl_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_I (n_NFCPowerControl_Api_Z));
				return cb_NFCPowerControl_Api_Z;
			}

			static int n_NFCPowerControl_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NFCPowerControl_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCPowerControl_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("NFCPowerControl_Api", "(Z)I", "GetNFCPowerControl_Api_ZHandler")]
			public abstract int NFCPowerControl_Api (bool p0);

			static Delegate? cb_NFCReadUriInfo_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetNFCReadUriInfo_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_NFCReadUriInfo_Api_arrayBarrayBarrayB == null)
					cb_NFCReadUriInfo_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_NFCReadUriInfo_Api_arrayBarrayBarrayB));
				return cb_NFCReadUriInfo_Api_arrayBarrayBarrayB;
			}

			static int n_NFCReadUriInfo_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NFCReadUriInfo_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCReadUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("NFCReadUriInfo_Api", "([B[B[B)I", "GetNFCReadUriInfo_Api_arrayBarrayBarrayBHandler")]
			public abstract int NFCReadUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetNFCWriteUriInfo_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB == null)
					cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_NFCWriteUriInfo_Api_arrayBarrayBarrayB));
				return cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB;
			}

			static int n_NFCWriteUriInfo_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NFCWriteUriInfo_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCWriteUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("NFCWriteUriInfo_Api", "([B[B[B)I", "GetNFCWriteUriInfo_Api_arrayBarrayBarrayBHandler")]
			public abstract int NFCWriteUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_NTAGAuthority_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGAuthority_Api_arrayBarrayBHandler ()
			{
				if (cb_NTAGAuthority_Api_arrayBarrayB == null)
					cb_NTAGAuthority_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_NTAGAuthority_Api_arrayBarrayB));
				return cb_NTAGAuthority_Api_arrayBarrayB;
			}

			static int n_NTAGAuthority_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGAuthority_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGAuthority_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGAuthority_Api", "([B[B)I", "GetNTAGAuthority_Api_arrayBarrayBHandler")]
			public abstract int NTAGAuthority_Api (byte[]? p0, byte[]? p1);

			static Delegate? cb_NTAGFastReadData_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGFastReadData_Api_IIarrayBHandler ()
			{
				if (cb_NTAGFastReadData_Api_IIarrayB == null)
					cb_NTAGFastReadData_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_NTAGFastReadData_Api_IIarrayB));
				return cb_NTAGFastReadData_Api_IIarrayB;
			}

			static int n_NTAGFastReadData_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGFastReadData_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGFastReadData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("NTAGFastReadData_Api", "(II[B)I", "GetNTAGFastReadData_Api_IIarrayBHandler")]
			public abstract int NTAGFastReadData_Api (int p0, int p1, byte[]? p2);

			static Delegate? cb_NTAGGetCardInfo_Api;
#pragma warning disable 0169
			static Delegate GetNTAGGetCardInfo_ApiHandler ()
			{
				if (cb_NTAGGetCardInfo_Api == null)
					cb_NTAGGetCardInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NTAGGetCardInfo_Api));
				return cb_NTAGGetCardInfo_Api;
			}

			static IntPtr n_NTAGGetCardInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.NTAGGetCardInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGGetCardInfo_Api' and count(parameter)=0]"
			[Register ("NTAGGetCardInfo_Api", "()Landroid/os/Bundle;", "GetNTAGGetCardInfo_ApiHandler")]
			public abstract global::Android.OS.Bundle? NTAGGetCardInfo_Api ();

			static Delegate? cb_NTAGReadCount_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetNTAGReadCount_Api_arrayBHandler ()
			{
				if (cb_NTAGReadCount_Api_arrayB == null)
					cb_NTAGReadCount_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_NTAGReadCount_Api_arrayB));
				return cb_NTAGReadCount_Api_arrayB;
			}

			static int n_NTAGReadCount_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGReadCount_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadCount_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("NTAGReadCount_Api", "([B)I", "GetNTAGReadCount_Api_arrayBHandler")]
			public abstract int NTAGReadCount_Api (byte[]? p0);

			static Delegate? cb_NTAGReadData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGReadData_Api_IarrayBHandler ()
			{
				if (cb_NTAGReadData_Api_IarrayB == null)
					cb_NTAGReadData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_NTAGReadData_Api_IarrayB));
				return cb_NTAGReadData_Api_IarrayB;
			}

			static int n_NTAGReadData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGReadData_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGReadData_Api", "(I[B)I", "GetNTAGReadData_Api_IarrayBHandler")]
			public abstract int NTAGReadData_Api (int p0, byte[]? p1);

			static Delegate? cb_NTAGReadSign_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetNTAGReadSign_Api_arrayBHandler ()
			{
				if (cb_NTAGReadSign_Api_arrayB == null)
					cb_NTAGReadSign_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_NTAGReadSign_Api_arrayB));
				return cb_NTAGReadSign_Api_arrayB;
			}

			static int n_NTAGReadSign_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGReadSign_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadSign_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("NTAGReadSign_Api", "([B)I", "GetNTAGReadSign_Api_arrayBHandler")]
			public abstract int NTAGReadSign_Api (byte[]? p0);

			static Delegate? cb_NTAGWriteData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetNTAGWriteData_Api_IarrayBHandler ()
			{
				if (cb_NTAGWriteData_Api_IarrayB == null)
					cb_NTAGWriteData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_NTAGWriteData_Api_IarrayB));
				return cb_NTAGWriteData_Api_IarrayB;
			}

			static int n_NTAGWriteData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.NTAGWriteData_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGWriteData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGWriteData_Api", "(I[B)I", "GetNTAGWriteData_Api_IarrayBHandler")]
			public abstract int NTAGWriteData_Api (int p0, byte[]? p1);

			static Delegate? cb_PiccCheck_Api_IarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetPiccCheck_Api_IarrayBarrayBHandler ()
			{
				if (cb_PiccCheck_Api_IarrayBarrayB == null)
					cb_PiccCheck_Api_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_PiccCheck_Api_IarrayBarrayB));
				return cb_PiccCheck_Api_IarrayBarrayB;
			}

			static int n_PiccCheck_Api_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccCheck_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("PiccCheck_Api", "(I[B[B)I", "GetPiccCheck_Api_IarrayBarrayBHandler")]
			public abstract int PiccCheck_Api (int p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_PiccClose_Api;
#pragma warning disable 0169
			static Delegate GetPiccClose_ApiHandler ()
			{
				if (cb_PiccClose_Api == null)
					cb_PiccClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccClose_Api));
				return cb_PiccClose_Api;
			}

			static int n_PiccClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccClose_Api' and count(parameter)=0]"
			[Register ("PiccClose_Api", "()I", "GetPiccClose_ApiHandler")]
			public abstract int PiccClose_Api ();

			static Delegate? cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetPiccGetCardInfo_Api_arrayBarrayBarrayBarrayBHandler ()
			{
				if (cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB == null)
					cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_I (n_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB));
				return cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB;
			}

			static int n_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccGetCardInfo_Api (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccGetCardInfo_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("PiccGetCardInfo_Api", "([B[B[B[B)I", "GetPiccGetCardInfo_Api_arrayBarrayBarrayBarrayBHandler")]
			public abstract int PiccGetCardInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3);

			static Delegate? cb_PiccHalt_Api;
#pragma warning disable 0169
			static Delegate GetPiccHalt_ApiHandler ()
			{
				if (cb_PiccHalt_Api == null)
					cb_PiccHalt_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccHalt_Api));
				return cb_PiccHalt_Api;
			}

			static int n_PiccHalt_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccHalt_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccHalt_Api' and count(parameter)=0]"
			[Register ("PiccHalt_Api", "()I", "GetPiccHalt_ApiHandler")]
			public abstract int PiccHalt_Api ();

			static Delegate? cb_PiccIsoCommandType_Api_IarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetPiccIsoCommandType_Api_IarrayBIarrayBHandler ()
			{
				if (cb_PiccIsoCommandType_Api_IarrayBIarrayB == null)
					cb_PiccIsoCommandType_Api_IarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILIL_I (n_PiccIsoCommandType_Api_IarrayBIarrayB));
				return cb_PiccIsoCommandType_Api_IarrayBIarrayB;
			}

			static int n_PiccIsoCommandType_Api_IarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccIsoCommandType_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccIsoCommandType_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("PiccIsoCommandType_Api", "(I[BI[B)I", "GetPiccIsoCommandType_Api_IarrayBIarrayBHandler")]
			public abstract int PiccIsoCommandType_Api (int p0, byte[]? p1, int p2, byte[]? p3);

			static Delegate? cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_;
#pragma warning disable 0169
			static Delegate GetPiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_Handler ()
			{
				if (cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ == null)
					cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_));
				return cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_;
			}

			static void n_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.Apdu> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PiccIsoCommand_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccIsoCommand_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.Apdu']]"
			[Register ("PiccIsoCommand_Api", "(Lcom/vanstone/appsdk/api/struct/Apdu;)V", "GetPiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_Handler")]
			public abstract void PiccIsoCommand_Api (global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p0);

			static Delegate? cb_PiccOpen_Api;
#pragma warning disable 0169
			static Delegate GetPiccOpen_ApiHandler ()
			{
				if (cb_PiccOpen_Api == null)
					cb_PiccOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccOpen_Api));
				return cb_PiccOpen_Api;
			}

			static int n_PiccOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccOpen_Api' and count(parameter)=0]"
			[Register ("PiccOpen_Api", "()I", "GetPiccOpen_ApiHandler")]
			public abstract int PiccOpen_Api ();

			static Delegate? cb_PiccRemove_Api;
#pragma warning disable 0169
			static Delegate GetPiccRemove_ApiHandler ()
			{
				if (cb_PiccRemove_Api == null)
					cb_PiccRemove_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccRemove_Api));
				return cb_PiccRemove_Api;
			}

			static int n_PiccRemove_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PiccRemove_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccRemove_Api' and count(parameter)=0]"
			[Register ("PiccRemove_Api", "()I", "GetPiccRemove_ApiHandler")]
			public abstract int PiccRemove_Api ();

			static Delegate? cb_PiccRest_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetPiccRest_Api_IarrayBHandler ()
			{
				if (cb_PiccRest_Api_IarrayB == null)
					cb_PiccRest_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_PiccRest_Api_IarrayB));
				return cb_PiccRest_Api_IarrayB;
			}

			static int n_PiccRest_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PiccRest_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccRest_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("PiccRest_Api", "(I[B)I", "GetPiccRest_Api_IarrayBHandler")]
			public abstract int PiccRest_Api (int p0, byte[]? p1);

			static Delegate? cb_SidCardCommand_Api_arrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetSidCardCommand_Api_arrayBIarrayBHandler ()
			{
				if (cb_SidCardCommand_Api_arrayBIarrayB == null)
					cb_SidCardCommand_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_SidCardCommand_Api_arrayBIarrayB));
				return cb_SidCardCommand_Api_arrayBIarrayB;
			}

			static int n_SidCardCommand_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SidCardCommand_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='SidCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("SidCardCommand_Api", "([BI[B)I", "GetSidCardCommand_Api_arrayBIarrayBHandler")]
			public abstract int SidCardCommand_Api (byte[]? p0, int p1, byte[]? p2);

			static Delegate? cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBHandler ()
			{
				if (cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB == null)
					cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLLLLLLL_I (n_GetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB));
				return cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB;
			}

			static int n_GetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, IntPtr native_p11)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p8 = (byte[]?) JNIEnv.GetArray (native_p8, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p9 = (byte[]?) JNIEnv.GetArray (native_p9, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p10 = (byte[]?) JNIEnv.GetArray (native_p10, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p11 = (byte[]?) JNIEnv.GetArray (native_p11, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetIDCardMsg (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				if (p7 != null)
					JNIEnv.CopyArray (p7, native_p7);
				if (p8 != null)
					JNIEnv.CopyArray (p8, native_p8);
				if (p9 != null)
					JNIEnv.CopyArray (p9, native_p9);
				if (p10 != null)
					JNIEnv.CopyArray (p10, native_p10);
				if (p11 != null)
					JNIEnv.CopyArray (p11, native_p11);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='getIDCardMsg' and count(parameter)=12 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]'] and parameter[9][@type='byte[]'] and parameter[10][@type='byte[]'] and parameter[11][@type='byte[]'] and parameter[12][@type='byte[]']]"
			[Register ("getIDCardMsg", "([B[B[B[B[B[B[B[B[B[B[B[B)I", "GetGetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBHandler")]
			public abstract int GetIDCardMsg (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, byte[]? p7, byte[]? p8, byte[]? p9, byte[]? p10, byte[]? p11);

			static Delegate? cb_getIDCardImage;
#pragma warning disable 0169
			static Delegate GetGetIDCardImageHandler ()
			{
				if (cb_getIDCardImage == null)
					cb_getIDCardImage = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIDCardImage));
				return cb_getIDCardImage;
			}

			static IntPtr n_GetIDCardImage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IDCardImage);
			}
#pragma warning restore 0169

			public abstract global::Android.Graphics.Bitmap? IDCardImage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/method[@name='getIDCardImage' and count(parameter)=0]"
				[Register ("getIDCardImage", "()Landroid/graphics/Bitmap;", "GetGetIDCardImageHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/PICCHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/PICCHandler$Stub", typeof (StubInvoker));

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

			public override unsafe global::Android.Graphics.Bitmap? IDCardImage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='PICCHandler.Stub']/method[@name='getIDCardImage' and count(parameter)=0]"
				[Register ("getIDCardImage", "()Landroid/graphics/Bitmap;", "GetGetIDCardImageHandler")]
				get {
					const string __id = "getIDCardImage.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='CommCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("CommCardCommand_Api", "([BI[B)I", "GetCommCardCommand_Api_arrayBIarrayBHandler")]
			public override unsafe int CommCardCommand_Api (byte[]? p0, int p1, byte[]? p2)
			{
				const string __id = "CommCardCommand_Api.([BI[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1Authority_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("M1Authority_Api", "(II[B)I", "GetM1Authority_Api_IIarrayBHandler")]
			public override unsafe int M1Authority_Api (int p0, int p1, byte[]? p2)
			{
				const string __id = "M1Authority_Api.(II[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1DecreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("M1DecreaseValue_Api", "(III)I", "GetM1DecreaseValue_Api_IIIHandler")]
			public override unsafe int M1DecreaseValue_Api (int p0, int p1, int p2)
			{
				const string __id = "M1DecreaseValue_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1IncreaseValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("M1IncreaseValue_Api", "(III)I", "GetM1IncreaseValue_Api_IIIHandler")]
			public override unsafe int M1IncreaseValue_Api (int p0, int p1, int p2)
			{
				const string __id = "M1IncreaseValue_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1ReadBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("M1ReadBlock_Api", "(I[B)I", "GetM1ReadBlock_Api_IarrayBHandler")]
			public override unsafe int M1ReadBlock_Api (int p0, byte[]? p1)
			{
				const string __id = "M1ReadBlock_Api.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='M1WriteBlock_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("M1WriteBlock_Api", "(I[B)I", "GetM1WriteBlock_Api_IarrayBHandler")]
			public override unsafe int M1WriteBlock_Api (int p0, byte[]? p1)
			{
				const string __id = "M1WriteBlock_Api.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCListenStart_Api' and count(parameter)=0]"
			[Register ("NFCListenStart_Api", "()I", "GetNFCListenStart_ApiHandler")]
			public override unsafe int NFCListenStart_Api ()
			{
				const string __id = "NFCListenStart_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCListenStop_Api' and count(parameter)=0]"
			[Register ("NFCListenStop_Api", "()I", "GetNFCListenStop_ApiHandler")]
			public override unsafe int NFCListenStop_Api ()
			{
				const string __id = "NFCListenStop_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCPowerControl_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("NFCPowerControl_Api", "(Z)I", "GetNFCPowerControl_Api_ZHandler")]
			public override unsafe int NFCPowerControl_Api (bool p0)
			{
				const string __id = "NFCPowerControl_Api.(Z)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCReadUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("NFCReadUriInfo_Api", "([B[B[B)I", "GetNFCReadUriInfo_Api_arrayBarrayBarrayBHandler")]
			public override unsafe int NFCReadUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "NFCReadUriInfo_Api.([B[B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NFCWriteUriInfo_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("NFCWriteUriInfo_Api", "([B[B[B)I", "GetNFCWriteUriInfo_Api_arrayBarrayBarrayBHandler")]
			public override unsafe int NFCWriteUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "NFCWriteUriInfo_Api.([B[B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGAuthority_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGAuthority_Api", "([B[B)I", "GetNTAGAuthority_Api_arrayBarrayBHandler")]
			public override unsafe int NTAGAuthority_Api (byte[]? p0, byte[]? p1)
			{
				const string __id = "NTAGAuthority_Api.([B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGFastReadData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("NTAGFastReadData_Api", "(II[B)I", "GetNTAGFastReadData_Api_IIarrayBHandler")]
			public override unsafe int NTAGFastReadData_Api (int p0, int p1, byte[]? p2)
			{
				const string __id = "NTAGFastReadData_Api.(II[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGGetCardInfo_Api' and count(parameter)=0]"
			[Register ("NTAGGetCardInfo_Api", "()Landroid/os/Bundle;", "GetNTAGGetCardInfo_ApiHandler")]
			public override unsafe global::Android.OS.Bundle? NTAGGetCardInfo_Api ()
			{
				const string __id = "NTAGGetCardInfo_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadCount_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("NTAGReadCount_Api", "([B)I", "GetNTAGReadCount_Api_arrayBHandler")]
			public override unsafe int NTAGReadCount_Api (byte[]? p0)
			{
				const string __id = "NTAGReadCount_Api.([B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGReadData_Api", "(I[B)I", "GetNTAGReadData_Api_IarrayBHandler")]
			public override unsafe int NTAGReadData_Api (int p0, byte[]? p1)
			{
				const string __id = "NTAGReadData_Api.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGReadSign_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("NTAGReadSign_Api", "([B)I", "GetNTAGReadSign_Api_arrayBHandler")]
			public override unsafe int NTAGReadSign_Api (byte[]? p0)
			{
				const string __id = "NTAGReadSign_Api.([B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='NTAGWriteData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("NTAGWriteData_Api", "(I[B)I", "GetNTAGWriteData_Api_IarrayBHandler")]
			public override unsafe int NTAGWriteData_Api (int p0, byte[]? p1)
			{
				const string __id = "NTAGWriteData_Api.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("PiccCheck_Api", "(I[B[B)I", "GetPiccCheck_Api_IarrayBarrayBHandler")]
			public override unsafe int PiccCheck_Api (int p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "PiccCheck_Api.(I[B[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccClose_Api' and count(parameter)=0]"
			[Register ("PiccClose_Api", "()I", "GetPiccClose_ApiHandler")]
			public override unsafe int PiccClose_Api ()
			{
				const string __id = "PiccClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccGetCardInfo_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("PiccGetCardInfo_Api", "([B[B[B[B)I", "GetPiccGetCardInfo_Api_arrayBarrayBarrayBarrayBHandler")]
			public override unsafe int PiccGetCardInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3)
			{
				const string __id = "PiccGetCardInfo_Api.([B[B[B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccHalt_Api' and count(parameter)=0]"
			[Register ("PiccHalt_Api", "()I", "GetPiccHalt_ApiHandler")]
			public override unsafe int PiccHalt_Api ()
			{
				const string __id = "PiccHalt_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccIsoCommandType_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("PiccIsoCommandType_Api", "(I[BI[B)I", "GetPiccIsoCommandType_Api_IarrayBIarrayBHandler")]
			public override unsafe int PiccIsoCommandType_Api (int p0, byte[]? p1, int p2, byte[]? p3)
			{
				const string __id = "PiccIsoCommandType_Api.(I[BI[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccIsoCommand_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.Apdu']]"
			[Register ("PiccIsoCommand_Api", "(Lcom/vanstone/appsdk/api/struct/Apdu;)V", "GetPiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_Handler")]
			public override unsafe void PiccIsoCommand_Api (global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p0)
			{
				const string __id = "PiccIsoCommand_Api.(Lcom/vanstone/appsdk/api/struct/Apdu;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccOpen_Api' and count(parameter)=0]"
			[Register ("PiccOpen_Api", "()I", "GetPiccOpen_ApiHandler")]
			public override unsafe int PiccOpen_Api ()
			{
				const string __id = "PiccOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccRemove_Api' and count(parameter)=0]"
			[Register ("PiccRemove_Api", "()I", "GetPiccRemove_ApiHandler")]
			public override unsafe int PiccRemove_Api ()
			{
				const string __id = "PiccRemove_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='PiccRest_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("PiccRest_Api", "(I[B)I", "GetPiccRest_Api_IarrayBHandler")]
			public override unsafe int PiccRest_Api (int p0, byte[]? p1)
			{
				const string __id = "PiccRest_Api.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='SidCardCommand_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("SidCardCommand_Api", "([BI[B)I", "GetSidCardCommand_Api_arrayBIarrayBHandler")]
			public override unsafe int SidCardCommand_Api (byte[]? p0, int p1, byte[]? p2)
			{
				const string __id = "SidCardCommand_Api.([BI[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='PICCHandler']/method[@name='getIDCardMsg' and count(parameter)=12 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]'] and parameter[9][@type='byte[]'] and parameter[10][@type='byte[]'] and parameter[11][@type='byte[]'] and parameter[12][@type='byte[]']]"
			[Register ("getIDCardMsg", "([B[B[B[B[B[B[B[B[B[B[B[B)I", "GetGetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBHandler")]
			public override unsafe int GetIDCardMsg (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, byte[]? p7, byte[]? p8, byte[]? p9, byte[]? p10, byte[]? p11)
			{
				const string __id = "getIDCardMsg.([B[B[B[B[B[B[B[B[B[B[B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				IntPtr native_p7 = JNIEnv.NewArray (p7);
				IntPtr native_p8 = JNIEnv.NewArray (p8);
				IntPtr native_p9 = JNIEnv.NewArray (p9);
				IntPtr native_p10 = JNIEnv.NewArray (p10);
				IntPtr native_p11 = JNIEnv.NewArray (p11);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [12];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (native_p6);
					__args [7] = new JniArgumentValue (native_p7);
					__args [8] = new JniArgumentValue (native_p8);
					__args [9] = new JniArgumentValue (native_p9);
					__args [10] = new JniArgumentValue (native_p10);
					__args [11] = new JniArgumentValue (native_p11);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					if (p7 != null) {
						JNIEnv.CopyArray (native_p7, p7);
						JNIEnv.DeleteLocalRef (native_p7);
					}
					if (p8 != null) {
						JNIEnv.CopyArray (native_p8, p8);
						JNIEnv.DeleteLocalRef (native_p8);
					}
					if (p9 != null) {
						JNIEnv.CopyArray (native_p9, p9);
						JNIEnv.DeleteLocalRef (native_p9);
					}
					if (p10 != null) {
						JNIEnv.CopyArray (native_p10, p10);
						JNIEnv.DeleteLocalRef (native_p10);
					}
					if (p11 != null) {
						JNIEnv.CopyArray (native_p11, p11);
						JNIEnv.DeleteLocalRef (native_p11);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
					global::System.GC.KeepAlive (p6);
					global::System.GC.KeepAlive (p7);
					global::System.GC.KeepAlive (p8);
					global::System.GC.KeepAlive (p9);
					global::System.GC.KeepAlive (p10);
					global::System.GC.KeepAlive (p11);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/PICCHandler", DoNotGenerateAcw=true)]
	internal partial class IPICCHandlerInvoker : global::Java.Lang.Object, IPICCHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/PICCHandler", typeof (IPICCHandlerInvoker));

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

		public static IPICCHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPICCHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.PICCHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPICCHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getIDCardImage;
#pragma warning disable 0169
		static Delegate GetGetIDCardImageHandler ()
		{
			if (cb_getIDCardImage == null)
				cb_getIDCardImage = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIDCardImage));
			return cb_getIDCardImage;
		}

		static IntPtr n_GetIDCardImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IDCardImage);
		}
#pragma warning restore 0169

		IntPtr id_getIDCardImage;
		public unsafe global::Android.Graphics.Bitmap? IDCardImage {
			get {
				if (id_getIDCardImage == IntPtr.Zero)
					id_getIDCardImage = JNIEnv.GetMethodID (class_ref, "getIDCardImage", "()Landroid/graphics/Bitmap;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIDCardImage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_CommCardCommand_Api_arrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetCommCardCommand_Api_arrayBIarrayBHandler ()
		{
			if (cb_CommCardCommand_Api_arrayBIarrayB == null)
				cb_CommCardCommand_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_CommCardCommand_Api_arrayBIarrayB));
			return cb_CommCardCommand_Api_arrayBIarrayB;
		}

		static int n_CommCardCommand_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CommCardCommand_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_CommCardCommand_Api_arrayBIarrayB;
		public unsafe int CommCardCommand_Api (byte[]? p0, int p1, byte[]? p2)
		{
			if (id_CommCardCommand_Api_arrayBIarrayB == IntPtr.Zero)
				id_CommCardCommand_Api_arrayBIarrayB = JNIEnv.GetMethodID (class_ref, "CommCardCommand_Api", "([BI[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_CommCardCommand_Api_arrayBIarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_M1Authority_Api_IIarrayB;
#pragma warning disable 0169
		static Delegate GetM1Authority_Api_IIarrayBHandler ()
		{
			if (cb_M1Authority_Api_IIarrayB == null)
				cb_M1Authority_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_M1Authority_Api_IIarrayB));
			return cb_M1Authority_Api_IIarrayB;
		}

		static int n_M1Authority_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.M1Authority_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_M1Authority_Api_IIarrayB;
		public unsafe int M1Authority_Api (int p0, int p1, byte[]? p2)
		{
			if (id_M1Authority_Api_IIarrayB == IntPtr.Zero)
				id_M1Authority_Api_IIarrayB = JNIEnv.GetMethodID (class_ref, "M1Authority_Api", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1Authority_Api_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_M1DecreaseValue_Api_III;
#pragma warning disable 0169
		static Delegate GetM1DecreaseValue_Api_IIIHandler ()
		{
			if (cb_M1DecreaseValue_Api_III == null)
				cb_M1DecreaseValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_M1DecreaseValue_Api_III));
			return cb_M1DecreaseValue_Api_III;
		}

		static int n_M1DecreaseValue_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.M1DecreaseValue_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_M1DecreaseValue_Api_III;
		public unsafe int M1DecreaseValue_Api (int p0, int p1, int p2)
		{
			if (id_M1DecreaseValue_Api_III == IntPtr.Zero)
				id_M1DecreaseValue_Api_III = JNIEnv.GetMethodID (class_ref, "M1DecreaseValue_Api", "(III)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1DecreaseValue_Api_III, __args);
		}

		static Delegate? cb_M1IncreaseValue_Api_III;
#pragma warning disable 0169
		static Delegate GetM1IncreaseValue_Api_IIIHandler ()
		{
			if (cb_M1IncreaseValue_Api_III == null)
				cb_M1IncreaseValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_M1IncreaseValue_Api_III));
			return cb_M1IncreaseValue_Api_III;
		}

		static int n_M1IncreaseValue_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.M1IncreaseValue_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_M1IncreaseValue_Api_III;
		public unsafe int M1IncreaseValue_Api (int p0, int p1, int p2)
		{
			if (id_M1IncreaseValue_Api_III == IntPtr.Zero)
				id_M1IncreaseValue_Api_III = JNIEnv.GetMethodID (class_ref, "M1IncreaseValue_Api", "(III)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1IncreaseValue_Api_III, __args);
		}

		static Delegate? cb_M1ReadBlock_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetM1ReadBlock_Api_IarrayBHandler ()
		{
			if (cb_M1ReadBlock_Api_IarrayB == null)
				cb_M1ReadBlock_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_M1ReadBlock_Api_IarrayB));
			return cb_M1ReadBlock_Api_IarrayB;
		}

		static int n_M1ReadBlock_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.M1ReadBlock_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_M1ReadBlock_Api_IarrayB;
		public unsafe int M1ReadBlock_Api (int p0, byte[]? p1)
		{
			if (id_M1ReadBlock_Api_IarrayB == IntPtr.Zero)
				id_M1ReadBlock_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "M1ReadBlock_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1ReadBlock_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_M1WriteBlock_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetM1WriteBlock_Api_IarrayBHandler ()
		{
			if (cb_M1WriteBlock_Api_IarrayB == null)
				cb_M1WriteBlock_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_M1WriteBlock_Api_IarrayB));
			return cb_M1WriteBlock_Api_IarrayB;
		}

		static int n_M1WriteBlock_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.M1WriteBlock_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_M1WriteBlock_Api_IarrayB;
		public unsafe int M1WriteBlock_Api (int p0, byte[]? p1)
		{
			if (id_M1WriteBlock_Api_IarrayB == IntPtr.Zero)
				id_M1WriteBlock_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "M1WriteBlock_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1WriteBlock_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_NFCListenStart_Api;
#pragma warning disable 0169
		static Delegate GetNFCListenStart_ApiHandler ()
		{
			if (cb_NFCListenStart_Api == null)
				cb_NFCListenStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_NFCListenStart_Api));
			return cb_NFCListenStart_Api;
		}

		static int n_NFCListenStart_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NFCListenStart_Api ();
		}
#pragma warning restore 0169

		IntPtr id_NFCListenStart_Api;
		public unsafe int NFCListenStart_Api ()
		{
			if (id_NFCListenStart_Api == IntPtr.Zero)
				id_NFCListenStart_Api = JNIEnv.GetMethodID (class_ref, "NFCListenStart_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NFCListenStart_Api);
		}

		static Delegate? cb_NFCListenStop_Api;
#pragma warning disable 0169
		static Delegate GetNFCListenStop_ApiHandler ()
		{
			if (cb_NFCListenStop_Api == null)
				cb_NFCListenStop_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_NFCListenStop_Api));
			return cb_NFCListenStop_Api;
		}

		static int n_NFCListenStop_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NFCListenStop_Api ();
		}
#pragma warning restore 0169

		IntPtr id_NFCListenStop_Api;
		public unsafe int NFCListenStop_Api ()
		{
			if (id_NFCListenStop_Api == IntPtr.Zero)
				id_NFCListenStop_Api = JNIEnv.GetMethodID (class_ref, "NFCListenStop_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NFCListenStop_Api);
		}

		static Delegate? cb_NFCPowerControl_Api_Z;
#pragma warning disable 0169
		static Delegate GetNFCPowerControl_Api_ZHandler ()
		{
			if (cb_NFCPowerControl_Api_Z == null)
				cb_NFCPowerControl_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_I (n_NFCPowerControl_Api_Z));
			return cb_NFCPowerControl_Api_Z;
		}

		static int n_NFCPowerControl_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NFCPowerControl_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NFCPowerControl_Api_Z;
		public unsafe int NFCPowerControl_Api (bool p0)
		{
			if (id_NFCPowerControl_Api_Z == IntPtr.Zero)
				id_NFCPowerControl_Api_Z = JNIEnv.GetMethodID (class_ref, "NFCPowerControl_Api", "(Z)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NFCPowerControl_Api_Z, __args);
		}

		static Delegate? cb_NFCReadUriInfo_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetNFCReadUriInfo_Api_arrayBarrayBarrayBHandler ()
		{
			if (cb_NFCReadUriInfo_Api_arrayBarrayBarrayB == null)
				cb_NFCReadUriInfo_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_NFCReadUriInfo_Api_arrayBarrayBarrayB));
			return cb_NFCReadUriInfo_Api_arrayBarrayBarrayB;
		}

		static int n_NFCReadUriInfo_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NFCReadUriInfo_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NFCReadUriInfo_Api_arrayBarrayBarrayB;
		public unsafe int NFCReadUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2)
		{
			if (id_NFCReadUriInfo_Api_arrayBarrayBarrayB == IntPtr.Zero)
				id_NFCReadUriInfo_Api_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "NFCReadUriInfo_Api", "([B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NFCReadUriInfo_Api_arrayBarrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetNFCWriteUriInfo_Api_arrayBarrayBarrayBHandler ()
		{
			if (cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB == null)
				cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_NFCWriteUriInfo_Api_arrayBarrayBarrayB));
			return cb_NFCWriteUriInfo_Api_arrayBarrayBarrayB;
		}

		static int n_NFCWriteUriInfo_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NFCWriteUriInfo_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NFCWriteUriInfo_Api_arrayBarrayBarrayB;
		public unsafe int NFCWriteUriInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2)
		{
			if (id_NFCWriteUriInfo_Api_arrayBarrayBarrayB == IntPtr.Zero)
				id_NFCWriteUriInfo_Api_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "NFCWriteUriInfo_Api", "([B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NFCWriteUriInfo_Api_arrayBarrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_NTAGAuthority_Api_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetNTAGAuthority_Api_arrayBarrayBHandler ()
		{
			if (cb_NTAGAuthority_Api_arrayBarrayB == null)
				cb_NTAGAuthority_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_NTAGAuthority_Api_arrayBarrayB));
			return cb_NTAGAuthority_Api_arrayBarrayB;
		}

		static int n_NTAGAuthority_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NTAGAuthority_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NTAGAuthority_Api_arrayBarrayB;
		public unsafe int NTAGAuthority_Api (byte[]? p0, byte[]? p1)
		{
			if (id_NTAGAuthority_Api_arrayBarrayB == IntPtr.Zero)
				id_NTAGAuthority_Api_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "NTAGAuthority_Api", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NTAGAuthority_Api_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_NTAGFastReadData_Api_IIarrayB;
#pragma warning disable 0169
		static Delegate GetNTAGFastReadData_Api_IIarrayBHandler ()
		{
			if (cb_NTAGFastReadData_Api_IIarrayB == null)
				cb_NTAGFastReadData_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_NTAGFastReadData_Api_IIarrayB));
			return cb_NTAGFastReadData_Api_IIarrayB;
		}

		static int n_NTAGFastReadData_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NTAGFastReadData_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NTAGFastReadData_Api_IIarrayB;
		public unsafe int NTAGFastReadData_Api (int p0, int p1, byte[]? p2)
		{
			if (id_NTAGFastReadData_Api_IIarrayB == IntPtr.Zero)
				id_NTAGFastReadData_Api_IIarrayB = JNIEnv.GetMethodID (class_ref, "NTAGFastReadData_Api", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NTAGFastReadData_Api_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_NTAGGetCardInfo_Api;
#pragma warning disable 0169
		static Delegate GetNTAGGetCardInfo_ApiHandler ()
		{
			if (cb_NTAGGetCardInfo_Api == null)
				cb_NTAGGetCardInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NTAGGetCardInfo_Api));
			return cb_NTAGGetCardInfo_Api;
		}

		static IntPtr n_NTAGGetCardInfo_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NTAGGetCardInfo_Api ());
		}
#pragma warning restore 0169

		IntPtr id_NTAGGetCardInfo_Api;
		public unsafe global::Android.OS.Bundle? NTAGGetCardInfo_Api ()
		{
			if (id_NTAGGetCardInfo_Api == IntPtr.Zero)
				id_NTAGGetCardInfo_Api = JNIEnv.GetMethodID (class_ref, "NTAGGetCardInfo_Api", "()Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_NTAGGetCardInfo_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_NTAGReadCount_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetNTAGReadCount_Api_arrayBHandler ()
		{
			if (cb_NTAGReadCount_Api_arrayB == null)
				cb_NTAGReadCount_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_NTAGReadCount_Api_arrayB));
			return cb_NTAGReadCount_Api_arrayB;
		}

		static int n_NTAGReadCount_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NTAGReadCount_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NTAGReadCount_Api_arrayB;
		public unsafe int NTAGReadCount_Api (byte[]? p0)
		{
			if (id_NTAGReadCount_Api_arrayB == IntPtr.Zero)
				id_NTAGReadCount_Api_arrayB = JNIEnv.GetMethodID (class_ref, "NTAGReadCount_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NTAGReadCount_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_NTAGReadData_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetNTAGReadData_Api_IarrayBHandler ()
		{
			if (cb_NTAGReadData_Api_IarrayB == null)
				cb_NTAGReadData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_NTAGReadData_Api_IarrayB));
			return cb_NTAGReadData_Api_IarrayB;
		}

		static int n_NTAGReadData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NTAGReadData_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NTAGReadData_Api_IarrayB;
		public unsafe int NTAGReadData_Api (int p0, byte[]? p1)
		{
			if (id_NTAGReadData_Api_IarrayB == IntPtr.Zero)
				id_NTAGReadData_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "NTAGReadData_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NTAGReadData_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_NTAGReadSign_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetNTAGReadSign_Api_arrayBHandler ()
		{
			if (cb_NTAGReadSign_Api_arrayB == null)
				cb_NTAGReadSign_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_NTAGReadSign_Api_arrayB));
			return cb_NTAGReadSign_Api_arrayB;
		}

		static int n_NTAGReadSign_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NTAGReadSign_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NTAGReadSign_Api_arrayB;
		public unsafe int NTAGReadSign_Api (byte[]? p0)
		{
			if (id_NTAGReadSign_Api_arrayB == IntPtr.Zero)
				id_NTAGReadSign_Api_arrayB = JNIEnv.GetMethodID (class_ref, "NTAGReadSign_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NTAGReadSign_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_NTAGWriteData_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetNTAGWriteData_Api_IarrayBHandler ()
		{
			if (cb_NTAGWriteData_Api_IarrayB == null)
				cb_NTAGWriteData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_NTAGWriteData_Api_IarrayB));
			return cb_NTAGWriteData_Api_IarrayB;
		}

		static int n_NTAGWriteData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.NTAGWriteData_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_NTAGWriteData_Api_IarrayB;
		public unsafe int NTAGWriteData_Api (int p0, byte[]? p1)
		{
			if (id_NTAGWriteData_Api_IarrayB == IntPtr.Zero)
				id_NTAGWriteData_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "NTAGWriteData_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_NTAGWriteData_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_PiccCheck_Api_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetPiccCheck_Api_IarrayBarrayBHandler ()
		{
			if (cb_PiccCheck_Api_IarrayBarrayB == null)
				cb_PiccCheck_Api_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_PiccCheck_Api_IarrayBarrayB));
			return cb_PiccCheck_Api_IarrayBarrayB;
		}

		static int n_PiccCheck_Api_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PiccCheck_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PiccCheck_Api_IarrayBarrayB;
		public unsafe int PiccCheck_Api (int p0, byte[]? p1, byte[]? p2)
		{
			if (id_PiccCheck_Api_IarrayBarrayB == IntPtr.Zero)
				id_PiccCheck_Api_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "PiccCheck_Api", "(I[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccCheck_Api_IarrayBarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_PiccClose_Api;
#pragma warning disable 0169
		static Delegate GetPiccClose_ApiHandler ()
		{
			if (cb_PiccClose_Api == null)
				cb_PiccClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccClose_Api));
			return cb_PiccClose_Api;
		}

		static int n_PiccClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PiccClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PiccClose_Api;
		public unsafe int PiccClose_Api ()
		{
			if (id_PiccClose_Api == IntPtr.Zero)
				id_PiccClose_Api = JNIEnv.GetMethodID (class_ref, "PiccClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccClose_Api);
		}

		static Delegate? cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetPiccGetCardInfo_Api_arrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB == null)
				cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_I (n_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB));
			return cb_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB;
		}

		static int n_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PiccGetCardInfo_Api (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB;
		public unsafe int PiccGetCardInfo_Api (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3)
		{
			if (id_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "PiccGetCardInfo_Api", "([B[B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccGetCardInfo_Api_arrayBarrayBarrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_PiccHalt_Api;
#pragma warning disable 0169
		static Delegate GetPiccHalt_ApiHandler ()
		{
			if (cb_PiccHalt_Api == null)
				cb_PiccHalt_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccHalt_Api));
			return cb_PiccHalt_Api;
		}

		static int n_PiccHalt_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PiccHalt_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PiccHalt_Api;
		public unsafe int PiccHalt_Api ()
		{
			if (id_PiccHalt_Api == IntPtr.Zero)
				id_PiccHalt_Api = JNIEnv.GetMethodID (class_ref, "PiccHalt_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccHalt_Api);
		}

		static Delegate? cb_PiccIsoCommandType_Api_IarrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetPiccIsoCommandType_Api_IarrayBIarrayBHandler ()
		{
			if (cb_PiccIsoCommandType_Api_IarrayBIarrayB == null)
				cb_PiccIsoCommandType_Api_IarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILIL_I (n_PiccIsoCommandType_Api_IarrayBIarrayB));
			return cb_PiccIsoCommandType_Api_IarrayBIarrayB;
		}

		static int n_PiccIsoCommandType_Api_IarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PiccIsoCommandType_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PiccIsoCommandType_Api_IarrayBIarrayB;
		public unsafe int PiccIsoCommandType_Api (int p0, byte[]? p1, int p2, byte[]? p3)
		{
			if (id_PiccIsoCommandType_Api_IarrayBIarrayB == IntPtr.Zero)
				id_PiccIsoCommandType_Api_IarrayBIarrayB = JNIEnv.GetMethodID (class_ref, "PiccIsoCommandType_Api", "(I[BI[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccIsoCommandType_Api_IarrayBIarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_;
#pragma warning disable 0169
		static Delegate GetPiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_Handler ()
		{
			if (cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ == null)
				cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_));
			return cb_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_;
		}

		static void n_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.Apdu> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PiccIsoCommand_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_;
		public unsafe void PiccIsoCommand_Api (global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p0)
		{
			if (id_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ == IntPtr.Zero)
				id_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_ = JNIEnv.GetMethodID (class_ref, "PiccIsoCommand_Api", "(Lcom/vanstone/appsdk/api/struct/Apdu;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PiccIsoCommand_Api_Lcom_vanstone_appsdk_api_struct_Apdu_, __args);
		}

		static Delegate? cb_PiccOpen_Api;
#pragma warning disable 0169
		static Delegate GetPiccOpen_ApiHandler ()
		{
			if (cb_PiccOpen_Api == null)
				cb_PiccOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccOpen_Api));
			return cb_PiccOpen_Api;
		}

		static int n_PiccOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PiccOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PiccOpen_Api;
		public unsafe int PiccOpen_Api ()
		{
			if (id_PiccOpen_Api == IntPtr.Zero)
				id_PiccOpen_Api = JNIEnv.GetMethodID (class_ref, "PiccOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccOpen_Api);
		}

		static Delegate? cb_PiccRemove_Api;
#pragma warning disable 0169
		static Delegate GetPiccRemove_ApiHandler ()
		{
			if (cb_PiccRemove_Api == null)
				cb_PiccRemove_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PiccRemove_Api));
			return cb_PiccRemove_Api;
		}

		static int n_PiccRemove_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PiccRemove_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PiccRemove_Api;
		public unsafe int PiccRemove_Api ()
		{
			if (id_PiccRemove_Api == IntPtr.Zero)
				id_PiccRemove_Api = JNIEnv.GetMethodID (class_ref, "PiccRemove_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccRemove_Api);
		}

		static Delegate? cb_PiccRest_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetPiccRest_Api_IarrayBHandler ()
		{
			if (cb_PiccRest_Api_IarrayB == null)
				cb_PiccRest_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_PiccRest_Api_IarrayB));
			return cb_PiccRest_Api_IarrayB;
		}

		static int n_PiccRest_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PiccRest_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PiccRest_Api_IarrayB;
		public unsafe int PiccRest_Api (int p0, byte[]? p1)
		{
			if (id_PiccRest_Api_IarrayB == IntPtr.Zero)
				id_PiccRest_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "PiccRest_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PiccRest_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_SidCardCommand_Api_arrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetSidCardCommand_Api_arrayBIarrayBHandler ()
		{
			if (cb_SidCardCommand_Api_arrayBIarrayB == null)
				cb_SidCardCommand_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_SidCardCommand_Api_arrayBIarrayB));
			return cb_SidCardCommand_Api_arrayBIarrayB;
		}

		static int n_SidCardCommand_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SidCardCommand_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SidCardCommand_Api_arrayBIarrayB;
		public unsafe int SidCardCommand_Api (byte[]? p0, int p1, byte[]? p2)
		{
			if (id_SidCardCommand_Api_arrayBIarrayB == IntPtr.Zero)
				id_SidCardCommand_Api_arrayBIarrayB = JNIEnv.GetMethodID (class_ref, "SidCardCommand_Api", "([BI[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SidCardCommand_Api_arrayBIarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB == null)
				cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLLLLLLL_I (n_GetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB));
			return cb_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB;
		}

		static int n_GetIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, IntPtr native_p11)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p8 = (byte[]?) JNIEnv.GetArray (native_p8, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p9 = (byte[]?) JNIEnv.GetArray (native_p9, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p10 = (byte[]?) JNIEnv.GetArray (native_p10, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p11 = (byte[]?) JNIEnv.GetArray (native_p11, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetIDCardMsg (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
			if (p8 != null)
				JNIEnv.CopyArray (p8, native_p8);
			if (p9 != null)
				JNIEnv.CopyArray (p9, native_p9);
			if (p10 != null)
				JNIEnv.CopyArray (p10, native_p10);
			if (p11 != null)
				JNIEnv.CopyArray (p11, native_p11);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB;
		public unsafe int GetIDCardMsg (byte[]? p0, byte[]? p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, byte[]? p7, byte[]? p8, byte[]? p9, byte[]? p10, byte[]? p11)
		{
			if (id_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "getIDCardMsg", "([B[B[B[B[B[B[B[B[B[B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			IntPtr native_p9 = JNIEnv.NewArray (p9);
			IntPtr native_p10 = JNIEnv.NewArray (p10);
			IntPtr native_p11 = JNIEnv.NewArray (p11);
			JValue* __args = stackalloc JValue [12];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (native_p7);
			__args [8] = new JValue (native_p8);
			__args [9] = new JValue (native_p9);
			__args [10] = new JValue (native_p10);
			__args [11] = new JValue (native_p11);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIDCardMsg_arrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			if (p7 != null) {
				JNIEnv.CopyArray (native_p7, p7);
				JNIEnv.DeleteLocalRef (native_p7);
			}
			if (p8 != null) {
				JNIEnv.CopyArray (native_p8, p8);
				JNIEnv.DeleteLocalRef (native_p8);
			}
			if (p9 != null) {
				JNIEnv.CopyArray (native_p9, p9);
				JNIEnv.DeleteLocalRef (native_p9);
			}
			if (p10 != null) {
				JNIEnv.CopyArray (native_p10, p10);
				JNIEnv.DeleteLocalRef (native_p10);
			}
			if (p11 != null) {
				JNIEnv.CopyArray (native_p11, p11);
				JNIEnv.DeleteLocalRef (native_p11);
			}
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IPICCHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
