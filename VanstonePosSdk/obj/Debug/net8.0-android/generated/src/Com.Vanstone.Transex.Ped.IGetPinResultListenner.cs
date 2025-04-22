using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Transex.Ped {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']"
	[Register ("com/vanstone/transex/ped/IGetPinResultListenner", "", "Com.Vanstone.Transex.Ped.IGetPinResultListennerInvoker")]
	public partial interface IGetPinResultListenner : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onCancle' and count(parameter)=0]"
		[Register ("onCancle", "()V", "GetOnCancleHandler:Com.Vanstone.Transex.Ped.IGetPinResultListennerInvoker, VanstonePosSdk")]
		void OnCancle ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onClick", "(I)V", "GetOnClick_IHandler:Com.Vanstone.Transex.Ped.IGetPinResultListennerInvoker, VanstonePosSdk")]
		void OnClick (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onEnter' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onEnter", "([B)V", "GetOnEnter_arrayBHandler:Com.Vanstone.Transex.Ped.IGetPinResultListennerInvoker, VanstonePosSdk")]
		void OnEnter (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler:Com.Vanstone.Transex.Ped.IGetPinResultListennerInvoker, VanstonePosSdk")]
		void OnError (int p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onTimerOut' and count(parameter)=0]"
		[Register ("onTimerOut", "()V", "GetOnTimerOutHandler:Com.Vanstone.Transex.Ped.IGetPinResultListennerInvoker, VanstonePosSdk")]
		void OnTimerOut ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']"
		[global::Android.Runtime.Register ("com/vanstone/transex/ped/IGetPinResultListenner$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/transex/ped/IGetPinResultListenner$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']/constructor[@name='IGetPinResultListenner.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_onCancle;
#pragma warning disable 0169
			static Delegate GetOnCancleHandler ()
			{
				if (cb_onCancle == null)
					cb_onCancle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnCancle));
				return cb_onCancle;
			}

			static void n_OnCancle (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnCancle ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']/method[@name='onCancle' and count(parameter)=0]"
			[Register ("onCancle", "()V", "GetOnCancleHandler")]
			public virtual unsafe void OnCancle ()
			{
				const string __id = "onCancle.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_onClick_I;
#pragma warning disable 0169
			static Delegate GetOnClick_IHandler ()
			{
				if (cb_onClick_I == null)
					cb_onClick_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnClick_I));
				return cb_onClick_I;
			}

			static void n_OnClick_I (IntPtr jnienv, IntPtr native__this, int inputLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnClick (inputLen);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onClick", "(I)V", "GetOnClick_IHandler")]
			public virtual unsafe void OnClick (int inputLen)
			{
				const string __id = "onClick.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (inputLen);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_onEnter_arrayB;
#pragma warning disable 0169
			static Delegate GetOnEnter_arrayBHandler ()
			{
				if (cb_onEnter_arrayB == null)
					cb_onEnter_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnEnter_arrayB));
				return cb_onEnter_arrayB;
			}

			static void n_OnEnter_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pinOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pinOut = (byte[]?) JNIEnv.GetArray (native_pinOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnEnter (pinOut);
				if (pinOut != null)
					JNIEnv.CopyArray (pinOut, native_pinOut);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']/method[@name='onEnter' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onEnter", "([B)V", "GetOnEnter_arrayBHandler")]
			public virtual unsafe void OnEnter (byte[]? pinOut)
			{
				const string __id = "onEnter.([B)V";
				IntPtr native_pinOut = JNIEnv.NewArray (pinOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_pinOut);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (pinOut != null) {
						JNIEnv.CopyArray (native_pinOut, pinOut);
						JNIEnv.DeleteLocalRef (native_pinOut);
					}
					global::System.GC.KeepAlive (pinOut);
				}
			}

			static Delegate? cb_onError_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_ILjava_lang_String_Handler ()
			{
				if (cb_onError_ILjava_lang_String_ == null)
					cb_onError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnError_ILjava_lang_String_));
				return cb_onError_ILjava_lang_String_;
			}

			static void n_OnError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int errcode, IntPtr native_msg)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnError (errcode, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler")]
			public virtual unsafe void OnError (int errcode, string? msg)
			{
				const string __id = "onError.(ILjava/lang/String;)V";
				IntPtr native_msg = JNIEnv.NewString ((string?)msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (errcode);
					__args [1] = new JniArgumentValue (native_msg);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_msg);
				}
			}

			static Delegate? cb_onTimerOut;
#pragma warning disable 0169
			static Delegate GetOnTimerOutHandler ()
			{
				if (cb_onTimerOut == null)
					cb_onTimerOut = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnTimerOut));
				return cb_onTimerOut;
			}

			static void n_OnTimerOut (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnTimerOut ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Default']/method[@name='onTimerOut' and count(parameter)=0]"
			[Register ("onTimerOut", "()V", "GetOnTimerOutHandler")]
			public virtual unsafe void OnTimerOut ()
			{
				const string __id = "onTimerOut.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/transex/ped/IGetPinResultListenner$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/transex/ped/IGetPinResultListenner$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Stub']/constructor[@name='IGetPinResultListenner.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/transex/ped/IGetPinResultListenner;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/transex/ped/IGetPinResultListenner;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/transex/ped/IGetPinResultListenner;", "")]
			public static unsafe global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/transex/ped/IGetPinResultListenner;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/class[@name='IGetPinResultListenner.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/transex/ped/IGetPinResultListenner;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/transex/ped/IGetPinResultListenner;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_onCancle;
#pragma warning disable 0169
			static Delegate GetOnCancleHandler ()
			{
				if (cb_onCancle == null)
					cb_onCancle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnCancle));
				return cb_onCancle;
			}

			static void n_OnCancle (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnCancle ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onCancle' and count(parameter)=0]"
			[Register ("onCancle", "()V", "GetOnCancleHandler")]
			public abstract void OnCancle ();

			static Delegate? cb_onClick_I;
#pragma warning disable 0169
			static Delegate GetOnClick_IHandler ()
			{
				if (cb_onClick_I == null)
					cb_onClick_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnClick_I));
				return cb_onClick_I;
			}

			static void n_OnClick_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onClick", "(I)V", "GetOnClick_IHandler")]
			public abstract void OnClick (int p0);

			static Delegate? cb_onEnter_arrayB;
