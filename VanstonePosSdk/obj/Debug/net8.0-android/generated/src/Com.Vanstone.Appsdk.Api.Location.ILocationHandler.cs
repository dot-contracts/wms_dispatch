using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']"
	[Register ("com/vanstone/appsdk/api/location/LocationHandler", "", "Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker")]
	public partial interface ILocationHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationCalDistance_Api' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("LocationCalDistance_Api", "(DDDD)D", "GetLocationCalDistance_Api_DDDDHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		double LocationCalDistance_Api (double p0, double p1, double p2, double p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationClrBuff_Api' and count(parameter)=0]"
		[Register ("LocationClrBuff_Api", "()V", "GetLocationClrBuff_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		void LocationClrBuff_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetAddress_Api' and count(parameter)=0]"
		[Register ("LocationGetAddress_Api", "()Ljava/lang/String;", "GetLocationGetAddress_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		string? LocationGetAddress_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetCity_Api' and count(parameter)=0]"
		[Register ("LocationGetCity_Api", "()Ljava/lang/String;", "GetLocationGetCity_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		string? LocationGetCity_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetCoorType_Api' and count(parameter)=0]"
		[Register ("LocationGetCoorType_Api", "()Ljava/lang/String;", "GetLocationGetCoorType_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		string? LocationGetCoorType_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetDistrict_Api' and count(parameter)=0]"
		[Register ("LocationGetDistrict_Api", "()Ljava/lang/String;", "GetLocationGetDistrict_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		string? LocationGetDistrict_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetErrInfo_Api' and count(parameter)=0]"
		[Register ("LocationGetErrInfo_Api", "()Ljava/lang/String;", "GetLocationGetErrInfo_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		string? LocationGetErrInfo_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLat_Api' and count(parameter)=0]"
		[Register ("LocationGetLat_Api", "()D", "GetLocationGetLat_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		double LocationGetLat_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLng_Api' and count(parameter)=0]"
		[Register ("LocationGetLng_Api", "()D", "GetLocationGetLng_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		double LocationGetLng_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLocInfo_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("LocationGetLocInfo_Api", "(Landroid/os/Bundle;)V", "GetLocationGetLocInfo_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		void LocationGetLocInfo_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetProvince_Api' and count(parameter)=0]"
		[Register ("LocationGetProvince_Api", "()Ljava/lang/String;", "GetLocationGetProvince_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		string? LocationGetProvince_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationLoc_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("LocationLoc_Api", "(I)Z", "GetLocationLoc_Api_IHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		bool LocationLoc_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationResult_Api' and count(parameter)=0]"
		[Register ("LocationResult_Api", "()I", "GetLocationResult_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		int LocationResult_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationSetCoorType_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("LocationSetCoorType_Api", "(Ljava/lang/String;)V", "GetLocationSetCoorType_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		void LocationSetCoorType_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationStart_Api' and count(parameter)=0]"
		[Register ("LocationStart_Api", "()I", "GetLocationStart_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		int LocationStart_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationStop_Api' and count(parameter)=0]"
		[Register ("LocationStop_Api", "()V", "GetLocationStop_ApiHandler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		void LocationStop_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='getLocationInfo' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAidlLocationCallbackAIDL']]"
		[Register ("getLocationInfo", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IAidlLocationCallbackAIDL;)V", "GetGetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_Handler:Com.Vanstone.Appsdk.Api.Location.ILocationHandlerInvoker, VanstonePosSdk")]
		void GetLocationInfo (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL? p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/location/LocationHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/location/LocationHandler$Default", typeof (Default));

			internal static IntPtr class_ref {
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
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Default (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/constructor[@name='LocationHandler.Default' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Default () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_LocationCalDistance_Api_DDDD;
#pragma warning disable 0169
			static Delegate GetLocationCalDistance_Api_DDDDHandler ()
			{
				if (cb_LocationCalDistance_Api_DDDD == null)
					cb_LocationCalDistance_Api_DDDD = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPDDDD_D (n_LocationCalDistance_Api_DDDD));
				return cb_LocationCalDistance_Api_DDDD;
			}

			static double n_LocationCalDistance_Api_DDDD (IntPtr jnienv, IntPtr native__this, double startLat, double startLng, double endLat, double endLng)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationCalDistance_Api (startLat, startLng, endLat, endLng);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationCalDistance_Api' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
			[Register ("LocationCalDistance_Api", "(DDDD)D", "GetLocationCalDistance_Api_DDDDHandler")]
			public virtual unsafe double LocationCalDistance_Api (double startLat, double startLng, double endLat, double endLng)
			{
				const string __id = "LocationCalDistance_Api.(DDDD)D";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (startLat);
					__args [1] = new JniArgumentValue (startLng);
					__args [2] = new JniArgumentValue (endLat);
					__args [3] = new JniArgumentValue (endLng);
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LocationClrBuff_Api;
#pragma warning disable 0169
			static Delegate GetLocationClrBuff_ApiHandler ()
			{
				if (cb_LocationClrBuff_Api == null)
					cb_LocationClrBuff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LocationClrBuff_Api));
				return cb_LocationClrBuff_Api;
			}

			static void n_LocationClrBuff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.LocationClrBuff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationClrBuff_Api' and count(parameter)=0]"
			[Register ("LocationClrBuff_Api", "()V", "GetLocationClrBuff_ApiHandler")]
			public virtual unsafe void LocationClrBuff_Api ()
			{
				const string __id = "LocationClrBuff_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_LocationGetAddress_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetAddress_ApiHandler ()
			{
				if (cb_LocationGetAddress_Api == null)
					cb_LocationGetAddress_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetAddress_Api));
				return cb_LocationGetAddress_Api;
			}

			static IntPtr n_LocationGetAddress_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetAddress_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetAddress_Api' and count(parameter)=0]"
			[Register ("LocationGetAddress_Api", "()Ljava/lang/String;", "GetLocationGetAddress_ApiHandler")]
			public virtual unsafe string? LocationGetAddress_Api ()
			{
				const string __id = "LocationGetAddress_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_LocationGetCity_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetCity_ApiHandler ()
			{
				if (cb_LocationGetCity_Api == null)
					cb_LocationGetCity_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetCity_Api));
				return cb_LocationGetCity_Api;
			}

			static IntPtr n_LocationGetCity_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetCity_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetCity_Api' and count(parameter)=0]"
			[Register ("LocationGetCity_Api", "()Ljava/lang/String;", "GetLocationGetCity_ApiHandler")]
			public virtual unsafe string? LocationGetCity_Api ()
			{
				const string __id = "LocationGetCity_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_LocationGetCoorType_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetCoorType_ApiHandler ()
			{
				if (cb_LocationGetCoorType_Api == null)
					cb_LocationGetCoorType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetCoorType_Api));
				return cb_LocationGetCoorType_Api;
			}

			static IntPtr n_LocationGetCoorType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetCoorType_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetCoorType_Api' and count(parameter)=0]"
			[Register ("LocationGetCoorType_Api", "()Ljava/lang/String;", "GetLocationGetCoorType_ApiHandler")]
			public virtual unsafe string? LocationGetCoorType_Api ()
			{
				const string __id = "LocationGetCoorType_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_LocationGetDistrict_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetDistrict_ApiHandler ()
			{
				if (cb_LocationGetDistrict_Api == null)
					cb_LocationGetDistrict_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetDistrict_Api));
				return cb_LocationGetDistrict_Api;
			}

			static IntPtr n_LocationGetDistrict_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetDistrict_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetDistrict_Api' and count(parameter)=0]"
			[Register ("LocationGetDistrict_Api", "()Ljava/lang/String;", "GetLocationGetDistrict_ApiHandler")]
			public virtual unsafe string? LocationGetDistrict_Api ()
			{
				const string __id = "LocationGetDistrict_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_LocationGetErrInfo_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetErrInfo_ApiHandler ()
			{
				if (cb_LocationGetErrInfo_Api == null)
					cb_LocationGetErrInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetErrInfo_Api));
				return cb_LocationGetErrInfo_Api;
			}

			static IntPtr n_LocationGetErrInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetErrInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetErrInfo_Api' and count(parameter)=0]"
			[Register ("LocationGetErrInfo_Api", "()Ljava/lang/String;", "GetLocationGetErrInfo_ApiHandler")]
			public virtual unsafe string? LocationGetErrInfo_Api ()
			{
				const string __id = "LocationGetErrInfo_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_LocationGetLat_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetLat_ApiHandler ()
			{
				if (cb_LocationGetLat_Api == null)
					cb_LocationGetLat_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_LocationGetLat_Api));
				return cb_LocationGetLat_Api;
			}

			static double n_LocationGetLat_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationGetLat_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetLat_Api' and count(parameter)=0]"
			[Register ("LocationGetLat_Api", "()D", "GetLocationGetLat_ApiHandler")]
			public virtual unsafe double LocationGetLat_Api ()
			{
				const string __id = "LocationGetLat_Api.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LocationGetLng_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetLng_ApiHandler ()
			{
				if (cb_LocationGetLng_Api == null)
					cb_LocationGetLng_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_LocationGetLng_Api));
				return cb_LocationGetLng_Api;
			}

			static double n_LocationGetLng_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationGetLng_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetLng_Api' and count(parameter)=0]"
			[Register ("LocationGetLng_Api", "()D", "GetLocationGetLng_ApiHandler")]
			public virtual unsafe double LocationGetLng_Api ()
			{
				const string __id = "LocationGetLng_Api.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LocationGetLocInfo_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetLocationGetLocInfo_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_LocationGetLocInfo_Api_Landroid_os_Bundle_ == null)
					cb_LocationGetLocInfo_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LocationGetLocInfo_Api_Landroid_os_Bundle_));
				return cb_LocationGetLocInfo_Api_Landroid_os_Bundle_;
			}

			static void n_LocationGetLocInfo_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				__this.LocationGetLocInfo_Api (bundle);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetLocInfo_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("LocationGetLocInfo_Api", "(Landroid/os/Bundle;)V", "GetLocationGetLocInfo_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe void LocationGetLocInfo_Api (global::Android.OS.Bundle? bundle)
			{
				const string __id = "LocationGetLocInfo_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_LocationGetProvince_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetProvince_ApiHandler ()
			{
				if (cb_LocationGetProvince_Api == null)
					cb_LocationGetProvince_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetProvince_Api));
				return cb_LocationGetProvince_Api;
			}

			static IntPtr n_LocationGetProvince_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetProvince_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationGetProvince_Api' and count(parameter)=0]"
			[Register ("LocationGetProvince_Api", "()Ljava/lang/String;", "GetLocationGetProvince_ApiHandler")]
			public virtual unsafe string? LocationGetProvince_Api ()
			{
				const string __id = "LocationGetProvince_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_LocationLoc_Api_I;
#pragma warning disable 0169
			static Delegate GetLocationLoc_Api_IHandler ()
			{
				if (cb_LocationLoc_Api_I == null)
					cb_LocationLoc_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_LocationLoc_Api_I));
				return cb_LocationLoc_Api_I;
			}

			static bool n_LocationLoc_Api_I (IntPtr jnienv, IntPtr native__this, int timeout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationLoc_Api (timeout);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationLoc_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LocationLoc_Api", "(I)Z", "GetLocationLoc_Api_IHandler")]
			public virtual unsafe bool LocationLoc_Api (int timeout)
			{
				const string __id = "LocationLoc_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LocationResult_Api;
#pragma warning disable 0169
			static Delegate GetLocationResult_ApiHandler ()
			{
				if (cb_LocationResult_Api == null)
					cb_LocationResult_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_LocationResult_Api));
				return cb_LocationResult_Api;
			}

			static int n_LocationResult_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationResult_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationResult_Api' and count(parameter)=0]"
			[Register ("LocationResult_Api", "()I", "GetLocationResult_ApiHandler")]
			public virtual unsafe int LocationResult_Api ()
			{
				const string __id = "LocationResult_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LocationSetCoorType_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLocationSetCoorType_Api_Ljava_lang_String_Handler ()
			{
				if (cb_LocationSetCoorType_Api_Ljava_lang_String_ == null)
					cb_LocationSetCoorType_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LocationSetCoorType_Api_Ljava_lang_String_));
				return cb_LocationSetCoorType_Api_Ljava_lang_String_;
			}

			static void n_LocationSetCoorType_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_coorType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var coorType = JNIEnv.GetString (native_coorType, JniHandleOwnership.DoNotTransfer);
				__this.LocationSetCoorType_Api (coorType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationSetCoorType_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("LocationSetCoorType_Api", "(Ljava/lang/String;)V", "GetLocationSetCoorType_Api_Ljava_lang_String_Handler")]
			public virtual unsafe void LocationSetCoorType_Api (string? coorType)
			{
				const string __id = "LocationSetCoorType_Api.(Ljava/lang/String;)V";
				IntPtr native_coorType = JNIEnv.NewString ((string?)coorType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_coorType);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_coorType);
				}
			}

			static Delegate? cb_LocationStart_Api;
#pragma warning disable 0169
			static Delegate GetLocationStart_ApiHandler ()
			{
				if (cb_LocationStart_Api == null)
					cb_LocationStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_LocationStart_Api));
				return cb_LocationStart_Api;
			}

			static int n_LocationStart_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationStart_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationStart_Api' and count(parameter)=0]"
			[Register ("LocationStart_Api", "()I", "GetLocationStart_ApiHandler")]
			public virtual unsafe int LocationStart_Api ()
			{
				const string __id = "LocationStart_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_LocationStop_Api;
#pragma warning disable 0169
			static Delegate GetLocationStop_ApiHandler ()
			{
				if (cb_LocationStop_Api == null)
					cb_LocationStop_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LocationStop_Api));
				return cb_LocationStop_Api;
			}

			static void n_LocationStop_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.LocationStop_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='LocationStop_Api' and count(parameter)=0]"
			[Register ("LocationStop_Api", "()V", "GetLocationStop_ApiHandler")]
			public virtual unsafe void LocationStop_Api ()
			{
				const string __id = "LocationStop_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder? AsBinder ()
			{
				const string __id = "asBinder.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_;
#pragma warning disable 0169
			static Delegate GetGetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_Handler ()
			{
				if (cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ == null)
					cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_GetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_));
				return cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_;
			}

			static void n_GetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params, IntPtr native__callback)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var @params = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native__params, JniHandleOwnership.DoNotTransfer);
				var @callback = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.GetLocationInfo (@params, @callback);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Default']/method[@name='getLocationInfo' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAidlLocationCallbackAIDL']]"
			[Register ("getLocationInfo", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IAidlLocationCallbackAIDL;)V", "GetGetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_Handler")]
			public virtual unsafe void GetLocationInfo (global::Android.OS.Bundle? @params, global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL? @callback)
			{
				const string __id = "getLocationInfo.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IAidlLocationCallbackAIDL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
					__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@params);
					global::System.GC.KeepAlive (@callback);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/location/LocationHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/location/LocationHandler$Stub", typeof (Stub));

			internal static IntPtr class_ref {
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
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Stub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Stub']/constructor[@name='LocationHandler.Stub' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Stub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			public static unsafe global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/location/LocationHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/location/LocationHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder? AsBinder ()
			{
				const string __id = "asBinder.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/location/LocationHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/location/LocationHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (obj);
				}
			}

			static Delegate? cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
					cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLI_Z (n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I));
				return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
			}

			static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
			[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
			public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel? data, global::Android.OS.Parcel? reply, int flags)
			{
				const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (code);
					__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
					__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
					__args [3] = new JniArgumentValue (flags);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (data);
					global::System.GC.KeepAlive (reply);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/class[@name='LocationHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.location.LocationHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/location/LocationHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/location/LocationHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_LocationCalDistance_Api_DDDD;
#pragma warning disable 0169
			static Delegate GetLocationCalDistance_Api_DDDDHandler ()
			{
				if (cb_LocationCalDistance_Api_DDDD == null)
					cb_LocationCalDistance_Api_DDDD = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPDDDD_D (n_LocationCalDistance_Api_DDDD));
				return cb_LocationCalDistance_Api_DDDD;
			}

			static double n_LocationCalDistance_Api_DDDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2, double p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationCalDistance_Api (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationCalDistance_Api' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
			[Register ("LocationCalDistance_Api", "(DDDD)D", "GetLocationCalDistance_Api_DDDDHandler")]
			public abstract double LocationCalDistance_Api (double p0, double p1, double p2, double p3);

			static Delegate? cb_LocationClrBuff_Api;
#pragma warning disable 0169
			static Delegate GetLocationClrBuff_ApiHandler ()
			{
				if (cb_LocationClrBuff_Api == null)
					cb_LocationClrBuff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LocationClrBuff_Api));
				return cb_LocationClrBuff_Api;
			}

			static void n_LocationClrBuff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.LocationClrBuff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationClrBuff_Api' and count(parameter)=0]"
			[Register ("LocationClrBuff_Api", "()V", "GetLocationClrBuff_ApiHandler")]
			public abstract void LocationClrBuff_Api ();

			static Delegate? cb_LocationGetAddress_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetAddress_ApiHandler ()
			{
				if (cb_LocationGetAddress_Api == null)
					cb_LocationGetAddress_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetAddress_Api));
				return cb_LocationGetAddress_Api;
			}

			static IntPtr n_LocationGetAddress_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetAddress_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetAddress_Api' and count(parameter)=0]"
			[Register ("LocationGetAddress_Api", "()Ljava/lang/String;", "GetLocationGetAddress_ApiHandler")]
			public abstract string? LocationGetAddress_Api ();

			static Delegate? cb_LocationGetCity_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetCity_ApiHandler ()
			{
				if (cb_LocationGetCity_Api == null)
					cb_LocationGetCity_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetCity_Api));
				return cb_LocationGetCity_Api;
			}

			static IntPtr n_LocationGetCity_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetCity_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetCity_Api' and count(parameter)=0]"
			[Register ("LocationGetCity_Api", "()Ljava/lang/String;", "GetLocationGetCity_ApiHandler")]
			public abstract string? LocationGetCity_Api ();

			static Delegate? cb_LocationGetCoorType_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetCoorType_ApiHandler ()
			{
				if (cb_LocationGetCoorType_Api == null)
					cb_LocationGetCoorType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetCoorType_Api));
				return cb_LocationGetCoorType_Api;
			}

			static IntPtr n_LocationGetCoorType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetCoorType_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetCoorType_Api' and count(parameter)=0]"
			[Register ("LocationGetCoorType_Api", "()Ljava/lang/String;", "GetLocationGetCoorType_ApiHandler")]
			public abstract string? LocationGetCoorType_Api ();

			static Delegate? cb_LocationGetDistrict_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetDistrict_ApiHandler ()
			{
				if (cb_LocationGetDistrict_Api == null)
					cb_LocationGetDistrict_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetDistrict_Api));
				return cb_LocationGetDistrict_Api;
			}

			static IntPtr n_LocationGetDistrict_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetDistrict_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetDistrict_Api' and count(parameter)=0]"
			[Register ("LocationGetDistrict_Api", "()Ljava/lang/String;", "GetLocationGetDistrict_ApiHandler")]
			public abstract string? LocationGetDistrict_Api ();

			static Delegate? cb_LocationGetErrInfo_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetErrInfo_ApiHandler ()
			{
				if (cb_LocationGetErrInfo_Api == null)
					cb_LocationGetErrInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetErrInfo_Api));
				return cb_LocationGetErrInfo_Api;
			}

			static IntPtr n_LocationGetErrInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetErrInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetErrInfo_Api' and count(parameter)=0]"
			[Register ("LocationGetErrInfo_Api", "()Ljava/lang/String;", "GetLocationGetErrInfo_ApiHandler")]
			public abstract string? LocationGetErrInfo_Api ();

			static Delegate? cb_LocationGetLat_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetLat_ApiHandler ()
			{
				if (cb_LocationGetLat_Api == null)
					cb_LocationGetLat_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_LocationGetLat_Api));
				return cb_LocationGetLat_Api;
			}

			static double n_LocationGetLat_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationGetLat_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLat_Api' and count(parameter)=0]"
			[Register ("LocationGetLat_Api", "()D", "GetLocationGetLat_ApiHandler")]
			public abstract double LocationGetLat_Api ();

			static Delegate? cb_LocationGetLng_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetLng_ApiHandler ()
			{
				if (cb_LocationGetLng_Api == null)
					cb_LocationGetLng_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_LocationGetLng_Api));
				return cb_LocationGetLng_Api;
			}

			static double n_LocationGetLng_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationGetLng_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLng_Api' and count(parameter)=0]"
			[Register ("LocationGetLng_Api", "()D", "GetLocationGetLng_ApiHandler")]
			public abstract double LocationGetLng_Api ();

			static Delegate? cb_LocationGetLocInfo_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetLocationGetLocInfo_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_LocationGetLocInfo_Api_Landroid_os_Bundle_ == null)
					cb_LocationGetLocInfo_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LocationGetLocInfo_Api_Landroid_os_Bundle_));
				return cb_LocationGetLocInfo_Api_Landroid_os_Bundle_;
			}

			static void n_LocationGetLocInfo_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.LocationGetLocInfo_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLocInfo_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("LocationGetLocInfo_Api", "(Landroid/os/Bundle;)V", "GetLocationGetLocInfo_Api_Landroid_os_Bundle_Handler")]
			public abstract void LocationGetLocInfo_Api (global::Android.OS.Bundle? p0);

			static Delegate? cb_LocationGetProvince_Api;
