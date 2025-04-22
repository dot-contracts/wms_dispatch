using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.NLDeviceScan {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']"
	[Register ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler", "", "Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker")]
	public partial interface INLDeviceScanHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLGetSdkVersion_Api' and count(parameter)=0]"
		[Register ("NLGetSdkVersion_Api", "()Ljava/lang/String;", "GetNLGetSdkVersion_ApiHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		string? NLGetSdkVersion_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.NLDataListenerResultAIDL']]"
		[Register ("NLOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/NLDataListenerResultAIDL;)V", "GetNLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_Handler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		void NLOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLclose_Api' and count(parameter)=0]"
		[Register ("NLclose_Api", "()V", "GetNLclose_ApiHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		void NLclose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLgetDeviceInformation_Api' and count(parameter)=0]"
		[Register ("NLgetDeviceInformation_Api", "()Ljava/lang/String;", "GetNLgetDeviceInformation_ApiHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		string? NLgetDeviceInformation_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLreboot_Api' and count(parameter)=0]"
		[Register ("NLreboot_Api", "()V", "GetNLreboot_ApiHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		void NLreboot_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetAudio_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("NLsetAudio_Api", "(Z)V", "GetNLsetAudio_Api_ZHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		void NLsetAudio_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetScanMode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NLsetScanMode_Api", "(I)V", "GetNLsetScanMode_Api_IHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		void NLsetScanMode_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetTimeOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NLsetTimeOut_Api", "(I)Z", "GetNLsetTimeOut_Api_IHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		bool NLsetTimeOut_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLstartScan_Api' and count(parameter)=0]"
		[Register ("NLstartScan_Api", "()V", "GetNLstartScan_ApiHandler:Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandlerInvoker, VanstonePosSdk")]
		void NLstartScan_Api ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/constructor[@name='NLDeviceScanHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_NLGetSdkVersion_Api;
#pragma warning disable 0169
			static Delegate GetNLGetSdkVersion_ApiHandler ()
			{
				if (cb_NLGetSdkVersion_Api == null)
					cb_NLGetSdkVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NLGetSdkVersion_Api));
				return cb_NLGetSdkVersion_Api;
			}

			static IntPtr n_NLGetSdkVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.NLGetSdkVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLGetSdkVersion_Api' and count(parameter)=0]"
			[Register ("NLGetSdkVersion_Api", "()Ljava/lang/String;", "GetNLGetSdkVersion_ApiHandler")]
			public virtual unsafe string? NLGetSdkVersion_Api ()
			{
				const string __id = "NLGetSdkVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_;
#pragma warning disable 0169
			static Delegate GetNLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_Handler ()
			{
				if (cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ == null)
					cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_));
				return cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_;
			}

			static void n_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				__this.NLOpen_Api (listener);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.NLDataListenerResultAIDL']]"
			[Register ("NLOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/NLDataListenerResultAIDL;)V", "GetNLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_Handler")]
			public virtual unsafe void NLOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL? listener)
			{
				const string __id = "NLOpen_Api.(Lcom/vanstone/appsdk/api/interfaces/NLDataListenerResultAIDL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_NLclose_Api;
#pragma warning disable 0169
			static Delegate GetNLclose_ApiHandler ()
			{
				if (cb_NLclose_Api == null)
					cb_NLclose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLclose_Api));
				return cb_NLclose_Api;
			}

			static void n_NLclose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLclose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLclose_Api' and count(parameter)=0]"
			[Register ("NLclose_Api", "()V", "GetNLclose_ApiHandler")]
			public virtual unsafe void NLclose_Api ()
			{
				const string __id = "NLclose_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_NLgetDeviceInformation_Api;
#pragma warning disable 0169
			static Delegate GetNLgetDeviceInformation_ApiHandler ()
			{
				if (cb_NLgetDeviceInformation_Api == null)
					cb_NLgetDeviceInformation_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NLgetDeviceInformation_Api));
				return cb_NLgetDeviceInformation_Api;
			}

			static IntPtr n_NLgetDeviceInformation_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.NLgetDeviceInformation_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLgetDeviceInformation_Api' and count(parameter)=0]"
			[Register ("NLgetDeviceInformation_Api", "()Ljava/lang/String;", "GetNLgetDeviceInformation_ApiHandler")]
			public virtual unsafe string? NLgetDeviceInformation_Api ()
			{
				const string __id = "NLgetDeviceInformation_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_NLreboot_Api;
#pragma warning disable 0169
			static Delegate GetNLreboot_ApiHandler ()
			{
				if (cb_NLreboot_Api == null)
					cb_NLreboot_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLreboot_Api));
				return cb_NLreboot_Api;
			}

			static void n_NLreboot_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLreboot_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLreboot_Api' and count(parameter)=0]"
			[Register ("NLreboot_Api", "()V", "GetNLreboot_ApiHandler")]
			public virtual unsafe void NLreboot_Api ()
			{
				const string __id = "NLreboot_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_NLsetAudio_Api_Z;
#pragma warning disable 0169
			static Delegate GetNLsetAudio_Api_ZHandler ()
			{
				if (cb_NLsetAudio_Api_Z == null)
					cb_NLsetAudio_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_NLsetAudio_Api_Z));
				return cb_NLsetAudio_Api_Z;
			}

			static void n_NLsetAudio_Api_Z (IntPtr jnienv, IntPtr native__this, bool audio)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLsetAudio_Api (audio);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLsetAudio_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("NLsetAudio_Api", "(Z)V", "GetNLsetAudio_Api_ZHandler")]
			public virtual unsafe void NLsetAudio_Api (bool audio)
			{
				const string __id = "NLsetAudio_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (audio);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_NLsetScanMode_Api_I;
#pragma warning disable 0169
			static Delegate GetNLsetScanMode_Api_IHandler ()
			{
				if (cb_NLsetScanMode_Api_I == null)
					cb_NLsetScanMode_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_NLsetScanMode_Api_I));
				return cb_NLsetScanMode_Api_I;
			}

			static void n_NLsetScanMode_Api_I (IntPtr jnienv, IntPtr native__this, int mode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLsetScanMode_Api (mode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLsetScanMode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("NLsetScanMode_Api", "(I)V", "GetNLsetScanMode_Api_IHandler")]
			public virtual unsafe void NLsetScanMode_Api (int mode)
			{
				const string __id = "NLsetScanMode_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (mode);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_NLsetTimeOut_Api_I;
#pragma warning disable 0169
			static Delegate GetNLsetTimeOut_Api_IHandler ()
			{
				if (cb_NLsetTimeOut_Api_I == null)
					cb_NLsetTimeOut_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_NLsetTimeOut_Api_I));
				return cb_NLsetTimeOut_Api_I;
			}

			static bool n_NLsetTimeOut_Api_I (IntPtr jnienv, IntPtr native__this, int timeout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NLsetTimeOut_Api (timeout);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLsetTimeOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("NLsetTimeOut_Api", "(I)Z", "GetNLsetTimeOut_Api_IHandler")]
			public virtual unsafe bool NLsetTimeOut_Api (int timeout)
			{
				const string __id = "NLsetTimeOut_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_NLstartScan_Api;
#pragma warning disable 0169
			static Delegate GetNLstartScan_ApiHandler ()
			{
				if (cb_NLstartScan_Api == null)
					cb_NLstartScan_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLstartScan_Api));
				return cb_NLstartScan_Api;
			}

			static void n_NLstartScan_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLstartScan_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='NLstartScan_Api' and count(parameter)=0]"
			[Register ("NLstartScan_Api", "()V", "GetNLstartScan_ApiHandler")]
			public virtual unsafe void NLstartScan_Api ()
			{
				const string __id = "NLstartScan_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Stub']/constructor[@name='NLDeviceScanHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/class[@name='NLDeviceScanHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.NLDeviceScan.NLDeviceScanHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_NLGetSdkVersion_Api;
#pragma warning disable 0169
			static Delegate GetNLGetSdkVersion_ApiHandler ()
			{
				if (cb_NLGetSdkVersion_Api == null)
					cb_NLGetSdkVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NLGetSdkVersion_Api));
				return cb_NLGetSdkVersion_Api;
			}

			static IntPtr n_NLGetSdkVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.NLGetSdkVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLGetSdkVersion_Api' and count(parameter)=0]"
			[Register ("NLGetSdkVersion_Api", "()Ljava/lang/String;", "GetNLGetSdkVersion_ApiHandler")]
			public abstract string? NLGetSdkVersion_Api ();

			static Delegate? cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_;
