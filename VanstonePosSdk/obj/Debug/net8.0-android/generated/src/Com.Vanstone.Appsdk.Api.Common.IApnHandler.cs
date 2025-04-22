using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']"
	[Register ("com/vanstone/appsdk/api/common/ApnHandler", "", "Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker")]
	public partial interface IApnHandler : global::Android.OS.IInterface {
		global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>? AllApnList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='getAllApnList' and count(parameter)=0]"
			[Register ("getAllApnList", "()Ljava/util/List;", "GetGetAllApnListHandler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? PreferApn_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='getPreferApn_Api' and count(parameter)=0]"
			[Register ("getPreferApn_Api", "()Lcom/vanstone/appsdk/api/struct/ApnInfo;", "GetGetPreferApn_ApiHandler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='AddApn_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
		[Register ("AddApn_Api", "(Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetAddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		int AddApn_Api (global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='ApnOpen' and count(parameter)=0]"
		[Register ("ApnOpen", "()I", "GetApnOpenHandler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		int ApnOpen ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='DeleteApn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("DeleteApn", "(Ljava/lang/String;Ljava/lang/String;)I", "GetDeleteApn_Ljava_lang_String_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		int DeleteApn (string? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='DeleteApn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("DeleteApn_Api", "(I)Z", "GetDeleteApn_Api_IHandler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		bool DeleteApn_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='SelectedApn_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SelectedApn_Api", "(Ljava/lang/String;)I", "GetSelectedApn_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		int SelectedApn_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='getGprsAPNId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getGprsAPNId", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetGetGprsAPNId_Ljava_lang_String_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		bool GetGprsAPNId (string? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='setDefaultApn' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultApn", "(I)I", "GetSetDefaultApn_IHandler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		int SetDefaultApn (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='updateGprsAPN' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
		[Register ("updateGprsAPN", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetUpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler:Com.Vanstone.Appsdk.Api.Common.IApnHandlerInvoker, VanstonePosSdk")]
		int UpdateGprsAPN (string? p0, global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/ApnHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Common.IApnHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/ApnHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/constructor[@name='ApnHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_getAllApnList;
#pragma warning disable 0169
			static Delegate GetGetAllApnListHandler ()
			{
				if (cb_getAllApnList == null)
					cb_getAllApnList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAllApnList));
				return cb_getAllApnList;
			}

			static IntPtr n_GetAllApnList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>.ToLocalJniHandle (__this.AllApnList);
			}
#pragma warning restore 0169

			public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>? AllApnList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='getAllApnList' and count(parameter)=0]"
				[Register ("getAllApnList", "()Ljava/util/List;", "GetGetAllApnListHandler")]
				get {
					const string __id = "getAllApnList.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getPreferApn_Api;
#pragma warning disable 0169
			static Delegate GetGetPreferApn_ApiHandler ()
			{
				if (cb_getPreferApn_Api == null)
					cb_getPreferApn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPreferApn_Api));
				return cb_getPreferApn_Api;
			}

			static IntPtr n_GetPreferApn_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PreferApn_Api);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? PreferApn_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='getPreferApn_Api' and count(parameter)=0]"
				[Register ("getPreferApn_Api", "()Lcom/vanstone/appsdk/api/struct/ApnInfo;", "GetGetPreferApn_ApiHandler")]
				get {
					const string __id = "getPreferApn_Api.()Lcom/vanstone/appsdk/api/struct/ApnInfo;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
#pragma warning disable 0169
			static Delegate GetAddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler ()
			{
				if (cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == null)
					cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_));
				return cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
			}

			static int n_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apnInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var apnInfo = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (native_apnInfo, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.AddApn_Api (apnInfo);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='AddApn_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
			[Register ("AddApn_Api", "(Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetAddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler")]
			public virtual unsafe int AddApn_Api (global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? apnInfo)
			{
				const string __id = "AddApn_Api.(Lcom/vanstone/appsdk/api/struct/ApnInfo;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((apnInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apnInfo).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (apnInfo);
				}
			}

			static Delegate? cb_ApnOpen;
#pragma warning disable 0169
			static Delegate GetApnOpenHandler ()
			{
				if (cb_ApnOpen == null)
					cb_ApnOpen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ApnOpen));
				return cb_ApnOpen;
			}

			static int n_ApnOpen (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ApnOpen ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='ApnOpen' and count(parameter)=0]"
			[Register ("ApnOpen", "()I", "GetApnOpenHandler")]
			public virtual unsafe int ApnOpen ()
			{
				const string __id = "ApnOpen.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteApn_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_DeleteApn_Ljava_lang_String_Ljava_lang_String_));
				return cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_;
			}

			static int n_DeleteApn_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apnname, IntPtr native_numeric)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var apnname = JNIEnv.GetString (native_apnname, JniHandleOwnership.DoNotTransfer);
				var numeric = JNIEnv.GetString (native_numeric, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DeleteApn (apnname, numeric);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='DeleteApn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("DeleteApn", "(Ljava/lang/String;Ljava/lang/String;)I", "GetDeleteApn_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe int DeleteApn (string? apnname, string? numeric)
			{
				const string __id = "DeleteApn.(Ljava/lang/String;Ljava/lang/String;)I";
				IntPtr native_apnname = JNIEnv.NewString ((string?)apnname);
				IntPtr native_numeric = JNIEnv.NewString ((string?)numeric);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_apnname);
					__args [1] = new JniArgumentValue (native_numeric);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_apnname);
					JNIEnv.DeleteLocalRef (native_numeric);
				}
			}

			static Delegate? cb_DeleteApn_Api_I;
