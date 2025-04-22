using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']"
	[Register ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult", "", "Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResultInvoker")]
	public partial interface IFaceDetecResult : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResultInvoker, VanstonePosSdk")]
		void OnError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onPreview' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onPreview", "([BII)V", "GetOnPreview_arrayBIIHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResultInvoker, VanstonePosSdk")]
		void OnPreview (byte[]? p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onShowFrame' and count(parameter)=3 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onShowFrame", "(Landroid/graphics/RectF;II)V", "GetOnShowFrame_Landroid_graphics_RectF_IIHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResultInvoker, VanstonePosSdk")]
		void OnShowFrame (global::Android.Graphics.RectF? p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSuccess", "(Landroid/os/Bundle;)V", "GetOnSuccess_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResultInvoker, VanstonePosSdk")]
		void OnSuccess (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onTip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTip", "(I)V", "GetOnTip_IHandler:Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResultInvoker, VanstonePosSdk")]
		void OnTip (int p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']/constructor[@name='IFaceDetecResult.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_onError_I;
#pragma warning disable 0169
			static Delegate GetOnError_IHandler ()
			{
				if (cb_onError_I == null)
					cb_onError_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnError_I));
				return cb_onError_I;
			}

			static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int error)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnError (error);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onError", "(I)V", "GetOnError_IHandler")]
			public virtual unsafe void OnError (int error)
			{
				const string __id = "onError.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (error);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_onPreview_arrayBII;
#pragma warning disable 0169
			static Delegate GetOnPreview_arrayBIIHandler ()
			{
				if (cb_onPreview_arrayBII == null)
					cb_onPreview_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnPreview_arrayBII));
				return cb_onPreview_arrayBII;
			}

			static void n_OnPreview_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_img, int w, int h)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var img = (byte[]?) JNIEnv.GetArray (native_img, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnPreview (img, w, h);
				if (img != null)
					JNIEnv.CopyArray (img, native_img);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']/method[@name='onPreview' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onPreview", "([BII)V", "GetOnPreview_arrayBIIHandler")]
			public virtual unsafe void OnPreview (byte[]? img, int w, int h)
			{
				const string __id = "onPreview.([BII)V";
				IntPtr native_img = JNIEnv.NewArray (img);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_img);
					__args [1] = new JniArgumentValue (w);
					__args [2] = new JniArgumentValue (h);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (img != null) {
						JNIEnv.CopyArray (native_img, img);
						JNIEnv.DeleteLocalRef (native_img);
					}
					global::System.GC.KeepAlive (img);
				}
			}

			static Delegate? cb_onShowFrame_Landroid_graphics_RectF_II;
#pragma warning disable 0169
			static Delegate GetOnShowFrame_Landroid_graphics_RectF_IIHandler ()
			{
				if (cb_onShowFrame_Landroid_graphics_RectF_II == null)
					cb_onShowFrame_Landroid_graphics_RectF_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnShowFrame_Landroid_graphics_RectF_II));
				return cb_onShowFrame_Landroid_graphics_RectF_II;
			}

			static void n_OnShowFrame_Landroid_graphics_RectF_II (IntPtr jnienv, IntPtr native__this, IntPtr native_rect, int imgW, int imgH)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var rect = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_rect, JniHandleOwnership.DoNotTransfer);
				__this.OnShowFrame (rect, imgW, imgH);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']/method[@name='onShowFrame' and count(parameter)=3 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onShowFrame", "(Landroid/graphics/RectF;II)V", "GetOnShowFrame_Landroid_graphics_RectF_IIHandler")]
			public virtual unsafe void OnShowFrame (global::Android.Graphics.RectF? rect, int imgW, int imgH)
			{
				const string __id = "onShowFrame.(Landroid/graphics/RectF;II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((rect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rect).Handle);
					__args [1] = new JniArgumentValue (imgW);
					__args [2] = new JniArgumentValue (imgH);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (rect);
				}
			}

			static Delegate? cb_onSuccess_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Landroid_os_Bundle_Handler ()
			{
				if (cb_onSuccess_Landroid_os_Bundle_ == null)
					cb_onSuccess_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnSuccess_Landroid_os_Bundle_));
				return cb_onSuccess_Landroid_os_Bundle_;
			}

			static void n_OnSuccess_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var result = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("onSuccess", "(Landroid/os/Bundle;)V", "GetOnSuccess_Landroid_os_Bundle_Handler")]
			public virtual unsafe void OnSuccess (global::Android.OS.Bundle? result)
			{
				const string __id = "onSuccess.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (result);
				}
			}

			static Delegate? cb_onTip_I;
