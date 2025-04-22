using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Numkeyboard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']"
	[Register ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler", "", "Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker")]
	public partial interface INumKeyBoardHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyClose_Api' and count(parameter)=0]"
		[Register ("NumKeyClose_Api", "()V", "GetNumKeyClose_ApiHandler:Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker, VanstonePosSdk")]
		void NumKeyClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyDisplayText_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("NumKeyDisplayText_Api", "(Ljava/lang/String;)V", "GetNumKeyDisplayText_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker, VanstonePosSdk")]
		void NumKeyDisplayText_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyOpen_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("NumKeyOpen_Api", "(Landroid/os/Bundle;)V", "GetNumKeyOpen_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker, VanstonePosSdk")]
		void NumKeyOpen_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyReset_Api' and count(parameter)=0]"
		[Register ("NumKeyReset_Api", "()V", "GetNumKeyReset_ApiHandler:Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker, VanstonePosSdk")]
		void NumKeyReset_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeySetCheckListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardCheckAIDL']]"
		[Register ("NumKeySetCheckListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardCheckAIDL;)V", "GetNumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_Handler:Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker, VanstonePosSdk")]
		void NumKeySetCheckListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeySetKeyboardListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardListener']]"
		[Register ("NumKeySetKeyboardListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)V", "GetNumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_Handler:Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker, VanstonePosSdk")]
		void NumKeySetKeyboardListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyUpdateKeyboardSignal_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("NumKeyUpdateKeyboardSignal_Api", "(II)Z", "GetNumKeyUpdateKeyboardSignal_Api_IIHandler:Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandlerInvoker, VanstonePosSdk")]
		bool NumKeyUpdateKeyboardSignal_Api (int p0, int p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/constructor[@name='NumKeyBoardHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_NumKeyClose_Api;
#pragma warning disable 0169
			static Delegate GetNumKeyClose_ApiHandler ()
			{
				if (cb_NumKeyClose_Api == null)
					cb_NumKeyClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NumKeyClose_Api));
				return cb_NumKeyClose_Api;
			}

			static void n_NumKeyClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NumKeyClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='NumKeyClose_Api' and count(parameter)=0]"
			[Register ("NumKeyClose_Api", "()V", "GetNumKeyClose_ApiHandler")]
			public virtual unsafe void NumKeyClose_Api ()
			{
				const string __id = "NumKeyClose_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_NumKeyDisplayText_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNumKeyDisplayText_Api_Ljava_lang_String_Handler ()
			{
				if (cb_NumKeyDisplayText_Api_Ljava_lang_String_ == null)
					cb_NumKeyDisplayText_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeyDisplayText_Api_Ljava_lang_String_));
				return cb_NumKeyDisplayText_Api_Ljava_lang_String_;
			}

			static void n_NumKeyDisplayText_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				__this.NumKeyDisplayText_Api (text);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='NumKeyDisplayText_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("NumKeyDisplayText_Api", "(Ljava/lang/String;)V", "GetNumKeyDisplayText_Api_Ljava_lang_String_Handler")]
			public virtual unsafe void NumKeyDisplayText_Api (string? text)
			{
				const string __id = "NumKeyDisplayText_Api.(Ljava/lang/String;)V";
				IntPtr native_text = JNIEnv.NewString ((string?)text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

			static Delegate? cb_NumKeyOpen_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetNumKeyOpen_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_NumKeyOpen_Api_Landroid_os_Bundle_ == null)
					cb_NumKeyOpen_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeyOpen_Api_Landroid_os_Bundle_));
				return cb_NumKeyOpen_Api_Landroid_os_Bundle_;
			}

			static void n_NumKeyOpen_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @params = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native__params, JniHandleOwnership.DoNotTransfer);
				__this.NumKeyOpen_Api (@params);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='NumKeyOpen_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("NumKeyOpen_Api", "(Landroid/os/Bundle;)V", "GetNumKeyOpen_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe void NumKeyOpen_Api (global::Android.OS.Bundle? @params)
			{
				const string __id = "NumKeyOpen_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@params);
				}
			}

			static Delegate? cb_NumKeyReset_Api;
