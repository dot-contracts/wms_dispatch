using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Hsm {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']"
	[Register ("com/vanstone/appsdk/api/hsm/HsmHandler", "", "Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker")]
	public partial interface IHsmHandler : global::Android.OS.IInterface {
		long FreeSpace_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='getFreeSpace_Api' and count(parameter)=0]"
			[Register ("getFreeSpace_Api", "()J", "GetGetFreeSpace_ApiHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		bool IsTampered_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='isTampered_Api' and count(parameter)=0]"
			[Register ("isTampered_Api", "()Z", "GetIsTampered_ApiHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='decrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("decrypt_Api", "(ILjava/lang/String;[B)[B", "GetDecrypt_Api_ILjava_lang_String_arrayBHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		byte[]? Decrypt_Api (int p0, string? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='deleteCertificate_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteCertificate_Api", "(ILjava/lang/String;)Z", "GetDeleteCertificate_Api_ILjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		bool DeleteCertificate_Api (int p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='deleteKeyPair_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteKeyPair_Api", "(Ljava/lang/String;)Z", "GetDeleteKeyPair_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		bool DeleteKeyPair_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='encrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("encrypt_Api", "(ILjava/lang/String;[B)[B", "GetEncrypt_Api_ILjava_lang_String_arrayBHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		byte[]? Encrypt_Api (int p0, string? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateCSR_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("generateCSR_Api", "(Ljava/lang/String;Landroid/os/Bundle;)[B", "GetGenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		byte[]? GenerateCSR_Api (string? p0, global::Android.OS.Bundle? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateKeyPair_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("generateKeyPair_Api", "(Ljava/lang/String;II)Z", "GetGenerateKeyPair_Api_Ljava_lang_String_IIHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		bool GenerateKeyPair_Api (string? p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateRandom_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("generateRandom_Api", "(I)[B", "GetGenerateRandom_Api_IHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		byte[]? GenerateRandom_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='getCertificate_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getCertificate_Api", "(ILjava/lang/String;I)[B", "GetGetCertificate_Api_ILjava_lang_String_IHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		byte[]? GetCertificate_Api (int p0, string? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectPrivateKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("injectPrivateKey_Api", "([BI)Z", "GetInjectPrivateKey_Api_arrayBIHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		bool InjectPrivateKey_Api (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectPublicKeyCertificate_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("injectPublicKeyCertificate_Api", "(Ljava/lang/String;Ljava/lang/String;[BI)Z", "GetInjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBIHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		bool InjectPublicKeyCertificate_Api (string? p0, string? p1, byte[]? p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectRootCertificate_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("injectRootCertificate_Api", "(ILjava/lang/String;[BI)Z", "GetInjectRootCertificate_Api_ILjava_lang_String_arrayBIHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		bool InjectRootCertificate_Api (int p0, string? p1, byte[]? p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='queryCertificates_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("queryCertificates_Api", "(I)[Ljava/lang/String;", "GetQueryCertificates_Api_IHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		string[]? QueryCertificates_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='resetKeyStore_Api' and count(parameter)=0]"
		[Register ("resetKeyStore_Api", "()V", "GetResetKeyStore_ApiHandler:Com.Vanstone.Appsdk.Api.Hsm.IHsmHandlerInvoker, VanstonePosSdk")]
		void ResetKeyStore_Api ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/hsm/HsmHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/hsm/HsmHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/constructor[@name='HsmHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_getFreeSpace_Api;
#pragma warning disable 0169
			static Delegate GetGetFreeSpace_ApiHandler ()
			{
				if (cb_getFreeSpace_Api == null)
					cb_getFreeSpace_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetFreeSpace_Api));
				return cb_getFreeSpace_Api;
			}

			static long n_GetFreeSpace_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FreeSpace_Api;
			}
#pragma warning restore 0169

			public virtual unsafe long FreeSpace_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='getFreeSpace_Api' and count(parameter)=0]"
				[Register ("getFreeSpace_Api", "()J", "GetGetFreeSpace_ApiHandler")]
				get {
					const string __id = "getFreeSpace_Api.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_isTampered_Api;
#pragma warning disable 0169
			static Delegate GetIsTampered_ApiHandler ()
			{
				if (cb_isTampered_Api == null)
					cb_isTampered_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsTampered_Api));
				return cb_isTampered_Api;
			}

			static bool n_IsTampered_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsTampered_Api;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsTampered_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='isTampered_Api' and count(parameter)=0]"
				[Register ("isTampered_Api", "()Z", "GetIsTampered_ApiHandler")]
				get {
					const string __id = "isTampered_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_decrypt_Api_ILjava_lang_String_arrayB;
#pragma warning disable 0169
			static Delegate GetDecrypt_Api_ILjava_lang_String_arrayBHandler ()
			{
				if (cb_decrypt_Api_ILjava_lang_String_arrayB == null)
					cb_decrypt_Api_ILjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_L (n_Decrypt_Api_ILjava_lang_String_arrayB));
				return cb_decrypt_Api_ILjava_lang_String_arrayB;
			}

			static IntPtr n_Decrypt_Api_ILjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int algorithm, IntPtr native_aliasPrivateKey, IntPtr native_bufCipher)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aliasPrivateKey = JNIEnv.GetString (native_aliasPrivateKey, JniHandleOwnership.DoNotTransfer);
				var bufCipher = (byte[]?) JNIEnv.GetArray (native_bufCipher, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Decrypt_Api (algorithm, aliasPrivateKey, bufCipher));
				if (bufCipher != null)
					JNIEnv.CopyArray (bufCipher, native_bufCipher);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='decrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
			[Register ("decrypt_Api", "(ILjava/lang/String;[B)[B", "GetDecrypt_Api_ILjava_lang_String_arrayBHandler")]
			public virtual unsafe byte[]? Decrypt_Api (int algorithm, string? aliasPrivateKey, byte[]? bufCipher)
			{
				const string __id = "decrypt_Api.(ILjava/lang/String;[B)[B";
				IntPtr native_aliasPrivateKey = JNIEnv.NewString ((string?)aliasPrivateKey);
				IntPtr native_bufCipher = JNIEnv.NewArray (bufCipher);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (algorithm);
					__args [1] = new JniArgumentValue (native_aliasPrivateKey);
					__args [2] = new JniArgumentValue (native_bufCipher);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_aliasPrivateKey);
					if (bufCipher != null) {
						JNIEnv.CopyArray (native_bufCipher, bufCipher);
						JNIEnv.DeleteLocalRef (native_bufCipher);
					}
					global::System.GC.KeepAlive (bufCipher);
				}
			}

			static Delegate? cb_deleteCertificate_Api_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteCertificate_Api_ILjava_lang_String_Handler ()
			{
				if (cb_deleteCertificate_Api_ILjava_lang_String_ == null)
					cb_deleteCertificate_Api_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_Z (n_DeleteCertificate_Api_ILjava_lang_String_));
				return cb_deleteCertificate_Api_ILjava_lang_String_;
			}

			static bool n_DeleteCertificate_Api_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int certType, IntPtr native_alias)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DeleteCertificate_Api (certType, alias);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='deleteCertificate_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("deleteCertificate_Api", "(ILjava/lang/String;)Z", "GetDeleteCertificate_Api_ILjava_lang_String_Handler")]
			public virtual unsafe bool DeleteCertificate_Api (int certType, string? alias)
			{
				const string __id = "deleteCertificate_Api.(ILjava/lang/String;)Z";
				IntPtr native_alias = JNIEnv.NewString ((string?)alias);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (certType);
					__args [1] = new JniArgumentValue (native_alias);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_alias);
				}
			}

			static Delegate? cb_deleteKeyPair_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteKeyPair_Api_Ljava_lang_String_Handler ()
			{
				if (cb_deleteKeyPair_Api_Ljava_lang_String_ == null)
					cb_deleteKeyPair_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_DeleteKeyPair_Api_Ljava_lang_String_));
				return cb_deleteKeyPair_Api_Ljava_lang_String_;
			}

			static bool n_DeleteKeyPair_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aliasPrivateKey)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aliasPrivateKey = JNIEnv.GetString (native_aliasPrivateKey, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DeleteKeyPair_Api (aliasPrivateKey);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='deleteKeyPair_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteKeyPair_Api", "(Ljava/lang/String;)Z", "GetDeleteKeyPair_Api_Ljava_lang_String_Handler")]
			public virtual unsafe bool DeleteKeyPair_Api (string? aliasPrivateKey)
			{
				const string __id = "deleteKeyPair_Api.(Ljava/lang/String;)Z";
				IntPtr native_aliasPrivateKey = JNIEnv.NewString ((string?)aliasPrivateKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_aliasPrivateKey);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_aliasPrivateKey);
				}
			}

			static Delegate? cb_encrypt_Api_ILjava_lang_String_arrayB;