#pragma warning disable 0169
			static Delegate GetLocationGetProvince_ApiHandler ()
			{
				if (cb_LocationGetProvince_Api == null)
					cb_LocationGetProvince_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetProvince_Api));
				return cb_LocationGetProvince_Api;
			}

			static IntPtr n_LocationGetProvince_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.LocationGetProvince_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetProvince_Api' and count(parameter)=0]"
			[Register ("LocationGetProvince_Api", "()Ljava/lang/String;", "GetLocationGetProvince_ApiHandler")]
			public abstract string? LocationGetProvince_Api ();

			static Delegate? cb_LocationLoc_Api_I;
#pragma warning disable 0169
			static Delegate GetLocationLoc_Api_IHandler ()
			{
				if (cb_LocationLoc_Api_I == null)
					cb_LocationLoc_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_LocationLoc_Api_I));
				return cb_LocationLoc_Api_I;
			}

			static bool n_LocationLoc_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationLoc_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationLoc_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LocationLoc_Api", "(I)Z", "GetLocationLoc_Api_IHandler")]
			public abstract bool LocationLoc_Api (int p0);

			static Delegate? cb_LocationResult_Api;
#pragma warning disable 0169
			static Delegate GetLocationResult_ApiHandler ()
			{
				if (cb_LocationResult_Api == null)
					cb_LocationResult_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_LocationResult_Api));
				return cb_LocationResult_Api;
			}

			static int n_LocationResult_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationResult_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationResult_Api' and count(parameter)=0]"
			[Register ("LocationResult_Api", "()I", "GetLocationResult_ApiHandler")]
			public abstract int LocationResult_Api ();

			static Delegate? cb_LocationSetCoorType_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLocationSetCoorType_Api_Ljava_lang_String_Handler ()
			{
				if (cb_LocationSetCoorType_Api_Ljava_lang_String_ == null)
					cb_LocationSetCoorType_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LocationSetCoorType_Api_Ljava_lang_String_));
				return cb_LocationSetCoorType_Api_Ljava_lang_String_;
			}

			static void n_LocationSetCoorType_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.LocationSetCoorType_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationSetCoorType_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("LocationSetCoorType_Api", "(Ljava/lang/String;)V", "GetLocationSetCoorType_Api_Ljava_lang_String_Handler")]
			public abstract void LocationSetCoorType_Api (string? p0);

			static Delegate? cb_LocationStart_Api;
