using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Taxcontrol {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']"
	[Register ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle", "", "Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandleInvoker")]
	public partial interface ITaxControlHandle : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlClosedev_Api' and count(parameter)=0]"
		[Register ("TaxControlClosedev_Api", "()I", "GetTaxControlClosedev_ApiHandler:Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandleInvoker, VanstonePosSdk")]
		int TaxControlClosedev_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlOpendev_Api' and count(parameter)=0]"
		[Register ("TaxControlOpendev_Api", "()I", "GetTaxControlOpendev_ApiHandler:Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandleInvoker, VanstonePosSdk")]
		int TaxControlOpendev_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlSenddevWithTimeOut_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("TaxControlSenddevWithTimeOut_Api", "([B[BI)I", "GetTaxControlSenddevWithTimeOut_Api_arrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandleInvoker, VanstonePosSdk")]
		int TaxControlSenddevWithTimeOut_Api (byte[]? p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlSenddev_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("TaxControlSenddev_Api", "([B[B)I", "GetTaxControlSenddev_Api_arrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandleInvoker, VanstonePosSdk")]
		int TaxControlSenddev_Api (byte[]? p0, byte[]? p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Default']/constructor[@name='TaxControlHandle.Default' and count(parameter)=0]"
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

			static Delegate? cb_TaxControlClosedev_Api;
#pragma warning disable 0169
			static Delegate GetTaxControlClosedev_ApiHandler ()
			{
				if (cb_TaxControlClosedev_Api == null)
					cb_TaxControlClosedev_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_TaxControlClosedev_Api));
				return cb_TaxControlClosedev_Api;
			}

			static int n_TaxControlClosedev_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.TaxControlClosedev_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Default']/method[@name='TaxControlClosedev_Api' and count(parameter)=0]"
			[Register ("TaxControlClosedev_Api", "()I", "GetTaxControlClosedev_ApiHandler")]
			public virtual unsafe int TaxControlClosedev_Api ()
			{
				const string __id = "TaxControlClosedev_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_TaxControlOpendev_Api;
#pragma warning disable 0169
			static Delegate GetTaxControlOpendev_ApiHandler ()
			{
				if (cb_TaxControlOpendev_Api == null)
					cb_TaxControlOpendev_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_TaxControlOpendev_Api));
				return cb_TaxControlOpendev_Api;
			}

			static int n_TaxControlOpendev_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.TaxControlOpendev_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Default']/method[@name='TaxControlOpendev_Api' and count(parameter)=0]"
			[Register ("TaxControlOpendev_Api", "()I", "GetTaxControlOpendev_ApiHandler")]
			public virtual unsafe int TaxControlOpendev_Api ()
			{
				const string __id = "TaxControlOpendev_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetTaxControlSenddevWithTimeOut_Api_arrayBarrayBIHandler ()
			{
				if (cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI == null)
					cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_I (n_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI));
				return cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI;
			}

			static int n_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_sebuffer, IntPtr native_rebuffer, int timeout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var sebuffer = (byte[]?) JNIEnv.GetArray (native_sebuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var rebuffer = (byte[]?) JNIEnv.GetArray (native_rebuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.TaxControlSenddevWithTimeOut_Api (sebuffer, rebuffer, timeout);
				if (sebuffer != null)
					JNIEnv.CopyArray (sebuffer, native_sebuffer);
				if (rebuffer != null)
					JNIEnv.CopyArray (rebuffer, native_rebuffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Default']/method[@name='TaxControlSenddevWithTimeOut_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("TaxControlSenddevWithTimeOut_Api", "([B[BI)I", "GetTaxControlSenddevWithTimeOut_Api_arrayBarrayBIHandler")]
			public virtual unsafe int TaxControlSenddevWithTimeOut_Api (byte[]? sebuffer, byte[]? rebuffer, int timeout)
			{
				const string __id = "TaxControlSenddevWithTimeOut_Api.([B[BI)I";
				IntPtr native_sebuffer = JNIEnv.NewArray (sebuffer);
				IntPtr native_rebuffer = JNIEnv.NewArray (rebuffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_sebuffer);
					__args [1] = new JniArgumentValue (native_rebuffer);
					__args [2] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (sebuffer != null) {
						JNIEnv.CopyArray (native_sebuffer, sebuffer);
						JNIEnv.DeleteLocalRef (native_sebuffer);
					}
					if (rebuffer != null) {
						JNIEnv.CopyArray (native_rebuffer, rebuffer);
						JNIEnv.DeleteLocalRef (native_rebuffer);
					}
					global::System.GC.KeepAlive (sebuffer);
					global::System.GC.KeepAlive (rebuffer);
				}
			}

			static Delegate? cb_TaxControlSenddev_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetTaxControlSenddev_Api_arrayBarrayBHandler ()
			{
				if (cb_TaxControlSenddev_Api_arrayBarrayB == null)
					cb_TaxControlSenddev_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_TaxControlSenddev_Api_arrayBarrayB));
				return cb_TaxControlSenddev_Api_arrayBarrayB;
			}

			static int n_TaxControlSenddev_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_sebuffer, IntPtr native_rebuffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var sebuffer = (byte[]?) JNIEnv.GetArray (native_sebuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var rebuffer = (byte[]?) JNIEnv.GetArray (native_rebuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.TaxControlSenddev_Api (sebuffer, rebuffer);
				if (sebuffer != null)
					JNIEnv.CopyArray (sebuffer, native_sebuffer);
				if (rebuffer != null)
					JNIEnv.CopyArray (rebuffer, native_rebuffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Default']/method[@name='TaxControlSenddev_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("TaxControlSenddev_Api", "([B[B)I", "GetTaxControlSenddev_Api_arrayBarrayBHandler")]
			public virtual unsafe int TaxControlSenddev_Api (byte[]? sebuffer, byte[]? rebuffer)
			{
				const string __id = "TaxControlSenddev_Api.([B[B)I";
				IntPtr native_sebuffer = JNIEnv.NewArray (sebuffer);
				IntPtr native_rebuffer = JNIEnv.NewArray (rebuffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_sebuffer);
					__args [1] = new JniArgumentValue (native_rebuffer);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (sebuffer != null) {
						JNIEnv.CopyArray (native_sebuffer, sebuffer);
						JNIEnv.DeleteLocalRef (native_sebuffer);
					}
					if (rebuffer != null) {
						JNIEnv.CopyArray (native_rebuffer, rebuffer);
						JNIEnv.DeleteLocalRef (native_rebuffer);
					}
					global::System.GC.KeepAlive (sebuffer);
					global::System.GC.KeepAlive (rebuffer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Stub']/constructor[@name='TaxControlHandle.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/class[@name='TaxControlHandle.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.taxcontrol.TaxControlHandle']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/taxcontrol/TaxControlHandle;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_TaxControlClosedev_Api;
#pragma warning disable 0169
			static Delegate GetTaxControlClosedev_ApiHandler ()
			{
				if (cb_TaxControlClosedev_Api == null)
					cb_TaxControlClosedev_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_TaxControlClosedev_Api));
				return cb_TaxControlClosedev_Api;
			}

			static int n_TaxControlClosedev_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.TaxControlClosedev_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlClosedev_Api' and count(parameter)=0]"
			[Register ("TaxControlClosedev_Api", "()I", "GetTaxControlClosedev_ApiHandler")]
			public abstract int TaxControlClosedev_Api ();

			static Delegate? cb_TaxControlOpendev_Api;
#pragma warning disable 0169
			static Delegate GetTaxControlOpendev_ApiHandler ()
			{
				if (cb_TaxControlOpendev_Api == null)
					cb_TaxControlOpendev_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_TaxControlOpendev_Api));
				return cb_TaxControlOpendev_Api;
			}

			static int n_TaxControlOpendev_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.TaxControlOpendev_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlOpendev_Api' and count(parameter)=0]"
			[Register ("TaxControlOpendev_Api", "()I", "GetTaxControlOpendev_ApiHandler")]
			public abstract int TaxControlOpendev_Api ();

			static Delegate? cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetTaxControlSenddevWithTimeOut_Api_arrayBarrayBIHandler ()
			{
				if (cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI == null)
					cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_I (n_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI));
				return cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI;
			}

			static int n_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.TaxControlSenddevWithTimeOut_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlSenddevWithTimeOut_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("TaxControlSenddevWithTimeOut_Api", "([B[BI)I", "GetTaxControlSenddevWithTimeOut_Api_arrayBarrayBIHandler")]
			public abstract int TaxControlSenddevWithTimeOut_Api (byte[]? p0, byte[]? p1, int p2);

			static Delegate? cb_TaxControlSenddev_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetTaxControlSenddev_Api_arrayBarrayBHandler ()
			{
				if (cb_TaxControlSenddev_Api_arrayBarrayB == null)
					cb_TaxControlSenddev_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_TaxControlSenddev_Api_arrayBarrayB));
				return cb_TaxControlSenddev_Api_arrayBarrayB;
			}

			static int n_TaxControlSenddev_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.TaxControlSenddev_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlSenddev_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("TaxControlSenddev_Api", "([B[B)I", "GetTaxControlSenddev_Api_arrayBarrayBHandler")]
			public abstract int TaxControlSenddev_Api (byte[]? p0, byte[]? p1);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlClosedev_Api' and count(parameter)=0]"
			[Register ("TaxControlClosedev_Api", "()I", "GetTaxControlClosedev_ApiHandler")]
			public override unsafe int TaxControlClosedev_Api ()
			{
				const string __id = "TaxControlClosedev_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlOpendev_Api' and count(parameter)=0]"
			[Register ("TaxControlOpendev_Api", "()I", "GetTaxControlOpendev_ApiHandler")]
			public override unsafe int TaxControlOpendev_Api ()
			{
				const string __id = "TaxControlOpendev_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlSenddevWithTimeOut_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("TaxControlSenddevWithTimeOut_Api", "([B[BI)I", "GetTaxControlSenddevWithTimeOut_Api_arrayBarrayBIHandler")]
			public override unsafe int TaxControlSenddevWithTimeOut_Api (byte[]? p0, byte[]? p1, int p2)
			{
				const string __id = "TaxControlSenddevWithTimeOut_Api.([B[BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.taxcontrol']/interface[@name='TaxControlHandle']/method[@name='TaxControlSenddev_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("TaxControlSenddev_Api", "([B[B)I", "GetTaxControlSenddev_Api_arrayBarrayBHandler")]
			public override unsafe int TaxControlSenddev_Api (byte[]? p0, byte[]? p1)
			{
				const string __id = "TaxControlSenddev_Api.([B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle", DoNotGenerateAcw=true)]
	internal partial class ITaxControlHandleInvoker : global::Java.Lang.Object, ITaxControlHandle {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/taxcontrol/TaxControlHandle", typeof (ITaxControlHandleInvoker));

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

		public static ITaxControlHandle? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITaxControlHandle> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.taxcontrol.TaxControlHandle'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITaxControlHandleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_TaxControlClosedev_Api;
#pragma warning disable 0169
		static Delegate GetTaxControlClosedev_ApiHandler ()
		{
			if (cb_TaxControlClosedev_Api == null)
				cb_TaxControlClosedev_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_TaxControlClosedev_Api));
			return cb_TaxControlClosedev_Api;
		}

		static int n_TaxControlClosedev_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.TaxControlClosedev_Api ();
		}
#pragma warning restore 0169

		IntPtr id_TaxControlClosedev_Api;
		public unsafe int TaxControlClosedev_Api ()
		{
			if (id_TaxControlClosedev_Api == IntPtr.Zero)
				id_TaxControlClosedev_Api = JNIEnv.GetMethodID (class_ref, "TaxControlClosedev_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_TaxControlClosedev_Api);
		}

		static Delegate? cb_TaxControlOpendev_Api;
#pragma warning disable 0169
		static Delegate GetTaxControlOpendev_ApiHandler ()
		{
			if (cb_TaxControlOpendev_Api == null)
				cb_TaxControlOpendev_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_TaxControlOpendev_Api));
			return cb_TaxControlOpendev_Api;
		}

		static int n_TaxControlOpendev_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.TaxControlOpendev_Api ();
		}
#pragma warning restore 0169

		IntPtr id_TaxControlOpendev_Api;
		public unsafe int TaxControlOpendev_Api ()
		{
			if (id_TaxControlOpendev_Api == IntPtr.Zero)
				id_TaxControlOpendev_Api = JNIEnv.GetMethodID (class_ref, "TaxControlOpendev_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_TaxControlOpendev_Api);
		}

		static Delegate? cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetTaxControlSenddevWithTimeOut_Api_arrayBarrayBIHandler ()
		{
			if (cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI == null)
				cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_I (n_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI));
			return cb_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI;
		}

		static int n_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TaxControlSenddevWithTimeOut_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI;
		public unsafe int TaxControlSenddevWithTimeOut_Api (byte[]? p0, byte[]? p1, int p2)
		{
			if (id_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI == IntPtr.Zero)
				id_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI = JNIEnv.GetMethodID (class_ref, "TaxControlSenddevWithTimeOut_Api", "([B[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_TaxControlSenddevWithTimeOut_Api_arrayBarrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_TaxControlSenddev_Api_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetTaxControlSenddev_Api_arrayBarrayBHandler ()
		{
			if (cb_TaxControlSenddev_Api_arrayBarrayB == null)
				cb_TaxControlSenddev_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_TaxControlSenddev_Api_arrayBarrayB));
			return cb_TaxControlSenddev_Api_arrayBarrayB;
		}

		static int n_TaxControlSenddev_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TaxControlSenddev_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_TaxControlSenddev_Api_arrayBarrayB;
		public unsafe int TaxControlSenddev_Api (byte[]? p0, byte[]? p1)
		{
			if (id_TaxControlSenddev_Api_arrayBarrayB == IntPtr.Zero)
				id_TaxControlSenddev_Api_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "TaxControlSenddev_Api", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_TaxControlSenddev_Api_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Taxcontrol.ITaxControlHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
