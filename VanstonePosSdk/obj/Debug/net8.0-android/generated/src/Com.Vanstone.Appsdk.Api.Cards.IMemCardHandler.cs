using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']"
	[Register ("com/vanstone/appsdk/api/cards/MemCardHandler", "", "Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker")]
	public partial interface IMemCardHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428Close_Api' and count(parameter)=0]"
		[Register ("sle4428Close_Api", "()I", "GetSle4428Close_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4428Close_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("sle4428Open_Api", "(I[B)I", "GetSle4428Open_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4428Open_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428ReadNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("sle4428ReadNoProtect_Api", "(I[BI)I", "GetSle4428ReadNoProtect_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4428ReadNoProtect_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428VerifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("sle4428VerifyKey_Api", "(BB)I", "GetSle4428VerifyKey_Api_BBHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4428VerifyKey_Api (sbyte p0, sbyte p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428WriteAndCompareProtect_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte']]"
		[Register ("sle4428WriteAndCompareProtect_Api", "(I[BIB)I", "GetSle4428WriteAndCompareProtect_Api_IarrayBIBHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4428WriteAndCompareProtect_Api (int p0, byte[]? p1, int p2, sbyte p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428WriteNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("sle4428WriteNoProtect_Api", "(I[BI)I", "GetSle4428WriteNoProtect_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4428WriteNoProtect_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Close_Api' and count(parameter)=0]"
		[Register ("sle4442Close_Api", "()I", "GetSle4442Close_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4442Close_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442ModifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("sle4442ModifyKey_Api", "([B[B)I", "GetSle4442ModifyKey_Api_arrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4442ModifyKey_Api (byte[]? p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("sle4442Open_Api", "(I[B)I", "GetSle4442Open_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4442Open_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Read_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("sle4442Read_Api", "(BB[BI)I", "GetSle4442Read_Api_BBarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4442Read_Api (sbyte p0, sbyte p1, byte[]? p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442RemainCheckTime_Api' and count(parameter)=0]"
		[Register ("sle4442RemainCheckTime_Api", "()I", "GetSle4442RemainCheckTime_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4442RemainCheckTime_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Verify_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sle4442Verify_Api", "([B)I", "GetSle4442Verify_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4442Verify_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Write_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("sle4442Write_Api", "(BB[BI)I", "GetSle4442Write_Api_BBarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IMemCardHandlerInvoker, VanstonePosSdk")]
		int Sle4442Write_Api (sbyte p0, sbyte p1, byte[]? p2, int p3);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MemCardHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MemCardHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/constructor[@name='MemCardHandler.Default' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_sle4428Close_Api;
#pragma warning disable 0169
			static Delegate GetSle4428Close_ApiHandler ()
			{
				if (cb_sle4428Close_Api == null)
					cb_sle4428Close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4428Close_Api));
				return cb_sle4428Close_Api;
			}

			static int n_Sle4428Close_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4428Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4428Close_Api' and count(parameter)=0]"
			[Register ("sle4428Close_Api", "()I", "GetSle4428Close_ApiHandler")]
			public virtual unsafe int Sle4428Close_Api ()
			{
				const string __id = "sle4428Close_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_sle4428Open_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSle4428Open_Api_IarrayBHandler ()
			{
				if (cb_sle4428Open_Api_IarrayB == null)
					cb_sle4428Open_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sle4428Open_Api_IarrayB));
				return cb_sle4428Open_Api_IarrayB;
			}

			static int n_Sle4428Open_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int vol, IntPtr native_atr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var atr = (byte[]?) JNIEnv.GetArray (native_atr, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428Open_Api (vol, atr);
				if (atr != null)
					JNIEnv.CopyArray (atr, native_atr);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4428Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("sle4428Open_Api", "(I[B)I", "GetSle4428Open_Api_IarrayBHandler")]
			public virtual unsafe int Sle4428Open_Api (int vol, byte[]? atr)
			{
				const string __id = "sle4428Open_Api.(I[B)I";
				IntPtr native_atr = JNIEnv.NewArray (atr);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (vol);
					__args [1] = new JniArgumentValue (native_atr);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (atr != null) {
						JNIEnv.CopyArray (native_atr, atr);
						JNIEnv.DeleteLocalRef (native_atr);
					}
					global::System.GC.KeepAlive (atr);
				}
			}

			static Delegate? cb_sle4428ReadNoProtect_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4428ReadNoProtect_Api_IarrayBIHandler ()
			{
				if (cb_sle4428ReadNoProtect_Api_IarrayBI == null)
					cb_sle4428ReadNoProtect_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Sle4428ReadNoProtect_Api_IarrayBI));
				return cb_sle4428ReadNoProtect_Api_IarrayBI;
			}

			static int n_Sle4428ReadNoProtect_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int addr, IntPtr native_buf, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428ReadNoProtect_Api (addr, buf, len);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4428ReadNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("sle4428ReadNoProtect_Api", "(I[BI)I", "GetSle4428ReadNoProtect_Api_IarrayBIHandler")]
			public virtual unsafe int Sle4428ReadNoProtect_Api (int addr, byte[]? buf, int len)
			{
				const string __id = "sle4428ReadNoProtect_Api.(I[BI)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (addr);
					__args [1] = new JniArgumentValue (native_buf);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

			static Delegate? cb_sle4428VerifyKey_Api_BB;
#pragma warning disable 0169
			static Delegate GetSle4428VerifyKey_Api_BBHandler ()
			{
				if (cb_sle4428VerifyKey_Api_BB == null)
					cb_sle4428VerifyKey_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_Sle4428VerifyKey_Api_BB));
				return cb_sle4428VerifyKey_Api_BB;
			}

			static int n_Sle4428VerifyKey_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte keyF, sbyte keyS)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4428VerifyKey_Api (keyF, keyS);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4428VerifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("sle4428VerifyKey_Api", "(BB)I", "GetSle4428VerifyKey_Api_BBHandler")]
			public virtual unsafe int Sle4428VerifyKey_Api (sbyte keyF, sbyte keyS)
			{
				const string __id = "sle4428VerifyKey_Api.(BB)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyF);
					__args [1] = new JniArgumentValue (keyS);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_sle4428WriteAndCompareProtect_Api_IarrayBIB;
#pragma warning disable 0169
			static Delegate GetSle4428WriteAndCompareProtect_Api_IarrayBIBHandler ()
			{
				if (cb_sle4428WriteAndCompareProtect_Api_IarrayBIB == null)
					cb_sle4428WriteAndCompareProtect_Api_IarrayBIB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILIB_I (n_Sle4428WriteAndCompareProtect_Api_IarrayBIB));
				return cb_sle4428WriteAndCompareProtect_Api_IarrayBIB;
			}

			static int n_Sle4428WriteAndCompareProtect_Api_IarrayBIB (IntPtr jnienv, IntPtr native__this, int addr, IntPtr native_data, int len, sbyte mode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428WriteAndCompareProtect_Api (addr, data, len, mode);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4428WriteAndCompareProtect_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte']]"
			[Register ("sle4428WriteAndCompareProtect_Api", "(I[BIB)I", "GetSle4428WriteAndCompareProtect_Api_IarrayBIBHandler")]
			public virtual unsafe int Sle4428WriteAndCompareProtect_Api (int addr, byte[]? data, int len, sbyte mode)
			{
				const string __id = "sle4428WriteAndCompareProtect_Api.(I[BIB)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (addr);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (len);
					__args [3] = new JniArgumentValue (mode);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			static Delegate? cb_sle4428WriteNoProtect_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4428WriteNoProtect_Api_IarrayBIHandler ()
			{
				if (cb_sle4428WriteNoProtect_Api_IarrayBI == null)
					cb_sle4428WriteNoProtect_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Sle4428WriteNoProtect_Api_IarrayBI));
				return cb_sle4428WriteNoProtect_Api_IarrayBI;
			}

			static int n_Sle4428WriteNoProtect_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int addr, IntPtr native_data, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428WriteNoProtect_Api (addr, data, len);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4428WriteNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("sle4428WriteNoProtect_Api", "(I[BI)I", "GetSle4428WriteNoProtect_Api_IarrayBIHandler")]
			public virtual unsafe int Sle4428WriteNoProtect_Api (int addr, byte[]? data, int len)
			{
				const string __id = "sle4428WriteNoProtect_Api.(I[BI)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (addr);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			static Delegate? cb_sle4442Close_Api;
#pragma warning disable 0169
			static Delegate GetSle4442Close_ApiHandler ()
			{
				if (cb_sle4442Close_Api == null)
					cb_sle4442Close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4442Close_Api));
				return cb_sle4442Close_Api;
			}

			static int n_Sle4442Close_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4442Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4442Close_Api' and count(parameter)=0]"
			[Register ("sle4442Close_Api", "()I", "GetSle4442Close_ApiHandler")]
			public virtual unsafe int Sle4442Close_Api ()
			{
				const string __id = "sle4442Close_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_sle4442ModifyKey_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetSle4442ModifyKey_Api_arrayBarrayBHandler ()
			{
				if (cb_sle4442ModifyKey_Api_arrayBarrayB == null)
					cb_sle4442ModifyKey_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_Sle4442ModifyKey_Api_arrayBarrayB));
				return cb_sle4442ModifyKey_Api_arrayBarrayB;
			}

			static int n_Sle4442ModifyKey_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_oldKey, IntPtr native_newKey)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var oldKey = (byte[]?) JNIEnv.GetArray (native_oldKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var newKey = (byte[]?) JNIEnv.GetArray (native_newKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442ModifyKey_Api (oldKey, newKey);
				if (oldKey != null)
					JNIEnv.CopyArray (oldKey, native_oldKey);
				if (newKey != null)
					JNIEnv.CopyArray (newKey, native_newKey);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4442ModifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("sle4442ModifyKey_Api", "([B[B)I", "GetSle4442ModifyKey_Api_arrayBarrayBHandler")]
			public virtual unsafe int Sle4442ModifyKey_Api (byte[]? oldKey, byte[]? newKey)
			{
				const string __id = "sle4442ModifyKey_Api.([B[B)I";
				IntPtr native_oldKey = JNIEnv.NewArray (oldKey);
				IntPtr native_newKey = JNIEnv.NewArray (newKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_oldKey);
					__args [1] = new JniArgumentValue (native_newKey);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (oldKey != null) {
						JNIEnv.CopyArray (native_oldKey, oldKey);
						JNIEnv.DeleteLocalRef (native_oldKey);
					}
					if (newKey != null) {
						JNIEnv.CopyArray (native_newKey, newKey);
						JNIEnv.DeleteLocalRef (native_newKey);
					}
					global::System.GC.KeepAlive (oldKey);
					global::System.GC.KeepAlive (newKey);
				}
			}

			static Delegate? cb_sle4442Open_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSle4442Open_Api_IarrayBHandler ()
			{
				if (cb_sle4442Open_Api_IarrayB == null)
					cb_sle4442Open_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sle4442Open_Api_IarrayB));
				return cb_sle4442Open_Api_IarrayB;
			}

			static int n_Sle4442Open_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int vol, IntPtr native_atr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var atr = (byte[]?) JNIEnv.GetArray (native_atr, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Open_Api (vol, atr);
				if (atr != null)
					JNIEnv.CopyArray (atr, native_atr);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4442Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("sle4442Open_Api", "(I[B)I", "GetSle4442Open_Api_IarrayBHandler")]
			public virtual unsafe int Sle4442Open_Api (int vol, byte[]? atr)
			{
				const string __id = "sle4442Open_Api.(I[B)I";
				IntPtr native_atr = JNIEnv.NewArray (atr);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (vol);
					__args [1] = new JniArgumentValue (native_atr);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (atr != null) {
						JNIEnv.CopyArray (native_atr, atr);
						JNIEnv.DeleteLocalRef (native_atr);
					}
					global::System.GC.KeepAlive (atr);
				}
			}

			static Delegate? cb_sle4442Read_Api_BBarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4442Read_Api_BBarrayBIHandler ()
			{
				if (cb_sle4442Read_Api_BBarrayBI == null)
					cb_sle4442Read_Api_BBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLI_I (n_Sle4442Read_Api_BBarrayBI));
				return cb_sle4442Read_Api_BBarrayBI;
			}

			static int n_Sle4442Read_Api_BBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte ctrl, sbyte addr, IntPtr native_readData, int readLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var readData = (byte[]?) JNIEnv.GetArray (native_readData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Read_Api (ctrl, addr, readData, readLen);
				if (readData != null)
					JNIEnv.CopyArray (readData, native_readData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4442Read_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("sle4442Read_Api", "(BB[BI)I", "GetSle4442Read_Api_BBarrayBIHandler")]
			public virtual unsafe int Sle4442Read_Api (sbyte ctrl, sbyte addr, byte[]? readData, int readLen)
			{
				const string __id = "sle4442Read_Api.(BB[BI)I";
				IntPtr native_readData = JNIEnv.NewArray (readData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (ctrl);
					__args [1] = new JniArgumentValue (addr);
					__args [2] = new JniArgumentValue (native_readData);
					__args [3] = new JniArgumentValue (readLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (readData != null) {
						JNIEnv.CopyArray (native_readData, readData);
						JNIEnv.DeleteLocalRef (native_readData);
					}
					global::System.GC.KeepAlive (readData);
				}
			}

			static Delegate? cb_sle4442RemainCheckTime_Api;
#pragma warning disable 0169
			static Delegate GetSle4442RemainCheckTime_ApiHandler ()
			{
				if (cb_sle4442RemainCheckTime_Api == null)
					cb_sle4442RemainCheckTime_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4442RemainCheckTime_Api));
				return cb_sle4442RemainCheckTime_Api;
			}

			static int n_Sle4442RemainCheckTime_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4442RemainCheckTime_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4442RemainCheckTime_Api' and count(parameter)=0]"
			[Register ("sle4442RemainCheckTime_Api", "()I", "GetSle4442RemainCheckTime_ApiHandler")]
			public virtual unsafe int Sle4442RemainCheckTime_Api ()
			{
				const string __id = "sle4442RemainCheckTime_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_sle4442Verify_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetSle4442Verify_Api_arrayBHandler ()
			{
				if (cb_sle4442Verify_Api_arrayB == null)
					cb_sle4442Verify_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Sle4442Verify_Api_arrayB));
				return cb_sle4442Verify_Api_arrayB;
			}

			static int n_Sle4442Verify_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_password)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var password = (byte[]?) JNIEnv.GetArray (native_password, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Verify_Api (password);
				if (password != null)
					JNIEnv.CopyArray (password, native_password);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4442Verify_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("sle4442Verify_Api", "([B)I", "GetSle4442Verify_Api_arrayBHandler")]
			public virtual unsafe int Sle4442Verify_Api (byte[]? password)
			{
				const string __id = "sle4442Verify_Api.([B)I";
				IntPtr native_password = JNIEnv.NewArray (password);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_password);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (password != null) {
						JNIEnv.CopyArray (native_password, password);
						JNIEnv.DeleteLocalRef (native_password);
					}
					global::System.GC.KeepAlive (password);
				}
			}

			static Delegate? cb_sle4442Write_Api_BBarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4442Write_Api_BBarrayBIHandler ()
			{
				if (cb_sle4442Write_Api_BBarrayBI == null)
					cb_sle4442Write_Api_BBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLI_I (n_Sle4442Write_Api_BBarrayBI));
				return cb_sle4442Write_Api_BBarrayBI;
			}

			static int n_Sle4442Write_Api_BBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte ctrl, sbyte addr, IntPtr native_writeData, int writeLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var writeData = (byte[]?) JNIEnv.GetArray (native_writeData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Write_Api (ctrl, addr, writeData, writeLen);
				if (writeData != null)
					JNIEnv.CopyArray (writeData, native_writeData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Default']/method[@name='sle4442Write_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("sle4442Write_Api", "(BB[BI)I", "GetSle4442Write_Api_BBarrayBIHandler")]
			public virtual unsafe int Sle4442Write_Api (sbyte ctrl, sbyte addr, byte[]? writeData, int writeLen)
			{
				const string __id = "sle4442Write_Api.(BB[BI)I";
				IntPtr native_writeData = JNIEnv.NewArray (writeData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (ctrl);
					__args [1] = new JniArgumentValue (addr);
					__args [2] = new JniArgumentValue (native_writeData);
					__args [3] = new JniArgumentValue (writeLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (writeData != null) {
						JNIEnv.CopyArray (native_writeData, writeData);
						JNIEnv.DeleteLocalRef (native_writeData);
					}
					global::System.GC.KeepAlive (writeData);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MemCardHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MemCardHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Stub']/constructor[@name='MemCardHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/MemCardHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/MemCardHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/MemCardHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/MemCardHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='MemCardHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.MemCardHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/MemCardHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/MemCardHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_sle4428Close_Api;
#pragma warning disable 0169
			static Delegate GetSle4428Close_ApiHandler ()
			{
				if (cb_sle4428Close_Api == null)
					cb_sle4428Close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4428Close_Api));
				return cb_sle4428Close_Api;
			}

			static int n_Sle4428Close_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4428Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428Close_Api' and count(parameter)=0]"
			[Register ("sle4428Close_Api", "()I", "GetSle4428Close_ApiHandler")]
			public abstract int Sle4428Close_Api ();

			static Delegate? cb_sle4428Open_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSle4428Open_Api_IarrayBHandler ()
			{
				if (cb_sle4428Open_Api_IarrayB == null)
					cb_sle4428Open_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sle4428Open_Api_IarrayB));
				return cb_sle4428Open_Api_IarrayB;
			}

			static int n_Sle4428Open_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428Open_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("sle4428Open_Api", "(I[B)I", "GetSle4428Open_Api_IarrayBHandler")]
			public abstract int Sle4428Open_Api (int p0, byte[]? p1);

			static Delegate? cb_sle4428ReadNoProtect_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4428ReadNoProtect_Api_IarrayBIHandler ()
			{
				if (cb_sle4428ReadNoProtect_Api_IarrayBI == null)
					cb_sle4428ReadNoProtect_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Sle4428ReadNoProtect_Api_IarrayBI));
				return cb_sle4428ReadNoProtect_Api_IarrayBI;
			}

			static int n_Sle4428ReadNoProtect_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428ReadNoProtect_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428ReadNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("sle4428ReadNoProtect_Api", "(I[BI)I", "GetSle4428ReadNoProtect_Api_IarrayBIHandler")]
			public abstract int Sle4428ReadNoProtect_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_sle4428VerifyKey_Api_BB;
