using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Sign {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']"
	[Register ("com/vanstone/appsdk/api/sign/SignHandler", "", "Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker")]
	public partial interface ISignHandler : global::Android.OS.IInterface {
		global::Android.Graphics.Bitmap? SignBmp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='getSignBmp' and count(parameter)=0]"
			[Register ("getSignBmp", "()Landroid/graphics/Bitmap;", "GetGetSignBmpHandler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		int SignatureLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='getSignatureLength' and count(parameter)=0]"
			[Register ("getSignatureLength", "()I", "GetGetSignatureLengthHandler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='getSignatureCompressData' and count(parameter)=0]"
		[Register ("getSignatureCompressData", "()[B", "GetGetSignatureCompressDataHandler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
		byte[]? GetSignatureCompressData ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='isToastConfirm' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isToastConfirm", "(Z)V", "GetIsToastConfirm_ZHandler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
		void IsToastConfirm (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='setResignCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setResignCount", "(I)V", "GetSetResignCount_IHandler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
		void SetResignCount (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='setSignBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSignBoardStyle", "(I)V", "GetSetSignBoardStyle_IHandler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
		void SetSignBoardStyle (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='startSign' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.sign.IStartSignListenner']]"
		[Register ("startSign", "(ILjava/lang/String;Lcom/vanstone/sign/IStartSignListenner;)V", "GetStartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_Handler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
		void StartSign (int p0, string? p1, global::Com.Vanstone.Sign.IStartSignListenner? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='stopSign' and count(parameter)=0]"
		[Register ("stopSign", "()V", "GetStopSignHandler:Com.Vanstone.Appsdk.Api.Sign.ISignHandlerInvoker, VanstonePosSdk")]
		void StopSign ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sign/SignHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sign/SignHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/constructor[@name='SignHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_getSignBmp;
#pragma warning disable 0169
			static Delegate GetGetSignBmpHandler ()
			{
				if (cb_getSignBmp == null)
					cb_getSignBmp = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignBmp));
				return cb_getSignBmp;
			}

			static IntPtr n_GetSignBmp (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SignBmp);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Bitmap? SignBmp {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='getSignBmp' and count(parameter)=0]"
				[Register ("getSignBmp", "()Landroid/graphics/Bitmap;", "GetGetSignBmpHandler")]
				get {
					const string __id = "getSignBmp.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSignatureLength;
#pragma warning disable 0169
			static Delegate GetGetSignatureLengthHandler ()
			{
				if (cb_getSignatureLength == null)
					cb_getSignatureLength = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetSignatureLength));
				return cb_getSignatureLength;
			}

			static int n_GetSignatureLength (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SignatureLength;
			}
#pragma warning restore 0169

			public virtual unsafe int SignatureLength {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='getSignatureLength' and count(parameter)=0]"
				[Register ("getSignatureLength", "()I", "GetGetSignatureLengthHandler")]
				get {
					const string __id = "getSignatureLength.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_getSignatureCompressData;
#pragma warning disable 0169
			static Delegate GetGetSignatureCompressDataHandler ()
			{
				if (cb_getSignatureCompressData == null)
					cb_getSignatureCompressData = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignatureCompressData));
				return cb_getSignatureCompressData;
			}

			static IntPtr n_GetSignatureCompressData (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetSignatureCompressData ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='getSignatureCompressData' and count(parameter)=0]"
			[Register ("getSignatureCompressData", "()[B", "GetGetSignatureCompressDataHandler")]
			public virtual unsafe byte[]? GetSignatureCompressData ()
			{
				const string __id = "getSignatureCompressData.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate? cb_isToastConfirm_Z;
#pragma warning disable 0169
			static Delegate GetIsToastConfirm_ZHandler ()
			{
				if (cb_isToastConfirm_Z == null)
					cb_isToastConfirm_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_IsToastConfirm_Z));
				return cb_isToastConfirm_Z;
			}

			static void n_IsToastConfirm_Z (IntPtr jnienv, IntPtr native__this, bool isToast)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.IsToastConfirm (isToast);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='isToastConfirm' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("isToastConfirm", "(Z)V", "GetIsToastConfirm_ZHandler")]
			public virtual unsafe void IsToastConfirm (bool isToast)
			{
				const string __id = "isToastConfirm.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isToast);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setResignCount_I;
#pragma warning disable 0169
			static Delegate GetSetResignCount_IHandler ()
			{
				if (cb_setResignCount_I == null)
					cb_setResignCount_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetResignCount_I));
				return cb_setResignCount_I;
			}

			static void n_SetResignCount_I (IntPtr jnienv, IntPtr native__this, int count)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetResignCount (count);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='setResignCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResignCount", "(I)V", "GetSetResignCount_IHandler")]
			public virtual unsafe void SetResignCount (int count)
			{
				const string __id = "setResignCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setSignBoardStyle_I;
#pragma warning disable 0169
			static Delegate GetSetSignBoardStyle_IHandler ()
			{
				if (cb_setSignBoardStyle_I == null)
					cb_setSignBoardStyle_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetSignBoardStyle_I));
				return cb_setSignBoardStyle_I;
			}

			static void n_SetSignBoardStyle_I (IntPtr jnienv, IntPtr native__this, int signBoardStyle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetSignBoardStyle (signBoardStyle);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='setSignBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSignBoardStyle", "(I)V", "GetSetSignBoardStyle_IHandler")]
			public virtual unsafe void SetSignBoardStyle (int signBoardStyle)
			{
				const string __id = "setSignBoardStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (signBoardStyle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_;
#pragma warning disable 0169
			static Delegate GetStartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_Handler ()
			{
				if (cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ == null)
					cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_V (n_StartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_));
				return cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_;
			}

			static void n_StartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ (IntPtr jnienv, IntPtr native__this, int time, IntPtr native_signcode, IntPtr native_iStartSignListenner)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var signcode = JNIEnv.GetString (native_signcode, JniHandleOwnership.DoNotTransfer);
				var iStartSignListenner = (global::Com.Vanstone.Sign.IStartSignListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Sign.IStartSignListenner> (native_iStartSignListenner, JniHandleOwnership.DoNotTransfer);
				__this.StartSign (time, signcode, iStartSignListenner);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='startSign' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.sign.IStartSignListenner']]"
			[Register ("startSign", "(ILjava/lang/String;Lcom/vanstone/sign/IStartSignListenner;)V", "GetStartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_Handler")]
			public virtual unsafe void StartSign (int time, string? signcode, global::Com.Vanstone.Sign.IStartSignListenner? iStartSignListenner)
			{
				const string __id = "startSign.(ILjava/lang/String;Lcom/vanstone/sign/IStartSignListenner;)V";
				IntPtr native_signcode = JNIEnv.NewString ((string?)signcode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (time);
					__args [1] = new JniArgumentValue (native_signcode);
					__args [2] = new JniArgumentValue ((iStartSignListenner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iStartSignListenner).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_signcode);
					global::System.GC.KeepAlive (iStartSignListenner);
				}
			}

			static Delegate? cb_stopSign;
#pragma warning disable 0169
			static Delegate GetStopSignHandler ()
			{
				if (cb_stopSign == null)
					cb_stopSign = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StopSign));
				return cb_stopSign;
			}

			static void n_StopSign (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.StopSign ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Default']/method[@name='stopSign' and count(parameter)=0]"
			[Register ("stopSign", "()V", "GetStopSignHandler")]
			public virtual unsafe void StopSign ()
			{
				const string __id = "stopSign.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sign/SignHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sign/SignHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/constructor[@name='SignHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/sign/SignHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/sign/SignHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/sign/SignHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/sign/SignHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.sign.SignHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/sign/SignHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/sign/SignHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_getSignatureCompressData;
#pragma warning disable 0169
			static Delegate GetGetSignatureCompressDataHandler ()
			{
				if (cb_getSignatureCompressData == null)
					cb_getSignatureCompressData = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignatureCompressData));
				return cb_getSignatureCompressData;
			}

			static IntPtr n_GetSignatureCompressData (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetSignatureCompressData ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='getSignatureCompressData' and count(parameter)=0]"
			[Register ("getSignatureCompressData", "()[B", "GetGetSignatureCompressDataHandler")]
			public abstract byte[]? GetSignatureCompressData ();

			static Delegate? cb_isToastConfirm_Z;
#pragma warning disable 0169
			static Delegate GetIsToastConfirm_ZHandler ()
			{
				if (cb_isToastConfirm_Z == null)
					cb_isToastConfirm_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_IsToastConfirm_Z));
				return cb_isToastConfirm_Z;
			}

			static void n_IsToastConfirm_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.IsToastConfirm (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='isToastConfirm' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("isToastConfirm", "(Z)V", "GetIsToastConfirm_ZHandler")]
			public abstract void IsToastConfirm (bool p0);

			static Delegate? cb_setResignCount_I;
#pragma warning disable 0169
			static Delegate GetSetResignCount_IHandler ()
			{
				if (cb_setResignCount_I == null)
					cb_setResignCount_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetResignCount_I));
				return cb_setResignCount_I;
			}

			static void n_SetResignCount_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetResignCount (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='setResignCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResignCount", "(I)V", "GetSetResignCount_IHandler")]
			public abstract void SetResignCount (int p0);

			static Delegate? cb_setSignBoardStyle_I;
#pragma warning disable 0169
			static Delegate GetSetSignBoardStyle_IHandler ()
			{
				if (cb_setSignBoardStyle_I == null)
					cb_setSignBoardStyle_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetSignBoardStyle_I));
				return cb_setSignBoardStyle_I;
			}

			static void n_SetSignBoardStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetSignBoardStyle (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='setSignBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSignBoardStyle", "(I)V", "GetSetSignBoardStyle_IHandler")]
			public abstract void SetSignBoardStyle (int p0);

			static Delegate? cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_;
#pragma warning disable 0169
			static Delegate GetStartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_Handler ()
			{
				if (cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ == null)
					cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_V (n_StartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_));
				return cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_;
			}

			static void n_StartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Com.Vanstone.Sign.IStartSignListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Sign.IStartSignListenner> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.StartSign (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='startSign' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.sign.IStartSignListenner']]"
			[Register ("startSign", "(ILjava/lang/String;Lcom/vanstone/sign/IStartSignListenner;)V", "GetStartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_Handler")]
			public abstract void StartSign (int p0, string? p1, global::Com.Vanstone.Sign.IStartSignListenner? p2);

			static Delegate? cb_stopSign;
#pragma warning disable 0169
			static Delegate GetStopSignHandler ()
			{
				if (cb_stopSign == null)
					cb_stopSign = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StopSign));
				return cb_stopSign;
			}

			static void n_StopSign (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.StopSign ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='stopSign' and count(parameter)=0]"
			[Register ("stopSign", "()V", "GetStopSignHandler")]
			public abstract void StopSign ();

			static Delegate? cb_getSignBmp;
