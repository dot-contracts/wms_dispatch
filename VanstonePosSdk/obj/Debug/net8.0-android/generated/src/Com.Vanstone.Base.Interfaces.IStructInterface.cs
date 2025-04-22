using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Base.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='StructInterface']"
	[Register ("com/vanstone/base/interfaces/StructInterface", "", "Com.Vanstone.Base.Interfaces.IStructInterfaceInvoker")]
	public partial interface IStructInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='StructInterface']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler:Com.Vanstone.Base.Interfaces.IStructInterfaceInvoker, VanstonePosSdk")]
		int Size ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='StructInterface']/method[@name='toBean' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toBean", "([B)V", "GetToBean_arrayBHandler:Com.Vanstone.Base.Interfaces.IStructInterfaceInvoker, VanstonePosSdk")]
		void ToBean (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.base.interfaces']/interface[@name='StructInterface']/method[@name='toBytes' and count(parameter)=0]"
		[Register ("toBytes", "()[B", "GetToBytesHandler:Com.Vanstone.Base.Interfaces.IStructInterfaceInvoker, VanstonePosSdk")]
		byte[]? ToBytes ();

	}

	[global::Android.Runtime.Register ("com/vanstone/base/interfaces/StructInterface", DoNotGenerateAcw=true)]
	internal partial class IStructInterfaceInvoker : global::Java.Lang.Object, IStructInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/base/interfaces/StructInterface", typeof (IStructInterfaceInvoker));

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

		public static IStructInterface? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStructInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.base.interfaces.StructInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStructInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Size));
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IStructInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
		}

		static Delegate? cb_toBean_arrayB;
#pragma warning disable 0169
		static Delegate GetToBean_arrayBHandler ()
		{
			if (cb_toBean_arrayB == null)
				cb_toBean_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_ToBean_arrayB));
			return cb_toBean_arrayB;
		}

		static void n_ToBean_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IStructInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ToBean (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_toBean_arrayB;
		public unsafe void ToBean (byte[]? p0)
		{
			if (id_toBean_arrayB == IntPtr.Zero)
				id_toBean_arrayB = JNIEnv.GetMethodID (class_ref, "toBean", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toBean_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_toBytes;
#pragma warning disable 0169
		static Delegate GetToBytesHandler ()
		{
			if (cb_toBytes == null)
				cb_toBytes = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ToBytes));
			return cb_toBytes;
		}

		static IntPtr n_ToBytes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Base.Interfaces.IStructInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.ToBytes ());
		}
#pragma warning restore 0169

		IntPtr id_toBytes;
		public unsafe byte[]? ToBytes ()
		{
			if (id_toBytes == IntPtr.Zero)
				id_toBytes = JNIEnv.GetMethodID (class_ref, "toBytes", "()[B");
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}
}
