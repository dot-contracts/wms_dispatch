using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']"
	[Register ("com/vanstone/appsdk/api/interfaces/IScanResult", "", "Com.Vanstone.Appsdk.Api.Interfaces.IScanResultInvoker")]
	public partial interface IScanResult : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onButtonClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onButtonClick", "(Ljava/lang/String;)V", "GetOnButtonClick_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Interfaces.IScanResultInvoker, VanstonePosSdk")]
		void OnButtonClick (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onScanFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onScanFailed", "(ILjava/lang/String;)V", "GetOnScanFailed_ILjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Interfaces.IScanResultInvoker, VanstonePosSdk")]
		void OnScanFailed (int p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onScanSuccessed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onScanSuccessed", "(Ljava/lang/String;)V", "GetOnScanSuccessed_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Interfaces.IScanResultInvoker, VanstonePosSdk")]
		void OnScanSuccessed (string? p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IScanResult$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IScanResult$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Default']/constructor[@name='IScanResult.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_onButtonClick_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnButtonClick_Ljava_lang_String_Handler ()
			{
				if (cb_onButtonClick_Ljava_lang_String_ == null)
					cb_onButtonClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnButtonClick_Ljava_lang_String_));
				return cb_onButtonClick_Ljava_lang_String_;
			}

			static void n_OnButtonClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnButtonClick (msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Default']/method[@name='onButtonClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onButtonClick", "(Ljava/lang/String;)V", "GetOnButtonClick_Ljava_lang_String_Handler")]
			public virtual unsafe void OnButtonClick (string? msg)
			{
				const string __id = "onButtonClick.(Ljava/lang/String;)V";
				IntPtr native_msg = JNIEnv.NewString ((string?)msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_msg);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_msg);
				}
			}

			static Delegate? cb_onScanFailed_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnScanFailed_ILjava_lang_String_Handler ()
			{
				if (cb_onScanFailed_ILjava_lang_String_ == null)
					cb_onScanFailed_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnScanFailed_ILjava_lang_String_));
				return cb_onScanFailed_ILjava_lang_String_;
			}

			static void n_OnScanFailed_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int errCode, IntPtr native_errMsg)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var errMsg = JNIEnv.GetString (native_errMsg, JniHandleOwnership.DoNotTransfer);
				__this.OnScanFailed (errCode, errMsg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Default']/method[@name='onScanFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onScanFailed", "(ILjava/lang/String;)V", "GetOnScanFailed_ILjava_lang_String_Handler")]
			public virtual unsafe void OnScanFailed (int errCode, string? errMsg)
			{
				const string __id = "onScanFailed.(ILjava/lang/String;)V";
				IntPtr native_errMsg = JNIEnv.NewString ((string?)errMsg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (errCode);
					__args [1] = new JniArgumentValue (native_errMsg);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_errMsg);
				}
			}

			static Delegate? cb_onScanSuccessed_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnScanSuccessed_Ljava_lang_String_Handler ()
			{
				if (cb_onScanSuccessed_Ljava_lang_String_ == null)
					cb_onScanSuccessed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnScanSuccessed_Ljava_lang_String_));
				return cb_onScanSuccessed_Ljava_lang_String_;
			}

			static void n_OnScanSuccessed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var scanCode = JNIEnv.GetString (native_scanCode, JniHandleOwnership.DoNotTransfer);
				__this.OnScanSuccessed (scanCode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Default']/method[@name='onScanSuccessed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onScanSuccessed", "(Ljava/lang/String;)V", "GetOnScanSuccessed_Ljava_lang_String_Handler")]
			public virtual unsafe void OnScanSuccessed (string? scanCode)
			{
				const string __id = "onScanSuccessed.(Ljava/lang/String;)V";
				IntPtr native_scanCode = JNIEnv.NewString ((string?)scanCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scanCode);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_scanCode);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IScanResult$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IScanResult$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Stub']/constructor[@name='IScanResult.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/interfaces/IScanResult;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/interfaces/IScanResult;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IScanResult;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IScanResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IScanResult.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IScanResult']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/interfaces/IScanResult;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/interfaces/IScanResult;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_onButtonClick_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnButtonClick_Ljava_lang_String_Handler ()
			{
				if (cb_onButtonClick_Ljava_lang_String_ == null)
					cb_onButtonClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnButtonClick_Ljava_lang_String_));
				return cb_onButtonClick_Ljava_lang_String_;
			}

			static void n_OnButtonClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnButtonClick (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onButtonClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onButtonClick", "(Ljava/lang/String;)V", "GetOnButtonClick_Ljava_lang_String_Handler")]
			public abstract void OnButtonClick (string? p0);

			static Delegate? cb_onScanFailed_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnScanFailed_ILjava_lang_String_Handler ()
			{
				if (cb_onScanFailed_ILjava_lang_String_ == null)
					cb_onScanFailed_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnScanFailed_ILjava_lang_String_));
				return cb_onScanFailed_ILjava_lang_String_;
			}

			static void n_OnScanFailed_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnScanFailed (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onScanFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onScanFailed", "(ILjava/lang/String;)V", "GetOnScanFailed_ILjava_lang_String_Handler")]
			public abstract void OnScanFailed (int p0, string? p1);

			static Delegate? cb_onScanSuccessed_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnScanSuccessed_Ljava_lang_String_Handler ()
			{
				if (cb_onScanSuccessed_Ljava_lang_String_ == null)
					cb_onScanSuccessed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnScanSuccessed_Ljava_lang_String_));
				return cb_onScanSuccessed_Ljava_lang_String_;
			}

			static void n_OnScanSuccessed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnScanSuccessed (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onScanSuccessed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onScanSuccessed", "(Ljava/lang/String;)V", "GetOnScanSuccessed_Ljava_lang_String_Handler")]
			public abstract void OnScanSuccessed (string? p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IScanResult$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IScanResult$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onButtonClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onButtonClick", "(Ljava/lang/String;)V", "GetOnButtonClick_Ljava_lang_String_Handler")]
			public override unsafe void OnButtonClick (string? p0)
			{
				const string __id = "onButtonClick.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onScanFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onScanFailed", "(ILjava/lang/String;)V", "GetOnScanFailed_ILjava_lang_String_Handler")]
			public override unsafe void OnScanFailed (int p0, string? p1)
			{
				const string __id = "onScanFailed.(ILjava/lang/String;)V";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IScanResult']/method[@name='onScanSuccessed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onScanSuccessed", "(Ljava/lang/String;)V", "GetOnScanSuccessed_Ljava_lang_String_Handler")]
			public override unsafe void OnScanSuccessed (string? p0)
			{
				const string __id = "onScanSuccessed.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IScanResult", DoNotGenerateAcw=true)]
	internal partial class IScanResultInvoker : global::Java.Lang.Object, IScanResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IScanResult", typeof (IScanResultInvoker));

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

		public static IScanResult? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScanResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.interfaces.IScanResult'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScanResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onButtonClick_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnButtonClick_Ljava_lang_String_Handler ()
		{
			if (cb_onButtonClick_Ljava_lang_String_ == null)
				cb_onButtonClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnButtonClick_Ljava_lang_String_));
			return cb_onButtonClick_Ljava_lang_String_;
		}

		static void n_OnButtonClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onButtonClick_Ljava_lang_String_;
		public unsafe void OnButtonClick (string? p0)
		{
			if (id_onButtonClick_Ljava_lang_String_ == IntPtr.Zero)
				id_onButtonClick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onButtonClick", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onButtonClick_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_onScanFailed_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnScanFailed_ILjava_lang_String_Handler ()
		{
			if (cb_onScanFailed_ILjava_lang_String_ == null)
				cb_onScanFailed_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnScanFailed_ILjava_lang_String_));
			return cb_onScanFailed_ILjava_lang_String_;
		}

		static void n_OnScanFailed_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnScanFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onScanFailed_ILjava_lang_String_;
		public unsafe void OnScanFailed (int p0, string? p1)
		{
			if (id_onScanFailed_ILjava_lang_String_ == IntPtr.Zero)
				id_onScanFailed_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onScanFailed", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanFailed_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_onScanSuccessed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnScanSuccessed_Ljava_lang_String_Handler ()
		{
			if (cb_onScanSuccessed_Ljava_lang_String_ == null)
				cb_onScanSuccessed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnScanSuccessed_Ljava_lang_String_));
			return cb_onScanSuccessed_Ljava_lang_String_;
		}

		static void n_OnScanSuccessed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScanSuccessed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onScanSuccessed_Ljava_lang_String_;
		public unsafe void OnScanSuccessed (string? p0)
		{
			if (id_onScanSuccessed_Ljava_lang_String_ == IntPtr.Zero)
				id_onScanSuccessed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onScanSuccessed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanSuccessed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