#pragma warning disable 0169
			static Delegate GetGetSignBmpHandler ()
			{
				if (cb_getSignBmp == null)
					cb_getSignBmp = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignBmp));
				return cb_getSignBmp;
			}

			static IntPtr n_GetSignBmp (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SignBmp);
			}
#pragma warning restore 0169

			public abstract global::Android.Graphics.Bitmap? SignBmp {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='getSignBmp' and count(parameter)=0]"
				[Register ("getSignBmp", "()Landroid/graphics/Bitmap;", "GetGetSignBmpHandler")]
				get; 
			}

			static Delegate? cb_getSignatureLength;
#pragma warning disable 0169
			static Delegate GetGetSignatureLengthHandler ()
			{
				if (cb_getSignatureLength == null)
					cb_getSignatureLength = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetSignatureLength));
				return cb_getSignatureLength;
			}

			static int n_GetSignatureLength (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SignatureLength;
			}
#pragma warning restore 0169

			public abstract int SignatureLength {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='getSignatureLength' and count(parameter)=0]"
				[Register ("getSignatureLength", "()I", "GetGetSignatureLengthHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sign/SignHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sign/SignHandler$Stub", typeof (StubInvoker));

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

			public override unsafe global::Android.Graphics.Bitmap? SignBmp {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='getSignBmp' and count(parameter)=0]"
				[Register ("getSignBmp", "()Landroid/graphics/Bitmap;", "GetGetSignBmpHandler")]
				get {
					const string __id = "getSignBmp.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe int SignatureLength {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/class[@name='SignHandler.Stub']/method[@name='getSignatureLength' and count(parameter)=0]"
				[Register ("getSignatureLength", "()I", "GetGetSignatureLengthHandler")]
				get {
					const string __id = "getSignatureLength.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='getSignatureCompressData' and count(parameter)=0]"
			[Register ("getSignatureCompressData", "()[B", "GetGetSignatureCompressDataHandler")]
			public override unsafe byte[]? GetSignatureCompressData ()
			{
				const string __id = "getSignatureCompressData.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='isToastConfirm' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("isToastConfirm", "(Z)V", "GetIsToastConfirm_ZHandler")]
			public override unsafe void IsToastConfirm (bool p0)
			{
				const string __id = "isToastConfirm.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='setResignCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResignCount", "(I)V", "GetSetResignCount_IHandler")]
			public override unsafe void SetResignCount (int p0)
			{
				const string __id = "setResignCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='setSignBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSignBoardStyle", "(I)V", "GetSetSignBoardStyle_IHandler")]
			public override unsafe void SetSignBoardStyle (int p0)
			{
				const string __id = "setSignBoardStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='startSign' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.sign.IStartSignListenner']]"
			[Register ("startSign", "(ILjava/lang/String;Lcom/vanstone/sign/IStartSignListenner;)V", "GetStartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_Handler")]
			public override unsafe void StartSign (int p0, string? p1, global::Com.Vanstone.Sign.IStartSignListenner? p2)
			{
				const string __id = "startSign.(ILjava/lang/String;Lcom/vanstone/sign/IStartSignListenner;)V";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sign']/interface[@name='SignHandler']/method[@name='stopSign' and count(parameter)=0]"
			[Register ("stopSign", "()V", "GetStopSignHandler")]
			public override unsafe void StopSign ()
			{
				const string __id = "stopSign.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sign/SignHandler", DoNotGenerateAcw=true)]
	internal partial class ISignHandlerInvoker : global::Java.Lang.Object, ISignHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sign/SignHandler", typeof (ISignHandlerInvoker));

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

		public static ISignHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISignHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.sign.SignHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISignHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getSignBmp;
#pragma warning disable 0169
		static Delegate GetGetSignBmpHandler ()
		{
			if (cb_getSignBmp == null)
				cb_getSignBmp = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignBmp));
			return cb_getSignBmp;
		}

		static IntPtr n_GetSignBmp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SignBmp);
		}
