using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Utils.Object {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.utils.object']/interface[@name='ISaveJSonStr']"
	[Register ("com/vanstone/utils/object/ISaveJSonStr", "", "Com.Vanstone.Utils.Object.ISaveJSonStrInvoker")]
	public partial interface ISaveJSonStr : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.utils.object']/interface[@name='ISaveJSonStr']/method[@name='setJsonStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setJsonStr", "(Ljava/lang/String;)V", "GetSetJsonStr_Ljava_lang_String_Handler:Com.Vanstone.Utils.Object.ISaveJSonStrInvoker, VanstonePosSdk")]
		void SetJsonStr (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.utils.object']/interface[@name='ISaveJSonStr']/method[@name='toJSonStr' and count(parameter)=0]"
		[Register ("toJSonStr", "()Ljava/lang/String;", "GetToJSonStrHandler:Com.Vanstone.Utils.Object.ISaveJSonStrInvoker, VanstonePosSdk")]
		string? ToJSonStr ();

	}

	[global::Android.Runtime.Register ("com/vanstone/utils/object/ISaveJSonStr", DoNotGenerateAcw=true)]
	internal partial class ISaveJSonStrInvoker : global::Java.Lang.Object, ISaveJSonStr {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/utils/object/ISaveJSonStr", typeof (ISaveJSonStrInvoker));

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

		public static ISaveJSonStr? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISaveJSonStr> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.utils.object.ISaveJSonStr'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISaveJSonStrInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_setJsonStr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetJsonStr_Ljava_lang_String_Handler ()
		{
			if (cb_setJsonStr_Ljava_lang_String_ == null)
				cb_setJsonStr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetJsonStr_Ljava_lang_String_));
			return cb_setJsonStr_Ljava_lang_String_;
		}

		static void n_SetJsonStr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Utils.Object.ISaveJSonStr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetJsonStr (p0);
		}
#pragma warning restore 0169

		IntPtr id_setJsonStr_Ljava_lang_String_;
		public unsafe void SetJsonStr (string? p0)
		{
			if (id_setJsonStr_Ljava_lang_String_ == IntPtr.Zero)
				id_setJsonStr_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setJsonStr", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setJsonStr_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_toJSonStr;
#pragma warning disable 0169
		static Delegate GetToJSonStrHandler ()
		{
			if (cb_toJSonStr == null)
				cb_toJSonStr = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ToJSonStr));
			return cb_toJSonStr;
		}

		static IntPtr n_ToJSonStr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Utils.Object.ISaveJSonStr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ToJSonStr ());
		}
#pragma warning restore 0169

		IntPtr id_toJSonStr;
		public unsafe string? ToJSonStr ()
		{
			if (id_toJSonStr == IntPtr.Zero)
				id_toJSonStr = JNIEnv.GetMethodID (class_ref, "toJSonStr", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJSonStr), JniHandleOwnership.TransferLocalRef);
		}

	}
}