#pragma warning disable 0169
			static Delegate GetDeleteApn_Api_IHandler ()
			{
				if (cb_DeleteApn_Api_I == null)
					cb_DeleteApn_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_DeleteApn_Api_I));
				return cb_DeleteApn_Api_I;
			}

			static bool n_DeleteApn_Api_I (IntPtr jnienv, IntPtr native__this, int apnId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DeleteApn_Api (apnId);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='DeleteApn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DeleteApn_Api", "(I)Z", "GetDeleteApn_Api_IHandler")]
			public virtual unsafe bool DeleteApn_Api (int apnId)
			{
				const string __id = "DeleteApn_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (apnId);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SelectedApn_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSelectedApn_Api_Ljava_lang_String_Handler ()
			{
				if (cb_SelectedApn_Api_Ljava_lang_String_ == null)
					cb_SelectedApn_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SelectedApn_Api_Ljava_lang_String_));
				return cb_SelectedApn_Api_Ljava_lang_String_;
			}

			static int n_SelectedApn_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ApnName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ApnName = JNIEnv.GetString (native_ApnName, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SelectedApn_Api (ApnName);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='SelectedApn_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SelectedApn_Api", "(Ljava/lang/String;)I", "GetSelectedApn_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int SelectedApn_Api (string? ApnName)
			{
				const string __id = "SelectedApn_Api.(Ljava/lang/String;)I";
				IntPtr native_ApnName = JNIEnv.NewString ((string?)ApnName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ApnName);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_ApnName);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetGprsAPNId_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_GetGprsAPNId_Ljava_lang_String_Ljava_lang_String_));
				return cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_;
			}

			static bool n_GetGprsAPNId_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ApnName, IntPtr native_iNumericSTR)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ApnName = JNIEnv.GetString (native_ApnName, JniHandleOwnership.DoNotTransfer);
				var iNumericSTR = JNIEnv.GetString (native_iNumericSTR, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GetGprsAPNId (ApnName, iNumericSTR);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='getGprsAPNId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getGprsAPNId", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetGetGprsAPNId_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe bool GetGprsAPNId (string? ApnName, string? iNumericSTR)
			{
				const string __id = "getGprsAPNId.(Ljava/lang/String;Ljava/lang/String;)Z";
				IntPtr native_ApnName = JNIEnv.NewString ((string?)ApnName);
				IntPtr native_iNumericSTR = JNIEnv.NewString ((string?)iNumericSTR);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_ApnName);
					__args [1] = new JniArgumentValue (native_iNumericSTR);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_ApnName);
					JNIEnv.DeleteLocalRef (native_iNumericSTR);
				}
			}

			static Delegate? cb_setDefaultApn_I;