#pragma warning disable 0169
			static Delegate GetLocationStart_ApiHandler ()
			{
				if (cb_LocationStart_Api == null)
					cb_LocationStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_LocationStart_Api));
				return cb_LocationStart_Api;
			}

			static int n_LocationStart_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LocationStart_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationStart_Api' and count(parameter)=0]"
			[Register ("LocationStart_Api", "()I", "GetLocationStart_ApiHandler")]
			public abstract int LocationStart_Api ();

			static Delegate? cb_LocationStop_Api;
#pragma warning disable 0169
			static Delegate GetLocationStop_ApiHandler ()
			{
				if (cb_LocationStop_Api == null)
					cb_LocationStop_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LocationStop_Api));
				return cb_LocationStop_Api;
			}

			static void n_LocationStop_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.LocationStop_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationStop_Api' and count(parameter)=0]"
			[Register ("LocationStop_Api", "()V", "GetLocationStop_ApiHandler")]
			public abstract void LocationStop_Api ();

			static Delegate? cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_;
#pragma warning disable 0169
			static Delegate GetGetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_Handler ()
			{
				if (cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ == null)
					cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_GetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_));
				return cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_;
			}

			static void n_GetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.GetLocationInfo (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='getLocationInfo' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAidlLocationCallbackAIDL']]"
			[Register ("getLocationInfo", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IAidlLocationCallbackAIDL;)V", "GetGetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_Handler")]
			public abstract void GetLocationInfo (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL? p1);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/location/LocationHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/location/LocationHandler$Stub", typeof (StubInvoker));

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationCalDistance_Api' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
			[Register ("LocationCalDistance_Api", "(DDDD)D", "GetLocationCalDistance_Api_DDDDHandler")]
			public override unsafe double LocationCalDistance_Api (double p0, double p1, double p2, double p3)
			{
				const string __id = "LocationCalDistance_Api.(DDDD)D";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationClrBuff_Api' and count(parameter)=0]"
			[Register ("LocationClrBuff_Api", "()V", "GetLocationClrBuff_ApiHandler")]
			public override unsafe void LocationClrBuff_Api ()
			{
				const string __id = "LocationClrBuff_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetAddress_Api' and count(parameter)=0]"
			[Register ("LocationGetAddress_Api", "()Ljava/lang/String;", "GetLocationGetAddress_ApiHandler")]
			public override unsafe string? LocationGetAddress_Api ()
			{
				const string __id = "LocationGetAddress_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetCity_Api' and count(parameter)=0]"
			[Register ("LocationGetCity_Api", "()Ljava/lang/String;", "GetLocationGetCity_ApiHandler")]
			public override unsafe string? LocationGetCity_Api ()
			{
				const string __id = "LocationGetCity_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetCoorType_Api' and count(parameter)=0]"
			[Register ("LocationGetCoorType_Api", "()Ljava/lang/String;", "GetLocationGetCoorType_ApiHandler")]
			public override unsafe string? LocationGetCoorType_Api ()
			{
				const string __id = "LocationGetCoorType_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetDistrict_Api' and count(parameter)=0]"
			[Register ("LocationGetDistrict_Api", "()Ljava/lang/String;", "GetLocationGetDistrict_ApiHandler")]
			public override unsafe string? LocationGetDistrict_Api ()
			{
				const string __id = "LocationGetDistrict_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetErrInfo_Api' and count(parameter)=0]"
			[Register ("LocationGetErrInfo_Api", "()Ljava/lang/String;", "GetLocationGetErrInfo_ApiHandler")]
			public override unsafe string? LocationGetErrInfo_Api ()
			{
				const string __id = "LocationGetErrInfo_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLat_Api' and count(parameter)=0]"
			[Register ("LocationGetLat_Api", "()D", "GetLocationGetLat_ApiHandler")]
			public override unsafe double LocationGetLat_Api ()
			{
				const string __id = "LocationGetLat_Api.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLng_Api' and count(parameter)=0]"
			[Register ("LocationGetLng_Api", "()D", "GetLocationGetLng_ApiHandler")]
			public override unsafe double LocationGetLng_Api ()
			{
				const string __id = "LocationGetLng_Api.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetLocInfo_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("LocationGetLocInfo_Api", "(Landroid/os/Bundle;)V", "GetLocationGetLocInfo_Api_Landroid_os_Bundle_Handler")]
			public override unsafe void LocationGetLocInfo_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "LocationGetLocInfo_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationGetProvince_Api' and count(parameter)=0]"
			[Register ("LocationGetProvince_Api", "()Ljava/lang/String;", "GetLocationGetProvince_ApiHandler")]
			public override unsafe string? LocationGetProvince_Api ()
			{
				const string __id = "LocationGetProvince_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationLoc_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("LocationLoc_Api", "(I)Z", "GetLocationLoc_Api_IHandler")]
			public override unsafe bool LocationLoc_Api (int p0)
			{
				const string __id = "LocationLoc_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationResult_Api' and count(parameter)=0]"
			[Register ("LocationResult_Api", "()I", "GetLocationResult_ApiHandler")]
			public override unsafe int LocationResult_Api ()
			{
				const string __id = "LocationResult_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationSetCoorType_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("LocationSetCoorType_Api", "(Ljava/lang/String;)V", "GetLocationSetCoorType_Api_Ljava_lang_String_Handler")]
			public override unsafe void LocationSetCoorType_Api (string? p0)
			{
				const string __id = "LocationSetCoorType_Api.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationStart_Api' and count(parameter)=0]"
			[Register ("LocationStart_Api", "()I", "GetLocationStart_ApiHandler")]
			public override unsafe int LocationStart_Api ()
			{
				const string __id = "LocationStart_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='LocationStop_Api' and count(parameter)=0]"
			[Register ("LocationStop_Api", "()V", "GetLocationStop_ApiHandler")]
			public override unsafe void LocationStop_Api ()
			{
				const string __id = "LocationStop_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.location']/interface[@name='LocationHandler']/method[@name='getLocationInfo' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IAidlLocationCallbackAIDL']]"
			[Register ("getLocationInfo", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IAidlLocationCallbackAIDL;)V", "GetGetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_Handler")]
			public override unsafe void GetLocationInfo (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL? p1)
			{
				const string __id = "getLocationInfo.(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IAidlLocationCallbackAIDL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/location/LocationHandler", DoNotGenerateAcw=true)]
	internal partial class ILocationHandlerInvoker : global::Java.Lang.Object, ILocationHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/location/LocationHandler", typeof (ILocationHandlerInvoker));

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

		public static ILocationHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.location.LocationHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_LocationCalDistance_Api_DDDD;
#pragma warning disable 0169
		static Delegate GetLocationCalDistance_Api_DDDDHandler ()
		{
			if (cb_LocationCalDistance_Api_DDDD == null)
				cb_LocationCalDistance_Api_DDDD = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPDDDD_D (n_LocationCalDistance_Api_DDDD));
			return cb_LocationCalDistance_Api_DDDD;
		}

		static double n_LocationCalDistance_Api_DDDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2, double p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LocationCalDistance_Api (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_LocationCalDistance_Api_DDDD;
		public unsafe double LocationCalDistance_Api (double p0, double p1, double p2, double p3)
		{
			if (id_LocationCalDistance_Api_DDDD == IntPtr.Zero)
				id_LocationCalDistance_Api_DDDD = JNIEnv.GetMethodID (class_ref, "LocationCalDistance_Api", "(DDDD)D");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_LocationCalDistance_Api_DDDD, __args);
		}

		static Delegate? cb_LocationClrBuff_Api;
#pragma warning disable 0169
		static Delegate GetLocationClrBuff_ApiHandler ()
		{
			if (cb_LocationClrBuff_Api == null)
				cb_LocationClrBuff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LocationClrBuff_Api));
			return cb_LocationClrBuff_Api;
		}

		static void n_LocationClrBuff_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.LocationClrBuff_Api ();
		}
#pragma warning restore 0169

		IntPtr id_LocationClrBuff_Api;
		public unsafe void LocationClrBuff_Api ()
		{
			if (id_LocationClrBuff_Api == IntPtr.Zero)
				id_LocationClrBuff_Api = JNIEnv.GetMethodID (class_ref, "LocationClrBuff_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocationClrBuff_Api);
		}

		static Delegate? cb_LocationGetAddress_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetAddress_ApiHandler ()
		{
			if (cb_LocationGetAddress_Api == null)
				cb_LocationGetAddress_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetAddress_Api));
			return cb_LocationGetAddress_Api;
		}

		static IntPtr n_LocationGetAddress_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LocationGetAddress_Api ());
		}
#pragma warning restore 0169

		IntPtr id_LocationGetAddress_Api;
		public unsafe string? LocationGetAddress_Api ()
		{
			if (id_LocationGetAddress_Api == IntPtr.Zero)
				id_LocationGetAddress_Api = JNIEnv.GetMethodID (class_ref, "LocationGetAddress_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetAddress_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_LocationGetCity_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetCity_ApiHandler ()
		{
			if (cb_LocationGetCity_Api == null)
				cb_LocationGetCity_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetCity_Api));
			return cb_LocationGetCity_Api;
		}

		static IntPtr n_LocationGetCity_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LocationGetCity_Api ());
		}
#pragma warning restore 0169

		IntPtr id_LocationGetCity_Api;
		public unsafe string? LocationGetCity_Api ()
		{
			if (id_LocationGetCity_Api == IntPtr.Zero)
				id_LocationGetCity_Api = JNIEnv.GetMethodID (class_ref, "LocationGetCity_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetCity_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_LocationGetCoorType_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetCoorType_ApiHandler ()
		{
			if (cb_LocationGetCoorType_Api == null)
				cb_LocationGetCoorType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetCoorType_Api));
			return cb_LocationGetCoorType_Api;
		}

		static IntPtr n_LocationGetCoorType_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LocationGetCoorType_Api ());
		}
#pragma warning restore 0169

		IntPtr id_LocationGetCoorType_Api;
		public unsafe string? LocationGetCoorType_Api ()
		{
			if (id_LocationGetCoorType_Api == IntPtr.Zero)
				id_LocationGetCoorType_Api = JNIEnv.GetMethodID (class_ref, "LocationGetCoorType_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetCoorType_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_LocationGetDistrict_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetDistrict_ApiHandler ()
		{
			if (cb_LocationGetDistrict_Api == null)
				cb_LocationGetDistrict_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetDistrict_Api));
			return cb_LocationGetDistrict_Api;
		}

		static IntPtr n_LocationGetDistrict_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LocationGetDistrict_Api ());
		}
#pragma warning restore 0169

		IntPtr id_LocationGetDistrict_Api;
		public unsafe string? LocationGetDistrict_Api ()
		{
			if (id_LocationGetDistrict_Api == IntPtr.Zero)
				id_LocationGetDistrict_Api = JNIEnv.GetMethodID (class_ref, "LocationGetDistrict_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetDistrict_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_LocationGetErrInfo_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetErrInfo_ApiHandler ()
		{
			if (cb_LocationGetErrInfo_Api == null)
				cb_LocationGetErrInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetErrInfo_Api));
			return cb_LocationGetErrInfo_Api;
		}

		static IntPtr n_LocationGetErrInfo_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LocationGetErrInfo_Api ());
		}
#pragma warning restore 0169

		IntPtr id_LocationGetErrInfo_Api;
		public unsafe string? LocationGetErrInfo_Api ()
		{
			if (id_LocationGetErrInfo_Api == IntPtr.Zero)
				id_LocationGetErrInfo_Api = JNIEnv.GetMethodID (class_ref, "LocationGetErrInfo_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetErrInfo_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_LocationGetLat_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetLat_ApiHandler ()
		{
			if (cb_LocationGetLat_Api == null)
				cb_LocationGetLat_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_LocationGetLat_Api));
			return cb_LocationGetLat_Api;
		}

		static double n_LocationGetLat_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LocationGetLat_Api ();
		}
#pragma warning restore 0169

		IntPtr id_LocationGetLat_Api;
		public unsafe double LocationGetLat_Api ()
		{
			if (id_LocationGetLat_Api == IntPtr.Zero)
				id_LocationGetLat_Api = JNIEnv.GetMethodID (class_ref, "LocationGetLat_Api", "()D");
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetLat_Api);
		}

		static Delegate? cb_LocationGetLng_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetLng_ApiHandler ()
		{
			if (cb_LocationGetLng_Api == null)
				cb_LocationGetLng_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_LocationGetLng_Api));
			return cb_LocationGetLng_Api;
		}

		static double n_LocationGetLng_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LocationGetLng_Api ();
		}
