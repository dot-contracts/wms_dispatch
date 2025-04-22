using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.SerialPort {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']"
	[Register ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler", "", "Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandlerInvoker")]
	public partial interface ISerialPortHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='available_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("available_Api", "(I)I", "GetAvailable_Api_IHandler:Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandlerInvoker, VanstonePosSdk")]
		int Available_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='close_Api' and count(parameter)=0]"
		[Register ("close_Api", "()I", "GetClose_ApiHandler:Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandlerInvoker, VanstonePosSdk")]
		int Close_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("open_Api", "(II)I", "GetOpen_Api_IIHandler:Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandlerInvoker, VanstonePosSdk")]
		int Open_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read_Api", "([BII)I", "GetRead_Api_arrayBIIHandler:Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandlerInvoker, VanstonePosSdk")]
		int Read_Api (byte[]? p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write_Api", "([BII)I", "GetWrite_Api_arrayBIIHandler:Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandlerInvoker, VanstonePosSdk")]
		int Write_Api (byte[]? p0, int p1, int p2);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']/constructor[@name='SerialPortHandler.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_available_Api_I;
#pragma warning disable 0169
			static Delegate GetAvailable_Api_IHandler ()
			{
				if (cb_available_Api_I == null)
					cb_available_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Available_Api_I));
				return cb_available_Api_I;
			}

			static int n_Available_Api_I (IntPtr jnienv, IntPtr native__this, int timeout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Available_Api (timeout);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']/method[@name='available_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("available_Api", "(I)I", "GetAvailable_Api_IHandler")]
			public virtual unsafe int Available_Api (int timeout)
			{
				const string __id = "available_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']/method[@name='close_Api' and count(parameter)=0]"
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

			static Delegate? cb_open_Api_II;
#pragma warning disable 0169
			static Delegate GetOpen_Api_IIHandler ()
			{
				if (cb_open_Api_II == null)
					cb_open_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_Open_Api_II));
				return cb_open_Api_II;
			}

			static int n_Open_Api_II (IntPtr jnienv, IntPtr native__this, int portNum, int baudRate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Open_Api (portNum, baudRate);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']/method[@name='open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("open_Api", "(II)I", "GetOpen_Api_IIHandler")]
			public virtual unsafe int Open_Api (int portNum, int baudRate)
			{
				const string __id = "open_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (portNum);
					__args [1] = new JniArgumentValue (baudRate);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_read_Api_arrayBII;
#pragma warning disable 0169
			static Delegate GetRead_Api_arrayBIIHandler ()
			{
				if (cb_read_Api_arrayBII == null)
					cb_read_Api_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_Read_Api_arrayBII));
				return cb_read_Api_arrayBII;
			}

			static int n_Read_Api_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int off, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Read_Api (buf, off, len);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("read_Api", "([BII)I", "GetRead_Api_arrayBIIHandler")]
			public virtual unsafe int Read_Api (byte[]? buf, int off, int len)
			{
				const string __id = "read_Api.([BII)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_buf);
					__args [1] = new JniArgumentValue (off);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

			static Delegate? cb_write_Api_arrayBII;
#pragma warning disable 0169
			static Delegate GetWrite_Api_arrayBIIHandler ()
			{
				if (cb_write_Api_arrayBII == null)
					cb_write_Api_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_Write_Api_arrayBII));
				return cb_write_Api_arrayBII;
			}

			static int n_Write_Api_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int off, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Write_Api (buf, off, len);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Default']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("write_Api", "([BII)I", "GetWrite_Api_arrayBIIHandler")]
			public virtual unsafe int Write_Api (byte[]? buf, int off, int len)
			{
				const string __id = "write_Api.([BII)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_buf);
					__args [1] = new JniArgumentValue (off);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Stub']/constructor[@name='SerialPortHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/class[@name='SerialPortHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.SerialPort.SerialPortHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/SerialPort/SerialPortHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_available_Api_I;
#pragma warning disable 0169
			static Delegate GetAvailable_Api_IHandler ()
			{
				if (cb_available_Api_I == null)
					cb_available_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Available_Api_I));
				return cb_available_Api_I;
			}

			static int n_Available_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Available_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='available_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("available_Api", "(I)I", "GetAvailable_Api_IHandler")]
			public abstract int Available_Api (int p0);

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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='close_Api' and count(parameter)=0]"
			[Register ("close_Api", "()I", "GetClose_ApiHandler")]
			public abstract int Close_Api ();

			static Delegate? cb_open_Api_II;
#pragma warning disable 0169
			static Delegate GetOpen_Api_IIHandler ()
			{
				if (cb_open_Api_II == null)
					cb_open_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_Open_Api_II));
				return cb_open_Api_II;
			}

			static int n_Open_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Open_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("open_Api", "(II)I", "GetOpen_Api_IIHandler")]
			public abstract int Open_Api (int p0, int p1);

			static Delegate? cb_read_Api_arrayBII;