#pragma warning disable 0169
			static Delegate GetSetDefaultApn_IHandler ()
			{
				if (cb_setDefaultApn_I == null)
					cb_setDefaultApn_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_SetDefaultApn_I));
				return cb_setDefaultApn_I;
			}

			static int n_SetDefaultApn_I (IntPtr jnienv, IntPtr native__this, int id)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetDefaultApn (id);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='setDefaultApn' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDefaultApn", "(I)I", "GetSetDefaultApn_IHandler")]
			public virtual unsafe int SetDefaultApn (int id)
			{
				const string __id = "setDefaultApn.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (id);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
#pragma warning disable 0169
			static Delegate GetUpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler ()
			{
				if (cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == null)
					cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_UpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_));
				return cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
			}

			static int n_UpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ApnId, IntPtr native_apnInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ApnId = JNIEnv.GetString (native_ApnId, JniHandleOwnership.DoNotTransfer);
				var apnInfo = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (native_apnInfo, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.UpdateGprsAPN (ApnId, apnInfo);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Default']/method[@name='updateGprsAPN' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
			[Register ("updateGprsAPN", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetUpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler")]
			public virtual unsafe int UpdateGprsAPN (string? ApnId, global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? apnInfo)
			{
				const string __id = "updateGprsAPN.(Ljava/lang/String;Lcom/vanstone/appsdk/api/struct/ApnInfo;)I";
				IntPtr native_ApnId = JNIEnv.NewString ((string?)ApnId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_ApnId);
					__args [1] = new JniArgumentValue ((apnInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apnInfo).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_ApnId);
					global::System.GC.KeepAlive (apnInfo);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/ApnHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Common.IApnHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/ApnHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/constructor[@name='ApnHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/common/ApnHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/common/ApnHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/common/ApnHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/common/ApnHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.common.ApnHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/common/ApnHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Common.IApnHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/common/ApnHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
#pragma warning disable 0169
			static Delegate GetAddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler ()
			{
				if (cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == null)
					cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_));
				return cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
			}

			static int n_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.AddApn_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='AddApn_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
			[Register ("AddApn_Api", "(Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetAddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler")]
			public abstract int AddApn_Api (global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p0);

			static Delegate? cb_ApnOpen;
#pragma warning disable 0169
			static Delegate GetApnOpenHandler ()
			{
				if (cb_ApnOpen == null)
					cb_ApnOpen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ApnOpen));
				return cb_ApnOpen;
			}

			static int n_ApnOpen (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ApnOpen ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='ApnOpen' and count(parameter)=0]"
			[Register ("ApnOpen", "()I", "GetApnOpenHandler")]
			public abstract int ApnOpen ();

			static Delegate? cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteApn_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_DeleteApn_Ljava_lang_String_Ljava_lang_String_));
				return cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_;
			}

			static int n_DeleteApn_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DeleteApn (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='DeleteApn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("DeleteApn", "(Ljava/lang/String;Ljava/lang/String;)I", "GetDeleteApn_Ljava_lang_String_Ljava_lang_String_Handler")]
			public abstract int DeleteApn (string? p0, string? p1);

			static Delegate? cb_DeleteApn_Api_I;
#pragma warning disable 0169
			static Delegate GetDeleteApn_Api_IHandler ()
			{
				if (cb_DeleteApn_Api_I == null)
					cb_DeleteApn_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_DeleteApn_Api_I));
				return cb_DeleteApn_Api_I;
			}

			static bool n_DeleteApn_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DeleteApn_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='DeleteApn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DeleteApn_Api", "(I)Z", "GetDeleteApn_Api_IHandler")]
			public abstract bool DeleteApn_Api (int p0);

			static Delegate? cb_SelectedApn_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSelectedApn_Api_Ljava_lang_String_Handler ()
			{
				if (cb_SelectedApn_Api_Ljava_lang_String_ == null)
					cb_SelectedApn_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SelectedApn_Api_Ljava_lang_String_));
				return cb_SelectedApn_Api_Ljava_lang_String_;
			}

			static int n_SelectedApn_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SelectedApn_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='SelectedApn_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SelectedApn_Api", "(Ljava/lang/String;)I", "GetSelectedApn_Api_Ljava_lang_String_Handler")]
			public abstract int SelectedApn_Api (string? p0);

			static Delegate? cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetGprsAPNId_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_GetGprsAPNId_Ljava_lang_String_Ljava_lang_String_));
				return cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_;
			}

			static bool n_GetGprsAPNId_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GetGprsAPNId (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='getGprsAPNId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getGprsAPNId", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetGetGprsAPNId_Ljava_lang_String_Ljava_lang_String_Handler")]
			public abstract bool GetGprsAPNId (string? p0, string? p1);

			static Delegate? cb_setDefaultApn_I;
#pragma warning disable 0169
			static Delegate GetSetDefaultApn_IHandler ()
			{
				if (cb_setDefaultApn_I == null)
					cb_setDefaultApn_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_SetDefaultApn_I));
				return cb_setDefaultApn_I;
			}

			static int n_SetDefaultApn_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetDefaultApn (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='setDefaultApn' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDefaultApn", "(I)I", "GetSetDefaultApn_IHandler")]
			public abstract int SetDefaultApn (int p0);

			static Delegate? cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
#pragma warning disable 0169
			static Delegate GetUpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler ()
			{
				if (cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == null)
					cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_UpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_));
				return cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
			}

			static int n_UpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.UpdateGprsAPN (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='updateGprsAPN' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
			[Register ("updateGprsAPN", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetUpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler")]
			public abstract int UpdateGprsAPN (string? p0, global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p1);

			static Delegate? cb_getAllApnList;
#pragma warning disable 0169
			static Delegate GetGetAllApnListHandler ()
			{
				if (cb_getAllApnList == null)
					cb_getAllApnList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAllApnList));
				return cb_getAllApnList;
			}

			static IntPtr n_GetAllApnList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>.ToLocalJniHandle (__this.AllApnList);
			}