#pragma warning disable 0169
			static Delegate GetEncrypt_Api_ILjava_lang_String_arrayBHandler ()
			{
				if (cb_encrypt_Api_ILjava_lang_String_arrayB == null)
					cb_encrypt_Api_ILjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_L (n_Encrypt_Api_ILjava_lang_String_arrayB));
				return cb_encrypt_Api_ILjava_lang_String_arrayB;
			}

			static IntPtr n_Encrypt_Api_ILjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int algorithm, IntPtr native_aliasPrivateKey, IntPtr native_bufPlain)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aliasPrivateKey = JNIEnv.GetString (native_aliasPrivateKey, JniHandleOwnership.DoNotTransfer);
				var bufPlain = (byte[]?) JNIEnv.GetArray (native_bufPlain, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Encrypt_Api (algorithm, aliasPrivateKey, bufPlain));
				if (bufPlain != null)
					JNIEnv.CopyArray (bufPlain, native_bufPlain);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='encrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
			[Register ("encrypt_Api", "(ILjava/lang/String;[B)[B", "GetEncrypt_Api_ILjava_lang_String_arrayBHandler")]
			public virtual unsafe byte[]? Encrypt_Api (int algorithm, string? aliasPrivateKey, byte[]? bufPlain)
			{
				const string __id = "encrypt_Api.(ILjava/lang/String;[B)[B";
				IntPtr native_aliasPrivateKey = JNIEnv.NewString ((string?)aliasPrivateKey);
				IntPtr native_bufPlain = JNIEnv.NewArray (bufPlain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (algorithm);
					__args [1] = new JniArgumentValue (native_aliasPrivateKey);
					__args [2] = new JniArgumentValue (native_bufPlain);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_aliasPrivateKey);
					if (bufPlain != null) {
						JNIEnv.CopyArray (native_bufPlain, bufPlain);
						JNIEnv.DeleteLocalRef (native_bufPlain);
					}
					global::System.GC.KeepAlive (bufPlain);
				}
			}

			static Delegate? cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetGenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_Handler ()
			{
				if (cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ == null)
					cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_));
				return cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_;
			}

			static IntPtr n_GenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aliasPrivateKey, IntPtr native_subject)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aliasPrivateKey = JNIEnv.GetString (native_aliasPrivateKey, JniHandleOwnership.DoNotTransfer);
				var subject = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_subject, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.GenerateCSR_Api (aliasPrivateKey, subject));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='generateCSR_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("generateCSR_Api", "(Ljava/lang/String;Landroid/os/Bundle;)[B", "GetGenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_Handler")]
			public virtual unsafe byte[]? GenerateCSR_Api (string? aliasPrivateKey, global::Android.OS.Bundle? subject)
			{
				const string __id = "generateCSR_Api.(Ljava/lang/String;Landroid/os/Bundle;)[B";
				IntPtr native_aliasPrivateKey = JNIEnv.NewString ((string?)aliasPrivateKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_aliasPrivateKey);
					__args [1] = new JniArgumentValue ((subject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subject).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_aliasPrivateKey);
					global::System.GC.KeepAlive (subject);
				}
			}

			static Delegate? cb_generateKeyPair_Api_Ljava_lang_String_II;
