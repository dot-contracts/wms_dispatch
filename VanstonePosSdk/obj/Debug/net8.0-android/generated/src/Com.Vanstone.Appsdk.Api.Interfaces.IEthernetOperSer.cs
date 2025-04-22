using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']"
	[Register ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer", "", "Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSerInvoker")]
	public partial interface IEthernetOperSer : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetCloseResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("EthernetCloseResult", "(I)V", "GetEthernetCloseResult_IHandler:Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSerInvoker, VanstonePosSdk")]
		void EthernetCloseResult (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetGetIpConfigResult' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.VsIpConfiguration']]"
		[Register ("EthernetGetIpConfigResult", "(Lcom/vanstone/appsdk/api/struct/VsIpConfiguration;)V", "GetEthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_Handler:Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSerInvoker, VanstonePosSdk")]
		void EthernetGetIpConfigResult (global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetOpenResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("EthernetOpenResult", "(I)V", "GetEthernetOpenResult_IHandler:Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSerInvoker, VanstonePosSdk")]
		void EthernetOpenResult (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetSaveDhcpConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("EthernetSaveDhcpConfigResult", "(I)V", "GetEthernetSaveDhcpConfigResult_IHandler:Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSerInvoker, VanstonePosSdk")]
		void EthernetSaveDhcpConfigResult (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetSaveStaticConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("EthernetSaveStaticConfigResult", "(I)V", "GetEthernetSaveStaticConfigResult_IHandler:Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSerInvoker, VanstonePosSdk")]
		void EthernetSaveStaticConfigResult (int p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']/constructor[@name='IEthernetOperSer.Default' and count(parameter)=0]"
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

			static Delegate? cb_EthernetCloseResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetCloseResult_IHandler ()
			{
				if (cb_EthernetCloseResult_I == null)
					cb_EthernetCloseResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetCloseResult_I));
				return cb_EthernetCloseResult_I;
			}

			static void n_EthernetCloseResult_I (IntPtr jnienv, IntPtr native__this, int result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetCloseResult (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']/method[@name='EthernetCloseResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetCloseResult", "(I)V", "GetEthernetCloseResult_IHandler")]
			public virtual unsafe void EthernetCloseResult (int result)
			{
				const string __id = "EthernetCloseResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (result);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_;
#pragma warning disable 0169
			static Delegate GetEthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_Handler ()
			{
				if (cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ == null)
					cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_));
				return cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_;
			}

			static void n_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var config = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration> (native_config, JniHandleOwnership.DoNotTransfer);
				__this.EthernetGetIpConfigResult (config);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']/method[@name='EthernetGetIpConfigResult' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.VsIpConfiguration']]"
			[Register ("EthernetGetIpConfigResult", "(Lcom/vanstone/appsdk/api/struct/VsIpConfiguration;)V", "GetEthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_Handler")]
			public virtual unsafe void EthernetGetIpConfigResult (global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration? config)
			{
				const string __id = "EthernetGetIpConfigResult.(Lcom/vanstone/appsdk/api/struct/VsIpConfiguration;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (config);
				}
			}

			static Delegate? cb_EthernetOpenResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetOpenResult_IHandler ()
			{
				if (cb_EthernetOpenResult_I == null)
					cb_EthernetOpenResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetOpenResult_I));
				return cb_EthernetOpenResult_I;
			}

			static void n_EthernetOpenResult_I (IntPtr jnienv, IntPtr native__this, int result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetOpenResult (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']/method[@name='EthernetOpenResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetOpenResult", "(I)V", "GetEthernetOpenResult_IHandler")]
			public virtual unsafe void EthernetOpenResult (int result)
			{
				const string __id = "EthernetOpenResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (result);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_EthernetSaveDhcpConfigResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetSaveDhcpConfigResult_IHandler ()
			{
				if (cb_EthernetSaveDhcpConfigResult_I == null)
					cb_EthernetSaveDhcpConfigResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetSaveDhcpConfigResult_I));
				return cb_EthernetSaveDhcpConfigResult_I;
			}

			static void n_EthernetSaveDhcpConfigResult_I (IntPtr jnienv, IntPtr native__this, int result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetSaveDhcpConfigResult (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']/method[@name='EthernetSaveDhcpConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetSaveDhcpConfigResult", "(I)V", "GetEthernetSaveDhcpConfigResult_IHandler")]
			public virtual unsafe void EthernetSaveDhcpConfigResult (int result)
			{
				const string __id = "EthernetSaveDhcpConfigResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (result);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_EthernetSaveStaticConfigResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetSaveStaticConfigResult_IHandler ()
			{
				if (cb_EthernetSaveStaticConfigResult_I == null)
					cb_EthernetSaveStaticConfigResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetSaveStaticConfigResult_I));
				return cb_EthernetSaveStaticConfigResult_I;
			}

			static void n_EthernetSaveStaticConfigResult_I (IntPtr jnienv, IntPtr native__this, int result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetSaveStaticConfigResult (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']/method[@name='EthernetSaveStaticConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetSaveStaticConfigResult", "(I)V", "GetEthernetSaveStaticConfigResult_IHandler")]
			public virtual unsafe void EthernetSaveStaticConfigResult (int result)
			{
				const string __id = "EthernetSaveStaticConfigResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (result);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Stub']/constructor[@name='IEthernetOperSer.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IEthernetOperSer.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_EthernetCloseResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetCloseResult_IHandler ()
			{
				if (cb_EthernetCloseResult_I == null)
					cb_EthernetCloseResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetCloseResult_I));
				return cb_EthernetCloseResult_I;
			}

			static void n_EthernetCloseResult_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetCloseResult (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetCloseResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetCloseResult", "(I)V", "GetEthernetCloseResult_IHandler")]
			public abstract void EthernetCloseResult (int p0);

			static Delegate? cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_;
#pragma warning disable 0169
			static Delegate GetEthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_Handler ()
			{
				if (cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ == null)
					cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_));
				return cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_;
			}

			static void n_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.EthernetGetIpConfigResult (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetGetIpConfigResult' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.VsIpConfiguration']]"
			[Register ("EthernetGetIpConfigResult", "(Lcom/vanstone/appsdk/api/struct/VsIpConfiguration;)V", "GetEthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_Handler")]
			public abstract void EthernetGetIpConfigResult (global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration? p0);

			static Delegate? cb_EthernetOpenResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetOpenResult_IHandler ()
			{
				if (cb_EthernetOpenResult_I == null)
					cb_EthernetOpenResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetOpenResult_I));
				return cb_EthernetOpenResult_I;
			}

			static void n_EthernetOpenResult_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetOpenResult (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetOpenResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetOpenResult", "(I)V", "GetEthernetOpenResult_IHandler")]
			public abstract void EthernetOpenResult (int p0);

			static Delegate? cb_EthernetSaveDhcpConfigResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetSaveDhcpConfigResult_IHandler ()
			{
				if (cb_EthernetSaveDhcpConfigResult_I == null)
					cb_EthernetSaveDhcpConfigResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetSaveDhcpConfigResult_I));
				return cb_EthernetSaveDhcpConfigResult_I;
			}

			static void n_EthernetSaveDhcpConfigResult_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetSaveDhcpConfigResult (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetSaveDhcpConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetSaveDhcpConfigResult", "(I)V", "GetEthernetSaveDhcpConfigResult_IHandler")]
			public abstract void EthernetSaveDhcpConfigResult (int p0);

			static Delegate? cb_EthernetSaveStaticConfigResult_I;
#pragma warning disable 0169
			static Delegate GetEthernetSaveStaticConfigResult_IHandler ()
			{
				if (cb_EthernetSaveStaticConfigResult_I == null)
					cb_EthernetSaveStaticConfigResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetSaveStaticConfigResult_I));
				return cb_EthernetSaveStaticConfigResult_I;
			}

			static void n_EthernetSaveStaticConfigResult_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.EthernetSaveStaticConfigResult (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetSaveStaticConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetSaveStaticConfigResult", "(I)V", "GetEthernetSaveStaticConfigResult_IHandler")]
			public abstract void EthernetSaveStaticConfigResult (int p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetCloseResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetCloseResult", "(I)V", "GetEthernetCloseResult_IHandler")]
			public override unsafe void EthernetCloseResult (int p0)
			{
				const string __id = "EthernetCloseResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetGetIpConfigResult' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.VsIpConfiguration']]"
			[Register ("EthernetGetIpConfigResult", "(Lcom/vanstone/appsdk/api/struct/VsIpConfiguration;)V", "GetEthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_Handler")]
			public override unsafe void EthernetGetIpConfigResult (global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration? p0)
			{
				const string __id = "EthernetGetIpConfigResult.(Lcom/vanstone/appsdk/api/struct/VsIpConfiguration;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetOpenResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetOpenResult", "(I)V", "GetEthernetOpenResult_IHandler")]
			public override unsafe void EthernetOpenResult (int p0)
			{
				const string __id = "EthernetOpenResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetSaveDhcpConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetSaveDhcpConfigResult", "(I)V", "GetEthernetSaveDhcpConfigResult_IHandler")]
			public override unsafe void EthernetSaveDhcpConfigResult (int p0)
			{
				const string __id = "EthernetSaveDhcpConfigResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IEthernetOperSer']/method[@name='EthernetSaveStaticConfigResult' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("EthernetSaveStaticConfigResult", "(I)V", "GetEthernetSaveStaticConfigResult_IHandler")]
			public override unsafe void EthernetSaveStaticConfigResult (int p0)
			{
				const string __id = "EthernetSaveStaticConfigResult.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer", DoNotGenerateAcw=true)]
	internal partial class IEthernetOperSerInvoker : global::Java.Lang.Object, IEthernetOperSer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IEthernetOperSer", typeof (IEthernetOperSerInvoker));

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

		public static IEthernetOperSer? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEthernetOperSer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.interfaces.IEthernetOperSer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEthernetOperSerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_EthernetCloseResult_I;
#pragma warning disable 0169
		static Delegate GetEthernetCloseResult_IHandler ()
		{
			if (cb_EthernetCloseResult_I == null)
				cb_EthernetCloseResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetCloseResult_I));
			return cb_EthernetCloseResult_I;
		}

		static void n_EthernetCloseResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.EthernetCloseResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetCloseResult_I;
		public unsafe void EthernetCloseResult (int p0)
		{
			if (id_EthernetCloseResult_I == IntPtr.Zero)
				id_EthernetCloseResult_I = JNIEnv.GetMethodID (class_ref, "EthernetCloseResult", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetCloseResult_I, __args);
		}

		static Delegate? cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_;
