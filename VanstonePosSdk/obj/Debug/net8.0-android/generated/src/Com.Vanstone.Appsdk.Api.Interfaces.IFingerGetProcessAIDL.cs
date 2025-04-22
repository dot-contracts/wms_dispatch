using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']"
	[Register ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL", "", "Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDLInvoker")]
	public partial interface IFingerGetProcessAIDL : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='failed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("failed", "(I)V", "GetFailed_IHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDLInvoker, VanstonePosSdk")]
		void Failed (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='putFinger' and count(parameter)=0]"
		[Register ("putFinger", "()V", "GetPutFingerHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDLInvoker, VanstonePosSdk")]
		void PutFinger ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='success' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("success", "([BI)V", "GetSuccess_arrayBIHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDLInvoker, VanstonePosSdk")]
		void Success (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='upImg' and count(parameter)=0]"
		[Register ("upImg", "()V", "GetUpImgHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDLInvoker, VanstonePosSdk")]
		void UpImg ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Default']/constructor[@name='IFingerGetProcessAIDL.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_failed_I;
#pragma warning disable 0169
			static Delegate GetFailed_IHandler ()
			{
				if (cb_failed_I == null)
					cb_failed_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Failed_I));
				return cb_failed_I;
			}

			static void n_Failed_I (IntPtr jnienv, IntPtr native__this, int i)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.Failed (i);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Default']/method[@name='failed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("failed", "(I)V", "GetFailed_IHandler")]
			public virtual unsafe void Failed (int i)
			{
				const string __id = "failed.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (i);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_putFinger;
#pragma warning disable 0169
			static Delegate GetPutFingerHandler ()
			{
				if (cb_putFinger == null)
					cb_putFinger = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PutFinger));
				return cb_putFinger;
			}

			static void n_PutFinger (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PutFinger ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Default']/method[@name='putFinger' and count(parameter)=0]"
			[Register ("putFinger", "()V", "GetPutFingerHandler")]
			public virtual unsafe void PutFinger ()
			{
				const string __id = "putFinger.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_success_arrayBI;
#pragma warning disable 0169
			static Delegate GetSuccess_arrayBIHandler ()
			{
				if (cb_success_arrayBI == null)
					cb_success_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_Success_arrayBI));
				return cb_success_arrayBI;
			}

			static void n_Success_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes, int i)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bytes = (byte[]?) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Success (bytes, i);
				if (bytes != null)
					JNIEnv.CopyArray (bytes, native_bytes);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Default']/method[@name='success' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("success", "([BI)V", "GetSuccess_arrayBIHandler")]
			public virtual unsafe void Success (byte[]? bytes, int i)
			{
				const string __id = "success.([BI)V";
				IntPtr native_bytes = JNIEnv.NewArray (bytes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_bytes);
					__args [1] = new JniArgumentValue (i);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (bytes != null) {
						JNIEnv.CopyArray (native_bytes, bytes);
						JNIEnv.DeleteLocalRef (native_bytes);
					}
					global::System.GC.KeepAlive (bytes);
				}
			}

			static Delegate? cb_upImg;
#pragma warning disable 0169
			static Delegate GetUpImgHandler ()
			{
				if (cb_upImg == null)
					cb_upImg = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_UpImg));
				return cb_upImg;
			}

			static void n_UpImg (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.UpImg ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Default']/method[@name='upImg' and count(parameter)=0]"
			[Register ("upImg", "()V", "GetUpImgHandler")]
			public virtual unsafe void UpImg ()
			{
				const string __id = "upImg.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Stub']/constructor[@name='IFingerGetProcessAIDL.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFingerGetProcessAIDL.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IFingerGetProcessAIDL']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_failed_I;
#pragma warning disable 0169
			static Delegate GetFailed_IHandler ()
			{
				if (cb_failed_I == null)
					cb_failed_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Failed_I));
				return cb_failed_I;
			}

			static void n_Failed_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.Failed (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='failed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("failed", "(I)V", "GetFailed_IHandler")]
			public abstract void Failed (int p0);

			static Delegate? cb_putFinger;
#pragma warning disable 0169
			static Delegate GetPutFingerHandler ()
			{
				if (cb_putFinger == null)
					cb_putFinger = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PutFinger));
				return cb_putFinger;
			}

			static void n_PutFinger (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PutFinger ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='putFinger' and count(parameter)=0]"
			[Register ("putFinger", "()V", "GetPutFingerHandler")]
			public abstract void PutFinger ();

			static Delegate? cb_success_arrayBI;