#pragma warning disable 0169
			static Delegate GetNLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_Handler ()
			{
				if (cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ == null)
					cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_));
				return cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_;
			}

			static void n_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NLOpen_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.NLDataListenerResultAIDL']]"
			[Register ("NLOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/NLDataListenerResultAIDL;)V", "GetNLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_Handler")]
			public abstract void NLOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL? p0);

			static Delegate? cb_NLclose_Api;
#pragma warning disable 0169
			static Delegate GetNLclose_ApiHandler ()
			{
				if (cb_NLclose_Api == null)
					cb_NLclose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLclose_Api));
				return cb_NLclose_Api;
			}

			static void n_NLclose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLclose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLclose_Api' and count(parameter)=0]"
			[Register ("NLclose_Api", "()V", "GetNLclose_ApiHandler")]
			public abstract void NLclose_Api ();

			static Delegate? cb_NLgetDeviceInformation_Api;
#pragma warning disable 0169
			static Delegate GetNLgetDeviceInformation_ApiHandler ()
			{
				if (cb_NLgetDeviceInformation_Api == null)
					cb_NLgetDeviceInformation_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NLgetDeviceInformation_Api));
				return cb_NLgetDeviceInformation_Api;
			}

			static IntPtr n_NLgetDeviceInformation_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.NLgetDeviceInformation_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLgetDeviceInformation_Api' and count(parameter)=0]"
			[Register ("NLgetDeviceInformation_Api", "()Ljava/lang/String;", "GetNLgetDeviceInformation_ApiHandler")]
			public abstract string? NLgetDeviceInformation_Api ();

			static Delegate? cb_NLreboot_Api;
