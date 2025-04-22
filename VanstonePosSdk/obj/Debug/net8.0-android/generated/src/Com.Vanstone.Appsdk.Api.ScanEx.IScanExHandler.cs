using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.ScanEx {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']"
	[Register ("com/vanstone/appsdk/api/scanEx/ScanExHandler", "", "Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandlerInvoker")]
	public partial interface IScanExHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanCloseEx_Api' and count(parameter)=0]"
		[Register ("ScanCloseEx_Api", "()I", "GetScanCloseEx_ApiHandler:Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandlerInvoker, VanstonePosSdk")]
		int ScanCloseEx_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanGetDataEx_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("ScanGetDataEx_Api", "([BI)I", "GetScanGetDataEx_Api_arrayBIHandler:Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandlerInvoker, VanstonePosSdk")]
		int ScanGetDataEx_Api (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanOpenEx_Api' and count(parameter)=0]"
		[Register ("ScanOpenEx_Api", "()I", "GetScanOpenEx_ApiHandler:Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandlerInvoker, VanstonePosSdk")]
		int ScanOpenEx_Api ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scanEx/ScanExHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scanEx/ScanExHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Default']/constructor[@name='ScanExHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_ScanCloseEx_Api;
#pragma warning disable 0169
			static Delegate GetScanCloseEx_ApiHandler ()
			{
				if (cb_ScanCloseEx_Api == null)
					cb_ScanCloseEx_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanCloseEx_Api));
				return cb_ScanCloseEx_Api;
			}

			static int n_ScanCloseEx_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ScanCloseEx_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Default']/method[@name='ScanCloseEx_Api' and count(parameter)=0]"
			[Register ("ScanCloseEx_Api", "()I", "GetScanCloseEx_ApiHandler")]
			public virtual unsafe int ScanCloseEx_Api ()
			{
				const string __id = "ScanCloseEx_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_ScanGetDataEx_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetScanGetDataEx_Api_arrayBIHandler ()
			{
				if (cb_ScanGetDataEx_Api_arrayBI == null)
					cb_ScanGetDataEx_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_ScanGetDataEx_Api_arrayBI));
				return cb_ScanGetDataEx_Api_arrayBI;
			}

			static int n_ScanGetDataEx_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_barCodeOut, int MsTimOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var barCodeOut = (byte[]?) JNIEnv.GetArray (native_barCodeOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ScanGetDataEx_Api (barCodeOut, MsTimOut);
				if (barCodeOut != null)
					JNIEnv.CopyArray (barCodeOut, native_barCodeOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Default']/method[@name='ScanGetDataEx_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("ScanGetDataEx_Api", "([BI)I", "GetScanGetDataEx_Api_arrayBIHandler")]
			public virtual unsafe int ScanGetDataEx_Api (byte[]? barCodeOut, int MsTimOut)
			{
				const string __id = "ScanGetDataEx_Api.([BI)I";
				IntPtr native_barCodeOut = JNIEnv.NewArray (barCodeOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_barCodeOut);
					__args [1] = new JniArgumentValue (MsTimOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (barCodeOut != null) {
						JNIEnv.CopyArray (native_barCodeOut, barCodeOut);
						JNIEnv.DeleteLocalRef (native_barCodeOut);
					}
					global::System.GC.KeepAlive (barCodeOut);
				}
			}

			static Delegate? cb_ScanOpenEx_Api;
#pragma warning disable 0169
			static Delegate GetScanOpenEx_ApiHandler ()
			{
				if (cb_ScanOpenEx_Api == null)
					cb_ScanOpenEx_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanOpenEx_Api));
				return cb_ScanOpenEx_Api;
			}

			static int n_ScanOpenEx_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ScanOpenEx_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Default']/method[@name='ScanOpenEx_Api' and count(parameter)=0]"
			[Register ("ScanOpenEx_Api", "()I", "GetScanOpenEx_ApiHandler")]
			public virtual unsafe int ScanOpenEx_Api ()
			{
				const string __id = "ScanOpenEx_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scanEx/ScanExHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scanEx/ScanExHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Stub']/constructor[@name='ScanExHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/class[@name='ScanExHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.scanEx.ScanExHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/scanEx/ScanExHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_ScanCloseEx_Api;
#pragma warning disable 0169
			static Delegate GetScanCloseEx_ApiHandler ()
			{
				if (cb_ScanCloseEx_Api == null)
					cb_ScanCloseEx_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanCloseEx_Api));
				return cb_ScanCloseEx_Api;
			}

			static int n_ScanCloseEx_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ScanCloseEx_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanCloseEx_Api' and count(parameter)=0]"
			[Register ("ScanCloseEx_Api", "()I", "GetScanCloseEx_ApiHandler")]
			public abstract int ScanCloseEx_Api ();

			static Delegate? cb_ScanGetDataEx_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetScanGetDataEx_Api_arrayBIHandler ()
			{
				if (cb_ScanGetDataEx_Api_arrayBI == null)
					cb_ScanGetDataEx_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_ScanGetDataEx_Api_arrayBI));
				return cb_ScanGetDataEx_Api_arrayBI;
			}

			static int n_ScanGetDataEx_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ScanGetDataEx_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanGetDataEx_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("ScanGetDataEx_Api", "([BI)I", "GetScanGetDataEx_Api_arrayBIHandler")]
			public abstract int ScanGetDataEx_Api (byte[]? p0, int p1);

			static Delegate? cb_ScanOpenEx_Api;