#pragma warning restore 0169

		IntPtr id_getSignBmp;
		public unsafe global::Android.Graphics.Bitmap? SignBmp {
			get {
				if (id_getSignBmp == IntPtr.Zero)
					id_getSignBmp = JNIEnv.GetMethodID (class_ref, "getSignBmp", "()Landroid/graphics/Bitmap;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignBmp), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSignatureLength;
#pragma warning disable 0169
		static Delegate GetGetSignatureLengthHandler ()
		{
			if (cb_getSignatureLength == null)
				cb_getSignatureLength = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetSignatureLength));
			return cb_getSignatureLength;
		}

		static int n_GetSignatureLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SignatureLength;
		}
#pragma warning restore 0169

		IntPtr id_getSignatureLength;
		public unsafe int SignatureLength {
			get {
				if (id_getSignatureLength == IntPtr.Zero)
					id_getSignatureLength = JNIEnv.GetMethodID (class_ref, "getSignatureLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSignatureLength);
			}
		}

		static Delegate? cb_getSignatureCompressData;
#pragma warning disable 0169
		static Delegate GetGetSignatureCompressDataHandler ()
		{
			if (cb_getSignatureCompressData == null)
				cb_getSignatureCompressData = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSignatureCompressData));
			return cb_getSignatureCompressData;
		}

		static IntPtr n_GetSignatureCompressData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetSignatureCompressData ());
		}