#pragma warning restore 0169

		IntPtr id_LocationGetLng_Api;
		public unsafe double LocationGetLng_Api ()
		{
			if (id_LocationGetLng_Api == IntPtr.Zero)
				id_LocationGetLng_Api = JNIEnv.GetMethodID (class_ref, "LocationGetLng_Api", "()D");
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetLng_Api);
		}

		static Delegate? cb_LocationGetLocInfo_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetLocationGetLocInfo_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_LocationGetLocInfo_Api_Landroid_os_Bundle_ == null)
				cb_LocationGetLocInfo_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LocationGetLocInfo_Api_Landroid_os_Bundle_));
			return cb_LocationGetLocInfo_Api_Landroid_os_Bundle_;
		}

		static void n_LocationGetLocInfo_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocationGetLocInfo_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_LocationGetLocInfo_Api_Landroid_os_Bundle_;
		public unsafe void LocationGetLocInfo_Api (global::Android.OS.Bundle? p0)
		{
			if (id_LocationGetLocInfo_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_LocationGetLocInfo_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "LocationGetLocInfo_Api", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetLocInfo_Api_Landroid_os_Bundle_, __args);
		}

		static Delegate? cb_LocationGetProvince_Api;
#pragma warning disable 0169
		static Delegate GetLocationGetProvince_ApiHandler ()
		{
			if (cb_LocationGetProvince_Api == null)
				cb_LocationGetProvince_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_LocationGetProvince_Api));
			return cb_LocationGetProvince_Api;
		}

		static IntPtr n_LocationGetProvince_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LocationGetProvince_Api ());
		}