#pragma warning restore 0169

			public abstract global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>? AllApnList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='getAllApnList' and count(parameter)=0]"
				[Register ("getAllApnList", "()Ljava/util/List;", "GetGetAllApnListHandler")]
				get; 
			}

			static Delegate? cb_getPreferApn_Api;
#pragma warning disable 0169
			static Delegate GetGetPreferApn_ApiHandler ()
			{
				if (cb_getPreferApn_Api == null)
					cb_getPreferApn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPreferApn_Api));
				return cb_getPreferApn_Api;
			}

			static IntPtr n_GetPreferApn_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PreferApn_Api);
			}
#pragma warning restore 0169

			public abstract global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? PreferApn_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='getPreferApn_Api' and count(parameter)=0]"
				[Register ("getPreferApn_Api", "()Lcom/vanstone/appsdk/api/struct/ApnInfo;", "GetGetPreferApn_ApiHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/ApnHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/ApnHandler$Stub", typeof (StubInvoker));

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

			public override unsafe global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>? AllApnList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='getAllApnList' and count(parameter)=0]"
				[Register ("getAllApnList", "()Ljava/util/List;", "GetGetAllApnListHandler")]
				get {
					const string __id = "getAllApnList.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? PreferApn_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/class[@name='ApnHandler.Stub']/method[@name='getPreferApn_Api' and count(parameter)=0]"
				[Register ("getPreferApn_Api", "()Lcom/vanstone/appsdk/api/struct/ApnInfo;", "GetGetPreferApn_ApiHandler")]
				get {
					const string __id = "getPreferApn_Api.()Lcom/vanstone/appsdk/api/struct/ApnInfo;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='AddApn_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
			[Register ("AddApn_Api", "(Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetAddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler")]
			public override unsafe int AddApn_Api (global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p0)
			{
				const string __id = "AddApn_Api.(Lcom/vanstone/appsdk/api/struct/ApnInfo;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='ApnOpen' and count(parameter)=0]"
			[Register ("ApnOpen", "()I", "GetApnOpenHandler")]
			public override unsafe int ApnOpen ()
			{
				const string __id = "ApnOpen.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='DeleteApn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("DeleteApn", "(Ljava/lang/String;Ljava/lang/String;)I", "GetDeleteApn_Ljava_lang_String_Ljava_lang_String_Handler")]
			public override unsafe int DeleteApn (string? p0, string? p1)
			{
				const string __id = "DeleteApn.(Ljava/lang/String;Ljava/lang/String;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='DeleteApn_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DeleteApn_Api", "(I)Z", "GetDeleteApn_Api_IHandler")]
			public override unsafe bool DeleteApn_Api (int p0)
			{
				const string __id = "DeleteApn_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='SelectedApn_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SelectedApn_Api", "(Ljava/lang/String;)I", "GetSelectedApn_Api_Ljava_lang_String_Handler")]
			public override unsafe int SelectedApn_Api (string? p0)
			{
				const string __id = "SelectedApn_Api.(Ljava/lang/String;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='getGprsAPNId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getGprsAPNId", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetGetGprsAPNId_Ljava_lang_String_Ljava_lang_String_Handler")]
			public override unsafe bool GetGprsAPNId (string? p0, string? p1)
			{
				const string __id = "getGprsAPNId.(Ljava/lang/String;Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='setDefaultApn' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDefaultApn", "(I)I", "GetSetDefaultApn_IHandler")]
			public override unsafe int SetDefaultApn (int p0)
			{
				const string __id = "setDefaultApn.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.common']/interface[@name='ApnHandler']/method[@name='updateGprsAPN' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.struct.ApnInfo']]"
			[Register ("updateGprsAPN", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/struct/ApnInfo;)I", "GetUpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler")]
			public override unsafe int UpdateGprsAPN (string? p0, global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p1)
			{
				const string __id = "updateGprsAPN.(Ljava/lang/String;Lcom/vanstone/appsdk/api/struct/ApnInfo;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/common/ApnHandler", DoNotGenerateAcw=true)]
	internal partial class IApnHandlerInvoker : global::Java.Lang.Object, IApnHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/common/ApnHandler", typeof (IApnHandlerInvoker));

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

		public static IApnHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApnHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.common.ApnHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApnHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getAllApnList;
#pragma warning disable 0169
		static Delegate GetGetAllApnListHandler ()
		{
			if (cb_getAllApnList == null)
				cb_getAllApnList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAllApnList));
			return cb_getAllApnList;
		}

		static IntPtr n_GetAllApnList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>.ToLocalJniHandle (__this.AllApnList);
		}
