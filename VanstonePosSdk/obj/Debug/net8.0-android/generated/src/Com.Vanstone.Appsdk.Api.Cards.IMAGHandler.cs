using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']"
	[Register ("com/vanstone/appsdk/api/cards/MAGHandler", "", "Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker")]
	public partial interface IMAGHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagClose_Api' and count(parameter)=0]"
		[Register ("MagClose_Api", "()I", "GetMagClose_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		int MagClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagGetTradCode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("MagGetTradCode_Api", "(I)I", "GetMagGetTradCode_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		int MagGetTradCode_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagOpen_Api' and count(parameter)=0]"
		[Register ("MagOpen_Api", "()I", "GetMagOpen_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		int MagOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagRead_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("MagRead_Api", "([B[B)I", "GetMagRead_Api_arrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		int MagRead_Api (byte[]? p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagReset_Api' and count(parameter)=0]"
		[Register ("MagReset_Api", "()V", "GetMagReset_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		void MagReset_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagSetCheckLrc_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("MagSetCheckLrc_Api", "(Z)I", "GetMagSetCheckLrc_Api_ZHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		int MagSetCheckLrc_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagSwiped_Api' and count(parameter)=0]"
		[Register ("MagSwiped_Api", "()I", "GetMagSwiped_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		int MagSwiped_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='getTrackData_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTrackData_Api", "(I)[B", "GetGetTrackData_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IMAGHandlerInvoker, VanstonePosSdk")]
		byte[]? GetTrackData_Api (int p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MAGHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MAGHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/constructor[@name='MAGHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_MagClose_Api;
#pragma warning disable 0169
			static Delegate GetMagClose_ApiHandler ()
			{
				if (cb_MagClose_Api == null)
					cb_MagClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagClose_Api));
				return cb_MagClose_Api;
			}

			static int n_MagClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='MagClose_Api' and count(parameter)=0]"
			[Register ("MagClose_Api", "()I", "GetMagClose_ApiHandler")]
			public virtual unsafe int MagClose_Api ()
			{
				const string __id = "MagClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_MagGetTradCode_Api_I;
#pragma warning disable 0169
			static Delegate GetMagGetTradCode_Api_IHandler ()
			{
				if (cb_MagGetTradCode_Api_I == null)
					cb_MagGetTradCode_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_MagGetTradCode_Api_I));
				return cb_MagGetTradCode_Api_I;
			}

			static int n_MagGetTradCode_Api_I (IntPtr jnienv, IntPtr native__this, int tradNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagGetTradCode_Api (tradNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='MagGetTradCode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("MagGetTradCode_Api", "(I)I", "GetMagGetTradCode_Api_IHandler")]
			public virtual unsafe int MagGetTradCode_Api (int tradNo)
			{
				const string __id = "MagGetTradCode_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (tradNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_MagOpen_Api;
#pragma warning disable 0169
			static Delegate GetMagOpen_ApiHandler ()
			{
				if (cb_MagOpen_Api == null)
					cb_MagOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagOpen_Api));
				return cb_MagOpen_Api;
			}

			static int n_MagOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='MagOpen_Api' and count(parameter)=0]"
			[Register ("MagOpen_Api", "()I", "GetMagOpen_ApiHandler")]
			public virtual unsafe int MagOpen_Api ()
			{
				const string __id = "MagOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_MagRead_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetMagRead_Api_arrayBarrayBHandler ()
			{
				if (cb_MagRead_Api_arrayBarrayB == null)
					cb_MagRead_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_MagRead_Api_arrayBarrayB));
				return cb_MagRead_Api_arrayBarrayB;
			}

			static int n_MagRead_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_RBuf, IntPtr native_RLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var RBuf = (byte[]?) JNIEnv.GetArray (native_RBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var RLen = (byte[]?) JNIEnv.GetArray (native_RLen, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MagRead_Api (RBuf, RLen);
				if (RBuf != null)
					JNIEnv.CopyArray (RBuf, native_RBuf);
				if (RLen != null)
					JNIEnv.CopyArray (RLen, native_RLen);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='MagRead_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("MagRead_Api", "([B[B)I", "GetMagRead_Api_arrayBarrayBHandler")]
			public virtual unsafe int MagRead_Api (byte[]? RBuf, byte[]? RLen)
			{
				const string __id = "MagRead_Api.([B[B)I";
				IntPtr native_RBuf = JNIEnv.NewArray (RBuf);
				IntPtr native_RLen = JNIEnv.NewArray (RLen);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_RBuf);
					__args [1] = new JniArgumentValue (native_RLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (RBuf != null) {
						JNIEnv.CopyArray (native_RBuf, RBuf);
						JNIEnv.DeleteLocalRef (native_RBuf);
					}
					if (RLen != null) {
						JNIEnv.CopyArray (native_RLen, RLen);
						JNIEnv.DeleteLocalRef (native_RLen);
					}
					global::System.GC.KeepAlive (RBuf);
					global::System.GC.KeepAlive (RLen);
				}
			}

			static Delegate? cb_MagReset_Api;
#pragma warning disable 0169
			static Delegate GetMagReset_ApiHandler ()
			{
				if (cb_MagReset_Api == null)
					cb_MagReset_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_MagReset_Api));
				return cb_MagReset_Api;
			}

			static void n_MagReset_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.MagReset_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='MagReset_Api' and count(parameter)=0]"
			[Register ("MagReset_Api", "()V", "GetMagReset_ApiHandler")]
			public virtual unsafe void MagReset_Api ()
			{
				const string __id = "MagReset_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_MagSetCheckLrc_Api_Z;
#pragma warning disable 0169
			static Delegate GetMagSetCheckLrc_Api_ZHandler ()
			{
				if (cb_MagSetCheckLrc_Api_Z == null)
					cb_MagSetCheckLrc_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_I (n_MagSetCheckLrc_Api_Z));
				return cb_MagSetCheckLrc_Api_Z;
			}

			static int n_MagSetCheckLrc_Api_Z (IntPtr jnienv, IntPtr native__this, bool enable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagSetCheckLrc_Api (enable);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='MagSetCheckLrc_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("MagSetCheckLrc_Api", "(Z)I", "GetMagSetCheckLrc_Api_ZHandler")]
			public virtual unsafe int MagSetCheckLrc_Api (bool enable)
			{
				const string __id = "MagSetCheckLrc_Api.(Z)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_MagSwiped_Api;
#pragma warning disable 0169
			static Delegate GetMagSwiped_ApiHandler ()
			{
				if (cb_MagSwiped_Api == null)
					cb_MagSwiped_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagSwiped_Api));
				return cb_MagSwiped_Api;
			}

			static int n_MagSwiped_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagSwiped_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='MagSwiped_Api' and count(parameter)=0]"
			[Register ("MagSwiped_Api", "()I", "GetMagSwiped_ApiHandler")]
			public virtual unsafe int MagSwiped_Api ()
			{
				const string __id = "MagSwiped_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_getTrackData_Api_I;
#pragma warning disable 0169
			static Delegate GetGetTrackData_Api_IHandler ()
			{
				if (cb_getTrackData_Api_I == null)
					cb_getTrackData_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_GetTrackData_Api_I));
				return cb_getTrackData_Api_I;
			}

			static IntPtr n_GetTrackData_Api_I (IntPtr jnienv, IntPtr native__this, int track)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetTrackData_Api (track));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Default']/method[@name='getTrackData_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getTrackData_Api", "(I)[B", "GetGetTrackData_Api_IHandler")]
			public virtual unsafe byte[]? GetTrackData_Api (int track)
			{
				const string __id = "getTrackData_Api.(I)[B";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (track);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MAGHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MAGHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Stub']/constructor[@name='MAGHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/MAGHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/MAGHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/MAGHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/MAGHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MAGHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.MAGHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/MAGHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/MAGHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_MagClose_Api;
#pragma warning disable 0169
			static Delegate GetMagClose_ApiHandler ()
			{
				if (cb_MagClose_Api == null)
					cb_MagClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagClose_Api));
				return cb_MagClose_Api;
			}

			static int n_MagClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagClose_Api' and count(parameter)=0]"
			[Register ("MagClose_Api", "()I", "GetMagClose_ApiHandler")]
			public abstract int MagClose_Api ();

			static Delegate? cb_MagGetTradCode_Api_I;
#pragma warning disable 0169
			static Delegate GetMagGetTradCode_Api_IHandler ()
			{
				if (cb_MagGetTradCode_Api_I == null)
					cb_MagGetTradCode_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_MagGetTradCode_Api_I));
				return cb_MagGetTradCode_Api_I;
			}

			static int n_MagGetTradCode_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagGetTradCode_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagGetTradCode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("MagGetTradCode_Api", "(I)I", "GetMagGetTradCode_Api_IHandler")]
			public abstract int MagGetTradCode_Api (int p0);

			static Delegate? cb_MagOpen_Api;