#pragma warning disable 0169
			static Delegate GetOnTip_IHandler ()
			{
				if (cb_onTip_I == null)
					cb_onTip_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnTip_I));
				return cb_onTip_I;
			}

			static void n_OnTip_I (IntPtr jnienv, IntPtr native__this, int id)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnTip (id);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Default']/method[@name='onTip' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTip", "(I)V", "GetOnTip_IHandler")]
			public virtual unsafe void OnTip (int id)
			{
				const string __id = "onTip.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (id);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Stub']/constructor[@name='IFaceDetecResult.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/class[@name='IFaceDetecResult.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IFaceDetecResult']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/interfaces/IFaceDetecResult;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_onError_I;
#pragma warning disable 0169
			static Delegate GetOnError_IHandler ()
			{
				if (cb_onError_I == null)
					cb_onError_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnError_I));
				return cb_onError_I;
			}

			static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnError (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onError", "(I)V", "GetOnError_IHandler")]
			public abstract void OnError (int p0);

			static Delegate? cb_onPreview_arrayBII;
#pragma warning disable 0169
			static Delegate GetOnPreview_arrayBIIHandler ()
			{
				if (cb_onPreview_arrayBII == null)
					cb_onPreview_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnPreview_arrayBII));
				return cb_onPreview_arrayBII;
			}

			static void n_OnPreview_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnPreview (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onPreview' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onPreview", "([BII)V", "GetOnPreview_arrayBIIHandler")]
			public abstract void OnPreview (byte[]? p0, int p1, int p2);

			static Delegate? cb_onShowFrame_Landroid_graphics_RectF_II;
#pragma warning disable 0169
			static Delegate GetOnShowFrame_Landroid_graphics_RectF_IIHandler ()
			{
				if (cb_onShowFrame_Landroid_graphics_RectF_II == null)
					cb_onShowFrame_Landroid_graphics_RectF_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnShowFrame_Landroid_graphics_RectF_II));
				return cb_onShowFrame_Landroid_graphics_RectF_II;
			}

			static void n_OnShowFrame_Landroid_graphics_RectF_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnShowFrame (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onShowFrame' and count(parameter)=3 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onShowFrame", "(Landroid/graphics/RectF;II)V", "GetOnShowFrame_Landroid_graphics_RectF_IIHandler")]
			public abstract void OnShowFrame (global::Android.Graphics.RectF? p0, int p1, int p2);

			static Delegate? cb_onSuccess_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Landroid_os_Bundle_Handler ()
			{
				if (cb_onSuccess_Landroid_os_Bundle_ == null)
					cb_onSuccess_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnSuccess_Landroid_os_Bundle_));
				return cb_onSuccess_Landroid_os_Bundle_;
			}

			static void n_OnSuccess_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("onSuccess", "(Landroid/os/Bundle;)V", "GetOnSuccess_Landroid_os_Bundle_Handler")]
			public abstract void OnSuccess (global::Android.OS.Bundle? p0);

			static Delegate? cb_onTip_I;
