using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Finger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']"
	[Register ("com/vanstone/appsdk/api/finger/FingerHandler", "", "Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker")]
	public partial interface IFingerHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerCheckIDTemplate_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("FingerCheckIDTemplate_Api", "(I)I", "GetFingerCheckIDTemplate_Api_IHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerCheckIDTemplate_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerClearCache_Api' and count(parameter)=0]"
		[Register ("FingerClearCache_Api", "()V", "GetFingerClearCache_ApiHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		void FingerClearCache_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerClose_Api' and count(parameter)=0]"
		[Register ("FingerClose_Api", "()I", "GetFingerClose_ApiHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerDeleteAll_Api' and count(parameter)=0]"
		[Register ("FingerDeleteAll_Api", "()I", "GetFingerDeleteAll_ApiHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerDeleteAll_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerDelete_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("FingerDelete_Api", "(I)I", "GetFingerDelete_Api_IHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerDelete_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerECharFType_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("FingerECharFType_Api", "(I[BI)I", "GetFingerECharFType_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerECharFType_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerEnterFType_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
		[Register ("FingerEnterFType_Api", "(IIIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerEnterFType_Api (int p0, int p1, int p2, int p3, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerEnterFp_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
		[Register ("FingerEnterFp_Api", "(IIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerEnterFp_Api (int p0, int p1, int p2, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerExportChar_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("FingerExportChar_Api", "(I[B)I", "GetFingerExportChar_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerExportChar_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetBmp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("FingerGetBmp_Api", "([B)[B", "GetFingerGetBmp_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		byte[]? FingerGetBmp_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetCount_Api' and count(parameter)=0]"
		[Register ("FingerGetCount_Api", "()I", "GetFingerGetCount_ApiHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerGetCount_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetDevInfo_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("FingerGetDevInfo_Api", "([B)I", "GetFingerGetDevInfo_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerGetDevInfo_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetDevSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("FingerGetDevSN_Api", "([B)I", "GetFingerGetDevSN_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerGetDevSN_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetFp_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGetProcessAIDL']]"
		[Register ("FingerGetFp_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)I", "GetFingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_Handler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerGetFp_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetNextEmptyID_Api' and count(parameter)=0]"
		[Register ("FingerGetNextEmptyID_Api", "()I", "GetFingerGetNextEmptyID_ApiHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerGetNextEmptyID_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGrabImg_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
		[Register ("FingerGrabImg_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerGrabImg_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerInit_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("FingerInit_Api", "(I)V", "GetFingerInit_Api_IHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		void FingerInit_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerIsHas_Api' and count(parameter)=0]"
		[Register ("FingerIsHas_Api", "()Z", "GetFingerIsHas_ApiHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		bool FingerIsHas_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerOpen_Api' and count(parameter)=0]"
		[Register ("FingerOpen_Api", "()I", "GetFingerOpen_ApiHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerUpImage_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("FingerUpImage_Api", "([B)I", "GetFingerUpImage_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerUpImage_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerifyAll_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
		[Register ("FingerVerifyAll_Api", "(Lcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerVerifyAll_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerifySetTimeout_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
		[Register ("FingerVerifySetTimeout_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerVerifySetTimeout_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerify_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
		[Register ("FingerVerify_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler:Com.Vanstone.Appsdk.Api.Finger.IFingerHandlerInvoker, VanstonePosSdk")]
		int FingerVerify_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/finger/FingerHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/finger/FingerHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/constructor[@name='FingerHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_FingerCheckIDTemplate_Api_I;
#pragma warning disable 0169
			static Delegate GetFingerCheckIDTemplate_Api_IHandler ()
			{
				if (cb_FingerCheckIDTemplate_Api_I == null)
					cb_FingerCheckIDTemplate_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_FingerCheckIDTemplate_Api_I));
				return cb_FingerCheckIDTemplate_Api_I;
			}

			static int n_FingerCheckIDTemplate_Api_I (IntPtr jnienv, IntPtr native__this, int fingerID)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerCheckIDTemplate_Api (fingerID);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerCheckIDTemplate_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerCheckIDTemplate_Api", "(I)I", "GetFingerCheckIDTemplate_Api_IHandler")]
			public virtual unsafe int FingerCheckIDTemplate_Api (int fingerID)
			{
				const string __id = "FingerCheckIDTemplate_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (fingerID);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerClearCache_Api;
#pragma warning disable 0169
			static Delegate GetFingerClearCache_ApiHandler ()
			{
				if (cb_FingerClearCache_Api == null)
					cb_FingerClearCache_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FingerClearCache_Api));
				return cb_FingerClearCache_Api;
			}

			static void n_FingerClearCache_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.FingerClearCache_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerClearCache_Api' and count(parameter)=0]"
			[Register ("FingerClearCache_Api", "()V", "GetFingerClearCache_ApiHandler")]
			public virtual unsafe void FingerClearCache_Api ()
			{
				const string __id = "FingerClearCache_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_FingerClose_Api;
#pragma warning disable 0169
			static Delegate GetFingerClose_ApiHandler ()
			{
				if (cb_FingerClose_Api == null)
					cb_FingerClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerClose_Api));
				return cb_FingerClose_Api;
			}

			static int n_FingerClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerClose_Api' and count(parameter)=0]"
			[Register ("FingerClose_Api", "()I", "GetFingerClose_ApiHandler")]
			public virtual unsafe int FingerClose_Api ()
			{
				const string __id = "FingerClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerDeleteAll_Api;
#pragma warning disable 0169
			static Delegate GetFingerDeleteAll_ApiHandler ()
			{
				if (cb_FingerDeleteAll_Api == null)
					cb_FingerDeleteAll_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerDeleteAll_Api));
				return cb_FingerDeleteAll_Api;
			}

			static int n_FingerDeleteAll_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerDeleteAll_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerDeleteAll_Api' and count(parameter)=0]"
			[Register ("FingerDeleteAll_Api", "()I", "GetFingerDeleteAll_ApiHandler")]
			public virtual unsafe int FingerDeleteAll_Api ()
			{
				const string __id = "FingerDeleteAll_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerDelete_Api_I;
#pragma warning disable 0169
			static Delegate GetFingerDelete_Api_IHandler ()
			{
				if (cb_FingerDelete_Api_I == null)
					cb_FingerDelete_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_FingerDelete_Api_I));
				return cb_FingerDelete_Api_I;
			}

			static int n_FingerDelete_Api_I (IntPtr jnienv, IntPtr native__this, int fingerIndex)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerDelete_Api (fingerIndex);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerDelete_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerDelete_Api", "(I)I", "GetFingerDelete_Api_IHandler")]
			public virtual unsafe int FingerDelete_Api (int fingerIndex)
			{
				const string __id = "FingerDelete_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (fingerIndex);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerECharFType_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetFingerECharFType_Api_IarrayBIHandler ()
			{
				if (cb_FingerECharFType_Api_IarrayBI == null)
					cb_FingerECharFType_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_FingerECharFType_Api_IarrayBI));
				return cb_FingerECharFType_Api_IarrayBI;
			}

			static int n_FingerECharFType_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int slotId, IntPtr native_buf, int featureType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerECharFType_Api (slotId, buf, featureType);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerECharFType_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("FingerECharFType_Api", "(I[BI)I", "GetFingerECharFType_Api_IarrayBIHandler")]
			public virtual unsafe int FingerECharFType_Api (int slotId, byte[]? buf, int featureType)
			{
				const string __id = "FingerECharFType_Api.(I[BI)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (slotId);
					__args [1] = new JniArgumentValue (native_buf);
					__args [2] = new JniArgumentValue (featureType);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

			static Delegate? cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler ()
			{
				if (cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == null)
					cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_));
				return cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
			}

			static int n_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int fingerID, int entryCount, int featureType, int timeOutMs, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerEnterFType_Api (fingerID, entryCount, featureType, timeOutMs, listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerEnterFType_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
			[Register ("FingerEnterFType_Api", "(IIIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler")]
			public virtual unsafe int FingerEnterFType_Api (int fingerID, int entryCount, int featureType, int timeOutMs, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? listener)
			{
				const string __id = "FingerEnterFType_Api.(IIIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (fingerID);
					__args [1] = new JniArgumentValue (entryCount);
					__args [2] = new JniArgumentValue (featureType);
					__args [3] = new JniArgumentValue (timeOutMs);
					__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler ()
			{
				if (cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == null)
					cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_));
				return cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
			}

			static int n_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int fingerID, int entryCount, int timeOutMs, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerEnterFp_Api (fingerID, entryCount, timeOutMs, listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerEnterFp_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
			[Register ("FingerEnterFp_Api", "(IIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler")]
			public virtual unsafe int FingerEnterFp_Api (int fingerID, int entryCount, int timeOutMs, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? listener)
			{
				const string __id = "FingerEnterFp_Api.(IIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (fingerID);
					__args [1] = new JniArgumentValue (entryCount);
					__args [2] = new JniArgumentValue (timeOutMs);
					__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_FingerExportChar_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetFingerExportChar_Api_IarrayBHandler ()
			{
				if (cb_FingerExportChar_Api_IarrayB == null)
					cb_FingerExportChar_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerExportChar_Api_IarrayB));
				return cb_FingerExportChar_Api_IarrayB;
			}

			static int n_FingerExportChar_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int slotId, IntPtr native_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerExportChar_Api (slotId, buf);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerExportChar_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("FingerExportChar_Api", "(I[B)I", "GetFingerExportChar_Api_IarrayBHandler")]
			public virtual unsafe int FingerExportChar_Api (int slotId, byte[]? buf)
			{
				const string __id = "FingerExportChar_Api.(I[B)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (slotId);
					__args [1] = new JniArgumentValue (native_buf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

			static Delegate? cb_FingerGetBmp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerGetBmp_Api_arrayBHandler ()
			{
				if (cb_FingerGetBmp_Api_arrayB == null)
					cb_FingerGetBmp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_FingerGetBmp_Api_arrayB));
				return cb_FingerGetBmp_Api_arrayB;
			}

			static IntPtr n_FingerGetBmp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_imageData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var imageData = (byte[]?) JNIEnv.GetArray (native_imageData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.FingerGetBmp_Api (imageData));
				if (imageData != null)
					JNIEnv.CopyArray (imageData, native_imageData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerGetBmp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetBmp_Api", "([B)[B", "GetFingerGetBmp_Api_arrayBHandler")]
			public virtual unsafe byte[]? FingerGetBmp_Api (byte[]? imageData)
			{
				const string __id = "FingerGetBmp_Api.([B)[B";
				IntPtr native_imageData = JNIEnv.NewArray (imageData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_imageData);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (imageData != null) {
						JNIEnv.CopyArray (native_imageData, imageData);
						JNIEnv.DeleteLocalRef (native_imageData);
					}
					global::System.GC.KeepAlive (imageData);
				}
			}

			static Delegate? cb_FingerGetCount_Api;
#pragma warning disable 0169
			static Delegate GetFingerGetCount_ApiHandler ()
			{
				if (cb_FingerGetCount_Api == null)
					cb_FingerGetCount_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerGetCount_Api));
				return cb_FingerGetCount_Api;
			}

			static int n_FingerGetCount_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerGetCount_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerGetCount_Api' and count(parameter)=0]"
			[Register ("FingerGetCount_Api", "()I", "GetFingerGetCount_ApiHandler")]
			public virtual unsafe int FingerGetCount_Api ()
			{
				const string __id = "FingerGetCount_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerGetDevInfo_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerGetDevInfo_Api_arrayBHandler ()
			{
				if (cb_FingerGetDevInfo_Api_arrayB == null)
					cb_FingerGetDevInfo_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerGetDevInfo_Api_arrayB));
				return cb_FingerGetDevInfo_Api_arrayB;
			}

			static int n_FingerGetDevInfo_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_devInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var devInfo = (byte[]?) JNIEnv.GetArray (native_devInfo, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerGetDevInfo_Api (devInfo);
				if (devInfo != null)
					JNIEnv.CopyArray (devInfo, native_devInfo);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerGetDevInfo_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetDevInfo_Api", "([B)I", "GetFingerGetDevInfo_Api_arrayBHandler")]
			public virtual unsafe int FingerGetDevInfo_Api (byte[]? devInfo)
			{
				const string __id = "FingerGetDevInfo_Api.([B)I";
				IntPtr native_devInfo = JNIEnv.NewArray (devInfo);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_devInfo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (devInfo != null) {
						JNIEnv.CopyArray (native_devInfo, devInfo);
						JNIEnv.DeleteLocalRef (native_devInfo);
					}
					global::System.GC.KeepAlive (devInfo);
				}
			}

			static Delegate? cb_FingerGetDevSN_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerGetDevSN_Api_arrayBHandler ()
			{
				if (cb_FingerGetDevSN_Api_arrayB == null)
					cb_FingerGetDevSN_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerGetDevSN_Api_arrayB));
				return cb_FingerGetDevSN_Api_arrayB;
			}

			static int n_FingerGetDevSN_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_sn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var sn = (byte[]?) JNIEnv.GetArray (native_sn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerGetDevSN_Api (sn);
				if (sn != null)
					JNIEnv.CopyArray (sn, native_sn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerGetDevSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetDevSN_Api", "([B)I", "GetFingerGetDevSN_Api_arrayBHandler")]
			public virtual unsafe int FingerGetDevSN_Api (byte[]? sn)
			{
				const string __id = "FingerGetDevSN_Api.([B)I";
				IntPtr native_sn = JNIEnv.NewArray (sn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_sn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (sn != null) {
						JNIEnv.CopyArray (native_sn, sn);
						JNIEnv.DeleteLocalRef (native_sn);
					}
					global::System.GC.KeepAlive (sn);
				}
			}

			static Delegate? cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_Handler ()
			{
				if (cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ == null)
					cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_));
				return cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_;
			}

			static int n_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int featureType, int timeOutMs, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerGetFp_Api (featureType, timeOutMs, listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerGetFp_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGetProcessAIDL']]"
			[Register ("FingerGetFp_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)I", "GetFingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_Handler")]
			public virtual unsafe int FingerGetFp_Api (int featureType, int timeOutMs, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? listener)
			{
				const string __id = "FingerGetFp_Api.(IILcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (featureType);
					__args [1] = new JniArgumentValue (timeOutMs);
					__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_FingerGetNextEmptyID_Api;
#pragma warning disable 0169
			static Delegate GetFingerGetNextEmptyID_ApiHandler ()
			{
				if (cb_FingerGetNextEmptyID_Api == null)
					cb_FingerGetNextEmptyID_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerGetNextEmptyID_Api));
				return cb_FingerGetNextEmptyID_Api;
			}

			static int n_FingerGetNextEmptyID_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerGetNextEmptyID_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerGetNextEmptyID_Api' and count(parameter)=0]"
			[Register ("FingerGetNextEmptyID_Api", "()I", "GetFingerGetNextEmptyID_ApiHandler")]
			public virtual unsafe int FingerGetNextEmptyID_Api ()
			{
				const string __id = "FingerGetNextEmptyID_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int timeOutMs, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerGrabImg_Api (timeOutMs, listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerGrabImg_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerGrabImg_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public virtual unsafe int FingerGrabImg_Api (int timeOutMs, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? listener)
			{
				const string __id = "FingerGrabImg_Api.(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (timeOutMs);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_FingerInit_Api_I;
#pragma warning disable 0169
			static Delegate GetFingerInit_Api_IHandler ()
			{
				if (cb_FingerInit_Api_I == null)
					cb_FingerInit_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_FingerInit_Api_I));
				return cb_FingerInit_Api_I;
			}

			static void n_FingerInit_Api_I (IntPtr jnienv, IntPtr native__this, int delayTime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.FingerInit_Api (delayTime);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerInit_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerInit_Api", "(I)V", "GetFingerInit_Api_IHandler")]
			public virtual unsafe void FingerInit_Api (int delayTime)
			{
				const string __id = "FingerInit_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (delayTime);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_FingerIsHas_Api;
#pragma warning disable 0169
			static Delegate GetFingerIsHas_ApiHandler ()
			{
				if (cb_FingerIsHas_Api == null)
					cb_FingerIsHas_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_FingerIsHas_Api));
				return cb_FingerIsHas_Api;
			}

			static bool n_FingerIsHas_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerIsHas_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerIsHas_Api' and count(parameter)=0]"
			[Register ("FingerIsHas_Api", "()Z", "GetFingerIsHas_ApiHandler")]
			public virtual unsafe bool FingerIsHas_Api ()
			{
				const string __id = "FingerIsHas_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerOpen_Api;
#pragma warning disable 0169
			static Delegate GetFingerOpen_ApiHandler ()
			{
				if (cb_FingerOpen_Api == null)
					cb_FingerOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerOpen_Api));
				return cb_FingerOpen_Api;
			}

			static int n_FingerOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerOpen_Api' and count(parameter)=0]"
			[Register ("FingerOpen_Api", "()I", "GetFingerOpen_ApiHandler")]
			public virtual unsafe int FingerOpen_Api ()
			{
				const string __id = "FingerOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FingerUpImage_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerUpImage_Api_arrayBHandler ()
			{
				if (cb_FingerUpImage_Api_arrayB == null)
					cb_FingerUpImage_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerUpImage_Api_arrayB));
				return cb_FingerUpImage_Api_arrayB;
			}

			static int n_FingerUpImage_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_imageData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var imageData = (byte[]?) JNIEnv.GetArray (native_imageData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerUpImage_Api (imageData);
				if (imageData != null)
					JNIEnv.CopyArray (imageData, native_imageData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerUpImage_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerUpImage_Api", "([B)I", "GetFingerUpImage_Api_arrayBHandler")]
			public virtual unsafe int FingerUpImage_Api (byte[]? imageData)
			{
				const string __id = "FingerUpImage_Api.([B)I";
				IntPtr native_imageData = JNIEnv.NewArray (imageData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_imageData);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (imageData != null) {
						JNIEnv.CopyArray (native_imageData, imageData);
						JNIEnv.DeleteLocalRef (native_imageData);
					}
					global::System.GC.KeepAlive (imageData);
				}
			}

			static Delegate? cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerVerifyAll_Api (listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerVerifyAll_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerifyAll_Api", "(Lcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public virtual unsafe int FingerVerifyAll_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? listener)
			{
				const string __id = "FingerVerifyAll_Api.(Lcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int slotNum, int timeout, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerVerifySetTimeout_Api (slotNum, timeout, listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerVerifySetTimeout_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerifySetTimeout_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public virtual unsafe int FingerVerifySetTimeout_Api (int slotNum, int timeout, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? listener)
			{
				const string __id = "FingerVerifySetTimeout_Api.(IILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (slotNum);
					__args [1] = new JniArgumentValue (timeout);
					__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int fingerID, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerVerify_Api (fingerID, listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='FingerVerify_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerify_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public virtual unsafe int FingerVerify_Api (int fingerID, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? listener)
			{
				const string __id = "FingerVerify_Api.(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (fingerID);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/finger/FingerHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/finger/FingerHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Stub']/constructor[@name='FingerHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/finger/FingerHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/finger/FingerHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/finger/FingerHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/finger/FingerHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/class[@name='FingerHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.finger.FingerHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/finger/FingerHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/finger/FingerHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_FingerCheckIDTemplate_Api_I;
#pragma warning disable 0169
			static Delegate GetFingerCheckIDTemplate_Api_IHandler ()
			{
				if (cb_FingerCheckIDTemplate_Api_I == null)
					cb_FingerCheckIDTemplate_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_FingerCheckIDTemplate_Api_I));
				return cb_FingerCheckIDTemplate_Api_I;
			}

			static int n_FingerCheckIDTemplate_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerCheckIDTemplate_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerCheckIDTemplate_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerCheckIDTemplate_Api", "(I)I", "GetFingerCheckIDTemplate_Api_IHandler")]
			public abstract int FingerCheckIDTemplate_Api (int p0);

			static Delegate? cb_FingerClearCache_Api;
#pragma warning disable 0169
			static Delegate GetFingerClearCache_ApiHandler ()
			{
				if (cb_FingerClearCache_Api == null)
					cb_FingerClearCache_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FingerClearCache_Api));
				return cb_FingerClearCache_Api;
			}

			static void n_FingerClearCache_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.FingerClearCache_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerClearCache_Api' and count(parameter)=0]"
			[Register ("FingerClearCache_Api", "()V", "GetFingerClearCache_ApiHandler")]
			public abstract void FingerClearCache_Api ();

			static Delegate? cb_FingerClose_Api;
#pragma warning disable 0169
			static Delegate GetFingerClose_ApiHandler ()
			{
				if (cb_FingerClose_Api == null)
					cb_FingerClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerClose_Api));
				return cb_FingerClose_Api;
			}

			static int n_FingerClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerClose_Api' and count(parameter)=0]"
			[Register ("FingerClose_Api", "()I", "GetFingerClose_ApiHandler")]
			public abstract int FingerClose_Api ();

			static Delegate? cb_FingerDeleteAll_Api;
#pragma warning disable 0169
			static Delegate GetFingerDeleteAll_ApiHandler ()
			{
				if (cb_FingerDeleteAll_Api == null)
					cb_FingerDeleteAll_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerDeleteAll_Api));
				return cb_FingerDeleteAll_Api;
			}

			static int n_FingerDeleteAll_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerDeleteAll_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerDeleteAll_Api' and count(parameter)=0]"
			[Register ("FingerDeleteAll_Api", "()I", "GetFingerDeleteAll_ApiHandler")]
			public abstract int FingerDeleteAll_Api ();

			static Delegate? cb_FingerDelete_Api_I;
#pragma warning disable 0169
			static Delegate GetFingerDelete_Api_IHandler ()
			{
				if (cb_FingerDelete_Api_I == null)
					cb_FingerDelete_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_FingerDelete_Api_I));
				return cb_FingerDelete_Api_I;
			}

			static int n_FingerDelete_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerDelete_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerDelete_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerDelete_Api", "(I)I", "GetFingerDelete_Api_IHandler")]
			public abstract int FingerDelete_Api (int p0);

			static Delegate? cb_FingerECharFType_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetFingerECharFType_Api_IarrayBIHandler ()
			{
				if (cb_FingerECharFType_Api_IarrayBI == null)
					cb_FingerECharFType_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_FingerECharFType_Api_IarrayBI));
				return cb_FingerECharFType_Api_IarrayBI;
			}

			static int n_FingerECharFType_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerECharFType_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerECharFType_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("FingerECharFType_Api", "(I[BI)I", "GetFingerECharFType_Api_IarrayBIHandler")]
			public abstract int FingerECharFType_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler ()
			{
				if (cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == null)
					cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_));
				return cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
			}

			static int n_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p4 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL> (native_p4, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerEnterFType_Api (p0, p1, p2, p3, p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerEnterFType_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
			[Register ("FingerEnterFType_Api", "(IIIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler")]
			public abstract int FingerEnterFType_Api (int p0, int p1, int p2, int p3, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p4);

			static Delegate? cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler ()
			{
				if (cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == null)
					cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_));
				return cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
			}

			static int n_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL> (native_p3, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerEnterFp_Api (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerEnterFp_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
			[Register ("FingerEnterFp_Api", "(IIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler")]
			public abstract int FingerEnterFp_Api (int p0, int p1, int p2, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p3);

			static Delegate? cb_FingerExportChar_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetFingerExportChar_Api_IarrayBHandler ()
			{
				if (cb_FingerExportChar_Api_IarrayB == null)
					cb_FingerExportChar_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerExportChar_Api_IarrayB));
				return cb_FingerExportChar_Api_IarrayB;
			}

			static int n_FingerExportChar_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerExportChar_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerExportChar_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("FingerExportChar_Api", "(I[B)I", "GetFingerExportChar_Api_IarrayBHandler")]
			public abstract int FingerExportChar_Api (int p0, byte[]? p1);

			static Delegate? cb_FingerGetBmp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerGetBmp_Api_arrayBHandler ()
			{
				if (cb_FingerGetBmp_Api_arrayB == null)
					cb_FingerGetBmp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_FingerGetBmp_Api_arrayB));
				return cb_FingerGetBmp_Api_arrayB;
			}

			static IntPtr n_FingerGetBmp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.FingerGetBmp_Api (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetBmp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetBmp_Api", "([B)[B", "GetFingerGetBmp_Api_arrayBHandler")]
			public abstract byte[]? FingerGetBmp_Api (byte[]? p0);

			static Delegate? cb_FingerGetCount_Api;
#pragma warning disable 0169
			static Delegate GetFingerGetCount_ApiHandler ()
			{
				if (cb_FingerGetCount_Api == null)
					cb_FingerGetCount_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerGetCount_Api));
				return cb_FingerGetCount_Api;
			}

			static int n_FingerGetCount_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerGetCount_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetCount_Api' and count(parameter)=0]"
			[Register ("FingerGetCount_Api", "()I", "GetFingerGetCount_ApiHandler")]
			public abstract int FingerGetCount_Api ();

			static Delegate? cb_FingerGetDevInfo_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerGetDevInfo_Api_arrayBHandler ()
			{
				if (cb_FingerGetDevInfo_Api_arrayB == null)
					cb_FingerGetDevInfo_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerGetDevInfo_Api_arrayB));
				return cb_FingerGetDevInfo_Api_arrayB;
			}

			static int n_FingerGetDevInfo_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerGetDevInfo_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetDevInfo_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetDevInfo_Api", "([B)I", "GetFingerGetDevInfo_Api_arrayBHandler")]
			public abstract int FingerGetDevInfo_Api (byte[]? p0);

			static Delegate? cb_FingerGetDevSN_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerGetDevSN_Api_arrayBHandler ()
			{
				if (cb_FingerGetDevSN_Api_arrayB == null)
					cb_FingerGetDevSN_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerGetDevSN_Api_arrayB));
				return cb_FingerGetDevSN_Api_arrayB;
			}

			static int n_FingerGetDevSN_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerGetDevSN_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetDevSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetDevSN_Api", "([B)I", "GetFingerGetDevSN_Api_arrayBHandler")]
			public abstract int FingerGetDevSN_Api (byte[]? p0);

			static Delegate? cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_Handler ()
			{
				if (cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ == null)
					cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_));
				return cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_;
			}

			static int n_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (native_p2, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerGetFp_Api (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetFp_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGetProcessAIDL']]"
			[Register ("FingerGetFp_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)I", "GetFingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_Handler")]
			public abstract int FingerGetFp_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? p2);

			static Delegate? cb_FingerGetNextEmptyID_Api;
#pragma warning disable 0169
			static Delegate GetFingerGetNextEmptyID_ApiHandler ()
			{
				if (cb_FingerGetNextEmptyID_Api == null)
					cb_FingerGetNextEmptyID_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerGetNextEmptyID_Api));
				return cb_FingerGetNextEmptyID_Api;
			}

			static int n_FingerGetNextEmptyID_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerGetNextEmptyID_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetNextEmptyID_Api' and count(parameter)=0]"
			[Register ("FingerGetNextEmptyID_Api", "()I", "GetFingerGetNextEmptyID_ApiHandler")]
			public abstract int FingerGetNextEmptyID_Api ();

			static Delegate? cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerGrabImg_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGrabImg_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerGrabImg_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public abstract int FingerGrabImg_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1);

			static Delegate? cb_FingerInit_Api_I;
#pragma warning disable 0169
			static Delegate GetFingerInit_Api_IHandler ()
			{
				if (cb_FingerInit_Api_I == null)
					cb_FingerInit_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_FingerInit_Api_I));
				return cb_FingerInit_Api_I;
			}

			static void n_FingerInit_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.FingerInit_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerInit_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerInit_Api", "(I)V", "GetFingerInit_Api_IHandler")]
			public abstract void FingerInit_Api (int p0);

			static Delegate? cb_FingerIsHas_Api;
#pragma warning disable 0169
			static Delegate GetFingerIsHas_ApiHandler ()
			{
				if (cb_FingerIsHas_Api == null)
					cb_FingerIsHas_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_FingerIsHas_Api));
				return cb_FingerIsHas_Api;
			}

			static bool n_FingerIsHas_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerIsHas_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerIsHas_Api' and count(parameter)=0]"
			[Register ("FingerIsHas_Api", "()Z", "GetFingerIsHas_ApiHandler")]
			public abstract bool FingerIsHas_Api ();

			static Delegate? cb_FingerOpen_Api;
#pragma warning disable 0169
			static Delegate GetFingerOpen_ApiHandler ()
			{
				if (cb_FingerOpen_Api == null)
					cb_FingerOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerOpen_Api));
				return cb_FingerOpen_Api;
			}

			static int n_FingerOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FingerOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerOpen_Api' and count(parameter)=0]"
			[Register ("FingerOpen_Api", "()I", "GetFingerOpen_ApiHandler")]
			public abstract int FingerOpen_Api ();

			static Delegate? cb_FingerUpImage_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFingerUpImage_Api_arrayBHandler ()
			{
				if (cb_FingerUpImage_Api_arrayB == null)
					cb_FingerUpImage_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerUpImage_Api_arrayB));
				return cb_FingerUpImage_Api_arrayB;
			}

			static int n_FingerUpImage_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FingerUpImage_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerUpImage_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerUpImage_Api", "([B)I", "GetFingerUpImage_Api_arrayBHandler")]
			public abstract int FingerUpImage_Api (byte[]? p0);

			static Delegate? cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerVerifyAll_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerifyAll_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerifyAll_Api", "(Lcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public abstract int FingerVerifyAll_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p0);

			static Delegate? cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p2, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerVerifySetTimeout_Api (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerifySetTimeout_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerifySetTimeout_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public abstract int FingerVerifySetTimeout_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p2);

			static Delegate? cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
			static Delegate GetFingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
			{
				if (cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
					cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
				return cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
			}

			static int n_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FingerVerify_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerify_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerify_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public abstract int FingerVerify_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/finger/FingerHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/finger/FingerHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerCheckIDTemplate_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerCheckIDTemplate_Api", "(I)I", "GetFingerCheckIDTemplate_Api_IHandler")]
			public override unsafe int FingerCheckIDTemplate_Api (int p0)
			{
				const string __id = "FingerCheckIDTemplate_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerClearCache_Api' and count(parameter)=0]"
			[Register ("FingerClearCache_Api", "()V", "GetFingerClearCache_ApiHandler")]
			public override unsafe void FingerClearCache_Api ()
			{
				const string __id = "FingerClearCache_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerClose_Api' and count(parameter)=0]"
			[Register ("FingerClose_Api", "()I", "GetFingerClose_ApiHandler")]
			public override unsafe int FingerClose_Api ()
			{
				const string __id = "FingerClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerDeleteAll_Api' and count(parameter)=0]"
			[Register ("FingerDeleteAll_Api", "()I", "GetFingerDeleteAll_ApiHandler")]
			public override unsafe int FingerDeleteAll_Api ()
			{
				const string __id = "FingerDeleteAll_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerDelete_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerDelete_Api", "(I)I", "GetFingerDelete_Api_IHandler")]
			public override unsafe int FingerDelete_Api (int p0)
			{
				const string __id = "FingerDelete_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerECharFType_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("FingerECharFType_Api", "(I[BI)I", "GetFingerECharFType_Api_IarrayBIHandler")]
			public override unsafe int FingerECharFType_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "FingerECharFType_Api.(I[BI)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerEnterFType_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
			[Register ("FingerEnterFType_Api", "(IIIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler")]
			public override unsafe int FingerEnterFType_Api (int p0, int p1, int p2, int p3, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p4)
			{
				const string __id = "FingerEnterFType_Api.(IIIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerEnterFp_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.appsdk.api.interfaces.IFingerEntryProcessAIDL']]"
			[Register ("FingerEnterFp_Api", "(IIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I", "GetFingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler")]
			public override unsafe int FingerEnterFp_Api (int p0, int p1, int p2, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p3)
			{
				const string __id = "FingerEnterFp_Api.(IIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerExportChar_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("FingerExportChar_Api", "(I[B)I", "GetFingerExportChar_Api_IarrayBHandler")]
			public override unsafe int FingerExportChar_Api (int p0, byte[]? p1)
			{
				const string __id = "FingerExportChar_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetBmp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetBmp_Api", "([B)[B", "GetFingerGetBmp_Api_arrayBHandler")]
			public override unsafe byte[]? FingerGetBmp_Api (byte[]? p0)
			{
				const string __id = "FingerGetBmp_Api.([B)[B";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetCount_Api' and count(parameter)=0]"
			[Register ("FingerGetCount_Api", "()I", "GetFingerGetCount_ApiHandler")]
			public override unsafe int FingerGetCount_Api ()
			{
				const string __id = "FingerGetCount_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetDevInfo_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetDevInfo_Api", "([B)I", "GetFingerGetDevInfo_Api_arrayBHandler")]
			public override unsafe int FingerGetDevInfo_Api (byte[]? p0)
			{
				const string __id = "FingerGetDevInfo_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetDevSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerGetDevSN_Api", "([B)I", "GetFingerGetDevSN_Api_arrayBHandler")]
			public override unsafe int FingerGetDevSN_Api (byte[]? p0)
			{
				const string __id = "FingerGetDevSN_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetFp_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGetProcessAIDL']]"
			[Register ("FingerGetFp_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)I", "GetFingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_Handler")]
			public override unsafe int FingerGetFp_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? p2)
			{
				const string __id = "FingerGetFp_Api.(IILcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGetNextEmptyID_Api' and count(parameter)=0]"
			[Register ("FingerGetNextEmptyID_Api", "()I", "GetFingerGetNextEmptyID_ApiHandler")]
			public override unsafe int FingerGetNextEmptyID_Api ()
			{
				const string __id = "FingerGetNextEmptyID_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerGrabImg_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerGrabImg_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public override unsafe int FingerGrabImg_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1)
			{
				const string __id = "FingerGrabImg_Api.(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerInit_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("FingerInit_Api", "(I)V", "GetFingerInit_Api_IHandler")]
			public override unsafe void FingerInit_Api (int p0)
			{
				const string __id = "FingerInit_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerIsHas_Api' and count(parameter)=0]"
			[Register ("FingerIsHas_Api", "()Z", "GetFingerIsHas_ApiHandler")]
			public override unsafe bool FingerIsHas_Api ()
			{
				const string __id = "FingerIsHas_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerOpen_Api' and count(parameter)=0]"
			[Register ("FingerOpen_Api", "()I", "GetFingerOpen_ApiHandler")]
			public override unsafe int FingerOpen_Api ()
			{
				const string __id = "FingerOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerUpImage_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FingerUpImage_Api", "([B)I", "GetFingerUpImage_Api_arrayBHandler")]
			public override unsafe int FingerUpImage_Api (byte[]? p0)
			{
				const string __id = "FingerUpImage_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerifyAll_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerifyAll_Api", "(Lcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public override unsafe int FingerVerifyAll_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p0)
			{
				const string __id = "FingerVerifyAll_Api.(Lcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerifySetTimeout_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerifySetTimeout_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public override unsafe int FingerVerifySetTimeout_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p2)
			{
				const string __id = "FingerVerifySetTimeout_Api.(IILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.finger']/interface[@name='FingerHandler']/method[@name='FingerVerify_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFingerGrapImgProcessAIDL']]"
			[Register ("FingerVerify_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I", "GetFingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler")]
			public override unsafe int FingerVerify_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1)
			{
				const string __id = "FingerVerify_Api.(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/finger/FingerHandler", DoNotGenerateAcw=true)]
	internal partial class IFingerHandlerInvoker : global::Java.Lang.Object, IFingerHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/finger/FingerHandler", typeof (IFingerHandlerInvoker));

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

		public static IFingerHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFingerHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.finger.FingerHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFingerHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_FingerCheckIDTemplate_Api_I;
#pragma warning disable 0169
		static Delegate GetFingerCheckIDTemplate_Api_IHandler ()
		{
			if (cb_FingerCheckIDTemplate_Api_I == null)
				cb_FingerCheckIDTemplate_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_FingerCheckIDTemplate_Api_I));
			return cb_FingerCheckIDTemplate_Api_I;
		}

		static int n_FingerCheckIDTemplate_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerCheckIDTemplate_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_FingerCheckIDTemplate_Api_I;
		public unsafe int FingerCheckIDTemplate_Api (int p0)
		{
			if (id_FingerCheckIDTemplate_Api_I == IntPtr.Zero)
				id_FingerCheckIDTemplate_Api_I = JNIEnv.GetMethodID (class_ref, "FingerCheckIDTemplate_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerCheckIDTemplate_Api_I, __args);
		}

		static Delegate? cb_FingerClearCache_Api;
#pragma warning disable 0169
		static Delegate GetFingerClearCache_ApiHandler ()
		{
			if (cb_FingerClearCache_Api == null)
				cb_FingerClearCache_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FingerClearCache_Api));
			return cb_FingerClearCache_Api;
		}

		static void n_FingerClearCache_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.FingerClearCache_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FingerClearCache_Api;
		public unsafe void FingerClearCache_Api ()
		{
			if (id_FingerClearCache_Api == IntPtr.Zero)
				id_FingerClearCache_Api = JNIEnv.GetMethodID (class_ref, "FingerClearCache_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_FingerClearCache_Api);
		}

		static Delegate? cb_FingerClose_Api;
#pragma warning disable 0169
		static Delegate GetFingerClose_ApiHandler ()
		{
			if (cb_FingerClose_Api == null)
				cb_FingerClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerClose_Api));
			return cb_FingerClose_Api;
		}

		static int n_FingerClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FingerClose_Api;
		public unsafe int FingerClose_Api ()
		{
			if (id_FingerClose_Api == IntPtr.Zero)
				id_FingerClose_Api = JNIEnv.GetMethodID (class_ref, "FingerClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerClose_Api);
		}

		static Delegate? cb_FingerDeleteAll_Api;
#pragma warning disable 0169
		static Delegate GetFingerDeleteAll_ApiHandler ()
		{
			if (cb_FingerDeleteAll_Api == null)
				cb_FingerDeleteAll_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerDeleteAll_Api));
			return cb_FingerDeleteAll_Api;
		}

		static int n_FingerDeleteAll_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerDeleteAll_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FingerDeleteAll_Api;
		public unsafe int FingerDeleteAll_Api ()
		{
			if (id_FingerDeleteAll_Api == IntPtr.Zero)
				id_FingerDeleteAll_Api = JNIEnv.GetMethodID (class_ref, "FingerDeleteAll_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerDeleteAll_Api);
		}

		static Delegate? cb_FingerDelete_Api_I;
#pragma warning disable 0169
		static Delegate GetFingerDelete_Api_IHandler ()
		{
			if (cb_FingerDelete_Api_I == null)
				cb_FingerDelete_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_FingerDelete_Api_I));
			return cb_FingerDelete_Api_I;
		}

		static int n_FingerDelete_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerDelete_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_FingerDelete_Api_I;
		public unsafe int FingerDelete_Api (int p0)
		{
			if (id_FingerDelete_Api_I == IntPtr.Zero)
				id_FingerDelete_Api_I = JNIEnv.GetMethodID (class_ref, "FingerDelete_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerDelete_Api_I, __args);
		}

		static Delegate? cb_FingerECharFType_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetFingerECharFType_Api_IarrayBIHandler ()
		{
			if (cb_FingerECharFType_Api_IarrayBI == null)
				cb_FingerECharFType_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_FingerECharFType_Api_IarrayBI));
			return cb_FingerECharFType_Api_IarrayBI;
		}

		static int n_FingerECharFType_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FingerECharFType_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerECharFType_Api_IarrayBI;
		public unsafe int FingerECharFType_Api (int p0, byte[]? p1, int p2)
		{
			if (id_FingerECharFType_Api_IarrayBI == IntPtr.Zero)
				id_FingerECharFType_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "FingerECharFType_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerECharFType_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
#pragma warning disable 0169
		static Delegate GetFingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler ()
		{
			if (cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == null)
				cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_));
			return cb_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
		}

		static int n_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p4 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL> (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FingerEnterFType_Api (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
		public unsafe int FingerEnterFType_Api (int p0, int p1, int p2, int p3, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p4)
		{
			if (id_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == IntPtr.Zero)
				id_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNIEnv.GetMethodID (class_ref, "FingerEnterFType_Api", "(IIIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerEnterFType_Api_IIIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
#pragma warning disable 0169
		static Delegate GetFingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_Handler ()
		{
			if (cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == null)
				cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_));
			return cb_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
		}

		static int n_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FingerEnterFp_Api (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_;
		public unsafe int FingerEnterFp_Api (int p0, int p1, int p2, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerEntryProcessAIDL? p3)
		{
			if (id_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ == IntPtr.Zero)
				id_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_ = JNIEnv.GetMethodID (class_ref, "FingerEnterFp_Api", "(IIILcom/vanstone/appsdk/api/interfaces/IFingerEntryProcessAIDL;)I");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerEnterFp_Api_IIILcom_vanstone_appsdk_api_interfaces_IFingerEntryProcessAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_FingerExportChar_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetFingerExportChar_Api_IarrayBHandler ()
		{
			if (cb_FingerExportChar_Api_IarrayB == null)
				cb_FingerExportChar_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerExportChar_Api_IarrayB));
			return cb_FingerExportChar_Api_IarrayB;
		}

		static int n_FingerExportChar_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FingerExportChar_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerExportChar_Api_IarrayB;
		public unsafe int FingerExportChar_Api (int p0, byte[]? p1)
		{
			if (id_FingerExportChar_Api_IarrayB == IntPtr.Zero)
				id_FingerExportChar_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "FingerExportChar_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerExportChar_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_FingerGetBmp_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetFingerGetBmp_Api_arrayBHandler ()
		{
			if (cb_FingerGetBmp_Api_arrayB == null)
				cb_FingerGetBmp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_FingerGetBmp_Api_arrayB));
			return cb_FingerGetBmp_Api_arrayB;
		}

		static IntPtr n_FingerGetBmp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.FingerGetBmp_Api (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerGetBmp_Api_arrayB;
		public unsafe byte[]? FingerGetBmp_Api (byte[]? p0)
		{
			if (id_FingerGetBmp_Api_arrayB == IntPtr.Zero)
				id_FingerGetBmp_Api_arrayB = JNIEnv.GetMethodID (class_ref, "FingerGetBmp_Api", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_FingerGetBmp_Api_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FingerGetCount_Api;
#pragma warning disable 0169
		static Delegate GetFingerGetCount_ApiHandler ()
		{
			if (cb_FingerGetCount_Api == null)
				cb_FingerGetCount_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerGetCount_Api));
			return cb_FingerGetCount_Api;
		}

		static int n_FingerGetCount_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerGetCount_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FingerGetCount_Api;
		public unsafe int FingerGetCount_Api ()
		{
			if (id_FingerGetCount_Api == IntPtr.Zero)
				id_FingerGetCount_Api = JNIEnv.GetMethodID (class_ref, "FingerGetCount_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerGetCount_Api);
		}

		static Delegate? cb_FingerGetDevInfo_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetFingerGetDevInfo_Api_arrayBHandler ()
		{
			if (cb_FingerGetDevInfo_Api_arrayB == null)
				cb_FingerGetDevInfo_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerGetDevInfo_Api_arrayB));
			return cb_FingerGetDevInfo_Api_arrayB;
		}

		static int n_FingerGetDevInfo_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FingerGetDevInfo_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerGetDevInfo_Api_arrayB;
		public unsafe int FingerGetDevInfo_Api (byte[]? p0)
		{
			if (id_FingerGetDevInfo_Api_arrayB == IntPtr.Zero)
				id_FingerGetDevInfo_Api_arrayB = JNIEnv.GetMethodID (class_ref, "FingerGetDevInfo_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerGetDevInfo_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FingerGetDevSN_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetFingerGetDevSN_Api_arrayBHandler ()
		{
			if (cb_FingerGetDevSN_Api_arrayB == null)
				cb_FingerGetDevSN_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerGetDevSN_Api_arrayB));
			return cb_FingerGetDevSN_Api_arrayB;
		}

		static int n_FingerGetDevSN_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FingerGetDevSN_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerGetDevSN_Api_arrayB;
		public unsafe int FingerGetDevSN_Api (byte[]? p0)
		{
			if (id_FingerGetDevSN_Api_arrayB == IntPtr.Zero)
				id_FingerGetDevSN_Api_arrayB = JNIEnv.GetMethodID (class_ref, "FingerGetDevSN_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerGetDevSN_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_;
#pragma warning disable 0169
		static Delegate GetFingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_Handler ()
		{
			if (cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ == null)
				cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_));
			return cb_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_;
		}

		static int n_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FingerGetFp_Api (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_;
		public unsafe int FingerGetFp_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? p2)
		{
			if (id_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ == IntPtr.Zero)
				id_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_ = JNIEnv.GetMethodID (class_ref, "FingerGetFp_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerGetFp_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGetProcessAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_FingerGetNextEmptyID_Api;
#pragma warning disable 0169
		static Delegate GetFingerGetNextEmptyID_ApiHandler ()
		{
			if (cb_FingerGetNextEmptyID_Api == null)
				cb_FingerGetNextEmptyID_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerGetNextEmptyID_Api));
			return cb_FingerGetNextEmptyID_Api;
		}

		static int n_FingerGetNextEmptyID_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerGetNextEmptyID_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FingerGetNextEmptyID_Api;
		public unsafe int FingerGetNextEmptyID_Api ()
		{
			if (id_FingerGetNextEmptyID_Api == IntPtr.Zero)
				id_FingerGetNextEmptyID_Api = JNIEnv.GetMethodID (class_ref, "FingerGetNextEmptyID_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerGetNextEmptyID_Api);
		}

		static Delegate? cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
		static Delegate GetFingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
		{
			if (cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
				cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
			return cb_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		}

		static int n_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FingerGrabImg_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		public unsafe int FingerGrabImg_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1)
		{
			if (id_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == IntPtr.Zero)
				id_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNIEnv.GetMethodID (class_ref, "FingerGrabImg_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerGrabImg_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_FingerInit_Api_I;
#pragma warning disable 0169
		static Delegate GetFingerInit_Api_IHandler ()
		{
			if (cb_FingerInit_Api_I == null)
				cb_FingerInit_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_FingerInit_Api_I));
			return cb_FingerInit_Api_I;
		}

		static void n_FingerInit_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.FingerInit_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_FingerInit_Api_I;
		public unsafe void FingerInit_Api (int p0)
		{
			if (id_FingerInit_Api_I == IntPtr.Zero)
				id_FingerInit_Api_I = JNIEnv.GetMethodID (class_ref, "FingerInit_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_FingerInit_Api_I, __args);
		}

		static Delegate? cb_FingerIsHas_Api;
#pragma warning disable 0169
		static Delegate GetFingerIsHas_ApiHandler ()
		{
			if (cb_FingerIsHas_Api == null)
				cb_FingerIsHas_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_FingerIsHas_Api));
			return cb_FingerIsHas_Api;
		}

		static bool n_FingerIsHas_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerIsHas_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FingerIsHas_Api;
		public unsafe bool FingerIsHas_Api ()
		{
			if (id_FingerIsHas_Api == IntPtr.Zero)
				id_FingerIsHas_Api = JNIEnv.GetMethodID (class_ref, "FingerIsHas_Api", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_FingerIsHas_Api);
		}

		static Delegate? cb_FingerOpen_Api;
#pragma warning disable 0169
		static Delegate GetFingerOpen_ApiHandler ()
		{
			if (cb_FingerOpen_Api == null)
				cb_FingerOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FingerOpen_Api));
			return cb_FingerOpen_Api;
		}

		static int n_FingerOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FingerOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FingerOpen_Api;
		public unsafe int FingerOpen_Api ()
		{
			if (id_FingerOpen_Api == IntPtr.Zero)
				id_FingerOpen_Api = JNIEnv.GetMethodID (class_ref, "FingerOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerOpen_Api);
		}

		static Delegate? cb_FingerUpImage_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetFingerUpImage_Api_arrayBHandler ()
		{
			if (cb_FingerUpImage_Api_arrayB == null)
				cb_FingerUpImage_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerUpImage_Api_arrayB));
			return cb_FingerUpImage_Api_arrayB;
		}

		static int n_FingerUpImage_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FingerUpImage_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerUpImage_Api_arrayB;
		public unsafe int FingerUpImage_Api (byte[]? p0)
		{
			if (id_FingerUpImage_Api_arrayB == IntPtr.Zero)
				id_FingerUpImage_Api_arrayB = JNIEnv.GetMethodID (class_ref, "FingerUpImage_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerUpImage_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
		static Delegate GetFingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
		{
			if (cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
				cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
			return cb_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		}

		static int n_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FingerVerifyAll_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		public unsafe int FingerVerifyAll_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p0)
		{
			if (id_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == IntPtr.Zero)
				id_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNIEnv.GetMethodID (class_ref, "FingerVerifyAll_Api", "(Lcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerVerifyAll_Api_Lcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
		static Delegate GetFingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
		{
			if (cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
				cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
			return cb_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		}

		static int n_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FingerVerifySetTimeout_Api (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		public unsafe int FingerVerifySetTimeout_Api (int p0, int p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p2)
		{
			if (id_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == IntPtr.Zero)
				id_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNIEnv.GetMethodID (class_ref, "FingerVerifySetTimeout_Api", "(IILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerVerifySetTimeout_Api_IILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
#pragma warning disable 0169
		static Delegate GetFingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_Handler ()
		{
			if (cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == null)
				cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_));
			return cb_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		}

		static int n_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FingerVerify_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_;
		public unsafe int FingerVerify_Api (int p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGrapImgProcessAIDL? p1)
		{
			if (id_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ == IntPtr.Zero)
				id_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_ = JNIEnv.GetMethodID (class_ref, "FingerVerify_Api", "(ILcom/vanstone/appsdk/api/interfaces/IFingerGrapImgProcessAIDL;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FingerVerify_Api_ILcom_vanstone_appsdk_api_interfaces_IFingerGrapImgProcessAIDL_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Finger.IFingerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