#pragma warning disable 0169
			static Delegate GetNumKeyReset_ApiHandler ()
			{
				if (cb_NumKeyReset_Api == null)
					cb_NumKeyReset_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NumKeyReset_Api));
				return cb_NumKeyReset_Api;
			}

			static void n_NumKeyReset_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NumKeyReset_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='NumKeyReset_Api' and count(parameter)=0]"
			[Register ("NumKeyReset_Api", "()V", "GetNumKeyReset_ApiHandler")]
			public virtual unsafe void NumKeyReset_Api ()
			{
				const string __id = "NumKeyReset_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_;
#pragma warning disable 0169
			static Delegate GetNumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_Handler ()
			{
				if (cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ == null)
					cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_));
				return cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_;
			}

			static void n_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				__this.NumKeySetCheckListener_Api (listener);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='NumKeySetCheckListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardCheckAIDL']]"
			[Register ("NumKeySetCheckListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardCheckAIDL;)V", "GetNumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_Handler")]
			public virtual unsafe void NumKeySetCheckListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL? listener)
			{
				const string __id = "NumKeySetCheckListener_Api.(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardCheckAIDL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_;
#pragma warning disable 0169
			static Delegate GetNumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_Handler ()
			{
				if (cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ == null)
					cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_));
				return cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_;
			}

			static void n_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				__this.NumKeySetKeyboardListener_Api (listener);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='NumKeySetKeyboardListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardListener']]"
			[Register ("NumKeySetKeyboardListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)V", "GetNumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_Handler")]
			public virtual unsafe void NumKeySetKeyboardListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? listener)
			{
				const string __id = "NumKeySetKeyboardListener_Api.(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_NumKeyUpdateKeyboardSignal_Api_II;
#pragma warning disable 0169
			static Delegate GetNumKeyUpdateKeyboardSignal_Api_IIHandler ()
			{
				if (cb_NumKeyUpdateKeyboardSignal_Api_II == null)
					cb_NumKeyUpdateKeyboardSignal_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_NumKeyUpdateKeyboardSignal_Api_II));
				return cb_NumKeyUpdateKeyboardSignal_Api_II;
			}

			static bool n_NumKeyUpdateKeyboardSignal_Api_II (IntPtr jnienv, IntPtr native__this, int wifi, int gprs)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NumKeyUpdateKeyboardSignal_Api (wifi, gprs);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='NumKeyUpdateKeyboardSignal_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("NumKeyUpdateKeyboardSignal_Api", "(II)Z", "GetNumKeyUpdateKeyboardSignal_Api_IIHandler")]
			public virtual unsafe bool NumKeyUpdateKeyboardSignal_Api (int wifi, int gprs)
			{
				const string __id = "NumKeyUpdateKeyboardSignal_Api.(II)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (wifi);
					__args [1] = new JniArgumentValue (gprs);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Stub']/constructor[@name='NumKeyBoardHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/class[@name='NumKeyBoardHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.numkeyboard.NumKeyBoardHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_NumKeyClose_Api;
#pragma warning disable 0169
			static Delegate GetNumKeyClose_ApiHandler ()
			{
				if (cb_NumKeyClose_Api == null)
					cb_NumKeyClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NumKeyClose_Api));
				return cb_NumKeyClose_Api;
			}

			static void n_NumKeyClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NumKeyClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyClose_Api' and count(parameter)=0]"
			[Register ("NumKeyClose_Api", "()V", "GetNumKeyClose_ApiHandler")]
			public abstract void NumKeyClose_Api ();

			static Delegate? cb_NumKeyDisplayText_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNumKeyDisplayText_Api_Ljava_lang_String_Handler ()
			{
				if (cb_NumKeyDisplayText_Api_Ljava_lang_String_ == null)
					cb_NumKeyDisplayText_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeyDisplayText_Api_Ljava_lang_String_));
				return cb_NumKeyDisplayText_Api_Ljava_lang_String_;
			}

			static void n_NumKeyDisplayText_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NumKeyDisplayText_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyDisplayText_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("NumKeyDisplayText_Api", "(Ljava/lang/String;)V", "GetNumKeyDisplayText_Api_Ljava_lang_String_Handler")]
			public abstract void NumKeyDisplayText_Api (string? p0);

			static Delegate? cb_NumKeyOpen_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetNumKeyOpen_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_NumKeyOpen_Api_Landroid_os_Bundle_ == null)
					cb_NumKeyOpen_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeyOpen_Api_Landroid_os_Bundle_));
				return cb_NumKeyOpen_Api_Landroid_os_Bundle_;
			}

			static void n_NumKeyOpen_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NumKeyOpen_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyOpen_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("NumKeyOpen_Api", "(Landroid/os/Bundle;)V", "GetNumKeyOpen_Api_Landroid_os_Bundle_Handler")]
			public abstract void NumKeyOpen_Api (global::Android.OS.Bundle? p0);

			static Delegate? cb_NumKeyReset_Api;
#pragma warning disable 0169
			static Delegate GetNumKeyReset_ApiHandler ()
			{
				if (cb_NumKeyReset_Api == null)
					cb_NumKeyReset_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NumKeyReset_Api));
				return cb_NumKeyReset_Api;
			}

			static void n_NumKeyReset_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.NumKeyReset_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyReset_Api' and count(parameter)=0]"
			[Register ("NumKeyReset_Api", "()V", "GetNumKeyReset_ApiHandler")]
			public abstract void NumKeyReset_Api ();

			static Delegate? cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_;