#pragma warning restore 0169

		IntPtr id_LocationGetProvince_Api;
		public unsafe string? LocationGetProvince_Api ()
		{
			if (id_LocationGetProvince_Api == IntPtr.Zero)
				id_LocationGetProvince_Api = JNIEnv.GetMethodID (class_ref, "LocationGetProvince_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LocationGetProvince_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_LocationLoc_Api_I;
#pragma warning disable 0169
		static Delegate GetLocationLoc_Api_IHandler ()
		{
			if (cb_LocationLoc_Api_I == null)
				cb_LocationLoc_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_LocationLoc_Api_I));
			return cb_LocationLoc_Api_I;
		}

		static bool n_LocationLoc_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LocationLoc_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_LocationLoc_Api_I;
		public unsafe bool LocationLoc_Api (int p0)
		{
			if (id_LocationLoc_Api_I == IntPtr.Zero)
				id_LocationLoc_Api_I = JNIEnv.GetMethodID (class_ref, "LocationLoc_Api", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LocationLoc_Api_I, __args);
		}

		static Delegate? cb_LocationResult_Api;
#pragma warning disable 0169
		static Delegate GetLocationResult_ApiHandler ()
		{
			if (cb_LocationResult_Api == null)
				cb_LocationResult_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_LocationResult_Api));
			return cb_LocationResult_Api;
		}

		static int n_LocationResult_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LocationResult_Api ();
		}