#pragma warning restore 0169

		IntPtr id_getSignatureCompressData;
		public unsafe byte[]? GetSignatureCompressData ()
		{
			if (id_getSignatureCompressData == IntPtr.Zero)
				id_getSignatureCompressData = JNIEnv.GetMethodID (class_ref, "getSignatureCompressData", "()[B");
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignatureCompressData), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate? cb_isToastConfirm_Z;
#pragma warning disable 0169
		static Delegate GetIsToastConfirm_ZHandler ()
		{
			if (cb_isToastConfirm_Z == null)
				cb_isToastConfirm_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_IsToastConfirm_Z));
			return cb_isToastConfirm_Z;
		}

		static void n_IsToastConfirm_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.IsToastConfirm (p0);
		}
#pragma warning restore 0169

		IntPtr id_isToastConfirm_Z;
		public unsafe void IsToastConfirm (bool p0)
		{
			if (id_isToastConfirm_Z == IntPtr.Zero)
				id_isToastConfirm_Z = JNIEnv.GetMethodID (class_ref, "isToastConfirm", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_isToastConfirm_Z, __args);
		}

		static Delegate? cb_setResignCount_I;
#pragma warning disable 0169
		static Delegate GetSetResignCount_IHandler ()
		{
			if (cb_setResignCount_I == null)
				cb_setResignCount_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetResignCount_I));
			return cb_setResignCount_I;
		}

		static void n_SetResignCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetResignCount (p0);
		}