#pragma warning disable 0169
			static Delegate GetOnTip_IHandler ()
			{
				if (cb_onTip_I == null)
					cb_onTip_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnTip_I));
				return cb_onTip_I;
			}

			static void n_OnTip_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnTip (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onTip' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTip", "(I)V", "GetOnTip_IHandler")]
			public abstract void OnTip (int p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onError", "(I)V", "GetOnError_IHandler")]
			public override unsafe void OnError (int p0)
			{
				const string __id = "onError.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onPreview' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onPreview", "([BII)V", "GetOnPreview_arrayBIIHandler")]
			public override unsafe void OnPreview (byte[]? p0, int p1, int p2)
			{
				const string __id = "onPreview.([BII)V";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onShowFrame' and count(parameter)=3 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onShowFrame", "(Landroid/graphics/RectF;II)V", "GetOnShowFrame_Landroid_graphics_RectF_IIHandler")]
			public override unsafe void OnShowFrame (global::Android.Graphics.RectF? p0, int p1, int p2)
			{
				const string __id = "onShowFrame.(Landroid/graphics/RectF;II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("onSuccess", "(Landroid/os/Bundle;)V", "GetOnSuccess_Landroid_os_Bundle_Handler")]
			public override unsafe void OnSuccess (global::Android.OS.Bundle? p0)
			{
				const string __id = "onSuccess.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.interfaces']/interface[@name='IFaceDetecResult']/method[@name='onTip' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTip", "(I)V", "GetOnTip_IHandler")]
			public override unsafe void OnTip (int p0)
			{
				const string __id = "onTip.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult", DoNotGenerateAcw=true)]
	internal partial class IFaceDetecResultInvoker : global::Java.Lang.Object, IFaceDetecResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/interfaces/IFaceDetecResult", typeof (IFaceDetecResultInvoker));

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

		public static IFaceDetecResult? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFaceDetecResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.interfaces.IFaceDetecResult'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFaceDetecResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnError_I));
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_I;
		public unsafe void OnError (int p0)
		{
			if (id_onError_I == IntPtr.Zero)
				id_onError_I = JNIEnv.GetMethodID (class_ref, "onError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_I, __args);
		}

		static Delegate? cb_onPreview_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnPreview_arrayBIIHandler ()
		{
			if (cb_onPreview_arrayBII == null)
				cb_onPreview_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnPreview_arrayBII));
			return cb_onPreview_arrayBII;
		}

		static void n_OnPreview_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnPreview (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onPreview_arrayBII;
		public unsafe void OnPreview (byte[]? p0, int p1, int p2)
		{
			if (id_onPreview_arrayBII == IntPtr.Zero)
				id_onPreview_arrayBII = JNIEnv.GetMethodID (class_ref, "onPreview", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreview_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_onShowFrame_Landroid_graphics_RectF_II;
#pragma warning disable 0169
		static Delegate GetOnShowFrame_Landroid_graphics_RectF_IIHandler ()
		{
			if (cb_onShowFrame_Landroid_graphics_RectF_II == null)
				cb_onShowFrame_Landroid_graphics_RectF_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnShowFrame_Landroid_graphics_RectF_II));
			return cb_onShowFrame_Landroid_graphics_RectF_II;
		}

		static void n_OnShowFrame_Landroid_graphics_RectF_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnShowFrame (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onShowFrame_Landroid_graphics_RectF_II;
		public unsafe void OnShowFrame (global::Android.Graphics.RectF? p0, int p1, int p2)
		{
			if (id_onShowFrame_Landroid_graphics_RectF_II == IntPtr.Zero)
				id_onShowFrame_Landroid_graphics_RectF_II = JNIEnv.GetMethodID (class_ref, "onShowFrame", "(Landroid/graphics/RectF;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShowFrame_Landroid_graphics_RectF_II, __args);
		}

		static Delegate? cb_onSuccess_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSuccess_Landroid_os_Bundle_ == null)
				cb_onSuccess_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnSuccess_Landroid_os_Bundle_));
			return cb_onSuccess_Landroid_os_Bundle_;
		}

		static void n_OnSuccess_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Landroid_os_Bundle_;
		public unsafe void OnSuccess (global::Android.OS.Bundle? p0)
		{
			if (id_onSuccess_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSuccess_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Landroid_os_Bundle_, __args);
		}

		static Delegate? cb_onTip_I;
#pragma warning disable 0169
		static Delegate GetOnTip_IHandler ()
		{
			if (cb_onTip_I == null)
				cb_onTip_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnTip_I));
			return cb_onTip_I;
		}

		static void n_OnTip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnTip (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTip_I;
		public unsafe void OnTip (int p0)
		{
			if (id_onTip_I == IntPtr.Zero)
				id_onTip_I = JNIEnv.GetMethodID (class_ref, "onTip", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTip_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IFaceDetecResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
