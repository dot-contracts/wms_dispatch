using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']"
	[Register ("com/vanstone/appsdk/api/cards/At88scXXHandler", "", "Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker")]
	public partial interface IAt88scXXHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='EarseEzData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("EarseEzData_Api", "(III)I", "GetEarseEzData_Api_IIIHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int EarseEzData_Api (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='Get1608ConfigZoneData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("Get1608ConfigZoneData", "(II[B)I", "GetGet1608ConfigZoneData_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Get1608ConfigZoneData (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='GetEzKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("GetEzKey", "(II[B)I", "GetGetEzKey_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int GetEzKey (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("IccDetect_Api", "(I)I", "GetIccDetect_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int IccDetect_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='Verify102EzKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("Verify102EzKey_Api", "(II[B)I", "GetVerify102EzKey_Api_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Verify102EzKey_Api (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("icc102CheckCardType_Api", "([B)I", "GetIcc102CheckCardType_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102CheckCardType_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadAppArea_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("icc102ReadAppArea_Api", "(III[B)I", "GetIcc102ReadAppArea_Api_IIIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102ReadAppArea_Api (int p0, int p1, int p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("icc102ReadCodeProtectedBlock_Api", "(II[B)I", "GetIcc102ReadCodeProtectedBlock_Api_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102ReadCodeProtectedBlock_Api (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadErrorCountBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("icc102ReadErrorCountBlock_Api", "([B)I", "GetIcc102ReadErrorCountBlock_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102ReadErrorCountBlock_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadMfrsLoneCode_Api' and count(parameter)=0]"
		[Register ("icc102ReadMfrsLoneCode_Api", "()[B", "GetIcc102ReadMfrsLoneCode_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		byte[]? Icc102ReadMfrsLoneCode_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadMfrsShortCode_Api' and count(parameter)=0]"
		[Register ("icc102ReadMfrsShortCode_Api", "()[B", "GetIcc102ReadMfrsShortCode_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		byte[]? Icc102ReadMfrsShortCode_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadPwdErrorCount_Api' and count(parameter)=0]"
		[Register ("icc102ReadPwdErrorCount_Api", "()I", "GetIcc102ReadPwdErrorCount_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102ReadPwdErrorCount_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadTestBlock_Api' and count(parameter)=0]"
		[Register ("icc102ReadTestBlock_Api", "()[B", "GetIcc102ReadTestBlock_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		byte[]? Icc102ReadTestBlock_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102UpdatePwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("icc102UpdatePwd_Api", "([B)I", "GetIcc102UpdatePwd_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102UpdatePwd_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102VerifyPwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("icc102VerifyPwd_Api", "([B)I", "GetIcc102VerifyPwd_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102VerifyPwd_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteAppArea_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register ("icc102WriteAppArea_Api", "(BB[B)I", "GetIcc102WriteAppArea_Api_BBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102WriteAppArea_Api (sbyte p0, sbyte p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteCardMfrsData_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("icc102WriteCardMfrsData_Api", "([B)I", "GetIcc102WriteCardMfrsData_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102WriteCardMfrsData_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("icc102WriteCodeProtectedBlock_Api", "(II[B)I", "GetIcc102WriteCodeProtectedBlock_Api_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102WriteCodeProtectedBlock_Api (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteTestBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("icc102WriteTestBlock_Api", "([B)I", "GetIcc102WriteTestBlock_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc102WriteTestBlock_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Certify_Api' and count(parameter)=0]"
		[Register ("icc1608Certify_Api", "()I", "GetIcc1608Certify_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc1608Certify_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("icc1608CheckCardType_Api", "([B)I", "GetIcc1608CheckCardType_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc1608CheckCardType_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Read_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register ("icc1608Read_Api", "(BB[B)I", "GetIcc1608Read_Api_BBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc1608Read_Api (sbyte p0, sbyte p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608SelectUserArea_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("icc1608SelectUserArea_Api", "(B)I", "GetIcc1608SelectUserArea_Api_BHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc1608SelectUserArea_Api (sbyte p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608VerifyKey_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte']]"
		[Register ("icc1608VerifyKey_Api", "(B[BB)I", "GetIcc1608VerifyKey_Api_BarrayBBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc1608VerifyKey_Api (sbyte p0, byte[]? p1, sbyte p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Write' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register ("icc1608Write", "(BB[B)I", "GetIcc1608Write_BBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int Icc1608Write (sbyte p0, sbyte p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='powerDown_Api' and count(parameter)=0]"
		[Register ("powerDown_Api", "()I", "GetPowerDown_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int PowerDown_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='powerOn_Api' and count(parameter)=0]"
		[Register ("powerOn_Api", "()I", "GetPowerOn_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandlerInvoker, VanstonePosSdk")]
		int PowerOn_Api ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At88scXXHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At88scXXHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/constructor[@name='At88scXXHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_EarseEzData_Api_III;
#pragma warning disable 0169
			static Delegate GetEarseEzData_Api_IIIHandler ()
			{
				if (cb_EarseEzData_Api_III == null)
					cb_EarseEzData_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_EarseEzData_Api_III));
				return cb_EarseEzData_Api_III;
			}

			static int n_EarseEzData_Api_III (IntPtr jnienv, IntPtr native__this, int zone, int offset, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.EarseEzData_Api (zone, offset, len);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='EarseEzData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("EarseEzData_Api", "(III)I", "GetEarseEzData_Api_IIIHandler")]
			public virtual unsafe int EarseEzData_Api (int zone, int offset, int len)
			{
				const string __id = "EarseEzData_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (zone);
					__args [1] = new JniArgumentValue (offset);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_Get1608ConfigZoneData_IIarrayB;
#pragma warning disable 0169
			static Delegate GetGet1608ConfigZoneData_IIarrayBHandler ()
			{
				if (cb_Get1608ConfigZoneData_IIarrayB == null)
					cb_Get1608ConfigZoneData_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Get1608ConfigZoneData_IIarrayB));
				return cb_Get1608ConfigZoneData_IIarrayB;
			}

			static int n_Get1608ConfigZoneData_IIarrayB (IntPtr jnienv, IntPtr native__this, int offset, int len, IntPtr native_data_buffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data_buffer = (byte[]?) JNIEnv.GetArray (native_data_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Get1608ConfigZoneData (offset, len, data_buffer);
				if (data_buffer != null)
					JNIEnv.CopyArray (data_buffer, native_data_buffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='Get1608ConfigZoneData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("Get1608ConfigZoneData", "(II[B)I", "GetGet1608ConfigZoneData_IIarrayBHandler")]
			public virtual unsafe int Get1608ConfigZoneData (int offset, int len, byte[]? data_buffer)
			{
				const string __id = "Get1608ConfigZoneData.(II[B)I";
				IntPtr native_data_buffer = JNIEnv.NewArray (data_buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (len);
					__args [2] = new JniArgumentValue (native_data_buffer);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data_buffer != null) {
						JNIEnv.CopyArray (native_data_buffer, data_buffer);
						JNIEnv.DeleteLocalRef (native_data_buffer);
					}
					global::System.GC.KeepAlive (data_buffer);
				}
			}

			static Delegate? cb_GetEzKey_IIarrayB;
#pragma warning disable 0169
			static Delegate GetGetEzKey_IIarrayBHandler ()
			{
				if (cb_GetEzKey_IIarrayB == null)
					cb_GetEzKey_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_GetEzKey_IIarrayB));
				return cb_GetEzKey_IIarrayB;
			}

			static int n_GetEzKey_IIarrayB (IntPtr jnienv, IntPtr native__this, int zone, int len, IntPtr native_bKey)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bKey = (byte[]?) JNIEnv.GetArray (native_bKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetEzKey (zone, len, bKey);
				if (bKey != null)
					JNIEnv.CopyArray (bKey, native_bKey);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='GetEzKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("GetEzKey", "(II[B)I", "GetGetEzKey_IIarrayBHandler")]
			public virtual unsafe int GetEzKey (int zone, int len, byte[]? bKey)
			{
				const string __id = "GetEzKey.(II[B)I";
				IntPtr native_bKey = JNIEnv.NewArray (bKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (zone);
					__args [1] = new JniArgumentValue (len);
					__args [2] = new JniArgumentValue (native_bKey);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (bKey != null) {
						JNIEnv.CopyArray (native_bKey, bKey);
						JNIEnv.DeleteLocalRef (native_bKey);
					}
					global::System.GC.KeepAlive (bKey);
				}
			}

			static Delegate? cb_IccDetect_Api_I;
#pragma warning disable 0169
			static Delegate GetIccDetect_Api_IHandler ()
			{
				if (cb_IccDetect_Api_I == null)
					cb_IccDetect_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_IccDetect_Api_I));
				return cb_IccDetect_Api_I;
			}

			static int n_IccDetect_Api_I (IntPtr jnienv, IntPtr native__this, int cardNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccDetect_Api (cardNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetect_Api", "(I)I", "GetIccDetect_Api_IHandler")]
			public virtual unsafe int IccDetect_Api (int cardNo)
			{
				const string __id = "IccDetect_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (cardNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_Verify102EzKey_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetVerify102EzKey_Api_IIarrayBHandler ()
			{
				if (cb_Verify102EzKey_Api_IIarrayB == null)
					cb_Verify102EzKey_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Verify102EzKey_Api_IIarrayB));
				return cb_Verify102EzKey_Api_IIarrayB;
			}

			static int n_Verify102EzKey_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int zone, int len, IntPtr native_bKey)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bKey = (byte[]?) JNIEnv.GetArray (native_bKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Verify102EzKey_Api (zone, len, bKey);
				if (bKey != null)
					JNIEnv.CopyArray (bKey, native_bKey);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='Verify102EzKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("Verify102EzKey_Api", "(II[B)I", "GetVerify102EzKey_Api_IIarrayBHandler")]
			public virtual unsafe int Verify102EzKey_Api (int zone, int len, byte[]? bKey)
			{
				const string __id = "Verify102EzKey_Api.(II[B)I";
				IntPtr native_bKey = JNIEnv.NewArray (bKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (zone);
					__args [1] = new JniArgumentValue (len);
					__args [2] = new JniArgumentValue (native_bKey);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (bKey != null) {
						JNIEnv.CopyArray (native_bKey, bKey);
						JNIEnv.DeleteLocalRef (native_bKey);
					}
					global::System.GC.KeepAlive (bKey);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_icc102CheckCardType_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102CheckCardType_Api_arrayBHandler ()
			{
				if (cb_icc102CheckCardType_Api_arrayB == null)
					cb_icc102CheckCardType_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102CheckCardType_Api_arrayB));
				return cb_icc102CheckCardType_Api_arrayB;
			}

			static int n_Icc102CheckCardType_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cardType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var cardType = (byte[]?) JNIEnv.GetArray (native_cardType, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102CheckCardType_Api (cardType);
				if (cardType != null)
					JNIEnv.CopyArray (cardType, native_cardType);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102CheckCardType_Api", "([B)I", "GetIcc102CheckCardType_Api_arrayBHandler")]
			public virtual unsafe int Icc102CheckCardType_Api (byte[]? cardType)
			{
				const string __id = "icc102CheckCardType_Api.([B)I";
				IntPtr native_cardType = JNIEnv.NewArray (cardType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cardType);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (cardType != null) {
						JNIEnv.CopyArray (native_cardType, cardType);
						JNIEnv.DeleteLocalRef (native_cardType);
					}
					global::System.GC.KeepAlive (cardType);
				}
			}

			static Delegate? cb_icc102ReadAppArea_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102ReadAppArea_Api_IIIarrayBHandler ()
			{
				if (cb_icc102ReadAppArea_Api_IIIarrayB == null)
					cb_icc102ReadAppArea_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_Icc102ReadAppArea_Api_IIIarrayB));
				return cb_icc102ReadAppArea_Api_IIIarrayB;
			}

			static int n_Icc102ReadAppArea_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int appIndex, int offset, int len, IntPtr native_buffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buffer = (byte[]?) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102ReadAppArea_Api (appIndex, offset, len, buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102ReadAppArea_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("icc102ReadAppArea_Api", "(III[B)I", "GetIcc102ReadAppArea_Api_IIIarrayBHandler")]
			public virtual unsafe int Icc102ReadAppArea_Api (int appIndex, int offset, int len, byte[]? buffer)
			{
				const string __id = "icc102ReadAppArea_Api.(III[B)I";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (appIndex);
					__args [1] = new JniArgumentValue (offset);
					__args [2] = new JniArgumentValue (len);
					__args [3] = new JniArgumentValue (native_buffer);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
					global::System.GC.KeepAlive (buffer);
				}
			}

			static Delegate? cb_icc102ReadCodeProtectedBlock_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102ReadCodeProtectedBlock_Api_IIarrayBHandler ()
			{
				if (cb_icc102ReadCodeProtectedBlock_Api_IIarrayB == null)
					cb_icc102ReadCodeProtectedBlock_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Icc102ReadCodeProtectedBlock_Api_IIarrayB));
				return cb_icc102ReadCodeProtectedBlock_Api_IIarrayB;
			}

			static int n_Icc102ReadCodeProtectedBlock_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int offset, int len, IntPtr native_buffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buffer = (byte[]?) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102ReadCodeProtectedBlock_Api (offset, len, buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102ReadCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("icc102ReadCodeProtectedBlock_Api", "(II[B)I", "GetIcc102ReadCodeProtectedBlock_Api_IIarrayBHandler")]
			public virtual unsafe int Icc102ReadCodeProtectedBlock_Api (int offset, int len, byte[]? buffer)
			{
				const string __id = "icc102ReadCodeProtectedBlock_Api.(II[B)I";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (len);
					__args [2] = new JniArgumentValue (native_buffer);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
					global::System.GC.KeepAlive (buffer);
				}
			}

			static Delegate? cb_icc102ReadErrorCountBlock_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102ReadErrorCountBlock_Api_arrayBHandler ()
			{
				if (cb_icc102ReadErrorCountBlock_Api_arrayB == null)
					cb_icc102ReadErrorCountBlock_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102ReadErrorCountBlock_Api_arrayB));
				return cb_icc102ReadErrorCountBlock_Api_arrayB;
			}

			static int n_Icc102ReadErrorCountBlock_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var errorCount = (byte[]?) JNIEnv.GetArray (native_errorCount, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102ReadErrorCountBlock_Api (errorCount);
				if (errorCount != null)
					JNIEnv.CopyArray (errorCount, native_errorCount);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102ReadErrorCountBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102ReadErrorCountBlock_Api", "([B)I", "GetIcc102ReadErrorCountBlock_Api_arrayBHandler")]
			public virtual unsafe int Icc102ReadErrorCountBlock_Api (byte[]? errorCount)
			{
				const string __id = "icc102ReadErrorCountBlock_Api.([B)I";
				IntPtr native_errorCount = JNIEnv.NewArray (errorCount);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_errorCount);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (errorCount != null) {
						JNIEnv.CopyArray (native_errorCount, errorCount);
						JNIEnv.DeleteLocalRef (native_errorCount);
					}
					global::System.GC.KeepAlive (errorCount);
				}
			}

			static Delegate? cb_icc102ReadMfrsLoneCode_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadMfrsLoneCode_ApiHandler ()
			{
				if (cb_icc102ReadMfrsLoneCode_Api == null)
					cb_icc102ReadMfrsLoneCode_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadMfrsLoneCode_Api));
				return cb_icc102ReadMfrsLoneCode_Api;
			}

			static IntPtr n_Icc102ReadMfrsLoneCode_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.Icc102ReadMfrsLoneCode_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102ReadMfrsLoneCode_Api' and count(parameter)=0]"
			[Register ("icc102ReadMfrsLoneCode_Api", "()[B", "GetIcc102ReadMfrsLoneCode_ApiHandler")]
			public virtual unsafe byte[]? Icc102ReadMfrsLoneCode_Api ()
			{
				const string __id = "icc102ReadMfrsLoneCode_Api.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate? cb_icc102ReadMfrsShortCode_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadMfrsShortCode_ApiHandler ()
			{
				if (cb_icc102ReadMfrsShortCode_Api == null)
					cb_icc102ReadMfrsShortCode_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadMfrsShortCode_Api));
				return cb_icc102ReadMfrsShortCode_Api;
			}

			static IntPtr n_Icc102ReadMfrsShortCode_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.Icc102ReadMfrsShortCode_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102ReadMfrsShortCode_Api' and count(parameter)=0]"
			[Register ("icc102ReadMfrsShortCode_Api", "()[B", "GetIcc102ReadMfrsShortCode_ApiHandler")]
			public virtual unsafe byte[]? Icc102ReadMfrsShortCode_Api ()
			{
				const string __id = "icc102ReadMfrsShortCode_Api.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate? cb_icc102ReadPwdErrorCount_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadPwdErrorCount_ApiHandler ()
			{
				if (cb_icc102ReadPwdErrorCount_Api == null)
					cb_icc102ReadPwdErrorCount_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Icc102ReadPwdErrorCount_Api));
				return cb_icc102ReadPwdErrorCount_Api;
			}

			static int n_Icc102ReadPwdErrorCount_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Icc102ReadPwdErrorCount_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102ReadPwdErrorCount_Api' and count(parameter)=0]"
			[Register ("icc102ReadPwdErrorCount_Api", "()I", "GetIcc102ReadPwdErrorCount_ApiHandler")]
			public virtual unsafe int Icc102ReadPwdErrorCount_Api ()
			{
				const string __id = "icc102ReadPwdErrorCount_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_icc102ReadTestBlock_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadTestBlock_ApiHandler ()
			{
				if (cb_icc102ReadTestBlock_Api == null)
					cb_icc102ReadTestBlock_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadTestBlock_Api));
				return cb_icc102ReadTestBlock_Api;
			}

			static IntPtr n_Icc102ReadTestBlock_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.Icc102ReadTestBlock_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102ReadTestBlock_Api' and count(parameter)=0]"
			[Register ("icc102ReadTestBlock_Api", "()[B", "GetIcc102ReadTestBlock_ApiHandler")]
			public virtual unsafe byte[]? Icc102ReadTestBlock_Api ()
			{
				const string __id = "icc102ReadTestBlock_Api.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate? cb_icc102UpdatePwd_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102UpdatePwd_Api_arrayBHandler ()
			{
				if (cb_icc102UpdatePwd_Api_arrayB == null)
					cb_icc102UpdatePwd_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102UpdatePwd_Api_arrayB));
				return cb_icc102UpdatePwd_Api_arrayB;
			}

			static int n_Icc102UpdatePwd_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102UpdatePwd_Api (key);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102UpdatePwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102UpdatePwd_Api", "([B)I", "GetIcc102UpdatePwd_Api_arrayBHandler")]
			public virtual unsafe int Icc102UpdatePwd_Api (byte[]? key)
			{
				const string __id = "icc102UpdatePwd_Api.([B)I";
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_icc102VerifyPwd_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102VerifyPwd_Api_arrayBHandler ()
			{
				if (cb_icc102VerifyPwd_Api_arrayB == null)
					cb_icc102VerifyPwd_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102VerifyPwd_Api_arrayB));
				return cb_icc102VerifyPwd_Api_arrayB;
			}

			static int n_Icc102VerifyPwd_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102VerifyPwd_Api (key);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102VerifyPwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102VerifyPwd_Api", "([B)I", "GetIcc102VerifyPwd_Api_arrayBHandler")]
			public virtual unsafe int Icc102VerifyPwd_Api (byte[]? key)
			{
				const string __id = "icc102VerifyPwd_Api.([B)I";
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_icc102WriteAppArea_Api_BBarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteAppArea_Api_BBarrayBHandler ()
			{
				if (cb_icc102WriteAppArea_Api_BBarrayB == null)
					cb_icc102WriteAppArea_Api_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc102WriteAppArea_Api_BBarrayB));
				return cb_icc102WriteAppArea_Api_BBarrayB;
			}

			static int n_Icc102WriteAppArea_Api_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte appArea, sbyte addrOffset, IntPtr native_writeData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var writeData = (byte[]?) JNIEnv.GetArray (native_writeData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteAppArea_Api (appArea, addrOffset, writeData);
				if (writeData != null)
					JNIEnv.CopyArray (writeData, native_writeData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102WriteAppArea_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc102WriteAppArea_Api", "(BB[B)I", "GetIcc102WriteAppArea_Api_BBarrayBHandler")]
			public virtual unsafe int Icc102WriteAppArea_Api (sbyte appArea, sbyte addrOffset, byte[]? writeData)
			{
				const string __id = "icc102WriteAppArea_Api.(BB[B)I";
				IntPtr native_writeData = JNIEnv.NewArray (writeData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (appArea);
					__args [1] = new JniArgumentValue (addrOffset);
					__args [2] = new JniArgumentValue (native_writeData);
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

			static Delegate? cb_icc102WriteCardMfrsData_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteCardMfrsData_Api_arrayBHandler ()
			{
				if (cb_icc102WriteCardMfrsData_Api_arrayB == null)
					cb_icc102WriteCardMfrsData_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102WriteCardMfrsData_Api_arrayB));
				return cb_icc102WriteCardMfrsData_Api_arrayB;
			}

			static int n_Icc102WriteCardMfrsData_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteCardMfrsData_Api (data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102WriteCardMfrsData_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102WriteCardMfrsData_Api", "([B)I", "GetIcc102WriteCardMfrsData_Api_arrayBHandler")]
			public virtual unsafe int Icc102WriteCardMfrsData_Api (byte[]? data)
			{
				const string __id = "icc102WriteCardMfrsData_Api.([B)I";
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

			static Delegate? cb_icc102WriteCodeProtectedBlock_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteCodeProtectedBlock_Api_IIarrayBHandler ()
			{
				if (cb_icc102WriteCodeProtectedBlock_Api_IIarrayB == null)
					cb_icc102WriteCodeProtectedBlock_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Icc102WriteCodeProtectedBlock_Api_IIarrayB));
				return cb_icc102WriteCodeProtectedBlock_Api_IIarrayB;
			}

			static int n_Icc102WriteCodeProtectedBlock_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int offset, int len, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteCodeProtectedBlock_Api (offset, len, data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102WriteCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("icc102WriteCodeProtectedBlock_Api", "(II[B)I", "GetIcc102WriteCodeProtectedBlock_Api_IIarrayBHandler")]
			public virtual unsafe int Icc102WriteCodeProtectedBlock_Api (int offset, int len, byte[]? data)
			{
				const string __id = "icc102WriteCodeProtectedBlock_Api.(II[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (len);
					__args [2] = new JniArgumentValue (native_data);
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

			static Delegate? cb_icc102WriteTestBlock_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteTestBlock_Api_arrayBHandler ()
			{
				if (cb_icc102WriteTestBlock_Api_arrayB == null)
					cb_icc102WriteTestBlock_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102WriteTestBlock_Api_arrayB));
				return cb_icc102WriteTestBlock_Api_arrayB;
			}

			static int n_Icc102WriteTestBlock_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteTestBlock_Api (data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc102WriteTestBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102WriteTestBlock_Api", "([B)I", "GetIcc102WriteTestBlock_Api_arrayBHandler")]
			public virtual unsafe int Icc102WriteTestBlock_Api (byte[]? data)
			{
				const string __id = "icc102WriteTestBlock_Api.([B)I";
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

			static Delegate? cb_icc1608Certify_Api;
#pragma warning disable 0169
			static Delegate GetIcc1608Certify_ApiHandler ()
			{
				if (cb_icc1608Certify_Api == null)
					cb_icc1608Certify_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Icc1608Certify_Api));
				return cb_icc1608Certify_Api;
			}

			static int n_Icc1608Certify_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Icc1608Certify_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc1608Certify_Api' and count(parameter)=0]"
			[Register ("icc1608Certify_Api", "()I", "GetIcc1608Certify_ApiHandler")]
			public virtual unsafe int Icc1608Certify_Api ()
			{
				const string __id = "icc1608Certify_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_icc1608CheckCardType_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc1608CheckCardType_Api_arrayBHandler ()
			{
				if (cb_icc1608CheckCardType_Api_arrayB == null)
					cb_icc1608CheckCardType_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc1608CheckCardType_Api_arrayB));
				return cb_icc1608CheckCardType_Api_arrayB;
			}

			static int n_Icc1608CheckCardType_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cardType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var cardType = (byte[]?) JNIEnv.GetArray (native_cardType, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608CheckCardType_Api (cardType);
				if (cardType != null)
					JNIEnv.CopyArray (cardType, native_cardType);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc1608CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc1608CheckCardType_Api", "([B)I", "GetIcc1608CheckCardType_Api_arrayBHandler")]
			public virtual unsafe int Icc1608CheckCardType_Api (byte[]? cardType)
			{
				const string __id = "icc1608CheckCardType_Api.([B)I";
				IntPtr native_cardType = JNIEnv.NewArray (cardType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cardType);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (cardType != null) {
						JNIEnv.CopyArray (native_cardType, cardType);
						JNIEnv.DeleteLocalRef (native_cardType);
					}
					global::System.GC.KeepAlive (cardType);
				}
			}

			static Delegate? cb_icc1608Read_Api_BBarrayB;
#pragma warning disable 0169
			static Delegate GetIcc1608Read_Api_BBarrayBHandler ()
			{
				if (cb_icc1608Read_Api_BBarrayB == null)
					cb_icc1608Read_Api_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc1608Read_Api_BBarrayB));
				return cb_icc1608Read_Api_BBarrayB;
			}

			static int n_Icc1608Read_Api_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte protocolCmd, sbyte addr, IntPtr native_readData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var readData = (byte[]?) JNIEnv.GetArray (native_readData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608Read_Api (protocolCmd, addr, readData);
				if (readData != null)
					JNIEnv.CopyArray (readData, native_readData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc1608Read_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc1608Read_Api", "(BB[B)I", "GetIcc1608Read_Api_BBarrayBHandler")]
			public virtual unsafe int Icc1608Read_Api (sbyte protocolCmd, sbyte addr, byte[]? readData)
			{
				const string __id = "icc1608Read_Api.(BB[B)I";
				IntPtr native_readData = JNIEnv.NewArray (readData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (protocolCmd);
					__args [1] = new JniArgumentValue (addr);
					__args [2] = new JniArgumentValue (native_readData);
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

			static Delegate? cb_icc1608SelectUserArea_Api_B;
#pragma warning disable 0169
			static Delegate GetIcc1608SelectUserArea_Api_BHandler ()
			{
				if (cb_icc1608SelectUserArea_Api_B == null)
					cb_icc1608SelectUserArea_Api_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_Icc1608SelectUserArea_Api_B));
				return cb_icc1608SelectUserArea_Api_B;
			}

			static int n_Icc1608SelectUserArea_Api_B (IntPtr jnienv, IntPtr native__this, sbyte userArea)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Icc1608SelectUserArea_Api (userArea);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc1608SelectUserArea_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("icc1608SelectUserArea_Api", "(B)I", "GetIcc1608SelectUserArea_Api_BHandler")]
			public virtual unsafe int Icc1608SelectUserArea_Api (sbyte userArea)
			{
				const string __id = "icc1608SelectUserArea_Api.(B)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (userArea);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_icc1608VerifyKey_Api_BarrayBB;
#pragma warning disable 0169
			static Delegate GetIcc1608VerifyKey_Api_BarrayBBHandler ()
			{
				if (cb_icc1608VerifyKey_Api_BarrayBB == null)
					cb_icc1608VerifyKey_Api_BarrayBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLB_I (n_Icc1608VerifyKey_Api_BarrayBB));
				return cb_icc1608VerifyKey_Api_BarrayBB;
			}

			static int n_Icc1608VerifyKey_Api_BarrayBB (IntPtr jnienv, IntPtr native__this, sbyte keyMode, IntPtr native_key, sbyte keyGroup)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608VerifyKey_Api (keyMode, key, keyGroup);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc1608VerifyKey_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte']]"
			[Register ("icc1608VerifyKey_Api", "(B[BB)I", "GetIcc1608VerifyKey_Api_BarrayBBHandler")]
			public virtual unsafe int Icc1608VerifyKey_Api (sbyte keyMode, byte[]? key, sbyte keyGroup)
			{
				const string __id = "icc1608VerifyKey_Api.(B[BB)I";
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (keyMode);
					__args [1] = new JniArgumentValue (native_key);
					__args [2] = new JniArgumentValue (keyGroup);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_icc1608Write_BBarrayB;
#pragma warning disable 0169
			static Delegate GetIcc1608Write_BBarrayBHandler ()
			{
				if (cb_icc1608Write_BBarrayB == null)
					cb_icc1608Write_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc1608Write_BBarrayB));
				return cb_icc1608Write_BBarrayB;
			}

			static int n_Icc1608Write_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte protocolCmd, sbyte addr, IntPtr native_writeData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var writeData = (byte[]?) JNIEnv.GetArray (native_writeData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608Write (protocolCmd, addr, writeData);
				if (writeData != null)
					JNIEnv.CopyArray (writeData, native_writeData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='icc1608Write' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc1608Write", "(BB[B)I", "GetIcc1608Write_BBarrayBHandler")]
			public virtual unsafe int Icc1608Write (sbyte protocolCmd, sbyte addr, byte[]? writeData)
			{
				const string __id = "icc1608Write.(BB[B)I";
				IntPtr native_writeData = JNIEnv.NewArray (writeData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (protocolCmd);
					__args [1] = new JniArgumentValue (addr);
					__args [2] = new JniArgumentValue (native_writeData);
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

			static Delegate? cb_powerDown_Api;
#pragma warning disable 0169
			static Delegate GetPowerDown_ApiHandler ()
			{
				if (cb_powerDown_Api == null)
					cb_powerDown_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PowerDown_Api));
				return cb_powerDown_Api;
			}

			static int n_PowerDown_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PowerDown_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='powerDown_Api' and count(parameter)=0]"
			[Register ("powerDown_Api", "()I", "GetPowerDown_ApiHandler")]
			public virtual unsafe int PowerDown_Api ()
			{
				const string __id = "powerDown_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_powerOn_Api;
#pragma warning disable 0169
			static Delegate GetPowerOn_ApiHandler ()
			{
				if (cb_powerOn_Api == null)
					cb_powerOn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PowerOn_Api));
				return cb_powerOn_Api;
			}

			static int n_PowerOn_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PowerOn_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Default']/method[@name='powerOn_Api' and count(parameter)=0]"
			[Register ("powerOn_Api", "()I", "GetPowerOn_ApiHandler")]
			public virtual unsafe int PowerOn_Api ()
			{
				const string __id = "powerOn_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At88scXXHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At88scXXHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Stub']/constructor[@name='At88scXXHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/At88scXXHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/At88scXXHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/At88scXXHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='At88scXXHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.At88scXXHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/At88scXXHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/At88scXXHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_EarseEzData_Api_III;
#pragma warning disable 0169
			static Delegate GetEarseEzData_Api_IIIHandler ()
			{
				if (cb_EarseEzData_Api_III == null)
					cb_EarseEzData_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_EarseEzData_Api_III));
				return cb_EarseEzData_Api_III;
			}

			static int n_EarseEzData_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.EarseEzData_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='EarseEzData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("EarseEzData_Api", "(III)I", "GetEarseEzData_Api_IIIHandler")]
			public abstract int EarseEzData_Api (int p0, int p1, int p2);

			static Delegate? cb_Get1608ConfigZoneData_IIarrayB;
#pragma warning disable 0169
			static Delegate GetGet1608ConfigZoneData_IIarrayBHandler ()
			{
				if (cb_Get1608ConfigZoneData_IIarrayB == null)
					cb_Get1608ConfigZoneData_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Get1608ConfigZoneData_IIarrayB));
				return cb_Get1608ConfigZoneData_IIarrayB;
			}

			static int n_Get1608ConfigZoneData_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Get1608ConfigZoneData (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='Get1608ConfigZoneData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("Get1608ConfigZoneData", "(II[B)I", "GetGet1608ConfigZoneData_IIarrayBHandler")]
			public abstract int Get1608ConfigZoneData (int p0, int p1, byte[]? p2);

			static Delegate? cb_GetEzKey_IIarrayB;
#pragma warning disable 0169
			static Delegate GetGetEzKey_IIarrayBHandler ()
			{
				if (cb_GetEzKey_IIarrayB == null)
					cb_GetEzKey_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_GetEzKey_IIarrayB));
				return cb_GetEzKey_IIarrayB;
			}

			static int n_GetEzKey_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetEzKey (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='GetEzKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("GetEzKey", "(II[B)I", "GetGetEzKey_IIarrayBHandler")]
			public abstract int GetEzKey (int p0, int p1, byte[]? p2);

			static Delegate? cb_IccDetect_Api_I;
#pragma warning disable 0169
			static Delegate GetIccDetect_Api_IHandler ()
			{
				if (cb_IccDetect_Api_I == null)
					cb_IccDetect_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_IccDetect_Api_I));
				return cb_IccDetect_Api_I;
			}

			static int n_IccDetect_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccDetect_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetect_Api", "(I)I", "GetIccDetect_Api_IHandler")]
			public abstract int IccDetect_Api (int p0);

			static Delegate? cb_Verify102EzKey_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetVerify102EzKey_Api_IIarrayBHandler ()
			{
				if (cb_Verify102EzKey_Api_IIarrayB == null)
					cb_Verify102EzKey_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Verify102EzKey_Api_IIarrayB));
				return cb_Verify102EzKey_Api_IIarrayB;
			}

			static int n_Verify102EzKey_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Verify102EzKey_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='Verify102EzKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("Verify102EzKey_Api", "(II[B)I", "GetVerify102EzKey_Api_IIarrayBHandler")]
			public abstract int Verify102EzKey_Api (int p0, int p1, byte[]? p2);

			static Delegate? cb_icc102CheckCardType_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102CheckCardType_Api_arrayBHandler ()
			{
				if (cb_icc102CheckCardType_Api_arrayB == null)
					cb_icc102CheckCardType_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102CheckCardType_Api_arrayB));
				return cb_icc102CheckCardType_Api_arrayB;
			}

			static int n_Icc102CheckCardType_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102CheckCardType_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102CheckCardType_Api", "([B)I", "GetIcc102CheckCardType_Api_arrayBHandler")]
			public abstract int Icc102CheckCardType_Api (byte[]? p0);

			static Delegate? cb_icc102ReadAppArea_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102ReadAppArea_Api_IIIarrayBHandler ()
			{
				if (cb_icc102ReadAppArea_Api_IIIarrayB == null)
					cb_icc102ReadAppArea_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_Icc102ReadAppArea_Api_IIIarrayB));
				return cb_icc102ReadAppArea_Api_IIIarrayB;
			}

			static int n_Icc102ReadAppArea_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102ReadAppArea_Api (p0, p1, p2, p3);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadAppArea_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("icc102ReadAppArea_Api", "(III[B)I", "GetIcc102ReadAppArea_Api_IIIarrayBHandler")]
			public abstract int Icc102ReadAppArea_Api (int p0, int p1, int p2, byte[]? p3);

			static Delegate? cb_icc102ReadCodeProtectedBlock_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102ReadCodeProtectedBlock_Api_IIarrayBHandler ()
			{
				if (cb_icc102ReadCodeProtectedBlock_Api_IIarrayB == null)
					cb_icc102ReadCodeProtectedBlock_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Icc102ReadCodeProtectedBlock_Api_IIarrayB));
				return cb_icc102ReadCodeProtectedBlock_Api_IIarrayB;
			}

			static int n_Icc102ReadCodeProtectedBlock_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102ReadCodeProtectedBlock_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("icc102ReadCodeProtectedBlock_Api", "(II[B)I", "GetIcc102ReadCodeProtectedBlock_Api_IIarrayBHandler")]
			public abstract int Icc102ReadCodeProtectedBlock_Api (int p0, int p1, byte[]? p2);

			static Delegate? cb_icc102ReadErrorCountBlock_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102ReadErrorCountBlock_Api_arrayBHandler ()
			{
				if (cb_icc102ReadErrorCountBlock_Api_arrayB == null)
					cb_icc102ReadErrorCountBlock_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102ReadErrorCountBlock_Api_arrayB));
				return cb_icc102ReadErrorCountBlock_Api_arrayB;
			}

			static int n_Icc102ReadErrorCountBlock_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102ReadErrorCountBlock_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadErrorCountBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102ReadErrorCountBlock_Api", "([B)I", "GetIcc102ReadErrorCountBlock_Api_arrayBHandler")]
			public abstract int Icc102ReadErrorCountBlock_Api (byte[]? p0);

			static Delegate? cb_icc102ReadMfrsLoneCode_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadMfrsLoneCode_ApiHandler ()
			{
				if (cb_icc102ReadMfrsLoneCode_Api == null)
					cb_icc102ReadMfrsLoneCode_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadMfrsLoneCode_Api));
				return cb_icc102ReadMfrsLoneCode_Api;
			}

			static IntPtr n_Icc102ReadMfrsLoneCode_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.Icc102ReadMfrsLoneCode_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadMfrsLoneCode_Api' and count(parameter)=0]"
			[Register ("icc102ReadMfrsLoneCode_Api", "()[B", "GetIcc102ReadMfrsLoneCode_ApiHandler")]
			public abstract byte[]? Icc102ReadMfrsLoneCode_Api ();

			static Delegate? cb_icc102ReadMfrsShortCode_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadMfrsShortCode_ApiHandler ()
			{
				if (cb_icc102ReadMfrsShortCode_Api == null)
					cb_icc102ReadMfrsShortCode_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadMfrsShortCode_Api));
				return cb_icc102ReadMfrsShortCode_Api;
			}

			static IntPtr n_Icc102ReadMfrsShortCode_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.Icc102ReadMfrsShortCode_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadMfrsShortCode_Api' and count(parameter)=0]"
			[Register ("icc102ReadMfrsShortCode_Api", "()[B", "GetIcc102ReadMfrsShortCode_ApiHandler")]
			public abstract byte[]? Icc102ReadMfrsShortCode_Api ();

			static Delegate? cb_icc102ReadPwdErrorCount_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadPwdErrorCount_ApiHandler ()
			{
				if (cb_icc102ReadPwdErrorCount_Api == null)
					cb_icc102ReadPwdErrorCount_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Icc102ReadPwdErrorCount_Api));
				return cb_icc102ReadPwdErrorCount_Api;
			}

			static int n_Icc102ReadPwdErrorCount_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Icc102ReadPwdErrorCount_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadPwdErrorCount_Api' and count(parameter)=0]"
			[Register ("icc102ReadPwdErrorCount_Api", "()I", "GetIcc102ReadPwdErrorCount_ApiHandler")]
			public abstract int Icc102ReadPwdErrorCount_Api ();

			static Delegate? cb_icc102ReadTestBlock_Api;
#pragma warning disable 0169
			static Delegate GetIcc102ReadTestBlock_ApiHandler ()
			{
				if (cb_icc102ReadTestBlock_Api == null)
					cb_icc102ReadTestBlock_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadTestBlock_Api));
				return cb_icc102ReadTestBlock_Api;
			}

			static IntPtr n_Icc102ReadTestBlock_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.Icc102ReadTestBlock_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadTestBlock_Api' and count(parameter)=0]"
			[Register ("icc102ReadTestBlock_Api", "()[B", "GetIcc102ReadTestBlock_ApiHandler")]
			public abstract byte[]? Icc102ReadTestBlock_Api ();

			static Delegate? cb_icc102UpdatePwd_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102UpdatePwd_Api_arrayBHandler ()
			{
				if (cb_icc102UpdatePwd_Api_arrayB == null)
					cb_icc102UpdatePwd_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102UpdatePwd_Api_arrayB));
				return cb_icc102UpdatePwd_Api_arrayB;
			}

			static int n_Icc102UpdatePwd_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102UpdatePwd_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102UpdatePwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102UpdatePwd_Api", "([B)I", "GetIcc102UpdatePwd_Api_arrayBHandler")]
			public abstract int Icc102UpdatePwd_Api (byte[]? p0);

			static Delegate? cb_icc102VerifyPwd_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102VerifyPwd_Api_arrayBHandler ()
			{
				if (cb_icc102VerifyPwd_Api_arrayB == null)
					cb_icc102VerifyPwd_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102VerifyPwd_Api_arrayB));
				return cb_icc102VerifyPwd_Api_arrayB;
			}

			static int n_Icc102VerifyPwd_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102VerifyPwd_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102VerifyPwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102VerifyPwd_Api", "([B)I", "GetIcc102VerifyPwd_Api_arrayBHandler")]
			public abstract int Icc102VerifyPwd_Api (byte[]? p0);

			static Delegate? cb_icc102WriteAppArea_Api_BBarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteAppArea_Api_BBarrayBHandler ()
			{
				if (cb_icc102WriteAppArea_Api_BBarrayB == null)
					cb_icc102WriteAppArea_Api_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc102WriteAppArea_Api_BBarrayB));
				return cb_icc102WriteAppArea_Api_BBarrayB;
			}

			static int n_Icc102WriteAppArea_Api_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteAppArea_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteAppArea_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc102WriteAppArea_Api", "(BB[B)I", "GetIcc102WriteAppArea_Api_BBarrayBHandler")]
			public abstract int Icc102WriteAppArea_Api (sbyte p0, sbyte p1, byte[]? p2);

			static Delegate? cb_icc102WriteCardMfrsData_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteCardMfrsData_Api_arrayBHandler ()
			{
				if (cb_icc102WriteCardMfrsData_Api_arrayB == null)
					cb_icc102WriteCardMfrsData_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102WriteCardMfrsData_Api_arrayB));
				return cb_icc102WriteCardMfrsData_Api_arrayB;
			}

			static int n_Icc102WriteCardMfrsData_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteCardMfrsData_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteCardMfrsData_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102WriteCardMfrsData_Api", "([B)I", "GetIcc102WriteCardMfrsData_Api_arrayBHandler")]
			public abstract int Icc102WriteCardMfrsData_Api (byte[]? p0);

			static Delegate? cb_icc102WriteCodeProtectedBlock_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteCodeProtectedBlock_Api_IIarrayBHandler ()
			{
				if (cb_icc102WriteCodeProtectedBlock_Api_IIarrayB == null)
					cb_icc102WriteCodeProtectedBlock_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Icc102WriteCodeProtectedBlock_Api_IIarrayB));
				return cb_icc102WriteCodeProtectedBlock_Api_IIarrayB;
			}

			static int n_Icc102WriteCodeProtectedBlock_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteCodeProtectedBlock_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("icc102WriteCodeProtectedBlock_Api", "(II[B)I", "GetIcc102WriteCodeProtectedBlock_Api_IIarrayBHandler")]
			public abstract int Icc102WriteCodeProtectedBlock_Api (int p0, int p1, byte[]? p2);

			static Delegate? cb_icc102WriteTestBlock_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc102WriteTestBlock_Api_arrayBHandler ()
			{
				if (cb_icc102WriteTestBlock_Api_arrayB == null)
					cb_icc102WriteTestBlock_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102WriteTestBlock_Api_arrayB));
				return cb_icc102WriteTestBlock_Api_arrayB;
			}

			static int n_Icc102WriteTestBlock_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc102WriteTestBlock_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteTestBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102WriteTestBlock_Api", "([B)I", "GetIcc102WriteTestBlock_Api_arrayBHandler")]
			public abstract int Icc102WriteTestBlock_Api (byte[]? p0);

			static Delegate? cb_icc1608Certify_Api;
#pragma warning disable 0169
			static Delegate GetIcc1608Certify_ApiHandler ()
			{
				if (cb_icc1608Certify_Api == null)
					cb_icc1608Certify_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Icc1608Certify_Api));
				return cb_icc1608Certify_Api;
			}

			static int n_Icc1608Certify_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Icc1608Certify_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Certify_Api' and count(parameter)=0]"
			[Register ("icc1608Certify_Api", "()I", "GetIcc1608Certify_ApiHandler")]
			public abstract int Icc1608Certify_Api ();

			static Delegate? cb_icc1608CheckCardType_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetIcc1608CheckCardType_Api_arrayBHandler ()
			{
				if (cb_icc1608CheckCardType_Api_arrayB == null)
					cb_icc1608CheckCardType_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc1608CheckCardType_Api_arrayB));
				return cb_icc1608CheckCardType_Api_arrayB;
			}

			static int n_Icc1608CheckCardType_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608CheckCardType_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc1608CheckCardType_Api", "([B)I", "GetIcc1608CheckCardType_Api_arrayBHandler")]
			public abstract int Icc1608CheckCardType_Api (byte[]? p0);

			static Delegate? cb_icc1608Read_Api_BBarrayB;
#pragma warning disable 0169
			static Delegate GetIcc1608Read_Api_BBarrayBHandler ()
			{
				if (cb_icc1608Read_Api_BBarrayB == null)
					cb_icc1608Read_Api_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc1608Read_Api_BBarrayB));
				return cb_icc1608Read_Api_BBarrayB;
			}

			static int n_Icc1608Read_Api_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608Read_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Read_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc1608Read_Api", "(BB[B)I", "GetIcc1608Read_Api_BBarrayBHandler")]
			public abstract int Icc1608Read_Api (sbyte p0, sbyte p1, byte[]? p2);

			static Delegate? cb_icc1608SelectUserArea_Api_B;
#pragma warning disable 0169
			static Delegate GetIcc1608SelectUserArea_Api_BHandler ()
			{
				if (cb_icc1608SelectUserArea_Api_B == null)
					cb_icc1608SelectUserArea_Api_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_Icc1608SelectUserArea_Api_B));
				return cb_icc1608SelectUserArea_Api_B;
			}

			static int n_Icc1608SelectUserArea_Api_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Icc1608SelectUserArea_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608SelectUserArea_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("icc1608SelectUserArea_Api", "(B)I", "GetIcc1608SelectUserArea_Api_BHandler")]
			public abstract int Icc1608SelectUserArea_Api (sbyte p0);

			static Delegate? cb_icc1608VerifyKey_Api_BarrayBB;