#pragma warning restore 0169

		IntPtr id_setResignCount_I;
		public unsafe void SetResignCount (int p0)
		{
			if (id_setResignCount_I == IntPtr.Zero)
				id_setResignCount_I = JNIEnv.GetMethodID (class_ref, "setResignCount", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResignCount_I, __args);
		}

		static Delegate? cb_setSignBoardStyle_I;
#pragma warning disable 0169
		static Delegate GetSetSignBoardStyle_IHandler ()
		{
			if (cb_setSignBoardStyle_I == null)
				cb_setSignBoardStyle_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetSignBoardStyle_I));
			return cb_setSignBoardStyle_I;
		}

		static void n_SetSignBoardStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetSignBoardStyle (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSignBoardStyle_I;
		public unsafe void SetSignBoardStyle (int p0)
		{
			if (id_setSignBoardStyle_I == IntPtr.Zero)
				id_setSignBoardStyle_I = JNIEnv.GetMethodID (class_ref, "setSignBoardStyle", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSignBoardStyle_I, __args);
		}

		static Delegate? cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_;
#pragma warning disable 0169
		static Delegate GetStartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_Handler ()
		{
			if (cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ == null)
				cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_V (n_StartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_));
			return cb_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_;
		}

		static void n_StartSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Vanstone.Sign.IStartSignListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Sign.IStartSignListenner> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.StartSign (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_;
		public unsafe void StartSign (int p0, string? p1, global::Com.Vanstone.Sign.IStartSignListenner? p2)
		{
			if (id_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ == IntPtr.Zero)
				id_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_ = JNIEnv.GetMethodID (class_ref, "startSign", "(ILjava/lang/String;Lcom/vanstone/sign/IStartSignListenner;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startSign_ILjava_lang_String_Lcom_vanstone_sign_IStartSignListenner_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_stopSign;
#pragma warning disable 0169
		static Delegate GetStopSignHandler ()
		{
			if (cb_stopSign == null)
				cb_stopSign = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StopSign));
			return cb_stopSign;
		}

		static void n_StopSign (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.StopSign ();
		}
#pragma warning restore 0169

		IntPtr id_stopSign;
		public unsafe void StopSign ()
		{
			if (id_stopSign == IntPtr.Zero)
				id_stopSign = JNIEnv.GetMethodID (class_ref, "stopSign", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopSign);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Sign.ISignHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
