using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Authface {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']"
	[Register ("com/vanstone/appsdk/api/authface/AuthFaceHandler", "", "Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandlerInvoker")]
	public partial interface IAuthFaceHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceGetFirmwareInfo_Api' and count(parameter)=0]"
		[Register ("FaceGetFirmwareInfo_Api", "()Landroid/os/Bundle;", "GetFaceGetFirmwareInfo_ApiHandler:Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandlerInvoker, VanstonePosSdk")]
		global::Android.OS.Bundle? FaceGetFirmwareInfo_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceGetParam_Api' and count(parameter)=0]"
		[Register ("FaceGetParam_Api", "()Landroid/os/Bundle;", "GetFaceGetParam_ApiHandler:Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandlerInvoker, VanstonePosSdk")]
		global::Android.OS.Bundle? FaceGetParam_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceSetParam_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("FaceSetParam_Api", "(Landroid/os/Bundle;)V", "GetFaceSetParam_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandlerInvoker, VanstonePosSdk")]
		void FaceSetParam_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceStartDetect_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFaceDetecResult']]"
		[Register ("FaceStartDetect_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)V", "GetFaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_Handler:Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandlerInvoker, VanstonePosSdk")]
		void FaceStartDetect_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceStopDetect_Api' and count(parameter)=0]"
		[Register ("FaceStopDetect_Api", "()V", "GetFaceStopDetect_ApiHandler:Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandlerInvoker, VanstonePosSdk")]
		void FaceStopDetect_Api ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/authface/AuthFaceHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/authface/AuthFaceHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']/constructor[@name='AuthFaceHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_FaceGetFirmwareInfo_Api;
#pragma warning disable 0169
			static Delegate GetFaceGetFirmwareInfo_ApiHandler ()
			{
				if (cb_FaceGetFirmwareInfo_Api == null)
					cb_FaceGetFirmwareInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_FaceGetFirmwareInfo_Api));
				return cb_FaceGetFirmwareInfo_Api;
			}

			static IntPtr n_FaceGetFirmwareInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FaceGetFirmwareInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']/method[@name='FaceGetFirmwareInfo_Api' and count(parameter)=0]"
			[Register ("FaceGetFirmwareInfo_Api", "()Landroid/os/Bundle;", "GetFaceGetFirmwareInfo_ApiHandler")]
			public virtual unsafe global::Android.OS.Bundle? FaceGetFirmwareInfo_Api ()
			{
				const string __id = "FaceGetFirmwareInfo_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_FaceGetParam_Api;
#pragma warning disable 0169
			static Delegate GetFaceGetParam_ApiHandler ()
			{
				if (cb_FaceGetParam_Api == null)
					cb_FaceGetParam_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_FaceGetParam_Api));
				return cb_FaceGetParam_Api;
			}

			static IntPtr n_FaceGetParam_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FaceGetParam_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']/method[@name='FaceGetParam_Api' and count(parameter)=0]"
			[Register ("FaceGetParam_Api", "()Landroid/os/Bundle;", "GetFaceGetParam_ApiHandler")]
			public virtual unsafe global::Android.OS.Bundle? FaceGetParam_Api ()
			{
				const string __id = "FaceGetParam_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_FaceSetParam_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetFaceSetParam_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_FaceSetParam_Api_Landroid_os_Bundle_ == null)
					cb_FaceSetParam_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_FaceSetParam_Api_Landroid_os_Bundle_));
				return cb_FaceSetParam_Api_Landroid_os_Bundle_;
			}

			static void n_FaceSetParam_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_param)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var param = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_param, JniHandleOwnership.DoNotTransfer);
				__this.FaceSetParam_Api (param);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']/method[@name='FaceSetParam_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("FaceSetParam_Api", "(Landroid/os/Bundle;)V", "GetFaceSetParam_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe void FaceSetParam_Api (global::Android.OS.Bundle? param)
			{
				const string __id = "FaceSetParam_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((param == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (param);
				}
			}

			static Delegate? cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_;
#pragma warning disable 0169
			static Delegate GetFaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_Handler ()
			{
				if (cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ == null)
					cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_));
				return cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_;
			}

			static void n_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params, IntPtr native_result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @params = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native__params, JniHandleOwnership.DoNotTransfer);
				var result = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.FaceStartDetect_Api (@params, result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']/method[@name='FaceStartDetect_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFaceDetecResult']]"
			[Register ("FaceStartDetect_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)V", "GetFaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_Handler")]
			public virtual unsafe void FaceStartDetect_Api (global::Android.OS.Bundle? @params, global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? result)
			{
				const string __id = "FaceStartDetect_Api.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@params);
					global::System.GC.KeepAlive (result);
				}
			}

			static Delegate? cb_FaceStopDetect_Api;
