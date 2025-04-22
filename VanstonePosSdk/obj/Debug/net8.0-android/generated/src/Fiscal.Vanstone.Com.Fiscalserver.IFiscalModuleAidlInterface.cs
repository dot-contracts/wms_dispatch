using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Fiscal.Vanstone.Com.Fiscalserver {

	// Metadata.xml XPath interface reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']"
	[Register ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface", "", "Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker")]
	public partial interface IFiscalModuleAidlInterface : global::Android.OS.IInterface {
		long FreeDiskSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFreeDiskSpace' and count(parameter)=0]"
			[Register ("GetFreeDiskSpace", "()J", "GetGetFreeDiskSpaceHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
			get; 
		}

		int TotalRow {
			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetTotalRow' and count(parameter)=0]"
			[Register ("GetTotalRow", "()I", "GetGetTotalRowHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='AuthChallenge' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("AuthChallenge", "([BI)I", "GetAuthChallenge_arrayBIHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int AuthChallenge (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='Authexec' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("Authexec", "([BI)I", "GetAuthexec_arrayBIHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int Authexec (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='Authrequest' and count(parameter)=0]"
		[Register ("Authrequest", "()I", "GetAuthrequestHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int Authrequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindExec' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("BindExec", "([BI[BI)I", "GetBindExec_arrayBIarrayBIHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int BindExec (byte[]? p0, int p1, byte[]? p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindQuery' and count(parameter)=0]"
		[Register ("BindQuery", "()I", "GetBindQueryHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int BindQuery ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindRequest' and count(parameter)=0]"
		[Register ("BindRequest", "()I", "GetBindRequestHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int BindRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='ClearFiscalDatabase' and count(parameter)=0]"
		[Register ("ClearFiscalDatabase", "()I", "GetClearFiscalDatabaseHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int ClearFiscalDatabase ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='ClearWormDatabase' and count(parameter)=0]"
		[Register ("ClearWormDatabase", "()I", "GetClearWormDatabaseHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int ClearWormDatabase ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='CloseFiscalModuleDatabase' and count(parameter)=0]"
		[Register ("CloseFiscalModuleDatabase", "()I", "GetCloseFiscalModuleDatabaseHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int CloseFiscalModuleDatabase ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='DownloadFile' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("DownloadFile", "([BI)I", "GetDownloadFile_arrayBIHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int DownloadFile (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='DownloadServer' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("DownloadServer", "([BI)I", "GetDownloadServer_arrayBIHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int DownloadServer (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='FiscalModulePowerOff' and count(parameter)=0]"
		[Register ("FiscalModulePowerOff", "()I", "GetFiscalModulePowerOffHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int FiscalModulePowerOff ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='FiscalModulePowerOn' and count(parameter)=0]"
		[Register ("FiscalModulePowerOn", "()I", "GetFiscalModulePowerOnHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int FiscalModulePowerOn ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxContentById' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("GetFaxContentById", "(J)Ljava/lang/String;", "GetGetFaxContentById_JHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		string? GetFaxContentById (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxIdsByDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("GetFaxIdsByDate", "(J)[J", "GetGetFaxIdsByDate_JHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		long[]? GetFaxIdsByDate (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxMessage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("GetFaxMessage", "(JLjava/lang/String;)Z", "GetGetFaxMessage_JLjava_lang_String_Handler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		bool GetFaxMessage (long p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxMessageDayNumber' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("GetFaxMessageDayNumber", "(JJ[B[Ljava/lang/String;)[B", "GetGetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_Handler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		byte[]? GetFaxMessageDayNumber (long p0, long p1, byte[]? p2, string[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("GetFaxVersion", "([B)Z", "GetGetFaxVersion_arrayBHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		bool GetFaxVersion (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleDataById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("GetFiscalModuleDataById", "(I[B)I", "GetGetFiscalModuleDataById_IarrayBHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int GetFiscalModuleDataById (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleHardwareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("GetFiscalModuleHardwareVersion", "([B)I", "GetGetFiscalModuleHardwareVersion_arrayBHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int GetFiscalModuleHardwareVersion (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleIds' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("GetFiscalModuleIds", "(III[B)I", "GetGetFiscalModuleIds_IIIarrayBHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int GetFiscalModuleIds (int p0, int p1, int p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleMkey' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("GetFiscalModuleMkey", "(JI)I", "GetGetFiscalModuleMkey_JIHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int GetFiscalModuleMkey (long p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleSoftWareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("GetFiscalModuleSoftWareVersion", "([B)I", "GetGetFiscalModuleSoftWareVersion_arrayBHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int GetFiscalModuleSoftWareVersion (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='OpenFiscalModuleDatabase' and count(parameter)=0]"
		[Register ("OpenFiscalModuleDatabase", "()I", "GetOpenFiscalModuleDatabaseHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int OpenFiscalModuleDatabase ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='SysGetSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("SysGetSN", "([B)I", "GetSysGetSN_arrayBHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int SysGetSN (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='WriteFiscalOnly' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
		[Register ("WriteFiscalOnly", "(I[BJ)I", "GetWriteFiscalOnly_IarrayBJHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int WriteFiscalOnly (int p0, byte[]? p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='WriteWormOnly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
		[Register ("WriteWormOnly", "(J[BJ)J", "GetWriteWormOnly_JarrayBJHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		long WriteWormOnly (long p0, byte[]? p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='basicTypes' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='float'] and parameter[5][@type='double'] and parameter[6][@type='java.lang.String']]"
		[Register ("basicTypes", "(IJZFDLjava/lang/String;)V", "GetBasicTypes_IJZFDLjava_lang_String_Handler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		void BasicTypes (int p0, long p1, bool p2, float p3, double p4, string? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordCheck' and count(parameter)=0]"
		[Register ("databaseRecordCheck", "()I", "GetDatabaseRecordCheckHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int DatabaseRecordCheck ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordClose' and count(parameter)=0]"
		[Register ("databaseRecordClose", "()I", "GetDatabaseRecordCloseHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int DatabaseRecordClose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordOpen' and count(parameter)=0]"
		[Register ("databaseRecordOpen", "()I", "GetDatabaseRecordOpenHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int DatabaseRecordOpen ();

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordRead' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("databaseRecordRead", "(I[I[B[I)I", "GetDatabaseRecordRead_IarrayIarrayBarrayIHandler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		int DatabaseRecordRead (int p0, int[]? p1, byte[]? p2, int[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='getreceipt' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("getreceipt", "(JJLjava/lang/String;)Z", "GetGetreceipt_JJLjava_lang_String_Handler:Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterfaceInvoker, VanstonePosSdk")]
		bool Getreceipt (long p0, long p1, string? p2);

		// Metadata.xml XPath class reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']"
		[global::Android.Runtime.Register ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface {
			static readonly JniPeerMembers _members = new XAPeerMembers ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/constructor[@name='IFiscalModuleAidlInterface.Default' and count(parameter)=0]"
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

			static Delegate? cb_GetFreeDiskSpace;
#pragma warning disable 0169
			static Delegate GetGetFreeDiskSpaceHandler ()
			{
				if (cb_GetFreeDiskSpace == null)
					cb_GetFreeDiskSpace = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetFreeDiskSpace));
				return cb_GetFreeDiskSpace;
			}

			static long n_GetFreeDiskSpace (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FreeDiskSpace;
			}
#pragma warning restore 0169

			public virtual unsafe long FreeDiskSpace {
				// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFreeDiskSpace' and count(parameter)=0]"
				[Register ("GetFreeDiskSpace", "()J", "GetGetFreeDiskSpaceHandler")]
				get {
					const string __id = "GetFreeDiskSpace.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_GetTotalRow;
#pragma warning disable 0169
			static Delegate GetGetTotalRowHandler ()
			{
				if (cb_GetTotalRow == null)
					cb_GetTotalRow = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetTotalRow));
				return cb_GetTotalRow;
			}

			static int n_GetTotalRow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.TotalRow;
			}
#pragma warning restore 0169

			public virtual unsafe int TotalRow {
				// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetTotalRow' and count(parameter)=0]"
				[Register ("GetTotalRow", "()I", "GetGetTotalRowHandler")]
				get {
					const string __id = "GetTotalRow.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_AuthChallenge_arrayBI;
#pragma warning disable 0169
			static Delegate GetAuthChallenge_arrayBIHandler ()
			{
				if (cb_AuthChallenge_arrayBI == null)
					cb_AuthChallenge_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_AuthChallenge_arrayBI));
				return cb_AuthChallenge_arrayBI;
			}

			static int n_AuthChallenge_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_content, int contentlength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var content = (byte[]?) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.AuthChallenge (content, contentlength);
				if (content != null)
					JNIEnv.CopyArray (content, native_content);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='AuthChallenge' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("AuthChallenge", "([BI)I", "GetAuthChallenge_arrayBIHandler")]
			public virtual unsafe int AuthChallenge (byte[]? content, int contentlength)
			{
				const string __id = "AuthChallenge.([BI)I";
				IntPtr native_content = JNIEnv.NewArray (content);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_content);
					__args [1] = new JniArgumentValue (contentlength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (content != null) {
						JNIEnv.CopyArray (native_content, content);
						JNIEnv.DeleteLocalRef (native_content);
					}
					global::System.GC.KeepAlive (content);
				}
			}

			static Delegate? cb_Authexec_arrayBI;
#pragma warning disable 0169
			static Delegate GetAuthexec_arrayBIHandler ()
			{
				if (cb_Authexec_arrayBI == null)
					cb_Authexec_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Authexec_arrayBI));
				return cb_Authexec_arrayBI;
			}

			static int n_Authexec_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_content, int contentlength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var content = (byte[]?) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Authexec (content, contentlength);
				if (content != null)
					JNIEnv.CopyArray (content, native_content);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='Authexec' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Authexec", "([BI)I", "GetAuthexec_arrayBIHandler")]
			public virtual unsafe int Authexec (byte[]? content, int contentlength)
			{
				const string __id = "Authexec.([BI)I";
				IntPtr native_content = JNIEnv.NewArray (content);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_content);
					__args [1] = new JniArgumentValue (contentlength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (content != null) {
						JNIEnv.CopyArray (native_content, content);
						JNIEnv.DeleteLocalRef (native_content);
					}
					global::System.GC.KeepAlive (content);
				}
			}

			static Delegate? cb_Authrequest;
#pragma warning disable 0169
			static Delegate GetAuthrequestHandler ()
			{
				if (cb_Authrequest == null)
					cb_Authrequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Authrequest));
				return cb_Authrequest;
			}

			static int n_Authrequest (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Authrequest ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='Authrequest' and count(parameter)=0]"
			[Register ("Authrequest", "()I", "GetAuthrequestHandler")]
			public virtual unsafe int Authrequest ()
			{
				const string __id = "Authrequest.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_BindExec_arrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetBindExec_arrayBIarrayBIHandler ()
			{
				if (cb_BindExec_arrayBIarrayBI == null)
					cb_BindExec_arrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_I (n_BindExec_arrayBIarrayBI));
				return cb_BindExec_arrayBIarrayBI;
			}

			static int n_BindExec_arrayBIarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_sn, int snlength, IntPtr native_key, int keylength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var sn = (byte[]?) JNIEnv.GetArray (native_sn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.BindExec (sn, snlength, key, keylength);
				if (sn != null)
					JNIEnv.CopyArray (sn, native_sn);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='BindExec' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("BindExec", "([BI[BI)I", "GetBindExec_arrayBIarrayBIHandler")]
			public virtual unsafe int BindExec (byte[]? sn, int snlength, byte[]? key, int keylength)
			{
				const string __id = "BindExec.([BI[BI)I";
				IntPtr native_sn = JNIEnv.NewArray (sn);
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_sn);
					__args [1] = new JniArgumentValue (snlength);
					__args [2] = new JniArgumentValue (native_key);
					__args [3] = new JniArgumentValue (keylength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (sn != null) {
						JNIEnv.CopyArray (native_sn, sn);
						JNIEnv.DeleteLocalRef (native_sn);
					}
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (sn);
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_BindQuery;
#pragma warning disable 0169
			static Delegate GetBindQueryHandler ()
			{
				if (cb_BindQuery == null)
					cb_BindQuery = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_BindQuery));
				return cb_BindQuery;
			}

			static int n_BindQuery (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.BindQuery ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='BindQuery' and count(parameter)=0]"
			[Register ("BindQuery", "()I", "GetBindQueryHandler")]
			public virtual unsafe int BindQuery ()
			{
				const string __id = "BindQuery.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_BindRequest;
#pragma warning disable 0169
			static Delegate GetBindRequestHandler ()
			{
				if (cb_BindRequest == null)
					cb_BindRequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_BindRequest));
				return cb_BindRequest;
			}

			static int n_BindRequest (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.BindRequest ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='BindRequest' and count(parameter)=0]"
			[Register ("BindRequest", "()I", "GetBindRequestHandler")]
			public virtual unsafe int BindRequest ()
			{
				const string __id = "BindRequest.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_ClearFiscalDatabase;
#pragma warning disable 0169
			static Delegate GetClearFiscalDatabaseHandler ()
			{
				if (cb_ClearFiscalDatabase == null)
					cb_ClearFiscalDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ClearFiscalDatabase));
				return cb_ClearFiscalDatabase;
			}

			static int n_ClearFiscalDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ClearFiscalDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='ClearFiscalDatabase' and count(parameter)=0]"
			[Register ("ClearFiscalDatabase", "()I", "GetClearFiscalDatabaseHandler")]
			public virtual unsafe int ClearFiscalDatabase ()
			{
				const string __id = "ClearFiscalDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_ClearWormDatabase;
#pragma warning disable 0169
			static Delegate GetClearWormDatabaseHandler ()
			{
				if (cb_ClearWormDatabase == null)
					cb_ClearWormDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ClearWormDatabase));
				return cb_ClearWormDatabase;
			}

			static int n_ClearWormDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ClearWormDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='ClearWormDatabase' and count(parameter)=0]"
			[Register ("ClearWormDatabase", "()I", "GetClearWormDatabaseHandler")]
			public virtual unsafe int ClearWormDatabase ()
			{
				const string __id = "ClearWormDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_CloseFiscalModuleDatabase;
#pragma warning disable 0169
			static Delegate GetCloseFiscalModuleDatabaseHandler ()
			{
				if (cb_CloseFiscalModuleDatabase == null)
					cb_CloseFiscalModuleDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseFiscalModuleDatabase));
				return cb_CloseFiscalModuleDatabase;
			}

			static int n_CloseFiscalModuleDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseFiscalModuleDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='CloseFiscalModuleDatabase' and count(parameter)=0]"
			[Register ("CloseFiscalModuleDatabase", "()I", "GetCloseFiscalModuleDatabaseHandler")]
			public virtual unsafe int CloseFiscalModuleDatabase ()
			{
				const string __id = "CloseFiscalModuleDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DownloadFile_arrayBI;
#pragma warning disable 0169
			static Delegate GetDownloadFile_arrayBIHandler ()
			{
				if (cb_DownloadFile_arrayBI == null)
					cb_DownloadFile_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_DownloadFile_arrayBI));
				return cb_DownloadFile_arrayBI;
			}

			static int n_DownloadFile_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_content, int contentlength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var content = (byte[]?) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DownloadFile (content, contentlength);
				if (content != null)
					JNIEnv.CopyArray (content, native_content);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='DownloadFile' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("DownloadFile", "([BI)I", "GetDownloadFile_arrayBIHandler")]
			public virtual unsafe int DownloadFile (byte[]? content, int contentlength)
			{
				const string __id = "DownloadFile.([BI)I";
				IntPtr native_content = JNIEnv.NewArray (content);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_content);
					__args [1] = new JniArgumentValue (contentlength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (content != null) {
						JNIEnv.CopyArray (native_content, content);
						JNIEnv.DeleteLocalRef (native_content);
					}
					global::System.GC.KeepAlive (content);
				}
			}

			static Delegate? cb_DownloadServer_arrayBI;
#pragma warning disable 0169
			static Delegate GetDownloadServer_arrayBIHandler ()
			{
				if (cb_DownloadServer_arrayBI == null)
					cb_DownloadServer_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_DownloadServer_arrayBI));
				return cb_DownloadServer_arrayBI;
			}

			static int n_DownloadServer_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, int filenamelength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var filename = (byte[]?) JNIEnv.GetArray (native_filename, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DownloadServer (filename, filenamelength);
				if (filename != null)
					JNIEnv.CopyArray (filename, native_filename);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='DownloadServer' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("DownloadServer", "([BI)I", "GetDownloadServer_arrayBIHandler")]
			public virtual unsafe int DownloadServer (byte[]? filename, int filenamelength)
			{
				const string __id = "DownloadServer.([BI)I";
				IntPtr native_filename = JNIEnv.NewArray (filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_filename);
					__args [1] = new JniArgumentValue (filenamelength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (filename != null) {
						JNIEnv.CopyArray (native_filename, filename);
						JNIEnv.DeleteLocalRef (native_filename);
					}
					global::System.GC.KeepAlive (filename);
				}
			}

			static Delegate? cb_FiscalModulePowerOff;
#pragma warning disable 0169
			static Delegate GetFiscalModulePowerOffHandler ()
			{
				if (cb_FiscalModulePowerOff == null)
					cb_FiscalModulePowerOff = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalModulePowerOff));
				return cb_FiscalModulePowerOff;
			}

			static int n_FiscalModulePowerOff (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalModulePowerOff ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='FiscalModulePowerOff' and count(parameter)=0]"
			[Register ("FiscalModulePowerOff", "()I", "GetFiscalModulePowerOffHandler")]
			public virtual unsafe int FiscalModulePowerOff ()
			{
				const string __id = "FiscalModulePowerOff.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_FiscalModulePowerOn;
#pragma warning disable 0169
			static Delegate GetFiscalModulePowerOnHandler ()
			{
				if (cb_FiscalModulePowerOn == null)
					cb_FiscalModulePowerOn = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalModulePowerOn));
				return cb_FiscalModulePowerOn;
			}

			static int n_FiscalModulePowerOn (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalModulePowerOn ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='FiscalModulePowerOn' and count(parameter)=0]"
			[Register ("FiscalModulePowerOn", "()I", "GetFiscalModulePowerOnHandler")]
			public virtual unsafe int FiscalModulePowerOn ()
			{
				const string __id = "FiscalModulePowerOn.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_GetFaxContentById_J;
#pragma warning disable 0169
			static Delegate GetGetFaxContentById_JHandler ()
			{
				if (cb_GetFaxContentById_J == null)
					cb_GetFaxContentById_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_L (n_GetFaxContentById_J));
				return cb_GetFaxContentById_J;
			}

			static IntPtr n_GetFaxContentById_J (IntPtr jnienv, IntPtr native__this, long id)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.GetFaxContentById (id));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFaxContentById' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("GetFaxContentById", "(J)Ljava/lang/String;", "GetGetFaxContentById_JHandler")]
			public virtual unsafe string? GetFaxContentById (long id)
			{
				const string __id = "GetFaxContentById.(J)Ljava/lang/String;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (id);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_GetFaxIdsByDate_J;
#pragma warning disable 0169
			static Delegate GetGetFaxIdsByDate_JHandler ()
			{
				if (cb_GetFaxIdsByDate_J == null)
					cb_GetFaxIdsByDate_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_L (n_GetFaxIdsByDate_J));
				return cb_GetFaxIdsByDate_J;
			}

			static IntPtr n_GetFaxIdsByDate_J (IntPtr jnienv, IntPtr native__this, long datatime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetFaxIdsByDate (datatime));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFaxIdsByDate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("GetFaxIdsByDate", "(J)[J", "GetGetFaxIdsByDate_JHandler")]
			public virtual unsafe long[]? GetFaxIdsByDate (long datatime)
			{
				const string __id = "GetFaxIdsByDate.(J)[J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (datatime);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (long[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
				} finally {
				}
			}

			static Delegate? cb_GetFaxMessage_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetFaxMessage_JLjava_lang_String_Handler ()
			{
				if (cb_GetFaxMessage_JLjava_lang_String_ == null)
					cb_GetFaxMessage_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJL_Z (n_GetFaxMessage_JLjava_lang_String_));
				return cb_GetFaxMessage_JLjava_lang_String_;
			}

			static bool n_GetFaxMessage_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long datatime, IntPtr native_filename)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GetFaxMessage (datatime, filename);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFaxMessage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("GetFaxMessage", "(JLjava/lang/String;)Z", "GetGetFaxMessage_JLjava_lang_String_Handler")]
			public virtual unsafe bool GetFaxMessage (long datatime, string? filename)
			{
				const string __id = "GetFaxMessage.(JLjava/lang/String;)Z";
				IntPtr native_filename = JNIEnv.NewString ((string?)filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (datatime);
					__args [1] = new JniArgumentValue (native_filename);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

			static Delegate? cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_Handler ()
			{
				if (cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ == null)
					cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJLL_L (n_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_));
				return cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_;
			}

			static IntPtr n_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long datatime, long endtime, IntPtr native_daynumber, IntPtr native_datetime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var daynumber = (byte[]?) JNIEnv.GetArray (native_daynumber, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var datetime = (string[]?) JNIEnv.GetArray (native_datetime, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.NewArray (__this.GetFaxMessageDayNumber (datatime, endtime, daynumber, datetime));
				if (daynumber != null)
					JNIEnv.CopyArray (daynumber, native_daynumber);
				if (datetime != null)
					JNIEnv.CopyArray (datetime, native_datetime);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFaxMessageDayNumber' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String[]']]"
			[Register ("GetFaxMessageDayNumber", "(JJ[B[Ljava/lang/String;)[B", "GetGetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_Handler")]
			public virtual unsafe byte[]? GetFaxMessageDayNumber (long datatime, long endtime, byte[]? daynumber, string[]? datetime)
			{
				const string __id = "GetFaxMessageDayNumber.(JJ[B[Ljava/lang/String;)[B";
				IntPtr native_daynumber = JNIEnv.NewArray (daynumber);
				IntPtr native_datetime = JNIEnv.NewArray (datetime);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (datatime);
					__args [1] = new JniArgumentValue (endtime);
					__args [2] = new JniArgumentValue (native_daynumber);
					__args [3] = new JniArgumentValue (native_datetime);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (daynumber != null) {
						JNIEnv.CopyArray (native_daynumber, daynumber);
						JNIEnv.DeleteLocalRef (native_daynumber);
					}
					if (datetime != null) {
						JNIEnv.CopyArray (native_datetime, datetime);
						JNIEnv.DeleteLocalRef (native_datetime);
					}
					global::System.GC.KeepAlive (daynumber);
					global::System.GC.KeepAlive (datetime);
				}
			}

			static Delegate? cb_GetFaxVersion_arrayB;
#pragma warning disable 0169
			static Delegate GetGetFaxVersion_arrayBHandler ()
			{
				if (cb_GetFaxVersion_arrayB == null)
					cb_GetFaxVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_GetFaxVersion_arrayB));
				return cb_GetFaxVersion_arrayB;
			}

			static bool n_GetFaxVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_Version)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Version = (byte[]?) JNIEnv.GetArray (native_Version, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.GetFaxVersion (Version);
				if (Version != null)
					JNIEnv.CopyArray (Version, native_Version);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFaxVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFaxVersion", "([B)Z", "GetGetFaxVersion_arrayBHandler")]
			public virtual unsafe bool GetFaxVersion (byte[]? Version)
			{
				const string __id = "GetFaxVersion.([B)Z";
				IntPtr native_Version = JNIEnv.NewArray (Version);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_Version);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					if (Version != null) {
						JNIEnv.CopyArray (native_Version, Version);
						JNIEnv.DeleteLocalRef (native_Version);
					}
					global::System.GC.KeepAlive (Version);
				}
			}

			static Delegate? cb_GetFiscalModuleDataById_IarrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleDataById_IarrayBHandler ()
			{
				if (cb_GetFiscalModuleDataById_IarrayB == null)
					cb_GetFiscalModuleDataById_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_GetFiscalModuleDataById_IarrayB));
				return cb_GetFiscalModuleDataById_IarrayB;
			}

			static int n_GetFiscalModuleDataById_IarrayB (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_datastring)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var datastring = (byte[]?) JNIEnv.GetArray (native_datastring, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleDataById (index, datastring);
				if (datastring != null)
					JNIEnv.CopyArray (datastring, native_datastring);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFiscalModuleDataById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("GetFiscalModuleDataById", "(I[B)I", "GetGetFiscalModuleDataById_IarrayBHandler")]
			public virtual unsafe int GetFiscalModuleDataById (int index, byte[]? datastring)
			{
				const string __id = "GetFiscalModuleDataById.(I[B)I";
				IntPtr native_datastring = JNIEnv.NewArray (datastring);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (native_datastring);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (datastring != null) {
						JNIEnv.CopyArray (native_datastring, datastring);
						JNIEnv.DeleteLocalRef (native_datastring);
					}
					global::System.GC.KeepAlive (datastring);
				}
			}

			static Delegate? cb_GetFiscalModuleHardwareVersion_arrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleHardwareVersion_arrayBHandler ()
			{
				if (cb_GetFiscalModuleHardwareVersion_arrayB == null)
					cb_GetFiscalModuleHardwareVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFiscalModuleHardwareVersion_arrayB));
				return cb_GetFiscalModuleHardwareVersion_arrayB;
			}

			static int n_GetFiscalModuleHardwareVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_datastring)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var datastring = (byte[]?) JNIEnv.GetArray (native_datastring, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleHardwareVersion (datastring);
				if (datastring != null)
					JNIEnv.CopyArray (datastring, native_datastring);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFiscalModuleHardwareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFiscalModuleHardwareVersion", "([B)I", "GetGetFiscalModuleHardwareVersion_arrayBHandler")]
			public virtual unsafe int GetFiscalModuleHardwareVersion (byte[]? datastring)
			{
				const string __id = "GetFiscalModuleHardwareVersion.([B)I";
				IntPtr native_datastring = JNIEnv.NewArray (datastring);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_datastring);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (datastring != null) {
						JNIEnv.CopyArray (native_datastring, datastring);
						JNIEnv.DeleteLocalRef (native_datastring);
					}
					global::System.GC.KeepAlive (datastring);
				}
			}

			static Delegate? cb_GetFiscalModuleIds_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleIds_IIIarrayBHandler ()
			{
				if (cb_GetFiscalModuleIds_IIIarrayB == null)
					cb_GetFiscalModuleIds_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_GetFiscalModuleIds_IIIarrayB));
				return cb_GetFiscalModuleIds_IIIarrayB;
			}

			static int n_GetFiscalModuleIds_IIIarrayB (IntPtr jnienv, IntPtr native__this, int startid, int endid, int count, IntPtr native_datastring)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var datastring = (byte[]?) JNIEnv.GetArray (native_datastring, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleIds (startid, endid, count, datastring);
				if (datastring != null)
					JNIEnv.CopyArray (datastring, native_datastring);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFiscalModuleIds' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("GetFiscalModuleIds", "(III[B)I", "GetGetFiscalModuleIds_IIIarrayBHandler")]
			public virtual unsafe int GetFiscalModuleIds (int startid, int endid, int count, byte[]? datastring)
			{
				const string __id = "GetFiscalModuleIds.(III[B)I";
				IntPtr native_datastring = JNIEnv.NewArray (datastring);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (startid);
					__args [1] = new JniArgumentValue (endid);
					__args [2] = new JniArgumentValue (count);
					__args [3] = new JniArgumentValue (native_datastring);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (datastring != null) {
						JNIEnv.CopyArray (native_datastring, datastring);
						JNIEnv.DeleteLocalRef (native_datastring);
					}
					global::System.GC.KeepAlive (datastring);
				}
			}

			static Delegate? cb_GetFiscalModuleMkey_JI;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleMkey_JIHandler ()
			{
				if (cb_GetFiscalModuleMkey_JI == null)
					cb_GetFiscalModuleMkey_JI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJI_I (n_GetFiscalModuleMkey_JI));
				return cb_GetFiscalModuleMkey_JI;
			}

			static int n_GetFiscalModuleMkey_JI (IntPtr jnienv, IntPtr native__this, long datetime, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GetFiscalModuleMkey (datetime, index);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFiscalModuleMkey' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
			[Register ("GetFiscalModuleMkey", "(JI)I", "GetGetFiscalModuleMkey_JIHandler")]
			public virtual unsafe int GetFiscalModuleMkey (long datetime, int index)
			{
				const string __id = "GetFiscalModuleMkey.(JI)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (datetime);
					__args [1] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_GetFiscalModuleSoftWareVersion_arrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleSoftWareVersion_arrayBHandler ()
			{
				if (cb_GetFiscalModuleSoftWareVersion_arrayB == null)
					cb_GetFiscalModuleSoftWareVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFiscalModuleSoftWareVersion_arrayB));
				return cb_GetFiscalModuleSoftWareVersion_arrayB;
			}

			static int n_GetFiscalModuleSoftWareVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_datastring)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var datastring = (byte[]?) JNIEnv.GetArray (native_datastring, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleSoftWareVersion (datastring);
				if (datastring != null)
					JNIEnv.CopyArray (datastring, native_datastring);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='GetFiscalModuleSoftWareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFiscalModuleSoftWareVersion", "([B)I", "GetGetFiscalModuleSoftWareVersion_arrayBHandler")]
			public virtual unsafe int GetFiscalModuleSoftWareVersion (byte[]? datastring)
			{
				const string __id = "GetFiscalModuleSoftWareVersion.([B)I";
				IntPtr native_datastring = JNIEnv.NewArray (datastring);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_datastring);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (datastring != null) {
						JNIEnv.CopyArray (native_datastring, datastring);
						JNIEnv.DeleteLocalRef (native_datastring);
					}
					global::System.GC.KeepAlive (datastring);
				}
			}

			static Delegate? cb_OpenFiscalModuleDatabase;
#pragma warning disable 0169
			static Delegate GetOpenFiscalModuleDatabaseHandler ()
			{
				if (cb_OpenFiscalModuleDatabase == null)
					cb_OpenFiscalModuleDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenFiscalModuleDatabase));
				return cb_OpenFiscalModuleDatabase;
			}

			static int n_OpenFiscalModuleDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.OpenFiscalModuleDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='OpenFiscalModuleDatabase' and count(parameter)=0]"
			[Register ("OpenFiscalModuleDatabase", "()I", "GetOpenFiscalModuleDatabaseHandler")]
			public virtual unsafe int OpenFiscalModuleDatabase ()
			{
				const string __id = "OpenFiscalModuleDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SysGetSN_arrayB;
#pragma warning disable 0169
			static Delegate GetSysGetSN_arrayBHandler ()
			{
				if (cb_SysGetSN_arrayB == null)
					cb_SysGetSN_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SysGetSN_arrayB));
				return cb_SysGetSN_arrayB;
			}

			static int n_SysGetSN_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_sn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var sn = (byte[]?) JNIEnv.GetArray (native_sn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SysGetSN (sn);
				if (sn != null)
					JNIEnv.CopyArray (sn, native_sn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='SysGetSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("SysGetSN", "([B)I", "GetSysGetSN_arrayBHandler")]
			public virtual unsafe int SysGetSN (byte[]? sn)
			{
				const string __id = "SysGetSN.([B)I";
				IntPtr native_sn = JNIEnv.NewArray (sn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_sn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (sn != null) {
						JNIEnv.CopyArray (native_sn, sn);
						JNIEnv.DeleteLocalRef (native_sn);
					}
					global::System.GC.KeepAlive (sn);
				}
			}

			static Delegate? cb_WriteFiscalOnly_IarrayBJ;
#pragma warning disable 0169
			static Delegate GetWriteFiscalOnly_IarrayBJHandler ()
			{
				if (cb_WriteFiscalOnly_IarrayBJ == null)
					cb_WriteFiscalOnly_IarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILJ_I (n_WriteFiscalOnly_IarrayBJ));
				return cb_WriteFiscalOnly_IarrayBJ;
			}

			static int n_WriteFiscalOnly_IarrayBJ (IntPtr jnienv, IntPtr native__this, int id, IntPtr native_datastring, long datalength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var datastring = (byte[]?) JNIEnv.GetArray (native_datastring, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteFiscalOnly (id, datastring, datalength);
				if (datastring != null)
					JNIEnv.CopyArray (datastring, native_datastring);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='WriteFiscalOnly' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("WriteFiscalOnly", "(I[BJ)I", "GetWriteFiscalOnly_IarrayBJHandler")]
			public virtual unsafe int WriteFiscalOnly (int id, byte[]? datastring, long datalength)
			{
				const string __id = "WriteFiscalOnly.(I[BJ)I";
				IntPtr native_datastring = JNIEnv.NewArray (datastring);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (id);
					__args [1] = new JniArgumentValue (native_datastring);
					__args [2] = new JniArgumentValue (datalength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (datastring != null) {
						JNIEnv.CopyArray (native_datastring, datastring);
						JNIEnv.DeleteLocalRef (native_datastring);
					}
					global::System.GC.KeepAlive (datastring);
				}
			}

			static Delegate? cb_WriteWormOnly_JarrayBJ;
#pragma warning disable 0169
			static Delegate GetWriteWormOnly_JarrayBJHandler ()
			{
				if (cb_WriteWormOnly_JarrayBJ == null)
					cb_WriteWormOnly_JarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJLJ_J (n_WriteWormOnly_JarrayBJ));
				return cb_WriteWormOnly_JarrayBJ;
			}

			static long n_WriteWormOnly_JarrayBJ (IntPtr jnienv, IntPtr native__this, long datetime, IntPtr native_datastring, long datalength)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var datastring = (byte[]?) JNIEnv.GetArray (native_datastring, JniHandleOwnership.DoNotTransfer, typeof (byte));
				long __ret = __this.WriteWormOnly (datetime, datastring, datalength);
				if (datastring != null)
					JNIEnv.CopyArray (datastring, native_datastring);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='WriteWormOnly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("WriteWormOnly", "(J[BJ)J", "GetWriteWormOnly_JarrayBJHandler")]
			public virtual unsafe long WriteWormOnly (long datetime, byte[]? datastring, long datalength)
			{
				const string __id = "WriteWormOnly.(J[BJ)J";
				IntPtr native_datastring = JNIEnv.NewArray (datastring);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (datetime);
					__args [1] = new JniArgumentValue (native_datastring);
					__args [2] = new JniArgumentValue (datalength);
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
					return __rm;
				} finally {
					if (datastring != null) {
						JNIEnv.CopyArray (native_datastring, datastring);
						JNIEnv.DeleteLocalRef (native_datastring);
					}
					global::System.GC.KeepAlive (datastring);
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
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_basicTypes_IJZFDLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBasicTypes_IJZFDLjava_lang_String_Handler ()
			{
				if (cb_basicTypes_IJZFDLjava_lang_String_ == null)
					cb_basicTypes_IJZFDLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIJZFDL_V (n_BasicTypes_IJZFDLjava_lang_String_));
				return cb_basicTypes_IJZFDLjava_lang_String_;
			}

			static void n_BasicTypes_IJZFDLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int anInt, long aLong, bool aBoolean, float aFloat, double aDouble, IntPtr native_aString)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aString = JNIEnv.GetString (native_aString, JniHandleOwnership.DoNotTransfer);
				__this.BasicTypes (anInt, aLong, aBoolean, aFloat, aDouble, aString);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='basicTypes' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='float'] and parameter[5][@type='double'] and parameter[6][@type='java.lang.String']]"
			[Register ("basicTypes", "(IJZFDLjava/lang/String;)V", "GetBasicTypes_IJZFDLjava_lang_String_Handler")]
			public virtual unsafe void BasicTypes (int anInt, long aLong, bool aBoolean, float aFloat, double aDouble, string? aString)
			{
				const string __id = "basicTypes.(IJZFDLjava/lang/String;)V";
				IntPtr native_aString = JNIEnv.NewString ((string?)aString);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (anInt);
					__args [1] = new JniArgumentValue (aLong);
					__args [2] = new JniArgumentValue (aBoolean);
					__args [3] = new JniArgumentValue (aFloat);
					__args [4] = new JniArgumentValue (aDouble);
					__args [5] = new JniArgumentValue (native_aString);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_aString);
				}
			}

			static Delegate? cb_databaseRecordCheck;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordCheckHandler ()
			{
				if (cb_databaseRecordCheck == null)
					cb_databaseRecordCheck = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordCheck));
				return cb_databaseRecordCheck;
			}

			static int n_DatabaseRecordCheck (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DatabaseRecordCheck ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='databaseRecordCheck' and count(parameter)=0]"
			[Register ("databaseRecordCheck", "()I", "GetDatabaseRecordCheckHandler")]
			public virtual unsafe int DatabaseRecordCheck ()
			{
				const string __id = "databaseRecordCheck.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_databaseRecordClose;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordCloseHandler ()
			{
				if (cb_databaseRecordClose == null)
					cb_databaseRecordClose = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordClose));
				return cb_databaseRecordClose;
			}

			static int n_DatabaseRecordClose (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DatabaseRecordClose ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='databaseRecordClose' and count(parameter)=0]"
			[Register ("databaseRecordClose", "()I", "GetDatabaseRecordCloseHandler")]
			public virtual unsafe int DatabaseRecordClose ()
			{
				const string __id = "databaseRecordClose.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_databaseRecordOpen;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordOpenHandler ()
			{
				if (cb_databaseRecordOpen == null)
					cb_databaseRecordOpen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordOpen));
				return cb_databaseRecordOpen;
			}

			static int n_DatabaseRecordOpen (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DatabaseRecordOpen ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='databaseRecordOpen' and count(parameter)=0]"
			[Register ("databaseRecordOpen", "()I", "GetDatabaseRecordOpenHandler")]
			public virtual unsafe int DatabaseRecordOpen ()
			{
				const string __id = "databaseRecordOpen.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_databaseRecordRead_IarrayIarrayBarrayI;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordRead_IarrayIarrayBarrayIHandler ()
			{
				if (cb_databaseRecordRead_IarrayIarrayBarrayI == null)
					cb_databaseRecordRead_IarrayIarrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_DatabaseRecordRead_IarrayIarrayBarrayI));
				return cb_databaseRecordRead_IarrayIarrayBarrayI;
			}

			static int n_DatabaseRecordRead_IarrayIarrayBarrayI (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_lenOfPkey, IntPtr native_buf, IntPtr native_lenOfBuf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var lenOfPkey = (int[]?) JNIEnv.GetArray (native_lenOfPkey, JniHandleOwnership.DoNotTransfer, typeof (int));
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var lenOfBuf = (int[]?) JNIEnv.GetArray (native_lenOfBuf, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.DatabaseRecordRead (index, lenOfPkey, buf, lenOfBuf);
				if (lenOfPkey != null)
					JNIEnv.CopyArray (lenOfPkey, native_lenOfPkey);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				if (lenOfBuf != null)
					JNIEnv.CopyArray (lenOfBuf, native_lenOfBuf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='databaseRecordRead' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
			[Register ("databaseRecordRead", "(I[I[B[I)I", "GetDatabaseRecordRead_IarrayIarrayBarrayIHandler")]
			public virtual unsafe int DatabaseRecordRead (int index, int[]? lenOfPkey, byte[]? buf, int[]? lenOfBuf)
			{
				const string __id = "databaseRecordRead.(I[I[B[I)I";
				IntPtr native_lenOfPkey = JNIEnv.NewArray (lenOfPkey);
				IntPtr native_buf = JNIEnv.NewArray (buf);
				IntPtr native_lenOfBuf = JNIEnv.NewArray (lenOfBuf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (native_lenOfPkey);
					__args [2] = new JniArgumentValue (native_buf);
					__args [3] = new JniArgumentValue (native_lenOfBuf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (lenOfPkey != null) {
						JNIEnv.CopyArray (native_lenOfPkey, lenOfPkey);
						JNIEnv.DeleteLocalRef (native_lenOfPkey);
					}
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					if (lenOfBuf != null) {
						JNIEnv.CopyArray (native_lenOfBuf, lenOfBuf);
						JNIEnv.DeleteLocalRef (native_lenOfBuf);
					}
					global::System.GC.KeepAlive (lenOfPkey);
					global::System.GC.KeepAlive (buf);
					global::System.GC.KeepAlive (lenOfBuf);
				}
			}

			static Delegate? cb_getreceipt_JJLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetreceipt_JJLjava_lang_String_Handler ()
			{
				if (cb_getreceipt_JJLjava_lang_String_ == null)
					cb_getreceipt_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJL_Z (n_Getreceipt_JJLjava_lang_String_));
				return cb_getreceipt_JJLjava_lang_String_;
			}

			static bool n_Getreceipt_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long startdate, long enddate, IntPtr native_filename)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Getreceipt (startdate, enddate, filename);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Default']/method[@name='getreceipt' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
			[Register ("getreceipt", "(JJLjava/lang/String;)Z", "GetGetreceipt_JJLjava_lang_String_Handler")]
			public virtual unsafe bool Getreceipt (long startdate, long enddate, string? filename)
			{
				const string __id = "getreceipt.(JJLjava/lang/String;)Z";
				IntPtr native_filename = JNIEnv.NewString ((string?)filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (startdate);
					__args [1] = new JniArgumentValue (enddate);
					__args [2] = new JniArgumentValue (native_filename);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']"
		[global::Android.Runtime.Register ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface {
			static readonly JniPeerMembers _members = new XAPeerMembers ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/constructor[@name='IFiscalModuleAidlInterface.Stub' and count(parameter)=0]"
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

			public static unsafe global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lfiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface;", "")]
				get {
					const string __id = "getDefaultImpl.()Lfiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lfiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface;", "")]
			public static unsafe global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lfiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='fiscal.vanstone.com.fiscalserver.IFiscalModuleAidlInterface']]"
			[Register ("setDefaultImpl", "(Lfiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface? impl)
			{
				const string __id = "setDefaultImpl.(Lfiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_AuthChallenge_arrayBI;
#pragma warning disable 0169
			static Delegate GetAuthChallenge_arrayBIHandler ()
			{
				if (cb_AuthChallenge_arrayBI == null)
					cb_AuthChallenge_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_AuthChallenge_arrayBI));
				return cb_AuthChallenge_arrayBI;
			}

			static int n_AuthChallenge_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.AuthChallenge (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='AuthChallenge' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("AuthChallenge", "([BI)I", "GetAuthChallenge_arrayBIHandler")]
			public abstract int AuthChallenge (byte[]? p0, int p1);

			static Delegate? cb_Authexec_arrayBI;
#pragma warning disable 0169
			static Delegate GetAuthexec_arrayBIHandler ()
			{
				if (cb_Authexec_arrayBI == null)
					cb_Authexec_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Authexec_arrayBI));
				return cb_Authexec_arrayBI;
			}

			static int n_Authexec_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Authexec (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='Authexec' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Authexec", "([BI)I", "GetAuthexec_arrayBIHandler")]
			public abstract int Authexec (byte[]? p0, int p1);

			static Delegate? cb_Authrequest;
#pragma warning disable 0169
			static Delegate GetAuthrequestHandler ()
			{
				if (cb_Authrequest == null)
					cb_Authrequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Authrequest));
				return cb_Authrequest;
			}

			static int n_Authrequest (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Authrequest ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='Authrequest' and count(parameter)=0]"
			[Register ("Authrequest", "()I", "GetAuthrequestHandler")]
			public abstract int Authrequest ();

			static Delegate? cb_BindExec_arrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetBindExec_arrayBIarrayBIHandler ()
			{
				if (cb_BindExec_arrayBIarrayBI == null)
					cb_BindExec_arrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_I (n_BindExec_arrayBIarrayBI));
				return cb_BindExec_arrayBIarrayBI;
			}

			static int n_BindExec_arrayBIarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.BindExec (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindExec' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("BindExec", "([BI[BI)I", "GetBindExec_arrayBIarrayBIHandler")]
			public abstract int BindExec (byte[]? p0, int p1, byte[]? p2, int p3);

			static Delegate? cb_BindQuery;
#pragma warning disable 0169
			static Delegate GetBindQueryHandler ()
			{
				if (cb_BindQuery == null)
					cb_BindQuery = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_BindQuery));
				return cb_BindQuery;
			}

			static int n_BindQuery (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.BindQuery ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindQuery' and count(parameter)=0]"
			[Register ("BindQuery", "()I", "GetBindQueryHandler")]
			public abstract int BindQuery ();

			static Delegate? cb_BindRequest;
#pragma warning disable 0169
			static Delegate GetBindRequestHandler ()
			{
				if (cb_BindRequest == null)
					cb_BindRequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_BindRequest));
				return cb_BindRequest;
			}

			static int n_BindRequest (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.BindRequest ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindRequest' and count(parameter)=0]"
			[Register ("BindRequest", "()I", "GetBindRequestHandler")]
			public abstract int BindRequest ();

			static Delegate? cb_ClearFiscalDatabase;
#pragma warning disable 0169
			static Delegate GetClearFiscalDatabaseHandler ()
			{
				if (cb_ClearFiscalDatabase == null)
					cb_ClearFiscalDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ClearFiscalDatabase));
				return cb_ClearFiscalDatabase;
			}

			static int n_ClearFiscalDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ClearFiscalDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='ClearFiscalDatabase' and count(parameter)=0]"
			[Register ("ClearFiscalDatabase", "()I", "GetClearFiscalDatabaseHandler")]
			public abstract int ClearFiscalDatabase ();

			static Delegate? cb_ClearWormDatabase;
