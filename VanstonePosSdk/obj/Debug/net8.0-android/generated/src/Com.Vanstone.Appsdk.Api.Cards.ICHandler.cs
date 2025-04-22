using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']"
	[Register ("com/vanstone/appsdk/api/cards/ICHandler", "", "Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker")]
	public partial interface ICHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IcCardSetAutoResp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("IcCardSetAutoResp", "(II)I", "GetIcCardSetAutoResp_IIHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int IcCardSetAutoResp (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccDetectOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("IccDetectOut_Api", "(I)I", "GetIccDetectOut_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int IccDetectOut_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("IccDetect_Api", "(I)I", "GetIccDetect_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int IccDetect_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccGetCardType_Api' and count(parameter)=0]"
		[Register ("IccGetCardType_Api", "()I", "GetIccGetCardType_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int IccGetCardType_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccInit_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("IccInit_Api", "(II[B[B)I", "GetIccInit_Api_IIarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int IccInit_Api (int p0, int p1, byte[]? p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccIsoCommand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.struct.Apdu']]"
		[Register ("IccIsoCommand_Api", "(ILcom/vanstone/appsdk/api/struct/Apdu;)V", "GetIccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_Handler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		void IccIsoCommand_Api (int p0, global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccPowerOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("IccPowerOff_Api", "(I)V", "GetIccPowerOff_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		void IccPowerOff_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='Mem4442IccGetPwdCount_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("Mem4442IccGetPwdCount_Api", "([BI)I", "GetMem4442IccGetPwdCount_Api_arrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int Mem4442IccGetPwdCount_Api (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccCheck_Api' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
		[Register ("MemIccCheck_Api", "(BBI[BI)I", "GetMemIccCheck_Api_BBIarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int MemIccCheck_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPowerOff_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("MemIccPowerOff_Api", "(BB)I", "GetMemIccPowerOff_Api_BBHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int MemIccPowerOff_Api (sbyte p0, sbyte p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPowerOn_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("MemIccPowerOn_Api", "(BB)I", "GetMemIccPowerOn_Api_BBHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int MemIccPowerOn_Api (sbyte p0, sbyte p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPwdProc_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
		[Register ("MemIccPwdProc_Api", "(BBI[B[B[BI)I", "GetMemIccPwdProc_Api_BBIarrayBarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int MemIccPwdProc_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccReadData_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
		[Register ("MemIccReadData_Api", "(BBII[BI)I", "GetMemIccReadData_Api_BBIIarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int MemIccReadData_Api (sbyte p0, sbyte p1, int p2, int p3, byte[]? p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccWriteData_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
		[Register ("MemIccWriteData_Api", "(BB[BII[BI)I", "GetMemIccWriteData_Api_BBarrayBIIarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.ICHandlerInvoker, VanstonePosSdk")]
		int MemIccWriteData_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, int p4, byte[]? p5, int p6);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ICHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.ICHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ICHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/constructor[@name='ICHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_IcCardSetAutoResp_II;
#pragma warning disable 0169
			static Delegate GetIcCardSetAutoResp_IIHandler ()
			{
				if (cb_IcCardSetAutoResp_II == null)
					cb_IcCardSetAutoResp_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_IcCardSetAutoResp_II));
				return cb_IcCardSetAutoResp_II;
			}

			static int n_IcCardSetAutoResp_II (IntPtr jnienv, IntPtr native__this, int CardNo, int autoResp)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IcCardSetAutoResp (CardNo, autoResp);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='IcCardSetAutoResp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("IcCardSetAutoResp", "(II)I", "GetIcCardSetAutoResp_IIHandler")]
			public virtual unsafe int IcCardSetAutoResp (int CardNo, int autoResp)
			{
				const string __id = "IcCardSetAutoResp.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (autoResp);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_IccDetectOut_Api_I;
#pragma warning disable 0169
			static Delegate GetIccDetectOut_Api_IHandler ()
			{
				if (cb_IccDetectOut_Api_I == null)
					cb_IccDetectOut_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_IccDetectOut_Api_I));
				return cb_IccDetectOut_Api_I;
			}

			static int n_IccDetectOut_Api_I (IntPtr jnienv, IntPtr native__this, int CardNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccDetectOut_Api (CardNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='IccDetectOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetectOut_Api", "(I)I", "GetIccDetectOut_Api_IHandler")]
			public virtual unsafe int IccDetectOut_Api (int CardNo)
			{
				const string __id = "IccDetectOut_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (CardNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
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

			static int n_IccDetect_Api_I (IntPtr jnienv, IntPtr native__this, int CardNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccDetect_Api (CardNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetect_Api", "(I)I", "GetIccDetect_Api_IHandler")]
			public virtual unsafe int IccDetect_Api (int CardNo)
			{
				const string __id = "IccDetect_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (CardNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_IccGetCardType_Api;
#pragma warning disable 0169
			static Delegate GetIccGetCardType_ApiHandler ()
			{
				if (cb_IccGetCardType_Api == null)
					cb_IccGetCardType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_IccGetCardType_Api));
				return cb_IccGetCardType_Api;
			}

			static int n_IccGetCardType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccGetCardType_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='IccGetCardType_Api' and count(parameter)=0]"
			[Register ("IccGetCardType_Api", "()I", "GetIccGetCardType_ApiHandler")]
			public virtual unsafe int IccGetCardType_Api ()
			{
				const string __id = "IccGetCardType_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_IccInit_Api_IIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetIccInit_Api_IIarrayBarrayBHandler ()
			{
				if (cb_IccInit_Api_IIarrayBarrayB == null)
					cb_IccInit_Api_IIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILL_I (n_IccInit_Api_IIarrayBarrayB));
				return cb_IccInit_Api_IIarrayBarrayB;
			}

			static int n_IccInit_Api_IIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int CardNo, int VccMode, IntPtr native_RstBuf, IntPtr native_Rlen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var RstBuf = (byte[]?) JNIEnv.GetArray (native_RstBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Rlen = (byte[]?) JNIEnv.GetArray (native_Rlen, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.IccInit_Api (CardNo, VccMode, RstBuf, Rlen);
				if (RstBuf != null)
					JNIEnv.CopyArray (RstBuf, native_RstBuf);
				if (Rlen != null)
					JNIEnv.CopyArray (Rlen, native_Rlen);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='IccInit_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("IccInit_Api", "(II[B[B)I", "GetIccInit_Api_IIarrayBarrayBHandler")]
			public virtual unsafe int IccInit_Api (int CardNo, int VccMode, byte[]? RstBuf, byte[]? Rlen)
			{
				const string __id = "IccInit_Api.(II[B[B)I";
				IntPtr native_RstBuf = JNIEnv.NewArray (RstBuf);
				IntPtr native_Rlen = JNIEnv.NewArray (Rlen);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (VccMode);
					__args [2] = new JniArgumentValue (native_RstBuf);
					__args [3] = new JniArgumentValue (native_Rlen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (RstBuf != null) {
						JNIEnv.CopyArray (native_RstBuf, RstBuf);
						JNIEnv.DeleteLocalRef (native_RstBuf);
					}
					if (Rlen != null) {
						JNIEnv.CopyArray (native_Rlen, Rlen);
						JNIEnv.DeleteLocalRef (native_Rlen);
					}
					global::System.GC.KeepAlive (RstBuf);
					global::System.GC.KeepAlive (Rlen);
				}
			}

			static Delegate? cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_;
#pragma warning disable 0169
			static Delegate GetIccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_Handler ()
			{
				if (cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ == null)
					cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_));
				return cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_;
			}

			static void n_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ (IntPtr jnienv, IntPtr native__this, int CardNo, IntPtr native_apdu)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var apdu = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.Apdu> (native_apdu, JniHandleOwnership.DoNotTransfer);
				__this.IccIsoCommand_Api (CardNo, apdu);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='IccIsoCommand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.struct.Apdu']]"
			[Register ("IccIsoCommand_Api", "(ILcom/vanstone/appsdk/api/struct/Apdu;)V", "GetIccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_Handler")]
			public virtual unsafe void IccIsoCommand_Api (int CardNo, global::Com.Vanstone.Appsdk.Api.Struct.Apdu? apdu)
			{
				const string __id = "IccIsoCommand_Api.(ILcom/vanstone/appsdk/api/struct/Apdu;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue ((apdu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apdu).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (apdu);
				}
			}

			static Delegate? cb_IccPowerOff_Api_I;
#pragma warning disable 0169
			static Delegate GetIccPowerOff_Api_IHandler ()
			{
				if (cb_IccPowerOff_Api_I == null)
					cb_IccPowerOff_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_IccPowerOff_Api_I));
				return cb_IccPowerOff_Api_I;
			}

			static void n_IccPowerOff_Api_I (IntPtr jnienv, IntPtr native__this, int CardNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.IccPowerOff_Api (CardNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='IccPowerOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccPowerOff_Api", "(I)V", "GetIccPowerOff_Api_IHandler")]
			public virtual unsafe void IccPowerOff_Api (int CardNo)
			{
				const string __id = "IccPowerOff_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (CardNo);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_Mem4442IccGetPwdCount_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetMem4442IccGetPwdCount_Api_arrayBIHandler ()
			{
				if (cb_Mem4442IccGetPwdCount_Api_arrayBI == null)
					cb_Mem4442IccGetPwdCount_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Mem4442IccGetPwdCount_Api_arrayBI));
				return cb_Mem4442IccGetPwdCount_Api_arrayBI;
			}

			static int n_Mem4442IccGetPwdCount_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_OutBufHex, int OutLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var OutBufHex = (byte[]?) JNIEnv.GetArray (native_OutBufHex, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Mem4442IccGetPwdCount_Api (OutBufHex, OutLen);
				if (OutBufHex != null)
					JNIEnv.CopyArray (OutBufHex, native_OutBufHex);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='Mem4442IccGetPwdCount_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Mem4442IccGetPwdCount_Api", "([BI)I", "GetMem4442IccGetPwdCount_Api_arrayBIHandler")]
			public virtual unsafe int Mem4442IccGetPwdCount_Api (byte[]? OutBufHex, int OutLen)
			{
				const string __id = "Mem4442IccGetPwdCount_Api.([BI)I";
				IntPtr native_OutBufHex = JNIEnv.NewArray (OutBufHex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_OutBufHex);
					__args [1] = new JniArgumentValue (OutLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (OutBufHex != null) {
						JNIEnv.CopyArray (native_OutBufHex, OutBufHex);
						JNIEnv.DeleteLocalRef (native_OutBufHex);
					}
					global::System.GC.KeepAlive (OutBufHex);
				}
			}

			static Delegate? cb_MemIccCheck_Api_BBIarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccCheck_Api_BBIarrayBIHandler ()
			{
				if (cb_MemIccCheck_Api_BBIarrayBI == null)
					cb_MemIccCheck_Api_BBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBILI_I (n_MemIccCheck_Api_BBIarrayBI));
				return cb_MemIccCheck_Api_BBIarrayBI;
			}

			static int n_MemIccCheck_Api_BBIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte CardNo, sbyte CardType, int InitFlag, IntPtr native_OutBufHex, int OutLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var OutBufHex = (byte[]?) JNIEnv.GetArray (native_OutBufHex, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccCheck_Api (CardNo, CardType, InitFlag, OutBufHex, OutLen);
				if (OutBufHex != null)
					JNIEnv.CopyArray (OutBufHex, native_OutBufHex);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='MemIccCheck_Api' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("MemIccCheck_Api", "(BBI[BI)I", "GetMemIccCheck_Api_BBIarrayBIHandler")]
			public virtual unsafe int MemIccCheck_Api (sbyte CardNo, sbyte CardType, int InitFlag, byte[]? OutBufHex, int OutLen)
			{
				const string __id = "MemIccCheck_Api.(BBI[BI)I";
				IntPtr native_OutBufHex = JNIEnv.NewArray (OutBufHex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (CardType);
					__args [2] = new JniArgumentValue (InitFlag);
					__args [3] = new JniArgumentValue (native_OutBufHex);
					__args [4] = new JniArgumentValue (OutLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (OutBufHex != null) {
						JNIEnv.CopyArray (native_OutBufHex, OutBufHex);
						JNIEnv.DeleteLocalRef (native_OutBufHex);
					}
					global::System.GC.KeepAlive (OutBufHex);
				}
			}

			static Delegate? cb_MemIccPowerOff_Api_BB;
#pragma warning disable 0169
			static Delegate GetMemIccPowerOff_Api_BBHandler ()
			{
				if (cb_MemIccPowerOff_Api_BB == null)
					cb_MemIccPowerOff_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_MemIccPowerOff_Api_BB));
				return cb_MemIccPowerOff_Api_BB;
			}

			static int n_MemIccPowerOff_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte CardNo, sbyte CardType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MemIccPowerOff_Api (CardNo, CardType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='MemIccPowerOff_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("MemIccPowerOff_Api", "(BB)I", "GetMemIccPowerOff_Api_BBHandler")]
			public virtual unsafe int MemIccPowerOff_Api (sbyte CardNo, sbyte CardType)
			{
				const string __id = "MemIccPowerOff_Api.(BB)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (CardType);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_MemIccPowerOn_Api_BB;
#pragma warning disable 0169
			static Delegate GetMemIccPowerOn_Api_BBHandler ()
			{
				if (cb_MemIccPowerOn_Api_BB == null)
					cb_MemIccPowerOn_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_MemIccPowerOn_Api_BB));
				return cb_MemIccPowerOn_Api_BB;
			}

			static int n_MemIccPowerOn_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte CardNo, sbyte CardType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MemIccPowerOn_Api (CardNo, CardType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='MemIccPowerOn_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("MemIccPowerOn_Api", "(BB)I", "GetMemIccPowerOn_Api_BBHandler")]
			public virtual unsafe int MemIccPowerOn_Api (sbyte CardNo, sbyte CardType)
			{
				const string __id = "MemIccPowerOn_Api.(BB)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (CardType);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccPwdProc_Api_BBIarrayBarrayBarrayBIHandler ()
			{
				if (cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI == null)
					cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBILLLI_I (n_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI));
				return cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI;
			}

			static int n_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte CardNo, sbyte CardType, int CheckOrModify, IntPtr native_OldPwd, IntPtr native_NewPwd, IntPtr native_OutBufHex, int OutLent)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var OldPwd = (byte[]?) JNIEnv.GetArray (native_OldPwd, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var NewPwd = (byte[]?) JNIEnv.GetArray (native_NewPwd, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var OutBufHex = (byte[]?) JNIEnv.GetArray (native_OutBufHex, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccPwdProc_Api (CardNo, CardType, CheckOrModify, OldPwd, NewPwd, OutBufHex, OutLent);
				if (OldPwd != null)
					JNIEnv.CopyArray (OldPwd, native_OldPwd);
				if (NewPwd != null)
					JNIEnv.CopyArray (NewPwd, native_NewPwd);
				if (OutBufHex != null)
					JNIEnv.CopyArray (OutBufHex, native_OutBufHex);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='MemIccPwdProc_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("MemIccPwdProc_Api", "(BBI[B[B[BI)I", "GetMemIccPwdProc_Api_BBIarrayBarrayBarrayBIHandler")]
			public virtual unsafe int MemIccPwdProc_Api (sbyte CardNo, sbyte CardType, int CheckOrModify, byte[]? OldPwd, byte[]? NewPwd, byte[]? OutBufHex, int OutLent)
			{
				const string __id = "MemIccPwdProc_Api.(BBI[B[B[BI)I";
				IntPtr native_OldPwd = JNIEnv.NewArray (OldPwd);
				IntPtr native_NewPwd = JNIEnv.NewArray (NewPwd);
				IntPtr native_OutBufHex = JNIEnv.NewArray (OutBufHex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (CardType);
					__args [2] = new JniArgumentValue (CheckOrModify);
					__args [3] = new JniArgumentValue (native_OldPwd);
					__args [4] = new JniArgumentValue (native_NewPwd);
					__args [5] = new JniArgumentValue (native_OutBufHex);
					__args [6] = new JniArgumentValue (OutLent);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (OldPwd != null) {
						JNIEnv.CopyArray (native_OldPwd, OldPwd);
						JNIEnv.DeleteLocalRef (native_OldPwd);
					}
					if (NewPwd != null) {
						JNIEnv.CopyArray (native_NewPwd, NewPwd);
						JNIEnv.DeleteLocalRef (native_NewPwd);
					}
					if (OutBufHex != null) {
						JNIEnv.CopyArray (native_OutBufHex, OutBufHex);
						JNIEnv.DeleteLocalRef (native_OutBufHex);
					}
					global::System.GC.KeepAlive (OldPwd);
					global::System.GC.KeepAlive (NewPwd);
					global::System.GC.KeepAlive (OutBufHex);
				}
			}

			static Delegate? cb_MemIccReadData_Api_BBIIarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccReadData_Api_BBIIarrayBIHandler ()
			{
				if (cb_MemIccReadData_Api_BBIIarrayBI == null)
					cb_MemIccReadData_Api_BBIIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBIILI_I (n_MemIccReadData_Api_BBIIarrayBI));
				return cb_MemIccReadData_Api_BBIIarrayBI;
			}

			static int n_MemIccReadData_Api_BBIIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte CardNo, sbyte CardType, int StartAddr, int ReadLen, IntPtr native_OutBufHex, int OutLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var OutBufHex = (byte[]?) JNIEnv.GetArray (native_OutBufHex, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccReadData_Api (CardNo, CardType, StartAddr, ReadLen, OutBufHex, OutLen);
				if (OutBufHex != null)
					JNIEnv.CopyArray (OutBufHex, native_OutBufHex);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='MemIccReadData_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("MemIccReadData_Api", "(BBII[BI)I", "GetMemIccReadData_Api_BBIIarrayBIHandler")]
			public virtual unsafe int MemIccReadData_Api (sbyte CardNo, sbyte CardType, int StartAddr, int ReadLen, byte[]? OutBufHex, int OutLen)
			{
				const string __id = "MemIccReadData_Api.(BBII[BI)I";
				IntPtr native_OutBufHex = JNIEnv.NewArray (OutBufHex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (CardType);
					__args [2] = new JniArgumentValue (StartAddr);
					__args [3] = new JniArgumentValue (ReadLen);
					__args [4] = new JniArgumentValue (native_OutBufHex);
					__args [5] = new JniArgumentValue (OutLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (OutBufHex != null) {
						JNIEnv.CopyArray (native_OutBufHex, OutBufHex);
						JNIEnv.DeleteLocalRef (native_OutBufHex);
					}
					global::System.GC.KeepAlive (OutBufHex);
				}
			}

			static Delegate? cb_MemIccWriteData_Api_BBarrayBIIarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccWriteData_Api_BBarrayBIIarrayBIHandler ()
			{
				if (cb_MemIccWriteData_Api_BBarrayBIIarrayBI == null)
					cb_MemIccWriteData_Api_BBarrayBIIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLIILI_I (n_MemIccWriteData_Api_BBarrayBIIarrayBI));
				return cb_MemIccWriteData_Api_BBarrayBIIarrayBI;
			}

			static int n_MemIccWriteData_Api_BBarrayBIIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte CardNo, sbyte CardType, IntPtr native_WriteBuf, int StartAddr, int WriteLen, IntPtr native_OutBufHex, int OutLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var WriteBuf = (byte[]?) JNIEnv.GetArray (native_WriteBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var OutBufHex = (byte[]?) JNIEnv.GetArray (native_OutBufHex, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccWriteData_Api (CardNo, CardType, WriteBuf, StartAddr, WriteLen, OutBufHex, OutLen);
				if (WriteBuf != null)
					JNIEnv.CopyArray (WriteBuf, native_WriteBuf);
				if (OutBufHex != null)
					JNIEnv.CopyArray (OutBufHex, native_OutBufHex);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='MemIccWriteData_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("MemIccWriteData_Api", "(BB[BII[BI)I", "GetMemIccWriteData_Api_BBarrayBIIarrayBIHandler")]
			public virtual unsafe int MemIccWriteData_Api (sbyte CardNo, sbyte CardType, byte[]? WriteBuf, int StartAddr, int WriteLen, byte[]? OutBufHex, int OutLen)
			{
				const string __id = "MemIccWriteData_Api.(BB[BII[BI)I";
				IntPtr native_WriteBuf = JNIEnv.NewArray (WriteBuf);
				IntPtr native_OutBufHex = JNIEnv.NewArray (OutBufHex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (CardNo);
					__args [1] = new JniArgumentValue (CardType);
					__args [2] = new JniArgumentValue (native_WriteBuf);
					__args [3] = new JniArgumentValue (StartAddr);
					__args [4] = new JniArgumentValue (WriteLen);
					__args [5] = new JniArgumentValue (native_OutBufHex);
					__args [6] = new JniArgumentValue (OutLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (WriteBuf != null) {
						JNIEnv.CopyArray (native_WriteBuf, WriteBuf);
						JNIEnv.DeleteLocalRef (native_WriteBuf);
					}
					if (OutBufHex != null) {
						JNIEnv.CopyArray (native_OutBufHex, OutBufHex);
						JNIEnv.DeleteLocalRef (native_OutBufHex);
					}
					global::System.GC.KeepAlive (WriteBuf);
					global::System.GC.KeepAlive (OutBufHex);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ICHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.ICHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ICHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Stub']/constructor[@name='ICHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/ICHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/ICHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/ICHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/ICHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ICHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.ICHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/ICHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.ICHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/ICHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_IcCardSetAutoResp_II;
#pragma warning disable 0169
			static Delegate GetIcCardSetAutoResp_IIHandler ()
			{
				if (cb_IcCardSetAutoResp_II == null)
					cb_IcCardSetAutoResp_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_IcCardSetAutoResp_II));
				return cb_IcCardSetAutoResp_II;
			}

			static int n_IcCardSetAutoResp_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IcCardSetAutoResp (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IcCardSetAutoResp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("IcCardSetAutoResp", "(II)I", "GetIcCardSetAutoResp_IIHandler")]
			public abstract int IcCardSetAutoResp (int p0, int p1);

			static Delegate? cb_IccDetectOut_Api_I;
#pragma warning disable 0169
			static Delegate GetIccDetectOut_Api_IHandler ()
			{
				if (cb_IccDetectOut_Api_I == null)
					cb_IccDetectOut_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_IccDetectOut_Api_I));
				return cb_IccDetectOut_Api_I;
			}

			static int n_IccDetectOut_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccDetectOut_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccDetectOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetectOut_Api", "(I)I", "GetIccDetectOut_Api_IHandler")]
			public abstract int IccDetectOut_Api (int p0);

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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccDetect_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetect_Api", "(I)I", "GetIccDetect_Api_IHandler")]
			public abstract int IccDetect_Api (int p0);

			static Delegate? cb_IccGetCardType_Api;
#pragma warning disable 0169
			static Delegate GetIccGetCardType_ApiHandler ()
			{
				if (cb_IccGetCardType_Api == null)
					cb_IccGetCardType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_IccGetCardType_Api));
				return cb_IccGetCardType_Api;
			}

			static int n_IccGetCardType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IccGetCardType_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccGetCardType_Api' and count(parameter)=0]"
			[Register ("IccGetCardType_Api", "()I", "GetIccGetCardType_ApiHandler")]
			public abstract int IccGetCardType_Api ();

			static Delegate? cb_IccInit_Api_IIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetIccInit_Api_IIarrayBarrayBHandler ()
			{
				if (cb_IccInit_Api_IIarrayBarrayB == null)
					cb_IccInit_Api_IIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILL_I (n_IccInit_Api_IIarrayBarrayB));
				return cb_IccInit_Api_IIarrayBarrayB;
			}

			static int n_IccInit_Api_IIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.IccInit_Api (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccInit_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("IccInit_Api", "(II[B[B)I", "GetIccInit_Api_IIarrayBarrayBHandler")]
			public abstract int IccInit_Api (int p0, int p1, byte[]? p2, byte[]? p3);

			static Delegate? cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_;
#pragma warning disable 0169
			static Delegate GetIccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_Handler ()
			{
				if (cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ == null)
					cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_));
				return cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_;
			}

			static void n_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.Apdu> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.IccIsoCommand_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccIsoCommand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.struct.Apdu']]"
			[Register ("IccIsoCommand_Api", "(ILcom/vanstone/appsdk/api/struct/Apdu;)V", "GetIccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_Handler")]
			public abstract void IccIsoCommand_Api (int p0, global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p1);

			static Delegate? cb_IccPowerOff_Api_I;
#pragma warning disable 0169
			static Delegate GetIccPowerOff_Api_IHandler ()
			{
				if (cb_IccPowerOff_Api_I == null)
					cb_IccPowerOff_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_IccPowerOff_Api_I));
				return cb_IccPowerOff_Api_I;
			}

			static void n_IccPowerOff_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.IccPowerOff_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccPowerOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccPowerOff_Api", "(I)V", "GetIccPowerOff_Api_IHandler")]
			public abstract void IccPowerOff_Api (int p0);

			static Delegate? cb_Mem4442IccGetPwdCount_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetMem4442IccGetPwdCount_Api_arrayBIHandler ()
			{
				if (cb_Mem4442IccGetPwdCount_Api_arrayBI == null)
					cb_Mem4442IccGetPwdCount_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Mem4442IccGetPwdCount_Api_arrayBI));
				return cb_Mem4442IccGetPwdCount_Api_arrayBI;
			}

			static int n_Mem4442IccGetPwdCount_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Mem4442IccGetPwdCount_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='Mem4442IccGetPwdCount_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Mem4442IccGetPwdCount_Api", "([BI)I", "GetMem4442IccGetPwdCount_Api_arrayBIHandler")]
			public abstract int Mem4442IccGetPwdCount_Api (byte[]? p0, int p1);

			static Delegate? cb_MemIccCheck_Api_BBIarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccCheck_Api_BBIarrayBIHandler ()
			{
				if (cb_MemIccCheck_Api_BBIarrayBI == null)
					cb_MemIccCheck_Api_BBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBILI_I (n_MemIccCheck_Api_BBIarrayBI));
				return cb_MemIccCheck_Api_BBIarrayBI;
			}

			static int n_MemIccCheck_Api_BBIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, int p2, IntPtr native_p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccCheck_Api (p0, p1, p2, p3, p4);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccCheck_Api' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("MemIccCheck_Api", "(BBI[BI)I", "GetMemIccCheck_Api_BBIarrayBIHandler")]
			public abstract int MemIccCheck_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, int p4);

			static Delegate? cb_MemIccPowerOff_Api_BB;
#pragma warning disable 0169
			static Delegate GetMemIccPowerOff_Api_BBHandler ()
			{
				if (cb_MemIccPowerOff_Api_BB == null)
					cb_MemIccPowerOff_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_MemIccPowerOff_Api_BB));
				return cb_MemIccPowerOff_Api_BB;
			}

			static int n_MemIccPowerOff_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MemIccPowerOff_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPowerOff_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("MemIccPowerOff_Api", "(BB)I", "GetMemIccPowerOff_Api_BBHandler")]
			public abstract int MemIccPowerOff_Api (sbyte p0, sbyte p1);

			static Delegate? cb_MemIccPowerOn_Api_BB;
#pragma warning disable 0169
			static Delegate GetMemIccPowerOn_Api_BBHandler ()
			{
				if (cb_MemIccPowerOn_Api_BB == null)
					cb_MemIccPowerOn_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_MemIccPowerOn_Api_BB));
				return cb_MemIccPowerOn_Api_BB;
			}

			static int n_MemIccPowerOn_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MemIccPowerOn_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPowerOn_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("MemIccPowerOn_Api", "(BB)I", "GetMemIccPowerOn_Api_BBHandler")]
			public abstract int MemIccPowerOn_Api (sbyte p0, sbyte p1);

			static Delegate? cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccPwdProc_Api_BBIarrayBarrayBarrayBIHandler ()
			{
				if (cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI == null)
					cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBILLLI_I (n_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI));
				return cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI;
			}

			static int n_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, int p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccPwdProc_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPwdProc_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("MemIccPwdProc_Api", "(BBI[B[B[BI)I", "GetMemIccPwdProc_Api_BBIarrayBarrayBarrayBIHandler")]
			public abstract int MemIccPwdProc_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6);

			static Delegate? cb_MemIccReadData_Api_BBIIarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccReadData_Api_BBIIarrayBIHandler ()
			{
				if (cb_MemIccReadData_Api_BBIIarrayBI == null)
					cb_MemIccReadData_Api_BBIIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBIILI_I (n_MemIccReadData_Api_BBIIarrayBI));
				return cb_MemIccReadData_Api_BBIIarrayBI;
			}

			static int n_MemIccReadData_Api_BBIIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, int p2, int p3, IntPtr native_p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccReadData_Api (p0, p1, p2, p3, p4, p5);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccReadData_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("MemIccReadData_Api", "(BBII[BI)I", "GetMemIccReadData_Api_BBIIarrayBIHandler")]
			public abstract int MemIccReadData_Api (sbyte p0, sbyte p1, int p2, int p3, byte[]? p4, int p5);

			static Delegate? cb_MemIccWriteData_Api_BBarrayBIIarrayBI;