#pragma warning disable 0169
			static Delegate GetFaceStopDetect_ApiHandler ()
			{
				if (cb_FaceStopDetect_Api == null)
					cb_FaceStopDetect_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FaceStopDetect_Api));
				return cb_FaceStopDetect_Api;
			}

			static void n_FaceStopDetect_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.FaceStopDetect_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']/method[@name='FaceStopDetect_Api' and count(parameter)=0]"
			[Register ("FaceStopDetect_Api", "()V", "GetFaceStopDetect_ApiHandler")]
			public virtual unsafe void FaceStopDetect_Api ()
			{
				const string __id = "FaceStopDetect_Api.()V";
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/authface/AuthFaceHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/authface/AuthFaceHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Stub']/constructor[@name='AuthFaceHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/class[@name='AuthFaceHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.authface.AuthFaceHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/authface/AuthFaceHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_FaceGetFirmwareInfo_Api;
#pragma warning disable 0169
			static Delegate GetFaceGetFirmwareInfo_ApiHandler ()
			{
				if (cb_FaceGetFirmwareInfo_Api == null)
					cb_FaceGetFirmwareInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_FaceGetFirmwareInfo_Api));
				return cb_FaceGetFirmwareInfo_Api;
			}

			static IntPtr n_FaceGetFirmwareInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FaceGetFirmwareInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceGetFirmwareInfo_Api' and count(parameter)=0]"
			[Register ("FaceGetFirmwareInfo_Api", "()Landroid/os/Bundle;", "GetFaceGetFirmwareInfo_ApiHandler")]
			public abstract global::Android.OS.Bundle? FaceGetFirmwareInfo_Api ();

			static Delegate? cb_FaceGetParam_Api;
#pragma warning disable 0169
			static Delegate GetFaceGetParam_ApiHandler ()
			{
				if (cb_FaceGetParam_Api == null)
					cb_FaceGetParam_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_FaceGetParam_Api));
				return cb_FaceGetParam_Api;
			}

			static IntPtr n_FaceGetParam_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FaceGetParam_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceGetParam_Api' and count(parameter)=0]"
			[Register ("FaceGetParam_Api", "()Landroid/os/Bundle;", "GetFaceGetParam_ApiHandler")]
			public abstract global::Android.OS.Bundle? FaceGetParam_Api ();

			static Delegate? cb_FaceSetParam_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetFaceSetParam_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_FaceSetParam_Api_Landroid_os_Bundle_ == null)
					cb_FaceSetParam_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_FaceSetParam_Api_Landroid_os_Bundle_));
				return cb_FaceSetParam_Api_Landroid_os_Bundle_;
			}

			static void n_FaceSetParam_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.FaceSetParam_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceSetParam_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("FaceSetParam_Api", "(Landroid/os/Bundle;)V", "GetFaceSetParam_Api_Landroid_os_Bundle_Handler")]
			public abstract void FaceSetParam_Api (global::Android.OS.Bundle? p0);

			static Delegate? cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_;
#pragma warning disable 0169
			static Delegate GetFaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_Handler ()
			{
				if (cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ == null)
					cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_));
				return cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_;
			}

			static void n_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.FaceStartDetect_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceStartDetect_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFaceDetecResult']]"
			[Register ("FaceStartDetect_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)V", "GetFaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_Handler")]
			public abstract void FaceStartDetect_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? p1);

			static Delegate? cb_FaceStopDetect_Api;
