using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Lcd {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']"
	[Register ("com/vanstone/appsdk/api/lcd/LcdHandler", "", "Com.Vanstone.Appsdk.Api.Lcd.ILcdHandlerInvoker")]
	public partial interface ILcdHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedLightOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("LedLightOff_Api", "(I)I", "GetLedLightOff_Api_IHandler:Com.Vanstone.Appsdk.Api.Lcd.ILcdHandlerInvoker, VanstonePosSdk")]
		int LedLightOff_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedLightOn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("LedLightOn_Api", "(I)I", "GetLedLightOn_Api_IHandler:Com.Vanstone.Appsdk.Api.Lcd.ILcdHandlerInvoker, VanstonePosSdk")]
		int LedLightOn_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedOper_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("LedOper_Api", "(II)I", "GetLedOper_Api_IIHandler:Com.Vanstone.Appsdk.Api.Lcd.ILcdHandlerInvoker, VanstonePosSdk")]
		int LedOper_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='Led_GetStatus_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Led_GetStatus_Api", "(I)Z", "GetLed_GetStatus_Api_IHandler:Com.Vanstone.Appsdk.Api.Lcd.ILcdHandlerInvoker, VanstonePosSdk")]
		bool Led_GetStatus_Api (int p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/lcd/LcdHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/lcd/LcdHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Default']/constructor[@name='LcdHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_LedLightOff_Api_I;
#pragma warning disable 0169
			static Delegate GetLedLightOff_Api_IHandler ()
			{
				if (cb_LedLightOff_Api_I == null)
					cb_LedLightOff_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_LedLightOff_Api_I));
				return cb_LedLightOff_Api_I;
			}

			static int n_LedLightOff_Api_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LedLightOff_Api (index);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Default']/method[@name='LedLightOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LedLightOff_Api", "(I)I", "GetLedLightOff_Api_IHandler")]
			public virtual unsafe int LedLightOff_Api (int index)
			{
				const string __id = "LedLightOff_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LedLightOn_Api_I;
#pragma warning disable 0169
			static Delegate GetLedLightOn_Api_IHandler ()
			{
				if (cb_LedLightOn_Api_I == null)
					cb_LedLightOn_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_LedLightOn_Api_I));
				return cb_LedLightOn_Api_I;
			}

			static int n_LedLightOn_Api_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LedLightOn_Api (index);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Default']/method[@name='LedLightOn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LedLightOn_Api", "(I)I", "GetLedLightOn_Api_IHandler")]
			public virtual unsafe int LedLightOn_Api (int index)
			{
				const string __id = "LedLightOn_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LedOper_Api_II;
#pragma warning disable 0169
			static Delegate GetLedOper_Api_IIHandler ()
			{
				if (cb_LedOper_Api_II == null)
					cb_LedOper_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_LedOper_Api_II));
				return cb_LedOper_Api_II;
			}

			static int n_LedOper_Api_II (IntPtr jnienv, IntPtr native__this, int index, int oper)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LedOper_Api (index, oper);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Default']/method[@name='LedOper_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("LedOper_Api", "(II)I", "GetLedOper_Api_IIHandler")]
			public virtual unsafe int LedOper_Api (int index, int oper)
			{
				const string __id = "LedOper_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (oper);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_Led_GetStatus_Api_I;
#pragma warning disable 0169
			static Delegate GetLed_GetStatus_Api_IHandler ()
			{
				if (cb_Led_GetStatus_Api_I == null)
					cb_Led_GetStatus_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_Led_GetStatus_Api_I));
				return cb_Led_GetStatus_Api_I;
			}

			static bool n_Led_GetStatus_Api_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Led_GetStatus_Api (index);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Default']/method[@name='Led_GetStatus_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Led_GetStatus_Api", "(I)Z", "GetLed_GetStatus_Api_IHandler")]
			public virtual unsafe bool Led_GetStatus_Api (int index)
			{
				const string __id = "Led_GetStatus_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/lcd/LcdHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/lcd/LcdHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Stub']/constructor[@name='LcdHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/lcd/LcdHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/lcd/LcdHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/lcd/LcdHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/lcd/LcdHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/class[@name='LcdHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.lcd.LcdHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/lcd/LcdHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/lcd/LcdHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_LedLightOff_Api_I;
#pragma warning disable 0169
			static Delegate GetLedLightOff_Api_IHandler ()
			{
				if (cb_LedLightOff_Api_I == null)
					cb_LedLightOff_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_LedLightOff_Api_I));
				return cb_LedLightOff_Api_I;
			}

			static int n_LedLightOff_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LedLightOff_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedLightOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LedLightOff_Api", "(I)I", "GetLedLightOff_Api_IHandler")]
			public abstract int LedLightOff_Api (int p0);

			static Delegate? cb_LedLightOn_Api_I;
#pragma warning disable 0169
			static Delegate GetLedLightOn_Api_IHandler ()
			{
				if (cb_LedLightOn_Api_I == null)
					cb_LedLightOn_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_LedLightOn_Api_I));
				return cb_LedLightOn_Api_I;
			}

			static int n_LedLightOn_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LedLightOn_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedLightOn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LedLightOn_Api", "(I)I", "GetLedLightOn_Api_IHandler")]
			public abstract int LedLightOn_Api (int p0);

			static Delegate? cb_LedOper_Api_II;
