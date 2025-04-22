using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']"
	[Register ("com/vanstone/appsdk/api/cards/ContactlessHandler", "", "Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker")]
	public partial interface IContactlessHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Decrement_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("M1Decrement_Api", "(II)I", "GetM1Decrement_Api_IIHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int M1Decrement_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Increment_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("M1Increment_Api", "(II)I", "GetM1Increment_Api_IIHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int M1Increment_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Restore_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("M1Restore_Api", "(I)I", "GetM1Restore_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int M1Restore_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Transfer_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("M1Transfer_Api", "(I)I", "GetM1Transfer_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int M1Transfer_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAAnticollision_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
		[Register ("cardAAnticollision_Api", "([B[I)I", "GetCardAAnticollision_Api_arrayBarrayIHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int CardAAnticollision_Api (byte[]? p0, int[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardADeselect_Api' and count(parameter)=0]"
		[Register ("cardADeselect_Api", "()I", "GetCardADeselect_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int CardADeselect_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAPause_Api' and count(parameter)=0]"
		[Register ("cardAPause_Api", "()I", "GetCardAPause_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int CardAPause_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardARats_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("cardARats_Api", "(I[B)I", "GetCardARats_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int CardARats_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAReq_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("cardAReq_Api", "([B)I", "GetCardAReq_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int CardAReq_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAWakeUp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("cardAWakeUp_Api", "([B)I", "GetCardAWakeUp_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int CardAWakeUp_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='closeField_Api' and count(parameter)=0]"
		[Register ("closeField_Api", "()I", "GetCloseField_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int CloseField_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='openField_Api' and count(parameter)=0]"
		[Register ("openField_Api", "()I", "GetOpenField_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int OpenField_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='readSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("readSecurityMem_Api", "(I[BI)I", "GetReadSecurityMem_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int ReadSecurityMem_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='writeSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("writeSecurityMem_Api", "(I[BI)I", "GetWriteSecurityMem_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IContactlessHandlerInvoker, VanstonePosSdk")]
		int WriteSecurityMem_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ContactlessHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ContactlessHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/constructor[@name='ContactlessHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_M1Decrement_Api_II;
#pragma warning disable 0169
			static Delegate GetM1Decrement_Api_IIHandler ()
			{
				if (cb_M1Decrement_Api_II == null)
					cb_M1Decrement_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_M1Decrement_Api_II));
				return cb_M1Decrement_Api_II;
			}

			static int n_M1Decrement_Api_II (IntPtr jnienv, IntPtr native__this, int blockNum, int value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Decrement_Api (blockNum, value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='M1Decrement_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("M1Decrement_Api", "(II)I", "GetM1Decrement_Api_IIHandler")]
			public virtual unsafe int M1Decrement_Api (int blockNum, int value)
			{
				const string __id = "M1Decrement_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (blockNum);
					__args [1] = new JniArgumentValue (value);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_M1Increment_Api_II;
#pragma warning disable 0169
			static Delegate GetM1Increment_Api_IIHandler ()
			{
				if (cb_M1Increment_Api_II == null)
					cb_M1Increment_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_M1Increment_Api_II));
				return cb_M1Increment_Api_II;
			}

			static int n_M1Increment_Api_II (IntPtr jnienv, IntPtr native__this, int blockNum, int value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Increment_Api (blockNum, value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='M1Increment_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("M1Increment_Api", "(II)I", "GetM1Increment_Api_IIHandler")]
			public virtual unsafe int M1Increment_Api (int blockNum, int value)
			{
				const string __id = "M1Increment_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (blockNum);
					__args [1] = new JniArgumentValue (value);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_M1Restore_Api_I;
#pragma warning disable 0169
			static Delegate GetM1Restore_Api_IHandler ()
			{
				if (cb_M1Restore_Api_I == null)
					cb_M1Restore_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_M1Restore_Api_I));
				return cb_M1Restore_Api_I;
			}

			static int n_M1Restore_Api_I (IntPtr jnienv, IntPtr native__this, int blockNum)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Restore_Api (blockNum);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='M1Restore_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("M1Restore_Api", "(I)I", "GetM1Restore_Api_IHandler")]
			public virtual unsafe int M1Restore_Api (int blockNum)
			{
				const string __id = "M1Restore_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (blockNum);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_M1Transfer_Api_I;
#pragma warning disable 0169
			static Delegate GetM1Transfer_Api_IHandler ()
			{
				if (cb_M1Transfer_Api_I == null)
					cb_M1Transfer_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_M1Transfer_Api_I));
				return cb_M1Transfer_Api_I;
			}

			static int n_M1Transfer_Api_I (IntPtr jnienv, IntPtr native__this, int blockNum)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Transfer_Api (blockNum);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='M1Transfer_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("M1Transfer_Api", "(I)I", "GetM1Transfer_Api_IHandler")]
			public virtual unsafe int M1Transfer_Api (int blockNum)
			{
				const string __id = "M1Transfer_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (blockNum);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_cardAAnticollision_Api_arrayBarrayI;
#pragma warning disable 0169
			static Delegate GetCardAAnticollision_Api_arrayBarrayIHandler ()
			{
				if (cb_cardAAnticollision_Api_arrayBarrayI == null)
					cb_cardAAnticollision_Api_arrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_CardAAnticollision_Api_arrayBarrayI));
				return cb_cardAAnticollision_Api_arrayBarrayI;
			}

			static int n_CardAAnticollision_Api_arrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_uid, IntPtr native_sak)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var uid = (byte[]?) JNIEnv.GetArray (native_uid, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var sak = (int[]?) JNIEnv.GetArray (native_sak, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.CardAAnticollision_Api (uid, sak);
				if (uid != null)
					JNIEnv.CopyArray (uid, native_uid);
				if (sak != null)
					JNIEnv.CopyArray (sak, native_sak);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='cardAAnticollision_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
			[Register ("cardAAnticollision_Api", "([B[I)I", "GetCardAAnticollision_Api_arrayBarrayIHandler")]
			public virtual unsafe int CardAAnticollision_Api (byte[]? uid, int[]? sak)
			{
				const string __id = "cardAAnticollision_Api.([B[I)I";
				IntPtr native_uid = JNIEnv.NewArray (uid);
				IntPtr native_sak = JNIEnv.NewArray (sak);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_uid);
					__args [1] = new JniArgumentValue (native_sak);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (uid != null) {
						JNIEnv.CopyArray (native_uid, uid);
						JNIEnv.DeleteLocalRef (native_uid);
					}
					if (sak != null) {
						JNIEnv.CopyArray (native_sak, sak);
						JNIEnv.DeleteLocalRef (native_sak);
					}
					global::System.GC.KeepAlive (uid);
					global::System.GC.KeepAlive (sak);
				}
			}

			static Delegate? cb_cardADeselect_Api;
#pragma warning disable 0169
			static Delegate GetCardADeselect_ApiHandler ()
			{
				if (cb_cardADeselect_Api == null)
					cb_cardADeselect_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CardADeselect_Api));
				return cb_cardADeselect_Api;
			}

			static int n_CardADeselect_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CardADeselect_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='cardADeselect_Api' and count(parameter)=0]"
			[Register ("cardADeselect_Api", "()I", "GetCardADeselect_ApiHandler")]
			public virtual unsafe int CardADeselect_Api ()
			{
				const string __id = "cardADeselect_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_cardAPause_Api;
#pragma warning disable 0169
			static Delegate GetCardAPause_ApiHandler ()
			{
				if (cb_cardAPause_Api == null)
					cb_cardAPause_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CardAPause_Api));
				return cb_cardAPause_Api;
			}

			static int n_CardAPause_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CardAPause_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='cardAPause_Api' and count(parameter)=0]"
			[Register ("cardAPause_Api", "()I", "GetCardAPause_ApiHandler")]
			public virtual unsafe int CardAPause_Api ()
			{
				const string __id = "cardAPause_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_cardARats_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetCardARats_Api_IarrayBHandler ()
			{
				if (cb_cardARats_Api_IarrayB == null)
					cb_cardARats_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_CardARats_Api_IarrayB));
				return cb_cardARats_Api_IarrayB;
			}

			static int n_CardARats_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int mode, IntPtr native_ats)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ats = (byte[]?) JNIEnv.GetArray (native_ats, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CardARats_Api (mode, ats);
				if (ats != null)
					JNIEnv.CopyArray (ats, native_ats);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='cardARats_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("cardARats_Api", "(I[B)I", "GetCardARats_Api_IarrayBHandler")]
			public virtual unsafe int CardARats_Api (int mode, byte[]? ats)
			{
				const string __id = "cardARats_Api.(I[B)I";
				IntPtr native_ats = JNIEnv.NewArray (ats);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (mode);
					__args [1] = new JniArgumentValue (native_ats);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ats != null) {
						JNIEnv.CopyArray (native_ats, ats);
						JNIEnv.DeleteLocalRef (native_ats);
					}
					global::System.GC.KeepAlive (ats);
				}
			}

			static Delegate? cb_cardAReq_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetCardAReq_Api_arrayBHandler ()
			{
				if (cb_cardAReq_Api_arrayB == null)
					cb_cardAReq_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_CardAReq_Api_arrayB));
				return cb_cardAReq_Api_arrayB;
			}

			static int n_CardAReq_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_ATQA)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ATQA = (byte[]?) JNIEnv.GetArray (native_ATQA, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CardAReq_Api (ATQA);
				if (ATQA != null)
					JNIEnv.CopyArray (ATQA, native_ATQA);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='cardAReq_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("cardAReq_Api", "([B)I", "GetCardAReq_Api_arrayBHandler")]
			public virtual unsafe int CardAReq_Api (byte[]? ATQA)
			{
				const string __id = "cardAReq_Api.([B)I";
				IntPtr native_ATQA = JNIEnv.NewArray (ATQA);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ATQA);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ATQA != null) {
						JNIEnv.CopyArray (native_ATQA, ATQA);
						JNIEnv.DeleteLocalRef (native_ATQA);
					}
					global::System.GC.KeepAlive (ATQA);
				}
			}

			static Delegate? cb_cardAWakeUp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetCardAWakeUp_Api_arrayBHandler ()
			{
				if (cb_cardAWakeUp_Api_arrayB == null)
					cb_cardAWakeUp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_CardAWakeUp_Api_arrayB));
				return cb_cardAWakeUp_Api_arrayB;
			}

			static int n_CardAWakeUp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_ATQA)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ATQA = (byte[]?) JNIEnv.GetArray (native_ATQA, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CardAWakeUp_Api (ATQA);
				if (ATQA != null)
					JNIEnv.CopyArray (ATQA, native_ATQA);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='cardAWakeUp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("cardAWakeUp_Api", "([B)I", "GetCardAWakeUp_Api_arrayBHandler")]
			public virtual unsafe int CardAWakeUp_Api (byte[]? ATQA)
			{
				const string __id = "cardAWakeUp_Api.([B)I";
				IntPtr native_ATQA = JNIEnv.NewArray (ATQA);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ATQA);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ATQA != null) {
						JNIEnv.CopyArray (native_ATQA, ATQA);
						JNIEnv.DeleteLocalRef (native_ATQA);
					}
					global::System.GC.KeepAlive (ATQA);
				}
			}

			static Delegate? cb_closeField_Api;