#pragma warning disable 0169
			static Delegate GetFaceStopDetect_ApiHandler ()
			{
				if (cb_FaceStopDetect_Api == null)
					cb_FaceStopDetect_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FaceStopDetect_Api));
				return cb_FaceStopDetect_Api;
			}

			static void n_FaceStopDetect_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.FaceStopDetect_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceStopDetect_Api' and count(parameter)=0]"
			[Register ("FaceStopDetect_Api", "()V", "GetFaceStopDetect_ApiHandler")]
			public abstract void FaceStopDetect_Api ();

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/authface/AuthFaceHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/authface/AuthFaceHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceGetFirmwareInfo_Api' and count(parameter)=0]"
			[Register ("FaceGetFirmwareInfo_Api", "()Landroid/os/Bundle;", "GetFaceGetFirmwareInfo_ApiHandler")]
			public override unsafe global::Android.OS.Bundle? FaceGetFirmwareInfo_Api ()
			{
				const string __id = "FaceGetFirmwareInfo_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceGetParam_Api' and count(parameter)=0]"
			[Register ("FaceGetParam_Api", "()Landroid/os/Bundle;", "GetFaceGetParam_ApiHandler")]
			public override unsafe global::Android.OS.Bundle? FaceGetParam_Api ()
			{
				const string __id = "FaceGetParam_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceSetParam_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("FaceSetParam_Api", "(Landroid/os/Bundle;)V", "GetFaceSetParam_Api_Landroid_os_Bundle_Handler")]
			public override unsafe void FaceSetParam_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "FaceSetParam_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceStartDetect_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IFaceDetecResult']]"
			[Register ("FaceStartDetect_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)V", "GetFaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_Handler")]
			public override unsafe void FaceStartDetect_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? p1)
			{
				const string __id = "FaceStartDetect_Api.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.authface']/interface[@name='AuthFaceHandler']/method[@name='FaceStopDetect_Api' and count(parameter)=0]"
			[Register ("FaceStopDetect_Api", "()V", "GetFaceStopDetect_ApiHandler")]
			public override unsafe void FaceStopDetect_Api ()
			{
				const string __id = "FaceStopDetect_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/authface/AuthFaceHandler", DoNotGenerateAcw=true)]
	internal partial class IAuthFaceHandlerInvoker : global::Java.Lang.Object, IAuthFaceHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/authface/AuthFaceHandler", typeof (IAuthFaceHandlerInvoker));

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

		public static IAuthFaceHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthFaceHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.authface.AuthFaceHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthFaceHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_FaceGetFirmwareInfo_Api;
#pragma warning disable 0169
		static Delegate GetFaceGetFirmwareInfo_ApiHandler ()
		{
			if (cb_FaceGetFirmwareInfo_Api == null)
				cb_FaceGetFirmwareInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_FaceGetFirmwareInfo_Api));
			return cb_FaceGetFirmwareInfo_Api;
		}

		static IntPtr n_FaceGetFirmwareInfo_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.FaceGetFirmwareInfo_Api ());
		}
#pragma warning restore 0169

		IntPtr id_FaceGetFirmwareInfo_Api;
		public unsafe global::Android.OS.Bundle? FaceGetFirmwareInfo_Api ()
		{
			if (id_FaceGetFirmwareInfo_Api == IntPtr.Zero)
				id_FaceGetFirmwareInfo_Api = JNIEnv.GetMethodID (class_ref, "FaceGetFirmwareInfo_Api", "()Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_FaceGetFirmwareInfo_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_FaceGetParam_Api;
#pragma warning disable 0169
		static Delegate GetFaceGetParam_ApiHandler ()
		{
			if (cb_FaceGetParam_Api == null)
				cb_FaceGetParam_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_FaceGetParam_Api));
			return cb_FaceGetParam_Api;
		}

		static IntPtr n_FaceGetParam_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.FaceGetParam_Api ());
		}
#pragma warning restore 0169

		IntPtr id_FaceGetParam_Api;
		public unsafe global::Android.OS.Bundle? FaceGetParam_Api ()
		{
			if (id_FaceGetParam_Api == IntPtr.Zero)
				id_FaceGetParam_Api = JNIEnv.GetMethodID (class_ref, "FaceGetParam_Api", "()Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_FaceGetParam_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_FaceSetParam_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetFaceSetParam_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_FaceSetParam_Api_Landroid_os_Bundle_ == null)
				cb_FaceSetParam_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_FaceSetParam_Api_Landroid_os_Bundle_));
			return cb_FaceSetParam_Api_Landroid_os_Bundle_;
		}

		static void n_FaceSetParam_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FaceSetParam_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_FaceSetParam_Api_Landroid_os_Bundle_;
		public unsafe void FaceSetParam_Api (global::Android.OS.Bundle? p0)
		{
			if (id_FaceSetParam_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_FaceSetParam_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "FaceSetParam_Api", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_FaceSetParam_Api_Landroid_os_Bundle_, __args);
		}

		static Delegate? cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_;
#pragma warning disable 0169
		static Delegate GetFaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_Handler ()
		{
			if (cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ == null)
				cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_));
			return cb_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_;
		}

		static void n_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FaceStartDetect_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_;
		public unsafe void FaceStartDetect_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? p1)
		{
			if (id_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ == IntPtr.Zero)
				id_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_ = JNIEnv.GetMethodID (class_ref, "FaceStartDetect_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_FaceStartDetect_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IFaceDetecResult_, __args);
		}

		static Delegate? cb_FaceStopDetect_Api;
#pragma warning disable 0169
		static Delegate GetFaceStopDetect_ApiHandler ()
		{
			if (cb_FaceStopDetect_Api == null)
				cb_FaceStopDetect_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FaceStopDetect_Api));
			return cb_FaceStopDetect_Api;
		}

		static void n_FaceStopDetect_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.FaceStopDetect_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FaceStopDetect_Api;
		public unsafe void FaceStopDetect_Api ()
		{
			if (id_FaceStopDetect_Api == IntPtr.Zero)
				id_FaceStopDetect_Api = JNIEnv.GetMethodID (class_ref, "FaceStopDetect_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_FaceStopDetect_Api);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Authface.IAuthFaceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
