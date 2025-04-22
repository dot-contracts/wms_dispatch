using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Base.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='DataParser']"
	[Register ("com/vanstone/base/interfaces/DataParser", "", "Com.Vanstone.Base.Interfaces.IDataParserInvoker")]
	public partial interface IDataParser : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='DataParser']/method[@name='Bean2Form' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("Bean2Form", "(Ljava/lang/Object;)V", "GetBean2Form_Ljava_lang_Object_Handler:Com.Vanstone.Base.Interfaces.IDataParserInvoker, VanstonePosSdk")]
		void Bean2Form (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='DataParser']/method[@name='Form2Bean' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("Form2Bean", "(Ljava/lang/Object;)V", "GetForm2Bean_Ljava_lang_Object_Handler:Com.Vanstone.Base.Interfaces.IDataParserInvoker, VanstonePosSdk")]
		void Form2Bean (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='DataParser']/method[@name='Verify' and count(parameter)=0]"
		[Register ("Verify", "()I", "GetVerifyHandler:Com.Vanstone.Base.Interfaces.IDataParserInvoker, VanstonePosSdk")]
		int Verify ();

	}

	[global::Android.Runtime.Register ("com/vanstone/base/interfaces/DataParser", DoNotGenerateAcw=true)]
	internal partial class IDataParserInvoker : global::Java.Lang.Object, IDataParser {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/base/interfaces/DataParser", typeof (IDataParserInvoker));

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

		public static IDataParser? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataParser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.base.interfaces.DataParser'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_Bean2Form_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetBean2Form_Ljava_lang_Object_Handler ()
		{
			if (cb_Bean2Form_Ljava_lang_Object_ == null)
				cb_Bean2Form_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Bean2Form_Ljava_lang_Object_));
			return cb_Bean2Form_Ljava_lang_Object_;
		}

		static void n_Bean2Form_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IDataParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Bean2Form (p0);
		}
#pragma warning restore 0169

		IntPtr id_Bean2Form_Ljava_lang_Object_;
		public unsafe void Bean2Form (global::Java.Lang.Object? p0)
		{
			if (id_Bean2Form_Ljava_lang_Object_ == IntPtr.Zero)
				id_Bean2Form_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "Bean2Form", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Bean2Form_Ljava_lang_Object_, __args);
		}

		static Delegate? cb_Form2Bean_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetForm2Bean_Ljava_lang_Object_Handler ()
		{
			if (cb_Form2Bean_Ljava_lang_Object_ == null)
				cb_Form2Bean_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Form2Bean_Ljava_lang_Object_));
			return cb_Form2Bean_Ljava_lang_Object_;
		}

		static void n_Form2Bean_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IDataParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Form2Bean (p0);
		}
#pragma warning restore 0169

		IntPtr id_Form2Bean_Ljava_lang_Object_;
		public unsafe void Form2Bean (global::Java.Lang.Object? p0)
		{
			if (id_Form2Bean_Ljava_lang_Object_ == IntPtr.Zero)
				id_Form2Bean_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "Form2Bean", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Form2Bean_Ljava_lang_Object_, __args);
		}

		static Delegate? cb_Verify;
#pragma warning disable 0169
		static Delegate GetVerifyHandler ()
		{
			if (cb_Verify == null)
				cb_Verify = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Verify));
			return cb_Verify;
		}

		static int n_Verify (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IDataParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Verify ();
		}
#pragma warning restore 0169

		IntPtr id_Verify;
		public unsafe int Verify ()
		{
			if (id_Verify == IntPtr.Zero)
				id_Verify = JNIEnv.GetMethodID (class_ref, "Verify", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Verify);
		}

	}
}