#pragma warning disable 0169
			static Delegate GetCloseField_ApiHandler ()
			{
				if (cb_closeField_Api == null)
					cb_closeField_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseField_Api));
				return cb_closeField_Api;
			}

			static int n_CloseField_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseField_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='closeField_Api' and count(parameter)=0]"
			[Register ("closeField_Api", "()I", "GetCloseField_ApiHandler")]
			public virtual unsafe int CloseField_Api ()
			{
				const string __id = "closeField_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_openField_Api;
#pragma warning disable 0169
			static Delegate GetOpenField_ApiHandler ()
			{
				if (cb_openField_Api == null)
					cb_openField_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenField_Api));
				return cb_openField_Api;
			}

			static int n_OpenField_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.OpenField_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='openField_Api' and count(parameter)=0]"
			[Register ("openField_Api", "()I", "GetOpenField_ApiHandler")]
			public virtual unsafe int OpenField_Api ()
			{
				const string __id = "openField_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_readSecurityMem_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetReadSecurityMem_Api_IarrayBIHandler ()
			{
				if (cb_readSecurityMem_Api_IarrayBI == null)
					cb_readSecurityMem_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_ReadSecurityMem_Api_IarrayBI));
				return cb_readSecurityMem_Api_IarrayBI;
			}

			static int n_ReadSecurityMem_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int offset, IntPtr native_dataOut, int dataLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var dataOut = (byte[]?) JNIEnv.GetArray (native_dataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadSecurityMem_Api (offset, dataOut, dataLen);
				if (dataOut != null)
					JNIEnv.CopyArray (dataOut, native_dataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='readSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("readSecurityMem_Api", "(I[BI)I", "GetReadSecurityMem_Api_IarrayBIHandler")]
			public virtual unsafe int ReadSecurityMem_Api (int offset, byte[]? dataOut, int dataLen)
			{
				const string __id = "readSecurityMem_Api.(I[BI)I";
				IntPtr native_dataOut = JNIEnv.NewArray (dataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (native_dataOut);
					__args [2] = new JniArgumentValue (dataLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (dataOut != null) {
						JNIEnv.CopyArray (native_dataOut, dataOut);
						JNIEnv.DeleteLocalRef (native_dataOut);
					}
					global::System.GC.KeepAlive (dataOut);
				}
			}

			static Delegate? cb_writeSecurityMem_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetWriteSecurityMem_Api_IarrayBIHandler ()
			{
				if (cb_writeSecurityMem_Api_IarrayBI == null)
					cb_writeSecurityMem_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_WriteSecurityMem_Api_IarrayBI));
				return cb_writeSecurityMem_Api_IarrayBI;
			}

			static int n_WriteSecurityMem_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int offset, IntPtr native_data, int dataLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteSecurityMem_Api (offset, data, dataLen);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Default']/method[@name='writeSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("writeSecurityMem_Api", "(I[BI)I", "GetWriteSecurityMem_Api_IarrayBIHandler")]
			public virtual unsafe int WriteSecurityMem_Api (int offset, byte[]? data, int dataLen)
			{
				const string __id = "writeSecurityMem_Api.(I[BI)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (dataLen);
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ContactlessHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ContactlessHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Stub']/constructor[@name='ContactlessHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/ContactlessHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/ContactlessHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/ContactlessHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='ContactlessHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.ContactlessHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/ContactlessHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/ContactlessHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_M1Decrement_Api_II;
#pragma warning disable 0169
			static Delegate GetM1Decrement_Api_IIHandler ()
			{
				if (cb_M1Decrement_Api_II == null)
					cb_M1Decrement_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_M1Decrement_Api_II));
				return cb_M1Decrement_Api_II;
			}

			static int n_M1Decrement_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Decrement_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Decrement_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("M1Decrement_Api", "(II)I", "GetM1Decrement_Api_IIHandler")]
			public abstract int M1Decrement_Api (int p0, int p1);

			static Delegate? cb_M1Increment_Api_II;