#pragma warning disable 0169
			static Delegate GetNumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_Handler ()
			{
				if (cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ == null)
					cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_));
				return cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_;
			}

			static void n_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NumKeySetCheckListener_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeySetCheckListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardCheckAIDL']]"
			[Register ("NumKeySetCheckListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardCheckAIDL;)V", "GetNumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_Handler")]
			public abstract void NumKeySetCheckListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL? p0);

			static Delegate? cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_;
#pragma warning disable 0169
			static Delegate GetNumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_Handler ()
			{
				if (cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ == null)
					cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_));
				return cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_;
			}

			static void n_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NumKeySetKeyboardListener_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeySetKeyboardListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardListener']]"
			[Register ("NumKeySetKeyboardListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)V", "GetNumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_Handler")]
			public abstract void NumKeySetKeyboardListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? p0);

			static Delegate? cb_NumKeyUpdateKeyboardSignal_Api_II;
#pragma warning disable 0169
			static Delegate GetNumKeyUpdateKeyboardSignal_Api_IIHandler ()
			{
				if (cb_NumKeyUpdateKeyboardSignal_Api_II == null)
					cb_NumKeyUpdateKeyboardSignal_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_NumKeyUpdateKeyboardSignal_Api_II));
				return cb_NumKeyUpdateKeyboardSignal_Api_II;
			}

			static bool n_NumKeyUpdateKeyboardSignal_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NumKeyUpdateKeyboardSignal_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyUpdateKeyboardSignal_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("NumKeyUpdateKeyboardSignal_Api", "(II)Z", "GetNumKeyUpdateKeyboardSignal_Api_IIHandler")]
			public abstract bool NumKeyUpdateKeyboardSignal_Api (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyClose_Api' and count(parameter)=0]"
			[Register ("NumKeyClose_Api", "()V", "GetNumKeyClose_ApiHandler")]
			public override unsafe void NumKeyClose_Api ()
			{
				const string __id = "NumKeyClose_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyDisplayText_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("NumKeyDisplayText_Api", "(Ljava/lang/String;)V", "GetNumKeyDisplayText_Api_Ljava_lang_String_Handler")]
			public override unsafe void NumKeyDisplayText_Api (string? p0)
			{
				const string __id = "NumKeyDisplayText_Api.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyOpen_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("NumKeyOpen_Api", "(Landroid/os/Bundle;)V", "GetNumKeyOpen_Api_Landroid_os_Bundle_Handler")]
			public override unsafe void NumKeyOpen_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "NumKeyOpen_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyReset_Api' and count(parameter)=0]"
			[Register ("NumKeyReset_Api", "()V", "GetNumKeyReset_ApiHandler")]
			public override unsafe void NumKeyReset_Api ()
			{
				const string __id = "NumKeyReset_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeySetCheckListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardCheckAIDL']]"
			[Register ("NumKeySetCheckListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardCheckAIDL;)V", "GetNumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_Handler")]
			public override unsafe void NumKeySetCheckListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL? p0)
			{
				const string __id = "NumKeySetCheckListener_Api.(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardCheckAIDL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeySetKeyboardListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyBoardListener']]"
			[Register ("NumKeySetKeyboardListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)V", "GetNumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_Handler")]
			public override unsafe void NumKeySetKeyboardListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? p0)
			{
				const string __id = "NumKeySetKeyboardListener_Api.(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.numkeyboard']/interface[@name='NumKeyBoardHandler']/method[@name='NumKeyUpdateKeyboardSignal_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("NumKeyUpdateKeyboardSignal_Api", "(II)Z", "GetNumKeyUpdateKeyboardSignal_Api_IIHandler")]
			public override unsafe bool NumKeyUpdateKeyboardSignal_Api (int p0, int p1)
			{
				const string __id = "NumKeyUpdateKeyboardSignal_Api.(II)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler", DoNotGenerateAcw=true)]
	internal partial class INumKeyBoardHandlerInvoker : global::Java.Lang.Object, INumKeyBoardHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/numkeyboard/NumKeyBoardHandler", typeof (INumKeyBoardHandlerInvoker));

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

		public static INumKeyBoardHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INumKeyBoardHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.numkeyboard.NumKeyBoardHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INumKeyBoardHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_NumKeyClose_Api;
#pragma warning disable 0169
		static Delegate GetNumKeyClose_ApiHandler ()
		{
			if (cb_NumKeyClose_Api == null)
				cb_NumKeyClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NumKeyClose_Api));
			return cb_NumKeyClose_Api;
		}

		static void n_NumKeyClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.NumKeyClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_NumKeyClose_Api;
		public unsafe void NumKeyClose_Api ()
		{
			if (id_NumKeyClose_Api == IntPtr.Zero)
				id_NumKeyClose_Api = JNIEnv.GetMethodID (class_ref, "NumKeyClose_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NumKeyClose_Api);
		}

		static Delegate? cb_NumKeyDisplayText_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNumKeyDisplayText_Api_Ljava_lang_String_Handler ()
		{
			if (cb_NumKeyDisplayText_Api_Ljava_lang_String_ == null)
				cb_NumKeyDisplayText_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeyDisplayText_Api_Ljava_lang_String_));
			return cb_NumKeyDisplayText_Api_Ljava_lang_String_;
		}

		static void n_NumKeyDisplayText_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NumKeyDisplayText_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NumKeyDisplayText_Api_Ljava_lang_String_;
		public unsafe void NumKeyDisplayText_Api (string? p0)
		{
			if (id_NumKeyDisplayText_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_NumKeyDisplayText_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "NumKeyDisplayText_Api", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NumKeyDisplayText_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_NumKeyOpen_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetNumKeyOpen_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_NumKeyOpen_Api_Landroid_os_Bundle_ == null)
				cb_NumKeyOpen_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeyOpen_Api_Landroid_os_Bundle_));
			return cb_NumKeyOpen_Api_Landroid_os_Bundle_;
		}

		static void n_NumKeyOpen_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NumKeyOpen_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NumKeyOpen_Api_Landroid_os_Bundle_;
		public unsafe void NumKeyOpen_Api (global::Android.OS.Bundle? p0)
		{
			if (id_NumKeyOpen_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_NumKeyOpen_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "NumKeyOpen_Api", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NumKeyOpen_Api_Landroid_os_Bundle_, __args);
		}

		static Delegate? cb_NumKeyReset_Api;