#pragma warning disable 0169
			static Delegate GetIcc1608VerifyKey_Api_BarrayBBHandler ()
			{
				if (cb_icc1608VerifyKey_Api_BarrayBB == null)
					cb_icc1608VerifyKey_Api_BarrayBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLB_I (n_Icc1608VerifyKey_Api_BarrayBB));
				return cb_icc1608VerifyKey_Api_BarrayBB;
			}

			static int n_Icc1608VerifyKey_Api_BarrayBB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, sbyte p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608VerifyKey_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608VerifyKey_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte']]"
			[Register ("icc1608VerifyKey_Api", "(B[BB)I", "GetIcc1608VerifyKey_Api_BarrayBBHandler")]
			public abstract int Icc1608VerifyKey_Api (sbyte p0, byte[]? p1, sbyte p2);

			static Delegate? cb_icc1608Write_BBarrayB;
#pragma warning disable 0169
			static Delegate GetIcc1608Write_BBarrayBHandler ()
			{
				if (cb_icc1608Write_BBarrayB == null)
					cb_icc1608Write_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc1608Write_BBarrayB));
				return cb_icc1608Write_BBarrayB;
			}

			static int n_Icc1608Write_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Icc1608Write (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Write' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc1608Write", "(BB[B)I", "GetIcc1608Write_BBarrayBHandler")]
			public abstract int Icc1608Write (sbyte p0, sbyte p1, byte[]? p2);

			static Delegate? cb_powerDown_Api;
#pragma warning disable 0169
			static Delegate GetPowerDown_ApiHandler ()
			{
				if (cb_powerDown_Api == null)
					cb_powerDown_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PowerDown_Api));
				return cb_powerDown_Api;
			}

			static int n_PowerDown_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PowerDown_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='powerDown_Api' and count(parameter)=0]"
			[Register ("powerDown_Api", "()I", "GetPowerDown_ApiHandler")]
			public abstract int PowerDown_Api ();

			static Delegate? cb_powerOn_Api;