#pragma warning disable 0169
		static Delegate GetEthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_Handler ()
		{
			if (cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ == null)
				cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_));
			return cb_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_;
		}

		static void n_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EthernetGetIpConfigResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_;
		public unsafe void EthernetGetIpConfigResult (global::Com.Vanstone.Appsdk.Api.Struct.VsIpConfiguration? p0)
		{
			if (id_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ == IntPtr.Zero)
				id_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_ = JNIEnv.GetMethodID (class_ref, "EthernetGetIpConfigResult", "(Lcom/vanstone/appsdk/api/struct/VsIpConfiguration;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetGetIpConfigResult_Lcom_vanstone_appsdk_api_struct_VsIpConfiguration_, __args);
		}

		static Delegate? cb_EthernetOpenResult_I;
#pragma warning disable 0169
		static Delegate GetEthernetOpenResult_IHandler ()
		{
			if (cb_EthernetOpenResult_I == null)
				cb_EthernetOpenResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetOpenResult_I));
			return cb_EthernetOpenResult_I;
		}

		static void n_EthernetOpenResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.EthernetOpenResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetOpenResult_I;
		public unsafe void EthernetOpenResult (int p0)
		{
			if (id_EthernetOpenResult_I == IntPtr.Zero)
				id_EthernetOpenResult_I = JNIEnv.GetMethodID (class_ref, "EthernetOpenResult", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetOpenResult_I, __args);
		}

		static Delegate? cb_EthernetSaveDhcpConfigResult_I;