#pragma warning disable 0169
			static Delegate GetGenerateKeyPair_Api_Ljava_lang_String_IIHandler ()
			{
				if (cb_generateKeyPair_Api_Ljava_lang_String_II == null)
					cb_generateKeyPair_Api_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_Z (n_GenerateKeyPair_Api_Ljava_lang_String_II));
				return cb_generateKeyPair_Api_Ljava_lang_String_II;
			}

			static bool n_GenerateKeyPair_Api_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_aliasPrivateKey, int algorithm, int keySize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aliasPrivateKey = JNIEnv.GetString (native_aliasPrivateKey, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GenerateKeyPair_Api (aliasPrivateKey, algorithm, keySize);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='generateKeyPair_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("generateKeyPair_Api", "(Ljava/lang/String;II)Z", "GetGenerateKeyPair_Api_Ljava_lang_String_IIHandler")]
			public virtual unsafe bool GenerateKeyPair_Api (string? aliasPrivateKey, int algorithm, int keySize)
			{
				const string __id = "generateKeyPair_Api.(Ljava/lang/String;II)Z";
				IntPtr native_aliasPrivateKey = JNIEnv.NewString ((string?)aliasPrivateKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_aliasPrivateKey);
					__args [1] = new JniArgumentValue (algorithm);
					__args [2] = new JniArgumentValue (keySize);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_aliasPrivateKey);
				}
			}

			static Delegate? cb_generateRandom_Api_I;
#pragma warning disable 0169
			static Delegate GetGenerateRandom_Api_IHandler ()
			{
				if (cb_generateRandom_Api_I == null)
					cb_generateRandom_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_GenerateRandom_Api_I));
				return cb_generateRandom_Api_I;
			}

			static IntPtr n_GenerateRandom_Api_I (IntPtr jnienv, IntPtr native__this, int length)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GenerateRandom_Api (length));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='generateRandom_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("generateRandom_Api", "(I)[B", "GetGenerateRandom_Api_IHandler")]
			public virtual unsafe byte[]? GenerateRandom_Api (int length)
			{
				const string __id = "generateRandom_Api.(I)[B";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (length);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate? cb_getCertificate_Api_ILjava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetGetCertificate_Api_ILjava_lang_String_IHandler ()
			{
				if (cb_getCertificate_Api_ILjava_lang_String_I == null)
					cb_getCertificate_Api_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_L (n_GetCertificate_Api_ILjava_lang_String_I));
				return cb_getCertificate_Api_ILjava_lang_String_I;
			}

			static IntPtr n_GetCertificate_Api_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int certType, IntPtr native_alias, int dataFormat)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.GetCertificate_Api (certType, alias, dataFormat));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='getCertificate_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("getCertificate_Api", "(ILjava/lang/String;I)[B", "GetGetCertificate_Api_ILjava_lang_String_IHandler")]
			public virtual unsafe byte[]? GetCertificate_Api (int certType, string? alias, int dataFormat)
			{
				const string __id = "getCertificate_Api.(ILjava/lang/String;I)[B";
				IntPtr native_alias = JNIEnv.NewString ((string?)alias);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (certType);
					__args [1] = new JniArgumentValue (native_alias);
					__args [2] = new JniArgumentValue (dataFormat);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_alias);
				}
			}

			static Delegate? cb_injectPrivateKey_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetInjectPrivateKey_Api_arrayBIHandler ()
			{
				if (cb_injectPrivateKey_Api_arrayBI == null)
					cb_injectPrivateKey_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_Z (n_InjectPrivateKey_Api_arrayBI));
				return cb_injectPrivateKey_Api_arrayBI;
			}

			static bool n_InjectPrivateKey_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_keyBuffer, int dataFormat)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var keyBuffer = (byte[]?) JNIEnv.GetArray (native_keyBuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.InjectPrivateKey_Api (keyBuffer, dataFormat);
				if (keyBuffer != null)
					JNIEnv.CopyArray (keyBuffer, native_keyBuffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='injectPrivateKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("injectPrivateKey_Api", "([BI)Z", "GetInjectPrivateKey_Api_arrayBIHandler")]
			public virtual unsafe bool InjectPrivateKey_Api (byte[]? keyBuffer, int dataFormat)
			{
				const string __id = "injectPrivateKey_Api.([BI)Z";
				IntPtr native_keyBuffer = JNIEnv.NewArray (keyBuffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_keyBuffer);
					__args [1] = new JniArgumentValue (dataFormat);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					if (keyBuffer != null) {
						JNIEnv.CopyArray (native_keyBuffer, keyBuffer);
						JNIEnv.DeleteLocalRef (native_keyBuffer);
					}
					global::System.GC.KeepAlive (keyBuffer);
				}
			}

			static Delegate? cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI;
#pragma warning disable 0169
			static Delegate GetInjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBIHandler ()
			{
				if (cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI == null)
					cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLI_Z (n_InjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI));
				return cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI;
			}

			static bool n_InjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_alias, IntPtr native_aliasPrivateKey, IntPtr native_bufCert, int dataFormat)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
				var aliasPrivateKey = JNIEnv.GetString (native_aliasPrivateKey, JniHandleOwnership.DoNotTransfer);
				var bufCert = (byte[]?) JNIEnv.GetArray (native_bufCert, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.InjectPublicKeyCertificate_Api (alias, aliasPrivateKey, bufCert, dataFormat);
				if (bufCert != null)
					JNIEnv.CopyArray (bufCert, native_bufCert);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='injectPublicKeyCertificate_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("injectPublicKeyCertificate_Api", "(Ljava/lang/String;Ljava/lang/String;[BI)Z", "GetInjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBIHandler")]
			public virtual unsafe bool InjectPublicKeyCertificate_Api (string? alias, string? aliasPrivateKey, byte[]? bufCert, int dataFormat)
			{
				const string __id = "injectPublicKeyCertificate_Api.(Ljava/lang/String;Ljava/lang/String;[BI)Z";
				IntPtr native_alias = JNIEnv.NewString ((string?)alias);
				IntPtr native_aliasPrivateKey = JNIEnv.NewString ((string?)aliasPrivateKey);
				IntPtr native_bufCert = JNIEnv.NewArray (bufCert);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_alias);
					__args [1] = new JniArgumentValue (native_aliasPrivateKey);
					__args [2] = new JniArgumentValue (native_bufCert);
					__args [3] = new JniArgumentValue (dataFormat);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_alias);
					JNIEnv.DeleteLocalRef (native_aliasPrivateKey);
					if (bufCert != null) {
						JNIEnv.CopyArray (native_bufCert, bufCert);
						JNIEnv.DeleteLocalRef (native_bufCert);
					}
					global::System.GC.KeepAlive (bufCert);
				}
			}

			static Delegate? cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI;
