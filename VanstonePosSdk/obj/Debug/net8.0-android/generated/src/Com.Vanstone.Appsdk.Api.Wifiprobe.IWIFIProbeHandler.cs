using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Wifiprobe {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']"
	[Register ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler", "", "Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandlerInvoker")]
	public partial interface IWIFIProbeHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeCloseInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
		[Register ("WifiProbeCloseInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler:Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandlerInvoker, VanstonePosSdk")]
		void WifiProbeCloseInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeClose_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
		[Register ("WifiProbeClose_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler:Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandlerInvoker, VanstonePosSdk")]
		void WifiProbeClose_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
		[Register ("WifiProbeOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler:Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandlerInvoker, VanstonePosSdk")]
		void WifiProbeOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeRegister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
		[Register ("WifiProbeRegister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler:Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandlerInvoker, VanstonePosSdk")]
		void WifiProbeRegister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeStartInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
		[Register ("WifiProbeStartInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler:Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandlerInvoker, VanstonePosSdk")]
		void WifiProbeStartInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeUnregister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
		[Register ("WifiProbeUnregister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler:Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandlerInvoker, VanstonePosSdk")]
		void WifiProbeUnregister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/constructor[@name='WIFIProbeHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @callback = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeCloseInfo_Api (@callback);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/method[@name='WifiProbeCloseInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeCloseInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public virtual unsafe void WifiProbeCloseInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? @callback)
			{
				const string __id = "WifiProbeCloseInfo_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@callback);
				}
			}

			static Delegate? cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @callback = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeClose_Api (@callback);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/method[@name='WifiProbeClose_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeClose_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public virtual unsafe void WifiProbeClose_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? @callback)
			{
				const string __id = "WifiProbeClose_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@callback);
				}
			}

			static Delegate? cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @callback = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeOpen_Api (@callback);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/method[@name='WifiProbeOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public virtual unsafe void WifiProbeOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? @callback)
			{
				const string __id = "WifiProbeOpen_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@callback);
				}
			}

			static Delegate? cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler ()
			{
				if (cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == null)
					cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_));
				return cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
			}

			static void n_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @callback = (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeRegister_Api (@callback);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/method[@name='WifiProbeRegister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
			[Register ("WifiProbeRegister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler")]
			public virtual unsafe void WifiProbeRegister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? @callback)
			{
				const string __id = "WifiProbeRegister_Api.(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@callback);
				}
			}

			static Delegate? cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @callback = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeStartInfo_Api (@callback);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/method[@name='WifiProbeStartInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeStartInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public virtual unsafe void WifiProbeStartInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? @callback)
			{
				const string __id = "WifiProbeStartInfo_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@callback);
				}
			}

			static Delegate? cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler ()
			{
				if (cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == null)
					cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_));
				return cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
			}

			static void n_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @callback = (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeUnregister_Api (@callback);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/method[@name='WifiProbeUnregister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
			[Register ("WifiProbeUnregister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler")]
			public virtual unsafe void WifiProbeUnregister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? @callback)
			{
				const string __id = "WifiProbeUnregister_Api.(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@callback);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Stub']/constructor[@name='WIFIProbeHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/class[@name='WIFIProbeHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.wifiprobe.WIFIProbeHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeCloseInfo_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeCloseInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeCloseInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public abstract void WifiProbeCloseInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

			static Delegate? cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeClose_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeClose_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeClose_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public abstract void WifiProbeClose_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

			static Delegate? cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeOpen_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public abstract void WifiProbeOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

			static Delegate? cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler ()
			{
				if (cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == null)
					cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_));
				return cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
			}

			static void n_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeRegister_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeRegister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
			[Register ("WifiProbeRegister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler")]
			public abstract void WifiProbeRegister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0);

			static Delegate? cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
			{
				if (cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
					cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
				return cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
			}

			static void n_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeStartInfo_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeStartInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeStartInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public abstract void WifiProbeStartInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0);

			static Delegate? cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
