using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Base.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='PedListener']"
	[Register ("com/vanstone/base/interfaces/PedListener", "", "Com.Vanstone.Base.Interfaces.IPedListenerInvoker")]
	public partial interface IPedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='PedListener']/method[@name='processCallback' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("processCallback", "([B)V", "GetProcessCallback_arrayBHandler:Com.Vanstone.Base.Interfaces.IPedListenerInvoker, VanstonePosSdk")]
		void ProcessCallback (byte[]? p0);

	}

	[global::Android.Runtime.Register ("com/vanstone/base/interfaces/PedListener", DoNotGenerateAcw=true)]
	internal partial class IPedListenerInvoker : global::Java.Lang.Object, IPedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/base/interfaces/PedListener", typeof (IPedListenerInvoker));

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

		public static IPedListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.base.interfaces.PedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_processCallback_arrayB;
#pragma warning disable 0169
		static Delegate GetProcessCallback_arrayBHandler ()
		{
			if (cb_processCallback_arrayB == null)
				cb_processCallback_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_ProcessCallback_arrayB));
			return cb_processCallback_arrayB;
		}

		static void n_ProcessCallback_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IPedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ProcessCallback (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_processCallback_arrayB;
		public unsafe void ProcessCallback (byte[]? p0)
		{
			if (id_processCallback_arrayB == IntPtr.Zero)
				id_processCallback_arrayB = JNIEnv.GetMethodID (class_ref, "processCallback", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processCallback_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	// event args for com.vanstone.base.interfaces.PedListener.processCallback
	public partial class PedEventArgs : global::System.EventArgs {
		public PedEventArgs (byte[]? p0)
		{
			this.p0 = p0;
		}

		byte[]? p0;

		public byte[]? P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/vanstone/base/interfaces/PedListenerImplementor")]
	internal sealed partial class IPedListenerImplementor : global::Java.Lang.Object, IPedListener {

		object? sender;

		public unsafe IPedListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<PedEventArgs>? Handler;
		#pragma warning restore 0649

		public void ProcessCallback (byte[]? p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PedEventArgs (p0));
		}

		internal static bool __IsEmpty (IPedListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