#pragma warning disable 0169
			static Delegate GetInjectRootCertificate_Api_ILjava_lang_String_arrayBIHandler ()
			{
				if (cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI == null)
					cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLI_Z (n_InjectRootCertificate_Api_ILjava_lang_String_arrayBI));
				return cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI;
			}

			static bool n_InjectRootCertificate_Api_ILjava_lang_String_arrayBI (IntPtr jnienv, IntPtr native__this, int certType, IntPtr native_alias, IntPtr native_bufCert, int dataFormat)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
				var bufCert = (byte[]?) JNIEnv.GetArray (native_bufCert, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.InjectRootCertificate_Api (certType, alias, bufCert, dataFormat);
				if (bufCert != null)
					JNIEnv.CopyArray (bufCert, native_bufCert);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='injectRootCertificate_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("injectRootCertificate_Api", "(ILjava/lang/String;[BI)Z", "GetInjectRootCertificate_Api_ILjava_lang_String_arrayBIHandler")]
			public virtual unsafe bool InjectRootCertificate_Api (int certType, string? alias, byte[]? bufCert, int dataFormat)
			{
				const string __id = "injectRootCertificate_Api.(ILjava/lang/String;[BI)Z";
				IntPtr native_alias = JNIEnv.NewString ((string?)alias);
				IntPtr native_bufCert = JNIEnv.NewArray (bufCert);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (certType);
					__args [1] = new JniArgumentValue (native_alias);
					__args [2] = new JniArgumentValue (native_bufCert);
					__args [3] = new JniArgumentValue (dataFormat);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_alias);
					if (bufCert != null) {
						JNIEnv.CopyArray (native_bufCert, bufCert);
						JNIEnv.DeleteLocalRef (native_bufCert);
					}
					global::System.GC.KeepAlive (bufCert);
				}
			}

			static Delegate? cb_queryCertificates_Api_I;
#pragma warning disable 0169
			static Delegate GetQueryCertificates_Api_IHandler ()
			{
				if (cb_queryCertificates_Api_I == null)
					cb_queryCertificates_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_QueryCertificates_Api_I));
				return cb_queryCertificates_Api_I;
			}

			static IntPtr n_QueryCertificates_Api_I (IntPtr jnienv, IntPtr native__this, int certType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.QueryCertificates_Api (certType));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='queryCertificates_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("queryCertificates_Api", "(I)[Ljava/lang/String;", "GetQueryCertificates_Api_IHandler")]
			public virtual unsafe string[]? QueryCertificates_Api (int certType)
			{
				const string __id = "queryCertificates_Api.(I)[Ljava/lang/String;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (certType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate? cb_resetKeyStore_Api;
#pragma warning disable 0169
			static Delegate GetResetKeyStore_ApiHandler ()
			{
				if (cb_resetKeyStore_Api == null)
					cb_resetKeyStore_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ResetKeyStore_Api));
				return cb_resetKeyStore_Api;
			}

			static void n_ResetKeyStore_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.ResetKeyStore_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Default']/method[@name='resetKeyStore_Api' and count(parameter)=0]"
			[Register ("resetKeyStore_Api", "()V", "GetResetKeyStore_ApiHandler")]
			public virtual unsafe void ResetKeyStore_Api ()
			{
				const string __id = "resetKeyStore_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/hsm/HsmHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/hsm/HsmHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/constructor[@name='HsmHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/hsm/HsmHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/hsm/HsmHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/hsm/HsmHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/hsm/HsmHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.hsm.HsmHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/hsm/HsmHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/hsm/HsmHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_decrypt_Api_ILjava_lang_String_arrayB;
#pragma warning disable 0169
			static Delegate GetDecrypt_Api_ILjava_lang_String_arrayBHandler ()
			{
				if (cb_decrypt_Api_ILjava_lang_String_arrayB == null)
					cb_decrypt_Api_ILjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_L (n_Decrypt_Api_ILjava_lang_String_arrayB));
				return cb_decrypt_Api_ILjava_lang_String_arrayB;
			}

			static IntPtr n_Decrypt_Api_ILjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Decrypt_Api (p0, p1, p2));
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='decrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
			[Register ("decrypt_Api", "(ILjava/lang/String;[B)[B", "GetDecrypt_Api_ILjava_lang_String_arrayBHandler")]
			public abstract byte[]? Decrypt_Api (int p0, string? p1, byte[]? p2);

			static Delegate? cb_deleteCertificate_Api_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteCertificate_Api_ILjava_lang_String_Handler ()
			{
				if (cb_deleteCertificate_Api_ILjava_lang_String_ == null)
					cb_deleteCertificate_Api_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_Z (n_DeleteCertificate_Api_ILjava_lang_String_));
				return cb_deleteCertificate_Api_ILjava_lang_String_;
			}

			static bool n_DeleteCertificate_Api_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DeleteCertificate_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='deleteCertificate_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("deleteCertificate_Api", "(ILjava/lang/String;)Z", "GetDeleteCertificate_Api_ILjava_lang_String_Handler")]
			public abstract bool DeleteCertificate_Api (int p0, string? p1);

			static Delegate? cb_deleteKeyPair_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteKeyPair_Api_Ljava_lang_String_Handler ()
			{
				if (cb_deleteKeyPair_Api_Ljava_lang_String_ == null)
					cb_deleteKeyPair_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_DeleteKeyPair_Api_Ljava_lang_String_));
				return cb_deleteKeyPair_Api_Ljava_lang_String_;
			}

			static bool n_DeleteKeyPair_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DeleteKeyPair_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='deleteKeyPair_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteKeyPair_Api", "(Ljava/lang/String;)Z", "GetDeleteKeyPair_Api_Ljava_lang_String_Handler")]
			public abstract bool DeleteKeyPair_Api (string? p0);

			static Delegate? cb_encrypt_Api_ILjava_lang_String_arrayB;