#pragma warning disable 0169
			static Delegate GetNLreboot_ApiHandler ()
			{
				if (cb_NLreboot_Api == null)
					cb_NLreboot_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLreboot_Api));
				return cb_NLreboot_Api;
			}

			static void n_NLreboot_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLreboot_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLreboot_Api' and count(parameter)=0]"
			[Register ("NLreboot_Api", "()V", "GetNLreboot_ApiHandler")]
			public abstract void NLreboot_Api ();

			static Delegate? cb_NLsetAudio_Api_Z;
#pragma warning disable 0169
			static Delegate GetNLsetAudio_Api_ZHandler ()
			{
				if (cb_NLsetAudio_Api_Z == null)
					cb_NLsetAudio_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_NLsetAudio_Api_Z));
				return cb_NLsetAudio_Api_Z;
			}

			static void n_NLsetAudio_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLsetAudio_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetAudio_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("NLsetAudio_Api", "(Z)V", "GetNLsetAudio_Api_ZHandler")]
			public abstract void NLsetAudio_Api (bool p0);

			static Delegate? cb_NLsetScanMode_Api_I;
#pragma warning disable 0169
			static Delegate GetNLsetScanMode_Api_IHandler ()
			{
				if (cb_NLsetScanMode_Api_I == null)
					cb_NLsetScanMode_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_NLsetScanMode_Api_I));
				return cb_NLsetScanMode_Api_I;
			}

			static void n_NLsetScanMode_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLsetScanMode_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetScanMode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("NLsetScanMode_Api", "(I)V", "GetNLsetScanMode_Api_IHandler")]
			public abstract void NLsetScanMode_Api (int p0);

			static Delegate? cb_NLsetTimeOut_Api_I;
#pragma warning disable 0169
			static Delegate GetNLsetTimeOut_Api_IHandler ()
			{
				if (cb_NLsetTimeOut_Api_I == null)
					cb_NLsetTimeOut_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_NLsetTimeOut_Api_I));
				return cb_NLsetTimeOut_Api_I;
			}

			static bool n_NLsetTimeOut_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NLsetTimeOut_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetTimeOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("NLsetTimeOut_Api", "(I)Z", "GetNLsetTimeOut_Api_IHandler")]
			public abstract bool NLsetTimeOut_Api (int p0);

			static Delegate? cb_NLstartScan_Api;