#pragma warning disable 0169
			static Delegate GetMemIccWriteData_Api_BBarrayBIIarrayBIHandler ()
			{
				if (cb_MemIccWriteData_Api_BBarrayBIIarrayBI == null)
					cb_MemIccWriteData_Api_BBarrayBIIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLIILI_I (n_MemIccWriteData_Api_BBarrayBIIarrayBI));
				return cb_MemIccWriteData_Api_BBarrayBIIarrayBI;
			}

			static int n_MemIccWriteData_Api_BBarrayBIIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5, int p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.MemIccWriteData_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccWriteData_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("MemIccWriteData_Api", "(BB[BII[BI)I", "GetMemIccWriteData_Api_BBarrayBIIarrayBIHandler")]
			public abstract int MemIccWriteData_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, int p4, byte[]? p5, int p6);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ICHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ICHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IcCardSetAutoResp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("IcCardSetAutoResp", "(II)I", "GetIcCardSetAutoResp_IIHandler")]
			public override unsafe int IcCardSetAutoResp (int p0, int p1)
			{
				const string __id = "IcCardSetAutoResp.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccDetectOut_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccDetectOut_Api", "(I)I", "GetIccDetectOut_Api_IHandler")]
			public override unsafe int IccDetectOut_Api (int p0)
			{
				const string __id = "IccDetectOut_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccDetect_Api' and count(parameter)=1 and parameter[1][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccGetCardType_Api' and count(parameter)=0]"
			[Register ("IccGetCardType_Api", "()I", "GetIccGetCardType_ApiHandler")]
			public override unsafe int IccGetCardType_Api ()
			{
				const string __id = "IccGetCardType_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccInit_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("IccInit_Api", "(II[B[B)I", "GetIccInit_Api_IIarrayBarrayBHandler")]
			public override unsafe int IccInit_Api (int p0, int p1, byte[]? p2, byte[]? p3)
			{
				const string __id = "IccInit_Api.(II[B[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccIsoCommand_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vanstone.appsdk.api.struct.Apdu']]"
			[Register ("IccIsoCommand_Api", "(ILcom/vanstone/appsdk/api/struct/Apdu;)V", "GetIccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_Handler")]
			public override unsafe void IccIsoCommand_Api (int p0, global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p1)
			{
				const string __id = "IccIsoCommand_Api.(ILcom/vanstone/appsdk/api/struct/Apdu;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='IccPowerOff_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("IccPowerOff_Api", "(I)V", "GetIccPowerOff_Api_IHandler")]
			public override unsafe void IccPowerOff_Api (int p0)
			{
				const string __id = "IccPowerOff_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='Mem4442IccGetPwdCount_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Mem4442IccGetPwdCount_Api", "([BI)I", "GetMem4442IccGetPwdCount_Api_arrayBIHandler")]
			public override unsafe int Mem4442IccGetPwdCount_Api (byte[]? p0, int p1)
			{
				const string __id = "Mem4442IccGetPwdCount_Api.([BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccCheck_Api' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
			[Register ("MemIccCheck_Api", "(BBI[BI)I", "GetMemIccCheck_Api_BBIarrayBIHandler")]
			public override unsafe int MemIccCheck_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, int p4)
			{
				const string __id = "MemIccCheck_Api.(BBI[BI)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPowerOff_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("MemIccPowerOff_Api", "(BB)I", "GetMemIccPowerOff_Api_BBHandler")]
			public override unsafe int MemIccPowerOff_Api (sbyte p0, sbyte p1)
			{
				const string __id = "MemIccPowerOff_Api.(BB)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPowerOn_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("MemIccPowerOn_Api", "(BB)I", "GetMemIccPowerOn_Api_BBHandler")]
			public override unsafe int MemIccPowerOn_Api (sbyte p0, sbyte p1)
			{
				const string __id = "MemIccPowerOn_Api.(BB)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccPwdProc_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("MemIccPwdProc_Api", "(BBI[B[B[BI)I", "GetMemIccPwdProc_Api_BBIarrayBarrayBarrayBIHandler")]
			public override unsafe int MemIccPwdProc_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6)
			{
				const string __id = "MemIccPwdProc_Api.(BBI[B[B[BI)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
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
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccReadData_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("MemIccReadData_Api", "(BBII[BI)I", "GetMemIccReadData_Api_BBIIarrayBIHandler")]
			public override unsafe int MemIccReadData_Api (sbyte p0, sbyte p1, int p2, int p3, byte[]? p4, int p5)
			{
				const string __id = "MemIccReadData_Api.(BBII[BI)I";
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ICHandler']/method[@name='MemIccWriteData_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
			[Register ("MemIccWriteData_Api", "(BB[BII[BI)I", "GetMemIccWriteData_Api_BBarrayBIIarrayBIHandler")]
			public override unsafe int MemIccWriteData_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, int p4, byte[]? p5, int p6)
			{
				const string __id = "MemIccWriteData_Api.(BB[BII[BI)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p5);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ICHandler", DoNotGenerateAcw=true)]
	internal partial class ICHandlerInvoker : global::Java.Lang.Object, ICHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ICHandler", typeof (ICHandlerInvoker));

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

		public static ICHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.ICHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_IcCardSetAutoResp_II;
#pragma warning disable 0169
		static Delegate GetIcCardSetAutoResp_IIHandler ()
		{
			if (cb_IcCardSetAutoResp_II == null)
				cb_IcCardSetAutoResp_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_IcCardSetAutoResp_II));
			return cb_IcCardSetAutoResp_II;
		}

		static int n_IcCardSetAutoResp_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IcCardSetAutoResp (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_IcCardSetAutoResp_II;
		public unsafe int IcCardSetAutoResp (int p0, int p1)
		{
			if (id_IcCardSetAutoResp_II == IntPtr.Zero)
				id_IcCardSetAutoResp_II = JNIEnv.GetMethodID (class_ref, "IcCardSetAutoResp", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_IcCardSetAutoResp_II, __args);
		}

		static Delegate? cb_IccDetectOut_Api_I;
#pragma warning disable 0169
		static Delegate GetIccDetectOut_Api_IHandler ()
		{
			if (cb_IccDetectOut_Api_I == null)
				cb_IccDetectOut_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_IccDetectOut_Api_I));
			return cb_IccDetectOut_Api_I;
		}

		static int n_IccDetectOut_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IccDetectOut_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_IccDetectOut_Api_I;
		public unsafe int IccDetectOut_Api (int p0)
		{
			if (id_IccDetectOut_Api_I == IntPtr.Zero)
				id_IccDetectOut_Api_I = JNIEnv.GetMethodID (class_ref, "IccDetectOut_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_IccDetectOut_Api_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_IccGetCardType_Api;
#pragma warning disable 0169
		static Delegate GetIccGetCardType_ApiHandler ()
		{
			if (cb_IccGetCardType_Api == null)
				cb_IccGetCardType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_IccGetCardType_Api));
			return cb_IccGetCardType_Api;
		}

		static int n_IccGetCardType_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IccGetCardType_Api ();
		}
#pragma warning restore 0169

		IntPtr id_IccGetCardType_Api;
		public unsafe int IccGetCardType_Api ()
		{
			if (id_IccGetCardType_Api == IntPtr.Zero)
				id_IccGetCardType_Api = JNIEnv.GetMethodID (class_ref, "IccGetCardType_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_IccGetCardType_Api);
		}

		static Delegate? cb_IccInit_Api_IIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetIccInit_Api_IIarrayBarrayBHandler ()
		{
			if (cb_IccInit_Api_IIarrayBarrayB == null)
				cb_IccInit_Api_IIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILL_I (n_IccInit_Api_IIarrayBarrayB));
			return cb_IccInit_Api_IIarrayBarrayB;
		}

		static int n_IccInit_Api_IIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.IccInit_Api (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_IccInit_Api_IIarrayBarrayB;
		public unsafe int IccInit_Api (int p0, int p1, byte[]? p2, byte[]? p3)
		{
			if (id_IccInit_Api_IIarrayBarrayB == IntPtr.Zero)
				id_IccInit_Api_IIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "IccInit_Api", "(II[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_IccInit_Api_IIarrayBarrayB, __args);
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

		static Delegate? cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_;
#pragma warning disable 0169
		static Delegate GetIccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_Handler ()
		{
			if (cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ == null)
				cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_));
			return cb_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_;
		}

		static void n_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.Apdu> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.IccIsoCommand_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_;
		public unsafe void IccIsoCommand_Api (int p0, global::Com.Vanstone.Appsdk.Api.Struct.Apdu? p1)
		{
			if (id_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ == IntPtr.Zero)
				id_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_ = JNIEnv.GetMethodID (class_ref, "IccIsoCommand_Api", "(ILcom/vanstone/appsdk/api/struct/Apdu;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_IccIsoCommand_Api_ILcom_vanstone_appsdk_api_struct_Apdu_, __args);
		}

		static Delegate? cb_IccPowerOff_Api_I;
#pragma warning disable 0169
		static Delegate GetIccPowerOff_Api_IHandler ()
		{
			if (cb_IccPowerOff_Api_I == null)
				cb_IccPowerOff_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_IccPowerOff_Api_I));
			return cb_IccPowerOff_Api_I;
		}

		static void n_IccPowerOff_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.IccPowerOff_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_IccPowerOff_Api_I;
		public unsafe void IccPowerOff_Api (int p0)
		{
			if (id_IccPowerOff_Api_I == IntPtr.Zero)
				id_IccPowerOff_Api_I = JNIEnv.GetMethodID (class_ref, "IccPowerOff_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_IccPowerOff_Api_I, __args);
		}

		static Delegate? cb_Mem4442IccGetPwdCount_Api_arrayBI;
#pragma warning disable 0169
		static Delegate GetMem4442IccGetPwdCount_Api_arrayBIHandler ()
		{
			if (cb_Mem4442IccGetPwdCount_Api_arrayBI == null)
				cb_Mem4442IccGetPwdCount_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Mem4442IccGetPwdCount_Api_arrayBI));
			return cb_Mem4442IccGetPwdCount_Api_arrayBI;
		}

		static int n_Mem4442IccGetPwdCount_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Mem4442IccGetPwdCount_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Mem4442IccGetPwdCount_Api_arrayBI;
		public unsafe int Mem4442IccGetPwdCount_Api (byte[]? p0, int p1)
		{
			if (id_Mem4442IccGetPwdCount_Api_arrayBI == IntPtr.Zero)
				id_Mem4442IccGetPwdCount_Api_arrayBI = JNIEnv.GetMethodID (class_ref, "Mem4442IccGetPwdCount_Api", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Mem4442IccGetPwdCount_Api_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_MemIccCheck_Api_BBIarrayBI;
#pragma warning disable 0169
		static Delegate GetMemIccCheck_Api_BBIarrayBIHandler ()
		{
			if (cb_MemIccCheck_Api_BBIarrayBI == null)
				cb_MemIccCheck_Api_BBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBILI_I (n_MemIccCheck_Api_BBIarrayBI));
			return cb_MemIccCheck_Api_BBIarrayBI;
		}

		static int n_MemIccCheck_Api_BBIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, int p2, IntPtr native_p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.MemIccCheck_Api (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_MemIccCheck_Api_BBIarrayBI;
		public unsafe int MemIccCheck_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, int p4)
		{
			if (id_MemIccCheck_Api_BBIarrayBI == IntPtr.Zero)
				id_MemIccCheck_Api_BBIarrayBI = JNIEnv.GetMethodID (class_ref, "MemIccCheck_Api", "(BBI[BI)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MemIccCheck_Api_BBIarrayBI, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_MemIccPowerOff_Api_BB;
#pragma warning disable 0169
		static Delegate GetMemIccPowerOff_Api_BBHandler ()
		{
			if (cb_MemIccPowerOff_Api_BB == null)
				cb_MemIccPowerOff_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_MemIccPowerOff_Api_BB));
			return cb_MemIccPowerOff_Api_BB;
		}

		static int n_MemIccPowerOff_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MemIccPowerOff_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_MemIccPowerOff_Api_BB;
		public unsafe int MemIccPowerOff_Api (sbyte p0, sbyte p1)
		{
			if (id_MemIccPowerOff_Api_BB == IntPtr.Zero)
				id_MemIccPowerOff_Api_BB = JNIEnv.GetMethodID (class_ref, "MemIccPowerOff_Api", "(BB)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MemIccPowerOff_Api_BB, __args);
		}

		static Delegate? cb_MemIccPowerOn_Api_BB;
#pragma warning disable 0169
		static Delegate GetMemIccPowerOn_Api_BBHandler ()
		{
			if (cb_MemIccPowerOn_Api_BB == null)
				cb_MemIccPowerOn_Api_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_MemIccPowerOn_Api_BB));
			return cb_MemIccPowerOn_Api_BB;
		}

		static int n_MemIccPowerOn_Api_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MemIccPowerOn_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_MemIccPowerOn_Api_BB;
		public unsafe int MemIccPowerOn_Api (sbyte p0, sbyte p1)
		{
			if (id_MemIccPowerOn_Api_BB == IntPtr.Zero)
				id_MemIccPowerOn_Api_BB = JNIEnv.GetMethodID (class_ref, "MemIccPowerOn_Api", "(BB)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MemIccPowerOn_Api_BB, __args);
		}

		static Delegate? cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetMemIccPwdProc_Api_BBIarrayBarrayBarrayBIHandler ()
		{
			if (cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI == null)
				cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBILLLI_I (n_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI));
			return cb_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI;
		}

		static int n_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, int p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.MemIccPwdProc_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI;
		public unsafe int MemIccPwdProc_Api (sbyte p0, sbyte p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, int p6)
		{
			if (id_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI == IntPtr.Zero)
				id_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "MemIccPwdProc_Api", "(BBI[B[B[BI)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MemIccPwdProc_Api_BBIarrayBarrayBarrayBI, __args);
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

		static Delegate? cb_MemIccReadData_Api_BBIIarrayBI;
#pragma warning disable 0169
		static Delegate GetMemIccReadData_Api_BBIIarrayBIHandler ()
		{
			if (cb_MemIccReadData_Api_BBIIarrayBI == null)
				cb_MemIccReadData_Api_BBIIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBIILI_I (n_MemIccReadData_Api_BBIIarrayBI));
			return cb_MemIccReadData_Api_BBIIarrayBI;
		}

		static int n_MemIccReadData_Api_BBIIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, int p2, int p3, IntPtr native_p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.MemIccReadData_Api (p0, p1, p2, p3, p4, p5);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_MemIccReadData_Api_BBIIarrayBI;
		public unsafe int MemIccReadData_Api (sbyte p0, sbyte p1, int p2, int p3, byte[]? p4, int p5)
		{
			if (id_MemIccReadData_Api_BBIIarrayBI == IntPtr.Zero)
				id_MemIccReadData_Api_BBIIarrayBI = JNIEnv.GetMethodID (class_ref, "MemIccReadData_Api", "(BBII[BI)I");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MemIccReadData_Api_BBIIarrayBI, __args);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_MemIccWriteData_Api_BBarrayBIIarrayBI;
#pragma warning disable 0169
		static Delegate GetMemIccWriteData_Api_BBarrayBIIarrayBIHandler ()
		{
			if (cb_MemIccWriteData_Api_BBarrayBIIarrayBI == null)
				cb_MemIccWriteData_Api_BBarrayBIIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLIILI_I (n_MemIccWriteData_Api_BBarrayBIIarrayBI));
			return cb_MemIccWriteData_Api_BBarrayBIIarrayBI;
		}

		static int n_MemIccWriteData_Api_BBarrayBIIarrayBI (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5, int p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.MemIccWriteData_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_MemIccWriteData_Api_BBarrayBIIarrayBI;
		public unsafe int MemIccWriteData_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, int p4, byte[]? p5, int p6)
		{
			if (id_MemIccWriteData_Api_BBarrayBIIarrayBI == IntPtr.Zero)
				id_MemIccWriteData_Api_BBarrayBIIarrayBI = JNIEnv.GetMethodID (class_ref, "MemIccWriteData_Api", "(BB[BII[BI)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_MemIccWriteData_Api_BBarrayBIIarrayBI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.ICHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
