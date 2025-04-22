using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']"
	[Register ("com/vanstone/appsdk/api/common/CommHandler", "", "Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker")]
	public partial interface ICommHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetClose' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
		[Register ("EthernetClose", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler:Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker, VanstonePosSdk")]
		void EthernetClose (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetGetIpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
		[Register ("EthernetGetIpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler:Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker, VanstonePosSdk")]
		void EthernetGetIpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetOpen' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
		[Register ("EthernetOpen", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler:Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker, VanstonePosSdk")]
		void EthernetOpen (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetSaveDhcpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
		[Register ("EthernetSaveDhcpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler:Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker, VanstonePosSdk")]
		void EthernetSaveDhcpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetSaveStaticConfig' and count(parameter)=5 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("EthernetSaveStaticConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetEthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker, VanstonePosSdk")]
		void EthernetSaveStaticConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0, string? p1, string? p2, string? p3, string? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='addApn' and count(parameter)=2 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAPNOperSer']]"
		[Register ("addApn", "(Landroid/content/ContentValues;Lcom/vanstone/appsdk/api/interfaces/IAPNOperSer;)V", "GetAddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_Handler:Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker, VanstonePosSdk")]
		void AddApn (global::Android.Content.ContentValues? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='openGPRS' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("openGPRS", "(Z)V", "GetOpenGPRS_ZHandler:Com.Vanstone.Appsdk.Api.Common.ICommHandlerInvoker, VanstonePosSdk")]
		void OpenGPRS (bool p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/CommHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Common.ICommHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/CommHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/constructor[@name='CommHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oper)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var oper = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_oper, JniHandleOwnership.DoNotTransfer);
				__this.EthernetClose (oper);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='EthernetClose' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetClose", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public virtual unsafe void EthernetClose (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? oper)
			{
				const string __id = "EthernetClose.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((oper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oper).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (oper);
				}
			}

			static Delegate? cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oper)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var oper = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_oper, JniHandleOwnership.DoNotTransfer);
				__this.EthernetGetIpConfig (oper);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='EthernetGetIpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetGetIpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public virtual unsafe void EthernetGetIpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? oper)
			{
				const string __id = "EthernetGetIpConfig.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((oper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oper).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (oper);
				}
			}

			static Delegate? cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oper)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var oper = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_oper, JniHandleOwnership.DoNotTransfer);
				__this.EthernetOpen (oper);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='EthernetOpen' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetOpen", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public virtual unsafe void EthernetOpen (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? oper)
			{
				const string __id = "EthernetOpen.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((oper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oper).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (oper);
				}
			}

			static Delegate? cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oper)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var oper = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_oper, JniHandleOwnership.DoNotTransfer);
				__this.EthernetSaveDhcpConfig (oper);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='EthernetSaveDhcpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetSaveDhcpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public virtual unsafe void EthernetSaveDhcpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? oper)
			{
				const string __id = "EthernetSaveDhcpConfig.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((oper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oper).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (oper);
				}
			}

			static Delegate? cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetEthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
				return cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oper, IntPtr native_mIpaddr, IntPtr native_mDns, IntPtr native_mGw, IntPtr native_mprefix)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var oper = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_oper, JniHandleOwnership.DoNotTransfer);
				var mIpaddr = JNIEnv.GetString (native_mIpaddr, JniHandleOwnership.DoNotTransfer);
				var mDns = JNIEnv.GetString (native_mDns, JniHandleOwnership.DoNotTransfer);
				var mGw = JNIEnv.GetString (native_mGw, JniHandleOwnership.DoNotTransfer);
				var mprefix = JNIEnv.GetString (native_mprefix, JniHandleOwnership.DoNotTransfer);
				__this.EthernetSaveStaticConfig (oper, mIpaddr, mDns, mGw, mprefix);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='EthernetSaveStaticConfig' and count(parameter)=5 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
			[Register ("EthernetSaveStaticConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetEthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void EthernetSaveStaticConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? oper, string? mIpaddr, string? mDns, string? mGw, string? mprefix)
			{
				const string __id = "EthernetSaveStaticConfig.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
				IntPtr native_mIpaddr = JNIEnv.NewString ((string?)mIpaddr);
				IntPtr native_mDns = JNIEnv.NewString ((string?)mDns);
				IntPtr native_mGw = JNIEnv.NewString ((string?)mGw);
				IntPtr native_mprefix = JNIEnv.NewString ((string?)mprefix);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue ((oper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oper).Handle);
					__args [1] = new JniArgumentValue (native_mIpaddr);
					__args [2] = new JniArgumentValue (native_mDns);
					__args [3] = new JniArgumentValue (native_mGw);
					__args [4] = new JniArgumentValue (native_mprefix);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_mIpaddr);
					JNIEnv.DeleteLocalRef (native_mDns);
					JNIEnv.DeleteLocalRef (native_mGw);
					JNIEnv.DeleteLocalRef (native_mprefix);
					global::System.GC.KeepAlive (oper);
				}
			}

			static Delegate? cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_;