#pragma warning disable 0169
			static Delegate GetOnEnter_arrayBHandler ()
			{
				if (cb_onEnter_arrayB == null)
					cb_onEnter_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnEnter_arrayB));
				return cb_onEnter_arrayB;
			}

			static void n_OnEnter_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnEnter (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onEnter' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onEnter", "([B)V", "GetOnEnter_arrayBHandler")]
			public abstract void OnEnter (byte[]? p0);

			static Delegate? cb_onError_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_ILjava_lang_String_Handler ()
			{
				if (cb_onError_ILjava_lang_String_ == null)
					cb_onError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnError_ILjava_lang_String_));
				return cb_onError_ILjava_lang_String_;
			}

			static void n_OnError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler")]
			public abstract void OnError (int p0, string? p1);

			static Delegate? cb_onTimerOut;
#pragma warning disable 0169
			static Delegate GetOnTimerOutHandler ()
			{
				if (cb_onTimerOut == null)
					cb_onTimerOut = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnTimerOut));
				return cb_onTimerOut;
			}

			static void n_OnTimerOut (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnTimerOut ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onTimerOut' and count(parameter)=0]"
			[Register ("onTimerOut", "()V", "GetOnTimerOutHandler")]
			public abstract void OnTimerOut ();

		}

		[global::Android.Runtime.Register ("com/vanstone/transex/ped/IGetPinResultListenner$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/transex/ped/IGetPinResultListenner$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onCancle' and count(parameter)=0]"
			[Register ("onCancle", "()V", "GetOnCancleHandler")]
			public override unsafe void OnCancle ()
			{
				const string __id = "onCancle.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onClick", "(I)V", "GetOnClick_IHandler")]
			public override unsafe void OnClick (int p0)
			{
				const string __id = "onClick.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onEnter' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onEnter", "([B)V", "GetOnEnter_arrayBHandler")]
			public override unsafe void OnEnter (byte[]? p0)
			{
				const string __id = "onEnter.([B)V";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler")]
			public override unsafe void OnError (int p0, string? p1)
			{
				const string __id = "onError.(ILjava/lang/String;)V";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.transex.ped']/interface[@name='IGetPinResultListenner']/method[@name='onTimerOut' and count(parameter)=0]"
			[Register ("onTimerOut", "()V", "GetOnTimerOutHandler")]
			public override unsafe void OnTimerOut ()
			{
				const string __id = "onTimerOut.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/transex/ped/IGetPinResultListenner", DoNotGenerateAcw=true)]
	internal partial class IGetPinResultListennerInvoker : global::Java.Lang.Object, IGetPinResultListenner {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/transex/ped/IGetPinResultListenner", typeof (IGetPinResultListennerInvoker));

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

		public static IGetPinResultListenner? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetPinResultListenner> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.transex.ped.IGetPinResultListenner'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetPinResultListennerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCancle;
#pragma warning disable 0169
		static Delegate GetOnCancleHandler ()
		{
			if (cb_onCancle == null)
				cb_onCancle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnCancle));
			return cb_onCancle;
		}

		static void n_OnCancle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnCancle ();
		}