#pragma warning disable 0169
			static Delegate GetClearWormDatabaseHandler ()
			{
				if (cb_ClearWormDatabase == null)
					cb_ClearWormDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ClearWormDatabase));
				return cb_ClearWormDatabase;
			}

			static int n_ClearWormDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ClearWormDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='ClearWormDatabase' and count(parameter)=0]"
			[Register ("ClearWormDatabase", "()I", "GetClearWormDatabaseHandler")]
			public abstract int ClearWormDatabase ();

			static Delegate? cb_CloseFiscalModuleDatabase;
#pragma warning disable 0169
			static Delegate GetCloseFiscalModuleDatabaseHandler ()
			{
				if (cb_CloseFiscalModuleDatabase == null)
					cb_CloseFiscalModuleDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseFiscalModuleDatabase));
				return cb_CloseFiscalModuleDatabase;
			}

			static int n_CloseFiscalModuleDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CloseFiscalModuleDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='CloseFiscalModuleDatabase' and count(parameter)=0]"
			[Register ("CloseFiscalModuleDatabase", "()I", "GetCloseFiscalModuleDatabaseHandler")]
			public abstract int CloseFiscalModuleDatabase ();

			static Delegate? cb_DownloadFile_arrayBI;
#pragma warning disable 0169
			static Delegate GetDownloadFile_arrayBIHandler ()
			{
				if (cb_DownloadFile_arrayBI == null)
					cb_DownloadFile_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_DownloadFile_arrayBI));
				return cb_DownloadFile_arrayBI;
			}

			static int n_DownloadFile_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DownloadFile (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='DownloadFile' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("DownloadFile", "([BI)I", "GetDownloadFile_arrayBIHandler")]
			public abstract int DownloadFile (byte[]? p0, int p1);

			static Delegate? cb_DownloadServer_arrayBI;
