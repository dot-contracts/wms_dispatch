using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Rs232 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']"
	[Register ("com/vanstone/appsdk/api/rs232/Rs232Handler", "", "Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker")]
	public partial interface IRs232Handler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortClose_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PortClose_Api", "(I)I", "GetPortClose_Api_IHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortClose_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortIsBufferEmpty' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("PortIsBufferEmpty", "(IZ)I", "GetPortIsBufferEmpty_IZHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortIsBufferEmpty (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortIsEmpty' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PortIsEmpty", "(I)I", "GetPortIsEmpty_IHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortIsEmpty (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortOpen_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PortOpen_Api", "(I)I", "GetPortOpen_Api_IHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortOpen_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortRecv_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("PortRecv_Api", "(I[BII)I", "GetPortRecv_Api_IarrayBIIHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortRecv_Api (int p0, byte[]? p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortReset_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PortReset_Api", "(I)I", "GetPortReset_Api_IHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortReset_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortSends_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("PortSends_Api", "(I[BI)I", "GetPortSends_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortSends_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortSetBaud_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("PortSetBaud_Api", "(IIIII)I", "GetPortSetBaud_Api_IIIIIHandler:Com.Vanstone.Appsdk.Api.Rs232.IRs232HandlerInvoker, VanstonePosSdk")]
		int PortSetBaud_Api (int p0, int p1, int p2, int p3, int p4);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/rs232/Rs232Handler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/rs232/Rs232Handler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/constructor[@name='Rs232Handler.Default' and count(parameter)=0]"
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

			static Delegate? cb_PortClose_Api_I;
#pragma warning disable 0169
			static Delegate GetPortClose_Api_IHandler ()
			{
				if (cb_PortClose_Api_I == null)
					cb_PortClose_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortClose_Api_I));
				return cb_PortClose_Api_I;
			}

			static int n_PortClose_Api_I (IntPtr jnienv, IntPtr native__this, int comport)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortClose_Api (comport);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortClose_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortClose_Api", "(I)I", "GetPortClose_Api_IHandler")]
			public virtual unsafe int PortClose_Api (int comport)
			{
				const string __id = "PortClose_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (comport);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PortIsBufferEmpty_IZ;
#pragma warning disable 0169
			static Delegate GetPortIsBufferEmpty_IZHandler ()
			{
				if (cb_PortIsBufferEmpty_IZ == null)
					cb_PortIsBufferEmpty_IZ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIZ_I (n_PortIsBufferEmpty_IZ));
				return cb_PortIsBufferEmpty_IZ;
			}

			static int n_PortIsBufferEmpty_IZ (IntPtr jnienv, IntPtr native__this, int comport, bool input)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortIsBufferEmpty (comport, input);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortIsBufferEmpty' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("PortIsBufferEmpty", "(IZ)I", "GetPortIsBufferEmpty_IZHandler")]
			public virtual unsafe int PortIsBufferEmpty (int comport, bool input)
			{
				const string __id = "PortIsBufferEmpty.(IZ)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (comport);
					__args [1] = new JniArgumentValue (input);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PortIsEmpty_I;
#pragma warning disable 0169
			static Delegate GetPortIsEmpty_IHandler ()
			{
				if (cb_PortIsEmpty_I == null)
					cb_PortIsEmpty_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortIsEmpty_I));
				return cb_PortIsEmpty_I;
			}

			static int n_PortIsEmpty_I (IntPtr jnienv, IntPtr native__this, int comport)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortIsEmpty (comport);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortIsEmpty' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortIsEmpty", "(I)I", "GetPortIsEmpty_IHandler")]
			public virtual unsafe int PortIsEmpty (int comport)
			{
				const string __id = "PortIsEmpty.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (comport);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PortOpen_Api_I;
#pragma warning disable 0169
			static Delegate GetPortOpen_Api_IHandler ()
			{
				if (cb_PortOpen_Api_I == null)
					cb_PortOpen_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortOpen_Api_I));
				return cb_PortOpen_Api_I;
			}

			static int n_PortOpen_Api_I (IntPtr jnienv, IntPtr native__this, int comport)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortOpen_Api (comport);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortOpen_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortOpen_Api", "(I)I", "GetPortOpen_Api_IHandler")]
			public virtual unsafe int PortOpen_Api (int comport)
			{
				const string __id = "PortOpen_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (comport);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PortRecv_Api_IarrayBII;
#pragma warning disable 0169
			static Delegate GetPortRecv_Api_IarrayBIIHandler ()
			{
				if (cb_PortRecv_Api_IarrayBII == null)
					cb_PortRecv_Api_IarrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILII_I (n_PortRecv_Api_IarrayBII));
				return cb_PortRecv_Api_IarrayBII;
			}

			static int n_PortRecv_Api_IarrayBII (IntPtr jnienv, IntPtr native__this, int comport, IntPtr native_buf, int len, int ms)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PortRecv_Api (comport, buf, len, ms);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortRecv_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("PortRecv_Api", "(I[BII)I", "GetPortRecv_Api_IarrayBIIHandler")]
			public virtual unsafe int PortRecv_Api (int comport, byte[]? buf, int len, int ms)
			{
				const string __id = "PortRecv_Api.(I[BII)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (comport);
					__args [1] = new JniArgumentValue (native_buf);
					__args [2] = new JniArgumentValue (len);
					__args [3] = new JniArgumentValue (ms);
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

			static Delegate? cb_PortReset_Api_I;
#pragma warning disable 0169
			static Delegate GetPortReset_Api_IHandler ()
			{
				if (cb_PortReset_Api_I == null)
					cb_PortReset_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortReset_Api_I));
				return cb_PortReset_Api_I;
			}

			static int n_PortReset_Api_I (IntPtr jnienv, IntPtr native__this, int comport)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortReset_Api (comport);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortReset_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortReset_Api", "(I)I", "GetPortReset_Api_IHandler")]
			public virtual unsafe int PortReset_Api (int comport)
			{
				const string __id = "PortReset_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (comport);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PortSends_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetPortSends_Api_IarrayBIHandler ()
			{
				if (cb_PortSends_Api_IarrayBI == null)
					cb_PortSends_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_PortSends_Api_IarrayBI));
				return cb_PortSends_Api_IarrayBI;
			}

			static int n_PortSends_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int comport, IntPtr native_buf, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PortSends_Api (comport, buf, len);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortSends_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("PortSends_Api", "(I[BI)I", "GetPortSends_Api_IarrayBIHandler")]
			public virtual unsafe int PortSends_Api (int comport, byte[]? buf, int len)
			{
				const string __id = "PortSends_Api.(I[BI)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (comport);
					__args [1] = new JniArgumentValue (native_buf);
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

			static Delegate? cb_PortSetBaud_Api_IIIII;
#pragma warning disable 0169
			static Delegate GetPortSetBaud_Api_IIIIIHandler ()
			{
				if (cb_PortSetBaud_Api_IIIII == null)
					cb_PortSetBaud_Api_IIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIII_I (n_PortSetBaud_Api_IIIII));
				return cb_PortSetBaud_Api_IIIII;
			}

			static int n_PortSetBaud_Api_IIIII (IntPtr jnienv, IntPtr native__this, int comport, int baud, int databits, int parity, int stopbits)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortSetBaud_Api (comport, baud, databits, parity, stopbits);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='PortSetBaud_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("PortSetBaud_Api", "(IIIII)I", "GetPortSetBaud_Api_IIIIIHandler")]
			public virtual unsafe int PortSetBaud_Api (int comport, int baud, int databits, int parity, int stopbits)
			{
				const string __id = "PortSetBaud_Api.(IIIII)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (comport);
					__args [1] = new JniArgumentValue (baud);
					__args [2] = new JniArgumentValue (databits);
					__args [3] = new JniArgumentValue (parity);
					__args [4] = new JniArgumentValue (stopbits);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/rs232/Rs232Handler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/rs232/Rs232Handler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Stub']/constructor[@name='Rs232Handler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/rs232/Rs232Handler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/rs232/Rs232Handler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/rs232/Rs232Handler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/class[@name='Rs232Handler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.rs232.Rs232Handler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/rs232/Rs232Handler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/rs232/Rs232Handler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_PortClose_Api_I;
#pragma warning disable 0169
			static Delegate GetPortClose_Api_IHandler ()
			{
				if (cb_PortClose_Api_I == null)
					cb_PortClose_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortClose_Api_I));
				return cb_PortClose_Api_I;
			}

			static int n_PortClose_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortClose_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortClose_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortClose_Api", "(I)I", "GetPortClose_Api_IHandler")]
			public abstract int PortClose_Api (int p0);

			static Delegate? cb_PortIsBufferEmpty_IZ;
