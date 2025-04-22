using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.IRThermometer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']"
	[Register ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler", "", "Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandlerInvoker")]
	public partial interface IRThermometerHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='CloseIRThermometer_Api' and count(parameter)=0]"
		[Register ("CloseIRThermometer_Api", "()I", "GetCloseIRThermometer_ApiHandler:Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandlerInvoker, VanstonePosSdk")]
		int CloseIRThermometer_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='GetThermometer_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("GetThermometer_Api", "(Landroid/os/Bundle;)I", "GetGetThermometer_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandlerInvoker, VanstonePosSdk")]
		int GetThermometer_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='OpenIRThermometer_Api' and count(parameter)=0]"
		[Register ("OpenIRThermometer_Api", "()I", "GetOpenIRThermometer_ApiHandler:Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandlerInvoker, VanstonePosSdk")]
		int OpenIRThermometer_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='SetIRThermometerParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("SetIRThermometerParams_Api", "(Landroid/os/Bundle;)I", "GetSetIRThermometerParams_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandlerInvoker, VanstonePosSdk")]
		int SetIRThermometerParams_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Default']/constructor[@name='IRThermometerHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_CloseIRThermometer_Api;
#pragma warning disable 0169
			static Delegate GetCloseIRThermometer_ApiHandler ()
			{
				if (cb_CloseIRThermometer_Api == null)
					cb_CloseIRThermometer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseIRThermometer_Api));
				return cb_CloseIRThermometer_Api;
			}

			static int n_CloseIRThermometer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseIRThermometer_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Default']/method[@name='CloseIRThermometer_Api' and count(parameter)=0]"
			[Register ("CloseIRThermometer_Api", "()I", "GetCloseIRThermometer_ApiHandler")]
			public virtual unsafe int CloseIRThermometer_Api ()
			{
				const string __id = "CloseIRThermometer_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_GetThermometer_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetGetThermometer_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_GetThermometer_Api_Landroid_os_Bundle_ == null)
					cb_GetThermometer_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetThermometer_Api_Landroid_os_Bundle_));
				return cb_GetThermometer_Api_Landroid_os_Bundle_;
			}

			static int n_GetThermometer_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_OutParams)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var OutParams = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_OutParams, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetThermometer_Api (OutParams);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Default']/method[@name='GetThermometer_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("GetThermometer_Api", "(Landroid/os/Bundle;)I", "GetGetThermometer_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe int GetThermometer_Api (global::Android.OS.Bundle? OutParams)
			{
				const string __id = "GetThermometer_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((OutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) OutParams).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (OutParams);
				}
			}

			static Delegate? cb_OpenIRThermometer_Api;
#pragma warning disable 0169
			static Delegate GetOpenIRThermometer_ApiHandler ()
			{
				if (cb_OpenIRThermometer_Api == null)
					cb_OpenIRThermometer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenIRThermometer_Api));
				return cb_OpenIRThermometer_Api;
			}

			static int n_OpenIRThermometer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.OpenIRThermometer_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Default']/method[@name='OpenIRThermometer_Api' and count(parameter)=0]"
			[Register ("OpenIRThermometer_Api", "()I", "GetOpenIRThermometer_ApiHandler")]
			public virtual unsafe int OpenIRThermometer_Api ()
			{
				const string __id = "OpenIRThermometer_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SetIRThermometerParams_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetIRThermometerParams_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_SetIRThermometerParams_Api_Landroid_os_Bundle_ == null)
					cb_SetIRThermometerParams_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetIRThermometerParams_Api_Landroid_os_Bundle_));
				return cb_SetIRThermometerParams_Api_Landroid_os_Bundle_;
			}

			static int n_SetIRThermometerParams_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_InParams)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var InParams = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_InParams, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetIRThermometerParams_Api (InParams);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Default']/method[@name='SetIRThermometerParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("SetIRThermometerParams_Api", "(Landroid/os/Bundle;)I", "GetSetIRThermometerParams_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe int SetIRThermometerParams_Api (global::Android.OS.Bundle? InParams)
			{
				const string __id = "SetIRThermometerParams_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((InParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) InParams).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (InParams);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Stub']/constructor[@name='IRThermometerHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/class[@name='IRThermometerHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.IRThermometer.IRThermometerHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/IRThermometer/IRThermometerHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_CloseIRThermometer_Api;
#pragma warning disable 0169
			static Delegate GetCloseIRThermometer_ApiHandler ()
			{
				if (cb_CloseIRThermometer_Api == null)
					cb_CloseIRThermometer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseIRThermometer_Api));
				return cb_CloseIRThermometer_Api;
			}

			static int n_CloseIRThermometer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseIRThermometer_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='CloseIRThermometer_Api' and count(parameter)=0]"
			[Register ("CloseIRThermometer_Api", "()I", "GetCloseIRThermometer_ApiHandler")]
			public abstract int CloseIRThermometer_Api ();

			static Delegate? cb_GetThermometer_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetGetThermometer_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_GetThermometer_Api_Landroid_os_Bundle_ == null)
					cb_GetThermometer_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetThermometer_Api_Landroid_os_Bundle_));
				return cb_GetThermometer_Api_Landroid_os_Bundle_;
			}

			static int n_GetThermometer_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetThermometer_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='GetThermometer_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("GetThermometer_Api", "(Landroid/os/Bundle;)I", "GetGetThermometer_Api_Landroid_os_Bundle_Handler")]
			public abstract int GetThermometer_Api (global::Android.OS.Bundle? p0);

			static Delegate? cb_OpenIRThermometer_Api;