#pragma warning disable 0169
			static Delegate GetM1Increment_Api_IIHandler ()
			{
				if (cb_M1Increment_Api_II == null)
					cb_M1Increment_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_M1Increment_Api_II));
				return cb_M1Increment_Api_II;
			}

			static int n_M1Increment_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Increment_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Increment_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("M1Increment_Api", "(II)I", "GetM1Increment_Api_IIHandler")]
			public abstract int M1Increment_Api (int p0, int p1);

			static Delegate? cb_M1Restore_Api_I;
#pragma warning disable 0169
			static Delegate GetM1Restore_Api_IHandler ()
			{
				if (cb_M1Restore_Api_I == null)
					cb_M1Restore_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_M1Restore_Api_I));
				return cb_M1Restore_Api_I;
			}

			static int n_M1Restore_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Restore_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Restore_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("M1Restore_Api", "(I)I", "GetM1Restore_Api_IHandler")]
			public abstract int M1Restore_Api (int p0);

			static Delegate? cb_M1Transfer_Api_I;
#pragma warning disable 0169
			static Delegate GetM1Transfer_Api_IHandler ()
			{
				if (cb_M1Transfer_Api_I == null)
					cb_M1Transfer_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_M1Transfer_Api_I));
				return cb_M1Transfer_Api_I;
			}

			static int n_M1Transfer_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.M1Transfer_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Transfer_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("M1Transfer_Api", "(I)I", "GetM1Transfer_Api_IHandler")]
			public abstract int M1Transfer_Api (int p0);

			static Delegate? cb_cardAAnticollision_Api_arrayBarrayI;
