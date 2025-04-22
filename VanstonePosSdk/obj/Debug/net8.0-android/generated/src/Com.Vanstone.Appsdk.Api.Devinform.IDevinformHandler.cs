using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Devinform {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']"
	[Register ("com/vanstone/appsdk/api/devinform/DevinformHandler", "", "Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker")]
	public partial interface IDevinformHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetAndroidKernelVersion_Api' and count(parameter)=0]"
		[Register ("DevInfoGetAndroidKernelVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidKernelVersion_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetAndroidKernelVersion_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetAndroidOSVersion_Api' and count(parameter)=0]"
		[Register ("DevInfoGetAndroidOSVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidOSVersion_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetAndroidOSVersion_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetFirmwareVersion_Api' and count(parameter)=0]"
		[Register ("DevInfoGetFirmwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetFirmwareVersion_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetFirmwareVersion_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetHardwareVersion_Api' and count(parameter)=0]"
		[Register ("DevInfoGetHardwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetHardwareVersion_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetHardwareVersion_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetICCID_Api' and count(parameter)=0]"
		[Register ("DevInfoGetICCID_Api", "()Ljava/lang/String;", "GetDevInfoGetICCID_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetICCID_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetIMSI_Api' and count(parameter)=0]"
		[Register ("DevInfoGetIMSI_Api", "()Ljava/lang/String;", "GetDevInfoGetIMSI_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetIMSI_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetManufacture_Api' and count(parameter)=0]"
		[Register ("DevInfoGetManufacture_Api", "()Ljava/lang/String;", "GetDevInfoGetManufacture_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetManufacture_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetModel_Api' and count(parameter)=0]"
		[Register ("DevInfoGetModel_Api", "()Ljava/lang/String;", "GetDevInfoGetModel_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetModel_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetROMVerion_Api' and count(parameter)=0]"
		[Register ("DevInfoGetROMVerion_Api", "()Ljava/lang/String;", "GetDevInfoGetROMVerion_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetROMVerion_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetSETime_Api' and count(parameter)=0]"
		[Register ("DevInfoGetSETime_Api", "()J", "GetDevInfoGetSETime_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		long DevInfoGetSETime_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetSerialNo_Api' and count(parameter)=0]"
		[Register ("DevInfoGetSerialNo_Api", "()Ljava/lang/String;", "GetDevInfoGetSerialNo_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetSerialNo_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetTUSN_Api' and count(parameter)=0]"
		[Register ("DevInfoGetTUSN_Api", "()Ljava/lang/String;", "GetDevInfoGetTUSN_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfoGetTUSN_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoUpdateSystemTime_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("DevInfoUpdateSystemTime_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		bool DevInfoUpdateSystemTime_Api (string? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfogetSafeModuleVersion_Api' and count(parameter)=0]"
		[Register ("DevInfogetSafeModuleVersion_Api", "()Ljava/lang/String;", "GetDevInfogetSafeModuleVersion_ApiHandler:Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandlerInvoker, VanstonePosSdk")]
		string? DevInfogetSafeModuleVersion_Api ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/devinform/DevinformHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/devinform/DevinformHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/constructor[@name='DevinformHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_DevInfoGetAndroidKernelVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetAndroidKernelVersion_ApiHandler ()
			{
				if (cb_DevInfoGetAndroidKernelVersion_Api == null)
					cb_DevInfoGetAndroidKernelVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetAndroidKernelVersion_Api));
				return cb_DevInfoGetAndroidKernelVersion_Api;
			}

			static IntPtr n_DevInfoGetAndroidKernelVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetAndroidKernelVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetAndroidKernelVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetAndroidKernelVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidKernelVersion_ApiHandler")]
			public virtual unsafe string? DevInfoGetAndroidKernelVersion_Api ()
			{
				const string __id = "DevInfoGetAndroidKernelVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetAndroidOSVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetAndroidOSVersion_ApiHandler ()
			{
				if (cb_DevInfoGetAndroidOSVersion_Api == null)
					cb_DevInfoGetAndroidOSVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetAndroidOSVersion_Api));
				return cb_DevInfoGetAndroidOSVersion_Api;
			}

			static IntPtr n_DevInfoGetAndroidOSVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetAndroidOSVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetAndroidOSVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetAndroidOSVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidOSVersion_ApiHandler")]
			public virtual unsafe string? DevInfoGetAndroidOSVersion_Api ()
			{
				const string __id = "DevInfoGetAndroidOSVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetFirmwareVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetFirmwareVersion_ApiHandler ()
			{
				if (cb_DevInfoGetFirmwareVersion_Api == null)
					cb_DevInfoGetFirmwareVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetFirmwareVersion_Api));
				return cb_DevInfoGetFirmwareVersion_Api;
			}

			static IntPtr n_DevInfoGetFirmwareVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetFirmwareVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetFirmwareVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetFirmwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetFirmwareVersion_ApiHandler")]
			public virtual unsafe string? DevInfoGetFirmwareVersion_Api ()
			{
				const string __id = "DevInfoGetFirmwareVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetHardwareVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetHardwareVersion_ApiHandler ()
			{
				if (cb_DevInfoGetHardwareVersion_Api == null)
					cb_DevInfoGetHardwareVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetHardwareVersion_Api));
				return cb_DevInfoGetHardwareVersion_Api;
			}

			static IntPtr n_DevInfoGetHardwareVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetHardwareVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetHardwareVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetHardwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetHardwareVersion_ApiHandler")]
			public virtual unsafe string? DevInfoGetHardwareVersion_Api ()
			{
				const string __id = "DevInfoGetHardwareVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetICCID_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetICCID_ApiHandler ()
			{
				if (cb_DevInfoGetICCID_Api == null)
					cb_DevInfoGetICCID_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetICCID_Api));
				return cb_DevInfoGetICCID_Api;
			}

			static IntPtr n_DevInfoGetICCID_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetICCID_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetICCID_Api' and count(parameter)=0]"
			[Register ("DevInfoGetICCID_Api", "()Ljava/lang/String;", "GetDevInfoGetICCID_ApiHandler")]
			public virtual unsafe string? DevInfoGetICCID_Api ()
			{
				const string __id = "DevInfoGetICCID_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetIMSI_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetIMSI_ApiHandler ()
			{
				if (cb_DevInfoGetIMSI_Api == null)
					cb_DevInfoGetIMSI_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetIMSI_Api));
				return cb_DevInfoGetIMSI_Api;
			}

			static IntPtr n_DevInfoGetIMSI_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetIMSI_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetIMSI_Api' and count(parameter)=0]"
			[Register ("DevInfoGetIMSI_Api", "()Ljava/lang/String;", "GetDevInfoGetIMSI_ApiHandler")]
			public virtual unsafe string? DevInfoGetIMSI_Api ()
			{
				const string __id = "DevInfoGetIMSI_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetManufacture_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetManufacture_ApiHandler ()
			{
				if (cb_DevInfoGetManufacture_Api == null)
					cb_DevInfoGetManufacture_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetManufacture_Api));
				return cb_DevInfoGetManufacture_Api;
			}

			static IntPtr n_DevInfoGetManufacture_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetManufacture_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetManufacture_Api' and count(parameter)=0]"
			[Register ("DevInfoGetManufacture_Api", "()Ljava/lang/String;", "GetDevInfoGetManufacture_ApiHandler")]
			public virtual unsafe string? DevInfoGetManufacture_Api ()
			{
				const string __id = "DevInfoGetManufacture_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetModel_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetModel_ApiHandler ()
			{
				if (cb_DevInfoGetModel_Api == null)
					cb_DevInfoGetModel_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetModel_Api));
				return cb_DevInfoGetModel_Api;
			}

			static IntPtr n_DevInfoGetModel_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetModel_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetModel_Api' and count(parameter)=0]"
			[Register ("DevInfoGetModel_Api", "()Ljava/lang/String;", "GetDevInfoGetModel_ApiHandler")]
			public virtual unsafe string? DevInfoGetModel_Api ()
			{
				const string __id = "DevInfoGetModel_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetROMVerion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetROMVerion_ApiHandler ()
			{
				if (cb_DevInfoGetROMVerion_Api == null)
					cb_DevInfoGetROMVerion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetROMVerion_Api));
				return cb_DevInfoGetROMVerion_Api;
			}

			static IntPtr n_DevInfoGetROMVerion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetROMVerion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetROMVerion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetROMVerion_Api", "()Ljava/lang/String;", "GetDevInfoGetROMVerion_ApiHandler")]
			public virtual unsafe string? DevInfoGetROMVerion_Api ()
			{
				const string __id = "DevInfoGetROMVerion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetSETime_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetSETime_ApiHandler ()
			{
				if (cb_DevInfoGetSETime_Api == null)
					cb_DevInfoGetSETime_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_DevInfoGetSETime_Api));
				return cb_DevInfoGetSETime_Api;
			}

			static long n_DevInfoGetSETime_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DevInfoGetSETime_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetSETime_Api' and count(parameter)=0]"
			[Register ("DevInfoGetSETime_Api", "()J", "GetDevInfoGetSETime_ApiHandler")]
			public virtual unsafe long DevInfoGetSETime_Api ()
			{
				const string __id = "DevInfoGetSETime_Api.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetSerialNo_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetSerialNo_ApiHandler ()
			{
				if (cb_DevInfoGetSerialNo_Api == null)
					cb_DevInfoGetSerialNo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetSerialNo_Api));
				return cb_DevInfoGetSerialNo_Api;
			}

			static IntPtr n_DevInfoGetSerialNo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetSerialNo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetSerialNo_Api' and count(parameter)=0]"
			[Register ("DevInfoGetSerialNo_Api", "()Ljava/lang/String;", "GetDevInfoGetSerialNo_ApiHandler")]
			public virtual unsafe string? DevInfoGetSerialNo_Api ()
			{
				const string __id = "DevInfoGetSerialNo_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoGetTUSN_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetTUSN_ApiHandler ()
			{
				if (cb_DevInfoGetTUSN_Api == null)
					cb_DevInfoGetTUSN_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetTUSN_Api));
				return cb_DevInfoGetTUSN_Api;
			}

			static IntPtr n_DevInfoGetTUSN_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetTUSN_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoGetTUSN_Api' and count(parameter)=0]"
			[Register ("DevInfoGetTUSN_Api", "()Ljava/lang/String;", "GetDevInfoGetTUSN_ApiHandler")]
			public virtual unsafe string? DevInfoGetTUSN_Api ()
			{
				const string __id = "DevInfoGetTUSN_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_));
				return cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_;
			}

			static bool n_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date, IntPtr native_time)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var date = JNIEnv.GetString (native_date, JniHandleOwnership.DoNotTransfer);
				var time = JNIEnv.GetString (native_time, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DevInfoUpdateSystemTime_Api (date, time);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfoUpdateSystemTime_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("DevInfoUpdateSystemTime_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe bool DevInfoUpdateSystemTime_Api (string? date, string? time)
			{
				const string __id = "DevInfoUpdateSystemTime_Api.(Ljava/lang/String;Ljava/lang/String;)Z";
				IntPtr native_date = JNIEnv.NewString ((string?)date);
				IntPtr native_time = JNIEnv.NewString ((string?)time);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_date);
					__args [1] = new JniArgumentValue (native_time);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_date);
					JNIEnv.DeleteLocalRef (native_time);
				}
			}

			static Delegate? cb_DevInfogetSafeModuleVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfogetSafeModuleVersion_ApiHandler ()
			{
				if (cb_DevInfogetSafeModuleVersion_Api == null)
					cb_DevInfogetSafeModuleVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfogetSafeModuleVersion_Api));
				return cb_DevInfogetSafeModuleVersion_Api;
			}

			static IntPtr n_DevInfogetSafeModuleVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfogetSafeModuleVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='DevInfogetSafeModuleVersion_Api' and count(parameter)=0]"
			[Register ("DevInfogetSafeModuleVersion_Api", "()Ljava/lang/String;", "GetDevInfogetSafeModuleVersion_ApiHandler")]
			public virtual unsafe string? DevInfogetSafeModuleVersion_Api ()
			{
				const string __id = "DevInfogetSafeModuleVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/devinform/DevinformHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/devinform/DevinformHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Stub']/constructor[@name='DevinformHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/devinform/DevinformHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/devinform/DevinformHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/devinform/DevinformHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/class[@name='DevinformHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.devinform.DevinformHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/devinform/DevinformHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/devinform/DevinformHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_DevInfoGetAndroidKernelVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetAndroidKernelVersion_ApiHandler ()
			{
				if (cb_DevInfoGetAndroidKernelVersion_Api == null)
					cb_DevInfoGetAndroidKernelVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetAndroidKernelVersion_Api));
				return cb_DevInfoGetAndroidKernelVersion_Api;
			}

			static IntPtr n_DevInfoGetAndroidKernelVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetAndroidKernelVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetAndroidKernelVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetAndroidKernelVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidKernelVersion_ApiHandler")]
			public abstract string? DevInfoGetAndroidKernelVersion_Api ();

			static Delegate? cb_DevInfoGetAndroidOSVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetAndroidOSVersion_ApiHandler ()
			{
				if (cb_DevInfoGetAndroidOSVersion_Api == null)
					cb_DevInfoGetAndroidOSVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetAndroidOSVersion_Api));
				return cb_DevInfoGetAndroidOSVersion_Api;
			}

			static IntPtr n_DevInfoGetAndroidOSVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetAndroidOSVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetAndroidOSVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetAndroidOSVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidOSVersion_ApiHandler")]
			public abstract string? DevInfoGetAndroidOSVersion_Api ();

			static Delegate? cb_DevInfoGetFirmwareVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetFirmwareVersion_ApiHandler ()
			{
				if (cb_DevInfoGetFirmwareVersion_Api == null)
					cb_DevInfoGetFirmwareVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetFirmwareVersion_Api));
				return cb_DevInfoGetFirmwareVersion_Api;
			}

			static IntPtr n_DevInfoGetFirmwareVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetFirmwareVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetFirmwareVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetFirmwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetFirmwareVersion_ApiHandler")]
			public abstract string? DevInfoGetFirmwareVersion_Api ();

			static Delegate? cb_DevInfoGetHardwareVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetHardwareVersion_ApiHandler ()
			{
				if (cb_DevInfoGetHardwareVersion_Api == null)
					cb_DevInfoGetHardwareVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetHardwareVersion_Api));
				return cb_DevInfoGetHardwareVersion_Api;
			}

			static IntPtr n_DevInfoGetHardwareVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetHardwareVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetHardwareVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetHardwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetHardwareVersion_ApiHandler")]
			public abstract string? DevInfoGetHardwareVersion_Api ();

			static Delegate? cb_DevInfoGetICCID_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetICCID_ApiHandler ()
			{
				if (cb_DevInfoGetICCID_Api == null)
					cb_DevInfoGetICCID_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetICCID_Api));
				return cb_DevInfoGetICCID_Api;
			}

			static IntPtr n_DevInfoGetICCID_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetICCID_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetICCID_Api' and count(parameter)=0]"
			[Register ("DevInfoGetICCID_Api", "()Ljava/lang/String;", "GetDevInfoGetICCID_ApiHandler")]
			public abstract string? DevInfoGetICCID_Api ();

			static Delegate? cb_DevInfoGetIMSI_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetIMSI_ApiHandler ()
			{
				if (cb_DevInfoGetIMSI_Api == null)
					cb_DevInfoGetIMSI_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetIMSI_Api));
				return cb_DevInfoGetIMSI_Api;
			}

			static IntPtr n_DevInfoGetIMSI_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetIMSI_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetIMSI_Api' and count(parameter)=0]"
			[Register ("DevInfoGetIMSI_Api", "()Ljava/lang/String;", "GetDevInfoGetIMSI_ApiHandler")]
			public abstract string? DevInfoGetIMSI_Api ();

			static Delegate? cb_DevInfoGetManufacture_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetManufacture_ApiHandler ()
			{
				if (cb_DevInfoGetManufacture_Api == null)
					cb_DevInfoGetManufacture_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetManufacture_Api));
				return cb_DevInfoGetManufacture_Api;
			}

			static IntPtr n_DevInfoGetManufacture_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetManufacture_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetManufacture_Api' and count(parameter)=0]"
			[Register ("DevInfoGetManufacture_Api", "()Ljava/lang/String;", "GetDevInfoGetManufacture_ApiHandler")]
			public abstract string? DevInfoGetManufacture_Api ();

			static Delegate? cb_DevInfoGetModel_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetModel_ApiHandler ()
			{
				if (cb_DevInfoGetModel_Api == null)
					cb_DevInfoGetModel_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetModel_Api));
				return cb_DevInfoGetModel_Api;
			}

			static IntPtr n_DevInfoGetModel_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetModel_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetModel_Api' and count(parameter)=0]"
			[Register ("DevInfoGetModel_Api", "()Ljava/lang/String;", "GetDevInfoGetModel_ApiHandler")]
			public abstract string? DevInfoGetModel_Api ();

			static Delegate? cb_DevInfoGetROMVerion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetROMVerion_ApiHandler ()
			{
				if (cb_DevInfoGetROMVerion_Api == null)
					cb_DevInfoGetROMVerion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetROMVerion_Api));
				return cb_DevInfoGetROMVerion_Api;
			}

			static IntPtr n_DevInfoGetROMVerion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetROMVerion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetROMVerion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetROMVerion_Api", "()Ljava/lang/String;", "GetDevInfoGetROMVerion_ApiHandler")]
			public abstract string? DevInfoGetROMVerion_Api ();

			static Delegate? cb_DevInfoGetSETime_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetSETime_ApiHandler ()
			{
				if (cb_DevInfoGetSETime_Api == null)
					cb_DevInfoGetSETime_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_DevInfoGetSETime_Api));
				return cb_DevInfoGetSETime_Api;
			}

			static long n_DevInfoGetSETime_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DevInfoGetSETime_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetSETime_Api' and count(parameter)=0]"
			[Register ("DevInfoGetSETime_Api", "()J", "GetDevInfoGetSETime_ApiHandler")]
			public abstract long DevInfoGetSETime_Api ();

			static Delegate? cb_DevInfoGetSerialNo_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetSerialNo_ApiHandler ()
			{
				if (cb_DevInfoGetSerialNo_Api == null)
					cb_DevInfoGetSerialNo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetSerialNo_Api));
				return cb_DevInfoGetSerialNo_Api;
			}

			static IntPtr n_DevInfoGetSerialNo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetSerialNo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetSerialNo_Api' and count(parameter)=0]"
			[Register ("DevInfoGetSerialNo_Api", "()Ljava/lang/String;", "GetDevInfoGetSerialNo_ApiHandler")]
			public abstract string? DevInfoGetSerialNo_Api ();

			static Delegate? cb_DevInfoGetTUSN_Api;