#pragma warning disable 0169
			static Delegate GetScanOpenEx_ApiHandler ()
			{
				if (cb_ScanOpenEx_Api == null)
					cb_ScanOpenEx_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanOpenEx_Api));
				return cb_ScanOpenEx_Api;
			}

			static int n_ScanOpenEx_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ScanOpenEx_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanOpenEx_Api' and count(parameter)=0]"
			[Register ("ScanOpenEx_Api", "()I", "GetScanOpenEx_ApiHandler")]
			public abstract int ScanOpenEx_Api ();

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scanEx/ScanExHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scanEx/ScanExHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanCloseEx_Api' and count(parameter)=0]"
			[Register ("ScanCloseEx_Api", "()I", "GetScanCloseEx_ApiHandler")]
			public override unsafe int ScanCloseEx_Api ()
			{
				const string __id = "ScanCloseEx_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanGetDataEx_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("ScanGetDataEx_Api", "([BI)I", "GetScanGetDataEx_Api_arrayBIHandler")]
			public override unsafe int ScanGetDataEx_Api (byte[]? p0, int p1)
			{
				const string __id = "ScanGetDataEx_Api.([BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.scanEx']/interface[@name='ScanExHandler']/method[@name='ScanOpenEx_Api' and count(parameter)=0]"
			[Register ("ScanOpenEx_Api", "()I", "GetScanOpenEx_ApiHandler")]
			public override unsafe int ScanOpenEx_Api ()
			{
				const string __id = "ScanOpenEx_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/scanEx/ScanExHandler", DoNotGenerateAcw=true)]
	internal partial class IScanExHandlerInvoker : global::Java.Lang.Object, IScanExHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/scanEx/ScanExHandler", typeof (IScanExHandlerInvoker));

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

		public static IScanExHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScanExHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.scanEx.ScanExHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScanExHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_ScanCloseEx_Api;
#pragma warning disable 0169
		static Delegate GetScanCloseEx_ApiHandler ()
		{
			if (cb_ScanCloseEx_Api == null)
				cb_ScanCloseEx_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanCloseEx_Api));
			return cb_ScanCloseEx_Api;
		}

		static int n_ScanCloseEx_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ScanCloseEx_Api ();
		}
#pragma warning restore 0169

		IntPtr id_ScanCloseEx_Api;
		public unsafe int ScanCloseEx_Api ()
		{
			if (id_ScanCloseEx_Api == IntPtr.Zero)
				id_ScanCloseEx_Api = JNIEnv.GetMethodID (class_ref, "ScanCloseEx_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ScanCloseEx_Api);
		}

		static Delegate? cb_ScanGetDataEx_Api_arrayBI;
#pragma warning disable 0169
		static Delegate GetScanGetDataEx_Api_arrayBIHandler ()
		{
			if (cb_ScanGetDataEx_Api_arrayBI == null)
				cb_ScanGetDataEx_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_ScanGetDataEx_Api_arrayBI));
			return cb_ScanGetDataEx_Api_arrayBI;
		}

		static int n_ScanGetDataEx_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ScanGetDataEx_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_ScanGetDataEx_Api_arrayBI;
		public unsafe int ScanGetDataEx_Api (byte[]? p0, int p1)
		{
			if (id_ScanGetDataEx_Api_arrayBI == IntPtr.Zero)
				id_ScanGetDataEx_Api_arrayBI = JNIEnv.GetMethodID (class_ref, "ScanGetDataEx_Api", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ScanGetDataEx_Api_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_ScanOpenEx_Api;
#pragma warning disable 0169
		static Delegate GetScanOpenEx_ApiHandler ()
		{
			if (cb_ScanOpenEx_Api == null)
				cb_ScanOpenEx_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ScanOpenEx_Api));
			return cb_ScanOpenEx_Api;
		}

		static int n_ScanOpenEx_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ScanOpenEx_Api ();
		}
#pragma warning restore 0169

		IntPtr id_ScanOpenEx_Api;
		public unsafe int ScanOpenEx_Api ()
		{
			if (id_ScanOpenEx_Api == IntPtr.Zero)
				id_ScanOpenEx_Api = JNIEnv.GetMethodID (class_ref, "ScanOpenEx_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ScanOpenEx_Api);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.ScanEx.IScanExHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