#pragma warning disable 0169
			static Delegate GetDownloadServer_arrayBIHandler ()
			{
				if (cb_DownloadServer_arrayBI == null)
					cb_DownloadServer_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_DownloadServer_arrayBI));
				return cb_DownloadServer_arrayBI;
			}

			static int n_DownloadServer_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DownloadServer (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='DownloadServer' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("DownloadServer", "([BI)I", "GetDownloadServer_arrayBIHandler")]
			public abstract int DownloadServer (byte[]? p0, int p1);

			static Delegate? cb_FiscalModulePowerOff;
#pragma warning disable 0169
			static Delegate GetFiscalModulePowerOffHandler ()
			{
				if (cb_FiscalModulePowerOff == null)
					cb_FiscalModulePowerOff = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalModulePowerOff));
				return cb_FiscalModulePowerOff;
			}

			static int n_FiscalModulePowerOff (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalModulePowerOff ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='FiscalModulePowerOff' and count(parameter)=0]"
			[Register ("FiscalModulePowerOff", "()I", "GetFiscalModulePowerOffHandler")]
			public abstract int FiscalModulePowerOff ();

			static Delegate? cb_FiscalModulePowerOn;
#pragma warning disable 0169
			static Delegate GetFiscalModulePowerOnHandler ()
			{
				if (cb_FiscalModulePowerOn == null)
					cb_FiscalModulePowerOn = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalModulePowerOn));
				return cb_FiscalModulePowerOn;
			}

			static int n_FiscalModulePowerOn (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalModulePowerOn ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='FiscalModulePowerOn' and count(parameter)=0]"
			[Register ("FiscalModulePowerOn", "()I", "GetFiscalModulePowerOnHandler")]
			public abstract int FiscalModulePowerOn ();

			static Delegate? cb_GetFaxContentById_J;
