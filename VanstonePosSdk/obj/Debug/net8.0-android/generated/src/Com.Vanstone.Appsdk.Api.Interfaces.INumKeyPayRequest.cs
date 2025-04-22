using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyPayRequest']"
	[Register ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest", "", "Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequestInvoker")]
	public partial interface INumKeyPayRequest : global::Android.OS.IInterface {
		double Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyPayRequest']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()D", "GetGetAmountHandler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequestInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyPayRequest']/method[@name='displayTransResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("displayTransResult", "(Z)V", "GetDisplayTransResult_ZHandler:Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequestInvoker, VanstonePosSdk")]
		void DisplayTransResult (bool p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Default']/constructor[@name='INumKeyPayRequest.Default' and count(parameter)=0]"
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

			static Delegate? cb_getAmount;
#pragma warning disable 0169
			static Delegate GetGetAmountHandler ()
			{
				if (cb_getAmount == null)
					cb_getAmount = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_GetAmount));
				return cb_getAmount;
			}

			static double n_GetAmount (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Amount;
			}
#pragma warning restore 0169

			public virtual unsafe double Amount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Default']/method[@name='getAmount' and count(parameter)=0]"
				[Register ("getAmount", "()D", "GetGetAmountHandler")]
				get {
					const string __id = "getAmount.()D";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
						return __rm;
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_displayTransResult_Z;
#pragma warning disable 0169
			static Delegate GetDisplayTransResult_ZHandler ()
			{
				if (cb_displayTransResult_Z == null)
					cb_displayTransResult_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_DisplayTransResult_Z));
				return cb_displayTransResult_Z;
			}

			static void n_DisplayTransResult_Z (IntPtr jnienv, IntPtr native__this, bool result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.DisplayTransResult (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Default']/method[@name='displayTransResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("displayTransResult", "(Z)V", "GetDisplayTransResult_ZHandler")]
			public virtual unsafe void DisplayTransResult (bool result)
			{
				const string __id = "displayTransResult.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (result);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/constructor[@name='INumKeyPayRequest.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.INumKeyPayRequest']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/interfaces/INumKeyPayRequest;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_displayTransResult_Z;
#pragma warning disable 0169
			static Delegate GetDisplayTransResult_ZHandler ()
			{
				if (cb_displayTransResult_Z == null)
					cb_displayTransResult_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_DisplayTransResult_Z));
				return cb_displayTransResult_Z;
			}

			static void n_DisplayTransResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.DisplayTransResult (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyPayRequest']/method[@name='displayTransResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("displayTransResult", "(Z)V", "GetDisplayTransResult_ZHandler")]
			public abstract void DisplayTransResult (bool p0);

			static Delegate? cb_getAmount;
#pragma warning disable 0169
			static Delegate GetGetAmountHandler ()
			{
				if (cb_getAmount == null)
					cb_getAmount = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_GetAmount));
				return cb_getAmount;
			}

			static double n_GetAmount (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Amount;
			}
#pragma warning restore 0169

			public abstract double Amount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/method[@name='getAmount' and count(parameter)=0]"
				[Register ("getAmount", "()D", "GetGetAmountHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest$Stub", typeof (StubInvoker));

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

			public override unsafe double Amount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='INumKeyPayRequest.Stub']/method[@name='getAmount' and count(parameter)=0]"
				[Register ("getAmount", "()D", "GetGetAmountHandler")]
				get {
					const string __id = "getAmount.()D";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='INumKeyPayRequest']/method[@name='displayTransResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("displayTransResult", "(Z)V", "GetDisplayTransResult_ZHandler")]
			public override unsafe void DisplayTransResult (bool p0)
			{
				const string __id = "displayTransResult.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest", DoNotGenerateAcw=true)]
	internal partial class INumKeyPayRequestInvoker : global::Java.Lang.Object, INumKeyPayRequest {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/INumKeyPayRequest", typeof (INumKeyPayRequestInvoker));

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

		public static INumKeyPayRequest? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INumKeyPayRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.interfaces.INumKeyPayRequest'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INumKeyPayRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_GetAmount));
			return cb_getAmount;
		}

		static double n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Amount;
		}
#pragma warning restore 0169

		IntPtr id_getAmount;
		public unsafe double Amount {
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAmount);
			}
		}

		static Delegate? cb_displayTransResult_Z;
#pragma warning disable 0169
		static Delegate GetDisplayTransResult_ZHandler ()
		{
			if (cb_displayTransResult_Z == null)
				cb_displayTransResult_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_DisplayTransResult_Z));
			return cb_displayTransResult_Z;
		}

		static void n_DisplayTransResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.DisplayTransResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_displayTransResult_Z;
		public unsafe void DisplayTransResult (bool p0)
		{
			if (id_displayTransResult_Z == IntPtr.Zero)
				id_displayTransResult_Z = JNIEnv.GetMethodID (class_ref, "displayTransResult", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_displayTransResult_Z, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.INumKeyPayRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
