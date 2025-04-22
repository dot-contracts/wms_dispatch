using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Base.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']"
	[Register ("com/vanstone/base/interfaces/EventCallback", "", "Com.Vanstone.Base.Interfaces.IEventCallbackInvoker")]
	public partial interface IEventCallback : IJavaObject, IJavaPeerable {
		string? FirstTextBoxValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']/method[@name='getFirstTextBoxValue' and count(parameter)=0]"
			[Register ("getFirstTextBoxValue", "()Ljava/lang/String;", "GetGetFirstTextBoxValueHandler:Com.Vanstone.Base.Interfaces.IEventCallbackInvoker, VanstonePosSdk")]
			get; 
		}

		string? LastTextBoxValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']/method[@name='getLastTextBoxValue' and count(parameter)=0]"
			[Register ("getLastTextBoxValue", "()Ljava/lang/String;", "GetGetLastTextBoxValueHandler:Com.Vanstone.Base.Interfaces.IEventCallbackInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']/method[@name='DispTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("DispTitle", "(Ljava/lang/String;)V", "GetDispTitle_Ljava_lang_String_Handler:Com.Vanstone.Base.Interfaces.IEventCallbackInvoker, VanstonePosSdk")]
		void DispTitle (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']/method[@name='getTextBoxValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTextBoxValue", "(I)Ljava/lang/String;", "GetGetTextBoxValue_IHandler:Com.Vanstone.Base.Interfaces.IEventCallbackInvoker, VanstonePosSdk")]
		string? GetTextBoxValue (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']/method[@name='pageRepaint' and count(parameter)=0]"
		[Register ("pageRepaint", "()V", "GetPageRepaintHandler:Com.Vanstone.Base.Interfaces.IEventCallbackInvoker, VanstonePosSdk")]
		void PageRepaint ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']/method[@name='pageRepaint' and count(parameter)=1 and parameter[1][@type='java.util.Vector']]"
		[Register ("pageRepaint", "(Ljava/util/Vector;)V", "GetPageRepaint_Ljava_util_Vector_Handler:Com.Vanstone.Base.Interfaces.IEventCallbackInvoker, VanstonePosSdk")]
		void PageRepaint (global::Java.Util.Vector? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='EventCallback']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Handler:Com.Vanstone.Base.Interfaces.IEventCallbackInvoker, VanstonePosSdk")]
		void SendMessage (string? p0);

	}

	[global::Android.Runtime.Register ("com/vanstone/base/interfaces/EventCallback", DoNotGenerateAcw=true)]
	internal partial class IEventCallbackInvoker : global::Java.Lang.Object, IEventCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/base/interfaces/EventCallback", typeof (IEventCallbackInvoker));

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

		public static IEventCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.base.interfaces.EventCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getFirstTextBoxValue;
#pragma warning disable 0169
		static Delegate GetGetFirstTextBoxValueHandler ()
		{
			if (cb_getFirstTextBoxValue == null)
				cb_getFirstTextBoxValue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFirstTextBoxValue));
			return cb_getFirstTextBoxValue;
		}

		static IntPtr n_GetFirstTextBoxValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.FirstTextBoxValue);
		}
#pragma warning restore 0169

		IntPtr id_getFirstTextBoxValue;
		public unsafe string? FirstTextBoxValue {
			get {
				if (id_getFirstTextBoxValue == IntPtr.Zero)
					id_getFirstTextBoxValue = JNIEnv.GetMethodID (class_ref, "getFirstTextBoxValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstTextBoxValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getLastTextBoxValue;
#pragma warning disable 0169
		static Delegate GetGetLastTextBoxValueHandler ()
		{
			if (cb_getLastTextBoxValue == null)
				cb_getLastTextBoxValue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLastTextBoxValue));
			return cb_getLastTextBoxValue;
		}

		static IntPtr n_GetLastTextBoxValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LastTextBoxValue);
		}
#pragma warning restore 0169

		IntPtr id_getLastTextBoxValue;
		public unsafe string? LastTextBoxValue {
			get {
				if (id_getLastTextBoxValue == IntPtr.Zero)
					id_getLastTextBoxValue = JNIEnv.GetMethodID (class_ref, "getLastTextBoxValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastTextBoxValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_DispTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDispTitle_Ljava_lang_String_Handler ()
		{
			if (cb_DispTitle_Ljava_lang_String_ == null)
				cb_DispTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_DispTitle_Ljava_lang_String_));
			return cb_DispTitle_Ljava_lang_String_;
		}

		static void n_DispTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispTitle (p0);
		}
#pragma warning restore 0169

		IntPtr id_DispTitle_Ljava_lang_String_;
		public unsafe void DispTitle (string? p0)
		{
			if (id_DispTitle_Ljava_lang_String_ == IntPtr.Zero)
				id_DispTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "DispTitle", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_DispTitle_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_getTextBoxValue_I;
#pragma warning disable 0169
		static Delegate GetGetTextBoxValue_IHandler ()
		{
			if (cb_getTextBoxValue_I == null)
				cb_getTextBoxValue_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_GetTextBoxValue_I));
			return cb_getTextBoxValue_I;
		}

		static IntPtr n_GetTextBoxValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GetTextBoxValue (p0));
		}
#pragma warning restore 0169

		IntPtr id_getTextBoxValue_I;
		public unsafe string? GetTextBoxValue (int p0)
		{
			if (id_getTextBoxValue_I == IntPtr.Zero)
				id_getTextBoxValue_I = JNIEnv.GetMethodID (class_ref, "getTextBoxValue", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextBoxValue_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_pageRepaint;
#pragma warning disable 0169
		static Delegate GetPageRepaintHandler ()
		{
			if (cb_pageRepaint == null)
				cb_pageRepaint = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PageRepaint));
			return cb_pageRepaint;
		}

		static void n_PageRepaint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PageRepaint ();
		}
#pragma warning restore 0169

		IntPtr id_pageRepaint;
		public unsafe void PageRepaint ()
		{
			if (id_pageRepaint == IntPtr.Zero)
				id_pageRepaint = JNIEnv.GetMethodID (class_ref, "pageRepaint", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pageRepaint);
		}

		static Delegate? cb_pageRepaint_Ljava_util_Vector_;
#pragma warning disable 0169
		static Delegate GetPageRepaint_Ljava_util_Vector_Handler ()
		{
			if (cb_pageRepaint_Ljava_util_Vector_ == null)
				cb_pageRepaint_Ljava_util_Vector_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PageRepaint_Ljava_util_Vector_));
			return cb_pageRepaint_Ljava_util_Vector_;
		}

		static void n_PageRepaint_Ljava_util_Vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PageRepaint (p0);
		}
#pragma warning restore 0169

		IntPtr id_pageRepaint_Ljava_util_Vector_;
		public unsafe void PageRepaint (global::Java.Util.Vector? p0)
		{
			if (id_pageRepaint_Ljava_util_Vector_ == IntPtr.Zero)
				id_pageRepaint_Ljava_util_Vector_ = JNIEnv.GetMethodID (class_ref, "pageRepaint", "(Ljava/util/Vector;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pageRepaint_Ljava_util_Vector_, __args);
		}

		static Delegate? cb_sendMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_ == null)
				cb_sendMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SendMessage_Ljava_lang_String_));
			return cb_sendMessage_Ljava_lang_String_;
		}

		static void n_SendMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Ljava_lang_String_;
		public unsafe void SendMessage (string? p0)
		{
			if (id_sendMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