#pragma warning disable 0169
			static Delegate GetGetFaxContentById_JHandler ()
			{
				if (cb_GetFaxContentById_J == null)
					cb_GetFaxContentById_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_L (n_GetFaxContentById_J));
				return cb_GetFaxContentById_J;
			}

			static IntPtr n_GetFaxContentById_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.GetFaxContentById (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxContentById' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("GetFaxContentById", "(J)Ljava/lang/String;", "GetGetFaxContentById_JHandler")]
			public abstract string? GetFaxContentById (long p0);

			static Delegate? cb_GetFaxIdsByDate_J;
#pragma warning disable 0169
			static Delegate GetGetFaxIdsByDate_JHandler ()
			{
				if (cb_GetFaxIdsByDate_J == null)
					cb_GetFaxIdsByDate_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_L (n_GetFaxIdsByDate_J));
				return cb_GetFaxIdsByDate_J;
			}

			static IntPtr n_GetFaxIdsByDate_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetFaxIdsByDate (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxIdsByDate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("GetFaxIdsByDate", "(J)[J", "GetGetFaxIdsByDate_JHandler")]
			public abstract long[]? GetFaxIdsByDate (long p0);

			static Delegate? cb_GetFaxMessage_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetFaxMessage_JLjava_lang_String_Handler ()
			{
				if (cb_GetFaxMessage_JLjava_lang_String_ == null)
					cb_GetFaxMessage_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJL_Z (n_GetFaxMessage_JLjava_lang_String_));
				return cb_GetFaxMessage_JLjava_lang_String_;
			}

			static bool n_GetFaxMessage_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GetFaxMessage (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxMessage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("GetFaxMessage", "(JLjava/lang/String;)Z", "GetGetFaxMessage_JLjava_lang_String_Handler")]
			public abstract bool GetFaxMessage (long p0, string? p1);

			static Delegate? cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_Handler ()
			{
				if (cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ == null)
					cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJLL_L (n_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_));
				return cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_;
			}

			static IntPtr n_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (string[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.NewArray (__this.GetFaxMessageDayNumber (p0, p1, p2, p3));
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxMessageDayNumber' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String[]']]"
			[Register ("GetFaxMessageDayNumber", "(JJ[B[Ljava/lang/String;)[B", "GetGetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_Handler")]
			public abstract byte[]? GetFaxMessageDayNumber (long p0, long p1, byte[]? p2, string[]? p3);

			static Delegate? cb_GetFaxVersion_arrayB;
