using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Base.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='ISystemOper']"
	[Register ("com/vanstone/base/interfaces/ISystemOper", "", "Com.Vanstone.Base.Interfaces.ISystemOperInvoker")]
	public partial interface ISystemOper : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='ISystemOper']/method[@name='updateAndroidResult' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("updateAndroidResult", "(Ljava/lang/String;I)V", "GetUpdateAndroidResult_Ljava_lang_String_IHandler:Com.Vanstone.Base.Interfaces.ISystemOperInvoker, VanstonePosSdk")]
		void UpdateAndroidResult (string? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/vanstone/base/interfaces/ISystemOper", DoNotGenerateAcw=true)]
	internal partial class ISystemOperInvoker : global::Java.Lang.Object, ISystemOper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/base/interfaces/ISystemOper", typeof (ISystemOperInvoker));

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

		public static ISystemOper? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISystemOper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.base.interfaces.ISystemOper'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISystemOperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_updateAndroidResult_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdateAndroidResult_Ljava_lang_String_IHandler ()
		{
			if (cb_updateAndroidResult_Ljava_lang_String_I == null)
				cb_updateAndroidResult_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_UpdateAndroidResult_Ljava_lang_String_I));
			return cb_updateAndroidResult_Ljava_lang_String_I;
		}

		static void n_UpdateAndroidResult_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.ISystemOper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateAndroidResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_updateAndroidResult_Ljava_lang_String_I;
		public unsafe void UpdateAndroidResult (string? p0, int p1)
		{
			if (id_updateAndroidResult_Ljava_lang_String_I == IntPtr.Zero)
				id_updateAndroidResult_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "updateAndroidResult", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateAndroidResult_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
