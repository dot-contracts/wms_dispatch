using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Fiscal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']"
	[Register ("com/vanstone/appsdk/api/fiscal/FiscalHandler", "", "Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker")]
	public partial interface IFiscalHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalAuth_Api' and count(parameter)=0]"
		[Register ("FiscalAuth_Api", "()I", "GetFiscalAuth_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalAuth_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalBindServer_Api' and count(parameter)=0]"
		[Register ("FiscalBindServer_Api", "()I", "GetFiscalBindServer_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalBindServer_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalCloseDatabase_Api' and count(parameter)=0]"
		[Register ("FiscalCloseDatabase_Api", "()I", "GetFiscalCloseDatabase_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalCloseDatabase_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordCheck_Api' and count(parameter)=0]"
		[Register ("FiscalDBRecordCheck_Api", "()I", "GetFiscalDBRecordCheck_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalDBRecordCheck_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordClose_Api' and count(parameter)=0]"
		[Register ("FiscalDBRecordClose_Api", "()I", "GetFiscalDBRecordClose_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalDBRecordClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordOpen_Api' and count(parameter)=0]"
		[Register ("FiscalDBRecordOpen_Api", "()I", "GetFiscalDBRecordOpen_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalDBRecordOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordRead_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("FiscalDBRecordRead_Api", "(I[I[B[I)I", "GetFiscalDBRecordRead_Api_IarrayIarrayBarrayIHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalDBRecordRead_Api (int p0, int[]? p1, byte[]? p2, int[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetFreeDiskSpace_Api' and count(parameter)=0]"
		[Register ("FiscalGetFreeDiskSpace_Api", "()J", "GetFiscalGetFreeDiskSpace_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		long FiscalGetFreeDiskSpace_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetHdVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("FiscalGetHdVersion_Api", "([B)I", "GetFiscalGetHdVersion_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalGetHdVersion_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetIdkey_Api' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("FiscalGetIdkey_Api", "(JI)I", "GetFiscalGetIdkey_Api_JIHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalGetIdkey_Api (long p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetIds_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("FiscalGetIds_Api", "(III[B)I", "GetFiscalGetIds_Api_IIIarrayBHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalGetIds_Api (int p0, int p1, int p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetSoftVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("FiscalGetSoftVersion_Api", "([B)I", "GetFiscalGetSoftVersion_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalGetSoftVersion_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetSysSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("FiscalGetSysSN_Api", "([B)I", "GetFiscalGetSysSN_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalGetSysSN_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetTotalRow_Api' and count(parameter)=0]"
		[Register ("FiscalGetTotalRow_Api", "()I", "GetFiscalGetTotalRow_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalGetTotalRow_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalOpenDatabase_Api' and count(parameter)=0]"
		[Register ("FiscalOpenDatabase_Api", "()I", "GetFiscalOpenDatabase_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalOpenDatabase_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalPowerOff_Api' and count(parameter)=0]"
		[Register ("FiscalPowerOff_Api", "()I", "GetFiscalPowerOff_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalPowerOff_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalPowerOn_Api' and count(parameter)=0]"
		[Register ("FiscalPowerOn_Api", "()I", "GetFiscalPowerOn_ApiHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalPowerOn_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalReadDataById_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("FiscalReadDataById_Api", "(I[B)I", "GetFiscalReadDataById_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalReadDataById_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalReadWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("FiscalReadWormFlashData_Api", "(JJLjava/lang/String;)Z", "GetFiscalReadWormFlashData_Api_JJLjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		bool FiscalReadWormFlashData_Api (long p0, long p1, string? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalUpdateServer_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("FiscalUpdateServer_Api", "([BI)I", "GetFiscalUpdateServer_Api_arrayBIHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalUpdateServer_Api (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalWriteDataById_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
		[Register ("FiscalWriteDataById_Api", "(I[BJ)I", "GetFiscalWriteDataById_Api_IarrayBJHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		int FiscalWriteDataById_Api (int p0, byte[]? p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalWriteWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
		[Register ("FiscalWriteWormFlashData_Api", "(J[BJ)J", "GetFiscalWriteWormFlashData_Api_JarrayBJHandler:Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandlerInvoker, VanstonePosSdk")]
		long FiscalWriteWormFlashData_Api (long p0, byte[]? p1, long p2);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/fiscal/FiscalHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/fiscal/FiscalHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/constructor[@name='FiscalHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_FiscalAuth_Api;
#pragma warning disable 0169
			static Delegate GetFiscalAuth_ApiHandler ()
			{
				if (cb_FiscalAuth_Api == null)
					cb_FiscalAuth_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalAuth_Api));
				return cb_FiscalAuth_Api;
			}

			static int n_FiscalAuth_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalAuth_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalAuth_Api' and count(parameter)=0]"
			[Register ("FiscalAuth_Api", "()I", "GetFiscalAuth_ApiHandler")]
			public virtual unsafe int FiscalAuth_Api ()
			{
				const string __id = "FiscalAuth_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalBindServer_Api;
#pragma warning disable 0169
			static Delegate GetFiscalBindServer_ApiHandler ()
			{
				if (cb_FiscalBindServer_Api == null)
					cb_FiscalBindServer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalBindServer_Api));
				return cb_FiscalBindServer_Api;
			}

			static int n_FiscalBindServer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalBindServer_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalBindServer_Api' and count(parameter)=0]"
			[Register ("FiscalBindServer_Api", "()I", "GetFiscalBindServer_ApiHandler")]
			public virtual unsafe int FiscalBindServer_Api ()
			{
				const string __id = "FiscalBindServer_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalCloseDatabase_Api;
#pragma warning disable 0169
			static Delegate GetFiscalCloseDatabase_ApiHandler ()
			{
				if (cb_FiscalCloseDatabase_Api == null)
					cb_FiscalCloseDatabase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalCloseDatabase_Api));
				return cb_FiscalCloseDatabase_Api;
			}

			static int n_FiscalCloseDatabase_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalCloseDatabase_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalCloseDatabase_Api' and count(parameter)=0]"
			[Register ("FiscalCloseDatabase_Api", "()I", "GetFiscalCloseDatabase_ApiHandler")]
			public virtual unsafe int FiscalCloseDatabase_Api ()
			{
				const string __id = "FiscalCloseDatabase_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalDBRecordCheck_Api;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordCheck_ApiHandler ()
			{
				if (cb_FiscalDBRecordCheck_Api == null)
					cb_FiscalDBRecordCheck_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordCheck_Api));
				return cb_FiscalDBRecordCheck_Api;
			}

			static int n_FiscalDBRecordCheck_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalDBRecordCheck_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalDBRecordCheck_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordCheck_Api", "()I", "GetFiscalDBRecordCheck_ApiHandler")]
			public virtual unsafe int FiscalDBRecordCheck_Api ()
			{
				const string __id = "FiscalDBRecordCheck_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalDBRecordClose_Api;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordClose_ApiHandler ()
			{
				if (cb_FiscalDBRecordClose_Api == null)
					cb_FiscalDBRecordClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordClose_Api));
				return cb_FiscalDBRecordClose_Api;
			}

			static int n_FiscalDBRecordClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalDBRecordClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalDBRecordClose_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordClose_Api", "()I", "GetFiscalDBRecordClose_ApiHandler")]
			public virtual unsafe int FiscalDBRecordClose_Api ()
			{
				const string __id = "FiscalDBRecordClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalDBRecordOpen_Api;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordOpen_ApiHandler ()
			{
				if (cb_FiscalDBRecordOpen_Api == null)
					cb_FiscalDBRecordOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordOpen_Api));
				return cb_FiscalDBRecordOpen_Api;
			}

			static int n_FiscalDBRecordOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalDBRecordOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalDBRecordOpen_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordOpen_Api", "()I", "GetFiscalDBRecordOpen_ApiHandler")]
			public virtual unsafe int FiscalDBRecordOpen_Api ()
			{
				const string __id = "FiscalDBRecordOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordRead_Api_IarrayIarrayBarrayIHandler ()
			{
				if (cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI == null)
					cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_FiscalDBRecordRead_Api_IarrayIarrayBarrayI));
				return cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI;
			}

			static int n_FiscalDBRecordRead_Api_IarrayIarrayBarrayI (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_lenOfPkey, IntPtr native_buf, IntPtr native_lenOfBuf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var lenOfPkey = (int[]?) JNIEnv.GetArray (native_lenOfPkey, JniHandleOwnership.DoNotTransfer, typeof (int));
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var lenOfBuf = (int[]?) JNIEnv.GetArray (native_lenOfBuf, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.FiscalDBRecordRead_Api (index, lenOfPkey, buf, lenOfBuf);
				if (lenOfPkey != null)
					JNIEnv.CopyArray (lenOfPkey, native_lenOfPkey);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				if (lenOfBuf != null)
					JNIEnv.CopyArray (lenOfBuf, native_lenOfBuf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalDBRecordRead_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
			[Register ("FiscalDBRecordRead_Api", "(I[I[B[I)I", "GetFiscalDBRecordRead_Api_IarrayIarrayBarrayIHandler")]
			public virtual unsafe int FiscalDBRecordRead_Api (int index, int[]? lenOfPkey, byte[]? buf, int[]? lenOfBuf)
			{
				const string __id = "FiscalDBRecordRead_Api.(I[I[B[I)I";
				IntPtr native_lenOfPkey = JNIEnv.NewArray (lenOfPkey);
				IntPtr native_buf = JNIEnv.NewArray (buf);
				IntPtr native_lenOfBuf = JNIEnv.NewArray (lenOfBuf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (native_lenOfPkey);
					__args [2] = new JniArgumentValue (native_buf);
					__args [3] = new JniArgumentValue (native_lenOfBuf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (lenOfPkey != null) {
						JNIEnv.CopyArray (native_lenOfPkey, lenOfPkey);
						JNIEnv.DeleteLocalRef (native_lenOfPkey);
					}
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					if (lenOfBuf != null) {
						JNIEnv.CopyArray (native_lenOfBuf, lenOfBuf);
						JNIEnv.DeleteLocalRef (native_lenOfBuf);
					}
					global::System.GC.KeepAlive (lenOfPkey);
					global::System.GC.KeepAlive (buf);
					global::System.GC.KeepAlive (lenOfBuf);
				}
			}

			static Delegate? cb_FiscalGetFreeDiskSpace_Api;
#pragma warning disable 0169
			static Delegate GetFiscalGetFreeDiskSpace_ApiHandler ()
			{
				if (cb_FiscalGetFreeDiskSpace_Api == null)
					cb_FiscalGetFreeDiskSpace_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_FiscalGetFreeDiskSpace_Api));
				return cb_FiscalGetFreeDiskSpace_Api;
			}

			static long n_FiscalGetFreeDiskSpace_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalGetFreeDiskSpace_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalGetFreeDiskSpace_Api' and count(parameter)=0]"
			[Register ("FiscalGetFreeDiskSpace_Api", "()J", "GetFiscalGetFreeDiskSpace_ApiHandler")]
			public virtual unsafe long FiscalGetFreeDiskSpace_Api ()
			{
				const string __id = "FiscalGetFreeDiskSpace_Api.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalGetHdVersion_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetHdVersion_Api_arrayBHandler ()
			{
				if (cb_FiscalGetHdVersion_Api_arrayB == null)
					cb_FiscalGetHdVersion_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetHdVersion_Api_arrayB));
				return cb_FiscalGetHdVersion_Api_arrayB;
			}

			static int n_FiscalGetHdVersion_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetHdVersion_Api (data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalGetHdVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetHdVersion_Api", "([B)I", "GetFiscalGetHdVersion_Api_arrayBHandler")]
			public virtual unsafe int FiscalGetHdVersion_Api (byte[]? data)
			{
				const string __id = "FiscalGetHdVersion_Api.([B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_data);
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

			static Delegate? cb_FiscalGetIdkey_Api_JI;
#pragma warning disable 0169
			static Delegate GetFiscalGetIdkey_Api_JIHandler ()
			{
				if (cb_FiscalGetIdkey_Api_JI == null)
					cb_FiscalGetIdkey_Api_JI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJI_I (n_FiscalGetIdkey_Api_JI));
				return cb_FiscalGetIdkey_Api_JI;
			}

			static int n_FiscalGetIdkey_Api_JI (IntPtr jnienv, IntPtr native__this, long datetime, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalGetIdkey_Api (datetime, index);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalGetIdkey_Api' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
			[Register ("FiscalGetIdkey_Api", "(JI)I", "GetFiscalGetIdkey_Api_JIHandler")]
			public virtual unsafe int FiscalGetIdkey_Api (long datetime, int index)
			{
				const string __id = "FiscalGetIdkey_Api.(JI)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (datetime);
					__args [1] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalGetIds_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetIds_Api_IIIarrayBHandler ()
			{
				if (cb_FiscalGetIds_Api_IIIarrayB == null)
					cb_FiscalGetIds_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_FiscalGetIds_Api_IIIarrayB));
				return cb_FiscalGetIds_Api_IIIarrayB;
			}

			static int n_FiscalGetIds_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int startid, int endid, int count, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetIds_Api (startid, endid, count, data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalGetIds_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("FiscalGetIds_Api", "(III[B)I", "GetFiscalGetIds_Api_IIIarrayBHandler")]
			public virtual unsafe int FiscalGetIds_Api (int startid, int endid, int count, byte[]? data)
			{
				const string __id = "FiscalGetIds_Api.(III[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (startid);
					__args [1] = new JniArgumentValue (endid);
					__args [2] = new JniArgumentValue (count);
					__args [3] = new JniArgumentValue (native_data);
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

			static Delegate? cb_FiscalGetSoftVersion_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetSoftVersion_Api_arrayBHandler ()
			{
				if (cb_FiscalGetSoftVersion_Api_arrayB == null)
					cb_FiscalGetSoftVersion_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetSoftVersion_Api_arrayB));
				return cb_FiscalGetSoftVersion_Api_arrayB;
			}

			static int n_FiscalGetSoftVersion_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetSoftVersion_Api (data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalGetSoftVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetSoftVersion_Api", "([B)I", "GetFiscalGetSoftVersion_Api_arrayBHandler")]
			public virtual unsafe int FiscalGetSoftVersion_Api (byte[]? data)
			{
				const string __id = "FiscalGetSoftVersion_Api.([B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_data);
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

			static Delegate? cb_FiscalGetSysSN_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetSysSN_Api_arrayBHandler ()
			{
				if (cb_FiscalGetSysSN_Api_arrayB == null)
					cb_FiscalGetSysSN_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetSysSN_Api_arrayB));
				return cb_FiscalGetSysSN_Api_arrayB;
			}

			static int n_FiscalGetSysSN_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_sn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var sn = (byte[]?) JNIEnv.GetArray (native_sn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetSysSN_Api (sn);
				if (sn != null)
					JNIEnv.CopyArray (sn, native_sn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalGetSysSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetSysSN_Api", "([B)I", "GetFiscalGetSysSN_Api_arrayBHandler")]
			public virtual unsafe int FiscalGetSysSN_Api (byte[]? sn)
			{
				const string __id = "FiscalGetSysSN_Api.([B)I";
				IntPtr native_sn = JNIEnv.NewArray (sn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_sn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (sn != null) {
						JNIEnv.CopyArray (native_sn, sn);
						JNIEnv.DeleteLocalRef (native_sn);
					}
					global::System.GC.KeepAlive (sn);
				}
			}

			static Delegate? cb_FiscalGetTotalRow_Api;
#pragma warning disable 0169
			static Delegate GetFiscalGetTotalRow_ApiHandler ()
			{
				if (cb_FiscalGetTotalRow_Api == null)
					cb_FiscalGetTotalRow_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalGetTotalRow_Api));
				return cb_FiscalGetTotalRow_Api;
			}

			static int n_FiscalGetTotalRow_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalGetTotalRow_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalGetTotalRow_Api' and count(parameter)=0]"
			[Register ("FiscalGetTotalRow_Api", "()I", "GetFiscalGetTotalRow_ApiHandler")]
			public virtual unsafe int FiscalGetTotalRow_Api ()
			{
				const string __id = "FiscalGetTotalRow_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalOpenDatabase_Api;
#pragma warning disable 0169
			static Delegate GetFiscalOpenDatabase_ApiHandler ()
			{
				if (cb_FiscalOpenDatabase_Api == null)
					cb_FiscalOpenDatabase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalOpenDatabase_Api));
				return cb_FiscalOpenDatabase_Api;
			}

			static int n_FiscalOpenDatabase_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalOpenDatabase_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalOpenDatabase_Api' and count(parameter)=0]"
			[Register ("FiscalOpenDatabase_Api", "()I", "GetFiscalOpenDatabase_ApiHandler")]
			public virtual unsafe int FiscalOpenDatabase_Api ()
			{
				const string __id = "FiscalOpenDatabase_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalPowerOff_Api;
#pragma warning disable 0169
			static Delegate GetFiscalPowerOff_ApiHandler ()
			{
				if (cb_FiscalPowerOff_Api == null)
					cb_FiscalPowerOff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalPowerOff_Api));
				return cb_FiscalPowerOff_Api;
			}

			static int n_FiscalPowerOff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalPowerOff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalPowerOff_Api' and count(parameter)=0]"
			[Register ("FiscalPowerOff_Api", "()I", "GetFiscalPowerOff_ApiHandler")]
			public virtual unsafe int FiscalPowerOff_Api ()
			{
				const string __id = "FiscalPowerOff_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalPowerOn_Api;
#pragma warning disable 0169
			static Delegate GetFiscalPowerOn_ApiHandler ()
			{
				if (cb_FiscalPowerOn_Api == null)
					cb_FiscalPowerOn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalPowerOn_Api));
				return cb_FiscalPowerOn_Api;
			}

			static int n_FiscalPowerOn_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalPowerOn_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalPowerOn_Api' and count(parameter)=0]"
			[Register ("FiscalPowerOn_Api", "()I", "GetFiscalPowerOn_ApiHandler")]
			public virtual unsafe int FiscalPowerOn_Api ()
			{
				const string __id = "FiscalPowerOn_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalReadDataById_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetFiscalReadDataById_Api_IarrayBHandler ()
			{
				if (cb_FiscalReadDataById_Api_IarrayB == null)
					cb_FiscalReadDataById_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FiscalReadDataById_Api_IarrayB));
				return cb_FiscalReadDataById_Api_IarrayB;
			}

			static int n_FiscalReadDataById_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalReadDataById_Api (index, data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalReadDataById_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("FiscalReadDataById_Api", "(I[B)I", "GetFiscalReadDataById_Api_IarrayBHandler")]
			public virtual unsafe int FiscalReadDataById_Api (int index, byte[]? data)
			{
				const string __id = "FiscalReadDataById_Api.(I[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (native_data);
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

			static Delegate? cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFiscalReadWormFlashData_Api_JJLjava_lang_String_Handler ()
			{
				if (cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_ == null)
					cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJL_Z (n_FiscalReadWormFlashData_Api_JJLjava_lang_String_));
				return cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_;
			}

			static bool n_FiscalReadWormFlashData_Api_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long startdate, long enddate, IntPtr native_filename)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.FiscalReadWormFlashData_Api (startdate, enddate, filename);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalReadWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
			[Register ("FiscalReadWormFlashData_Api", "(JJLjava/lang/String;)Z", "GetFiscalReadWormFlashData_Api_JJLjava_lang_String_Handler")]
			public virtual unsafe bool FiscalReadWormFlashData_Api (long startdate, long enddate, string? filename)
			{
				const string __id = "FiscalReadWormFlashData_Api.(JJLjava/lang/String;)Z";
				IntPtr native_filename = JNIEnv.NewString ((string?)filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (startdate);
					__args [1] = new JniArgumentValue (enddate);
					__args [2] = new JniArgumentValue (native_filename);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

			static Delegate? cb_FiscalUpdateServer_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetFiscalUpdateServer_Api_arrayBIHandler ()
			{
				if (cb_FiscalUpdateServer_Api_arrayBI == null)
					cb_FiscalUpdateServer_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_FiscalUpdateServer_Api_arrayBI));
				return cb_FiscalUpdateServer_Api_arrayBI;
			}

			static int n_FiscalUpdateServer_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, int filenamelength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var filename = (byte[]?) JNIEnv.GetArray (native_filename, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalUpdateServer_Api (filename, filenamelength);
				if (filename != null)
					JNIEnv.CopyArray (filename, native_filename);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalUpdateServer_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("FiscalUpdateServer_Api", "([BI)I", "GetFiscalUpdateServer_Api_arrayBIHandler")]
			public virtual unsafe int FiscalUpdateServer_Api (byte[]? filename, int filenamelength)
			{
				const string __id = "FiscalUpdateServer_Api.([BI)I";
				IntPtr native_filename = JNIEnv.NewArray (filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_filename);
					__args [1] = new JniArgumentValue (filenamelength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (filename != null) {
						JNIEnv.CopyArray (native_filename, filename);
						JNIEnv.DeleteLocalRef (native_filename);
					}
					global::System.GC.KeepAlive (filename);
				}
			}

			static Delegate? cb_FiscalWriteDataById_Api_IarrayBJ;
#pragma warning disable 0169
			static Delegate GetFiscalWriteDataById_Api_IarrayBJHandler ()
			{
				if (cb_FiscalWriteDataById_Api_IarrayBJ == null)
					cb_FiscalWriteDataById_Api_IarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILJ_I (n_FiscalWriteDataById_Api_IarrayBJ));
				return cb_FiscalWriteDataById_Api_IarrayBJ;
			}

			static int n_FiscalWriteDataById_Api_IarrayBJ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_data, long datalength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalWriteDataById_Api (index, data, datalength);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalWriteDataById_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("FiscalWriteDataById_Api", "(I[BJ)I", "GetFiscalWriteDataById_Api_IarrayBJHandler")]
			public virtual unsafe int FiscalWriteDataById_Api (int index, byte[]? data, long datalength)
			{
				const string __id = "FiscalWriteDataById_Api.(I[BJ)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (datalength);
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

			static Delegate? cb_FiscalWriteWormFlashData_Api_JarrayBJ;
#pragma warning disable 0169
			static Delegate GetFiscalWriteWormFlashData_Api_JarrayBJHandler ()
			{
				if (cb_FiscalWriteWormFlashData_Api_JarrayBJ == null)
					cb_FiscalWriteWormFlashData_Api_JarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJLJ_J (n_FiscalWriteWormFlashData_Api_JarrayBJ));
				return cb_FiscalWriteWormFlashData_Api_JarrayBJ;
			}

			static long n_FiscalWriteWormFlashData_Api_JarrayBJ (IntPtr jnienv, IntPtr native__this, long datetime, IntPtr native_data, long datalength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				long __ret = __this.FiscalWriteWormFlashData_Api (datetime, data, datalength);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='FiscalWriteWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("FiscalWriteWormFlashData_Api", "(J[BJ)J", "GetFiscalWriteWormFlashData_Api_JarrayBJHandler")]
			public virtual unsafe long FiscalWriteWormFlashData_Api (long datetime, byte[]? data, long datalength)
			{
				const string __id = "FiscalWriteWormFlashData_Api.(J[BJ)J";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (datetime);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (datalength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/fiscal/FiscalHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/fiscal/FiscalHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Stub']/constructor[@name='FiscalHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/class[@name='FiscalHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.fiscal.FiscalHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/fiscal/FiscalHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_FiscalAuth_Api;
#pragma warning disable 0169
			static Delegate GetFiscalAuth_ApiHandler ()
			{
				if (cb_FiscalAuth_Api == null)
					cb_FiscalAuth_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalAuth_Api));
				return cb_FiscalAuth_Api;
			}

			static int n_FiscalAuth_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalAuth_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalAuth_Api' and count(parameter)=0]"
			[Register ("FiscalAuth_Api", "()I", "GetFiscalAuth_ApiHandler")]
			public abstract int FiscalAuth_Api ();

			static Delegate? cb_FiscalBindServer_Api;
#pragma warning disable 0169
			static Delegate GetFiscalBindServer_ApiHandler ()
			{
				if (cb_FiscalBindServer_Api == null)
					cb_FiscalBindServer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalBindServer_Api));
				return cb_FiscalBindServer_Api;
			}

			static int n_FiscalBindServer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalBindServer_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalBindServer_Api' and count(parameter)=0]"
			[Register ("FiscalBindServer_Api", "()I", "GetFiscalBindServer_ApiHandler")]
			public abstract int FiscalBindServer_Api ();

			static Delegate? cb_FiscalCloseDatabase_Api;
#pragma warning disable 0169
			static Delegate GetFiscalCloseDatabase_ApiHandler ()
			{
				if (cb_FiscalCloseDatabase_Api == null)
					cb_FiscalCloseDatabase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalCloseDatabase_Api));
				return cb_FiscalCloseDatabase_Api;
			}

			static int n_FiscalCloseDatabase_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalCloseDatabase_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalCloseDatabase_Api' and count(parameter)=0]"
			[Register ("FiscalCloseDatabase_Api", "()I", "GetFiscalCloseDatabase_ApiHandler")]
			public abstract int FiscalCloseDatabase_Api ();

			static Delegate? cb_FiscalDBRecordCheck_Api;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordCheck_ApiHandler ()
			{
				if (cb_FiscalDBRecordCheck_Api == null)
					cb_FiscalDBRecordCheck_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordCheck_Api));
				return cb_FiscalDBRecordCheck_Api;
			}

			static int n_FiscalDBRecordCheck_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalDBRecordCheck_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordCheck_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordCheck_Api", "()I", "GetFiscalDBRecordCheck_ApiHandler")]
			public abstract int FiscalDBRecordCheck_Api ();

			static Delegate? cb_FiscalDBRecordClose_Api;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordClose_ApiHandler ()
			{
				if (cb_FiscalDBRecordClose_Api == null)
					cb_FiscalDBRecordClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordClose_Api));
				return cb_FiscalDBRecordClose_Api;
			}

			static int n_FiscalDBRecordClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalDBRecordClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordClose_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordClose_Api", "()I", "GetFiscalDBRecordClose_ApiHandler")]
			public abstract int FiscalDBRecordClose_Api ();

			static Delegate? cb_FiscalDBRecordOpen_Api;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordOpen_ApiHandler ()
			{
				if (cb_FiscalDBRecordOpen_Api == null)
					cb_FiscalDBRecordOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordOpen_Api));
				return cb_FiscalDBRecordOpen_Api;
			}

			static int n_FiscalDBRecordOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalDBRecordOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordOpen_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordOpen_Api", "()I", "GetFiscalDBRecordOpen_ApiHandler")]
			public abstract int FiscalDBRecordOpen_Api ();

			static Delegate? cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI;
#pragma warning disable 0169
			static Delegate GetFiscalDBRecordRead_Api_IarrayIarrayBarrayIHandler ()
			{
				if (cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI == null)
					cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_FiscalDBRecordRead_Api_IarrayIarrayBarrayI));
				return cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI;
			}

			static int n_FiscalDBRecordRead_Api_IarrayIarrayBarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (int[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (int[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.FiscalDBRecordRead_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordRead_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
			[Register ("FiscalDBRecordRead_Api", "(I[I[B[I)I", "GetFiscalDBRecordRead_Api_IarrayIarrayBarrayIHandler")]
			public abstract int FiscalDBRecordRead_Api (int p0, int[]? p1, byte[]? p2, int[]? p3);

			static Delegate? cb_FiscalGetFreeDiskSpace_Api;
#pragma warning disable 0169
			static Delegate GetFiscalGetFreeDiskSpace_ApiHandler ()
			{
				if (cb_FiscalGetFreeDiskSpace_Api == null)
					cb_FiscalGetFreeDiskSpace_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_FiscalGetFreeDiskSpace_Api));
				return cb_FiscalGetFreeDiskSpace_Api;
			}

			static long n_FiscalGetFreeDiskSpace_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalGetFreeDiskSpace_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetFreeDiskSpace_Api' and count(parameter)=0]"
			[Register ("FiscalGetFreeDiskSpace_Api", "()J", "GetFiscalGetFreeDiskSpace_ApiHandler")]
			public abstract long FiscalGetFreeDiskSpace_Api ();

			static Delegate? cb_FiscalGetHdVersion_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetHdVersion_Api_arrayBHandler ()
			{
				if (cb_FiscalGetHdVersion_Api_arrayB == null)
					cb_FiscalGetHdVersion_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetHdVersion_Api_arrayB));
				return cb_FiscalGetHdVersion_Api_arrayB;
			}

			static int n_FiscalGetHdVersion_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetHdVersion_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetHdVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetHdVersion_Api", "([B)I", "GetFiscalGetHdVersion_Api_arrayBHandler")]
			public abstract int FiscalGetHdVersion_Api (byte[]? p0);

			static Delegate? cb_FiscalGetIdkey_Api_JI;
#pragma warning disable 0169
			static Delegate GetFiscalGetIdkey_Api_JIHandler ()
			{
				if (cb_FiscalGetIdkey_Api_JI == null)
					cb_FiscalGetIdkey_Api_JI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJI_I (n_FiscalGetIdkey_Api_JI));
				return cb_FiscalGetIdkey_Api_JI;
			}

			static int n_FiscalGetIdkey_Api_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalGetIdkey_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetIdkey_Api' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
			[Register ("FiscalGetIdkey_Api", "(JI)I", "GetFiscalGetIdkey_Api_JIHandler")]
			public abstract int FiscalGetIdkey_Api (long p0, int p1);

			static Delegate? cb_FiscalGetIds_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetIds_Api_IIIarrayBHandler ()
			{
				if (cb_FiscalGetIds_Api_IIIarrayB == null)
					cb_FiscalGetIds_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_FiscalGetIds_Api_IIIarrayB));
				return cb_FiscalGetIds_Api_IIIarrayB;
			}

			static int n_FiscalGetIds_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetIds_Api (p0, p1, p2, p3);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetIds_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("FiscalGetIds_Api", "(III[B)I", "GetFiscalGetIds_Api_IIIarrayBHandler")]
			public abstract int FiscalGetIds_Api (int p0, int p1, int p2, byte[]? p3);

			static Delegate? cb_FiscalGetSoftVersion_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetSoftVersion_Api_arrayBHandler ()
			{
				if (cb_FiscalGetSoftVersion_Api_arrayB == null)
					cb_FiscalGetSoftVersion_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetSoftVersion_Api_arrayB));
				return cb_FiscalGetSoftVersion_Api_arrayB;
			}

			static int n_FiscalGetSoftVersion_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetSoftVersion_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetSoftVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetSoftVersion_Api", "([B)I", "GetFiscalGetSoftVersion_Api_arrayBHandler")]
			public abstract int FiscalGetSoftVersion_Api (byte[]? p0);

			static Delegate? cb_FiscalGetSysSN_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetFiscalGetSysSN_Api_arrayBHandler ()
			{
				if (cb_FiscalGetSysSN_Api_arrayB == null)
					cb_FiscalGetSysSN_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetSysSN_Api_arrayB));
				return cb_FiscalGetSysSN_Api_arrayB;
			}

			static int n_FiscalGetSysSN_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalGetSysSN_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetSysSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetSysSN_Api", "([B)I", "GetFiscalGetSysSN_Api_arrayBHandler")]
			public abstract int FiscalGetSysSN_Api (byte[]? p0);

			static Delegate? cb_FiscalGetTotalRow_Api;
#pragma warning disable 0169
			static Delegate GetFiscalGetTotalRow_ApiHandler ()
			{
				if (cb_FiscalGetTotalRow_Api == null)
					cb_FiscalGetTotalRow_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalGetTotalRow_Api));
				return cb_FiscalGetTotalRow_Api;
			}

			static int n_FiscalGetTotalRow_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalGetTotalRow_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetTotalRow_Api' and count(parameter)=0]"
			[Register ("FiscalGetTotalRow_Api", "()I", "GetFiscalGetTotalRow_ApiHandler")]
			public abstract int FiscalGetTotalRow_Api ();

			static Delegate? cb_FiscalOpenDatabase_Api;
#pragma warning disable 0169
			static Delegate GetFiscalOpenDatabase_ApiHandler ()
			{
				if (cb_FiscalOpenDatabase_Api == null)
					cb_FiscalOpenDatabase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalOpenDatabase_Api));
				return cb_FiscalOpenDatabase_Api;
			}

			static int n_FiscalOpenDatabase_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalOpenDatabase_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalOpenDatabase_Api' and count(parameter)=0]"
			[Register ("FiscalOpenDatabase_Api", "()I", "GetFiscalOpenDatabase_ApiHandler")]
			public abstract int FiscalOpenDatabase_Api ();

			static Delegate? cb_FiscalPowerOff_Api;
#pragma warning disable 0169
			static Delegate GetFiscalPowerOff_ApiHandler ()
			{
				if (cb_FiscalPowerOff_Api == null)
					cb_FiscalPowerOff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalPowerOff_Api));
				return cb_FiscalPowerOff_Api;
			}

			static int n_FiscalPowerOff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalPowerOff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalPowerOff_Api' and count(parameter)=0]"
			[Register ("FiscalPowerOff_Api", "()I", "GetFiscalPowerOff_ApiHandler")]
			public abstract int FiscalPowerOff_Api ();

			static Delegate? cb_FiscalPowerOn_Api;
#pragma warning disable 0169
			static Delegate GetFiscalPowerOn_ApiHandler ()
			{
				if (cb_FiscalPowerOn_Api == null)
					cb_FiscalPowerOn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalPowerOn_Api));
				return cb_FiscalPowerOn_Api;
			}

			static int n_FiscalPowerOn_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalPowerOn_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalPowerOn_Api' and count(parameter)=0]"
			[Register ("FiscalPowerOn_Api", "()I", "GetFiscalPowerOn_ApiHandler")]
			public abstract int FiscalPowerOn_Api ();

			static Delegate? cb_FiscalReadDataById_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetFiscalReadDataById_Api_IarrayBHandler ()
			{
				if (cb_FiscalReadDataById_Api_IarrayB == null)
					cb_FiscalReadDataById_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FiscalReadDataById_Api_IarrayB));
				return cb_FiscalReadDataById_Api_IarrayB;
			}

			static int n_FiscalReadDataById_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalReadDataById_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalReadDataById_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("FiscalReadDataById_Api", "(I[B)I", "GetFiscalReadDataById_Api_IarrayBHandler")]
			public abstract int FiscalReadDataById_Api (int p0, byte[]? p1);

			static Delegate? cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFiscalReadWormFlashData_Api_JJLjava_lang_String_Handler ()
			{
				if (cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_ == null)
					cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJL_Z (n_FiscalReadWormFlashData_Api_JJLjava_lang_String_));
				return cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_;
			}

			static bool n_FiscalReadWormFlashData_Api_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.FiscalReadWormFlashData_Api (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalReadWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
			[Register ("FiscalReadWormFlashData_Api", "(JJLjava/lang/String;)Z", "GetFiscalReadWormFlashData_Api_JJLjava_lang_String_Handler")]
			public abstract bool FiscalReadWormFlashData_Api (long p0, long p1, string? p2);

			static Delegate? cb_FiscalUpdateServer_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetFiscalUpdateServer_Api_arrayBIHandler ()
			{
				if (cb_FiscalUpdateServer_Api_arrayBI == null)
					cb_FiscalUpdateServer_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_FiscalUpdateServer_Api_arrayBI));
				return cb_FiscalUpdateServer_Api_arrayBI;
			}

			static int n_FiscalUpdateServer_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalUpdateServer_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalUpdateServer_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("FiscalUpdateServer_Api", "([BI)I", "GetFiscalUpdateServer_Api_arrayBIHandler")]
			public abstract int FiscalUpdateServer_Api (byte[]? p0, int p1);

			static Delegate? cb_FiscalWriteDataById_Api_IarrayBJ;