#pragma warning disable 0169
			static Delegate GetMagOpen_ApiHandler ()
			{
				if (cb_MagOpen_Api == null)
					cb_MagOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagOpen_Api));
				return cb_MagOpen_Api;
			}

			static int n_MagOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagOpen_Api' and count(parameter)=0]"
			[Register ("MagOpen_Api", "()I", "GetMagOpen_ApiHandler")]
			public abstract int MagOpen_Api ();

			static Delegate? cb_MagRead_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetMagRead_Api_arrayBarrayBHandler ()
			{
				if (cb_MagRead_Api_arrayBarrayB == null)
					cb_MagRead_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_MagRead_Api_arrayBarrayB));
				return cb_MagRead_Api_arrayBarrayB;
			}

			static int n_MagRead_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MagRead_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagRead_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("MagRead_Api", "([B[B)I", "GetMagRead_Api_arrayBarrayBHandler")]
			public abstract int MagRead_Api (byte[]? p0, byte[]? p1);

			static Delegate? cb_MagReset_Api;
#pragma warning disable 0169
			static Delegate GetMagReset_ApiHandler ()
			{
				if (cb_MagReset_Api == null)
					cb_MagReset_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_MagReset_Api));
				return cb_MagReset_Api;
			}

			static void n_MagReset_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.MagReset_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagReset_Api' and count(parameter)=0]"
			[Register ("MagReset_Api", "()V", "GetMagReset_ApiHandler")]
			public abstract void MagReset_Api ();

			static Delegate? cb_MagSetCheckLrc_Api_Z;