#pragma warning disable 0169
			static Delegate GetSle4428VerifyKey_Api_BBHandler ()
			{
				if (cb_sle4428VerifyKey_Api_BB == null)
					cb_sle4428VerifyKey_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_Sle4428VerifyKey_Api_BB));
				return cb_sle4428VerifyKey_Api_BB;
			}

			static int n_Sle4428VerifyKey_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4428VerifyKey_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428VerifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("sle4428VerifyKey_Api", "(BB)I", "GetSle4428VerifyKey_Api_BBHandler")]
			public abstract int Sle4428VerifyKey_Api (sbyte p0, sbyte p1);

			static Delegate? cb_sle4428WriteAndCompareProtect_Api_IarrayBIB;
#pragma warning disable 0169
			static Delegate GetSle4428WriteAndCompareProtect_Api_IarrayBIBHandler ()
			{
				if (cb_sle4428WriteAndCompareProtect_Api_IarrayBIB == null)
					cb_sle4428WriteAndCompareProtect_Api_IarrayBIB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILIB_I (n_Sle4428WriteAndCompareProtect_Api_IarrayBIB));
				return cb_sle4428WriteAndCompareProtect_Api_IarrayBIB;
			}

			static int n_Sle4428WriteAndCompareProtect_Api_IarrayBIB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, sbyte p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428WriteAndCompareProtect_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428WriteAndCompareProtect_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte']]"
			[Register ("sle4428WriteAndCompareProtect_Api", "(I[BIB)I", "GetSle4428WriteAndCompareProtect_Api_IarrayBIBHandler")]
			public abstract int Sle4428WriteAndCompareProtect_Api (int p0, byte[]? p1, int p2, sbyte p3);

			static Delegate? cb_sle4428WriteNoProtect_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4428WriteNoProtect_Api_IarrayBIHandler ()
			{
				if (cb_sle4428WriteNoProtect_Api_IarrayBI == null)
					cb_sle4428WriteNoProtect_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Sle4428WriteNoProtect_Api_IarrayBI));
				return cb_sle4428WriteNoProtect_Api_IarrayBI;
			}

			static int n_Sle4428WriteNoProtect_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4428WriteNoProtect_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428WriteNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("sle4428WriteNoProtect_Api", "(I[BI)I", "GetSle4428WriteNoProtect_Api_IarrayBIHandler")]
			public abstract int Sle4428WriteNoProtect_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_sle4442Close_Api;
