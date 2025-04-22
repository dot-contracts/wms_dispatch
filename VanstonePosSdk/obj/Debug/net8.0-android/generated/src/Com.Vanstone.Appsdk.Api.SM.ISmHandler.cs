using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.SM {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']"
	[Register ("com/vanstone/appsdk/api/sm/SmHandler", "", "Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker")]
	public partial interface ISmHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SM2Verify_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
		[Register ("SM2Verify_Api", "([BI[B[B[BI)I", "GetSM2Verify_Api_arrayBIarrayBarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int SM2Verify_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SM3Hash_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("SM3Hash_Api", "([BI[B)I", "GetSM3Hash_Api_arrayBIarrayBHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int SM3Hash_Api (byte[]? p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm1_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
		[Register ("Sm1_Api", "([BI[B[BI)I", "GetSm1_Api_arrayBIarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int Sm1_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2ExportPKAll_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("Sm2ExportPKAll_Api", "([B[B[B)I", "GetSm2ExportPKAll_Api_arrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int Sm2ExportPKAll_Api (byte[]? p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2ExportPK_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("Sm2ExportPK_Api", "(I[B)I", "GetSm2ExportPK_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int Sm2ExportPK_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2Sign_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
		[Register ("Sm2Sign_Api", "([BI[B[B[B[BI)I", "GetSm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int Sm2Sign_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm4Soft_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
		[Register ("Sm4Soft_Api", "([BI[B[BI)I", "GetSm4Soft_Api_arrayBIarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int Sm4Soft_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm4_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
		[Register ("Sm4_Api", "([BI[B[B[BI)I", "GetSm4_Api_arrayBIarrayBarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int Sm4_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SmGetRand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("SmGetRand_Api", "(I[B)I", "GetSmGetRand_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int SmGetRand_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='gmClose_Api' and count(parameter)=0]"
		[Register ("gmClose_Api", "()I", "GetGmClose_ApiHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int GmClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='gmOpen_Api' and count(parameter)=0]"
		[Register ("gmOpen_Api", "()I", "GetGmOpen_ApiHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int GmOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='sm2_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int[]'] and parameter[7][@type='byte']]"
		[Register ("sm2_Api", "([BI[BI[B[IB)I", "GetSm2_Api_arrayBIarrayBIarrayBarrayIBHandler:Com.Vanstone.Appsdk.Api.SM.ISmHandlerInvoker, VanstonePosSdk")]
		int Sm2_Api (byte[]? p0, int p1, byte[]? p2, int p3, byte[]? p4, int[]? p5, sbyte p6);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sm/SmHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.SM.ISmHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sm/SmHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/constructor[@name='SmHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSM2Verify_Api_arrayBIarrayBarrayBarrayBIHandler ()
			{
				if (cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI == null)
					cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLI_I (n_SM2Verify_Api_arrayBIarrayBarrayBarrayBI));
				return cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI;
			}

			static int n_SM2Verify_Api_arrayBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_userid, int useridLen, IntPtr native_publicKey, IntPtr native_signData, IntPtr native_msg, int msgLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var userid = (byte[]?) JNIEnv.GetArray (native_userid, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var publicKey = (byte[]?) JNIEnv.GetArray (native_publicKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var signData = (byte[]?) JNIEnv.GetArray (native_signData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var msg = (byte[]?) JNIEnv.GetArray (native_msg, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SM2Verify_Api (userid, useridLen, publicKey, signData, msg, msgLen);
				if (userid != null)
					JNIEnv.CopyArray (userid, native_userid);
				if (publicKey != null)
					JNIEnv.CopyArray (publicKey, native_publicKey);
				if (signData != null)
					JNIEnv.CopyArray (signData, native_signData);
				if (msg != null)
					JNIEnv.CopyArray (msg, native_msg);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='SM2Verify_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("SM2Verify_Api", "([BI[B[B[BI)I", "GetSM2Verify_Api_arrayBIarrayBarrayBarrayBIHandler")]
			public virtual unsafe int SM2Verify_Api (byte[]? userid, int useridLen, byte[]? publicKey, byte[]? signData, byte[]? msg, int msgLen)
			{
				const string __id = "SM2Verify_Api.([BI[B[B[BI)I";
				IntPtr native_userid = JNIEnv.NewArray (userid);
				IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
				IntPtr native_signData = JNIEnv.NewArray (signData);
				IntPtr native_msg = JNIEnv.NewArray (msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (native_userid);
					__args [1] = new JniArgumentValue (useridLen);
					__args [2] = new JniArgumentValue (native_publicKey);
					__args [3] = new JniArgumentValue (native_signData);
					__args [4] = new JniArgumentValue (native_msg);
					__args [5] = new JniArgumentValue (msgLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (userid != null) {
						JNIEnv.CopyArray (native_userid, userid);
						JNIEnv.DeleteLocalRef (native_userid);
					}
					if (publicKey != null) {
						JNIEnv.CopyArray (native_publicKey, publicKey);
						JNIEnv.DeleteLocalRef (native_publicKey);
					}
					if (signData != null) {
						JNIEnv.CopyArray (native_signData, signData);
						JNIEnv.DeleteLocalRef (native_signData);
					}
					if (msg != null) {
						JNIEnv.CopyArray (native_msg, msg);
						JNIEnv.DeleteLocalRef (native_msg);
					}
					global::System.GC.KeepAlive (userid);
					global::System.GC.KeepAlive (publicKey);
					global::System.GC.KeepAlive (signData);
					global::System.GC.KeepAlive (msg);
				}
			}

			static Delegate? cb_SM3Hash_Api_arrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetSM3Hash_Api_arrayBIarrayBHandler ()
			{
				if (cb_SM3Hash_Api_arrayBIarrayB == null)
					cb_SM3Hash_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_SM3Hash_Api_arrayBIarrayB));
				return cb_SM3Hash_Api_arrayBIarrayB;
			}

			static int n_SM3Hash_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int input_len, IntPtr native_out_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var out_buf = (byte[]?) JNIEnv.GetArray (native_out_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SM3Hash_Api (data, input_len, out_buf);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				if (out_buf != null)
					JNIEnv.CopyArray (out_buf, native_out_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='SM3Hash_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("SM3Hash_Api", "([BI[B)I", "GetSM3Hash_Api_arrayBIarrayBHandler")]
			public virtual unsafe int SM3Hash_Api (byte[]? data, int input_len, byte[]? out_buf)
			{
				const string __id = "SM3Hash_Api.([BI[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				IntPtr native_out_buf = JNIEnv.NewArray (out_buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_data);
					__args [1] = new JniArgumentValue (input_len);
					__args [2] = new JniArgumentValue (native_out_buf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					if (out_buf != null) {
						JNIEnv.CopyArray (native_out_buf, out_buf);
						JNIEnv.DeleteLocalRef (native_out_buf);
					}
					global::System.GC.KeepAlive (data);
					global::System.GC.KeepAlive (out_buf);
				}
			}

			static Delegate? cb_Sm1_Api_arrayBIarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm1_Api_arrayBIarrayBarrayBIHandler ()
			{
				if (cb_Sm1_Api_arrayBIarrayBarrayBI == null)
					cb_Sm1_Api_arrayBIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLI_I (n_Sm1_Api_arrayBIarrayBarrayBI));
				return cb_Sm1_Api_arrayBIarrayBarrayBI;
			}

			static int n_Sm1_Api_arrayBIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_input, int inputLen, IntPtr native_output, IntPtr native_smkey, int mode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var input = (byte[]?) JNIEnv.GetArray (native_input, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var output = (byte[]?) JNIEnv.GetArray (native_output, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var smkey = (byte[]?) JNIEnv.GetArray (native_smkey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm1_Api (input, inputLen, output, smkey, mode);
				if (input != null)
					JNIEnv.CopyArray (input, native_input);
				if (output != null)
					JNIEnv.CopyArray (output, native_output);
				if (smkey != null)
					JNIEnv.CopyArray (smkey, native_smkey);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='Sm1_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("Sm1_Api", "([BI[B[BI)I", "GetSm1_Api_arrayBIarrayBarrayBIHandler")]
			public virtual unsafe int Sm1_Api (byte[]? input, int inputLen, byte[]? output, byte[]? smkey, int mode)
			{
				const string __id = "Sm1_Api.([BI[B[BI)I";
				IntPtr native_input = JNIEnv.NewArray (input);
				IntPtr native_output = JNIEnv.NewArray (output);
				IntPtr native_smkey = JNIEnv.NewArray (smkey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_input);
					__args [1] = new JniArgumentValue (inputLen);
					__args [2] = new JniArgumentValue (native_output);
					__args [3] = new JniArgumentValue (native_smkey);
					__args [4] = new JniArgumentValue (mode);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (input != null) {
						JNIEnv.CopyArray (native_input, input);
						JNIEnv.DeleteLocalRef (native_input);
					}
					if (output != null) {
						JNIEnv.CopyArray (native_output, output);
						JNIEnv.DeleteLocalRef (native_output);
					}
					if (smkey != null) {
						JNIEnv.CopyArray (native_smkey, smkey);
						JNIEnv.DeleteLocalRef (native_smkey);
					}
					global::System.GC.KeepAlive (input);
					global::System.GC.KeepAlive (output);
					global::System.GC.KeepAlive (smkey);
				}
			}

			static Delegate? cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetSm2ExportPKAll_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB == null)
					cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_Sm2ExportPKAll_Api_arrayBarrayBarrayB));
				return cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB;
			}

			static int n_Sm2ExportPKAll_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_PrivateKey, IntPtr native_PublicKeyX, IntPtr native_PublicKeyY)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var PrivateKey = (byte[]?) JNIEnv.GetArray (native_PrivateKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var PublicKeyX = (byte[]?) JNIEnv.GetArray (native_PublicKeyX, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var PublicKeyY = (byte[]?) JNIEnv.GetArray (native_PublicKeyY, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm2ExportPKAll_Api (PrivateKey, PublicKeyX, PublicKeyY);
				if (PrivateKey != null)
					JNIEnv.CopyArray (PrivateKey, native_PrivateKey);
				if (PublicKeyX != null)
					JNIEnv.CopyArray (PublicKeyX, native_PublicKeyX);
				if (PublicKeyY != null)
					JNIEnv.CopyArray (PublicKeyY, native_PublicKeyY);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='Sm2ExportPKAll_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("Sm2ExportPKAll_Api", "([B[B[B)I", "GetSm2ExportPKAll_Api_arrayBarrayBarrayBHandler")]
			public virtual unsafe int Sm2ExportPKAll_Api (byte[]? PrivateKey, byte[]? PublicKeyX, byte[]? PublicKeyY)
			{
				const string __id = "Sm2ExportPKAll_Api.([B[B[B)I";
				IntPtr native_PrivateKey = JNIEnv.NewArray (PrivateKey);
				IntPtr native_PublicKeyX = JNIEnv.NewArray (PublicKeyX);
				IntPtr native_PublicKeyY = JNIEnv.NewArray (PublicKeyY);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_PrivateKey);
					__args [1] = new JniArgumentValue (native_PublicKeyX);
					__args [2] = new JniArgumentValue (native_PublicKeyY);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (PrivateKey != null) {
						JNIEnv.CopyArray (native_PrivateKey, PrivateKey);
						JNIEnv.DeleteLocalRef (native_PrivateKey);
					}
					if (PublicKeyX != null) {
						JNIEnv.CopyArray (native_PublicKeyX, PublicKeyX);
						JNIEnv.DeleteLocalRef (native_PublicKeyX);
					}
					if (PublicKeyY != null) {
						JNIEnv.CopyArray (native_PublicKeyY, PublicKeyY);
						JNIEnv.DeleteLocalRef (native_PublicKeyY);
					}
					global::System.GC.KeepAlive (PrivateKey);
					global::System.GC.KeepAlive (PublicKeyX);
					global::System.GC.KeepAlive (PublicKeyY);
				}
			}

			static Delegate? cb_Sm2ExportPK_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSm2ExportPK_Api_IarrayBHandler ()
			{
				if (cb_Sm2ExportPK_Api_IarrayB == null)
					cb_Sm2ExportPK_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sm2ExportPK_Api_IarrayB));
				return cb_Sm2ExportPK_Api_IarrayB;
			}

			static int n_Sm2ExportPK_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int Type, IntPtr native_Output)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Output = (byte[]?) JNIEnv.GetArray (native_Output, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm2ExportPK_Api (Type, Output);
				if (Output != null)
					JNIEnv.CopyArray (Output, native_Output);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='Sm2ExportPK_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("Sm2ExportPK_Api", "(I[B)I", "GetSm2ExportPK_Api_IarrayBHandler")]
			public virtual unsafe int Sm2ExportPK_Api (int Type, byte[]? Output)
			{
				const string __id = "Sm2ExportPK_Api.(I[B)I";
				IntPtr native_Output = JNIEnv.NewArray (Output);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (Type);
					__args [1] = new JniArgumentValue (native_Output);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Output != null) {
						JNIEnv.CopyArray (native_Output, Output);
						JNIEnv.DeleteLocalRef (native_Output);
					}
					global::System.GC.KeepAlive (Output);
				}
			}

			static Delegate? cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBIHandler ()
			{
				if (cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI == null)
					cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLLI_I (n_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI));
				return cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI;
			}

			static int n_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_UserId, int UserIdLen, IntPtr native_PublicKey, IntPtr native_PrivateKey, IntPtr native_Sign, IntPtr native_Msg, int MsgLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var UserId = (byte[]?) JNIEnv.GetArray (native_UserId, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var PublicKey = (byte[]?) JNIEnv.GetArray (native_PublicKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var PrivateKey = (byte[]?) JNIEnv.GetArray (native_PrivateKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Sign = (byte[]?) JNIEnv.GetArray (native_Sign, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Msg = (byte[]?) JNIEnv.GetArray (native_Msg, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm2Sign_Api (UserId, UserIdLen, PublicKey, PrivateKey, Sign, Msg, MsgLen);
				if (UserId != null)
					JNIEnv.CopyArray (UserId, native_UserId);
				if (PublicKey != null)
					JNIEnv.CopyArray (PublicKey, native_PublicKey);
				if (PrivateKey != null)
					JNIEnv.CopyArray (PrivateKey, native_PrivateKey);
				if (Sign != null)
					JNIEnv.CopyArray (Sign, native_Sign);
				if (Msg != null)
					JNIEnv.CopyArray (Msg, native_Msg);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='Sm2Sign_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("Sm2Sign_Api", "([BI[B[B[B[BI)I", "GetSm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBIHandler")]
			public virtual unsafe int Sm2Sign_Api (byte[]? UserId, int UserIdLen, byte[]? PublicKey, byte[]? PrivateKey, byte[]? Sign, byte[]? Msg, int MsgLen)
			{
				const string __id = "Sm2Sign_Api.([BI[B[B[B[BI)I";
				IntPtr native_UserId = JNIEnv.NewArray (UserId);
				IntPtr native_PublicKey = JNIEnv.NewArray (PublicKey);
				IntPtr native_PrivateKey = JNIEnv.NewArray (PrivateKey);
				IntPtr native_Sign = JNIEnv.NewArray (Sign);
				IntPtr native_Msg = JNIEnv.NewArray (Msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_UserId);
					__args [1] = new JniArgumentValue (UserIdLen);
					__args [2] = new JniArgumentValue (native_PublicKey);
					__args [3] = new JniArgumentValue (native_PrivateKey);
					__args [4] = new JniArgumentValue (native_Sign);
					__args [5] = new JniArgumentValue (native_Msg);
					__args [6] = new JniArgumentValue (MsgLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (UserId != null) {
						JNIEnv.CopyArray (native_UserId, UserId);
						JNIEnv.DeleteLocalRef (native_UserId);
					}
					if (PublicKey != null) {
						JNIEnv.CopyArray (native_PublicKey, PublicKey);
						JNIEnv.DeleteLocalRef (native_PublicKey);
					}
					if (PrivateKey != null) {
						JNIEnv.CopyArray (native_PrivateKey, PrivateKey);
						JNIEnv.DeleteLocalRef (native_PrivateKey);
					}
					if (Sign != null) {
						JNIEnv.CopyArray (native_Sign, Sign);
						JNIEnv.DeleteLocalRef (native_Sign);
					}
					if (Msg != null) {
						JNIEnv.CopyArray (native_Msg, Msg);
						JNIEnv.DeleteLocalRef (native_Msg);
					}
					global::System.GC.KeepAlive (UserId);
					global::System.GC.KeepAlive (PublicKey);
					global::System.GC.KeepAlive (PrivateKey);
					global::System.GC.KeepAlive (Sign);
					global::System.GC.KeepAlive (Msg);
				}
			}

			static Delegate? cb_Sm4Soft_Api_arrayBIarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm4Soft_Api_arrayBIarrayBarrayBIHandler ()
			{
				if (cb_Sm4Soft_Api_arrayBIarrayBarrayBI == null)
					cb_Sm4Soft_Api_arrayBIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLI_I (n_Sm4Soft_Api_arrayBIarrayBarrayBI));
				return cb_Sm4Soft_Api_arrayBIarrayBarrayBI;
			}

			static int n_Sm4Soft_Api_arrayBIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_Source, int SourceLen, IntPtr native_Dest, IntPtr native_Inkey, int Flag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Source = (byte[]?) JNIEnv.GetArray (native_Source, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Dest = (byte[]?) JNIEnv.GetArray (native_Dest, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Inkey = (byte[]?) JNIEnv.GetArray (native_Inkey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm4Soft_Api (Source, SourceLen, Dest, Inkey, Flag);
				if (Source != null)
					JNIEnv.CopyArray (Source, native_Source);
				if (Dest != null)
					JNIEnv.CopyArray (Dest, native_Dest);
				if (Inkey != null)
					JNIEnv.CopyArray (Inkey, native_Inkey);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='Sm4Soft_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("Sm4Soft_Api", "([BI[B[BI)I", "GetSm4Soft_Api_arrayBIarrayBarrayBIHandler")]
			public virtual unsafe int Sm4Soft_Api (byte[]? Source, int SourceLen, byte[]? Dest, byte[]? Inkey, int Flag)
			{
				const string __id = "Sm4Soft_Api.([BI[B[BI)I";
				IntPtr native_Source = JNIEnv.NewArray (Source);
				IntPtr native_Dest = JNIEnv.NewArray (Dest);
				IntPtr native_Inkey = JNIEnv.NewArray (Inkey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_Source);
					__args [1] = new JniArgumentValue (SourceLen);
					__args [2] = new JniArgumentValue (native_Dest);
					__args [3] = new JniArgumentValue (native_Inkey);
					__args [4] = new JniArgumentValue (Flag);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Source != null) {
						JNIEnv.CopyArray (native_Source, Source);
						JNIEnv.DeleteLocalRef (native_Source);
					}
					if (Dest != null) {
						JNIEnv.CopyArray (native_Dest, Dest);
						JNIEnv.DeleteLocalRef (native_Dest);
					}
					if (Inkey != null) {
						JNIEnv.CopyArray (native_Inkey, Inkey);
						JNIEnv.DeleteLocalRef (native_Inkey);
					}
					global::System.GC.KeepAlive (Source);
					global::System.GC.KeepAlive (Dest);
					global::System.GC.KeepAlive (Inkey);
				}
			}

			static Delegate? cb_Sm4_Api_arrayBIarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm4_Api_arrayBIarrayBarrayBarrayBIHandler ()
			{
				if (cb_Sm4_Api_arrayBIarrayBarrayBarrayBI == null)
					cb_Sm4_Api_arrayBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLI_I (n_Sm4_Api_arrayBIarrayBarrayBarrayBI));
				return cb_Sm4_Api_arrayBIarrayBarrayBarrayBI;
			}

			static int n_Sm4_Api_arrayBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_input, int inputLen, IntPtr native_outBuf, IntPtr native_smkey, IntPtr native_vector, int mode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var input = (byte[]?) JNIEnv.GetArray (native_input, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var outBuf = (byte[]?) JNIEnv.GetArray (native_outBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var smkey = (byte[]?) JNIEnv.GetArray (native_smkey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var vector = (byte[]?) JNIEnv.GetArray (native_vector, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm4_Api (input, inputLen, outBuf, smkey, vector, mode);
				if (input != null)
					JNIEnv.CopyArray (input, native_input);
				if (outBuf != null)
					JNIEnv.CopyArray (outBuf, native_outBuf);
				if (smkey != null)
					JNIEnv.CopyArray (smkey, native_smkey);
				if (vector != null)
					JNIEnv.CopyArray (vector, native_vector);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='Sm4_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("Sm4_Api", "([BI[B[B[BI)I", "GetSm4_Api_arrayBIarrayBarrayBarrayBIHandler")]
			public virtual unsafe int Sm4_Api (byte[]? input, int inputLen, byte[]? outBuf, byte[]? smkey, byte[]? vector, int mode)
			{
				const string __id = "Sm4_Api.([BI[B[B[BI)I";
				IntPtr native_input = JNIEnv.NewArray (input);
				IntPtr native_outBuf = JNIEnv.NewArray (outBuf);
				IntPtr native_smkey = JNIEnv.NewArray (smkey);
				IntPtr native_vector = JNIEnv.NewArray (vector);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (native_input);
					__args [1] = new JniArgumentValue (inputLen);
					__args [2] = new JniArgumentValue (native_outBuf);
					__args [3] = new JniArgumentValue (native_smkey);
					__args [4] = new JniArgumentValue (native_vector);
					__args [5] = new JniArgumentValue (mode);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (input != null) {
						JNIEnv.CopyArray (native_input, input);
						JNIEnv.DeleteLocalRef (native_input);
					}
					if (outBuf != null) {
						JNIEnv.CopyArray (native_outBuf, outBuf);
						JNIEnv.DeleteLocalRef (native_outBuf);
					}
					if (smkey != null) {
						JNIEnv.CopyArray (native_smkey, smkey);
						JNIEnv.DeleteLocalRef (native_smkey);
					}
					if (vector != null) {
						JNIEnv.CopyArray (native_vector, vector);
						JNIEnv.DeleteLocalRef (native_vector);
					}
					global::System.GC.KeepAlive (input);
					global::System.GC.KeepAlive (outBuf);
					global::System.GC.KeepAlive (smkey);
					global::System.GC.KeepAlive (vector);
				}
			}

			static Delegate? cb_SmGetRand_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSmGetRand_Api_IarrayBHandler ()
			{
				if (cb_SmGetRand_Api_IarrayB == null)
					cb_SmGetRand_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_SmGetRand_Api_IarrayB));
				return cb_SmGetRand_Api_IarrayB;
			}

			static int n_SmGetRand_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int Lc, IntPtr native_Rand)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Rand = (byte[]?) JNIEnv.GetArray (native_Rand, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SmGetRand_Api (Lc, Rand);
				if (Rand != null)
					JNIEnv.CopyArray (Rand, native_Rand);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='SmGetRand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("SmGetRand_Api", "(I[B)I", "GetSmGetRand_Api_IarrayBHandler")]
			public virtual unsafe int SmGetRand_Api (int Lc, byte[]? Rand)
			{
				const string __id = "SmGetRand_Api.(I[B)I";
				IntPtr native_Rand = JNIEnv.NewArray (Rand);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (Lc);
					__args [1] = new JniArgumentValue (native_Rand);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Rand != null) {
						JNIEnv.CopyArray (native_Rand, Rand);
						JNIEnv.DeleteLocalRef (native_Rand);
					}
					global::System.GC.KeepAlive (Rand);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_gmClose_Api;
#pragma warning disable 0169
			static Delegate GetGmClose_ApiHandler ()
			{
				if (cb_gmClose_Api == null)
					cb_gmClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GmClose_Api));
				return cb_gmClose_Api;
			}

			static int n_GmClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GmClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='gmClose_Api' and count(parameter)=0]"
			[Register ("gmClose_Api", "()I", "GetGmClose_ApiHandler")]
			public virtual unsafe int GmClose_Api ()
			{
				const string __id = "gmClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_gmOpen_Api;
#pragma warning disable 0169
			static Delegate GetGmOpen_ApiHandler ()
			{
				if (cb_gmOpen_Api == null)
					cb_gmOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GmOpen_Api));
				return cb_gmOpen_Api;
			}

			static int n_GmOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GmOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='gmOpen_Api' and count(parameter)=0]"
			[Register ("gmOpen_Api", "()I", "GetGmOpen_ApiHandler")]
			public virtual unsafe int GmOpen_Api ()
			{
				const string __id = "gmOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_sm2_Api_arrayBIarrayBIarrayBarrayIB;
#pragma warning disable 0169
			static Delegate GetSm2_Api_arrayBIarrayBIarrayBarrayIBHandler ()
			{
				if (cb_sm2_Api_arrayBIarrayBIarrayBarrayIB == null)
					cb_sm2_Api_arrayBIarrayBIarrayBarrayIB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILILLB_I (n_Sm2_Api_arrayBIarrayBIarrayBarrayIB));
				return cb_sm2_Api_arrayBIarrayBIarrayBarrayIB;
			}

			static int n_Sm2_Api_arrayBIarrayBIarrayBarrayIB (IntPtr jnienv, IntPtr native__this, IntPtr native_Key, int KeyLen, IntPtr native_Input, int InputLen, IntPtr native_Output, IntPtr native_OutputLen, sbyte Mode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Key = (byte[]?) JNIEnv.GetArray (native_Key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Input = (byte[]?) JNIEnv.GetArray (native_Input, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Output = (byte[]?) JNIEnv.GetArray (native_Output, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var OutputLen = (int[]?) JNIEnv.GetArray (native_OutputLen, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.Sm2_Api (Key, KeyLen, Input, InputLen, Output, OutputLen, Mode);
				if (Key != null)
					JNIEnv.CopyArray (Key, native_Key);
				if (Input != null)
					JNIEnv.CopyArray (Input, native_Input);
				if (Output != null)
					JNIEnv.CopyArray (Output, native_Output);
				if (OutputLen != null)
					JNIEnv.CopyArray (OutputLen, native_OutputLen);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Default']/method[@name='sm2_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int[]'] and parameter[7][@type='byte']]"
			[Register ("sm2_Api", "([BI[BI[B[IB)I", "GetSm2_Api_arrayBIarrayBIarrayBarrayIBHandler")]
			public virtual unsafe int Sm2_Api (byte[]? Key, int KeyLen, byte[]? Input, int InputLen, byte[]? Output, int[]? OutputLen, sbyte Mode)
			{
				const string __id = "sm2_Api.([BI[BI[B[IB)I";
				IntPtr native_Key = JNIEnv.NewArray (Key);
				IntPtr native_Input = JNIEnv.NewArray (Input);
				IntPtr native_Output = JNIEnv.NewArray (Output);
				IntPtr native_OutputLen = JNIEnv.NewArray (OutputLen);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_Key);
					__args [1] = new JniArgumentValue (KeyLen);
					__args [2] = new JniArgumentValue (native_Input);
					__args [3] = new JniArgumentValue (InputLen);
					__args [4] = new JniArgumentValue (native_Output);
					__args [5] = new JniArgumentValue (native_OutputLen);
					__args [6] = new JniArgumentValue (Mode);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Key != null) {
						JNIEnv.CopyArray (native_Key, Key);
						JNIEnv.DeleteLocalRef (native_Key);
					}
					if (Input != null) {
						JNIEnv.CopyArray (native_Input, Input);
						JNIEnv.DeleteLocalRef (native_Input);
					}
					if (Output != null) {
						JNIEnv.CopyArray (native_Output, Output);
						JNIEnv.DeleteLocalRef (native_Output);
					}
					if (OutputLen != null) {
						JNIEnv.CopyArray (native_OutputLen, OutputLen);
						JNIEnv.DeleteLocalRef (native_OutputLen);
					}
					global::System.GC.KeepAlive (Key);
					global::System.GC.KeepAlive (Input);
					global::System.GC.KeepAlive (Output);
					global::System.GC.KeepAlive (OutputLen);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sm/SmHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.SM.ISmHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sm/SmHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Stub']/constructor[@name='SmHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/sm/SmHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/sm/SmHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/sm/SmHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/sm/SmHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/class[@name='SmHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.sm.SmHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/sm/SmHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.SM.ISmHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/sm/SmHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSM2Verify_Api_arrayBIarrayBarrayBarrayBIHandler ()
			{
				if (cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI == null)
					cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLI_I (n_SM2Verify_Api_arrayBIarrayBarrayBarrayBI));
				return cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI;
			}

			static int n_SM2Verify_Api_arrayBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SM2Verify_Api (p0, p1, p2, p3, p4, p5);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SM2Verify_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("SM2Verify_Api", "([BI[B[B[BI)I", "GetSM2Verify_Api_arrayBIarrayBarrayBarrayBIHandler")]
			public abstract int SM2Verify_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5);

			static Delegate? cb_SM3Hash_Api_arrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetSM3Hash_Api_arrayBIarrayBHandler ()
			{
				if (cb_SM3Hash_Api_arrayBIarrayB == null)
					cb_SM3Hash_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_SM3Hash_Api_arrayBIarrayB));
				return cb_SM3Hash_Api_arrayBIarrayB;
			}

			static int n_SM3Hash_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SM3Hash_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SM3Hash_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("SM3Hash_Api", "([BI[B)I", "GetSM3Hash_Api_arrayBIarrayBHandler")]
			public abstract int SM3Hash_Api (byte[]? p0, int p1, byte[]? p2);

			static Delegate? cb_Sm1_Api_arrayBIarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm1_Api_arrayBIarrayBarrayBIHandler ()
			{
				if (cb_Sm1_Api_arrayBIarrayBarrayBI == null)
					cb_Sm1_Api_arrayBIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLI_I (n_Sm1_Api_arrayBIarrayBarrayBI));
				return cb_Sm1_Api_arrayBIarrayBarrayBI;
			}

			static int n_Sm1_Api_arrayBIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm1_Api (p0, p1, p2, p3, p4);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm1_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("Sm1_Api", "([BI[B[BI)I", "GetSm1_Api_arrayBIarrayBarrayBIHandler")]
			public abstract int Sm1_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4);

			static Delegate? cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetSm2ExportPKAll_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB == null)
					cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_Sm2ExportPKAll_Api_arrayBarrayBarrayB));
				return cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB;
			}

			static int n_Sm2ExportPKAll_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm2ExportPKAll_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2ExportPKAll_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("Sm2ExportPKAll_Api", "([B[B[B)I", "GetSm2ExportPKAll_Api_arrayBarrayBarrayBHandler")]
			public abstract int Sm2ExportPKAll_Api (byte[]? p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_Sm2ExportPK_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSm2ExportPK_Api_IarrayBHandler ()
			{
				if (cb_Sm2ExportPK_Api_IarrayB == null)
					cb_Sm2ExportPK_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sm2ExportPK_Api_IarrayB));
				return cb_Sm2ExportPK_Api_IarrayB;
			}

			static int n_Sm2ExportPK_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm2ExportPK_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2ExportPK_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("Sm2ExportPK_Api", "(I[B)I", "GetSm2ExportPK_Api_IarrayBHandler")]
			public abstract int Sm2ExportPK_Api (int p0, byte[]? p1);

			static Delegate? cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBIHandler ()
			{
				if (cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI == null)
					cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLLI_I (n_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI));
				return cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI;
			}

			static int n_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, int p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm2Sign_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2Sign_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("Sm2Sign_Api", "([BI[B[B[B[BI)I", "GetSm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBIHandler")]
			public abstract int Sm2Sign_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6);

			static Delegate? cb_Sm4Soft_Api_arrayBIarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm4Soft_Api_arrayBIarrayBarrayBIHandler ()
			{
				if (cb_Sm4Soft_Api_arrayBIarrayBarrayBI == null)
					cb_Sm4Soft_Api_arrayBIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLI_I (n_Sm4Soft_Api_arrayBIarrayBarrayBI));
				return cb_Sm4Soft_Api_arrayBIarrayBarrayBI;
			}

			static int n_Sm4Soft_Api_arrayBIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm4Soft_Api (p0, p1, p2, p3, p4);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm4Soft_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("Sm4Soft_Api", "([BI[B[BI)I", "GetSm4Soft_Api_arrayBIarrayBarrayBIHandler")]
			public abstract int Sm4Soft_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4);

			static Delegate? cb_Sm4_Api_arrayBIarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetSm4_Api_arrayBIarrayBarrayBarrayBIHandler ()
			{
				if (cb_Sm4_Api_arrayBIarrayBarrayBarrayBI == null)
					cb_Sm4_Api_arrayBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLI_I (n_Sm4_Api_arrayBIarrayBarrayBarrayBI));
				return cb_Sm4_Api_arrayBIarrayBarrayBarrayBI;
			}

			static int n_Sm4_Api_arrayBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Sm4_Api (p0, p1, p2, p3, p4, p5);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm4_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("Sm4_Api", "([BI[B[B[BI)I", "GetSm4_Api_arrayBIarrayBarrayBarrayBIHandler")]
			public abstract int Sm4_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5);

			static Delegate? cb_SmGetRand_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetSmGetRand_Api_IarrayBHandler ()
			{
				if (cb_SmGetRand_Api_IarrayB == null)
					cb_SmGetRand_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_SmGetRand_Api_IarrayB));
				return cb_SmGetRand_Api_IarrayB;
			}

			static int n_SmGetRand_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SmGetRand_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SmGetRand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("SmGetRand_Api", "(I[B)I", "GetSmGetRand_Api_IarrayBHandler")]
			public abstract int SmGetRand_Api (int p0, byte[]? p1);

			static Delegate? cb_gmClose_Api;