#pragma warning disable 0169
			static Delegate GetCardAAnticollision_Api_arrayBarrayIHandler ()
			{
				if (cb_cardAAnticollision_Api_arrayBarrayI == null)
					cb_cardAAnticollision_Api_arrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_CardAAnticollision_Api_arrayBarrayI));
				return cb_cardAAnticollision_Api_arrayBarrayI;
			}

			static int n_CardAAnticollision_Api_arrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (int[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.CardAAnticollision_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAAnticollision_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
			[Register ("cardAAnticollision_Api", "([B[I)I", "GetCardAAnticollision_Api_arrayBarrayIHandler")]
			public abstract int CardAAnticollision_Api (byte[]? p0, int[]? p1);

			static Delegate? cb_cardADeselect_Api;
#pragma warning disable 0169
			static Delegate GetCardADeselect_ApiHandler ()
			{
				if (cb_cardADeselect_Api == null)
					cb_cardADeselect_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CardADeselect_Api));
				return cb_cardADeselect_Api;
			}

			static int n_CardADeselect_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CardADeselect_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardADeselect_Api' and count(parameter)=0]"
			[Register ("cardADeselect_Api", "()I", "GetCardADeselect_ApiHandler")]
			public abstract int CardADeselect_Api ();

			static Delegate? cb_cardAPause_Api;