#pragma warning disable 0169
			static Delegate GetMagSetCheckLrc_Api_ZHandler ()
			{
				if (cb_MagSetCheckLrc_Api_Z == null)
					cb_MagSetCheckLrc_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_I (n_MagSetCheckLrc_Api_Z));
				return cb_MagSetCheckLrc_Api_Z;
			}

			static int n_MagSetCheckLrc_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagSetCheckLrc_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagSetCheckLrc_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("MagSetCheckLrc_Api", "(Z)I", "GetMagSetCheckLrc_Api_ZHandler")]
			public abstract int MagSetCheckLrc_Api (bool p0);

			static Delegate? cb_MagSwiped_Api;
#pragma warning disable 0169
			static Delegate GetMagSwiped_ApiHandler ()
			{
				if (cb_MagSwiped_Api == null)
					cb_MagSwiped_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagSwiped_Api));
				return cb_MagSwiped_Api;
			}

			static int n_MagSwiped_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MagSwiped_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagSwiped_Api' and count(parameter)=0]"
			[Register ("MagSwiped_Api", "()I", "GetMagSwiped_ApiHandler")]
			public abstract int MagSwiped_Api ();

			static Delegate? cb_getTrackData_Api_I;
#pragma warning disable 0169
			static Delegate GetGetTrackData_Api_IHandler ()
			{
				if (cb_getTrackData_Api_I == null)
					cb_getTrackData_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_GetTrackData_Api_I));
				return cb_getTrackData_Api_I;
			}

			static IntPtr n_GetTrackData_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetTrackData_Api (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='getTrackData_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getTrackData_Api", "(I)[B", "GetGetTrackData_Api_IHandler")]
			public abstract byte[]? GetTrackData_Api (int p0);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MAGHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MAGHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagClose_Api' and count(parameter)=0]"
			[Register ("MagClose_Api", "()I", "GetMagClose_ApiHandler")]
			public override unsafe int MagClose_Api ()
			{
				const string __id = "MagClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagGetTradCode_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("MagGetTradCode_Api", "(I)I", "GetMagGetTradCode_Api_IHandler")]
			public override unsafe int MagGetTradCode_Api (int p0)
			{
				const string __id = "MagGetTradCode_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagOpen_Api' and count(parameter)=0]"
			[Register ("MagOpen_Api", "()I", "GetMagOpen_ApiHandler")]
			public override unsafe int MagOpen_Api ()
			{
				const string __id = "MagOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagRead_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("MagRead_Api", "([B[B)I", "GetMagRead_Api_arrayBarrayBHandler")]
			public override unsafe int MagRead_Api (byte[]? p0, byte[]? p1)
			{
				const string __id = "MagRead_Api.([B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagReset_Api' and count(parameter)=0]"
			[Register ("MagReset_Api", "()V", "GetMagReset_ApiHandler")]
			public override unsafe void MagReset_Api ()
			{
				const string __id = "MagReset_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagSetCheckLrc_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("MagSetCheckLrc_Api", "(Z)I", "GetMagSetCheckLrc_Api_ZHandler")]
			public override unsafe int MagSetCheckLrc_Api (bool p0)
			{
				const string __id = "MagSetCheckLrc_Api.(Z)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='MagSwiped_Api' and count(parameter)=0]"
			[Register ("MagSwiped_Api", "()I", "GetMagSwiped_ApiHandler")]
			public override unsafe int MagSwiped_Api ()
			{
				const string __id = "MagSwiped_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MAGHandler']/method[@name='getTrackData_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getTrackData_Api", "(I)[B", "GetGetTrackData_Api_IHandler")]
			public override unsafe byte[]? GetTrackData_Api (int p0)
			{
				const string __id = "getTrackData_Api.(I)[B";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MAGHandler", DoNotGenerateAcw=true)]
	internal partial class IMAGHandlerInvoker : global::Java.Lang.Object, IMAGHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MAGHandler", typeof (IMAGHandlerInvoker));

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

		public static IMAGHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMAGHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.MAGHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMAGHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_MagClose_Api;
#pragma warning disable 0169
		static Delegate GetMagClose_ApiHandler ()
		{
			if (cb_MagClose_Api == null)
				cb_MagClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagClose_Api));
			return cb_MagClose_Api;
		}

		static int n_MagClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MagClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_MagClose_Api;
		public unsafe int MagClose_Api ()
		{
			if (id_MagClose_Api == IntPtr.Zero)
				id_MagClose_Api = JNIEnv.GetMethodID (class_ref, "MagClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MagClose_Api);
		}

		static Delegate? cb_MagGetTradCode_Api_I;
#pragma warning disable 0169
		static Delegate GetMagGetTradCode_Api_IHandler ()
		{
			if (cb_MagGetTradCode_Api_I == null)
				cb_MagGetTradCode_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_MagGetTradCode_Api_I));
			return cb_MagGetTradCode_Api_I;
		}

		static int n_MagGetTradCode_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MagGetTradCode_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_MagGetTradCode_Api_I;
		public unsafe int MagGetTradCode_Api (int p0)
		{
			if (id_MagGetTradCode_Api_I == IntPtr.Zero)
				id_MagGetTradCode_Api_I = JNIEnv.GetMethodID (class_ref, "MagGetTradCode_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MagGetTradCode_Api_I, __args);
		}

		static Delegate? cb_MagOpen_Api;
#pragma warning disable 0169
		static Delegate GetMagOpen_ApiHandler ()
		{
			if (cb_MagOpen_Api == null)
				cb_MagOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagOpen_Api));
			return cb_MagOpen_Api;
		}

		static int n_MagOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MagOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_MagOpen_Api;
		public unsafe int MagOpen_Api ()
		{
			if (id_MagOpen_Api == IntPtr.Zero)
				id_MagOpen_Api = JNIEnv.GetMethodID (class_ref, "MagOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MagOpen_Api);
		}

		static Delegate? cb_MagRead_Api_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetMagRead_Api_arrayBarrayBHandler ()
		{
			if (cb_MagRead_Api_arrayBarrayB == null)
				cb_MagRead_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_MagRead_Api_arrayBarrayB));
			return cb_MagRead_Api_arrayBarrayB;
		}

		static int n_MagRead_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.MagRead_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_MagRead_Api_arrayBarrayB;
		public unsafe int MagRead_Api (byte[]? p0, byte[]? p1)
		{
			if (id_MagRead_Api_arrayBarrayB == IntPtr.Zero)
				id_MagRead_Api_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "MagRead_Api", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MagRead_Api_arrayBarrayB, __args);
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

		static Delegate? cb_MagReset_Api;
#pragma warning disable 0169
		static Delegate GetMagReset_ApiHandler ()
		{
			if (cb_MagReset_Api == null)
				cb_MagReset_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_MagReset_Api));
			return cb_MagReset_Api;
		}

		static void n_MagReset_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.MagReset_Api ();
		}
#pragma warning restore 0169

		IntPtr id_MagReset_Api;
		public unsafe void MagReset_Api ()
		{
			if (id_MagReset_Api == IntPtr.Zero)
				id_MagReset_Api = JNIEnv.GetMethodID (class_ref, "MagReset_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MagReset_Api);
		}

		static Delegate? cb_MagSetCheckLrc_Api_Z;
#pragma warning disable 0169
		static Delegate GetMagSetCheckLrc_Api_ZHandler ()
		{
			if (cb_MagSetCheckLrc_Api_Z == null)
				cb_MagSetCheckLrc_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_I (n_MagSetCheckLrc_Api_Z));
			return cb_MagSetCheckLrc_Api_Z;
		}

		static int n_MagSetCheckLrc_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MagSetCheckLrc_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_MagSetCheckLrc_Api_Z;
		public unsafe int MagSetCheckLrc_Api (bool p0)
		{
			if (id_MagSetCheckLrc_Api_Z == IntPtr.Zero)
				id_MagSetCheckLrc_Api_Z = JNIEnv.GetMethodID (class_ref, "MagSetCheckLrc_Api", "(Z)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MagSetCheckLrc_Api_Z, __args);
		}

		static Delegate? cb_MagSwiped_Api;
#pragma warning disable 0169
		static Delegate GetMagSwiped_ApiHandler ()
		{
			if (cb_MagSwiped_Api == null)
				cb_MagSwiped_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_MagSwiped_Api));
			return cb_MagSwiped_Api;
		}

		static int n_MagSwiped_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MagSwiped_Api ();
		}
#pragma warning restore 0169

		IntPtr id_MagSwiped_Api;
		public unsafe int MagSwiped_Api ()
		{
			if (id_MagSwiped_Api == IntPtr.Zero)
				id_MagSwiped_Api = JNIEnv.GetMethodID (class_ref, "MagSwiped_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MagSwiped_Api);
		}

		static Delegate? cb_getTrackData_Api_I;
#pragma warning disable 0169
		static Delegate GetGetTrackData_Api_IHandler ()
		{
			if (cb_getTrackData_Api_I == null)
				cb_getTrackData_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_GetTrackData_Api_I));
			return cb_getTrackData_Api_I;
		}

		static IntPtr n_GetTrackData_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetTrackData_Api (p0));
		}
#pragma warning restore 0169

		IntPtr id_getTrackData_Api_I;
		public unsafe byte[]? GetTrackData_Api (int p0)
		{
			if (id_getTrackData_Api_I == IntPtr.Zero)
				id_getTrackData_Api_I = JNIEnv.GetMethodID (class_ref, "getTrackData_Api", "(I)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackData_Api_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMAGHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