#pragma warning restore 0169

		IntPtr id_LocationResult_Api;
		public unsafe int LocationResult_Api ()
		{
			if (id_LocationResult_Api == IntPtr.Zero)
				id_LocationResult_Api = JNIEnv.GetMethodID (class_ref, "LocationResult_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_LocationResult_Api);
		}

		static Delegate? cb_LocationSetCoorType_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLocationSetCoorType_Api_Ljava_lang_String_Handler ()
		{
			if (cb_LocationSetCoorType_Api_Ljava_lang_String_ == null)
				cb_LocationSetCoorType_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LocationSetCoorType_Api_Ljava_lang_String_));
			return cb_LocationSetCoorType_Api_Ljava_lang_String_;
		}

		static void n_LocationSetCoorType_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocationSetCoorType_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_LocationSetCoorType_Api_Ljava_lang_String_;
		public unsafe void LocationSetCoorType_Api (string? p0)
		{
			if (id_LocationSetCoorType_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_LocationSetCoorType_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "LocationSetCoorType_Api", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocationSetCoorType_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_LocationStart_Api;
#pragma warning disable 0169
		static Delegate GetLocationStart_ApiHandler ()
		{
			if (cb_LocationStart_Api == null)
				cb_LocationStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_LocationStart_Api));
			return cb_LocationStart_Api;
		}

		static int n_LocationStart_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LocationStart_Api ();
		}
