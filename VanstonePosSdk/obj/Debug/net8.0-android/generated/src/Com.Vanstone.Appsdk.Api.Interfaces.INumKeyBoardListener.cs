using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']"
	[Register ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener", "", "Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker")]
	public partial interface INumKeyBoardListener : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onAvailable' and count(parameter)=0]"
		[Register ("onAvailable", "()V", "GetOnAvailableHandler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker, VanstonePosSdk")]
		void OnAvailable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onDisplayUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDisplayUpdate", "(Ljava/lang/String;)V", "GetOnDisplayUpdate_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker, VanstonePosSdk")]
		void OnDisplayUpdate (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onException", "(Ljava/lang/String;)V", "GetOnException_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker, VanstonePosSdk")]
		void OnException (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onKeyDown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onKeyDown", "(ILjava/lang/String;)V", "GetOnKeyDown_ILjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker, VanstonePosSdk")]
		void OnKeyDown (int p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onKeyUp", "(ILjava/lang/String;)V", "GetOnKeyUp_ILjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker, VanstonePosSdk")]
		void OnKeyUp (int p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onPayRequest' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyPayRequest']]"
		[Register ("onPayRequest", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)V", "GetOnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_Handler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker, VanstonePosSdk")]
		void OnPayRequest (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onRelease' and count(parameter)=0]"
		[Register ("onRelease", "()V", "GetOnReleaseHandler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListenerInvoker, VanstonePosSdk")]
		void OnRelease ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/constructor[@name='INumKeyBoardListener.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_onAvailable;
#pragma warning disable 0169
			static Delegate GetOnAvailableHandler ()
			{
				if (cb_onAvailable == null)
					cb_onAvailable = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAvailable));
				return cb_onAvailable;
			}

			static void n_OnAvailable (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnAvailable ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='onAvailable' and count(parameter)=0]"
			[Register ("onAvailable", "()V", "GetOnAvailableHandler")]
			public virtual unsafe void OnAvailable ()
			{
				const string __id = "onAvailable.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_onDisplayUpdate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnDisplayUpdate_Ljava_lang_String_Handler ()
			{
				if (cb_onDisplayUpdate_Ljava_lang_String_ == null)
					cb_onDisplayUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnDisplayUpdate_Ljava_lang_String_));
				return cb_onDisplayUpdate_Ljava_lang_String_;
			}

			static void n_OnDisplayUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				__this.OnDisplayUpdate (text);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='onDisplayUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onDisplayUpdate", "(Ljava/lang/String;)V", "GetOnDisplayUpdate_Ljava_lang_String_Handler")]
			public virtual unsafe void OnDisplayUpdate (string? text)
			{
				const string __id = "onDisplayUpdate.(Ljava/lang/String;)V";
				IntPtr native_text = JNIEnv.NewString ((string?)text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

			static Delegate? cb_onException_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnException_Ljava_lang_String_Handler ()
			{
				if (cb_onException_Ljava_lang_String_ == null)
					cb_onException_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnException_Ljava_lang_String_));
				return cb_onException_Ljava_lang_String_;
			}

			static void n_OnException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var exception = JNIEnv.GetString (native_exception, JniHandleOwnership.DoNotTransfer);
				__this.OnException (exception);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onException", "(Ljava/lang/String;)V", "GetOnException_Ljava_lang_String_Handler")]
			public virtual unsafe void OnException (string? exception)
			{
				const string __id = "onException.(Ljava/lang/String;)V";
				IntPtr native_exception = JNIEnv.NewString ((string?)exception);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_exception);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_exception);
				}
			}

			static Delegate? cb_onKeyDown_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnKeyDown_ILjava_lang_String_Handler ()
			{
				if (cb_onKeyDown_ILjava_lang_String_ == null)
					cb_onKeyDown_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnKeyDown_ILjava_lang_String_));
				return cb_onKeyDown_ILjava_lang_String_;
			}

			static void n_OnKeyDown_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_keyName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var keyName = JNIEnv.GetString (native_keyName, JniHandleOwnership.DoNotTransfer);
				__this.OnKeyDown (keyCode, keyName);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='onKeyDown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onKeyDown", "(ILjava/lang/String;)V", "GetOnKeyDown_ILjava_lang_String_Handler")]
			public virtual unsafe void OnKeyDown (int keyCode, string? keyName)
			{
				const string __id = "onKeyDown.(ILjava/lang/String;)V";
				IntPtr native_keyName = JNIEnv.NewString ((string?)keyName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyCode);
					__args [1] = new JniArgumentValue (native_keyName);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_keyName);
				}
			}

			static Delegate? cb_onKeyUp_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnKeyUp_ILjava_lang_String_Handler ()
			{
				if (cb_onKeyUp_ILjava_lang_String_ == null)
					cb_onKeyUp_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnKeyUp_ILjava_lang_String_));
				return cb_onKeyUp_ILjava_lang_String_;
			}

			static void n_OnKeyUp_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_keyName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var keyName = JNIEnv.GetString (native_keyName, JniHandleOwnership.DoNotTransfer);
				__this.OnKeyUp (keyCode, keyName);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onKeyUp", "(ILjava/lang/String;)V", "GetOnKeyUp_ILjava_lang_String_Handler")]
			public virtual unsafe void OnKeyUp (int keyCode, string? keyName)
			{
				const string __id = "onKeyUp.(ILjava/lang/String;)V";
				IntPtr native_keyName = JNIEnv.NewString ((string?)keyName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyCode);
					__args [1] = new JniArgumentValue (native_keyName);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_keyName);
				}
			}

			static Delegate? cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_;