#pragma warning disable 0169
		static Delegate GetNumKeyReset_ApiHandler ()
		{
			if (cb_NumKeyReset_Api == null)
				cb_NumKeyReset_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_NumKeyReset_Api));
			return cb_NumKeyReset_Api;
		}

		static void n_NumKeyReset_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.NumKeyReset_Api ();
		}
#pragma warning restore 0169

		IntPtr id_NumKeyReset_Api;
		public unsafe void NumKeyReset_Api ()
		{
			if (id_NumKeyReset_Api == IntPtr.Zero)
				id_NumKeyReset_Api = JNIEnv.GetMethodID (class_ref, "NumKeyReset_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NumKeyReset_Api);
		}

		static Delegate? cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_;
#pragma warning disable 0169
		static Delegate GetNumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_Handler ()
		{
			if (cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ == null)
				cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_));
			return cb_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_;
		}

		static void n_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NumKeySetCheckListener_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_;
		public unsafe void NumKeySetCheckListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardCheckAIDL? p0)
		{
			if (id_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ == IntPtr.Zero)
				id_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_ = JNIEnv.GetMethodID (class_ref, "NumKeySetCheckListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardCheckAIDL;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NumKeySetCheckListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardCheckAIDL_, __args);
		}

		static Delegate? cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_;
#pragma warning disable 0169
		static Delegate GetNumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_Handler ()
		{
			if (cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ == null)
				cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_));
			return cb_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_;
		}

		static void n_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NumKeySetKeyboardListener_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_;
		public unsafe void NumKeySetKeyboardListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyBoardListener? p0)
		{
			if (id_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ == IntPtr.Zero)
				id_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_ = JNIEnv.GetMethodID (class_ref, "NumKeySetKeyboardListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyBoardListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_NumKeySetKeyboardListener_Api_Lcom_vanstone_appsdk_api_interfaces_INumKeyBoardListener_, __args);
		}

		static Delegate? cb_NumKeyUpdateKeyboardSignal_Api_II;
#pragma warning disable 0169
		static Delegate GetNumKeyUpdateKeyboardSignal_Api_IIHandler ()
		{
			if (cb_NumKeyUpdateKeyboardSignal_Api_II == null)
				cb_NumKeyUpdateKeyboardSignal_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_NumKeyUpdateKeyboardSignal_Api_II));
			return cb_NumKeyUpdateKeyboardSignal_Api_II;
		}

		static bool n_NumKeyUpdateKeyboardSignal_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NumKeyUpdateKeyboardSignal_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_NumKeyUpdateKeyboardSignal_Api_II;
		public unsafe bool NumKeyUpdateKeyboardSignal_Api (int p0, int p1)
		{
			if (id_NumKeyUpdateKeyboardSignal_Api_II == IntPtr.Zero)
				id_NumKeyUpdateKeyboardSignal_Api_II = JNIEnv.GetMethodID (class_ref, "NumKeyUpdateKeyboardSignal_Api", "(II)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_NumKeyUpdateKeyboardSignal_Api_II, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Numkeyboard.INumKeyBoardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