#pragma warning disable 0169
			static Delegate GetGetFaxVersion_arrayBHandler ()
			{
				if (cb_GetFaxVersion_arrayB == null)
					cb_GetFaxVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_GetFaxVersion_arrayB));
				return cb_GetFaxVersion_arrayB;
			}

			static bool n_GetFaxVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.GetFaxVersion (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFaxVersion", "([B)Z", "GetGetFaxVersion_arrayBHandler")]
			public abstract bool GetFaxVersion (byte[]? p0);

			static Delegate? cb_GetFiscalModuleDataById_IarrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleDataById_IarrayBHandler ()
			{
				if (cb_GetFiscalModuleDataById_IarrayB == null)
					cb_GetFiscalModuleDataById_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_GetFiscalModuleDataById_IarrayB));
				return cb_GetFiscalModuleDataById_IarrayB;
			}

			static int n_GetFiscalModuleDataById_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleDataById (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleDataById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("GetFiscalModuleDataById", "(I[B)I", "GetGetFiscalModuleDataById_IarrayBHandler")]
			public abstract int GetFiscalModuleDataById (int p0, byte[]? p1);

			static Delegate? cb_GetFiscalModuleHardwareVersion_arrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleHardwareVersion_arrayBHandler ()
			{
				if (cb_GetFiscalModuleHardwareVersion_arrayB == null)
					cb_GetFiscalModuleHardwareVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFiscalModuleHardwareVersion_arrayB));
				return cb_GetFiscalModuleHardwareVersion_arrayB;
			}

			static int n_GetFiscalModuleHardwareVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleHardwareVersion (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleHardwareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFiscalModuleHardwareVersion", "([B)I", "GetGetFiscalModuleHardwareVersion_arrayBHandler")]
			public abstract int GetFiscalModuleHardwareVersion (byte[]? p0);

			static Delegate? cb_GetFiscalModuleIds_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleIds_IIIarrayBHandler ()
			{
				if (cb_GetFiscalModuleIds_IIIarrayB == null)
					cb_GetFiscalModuleIds_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_GetFiscalModuleIds_IIIarrayB));
				return cb_GetFiscalModuleIds_IIIarrayB;
			}

			static int n_GetFiscalModuleIds_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleIds (p0, p1, p2, p3);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleIds' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("GetFiscalModuleIds", "(III[B)I", "GetGetFiscalModuleIds_IIIarrayBHandler")]
			public abstract int GetFiscalModuleIds (int p0, int p1, int p2, byte[]? p3);

			static Delegate? cb_GetFiscalModuleMkey_JI;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleMkey_JIHandler ()
			{
				if (cb_GetFiscalModuleMkey_JI == null)
					cb_GetFiscalModuleMkey_JI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJI_I (n_GetFiscalModuleMkey_JI));
				return cb_GetFiscalModuleMkey_JI;
			}

			static int n_GetFiscalModuleMkey_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GetFiscalModuleMkey (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleMkey' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
			[Register ("GetFiscalModuleMkey", "(JI)I", "GetGetFiscalModuleMkey_JIHandler")]
			public abstract int GetFiscalModuleMkey (long p0, int p1);

			static Delegate? cb_GetFiscalModuleSoftWareVersion_arrayB;
#pragma warning disable 0169
			static Delegate GetGetFiscalModuleSoftWareVersion_arrayBHandler ()
			{
				if (cb_GetFiscalModuleSoftWareVersion_arrayB == null)
					cb_GetFiscalModuleSoftWareVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFiscalModuleSoftWareVersion_arrayB));
				return cb_GetFiscalModuleSoftWareVersion_arrayB;
			}

			static int n_GetFiscalModuleSoftWareVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetFiscalModuleSoftWareVersion (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleSoftWareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFiscalModuleSoftWareVersion", "([B)I", "GetGetFiscalModuleSoftWareVersion_arrayBHandler")]
			public abstract int GetFiscalModuleSoftWareVersion (byte[]? p0);

			static Delegate? cb_OpenFiscalModuleDatabase;
#pragma warning disable 0169
			static Delegate GetOpenFiscalModuleDatabaseHandler ()
			{
				if (cb_OpenFiscalModuleDatabase == null)
					cb_OpenFiscalModuleDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenFiscalModuleDatabase));
				return cb_OpenFiscalModuleDatabase;
			}

			static int n_OpenFiscalModuleDatabase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.OpenFiscalModuleDatabase ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='OpenFiscalModuleDatabase' and count(parameter)=0]"
			[Register ("OpenFiscalModuleDatabase", "()I", "GetOpenFiscalModuleDatabaseHandler")]
			public abstract int OpenFiscalModuleDatabase ();

			static Delegate? cb_SysGetSN_arrayB;
#pragma warning disable 0169
			static Delegate GetSysGetSN_arrayBHandler ()
			{
				if (cb_SysGetSN_arrayB == null)
					cb_SysGetSN_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SysGetSN_arrayB));
				return cb_SysGetSN_arrayB;
			}

			static int n_SysGetSN_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SysGetSN (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='SysGetSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("SysGetSN", "([B)I", "GetSysGetSN_arrayBHandler")]
			public abstract int SysGetSN (byte[]? p0);

			static Delegate? cb_WriteFiscalOnly_IarrayBJ;
#pragma warning disable 0169
			static Delegate GetWriteFiscalOnly_IarrayBJHandler ()
			{
				if (cb_WriteFiscalOnly_IarrayBJ == null)
					cb_WriteFiscalOnly_IarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILJ_I (n_WriteFiscalOnly_IarrayBJ));
				return cb_WriteFiscalOnly_IarrayBJ;
			}

			static int n_WriteFiscalOnly_IarrayBJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, long p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteFiscalOnly (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='WriteFiscalOnly' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("WriteFiscalOnly", "(I[BJ)I", "GetWriteFiscalOnly_IarrayBJHandler")]
			public abstract int WriteFiscalOnly (int p0, byte[]? p1, long p2);

			static Delegate? cb_WriteWormOnly_JarrayBJ;
#pragma warning disable 0169
			static Delegate GetWriteWormOnly_JarrayBJHandler ()
			{
				if (cb_WriteWormOnly_JarrayBJ == null)
					cb_WriteWormOnly_JarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJLJ_J (n_WriteWormOnly_JarrayBJ));
				return cb_WriteWormOnly_JarrayBJ;
			}

			static long n_WriteWormOnly_JarrayBJ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, long p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				long __ret = __this.WriteWormOnly (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='WriteWormOnly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("WriteWormOnly", "(J[BJ)J", "GetWriteWormOnly_JarrayBJHandler")]
			public abstract long WriteWormOnly (long p0, byte[]? p1, long p2);

			static Delegate? cb_basicTypes_IJZFDLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBasicTypes_IJZFDLjava_lang_String_Handler ()
			{
				if (cb_basicTypes_IJZFDLjava_lang_String_ == null)
					cb_basicTypes_IJZFDLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIJZFDL_V (n_BasicTypes_IJZFDLjava_lang_String_));
				return cb_basicTypes_IJZFDLjava_lang_String_;
			}

			static void n_BasicTypes_IJZFDLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, long p1, bool p2, float p3, double p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
				__this.BasicTypes (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='basicTypes' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='float'] and parameter[5][@type='double'] and parameter[6][@type='java.lang.String']]"
			[Register ("basicTypes", "(IJZFDLjava/lang/String;)V", "GetBasicTypes_IJZFDLjava_lang_String_Handler")]
			public abstract void BasicTypes (int p0, long p1, bool p2, float p3, double p4, string? p5);

			static Delegate? cb_databaseRecordCheck;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordCheckHandler ()
			{
				if (cb_databaseRecordCheck == null)
					cb_databaseRecordCheck = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordCheck));
				return cb_databaseRecordCheck;
			}

			static int n_DatabaseRecordCheck (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DatabaseRecordCheck ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordCheck' and count(parameter)=0]"
			[Register ("databaseRecordCheck", "()I", "GetDatabaseRecordCheckHandler")]
			public abstract int DatabaseRecordCheck ();

			static Delegate? cb_databaseRecordClose;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordCloseHandler ()
			{
				if (cb_databaseRecordClose == null)
					cb_databaseRecordClose = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordClose));
				return cb_databaseRecordClose;
			}

			static int n_DatabaseRecordClose (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DatabaseRecordClose ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordClose' and count(parameter)=0]"
			[Register ("databaseRecordClose", "()I", "GetDatabaseRecordCloseHandler")]
			public abstract int DatabaseRecordClose ();

			static Delegate? cb_databaseRecordOpen;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordOpenHandler ()
			{
				if (cb_databaseRecordOpen == null)
					cb_databaseRecordOpen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordOpen));
				return cb_databaseRecordOpen;
			}

			static int n_DatabaseRecordOpen (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DatabaseRecordOpen ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordOpen' and count(parameter)=0]"
			[Register ("databaseRecordOpen", "()I", "GetDatabaseRecordOpenHandler")]
			public abstract int DatabaseRecordOpen ();

			static Delegate? cb_databaseRecordRead_IarrayIarrayBarrayI;
#pragma warning disable 0169
			static Delegate GetDatabaseRecordRead_IarrayIarrayBarrayIHandler ()
			{
				if (cb_databaseRecordRead_IarrayIarrayBarrayI == null)
					cb_databaseRecordRead_IarrayIarrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_DatabaseRecordRead_IarrayIarrayBarrayI));
				return cb_databaseRecordRead_IarrayIarrayBarrayI;
			}

			static int n_DatabaseRecordRead_IarrayIarrayBarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (int[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (int[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.DatabaseRecordRead (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordRead' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
			[Register ("databaseRecordRead", "(I[I[B[I)I", "GetDatabaseRecordRead_IarrayIarrayBarrayIHandler")]
			public abstract int DatabaseRecordRead (int p0, int[]? p1, byte[]? p2, int[]? p3);

			static Delegate? cb_getreceipt_JJLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetreceipt_JJLjava_lang_String_Handler ()
			{
				if (cb_getreceipt_JJLjava_lang_String_ == null)
					cb_getreceipt_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJL_Z (n_Getreceipt_JJLjava_lang_String_));
				return cb_getreceipt_JJLjava_lang_String_;
			}

			static bool n_Getreceipt_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Getreceipt (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='getreceipt' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
			[Register ("getreceipt", "(JJLjava/lang/String;)Z", "GetGetreceipt_JJLjava_lang_String_Handler")]
			public abstract bool Getreceipt (long p0, long p1, string? p2);

			static Delegate? cb_GetFreeDiskSpace;
#pragma warning disable 0169
			static Delegate GetGetFreeDiskSpaceHandler ()
			{
				if (cb_GetFreeDiskSpace == null)
					cb_GetFreeDiskSpace = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetFreeDiskSpace));
				return cb_GetFreeDiskSpace;
			}

			static long n_GetFreeDiskSpace (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FreeDiskSpace;
			}
#pragma warning restore 0169

			public abstract long FreeDiskSpace {
				// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='GetFreeDiskSpace' and count(parameter)=0]"
				[Register ("GetFreeDiskSpace", "()J", "GetGetFreeDiskSpaceHandler")]
				get; 
			}

			static Delegate? cb_GetTotalRow;
#pragma warning disable 0169
			static Delegate GetGetTotalRowHandler ()
			{
				if (cb_GetTotalRow == null)
					cb_GetTotalRow = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetTotalRow));
				return cb_GetTotalRow;
			}

			static int n_GetTotalRow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.TotalRow;
			}