#pragma warning restore 0169

		IntPtr id_onCancle;
		public unsafe void OnCancle ()
		{
			if (id_onCancle == IntPtr.Zero)
				id_onCancle = JNIEnv.GetMethodID (class_ref, "onCancle", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancle);
		}

		static Delegate? cb_onClick_I;
#pragma warning disable 0169
		static Delegate GetOnClick_IHandler ()
		{
			if (cb_onClick_I == null)
				cb_onClick_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnClick_I));
			return cb_onClick_I;
		}

		static void n_OnClick_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onClick_I;
		public unsafe void OnClick (int p0)
		{
			if (id_onClick_I == IntPtr.Zero)
				id_onClick_I = JNIEnv.GetMethodID (class_ref, "onClick", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_I, __args);
		}

		static Delegate? cb_onEnter_arrayB;
#pragma warning disable 0169
		static Delegate GetOnEnter_arrayBHandler ()
		{
			if (cb_onEnter_arrayB == null)
				cb_onEnter_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnEnter_arrayB));
			return cb_onEnter_arrayB;
		}

		static void n_OnEnter_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnEnter (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onEnter_arrayB;
		public unsafe void OnEnter (byte[]? p0)
		{
			if (id_onEnter_arrayB == IntPtr.Zero)
				id_onEnter_arrayB = JNIEnv.GetMethodID (class_ref, "onEnter", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEnter_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_onError_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_ILjava_lang_String_Handler ()
		{
			if (cb_onError_ILjava_lang_String_ == null)
				cb_onError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnError_ILjava_lang_String_));
			return cb_onError_ILjava_lang_String_;
		}

		static void n_OnError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_ILjava_lang_String_;
		public unsafe void OnError (int p0, string? p1)
		{
			if (id_onError_ILjava_lang_String_ == IntPtr.Zero)
				id_onError_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_onTimerOut;
#pragma warning disable 0169
		static Delegate GetOnTimerOutHandler ()
		{
			if (cb_onTimerOut == null)
				cb_onTimerOut = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnTimerOut));
			return cb_onTimerOut;
		}

		static void n_OnTimerOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnTimerOut ();
		}
#pragma warning restore 0169

		IntPtr id_onTimerOut;
		public unsafe void OnTimerOut ()
		{
			if (id_onTimerOut == IntPtr.Zero)
				id_onTimerOut = JNIEnv.GetMethodID (class_ref, "onTimerOut", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimerOut);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
