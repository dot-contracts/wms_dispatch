using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.client']/interface[@name='ISdkStatue']"
	[Register ("com/vanstone/appsdk/client/ISdkStatue", "", "Com.Vanstone.Appsdk.Client.ISdkStatueInvoker")]
	public partial interface ISdkStatue : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.client']/interface[@name='ISdkStatue']/method[@name='sdkInitFailed' and count(parameter)=0]"
		[Register ("sdkInitFailed", "()V", "GetSdkInitFailedHandler:Com.Vanstone.Appsdk.Client.ISdkStatueInvoker, VanstonePosSdk")]
		void SdkInitFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.client']/interface[@name='ISdkStatue']/method[@name='sdkInitSuccessed' and count(parameter)=0]"
		[Register ("sdkInitSuccessed", "()V", "GetSdkInitSuccessedHandler:Com.Vanstone.Appsdk.Client.ISdkStatueInvoker, VanstonePosSdk")]
		void SdkInitSuccessed ();

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/client/ISdkStatue", DoNotGenerateAcw=true)]
	internal partial class ISdkStatueInvoker : global::Java.Lang.Object, ISdkStatue {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/client/ISdkStatue", typeof (ISdkStatueInvoker));

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

		public static ISdkStatue? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISdkStatue> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.client.ISdkStatue'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISdkStatueInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_sdkInitFailed;
#pragma warning disable 0169
		static Delegate GetSdkInitFailedHandler ()
		{
			if (cb_sdkInitFailed == null)
				cb_sdkInitFailed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SdkInitFailed));
			return cb_sdkInitFailed;
		}

		static void n_SdkInitFailed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Client.ISdkStatue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SdkInitFailed ();
		}
#pragma warning restore 0169

		IntPtr id_sdkInitFailed;
		public unsafe void SdkInitFailed ()
		{
			if (id_sdkInitFailed == IntPtr.Zero)
				id_sdkInitFailed = JNIEnv.GetMethodID (class_ref, "sdkInitFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sdkInitFailed);
		}

		static Delegate? cb_sdkInitSuccessed;
#pragma warning disable 0169
		static Delegate GetSdkInitSuccessedHandler ()
		{
			if (cb_sdkInitSuccessed == null)
				cb_sdkInitSuccessed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SdkInitSuccessed));
			return cb_sdkInitSuccessed;
		}

		static void n_SdkInitSuccessed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Client.ISdkStatue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SdkInitSuccessed ();
		}
#pragma warning restore 0169

		IntPtr id_sdkInitSuccessed;
		public unsafe void SdkInitSuccessed ()
		{
			if (id_sdkInitSuccessed == IntPtr.Zero)
				id_sdkInitSuccessed = JNIEnv.GetMethodID (class_ref, "sdkInitSuccessed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sdkInitSuccessed);
		}

	}
}