#pragma warning restore 0169

		IntPtr id_LocationStart_Api;
		public unsafe int LocationStart_Api ()
		{
			if (id_LocationStart_Api == IntPtr.Zero)
				id_LocationStart_Api = JNIEnv.GetMethodID (class_ref, "LocationStart_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_LocationStart_Api);
		}

		static Delegate? cb_LocationStop_Api;
#pragma warning disable 0169
		static Delegate GetLocationStop_ApiHandler ()
		{
			if (cb_LocationStop_Api == null)
				cb_LocationStop_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LocationStop_Api));
			return cb_LocationStop_Api;
		}

		static void n_LocationStop_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.LocationStop_Api ();
		}
#pragma warning restore 0169

		IntPtr id_LocationStop_Api;
		public unsafe void LocationStop_Api ()
		{
			if (id_LocationStop_Api == IntPtr.Zero)
				id_LocationStop_Api = JNIEnv.GetMethodID (class_ref, "LocationStop_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocationStop_Api);
		}

		static Delegate? cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_;
#pragma warning disable 0169
		static Delegate GetGetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_Handler ()
		{
			if (cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ == null)
				cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_GetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_));
			return cb_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_;
		}

		static void n_GetLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetLocationInfo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_;
		public unsafe void GetLocationInfo (global::Android.OS.Bundle? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlLocationCallbackAIDL? p1)
		{
			if (id_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ == IntPtr.Zero)
				id_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_ = JNIEnv.GetMethodID (class_ref, "getLocationInfo", "(Landroid/os/Bundle;Lcom/vanstone/appsdk/api/interfaces/IAidlLocationCallbackAIDL;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLocationInfo_Landroid_os_Bundle_Lcom_vanstone_appsdk_api_interfaces_IAidlLocationCallbackAIDL_, __args);
		}

		static Delegate? cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Location.ILocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder? AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