#pragma warning disable 0169
			static Delegate GetNLstartScan_ApiHandler ()
			{
				if (cb_NLstartScan_Api == null)
					cb_NLstartScan_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLstartScan_Api));
				return cb_NLstartScan_Api;
			}

			static void n_NLstartScan_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NLstartScan_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLstartScan_Api' and count(parameter)=0]"
			[Register ("NLstartScan_Api", "()V", "GetNLstartScan_ApiHandler")]
			public abstract void NLstartScan_Api ();

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLGetSdkVersion_Api' and count(parameter)=0]"
			[Register ("NLGetSdkVersion_Api", "()Ljava/lang/String;", "GetNLGetSdkVersion_ApiHandler")]
			public override unsafe string? NLGetSdkVersion_Api ()
			{
				const string __id = "NLGetSdkVersion_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.NLDataListenerResultAIDL']]"
			[Register ("NLOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/NLDataListenerResultAIDL;)V", "GetNLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_Handler")]
			public override unsafe void NLOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL? p0)
			{
				const string __id = "NLOpen_Api.(Lcom/vanstone/appsdk/api/interfaces/NLDataListenerResultAIDL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLclose_Api' and count(parameter)=0]"
			[Register ("NLclose_Api", "()V", "GetNLclose_ApiHandler")]
			public override unsafe void NLclose_Api ()
			{
				const string __id = "NLclose_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLgetDeviceInformation_Api' and count(parameter)=0]"
			[Register ("NLgetDeviceInformation_Api", "()Ljava/lang/String;", "GetNLgetDeviceInformation_ApiHandler")]
			public override unsafe string? NLgetDeviceInformation_Api ()
			{
				const string __id = "NLgetDeviceInformation_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLreboot_Api' and count(parameter)=0]"
			[Register ("NLreboot_Api", "()V", "GetNLreboot_ApiHandler")]
			public override unsafe void NLreboot_Api ()
			{
				const string __id = "NLreboot_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetAudio_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("NLsetAudio_Api", "(Z)V", "GetNLsetAudio_Api_ZHandler")]
			public override unsafe void NLsetAudio_Api (bool p0)
			{
				const string __id = "NLsetAudio_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetScanMode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("NLsetScanMode_Api", "(I)V", "GetNLsetScanMode_Api_IHandler")]
			public override unsafe void NLsetScanMode_Api (int p0)
			{
				const string __id = "NLsetScanMode_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLsetTimeOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("NLsetTimeOut_Api", "(I)Z", "GetNLsetTimeOut_Api_IHandler")]
			public override unsafe bool NLsetTimeOut_Api (int p0)
			{
				const string __id = "NLsetTimeOut_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.NLDeviceScan']/interface[@name='NLDeviceScanHandler']/method[@name='NLstartScan_Api' and count(parameter)=0]"
			[Register ("NLstartScan_Api", "()V", "GetNLstartScan_ApiHandler")]
			public override unsafe void NLstartScan_Api ()
			{
				const string __id = "NLstartScan_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler", DoNotGenerateAcw=true)]
	internal partial class INLDeviceScanHandlerInvoker : global::Java.Lang.Object, INLDeviceScanHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/NLDeviceScan/NLDeviceScanHandler", typeof (INLDeviceScanHandlerInvoker));

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

		public static INLDeviceScanHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INLDeviceScanHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.NLDeviceScan.NLDeviceScanHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INLDeviceScanHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_NLGetSdkVersion_Api;
#pragma warning disable 0169
		static Delegate GetNLGetSdkVersion_ApiHandler ()
		{
			if (cb_NLGetSdkVersion_Api == null)
				cb_NLGetSdkVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NLGetSdkVersion_Api));
			return cb_NLGetSdkVersion_Api;
		}

		static IntPtr n_NLGetSdkVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.NLGetSdkVersion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_NLGetSdkVersion_Api;
		public unsafe string? NLGetSdkVersion_Api ()
		{
			if (id_NLGetSdkVersion_Api == IntPtr.Zero)
				id_NLGetSdkVersion_Api = JNIEnv.GetMethodID (class_ref, "NLGetSdkVersion_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_NLGetSdkVersion_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_;
#pragma warning disable 0169
		static Delegate GetNLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_Handler ()
		{
			if (cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ == null)
				cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_));
			return cb_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_;
		}

		static void n_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NLOpen_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_;
		public unsafe void NLOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INLDataListenerResultAIDL? p0)
		{
			if (id_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ == IntPtr.Zero)
				id_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_ = JNIEnv.GetMethodID (class_ref, "NLOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/NLDataListenerResultAIDL;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NLOpen_Api_Lcom_vanstone_appsdk_api_interfaces_NLDataListenerResultAIDL_, __args);
		}

		static Delegate? cb_NLclose_Api;
#pragma warning disable 0169
		static Delegate GetNLclose_ApiHandler ()
		{
			if (cb_NLclose_Api == null)
				cb_NLclose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLclose_Api));
			return cb_NLclose_Api;
		}

		static void n_NLclose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.NLclose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_NLclose_Api;
		public unsafe void NLclose_Api ()
		{
			if (id_NLclose_Api == IntPtr.Zero)
				id_NLclose_Api = JNIEnv.GetMethodID (class_ref, "NLclose_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NLclose_Api);
		}

		static Delegate? cb_NLgetDeviceInformation_Api;
#pragma warning disable 0169
		static Delegate GetNLgetDeviceInformation_ApiHandler ()
		{
			if (cb_NLgetDeviceInformation_Api == null)
				cb_NLgetDeviceInformation_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_NLgetDeviceInformation_Api));
			return cb_NLgetDeviceInformation_Api;
		}

		static IntPtr n_NLgetDeviceInformation_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.NLgetDeviceInformation_Api ());
		}