#pragma warning disable 0169
			static Delegate GetGmClose_ApiHandler ()
			{
				if (cb_gmClose_Api == null)
					cb_gmClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GmClose_Api));
				return cb_gmClose_Api;
			}

			static int n_GmClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GmClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='gmClose_Api' and count(parameter)=0]"
			[Register ("gmClose_Api", "()I", "GetGmClose_ApiHandler")]
			public abstract int GmClose_Api ();

			static Delegate? cb_gmOpen_Api;
#pragma warning disable 0169
			static Delegate GetGmOpen_ApiHandler ()
			{
				if (cb_gmOpen_Api == null)
					cb_gmOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GmOpen_Api));
				return cb_gmOpen_Api;
			}

			static int n_GmOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GmOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='gmOpen_Api' and count(parameter)=0]"
			[Register ("gmOpen_Api", "()I", "GetGmOpen_ApiHandler")]
			public abstract int GmOpen_Api ();

			static Delegate? cb_sm2_Api_arrayBIarrayBIarrayBarrayIB;
#pragma warning disable 0169
			static Delegate GetSm2_Api_arrayBIarrayBIarrayBarrayIBHandler ()
			{
				if (cb_sm2_Api_arrayBIarrayBIarrayBarrayIB == null)
					cb_sm2_Api_arrayBIarrayBIarrayBarrayIB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILILLB_I (n_Sm2_Api_arrayBIarrayBIarrayBarrayIB));
				return cb_sm2_Api_arrayBIarrayBIarrayBarrayIB;
			}

			static int n_Sm2_Api_arrayBIarrayBIarrayBarrayIB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5, sbyte p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (int[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.Sm2_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='sm2_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int[]'] and parameter[7][@type='byte']]"
			[Register ("sm2_Api", "([BI[BI[B[IB)I", "GetSm2_Api_arrayBIarrayBIarrayBarrayIBHandler")]
			public abstract int Sm2_Api (byte[]? p0, int p1, byte[]? p2, int p3, byte[]? p4, int[]? p5, sbyte p6);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sm/SmHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sm/SmHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SM2Verify_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("SM2Verify_Api", "([BI[B[B[BI)I", "GetSM2Verify_Api_arrayBIarrayBarrayBarrayBIHandler")]
			public override unsafe int SM2Verify_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5)
			{
				const string __id = "SM2Verify_Api.([BI[B[B[BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SM3Hash_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("SM3Hash_Api", "([BI[B)I", "GetSM3Hash_Api_arrayBIarrayBHandler")]
			public override unsafe int SM3Hash_Api (byte[]? p0, int p1, byte[]? p2)
			{
				const string __id = "SM3Hash_Api.([BI[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm1_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("Sm1_Api", "([BI[B[BI)I", "GetSm1_Api_arrayBIarrayBarrayBIHandler")]
			public override unsafe int Sm1_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4)
			{
				const string __id = "Sm1_Api.([BI[B[BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2ExportPKAll_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("Sm2ExportPKAll_Api", "([B[B[B)I", "GetSm2ExportPKAll_Api_arrayBarrayBarrayBHandler")]
			public override unsafe int Sm2ExportPKAll_Api (byte[]? p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "Sm2ExportPKAll_Api.([B[B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
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
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2ExportPK_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("Sm2ExportPK_Api", "(I[B)I", "GetSm2ExportPK_Api_IarrayBHandler")]
			public override unsafe int Sm2ExportPK_Api (int p0, byte[]? p1)
			{
				const string __id = "Sm2ExportPK_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm2Sign_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("Sm2Sign_Api", "([BI[B[B[B[BI)I", "GetSm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBIHandler")]
			public override unsafe int Sm2Sign_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6)
			{
				const string __id = "Sm2Sign_Api.([BI[B[B[B[BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm4Soft_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("Sm4Soft_Api", "([BI[B[BI)I", "GetSm4Soft_Api_arrayBIarrayBarrayBIHandler")]
			public override unsafe int Sm4Soft_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4)
			{
				const string __id = "Sm4Soft_Api.([BI[B[BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='Sm4_Api' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("Sm4_Api", "([BI[B[B[BI)I", "GetSm4_Api_arrayBIarrayBarrayBarrayBIHandler")]
			public override unsafe int Sm4_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5)
			{
				const string __id = "Sm4_Api.([BI[B[B[BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='SmGetRand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("SmGetRand_Api", "(I[B)I", "GetSmGetRand_Api_IarrayBHandler")]
			public override unsafe int SmGetRand_Api (int p0, byte[]? p1)
			{
				const string __id = "SmGetRand_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='gmClose_Api' and count(parameter)=0]"
			[Register ("gmClose_Api", "()I", "GetGmClose_ApiHandler")]
			public override unsafe int GmClose_Api ()
			{
				const string __id = "gmClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='gmOpen_Api' and count(parameter)=0]"
			[Register ("gmOpen_Api", "()I", "GetGmOpen_ApiHandler")]
			public override unsafe int GmOpen_Api ()
			{
				const string __id = "gmOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.sm']/interface[@name='SmHandler']/method[@name='sm2_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int[]'] and parameter[7][@type='byte']]"
			[Register ("sm2_Api", "([BI[BI[B[IB)I", "GetSm2_Api_arrayBIarrayBIarrayBarrayIBHandler")]
			public override unsafe int Sm2_Api (byte[]? p0, int p1, byte[]? p2, int p3, byte[]? p4, int[]? p5, sbyte p6)
			{
				const string __id = "sm2_Api.([BI[BI[B[IB)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/sm/SmHandler", DoNotGenerateAcw=true)]
	internal partial class ISmHandlerInvoker : global::Java.Lang.Object, ISmHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/sm/SmHandler", typeof (ISmHandlerInvoker));

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

		public static ISmHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISmHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.sm.SmHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISmHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetSM2Verify_Api_arrayBIarrayBarrayBarrayBIHandler ()
		{
			if (cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI == null)
				cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLI_I (n_SM2Verify_Api_arrayBIarrayBarrayBarrayBI));
			return cb_SM2Verify_Api_arrayBIarrayBarrayBarrayBI;
		}

		static int n_SM2Verify_Api_arrayBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SM2Verify_Api (p0, p1, p2, p3, p4, p5);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SM2Verify_Api_arrayBIarrayBarrayBarrayBI;
		public unsafe int SM2Verify_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5)
		{
			if (id_SM2Verify_Api_arrayBIarrayBarrayBarrayBI == IntPtr.Zero)
				id_SM2Verify_Api_arrayBIarrayBarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "SM2Verify_Api", "([BI[B[B[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SM2Verify_Api_arrayBIarrayBarrayBarrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_SM3Hash_Api_arrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetSM3Hash_Api_arrayBIarrayBHandler ()
		{
			if (cb_SM3Hash_Api_arrayBIarrayB == null)
				cb_SM3Hash_Api_arrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_I (n_SM3Hash_Api_arrayBIarrayB));
			return cb_SM3Hash_Api_arrayBIarrayB;
		}

		static int n_SM3Hash_Api_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SM3Hash_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SM3Hash_Api_arrayBIarrayB;
		public unsafe int SM3Hash_Api (byte[]? p0, int p1, byte[]? p2)
		{
			if (id_SM3Hash_Api_arrayBIarrayB == IntPtr.Zero)
				id_SM3Hash_Api_arrayBIarrayB = JNIEnv.GetMethodID (class_ref, "SM3Hash_Api", "([BI[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SM3Hash_Api_arrayBIarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_Sm1_Api_arrayBIarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetSm1_Api_arrayBIarrayBarrayBIHandler ()
		{
			if (cb_Sm1_Api_arrayBIarrayBarrayBI == null)
				cb_Sm1_Api_arrayBIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLI_I (n_Sm1_Api_arrayBIarrayBarrayBI));
			return cb_Sm1_Api_arrayBIarrayBarrayBI;
		}

		static int n_Sm1_Api_arrayBIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sm1_Api (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Sm1_Api_arrayBIarrayBarrayBI;
		public unsafe int Sm1_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4)
		{
			if (id_Sm1_Api_arrayBIarrayBarrayBI == IntPtr.Zero)
				id_Sm1_Api_arrayBIarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "Sm1_Api", "([BI[B[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Sm1_Api_arrayBIarrayBarrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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

		static Delegate? cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSm2ExportPKAll_Api_arrayBarrayBarrayBHandler ()
		{
			if (cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB == null)
				cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_Sm2ExportPKAll_Api_arrayBarrayBarrayB));
			return cb_Sm2ExportPKAll_Api_arrayBarrayBarrayB;
		}

		static int n_Sm2ExportPKAll_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sm2ExportPKAll_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Sm2ExportPKAll_Api_arrayBarrayBarrayB;
		public unsafe int Sm2ExportPKAll_Api (byte[]? p0, byte[]? p1, byte[]? p2)
		{
			if (id_Sm2ExportPKAll_Api_arrayBarrayBarrayB == IntPtr.Zero)
				id_Sm2ExportPKAll_Api_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "Sm2ExportPKAll_Api", "([B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Sm2ExportPKAll_Api_arrayBarrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_Sm2ExportPK_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetSm2ExportPK_Api_IarrayBHandler ()
		{
			if (cb_Sm2ExportPK_Api_IarrayB == null)
				cb_Sm2ExportPK_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_Sm2ExportPK_Api_IarrayB));
			return cb_Sm2ExportPK_Api_IarrayB;
		}

		static int n_Sm2ExportPK_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sm2ExportPK_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Sm2ExportPK_Api_IarrayB;
		public unsafe int Sm2ExportPK_Api (int p0, byte[]? p1)
		{
			if (id_Sm2ExportPK_Api_IarrayB == IntPtr.Zero)
				id_Sm2ExportPK_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "Sm2ExportPK_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Sm2ExportPK_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetSm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBIHandler ()
		{
			if (cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI == null)
				cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLLI_I (n_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI));
			return cb_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI;
		}

		static int n_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, int p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sm2Sign_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI;
		public unsafe int Sm2Sign_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6)
		{
			if (id_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI == IntPtr.Zero)
				id_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "Sm2Sign_Api", "([BI[B[B[B[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Sm2Sign_Api_arrayBIarrayBarrayBarrayBarrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_Sm4Soft_Api_arrayBIarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetSm4Soft_Api_arrayBIarrayBarrayBIHandler ()
		{
			if (cb_Sm4Soft_Api_arrayBIarrayBarrayBI == null)
				cb_Sm4Soft_Api_arrayBIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLI_I (n_Sm4Soft_Api_arrayBIarrayBarrayBI));
			return cb_Sm4Soft_Api_arrayBIarrayBarrayBI;
		}

		static int n_Sm4Soft_Api_arrayBIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sm4Soft_Api (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Sm4Soft_Api_arrayBIarrayBarrayBI;
		public unsafe int Sm4Soft_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, int p4)
		{
			if (id_Sm4Soft_Api_arrayBIarrayBarrayBI == IntPtr.Zero)
				id_Sm4Soft_Api_arrayBIarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "Sm4Soft_Api", "([BI[B[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Sm4Soft_Api_arrayBIarrayBarrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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

		static Delegate? cb_Sm4_Api_arrayBIarrayBarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetSm4_Api_arrayBIarrayBarrayBarrayBIHandler ()
		{
			if (cb_Sm4_Api_arrayBIarrayBarrayBarrayBI == null)
				cb_Sm4_Api_arrayBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILLLI_I (n_Sm4_Api_arrayBIarrayBarrayBarrayBI));
			return cb_Sm4_Api_arrayBIarrayBarrayBarrayBI;
		}

		static int n_Sm4_Api_arrayBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sm4_Api (p0, p1, p2, p3, p4, p5);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Sm4_Api_arrayBIarrayBarrayBarrayBI;
		public unsafe int Sm4_Api (byte[]? p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4, int p5)
		{
			if (id_Sm4_Api_arrayBIarrayBarrayBarrayBI == IntPtr.Zero)
				id_Sm4_Api_arrayBIarrayBarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "Sm4_Api", "([BI[B[B[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Sm4_Api_arrayBIarrayBarrayBarrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_SmGetRand_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetSmGetRand_Api_IarrayBHandler ()
		{
			if (cb_SmGetRand_Api_IarrayB == null)
				cb_SmGetRand_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_SmGetRand_Api_IarrayB));
			return cb_SmGetRand_Api_IarrayB;
		}

		static int n_SmGetRand_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SmGetRand_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SmGetRand_Api_IarrayB;
		public unsafe int SmGetRand_Api (int p0, byte[]? p1)
		{
			if (id_SmGetRand_Api_IarrayB == IntPtr.Zero)
				id_SmGetRand_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "SmGetRand_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SmGetRand_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_gmClose_Api;
#pragma warning disable 0169
		static Delegate GetGmClose_ApiHandler ()
		{
			if (cb_gmClose_Api == null)
				cb_gmClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GmClose_Api));
			return cb_gmClose_Api;
		}

		static int n_GmClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GmClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_gmClose_Api;
		public unsafe int GmClose_Api ()
		{
			if (id_gmClose_Api == IntPtr.Zero)
				id_gmClose_Api = JNIEnv.GetMethodID (class_ref, "gmClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_gmClose_Api);
		}

		static Delegate? cb_gmOpen_Api;
#pragma warning disable 0169
		static Delegate GetGmOpen_ApiHandler ()
		{
			if (cb_gmOpen_Api == null)
				cb_gmOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GmOpen_Api));
			return cb_gmOpen_Api;
		}

		static int n_GmOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GmOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_gmOpen_Api;
		public unsafe int GmOpen_Api ()
		{
			if (id_gmOpen_Api == IntPtr.Zero)
				id_gmOpen_Api = JNIEnv.GetMethodID (class_ref, "gmOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_gmOpen_Api);
		}

		static Delegate? cb_sm2_Api_arrayBIarrayBIarrayBarrayIB;
#pragma warning disable 0169
		static Delegate GetSm2_Api_arrayBIarrayBIarrayBarrayIBHandler ()
		{
			if (cb_sm2_Api_arrayBIarrayBIarrayBarrayIB == null)
				cb_sm2_Api_arrayBIarrayBIarrayBarrayIB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILILLB_I (n_Sm2_Api_arrayBIarrayBIarrayBarrayIB));
			return cb_sm2_Api_arrayBIarrayBIarrayBarrayIB;
		}

		static int n_Sm2_Api_arrayBIarrayBIarrayBarrayIB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5, sbyte p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (int[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.Sm2_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sm2_Api_arrayBIarrayBIarrayBarrayIB;
		public unsafe int Sm2_Api (byte[]? p0, int p1, byte[]? p2, int p3, byte[]? p4, int[]? p5, sbyte p6)
		{
			if (id_sm2_Api_arrayBIarrayBIarrayBarrayIB == IntPtr.Zero)
				id_sm2_Api_arrayBIarrayBIarrayBarrayIB = JNIEnv.GetMethodID (class_ref, "sm2_Api", "([BI[BI[B[IB)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sm2_Api_arrayBIarrayBIarrayBarrayIB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.SM.ISmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