#pragma warning disable 0169
			static Delegate GetPortIsBufferEmpty_IZHandler ()
			{
				if (cb_PortIsBufferEmpty_IZ == null)
					cb_PortIsBufferEmpty_IZ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIZ_I (n_PortIsBufferEmpty_IZ));
				return cb_PortIsBufferEmpty_IZ;
			}

			static int n_PortIsBufferEmpty_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortIsBufferEmpty (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortIsBufferEmpty' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("PortIsBufferEmpty", "(IZ)I", "GetPortIsBufferEmpty_IZHandler")]
			public abstract int PortIsBufferEmpty (int p0, bool p1);

			static Delegate? cb_PortIsEmpty_I;
#pragma warning disable 0169
			static Delegate GetPortIsEmpty_IHandler ()
			{
				if (cb_PortIsEmpty_I == null)
					cb_PortIsEmpty_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortIsEmpty_I));
				return cb_PortIsEmpty_I;
			}

			static int n_PortIsEmpty_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortIsEmpty (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortIsEmpty' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortIsEmpty", "(I)I", "GetPortIsEmpty_IHandler")]
			public abstract int PortIsEmpty (int p0);

			static Delegate? cb_PortOpen_Api_I;
#pragma warning disable 0169
			static Delegate GetPortOpen_Api_IHandler ()
			{
				if (cb_PortOpen_Api_I == null)
					cb_PortOpen_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortOpen_Api_I));
				return cb_PortOpen_Api_I;
			}

			static int n_PortOpen_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortOpen_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortOpen_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortOpen_Api", "(I)I", "GetPortOpen_Api_IHandler")]
			public abstract int PortOpen_Api (int p0);

			static Delegate? cb_PortRecv_Api_IarrayBII;
