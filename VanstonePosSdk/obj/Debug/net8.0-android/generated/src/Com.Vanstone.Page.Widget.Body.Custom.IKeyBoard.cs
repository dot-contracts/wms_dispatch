using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Page.Widget.Body.Custom {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']"
	[Register ("com/vanstone/page/widget/body/custom/IKeyBoard", "", "Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker")]
	public partial interface IKeyBoard : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']/method[@name='enter' and count(parameter)=0]"
		[Register ("enter", "()V", "GetEnterHandler:Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker, VanstonePosSdk")]
		void Enter ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAmount", "(Ljava/lang/String;)V", "GetSetAmount_Ljava_lang_String_Handler:Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker, VanstonePosSdk")]
		void SetAmount (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']/method[@name='setDispAmount' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDispAmount", "(Z)V", "GetSetDispAmount_ZHandler:Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker, VanstonePosSdk")]
		void SetDispAmount (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']/method[@name='setDispMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDispMsg", "(Ljava/lang/String;)V", "GetSetDispMsg_Ljava_lang_String_Handler:Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker, VanstonePosSdk")]
		void SetDispMsg (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']/method[@name='setDispPwdBox' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDispPwdBox", "(Z)V", "GetSetDispPwdBox_ZHandler:Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker, VanstonePosSdk")]
		void SetDispPwdBox (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']/method[@name='setKeyLen' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setKeyLen", "(I)V", "GetSetKeyLen_IHandler:Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker, VanstonePosSdk")]
		void SetKeyLen (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='IKeyBoard']/method[@name='setOnKeyBoardListener' and count(parameter)=1 and parameter[1][@type='com.vanstone.page.widget.body.custom.OnKeyBoardClickListener']]"
		[Register ("setOnKeyBoardListener", "(Lcom/vanstone/page/widget/body/custom/OnKeyBoardClickListener;)V", "GetSetOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_Handler:Com.Vanstone.Page.Widget.Body.Custom.IKeyBoardInvoker, VanstonePosSdk")]
		void SetOnKeyBoardListener (global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener? p0);

	}

	[global::Android.Runtime.Register ("com/vanstone/page/widget/body/custom/IKeyBoard", DoNotGenerateAcw=true)]
	internal partial class IKeyBoardInvoker : global::Java.Lang.Object, IKeyBoard {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/page/widget/body/custom/IKeyBoard", typeof (IKeyBoardInvoker));

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

		public static IKeyBoard? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyBoard> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.page.widget.body.custom.IKeyBoard'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyBoardInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_enter;
#pragma warning disable 0169
		static Delegate GetEnterHandler ()
		{
			if (cb_enter == null)
				cb_enter = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Enter));
			return cb_enter;
		}

		static void n_Enter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IKeyBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Enter ();
		}
#pragma warning restore 0169

		IntPtr id_enter;
		public unsafe void Enter ()
		{
			if (id_enter == IntPtr.Zero)
				id_enter = JNIEnv.GetMethodID (class_ref, "enter", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enter);
		}

		static Delegate? cb_setAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setAmount_Ljava_lang_String_ == null)
				cb_setAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAmount_Ljava_lang_String_));
			return cb_setAmount_Ljava_lang_String_;
		}

		static void n_SetAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IKeyBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAmount (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAmount_Ljava_lang_String_;
		public unsafe void SetAmount (string? p0)
		{
			if (id_setAmount_Ljava_lang_String_ == IntPtr.Zero)
				id_setAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAmount", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAmount_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setDispAmount_Z;
#pragma warning disable 0169
		static Delegate GetSetDispAmount_ZHandler ()
		{
			if (cb_setDispAmount_Z == null)
				cb_setDispAmount_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetDispAmount_Z));
			return cb_setDispAmount_Z;
		}

		static void n_SetDispAmount_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IKeyBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetDispAmount (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDispAmount_Z;
		public unsafe void SetDispAmount (bool p0)
		{
			if (id_setDispAmount_Z == IntPtr.Zero)
				id_setDispAmount_Z = JNIEnv.GetMethodID (class_ref, "setDispAmount", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDispAmount_Z, __args);
		}

		static Delegate? cb_setDispMsg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDispMsg_Ljava_lang_String_Handler ()
		{
			if (cb_setDispMsg_Ljava_lang_String_ == null)
				cb_setDispMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetDispMsg_Ljava_lang_String_));
			return cb_setDispMsg_Ljava_lang_String_;
		}

		static void n_SetDispMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IKeyBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDispMsg (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDispMsg_Ljava_lang_String_;
		public unsafe void SetDispMsg (string? p0)
		{
			if (id_setDispMsg_Ljava_lang_String_ == IntPtr.Zero)
				id_setDispMsg_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDispMsg", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDispMsg_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setDispPwdBox_Z;
#pragma warning disable 0169
		static Delegate GetSetDispPwdBox_ZHandler ()
		{
			if (cb_setDispPwdBox_Z == null)
				cb_setDispPwdBox_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetDispPwdBox_Z));
			return cb_setDispPwdBox_Z;
		}

		static void n_SetDispPwdBox_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IKeyBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetDispPwdBox (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDispPwdBox_Z;
		public unsafe void SetDispPwdBox (bool p0)
		{
			if (id_setDispPwdBox_Z == IntPtr.Zero)
				id_setDispPwdBox_Z = JNIEnv.GetMethodID (class_ref, "setDispPwdBox", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDispPwdBox_Z, __args);
		}

		static Delegate? cb_setKeyLen_I;
#pragma warning disable 0169
		static Delegate GetSetKeyLen_IHandler ()
		{
			if (cb_setKeyLen_I == null)
				cb_setKeyLen_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetKeyLen_I));
			return cb_setKeyLen_I;
		}

		static void n_SetKeyLen_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IKeyBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetKeyLen (p0);
		}
#pragma warning restore 0169

		IntPtr id_setKeyLen_I;
		public unsafe void SetKeyLen (int p0)
		{
			if (id_setKeyLen_I == IntPtr.Zero)
				id_setKeyLen_I = JNIEnv.GetMethodID (class_ref, "setKeyLen", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeyLen_I, __args);
		}

		static Delegate? cb_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_Handler ()
		{
			if (cb_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_ == null)
				cb_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_));
			return cb_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_;
		}

		static void n_SetOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IKeyBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnKeyBoardListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_;
		public unsafe void SetOnKeyBoardListener (global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener? p0)
		{
			if (id_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_ == IntPtr.Zero)
				id_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnKeyBoardListener", "(Lcom/vanstone/page/widget/body/custom/OnKeyBoardClickListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnKeyBoardListener_Lcom_vanstone_page_widget_body_custom_OnKeyBoardClickListener_, __args);
		}

	}
}
