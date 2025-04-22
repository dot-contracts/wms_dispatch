using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']"
	[Register ("com/vanstone/appsdk/api/cards/At24cXXHandler", "", "Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandlerInvoker")]
	public partial interface IAt24cXXHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='checkType_Api' and count(parameter)=0]"
		[Register ("checkType_Api", "()I", "GetCheckType_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandlerInvoker, VanstonePosSdk")]
		int CheckType_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='close_Api' and count(parameter)=0]"
		[Register ("close_Api", "()I", "GetClose_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandlerInvoker, VanstonePosSdk")]
		int Close_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='open_Api' and count(parameter)=0]"
		[Register ("open_Api", "()I", "GetOpen_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandlerInvoker, VanstonePosSdk")]
		int Open_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("read_Api", "(I[BI)I", "GetRead_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandlerInvoker, VanstonePosSdk")]
		int Read_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("write_Api", "(I[BI)I", "GetWrite_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandlerInvoker, VanstonePosSdk")]
		int Write_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At24cXXHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At24cXXHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']/constructor[@name='At24cXXHandler.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_checkType_Api;
#pragma warning disable 0169
			static Delegate GetCheckType_ApiHandler ()
			{
				if (cb_checkType_Api == null)
					cb_checkType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CheckType_Api));
				return cb_checkType_Api;
			}

			static int n_CheckType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CheckType_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']/method[@name='checkType_Api' and count(parameter)=0]"
			[Register ("checkType_Api", "()I", "GetCheckType_ApiHandler")]
			public virtual unsafe int CheckType_Api ()
			{
				const string __id = "checkType_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_close_Api;
#pragma warning disable 0169
			static Delegate GetClose_ApiHandler ()
			{
				if (cb_close_Api == null)
					cb_close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Close_Api));
				return cb_close_Api;
			}

			static int n_Close_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']/method[@name='close_Api' and count(parameter)=0]"
			[Register ("close_Api", "()I", "GetClose_ApiHandler")]
			public virtual unsafe int Close_Api ()
			{
				const string __id = "close_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_open_Api;
#pragma warning disable 0169
			static Delegate GetOpen_ApiHandler ()
			{
				if (cb_open_Api == null)
					cb_open_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Open_Api));
				return cb_open_Api;
			}

			static int n_Open_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Open_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']/method[@name='open_Api' and count(parameter)=0]"
			[Register ("open_Api", "()I", "GetOpen_ApiHandler")]
			public virtual unsafe int Open_Api ()
			{
				const string __id = "open_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_read_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetRead_Api_IarrayBIHandler ()
			{
				if (cb_read_Api_IarrayBI == null)
					cb_read_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Read_Api_IarrayBI));
				return cb_read_Api_IarrayBI;
			}

			static int n_Read_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int addr, IntPtr native_buffer, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buffer = (byte[]?) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Read_Api (addr, buffer, len);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("read_Api", "(I[BI)I", "GetRead_Api_IarrayBIHandler")]
			public virtual unsafe int Read_Api (int addr, byte[]? buffer, int len)
			{
				const string __id = "read_Api.(I[BI)I";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (addr);
					__args [1] = new JniArgumentValue (native_buffer);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
					global::System.GC.KeepAlive (buffer);
				}
			}

			static Delegate? cb_write_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetWrite_Api_IarrayBIHandler ()
			{
				if (cb_write_Api_IarrayBI == null)
					cb_write_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Write_Api_IarrayBI));
				return cb_write_Api_IarrayBI;
			}

			static int n_Write_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int addr, IntPtr native_data, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Write_Api (addr, data, len);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Default']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("write_Api", "(I[BI)I", "GetWrite_Api_IarrayBIHandler")]
			public virtual unsafe int Write_Api (int addr, byte[]? data, int len)
			{
				const string __id = "write_Api.(I[BI)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (addr);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At24cXXHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At24cXXHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Stub']/constructor[@name='At24cXXHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/At24cXXHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/At24cXXHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/At24cXXHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At24cXXHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.At24cXXHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/At24cXXHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/At24cXXHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_checkType_Api;
#pragma warning disable 0169
			static Delegate GetCheckType_ApiHandler ()
			{
				if (cb_checkType_Api == null)
					cb_checkType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CheckType_Api));
				return cb_checkType_Api;
			}

			static int n_CheckType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CheckType_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='checkType_Api' and count(parameter)=0]"
			[Register ("checkType_Api", "()I", "GetCheckType_ApiHandler")]
			public abstract int CheckType_Api ();

			static Delegate? cb_close_Api;
#pragma warning disable 0169
			static Delegate GetClose_ApiHandler ()
			{
				if (cb_close_Api == null)
					cb_close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Close_Api));
				return cb_close_Api;
			}

			static int n_Close_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='close_Api' and count(parameter)=0]"
			[Register ("close_Api", "()I", "GetClose_ApiHandler")]
			public abstract int Close_Api ();

			static Delegate? cb_open_Api;