#pragma warning disable 0169
			static Delegate GetWifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler ()
			{
				if (cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == null)
					cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_));
				return cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
			}

			static void n_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WifiProbeUnregister_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeUnregister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
			[Register ("WifiProbeUnregister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler")]
			public abstract void WifiProbeUnregister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeCloseInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeCloseInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public override unsafe void WifiProbeCloseInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
			{
				const string __id = "WifiProbeCloseInfo_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeClose_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeClose_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public override unsafe void WifiProbeClose_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
			{
				const string __id = "WifiProbeClose_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeOpen_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public override unsafe void WifiProbeOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
			{
				const string __id = "WifiProbeOpen_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeRegister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
			[Register ("WifiProbeRegister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler")]
			public override unsafe void WifiProbeRegister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0)
			{
				const string __id = "WifiProbeRegister_Api.(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeStartInfo_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ISwitchCallback']]"
			[Register ("WifiProbeStartInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V", "GetWifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler")]
			public override unsafe void WifiProbeStartInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
			{
				const string __id = "WifiProbeStartInfo_Api.(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.wifiprobe']/interface[@name='WIFIProbeHandler']/method[@name='WifiProbeUnregister_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.ITaskCallback']]"
			[Register ("WifiProbeUnregister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V", "GetWifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler")]
			public override unsafe void WifiProbeUnregister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0)
			{
				const string __id = "WifiProbeUnregister_Api.(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler", DoNotGenerateAcw=true)]
	internal partial class IWIFIProbeHandlerInvoker : global::Java.Lang.Object, IWIFIProbeHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/wifiprobe/WIFIProbeHandler", typeof (IWIFIProbeHandlerInvoker));

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

		public static IWIFIProbeHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWIFIProbeHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.wifiprobe.WIFIProbeHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWIFIProbeHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
		static Delegate GetWifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
		{
			if (cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
				cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
			return cb_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		}

		static void n_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WifiProbeCloseInfo_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		public unsafe void WifiProbeCloseInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
		{
			if (id_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == IntPtr.Zero)
				id_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNIEnv.GetMethodID (class_ref, "WifiProbeCloseInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_WifiProbeCloseInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_, __args);
		}

		static Delegate? cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
		static Delegate GetWifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
		{
			if (cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
				cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
			return cb_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		}

		static void n_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WifiProbeClose_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		public unsafe void WifiProbeClose_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
		{
			if (id_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == IntPtr.Zero)
				id_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNIEnv.GetMethodID (class_ref, "WifiProbeClose_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_WifiProbeClose_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_, __args);
		}

		static Delegate? cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
		static Delegate GetWifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
		{
			if (cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
				cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
			return cb_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		}

		static void n_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WifiProbeOpen_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		public unsafe void WifiProbeOpen_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
		{
			if (id_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == IntPtr.Zero)
				id_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNIEnv.GetMethodID (class_ref, "WifiProbeOpen_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_WifiProbeOpen_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_, __args);
		}

		static Delegate? cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
#pragma warning disable 0169
		static Delegate GetWifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler ()
		{
			if (cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == null)
				cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_));
			return cb_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
		}

		static void n_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WifiProbeRegister_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
		public unsafe void WifiProbeRegister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0)
		{
			if (id_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == IntPtr.Zero)
				id_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNIEnv.GetMethodID (class_ref, "WifiProbeRegister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_WifiProbeRegister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_, __args);
		}

		static Delegate? cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
#pragma warning disable 0169
		static Delegate GetWifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_Handler ()
		{
			if (cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == null)
				cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_));
			return cb_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		}

		static void n_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WifiProbeStartInfo_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_;
		public unsafe void WifiProbeStartInfo_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ISwitchCallback? p0)
		{
			if (id_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ == IntPtr.Zero)
				id_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_ = JNIEnv.GetMethodID (class_ref, "WifiProbeStartInfo_Api", "(Lcom/vanstone/appsdk/api/interfaces/ISwitchCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_WifiProbeStartInfo_Api_Lcom_vanstone_appsdk_api_interfaces_ISwitchCallback_, __args);
		}

		static Delegate? cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
#pragma warning disable 0169
		static Delegate GetWifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_Handler ()
		{
			if (cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == null)
				cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_));
			return cb_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
		}

		static void n_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WifiProbeUnregister_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_;
		public unsafe void WifiProbeUnregister_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.ITaskCallback? p0)
		{
			if (id_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ == IntPtr.Zero)
				id_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_ = JNIEnv.GetMethodID (class_ref, "WifiProbeUnregister_Api", "(Lcom/vanstone/appsdk/api/interfaces/ITaskCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_WifiProbeUnregister_Api_Lcom_vanstone_appsdk_api_interfaces_ITaskCallback_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Wifiprobe.IWIFIProbeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