#pragma warning disable 0169
			static Delegate GetSle4442Close_ApiHandler ()
			{
				if (cb_sle4442Close_Api == null)
					cb_sle4442Close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4442Close_Api));
				return cb_sle4442Close_Api;
			}

			static int n_Sle4442Close_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4442Close_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Close_Api' and count(parameter)=0]"
			[Register ("sle4442Close_Api", "()I", "GetSle4442Close_ApiHandler")]
			public abstract int Sle4442Close_Api ();

			static Delegate? cb_sle4442ModifyKey_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetSle4442ModifyKey_Api_arrayBarrayBHandler ()
			{
				if (cb_sle4442ModifyKey_Api_arrayBarrayB == null)
					cb_sle4442ModifyKey_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_Sle4442ModifyKey_Api_arrayBarrayB));
				return cb_sle4442ModifyKey_Api_arrayBarrayB;
			}

			static int n_Sle4442ModifyKey_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442ModifyKey_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442ModifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("sle4442ModifyKey_Api", "([B[B)I", "GetSle4442ModifyKey_Api_arrayBarrayBHandler")]
			public abstract int Sle4442ModifyKey_Api (byte[]? p0, byte[]? p1);

			static Delegate? cb_sle4442Open_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSle4442Open_Api_IarrayBHandler ()
			{
				if (cb_sle4442Open_Api_IarrayB == null)
					cb_sle4442Open_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sle4442Open_Api_IarrayB));
				return cb_sle4442Open_Api_IarrayB;
			}

			static int n_Sle4442Open_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Open_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("sle4442Open_Api", "(I[B)I", "GetSle4442Open_Api_IarrayBHandler")]
			public abstract int Sle4442Open_Api (int p0, byte[]? p1);

			static Delegate? cb_sle4442Read_Api_BBarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4442Read_Api_BBarrayBIHandler ()
			{
				if (cb_sle4442Read_Api_BBarrayBI == null)
					cb_sle4442Read_Api_BBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLI_I (n_Sle4442Read_Api_BBarrayBI));
				return cb_sle4442Read_Api_BBarrayBI;
			}

			static int n_Sle4442Read_Api_BBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Read_Api (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Read_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("sle4442Read_Api", "(BB[BI)I", "GetSle4442Read_Api_BBarrayBIHandler")]
			public abstract int Sle4442Read_Api (sbyte p0, sbyte p1, byte[]? p2, int p3);

			static Delegate? cb_sle4442RemainCheckTime_Api;