#pragma warning restore 0169

		IntPtr id_NLgetDeviceInformation_Api;
		public unsafe string? NLgetDeviceInformation_Api ()
		{
			if (id_NLgetDeviceInformation_Api == IntPtr.Zero)
				id_NLgetDeviceInformation_Api = JNIEnv.GetMethodID (class_ref, "NLgetDeviceInformation_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_NLgetDeviceInformation_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_NLreboot_Api;
#pragma warning disable 0169
		static Delegate GetNLreboot_ApiHandler ()
		{
			if (cb_NLreboot_Api == null)
				cb_NLreboot_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLreboot_Api));
			return cb_NLreboot_Api;
		}

		static void n_NLreboot_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.NLreboot_Api ();
		}
#pragma warning restore 0169

		IntPtr id_NLreboot_Api;
		public unsafe void NLreboot_Api ()
		{
			if (id_NLreboot_Api == IntPtr.Zero)
				id_NLreboot_Api = JNIEnv.GetMethodID (class_ref, "NLreboot_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NLreboot_Api);
		}

		static Delegate? cb_NLsetAudio_Api_Z;
#pragma warning disable 0169
		static Delegate GetNLsetAudio_Api_ZHandler ()
		{
			if (cb_NLsetAudio_Api_Z == null)
				cb_NLsetAudio_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_NLsetAudio_Api_Z));
			return cb_NLsetAudio_Api_Z;
		}

		static void n_NLsetAudio_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.NLsetAudio_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NLsetAudio_Api_Z;
		public unsafe void NLsetAudio_Api (bool p0)
		{
			if (id_NLsetAudio_Api_Z == IntPtr.Zero)
				id_NLsetAudio_Api_Z = JNIEnv.GetMethodID (class_ref, "NLsetAudio_Api", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NLsetAudio_Api_Z, __args);
		}

		static Delegate? cb_NLsetScanMode_Api_I;
#pragma warning disable 0169
		static Delegate GetNLsetScanMode_Api_IHandler ()
		{
			if (cb_NLsetScanMode_Api_I == null)
				cb_NLsetScanMode_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_NLsetScanMode_Api_I));
			return cb_NLsetScanMode_Api_I;
		}

		static void n_NLsetScanMode_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.NLsetScanMode_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NLsetScanMode_Api_I;
		public unsafe void NLsetScanMode_Api (int p0)
		{
			if (id_NLsetScanMode_Api_I == IntPtr.Zero)
				id_NLsetScanMode_Api_I = JNIEnv.GetMethodID (class_ref, "NLsetScanMode_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NLsetScanMode_Api_I, __args);
		}

		static Delegate? cb_NLsetTimeOut_Api_I;
#pragma warning disable 0169
		static Delegate GetNLsetTimeOut_Api_IHandler ()
		{
			if (cb_NLsetTimeOut_Api_I == null)
				cb_NLsetTimeOut_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_NLsetTimeOut_Api_I));
			return cb_NLsetTimeOut_Api_I;
		}

		static bool n_NLsetTimeOut_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NLsetTimeOut_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NLsetTimeOut_Api_I;
		public unsafe bool NLsetTimeOut_Api (int p0)
		{
			if (id_NLsetTimeOut_Api_I == IntPtr.Zero)
				id_NLsetTimeOut_Api_I = JNIEnv.GetMethodID (class_ref, "NLsetTimeOut_Api", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_NLsetTimeOut_Api_I, __args);
		}

		static Delegate? cb_NLstartScan_Api;
#pragma warning disable 0169
		static Delegate GetNLstartScan_ApiHandler ()
		{
			if (cb_NLstartScan_Api == null)
				cb_NLstartScan_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NLstartScan_Api));
			return cb_NLstartScan_Api;
		}

		static void n_NLstartScan_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.NLstartScan_Api ();
		}
#pragma warning restore 0169

		IntPtr id_NLstartScan_Api;
		public unsafe void NLstartScan_Api ()
		{
			if (id_NLstartScan_Api == IntPtr.Zero)
				id_NLstartScan_Api = JNIEnv.GetMethodID (class_ref, "NLstartScan_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NLstartScan_Api);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.NLDeviceScan.INLDeviceScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