#pragma warning disable 0169
			static Delegate GetCardAPause_ApiHandler ()
			{
				if (cb_cardAPause_Api == null)
					cb_cardAPause_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CardAPause_Api));
				return cb_cardAPause_Api;
			}

			static int n_CardAPause_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CardAPause_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAPause_Api' and count(parameter)=0]"
			[Register ("cardAPause_Api", "()I", "GetCardAPause_ApiHandler")]
			public abstract int CardAPause_Api ();

			static Delegate? cb_cardARats_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetCardARats_Api_IarrayBHandler ()
			{
				if (cb_cardARats_Api_IarrayB == null)
					cb_cardARats_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_CardARats_Api_IarrayB));
				return cb_cardARats_Api_IarrayB;
			}

			static int n_CardARats_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CardARats_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardARats_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("cardARats_Api", "(I[B)I", "GetCardARats_Api_IarrayBHandler")]
			public abstract int CardARats_Api (int p0, byte[]? p1);

			static Delegate? cb_cardAReq_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetCardAReq_Api_arrayBHandler ()
			{
				if (cb_cardAReq_Api_arrayB == null)
					cb_cardAReq_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_CardAReq_Api_arrayB));
				return cb_cardAReq_Api_arrayB;
			}

			static int n_CardAReq_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CardAReq_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAReq_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("cardAReq_Api", "([B)I", "GetCardAReq_Api_arrayBHandler")]
			public abstract int CardAReq_Api (byte[]? p0);

			static Delegate? cb_cardAWakeUp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetCardAWakeUp_Api_arrayBHandler ()
			{
				if (cb_cardAWakeUp_Api_arrayB == null)
					cb_cardAWakeUp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_CardAWakeUp_Api_arrayB));
				return cb_cardAWakeUp_Api_arrayB;
			}

			static int n_CardAWakeUp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CardAWakeUp_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAWakeUp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("cardAWakeUp_Api", "([B)I", "GetCardAWakeUp_Api_arrayBHandler")]
			public abstract int CardAWakeUp_Api (byte[]? p0);

			static Delegate? cb_closeField_Api;
#pragma warning disable 0169
			static Delegate GetCloseField_ApiHandler ()
			{
				if (cb_closeField_Api == null)
					cb_closeField_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseField_Api));
				return cb_closeField_Api;
			}

			static int n_CloseField_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseField_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='closeField_Api' and count(parameter)=0]"
			[Register ("closeField_Api", "()I", "GetCloseField_ApiHandler")]
			public abstract int CloseField_Api ();

			static Delegate? cb_openField_Api;