#pragma warning disable 0169
			static Delegate GetDevInfoGetTUSN_ApiHandler ()
			{
				if (cb_DevInfoGetTUSN_Api == null)
					cb_DevInfoGetTUSN_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetTUSN_Api));
				return cb_DevInfoGetTUSN_Api;
			}

			static IntPtr n_DevInfoGetTUSN_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfoGetTUSN_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetTUSN_Api' and count(parameter)=0]"
			[Register ("DevInfoGetTUSN_Api", "()Ljava/lang/String;", "GetDevInfoGetTUSN_ApiHandler")]
			public abstract string? DevInfoGetTUSN_Api ();

			static Delegate? cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_));
				return cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_;
			}

			static bool n_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DevInfoUpdateSystemTime_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoUpdateSystemTime_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("DevInfoUpdateSystemTime_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public abstract bool DevInfoUpdateSystemTime_Api (string? p0, string? p1);

			static Delegate? cb_DevInfogetSafeModuleVersion_Api;
#pragma warning disable 0169
			static Delegate GetDevInfogetSafeModuleVersion_ApiHandler ()
			{
				if (cb_DevInfogetSafeModuleVersion_Api == null)
					cb_DevInfogetSafeModuleVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfogetSafeModuleVersion_Api));
				return cb_DevInfogetSafeModuleVersion_Api;
			}

			static IntPtr n_DevInfogetSafeModuleVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DevInfogetSafeModuleVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfogetSafeModuleVersion_Api' and count(parameter)=0]"
			[Register ("DevInfogetSafeModuleVersion_Api", "()Ljava/lang/String;", "GetDevInfogetSafeModuleVersion_ApiHandler")]
			public abstract string? DevInfogetSafeModuleVersion_Api ();

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/devinform/DevinformHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/devinform/DevinformHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetAndroidKernelVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetAndroidKernelVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidKernelVersion_ApiHandler")]
			public override unsafe string? DevInfoGetAndroidKernelVersion_Api ()
			{
				const string __id = "DevInfoGetAndroidKernelVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetAndroidOSVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetAndroidOSVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetAndroidOSVersion_ApiHandler")]
			public override unsafe string? DevInfoGetAndroidOSVersion_Api ()
			{
				const string __id = "DevInfoGetAndroidOSVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetFirmwareVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetFirmwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetFirmwareVersion_ApiHandler")]
			public override unsafe string? DevInfoGetFirmwareVersion_Api ()
			{
				const string __id = "DevInfoGetFirmwareVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetHardwareVersion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetHardwareVersion_Api", "()Ljava/lang/String;", "GetDevInfoGetHardwareVersion_ApiHandler")]
			public override unsafe string? DevInfoGetHardwareVersion_Api ()
			{
				const string __id = "DevInfoGetHardwareVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetICCID_Api' and count(parameter)=0]"
			[Register ("DevInfoGetICCID_Api", "()Ljava/lang/String;", "GetDevInfoGetICCID_ApiHandler")]
			public override unsafe string? DevInfoGetICCID_Api ()
			{
				const string __id = "DevInfoGetICCID_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetIMSI_Api' and count(parameter)=0]"
			[Register ("DevInfoGetIMSI_Api", "()Ljava/lang/String;", "GetDevInfoGetIMSI_ApiHandler")]
			public override unsafe string? DevInfoGetIMSI_Api ()
			{
				const string __id = "DevInfoGetIMSI_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetManufacture_Api' and count(parameter)=0]"
			[Register ("DevInfoGetManufacture_Api", "()Ljava/lang/String;", "GetDevInfoGetManufacture_ApiHandler")]
			public override unsafe string? DevInfoGetManufacture_Api ()
			{
				const string __id = "DevInfoGetManufacture_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetModel_Api' and count(parameter)=0]"
			[Register ("DevInfoGetModel_Api", "()Ljava/lang/String;", "GetDevInfoGetModel_ApiHandler")]
			public override unsafe string? DevInfoGetModel_Api ()
			{
				const string __id = "DevInfoGetModel_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetROMVerion_Api' and count(parameter)=0]"
			[Register ("DevInfoGetROMVerion_Api", "()Ljava/lang/String;", "GetDevInfoGetROMVerion_ApiHandler")]
			public override unsafe string? DevInfoGetROMVerion_Api ()
			{
				const string __id = "DevInfoGetROMVerion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetSETime_Api' and count(parameter)=0]"
			[Register ("DevInfoGetSETime_Api", "()J", "GetDevInfoGetSETime_ApiHandler")]
			public override unsafe long DevInfoGetSETime_Api ()
			{
				const string __id = "DevInfoGetSETime_Api.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetSerialNo_Api' and count(parameter)=0]"
			[Register ("DevInfoGetSerialNo_Api", "()Ljava/lang/String;", "GetDevInfoGetSerialNo_ApiHandler")]
			public override unsafe string? DevInfoGetSerialNo_Api ()
			{
				const string __id = "DevInfoGetSerialNo_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoGetTUSN_Api' and count(parameter)=0]"
			[Register ("DevInfoGetTUSN_Api", "()Ljava/lang/String;", "GetDevInfoGetTUSN_ApiHandler")]
			public override unsafe string? DevInfoGetTUSN_Api ()
			{
				const string __id = "DevInfoGetTUSN_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfoUpdateSystemTime_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("DevInfoUpdateSystemTime_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public override unsafe bool DevInfoUpdateSystemTime_Api (string? p0, string? p1)
			{
				const string __id = "DevInfoUpdateSystemTime_Api.(Ljava/lang/String;Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.devinform']/interface[@name='DevinformHandler']/method[@name='DevInfogetSafeModuleVersion_Api' and count(parameter)=0]"
			[Register ("DevInfogetSafeModuleVersion_Api", "()Ljava/lang/String;", "GetDevInfogetSafeModuleVersion_ApiHandler")]
			public override unsafe string? DevInfogetSafeModuleVersion_Api ()
			{
				const string __id = "DevInfogetSafeModuleVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/devinform/DevinformHandler", DoNotGenerateAcw=true)]
	internal partial class IDevinformHandlerInvoker : global::Java.Lang.Object, IDevinformHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/devinform/DevinformHandler", typeof (IDevinformHandlerInvoker));

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

		public static IDevinformHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDevinformHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.devinform.DevinformHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDevinformHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_DevInfoGetAndroidKernelVersion_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetAndroidKernelVersion_ApiHandler ()
		{
			if (cb_DevInfoGetAndroidKernelVersion_Api == null)
				cb_DevInfoGetAndroidKernelVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetAndroidKernelVersion_Api));
			return cb_DevInfoGetAndroidKernelVersion_Api;
		}

		static IntPtr n_DevInfoGetAndroidKernelVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetAndroidKernelVersion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetAndroidKernelVersion_Api;
		public unsafe string? DevInfoGetAndroidKernelVersion_Api ()
		{
			if (id_DevInfoGetAndroidKernelVersion_Api == IntPtr.Zero)
				id_DevInfoGetAndroidKernelVersion_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetAndroidKernelVersion_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetAndroidKernelVersion_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetAndroidOSVersion_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetAndroidOSVersion_ApiHandler ()
		{
			if (cb_DevInfoGetAndroidOSVersion_Api == null)
				cb_DevInfoGetAndroidOSVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetAndroidOSVersion_Api));
			return cb_DevInfoGetAndroidOSVersion_Api;
		}

		static IntPtr n_DevInfoGetAndroidOSVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetAndroidOSVersion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetAndroidOSVersion_Api;
		public unsafe string? DevInfoGetAndroidOSVersion_Api ()
		{
			if (id_DevInfoGetAndroidOSVersion_Api == IntPtr.Zero)
				id_DevInfoGetAndroidOSVersion_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetAndroidOSVersion_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetAndroidOSVersion_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetFirmwareVersion_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetFirmwareVersion_ApiHandler ()
		{
			if (cb_DevInfoGetFirmwareVersion_Api == null)
				cb_DevInfoGetFirmwareVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetFirmwareVersion_Api));
			return cb_DevInfoGetFirmwareVersion_Api;
		}

		static IntPtr n_DevInfoGetFirmwareVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetFirmwareVersion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetFirmwareVersion_Api;
		public unsafe string? DevInfoGetFirmwareVersion_Api ()
		{
			if (id_DevInfoGetFirmwareVersion_Api == IntPtr.Zero)
				id_DevInfoGetFirmwareVersion_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetFirmwareVersion_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetFirmwareVersion_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetHardwareVersion_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetHardwareVersion_ApiHandler ()
		{
			if (cb_DevInfoGetHardwareVersion_Api == null)
				cb_DevInfoGetHardwareVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetHardwareVersion_Api));
			return cb_DevInfoGetHardwareVersion_Api;
		}

		static IntPtr n_DevInfoGetHardwareVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetHardwareVersion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetHardwareVersion_Api;
		public unsafe string? DevInfoGetHardwareVersion_Api ()
		{
			if (id_DevInfoGetHardwareVersion_Api == IntPtr.Zero)
				id_DevInfoGetHardwareVersion_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetHardwareVersion_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetHardwareVersion_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetICCID_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetICCID_ApiHandler ()
		{
			if (cb_DevInfoGetICCID_Api == null)
				cb_DevInfoGetICCID_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetICCID_Api));
			return cb_DevInfoGetICCID_Api;
		}

		static IntPtr n_DevInfoGetICCID_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetICCID_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetICCID_Api;
		public unsafe string? DevInfoGetICCID_Api ()
		{
			if (id_DevInfoGetICCID_Api == IntPtr.Zero)
				id_DevInfoGetICCID_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetICCID_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetICCID_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetIMSI_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetIMSI_ApiHandler ()
		{
			if (cb_DevInfoGetIMSI_Api == null)
				cb_DevInfoGetIMSI_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetIMSI_Api));
			return cb_DevInfoGetIMSI_Api;
		}

		static IntPtr n_DevInfoGetIMSI_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetIMSI_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetIMSI_Api;
		public unsafe string? DevInfoGetIMSI_Api ()
		{
			if (id_DevInfoGetIMSI_Api == IntPtr.Zero)
				id_DevInfoGetIMSI_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetIMSI_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetIMSI_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetManufacture_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetManufacture_ApiHandler ()
		{
			if (cb_DevInfoGetManufacture_Api == null)
				cb_DevInfoGetManufacture_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetManufacture_Api));
			return cb_DevInfoGetManufacture_Api;
		}

		static IntPtr n_DevInfoGetManufacture_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetManufacture_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetManufacture_Api;
		public unsafe string? DevInfoGetManufacture_Api ()
		{
			if (id_DevInfoGetManufacture_Api == IntPtr.Zero)
				id_DevInfoGetManufacture_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetManufacture_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetManufacture_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetModel_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetModel_ApiHandler ()
		{
			if (cb_DevInfoGetModel_Api == null)
				cb_DevInfoGetModel_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetModel_Api));
			return cb_DevInfoGetModel_Api;
		}

		static IntPtr n_DevInfoGetModel_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetModel_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetModel_Api;
		public unsafe string? DevInfoGetModel_Api ()
		{
			if (id_DevInfoGetModel_Api == IntPtr.Zero)
				id_DevInfoGetModel_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetModel_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetModel_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetROMVerion_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetROMVerion_ApiHandler ()
		{
			if (cb_DevInfoGetROMVerion_Api == null)
				cb_DevInfoGetROMVerion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetROMVerion_Api));
			return cb_DevInfoGetROMVerion_Api;
		}

		static IntPtr n_DevInfoGetROMVerion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetROMVerion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetROMVerion_Api;
		public unsafe string? DevInfoGetROMVerion_Api ()
		{
			if (id_DevInfoGetROMVerion_Api == IntPtr.Zero)
				id_DevInfoGetROMVerion_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetROMVerion_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetROMVerion_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetSETime_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetSETime_ApiHandler ()
		{
			if (cb_DevInfoGetSETime_Api == null)
				cb_DevInfoGetSETime_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_DevInfoGetSETime_Api));
			return cb_DevInfoGetSETime_Api;
		}

		static long n_DevInfoGetSETime_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DevInfoGetSETime_Api ();
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetSETime_Api;
		public unsafe long DevInfoGetSETime_Api ()
		{
			if (id_DevInfoGetSETime_Api == IntPtr.Zero)
				id_DevInfoGetSETime_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetSETime_Api", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetSETime_Api);
		}

		static Delegate? cb_DevInfoGetSerialNo_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetSerialNo_ApiHandler ()
		{
			if (cb_DevInfoGetSerialNo_Api == null)
				cb_DevInfoGetSerialNo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetSerialNo_Api));
			return cb_DevInfoGetSerialNo_Api;
		}

		static IntPtr n_DevInfoGetSerialNo_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetSerialNo_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetSerialNo_Api;
		public unsafe string? DevInfoGetSerialNo_Api ()
		{
			if (id_DevInfoGetSerialNo_Api == IntPtr.Zero)
				id_DevInfoGetSerialNo_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetSerialNo_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetSerialNo_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoGetTUSN_Api;
#pragma warning disable 0169
		static Delegate GetDevInfoGetTUSN_ApiHandler ()
		{
			if (cb_DevInfoGetTUSN_Api == null)
				cb_DevInfoGetTUSN_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfoGetTUSN_Api));
			return cb_DevInfoGetTUSN_Api;
		}

		static IntPtr n_DevInfoGetTUSN_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfoGetTUSN_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfoGetTUSN_Api;
		public unsafe string? DevInfoGetTUSN_Api ()
		{
			if (id_DevInfoGetTUSN_Api == IntPtr.Zero)
				id_DevInfoGetTUSN_Api = JNIEnv.GetMethodID (class_ref, "DevInfoGetTUSN_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoGetTUSN_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_));
			return cb_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DevInfoUpdateSystemTime_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool DevInfoUpdateSystemTime_Api (string? p0, string? p1)
		{
			if (id_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "DevInfoUpdateSystemTime_Api", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_DevInfoUpdateSystemTime_Api_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_DevInfogetSafeModuleVersion_Api;
#pragma warning disable 0169
		static Delegate GetDevInfogetSafeModuleVersion_ApiHandler ()
		{
			if (cb_DevInfogetSafeModuleVersion_Api == null)
				cb_DevInfogetSafeModuleVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DevInfogetSafeModuleVersion_Api));
			return cb_DevInfogetSafeModuleVersion_Api;
		}

		static IntPtr n_DevInfogetSafeModuleVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DevInfogetSafeModuleVersion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DevInfogetSafeModuleVersion_Api;
		public unsafe string? DevInfogetSafeModuleVersion_Api ()
		{
			if (id_DevInfogetSafeModuleVersion_Api == IntPtr.Zero)
				id_DevInfogetSafeModuleVersion_Api = JNIEnv.GetMethodID (class_ref, "DevInfogetSafeModuleVersion_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DevInfogetSafeModuleVersion_Api), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Devinform.IDevinformHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