#pragma warning disable 0169
			static Delegate GetPortRecv_Api_IarrayBIIHandler ()
			{
				if (cb_PortRecv_Api_IarrayBII == null)
					cb_PortRecv_Api_IarrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILII_I (n_PortRecv_Api_IarrayBII));
				return cb_PortRecv_Api_IarrayBII;
			}

			static int n_PortRecv_Api_IarrayBII (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PortRecv_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortRecv_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("PortRecv_Api", "(I[BII)I", "GetPortRecv_Api_IarrayBIIHandler")]
			public abstract int PortRecv_Api (int p0, byte[]? p1, int p2, int p3);

			static Delegate? cb_PortReset_Api_I;
#pragma warning disable 0169
			static Delegate GetPortReset_Api_IHandler ()
			{
				if (cb_PortReset_Api_I == null)
					cb_PortReset_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortReset_Api_I));
				return cb_PortReset_Api_I;
			}

			static int n_PortReset_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortReset_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortReset_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortReset_Api", "(I)I", "GetPortReset_Api_IHandler")]
			public abstract int PortReset_Api (int p0);

			static Delegate? cb_PortSends_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetPortSends_Api_IarrayBIHandler ()
			{
				if (cb_PortSends_Api_IarrayBI == null)
					cb_PortSends_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_PortSends_Api_IarrayBI));
				return cb_PortSends_Api_IarrayBI;
			}

			static int n_PortSends_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PortSends_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortSends_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("PortSends_Api", "(I[BI)I", "GetPortSends_Api_IarrayBIHandler")]
			public abstract int PortSends_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_PortSetBaud_Api_IIIII;