#pragma warning disable 0169
			static Delegate GetOnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_Handler ()
			{
				if (cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ == null)
					cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_));
				return cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_;
			}

			static void n_OnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var request = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (native_request, JniHandleOwnership.DoNotTransfer);
				__this.OnPayRequest (request);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='onPayRequest' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyPayRequest']]"
			[Register ("onPayRequest", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)V", "GetOnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_Handler")]
			public virtual unsafe void OnPayRequest (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? request)
			{
				const string __id = "onPayRequest.(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (request);
				}
			}

			static Delegate? cb_onRelease;
#pragma warning disable 0169
			static Delegate GetOnReleaseHandler ()
			{
				if (cb_onRelease == null)
					cb_onRelease = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRelease));
				return cb_onRelease;
			}

			static void n_OnRelease (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnRelease ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Default']/method[@name='onRelease' and count(parameter)=0]"
			[Register ("onRelease", "()V", "GetOnReleaseHandler")]
			public virtual unsafe void OnRelease ()
			{
				const string __id = "onRelease.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Stub']/constructor[@name='INumKeyBoardListener.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyBoardListener.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardListener']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_onAvailable;
#pragma warning disable 0169
			static Delegate GetOnAvailableHandler ()
			{
				if (cb_onAvailable == null)
					cb_onAvailable = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAvailable));
				return cb_onAvailable;
			}

			static void n_OnAvailable (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnAvailable ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onAvailable' and count(parameter)=0]"
			[Register ("onAvailable", "()V", "GetOnAvailableHandler")]
			public abstract void OnAvailable ();

			static Delegate? cb_onDisplayUpdate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnDisplayUpdate_Ljava_lang_String_Handler ()
			{
				if (cb_onDisplayUpdate_Ljava_lang_String_ == null)
					cb_onDisplayUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnDisplayUpdate_Ljava_lang_String_));
				return cb_onDisplayUpdate_Ljava_lang_String_;
			}

			static void n_OnDisplayUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisplayUpdate (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onDisplayUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onDisplayUpdate", "(Ljava/lang/String;)V", "GetOnDisplayUpdate_Ljava_lang_String_Handler")]
			public abstract void OnDisplayUpdate (string? p0);

			static Delegate? cb_onException_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnException_Ljava_lang_String_Handler ()
			{
				if (cb_onException_Ljava_lang_String_ == null)
					cb_onException_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnException_Ljava_lang_String_));
				return cb_onException_Ljava_lang_String_;
			}

			static void n_OnException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnException (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onException", "(Ljava/lang/String;)V", "GetOnException_Ljava_lang_String_Handler")]
			public abstract void OnException (string? p0);

			static Delegate? cb_onKeyDown_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnKeyDown_ILjava_lang_String_Handler ()
			{
				if (cb_onKeyDown_ILjava_lang_String_ == null)
					cb_onKeyDown_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnKeyDown_ILjava_lang_String_));
				return cb_onKeyDown_ILjava_lang_String_;
			}

			static void n_OnKeyDown_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnKeyDown (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onKeyDown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onKeyDown", "(ILjava/lang/String;)V", "GetOnKeyDown_ILjava_lang_String_Handler")]
			public abstract void OnKeyDown (int p0, string? p1);

			static Delegate? cb_onKeyUp_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnKeyUp_ILjava_lang_String_Handler ()
			{
				if (cb_onKeyUp_ILjava_lang_String_ == null)
					cb_onKeyUp_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnKeyUp_ILjava_lang_String_));
				return cb_onKeyUp_ILjava_lang_String_;
			}

			static void n_OnKeyUp_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnKeyUp (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onKeyUp", "(ILjava/lang/String;)V", "GetOnKeyUp_ILjava_lang_String_Handler")]
			public abstract void OnKeyUp (int p0, string? p1);

			static Delegate? cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_;
#pragma warning disable 0169
			static Delegate GetOnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_Handler ()
			{
				if (cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ == null)
					cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_));
				return cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_;
			}

			static void n_OnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPayRequest (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onPayRequest' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyPayRequest']]"
			[Register ("onPayRequest", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)V", "GetOnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_Handler")]
			public abstract void OnPayRequest (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? p0);

			static Delegate? cb_onRelease;
#pragma warning disable 0169
			static Delegate GetOnReleaseHandler ()
			{
				if (cb_onRelease == null)
					cb_onRelease = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRelease));
				return cb_onRelease;
			}

			static void n_OnRelease (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnRelease ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onRelease' and count(parameter)=0]"
			[Register ("onRelease", "()V", "GetOnReleaseHandler")]
			public abstract void OnRelease ();

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onAvailable' and count(parameter)=0]"
			[Register ("onAvailable", "()V", "GetOnAvailableHandler")]
			public override unsafe void OnAvailable ()
			{
				const string __id = "onAvailable.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onDisplayUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onDisplayUpdate", "(Ljava/lang/String;)V", "GetOnDisplayUpdate_Ljava_lang_String_Handler")]
			public override unsafe void OnDisplayUpdate (string? p0)
			{
				const string __id = "onDisplayUpdate.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onException", "(Ljava/lang/String;)V", "GetOnException_Ljava_lang_String_Handler")]
			public override unsafe void OnException (string? p0)
			{
				const string __id = "onException.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onKeyDown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onKeyDown", "(ILjava/lang/String;)V", "GetOnKeyDown_ILjava_lang_String_Handler")]
			public override unsafe void OnKeyDown (int p0, string? p1)
			{
				const string __id = "onKeyDown.(ILjava/lang/String;)V";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onKeyUp", "(ILjava/lang/String;)V", "GetOnKeyUp_ILjava_lang_String_Handler")]
			public override unsafe void OnKeyUp (int p0, string? p1)
			{
				const string __id = "onKeyUp.(ILjava/lang/String;)V";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onPayRequest' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyPayRequest']]"
			[Register ("onPayRequest", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)V", "GetOnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_Handler")]
			public override unsafe void OnPayRequest (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? p0)
			{
				const string __id = "onPayRequest.(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyBoardListener']/method[@name='onRelease' and count(parameter)=0]"
			[Register ("onRelease", "()V", "GetOnReleaseHandler")]
			public override unsafe void OnRelease ()
			{
				const string __id = "onRelease.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener", DoNotGenerateAcw=true)]
	internal partial class INumKeyBoardListenerInvoker : global::Java.Lang.Object, INumKeyBoardListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyBoardListener", typeof (INumKeyBoardListenerInvoker));

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

		public static INumKeyBoardListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INumKeyBoardListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.interfaces.INumKeyBoardListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INumKeyBoardListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onAvailable;
#pragma warning disable 0169
		static Delegate GetOnAvailableHandler ()
		{
			if (cb_onAvailable == null)
				cb_onAvailable = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAvailable));
			return cb_onAvailable;
		}

		static void n_OnAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnAvailable ();
		}