#pragma warning disable 0169
			static Delegate GetLedOper_Api_IIHandler ()
			{
				if (cb_LedOper_Api_II == null)
					cb_LedOper_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_LedOper_Api_II));
				return cb_LedOper_Api_II;
			}

			static int n_LedOper_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LedOper_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedOper_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("LedOper_Api", "(II)I", "GetLedOper_Api_IIHandler")]
			public abstract int LedOper_Api (int p0, int p1);

			static Delegate? cb_Led_GetStatus_Api_I;
#pragma warning disable 0169
			static Delegate GetLed_GetStatus_Api_IHandler ()
			{
				if (cb_Led_GetStatus_Api_I == null)
					cb_Led_GetStatus_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_Led_GetStatus_Api_I));
				return cb_Led_GetStatus_Api_I;
			}

			static bool n_Led_GetStatus_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Led_GetStatus_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='Led_GetStatus_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Led_GetStatus_Api", "(I)Z", "GetLed_GetStatus_Api_IHandler")]
			public abstract bool Led_GetStatus_Api (int p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/lcd/LcdHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/lcd/LcdHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedLightOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LedLightOff_Api", "(I)I", "GetLedLightOff_Api_IHandler")]
			public override unsafe int LedLightOff_Api (int p0)
			{
				const string __id = "LedLightOff_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedLightOn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LedLightOn_Api", "(I)I", "GetLedLightOn_Api_IHandler")]
			public override unsafe int LedLightOn_Api (int p0)
			{
				const string __id = "LedLightOn_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='LedOper_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("LedOper_Api", "(II)I", "GetLedOper_Api_IIHandler")]
			public override unsafe int LedOper_Api (int p0, int p1)
			{
				const string __id = "LedOper_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.lcd']/interface[@name='LcdHandler']/method[@name='Led_GetStatus_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Led_GetStatus_Api", "(I)Z", "GetLed_GetStatus_Api_IHandler")]
			public override unsafe bool Led_GetStatus_Api (int p0)
			{
				const string __id = "Led_GetStatus_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/lcd/LcdHandler", DoNotGenerateAcw=true)]
	internal partial class ILcdHandlerInvoker : global::Java.Lang.Object, ILcdHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/lcd/LcdHandler", typeof (ILcdHandlerInvoker));

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

		public static ILcdHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILcdHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.lcd.LcdHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILcdHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_LedLightOff_Api_I;
#pragma warning disable 0169
		static Delegate GetLedLightOff_Api_IHandler ()
		{
			if (cb_LedLightOff_Api_I == null)
				cb_LedLightOff_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_LedLightOff_Api_I));
			return cb_LedLightOff_Api_I;
		}

		static int n_LedLightOff_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LedLightOff_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_LedLightOff_Api_I;
		public unsafe int LedLightOff_Api (int p0)
		{
			if (id_LedLightOff_Api_I == IntPtr.Zero)
				id_LedLightOff_Api_I = JNIEnv.GetMethodID (class_ref, "LedLightOff_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_LedLightOff_Api_I, __args);
		}

		static Delegate? cb_LedLightOn_Api_I;
#pragma warning disable 0169
		static Delegate GetLedLightOn_Api_IHandler ()
		{
			if (cb_LedLightOn_Api_I == null)
				cb_LedLightOn_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_LedLightOn_Api_I));
			return cb_LedLightOn_Api_I;
		}

		static int n_LedLightOn_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LedLightOn_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_LedLightOn_Api_I;
		public unsafe int LedLightOn_Api (int p0)
		{
			if (id_LedLightOn_Api_I == IntPtr.Zero)
				id_LedLightOn_Api_I = JNIEnv.GetMethodID (class_ref, "LedLightOn_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_LedLightOn_Api_I, __args);
		}

		static Delegate? cb_LedOper_Api_II;
#pragma warning disable 0169
		static Delegate GetLedOper_Api_IIHandler ()
		{
			if (cb_LedOper_Api_II == null)
				cb_LedOper_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_LedOper_Api_II));
			return cb_LedOper_Api_II;
		}

		static int n_LedOper_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LedOper_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_LedOper_Api_II;
		public unsafe int LedOper_Api (int p0, int p1)
		{
			if (id_LedOper_Api_II == IntPtr.Zero)
				id_LedOper_Api_II = JNIEnv.GetMethodID (class_ref, "LedOper_Api", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_LedOper_Api_II, __args);
		}

		static Delegate? cb_Led_GetStatus_Api_I;
#pragma warning disable 0169
		static Delegate GetLed_GetStatus_Api_IHandler ()
		{
			if (cb_Led_GetStatus_Api_I == null)
				cb_Led_GetStatus_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_Led_GetStatus_Api_I));
			return cb_Led_GetStatus_Api_I;
		}

		static bool n_Led_GetStatus_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Led_GetStatus_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_Led_GetStatus_Api_I;
		public unsafe bool Led_GetStatus_Api (int p0)
		{
			if (id_Led_GetStatus_Api_I == IntPtr.Zero)
				id_Led_GetStatus_Api_I = JNIEnv.GetMethodID (class_ref, "Led_GetStatus_Api", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Led_GetStatus_Api_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Lcd.ILcdHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