#pragma warning disable 0169
			static Delegate GetSle4442RemainCheckTime_ApiHandler ()
			{
				if (cb_sle4442RemainCheckTime_Api == null)
					cb_sle4442RemainCheckTime_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4442RemainCheckTime_Api));
				return cb_sle4442RemainCheckTime_Api;
			}

			static int n_Sle4442RemainCheckTime_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sle4442RemainCheckTime_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442RemainCheckTime_Api' and count(parameter)=0]"
			[Register ("sle4442RemainCheckTime_Api", "()I", "GetSle4442RemainCheckTime_ApiHandler")]
			public abstract int Sle4442RemainCheckTime_Api ();

			static Delegate? cb_sle4442Verify_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetSle4442Verify_Api_arrayBHandler ()
			{
				if (cb_sle4442Verify_Api_arrayB == null)
					cb_sle4442Verify_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Sle4442Verify_Api_arrayB));
				return cb_sle4442Verify_Api_arrayB;
			}

			static int n_Sle4442Verify_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Verify_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Verify_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("sle4442Verify_Api", "([B)I", "GetSle4442Verify_Api_arrayBHandler")]
			public abstract int Sle4442Verify_Api (byte[]? p0);

			static Delegate? cb_sle4442Write_Api_BBarrayBI;
#pragma warning disable 0169
			static Delegate GetSle4442Write_Api_BBarrayBIHandler ()
			{
				if (cb_sle4442Write_Api_BBarrayBI == null)
					cb_sle4442Write_Api_BBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLI_I (n_Sle4442Write_Api_BBarrayBI));
				return cb_sle4442Write_Api_BBarrayBI;
			}

			static int n_Sle4442Write_Api_BBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sle4442Write_Api (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Write_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("sle4442Write_Api", "(BB[BI)I", "GetSle4442Write_Api_BBarrayBIHandler")]
			public abstract int Sle4442Write_Api (sbyte p0, sbyte p1, byte[]? p2, int p3);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MemCardHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MemCardHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428Close_Api' and count(parameter)=0]"
			[Register ("sle4428Close_Api", "()I", "GetSle4428Close_ApiHandler")]
			public override unsafe int Sle4428Close_Api ()
			{
				const string __id = "sle4428Close_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("sle4428Open_Api", "(I[B)I", "GetSle4428Open_Api_IarrayBHandler")]
			public override unsafe int Sle4428Open_Api (int p0, byte[]? p1)
			{
				const string __id = "sle4428Open_Api.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428ReadNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("sle4428ReadNoProtect_Api", "(I[BI)I", "GetSle4428ReadNoProtect_Api_IarrayBIHandler")]
			public override unsafe int Sle4428ReadNoProtect_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "sle4428ReadNoProtect_Api.(I[BI)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428VerifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("sle4428VerifyKey_Api", "(BB)I", "GetSle4428VerifyKey_Api_BBHandler")]
			public override unsafe int Sle4428VerifyKey_Api (sbyte p0, sbyte p1)
			{
				const string __id = "sle4428VerifyKey_Api.(BB)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428WriteAndCompareProtect_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte']]"
			[Register ("sle4428WriteAndCompareProtect_Api", "(I[BIB)I", "GetSle4428WriteAndCompareProtect_Api_IarrayBIBHandler")]
			public override unsafe int Sle4428WriteAndCompareProtect_Api (int p0, byte[]? p1, int p2, sbyte p3)
			{
				const string __id = "sle4428WriteAndCompareProtect_Api.(I[BIB)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4428WriteNoProtect_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("sle4428WriteNoProtect_Api", "(I[BI)I", "GetSle4428WriteNoProtect_Api_IarrayBIHandler")]
			public override unsafe int Sle4428WriteNoProtect_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "sle4428WriteNoProtect_Api.(I[BI)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Close_Api' and count(parameter)=0]"
			[Register ("sle4442Close_Api", "()I", "GetSle4442Close_ApiHandler")]
			public override unsafe int Sle4442Close_Api ()
			{
				const string __id = "sle4442Close_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442ModifyKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("sle4442ModifyKey_Api", "([B[B)I", "GetSle4442ModifyKey_Api_arrayBarrayBHandler")]
			public override unsafe int Sle4442ModifyKey_Api (byte[]? p0, byte[]? p1)
			{
				const string __id = "sle4442ModifyKey_Api.([B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Open_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("sle4442Open_Api", "(I[B)I", "GetSle4442Open_Api_IarrayBHandler")]
			public override unsafe int Sle4442Open_Api (int p0, byte[]? p1)
			{
				const string __id = "sle4442Open_Api.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Read_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("sle4442Read_Api", "(BB[BI)I", "GetSle4442Read_Api_BBarrayBIHandler")]
			public override unsafe int Sle4442Read_Api (sbyte p0, sbyte p1, byte[]? p2, int p3)
			{
				const string __id = "sle4442Read_Api.(BB[BI)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442RemainCheckTime_Api' and count(parameter)=0]"
			[Register ("sle4442RemainCheckTime_Api", "()I", "GetSle4442RemainCheckTime_ApiHandler")]
			public override unsafe int Sle4442RemainCheckTime_Api ()
			{
				const string __id = "sle4442RemainCheckTime_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Verify_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("sle4442Verify_Api", "([B)I", "GetSle4442Verify_Api_arrayBHandler")]
			public override unsafe int Sle4442Verify_Api (byte[]? p0)
			{
				const string __id = "sle4442Verify_Api.([B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='MemCardHandler']/method[@name='sle4442Write_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("sle4442Write_Api", "(BB[BI)I", "GetSle4442Write_Api_BBarrayBIHandler")]
			public override unsafe int Sle4442Write_Api (sbyte p0, sbyte p1, byte[]? p2, int p3)
			{
				const string __id = "sle4442Write_Api.(BB[BI)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/MemCardHandler", DoNotGenerateAcw=true)]
	internal partial class IMemCardHandlerInvoker : global::Java.Lang.Object, IMemCardHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/MemCardHandler", typeof (IMemCardHandlerInvoker));

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

		public static IMemCardHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMemCardHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.MemCardHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMemCardHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_sle4428Close_Api;
#pragma warning disable 0169
		static Delegate GetSle4428Close_ApiHandler ()
		{
			if (cb_sle4428Close_Api == null)
				cb_sle4428Close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4428Close_Api));
			return cb_sle4428Close_Api;
		}

		static int n_Sle4428Close_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Sle4428Close_Api ();
		}
#pragma warning restore 0169

		IntPtr id_sle4428Close_Api;
		public unsafe int Sle4428Close_Api ()
		{
			if (id_sle4428Close_Api == IntPtr.Zero)
				id_sle4428Close_Api = JNIEnv.GetMethodID (class_ref, "sle4428Close_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4428Close_Api);
		}

		static Delegate? cb_sle4428Open_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetSle4428Open_Api_IarrayBHandler ()
		{
			if (cb_sle4428Open_Api_IarrayB == null)
				cb_sle4428Open_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sle4428Open_Api_IarrayB));
			return cb_sle4428Open_Api_IarrayB;
		}

		static int n_Sle4428Open_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4428Open_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4428Open_Api_IarrayB;
		public unsafe int Sle4428Open_Api (int p0, byte[]? p1)
		{
			if (id_sle4428Open_Api_IarrayB == IntPtr.Zero)
				id_sle4428Open_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "sle4428Open_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4428Open_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_sle4428ReadNoProtect_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetSle4428ReadNoProtect_Api_IarrayBIHandler ()
		{
			if (cb_sle4428ReadNoProtect_Api_IarrayBI == null)
				cb_sle4428ReadNoProtect_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Sle4428ReadNoProtect_Api_IarrayBI));
			return cb_sle4428ReadNoProtect_Api_IarrayBI;
		}

		static int n_Sle4428ReadNoProtect_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4428ReadNoProtect_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4428ReadNoProtect_Api_IarrayBI;
		public unsafe int Sle4428ReadNoProtect_Api (int p0, byte[]? p1, int p2)
		{
			if (id_sle4428ReadNoProtect_Api_IarrayBI == IntPtr.Zero)
				id_sle4428ReadNoProtect_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "sle4428ReadNoProtect_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4428ReadNoProtect_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_sle4428VerifyKey_Api_BB;
#pragma warning disable 0169
		static Delegate GetSle4428VerifyKey_Api_BBHandler ()
		{
			if (cb_sle4428VerifyKey_Api_BB == null)
				cb_sle4428VerifyKey_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_Sle4428VerifyKey_Api_BB));
			return cb_sle4428VerifyKey_Api_BB;
		}

		static int n_Sle4428VerifyKey_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Sle4428VerifyKey_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sle4428VerifyKey_Api_BB;
		public unsafe int Sle4428VerifyKey_Api (sbyte p0, sbyte p1)
		{
			if (id_sle4428VerifyKey_Api_BB == IntPtr.Zero)
				id_sle4428VerifyKey_Api_BB = JNIEnv.GetMethodID (class_ref, "sle4428VerifyKey_Api", "(BB)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4428VerifyKey_Api_BB, __args);
		}

		static Delegate? cb_sle4428WriteAndCompareProtect_Api_IarrayBIB;
#pragma warning disable 0169
		static Delegate GetSle4428WriteAndCompareProtect_Api_IarrayBIBHandler ()
		{
			if (cb_sle4428WriteAndCompareProtect_Api_IarrayBIB == null)
				cb_sle4428WriteAndCompareProtect_Api_IarrayBIB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILIB_I (n_Sle4428WriteAndCompareProtect_Api_IarrayBIB));
			return cb_sle4428WriteAndCompareProtect_Api_IarrayBIB;
		}

		static int n_Sle4428WriteAndCompareProtect_Api_IarrayBIB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, sbyte p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4428WriteAndCompareProtect_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4428WriteAndCompareProtect_Api_IarrayBIB;
		public unsafe int Sle4428WriteAndCompareProtect_Api (int p0, byte[]? p1, int p2, sbyte p3)
		{
			if (id_sle4428WriteAndCompareProtect_Api_IarrayBIB == IntPtr.Zero)
				id_sle4428WriteAndCompareProtect_Api_IarrayBIB = JNIEnv.GetMethodID (class_ref, "sle4428WriteAndCompareProtect_Api", "(I[BIB)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4428WriteAndCompareProtect_Api_IarrayBIB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_sle4428WriteNoProtect_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetSle4428WriteNoProtect_Api_IarrayBIHandler ()
		{
			if (cb_sle4428WriteNoProtect_Api_IarrayBI == null)
				cb_sle4428WriteNoProtect_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_Sle4428WriteNoProtect_Api_IarrayBI));
			return cb_sle4428WriteNoProtect_Api_IarrayBI;
		}

		static int n_Sle4428WriteNoProtect_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4428WriteNoProtect_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4428WriteNoProtect_Api_IarrayBI;
		public unsafe int Sle4428WriteNoProtect_Api (int p0, byte[]? p1, int p2)
		{
			if (id_sle4428WriteNoProtect_Api_IarrayBI == IntPtr.Zero)
				id_sle4428WriteNoProtect_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "sle4428WriteNoProtect_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4428WriteNoProtect_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_sle4442Close_Api;
#pragma warning disable 0169
		static Delegate GetSle4442Close_ApiHandler ()
		{
			if (cb_sle4442Close_Api == null)
				cb_sle4442Close_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4442Close_Api));
			return cb_sle4442Close_Api;
		}

		static int n_Sle4442Close_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Sle4442Close_Api ();
		}
#pragma warning restore 0169

		IntPtr id_sle4442Close_Api;
		public unsafe int Sle4442Close_Api ()
		{
			if (id_sle4442Close_Api == IntPtr.Zero)
				id_sle4442Close_Api = JNIEnv.GetMethodID (class_ref, "sle4442Close_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4442Close_Api);
		}

		static Delegate? cb_sle4442ModifyKey_Api_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSle4442ModifyKey_Api_arrayBarrayBHandler ()
		{
			if (cb_sle4442ModifyKey_Api_arrayBarrayB == null)
				cb_sle4442ModifyKey_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_Sle4442ModifyKey_Api_arrayBarrayB));
			return cb_sle4442ModifyKey_Api_arrayBarrayB;
		}

		static int n_Sle4442ModifyKey_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4442ModifyKey_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4442ModifyKey_Api_arrayBarrayB;
		public unsafe int Sle4442ModifyKey_Api (byte[]? p0, byte[]? p1)
		{
			if (id_sle4442ModifyKey_Api_arrayBarrayB == IntPtr.Zero)
				id_sle4442ModifyKey_Api_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "sle4442ModifyKey_Api", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4442ModifyKey_Api_arrayBarrayB, __args);
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

		static Delegate? cb_sle4442Open_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetSle4442Open_Api_IarrayBHandler ()
		{
			if (cb_sle4442Open_Api_IarrayB == null)
				cb_sle4442Open_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sle4442Open_Api_IarrayB));
			return cb_sle4442Open_Api_IarrayB;
		}

		static int n_Sle4442Open_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4442Open_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4442Open_Api_IarrayB;
		public unsafe int Sle4442Open_Api (int p0, byte[]? p1)
		{
			if (id_sle4442Open_Api_IarrayB == IntPtr.Zero)
				id_sle4442Open_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "sle4442Open_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4442Open_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_sle4442Read_Api_BBarrayBI;
#pragma warning disable 0169
		static Delegate GetSle4442Read_Api_BBarrayBIHandler ()
		{
			if (cb_sle4442Read_Api_BBarrayBI == null)
				cb_sle4442Read_Api_BBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLI_I (n_Sle4442Read_Api_BBarrayBI));
			return cb_sle4442Read_Api_BBarrayBI;
		}

		static int n_Sle4442Read_Api_BBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4442Read_Api (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4442Read_Api_BBarrayBI;
		public unsafe int Sle4442Read_Api (sbyte p0, sbyte p1, byte[]? p2, int p3)
		{
			if (id_sle4442Read_Api_BBarrayBI == IntPtr.Zero)
				id_sle4442Read_Api_BBarrayBI = JNIEnv.GetMethodID (class_ref, "sle4442Read_Api", "(BB[BI)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4442Read_Api_BBarrayBI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_sle4442RemainCheckTime_Api;
#pragma warning disable 0169
		static Delegate GetSle4442RemainCheckTime_ApiHandler ()
		{
			if (cb_sle4442RemainCheckTime_Api == null)
				cb_sle4442RemainCheckTime_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Sle4442RemainCheckTime_Api));
			return cb_sle4442RemainCheckTime_Api;
		}

		static int n_Sle4442RemainCheckTime_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Sle4442RemainCheckTime_Api ();
		}
#pragma warning restore 0169

		IntPtr id_sle4442RemainCheckTime_Api;
		public unsafe int Sle4442RemainCheckTime_Api ()
		{
			if (id_sle4442RemainCheckTime_Api == IntPtr.Zero)
				id_sle4442RemainCheckTime_Api = JNIEnv.GetMethodID (class_ref, "sle4442RemainCheckTime_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4442RemainCheckTime_Api);
		}

		static Delegate? cb_sle4442Verify_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetSle4442Verify_Api_arrayBHandler ()
		{
			if (cb_sle4442Verify_Api_arrayB == null)
				cb_sle4442Verify_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Sle4442Verify_Api_arrayB));
			return cb_sle4442Verify_Api_arrayB;
		}

		static int n_Sle4442Verify_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4442Verify_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4442Verify_Api_arrayB;
		public unsafe int Sle4442Verify_Api (byte[]? p0)
		{
			if (id_sle4442Verify_Api_arrayB == IntPtr.Zero)
				id_sle4442Verify_Api_arrayB = JNIEnv.GetMethodID (class_ref, "sle4442Verify_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4442Verify_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_sle4442Write_Api_BBarrayBI;
#pragma warning disable 0169
		static Delegate GetSle4442Write_Api_BBarrayBIHandler ()
		{
			if (cb_sle4442Write_Api_BBarrayBI == null)
				cb_sle4442Write_Api_BBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLI_I (n_Sle4442Write_Api_BBarrayBI));
			return cb_sle4442Write_Api_BBarrayBI;
		}

		static int n_Sle4442Write_Api_BBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sle4442Write_Api (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sle4442Write_Api_BBarrayBI;
		public unsafe int Sle4442Write_Api (sbyte p0, sbyte p1, byte[]? p2, int p3)
		{
			if (id_sle4442Write_Api_BBarrayBI == IntPtr.Zero)
				id_sle4442Write_Api_BBarrayBI = JNIEnv.GetMethodID (class_ref, "sle4442Write_Api", "(BB[BI)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sle4442Write_Api_BBarrayBI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IMemCardHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