#pragma warning disable 0169
			static Delegate GetFiscalWriteDataById_Api_IarrayBJHandler ()
			{
				if (cb_FiscalWriteDataById_Api_IarrayBJ == null)
					cb_FiscalWriteDataById_Api_IarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILJ_I (n_FiscalWriteDataById_Api_IarrayBJ));
				return cb_FiscalWriteDataById_Api_IarrayBJ;
			}

			static int n_FiscalWriteDataById_Api_IarrayBJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, long p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalWriteDataById_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalWriteDataById_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("FiscalWriteDataById_Api", "(I[BJ)I", "GetFiscalWriteDataById_Api_IarrayBJHandler")]
			public abstract int FiscalWriteDataById_Api (int p0, byte[]? p1, long p2);

			static Delegate? cb_FiscalWriteWormFlashData_Api_JarrayBJ;
#pragma warning disable 0169
			static Delegate GetFiscalWriteWormFlashData_Api_JarrayBJHandler ()
			{
				if (cb_FiscalWriteWormFlashData_Api_JarrayBJ == null)
					cb_FiscalWriteWormFlashData_Api_JarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJLJ_J (n_FiscalWriteWormFlashData_Api_JarrayBJ));
				return cb_FiscalWriteWormFlashData_Api_JarrayBJ;
			}

			static long n_FiscalWriteWormFlashData_Api_JarrayBJ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, long p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				long __ret = __this.FiscalWriteWormFlashData_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalWriteWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("FiscalWriteWormFlashData_Api", "(J[BJ)J", "GetFiscalWriteWormFlashData_Api_JarrayBJHandler")]
			public abstract long FiscalWriteWormFlashData_Api (long p0, byte[]? p1, long p2);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/fiscal/FiscalHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/fiscal/FiscalHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalAuth_Api' and count(parameter)=0]"
			[Register ("FiscalAuth_Api", "()I", "GetFiscalAuth_ApiHandler")]
			public override unsafe int FiscalAuth_Api ()
			{
				const string __id = "FiscalAuth_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalBindServer_Api' and count(parameter)=0]"
			[Register ("FiscalBindServer_Api", "()I", "GetFiscalBindServer_ApiHandler")]
			public override unsafe int FiscalBindServer_Api ()
			{
				const string __id = "FiscalBindServer_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalCloseDatabase_Api' and count(parameter)=0]"
			[Register ("FiscalCloseDatabase_Api", "()I", "GetFiscalCloseDatabase_ApiHandler")]
			public override unsafe int FiscalCloseDatabase_Api ()
			{
				const string __id = "FiscalCloseDatabase_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordCheck_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordCheck_Api", "()I", "GetFiscalDBRecordCheck_ApiHandler")]
			public override unsafe int FiscalDBRecordCheck_Api ()
			{
				const string __id = "FiscalDBRecordCheck_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordClose_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordClose_Api", "()I", "GetFiscalDBRecordClose_ApiHandler")]
			public override unsafe int FiscalDBRecordClose_Api ()
			{
				const string __id = "FiscalDBRecordClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordOpen_Api' and count(parameter)=0]"
			[Register ("FiscalDBRecordOpen_Api", "()I", "GetFiscalDBRecordOpen_ApiHandler")]
			public override unsafe int FiscalDBRecordOpen_Api ()
			{
				const string __id = "FiscalDBRecordOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalDBRecordRead_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
			[Register ("FiscalDBRecordRead_Api", "(I[I[B[I)I", "GetFiscalDBRecordRead_Api_IarrayIarrayBarrayIHandler")]
			public override unsafe int FiscalDBRecordRead_Api (int p0, int[]? p1, byte[]? p2, int[]? p3)
			{
				const string __id = "FiscalDBRecordRead_Api.(I[I[B[I)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetFreeDiskSpace_Api' and count(parameter)=0]"
			[Register ("FiscalGetFreeDiskSpace_Api", "()J", "GetFiscalGetFreeDiskSpace_ApiHandler")]
			public override unsafe long FiscalGetFreeDiskSpace_Api ()
			{
				const string __id = "FiscalGetFreeDiskSpace_Api.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetHdVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetHdVersion_Api", "([B)I", "GetFiscalGetHdVersion_Api_arrayBHandler")]
			public override unsafe int FiscalGetHdVersion_Api (byte[]? p0)
			{
				const string __id = "FiscalGetHdVersion_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetIdkey_Api' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
			[Register ("FiscalGetIdkey_Api", "(JI)I", "GetFiscalGetIdkey_Api_JIHandler")]
			public override unsafe int FiscalGetIdkey_Api (long p0, int p1)
			{
				const string __id = "FiscalGetIdkey_Api.(JI)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetIds_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("FiscalGetIds_Api", "(III[B)I", "GetFiscalGetIds_Api_IIIarrayBHandler")]
			public override unsafe int FiscalGetIds_Api (int p0, int p1, int p2, byte[]? p3)
			{
				const string __id = "FiscalGetIds_Api.(III[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetSoftVersion_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetSoftVersion_Api", "([B)I", "GetFiscalGetSoftVersion_Api_arrayBHandler")]
			public override unsafe int FiscalGetSoftVersion_Api (byte[]? p0)
			{
				const string __id = "FiscalGetSoftVersion_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetSysSN_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("FiscalGetSysSN_Api", "([B)I", "GetFiscalGetSysSN_Api_arrayBHandler")]
			public override unsafe int FiscalGetSysSN_Api (byte[]? p0)
			{
				const string __id = "FiscalGetSysSN_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalGetTotalRow_Api' and count(parameter)=0]"
			[Register ("FiscalGetTotalRow_Api", "()I", "GetFiscalGetTotalRow_ApiHandler")]
			public override unsafe int FiscalGetTotalRow_Api ()
			{
				const string __id = "FiscalGetTotalRow_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalOpenDatabase_Api' and count(parameter)=0]"
			[Register ("FiscalOpenDatabase_Api", "()I", "GetFiscalOpenDatabase_ApiHandler")]
			public override unsafe int FiscalOpenDatabase_Api ()
			{
				const string __id = "FiscalOpenDatabase_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalPowerOff_Api' and count(parameter)=0]"
			[Register ("FiscalPowerOff_Api", "()I", "GetFiscalPowerOff_ApiHandler")]
			public override unsafe int FiscalPowerOff_Api ()
			{
				const string __id = "FiscalPowerOff_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalPowerOn_Api' and count(parameter)=0]"
			[Register ("FiscalPowerOn_Api", "()I", "GetFiscalPowerOn_ApiHandler")]
			public override unsafe int FiscalPowerOn_Api ()
			{
				const string __id = "FiscalPowerOn_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalReadDataById_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("FiscalReadDataById_Api", "(I[B)I", "GetFiscalReadDataById_Api_IarrayBHandler")]
			public override unsafe int FiscalReadDataById_Api (int p0, byte[]? p1)
			{
				const string __id = "FiscalReadDataById_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalReadWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
			[Register ("FiscalReadWormFlashData_Api", "(JJLjava/lang/String;)Z", "GetFiscalReadWormFlashData_Api_JJLjava_lang_String_Handler")]
			public override unsafe bool FiscalReadWormFlashData_Api (long p0, long p1, string? p2)
			{
				const string __id = "FiscalReadWormFlashData_Api.(JJLjava/lang/String;)Z";
				IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalUpdateServer_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("FiscalUpdateServer_Api", "([BI)I", "GetFiscalUpdateServer_Api_arrayBIHandler")]
			public override unsafe int FiscalUpdateServer_Api (byte[]? p0, int p1)
			{
				const string __id = "FiscalUpdateServer_Api.([BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalWriteDataById_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("FiscalWriteDataById_Api", "(I[BJ)I", "GetFiscalWriteDataById_Api_IarrayBJHandler")]
			public override unsafe int FiscalWriteDataById_Api (int p0, byte[]? p1, long p2)
			{
				const string __id = "FiscalWriteDataById_Api.(I[BJ)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.fiscal']/interface[@name='FiscalHandler']/method[@name='FiscalWriteWormFlashData_Api' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("FiscalWriteWormFlashData_Api", "(J[BJ)J", "GetFiscalWriteWormFlashData_Api_JarrayBJHandler")]
			public override unsafe long FiscalWriteWormFlashData_Api (long p0, byte[]? p1, long p2)
			{
				const string __id = "FiscalWriteWormFlashData_Api.(J[BJ)J";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/fiscal/FiscalHandler", DoNotGenerateAcw=true)]
	internal partial class IFiscalHandlerInvoker : global::Java.Lang.Object, IFiscalHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/fiscal/FiscalHandler", typeof (IFiscalHandlerInvoker));

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

		public static IFiscalHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFiscalHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.fiscal.FiscalHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFiscalHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_FiscalAuth_Api;
#pragma warning disable 0169
		static Delegate GetFiscalAuth_ApiHandler ()
		{
			if (cb_FiscalAuth_Api == null)
				cb_FiscalAuth_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalAuth_Api));
			return cb_FiscalAuth_Api;
		}

		static int n_FiscalAuth_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalAuth_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalAuth_Api;
		public unsafe int FiscalAuth_Api ()
		{
			if (id_FiscalAuth_Api == IntPtr.Zero)
				id_FiscalAuth_Api = JNIEnv.GetMethodID (class_ref, "FiscalAuth_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalAuth_Api);
		}

		static Delegate? cb_FiscalBindServer_Api;
#pragma warning disable 0169
		static Delegate GetFiscalBindServer_ApiHandler ()
		{
			if (cb_FiscalBindServer_Api == null)
				cb_FiscalBindServer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalBindServer_Api));
			return cb_FiscalBindServer_Api;
		}

		static int n_FiscalBindServer_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalBindServer_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalBindServer_Api;
		public unsafe int FiscalBindServer_Api ()
		{
			if (id_FiscalBindServer_Api == IntPtr.Zero)
				id_FiscalBindServer_Api = JNIEnv.GetMethodID (class_ref, "FiscalBindServer_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalBindServer_Api);
		}

		static Delegate? cb_FiscalCloseDatabase_Api;
#pragma warning disable 0169
		static Delegate GetFiscalCloseDatabase_ApiHandler ()
		{
			if (cb_FiscalCloseDatabase_Api == null)
				cb_FiscalCloseDatabase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalCloseDatabase_Api));
			return cb_FiscalCloseDatabase_Api;
		}

		static int n_FiscalCloseDatabase_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalCloseDatabase_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalCloseDatabase_Api;
		public unsafe int FiscalCloseDatabase_Api ()
		{
			if (id_FiscalCloseDatabase_Api == IntPtr.Zero)
				id_FiscalCloseDatabase_Api = JNIEnv.GetMethodID (class_ref, "FiscalCloseDatabase_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalCloseDatabase_Api);
		}

		static Delegate? cb_FiscalDBRecordCheck_Api;
#pragma warning disable 0169
		static Delegate GetFiscalDBRecordCheck_ApiHandler ()
		{
			if (cb_FiscalDBRecordCheck_Api == null)
				cb_FiscalDBRecordCheck_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordCheck_Api));
			return cb_FiscalDBRecordCheck_Api;
		}

		static int n_FiscalDBRecordCheck_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalDBRecordCheck_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalDBRecordCheck_Api;
		public unsafe int FiscalDBRecordCheck_Api ()
		{
			if (id_FiscalDBRecordCheck_Api == IntPtr.Zero)
				id_FiscalDBRecordCheck_Api = JNIEnv.GetMethodID (class_ref, "FiscalDBRecordCheck_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalDBRecordCheck_Api);
		}

		static Delegate? cb_FiscalDBRecordClose_Api;
#pragma warning disable 0169
		static Delegate GetFiscalDBRecordClose_ApiHandler ()
		{
			if (cb_FiscalDBRecordClose_Api == null)
				cb_FiscalDBRecordClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordClose_Api));
			return cb_FiscalDBRecordClose_Api;
		}

		static int n_FiscalDBRecordClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalDBRecordClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalDBRecordClose_Api;
		public unsafe int FiscalDBRecordClose_Api ()
		{
			if (id_FiscalDBRecordClose_Api == IntPtr.Zero)
				id_FiscalDBRecordClose_Api = JNIEnv.GetMethodID (class_ref, "FiscalDBRecordClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalDBRecordClose_Api);
		}

		static Delegate? cb_FiscalDBRecordOpen_Api;
#pragma warning disable 0169
		static Delegate GetFiscalDBRecordOpen_ApiHandler ()
		{
			if (cb_FiscalDBRecordOpen_Api == null)
				cb_FiscalDBRecordOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalDBRecordOpen_Api));
			return cb_FiscalDBRecordOpen_Api;
		}

		static int n_FiscalDBRecordOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalDBRecordOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalDBRecordOpen_Api;
		public unsafe int FiscalDBRecordOpen_Api ()
		{
			if (id_FiscalDBRecordOpen_Api == IntPtr.Zero)
				id_FiscalDBRecordOpen_Api = JNIEnv.GetMethodID (class_ref, "FiscalDBRecordOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalDBRecordOpen_Api);
		}

		static Delegate? cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetFiscalDBRecordRead_Api_IarrayIarrayBarrayIHandler ()
		{
			if (cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI == null)
				cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_FiscalDBRecordRead_Api_IarrayIarrayBarrayI));
			return cb_FiscalDBRecordRead_Api_IarrayIarrayBarrayI;
		}

		static int n_FiscalDBRecordRead_Api_IarrayIarrayBarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (int[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (int[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.FiscalDBRecordRead_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalDBRecordRead_Api_IarrayIarrayBarrayI;
		public unsafe int FiscalDBRecordRead_Api (int p0, int[]? p1, byte[]? p2, int[]? p3)
		{
			if (id_FiscalDBRecordRead_Api_IarrayIarrayBarrayI == IntPtr.Zero)
				id_FiscalDBRecordRead_Api_IarrayIarrayBarrayI = JNIEnv.GetMethodID (class_ref, "FiscalDBRecordRead_Api", "(I[I[B[I)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalDBRecordRead_Api_IarrayIarrayBarrayI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_FiscalGetFreeDiskSpace_Api;
#pragma warning disable 0169
		static Delegate GetFiscalGetFreeDiskSpace_ApiHandler ()
		{
			if (cb_FiscalGetFreeDiskSpace_Api == null)
				cb_FiscalGetFreeDiskSpace_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_FiscalGetFreeDiskSpace_Api));
			return cb_FiscalGetFreeDiskSpace_Api;
		}

		static long n_FiscalGetFreeDiskSpace_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalGetFreeDiskSpace_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalGetFreeDiskSpace_Api;
		public unsafe long FiscalGetFreeDiskSpace_Api ()
		{
			if (id_FiscalGetFreeDiskSpace_Api == IntPtr.Zero)
				id_FiscalGetFreeDiskSpace_Api = JNIEnv.GetMethodID (class_ref, "FiscalGetFreeDiskSpace_Api", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_FiscalGetFreeDiskSpace_Api);
		}

		static Delegate? cb_FiscalGetHdVersion_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetFiscalGetHdVersion_Api_arrayBHandler ()
		{
			if (cb_FiscalGetHdVersion_Api_arrayB == null)
				cb_FiscalGetHdVersion_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetHdVersion_Api_arrayB));
			return cb_FiscalGetHdVersion_Api_arrayB;
		}

		static int n_FiscalGetHdVersion_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalGetHdVersion_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalGetHdVersion_Api_arrayB;
		public unsafe int FiscalGetHdVersion_Api (byte[]? p0)
		{
			if (id_FiscalGetHdVersion_Api_arrayB == IntPtr.Zero)
				id_FiscalGetHdVersion_Api_arrayB = JNIEnv.GetMethodID (class_ref, "FiscalGetHdVersion_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalGetHdVersion_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FiscalGetIdkey_Api_JI;
#pragma warning disable 0169
		static Delegate GetFiscalGetIdkey_Api_JIHandler ()
		{
			if (cb_FiscalGetIdkey_Api_JI == null)
				cb_FiscalGetIdkey_Api_JI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJI_I (n_FiscalGetIdkey_Api_JI));
			return cb_FiscalGetIdkey_Api_JI;
		}

		static int n_FiscalGetIdkey_Api_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalGetIdkey_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_FiscalGetIdkey_Api_JI;
		public unsafe int FiscalGetIdkey_Api (long p0, int p1)
		{
			if (id_FiscalGetIdkey_Api_JI == IntPtr.Zero)
				id_FiscalGetIdkey_Api_JI = JNIEnv.GetMethodID (class_ref, "FiscalGetIdkey_Api", "(JI)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalGetIdkey_Api_JI, __args);
		}

		static Delegate? cb_FiscalGetIds_Api_IIIarrayB;
#pragma warning disable 0169
		static Delegate GetFiscalGetIds_Api_IIIarrayBHandler ()
		{
			if (cb_FiscalGetIds_Api_IIIarrayB == null)
				cb_FiscalGetIds_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_FiscalGetIds_Api_IIIarrayB));
			return cb_FiscalGetIds_Api_IIIarrayB;
		}

		static int n_FiscalGetIds_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalGetIds_Api (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalGetIds_Api_IIIarrayB;
		public unsafe int FiscalGetIds_Api (int p0, int p1, int p2, byte[]? p3)
		{
			if (id_FiscalGetIds_Api_IIIarrayB == IntPtr.Zero)
				id_FiscalGetIds_Api_IIIarrayB = JNIEnv.GetMethodID (class_ref, "FiscalGetIds_Api", "(III[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalGetIds_Api_IIIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_FiscalGetSoftVersion_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetFiscalGetSoftVersion_Api_arrayBHandler ()
		{
			if (cb_FiscalGetSoftVersion_Api_arrayB == null)
				cb_FiscalGetSoftVersion_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetSoftVersion_Api_arrayB));
			return cb_FiscalGetSoftVersion_Api_arrayB;
		}

		static int n_FiscalGetSoftVersion_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalGetSoftVersion_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalGetSoftVersion_Api_arrayB;
		public unsafe int FiscalGetSoftVersion_Api (byte[]? p0)
		{
			if (id_FiscalGetSoftVersion_Api_arrayB == IntPtr.Zero)
				id_FiscalGetSoftVersion_Api_arrayB = JNIEnv.GetMethodID (class_ref, "FiscalGetSoftVersion_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalGetSoftVersion_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FiscalGetSysSN_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetFiscalGetSysSN_Api_arrayBHandler ()
		{
			if (cb_FiscalGetSysSN_Api_arrayB == null)
				cb_FiscalGetSysSN_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalGetSysSN_Api_arrayB));
			return cb_FiscalGetSysSN_Api_arrayB;
		}

		static int n_FiscalGetSysSN_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalGetSysSN_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalGetSysSN_Api_arrayB;
		public unsafe int FiscalGetSysSN_Api (byte[]? p0)
		{
			if (id_FiscalGetSysSN_Api_arrayB == IntPtr.Zero)
				id_FiscalGetSysSN_Api_arrayB = JNIEnv.GetMethodID (class_ref, "FiscalGetSysSN_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalGetSysSN_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FiscalGetTotalRow_Api;
#pragma warning disable 0169
		static Delegate GetFiscalGetTotalRow_ApiHandler ()
		{
			if (cb_FiscalGetTotalRow_Api == null)
				cb_FiscalGetTotalRow_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalGetTotalRow_Api));
			return cb_FiscalGetTotalRow_Api;
		}

		static int n_FiscalGetTotalRow_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalGetTotalRow_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalGetTotalRow_Api;
		public unsafe int FiscalGetTotalRow_Api ()
		{
			if (id_FiscalGetTotalRow_Api == IntPtr.Zero)
				id_FiscalGetTotalRow_Api = JNIEnv.GetMethodID (class_ref, "FiscalGetTotalRow_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalGetTotalRow_Api);
		}

		static Delegate? cb_FiscalOpenDatabase_Api;
#pragma warning disable 0169
		static Delegate GetFiscalOpenDatabase_ApiHandler ()
		{
			if (cb_FiscalOpenDatabase_Api == null)
				cb_FiscalOpenDatabase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalOpenDatabase_Api));
			return cb_FiscalOpenDatabase_Api;
		}

		static int n_FiscalOpenDatabase_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalOpenDatabase_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalOpenDatabase_Api;
		public unsafe int FiscalOpenDatabase_Api ()
		{
			if (id_FiscalOpenDatabase_Api == IntPtr.Zero)
				id_FiscalOpenDatabase_Api = JNIEnv.GetMethodID (class_ref, "FiscalOpenDatabase_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalOpenDatabase_Api);
		}

		static Delegate? cb_FiscalPowerOff_Api;
#pragma warning disable 0169
		static Delegate GetFiscalPowerOff_ApiHandler ()
		{
			if (cb_FiscalPowerOff_Api == null)
				cb_FiscalPowerOff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalPowerOff_Api));
			return cb_FiscalPowerOff_Api;
		}

		static int n_FiscalPowerOff_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalPowerOff_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalPowerOff_Api;
		public unsafe int FiscalPowerOff_Api ()
		{
			if (id_FiscalPowerOff_Api == IntPtr.Zero)
				id_FiscalPowerOff_Api = JNIEnv.GetMethodID (class_ref, "FiscalPowerOff_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalPowerOff_Api);
		}

		static Delegate? cb_FiscalPowerOn_Api;
#pragma warning disable 0169
		static Delegate GetFiscalPowerOn_ApiHandler ()
		{
			if (cb_FiscalPowerOn_Api == null)
				cb_FiscalPowerOn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalPowerOn_Api));
			return cb_FiscalPowerOn_Api;
		}

		static int n_FiscalPowerOn_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalPowerOn_Api ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalPowerOn_Api;
		public unsafe int FiscalPowerOn_Api ()
		{
			if (id_FiscalPowerOn_Api == IntPtr.Zero)
				id_FiscalPowerOn_Api = JNIEnv.GetMethodID (class_ref, "FiscalPowerOn_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalPowerOn_Api);
		}

		static Delegate? cb_FiscalReadDataById_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetFiscalReadDataById_Api_IarrayBHandler ()
		{
			if (cb_FiscalReadDataById_Api_IarrayB == null)
				cb_FiscalReadDataById_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_FiscalReadDataById_Api_IarrayB));
			return cb_FiscalReadDataById_Api_IarrayB;
		}

		static int n_FiscalReadDataById_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalReadDataById_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalReadDataById_Api_IarrayB;
		public unsafe int FiscalReadDataById_Api (int p0, byte[]? p1)
		{
			if (id_FiscalReadDataById_Api_IarrayB == IntPtr.Zero)
				id_FiscalReadDataById_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "FiscalReadDataById_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalReadDataById_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFiscalReadWormFlashData_Api_JJLjava_lang_String_Handler ()
		{
			if (cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_ == null)
				cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJL_Z (n_FiscalReadWormFlashData_Api_JJLjava_lang_String_));
			return cb_FiscalReadWormFlashData_Api_JJLjava_lang_String_;
		}

		static bool n_FiscalReadWormFlashData_Api_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.FiscalReadWormFlashData_Api (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalReadWormFlashData_Api_JJLjava_lang_String_;
		public unsafe bool FiscalReadWormFlashData_Api (long p0, long p1, string? p2)
		{
			if (id_FiscalReadWormFlashData_Api_JJLjava_lang_String_ == IntPtr.Zero)
				id_FiscalReadWormFlashData_Api_JJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "FiscalReadWormFlashData_Api", "(JJLjava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_FiscalReadWormFlashData_Api_JJLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate? cb_FiscalUpdateServer_Api_arrayBI;
#pragma warning disable 0169
		static Delegate GetFiscalUpdateServer_Api_arrayBIHandler ()
		{
			if (cb_FiscalUpdateServer_Api_arrayBI == null)
				cb_FiscalUpdateServer_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_FiscalUpdateServer_Api_arrayBI));
			return cb_FiscalUpdateServer_Api_arrayBI;
		}

		static int n_FiscalUpdateServer_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalUpdateServer_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalUpdateServer_Api_arrayBI;
		public unsafe int FiscalUpdateServer_Api (byte[]? p0, int p1)
		{
			if (id_FiscalUpdateServer_Api_arrayBI == IntPtr.Zero)
				id_FiscalUpdateServer_Api_arrayBI = JNIEnv.GetMethodID (class_ref, "FiscalUpdateServer_Api", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalUpdateServer_Api_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FiscalWriteDataById_Api_IarrayBJ;
#pragma warning disable 0169
		static Delegate GetFiscalWriteDataById_Api_IarrayBJHandler ()
		{
			if (cb_FiscalWriteDataById_Api_IarrayBJ == null)
				cb_FiscalWriteDataById_Api_IarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILJ_I (n_FiscalWriteDataById_Api_IarrayBJ));
			return cb_FiscalWriteDataById_Api_IarrayBJ;
		}

		static int n_FiscalWriteDataById_Api_IarrayBJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalWriteDataById_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalWriteDataById_Api_IarrayBJ;
		public unsafe int FiscalWriteDataById_Api (int p0, byte[]? p1, long p2)
		{
			if (id_FiscalWriteDataById_Api_IarrayBJ == IntPtr.Zero)
				id_FiscalWriteDataById_Api_IarrayBJ = JNIEnv.GetMethodID (class_ref, "FiscalWriteDataById_Api", "(I[BJ)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalWriteDataById_Api_IarrayBJ, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_FiscalWriteWormFlashData_Api_JarrayBJ;
#pragma warning disable 0169
		static Delegate GetFiscalWriteWormFlashData_Api_JarrayBJHandler ()
		{
			if (cb_FiscalWriteWormFlashData_Api_JarrayBJ == null)
				cb_FiscalWriteWormFlashData_Api_JarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJLJ_J (n_FiscalWriteWormFlashData_Api_JarrayBJ));
			return cb_FiscalWriteWormFlashData_Api_JarrayBJ;
		}

		static long n_FiscalWriteWormFlashData_Api_JarrayBJ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long __ret = __this.FiscalWriteWormFlashData_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_FiscalWriteWormFlashData_Api_JarrayBJ;
		public unsafe long FiscalWriteWormFlashData_Api (long p0, byte[]? p1, long p2)
		{
			if (id_FiscalWriteWormFlashData_Api_JarrayBJ == IntPtr.Zero)
				id_FiscalWriteWormFlashData_Api_JarrayBJ = JNIEnv.GetMethodID (class_ref, "FiscalWriteWormFlashData_Api", "(J[BJ)J");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_FiscalWriteWormFlashData_Api_JarrayBJ, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Fiscal.IFiscalHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
