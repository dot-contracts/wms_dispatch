using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Page.Widget.Body.Custom {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='OnKeyBoardClickListener']"
	[Register ("com/vanstone/page/widget/body/custom/OnKeyBoardClickListener", "", "Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker")]
	public partial interface IOnKeyBoardClickListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='OnKeyBoardClickListener']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='OnKeyBoardClickListener']/method[@name='onEnter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onEnter", "(Ljava/lang/String;)V", "GetOnEnter_Ljava_lang_String_Handler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk")]
		void OnEnter (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='OnKeyBoardClickListener']/method[@name='onKeyBoardClick' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String']]"
		[Register ("onKeyBoardClick", "(Landroid/view/View;Ljava/lang/String;)V", "GetOnKeyBoardClick_Landroid_view_View_Ljava_lang_String_Handler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk")]
		void OnKeyBoardClick (global::Android.Views.View? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.page.widget.body.custom']/interface[@name='OnKeyBoardClickListener']/method[@name='onKeyClick' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onKeyClick", "(I)V", "GetOnKeyClick_IHandler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk")]
		void OnKeyClick (int p0);

	}

	[global::Android.Runtime.Register ("com/vanstone/page/widget/body/custom/OnKeyBoardClickListener", DoNotGenerateAcw=true)]
	internal partial class IOnKeyBoardClickListenerInvoker : global::Java.Lang.Object, IOnKeyBoardClickListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/page/widget/body/custom/OnKeyBoardClickListener", typeof (IOnKeyBoardClickListenerInvoker));

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

		public static IOnKeyBoardClickListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnKeyBoardClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.page.widget.body.custom.OnKeyBoardClickListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnKeyBoardClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnCancel));
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
		}

		static Delegate? cb_onEnter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnEnter_Ljava_lang_String_Handler ()
		{
			if (cb_onEnter_Ljava_lang_String_ == null)
				cb_onEnter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnEnter_Ljava_lang_String_));
			return cb_onEnter_Ljava_lang_String_;
		}

		static void n_OnEnter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEnter (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEnter_Ljava_lang_String_;
		public unsafe void OnEnter (string? p0)
		{
			if (id_onEnter_Ljava_lang_String_ == IntPtr.Zero)
				id_onEnter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onEnter", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEnter_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnKeyBoardClick_Landroid_view_View_Ljava_lang_String_Handler ()
		{
			if (cb_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_ == null)
				cb_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnKeyBoardClick_Landroid_view_View_Ljava_lang_String_));
			return cb_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_;
		}

		static void n_OnKeyBoardClick_Landroid_view_View_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyBoardClick (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_;
		public unsafe void OnKeyBoardClick (global::Android.Views.View? p0, string? p1)
		{
			if (id_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_ == IntPtr.Zero)
				id_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onKeyBoardClick", "(Landroid/view/View;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKeyBoardClick_Landroid_view_View_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_onKeyClick_I;
#pragma warning disable 0169
		static Delegate GetOnKeyClick_IHandler ()
		{
			if (cb_onKeyClick_I == null)
				cb_onKeyClick_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnKeyClick_I));
			return cb_onKeyClick_I;
		}

		static void n_OnKeyClick_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnKeyClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onKeyClick_I;
		public unsafe void OnKeyClick (int p0)
		{
			if (id_onKeyClick_I == IntPtr.Zero)
				id_onKeyClick_I = JNIEnv.GetMethodID (class_ref, "onKeyClick", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKeyClick_I, __args);
		}

	}

	// event args for com.vanstone.page.widget.body.custom.OnKeyBoardClickListener.onEnter
	public partial class EnterEventArgs : global::System.EventArgs {
		public EnterEventArgs (string? p0)
		{
			this.p0 = p0;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

	}

	// event args for com.vanstone.page.widget.body.custom.OnKeyBoardClickListener.onKeyBoardClick
	public partial class KeyBoardClickEventArgs : global::System.EventArgs {
		public KeyBoardClickEventArgs (global::Android.Views.View? p0, string? p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Views.View? p0;

		public global::Android.Views.View? P0 {
			get { return p0; }
		}

		string? p1;

		public string? P1 {
			get { return p1; }
		}

	}

	// event args for com.vanstone.page.widget.body.custom.OnKeyBoardClickListener.onKeyClick
	public partial class KeyClickEventArgs : global::System.EventArgs {
		public KeyClickEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/vanstone/page/widget/body/custom/OnKeyBoardClickListenerImplementor")]
	internal sealed partial class IOnKeyBoardClickListenerImplementor : global::Java.Lang.Object, IOnKeyBoardClickListener {

		object? sender;

		public unsafe IOnKeyBoardClickListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler? OnCancelHandler;
		#pragma warning restore 0649

		public void OnCancel ()
		{
			var __h = OnCancelHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<EnterEventArgs>? OnEnterHandler;
		#pragma warning restore 0649

		public void OnEnter (string? p0)
		{
			var __h = OnEnterHandler;
			if (__h != null)
				__h (sender, new EnterEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<KeyBoardClickEventArgs>? OnKeyBoardClickHandler;
		#pragma warning restore 0649

		public void OnKeyBoardClick (global::Android.Views.View? p0, string? p1)
		{
			var __h = OnKeyBoardClickHandler;
			if (__h != null)
				__h (sender, new KeyBoardClickEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<KeyClickEventArgs>? OnKeyClickHandler;
		#pragma warning restore 0649

		public void OnKeyClick (int p0)
		{
			var __h = OnKeyClickHandler;
			if (__h != null)
				__h (sender, new KeyClickEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnKeyBoardClickListenerImplementor value)
		{
			return value.OnCancelHandler == null && value.OnEnterHandler == null && value.OnKeyBoardClickHandler == null && value.OnKeyClickHandler == null;
		}

	}
}