#pragma warning disable 0169
			static Delegate GetEncrypt_Api_ILjava_lang_String_arrayBHandler ()
			{
				if (cb_encrypt_Api_ILjava_lang_String_arrayB == null)
					cb_encrypt_Api_ILjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_L (n_Encrypt_Api_ILjava_lang_String_arrayB));
				return cb_encrypt_Api_ILjava_lang_String_arrayB;
			}

			static IntPtr n_Encrypt_Api_ILjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Encrypt_Api (p0, p1, p2));
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='encrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
			[Register ("encrypt_Api", "(ILjava/lang/String;[B)[B", "GetEncrypt_Api_ILjava_lang_String_arrayBHandler")]
			public abstract byte[]? Encrypt_Api (int p0, string? p1, byte[]? p2);

			static Delegate? cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetGenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_Handler ()
			{
				if (cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ == null)
					cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_));
				return cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_;
			}

			static IntPtr n_GenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.GenerateCSR_Api (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateCSR_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("generateCSR_Api", "(Ljava/lang/String;Landroid/os/Bundle;)[B", "GetGenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_Handler")]
			public abstract byte[]? GenerateCSR_Api (string? p0, global::Android.OS.Bundle? p1);

			static Delegate? cb_generateKeyPair_Api_Ljava_lang_String_II;
#pragma warning disable 0169
			static Delegate GetGenerateKeyPair_Api_Ljava_lang_String_IIHandler ()
			{
				if (cb_generateKeyPair_Api_Ljava_lang_String_II == null)
					cb_generateKeyPair_Api_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_Z (n_GenerateKeyPair_Api_Ljava_lang_String_II));
				return cb_generateKeyPair_Api_Ljava_lang_String_II;
			}

			static bool n_GenerateKeyPair_Api_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GenerateKeyPair_Api (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateKeyPair_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("generateKeyPair_Api", "(Ljava/lang/String;II)Z", "GetGenerateKeyPair_Api_Ljava_lang_String_IIHandler")]
			public abstract bool GenerateKeyPair_Api (string? p0, int p1, int p2);

			static Delegate? cb_generateRandom_Api_I;
#pragma warning disable 0169
			static Delegate GetGenerateRandom_Api_IHandler ()
			{
				if (cb_generateRandom_Api_I == null)
					cb_generateRandom_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_GenerateRandom_Api_I));
				return cb_generateRandom_Api_I;
			}

			static IntPtr n_GenerateRandom_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GenerateRandom_Api (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateRandom_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("generateRandom_Api", "(I)[B", "GetGenerateRandom_Api_IHandler")]
			public abstract byte[]? GenerateRandom_Api (int p0);

			static Delegate? cb_getCertificate_Api_ILjava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetGetCertificate_Api_ILjava_lang_String_IHandler ()
			{
				if (cb_getCertificate_Api_ILjava_lang_String_I == null)
					cb_getCertificate_Api_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_L (n_GetCertificate_Api_ILjava_lang_String_I));
				return cb_getCertificate_Api_ILjava_lang_String_I;
			}

			static IntPtr n_GetCertificate_Api_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.GetCertificate_Api (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='getCertificate_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("getCertificate_Api", "(ILjava/lang/String;I)[B", "GetGetCertificate_Api_ILjava_lang_String_IHandler")]
			public abstract byte[]? GetCertificate_Api (int p0, string? p1, int p2);

			static Delegate? cb_injectPrivateKey_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetInjectPrivateKey_Api_arrayBIHandler ()
			{
				if (cb_injectPrivateKey_Api_arrayBI == null)
					cb_injectPrivateKey_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_Z (n_InjectPrivateKey_Api_arrayBI));
				return cb_injectPrivateKey_Api_arrayBI;
			}

			static bool n_InjectPrivateKey_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.InjectPrivateKey_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectPrivateKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("injectPrivateKey_Api", "([BI)Z", "GetInjectPrivateKey_Api_arrayBIHandler")]
			public abstract bool InjectPrivateKey_Api (byte[]? p0, int p1);

			static Delegate? cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI;
#pragma warning disable 0169
			static Delegate GetInjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBIHandler ()
			{
				if (cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI == null)
					cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLI_Z (n_InjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI));
				return cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI;
			}

			static bool n_InjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.InjectPublicKeyCertificate_Api (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectPublicKeyCertificate_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("injectPublicKeyCertificate_Api", "(Ljava/lang/String;Ljava/lang/String;[BI)Z", "GetInjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBIHandler")]
			public abstract bool InjectPublicKeyCertificate_Api (string? p0, string? p1, byte[]? p2, int p3);

			static Delegate? cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI;
#pragma warning disable 0169
			static Delegate GetInjectRootCertificate_Api_ILjava_lang_String_arrayBIHandler ()
			{
				if (cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI == null)
					cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLI_Z (n_InjectRootCertificate_Api_ILjava_lang_String_arrayBI));
				return cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI;
			}

			static bool n_InjectRootCertificate_Api_ILjava_lang_String_arrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.InjectRootCertificate_Api (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectRootCertificate_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("injectRootCertificate_Api", "(ILjava/lang/String;[BI)Z", "GetInjectRootCertificate_Api_ILjava_lang_String_arrayBIHandler")]
			public abstract bool InjectRootCertificate_Api (int p0, string? p1, byte[]? p2, int p3);

			static Delegate? cb_queryCertificates_Api_I;
#pragma warning disable 0169
			static Delegate GetQueryCertificates_Api_IHandler ()
			{
				if (cb_queryCertificates_Api_I == null)
					cb_queryCertificates_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_QueryCertificates_Api_I));
				return cb_queryCertificates_Api_I;
			}

			static IntPtr n_QueryCertificates_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.QueryCertificates_Api (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='queryCertificates_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("queryCertificates_Api", "(I)[Ljava/lang/String;", "GetQueryCertificates_Api_IHandler")]
			public abstract string[]? QueryCertificates_Api (int p0);

			static Delegate? cb_resetKeyStore_Api;
#pragma warning disable 0169
			static Delegate GetResetKeyStore_ApiHandler ()
			{
				if (cb_resetKeyStore_Api == null)
					cb_resetKeyStore_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ResetKeyStore_Api));
				return cb_resetKeyStore_Api;
			}

			static void n_ResetKeyStore_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.ResetKeyStore_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='resetKeyStore_Api' and count(parameter)=0]"
			[Register ("resetKeyStore_Api", "()V", "GetResetKeyStore_ApiHandler")]
			public abstract void ResetKeyStore_Api ();

			static Delegate? cb_getFreeSpace_Api;