#pragma warning restore 0169

		IntPtr id_getAllApnList;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>? AllApnList {
			get {
				if (id_getAllApnList == IntPtr.Zero)
					id_getAllApnList = JNIEnv.GetMethodID (class_ref, "getAllApnList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllApnList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getPreferApn_Api;
#pragma warning disable 0169
		static Delegate GetGetPreferApn_ApiHandler ()
		{
			if (cb_getPreferApn_Api == null)
				cb_getPreferApn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPreferApn_Api));
			return cb_getPreferApn_Api;
		}

		static IntPtr n_GetPreferApn_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PreferApn_Api);
		}
#pragma warning restore 0169

		IntPtr id_getPreferApn_Api;
		public unsafe global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? PreferApn_Api {
			get {
				if (id_getPreferApn_Api == IntPtr.Zero)
					id_getPreferApn_Api = JNIEnv.GetMethodID (class_ref, "getPreferApn_Api", "()Lcom/vanstone/appsdk/api/struct/ApnInfo;");
				return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreferApn_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
#pragma warning disable 0169
		static Delegate GetAddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler ()
		{
			if (cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == null)
				cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_));
			return cb_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
		}

		static int n_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddApn_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
		public unsafe int AddApn_Api (global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p0)
		{
			if (id_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == IntPtr.Zero)
				id_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNIEnv.GetMethodID (class_ref, "AddApn_Api", "(Lcom/vanstone/appsdk/api/struct/ApnInfo;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_AddApn_Api_Lcom_vanstone_appsdk_api_struct_ApnInfo_, __args);
			return __ret;
		}

		static Delegate? cb_ApnOpen;
#pragma warning disable 0169
		static Delegate GetApnOpenHandler ()
		{
			if (cb_ApnOpen == null)
				cb_ApnOpen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ApnOpen));
			return cb_ApnOpen;
		}

		static int n_ApnOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ApnOpen ();
		}