#pragma warning disable 0169
			static Delegate GetOpenIRThermometer_ApiHandler ()
			{
				if (cb_OpenIRThermometer_Api == null)
					cb_OpenIRThermometer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenIRThermometer_Api));
				return cb_OpenIRThermometer_Api;
			}

			static int n_OpenIRThermometer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.OpenIRThermometer_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='OpenIRThermometer_Api' and count(parameter)=0]"
			[Register ("OpenIRThermometer_Api", "()I", "GetOpenIRThermometer_ApiHandler")]
			public abstract int OpenIRThermometer_Api ();

			static Delegate? cb_SetIRThermometerParams_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetIRThermometerParams_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_SetIRThermometerParams_Api_Landroid_os_Bundle_ == null)
					cb_SetIRThermometerParams_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetIRThermometerParams_Api_Landroid_os_Bundle_));
				return cb_SetIRThermometerParams_Api_Landroid_os_Bundle_;
			}

			static int n_SetIRThermometerParams_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetIRThermometerParams_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='SetIRThermometerParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("SetIRThermometerParams_Api", "(Landroid/os/Bundle;)I", "GetSetIRThermometerParams_Api_Landroid_os_Bundle_Handler")]
			public abstract int SetIRThermometerParams_Api (global::Android.OS.Bundle? p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='CloseIRThermometer_Api' and count(parameter)=0]"
			[Register ("CloseIRThermometer_Api", "()I", "GetCloseIRThermometer_ApiHandler")]
			public override unsafe int CloseIRThermometer_Api ()
			{
				const string __id = "CloseIRThermometer_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='GetThermometer_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("GetThermometer_Api", "(Landroid/os/Bundle;)I", "GetGetThermometer_Api_Landroid_os_Bundle_Handler")]
			public override unsafe int GetThermometer_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "GetThermometer_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='OpenIRThermometer_Api' and count(parameter)=0]"
			[Register ("OpenIRThermometer_Api", "()I", "GetOpenIRThermometer_ApiHandler")]
			public override unsafe int OpenIRThermometer_Api ()
			{
				const string __id = "OpenIRThermometer_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.IRThermometer']/interface[@name='IRThermometerHandler']/method[@name='SetIRThermometerParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("SetIRThermometerParams_Api", "(Landroid/os/Bundle;)I", "GetSetIRThermometerParams_Api_Landroid_os_Bundle_Handler")]
			public override unsafe int SetIRThermometerParams_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "SetIRThermometerParams_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler", DoNotGenerateAcw=true)]
	internal partial class IRThermometerHandlerInvoker : global::Java.Lang.Object, IRThermometerHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/IRThermometer/IRThermometerHandler", typeof (IRThermometerHandlerInvoker));

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

		public static IRThermometerHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRThermometerHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.IRThermometer.IRThermometerHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRThermometerHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_CloseIRThermometer_Api;
#pragma warning disable 0169
		static Delegate GetCloseIRThermometer_ApiHandler ()
		{
			if (cb_CloseIRThermometer_Api == null)
				cb_CloseIRThermometer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseIRThermometer_Api));
			return cb_CloseIRThermometer_Api;
		}

		static int n_CloseIRThermometer_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CloseIRThermometer_Api ();
		}
#pragma warning restore 0169

		IntPtr id_CloseIRThermometer_Api;
		public unsafe int CloseIRThermometer_Api ()
		{
			if (id_CloseIRThermometer_Api == IntPtr.Zero)
				id_CloseIRThermometer_Api = JNIEnv.GetMethodID (class_ref, "CloseIRThermometer_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_CloseIRThermometer_Api);
		}

		static Delegate? cb_GetThermometer_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetThermometer_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_GetThermometer_Api_Landroid_os_Bundle_ == null)
				cb_GetThermometer_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetThermometer_Api_Landroid_os_Bundle_));
			return cb_GetThermometer_Api_Landroid_os_Bundle_;
		}

		static int n_GetThermometer_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetThermometer_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetThermometer_Api_Landroid_os_Bundle_;
		public unsafe int GetThermometer_Api (global::Android.OS.Bundle? p0)
		{
			if (id_GetThermometer_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_GetThermometer_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "GetThermometer_Api", "(Landroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetThermometer_Api_Landroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_OpenIRThermometer_Api;
#pragma warning disable 0169
		static Delegate GetOpenIRThermometer_ApiHandler ()
		{
			if (cb_OpenIRThermometer_Api == null)
				cb_OpenIRThermometer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenIRThermometer_Api));
			return cb_OpenIRThermometer_Api;
		}

		static int n_OpenIRThermometer_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.OpenIRThermometer_Api ();
		}
#pragma warning restore 0169

		IntPtr id_OpenIRThermometer_Api;
		public unsafe int OpenIRThermometer_Api ()
		{
			if (id_OpenIRThermometer_Api == IntPtr.Zero)
				id_OpenIRThermometer_Api = JNIEnv.GetMethodID (class_ref, "OpenIRThermometer_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_OpenIRThermometer_Api);
		}

		static Delegate? cb_SetIRThermometerParams_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetIRThermometerParams_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_SetIRThermometerParams_Api_Landroid_os_Bundle_ == null)
				cb_SetIRThermometerParams_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetIRThermometerParams_Api_Landroid_os_Bundle_));
			return cb_SetIRThermometerParams_Api_Landroid_os_Bundle_;
		}

		static int n_SetIRThermometerParams_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetIRThermometerParams_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SetIRThermometerParams_Api_Landroid_os_Bundle_;
		public unsafe int SetIRThermometerParams_Api (global::Android.OS.Bundle? p0)
		{
			if (id_SetIRThermometerParams_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_SetIRThermometerParams_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "SetIRThermometerParams_Api", "(Landroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SetIRThermometerParams_Api_Landroid_os_Bundle_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.IRThermometer.IRThermometerHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