#pragma warning disable 0169
			static Delegate GetPowerOn_ApiHandler ()
			{
				if (cb_powerOn_Api == null)
					cb_powerOn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PowerOn_Api));
				return cb_powerOn_Api;
			}

			static int n_PowerOn_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PowerOn_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='powerOn_Api' and count(parameter)=0]"
			[Register ("powerOn_Api", "()I", "GetPowerOn_ApiHandler")]
			public abstract int PowerOn_Api ();

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At88scXXHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At88scXXHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='EarseEzData_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("EarseEzData_Api", "(III)I", "GetEarseEzData_Api_IIIHandler")]
			public override unsafe int EarseEzData_Api (int p0, int p1, int p2)
			{
				const string __id = "EarseEzData_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='Get1608ConfigZoneData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("Get1608ConfigZoneData", "(II[B)I", "GetGet1608ConfigZoneData_IIarrayBHandler")]
			public override unsafe int Get1608ConfigZoneData (int p0, int p1, byte[]? p2)
			{
				const string __id = "Get1608ConfigZoneData.(II[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='GetEzKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("GetEzKey", "(II[B)I", "GetGetEzKey_IIarrayBHandler")]
			public override unsafe int GetEzKey (int p0, int p1, byte[]? p2)
			{
				const string __id = "GetEzKey.(II[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetect_Api", "(I)I", "GetIccDetect_Api_IHandler")]
			public override unsafe int IccDetect_Api (int p0)
			{
				const string __id = "IccDetect_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='Verify102EzKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("Verify102EzKey_Api", "(II[B)I", "GetVerify102EzKey_Api_IIarrayBHandler")]
			public override unsafe int Verify102EzKey_Api (int p0, int p1, byte[]? p2)
			{
				const string __id = "Verify102EzKey_Api.(II[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102CheckCardType_Api", "([B)I", "GetIcc102CheckCardType_Api_arrayBHandler")]
			public override unsafe int Icc102CheckCardType_Api (byte[]? p0)
			{
				const string __id = "icc102CheckCardType_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadAppArea_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("icc102ReadAppArea_Api", "(III[B)I", "GetIcc102ReadAppArea_Api_IIIarrayBHandler")]
			public override unsafe int Icc102ReadAppArea_Api (int p0, int p1, int p2, byte[]? p3)
			{
				const string __id = "icc102ReadAppArea_Api.(III[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("icc102ReadCodeProtectedBlock_Api", "(II[B)I", "GetIcc102ReadCodeProtectedBlock_Api_IIarrayBHandler")]
			public override unsafe int Icc102ReadCodeProtectedBlock_Api (int p0, int p1, byte[]? p2)
			{
				const string __id = "icc102ReadCodeProtectedBlock_Api.(II[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadErrorCountBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102ReadErrorCountBlock_Api", "([B)I", "GetIcc102ReadErrorCountBlock_Api_arrayBHandler")]
			public override unsafe int Icc102ReadErrorCountBlock_Api (byte[]? p0)
			{
				const string __id = "icc102ReadErrorCountBlock_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadMfrsLoneCode_Api' and count(parameter)=0]"
			[Register ("icc102ReadMfrsLoneCode_Api", "()[B", "GetIcc102ReadMfrsLoneCode_ApiHandler")]
			public override unsafe byte[]? Icc102ReadMfrsLoneCode_Api ()
			{
				const string __id = "icc102ReadMfrsLoneCode_Api.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadMfrsShortCode_Api' and count(parameter)=0]"
			[Register ("icc102ReadMfrsShortCode_Api", "()[B", "GetIcc102ReadMfrsShortCode_ApiHandler")]
			public override unsafe byte[]? Icc102ReadMfrsShortCode_Api ()
			{
				const string __id = "icc102ReadMfrsShortCode_Api.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadPwdErrorCount_Api' and count(parameter)=0]"
			[Register ("icc102ReadPwdErrorCount_Api", "()I", "GetIcc102ReadPwdErrorCount_ApiHandler")]
			public override unsafe int Icc102ReadPwdErrorCount_Api ()
			{
				const string __id = "icc102ReadPwdErrorCount_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102ReadTestBlock_Api' and count(parameter)=0]"
			[Register ("icc102ReadTestBlock_Api", "()[B", "GetIcc102ReadTestBlock_ApiHandler")]
			public override unsafe byte[]? Icc102ReadTestBlock_Api ()
			{
				const string __id = "icc102ReadTestBlock_Api.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102UpdatePwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102UpdatePwd_Api", "([B)I", "GetIcc102UpdatePwd_Api_arrayBHandler")]
			public override unsafe int Icc102UpdatePwd_Api (byte[]? p0)
			{
				const string __id = "icc102UpdatePwd_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102VerifyPwd_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102VerifyPwd_Api", "([B)I", "GetIcc102VerifyPwd_Api_arrayBHandler")]
			public override unsafe int Icc102VerifyPwd_Api (byte[]? p0)
			{
				const string __id = "icc102VerifyPwd_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteAppArea_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc102WriteAppArea_Api", "(BB[B)I", "GetIcc102WriteAppArea_Api_BBarrayBHandler")]
			public override unsafe int Icc102WriteAppArea_Api (sbyte p0, sbyte p1, byte[]? p2)
			{
				const string __id = "icc102WriteAppArea_Api.(BB[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteCardMfrsData_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102WriteCardMfrsData_Api", "([B)I", "GetIcc102WriteCardMfrsData_Api_arrayBHandler")]
			public override unsafe int Icc102WriteCardMfrsData_Api (byte[]? p0)
			{
				const string __id = "icc102WriteCardMfrsData_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteCodeProtectedBlock_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("icc102WriteCodeProtectedBlock_Api", "(II[B)I", "GetIcc102WriteCodeProtectedBlock_Api_IIarrayBHandler")]
			public override unsafe int Icc102WriteCodeProtectedBlock_Api (int p0, int p1, byte[]? p2)
			{
				const string __id = "icc102WriteCodeProtectedBlock_Api.(II[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc102WriteTestBlock_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc102WriteTestBlock_Api", "([B)I", "GetIcc102WriteTestBlock_Api_arrayBHandler")]
			public override unsafe int Icc102WriteTestBlock_Api (byte[]? p0)
			{
				const string __id = "icc102WriteTestBlock_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Certify_Api' and count(parameter)=0]"
			[Register ("icc1608Certify_Api", "()I", "GetIcc1608Certify_ApiHandler")]
			public override unsafe int Icc1608Certify_Api ()
			{
				const string __id = "icc1608Certify_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608CheckCardType_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("icc1608CheckCardType_Api", "([B)I", "GetIcc1608CheckCardType_Api_arrayBHandler")]
			public override unsafe int Icc1608CheckCardType_Api (byte[]? p0)
			{
				const string __id = "icc1608CheckCardType_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Read_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc1608Read_Api", "(BB[B)I", "GetIcc1608Read_Api_BBarrayBHandler")]
			public override unsafe int Icc1608Read_Api (sbyte p0, sbyte p1, byte[]? p2)
			{
				const string __id = "icc1608Read_Api.(BB[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608SelectUserArea_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("icc1608SelectUserArea_Api", "(B)I", "GetIcc1608SelectUserArea_Api_BHandler")]
			public override unsafe int Icc1608SelectUserArea_Api (sbyte p0)
			{
				const string __id = "icc1608SelectUserArea_Api.(B)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608VerifyKey_Api' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte']]"
			[Register ("icc1608VerifyKey_Api", "(B[BB)I", "GetIcc1608VerifyKey_Api_BarrayBBHandler")]
			public override unsafe int Icc1608VerifyKey_Api (sbyte p0, byte[]? p1, sbyte p2)
			{
				const string __id = "icc1608VerifyKey_Api.(B[BB)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='icc1608Write' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("icc1608Write", "(BB[B)I", "GetIcc1608Write_BBarrayBHandler")]
			public override unsafe int Icc1608Write (sbyte p0, sbyte p1, byte[]? p2)
			{
				const string __id = "icc1608Write.(BB[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='powerDown_Api' and count(parameter)=0]"
			[Register ("powerDown_Api", "()I", "GetPowerDown_ApiHandler")]
			public override unsafe int PowerDown_Api ()
			{
				const string __id = "powerDown_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='At88scXXHandler']/method[@name='powerOn_Api' and count(parameter)=0]"
			[Register ("powerOn_Api", "()I", "GetPowerOn_ApiHandler")]
			public override unsafe int PowerOn_Api ()
			{
				const string __id = "powerOn_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/At88scXXHandler", DoNotGenerateAcw=true)]
	internal partial class IAt88scXXHandlerInvoker : global::Java.Lang.Object, IAt88scXXHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/At88scXXHandler", typeof (IAt88scXXHandlerInvoker));

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

		public static IAt88scXXHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAt88scXXHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.At88scXXHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAt88scXXHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_EarseEzData_Api_III;
#pragma warning disable 0169
		static Delegate GetEarseEzData_Api_IIIHandler ()
		{
			if (cb_EarseEzData_Api_III == null)
				cb_EarseEzData_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_EarseEzData_Api_III));
			return cb_EarseEzData_Api_III;
		}

		static int n_EarseEzData_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.EarseEzData_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_EarseEzData_Api_III;
		public unsafe int EarseEzData_Api (int p0, int p1, int p2)
		{
			if (id_EarseEzData_Api_III == IntPtr.Zero)
				id_EarseEzData_Api_III = JNIEnv.GetMethodID (class_ref, "EarseEzData_Api", "(III)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_EarseEzData_Api_III, __args);
		}

		static Delegate? cb_Get1608ConfigZoneData_IIarrayB;
#pragma warning disable 0169
		static Delegate GetGet1608ConfigZoneData_IIarrayBHandler ()
		{
			if (cb_Get1608ConfigZoneData_IIarrayB == null)
				cb_Get1608ConfigZoneData_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Get1608ConfigZoneData_IIarrayB));
			return cb_Get1608ConfigZoneData_IIarrayB;
		}

		static int n_Get1608ConfigZoneData_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Get1608ConfigZoneData (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Get1608ConfigZoneData_IIarrayB;
		public unsafe int Get1608ConfigZoneData (int p0, int p1, byte[]? p2)
		{
			if (id_Get1608ConfigZoneData_IIarrayB == IntPtr.Zero)
				id_Get1608ConfigZoneData_IIarrayB = JNIEnv.GetMethodID (class_ref, "Get1608ConfigZoneData", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Get1608ConfigZoneData_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_GetEzKey_IIarrayB;
#pragma warning disable 0169
		static Delegate GetGetEzKey_IIarrayBHandler ()
		{
			if (cb_GetEzKey_IIarrayB == null)
				cb_GetEzKey_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_GetEzKey_IIarrayB));
			return cb_GetEzKey_IIarrayB;
		}

		static int n_GetEzKey_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetEzKey (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetEzKey_IIarrayB;
		public unsafe int GetEzKey (int p0, int p1, byte[]? p2)
		{
			if (id_GetEzKey_IIarrayB == IntPtr.Zero)
				id_GetEzKey_IIarrayB = JNIEnv.GetMethodID (class_ref, "GetEzKey", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetEzKey_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_IccDetect_Api_I;
#pragma warning disable 0169
		static Delegate GetIccDetect_Api_IHandler ()
		{
			if (cb_IccDetect_Api_I == null)
				cb_IccDetect_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_IccDetect_Api_I));
			return cb_IccDetect_Api_I;
		}

		static int n_IccDetect_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IccDetect_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_IccDetect_Api_I;
		public unsafe int IccDetect_Api (int p0)
		{
			if (id_IccDetect_Api_I == IntPtr.Zero)
				id_IccDetect_Api_I = JNIEnv.GetMethodID (class_ref, "IccDetect_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_IccDetect_Api_I, __args);
		}

		static Delegate? cb_Verify102EzKey_Api_IIarrayB;
#pragma warning disable 0169
		static Delegate GetVerify102EzKey_Api_IIarrayBHandler ()
		{
			if (cb_Verify102EzKey_Api_IIarrayB == null)
				cb_Verify102EzKey_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Verify102EzKey_Api_IIarrayB));
			return cb_Verify102EzKey_Api_IIarrayB;
		}

		static int n_Verify102EzKey_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Verify102EzKey_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Verify102EzKey_Api_IIarrayB;
		public unsafe int Verify102EzKey_Api (int p0, int p1, byte[]? p2)
		{
			if (id_Verify102EzKey_Api_IIarrayB == IntPtr.Zero)
				id_Verify102EzKey_Api_IIarrayB = JNIEnv.GetMethodID (class_ref, "Verify102EzKey_Api", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Verify102EzKey_Api_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_icc102CheckCardType_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetIcc102CheckCardType_Api_arrayBHandler ()
		{
			if (cb_icc102CheckCardType_Api_arrayB == null)
				cb_icc102CheckCardType_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102CheckCardType_Api_arrayB));
			return cb_icc102CheckCardType_Api_arrayB;
		}

		static int n_Icc102CheckCardType_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102CheckCardType_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102CheckCardType_Api_arrayB;
		public unsafe int Icc102CheckCardType_Api (byte[]? p0)
		{
			if (id_icc102CheckCardType_Api_arrayB == IntPtr.Zero)
				id_icc102CheckCardType_Api_arrayB = JNIEnv.GetMethodID (class_ref, "icc102CheckCardType_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102CheckCardType_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_icc102ReadAppArea_Api_IIIarrayB;
#pragma warning disable 0169
		static Delegate GetIcc102ReadAppArea_Api_IIIarrayBHandler ()
		{
			if (cb_icc102ReadAppArea_Api_IIIarrayB == null)
				cb_icc102ReadAppArea_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_Icc102ReadAppArea_Api_IIIarrayB));
			return cb_icc102ReadAppArea_Api_IIIarrayB;
		}

		static int n_Icc102ReadAppArea_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102ReadAppArea_Api (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102ReadAppArea_Api_IIIarrayB;
		public unsafe int Icc102ReadAppArea_Api (int p0, int p1, int p2, byte[]? p3)
		{
			if (id_icc102ReadAppArea_Api_IIIarrayB == IntPtr.Zero)
				id_icc102ReadAppArea_Api_IIIarrayB = JNIEnv.GetMethodID (class_ref, "icc102ReadAppArea_Api", "(III[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102ReadAppArea_Api_IIIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_icc102ReadCodeProtectedBlock_Api_IIarrayB;
#pragma warning disable 0169
		static Delegate GetIcc102ReadCodeProtectedBlock_Api_IIarrayBHandler ()
		{
			if (cb_icc102ReadCodeProtectedBlock_Api_IIarrayB == null)
				cb_icc102ReadCodeProtectedBlock_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Icc102ReadCodeProtectedBlock_Api_IIarrayB));
			return cb_icc102ReadCodeProtectedBlock_Api_IIarrayB;
		}

		static int n_Icc102ReadCodeProtectedBlock_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102ReadCodeProtectedBlock_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102ReadCodeProtectedBlock_Api_IIarrayB;
		public unsafe int Icc102ReadCodeProtectedBlock_Api (int p0, int p1, byte[]? p2)
		{
			if (id_icc102ReadCodeProtectedBlock_Api_IIarrayB == IntPtr.Zero)
				id_icc102ReadCodeProtectedBlock_Api_IIarrayB = JNIEnv.GetMethodID (class_ref, "icc102ReadCodeProtectedBlock_Api", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102ReadCodeProtectedBlock_Api_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_icc102ReadErrorCountBlock_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetIcc102ReadErrorCountBlock_Api_arrayBHandler ()
		{
			if (cb_icc102ReadErrorCountBlock_Api_arrayB == null)
				cb_icc102ReadErrorCountBlock_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102ReadErrorCountBlock_Api_arrayB));
			return cb_icc102ReadErrorCountBlock_Api_arrayB;
		}

		static int n_Icc102ReadErrorCountBlock_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102ReadErrorCountBlock_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102ReadErrorCountBlock_Api_arrayB;
		public unsafe int Icc102ReadErrorCountBlock_Api (byte[]? p0)
		{
			if (id_icc102ReadErrorCountBlock_Api_arrayB == IntPtr.Zero)
				id_icc102ReadErrorCountBlock_Api_arrayB = JNIEnv.GetMethodID (class_ref, "icc102ReadErrorCountBlock_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102ReadErrorCountBlock_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_icc102ReadMfrsLoneCode_Api;
#pragma warning disable 0169
		static Delegate GetIcc102ReadMfrsLoneCode_ApiHandler ()
		{
			if (cb_icc102ReadMfrsLoneCode_Api == null)
				cb_icc102ReadMfrsLoneCode_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadMfrsLoneCode_Api));
			return cb_icc102ReadMfrsLoneCode_Api;
		}

		static IntPtr n_Icc102ReadMfrsLoneCode_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Icc102ReadMfrsLoneCode_Api ());
		}
#pragma warning restore 0169

		IntPtr id_icc102ReadMfrsLoneCode_Api;
		public unsafe byte[]? Icc102ReadMfrsLoneCode_Api ()
		{
			if (id_icc102ReadMfrsLoneCode_Api == IntPtr.Zero)
				id_icc102ReadMfrsLoneCode_Api = JNIEnv.GetMethodID (class_ref, "icc102ReadMfrsLoneCode_Api", "()[B");
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_icc102ReadMfrsLoneCode_Api), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate? cb_icc102ReadMfrsShortCode_Api;
#pragma warning disable 0169
		static Delegate GetIcc102ReadMfrsShortCode_ApiHandler ()
		{
			if (cb_icc102ReadMfrsShortCode_Api == null)
				cb_icc102ReadMfrsShortCode_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadMfrsShortCode_Api));
			return cb_icc102ReadMfrsShortCode_Api;
		}

		static IntPtr n_Icc102ReadMfrsShortCode_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Icc102ReadMfrsShortCode_Api ());
		}
#pragma warning restore 0169

		IntPtr id_icc102ReadMfrsShortCode_Api;
		public unsafe byte[]? Icc102ReadMfrsShortCode_Api ()
		{
			if (id_icc102ReadMfrsShortCode_Api == IntPtr.Zero)
				id_icc102ReadMfrsShortCode_Api = JNIEnv.GetMethodID (class_ref, "icc102ReadMfrsShortCode_Api", "()[B");
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_icc102ReadMfrsShortCode_Api), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate? cb_icc102ReadPwdErrorCount_Api;
#pragma warning disable 0169
		static Delegate GetIcc102ReadPwdErrorCount_ApiHandler ()
		{
			if (cb_icc102ReadPwdErrorCount_Api == null)
				cb_icc102ReadPwdErrorCount_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Icc102ReadPwdErrorCount_Api));
			return cb_icc102ReadPwdErrorCount_Api;
		}

		static int n_Icc102ReadPwdErrorCount_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Icc102ReadPwdErrorCount_Api ();
		}
#pragma warning restore 0169

		IntPtr id_icc102ReadPwdErrorCount_Api;
		public unsafe int Icc102ReadPwdErrorCount_Api ()
		{
			if (id_icc102ReadPwdErrorCount_Api == IntPtr.Zero)
				id_icc102ReadPwdErrorCount_Api = JNIEnv.GetMethodID (class_ref, "icc102ReadPwdErrorCount_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102ReadPwdErrorCount_Api);
		}

		static Delegate? cb_icc102ReadTestBlock_Api;
#pragma warning disable 0169
		static Delegate GetIcc102ReadTestBlock_ApiHandler ()
		{
			if (cb_icc102ReadTestBlock_Api == null)
				cb_icc102ReadTestBlock_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Icc102ReadTestBlock_Api));
			return cb_icc102ReadTestBlock_Api;
		}

		static IntPtr n_Icc102ReadTestBlock_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Icc102ReadTestBlock_Api ());
		}
#pragma warning restore 0169

		IntPtr id_icc102ReadTestBlock_Api;
		public unsafe byte[]? Icc102ReadTestBlock_Api ()
		{
			if (id_icc102ReadTestBlock_Api == IntPtr.Zero)
				id_icc102ReadTestBlock_Api = JNIEnv.GetMethodID (class_ref, "icc102ReadTestBlock_Api", "()[B");
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_icc102ReadTestBlock_Api), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate? cb_icc102UpdatePwd_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetIcc102UpdatePwd_Api_arrayBHandler ()
		{
			if (cb_icc102UpdatePwd_Api_arrayB == null)
				cb_icc102UpdatePwd_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102UpdatePwd_Api_arrayB));
			return cb_icc102UpdatePwd_Api_arrayB;
		}

		static int n_Icc102UpdatePwd_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102UpdatePwd_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102UpdatePwd_Api_arrayB;
		public unsafe int Icc102UpdatePwd_Api (byte[]? p0)
		{
			if (id_icc102UpdatePwd_Api_arrayB == IntPtr.Zero)
				id_icc102UpdatePwd_Api_arrayB = JNIEnv.GetMethodID (class_ref, "icc102UpdatePwd_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102UpdatePwd_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_icc102VerifyPwd_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetIcc102VerifyPwd_Api_arrayBHandler ()
		{
			if (cb_icc102VerifyPwd_Api_arrayB == null)
				cb_icc102VerifyPwd_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102VerifyPwd_Api_arrayB));
			return cb_icc102VerifyPwd_Api_arrayB;
		}

		static int n_Icc102VerifyPwd_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102VerifyPwd_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102VerifyPwd_Api_arrayB;
		public unsafe int Icc102VerifyPwd_Api (byte[]? p0)
		{
			if (id_icc102VerifyPwd_Api_arrayB == IntPtr.Zero)
				id_icc102VerifyPwd_Api_arrayB = JNIEnv.GetMethodID (class_ref, "icc102VerifyPwd_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102VerifyPwd_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_icc102WriteAppArea_Api_BBarrayB;
#pragma warning disable 0169
		static Delegate GetIcc102WriteAppArea_Api_BBarrayBHandler ()
		{
			if (cb_icc102WriteAppArea_Api_BBarrayB == null)
				cb_icc102WriteAppArea_Api_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc102WriteAppArea_Api_BBarrayB));
			return cb_icc102WriteAppArea_Api_BBarrayB;
		}

		static int n_Icc102WriteAppArea_Api_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102WriteAppArea_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102WriteAppArea_Api_BBarrayB;
		public unsafe int Icc102WriteAppArea_Api (sbyte p0, sbyte p1, byte[]? p2)
		{
			if (id_icc102WriteAppArea_Api_BBarrayB == IntPtr.Zero)
				id_icc102WriteAppArea_Api_BBarrayB = JNIEnv.GetMethodID (class_ref, "icc102WriteAppArea_Api", "(BB[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102WriteAppArea_Api_BBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_icc102WriteCardMfrsData_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetIcc102WriteCardMfrsData_Api_arrayBHandler ()
		{
			if (cb_icc102WriteCardMfrsData_Api_arrayB == null)
				cb_icc102WriteCardMfrsData_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102WriteCardMfrsData_Api_arrayB));
			return cb_icc102WriteCardMfrsData_Api_arrayB;
		}

		static int n_Icc102WriteCardMfrsData_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102WriteCardMfrsData_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102WriteCardMfrsData_Api_arrayB;
		public unsafe int Icc102WriteCardMfrsData_Api (byte[]? p0)
		{
			if (id_icc102WriteCardMfrsData_Api_arrayB == IntPtr.Zero)
				id_icc102WriteCardMfrsData_Api_arrayB = JNIEnv.GetMethodID (class_ref, "icc102WriteCardMfrsData_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102WriteCardMfrsData_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_icc102WriteCodeProtectedBlock_Api_IIarrayB;
#pragma warning disable 0169
		static Delegate GetIcc102WriteCodeProtectedBlock_Api_IIarrayBHandler ()
		{
			if (cb_icc102WriteCodeProtectedBlock_Api_IIarrayB == null)
				cb_icc102WriteCodeProtectedBlock_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_Icc102WriteCodeProtectedBlock_Api_IIarrayB));
			return cb_icc102WriteCodeProtectedBlock_Api_IIarrayB;
		}

		static int n_Icc102WriteCodeProtectedBlock_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102WriteCodeProtectedBlock_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102WriteCodeProtectedBlock_Api_IIarrayB;
		public unsafe int Icc102WriteCodeProtectedBlock_Api (int p0, int p1, byte[]? p2)
		{
			if (id_icc102WriteCodeProtectedBlock_Api_IIarrayB == IntPtr.Zero)
				id_icc102WriteCodeProtectedBlock_Api_IIarrayB = JNIEnv.GetMethodID (class_ref, "icc102WriteCodeProtectedBlock_Api", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102WriteCodeProtectedBlock_Api_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_icc102WriteTestBlock_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetIcc102WriteTestBlock_Api_arrayBHandler ()
		{
			if (cb_icc102WriteTestBlock_Api_arrayB == null)
				cb_icc102WriteTestBlock_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc102WriteTestBlock_Api_arrayB));
			return cb_icc102WriteTestBlock_Api_arrayB;
		}

		static int n_Icc102WriteTestBlock_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc102WriteTestBlock_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc102WriteTestBlock_Api_arrayB;
		public unsafe int Icc102WriteTestBlock_Api (byte[]? p0)
		{
			if (id_icc102WriteTestBlock_Api_arrayB == IntPtr.Zero)
				id_icc102WriteTestBlock_Api_arrayB = JNIEnv.GetMethodID (class_ref, "icc102WriteTestBlock_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc102WriteTestBlock_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_icc1608Certify_Api;
#pragma warning disable 0169
		static Delegate GetIcc1608Certify_ApiHandler ()
		{
			if (cb_icc1608Certify_Api == null)
				cb_icc1608Certify_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Icc1608Certify_Api));
			return cb_icc1608Certify_Api;
		}

		static int n_Icc1608Certify_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Icc1608Certify_Api ();
		}