#pragma warning disable 0169
			static Delegate GetGetFreeSpace_ApiHandler ()
			{
				if (cb_getFreeSpace_Api == null)
					cb_getFreeSpace_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetFreeSpace_Api));
				return cb_getFreeSpace_Api;
			}

			static long n_GetFreeSpace_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FreeSpace_Api;
			}
#pragma warning restore 0169

			public abstract long FreeSpace_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='getFreeSpace_Api' and count(parameter)=0]"
				[Register ("getFreeSpace_Api", "()J", "GetGetFreeSpace_ApiHandler")]
				get; 
			}

			static Delegate? cb_isTampered_Api;
#pragma warning disable 0169
			static Delegate GetIsTampered_ApiHandler ()
			{
				if (cb_isTampered_Api == null)
					cb_isTampered_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsTampered_Api));
				return cb_isTampered_Api;
			}

			static bool n_IsTampered_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsTampered_Api;
			}
#pragma warning restore 0169

			public abstract bool IsTampered_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='isTampered_Api' and count(parameter)=0]"
				[Register ("isTampered_Api", "()Z", "GetIsTampered_ApiHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/hsm/HsmHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/hsm/HsmHandler$Stub", typeof (StubInvoker));

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

			public override unsafe long FreeSpace_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='getFreeSpace_Api' and count(parameter)=0]"
				[Register ("getFreeSpace_Api", "()J", "GetGetFreeSpace_ApiHandler")]
				get {
					const string __id = "getFreeSpace_Api.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe bool IsTampered_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/class[@name='HsmHandler.Stub']/method[@name='isTampered_Api' and count(parameter)=0]"
				[Register ("isTampered_Api", "()Z", "GetIsTampered_ApiHandler")]
				get {
					const string __id = "isTampered_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='decrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
			[Register ("decrypt_Api", "(ILjava/lang/String;[B)[B", "GetDecrypt_Api_ILjava_lang_String_arrayBHandler")]
			public override unsafe byte[]? Decrypt_Api (int p0, string? p1, byte[]? p2)
			{
				const string __id = "decrypt_Api.(ILjava/lang/String;[B)[B";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='deleteCertificate_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("deleteCertificate_Api", "(ILjava/lang/String;)Z", "GetDeleteCertificate_Api_ILjava_lang_String_Handler")]
			public override unsafe bool DeleteCertificate_Api (int p0, string? p1)
			{
				const string __id = "deleteCertificate_Api.(ILjava/lang/String;)Z";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='deleteKeyPair_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteKeyPair_Api", "(Ljava/lang/String;)Z", "GetDeleteKeyPair_Api_Ljava_lang_String_Handler")]
			public override unsafe bool DeleteKeyPair_Api (string? p0)
			{
				const string __id = "deleteKeyPair_Api.(Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='encrypt_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
			[Register ("encrypt_Api", "(ILjava/lang/String;[B)[B", "GetEncrypt_Api_ILjava_lang_String_arrayBHandler")]
			public override unsafe byte[]? Encrypt_Api (int p0, string? p1, byte[]? p2)
			{
				const string __id = "encrypt_Api.(ILjava/lang/String;[B)[B";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateCSR_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("generateCSR_Api", "(Ljava/lang/String;Landroid/os/Bundle;)[B", "GetGenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_Handler")]
			public override unsafe byte[]? GenerateCSR_Api (string? p0, global::Android.OS.Bundle? p1)
			{
				const string __id = "generateCSR_Api.(Ljava/lang/String;Landroid/os/Bundle;)[B";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateKeyPair_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("generateKeyPair_Api", "(Ljava/lang/String;II)Z", "GetGenerateKeyPair_Api_Ljava_lang_String_IIHandler")]
			public override unsafe bool GenerateKeyPair_Api (string? p0, int p1, int p2)
			{
				const string __id = "generateKeyPair_Api.(Ljava/lang/String;II)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='generateRandom_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("generateRandom_Api", "(I)[B", "GetGenerateRandom_Api_IHandler")]
			public override unsafe byte[]? GenerateRandom_Api (int p0)
			{
				const string __id = "generateRandom_Api.(I)[B";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='getCertificate_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("getCertificate_Api", "(ILjava/lang/String;I)[B", "GetGetCertificate_Api_ILjava_lang_String_IHandler")]
			public override unsafe byte[]? GetCertificate_Api (int p0, string? p1, int p2)
			{
				const string __id = "getCertificate_Api.(ILjava/lang/String;I)[B";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectPrivateKey_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("injectPrivateKey_Api", "([BI)Z", "GetInjectPrivateKey_Api_arrayBIHandler")]
			public override unsafe bool InjectPrivateKey_Api (byte[]? p0, int p1)
			{
				const string __id = "injectPrivateKey_Api.([BI)Z";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectPublicKeyCertificate_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("injectPublicKeyCertificate_Api", "(Ljava/lang/String;Ljava/lang/String;[BI)Z", "GetInjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBIHandler")]
			public override unsafe bool InjectPublicKeyCertificate_Api (string? p0, string? p1, byte[]? p2, int p3)
			{
				const string __id = "injectPublicKeyCertificate_Api.(Ljava/lang/String;Ljava/lang/String;[BI)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='injectRootCertificate_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("injectRootCertificate_Api", "(ILjava/lang/String;[BI)Z", "GetInjectRootCertificate_Api_ILjava_lang_String_arrayBIHandler")]
			public override unsafe bool InjectRootCertificate_Api (int p0, string? p1, byte[]? p2, int p3)
			{
				const string __id = "injectRootCertificate_Api.(ILjava/lang/String;[BI)Z";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='queryCertificates_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("queryCertificates_Api", "(I)[Ljava/lang/String;", "GetQueryCertificates_Api_IHandler")]
			public override unsafe string[]? QueryCertificates_Api (int p0)
			{
				const string __id = "queryCertificates_Api.(I)[Ljava/lang/String;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.hsm']/interface[@name='HsmHandler']/method[@name='resetKeyStore_Api' and count(parameter)=0]"
			[Register ("resetKeyStore_Api", "()V", "GetResetKeyStore_ApiHandler")]
			public override unsafe void ResetKeyStore_Api ()
			{
				const string __id = "resetKeyStore_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/hsm/HsmHandler", DoNotGenerateAcw=true)]
	internal partial class IHsmHandlerInvoker : global::Java.Lang.Object, IHsmHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/hsm/HsmHandler", typeof (IHsmHandlerInvoker));

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

		public static IHsmHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHsmHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.hsm.HsmHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHsmHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getFreeSpace_Api;
#pragma warning disable 0169
		static Delegate GetGetFreeSpace_ApiHandler ()
		{
			if (cb_getFreeSpace_Api == null)
				cb_getFreeSpace_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetFreeSpace_Api));
			return cb_getFreeSpace_Api;
		}

		static long n_GetFreeSpace_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FreeSpace_Api;
		}
#pragma warning restore 0169

		IntPtr id_getFreeSpace_Api;
		public unsafe long FreeSpace_Api {
			get {
				if (id_getFreeSpace_Api == IntPtr.Zero)
					id_getFreeSpace_Api = JNIEnv.GetMethodID (class_ref, "getFreeSpace_Api", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFreeSpace_Api);
			}
		}

		static Delegate? cb_isTampered_Api;
#pragma warning disable 0169
		static Delegate GetIsTampered_ApiHandler ()
		{
			if (cb_isTampered_Api == null)
				cb_isTampered_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsTampered_Api));
			return cb_isTampered_Api;
		}

		static bool n_IsTampered_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsTampered_Api;
		}
#pragma warning restore 0169

		IntPtr id_isTampered_Api;
		public unsafe bool IsTampered_Api {
			get {
				if (id_isTampered_Api == IntPtr.Zero)
					id_isTampered_Api = JNIEnv.GetMethodID (class_ref, "isTampered_Api", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTampered_Api);
			}
		}

		static Delegate? cb_decrypt_Api_ILjava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetDecrypt_Api_ILjava_lang_String_arrayBHandler ()
		{
			if (cb_decrypt_Api_ILjava_lang_String_arrayB == null)
				cb_decrypt_Api_ILjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_L (n_Decrypt_Api_ILjava_lang_String_arrayB));
			return cb_decrypt_Api_ILjava_lang_String_arrayB;
		}

		static IntPtr n_Decrypt_Api_ILjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decrypt_Api (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decrypt_Api_ILjava_lang_String_arrayB;
		public unsafe byte[]? Decrypt_Api (int p0, string? p1, byte[]? p2)
		{
			if (id_decrypt_Api_ILjava_lang_String_arrayB == IntPtr.Zero)
				id_decrypt_Api_ILjava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "decrypt_Api", "(ILjava/lang/String;[B)[B");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_Api_ILjava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_deleteCertificate_Api_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteCertificate_Api_ILjava_lang_String_Handler ()
		{
			if (cb_deleteCertificate_Api_ILjava_lang_String_ == null)
				cb_deleteCertificate_Api_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_Z (n_DeleteCertificate_Api_ILjava_lang_String_));
			return cb_deleteCertificate_Api_ILjava_lang_String_;
		}

		static bool n_DeleteCertificate_Api_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteCertificate_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deleteCertificate_Api_ILjava_lang_String_;
		public unsafe bool DeleteCertificate_Api (int p0, string? p1)
		{
			if (id_deleteCertificate_Api_ILjava_lang_String_ == IntPtr.Zero)
				id_deleteCertificate_Api_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteCertificate_Api", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteCertificate_Api_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_deleteKeyPair_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteKeyPair_Api_Ljava_lang_String_Handler ()
		{
			if (cb_deleteKeyPair_Api_Ljava_lang_String_ == null)
				cb_deleteKeyPair_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_DeleteKeyPair_Api_Ljava_lang_String_));
			return cb_deleteKeyPair_Api_Ljava_lang_String_;
		}

		static bool n_DeleteKeyPair_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteKeyPair_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deleteKeyPair_Api_Ljava_lang_String_;
		public unsafe bool DeleteKeyPair_Api (string? p0)
		{
			if (id_deleteKeyPair_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteKeyPair_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteKeyPair_Api", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteKeyPair_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_encrypt_Api_ILjava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetEncrypt_Api_ILjava_lang_String_arrayBHandler ()
		{
			if (cb_encrypt_Api_ILjava_lang_String_arrayB == null)
				cb_encrypt_Api_ILjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_L (n_Encrypt_Api_ILjava_lang_String_arrayB));
			return cb_encrypt_Api_ILjava_lang_String_arrayB;
		}

		static IntPtr n_Encrypt_Api_ILjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encrypt_Api (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encrypt_Api_ILjava_lang_String_arrayB;
		public unsafe byte[]? Encrypt_Api (int p0, string? p1, byte[]? p2)
		{
			if (id_encrypt_Api_ILjava_lang_String_arrayB == IntPtr.Zero)
				id_encrypt_Api_ILjava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "encrypt_Api", "(ILjava/lang/String;[B)[B");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_Api_ILjava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_));
			return cb_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GenerateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GenerateCSR_Api (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe byte[]? GenerateCSR_Api (string? p0, global::Android.OS.Bundle? p1)
		{
			if (id_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "generateCSR_Api", "(Ljava/lang/String;Landroid/os/Bundle;)[B");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateCSR_Api_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_generateKeyPair_Api_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetGenerateKeyPair_Api_Ljava_lang_String_IIHandler ()
		{
			if (cb_generateKeyPair_Api_Ljava_lang_String_II == null)
				cb_generateKeyPair_Api_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_Z (n_GenerateKeyPair_Api_Ljava_lang_String_II));
			return cb_generateKeyPair_Api_Ljava_lang_String_II;
		}

		static bool n_GenerateKeyPair_Api_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GenerateKeyPair_Api (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateKeyPair_Api_Ljava_lang_String_II;
		public unsafe bool GenerateKeyPair_Api (string? p0, int p1, int p2)
		{
			if (id_generateKeyPair_Api_Ljava_lang_String_II == IntPtr.Zero)
				id_generateKeyPair_Api_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "generateKeyPair_Api", "(Ljava/lang/String;II)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_generateKeyPair_Api_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_generateRandom_Api_I;
#pragma warning disable 0169
		static Delegate GetGenerateRandom_Api_IHandler ()
		{
			if (cb_generateRandom_Api_I == null)
				cb_generateRandom_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_GenerateRandom_Api_I));
			return cb_generateRandom_Api_I;
		}

		static IntPtr n_GenerateRandom_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GenerateRandom_Api (p0));
		}
#pragma warning restore 0169

		IntPtr id_generateRandom_Api_I;
		public unsafe byte[]? GenerateRandom_Api (int p0)
		{
			if (id_generateRandom_Api_I == IntPtr.Zero)
				id_generateRandom_Api_I = JNIEnv.GetMethodID (class_ref, "generateRandom_Api", "(I)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateRandom_Api_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate? cb_getCertificate_Api_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetCertificate_Api_ILjava_lang_String_IHandler ()
		{
			if (cb_getCertificate_Api_ILjava_lang_String_I == null)
				cb_getCertificate_Api_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_L (n_GetCertificate_Api_ILjava_lang_String_I));
			return cb_getCertificate_Api_ILjava_lang_String_I;
		}

		static IntPtr n_GetCertificate_Api_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetCertificate_Api (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCertificate_Api_ILjava_lang_String_I;
		public unsafe byte[]? GetCertificate_Api (int p0, string? p1, int p2)
		{
			if (id_getCertificate_Api_ILjava_lang_String_I == IntPtr.Zero)
				id_getCertificate_Api_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getCertificate_Api", "(ILjava/lang/String;I)[B");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificate_Api_ILjava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_injectPrivateKey_Api_arrayBI;
#pragma warning disable 0169
		static Delegate GetInjectPrivateKey_Api_arrayBIHandler ()
		{
			if (cb_injectPrivateKey_Api_arrayBI == null)
				cb_injectPrivateKey_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_Z (n_InjectPrivateKey_Api_arrayBI));
			return cb_injectPrivateKey_Api_arrayBI;
		}

		static bool n_InjectPrivateKey_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.InjectPrivateKey_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_injectPrivateKey_Api_arrayBI;
		public unsafe bool InjectPrivateKey_Api (byte[]? p0, int p1)
		{
			if (id_injectPrivateKey_Api_arrayBI == IntPtr.Zero)
				id_injectPrivateKey_Api_arrayBI = JNIEnv.GetMethodID (class_ref, "injectPrivateKey_Api", "([BI)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_injectPrivateKey_Api_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI;
#pragma warning disable 0169
		static Delegate GetInjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBIHandler ()
		{
			if (cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI == null)
				cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLI_Z (n_InjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI));
			return cb_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI;
		}

		static bool n_InjectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.InjectPublicKeyCertificate_Api (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI;
		public unsafe bool InjectPublicKeyCertificate_Api (string? p0, string? p1, byte[]? p2, int p3)
		{
			if (id_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI == IntPtr.Zero)
				id_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI = JNIEnv.GetMethodID (class_ref, "injectPublicKeyCertificate_Api", "(Ljava/lang/String;Ljava/lang/String;[BI)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_injectPublicKeyCertificate_Api_Ljava_lang_String_Ljava_lang_String_arrayBI, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI;
#pragma warning disable 0169
		static Delegate GetInjectRootCertificate_Api_ILjava_lang_String_arrayBIHandler ()
		{
			if (cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI == null)
				cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLI_Z (n_InjectRootCertificate_Api_ILjava_lang_String_arrayBI));
			return cb_injectRootCertificate_Api_ILjava_lang_String_arrayBI;
		}

		static bool n_InjectRootCertificate_Api_ILjava_lang_String_arrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.InjectRootCertificate_Api (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_injectRootCertificate_Api_ILjava_lang_String_arrayBI;
		public unsafe bool InjectRootCertificate_Api (int p0, string? p1, byte[]? p2, int p3)
		{
			if (id_injectRootCertificate_Api_ILjava_lang_String_arrayBI == IntPtr.Zero)
				id_injectRootCertificate_Api_ILjava_lang_String_arrayBI = JNIEnv.GetMethodID (class_ref, "injectRootCertificate_Api", "(ILjava/lang/String;[BI)Z");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_injectRootCertificate_Api_ILjava_lang_String_arrayBI, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_queryCertificates_Api_I;
#pragma warning disable 0169
		static Delegate GetQueryCertificates_Api_IHandler ()
		{
			if (cb_queryCertificates_Api_I == null)
				cb_queryCertificates_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_QueryCertificates_Api_I));
			return cb_queryCertificates_Api_I;
		}

		static IntPtr n_QueryCertificates_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.QueryCertificates_Api (p0));
		}
#pragma warning restore 0169

		IntPtr id_queryCertificates_Api_I;
		public unsafe string[]? QueryCertificates_Api (int p0)
		{
			if (id_queryCertificates_Api_I == IntPtr.Zero)
				id_queryCertificates_Api_I = JNIEnv.GetMethodID (class_ref, "queryCertificates_Api", "(I)[Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (string[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryCertificates_Api_I, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate? cb_resetKeyStore_Api;
#pragma warning disable 0169
		static Delegate GetResetKeyStore_ApiHandler ()
		{
			if (cb_resetKeyStore_Api == null)
				cb_resetKeyStore_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ResetKeyStore_Api));
			return cb_resetKeyStore_Api;
		}

		static void n_ResetKeyStore_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ResetKeyStore_Api ();
		}
#pragma warning restore 0169

		IntPtr id_resetKeyStore_Api;
		public unsafe void ResetKeyStore_Api ()
		{
			if (id_resetKeyStore_Api == IntPtr.Zero)
				id_resetKeyStore_Api = JNIEnv.GetMethodID (class_ref, "resetKeyStore_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetKeyStore_Api);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Hsm.IHsmHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