#pragma warning disable 0169
			static Delegate GetSuccess_arrayBIHandler ()
			{
				if (cb_success_arrayBI == null)
					cb_success_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_Success_arrayBI));
				return cb_success_arrayBI;
			}

			static void n_Success_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Success (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='success' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("success", "([BI)V", "GetSuccess_arrayBIHandler")]
			public abstract void Success (byte[]? p0, int p1);

			static Delegate? cb_upImg;
#pragma warning disable 0169
			static Delegate GetUpImgHandler ()
			{
				if (cb_upImg == null)
					cb_upImg = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_UpImg));
				return cb_upImg;
			}

			static void n_UpImg (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.UpImg ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='upImg' and count(parameter)=0]"
			[Register ("upImg", "()V", "GetUpImgHandler")]
			public abstract void UpImg ();

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='failed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("failed", "(I)V", "GetFailed_IHandler")]
			public override unsafe void Failed (int p0)
			{
				const string __id = "failed.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='putFinger' and count(parameter)=0]"
			[Register ("putFinger", "()V", "GetPutFingerHandler")]
			public override unsafe void PutFinger ()
			{
				const string __id = "putFinger.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='success' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("success", "([BI)V", "GetSuccess_arrayBIHandler")]
			public override unsafe void Success (byte[]? p0, int p1)
			{
				const string __id = "success.([BI)V";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFingerGetProcessAIDL']/method[@name='upImg' and count(parameter)=0]"
			[Register ("upImg", "()V", "GetUpImgHandler")]
			public override unsafe void UpImg ()
			{
				const string __id = "upImg.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL", DoNotGenerateAcw=true)]
	internal partial class IFingerGetProcessAIDLInvoker : global::Java.Lang.Object, IFingerGetProcessAIDL {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFingerGetProcessAIDL", typeof (IFingerGetProcessAIDLInvoker));

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

		public static IFingerGetProcessAIDL? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFingerGetProcessAIDL> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.interfaces.IFingerGetProcessAIDL'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFingerGetProcessAIDLInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_failed_I;
#pragma warning disable 0169
		static Delegate GetFailed_IHandler ()
		{
			if (cb_failed_I == null)
				cb_failed_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Failed_I));
			return cb_failed_I;
		}

		static void n_Failed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Failed (p0);
		}
#pragma warning restore 0169

		IntPtr id_failed_I;
		public unsafe void Failed (int p0)
		{
			if (id_failed_I == IntPtr.Zero)
				id_failed_I = JNIEnv.GetMethodID (class_ref, "failed", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_failed_I, __args);
		}

		static Delegate? cb_putFinger;
#pragma warning disable 0169
		static Delegate GetPutFingerHandler ()
		{
			if (cb_putFinger == null)
				cb_putFinger = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PutFinger));
			return cb_putFinger;
		}

		static void n_PutFinger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PutFinger ();
		}
#pragma warning restore 0169

		IntPtr id_putFinger;
		public unsafe void PutFinger ()
		{
			if (id_putFinger == IntPtr.Zero)
				id_putFinger = JNIEnv.GetMethodID (class_ref, "putFinger", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putFinger);
		}

		static Delegate? cb_success_arrayBI;
#pragma warning disable 0169
		static Delegate GetSuccess_arrayBIHandler ()
		{
			if (cb_success_arrayBI == null)
				cb_success_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_Success_arrayBI));
			return cb_success_arrayBI;
		}

		static void n_Success_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Success (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_success_arrayBI;
		public unsafe void Success (byte[]? p0, int p1)
		{
			if (id_success_arrayBI == IntPtr.Zero)
				id_success_arrayBI = JNIEnv.GetMethodID (class_ref, "success", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_success_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_upImg;
#pragma warning disable 0169
		static Delegate GetUpImgHandler ()
		{
			if (cb_upImg == null)
				cb_upImg = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_UpImg));
			return cb_upImg;
		}

		static void n_UpImg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.UpImg ();
		}
#pragma warning restore 0169

		IntPtr id_upImg;
		public unsafe void UpImg ()
		{
			if (id_upImg == IntPtr.Zero)
				id_upImg = JNIEnv.GetMethodID (class_ref, "upImg", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upImg);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFingerGetProcessAIDL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