#pragma warning disable 0169
			static Delegate GetRead_Api_arrayBIIHandler ()
			{
				if (cb_read_Api_arrayBII == null)
					cb_read_Api_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_Read_Api_arrayBII));
				return cb_read_Api_arrayBII;
			}

			static int n_Read_Api_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Read_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("read_Api", "([BII)I", "GetRead_Api_arrayBIIHandler")]
			public abstract int Read_Api (byte[]? p0, int p1, int p2);

			static Delegate? cb_write_Api_arrayBII;
#pragma warning disable 0169
			static Delegate GetWrite_Api_arrayBIIHandler ()
			{
				if (cb_write_Api_arrayBII == null)
					cb_write_Api_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_Write_Api_arrayBII));
				return cb_write_Api_arrayBII;
			}

			static int n_Write_Api_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Write_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("write_Api", "([BII)I", "GetWrite_Api_arrayBIIHandler")]
			public abstract int Write_Api (byte[]? p0, int p1, int p2);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='available_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("available_Api", "(I)I", "GetAvailable_Api_IHandler")]
			public override unsafe int Available_Api (int p0)
			{
				const string __id = "available_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='close_Api' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("open_Api", "(II)I", "GetOpen_Api_IIHandler")]
			public override unsafe int Open_Api (int p0, int p1)
			{
				const string __id = "open_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='read_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("read_Api", "([BII)I", "GetRead_Api_arrayBIIHandler")]
			public override unsafe int Read_Api (byte[]? p0, int p1, int p2)
			{
				const string __id = "read_Api.([BII)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.SerialPort']/interface[@name='SerialPortHandler']/method[@name='write_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("write_Api", "([BII)I", "GetWrite_Api_arrayBIIHandler")]
			public override unsafe int Write_Api (byte[]? p0, int p1, int p2)
			{
				const string __id = "write_Api.([BII)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
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

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler", DoNotGenerateAcw=true)]
	internal partial class ISerialPortHandlerInvoker : global::Java.Lang.Object, ISerialPortHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/SerialPort/SerialPortHandler", typeof (ISerialPortHandlerInvoker));

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

		public static ISerialPortHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISerialPortHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.SerialPort.SerialPortHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISerialPortHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_available_Api_I;
#pragma warning disable 0169
		static Delegate GetAvailable_Api_IHandler ()
		{
			if (cb_available_Api_I == null)
				cb_available_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Available_Api_I));
			return cb_available_Api_I;
		}

		static int n_Available_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Available_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_available_Api_I;
		public unsafe int Available_Api (int p0)
		{
			if (id_available_Api_I == IntPtr.Zero)
				id_available_Api_I = JNIEnv.GetMethodID (class_ref, "available_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_available_Api_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_open_Api_II;
#pragma warning disable 0169
		static Delegate GetOpen_Api_IIHandler ()
		{
			if (cb_open_Api_II == null)
				cb_open_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_Open_Api_II));
			return cb_open_Api_II;
		}

		static int n_Open_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Open_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_open_Api_II;
		public unsafe int Open_Api (int p0, int p1)
		{
			if (id_open_Api_II == IntPtr.Zero)
				id_open_Api_II = JNIEnv.GetMethodID (class_ref, "open_Api", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_open_Api_II, __args);
		}

		static Delegate? cb_read_Api_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_Api_arrayBIIHandler ()
		{
			if (cb_read_Api_arrayBII == null)
				cb_read_Api_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_Read_Api_arrayBII));
			return cb_read_Api_arrayBII;
		}

		static int n_Read_Api_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Api_arrayBII;
		public unsafe int Read_Api (byte[]? p0, int p1, int p2)
		{
			if (id_read_Api_arrayBII == IntPtr.Zero)
				id_read_Api_arrayBII = JNIEnv.GetMethodID (class_ref, "read_Api", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Api_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_write_Api_arrayBII;
#pragma warning disable 0169
		static Delegate GetWrite_Api_arrayBIIHandler ()
		{
			if (cb_write_Api_arrayBII == null)
				cb_write_Api_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_Write_Api_arrayBII));
			return cb_write_Api_arrayBII;
		}

		static int n_Write_Api_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_Api_arrayBII;
		public unsafe int Write_Api (byte[]? p0, int p1, int p2)
		{
			if (id_write_Api_arrayBII == IntPtr.Zero)
				id_write_Api_arrayBII = JNIEnv.GetMethodID (class_ref, "write_Api", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_Api_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SerialPort.ISerialPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