#pragma warning disable 0169
		static Delegate GetEthernetSaveDhcpConfigResult_IHandler ()
		{
			if (cb_EthernetSaveDhcpConfigResult_I == null)
				cb_EthernetSaveDhcpConfigResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetSaveDhcpConfigResult_I));
			return cb_EthernetSaveDhcpConfigResult_I;
		}

		static void n_EthernetSaveDhcpConfigResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.EthernetSaveDhcpConfigResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetSaveDhcpConfigResult_I;
		public unsafe void EthernetSaveDhcpConfigResult (int p0)
		{
			if (id_EthernetSaveDhcpConfigResult_I == IntPtr.Zero)
				id_EthernetSaveDhcpConfigResult_I = JNIEnv.GetMethodID (class_ref, "EthernetSaveDhcpConfigResult", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetSaveDhcpConfigResult_I, __args);
		}

		static Delegate? cb_EthernetSaveStaticConfigResult_I;
#pragma warning disable 0169
		static Delegate GetEthernetSaveStaticConfigResult_IHandler ()
		{
			if (cb_EthernetSaveStaticConfigResult_I == null)
				cb_EthernetSaveStaticConfigResult_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_EthernetSaveStaticConfigResult_I));
			return cb_EthernetSaveStaticConfigResult_I;
		}

		static void n_EthernetSaveStaticConfigResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.EthernetSaveStaticConfigResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetSaveStaticConfigResult_I;
		public unsafe void EthernetSaveStaticConfigResult (int p0)
		{
			if (id_EthernetSaveStaticConfigResult_I == IntPtr.Zero)
				id_EthernetSaveStaticConfigResult_I = JNIEnv.GetMethodID (class_ref, "EthernetSaveStaticConfigResult", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetSaveStaticConfigResult_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