#pragma warning restore 0169

			public abstract int TotalRow {
				// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='GetTotalRow' and count(parameter)=0]"
				[Register ("GetTotalRow", "()I", "GetGetTotalRowHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface$Stub", typeof (StubInvoker));

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

			public override unsafe long FreeDiskSpace {
				// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='GetFreeDiskSpace' and count(parameter)=0]"
				[Register ("GetFreeDiskSpace", "()J", "GetGetFreeDiskSpaceHandler")]
				get {
					const string __id = "GetFreeDiskSpace.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe int TotalRow {
				// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/class[@name='IFiscalModuleAidlInterface.Stub']/method[@name='GetTotalRow' and count(parameter)=0]"
				[Register ("GetTotalRow", "()I", "GetGetTotalRowHandler")]
				get {
					const string __id = "GetTotalRow.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='AuthChallenge' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("AuthChallenge", "([BI)I", "GetAuthChallenge_arrayBIHandler")]
			public override unsafe int AuthChallenge (byte[]? p0, int p1)
			{
				const string __id = "AuthChallenge.([BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='Authexec' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Authexec", "([BI)I", "GetAuthexec_arrayBIHandler")]
			public override unsafe int Authexec (byte[]? p0, int p1)
			{
				const string __id = "Authexec.([BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='Authrequest' and count(parameter)=0]"
			[Register ("Authrequest", "()I", "GetAuthrequestHandler")]
			public override unsafe int Authrequest ()
			{
				const string __id = "Authrequest.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindExec' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("BindExec", "([BI[BI)I", "GetBindExec_arrayBIarrayBIHandler")]
			public override unsafe int BindExec (byte[]? p0, int p1, byte[]? p2, int p3)
			{
				const string __id = "BindExec.([BI[BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindQuery' and count(parameter)=0]"
			[Register ("BindQuery", "()I", "GetBindQueryHandler")]
			public override unsafe int BindQuery ()
			{
				const string __id = "BindQuery.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='BindRequest' and count(parameter)=0]"
			[Register ("BindRequest", "()I", "GetBindRequestHandler")]
			public override unsafe int BindRequest ()
			{
				const string __id = "BindRequest.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='ClearFiscalDatabase' and count(parameter)=0]"
			[Register ("ClearFiscalDatabase", "()I", "GetClearFiscalDatabaseHandler")]
			public override unsafe int ClearFiscalDatabase ()
			{
				const string __id = "ClearFiscalDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='ClearWormDatabase' and count(parameter)=0]"
			[Register ("ClearWormDatabase", "()I", "GetClearWormDatabaseHandler")]
			public override unsafe int ClearWormDatabase ()
			{
				const string __id = "ClearWormDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='CloseFiscalModuleDatabase' and count(parameter)=0]"
			[Register ("CloseFiscalModuleDatabase", "()I", "GetCloseFiscalModuleDatabaseHandler")]
			public override unsafe int CloseFiscalModuleDatabase ()
			{
				const string __id = "CloseFiscalModuleDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='DownloadFile' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("DownloadFile", "([BI)I", "GetDownloadFile_arrayBIHandler")]
			public override unsafe int DownloadFile (byte[]? p0, int p1)
			{
				const string __id = "DownloadFile.([BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='DownloadServer' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("DownloadServer", "([BI)I", "GetDownloadServer_arrayBIHandler")]
			public override unsafe int DownloadServer (byte[]? p0, int p1)
			{
				const string __id = "DownloadServer.([BI)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='FiscalModulePowerOff' and count(parameter)=0]"
			[Register ("FiscalModulePowerOff", "()I", "GetFiscalModulePowerOffHandler")]
			public override unsafe int FiscalModulePowerOff ()
			{
				const string __id = "FiscalModulePowerOff.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='FiscalModulePowerOn' and count(parameter)=0]"
			[Register ("FiscalModulePowerOn", "()I", "GetFiscalModulePowerOnHandler")]
			public override unsafe int FiscalModulePowerOn ()
			{
				const string __id = "FiscalModulePowerOn.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxContentById' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("GetFaxContentById", "(J)Ljava/lang/String;", "GetGetFaxContentById_JHandler")]
			public override unsafe string? GetFaxContentById (long p0)
			{
				const string __id = "GetFaxContentById.(J)Ljava/lang/String;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxIdsByDate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("GetFaxIdsByDate", "(J)[J", "GetGetFaxIdsByDate_JHandler")]
			public override unsafe long[]? GetFaxIdsByDate (long p0)
			{
				const string __id = "GetFaxIdsByDate.(J)[J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (long[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxMessage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("GetFaxMessage", "(JLjava/lang/String;)Z", "GetGetFaxMessage_JLjava_lang_String_Handler")]
			public override unsafe bool GetFaxMessage (long p0, string? p1)
			{
				const string __id = "GetFaxMessage.(JLjava/lang/String;)Z";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxMessageDayNumber' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String[]']]"
			[Register ("GetFaxMessageDayNumber", "(JJ[B[Ljava/lang/String;)[B", "GetGetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_Handler")]
			public override unsafe byte[]? GetFaxMessageDayNumber (long p0, long p1, byte[]? p2, string[]? p3)
			{
				const string __id = "GetFaxMessageDayNumber.(JJ[B[Ljava/lang/String;)[B";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFaxVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFaxVersion", "([B)Z", "GetGetFaxVersion_arrayBHandler")]
			public override unsafe bool GetFaxVersion (byte[]? p0)
			{
				const string __id = "GetFaxVersion.([B)Z";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleDataById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("GetFiscalModuleDataById", "(I[B)I", "GetGetFiscalModuleDataById_IarrayBHandler")]
			public override unsafe int GetFiscalModuleDataById (int p0, byte[]? p1)
			{
				const string __id = "GetFiscalModuleDataById.(I[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleHardwareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFiscalModuleHardwareVersion", "([B)I", "GetGetFiscalModuleHardwareVersion_arrayBHandler")]
			public override unsafe int GetFiscalModuleHardwareVersion (byte[]? p0)
			{
				const string __id = "GetFiscalModuleHardwareVersion.([B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleIds' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("GetFiscalModuleIds", "(III[B)I", "GetGetFiscalModuleIds_IIIarrayBHandler")]
			public override unsafe int GetFiscalModuleIds (int p0, int p1, int p2, byte[]? p3)
			{
				const string __id = "GetFiscalModuleIds.(III[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleMkey' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
			[Register ("GetFiscalModuleMkey", "(JI)I", "GetGetFiscalModuleMkey_JIHandler")]
			public override unsafe int GetFiscalModuleMkey (long p0, int p1)
			{
				const string __id = "GetFiscalModuleMkey.(JI)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='GetFiscalModuleSoftWareVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("GetFiscalModuleSoftWareVersion", "([B)I", "GetGetFiscalModuleSoftWareVersion_arrayBHandler")]
			public override unsafe int GetFiscalModuleSoftWareVersion (byte[]? p0)
			{
				const string __id = "GetFiscalModuleSoftWareVersion.([B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='OpenFiscalModuleDatabase' and count(parameter)=0]"
			[Register ("OpenFiscalModuleDatabase", "()I", "GetOpenFiscalModuleDatabaseHandler")]
			public override unsafe int OpenFiscalModuleDatabase ()
			{
				const string __id = "OpenFiscalModuleDatabase.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='SysGetSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("SysGetSN", "([B)I", "GetSysGetSN_arrayBHandler")]
			public override unsafe int SysGetSN (byte[]? p0)
			{
				const string __id = "SysGetSN.([B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='WriteFiscalOnly' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("WriteFiscalOnly", "(I[BJ)I", "GetWriteFiscalOnly_IarrayBJHandler")]
			public override unsafe int WriteFiscalOnly (int p0, byte[]? p1, long p2)
			{
				const string __id = "WriteFiscalOnly.(I[BJ)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='WriteWormOnly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long']]"
			[Register ("WriteWormOnly", "(J[BJ)J", "GetWriteWormOnly_JarrayBJHandler")]
			public override unsafe long WriteWormOnly (long p0, byte[]? p1, long p2)
			{
				const string __id = "WriteWormOnly.(J[BJ)J";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='basicTypes' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='float'] and parameter[5][@type='double'] and parameter[6][@type='java.lang.String']]"
			[Register ("basicTypes", "(IJZFDLjava/lang/String;)V", "GetBasicTypes_IJZFDLjava_lang_String_Handler")]
			public override unsafe void BasicTypes (int p0, long p1, bool p2, float p3, double p4, string? p5)
			{
				const string __id = "basicTypes.(IJZFDLjava/lang/String;)V";
				IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordCheck' and count(parameter)=0]"
			[Register ("databaseRecordCheck", "()I", "GetDatabaseRecordCheckHandler")]
			public override unsafe int DatabaseRecordCheck ()
			{
				const string __id = "databaseRecordCheck.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordClose' and count(parameter)=0]"
			[Register ("databaseRecordClose", "()I", "GetDatabaseRecordCloseHandler")]
			public override unsafe int DatabaseRecordClose ()
			{
				const string __id = "databaseRecordClose.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordOpen' and count(parameter)=0]"
			[Register ("databaseRecordOpen", "()I", "GetDatabaseRecordOpenHandler")]
			public override unsafe int DatabaseRecordOpen ()
			{
				const string __id = "databaseRecordOpen.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='databaseRecordRead' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
			[Register ("databaseRecordRead", "(I[I[B[I)I", "GetDatabaseRecordRead_IarrayIarrayBarrayIHandler")]
			public override unsafe int DatabaseRecordRead (int p0, int[]? p1, byte[]? p2, int[]? p3)
			{
				const string __id = "databaseRecordRead.(I[I[B[I)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='fiscal.vanstone.com.fiscalserver']/interface[@name='IFiscalModuleAidlInterface']/method[@name='getreceipt' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
			[Register ("getreceipt", "(JJLjava/lang/String;)Z", "GetGetreceipt_JJLjava_lang_String_Handler")]
			public override unsafe bool Getreceipt (long p0, long p1, string? p2)
			{
				const string __id = "getreceipt.(JJLjava/lang/String;)Z";
				IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface", DoNotGenerateAcw=true)]
	internal partial class IFiscalModuleAidlInterfaceInvoker : global::Java.Lang.Object, IFiscalModuleAidlInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("fiscal/vanstone/com/fiscalserver/IFiscalModuleAidlInterface", typeof (IFiscalModuleAidlInterfaceInvoker));

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

		public static IFiscalModuleAidlInterface? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFiscalModuleAidlInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'fiscal.vanstone.com.fiscalserver.IFiscalModuleAidlInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFiscalModuleAidlInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_GetFreeDiskSpace;
#pragma warning disable 0169
		static Delegate GetGetFreeDiskSpaceHandler ()
		{
			if (cb_GetFreeDiskSpace == null)
				cb_GetFreeDiskSpace = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetFreeDiskSpace));
			return cb_GetFreeDiskSpace;
		}

		static long n_GetFreeDiskSpace (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FreeDiskSpace;
		}
#pragma warning restore 0169

		IntPtr id_GetFreeDiskSpace;
		public unsafe long FreeDiskSpace {
			get {
				if (id_GetFreeDiskSpace == IntPtr.Zero)
					id_GetFreeDiskSpace = JNIEnv.GetMethodID (class_ref, "GetFreeDiskSpace", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetFreeDiskSpace);
			}
		}

		static Delegate? cb_GetTotalRow;
#pragma warning disable 0169
		static Delegate GetGetTotalRowHandler ()
		{
			if (cb_GetTotalRow == null)
				cb_GetTotalRow = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetTotalRow));
			return cb_GetTotalRow;
		}

		static int n_GetTotalRow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.TotalRow;
		}
#pragma warning restore 0169

		IntPtr id_GetTotalRow;
		public unsafe int TotalRow {
			get {
				if (id_GetTotalRow == IntPtr.Zero)
					id_GetTotalRow = JNIEnv.GetMethodID (class_ref, "GetTotalRow", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetTotalRow);
			}
		}

		static Delegate? cb_AuthChallenge_arrayBI;
#pragma warning disable 0169
		static Delegate GetAuthChallenge_arrayBIHandler ()
		{
			if (cb_AuthChallenge_arrayBI == null)
				cb_AuthChallenge_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_AuthChallenge_arrayBI));
			return cb_AuthChallenge_arrayBI;
		}

		static int n_AuthChallenge_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.AuthChallenge (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_AuthChallenge_arrayBI;
		public unsafe int AuthChallenge (byte[]? p0, int p1)
		{
			if (id_AuthChallenge_arrayBI == IntPtr.Zero)
				id_AuthChallenge_arrayBI = JNIEnv.GetMethodID (class_ref, "AuthChallenge", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_AuthChallenge_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_Authexec_arrayBI;
#pragma warning disable 0169
		static Delegate GetAuthexec_arrayBIHandler ()
		{
			if (cb_Authexec_arrayBI == null)
				cb_Authexec_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Authexec_arrayBI));
			return cb_Authexec_arrayBI;
		}

		static int n_Authexec_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Authexec (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Authexec_arrayBI;
		public unsafe int Authexec (byte[]? p0, int p1)
		{
			if (id_Authexec_arrayBI == IntPtr.Zero)
				id_Authexec_arrayBI = JNIEnv.GetMethodID (class_ref, "Authexec", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Authexec_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_Authrequest;
#pragma warning disable 0169
		static Delegate GetAuthrequestHandler ()
		{
			if (cb_Authrequest == null)
				cb_Authrequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Authrequest));
			return cb_Authrequest;
		}

		static int n_Authrequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Authrequest ();
		}
#pragma warning restore 0169

		IntPtr id_Authrequest;
		public unsafe int Authrequest ()
		{
			if (id_Authrequest == IntPtr.Zero)
				id_Authrequest = JNIEnv.GetMethodID (class_ref, "Authrequest", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Authrequest);
		}

		static Delegate? cb_BindExec_arrayBIarrayBI;
#pragma warning disable 0169
		static Delegate GetBindExec_arrayBIarrayBIHandler ()
		{
			if (cb_BindExec_arrayBIarrayBI == null)
				cb_BindExec_arrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_I (n_BindExec_arrayBIarrayBI));
			return cb_BindExec_arrayBIarrayBI;
		}

		static int n_BindExec_arrayBIarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.BindExec (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_BindExec_arrayBIarrayBI;
		public unsafe int BindExec (byte[]? p0, int p1, byte[]? p2, int p3)
		{
			if (id_BindExec_arrayBIarrayBI == IntPtr.Zero)
				id_BindExec_arrayBIarrayBI = JNIEnv.GetMethodID (class_ref, "BindExec", "([BI[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BindExec_arrayBIarrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_BindQuery;
#pragma warning disable 0169
		static Delegate GetBindQueryHandler ()
		{
			if (cb_BindQuery == null)
				cb_BindQuery = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_BindQuery));
			return cb_BindQuery;
		}

		static int n_BindQuery (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.BindQuery ();
		}
#pragma warning restore 0169

		IntPtr id_BindQuery;
		public unsafe int BindQuery ()
		{
			if (id_BindQuery == IntPtr.Zero)
				id_BindQuery = JNIEnv.GetMethodID (class_ref, "BindQuery", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BindQuery);
		}

		static Delegate? cb_BindRequest;
#pragma warning disable 0169
		static Delegate GetBindRequestHandler ()
		{
			if (cb_BindRequest == null)
				cb_BindRequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_BindRequest));
			return cb_BindRequest;
		}

		static int n_BindRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.BindRequest ();
		}
#pragma warning restore 0169

		IntPtr id_BindRequest;
		public unsafe int BindRequest ()
		{
			if (id_BindRequest == IntPtr.Zero)
				id_BindRequest = JNIEnv.GetMethodID (class_ref, "BindRequest", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BindRequest);
		}

		static Delegate? cb_ClearFiscalDatabase;
#pragma warning disable 0169
		static Delegate GetClearFiscalDatabaseHandler ()
		{
			if (cb_ClearFiscalDatabase == null)
				cb_ClearFiscalDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ClearFiscalDatabase));
			return cb_ClearFiscalDatabase;
		}

		static int n_ClearFiscalDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ClearFiscalDatabase ();
		}
#pragma warning restore 0169

		IntPtr id_ClearFiscalDatabase;
		public unsafe int ClearFiscalDatabase ()
		{
			if (id_ClearFiscalDatabase == IntPtr.Zero)
				id_ClearFiscalDatabase = JNIEnv.GetMethodID (class_ref, "ClearFiscalDatabase", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ClearFiscalDatabase);
		}

		static Delegate? cb_ClearWormDatabase;
#pragma warning disable 0169
		static Delegate GetClearWormDatabaseHandler ()
		{
			if (cb_ClearWormDatabase == null)
				cb_ClearWormDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ClearWormDatabase));
			return cb_ClearWormDatabase;
		}

		static int n_ClearWormDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ClearWormDatabase ();
		}
#pragma warning restore 0169

		IntPtr id_ClearWormDatabase;
		public unsafe int ClearWormDatabase ()
		{
			if (id_ClearWormDatabase == IntPtr.Zero)
				id_ClearWormDatabase = JNIEnv.GetMethodID (class_ref, "ClearWormDatabase", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_ClearWormDatabase);
		}

		static Delegate? cb_CloseFiscalModuleDatabase;
#pragma warning disable 0169
		static Delegate GetCloseFiscalModuleDatabaseHandler ()
		{
			if (cb_CloseFiscalModuleDatabase == null)
				cb_CloseFiscalModuleDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_CloseFiscalModuleDatabase));
			return cb_CloseFiscalModuleDatabase;
		}

		static int n_CloseFiscalModuleDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CloseFiscalModuleDatabase ();
		}
#pragma warning restore 0169

		IntPtr id_CloseFiscalModuleDatabase;
		public unsafe int CloseFiscalModuleDatabase ()
		{
			if (id_CloseFiscalModuleDatabase == IntPtr.Zero)
				id_CloseFiscalModuleDatabase = JNIEnv.GetMethodID (class_ref, "CloseFiscalModuleDatabase", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_CloseFiscalModuleDatabase);
		}

		static Delegate? cb_DownloadFile_arrayBI;
#pragma warning disable 0169
		static Delegate GetDownloadFile_arrayBIHandler ()
		{
			if (cb_DownloadFile_arrayBI == null)
				cb_DownloadFile_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_DownloadFile_arrayBI));
			return cb_DownloadFile_arrayBI;
		}

		static int n_DownloadFile_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DownloadFile (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DownloadFile_arrayBI;
		public unsafe int DownloadFile (byte[]? p0, int p1)
		{
			if (id_DownloadFile_arrayBI == IntPtr.Zero)
				id_DownloadFile_arrayBI = JNIEnv.GetMethodID (class_ref, "DownloadFile", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DownloadFile_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DownloadServer_arrayBI;
#pragma warning disable 0169
		static Delegate GetDownloadServer_arrayBIHandler ()
		{
			if (cb_DownloadServer_arrayBI == null)
				cb_DownloadServer_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_DownloadServer_arrayBI));
			return cb_DownloadServer_arrayBI;
		}

		static int n_DownloadServer_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DownloadServer (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DownloadServer_arrayBI;
		public unsafe int DownloadServer (byte[]? p0, int p1)
		{
			if (id_DownloadServer_arrayBI == IntPtr.Zero)
				id_DownloadServer_arrayBI = JNIEnv.GetMethodID (class_ref, "DownloadServer", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DownloadServer_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_FiscalModulePowerOff;
#pragma warning disable 0169
		static Delegate GetFiscalModulePowerOffHandler ()
		{
			if (cb_FiscalModulePowerOff == null)
				cb_FiscalModulePowerOff = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalModulePowerOff));
			return cb_FiscalModulePowerOff;
		}

		static int n_FiscalModulePowerOff (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalModulePowerOff ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalModulePowerOff;
		public unsafe int FiscalModulePowerOff ()
		{
			if (id_FiscalModulePowerOff == IntPtr.Zero)
				id_FiscalModulePowerOff = JNIEnv.GetMethodID (class_ref, "FiscalModulePowerOff", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalModulePowerOff);
		}

		static Delegate? cb_FiscalModulePowerOn;
#pragma warning disable 0169
		static Delegate GetFiscalModulePowerOnHandler ()
		{
			if (cb_FiscalModulePowerOn == null)
				cb_FiscalModulePowerOn = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalModulePowerOn));
			return cb_FiscalModulePowerOn;
		}

		static int n_FiscalModulePowerOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalModulePowerOn ();
		}
#pragma warning restore 0169

		IntPtr id_FiscalModulePowerOn;
		public unsafe int FiscalModulePowerOn ()
		{
			if (id_FiscalModulePowerOn == IntPtr.Zero)
				id_FiscalModulePowerOn = JNIEnv.GetMethodID (class_ref, "FiscalModulePowerOn", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_FiscalModulePowerOn);
		}

		static Delegate? cb_GetFaxContentById_J;
#pragma warning disable 0169
		static Delegate GetGetFaxContentById_JHandler ()
		{
			if (cb_GetFaxContentById_J == null)
				cb_GetFaxContentById_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_L (n_GetFaxContentById_J));
			return cb_GetFaxContentById_J;
		}

		static IntPtr n_GetFaxContentById_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GetFaxContentById (p0));
		}
#pragma warning restore 0169

		IntPtr id_GetFaxContentById_J;
		public unsafe string? GetFaxContentById (long p0)
		{
			if (id_GetFaxContentById_J == IntPtr.Zero)
				id_GetFaxContentById_J = JNIEnv.GetMethodID (class_ref, "GetFaxContentById", "(J)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetFaxContentById_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_GetFaxIdsByDate_J;
#pragma warning disable 0169
		static Delegate GetGetFaxIdsByDate_JHandler ()
		{
			if (cb_GetFaxIdsByDate_J == null)
				cb_GetFaxIdsByDate_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_L (n_GetFaxIdsByDate_J));
			return cb_GetFaxIdsByDate_J;
		}

		static IntPtr n_GetFaxIdsByDate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetFaxIdsByDate (p0));
		}
#pragma warning restore 0169

		IntPtr id_GetFaxIdsByDate_J;
		public unsafe long[]? GetFaxIdsByDate (long p0)
		{
			if (id_GetFaxIdsByDate_J == IntPtr.Zero)
				id_GetFaxIdsByDate_J = JNIEnv.GetMethodID (class_ref, "GetFaxIdsByDate", "(J)[J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (long[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetFaxIdsByDate_J, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
		}

		static Delegate? cb_GetFaxMessage_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFaxMessage_JLjava_lang_String_Handler ()
		{
			if (cb_GetFaxMessage_JLjava_lang_String_ == null)
				cb_GetFaxMessage_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJL_Z (n_GetFaxMessage_JLjava_lang_String_));
			return cb_GetFaxMessage_JLjava_lang_String_;
		}

		static bool n_GetFaxMessage_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetFaxMessage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetFaxMessage_JLjava_lang_String_;
		public unsafe bool GetFaxMessage (long p0, string? p1)
		{
			if (id_GetFaxMessage_JLjava_lang_String_ == IntPtr.Zero)
				id_GetFaxMessage_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetFaxMessage", "(JLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetFaxMessage_JLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_Handler ()
		{
			if (cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ == null)
				cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJLL_L (n_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_));
			return cb_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_;
		}

		static IntPtr n_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (string[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewArray (__this.GetFaxMessageDayNumber (p0, p1, p2, p3));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_;
		public unsafe byte[]? GetFaxMessageDayNumber (long p0, long p1, byte[]? p2, string[]? p3)
		{
			if (id_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ == IntPtr.Zero)
				id_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetFaxMessageDayNumber", "(JJ[B[Ljava/lang/String;)[B");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetFaxMessageDayNumber_JJarrayBarrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_GetFaxVersion_arrayB;
#pragma warning disable 0169
		static Delegate GetGetFaxVersion_arrayBHandler ()
		{
			if (cb_GetFaxVersion_arrayB == null)
				cb_GetFaxVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_GetFaxVersion_arrayB));
			return cb_GetFaxVersion_arrayB;
		}

		static bool n_GetFaxVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.GetFaxVersion (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetFaxVersion_arrayB;
		public unsafe bool GetFaxVersion (byte[]? p0)
		{
			if (id_GetFaxVersion_arrayB == IntPtr.Zero)
				id_GetFaxVersion_arrayB = JNIEnv.GetMethodID (class_ref, "GetFaxVersion", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetFaxVersion_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_GetFiscalModuleDataById_IarrayB;
#pragma warning disable 0169
		static Delegate GetGetFiscalModuleDataById_IarrayBHandler ()
		{
			if (cb_GetFiscalModuleDataById_IarrayB == null)
				cb_GetFiscalModuleDataById_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_GetFiscalModuleDataById_IarrayB));
			return cb_GetFiscalModuleDataById_IarrayB;
		}

		static int n_GetFiscalModuleDataById_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetFiscalModuleDataById (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetFiscalModuleDataById_IarrayB;
		public unsafe int GetFiscalModuleDataById (int p0, byte[]? p1)
		{
			if (id_GetFiscalModuleDataById_IarrayB == IntPtr.Zero)
				id_GetFiscalModuleDataById_IarrayB = JNIEnv.GetMethodID (class_ref, "GetFiscalModuleDataById", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetFiscalModuleDataById_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_GetFiscalModuleHardwareVersion_arrayB;
#pragma warning disable 0169
		static Delegate GetGetFiscalModuleHardwareVersion_arrayBHandler ()
		{
			if (cb_GetFiscalModuleHardwareVersion_arrayB == null)
				cb_GetFiscalModuleHardwareVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFiscalModuleHardwareVersion_arrayB));
			return cb_GetFiscalModuleHardwareVersion_arrayB;
		}

		static int n_GetFiscalModuleHardwareVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetFiscalModuleHardwareVersion (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetFiscalModuleHardwareVersion_arrayB;
		public unsafe int GetFiscalModuleHardwareVersion (byte[]? p0)
		{
			if (id_GetFiscalModuleHardwareVersion_arrayB == IntPtr.Zero)
				id_GetFiscalModuleHardwareVersion_arrayB = JNIEnv.GetMethodID (class_ref, "GetFiscalModuleHardwareVersion", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetFiscalModuleHardwareVersion_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_GetFiscalModuleIds_IIIarrayB;
#pragma warning disable 0169
		static Delegate GetGetFiscalModuleIds_IIIarrayBHandler ()
		{
			if (cb_GetFiscalModuleIds_IIIarrayB == null)
				cb_GetFiscalModuleIds_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_GetFiscalModuleIds_IIIarrayB));
			return cb_GetFiscalModuleIds_IIIarrayB;
		}

		static int n_GetFiscalModuleIds_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetFiscalModuleIds (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetFiscalModuleIds_IIIarrayB;
		public unsafe int GetFiscalModuleIds (int p0, int p1, int p2, byte[]? p3)
		{
			if (id_GetFiscalModuleIds_IIIarrayB == IntPtr.Zero)
				id_GetFiscalModuleIds_IIIarrayB = JNIEnv.GetMethodID (class_ref, "GetFiscalModuleIds", "(III[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetFiscalModuleIds_IIIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_GetFiscalModuleMkey_JI;
#pragma warning disable 0169
		static Delegate GetGetFiscalModuleMkey_JIHandler ()
		{
			if (cb_GetFiscalModuleMkey_JI == null)
				cb_GetFiscalModuleMkey_JI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJI_I (n_GetFiscalModuleMkey_JI));
			return cb_GetFiscalModuleMkey_JI;
		}

		static int n_GetFiscalModuleMkey_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GetFiscalModuleMkey (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_GetFiscalModuleMkey_JI;
		public unsafe int GetFiscalModuleMkey (long p0, int p1)
		{
			if (id_GetFiscalModuleMkey_JI == IntPtr.Zero)
				id_GetFiscalModuleMkey_JI = JNIEnv.GetMethodID (class_ref, "GetFiscalModuleMkey", "(JI)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetFiscalModuleMkey_JI, __args);
		}

		static Delegate? cb_GetFiscalModuleSoftWareVersion_arrayB;
#pragma warning disable 0169
		static Delegate GetGetFiscalModuleSoftWareVersion_arrayBHandler ()
		{
			if (cb_GetFiscalModuleSoftWareVersion_arrayB == null)
				cb_GetFiscalModuleSoftWareVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFiscalModuleSoftWareVersion_arrayB));
			return cb_GetFiscalModuleSoftWareVersion_arrayB;
		}

		static int n_GetFiscalModuleSoftWareVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetFiscalModuleSoftWareVersion (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetFiscalModuleSoftWareVersion_arrayB;
		public unsafe int GetFiscalModuleSoftWareVersion (byte[]? p0)
		{
			if (id_GetFiscalModuleSoftWareVersion_arrayB == IntPtr.Zero)
				id_GetFiscalModuleSoftWareVersion_arrayB = JNIEnv.GetMethodID (class_ref, "GetFiscalModuleSoftWareVersion", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetFiscalModuleSoftWareVersion_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_OpenFiscalModuleDatabase;
#pragma warning disable 0169
		static Delegate GetOpenFiscalModuleDatabaseHandler ()
		{
			if (cb_OpenFiscalModuleDatabase == null)
				cb_OpenFiscalModuleDatabase = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_OpenFiscalModuleDatabase));
			return cb_OpenFiscalModuleDatabase;
		}

		static int n_OpenFiscalModuleDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.OpenFiscalModuleDatabase ();
		}
#pragma warning restore 0169

		IntPtr id_OpenFiscalModuleDatabase;
		public unsafe int OpenFiscalModuleDatabase ()
		{
			if (id_OpenFiscalModuleDatabase == IntPtr.Zero)
				id_OpenFiscalModuleDatabase = JNIEnv.GetMethodID (class_ref, "OpenFiscalModuleDatabase", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_OpenFiscalModuleDatabase);
		}

		static Delegate? cb_SysGetSN_arrayB;
#pragma warning disable 0169
		static Delegate GetSysGetSN_arrayBHandler ()
		{
			if (cb_SysGetSN_arrayB == null)
				cb_SysGetSN_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SysGetSN_arrayB));
			return cb_SysGetSN_arrayB;
		}

		static int n_SysGetSN_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SysGetSN (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SysGetSN_arrayB;
		public unsafe int SysGetSN (byte[]? p0)
		{
			if (id_SysGetSN_arrayB == IntPtr.Zero)
				id_SysGetSN_arrayB = JNIEnv.GetMethodID (class_ref, "SysGetSN", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SysGetSN_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_WriteFiscalOnly_IarrayBJ;
#pragma warning disable 0169
		static Delegate GetWriteFiscalOnly_IarrayBJHandler ()
		{
			if (cb_WriteFiscalOnly_IarrayBJ == null)
				cb_WriteFiscalOnly_IarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILJ_I (n_WriteFiscalOnly_IarrayBJ));
			return cb_WriteFiscalOnly_IarrayBJ;
		}

		static int n_WriteFiscalOnly_IarrayBJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteFiscalOnly (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_WriteFiscalOnly_IarrayBJ;
		public unsafe int WriteFiscalOnly (int p0, byte[]? p1, long p2)
		{
			if (id_WriteFiscalOnly_IarrayBJ == IntPtr.Zero)
				id_WriteFiscalOnly_IarrayBJ = JNIEnv.GetMethodID (class_ref, "WriteFiscalOnly", "(I[BJ)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_WriteFiscalOnly_IarrayBJ, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_WriteWormOnly_JarrayBJ;
#pragma warning disable 0169
		static Delegate GetWriteWormOnly_JarrayBJHandler ()
		{
			if (cb_WriteWormOnly_JarrayBJ == null)
				cb_WriteWormOnly_JarrayBJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJLJ_J (n_WriteWormOnly_JarrayBJ));
			return cb_WriteWormOnly_JarrayBJ;
		}

		static long n_WriteWormOnly_JarrayBJ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long __ret = __this.WriteWormOnly (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_WriteWormOnly_JarrayBJ;
		public unsafe long WriteWormOnly (long p0, byte[]? p1, long p2)
		{
			if (id_WriteWormOnly_JarrayBJ == IntPtr.Zero)
				id_WriteWormOnly_JarrayBJ = JNIEnv.GetMethodID (class_ref, "WriteWormOnly", "(J[BJ)J");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_WriteWormOnly_JarrayBJ, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_basicTypes_IJZFDLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBasicTypes_IJZFDLjava_lang_String_Handler ()
		{
			if (cb_basicTypes_IJZFDLjava_lang_String_ == null)
				cb_basicTypes_IJZFDLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIJZFDL_V (n_BasicTypes_IJZFDLjava_lang_String_));
			return cb_basicTypes_IJZFDLjava_lang_String_;
		}

		static void n_BasicTypes_IJZFDLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, long p1, bool p2, float p3, double p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.BasicTypes (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_basicTypes_IJZFDLjava_lang_String_;
		public unsafe void BasicTypes (int p0, long p1, bool p2, float p3, double p4, string? p5)
		{
			if (id_basicTypes_IJZFDLjava_lang_String_ == IntPtr.Zero)
				id_basicTypes_IJZFDLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "basicTypes", "(IJZFDLjava/lang/String;)V");
			IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_basicTypes_IJZFDLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate? cb_databaseRecordCheck;
#pragma warning disable 0169
		static Delegate GetDatabaseRecordCheckHandler ()
		{
			if (cb_databaseRecordCheck == null)
				cb_databaseRecordCheck = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordCheck));
			return cb_databaseRecordCheck;
		}

		static int n_DatabaseRecordCheck (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DatabaseRecordCheck ();
		}
#pragma warning restore 0169

		IntPtr id_databaseRecordCheck;
		public unsafe int DatabaseRecordCheck ()
		{
			if (id_databaseRecordCheck == IntPtr.Zero)
				id_databaseRecordCheck = JNIEnv.GetMethodID (class_ref, "databaseRecordCheck", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_databaseRecordCheck);
		}

		static Delegate? cb_databaseRecordClose;
#pragma warning disable 0169
		static Delegate GetDatabaseRecordCloseHandler ()
		{
			if (cb_databaseRecordClose == null)
				cb_databaseRecordClose = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordClose));
			return cb_databaseRecordClose;
		}

		static int n_DatabaseRecordClose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DatabaseRecordClose ();
		}
#pragma warning restore 0169

		IntPtr id_databaseRecordClose;
		public unsafe int DatabaseRecordClose ()
		{
			if (id_databaseRecordClose == IntPtr.Zero)
				id_databaseRecordClose = JNIEnv.GetMethodID (class_ref, "databaseRecordClose", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_databaseRecordClose);
		}

		static Delegate? cb_databaseRecordOpen;
#pragma warning disable 0169
		static Delegate GetDatabaseRecordOpenHandler ()
		{
			if (cb_databaseRecordOpen == null)
				cb_databaseRecordOpen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DatabaseRecordOpen));
			return cb_databaseRecordOpen;
		}

		static int n_DatabaseRecordOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DatabaseRecordOpen ();
		}
#pragma warning restore 0169

		IntPtr id_databaseRecordOpen;
		public unsafe int DatabaseRecordOpen ()
		{
			if (id_databaseRecordOpen == IntPtr.Zero)
				id_databaseRecordOpen = JNIEnv.GetMethodID (class_ref, "databaseRecordOpen", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_databaseRecordOpen);
		}

		static Delegate? cb_databaseRecordRead_IarrayIarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetDatabaseRecordRead_IarrayIarrayBarrayIHandler ()
		{
			if (cb_databaseRecordRead_IarrayIarrayBarrayI == null)
				cb_databaseRecordRead_IarrayIarrayBarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_DatabaseRecordRead_IarrayIarrayBarrayI));
			return cb_databaseRecordRead_IarrayIarrayBarrayI;
		}

		static int n_DatabaseRecordRead_IarrayIarrayBarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (int[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (int[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.DatabaseRecordRead (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_databaseRecordRead_IarrayIarrayBarrayI;
		public unsafe int DatabaseRecordRead (int p0, int[]? p1, byte[]? p2, int[]? p3)
		{
			if (id_databaseRecordRead_IarrayIarrayBarrayI == IntPtr.Zero)
				id_databaseRecordRead_IarrayIarrayBarrayI = JNIEnv.GetMethodID (class_ref, "databaseRecordRead", "(I[I[B[I)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_databaseRecordRead_IarrayIarrayBarrayI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_getreceipt_JJLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetreceipt_JJLjava_lang_String_Handler ()
		{
			if (cb_getreceipt_JJLjava_lang_String_ == null)
				cb_getreceipt_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJJL_Z (n_Getreceipt_JJLjava_lang_String_));
			return cb_getreceipt_JJLjava_lang_String_;
		}

		static bool n_Getreceipt_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Getreceipt (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getreceipt_JJLjava_lang_String_;
		public unsafe bool Getreceipt (long p0, long p1, string? p2)
		{
			if (id_getreceipt_JJLjava_lang_String_ == IntPtr.Zero)
				id_getreceipt_JJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getreceipt", "(JJLjava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getreceipt_JJLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Fiscal.Vanstone.Com.Fiscalserver.IFiscalModuleAidlInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
