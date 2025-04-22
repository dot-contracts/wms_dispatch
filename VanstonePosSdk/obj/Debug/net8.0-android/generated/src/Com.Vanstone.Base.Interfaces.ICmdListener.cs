using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Base.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='CmdListener']"
	[Register ("com/vanstone/base/interfaces/CmdListener", "", "Com.Vanstone.Base.Interfaces.ICmdListenerInvoker")]
	public partial interface ICmdListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='CmdListener']/method[@name='cmdAction' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("cmdAction", "(ILjava/lang/Object;)V", "GetCmdAction_ILjava_lang_Object_Handler:Com.Vanstone.Base.Interfaces.ICmdListenerInvoker, VanstonePosSdk")]
		void CmdAction (int p0, global::Java.Lang.Object? p1);

	}

	[global::Android.Runtime.Register ("com/vanstone/base/interfaces/CmdListener", DoNotGenerateAcw=true)]
	internal partial class ICmdListenerInvoker : global::Java.Lang.Object, ICmdListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/base/interfaces/CmdListener", typeof (ICmdListenerInvoker));

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

		public static ICmdListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICmdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.base.interfaces.CmdListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICmdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_cmdAction_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCmdAction_ILjava_lang_Object_Handler ()
		{
			if (cb_cmdAction_ILjava_lang_Object_ == null)
				cb_cmdAction_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_CmdAction_ILjava_lang_Object_));
			return cb_cmdAction_ILjava_lang_Object_;
		}

		static void n_CmdAction_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.ICmdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CmdAction (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_cmdAction_ILjava_lang_Object_;
		public unsafe void CmdAction (int p0, global::Java.Lang.Object? p1)
		{
			if (id_cmdAction_ILjava_lang_Object_ == IntPtr.Zero)
				id_cmdAction_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "cmdAction", "(ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cmdAction_ILjava_lang_Object_, __args);
		}

	}

	// event args for com.vanstone.base.interfaces.CmdListener.cmdAction
	public partial class CmdEventArgs : global::System.EventArgs {
		public CmdEventArgs (int p0, global::Java.Lang.Object? p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		global::Java.Lang.Object? p1;

		public global::Java.Lang.Object? P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/vanstone/base/interfaces/CmdListenerImplementor")]
	internal sealed partial class ICmdListenerImplementor : global::Java.Lang.Object, ICmdListener {

		object? sender;

		public unsafe ICmdListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<CmdEventArgs>? Handler;
		#pragma warning restore 0649

		public void CmdAction (int p0, global::Java.Lang.Object? p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CmdEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICmdListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