#pragma warning disable 0169
			static Delegate GetOpen_ApiHandler ()
			{
				if (cb_open_Api == null)
					cb_open_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Open_Api));
				return cb_open_Api;
			}

			static int n_Open_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Open_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='open_Api' and count(parameter)=0]"
			[Register ("open_Api", "()I", "GetOpen_ApiHandler")]
			public abstract int Open_Api ();

			static Delegate? cb_read_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetRead_Api_IarrayBIHandler ()
			{
				if (cb_read_Api_IarrayBI == null)
					cb_read_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Read_Api_IarrayBI));
				return cb_read_Api_IarrayBI;
			}

			static int n_Read_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Read_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("read_Api", "(I[BI)I", "GetRead_Api_IarrayBIHandler")]
			public abstract int Read_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_write_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetWrite_Api_IarrayBIHandler ()
			{
				if (cb_write_Api_IarrayBI == null)
					cb_write_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Write_Api_IarrayBI));
				return cb_write_Api_IarrayBI;
			}

			static int n_Write_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Write_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("write_Api", "(I[BI)I", "GetWrite_Api_IarrayBIHandler")]
			public abstract int Write_Api (int p0, byte[]? p1, int p2);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At24cXXHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At24cXXHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='checkType_Api' and count(parameter)=0]"
			[Register ("checkType_Api", "()I", "GetCheckType_ApiHandler")]
			public override unsafe int CheckType_Api ()
			{
				const string __id = "checkType_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='close_Api' and count(parameter)=0]"
			[Register ("close_Api", "()I", "GetClose_ApiHandler")]
			public override unsafe int Close_Api ()
			{
				const string __id = "close_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='open_Api' and count(parameter)=0]"
			[Register ("open_Api", "()I", "GetOpen_ApiHandler")]
			public override unsafe int Open_Api ()
			{
				const string __id = "open_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("read_Api", "(I[BI)I", "GetRead_Api_IarrayBIHandler")]
			public override unsafe int Read_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "read_Api.(I[BI)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At24cXXHandler']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("write_Api", "(I[BI)I", "GetWrite_Api_IarrayBIHandler")]
			public override unsafe int Write_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "write_Api.(I[BI)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At24cXXHandler", DoNotGenerateAcw=true)]
	internal partial class IAt24cXXHandlerInvoker : global::Java.Lang.Object, IAt24cXXHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At24cXXHandler", typeof (IAt24cXXHandlerInvoker));

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

		public static IAt24cXXHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAt24cXXHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.At24cXXHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAt24cXXHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_checkType_Api;
#pragma warning disable 0169
		static Delegate GetCheckType_ApiHandler ()
		{
			if (cb_checkType_Api == null)
				cb_checkType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CheckType_Api));
			return cb_checkType_Api;
		}

		static int n_CheckType_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CheckType_Api ();
		}
#pragma warning restore 0169

		IntPtr id_checkType_Api;
		public unsafe int CheckType_Api ()
		{
			if (id_checkType_Api == IntPtr.Zero)
				id_checkType_Api = JNIEnv.GetMethodID (class_ref, "checkType_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkType_Api);
		}

		static Delegate? cb_close_Api;
#pragma warning disable 0169
		static Delegate GetClose_ApiHandler ()
		{
			if (cb_close_Api == null)
				cb_close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Close_Api));
			return cb_close_Api;
		}

		static int n_Close_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Close_Api ();
		}
#pragma warning restore 0169

		IntPtr id_close_Api;
		public unsafe int Close_Api ()
		{
			if (id_close_Api == IntPtr.Zero)
				id_close_Api = JNIEnv.GetMethodID (class_ref, "close_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_close_Api);
		}

		static Delegate? cb_open_Api;
#pragma warning disable 0169
		static Delegate GetOpen_ApiHandler ()
		{
			if (cb_open_Api == null)
				cb_open_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Open_Api));
			return cb_open_Api;
		}

		static int n_Open_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Open_Api ();
		}
#pragma warning restore 0169

		IntPtr id_open_Api;
		public unsafe int Open_Api ()
		{
			if (id_open_Api == IntPtr.Zero)
				id_open_Api = JNIEnv.GetMethodID (class_ref, "open_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_open_Api);
		}

		static Delegate? cb_read_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetRead_Api_IarrayBIHandler ()
		{
			if (cb_read_Api_IarrayBI == null)
				cb_read_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Read_Api_IarrayBI));
			return cb_read_Api_IarrayBI;
		}

		static int n_Read_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Api_IarrayBI;
		public unsafe int Read_Api (int p0, byte[]? p1, int p2)
		{
			if (id_read_Api_IarrayBI == IntPtr.Zero)
				id_read_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "read_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_write_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetWrite_Api_IarrayBIHandler ()
		{
			if (cb_write_Api_IarrayBI == null)
				cb_write_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Write_Api_IarrayBI));
			return cb_write_Api_IarrayBI;
		}

		static int n_Write_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_Api_IarrayBI;
		public unsafe int Write_Api (int p0, byte[]? p1, int p2)
		{
			if (id_write_Api_IarrayBI == IntPtr.Zero)
				id_write_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "write_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt24cXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