#pragma warning restore 0169

		IntPtr id_onAvailable;
		public unsafe void OnAvailable ()
		{
			if (id_onAvailable == IntPtr.Zero)
				id_onAvailable = JNIEnv.GetMethodID (class_ref, "onAvailable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAvailable);
		}

		static Delegate? cb_onDisplayUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDisplayUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_onDisplayUpdate_Ljava_lang_String_ == null)
				cb_onDisplayUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnDisplayUpdate_Ljava_lang_String_));
			return cb_onDisplayUpdate_Ljava_lang_String_;
		}

		static void n_OnDisplayUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisplayUpdate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDisplayUpdate_Ljava_lang_String_;
		public unsafe void OnDisplayUpdate (string? p0)
		{
			if (id_onDisplayUpdate_Ljava_lang_String_ == IntPtr.Zero)
				id_onDisplayUpdate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDisplayUpdate", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisplayUpdate_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_onException_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnException_Ljava_lang_String_Handler ()
		{
			if (cb_onException_Ljava_lang_String_ == null)
				cb_onException_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnException_Ljava_lang_String_));
			return cb_onException_Ljava_lang_String_;
		}

		static void n_OnException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onException_Ljava_lang_String_;
		public unsafe void OnException (string? p0)
		{
			if (id_onException_Ljava_lang_String_ == IntPtr.Zero)
				id_onException_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onException", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onException_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_onKeyDown_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnKeyDown_ILjava_lang_String_Handler ()
		{
			if (cb_onKeyDown_ILjava_lang_String_ == null)
				cb_onKeyDown_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnKeyDown_ILjava_lang_String_));
			return cb_onKeyDown_ILjava_lang_String_;
		}

		static void n_OnKeyDown_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyDown (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onKeyDown_ILjava_lang_String_;
		public unsafe void OnKeyDown (int p0, string? p1)
		{
			if (id_onKeyDown_ILjava_lang_String_ == IntPtr.Zero)
				id_onKeyDown_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onKeyDown", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKeyDown_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_onKeyUp_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnKeyUp_ILjava_lang_String_Handler ()
		{
			if (cb_onKeyUp_ILjava_lang_String_ == null)
				cb_onKeyUp_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnKeyUp_ILjava_lang_String_));
			return cb_onKeyUp_ILjava_lang_String_;
		}

		static void n_OnKeyUp_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyUp (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onKeyUp_ILjava_lang_String_;
		public unsafe void OnKeyUp (int p0, string? p1)
		{
			if (id_onKeyUp_ILjava_lang_String_ == IntPtr.Zero)
				id_onKeyUp_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onKeyUp", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKeyUp_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_;
#pragma warning disable 0169
		static Delegate GetOnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_Handler ()
		{
			if (cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ == null)
				cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_));
			return cb_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_;
		}

		static void n_OnPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPayRequest (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_;
		public unsafe void OnPayRequest (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? p0)
		{
			if (id_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ == IntPtr.Zero)
				id_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_ = JNIEnv.GetMethodID (class_ref, "onPayRequest", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPayRequest_Lcom_vanstone_appsdk_api_interfaces_INumKeyPayRequest_, __args);
		}

		static Delegate? cb_onRelease;
#pragma warning disable 0169
		static Delegate GetOnReleaseHandler ()
		{
			if (cb_onRelease == null)
				cb_onRelease = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRelease));
			return cb_onRelease;
		}

		static void n_OnRelease (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnRelease ();
		}
#pragma warning restore 0169

		IntPtr id_onRelease;
		public unsafe void OnRelease ()
		{
			if (id_onRelease == IntPtr.Zero)
				id_onRelease = JNIEnv.GetMethodID (class_ref, "onRelease", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRelease);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