#pragma warning restore 0169

		IntPtr id_ApnOpen;
		public unsafe int ApnOpen ()
		{
			if (id_ApnOpen == IntPtr.Zero)
				id_ApnOpen = JNIEnv.GetMethodID (class_ref, "ApnOpen", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ApnOpen);
		}

		static Delegate? cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteApn_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_DeleteApn_Ljava_lang_String_Ljava_lang_String_));
			return cb_DeleteApn_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_DeleteApn_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteApn (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DeleteApn_Ljava_lang_String_Ljava_lang_String_;
		public unsafe int DeleteApn (string? p0, string? p1)
		{
			if (id_DeleteApn_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_DeleteApn_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "DeleteApn", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DeleteApn_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_DeleteApn_Api_I;
#pragma warning disable 0169
		static Delegate GetDeleteApn_Api_IHandler ()
		{
			if (cb_DeleteApn_Api_I == null)
				cb_DeleteApn_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_DeleteApn_Api_I));
			return cb_DeleteApn_Api_I;
		}

		static bool n_DeleteApn_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DeleteApn_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_DeleteApn_Api_I;
		public unsafe bool DeleteApn_Api (int p0)
		{
			if (id_DeleteApn_Api_I == IntPtr.Zero)
				id_DeleteApn_Api_I = JNIEnv.GetMethodID (class_ref, "DeleteApn_Api", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_DeleteApn_Api_I, __args);
		}

		static Delegate? cb_SelectedApn_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSelectedApn_Api_Ljava_lang_String_Handler ()
		{
			if (cb_SelectedApn_Api_Ljava_lang_String_ == null)
				cb_SelectedApn_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SelectedApn_Api_Ljava_lang_String_));
			return cb_SelectedApn_Api_Ljava_lang_String_;
		}

		static int n_SelectedApn_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SelectedApn_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SelectedApn_Api_Ljava_lang_String_;
		public unsafe int SelectedApn_Api (string? p0)
		{
			if (id_SelectedApn_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_SelectedApn_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SelectedApn_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SelectedApn_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetGprsAPNId_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_GetGprsAPNId_Ljava_lang_String_Ljava_lang_String_));
			return cb_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_GetGprsAPNId_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetGprsAPNId (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool GetGprsAPNId (string? p0, string? p1)
		{
			if (id_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getGprsAPNId", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getGprsAPNId_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_setDefaultApn_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultApn_IHandler ()
		{
			if (cb_setDefaultApn_I == null)
				cb_setDefaultApn_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_SetDefaultApn_I));
			return cb_setDefaultApn_I;
		}

		static int n_SetDefaultApn_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetDefaultApn (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDefaultApn_I;
		public unsafe int SetDefaultApn (int p0)
		{
			if (id_setDefaultApn_I == IntPtr.Zero)
				id_setDefaultApn_I = JNIEnv.GetMethodID (class_ref, "setDefaultApn", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultApn_I, __args);
		}

		static Delegate? cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
#pragma warning disable 0169
		static Delegate GetUpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_Handler ()
		{
			if (cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == null)
				cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_UpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_));
			return cb_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
		}

		static int n_UpdateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateGprsAPN (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_;
		public unsafe int UpdateGprsAPN (string? p0, global::Com.Vanstone.Appsdk.Api.Struct.ApnInfo? p1)
		{
			if (id_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ == IntPtr.Zero)
				id_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_ = JNIEnv.GetMethodID (class_ref, "updateGprsAPN", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/struct/ApnInfo;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateGprsAPN_Ljava_lang_String_Lcom_vanstone_appsdk_api_struct_ApnInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Common.IApnHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