#pragma warning disable 0169
			static Delegate GetAddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_Handler ()
			{
				if (cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ == null)
					cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_));
				return cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_;
			}

			static void n_AddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values, IntPtr native_oper)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var values = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_values, JniHandleOwnership.DoNotTransfer);
				var oper = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer> (native_oper, JniHandleOwnership.DoNotTransfer);
				__this.AddApn (values, oper);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='addApn' and count(parameter)=2 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAPNOperSer']]"
			[Register ("addApn", "(Landroid/content/ContentValues;Lcom/vanstone/appsdk/api/interfaces/IAPNOperSer;)V", "GetAddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_Handler")]
			public virtual unsafe void AddApn (global::Android.Content.ContentValues? values, global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer? oper)
			{
				const string __id = "addApn.(Landroid/content/ContentValues;Lcom/vanstone/appsdk/api/interfaces/IAPNOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((values == null) ? IntPtr.Zero : ((global::Java.Lang.Object) values).Handle);
					__args [1] = new JniArgumentValue ((oper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oper).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (values);
					global::System.GC.KeepAlive (oper);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_openGPRS_Z;
#pragma warning disable 0169
			static Delegate GetOpenGPRS_ZHandler ()
			{
				if (cb_openGPRS_Z == null)
					cb_openGPRS_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_OpenGPRS_Z));
				return cb_openGPRS_Z;
			}

			static void n_OpenGPRS_Z (IntPtr jnienv, IntPtr native__this, bool oper)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OpenGPRS (oper);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Default']/method[@name='openGPRS' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("openGPRS", "(Z)V", "GetOpenGPRS_ZHandler")]
			public virtual unsafe void OpenGPRS (bool oper)
			{
				const string __id = "openGPRS.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (oper);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/CommHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Common.ICommHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/CommHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Stub']/constructor[@name='CommHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/common/CommHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/common/CommHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/common/CommHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/common/CommHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='CommHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.common.CommHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/common/CommHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Common.ICommHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/common/CommHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.EthernetClose (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetClose' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetClose", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public abstract void EthernetClose (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

			static Delegate? cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.EthernetGetIpConfig (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetGetIpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetGetIpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public abstract void EthernetGetIpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

			static Delegate? cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.EthernetOpen (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetOpen' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetOpen", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public abstract void EthernetOpen (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

			static Delegate? cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
			static Delegate GetEthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
			{
				if (cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
					cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
				return cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
			}

			static void n_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.EthernetSaveDhcpConfig (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetSaveDhcpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetSaveDhcpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public abstract void EthernetSaveDhcpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0);

			static Delegate? cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetEthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
				return cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
				var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.EthernetSaveStaticConfig (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetSaveStaticConfig' and count(parameter)=5 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
			[Register ("EthernetSaveStaticConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetEthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
			public abstract void EthernetSaveStaticConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0, string? p1, string? p2, string? p3, string? p4);

			static Delegate? cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_;
#pragma warning disable 0169
			static Delegate GetAddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_Handler ()
			{
				if (cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ == null)
					cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_));
				return cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_;
			}

			static void n_AddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.AddApn (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='addApn' and count(parameter)=2 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAPNOperSer']]"
			[Register ("addApn", "(Landroid/content/ContentValues;Lcom/vanstone/appsdk/api/interfaces/IAPNOperSer;)V", "GetAddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_Handler")]
			public abstract void AddApn (global::Android.Content.ContentValues? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer? p1);

			static Delegate? cb_openGPRS_Z;
#pragma warning disable 0169
			static Delegate GetOpenGPRS_ZHandler ()
			{
				if (cb_openGPRS_Z == null)
					cb_openGPRS_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_OpenGPRS_Z));
				return cb_openGPRS_Z;
			}

			static void n_OpenGPRS_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OpenGPRS (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='openGPRS' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("openGPRS", "(Z)V", "GetOpenGPRS_ZHandler")]
			public abstract void OpenGPRS (bool p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/CommHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/CommHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetClose' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetClose", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public override unsafe void EthernetClose (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
			{
				const string __id = "EthernetClose.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetGetIpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetGetIpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public override unsafe void EthernetGetIpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
			{
				const string __id = "EthernetGetIpConfig.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetOpen' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetOpen", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public override unsafe void EthernetOpen (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
			{
				const string __id = "EthernetOpen.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetSaveDhcpConfig' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer']]"
			[Register ("EthernetSaveDhcpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V", "GetEthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler")]
			public override unsafe void EthernetSaveDhcpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
			{
				const string __id = "EthernetSaveDhcpConfig.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='EthernetSaveStaticConfig' and count(parameter)=5 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IEthernetOperSer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
			[Register ("EthernetSaveStaticConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetEthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
			public override unsafe void EthernetSaveStaticConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0, string? p1, string? p2, string? p3, string? p4)
			{
				const string __id = "EthernetSaveStaticConfig.(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
				IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
				IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					JNIEnv.DeleteLocalRef (native_p4);
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='addApn' and count(parameter)=2 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAPNOperSer']]"
			[Register ("addApn", "(Landroid/content/ContentValues;Lcom/vanstone/appsdk/api/interfaces/IAPNOperSer;)V", "GetAddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_Handler")]
			public override unsafe void AddApn (global::Android.Content.ContentValues? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer? p1)
			{
				const string __id = "addApn.(Landroid/content/ContentValues;Lcom/vanstone/appsdk/api/interfaces/IAPNOperSer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='CommHandler']/method[@name='openGPRS' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("openGPRS", "(Z)V", "GetOpenGPRS_ZHandler")]
			public override unsafe void OpenGPRS (bool p0)
			{
				const string __id = "openGPRS.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/CommHandler", DoNotGenerateAcw=true)]
	internal partial class ICommHandlerInvoker : global::Java.Lang.Object, ICommHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/CommHandler", typeof (ICommHandlerInvoker));

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

		public static ICommHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.common.CommHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
		static Delegate GetEthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
		{
			if (cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
				cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
			return cb_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		}

		static void n_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EthernetClose (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		public unsafe void EthernetClose (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
		{
			if (id_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == IntPtr.Zero)
				id_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNIEnv.GetMethodID (class_ref, "EthernetClose", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetClose_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_, __args);
		}

		static Delegate? cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
		static Delegate GetEthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
		{
			if (cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
				cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
			return cb_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		}

		static void n_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EthernetGetIpConfig (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		public unsafe void EthernetGetIpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
		{
			if (id_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == IntPtr.Zero)
				id_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNIEnv.GetMethodID (class_ref, "EthernetGetIpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetGetIpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_, __args);
		}

		static Delegate? cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
		static Delegate GetEthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
		{
			if (cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
				cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
			return cb_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		}

		static void n_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EthernetOpen (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		public unsafe void EthernetOpen (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
		{
			if (id_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == IntPtr.Zero)
				id_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNIEnv.GetMethodID (class_ref, "EthernetOpen", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetOpen_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_, __args);
		}

		static Delegate? cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
#pragma warning disable 0169
		static Delegate GetEthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Handler ()
		{
			if (cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == null)
				cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_));
			return cb_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		}

		static void n_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EthernetSaveDhcpConfig (p0);
		}
#pragma warning restore 0169

		IntPtr id_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_;
		public unsafe void EthernetSaveDhcpConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0)
		{
			if (id_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ == IntPtr.Zero)
				id_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_ = JNIEnv.GetMethodID (class_ref, "EthernetSaveDhcpConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetSaveDhcpConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_, __args);
		}

		static Delegate? cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.EthernetSaveStaticConfig (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void EthernetSaveStaticConfig (global::Com.Vanstone.Appsdk.Api.Interfaces.IEthernetOperSer? p0, string? p1, string? p2, string? p3, string? p4)
		{
			if (id_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "EthernetSaveStaticConfig", "(Lcom/vanstone/appsdk/api/interfaces/IEthernetOperSer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EthernetSaveStaticConfig_Lcom_vanstone_appsdk_api_interfaces_IEthernetOperSer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate? cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_;
#pragma warning disable 0169
		static Delegate GetAddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_Handler ()
		{
			if (cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ == null)
				cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_));
			return cb_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_;
		}

		static void n_AddApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddApn (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_;
		public unsafe void AddApn (global::Android.Content.ContentValues? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAPNOperSer? p1)
		{
			if (id_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ == IntPtr.Zero)
				id_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_ = JNIEnv.GetMethodID (class_ref, "addApn", "(Landroid/content/ContentValues;Lcom/vanstone/appsdk/api/interfaces/IAPNOperSer;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addApn_Landroid_content_ContentValues_Lcom_vanstone_appsdk_api_interfaces_IAPNOperSer_, __args);
		}

		static Delegate? cb_openGPRS_Z;
#pragma warning disable 0169
		static Delegate GetOpenGPRS_ZHandler ()
		{
			if (cb_openGPRS_Z == null)
				cb_openGPRS_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_OpenGPRS_Z));
			return cb_openGPRS_Z;
		}

		static void n_OpenGPRS_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OpenGPRS (p0);
		}
#pragma warning restore 0169

		IntPtr id_openGPRS_Z;
		public unsafe void OpenGPRS (bool p0)
		{
			if (id_openGPRS_Z == IntPtr.Zero)
				id_openGPRS_Z = JNIEnv.GetMethodID (class_ref, "openGPRS", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openGPRS_Z, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.ICommHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