#pragma warning disable 0169
			static Delegate GetPortSetBaud_Api_IIIIIHandler ()
			{
				if (cb_PortSetBaud_Api_IIIII == null)
					cb_PortSetBaud_Api_IIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIII_I (n_PortSetBaud_Api_IIIII));
				return cb_PortSetBaud_Api_IIIII;
			}

			static int n_PortSetBaud_Api_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PortSetBaud_Api (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortSetBaud_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("PortSetBaud_Api", "(IIIII)I", "GetPortSetBaud_Api_IIIIIHandler")]
			public abstract int PortSetBaud_Api (int p0, int p1, int p2, int p3, int p4);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/rs232/Rs232Handler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/rs232/Rs232Handler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortClose_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortClose_Api", "(I)I", "GetPortClose_Api_IHandler")]
			public override unsafe int PortClose_Api (int p0)
			{
				const string __id = "PortClose_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortIsBufferEmpty' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("PortIsBufferEmpty", "(IZ)I", "GetPortIsBufferEmpty_IZHandler")]
			public override unsafe int PortIsBufferEmpty (int p0, bool p1)
			{
				const string __id = "PortIsBufferEmpty.(IZ)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortIsEmpty' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortIsEmpty", "(I)I", "GetPortIsEmpty_IHandler")]
			public override unsafe int PortIsEmpty (int p0)
			{
				const string __id = "PortIsEmpty.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortOpen_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortOpen_Api", "(I)I", "GetPortOpen_Api_IHandler")]
			public override unsafe int PortOpen_Api (int p0)
			{
				const string __id = "PortOpen_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortRecv_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("PortRecv_Api", "(I[BII)I", "GetPortRecv_Api_IarrayBIIHandler")]
			public override unsafe int PortRecv_Api (int p0, byte[]? p1, int p2, int p3)
			{
				const string __id = "PortRecv_Api.(I[BII)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortReset_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PortReset_Api", "(I)I", "GetPortReset_Api_IHandler")]
			public override unsafe int PortReset_Api (int p0)
			{
				const string __id = "PortReset_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortSends_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("PortSends_Api", "(I[BI)I", "GetPortSends_Api_IarrayBIHandler")]
			public override unsafe int PortSends_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "PortSends_Api.(I[BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.rs232']/interface[@name='Rs232Handler']/method[@name='PortSetBaud_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("PortSetBaud_Api", "(IIIII)I", "GetPortSetBaud_Api_IIIIIHandler")]
			public override unsafe int PortSetBaud_Api (int p0, int p1, int p2, int p3, int p4)
			{
				const string __id = "PortSetBaud_Api.(IIIII)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/rs232/Rs232Handler", DoNotGenerateAcw=true)]
	internal partial class IRs232HandlerInvoker : global::Java.Lang.Object, IRs232Handler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/rs232/Rs232Handler", typeof (IRs232HandlerInvoker));

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

		public static IRs232Handler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRs232Handler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.rs232.Rs232Handler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRs232HandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_PortClose_Api_I;
#pragma warning disable 0169
		static Delegate GetPortClose_Api_IHandler ()
		{
			if (cb_PortClose_Api_I == null)
				cb_PortClose_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortClose_Api_I));
			return cb_PortClose_Api_I;
		}

		static int n_PortClose_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PortClose_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PortClose_Api_I;
		public unsafe int PortClose_Api (int p0)
		{
			if (id_PortClose_Api_I == IntPtr.Zero)
				id_PortClose_Api_I = JNIEnv.GetMethodID (class_ref, "PortClose_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortClose_Api_I, __args);
		}

		static Delegate? cb_PortIsBufferEmpty_IZ;
#pragma warning disable 0169
		static Delegate GetPortIsBufferEmpty_IZHandler ()
		{
			if (cb_PortIsBufferEmpty_IZ == null)
				cb_PortIsBufferEmpty_IZ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIZ_I (n_PortIsBufferEmpty_IZ));
			return cb_PortIsBufferEmpty_IZ;
		}

		static int n_PortIsBufferEmpty_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PortIsBufferEmpty (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_PortIsBufferEmpty_IZ;
		public unsafe int PortIsBufferEmpty (int p0, bool p1)
		{
			if (id_PortIsBufferEmpty_IZ == IntPtr.Zero)
				id_PortIsBufferEmpty_IZ = JNIEnv.GetMethodID (class_ref, "PortIsBufferEmpty", "(IZ)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortIsBufferEmpty_IZ, __args);
		}

		static Delegate? cb_PortIsEmpty_I;
#pragma warning disable 0169
		static Delegate GetPortIsEmpty_IHandler ()
		{
			if (cb_PortIsEmpty_I == null)
				cb_PortIsEmpty_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortIsEmpty_I));
			return cb_PortIsEmpty_I;
		}

		static int n_PortIsEmpty_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PortIsEmpty (p0);
		}
