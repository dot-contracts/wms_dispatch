using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Idcard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']"
	[Register ("com/vanstone/appsdk/api/idcard/IDCardHandler", "", "Com.Vanstone.Appsdk.Api.Idcard.IDCardHandlerInvoker")]
	public partial interface IDCardHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='CloseIdCard_Api' and count(parameter)=0]"
		[Register ("CloseIdCard_Api", "()I", "GetCloseIdCard_ApiHandler:Com.Vanstone.Appsdk.Api.Idcard.IDCardHandlerInvoker, VanstonePosSdk")]
		int CloseIdCard_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='CompareBitMap_Api' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
		[Register ("CompareBitMap_Api", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetCompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler:Com.Vanstone.Appsdk.Api.Idcard.IDCardHandlerInvoker, VanstonePosSdk")]
		int CompareBitMap_Api (global::Android.Graphics.Bitmap? p0, global::Android.Graphics.Bitmap? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='GetInfoIdCard_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
		[Register ("GetInfoIdCard_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetGetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler:Com.Vanstone.Appsdk.Api.Idcard.IDCardHandlerInvoker, VanstonePosSdk")]
		int GetInfoIdCard_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='OpenIdCard_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
		[Register ("OpenIdCard_Api", "(Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetOpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler:Com.Vanstone.Appsdk.Api.Idcard.IDCardHandlerInvoker, VanstonePosSdk")]
		int OpenIdCard_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/idcard/IDCardHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/idcard/IDCardHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Default']/constructor[@name='IDCardHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_CloseIdCard_Api;
#pragma warning disable 0169
			static Delegate GetCloseIdCard_ApiHandler ()
			{
				if (cb_CloseIdCard_Api == null)
					cb_CloseIdCard_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseIdCard_Api));
				return cb_CloseIdCard_Api;
			}

			static int n_CloseIdCard_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseIdCard_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Default']/method[@name='CloseIdCard_Api' and count(parameter)=0]"
			[Register ("CloseIdCard_Api", "()I", "GetCloseIdCard_ApiHandler")]
			public virtual unsafe int CloseIdCard_Api ()
			{
				const string __id = "CloseIdCard_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
			static Delegate GetCompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
			{
				if (cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
					cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
				return cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
			}

			static int n_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_Bmp1, IntPtr native_Bmp2, IntPtr native_Result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Bmp1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_Bmp1, JniHandleOwnership.DoNotTransfer);
				var Bmp2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_Bmp2, JniHandleOwnership.DoNotTransfer);
				var Result = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_Result, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareBitMap_Api (Bmp1, Bmp2, Result);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Default']/method[@name='CompareBitMap_Api' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("CompareBitMap_Api", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetCompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public virtual unsafe int CompareBitMap_Api (global::Android.Graphics.Bitmap? Bmp1, global::Android.Graphics.Bitmap? Bmp2, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? Result)
			{
				const string __id = "CompareBitMap_Api.(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((Bmp1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Bmp1).Handle);
					__args [1] = new JniArgumentValue ((Bmp2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Bmp2).Handle);
					__args [2] = new JniArgumentValue ((Result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Result).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (Bmp1);
					global::System.GC.KeepAlive (Bmp2);
					global::System.GC.KeepAlive (Result);
				}
			}

			static Delegate? cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
			static Delegate GetGetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
			{
				if (cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
					cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
				return cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
			}

			static int n_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params, IntPtr native_Result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @params = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native__params, JniHandleOwnership.DoNotTransfer);
				var Result = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_Result, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetInfoIdCard_Api (@params, Result);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Default']/method[@name='GetInfoIdCard_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("GetInfoIdCard_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetGetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public virtual unsafe int GetInfoIdCard_Api (global::Android.OS.Bundle? @params, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? Result)
			{
				const string __id = "GetInfoIdCard_Api.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
					__args [1] = new JniArgumentValue ((Result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Result).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (@params);
					global::System.GC.KeepAlive (Result);
				}
			}

			static Delegate? cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
			static Delegate GetOpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
			{
				if (cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
					cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
				return cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
			}

			static int n_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_Result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Result = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_Result, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.OpenIdCard_Api (Result);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Default']/method[@name='OpenIdCard_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("OpenIdCard_Api", "(Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetOpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public virtual unsafe int OpenIdCard_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? Result)
			{
				const string __id = "OpenIdCard_Api.(Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((Result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Result).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (Result);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/idcard/IDCardHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/idcard/IDCardHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Stub']/constructor[@name='IDCardHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/idcard/IDCardHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/idcard/IDCardHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/idcard/IDCardHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/class[@name='IDCardHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.idcard.IDCardHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/idcard/IDCardHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/idcard/IDCardHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_CloseIdCard_Api;
#pragma warning disable 0169
			static Delegate GetCloseIdCard_ApiHandler ()
			{
				if (cb_CloseIdCard_Api == null)
					cb_CloseIdCard_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseIdCard_Api));
				return cb_CloseIdCard_Api;
			}

			static int n_CloseIdCard_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseIdCard_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='CloseIdCard_Api' and count(parameter)=0]"
			[Register ("CloseIdCard_Api", "()I", "GetCloseIdCard_ApiHandler")]
			public abstract int CloseIdCard_Api ();

			static Delegate? cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
			static Delegate GetCompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
			{
				if (cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
					cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
				return cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
			}

			static int n_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_p2, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareBitMap_Api (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='CompareBitMap_Api' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("CompareBitMap_Api", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetCompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public abstract int CompareBitMap_Api (global::Android.Graphics.Bitmap? p0, global::Android.Graphics.Bitmap? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p2);

			static Delegate? cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
			static Delegate GetGetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
			{
				if (cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
					cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
				return cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
			}

			static int n_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetInfoIdCard_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='GetInfoIdCard_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("GetInfoIdCard_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetGetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public abstract int GetInfoIdCard_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p1);

			static Delegate? cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
			static Delegate GetOpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
			{
				if (cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
					cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
				return cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
			}

			static int n_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.OpenIdCard_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='OpenIdCard_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("OpenIdCard_Api", "(Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetOpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public abstract int OpenIdCard_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/idcard/IDCardHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/idcard/IDCardHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='CloseIdCard_Api' and count(parameter)=0]"
			[Register ("CloseIdCard_Api", "()I", "GetCloseIdCard_ApiHandler")]
			public override unsafe int CloseIdCard_Api ()
			{
				const string __id = "CloseIdCard_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='CompareBitMap_Api' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("CompareBitMap_Api", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetCompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public override unsafe int CompareBitMap_Api (global::Android.Graphics.Bitmap? p0, global::Android.Graphics.Bitmap? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p2)
			{
				const string __id = "CompareBitMap_Api.(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='GetInfoIdCard_Api' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("GetInfoIdCard_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetGetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public override unsafe int GetInfoIdCard_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p1)
			{
				const string __id = "GetInfoIdCard_Api.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.idcard']/interface[@name='IDCardHandler']/method[@name='OpenIdCard_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IIDCardResult']]"
			[Register ("OpenIdCard_Api", "(Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I", "GetOpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler")]
			public override unsafe int OpenIdCard_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p0)
			{
				const string __id = "OpenIdCard_Api.(Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/idcard/IDCardHandler", DoNotGenerateAcw=true)]
	internal partial class IDCardHandlerInvoker : global::Java.Lang.Object, IDCardHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/idcard/IDCardHandler", typeof (IDCardHandlerInvoker));

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

		public static IDCardHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDCardHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.idcard.IDCardHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDCardHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_CloseIdCard_Api;
#pragma warning disable 0169
		static Delegate GetCloseIdCard_ApiHandler ()
		{
			if (cb_CloseIdCard_Api == null)
				cb_CloseIdCard_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseIdCard_Api));
			return cb_CloseIdCard_Api;
		}

		static int n_CloseIdCard_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CloseIdCard_Api ();
		}
#pragma warning restore 0169

		IntPtr id_CloseIdCard_Api;
		public unsafe int CloseIdCard_Api ()
		{
			if (id_CloseIdCard_Api == IntPtr.Zero)
				id_CloseIdCard_Api = JNIEnv.GetMethodID (class_ref, "CloseIdCard_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_CloseIdCard_Api);
		}

		static Delegate? cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
		static Delegate GetCompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
		{
			if (cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
				cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
			return cb_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
		}

		static int n_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareBitMap_Api (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
		public unsafe int CompareBitMap_Api (global::Android.Graphics.Bitmap? p0, global::Android.Graphics.Bitmap? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p2)
		{
			if (id_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == IntPtr.Zero)
				id_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNIEnv.GetMethodID (class_ref, "CompareBitMap_Api", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_CompareBitMap_Api_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_, __args);
			return __ret;
		}

		static Delegate? cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
		static Delegate GetGetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
		{
			if (cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
				cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
			return cb_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
		}

		static int n_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInfoIdCard_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
		public unsafe int GetInfoIdCard_Api (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p1)
		{
			if (id_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == IntPtr.Zero)
				id_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNIEnv.GetMethodID (class_ref, "GetInfoIdCard_Api", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetInfoIdCard_Api_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_, __args);
			return __ret;
		}

		static Delegate? cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
#pragma warning disable 0169
		static Delegate GetOpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_Handler ()
		{
			if (cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == null)
				cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_));
			return cb_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
		}

		static int n_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OpenIdCard_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_;
		public unsafe int OpenIdCard_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IIDCardResult? p0)
		{
			if (id_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ == IntPtr.Zero)
				id_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_ = JNIEnv.GetMethodID (class_ref, "OpenIdCard_Api", "(Lcom/vanstone/appsdk/api/interfaces/IIDCardResult;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_OpenIdCard_Api_Lcom_vanstone_appsdk_api_interfaces_IIDCardResult_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Idcard.IDCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