#pragma warning restore 0169

		IntPtr id_icc1608Certify_Api;
		public unsafe int Icc1608Certify_Api ()
		{
			if (id_icc1608Certify_Api == IntPtr.Zero)
				id_icc1608Certify_Api = JNIEnv.GetMethodID (class_ref, "icc1608Certify_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc1608Certify_Api);
		}

		static Delegate? cb_icc1608CheckCardType_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetIcc1608CheckCardType_Api_arrayBHandler ()
		{
			if (cb_icc1608CheckCardType_Api_arrayB == null)
				cb_icc1608CheckCardType_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Icc1608CheckCardType_Api_arrayB));
			return cb_icc1608CheckCardType_Api_arrayB;
		}

		static int n_Icc1608CheckCardType_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc1608CheckCardType_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc1608CheckCardType_Api_arrayB;
		public unsafe int Icc1608CheckCardType_Api (byte[]? p0)
		{
			if (id_icc1608CheckCardType_Api_arrayB == IntPtr.Zero)
				id_icc1608CheckCardType_Api_arrayB = JNIEnv.GetMethodID (class_ref, "icc1608CheckCardType_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc1608CheckCardType_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_icc1608Read_Api_BBarrayB;
#pragma warning disable 0169
		static Delegate GetIcc1608Read_Api_BBarrayBHandler ()
		{
			if (cb_icc1608Read_Api_BBarrayB == null)
				cb_icc1608Read_Api_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc1608Read_Api_BBarrayB));
			return cb_icc1608Read_Api_BBarrayB;
		}

		static int n_Icc1608Read_Api_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc1608Read_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc1608Read_Api_BBarrayB;
		public unsafe int Icc1608Read_Api (sbyte p0, sbyte p1, byte[]? p2)
		{
			if (id_icc1608Read_Api_BBarrayB == IntPtr.Zero)
				id_icc1608Read_Api_BBarrayB = JNIEnv.GetMethodID (class_ref, "icc1608Read_Api", "(BB[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc1608Read_Api_BBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_icc1608SelectUserArea_Api_B;
#pragma warning disable 0169
		static Delegate GetIcc1608SelectUserArea_Api_BHandler ()
		{
			if (cb_icc1608SelectUserArea_Api_B == null)
				cb_icc1608SelectUserArea_Api_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_Icc1608SelectUserArea_Api_B));
			return cb_icc1608SelectUserArea_Api_B;
		}

		static int n_Icc1608SelectUserArea_Api_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Icc1608SelectUserArea_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_icc1608SelectUserArea_Api_B;
		public unsafe int Icc1608SelectUserArea_Api (sbyte p0)
		{
			if (id_icc1608SelectUserArea_Api_B == IntPtr.Zero)
				id_icc1608SelectUserArea_Api_B = JNIEnv.GetMethodID (class_ref, "icc1608SelectUserArea_Api", "(B)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc1608SelectUserArea_Api_B, __args);
		}

		static Delegate? cb_icc1608VerifyKey_Api_BarrayBB;
#pragma warning disable 0169
		static Delegate GetIcc1608VerifyKey_Api_BarrayBBHandler ()
		{
			if (cb_icc1608VerifyKey_Api_BarrayBB == null)
				cb_icc1608VerifyKey_Api_BarrayBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLB_I (n_Icc1608VerifyKey_Api_BarrayBB));
			return cb_icc1608VerifyKey_Api_BarrayBB;
		}

		static int n_Icc1608VerifyKey_Api_BarrayBB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, sbyte p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc1608VerifyKey_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc1608VerifyKey_Api_BarrayBB;
		public unsafe int Icc1608VerifyKey_Api (sbyte p0, byte[]? p1, sbyte p2)
		{
			if (id_icc1608VerifyKey_Api_BarrayBB == IntPtr.Zero)
				id_icc1608VerifyKey_Api_BarrayBB = JNIEnv.GetMethodID (class_ref, "icc1608VerifyKey_Api", "(B[BB)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc1608VerifyKey_Api_BarrayBB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_icc1608Write_BBarrayB;
#pragma warning disable 0169
		static Delegate GetIcc1608Write_BBarrayBHandler ()
		{
			if (cb_icc1608Write_BBarrayB == null)
				cb_icc1608Write_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Icc1608Write_BBarrayB));
			return cb_icc1608Write_BBarrayB;
		}

		static int n_Icc1608Write_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Icc1608Write (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_icc1608Write_BBarrayB;
		public unsafe int Icc1608Write (sbyte p0, sbyte p1, byte[]? p2)
		{
			if (id_icc1608Write_BBarrayB == IntPtr.Zero)
				id_icc1608Write_BBarrayB = JNIEnv.GetMethodID (class_ref, "icc1608Write", "(BB[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_icc1608Write_BBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_powerDown_Api;
#pragma warning disable 0169
		static Delegate GetPowerDown_ApiHandler ()
		{
			if (cb_powerDown_Api == null)
				cb_powerDown_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PowerDown_Api));
			return cb_powerDown_Api;
		}

		static int n_PowerDown_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PowerDown_Api ();
		}
#pragma warning restore 0169

		IntPtr id_powerDown_Api;
		public unsafe int PowerDown_Api ()
		{
			if (id_powerDown_Api == IntPtr.Zero)
				id_powerDown_Api = JNIEnv.GetMethodID (class_ref, "powerDown_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_powerDown_Api);
		}

		static Delegate? cb_powerOn_Api;
#pragma warning disable 0169
		static Delegate GetPowerOn_ApiHandler ()
		{
			if (cb_powerOn_Api == null)
				cb_powerOn_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PowerOn_Api));
			return cb_powerOn_Api;
		}

		static int n_PowerOn_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PowerOn_Api ();
		}
#pragma warning restore 0169

		IntPtr id_powerOn_Api;
		public unsafe int PowerOn_Api ()
		{
			if (id_powerOn_Api == IntPtr.Zero)
				id_powerOn_Api = JNIEnv.GetMethodID (class_ref, "powerOn_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_powerOn_Api);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IAt88scXXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