#pragma warning restore 0169

		IntPtr id_PortIsEmpty_I;
		public unsafe int PortIsEmpty (int p0)
		{
			if (id_PortIsEmpty_I == IntPtr.Zero)
				id_PortIsEmpty_I = JNIEnv.GetMethodID (class_ref, "PortIsEmpty", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortIsEmpty_I, __args);
		}

		static Delegate? cb_PortOpen_Api_I;
#pragma warning disable 0169
		static Delegate GetPortOpen_Api_IHandler ()
		{
			if (cb_PortOpen_Api_I == null)
				cb_PortOpen_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortOpen_Api_I));
			return cb_PortOpen_Api_I;
		}

		static int n_PortOpen_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PortOpen_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PortOpen_Api_I;
		public unsafe int PortOpen_Api (int p0)
		{
			if (id_PortOpen_Api_I == IntPtr.Zero)
				id_PortOpen_Api_I = JNIEnv.GetMethodID (class_ref, "PortOpen_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortOpen_Api_I, __args);
		}

		static Delegate? cb_PortRecv_Api_IarrayBII;
#pragma warning disable 0169
		static Delegate GetPortRecv_Api_IarrayBIIHandler ()
		{
			if (cb_PortRecv_Api_IarrayBII == null)
				cb_PortRecv_Api_IarrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILII_I (n_PortRecv_Api_IarrayBII));
			return cb_PortRecv_Api_IarrayBII;
		}

		static int n_PortRecv_Api_IarrayBII (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PortRecv_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PortRecv_Api_IarrayBII;
		public unsafe int PortRecv_Api (int p0, byte[]? p1, int p2, int p3)
		{
			if (id_PortRecv_Api_IarrayBII == IntPtr.Zero)
				id_PortRecv_Api_IarrayBII = JNIEnv.GetMethodID (class_ref, "PortRecv_Api", "(I[BII)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortRecv_Api_IarrayBII, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_PortReset_Api_I;
#pragma warning disable 0169
		static Delegate GetPortReset_Api_IHandler ()
		{
			if (cb_PortReset_Api_I == null)
				cb_PortReset_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PortReset_Api_I));
			return cb_PortReset_Api_I;
		}

		static int n_PortReset_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PortReset_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PortReset_Api_I;
		public unsafe int PortReset_Api (int p0)
		{
			if (id_PortReset_Api_I == IntPtr.Zero)
				id_PortReset_Api_I = JNIEnv.GetMethodID (class_ref, "PortReset_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortReset_Api_I, __args);
		}

		static Delegate? cb_PortSends_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetPortSends_Api_IarrayBIHandler ()
		{
			if (cb_PortSends_Api_IarrayBI == null)
				cb_PortSends_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_PortSends_Api_IarrayBI));
			return cb_PortSends_Api_IarrayBI;
		}

		static int n_PortSends_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PortSends_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PortSends_Api_IarrayBI;
		public unsafe int PortSends_Api (int p0, byte[]? p1, int p2)
		{
			if (id_PortSends_Api_IarrayBI == IntPtr.Zero)
				id_PortSends_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "PortSends_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortSends_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_PortSetBaud_Api_IIIII;
#pragma warning disable 0169
		static Delegate GetPortSetBaud_Api_IIIIIHandler ()
		{
			if (cb_PortSetBaud_Api_IIIII == null)
				cb_PortSetBaud_Api_IIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIII_I (n_PortSetBaud_Api_IIIII));
			return cb_PortSetBaud_Api_IIIII;
		}

		static int n_PortSetBaud_Api_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PortSetBaud_Api (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_PortSetBaud_Api_IIIII;
		public unsafe int PortSetBaud_Api (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_PortSetBaud_Api_IIIII == IntPtr.Zero)
				id_PortSetBaud_Api_IIIII = JNIEnv.GetMethodID (class_ref, "PortSetBaud_Api", "(IIIII)I");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PortSetBaud_Api_IIIII, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Rs232.IRs232Handler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
