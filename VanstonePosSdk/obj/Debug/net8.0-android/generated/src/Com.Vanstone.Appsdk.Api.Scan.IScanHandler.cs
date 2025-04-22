using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Scan {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/interface[@name='ScanHandler']"
	[Register ("com/vanstone/appsdk/api/scan/ScanHandler", "", "Com.Vanstone.Appsdk.Api.Scan.IScanHandlerInvoker")]
	public partial interface IScanHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/interface[@name='ScanHandler']/method[@name='ScanClose_Api' and count(parameter)=0]"
		[Register ("ScanClose_Api", "()I", "GetScanClose_ApiHandler:Com.Vanstone.Appsdk.Api.Scan.IScanHandlerInvoker, VanstonePosSdk")]
		int ScanClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/interface[@name='ScanHandler']/method[@name='ScanOpen_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IScanResult']]"
		[Register ("ScanOpen_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IScanResult;)I", "GetScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_Handler:Com.Vanstone.Appsdk.Api.Scan.IScanHandlerInvoker, VanstonePosSdk")]
		int ScanOpen_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scan/ScanHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scan/ScanHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Default']/constructor[@name='ScanHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_ScanClose_Api;
#pragma warning disable 0169
			static Delegate GetScanClose_ApiHandler ()
			{
				if (cb_ScanClose_Api == null)
					cb_ScanClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanClose_Api));
				return cb_ScanClose_Api;
			}

			static int n_ScanClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ScanClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Default']/method[@name='ScanClose_Api' and count(parameter)=0]"
			[Register ("ScanClose_Api", "()I", "GetScanClose_ApiHandler")]
			public virtual unsafe int ScanClose_Api ()
			{
				const string __id = "ScanClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_;
#pragma warning disable 0169
			static Delegate GetScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_Handler ()
			{
				if (cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ == null)
					cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_));
				return cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_;
			}

			static int n_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle, IntPtr native_scanCallback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				var scanCallback = (global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (native_scanCallback, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ScanOpen_Api (bundle, scanCallback);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Default']/method[@name='ScanOpen_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IScanResult']]"
			[Register ("ScanOpen_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IScanResult;)I", "GetScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_Handler")]
			public virtual unsafe int ScanOpen_Api (global::Android.OS.Bundle? bundle, global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? scanCallback)
			{
				const string __id = "ScanOpen_Api.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IScanResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					__args [1] = new JniArgumentValue ((scanCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scanCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
					global::System.GC.KeepAlive (scanCallback);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scan/ScanHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scan/ScanHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Stub']/constructor[@name='ScanHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/scan/ScanHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/scan/ScanHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/scan/ScanHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/scan/ScanHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/class[@name='ScanHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.scan.ScanHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/scan/ScanHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/scan/ScanHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_ScanClose_Api;
#pragma warning disable 0169
			static Delegate GetScanClose_ApiHandler ()
			{
				if (cb_ScanClose_Api == null)
					cb_ScanClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanClose_Api));
				return cb_ScanClose_Api;
			}

			static int n_ScanClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ScanClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/interface[@name='ScanHandler']/method[@name='ScanClose_Api' and count(parameter)=0]"
			[Register ("ScanClose_Api", "()I", "GetScanClose_ApiHandler")]
			public abstract int ScanClose_Api ();

			static Delegate? cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_;
#pragma warning disable 0169
			static Delegate GetScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_Handler ()
			{
				if (cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ == null)
					cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_));
				return cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_;
			}

			static int n_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ScanOpen_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/interface[@name='ScanHandler']/method[@name='ScanOpen_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IScanResult']]"
			[Register ("ScanOpen_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IScanResult;)I", "GetScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_Handler")]
			public abstract int ScanOpen_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? p1);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scan/ScanHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scan/ScanHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/interface[@name='ScanHandler']/method[@name='ScanClose_Api' and count(parameter)=0]"
			[Register ("ScanClose_Api", "()I", "GetScanClose_ApiHandler")]
			public override unsafe int ScanClose_Api ()
			{
				const string __id = "ScanClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scan']/interface[@name='ScanHandler']/method[@name='ScanOpen_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IScanResult']]"
			[Register ("ScanOpen_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IScanResult;)I", "GetScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_Handler")]
			public override unsafe int ScanOpen_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? p1)
			{
				const string __id = "ScanOpen_Api.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IScanResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scan/ScanHandler", DoNotGenerateAcw=true)]
	internal partial class IScanHandlerInvoker : global::Java.Lang.Object, IScanHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scan/ScanHandler", typeof (IScanHandlerInvoker));

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

		public static IScanHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScanHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.scan.ScanHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScanHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_ScanClose_Api;
#pragma warning disable 0169
		static Delegate GetScanClose_ApiHandler ()
		{
			if (cb_ScanClose_Api == null)
				cb_ScanClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanClose_Api));
			return cb_ScanClose_Api;
		}

		static int n_ScanClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ScanClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_ScanClose_Api;
		public unsafe int ScanClose_Api ()
		{
			if (id_ScanClose_Api == IntPtr.Zero)
				id_ScanClose_Api = JNIEnv.GetMethodID (class_ref, "ScanClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ScanClose_Api);
		}

		static Delegate? cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_;
#pragma warning disable 0169
		static Delegate GetScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_Handler ()
		{
			if (cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ == null)
				cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_));
			return cb_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_;
		}

		static int n_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ScanOpen_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_;
		public unsafe int ScanOpen_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? p1)
		{
			if (id_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ == IntPtr.Zero)
				id_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_ = JNIEnv.GetMethodID (class_ref, "ScanOpen_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IScanResult;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ScanOpen_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IScanResult_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Scan.IScanHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