#pragma warning disable 0169
			static Delegate GetOpenField_ApiHandler ()
			{
				if (cb_openField_Api == null)
					cb_openField_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenField_Api));
				return cb_openField_Api;
			}

			static int n_OpenField_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.OpenField_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='openField_Api' and count(parameter)=0]"
			[Register ("openField_Api", "()I", "GetOpenField_ApiHandler")]
			public abstract int OpenField_Api ();

			static Delegate? cb_readSecurityMem_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetReadSecurityMem_Api_IarrayBIHandler ()
			{
				if (cb_readSecurityMem_Api_IarrayBI == null)
					cb_readSecurityMem_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_ReadSecurityMem_Api_IarrayBI));
				return cb_readSecurityMem_Api_IarrayBI;
			}

			static int n_ReadSecurityMem_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadSecurityMem_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='readSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("readSecurityMem_Api", "(I[BI)I", "GetReadSecurityMem_Api_IarrayBIHandler")]
			public abstract int ReadSecurityMem_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_writeSecurityMem_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetWriteSecurityMem_Api_IarrayBIHandler ()
			{
				if (cb_writeSecurityMem_Api_IarrayBI == null)
					cb_writeSecurityMem_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_WriteSecurityMem_Api_IarrayBI));
				return cb_writeSecurityMem_Api_IarrayBI;
			}

			static int n_WriteSecurityMem_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteSecurityMem_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='writeSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("writeSecurityMem_Api", "(I[BI)I", "GetWriteSecurityMem_Api_IarrayBIHandler")]
			public abstract int WriteSecurityMem_Api (int p0, byte[]? p1, int p2);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ContactlessHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ContactlessHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Decrement_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("M1Decrement_Api", "(II)I", "GetM1Decrement_Api_IIHandler")]
			public override unsafe int M1Decrement_Api (int p0, int p1)
			{
				const string __id = "M1Decrement_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Increment_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("M1Increment_Api", "(II)I", "GetM1Increment_Api_IIHandler")]
			public override unsafe int M1Increment_Api (int p0, int p1)
			{
				const string __id = "M1Increment_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Restore_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("M1Restore_Api", "(I)I", "GetM1Restore_Api_IHandler")]
			public override unsafe int M1Restore_Api (int p0)
			{
				const string __id = "M1Restore_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='M1Transfer_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("M1Transfer_Api", "(I)I", "GetM1Transfer_Api_IHandler")]
			public override unsafe int M1Transfer_Api (int p0)
			{
				const string __id = "M1Transfer_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAAnticollision_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
			[Register ("cardAAnticollision_Api", "([B[I)I", "GetCardAAnticollision_Api_arrayBarrayIHandler")]
			public override unsafe int CardAAnticollision_Api (byte[]? p0, int[]? p1)
			{
				const string __id = "cardAAnticollision_Api.([B[I)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardADeselect_Api' and count(parameter)=0]"
			[Register ("cardADeselect_Api", "()I", "GetCardADeselect_ApiHandler")]
			public override unsafe int CardADeselect_Api ()
			{
				const string __id = "cardADeselect_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAPause_Api' and count(parameter)=0]"
			[Register ("cardAPause_Api", "()I", "GetCardAPause_ApiHandler")]
			public override unsafe int CardAPause_Api ()
			{
				const string __id = "cardAPause_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardARats_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("cardARats_Api", "(I[B)I", "GetCardARats_Api_IarrayBHandler")]
			public override unsafe int CardARats_Api (int p0, byte[]? p1)
			{
				const string __id = "cardARats_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAReq_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("cardAReq_Api", "([B)I", "GetCardAReq_Api_arrayBHandler")]
			public override unsafe int CardAReq_Api (byte[]? p0)
			{
				const string __id = "cardAReq_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='cardAWakeUp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("cardAWakeUp_Api", "([B)I", "GetCardAWakeUp_Api_arrayBHandler")]
			public override unsafe int CardAWakeUp_Api (byte[]? p0)
			{
				const string __id = "cardAWakeUp_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='closeField_Api' and count(parameter)=0]"
			[Register ("closeField_Api", "()I", "GetCloseField_ApiHandler")]
			public override unsafe int CloseField_Api ()
			{
				const string __id = "closeField_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='openField_Api' and count(parameter)=0]"
			[Register ("openField_Api", "()I", "GetOpenField_ApiHandler")]
			public override unsafe int OpenField_Api ()
			{
				const string __id = "openField_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='readSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("readSecurityMem_Api", "(I[BI)I", "GetReadSecurityMem_Api_IarrayBIHandler")]
			public override unsafe int ReadSecurityMem_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "readSecurityMem_Api.(I[BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='ContactlessHandler']/method[@name='writeSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("writeSecurityMem_Api", "(I[BI)I", "GetWriteSecurityMem_Api_IarrayBIHandler")]
			public override unsafe int WriteSecurityMem_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "writeSecurityMem_Api.(I[BI)I";
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

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/ContactlessHandler", DoNotGenerateAcw=true)]
	internal partial class IContactlessHandlerInvoker : global::Java.Lang.Object, IContactlessHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/ContactlessHandler", typeof (IContactlessHandlerInvoker));

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

		public static IContactlessHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContactlessHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.ContactlessHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContactlessHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_M1Decrement_Api_II;
#pragma warning disable 0169
		static Delegate GetM1Decrement_Api_IIHandler ()
		{
			if (cb_M1Decrement_Api_II == null)
				cb_M1Decrement_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_M1Decrement_Api_II));
			return cb_M1Decrement_Api_II;
		}

		static int n_M1Decrement_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.M1Decrement_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_M1Decrement_Api_II;
		public unsafe int M1Decrement_Api (int p0, int p1)
		{
			if (id_M1Decrement_Api_II == IntPtr.Zero)
				id_M1Decrement_Api_II = JNIEnv.GetMethodID (class_ref, "M1Decrement_Api", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1Decrement_Api_II, __args);
		}

		static Delegate? cb_M1Increment_Api_II;
#pragma warning disable 0169
		static Delegate GetM1Increment_Api_IIHandler ()
		{
			if (cb_M1Increment_Api_II == null)
				cb_M1Increment_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_M1Increment_Api_II));
			return cb_M1Increment_Api_II;
		}

		static int n_M1Increment_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.M1Increment_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_M1Increment_Api_II;
		public unsafe int M1Increment_Api (int p0, int p1)
		{
			if (id_M1Increment_Api_II == IntPtr.Zero)
				id_M1Increment_Api_II = JNIEnv.GetMethodID (class_ref, "M1Increment_Api", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1Increment_Api_II, __args);
		}

		static Delegate? cb_M1Restore_Api_I;
#pragma warning disable 0169
		static Delegate GetM1Restore_Api_IHandler ()
		{
			if (cb_M1Restore_Api_I == null)
				cb_M1Restore_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_M1Restore_Api_I));
			return cb_M1Restore_Api_I;
		}

		static int n_M1Restore_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.M1Restore_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_M1Restore_Api_I;
		public unsafe int M1Restore_Api (int p0)
		{
			if (id_M1Restore_Api_I == IntPtr.Zero)
				id_M1Restore_Api_I = JNIEnv.GetMethodID (class_ref, "M1Restore_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1Restore_Api_I, __args);
		}

		static Delegate? cb_M1Transfer_Api_I;
#pragma warning disable 0169
		static Delegate GetM1Transfer_Api_IHandler ()
		{
			if (cb_M1Transfer_Api_I == null)
				cb_M1Transfer_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_M1Transfer_Api_I));
			return cb_M1Transfer_Api_I;
		}

		static int n_M1Transfer_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.M1Transfer_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_M1Transfer_Api_I;
		public unsafe int M1Transfer_Api (int p0)
		{
			if (id_M1Transfer_Api_I == IntPtr.Zero)
				id_M1Transfer_Api_I = JNIEnv.GetMethodID (class_ref, "M1Transfer_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_M1Transfer_Api_I, __args);
		}

		static Delegate? cb_cardAAnticollision_Api_arrayBarrayI;
#pragma warning disable 0169
		static Delegate GetCardAAnticollision_Api_arrayBarrayIHandler ()
		{
			if (cb_cardAAnticollision_Api_arrayBarrayI == null)
				cb_cardAAnticollision_Api_arrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_CardAAnticollision_Api_arrayBarrayI));
			return cb_cardAAnticollision_Api_arrayBarrayI;
		}

		static int n_CardAAnticollision_Api_arrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (int[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.CardAAnticollision_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cardAAnticollision_Api_arrayBarrayI;
		public unsafe int CardAAnticollision_Api (byte[]? p0, int[]? p1)
		{
			if (id_cardAAnticollision_Api_arrayBarrayI == IntPtr.Zero)
				id_cardAAnticollision_Api_arrayBarrayI = JNIEnv.GetMethodID (class_ref, "cardAAnticollision_Api", "([B[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cardAAnticollision_Api_arrayBarrayI, __args);
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

		static Delegate? cb_cardADeselect_Api;
#pragma warning disable 0169
		static Delegate GetCardADeselect_ApiHandler ()
		{
			if (cb_cardADeselect_Api == null)
				cb_cardADeselect_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CardADeselect_Api));
			return cb_cardADeselect_Api;
		}

		static int n_CardADeselect_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CardADeselect_Api ();
		}
#pragma warning restore 0169

		IntPtr id_cardADeselect_Api;
		public unsafe int CardADeselect_Api ()
		{
			if (id_cardADeselect_Api == IntPtr.Zero)
				id_cardADeselect_Api = JNIEnv.GetMethodID (class_ref, "cardADeselect_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cardADeselect_Api);
		}

		static Delegate? cb_cardAPause_Api;
#pragma warning disable 0169
		static Delegate GetCardAPause_ApiHandler ()
		{
			if (cb_cardAPause_Api == null)
				cb_cardAPause_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CardAPause_Api));
			return cb_cardAPause_Api;
		}

		static int n_CardAPause_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CardAPause_Api ();
		}
#pragma warning restore 0169

		IntPtr id_cardAPause_Api;
		public unsafe int CardAPause_Api ()
		{
			if (id_cardAPause_Api == IntPtr.Zero)
				id_cardAPause_Api = JNIEnv.GetMethodID (class_ref, "cardAPause_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cardAPause_Api);
		}

		static Delegate? cb_cardARats_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetCardARats_Api_IarrayBHandler ()
		{
			if (cb_cardARats_Api_IarrayB == null)
				cb_cardARats_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_CardARats_Api_IarrayB));
			return cb_cardARats_Api_IarrayB;
		}

		static int n_CardARats_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CardARats_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cardARats_Api_IarrayB;
		public unsafe int CardARats_Api (int p0, byte[]? p1)
		{
			if (id_cardARats_Api_IarrayB == IntPtr.Zero)
				id_cardARats_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "cardARats_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cardARats_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_cardAReq_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetCardAReq_Api_arrayBHandler ()
		{
			if (cb_cardAReq_Api_arrayB == null)
				cb_cardAReq_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_CardAReq_Api_arrayB));
			return cb_cardAReq_Api_arrayB;
		}

		static int n_CardAReq_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CardAReq_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cardAReq_Api_arrayB;
		public unsafe int CardAReq_Api (byte[]? p0)
		{
			if (id_cardAReq_Api_arrayB == IntPtr.Zero)
				id_cardAReq_Api_arrayB = JNIEnv.GetMethodID (class_ref, "cardAReq_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cardAReq_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_cardAWakeUp_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetCardAWakeUp_Api_arrayBHandler ()
		{
			if (cb_cardAWakeUp_Api_arrayB == null)
				cb_cardAWakeUp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_CardAWakeUp_Api_arrayB));
			return cb_cardAWakeUp_Api_arrayB;
		}

		static int n_CardAWakeUp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CardAWakeUp_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cardAWakeUp_Api_arrayB;
		public unsafe int CardAWakeUp_Api (byte[]? p0)
		{
			if (id_cardAWakeUp_Api_arrayB == IntPtr.Zero)
				id_cardAWakeUp_Api_arrayB = JNIEnv.GetMethodID (class_ref, "cardAWakeUp_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cardAWakeUp_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_closeField_Api;
#pragma warning disable 0169
		static Delegate GetCloseField_ApiHandler ()
		{
			if (cb_closeField_Api == null)
				cb_closeField_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseField_Api));
			return cb_closeField_Api;
		}

		static int n_CloseField_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CloseField_Api ();
		}
#pragma warning restore 0169

		IntPtr id_closeField_Api;
		public unsafe int CloseField_Api ()
		{
			if (id_closeField_Api == IntPtr.Zero)
				id_closeField_Api = JNIEnv.GetMethodID (class_ref, "closeField_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_closeField_Api);
		}

		static Delegate? cb_openField_Api;
#pragma warning disable 0169
		static Delegate GetOpenField_ApiHandler ()
		{
			if (cb_openField_Api == null)
				cb_openField_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenField_Api));
			return cb_openField_Api;
		}

		static int n_OpenField_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.OpenField_Api ();
		}
#pragma warning restore 0169

		IntPtr id_openField_Api;
		public unsafe int OpenField_Api ()
		{
			if (id_openField_Api == IntPtr.Zero)
				id_openField_Api = JNIEnv.GetMethodID (class_ref, "openField_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_openField_Api);
		}

		static Delegate? cb_readSecurityMem_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetReadSecurityMem_Api_IarrayBIHandler ()
		{
			if (cb_readSecurityMem_Api_IarrayBI == null)
				cb_readSecurityMem_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_ReadSecurityMem_Api_IarrayBI));
			return cb_readSecurityMem_Api_IarrayBI;
		}

		static int n_ReadSecurityMem_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadSecurityMem_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readSecurityMem_Api_IarrayBI;
		public unsafe int ReadSecurityMem_Api (int p0, byte[]? p1, int p2)
		{
			if (id_readSecurityMem_Api_IarrayBI == IntPtr.Zero)
				id_readSecurityMem_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "readSecurityMem_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readSecurityMem_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_writeSecurityMem_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetWriteSecurityMem_Api_IarrayBIHandler ()
		{
			if (cb_writeSecurityMem_Api_IarrayBI == null)
				cb_writeSecurityMem_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_WriteSecurityMem_Api_IarrayBI));
			return cb_writeSecurityMem_Api_IarrayBI;
		}

		static int n_WriteSecurityMem_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteSecurityMem_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeSecurityMem_Api_IarrayBI;
		public unsafe int WriteSecurityMem_Api (int p0, byte[]? p1, int p2)
		{
			if (id_writeSecurityMem_Api_IarrayBI == IntPtr.Zero)
				id_writeSecurityMem_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "writeSecurityMem_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeSecurityMem_Api_IarrayBI, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IContactlessHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
