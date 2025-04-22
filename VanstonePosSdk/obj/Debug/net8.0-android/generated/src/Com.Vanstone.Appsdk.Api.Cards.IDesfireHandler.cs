using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Cards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']"
	[Register ("com/vanstone/appsdk/api/cards/DesfireHandler", "", "Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker")]
	public partial interface IDesfireHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAbortTransaction_Api' and count(parameter)=0]"
		[Register ("DesfireAbortTransaction_Api", "()I", "GetDesfireAbortTransaction_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireAbortTransaction_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuthAes_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("DesfireAuthAes_Api", "(I[B)I", "GetDesfireAuthAes_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireAuthAes_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuthIso_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("DesfireAuthIso_Api", "(I[B)I", "GetDesfireAuthIso_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireAuthIso_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuth_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("DesfireAuth_Api", "(I[B)I", "GetDesfireAuth_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireAuth_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("DesfireCardCheck_Api", "(I[B[B)I", "GetDesfireCardCheck_Api_IarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCardCheck_Api (int p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardClose_Api' and count(parameter)=0]"
		[Register ("DesfireCardClose_Api", "()I", "GetDesfireCardClose_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCardClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardOpen_Api' and count(parameter)=0]"
		[Register ("DesfireCardOpen_Api", "()I", "GetDesfireCardOpen_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCardOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeAppKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
		[Register ("DesfireChangeAppKey_Api", "(III[B[BI)I", "GetDesfireChangeAppKey_Api_IIIarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireChangeAppKey_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeFileSettings_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("DesfireChangeFileSettings_Api", "(IIIIIII)I", "GetDesfireChangeFileSettings_Api_IIIIIIIHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireChangeFileSettings_Api (int p0, int p1, int p2, int p3, int p4, int p5, int p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeKeySetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("DesfireChangeKeySetting_Api", "(I)I", "GetDesfireChangeKeySetting_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireChangeKeySetting_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangePiccMkey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("DesfireChangePiccMkey_Api", "(I[BI)I", "GetDesfireChangePiccMkey_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireChangePiccMkey_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireClearRecordFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("DesfireClearRecordFile_Api", "(I)I", "GetDesfireClearRecordFile_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireClearRecordFile_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCommitTransaction_Api' and count(parameter)=0]"
		[Register ("DesfireCommitTransaction_Api", "()I", "GetDesfireCommitTransaction_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCommitTransaction_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateApp_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("DesfireCreateApp_Api", "(Landroid/os/Bundle;)I", "GetDesfireCreateApp_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCreateApp_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateBackupFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("DesfireCreateBackupFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateBackupFile_Api_ILandroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCreateBackupFile_Api (int p0, global::Android.OS.Bundle? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateCyclicrecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("DesfireCreateCyclicrecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCreateCyclicrecordFile_Api (int p0, global::Android.OS.Bundle? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateRecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("DesfireCreateRecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateRecordFile_Api_ILandroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCreateRecordFile_Api (int p0, global::Android.OS.Bundle? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateStdFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("DesfireCreateStdFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateStdFile_Api_ILandroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCreateStdFile_Api (int p0, global::Android.OS.Bundle? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateValueFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("DesfireCreateValueFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateValueFile_Api_ILandroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCreateValueFile_Api (int p0, global::Android.OS.Bundle? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreditValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("DesfireCreditValueFile_Api", "(III)I", "GetDesfireCreditValueFile_Api_IIIHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireCreditValueFile_Api (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDebitValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("DesfireDebitValueFile_Api", "(III)I", "GetDesfireDebitValueFile_Api_IIIHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireDebitValueFile_Api (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDeleteApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("DesfireDeleteApp_Api", "([B)I", "GetDesfireDeleteApp_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireDeleteApp_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDeleteFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("DesfireDeleteFile_Api", "(I)I", "GetDesfireDeleteFile_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireDeleteFile_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireFormatPicc_Api' and count(parameter)=0]"
		[Register ("DesfireFormatPicc_Api", "()I", "GetDesfireFormatPicc_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireFormatPicc_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetAppIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("DesfireGetAppIds_Api", "([B)I", "GetDesfireGetAppIds_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetAppIds_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetDFNameInfoList_Api' and count(parameter)=0]"
		[Register ("DesfireGetDFNameInfoList_Api", "()Ljava/util/List;", "GetDesfireGetDFNameInfoList_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>? DesfireGetDFNameInfoList_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFileIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("DesfireGetFileIds_Api", "([B)I", "GetDesfireGetFileIds_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetFileIds_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFileSetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("DesfireGetFileSetting_Api", "(I)Landroid/os/Bundle;", "GetDesfireGetFileSetting_Api_IHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		global::Android.OS.Bundle? DesfireGetFileSetting_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFreeMemory_Api' and count(parameter)=0]"
		[Register ("DesfireGetFreeMemory_Api", "()I", "GetDesfireGetFreeMemory_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetFreeMemory_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetIsoFIDs_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("DesfireGetIsoFIDs_Api", "([B)I", "GetDesfireGetIsoFIDs_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetIsoFIDs_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetKeySetting_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("DesfireGetKeySetting_Api", "([B)I", "GetDesfireGetKeySetting_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetKeySetting_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetKeyVersion_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("DesfireGetKeyVersion_Api", "(I[B)I", "GetDesfireGetKeyVersion_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetKeyVersion_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetUid_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("DesfireGetUid_Api", "([B)I", "GetDesfireGetUid_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetUid_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("DesfireGetValue_Api", "(II[I)I", "GetDesfireGetValue_Api_IIarrayIHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireGetValue_Api (int p0, int p1, int[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetVersion_Api' and count(parameter)=0]"
		[Register ("DesfireGetVersion_Api", "()Landroid/os/Bundle;", "GetDesfireGetVersion_ApiHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		global::Android.OS.Bundle? DesfireGetVersion_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireLimitedCreditValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("DesfireLimitedCreditValue_Api", "(III)I", "GetDesfireLimitedCreditValue_Api_IIIHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireLimitedCreditValue_Api (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireReadData_Api' and count(parameter)=5 and parameter[1][@type='char'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("DesfireReadData_Api", "(CIII[B)I", "GetDesfireReadData_Api_CIIIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireReadData_Api (char p0, int p1, int p2, int p3, byte[]? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireReadRecord_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
		[Register ("DesfireReadRecord_Api", "(IIIII[B)I", "GetDesfireReadRecord_Api_IIIIIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireReadRecord_Api (int p0, int p1, int p2, int p3, int p4, byte[]? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireSelectApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("DesfireSelectApp_Api", "([B)I", "GetDesfireSelectApp_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireSelectApp_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireWriteCrecord_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("DesfireWriteCrecord_Api", "(IIII[B)I", "GetDesfireWriteCrecord_Api_IIIIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireWriteCrecord_Api (int p0, int p1, int p2, int p3, byte[]? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireWriteData_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("DesfireWriteData_Api", "(IIII[B)I", "GetDesfireWriteData_Api_IIIIarrayBHandler:Com.Vanstone.Appsdk.Api.Cards.IDesfireHandlerInvoker, VanstonePosSdk")]
		int DesfireWriteData_Api (int p0, int p1, int p2, int p3, byte[]? p4);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/DesfireHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/DesfireHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/constructor[@name='DesfireHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_DesfireAbortTransaction_Api;
#pragma warning disable 0169
			static Delegate GetDesfireAbortTransaction_ApiHandler ()
			{
				if (cb_DesfireAbortTransaction_Api == null)
					cb_DesfireAbortTransaction_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireAbortTransaction_Api));
				return cb_DesfireAbortTransaction_Api;
			}

			static int n_DesfireAbortTransaction_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireAbortTransaction_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireAbortTransaction_Api' and count(parameter)=0]"
			[Register ("DesfireAbortTransaction_Api", "()I", "GetDesfireAbortTransaction_ApiHandler")]
			public virtual unsafe int DesfireAbortTransaction_Api ()
			{
				const string __id = "DesfireAbortTransaction_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireAuthAes_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireAuthAes_Api_IarrayBHandler ()
			{
				if (cb_DesfireAuthAes_Api_IarrayB == null)
					cb_DesfireAuthAes_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuthAes_Api_IarrayB));
				return cb_DesfireAuthAes_Api_IarrayB;
			}

			static int n_DesfireAuthAes_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int keyno, IntPtr native_key)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireAuthAes_Api (keyno, key);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireAuthAes_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuthAes_Api", "(I[B)I", "GetDesfireAuthAes_Api_IarrayBHandler")]
			public virtual unsafe int DesfireAuthAes_Api (int keyno, byte[]? key)
			{
				const string __id = "DesfireAuthAes_Api.(I[B)I";
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyno);
					__args [1] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_DesfireAuthIso_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireAuthIso_Api_IarrayBHandler ()
			{
				if (cb_DesfireAuthIso_Api_IarrayB == null)
					cb_DesfireAuthIso_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuthIso_Api_IarrayB));
				return cb_DesfireAuthIso_Api_IarrayB;
			}

			static int n_DesfireAuthIso_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int keyno, IntPtr native_key)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireAuthIso_Api (keyno, key);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireAuthIso_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuthIso_Api", "(I[B)I", "GetDesfireAuthIso_Api_IarrayBHandler")]
			public virtual unsafe int DesfireAuthIso_Api (int keyno, byte[]? key)
			{
				const string __id = "DesfireAuthIso_Api.(I[B)I";
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyno);
					__args [1] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_DesfireAuth_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireAuth_Api_IarrayBHandler ()
			{
				if (cb_DesfireAuth_Api_IarrayB == null)
					cb_DesfireAuth_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuth_Api_IarrayB));
				return cb_DesfireAuth_Api_IarrayB;
			}

			static int n_DesfireAuth_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int keyno, IntPtr native_key)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireAuth_Api (keyno, key);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireAuth_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuth_Api", "(I[B)I", "GetDesfireAuth_Api_IarrayBHandler")]
			public virtual unsafe int DesfireAuth_Api (int keyno, byte[]? key)
			{
				const string __id = "DesfireAuth_Api.(I[B)I";
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyno);
					__args [1] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_DesfireCardCheck_Api_IarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireCardCheck_Api_IarrayBarrayBHandler ()
			{
				if (cb_DesfireCardCheck_Api_IarrayBarrayB == null)
					cb_DesfireCardCheck_Api_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_DesfireCardCheck_Api_IarrayBarrayB));
				return cb_DesfireCardCheck_Api_IarrayBarrayB;
			}

			static int n_DesfireCardCheck_Api_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int Mode, IntPtr native_CardType, IntPtr native_SerialNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var CardType = (byte[]?) JNIEnv.GetArray (native_CardType, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var SerialNo = (byte[]?) JNIEnv.GetArray (native_SerialNo, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireCardCheck_Api (Mode, CardType, SerialNo);
				if (CardType != null)
					JNIEnv.CopyArray (CardType, native_CardType);
				if (SerialNo != null)
					JNIEnv.CopyArray (SerialNo, native_SerialNo);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCardCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("DesfireCardCheck_Api", "(I[B[B)I", "GetDesfireCardCheck_Api_IarrayBarrayBHandler")]
			public virtual unsafe int DesfireCardCheck_Api (int Mode, byte[]? CardType, byte[]? SerialNo)
			{
				const string __id = "DesfireCardCheck_Api.(I[B[B)I";
				IntPtr native_CardType = JNIEnv.NewArray (CardType);
				IntPtr native_SerialNo = JNIEnv.NewArray (SerialNo);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (Mode);
					__args [1] = new JniArgumentValue (native_CardType);
					__args [2] = new JniArgumentValue (native_SerialNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (CardType != null) {
						JNIEnv.CopyArray (native_CardType, CardType);
						JNIEnv.DeleteLocalRef (native_CardType);
					}
					if (SerialNo != null) {
						JNIEnv.CopyArray (native_SerialNo, SerialNo);
						JNIEnv.DeleteLocalRef (native_SerialNo);
					}
					global::System.GC.KeepAlive (CardType);
					global::System.GC.KeepAlive (SerialNo);
				}
			}

			static Delegate? cb_DesfireCardClose_Api;
#pragma warning disable 0169
			static Delegate GetDesfireCardClose_ApiHandler ()
			{
				if (cb_DesfireCardClose_Api == null)
					cb_DesfireCardClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCardClose_Api));
				return cb_DesfireCardClose_Api;
			}

			static int n_DesfireCardClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCardClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCardClose_Api' and count(parameter)=0]"
			[Register ("DesfireCardClose_Api", "()I", "GetDesfireCardClose_ApiHandler")]
			public virtual unsafe int DesfireCardClose_Api ()
			{
				const string __id = "DesfireCardClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireCardOpen_Api;
#pragma warning disable 0169
			static Delegate GetDesfireCardOpen_ApiHandler ()
			{
				if (cb_DesfireCardOpen_Api == null)
					cb_DesfireCardOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCardOpen_Api));
				return cb_DesfireCardOpen_Api;
			}

			static int n_DesfireCardOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCardOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCardOpen_Api' and count(parameter)=0]"
			[Register ("DesfireCardOpen_Api", "()I", "GetDesfireCardOpen_ApiHandler")]
			public virtual unsafe int DesfireCardOpen_Api ()
			{
				const string __id = "DesfireCardOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetDesfireChangeAppKey_Api_IIIarrayBarrayBIHandler ()
			{
				if (cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI == null)
					cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILLI_I (n_DesfireChangeAppKey_Api_IIIarrayBarrayBI));
				return cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI;
			}

			static int n_DesfireChangeAppKey_Api_IIIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, int keySetting, int type, int keyNo, IntPtr native_oldKey, IntPtr native_newKey, int version)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var oldKey = (byte[]?) JNIEnv.GetArray (native_oldKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var newKey = (byte[]?) JNIEnv.GetArray (native_newKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireChangeAppKey_Api (keySetting, type, keyNo, oldKey, newKey, version);
				if (oldKey != null)
					JNIEnv.CopyArray (oldKey, native_oldKey);
				if (newKey != null)
					JNIEnv.CopyArray (newKey, native_newKey);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireChangeAppKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("DesfireChangeAppKey_Api", "(III[B[BI)I", "GetDesfireChangeAppKey_Api_IIIarrayBarrayBIHandler")]
			public virtual unsafe int DesfireChangeAppKey_Api (int keySetting, int type, int keyNo, byte[]? oldKey, byte[]? newKey, int version)
			{
				const string __id = "DesfireChangeAppKey_Api.(III[B[BI)I";
				IntPtr native_oldKey = JNIEnv.NewArray (oldKey);
				IntPtr native_newKey = JNIEnv.NewArray (newKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (keySetting);
					__args [1] = new JniArgumentValue (type);
					__args [2] = new JniArgumentValue (keyNo);
					__args [3] = new JniArgumentValue (native_oldKey);
					__args [4] = new JniArgumentValue (native_newKey);
					__args [5] = new JniArgumentValue (version);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (oldKey != null) {
						JNIEnv.CopyArray (native_oldKey, oldKey);
						JNIEnv.DeleteLocalRef (native_oldKey);
					}
					if (newKey != null) {
						JNIEnv.CopyArray (native_newKey, newKey);
						JNIEnv.DeleteLocalRef (native_newKey);
					}
					global::System.GC.KeepAlive (oldKey);
					global::System.GC.KeepAlive (newKey);
				}
			}

			static Delegate? cb_DesfireChangeFileSettings_Api_IIIIIII;
#pragma warning disable 0169
			static Delegate GetDesfireChangeFileSettings_Api_IIIIIIIHandler ()
			{
				if (cb_DesfireChangeFileSettings_Api_IIIIIII == null)
					cb_DesfireChangeFileSettings_Api_IIIIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIIII_I (n_DesfireChangeFileSettings_Api_IIIIIII));
				return cb_DesfireChangeFileSettings_Api_IIIIIII;
			}

			static int n_DesfireChangeFileSettings_Api_IIIIIII (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSettings, int oldChangeAccessKeyNo, int newReadAccessKeyNo, int newWriteAccessKeyNo, int newReadWriteAccessKeyNo, int newChangeAccessKeyNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireChangeFileSettings_Api (fileNo, communicationSettings, oldChangeAccessKeyNo, newReadAccessKeyNo, newWriteAccessKeyNo, newReadWriteAccessKeyNo, newChangeAccessKeyNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireChangeFileSettings_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
			[Register ("DesfireChangeFileSettings_Api", "(IIIIIII)I", "GetDesfireChangeFileSettings_Api_IIIIIIIHandler")]
			public virtual unsafe int DesfireChangeFileSettings_Api (int fileNo, int communicationSettings, int oldChangeAccessKeyNo, int newReadAccessKeyNo, int newWriteAccessKeyNo, int newReadWriteAccessKeyNo, int newChangeAccessKeyNo)
			{
				const string __id = "DesfireChangeFileSettings_Api.(IIIIIII)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSettings);
					__args [2] = new JniArgumentValue (oldChangeAccessKeyNo);
					__args [3] = new JniArgumentValue (newReadAccessKeyNo);
					__args [4] = new JniArgumentValue (newWriteAccessKeyNo);
					__args [5] = new JniArgumentValue (newReadWriteAccessKeyNo);
					__args [6] = new JniArgumentValue (newChangeAccessKeyNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireChangeKeySetting_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireChangeKeySetting_Api_IHandler ()
			{
				if (cb_DesfireChangeKeySetting_Api_I == null)
					cb_DesfireChangeKeySetting_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireChangeKeySetting_Api_I));
				return cb_DesfireChangeKeySetting_Api_I;
			}

			static int n_DesfireChangeKeySetting_Api_I (IntPtr jnienv, IntPtr native__this, int keySetting)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireChangeKeySetting_Api (keySetting);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireChangeKeySetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireChangeKeySetting_Api", "(I)I", "GetDesfireChangeKeySetting_Api_IHandler")]
			public virtual unsafe int DesfireChangeKeySetting_Api (int keySetting)
			{
				const string __id = "DesfireChangeKeySetting_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (keySetting);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireChangePiccMkey_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetDesfireChangePiccMkey_Api_IarrayBIHandler ()
			{
				if (cb_DesfireChangePiccMkey_Api_IarrayBI == null)
					cb_DesfireChangePiccMkey_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_DesfireChangePiccMkey_Api_IarrayBI));
				return cb_DesfireChangePiccMkey_Api_IarrayBI;
			}

			static int n_DesfireChangePiccMkey_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_key, int version)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireChangePiccMkey_Api (type, key, version);
				if (key != null)
					JNIEnv.CopyArray (key, native_key);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireChangePiccMkey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("DesfireChangePiccMkey_Api", "(I[BI)I", "GetDesfireChangePiccMkey_Api_IarrayBIHandler")]
			public virtual unsafe int DesfireChangePiccMkey_Api (int type, byte[]? key, int version)
			{
				const string __id = "DesfireChangePiccMkey_Api.(I[BI)I";
				IntPtr native_key = JNIEnv.NewArray (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (type);
					__args [1] = new JniArgumentValue (native_key);
					__args [2] = new JniArgumentValue (version);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (key != null) {
						JNIEnv.CopyArray (native_key, key);
						JNIEnv.DeleteLocalRef (native_key);
					}
					global::System.GC.KeepAlive (key);
				}
			}

			static Delegate? cb_DesfireClearRecordFile_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireClearRecordFile_Api_IHandler ()
			{
				if (cb_DesfireClearRecordFile_Api_I == null)
					cb_DesfireClearRecordFile_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireClearRecordFile_Api_I));
				return cb_DesfireClearRecordFile_Api_I;
			}

			static int n_DesfireClearRecordFile_Api_I (IntPtr jnienv, IntPtr native__this, int fileNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireClearRecordFile_Api (fileNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireClearRecordFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireClearRecordFile_Api", "(I)I", "GetDesfireClearRecordFile_Api_IHandler")]
			public virtual unsafe int DesfireClearRecordFile_Api (int fileNo)
			{
				const string __id = "DesfireClearRecordFile_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (fileNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireCommitTransaction_Api;
#pragma warning disable 0169
			static Delegate GetDesfireCommitTransaction_ApiHandler ()
			{
				if (cb_DesfireCommitTransaction_Api == null)
					cb_DesfireCommitTransaction_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCommitTransaction_Api));
				return cb_DesfireCommitTransaction_Api;
			}

			static int n_DesfireCommitTransaction_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCommitTransaction_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCommitTransaction_Api' and count(parameter)=0]"
			[Register ("DesfireCommitTransaction_Api", "()I", "GetDesfireCommitTransaction_ApiHandler")]
			public virtual unsafe int DesfireCommitTransaction_Api ()
			{
				const string __id = "DesfireCommitTransaction_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireCreateApp_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateApp_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateApp_Api_Landroid_os_Bundle_ == null)
					cb_DesfireCreateApp_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireCreateApp_Api_Landroid_os_Bundle_));
				return cb_DesfireCreateApp_Api_Landroid_os_Bundle_;
			}

			static int n_DesfireCreateApp_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateApp_Api (bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCreateApp_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("DesfireCreateApp_Api", "(Landroid/os/Bundle;)I", "GetDesfireCreateApp_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe int DesfireCreateApp_Api (global::Android.OS.Bundle? bundle)
			{
				const string __id = "DesfireCreateApp_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateBackupFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int fileNo, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateBackupFile_Api (fileNo, bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCreateBackupFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateBackupFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateBackupFile_Api_ILandroid_os_Bundle_Handler")]
			public virtual unsafe int DesfireCreateBackupFile_Api (int fileNo, global::Android.OS.Bundle? bundle)
			{
				const string __id = "DesfireCreateBackupFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int fileNo, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateCyclicrecordFile_Api (fileNo, bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCreateCyclicrecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateCyclicrecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_Handler")]
			public virtual unsafe int DesfireCreateCyclicrecordFile_Api (int fileNo, global::Android.OS.Bundle? bundle)
			{
				const string __id = "DesfireCreateCyclicrecordFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateRecordFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int fileNo, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateRecordFile_Api (fileNo, bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCreateRecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateRecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateRecordFile_Api_ILandroid_os_Bundle_Handler")]
			public virtual unsafe int DesfireCreateRecordFile_Api (int fileNo, global::Android.OS.Bundle? bundle)
			{
				const string __id = "DesfireCreateRecordFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateStdFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateStdFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int fileNo, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateStdFile_Api (fileNo, bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCreateStdFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateStdFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateStdFile_Api_ILandroid_os_Bundle_Handler")]
			public virtual unsafe int DesfireCreateStdFile_Api (int fileNo, global::Android.OS.Bundle? bundle)
			{
				const string __id = "DesfireCreateStdFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateValueFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateValueFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int fileNo, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateValueFile_Api (fileNo, bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCreateValueFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateValueFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateValueFile_Api_ILandroid_os_Bundle_Handler")]
			public virtual unsafe int DesfireCreateValueFile_Api (int fileNo, global::Android.OS.Bundle? bundle)
			{
				const string __id = "DesfireCreateValueFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_DesfireCreditValueFile_Api_III;
#pragma warning disable 0169
			static Delegate GetDesfireCreditValueFile_Api_IIIHandler ()
			{
				if (cb_DesfireCreditValueFile_Api_III == null)
					cb_DesfireCreditValueFile_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireCreditValueFile_Api_III));
				return cb_DesfireCreditValueFile_Api_III;
			}

			static int n_DesfireCreditValueFile_Api_III (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSetting, int value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCreditValueFile_Api (fileNo, communicationSetting, value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireCreditValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireCreditValueFile_Api", "(III)I", "GetDesfireCreditValueFile_Api_IIIHandler")]
			public virtual unsafe int DesfireCreditValueFile_Api (int fileNo, int communicationSetting, int value)
			{
				const string __id = "DesfireCreditValueFile_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (value);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireDebitValueFile_Api_III;
#pragma warning disable 0169
			static Delegate GetDesfireDebitValueFile_Api_IIIHandler ()
			{
				if (cb_DesfireDebitValueFile_Api_III == null)
					cb_DesfireDebitValueFile_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireDebitValueFile_Api_III));
				return cb_DesfireDebitValueFile_Api_III;
			}

			static int n_DesfireDebitValueFile_Api_III (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSetting, int value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireDebitValueFile_Api (fileNo, communicationSetting, value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireDebitValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireDebitValueFile_Api", "(III)I", "GetDesfireDebitValueFile_Api_IIIHandler")]
			public virtual unsafe int DesfireDebitValueFile_Api (int fileNo, int communicationSetting, int value)
			{
				const string __id = "DesfireDebitValueFile_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (value);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireDeleteApp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireDeleteApp_Api_arrayBHandler ()
			{
				if (cb_DesfireDeleteApp_Api_arrayB == null)
					cb_DesfireDeleteApp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireDeleteApp_Api_arrayB));
				return cb_DesfireDeleteApp_Api_arrayB;
			}

			static int n_DesfireDeleteApp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_aid)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aid = (byte[]?) JNIEnv.GetArray (native_aid, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireDeleteApp_Api (aid);
				if (aid != null)
					JNIEnv.CopyArray (aid, native_aid);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireDeleteApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireDeleteApp_Api", "([B)I", "GetDesfireDeleteApp_Api_arrayBHandler")]
			public virtual unsafe int DesfireDeleteApp_Api (byte[]? aid)
			{
				const string __id = "DesfireDeleteApp_Api.([B)I";
				IntPtr native_aid = JNIEnv.NewArray (aid);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_aid);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (aid != null) {
						JNIEnv.CopyArray (native_aid, aid);
						JNIEnv.DeleteLocalRef (native_aid);
					}
					global::System.GC.KeepAlive (aid);
				}
			}

			static Delegate? cb_DesfireDeleteFile_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireDeleteFile_Api_IHandler ()
			{
				if (cb_DesfireDeleteFile_Api_I == null)
					cb_DesfireDeleteFile_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireDeleteFile_Api_I));
				return cb_DesfireDeleteFile_Api_I;
			}

			static int n_DesfireDeleteFile_Api_I (IntPtr jnienv, IntPtr native__this, int fileNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireDeleteFile_Api (fileNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireDeleteFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireDeleteFile_Api", "(I)I", "GetDesfireDeleteFile_Api_IHandler")]
			public virtual unsafe int DesfireDeleteFile_Api (int fileNo)
			{
				const string __id = "DesfireDeleteFile_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (fileNo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireFormatPicc_Api;
#pragma warning disable 0169
			static Delegate GetDesfireFormatPicc_ApiHandler ()
			{
				if (cb_DesfireFormatPicc_Api == null)
					cb_DesfireFormatPicc_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireFormatPicc_Api));
				return cb_DesfireFormatPicc_Api;
			}

			static int n_DesfireFormatPicc_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireFormatPicc_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireFormatPicc_Api' and count(parameter)=0]"
			[Register ("DesfireFormatPicc_Api", "()I", "GetDesfireFormatPicc_ApiHandler")]
			public virtual unsafe int DesfireFormatPicc_Api ()
			{
				const string __id = "DesfireFormatPicc_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireGetAppIds_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetAppIds_Api_arrayBHandler ()
			{
				if (cb_DesfireGetAppIds_Api_arrayB == null)
					cb_DesfireGetAppIds_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetAppIds_Api_arrayB));
				return cb_DesfireGetAppIds_Api_arrayB;
			}

			static int n_DesfireGetAppIds_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_ids)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ids = (byte[]?) JNIEnv.GetArray (native_ids, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetAppIds_Api (ids);
				if (ids != null)
					JNIEnv.CopyArray (ids, native_ids);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetAppIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetAppIds_Api", "([B)I", "GetDesfireGetAppIds_Api_arrayBHandler")]
			public virtual unsafe int DesfireGetAppIds_Api (byte[]? ids)
			{
				const string __id = "DesfireGetAppIds_Api.([B)I";
				IntPtr native_ids = JNIEnv.NewArray (ids);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ids);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ids != null) {
						JNIEnv.CopyArray (native_ids, ids);
						JNIEnv.DeleteLocalRef (native_ids);
					}
					global::System.GC.KeepAlive (ids);
				}
			}

			static Delegate? cb_DesfireGetDFNameInfoList_Api;
#pragma warning disable 0169
			static Delegate GetDesfireGetDFNameInfoList_ApiHandler ()
			{
				if (cb_DesfireGetDFNameInfoList_Api == null)
					cb_DesfireGetDFNameInfoList_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DesfireGetDFNameInfoList_Api));
				return cb_DesfireGetDFNameInfoList_Api;
			}

			static IntPtr n_DesfireGetDFNameInfoList_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>.ToLocalJniHandle (__this.DesfireGetDFNameInfoList_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetDFNameInfoList_Api' and count(parameter)=0]"
			[Register ("DesfireGetDFNameInfoList_Api", "()Ljava/util/List;", "GetDesfireGetDFNameInfoList_ApiHandler")]
			public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>? DesfireGetDFNameInfoList_Api ()
			{
				const string __id = "DesfireGetDFNameInfoList_Api.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DesfireGetFileIds_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetFileIds_Api_arrayBHandler ()
			{
				if (cb_DesfireGetFileIds_Api_arrayB == null)
					cb_DesfireGetFileIds_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetFileIds_Api_arrayB));
				return cb_DesfireGetFileIds_Api_arrayB;
			}

			static int n_DesfireGetFileIds_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_ids)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ids = (byte[]?) JNIEnv.GetArray (native_ids, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetFileIds_Api (ids);
				if (ids != null)
					JNIEnv.CopyArray (ids, native_ids);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetFileIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetFileIds_Api", "([B)I", "GetDesfireGetFileIds_Api_arrayBHandler")]
			public virtual unsafe int DesfireGetFileIds_Api (byte[]? ids)
			{
				const string __id = "DesfireGetFileIds_Api.([B)I";
				IntPtr native_ids = JNIEnv.NewArray (ids);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ids);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ids != null) {
						JNIEnv.CopyArray (native_ids, ids);
						JNIEnv.DeleteLocalRef (native_ids);
					}
					global::System.GC.KeepAlive (ids);
				}
			}

			static Delegate? cb_DesfireGetFileSetting_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireGetFileSetting_Api_IHandler ()
			{
				if (cb_DesfireGetFileSetting_Api_I == null)
					cb_DesfireGetFileSetting_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_DesfireGetFileSetting_Api_I));
				return cb_DesfireGetFileSetting_Api_I;
			}

			static IntPtr n_DesfireGetFileSetting_Api_I (IntPtr jnienv, IntPtr native__this, int fileNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DesfireGetFileSetting_Api (fileNo));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetFileSetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireGetFileSetting_Api", "(I)Landroid/os/Bundle;", "GetDesfireGetFileSetting_Api_IHandler")]
			public virtual unsafe global::Android.OS.Bundle? DesfireGetFileSetting_Api (int fileNo)
			{
				const string __id = "DesfireGetFileSetting_Api.(I)Landroid/os/Bundle;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (fileNo);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DesfireGetFreeMemory_Api;
#pragma warning disable 0169
			static Delegate GetDesfireGetFreeMemory_ApiHandler ()
			{
				if (cb_DesfireGetFreeMemory_Api == null)
					cb_DesfireGetFreeMemory_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireGetFreeMemory_Api));
				return cb_DesfireGetFreeMemory_Api;
			}

			static int n_DesfireGetFreeMemory_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireGetFreeMemory_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetFreeMemory_Api' and count(parameter)=0]"
			[Register ("DesfireGetFreeMemory_Api", "()I", "GetDesfireGetFreeMemory_ApiHandler")]
			public virtual unsafe int DesfireGetFreeMemory_Api ()
			{
				const string __id = "DesfireGetFreeMemory_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireGetIsoFIDs_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetIsoFIDs_Api_arrayBHandler ()
			{
				if (cb_DesfireGetIsoFIDs_Api_arrayB == null)
					cb_DesfireGetIsoFIDs_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetIsoFIDs_Api_arrayB));
				return cb_DesfireGetIsoFIDs_Api_arrayB;
			}

			static int n_DesfireGetIsoFIDs_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_ids)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ids = (byte[]?) JNIEnv.GetArray (native_ids, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetIsoFIDs_Api (ids);
				if (ids != null)
					JNIEnv.CopyArray (ids, native_ids);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetIsoFIDs_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetIsoFIDs_Api", "([B)I", "GetDesfireGetIsoFIDs_Api_arrayBHandler")]
			public virtual unsafe int DesfireGetIsoFIDs_Api (byte[]? ids)
			{
				const string __id = "DesfireGetIsoFIDs_Api.([B)I";
				IntPtr native_ids = JNIEnv.NewArray (ids);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ids);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ids != null) {
						JNIEnv.CopyArray (native_ids, ids);
						JNIEnv.DeleteLocalRef (native_ids);
					}
					global::System.GC.KeepAlive (ids);
				}
			}

			static Delegate? cb_DesfireGetKeySetting_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetKeySetting_Api_arrayBHandler ()
			{
				if (cb_DesfireGetKeySetting_Api_arrayB == null)
					cb_DesfireGetKeySetting_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetKeySetting_Api_arrayB));
				return cb_DesfireGetKeySetting_Api_arrayB;
			}

			static int n_DesfireGetKeySetting_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_set)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var set = (byte[]?) JNIEnv.GetArray (native_set, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetKeySetting_Api (set);
				if (set != null)
					JNIEnv.CopyArray (set, native_set);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetKeySetting_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetKeySetting_Api", "([B)I", "GetDesfireGetKeySetting_Api_arrayBHandler")]
			public virtual unsafe int DesfireGetKeySetting_Api (byte[]? set)
			{
				const string __id = "DesfireGetKeySetting_Api.([B)I";
				IntPtr native_set = JNIEnv.NewArray (set);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_set);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (set != null) {
						JNIEnv.CopyArray (native_set, set);
						JNIEnv.DeleteLocalRef (native_set);
					}
					global::System.GC.KeepAlive (set);
				}
			}

			static Delegate? cb_DesfireGetKeyVersion_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetKeyVersion_Api_IarrayBHandler ()
			{
				if (cb_DesfireGetKeyVersion_Api_IarrayB == null)
					cb_DesfireGetKeyVersion_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireGetKeyVersion_Api_IarrayB));
				return cb_DesfireGetKeyVersion_Api_IarrayB;
			}

			static int n_DesfireGetKeyVersion_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int keyNo, IntPtr native_ver)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ver = (byte[]?) JNIEnv.GetArray (native_ver, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetKeyVersion_Api (keyNo, ver);
				if (ver != null)
					JNIEnv.CopyArray (ver, native_ver);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetKeyVersion_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireGetKeyVersion_Api", "(I[B)I", "GetDesfireGetKeyVersion_Api_IarrayBHandler")]
			public virtual unsafe int DesfireGetKeyVersion_Api (int keyNo, byte[]? ver)
			{
				const string __id = "DesfireGetKeyVersion_Api.(I[B)I";
				IntPtr native_ver = JNIEnv.NewArray (ver);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyNo);
					__args [1] = new JniArgumentValue (native_ver);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ver != null) {
						JNIEnv.CopyArray (native_ver, ver);
						JNIEnv.DeleteLocalRef (native_ver);
					}
					global::System.GC.KeepAlive (ver);
				}
			}

			static Delegate? cb_DesfireGetUid_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetUid_Api_arrayBHandler ()
			{
				if (cb_DesfireGetUid_Api_arrayB == null)
					cb_DesfireGetUid_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetUid_Api_arrayB));
				return cb_DesfireGetUid_Api_arrayB;
			}

			static int n_DesfireGetUid_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_uid)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var uid = (byte[]?) JNIEnv.GetArray (native_uid, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetUid_Api (uid);
				if (uid != null)
					JNIEnv.CopyArray (uid, native_uid);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetUid_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetUid_Api", "([B)I", "GetDesfireGetUid_Api_arrayBHandler")]
			public virtual unsafe int DesfireGetUid_Api (byte[]? uid)
			{
				const string __id = "DesfireGetUid_Api.([B)I";
				IntPtr native_uid = JNIEnv.NewArray (uid);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_uid);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (uid != null) {
						JNIEnv.CopyArray (native_uid, uid);
						JNIEnv.DeleteLocalRef (native_uid);
					}
					global::System.GC.KeepAlive (uid);
				}
			}

			static Delegate? cb_DesfireGetValue_Api_IIarrayI;
#pragma warning disable 0169
			static Delegate GetDesfireGetValue_Api_IIarrayIHandler ()
			{
				if (cb_DesfireGetValue_Api_IIarrayI == null)
					cb_DesfireGetValue_Api_IIarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_DesfireGetValue_Api_IIarrayI));
				return cb_DesfireGetValue_Api_IIarrayI;
			}

			static int n_DesfireGetValue_Api_IIarrayI (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSetting, IntPtr native_value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var value = (int[]?) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.DesfireGetValue_Api (fileNo, communicationSetting, value);
				if (value != null)
					JNIEnv.CopyArray (value, native_value);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
			[Register ("DesfireGetValue_Api", "(II[I)I", "GetDesfireGetValue_Api_IIarrayIHandler")]
			public virtual unsafe int DesfireGetValue_Api (int fileNo, int communicationSetting, int[]? value)
			{
				const string __id = "DesfireGetValue_Api.(II[I)I";
				IntPtr native_value = JNIEnv.NewArray (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (value != null) {
						JNIEnv.CopyArray (native_value, value);
						JNIEnv.DeleteLocalRef (native_value);
					}
					global::System.GC.KeepAlive (value);
				}
			}

			static Delegate? cb_DesfireGetVersion_Api;
#pragma warning disable 0169
			static Delegate GetDesfireGetVersion_ApiHandler ()
			{
				if (cb_DesfireGetVersion_Api == null)
					cb_DesfireGetVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DesfireGetVersion_Api));
				return cb_DesfireGetVersion_Api;
			}

			static IntPtr n_DesfireGetVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DesfireGetVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireGetVersion_Api' and count(parameter)=0]"
			[Register ("DesfireGetVersion_Api", "()Landroid/os/Bundle;", "GetDesfireGetVersion_ApiHandler")]
			public virtual unsafe global::Android.OS.Bundle? DesfireGetVersion_Api ()
			{
				const string __id = "DesfireGetVersion_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_DesfireLimitedCreditValue_Api_III;
#pragma warning disable 0169
			static Delegate GetDesfireLimitedCreditValue_Api_IIIHandler ()
			{
				if (cb_DesfireLimitedCreditValue_Api_III == null)
					cb_DesfireLimitedCreditValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireLimitedCreditValue_Api_III));
				return cb_DesfireLimitedCreditValue_Api_III;
			}

			static int n_DesfireLimitedCreditValue_Api_III (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSetting, int value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireLimitedCreditValue_Api (fileNo, communicationSetting, value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireLimitedCreditValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireLimitedCreditValue_Api", "(III)I", "GetDesfireLimitedCreditValue_Api_IIIHandler")]
			public virtual unsafe int DesfireLimitedCreditValue_Api (int fileNo, int communicationSetting, int value)
			{
				const string __id = "DesfireLimitedCreditValue_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (value);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_DesfireReadData_Api_CIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireReadData_Api_CIIIarrayBHandler ()
			{
				if (cb_DesfireReadData_Api_CIIIarrayB == null)
					cb_DesfireReadData_Api_CIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPCIIIL_I (n_DesfireReadData_Api_CIIIarrayB));
				return cb_DesfireReadData_Api_CIIIarrayB;
			}

			static int n_DesfireReadData_Api_CIIIarrayB (IntPtr jnienv, IntPtr native__this, char fileNo, int communicationSetting, int offset, int len, IntPtr native_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireReadData_Api (fileNo, communicationSetting, offset, len, buf);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireReadData_Api' and count(parameter)=5 and parameter[1][@type='char'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireReadData_Api", "(CIII[B)I", "GetDesfireReadData_Api_CIIIarrayBHandler")]
			public virtual unsafe int DesfireReadData_Api (char fileNo, int communicationSetting, int offset, int len, byte[]? buf)
			{
				const string __id = "DesfireReadData_Api.(CIII[B)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (offset);
					__args [3] = new JniArgumentValue (len);
					__args [4] = new JniArgumentValue (native_buf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

			static Delegate? cb_DesfireReadRecord_Api_IIIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireReadRecord_Api_IIIIIarrayBHandler ()
			{
				if (cb_DesfireReadRecord_Api_IIIIIarrayB == null)
					cb_DesfireReadRecord_Api_IIIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIIL_I (n_DesfireReadRecord_Api_IIIIIarrayB));
				return cb_DesfireReadRecord_Api_IIIIIarrayB;
			}

			static int n_DesfireReadRecord_Api_IIIIIarrayB (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSetting, int recordSize, int first, int num, IntPtr native_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireReadRecord_Api (fileNo, communicationSetting, recordSize, first, num, buf);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireReadRecord_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("DesfireReadRecord_Api", "(IIIII[B)I", "GetDesfireReadRecord_Api_IIIIIarrayBHandler")]
			public virtual unsafe int DesfireReadRecord_Api (int fileNo, int communicationSetting, int recordSize, int first, int num, byte[]? buf)
			{
				const string __id = "DesfireReadRecord_Api.(IIIII[B)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (recordSize);
					__args [3] = new JniArgumentValue (first);
					__args [4] = new JniArgumentValue (num);
					__args [5] = new JniArgumentValue (native_buf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

			static Delegate? cb_DesfireSelectApp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireSelectApp_Api_arrayBHandler ()
			{
				if (cb_DesfireSelectApp_Api_arrayB == null)
					cb_DesfireSelectApp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireSelectApp_Api_arrayB));
				return cb_DesfireSelectApp_Api_arrayB;
			}

			static int n_DesfireSelectApp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_AID)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var AID = (byte[]?) JNIEnv.GetArray (native_AID, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireSelectApp_Api (AID);
				if (AID != null)
					JNIEnv.CopyArray (AID, native_AID);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireSelectApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireSelectApp_Api", "([B)I", "GetDesfireSelectApp_Api_arrayBHandler")]
			public virtual unsafe int DesfireSelectApp_Api (byte[]? AID)
			{
				const string __id = "DesfireSelectApp_Api.([B)I";
				IntPtr native_AID = JNIEnv.NewArray (AID);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_AID);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (AID != null) {
						JNIEnv.CopyArray (native_AID, AID);
						JNIEnv.DeleteLocalRef (native_AID);
					}
					global::System.GC.KeepAlive (AID);
				}
			}

			static Delegate? cb_DesfireWriteCrecord_Api_IIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireWriteCrecord_Api_IIIIarrayBHandler ()
			{
				if (cb_DesfireWriteCrecord_Api_IIIIarrayB == null)
					cb_DesfireWriteCrecord_Api_IIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_DesfireWriteCrecord_Api_IIIIarrayB));
				return cb_DesfireWriteCrecord_Api_IIIIarrayB;
			}

			static int n_DesfireWriteCrecord_Api_IIIIarrayB (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSetting, int offset, int len, IntPtr native_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireWriteCrecord_Api (fileNo, communicationSetting, offset, len, buf);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireWriteCrecord_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireWriteCrecord_Api", "(IIII[B)I", "GetDesfireWriteCrecord_Api_IIIIarrayBHandler")]
			public virtual unsafe int DesfireWriteCrecord_Api (int fileNo, int communicationSetting, int offset, int len, byte[]? buf)
			{
				const string __id = "DesfireWriteCrecord_Api.(IIII[B)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (offset);
					__args [3] = new JniArgumentValue (len);
					__args [4] = new JniArgumentValue (native_buf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
				}
			}

			static Delegate? cb_DesfireWriteData_Api_IIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireWriteData_Api_IIIIarrayBHandler ()
			{
				if (cb_DesfireWriteData_Api_IIIIarrayB == null)
					cb_DesfireWriteData_Api_IIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_DesfireWriteData_Api_IIIIarrayB));
				return cb_DesfireWriteData_Api_IIIIarrayB;
			}

			static int n_DesfireWriteData_Api_IIIIarrayB (IntPtr jnienv, IntPtr native__this, int fileNo, int communicationSetting, int offset, int len, IntPtr native_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireWriteData_Api (fileNo, communicationSetting, offset, len, buf);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='DesfireWriteData_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireWriteData_Api", "(IIII[B)I", "GetDesfireWriteData_Api_IIIIarrayBHandler")]
			public virtual unsafe int DesfireWriteData_Api (int fileNo, int communicationSetting, int offset, int len, byte[]? buf)
			{
				const string __id = "DesfireWriteData_Api.(IIII[B)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (fileNo);
					__args [1] = new JniArgumentValue (communicationSetting);
					__args [2] = new JniArgumentValue (offset);
					__args [3] = new JniArgumentValue (len);
					__args [4] = new JniArgumentValue (native_buf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buf != null) {
						JNIEnv.CopyArray (native_buf, buf);
						JNIEnv.DeleteLocalRef (native_buf);
					}
					global::System.GC.KeepAlive (buf);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/DesfireHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/DesfireHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Stub']/constructor[@name='DesfireHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/cards/DesfireHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/cards/DesfireHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/DesfireHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/cards/DesfireHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/class[@name='DesfireHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.cards.DesfireHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/cards/DesfireHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/cards/DesfireHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_DesfireAbortTransaction_Api;
#pragma warning disable 0169
			static Delegate GetDesfireAbortTransaction_ApiHandler ()
			{
				if (cb_DesfireAbortTransaction_Api == null)
					cb_DesfireAbortTransaction_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireAbortTransaction_Api));
				return cb_DesfireAbortTransaction_Api;
			}

			static int n_DesfireAbortTransaction_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireAbortTransaction_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAbortTransaction_Api' and count(parameter)=0]"
			[Register ("DesfireAbortTransaction_Api", "()I", "GetDesfireAbortTransaction_ApiHandler")]
			public abstract int DesfireAbortTransaction_Api ();

			static Delegate? cb_DesfireAuthAes_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireAuthAes_Api_IarrayBHandler ()
			{
				if (cb_DesfireAuthAes_Api_IarrayB == null)
					cb_DesfireAuthAes_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuthAes_Api_IarrayB));
				return cb_DesfireAuthAes_Api_IarrayB;
			}

			static int n_DesfireAuthAes_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireAuthAes_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuthAes_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuthAes_Api", "(I[B)I", "GetDesfireAuthAes_Api_IarrayBHandler")]
			public abstract int DesfireAuthAes_Api (int p0, byte[]? p1);

			static Delegate? cb_DesfireAuthIso_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireAuthIso_Api_IarrayBHandler ()
			{
				if (cb_DesfireAuthIso_Api_IarrayB == null)
					cb_DesfireAuthIso_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuthIso_Api_IarrayB));
				return cb_DesfireAuthIso_Api_IarrayB;
			}

			static int n_DesfireAuthIso_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireAuthIso_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuthIso_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuthIso_Api", "(I[B)I", "GetDesfireAuthIso_Api_IarrayBHandler")]
			public abstract int DesfireAuthIso_Api (int p0, byte[]? p1);

			static Delegate? cb_DesfireAuth_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireAuth_Api_IarrayBHandler ()
			{
				if (cb_DesfireAuth_Api_IarrayB == null)
					cb_DesfireAuth_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuth_Api_IarrayB));
				return cb_DesfireAuth_Api_IarrayB;
			}

			static int n_DesfireAuth_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireAuth_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuth_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuth_Api", "(I[B)I", "GetDesfireAuth_Api_IarrayBHandler")]
			public abstract int DesfireAuth_Api (int p0, byte[]? p1);

			static Delegate? cb_DesfireCardCheck_Api_IarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireCardCheck_Api_IarrayBarrayBHandler ()
			{
				if (cb_DesfireCardCheck_Api_IarrayBarrayB == null)
					cb_DesfireCardCheck_Api_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_DesfireCardCheck_Api_IarrayBarrayB));
				return cb_DesfireCardCheck_Api_IarrayBarrayB;
			}

			static int n_DesfireCardCheck_Api_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireCardCheck_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("DesfireCardCheck_Api", "(I[B[B)I", "GetDesfireCardCheck_Api_IarrayBarrayBHandler")]
			public abstract int DesfireCardCheck_Api (int p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_DesfireCardClose_Api;
#pragma warning disable 0169
			static Delegate GetDesfireCardClose_ApiHandler ()
			{
				if (cb_DesfireCardClose_Api == null)
					cb_DesfireCardClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCardClose_Api));
				return cb_DesfireCardClose_Api;
			}

			static int n_DesfireCardClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCardClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardClose_Api' and count(parameter)=0]"
			[Register ("DesfireCardClose_Api", "()I", "GetDesfireCardClose_ApiHandler")]
			public abstract int DesfireCardClose_Api ();

			static Delegate? cb_DesfireCardOpen_Api;
#pragma warning disable 0169
			static Delegate GetDesfireCardOpen_ApiHandler ()
			{
				if (cb_DesfireCardOpen_Api == null)
					cb_DesfireCardOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCardOpen_Api));
				return cb_DesfireCardOpen_Api;
			}

			static int n_DesfireCardOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCardOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardOpen_Api' and count(parameter)=0]"
			[Register ("DesfireCardOpen_Api", "()I", "GetDesfireCardOpen_ApiHandler")]
			public abstract int DesfireCardOpen_Api ();

			static Delegate? cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetDesfireChangeAppKey_Api_IIIarrayBarrayBIHandler ()
			{
				if (cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI == null)
					cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILLI_I (n_DesfireChangeAppKey_Api_IIIarrayBarrayBI));
				return cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI;
			}

			static int n_DesfireChangeAppKey_Api_IIIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireChangeAppKey_Api (p0, p1, p2, p3, p4, p5);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeAppKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("DesfireChangeAppKey_Api", "(III[B[BI)I", "GetDesfireChangeAppKey_Api_IIIarrayBarrayBIHandler")]
			public abstract int DesfireChangeAppKey_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, int p5);

			static Delegate? cb_DesfireChangeFileSettings_Api_IIIIIII;
#pragma warning disable 0169
			static Delegate GetDesfireChangeFileSettings_Api_IIIIIIIHandler ()
			{
				if (cb_DesfireChangeFileSettings_Api_IIIIIII == null)
					cb_DesfireChangeFileSettings_Api_IIIIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIIII_I (n_DesfireChangeFileSettings_Api_IIIIIII));
				return cb_DesfireChangeFileSettings_Api_IIIIIII;
			}

			static int n_DesfireChangeFileSettings_Api_IIIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5, int p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireChangeFileSettings_Api (p0, p1, p2, p3, p4, p5, p6);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeFileSettings_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
			[Register ("DesfireChangeFileSettings_Api", "(IIIIIII)I", "GetDesfireChangeFileSettings_Api_IIIIIIIHandler")]
			public abstract int DesfireChangeFileSettings_Api (int p0, int p1, int p2, int p3, int p4, int p5, int p6);

			static Delegate? cb_DesfireChangeKeySetting_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireChangeKeySetting_Api_IHandler ()
			{
				if (cb_DesfireChangeKeySetting_Api_I == null)
					cb_DesfireChangeKeySetting_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireChangeKeySetting_Api_I));
				return cb_DesfireChangeKeySetting_Api_I;
			}

			static int n_DesfireChangeKeySetting_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireChangeKeySetting_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeKeySetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireChangeKeySetting_Api", "(I)I", "GetDesfireChangeKeySetting_Api_IHandler")]
			public abstract int DesfireChangeKeySetting_Api (int p0);

			static Delegate? cb_DesfireChangePiccMkey_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetDesfireChangePiccMkey_Api_IarrayBIHandler ()
			{
				if (cb_DesfireChangePiccMkey_Api_IarrayBI == null)
					cb_DesfireChangePiccMkey_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_DesfireChangePiccMkey_Api_IarrayBI));
				return cb_DesfireChangePiccMkey_Api_IarrayBI;
			}

			static int n_DesfireChangePiccMkey_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireChangePiccMkey_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangePiccMkey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("DesfireChangePiccMkey_Api", "(I[BI)I", "GetDesfireChangePiccMkey_Api_IarrayBIHandler")]
			public abstract int DesfireChangePiccMkey_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_DesfireClearRecordFile_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireClearRecordFile_Api_IHandler ()
			{
				if (cb_DesfireClearRecordFile_Api_I == null)
					cb_DesfireClearRecordFile_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireClearRecordFile_Api_I));
				return cb_DesfireClearRecordFile_Api_I;
			}

			static int n_DesfireClearRecordFile_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireClearRecordFile_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireClearRecordFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireClearRecordFile_Api", "(I)I", "GetDesfireClearRecordFile_Api_IHandler")]
			public abstract int DesfireClearRecordFile_Api (int p0);

			static Delegate? cb_DesfireCommitTransaction_Api;
#pragma warning disable 0169
			static Delegate GetDesfireCommitTransaction_ApiHandler ()
			{
				if (cb_DesfireCommitTransaction_Api == null)
					cb_DesfireCommitTransaction_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCommitTransaction_Api));
				return cb_DesfireCommitTransaction_Api;
			}

			static int n_DesfireCommitTransaction_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCommitTransaction_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCommitTransaction_Api' and count(parameter)=0]"
			[Register ("DesfireCommitTransaction_Api", "()I", "GetDesfireCommitTransaction_ApiHandler")]
			public abstract int DesfireCommitTransaction_Api ();

			static Delegate? cb_DesfireCreateApp_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateApp_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateApp_Api_Landroid_os_Bundle_ == null)
					cb_DesfireCreateApp_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireCreateApp_Api_Landroid_os_Bundle_));
				return cb_DesfireCreateApp_Api_Landroid_os_Bundle_;
			}

			static int n_DesfireCreateApp_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateApp_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateApp_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("DesfireCreateApp_Api", "(Landroid/os/Bundle;)I", "GetDesfireCreateApp_Api_Landroid_os_Bundle_Handler")]
			public abstract int DesfireCreateApp_Api (global::Android.OS.Bundle? p0);

			static Delegate? cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateBackupFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateBackupFile_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateBackupFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateBackupFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateBackupFile_Api_ILandroid_os_Bundle_Handler")]
			public abstract int DesfireCreateBackupFile_Api (int p0, global::Android.OS.Bundle? p1);

			static Delegate? cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateCyclicrecordFile_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateCyclicrecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateCyclicrecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_Handler")]
			public abstract int DesfireCreateCyclicrecordFile_Api (int p0, global::Android.OS.Bundle? p1);

			static Delegate? cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateRecordFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateRecordFile_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateRecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateRecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateRecordFile_Api_ILandroid_os_Bundle_Handler")]
			public abstract int DesfireCreateRecordFile_Api (int p0, global::Android.OS.Bundle? p1);

			static Delegate? cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateStdFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateStdFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateStdFile_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateStdFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateStdFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateStdFile_Api_ILandroid_os_Bundle_Handler")]
			public abstract int DesfireCreateStdFile_Api (int p0, global::Android.OS.Bundle? p1);

			static Delegate? cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetDesfireCreateValueFile_Api_ILandroid_os_Bundle_Handler ()
			{
				if (cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ == null)
					cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateValueFile_Api_ILandroid_os_Bundle_));
				return cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_;
			}

			static int n_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DesfireCreateValueFile_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateValueFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateValueFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateValueFile_Api_ILandroid_os_Bundle_Handler")]
			public abstract int DesfireCreateValueFile_Api (int p0, global::Android.OS.Bundle? p1);

			static Delegate? cb_DesfireCreditValueFile_Api_III;
#pragma warning disable 0169
			static Delegate GetDesfireCreditValueFile_Api_IIIHandler ()
			{
				if (cb_DesfireCreditValueFile_Api_III == null)
					cb_DesfireCreditValueFile_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireCreditValueFile_Api_III));
				return cb_DesfireCreditValueFile_Api_III;
			}

			static int n_DesfireCreditValueFile_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireCreditValueFile_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreditValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireCreditValueFile_Api", "(III)I", "GetDesfireCreditValueFile_Api_IIIHandler")]
			public abstract int DesfireCreditValueFile_Api (int p0, int p1, int p2);

			static Delegate? cb_DesfireDebitValueFile_Api_III;
#pragma warning disable 0169
			static Delegate GetDesfireDebitValueFile_Api_IIIHandler ()
			{
				if (cb_DesfireDebitValueFile_Api_III == null)
					cb_DesfireDebitValueFile_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireDebitValueFile_Api_III));
				return cb_DesfireDebitValueFile_Api_III;
			}

			static int n_DesfireDebitValueFile_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireDebitValueFile_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDebitValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireDebitValueFile_Api", "(III)I", "GetDesfireDebitValueFile_Api_IIIHandler")]
			public abstract int DesfireDebitValueFile_Api (int p0, int p1, int p2);

			static Delegate? cb_DesfireDeleteApp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireDeleteApp_Api_arrayBHandler ()
			{
				if (cb_DesfireDeleteApp_Api_arrayB == null)
					cb_DesfireDeleteApp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireDeleteApp_Api_arrayB));
				return cb_DesfireDeleteApp_Api_arrayB;
			}

			static int n_DesfireDeleteApp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireDeleteApp_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDeleteApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireDeleteApp_Api", "([B)I", "GetDesfireDeleteApp_Api_arrayBHandler")]
			public abstract int DesfireDeleteApp_Api (byte[]? p0);

			static Delegate? cb_DesfireDeleteFile_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireDeleteFile_Api_IHandler ()
			{
				if (cb_DesfireDeleteFile_Api_I == null)
					cb_DesfireDeleteFile_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireDeleteFile_Api_I));
				return cb_DesfireDeleteFile_Api_I;
			}

			static int n_DesfireDeleteFile_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireDeleteFile_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDeleteFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireDeleteFile_Api", "(I)I", "GetDesfireDeleteFile_Api_IHandler")]
			public abstract int DesfireDeleteFile_Api (int p0);

			static Delegate? cb_DesfireFormatPicc_Api;
#pragma warning disable 0169
			static Delegate GetDesfireFormatPicc_ApiHandler ()
			{
				if (cb_DesfireFormatPicc_Api == null)
					cb_DesfireFormatPicc_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireFormatPicc_Api));
				return cb_DesfireFormatPicc_Api;
			}

			static int n_DesfireFormatPicc_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireFormatPicc_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireFormatPicc_Api' and count(parameter)=0]"
			[Register ("DesfireFormatPicc_Api", "()I", "GetDesfireFormatPicc_ApiHandler")]
			public abstract int DesfireFormatPicc_Api ();

			static Delegate? cb_DesfireGetAppIds_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetAppIds_Api_arrayBHandler ()
			{
				if (cb_DesfireGetAppIds_Api_arrayB == null)
					cb_DesfireGetAppIds_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetAppIds_Api_arrayB));
				return cb_DesfireGetAppIds_Api_arrayB;
			}

			static int n_DesfireGetAppIds_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetAppIds_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetAppIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetAppIds_Api", "([B)I", "GetDesfireGetAppIds_Api_arrayBHandler")]
			public abstract int DesfireGetAppIds_Api (byte[]? p0);

			static Delegate? cb_DesfireGetDFNameInfoList_Api;
#pragma warning disable 0169
			static Delegate GetDesfireGetDFNameInfoList_ApiHandler ()
			{
				if (cb_DesfireGetDFNameInfoList_Api == null)
					cb_DesfireGetDFNameInfoList_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DesfireGetDFNameInfoList_Api));
				return cb_DesfireGetDFNameInfoList_Api;
			}

			static IntPtr n_DesfireGetDFNameInfoList_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>.ToLocalJniHandle (__this.DesfireGetDFNameInfoList_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetDFNameInfoList_Api' and count(parameter)=0]"
			[Register ("DesfireGetDFNameInfoList_Api", "()Ljava/util/List;", "GetDesfireGetDFNameInfoList_ApiHandler")]
			public abstract global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>? DesfireGetDFNameInfoList_Api ();

			static Delegate? cb_DesfireGetFileIds_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetFileIds_Api_arrayBHandler ()
			{
				if (cb_DesfireGetFileIds_Api_arrayB == null)
					cb_DesfireGetFileIds_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetFileIds_Api_arrayB));
				return cb_DesfireGetFileIds_Api_arrayB;
			}

			static int n_DesfireGetFileIds_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetFileIds_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFileIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetFileIds_Api", "([B)I", "GetDesfireGetFileIds_Api_arrayBHandler")]
			public abstract int DesfireGetFileIds_Api (byte[]? p0);

			static Delegate? cb_DesfireGetFileSetting_Api_I;
#pragma warning disable 0169
			static Delegate GetDesfireGetFileSetting_Api_IHandler ()
			{
				if (cb_DesfireGetFileSetting_Api_I == null)
					cb_DesfireGetFileSetting_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_DesfireGetFileSetting_Api_I));
				return cb_DesfireGetFileSetting_Api_I;
			}

			static IntPtr n_DesfireGetFileSetting_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DesfireGetFileSetting_Api (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFileSetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireGetFileSetting_Api", "(I)Landroid/os/Bundle;", "GetDesfireGetFileSetting_Api_IHandler")]
			public abstract global::Android.OS.Bundle? DesfireGetFileSetting_Api (int p0);

			static Delegate? cb_DesfireGetFreeMemory_Api;
#pragma warning disable 0169
			static Delegate GetDesfireGetFreeMemory_ApiHandler ()
			{
				if (cb_DesfireGetFreeMemory_Api == null)
					cb_DesfireGetFreeMemory_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireGetFreeMemory_Api));
				return cb_DesfireGetFreeMemory_Api;
			}

			static int n_DesfireGetFreeMemory_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireGetFreeMemory_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFreeMemory_Api' and count(parameter)=0]"
			[Register ("DesfireGetFreeMemory_Api", "()I", "GetDesfireGetFreeMemory_ApiHandler")]
			public abstract int DesfireGetFreeMemory_Api ();

			static Delegate? cb_DesfireGetIsoFIDs_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetIsoFIDs_Api_arrayBHandler ()
			{
				if (cb_DesfireGetIsoFIDs_Api_arrayB == null)
					cb_DesfireGetIsoFIDs_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetIsoFIDs_Api_arrayB));
				return cb_DesfireGetIsoFIDs_Api_arrayB;
			}

			static int n_DesfireGetIsoFIDs_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetIsoFIDs_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetIsoFIDs_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetIsoFIDs_Api", "([B)I", "GetDesfireGetIsoFIDs_Api_arrayBHandler")]
			public abstract int DesfireGetIsoFIDs_Api (byte[]? p0);

			static Delegate? cb_DesfireGetKeySetting_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetKeySetting_Api_arrayBHandler ()
			{
				if (cb_DesfireGetKeySetting_Api_arrayB == null)
					cb_DesfireGetKeySetting_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetKeySetting_Api_arrayB));
				return cb_DesfireGetKeySetting_Api_arrayB;
			}

			static int n_DesfireGetKeySetting_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetKeySetting_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetKeySetting_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetKeySetting_Api", "([B)I", "GetDesfireGetKeySetting_Api_arrayBHandler")]
			public abstract int DesfireGetKeySetting_Api (byte[]? p0);

			static Delegate? cb_DesfireGetKeyVersion_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetKeyVersion_Api_IarrayBHandler ()
			{
				if (cb_DesfireGetKeyVersion_Api_IarrayB == null)
					cb_DesfireGetKeyVersion_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireGetKeyVersion_Api_IarrayB));
				return cb_DesfireGetKeyVersion_Api_IarrayB;
			}

			static int n_DesfireGetKeyVersion_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetKeyVersion_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetKeyVersion_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireGetKeyVersion_Api", "(I[B)I", "GetDesfireGetKeyVersion_Api_IarrayBHandler")]
			public abstract int DesfireGetKeyVersion_Api (int p0, byte[]? p1);

			static Delegate? cb_DesfireGetUid_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireGetUid_Api_arrayBHandler ()
			{
				if (cb_DesfireGetUid_Api_arrayB == null)
					cb_DesfireGetUid_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetUid_Api_arrayB));
				return cb_DesfireGetUid_Api_arrayB;
			}

			static int n_DesfireGetUid_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireGetUid_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetUid_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetUid_Api", "([B)I", "GetDesfireGetUid_Api_arrayBHandler")]
			public abstract int DesfireGetUid_Api (byte[]? p0);

			static Delegate? cb_DesfireGetValue_Api_IIarrayI;
#pragma warning disable 0169
			static Delegate GetDesfireGetValue_Api_IIarrayIHandler ()
			{
				if (cb_DesfireGetValue_Api_IIarrayI == null)
					cb_DesfireGetValue_Api_IIarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_DesfireGetValue_Api_IIarrayI));
				return cb_DesfireGetValue_Api_IIarrayI;
			}

			static int n_DesfireGetValue_Api_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (int[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.DesfireGetValue_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
			[Register ("DesfireGetValue_Api", "(II[I)I", "GetDesfireGetValue_Api_IIarrayIHandler")]
			public abstract int DesfireGetValue_Api (int p0, int p1, int[]? p2);

			static Delegate? cb_DesfireGetVersion_Api;
#pragma warning disable 0169
			static Delegate GetDesfireGetVersion_ApiHandler ()
			{
				if (cb_DesfireGetVersion_Api == null)
					cb_DesfireGetVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DesfireGetVersion_Api));
				return cb_DesfireGetVersion_Api;
			}

			static IntPtr n_DesfireGetVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DesfireGetVersion_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetVersion_Api' and count(parameter)=0]"
			[Register ("DesfireGetVersion_Api", "()Landroid/os/Bundle;", "GetDesfireGetVersion_ApiHandler")]
			public abstract global::Android.OS.Bundle? DesfireGetVersion_Api ();

			static Delegate? cb_DesfireLimitedCreditValue_Api_III;
#pragma warning disable 0169
			static Delegate GetDesfireLimitedCreditValue_Api_IIIHandler ()
			{
				if (cb_DesfireLimitedCreditValue_Api_III == null)
					cb_DesfireLimitedCreditValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireLimitedCreditValue_Api_III));
				return cb_DesfireLimitedCreditValue_Api_III;
			}

			static int n_DesfireLimitedCreditValue_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DesfireLimitedCreditValue_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireLimitedCreditValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireLimitedCreditValue_Api", "(III)I", "GetDesfireLimitedCreditValue_Api_IIIHandler")]
			public abstract int DesfireLimitedCreditValue_Api (int p0, int p1, int p2);

			static Delegate? cb_DesfireReadData_Api_CIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireReadData_Api_CIIIarrayBHandler ()
			{
				if (cb_DesfireReadData_Api_CIIIarrayB == null)
					cb_DesfireReadData_Api_CIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPCIIIL_I (n_DesfireReadData_Api_CIIIarrayB));
				return cb_DesfireReadData_Api_CIIIarrayB;
			}

			static int n_DesfireReadData_Api_CIIIarrayB (IntPtr jnienv, IntPtr native__this, char p0, int p1, int p2, int p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireReadData_Api (p0, p1, p2, p3, p4);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireReadData_Api' and count(parameter)=5 and parameter[1][@type='char'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireReadData_Api", "(CIII[B)I", "GetDesfireReadData_Api_CIIIarrayBHandler")]
			public abstract int DesfireReadData_Api (char p0, int p1, int p2, int p3, byte[]? p4);

			static Delegate? cb_DesfireReadRecord_Api_IIIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireReadRecord_Api_IIIIIarrayBHandler ()
			{
				if (cb_DesfireReadRecord_Api_IIIIIarrayB == null)
					cb_DesfireReadRecord_Api_IIIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIIL_I (n_DesfireReadRecord_Api_IIIIIarrayB));
				return cb_DesfireReadRecord_Api_IIIIIarrayB;
			}

			static int n_DesfireReadRecord_Api_IIIIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireReadRecord_Api (p0, p1, p2, p3, p4, p5);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireReadRecord_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("DesfireReadRecord_Api", "(IIIII[B)I", "GetDesfireReadRecord_Api_IIIIIarrayBHandler")]
			public abstract int DesfireReadRecord_Api (int p0, int p1, int p2, int p3, int p4, byte[]? p5);

			static Delegate? cb_DesfireSelectApp_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetDesfireSelectApp_Api_arrayBHandler ()
			{
				if (cb_DesfireSelectApp_Api_arrayB == null)
					cb_DesfireSelectApp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireSelectApp_Api_arrayB));
				return cb_DesfireSelectApp_Api_arrayB;
			}

			static int n_DesfireSelectApp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireSelectApp_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireSelectApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireSelectApp_Api", "([B)I", "GetDesfireSelectApp_Api_arrayBHandler")]
			public abstract int DesfireSelectApp_Api (byte[]? p0);

			static Delegate? cb_DesfireWriteCrecord_Api_IIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireWriteCrecord_Api_IIIIarrayBHandler ()
			{
				if (cb_DesfireWriteCrecord_Api_IIIIarrayB == null)
					cb_DesfireWriteCrecord_Api_IIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_DesfireWriteCrecord_Api_IIIIarrayB));
				return cb_DesfireWriteCrecord_Api_IIIIarrayB;
			}

			static int n_DesfireWriteCrecord_Api_IIIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireWriteCrecord_Api (p0, p1, p2, p3, p4);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireWriteCrecord_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireWriteCrecord_Api", "(IIII[B)I", "GetDesfireWriteCrecord_Api_IIIIarrayBHandler")]
			public abstract int DesfireWriteCrecord_Api (int p0, int p1, int p2, int p3, byte[]? p4);

			static Delegate? cb_DesfireWriteData_Api_IIIIarrayB;
#pragma warning disable 0169
			static Delegate GetDesfireWriteData_Api_IIIIarrayBHandler ()
			{
				if (cb_DesfireWriteData_Api_IIIIarrayB == null)
					cb_DesfireWriteData_Api_IIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_DesfireWriteData_Api_IIIIarrayB));
				return cb_DesfireWriteData_Api_IIIIarrayB;
			}

			static int n_DesfireWriteData_Api_IIIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.DesfireWriteData_Api (p0, p1, p2, p3, p4);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireWriteData_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireWriteData_Api", "(IIII[B)I", "GetDesfireWriteData_Api_IIIIarrayBHandler")]
			public abstract int DesfireWriteData_Api (int p0, int p1, int p2, int p3, byte[]? p4);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/DesfireHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/DesfireHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAbortTransaction_Api' and count(parameter)=0]"
			[Register ("DesfireAbortTransaction_Api", "()I", "GetDesfireAbortTransaction_ApiHandler")]
			public override unsafe int DesfireAbortTransaction_Api ()
			{
				const string __id = "DesfireAbortTransaction_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuthAes_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuthAes_Api", "(I[B)I", "GetDesfireAuthAes_Api_IarrayBHandler")]
			public override unsafe int DesfireAuthAes_Api (int p0, byte[]? p1)
			{
				const string __id = "DesfireAuthAes_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuthIso_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuthIso_Api", "(I[B)I", "GetDesfireAuthIso_Api_IarrayBHandler")]
			public override unsafe int DesfireAuthIso_Api (int p0, byte[]? p1)
			{
				const string __id = "DesfireAuthIso_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireAuth_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireAuth_Api", "(I[B)I", "GetDesfireAuth_Api_IarrayBHandler")]
			public override unsafe int DesfireAuth_Api (int p0, byte[]? p1)
			{
				const string __id = "DesfireAuth_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardCheck_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("DesfireCardCheck_Api", "(I[B[B)I", "GetDesfireCardCheck_Api_IarrayBarrayBHandler")]
			public override unsafe int DesfireCardCheck_Api (int p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "DesfireCardCheck_Api.(I[B[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
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
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardClose_Api' and count(parameter)=0]"
			[Register ("DesfireCardClose_Api", "()I", "GetDesfireCardClose_ApiHandler")]
			public override unsafe int DesfireCardClose_Api ()
			{
				const string __id = "DesfireCardClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCardOpen_Api' and count(parameter)=0]"
			[Register ("DesfireCardOpen_Api", "()I", "GetDesfireCardOpen_ApiHandler")]
			public override unsafe int DesfireCardOpen_Api ()
			{
				const string __id = "DesfireCardOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeAppKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("DesfireChangeAppKey_Api", "(III[B[BI)I", "GetDesfireChangeAppKey_Api_IIIarrayBarrayBIHandler")]
			public override unsafe int DesfireChangeAppKey_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, int p5)
			{
				const string __id = "DesfireChangeAppKey_Api.(III[B[BI)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeFileSettings_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
			[Register ("DesfireChangeFileSettings_Api", "(IIIIIII)I", "GetDesfireChangeFileSettings_Api_IIIIIIIHandler")]
			public override unsafe int DesfireChangeFileSettings_Api (int p0, int p1, int p2, int p3, int p4, int p5, int p6)
			{
				const string __id = "DesfireChangeFileSettings_Api.(IIIIIII)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangeKeySetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireChangeKeySetting_Api", "(I)I", "GetDesfireChangeKeySetting_Api_IHandler")]
			public override unsafe int DesfireChangeKeySetting_Api (int p0)
			{
				const string __id = "DesfireChangeKeySetting_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireChangePiccMkey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("DesfireChangePiccMkey_Api", "(I[BI)I", "GetDesfireChangePiccMkey_Api_IarrayBIHandler")]
			public override unsafe int DesfireChangePiccMkey_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "DesfireChangePiccMkey_Api.(I[BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireClearRecordFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireClearRecordFile_Api", "(I)I", "GetDesfireClearRecordFile_Api_IHandler")]
			public override unsafe int DesfireClearRecordFile_Api (int p0)
			{
				const string __id = "DesfireClearRecordFile_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCommitTransaction_Api' and count(parameter)=0]"
			[Register ("DesfireCommitTransaction_Api", "()I", "GetDesfireCommitTransaction_ApiHandler")]
			public override unsafe int DesfireCommitTransaction_Api ()
			{
				const string __id = "DesfireCommitTransaction_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateApp_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("DesfireCreateApp_Api", "(Landroid/os/Bundle;)I", "GetDesfireCreateApp_Api_Landroid_os_Bundle_Handler")]
			public override unsafe int DesfireCreateApp_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "DesfireCreateApp_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateBackupFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateBackupFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateBackupFile_Api_ILandroid_os_Bundle_Handler")]
			public override unsafe int DesfireCreateBackupFile_Api (int p0, global::Android.OS.Bundle? p1)
			{
				const string __id = "DesfireCreateBackupFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateCyclicrecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateCyclicrecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_Handler")]
			public override unsafe int DesfireCreateCyclicrecordFile_Api (int p0, global::Android.OS.Bundle? p1)
			{
				const string __id = "DesfireCreateCyclicrecordFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateRecordFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateRecordFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateRecordFile_Api_ILandroid_os_Bundle_Handler")]
			public override unsafe int DesfireCreateRecordFile_Api (int p0, global::Android.OS.Bundle? p1)
			{
				const string __id = "DesfireCreateRecordFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateStdFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateStdFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateStdFile_Api_ILandroid_os_Bundle_Handler")]
			public override unsafe int DesfireCreateStdFile_Api (int p0, global::Android.OS.Bundle? p1)
			{
				const string __id = "DesfireCreateStdFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreateValueFile_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("DesfireCreateValueFile_Api", "(ILandroid/os/Bundle;)I", "GetDesfireCreateValueFile_Api_ILandroid_os_Bundle_Handler")]
			public override unsafe int DesfireCreateValueFile_Api (int p0, global::Android.OS.Bundle? p1)
			{
				const string __id = "DesfireCreateValueFile_Api.(ILandroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireCreditValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireCreditValueFile_Api", "(III)I", "GetDesfireCreditValueFile_Api_IIIHandler")]
			public override unsafe int DesfireCreditValueFile_Api (int p0, int p1, int p2)
			{
				const string __id = "DesfireCreditValueFile_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDebitValueFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireDebitValueFile_Api", "(III)I", "GetDesfireDebitValueFile_Api_IIIHandler")]
			public override unsafe int DesfireDebitValueFile_Api (int p0, int p1, int p2)
			{
				const string __id = "DesfireDebitValueFile_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDeleteApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireDeleteApp_Api", "([B)I", "GetDesfireDeleteApp_Api_arrayBHandler")]
			public override unsafe int DesfireDeleteApp_Api (byte[]? p0)
			{
				const string __id = "DesfireDeleteApp_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireDeleteFile_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireDeleteFile_Api", "(I)I", "GetDesfireDeleteFile_Api_IHandler")]
			public override unsafe int DesfireDeleteFile_Api (int p0)
			{
				const string __id = "DesfireDeleteFile_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireFormatPicc_Api' and count(parameter)=0]"
			[Register ("DesfireFormatPicc_Api", "()I", "GetDesfireFormatPicc_ApiHandler")]
			public override unsafe int DesfireFormatPicc_Api ()
			{
				const string __id = "DesfireFormatPicc_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetAppIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetAppIds_Api", "([B)I", "GetDesfireGetAppIds_Api_arrayBHandler")]
			public override unsafe int DesfireGetAppIds_Api (byte[]? p0)
			{
				const string __id = "DesfireGetAppIds_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetDFNameInfoList_Api' and count(parameter)=0]"
			[Register ("DesfireGetDFNameInfoList_Api", "()Ljava/util/List;", "GetDesfireGetDFNameInfoList_ApiHandler")]
			public override unsafe global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>? DesfireGetDFNameInfoList_Api ()
			{
				const string __id = "DesfireGetDFNameInfoList_Api.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFileIds_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetFileIds_Api", "([B)I", "GetDesfireGetFileIds_Api_arrayBHandler")]
			public override unsafe int DesfireGetFileIds_Api (byte[]? p0)
			{
				const string __id = "DesfireGetFileIds_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFileSetting_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("DesfireGetFileSetting_Api", "(I)Landroid/os/Bundle;", "GetDesfireGetFileSetting_Api_IHandler")]
			public override unsafe global::Android.OS.Bundle? DesfireGetFileSetting_Api (int p0)
			{
				const string __id = "DesfireGetFileSetting_Api.(I)Landroid/os/Bundle;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetFreeMemory_Api' and count(parameter)=0]"
			[Register ("DesfireGetFreeMemory_Api", "()I", "GetDesfireGetFreeMemory_ApiHandler")]
			public override unsafe int DesfireGetFreeMemory_Api ()
			{
				const string __id = "DesfireGetFreeMemory_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetIsoFIDs_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetIsoFIDs_Api", "([B)I", "GetDesfireGetIsoFIDs_Api_arrayBHandler")]
			public override unsafe int DesfireGetIsoFIDs_Api (byte[]? p0)
			{
				const string __id = "DesfireGetIsoFIDs_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetKeySetting_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetKeySetting_Api", "([B)I", "GetDesfireGetKeySetting_Api_arrayBHandler")]
			public override unsafe int DesfireGetKeySetting_Api (byte[]? p0)
			{
				const string __id = "DesfireGetKeySetting_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetKeyVersion_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("DesfireGetKeyVersion_Api", "(I[B)I", "GetDesfireGetKeyVersion_Api_IarrayBHandler")]
			public override unsafe int DesfireGetKeyVersion_Api (int p0, byte[]? p1)
			{
				const string __id = "DesfireGetKeyVersion_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetUid_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireGetUid_Api", "([B)I", "GetDesfireGetUid_Api_arrayBHandler")]
			public override unsafe int DesfireGetUid_Api (byte[]? p0)
			{
				const string __id = "DesfireGetUid_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
			[Register ("DesfireGetValue_Api", "(II[I)I", "GetDesfireGetValue_Api_IIarrayIHandler")]
			public override unsafe int DesfireGetValue_Api (int p0, int p1, int[]? p2)
			{
				const string __id = "DesfireGetValue_Api.(II[I)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireGetVersion_Api' and count(parameter)=0]"
			[Register ("DesfireGetVersion_Api", "()Landroid/os/Bundle;", "GetDesfireGetVersion_ApiHandler")]
			public override unsafe global::Android.OS.Bundle? DesfireGetVersion_Api ()
			{
				const string __id = "DesfireGetVersion_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireLimitedCreditValue_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("DesfireLimitedCreditValue_Api", "(III)I", "GetDesfireLimitedCreditValue_Api_IIIHandler")]
			public override unsafe int DesfireLimitedCreditValue_Api (int p0, int p1, int p2)
			{
				const string __id = "DesfireLimitedCreditValue_Api.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireReadData_Api' and count(parameter)=5 and parameter[1][@type='char'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireReadData_Api", "(CIII[B)I", "GetDesfireReadData_Api_CIIIarrayBHandler")]
			public override unsafe int DesfireReadData_Api (char p0, int p1, int p2, int p3, byte[]? p4)
			{
				const string __id = "DesfireReadData_Api.(CIII[B)I";
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireReadRecord_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("DesfireReadRecord_Api", "(IIIII[B)I", "GetDesfireReadRecord_Api_IIIIIarrayBHandler")]
			public override unsafe int DesfireReadRecord_Api (int p0, int p1, int p2, int p3, int p4, byte[]? p5)
			{
				const string __id = "DesfireReadRecord_Api.(IIIII[B)I";
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireSelectApp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("DesfireSelectApp_Api", "([B)I", "GetDesfireSelectApp_Api_arrayBHandler")]
			public override unsafe int DesfireSelectApp_Api (byte[]? p0)
			{
				const string __id = "DesfireSelectApp_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireWriteCrecord_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireWriteCrecord_Api", "(IIII[B)I", "GetDesfireWriteCrecord_Api_IIIIarrayBHandler")]
			public override unsafe int DesfireWriteCrecord_Api (int p0, int p1, int p2, int p3, byte[]? p4)
			{
				const string __id = "DesfireWriteCrecord_Api.(IIII[B)I";
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.cards']/interface[@name='DesfireHandler']/method[@name='DesfireWriteData_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
			[Register ("DesfireWriteData_Api", "(IIII[B)I", "GetDesfireWriteData_Api_IIIIarrayBHandler")]
			public override unsafe int DesfireWriteData_Api (int p0, int p1, int p2, int p3, byte[]? p4)
			{
				const string __id = "DesfireWriteData_Api.(IIII[B)I";
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p4);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/cards/DesfireHandler", DoNotGenerateAcw=true)]
	internal partial class IDesfireHandlerInvoker : global::Java.Lang.Object, IDesfireHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/cards/DesfireHandler", typeof (IDesfireHandlerInvoker));

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

		public static IDesfireHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDesfireHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.cards.DesfireHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDesfireHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_DesfireAbortTransaction_Api;
#pragma warning disable 0169
		static Delegate GetDesfireAbortTransaction_ApiHandler ()
		{
			if (cb_DesfireAbortTransaction_Api == null)
				cb_DesfireAbortTransaction_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireAbortTransaction_Api));
			return cb_DesfireAbortTransaction_Api;
		}

		static int n_DesfireAbortTransaction_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireAbortTransaction_Api ();
		}
#pragma warning restore 0169

		IntPtr id_DesfireAbortTransaction_Api;
		public unsafe int DesfireAbortTransaction_Api ()
		{
			if (id_DesfireAbortTransaction_Api == IntPtr.Zero)
				id_DesfireAbortTransaction_Api = JNIEnv.GetMethodID (class_ref, "DesfireAbortTransaction_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireAbortTransaction_Api);
		}

		static Delegate? cb_DesfireAuthAes_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireAuthAes_Api_IarrayBHandler ()
		{
			if (cb_DesfireAuthAes_Api_IarrayB == null)
				cb_DesfireAuthAes_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuthAes_Api_IarrayB));
			return cb_DesfireAuthAes_Api_IarrayB;
		}

		static int n_DesfireAuthAes_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireAuthAes_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireAuthAes_Api_IarrayB;
		public unsafe int DesfireAuthAes_Api (int p0, byte[]? p1)
		{
			if (id_DesfireAuthAes_Api_IarrayB == IntPtr.Zero)
				id_DesfireAuthAes_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "DesfireAuthAes_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireAuthAes_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_DesfireAuthIso_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireAuthIso_Api_IarrayBHandler ()
		{
			if (cb_DesfireAuthIso_Api_IarrayB == null)
				cb_DesfireAuthIso_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuthIso_Api_IarrayB));
			return cb_DesfireAuthIso_Api_IarrayB;
		}

		static int n_DesfireAuthIso_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireAuthIso_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireAuthIso_Api_IarrayB;
		public unsafe int DesfireAuthIso_Api (int p0, byte[]? p1)
		{
			if (id_DesfireAuthIso_Api_IarrayB == IntPtr.Zero)
				id_DesfireAuthIso_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "DesfireAuthIso_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireAuthIso_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_DesfireAuth_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireAuth_Api_IarrayBHandler ()
		{
			if (cb_DesfireAuth_Api_IarrayB == null)
				cb_DesfireAuth_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireAuth_Api_IarrayB));
			return cb_DesfireAuth_Api_IarrayB;
		}

		static int n_DesfireAuth_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireAuth_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireAuth_Api_IarrayB;
		public unsafe int DesfireAuth_Api (int p0, byte[]? p1)
		{
			if (id_DesfireAuth_Api_IarrayB == IntPtr.Zero)
				id_DesfireAuth_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "DesfireAuth_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireAuth_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_DesfireCardCheck_Api_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireCardCheck_Api_IarrayBarrayBHandler ()
		{
			if (cb_DesfireCardCheck_Api_IarrayBarrayB == null)
				cb_DesfireCardCheck_Api_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_DesfireCardCheck_Api_IarrayBarrayB));
			return cb_DesfireCardCheck_Api_IarrayBarrayB;
		}

		static int n_DesfireCardCheck_Api_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireCardCheck_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireCardCheck_Api_IarrayBarrayB;
		public unsafe int DesfireCardCheck_Api (int p0, byte[]? p1, byte[]? p2)
		{
			if (id_DesfireCardCheck_Api_IarrayBarrayB == IntPtr.Zero)
				id_DesfireCardCheck_Api_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "DesfireCardCheck_Api", "(I[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCardCheck_Api_IarrayBarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_DesfireCardClose_Api;
#pragma warning disable 0169
		static Delegate GetDesfireCardClose_ApiHandler ()
		{
			if (cb_DesfireCardClose_Api == null)
				cb_DesfireCardClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCardClose_Api));
			return cb_DesfireCardClose_Api;
		}

		static int n_DesfireCardClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireCardClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_DesfireCardClose_Api;
		public unsafe int DesfireCardClose_Api ()
		{
			if (id_DesfireCardClose_Api == IntPtr.Zero)
				id_DesfireCardClose_Api = JNIEnv.GetMethodID (class_ref, "DesfireCardClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCardClose_Api);
		}

		static Delegate? cb_DesfireCardOpen_Api;
#pragma warning disable 0169
		static Delegate GetDesfireCardOpen_ApiHandler ()
		{
			if (cb_DesfireCardOpen_Api == null)
				cb_DesfireCardOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCardOpen_Api));
			return cb_DesfireCardOpen_Api;
		}

		static int n_DesfireCardOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireCardOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_DesfireCardOpen_Api;
		public unsafe int DesfireCardOpen_Api ()
		{
			if (id_DesfireCardOpen_Api == IntPtr.Zero)
				id_DesfireCardOpen_Api = JNIEnv.GetMethodID (class_ref, "DesfireCardOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCardOpen_Api);
		}

		static Delegate? cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetDesfireChangeAppKey_Api_IIIarrayBarrayBIHandler ()
		{
			if (cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI == null)
				cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILLI_I (n_DesfireChangeAppKey_Api_IIIarrayBarrayBI));
			return cb_DesfireChangeAppKey_Api_IIIarrayBarrayBI;
		}

		static int n_DesfireChangeAppKey_Api_IIIarrayBarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireChangeAppKey_Api (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireChangeAppKey_Api_IIIarrayBarrayBI;
		public unsafe int DesfireChangeAppKey_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, int p5)
		{
			if (id_DesfireChangeAppKey_Api_IIIarrayBarrayBI == IntPtr.Zero)
				id_DesfireChangeAppKey_Api_IIIarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "DesfireChangeAppKey_Api", "(III[B[BI)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireChangeAppKey_Api_IIIarrayBarrayBI, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_DesfireChangeFileSettings_Api_IIIIIII;
#pragma warning disable 0169
		static Delegate GetDesfireChangeFileSettings_Api_IIIIIIIHandler ()
		{
			if (cb_DesfireChangeFileSettings_Api_IIIIIII == null)
				cb_DesfireChangeFileSettings_Api_IIIIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIIII_I (n_DesfireChangeFileSettings_Api_IIIIIII));
			return cb_DesfireChangeFileSettings_Api_IIIIIII;
		}

		static int n_DesfireChangeFileSettings_Api_IIIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireChangeFileSettings_Api (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		IntPtr id_DesfireChangeFileSettings_Api_IIIIIII;
		public unsafe int DesfireChangeFileSettings_Api (int p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_DesfireChangeFileSettings_Api_IIIIIII == IntPtr.Zero)
				id_DesfireChangeFileSettings_Api_IIIIIII = JNIEnv.GetMethodID (class_ref, "DesfireChangeFileSettings_Api", "(IIIIIII)I");
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (p6);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireChangeFileSettings_Api_IIIIIII, __args);
		}

		static Delegate? cb_DesfireChangeKeySetting_Api_I;
#pragma warning disable 0169
		static Delegate GetDesfireChangeKeySetting_Api_IHandler ()
		{
			if (cb_DesfireChangeKeySetting_Api_I == null)
				cb_DesfireChangeKeySetting_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireChangeKeySetting_Api_I));
			return cb_DesfireChangeKeySetting_Api_I;
		}

		static int n_DesfireChangeKeySetting_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireChangeKeySetting_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_DesfireChangeKeySetting_Api_I;
		public unsafe int DesfireChangeKeySetting_Api (int p0)
		{
			if (id_DesfireChangeKeySetting_Api_I == IntPtr.Zero)
				id_DesfireChangeKeySetting_Api_I = JNIEnv.GetMethodID (class_ref, "DesfireChangeKeySetting_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireChangeKeySetting_Api_I, __args);
		}

		static Delegate? cb_DesfireChangePiccMkey_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetDesfireChangePiccMkey_Api_IarrayBIHandler ()
		{
			if (cb_DesfireChangePiccMkey_Api_IarrayBI == null)
				cb_DesfireChangePiccMkey_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_DesfireChangePiccMkey_Api_IarrayBI));
			return cb_DesfireChangePiccMkey_Api_IarrayBI;
		}

		static int n_DesfireChangePiccMkey_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireChangePiccMkey_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireChangePiccMkey_Api_IarrayBI;
		public unsafe int DesfireChangePiccMkey_Api (int p0, byte[]? p1, int p2)
		{
			if (id_DesfireChangePiccMkey_Api_IarrayBI == IntPtr.Zero)
				id_DesfireChangePiccMkey_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "DesfireChangePiccMkey_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireChangePiccMkey_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_DesfireClearRecordFile_Api_I;
#pragma warning disable 0169
		static Delegate GetDesfireClearRecordFile_Api_IHandler ()
		{
			if (cb_DesfireClearRecordFile_Api_I == null)
				cb_DesfireClearRecordFile_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireClearRecordFile_Api_I));
			return cb_DesfireClearRecordFile_Api_I;
		}

		static int n_DesfireClearRecordFile_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireClearRecordFile_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_DesfireClearRecordFile_Api_I;
		public unsafe int DesfireClearRecordFile_Api (int p0)
		{
			if (id_DesfireClearRecordFile_Api_I == IntPtr.Zero)
				id_DesfireClearRecordFile_Api_I = JNIEnv.GetMethodID (class_ref, "DesfireClearRecordFile_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireClearRecordFile_Api_I, __args);
		}

		static Delegate? cb_DesfireCommitTransaction_Api;
#pragma warning disable 0169
		static Delegate GetDesfireCommitTransaction_ApiHandler ()
		{
			if (cb_DesfireCommitTransaction_Api == null)
				cb_DesfireCommitTransaction_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireCommitTransaction_Api));
			return cb_DesfireCommitTransaction_Api;
		}

		static int n_DesfireCommitTransaction_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireCommitTransaction_Api ();
		}
#pragma warning restore 0169

		IntPtr id_DesfireCommitTransaction_Api;
		public unsafe int DesfireCommitTransaction_Api ()
		{
			if (id_DesfireCommitTransaction_Api == IntPtr.Zero)
				id_DesfireCommitTransaction_Api = JNIEnv.GetMethodID (class_ref, "DesfireCommitTransaction_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCommitTransaction_Api);
		}

		static Delegate? cb_DesfireCreateApp_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDesfireCreateApp_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_DesfireCreateApp_Api_Landroid_os_Bundle_ == null)
				cb_DesfireCreateApp_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireCreateApp_Api_Landroid_os_Bundle_));
			return cb_DesfireCreateApp_Api_Landroid_os_Bundle_;
		}

		static int n_DesfireCreateApp_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesfireCreateApp_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireCreateApp_Api_Landroid_os_Bundle_;
		public unsafe int DesfireCreateApp_Api (global::Android.OS.Bundle? p0)
		{
			if (id_DesfireCreateApp_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_DesfireCreateApp_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "DesfireCreateApp_Api", "(Landroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCreateApp_Api_Landroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDesfireCreateBackupFile_Api_ILandroid_os_Bundle_Handler ()
		{
			if (cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ == null)
				cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_));
			return cb_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_;
		}

		static int n_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesfireCreateBackupFile_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_;
		public unsafe int DesfireCreateBackupFile_Api (int p0, global::Android.OS.Bundle? p1)
		{
			if (id_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "DesfireCreateBackupFile_Api", "(ILandroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCreateBackupFile_Api_ILandroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_Handler ()
		{
			if (cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ == null)
				cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_));
			return cb_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_;
		}

		static int n_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesfireCreateCyclicrecordFile_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_;
		public unsafe int DesfireCreateCyclicrecordFile_Api (int p0, global::Android.OS.Bundle? p1)
		{
			if (id_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "DesfireCreateCyclicrecordFile_Api", "(ILandroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCreateCyclicrecordFile_Api_ILandroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDesfireCreateRecordFile_Api_ILandroid_os_Bundle_Handler ()
		{
			if (cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ == null)
				cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_));
			return cb_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_;
		}

		static int n_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesfireCreateRecordFile_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_;
		public unsafe int DesfireCreateRecordFile_Api (int p0, global::Android.OS.Bundle? p1)
		{
			if (id_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "DesfireCreateRecordFile_Api", "(ILandroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCreateRecordFile_Api_ILandroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDesfireCreateStdFile_Api_ILandroid_os_Bundle_Handler ()
		{
			if (cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ == null)
				cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateStdFile_Api_ILandroid_os_Bundle_));
			return cb_DesfireCreateStdFile_Api_ILandroid_os_Bundle_;
		}

		static int n_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesfireCreateStdFile_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireCreateStdFile_Api_ILandroid_os_Bundle_;
		public unsafe int DesfireCreateStdFile_Api (int p0, global::Android.OS.Bundle? p1)
		{
			if (id_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_DesfireCreateStdFile_Api_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "DesfireCreateStdFile_Api", "(ILandroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCreateStdFile_Api_ILandroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDesfireCreateValueFile_Api_ILandroid_os_Bundle_Handler ()
		{
			if (cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ == null)
				cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireCreateValueFile_Api_ILandroid_os_Bundle_));
			return cb_DesfireCreateValueFile_Api_ILandroid_os_Bundle_;
		}

		static int n_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesfireCreateValueFile_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireCreateValueFile_Api_ILandroid_os_Bundle_;
		public unsafe int DesfireCreateValueFile_Api (int p0, global::Android.OS.Bundle? p1)
		{
			if (id_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_DesfireCreateValueFile_Api_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "DesfireCreateValueFile_Api", "(ILandroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCreateValueFile_Api_ILandroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_DesfireCreditValueFile_Api_III;
#pragma warning disable 0169
		static Delegate GetDesfireCreditValueFile_Api_IIIHandler ()
		{
			if (cb_DesfireCreditValueFile_Api_III == null)
				cb_DesfireCreditValueFile_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireCreditValueFile_Api_III));
			return cb_DesfireCreditValueFile_Api_III;
		}

		static int n_DesfireCreditValueFile_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireCreditValueFile_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_DesfireCreditValueFile_Api_III;
		public unsafe int DesfireCreditValueFile_Api (int p0, int p1, int p2)
		{
			if (id_DesfireCreditValueFile_Api_III == IntPtr.Zero)
				id_DesfireCreditValueFile_Api_III = JNIEnv.GetMethodID (class_ref, "DesfireCreditValueFile_Api", "(III)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireCreditValueFile_Api_III, __args);
		}

		static Delegate? cb_DesfireDebitValueFile_Api_III;
#pragma warning disable 0169
		static Delegate GetDesfireDebitValueFile_Api_IIIHandler ()
		{
			if (cb_DesfireDebitValueFile_Api_III == null)
				cb_DesfireDebitValueFile_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireDebitValueFile_Api_III));
			return cb_DesfireDebitValueFile_Api_III;
		}

		static int n_DesfireDebitValueFile_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireDebitValueFile_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_DesfireDebitValueFile_Api_III;
		public unsafe int DesfireDebitValueFile_Api (int p0, int p1, int p2)
		{
			if (id_DesfireDebitValueFile_Api_III == IntPtr.Zero)
				id_DesfireDebitValueFile_Api_III = JNIEnv.GetMethodID (class_ref, "DesfireDebitValueFile_Api", "(III)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireDebitValueFile_Api_III, __args);
		}

		static Delegate? cb_DesfireDeleteApp_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetDesfireDeleteApp_Api_arrayBHandler ()
		{
			if (cb_DesfireDeleteApp_Api_arrayB == null)
				cb_DesfireDeleteApp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireDeleteApp_Api_arrayB));
			return cb_DesfireDeleteApp_Api_arrayB;
		}

		static int n_DesfireDeleteApp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireDeleteApp_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireDeleteApp_Api_arrayB;
		public unsafe int DesfireDeleteApp_Api (byte[]? p0)
		{
			if (id_DesfireDeleteApp_Api_arrayB == IntPtr.Zero)
				id_DesfireDeleteApp_Api_arrayB = JNIEnv.GetMethodID (class_ref, "DesfireDeleteApp_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireDeleteApp_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DesfireDeleteFile_Api_I;
#pragma warning disable 0169
		static Delegate GetDesfireDeleteFile_Api_IHandler ()
		{
			if (cb_DesfireDeleteFile_Api_I == null)
				cb_DesfireDeleteFile_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_DesfireDeleteFile_Api_I));
			return cb_DesfireDeleteFile_Api_I;
		}

		static int n_DesfireDeleteFile_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireDeleteFile_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_DesfireDeleteFile_Api_I;
		public unsafe int DesfireDeleteFile_Api (int p0)
		{
			if (id_DesfireDeleteFile_Api_I == IntPtr.Zero)
				id_DesfireDeleteFile_Api_I = JNIEnv.GetMethodID (class_ref, "DesfireDeleteFile_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireDeleteFile_Api_I, __args);
		}

		static Delegate? cb_DesfireFormatPicc_Api;
#pragma warning disable 0169
		static Delegate GetDesfireFormatPicc_ApiHandler ()
		{
			if (cb_DesfireFormatPicc_Api == null)
				cb_DesfireFormatPicc_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireFormatPicc_Api));
			return cb_DesfireFormatPicc_Api;
		}

		static int n_DesfireFormatPicc_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireFormatPicc_Api ();
		}
#pragma warning restore 0169

		IntPtr id_DesfireFormatPicc_Api;
		public unsafe int DesfireFormatPicc_Api ()
		{
			if (id_DesfireFormatPicc_Api == IntPtr.Zero)
				id_DesfireFormatPicc_Api = JNIEnv.GetMethodID (class_ref, "DesfireFormatPicc_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireFormatPicc_Api);
		}

		static Delegate? cb_DesfireGetAppIds_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetDesfireGetAppIds_Api_arrayBHandler ()
		{
			if (cb_DesfireGetAppIds_Api_arrayB == null)
				cb_DesfireGetAppIds_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetAppIds_Api_arrayB));
			return cb_DesfireGetAppIds_Api_arrayB;
		}

		static int n_DesfireGetAppIds_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireGetAppIds_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetAppIds_Api_arrayB;
		public unsafe int DesfireGetAppIds_Api (byte[]? p0)
		{
			if (id_DesfireGetAppIds_Api_arrayB == IntPtr.Zero)
				id_DesfireGetAppIds_Api_arrayB = JNIEnv.GetMethodID (class_ref, "DesfireGetAppIds_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetAppIds_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DesfireGetDFNameInfoList_Api;
#pragma warning disable 0169
		static Delegate GetDesfireGetDFNameInfoList_ApiHandler ()
		{
			if (cb_DesfireGetDFNameInfoList_Api == null)
				cb_DesfireGetDFNameInfoList_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DesfireGetDFNameInfoList_Api));
			return cb_DesfireGetDFNameInfoList_Api;
		}

		static IntPtr n_DesfireGetDFNameInfoList_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>.ToLocalJniHandle (__this.DesfireGetDFNameInfoList_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetDFNameInfoList_Api;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>? DesfireGetDFNameInfoList_Api ()
		{
			if (id_DesfireGetDFNameInfoList_Api == IntPtr.Zero)
				id_DesfireGetDFNameInfoList_Api = JNIEnv.GetMethodID (class_ref, "DesfireGetDFNameInfoList_Api", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Vanstone.Appsdk.Api.Struct.DFNameInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetDFNameInfoList_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DesfireGetFileIds_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetDesfireGetFileIds_Api_arrayBHandler ()
		{
			if (cb_DesfireGetFileIds_Api_arrayB == null)
				cb_DesfireGetFileIds_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetFileIds_Api_arrayB));
			return cb_DesfireGetFileIds_Api_arrayB;
		}

		static int n_DesfireGetFileIds_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireGetFileIds_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetFileIds_Api_arrayB;
		public unsafe int DesfireGetFileIds_Api (byte[]? p0)
		{
			if (id_DesfireGetFileIds_Api_arrayB == IntPtr.Zero)
				id_DesfireGetFileIds_Api_arrayB = JNIEnv.GetMethodID (class_ref, "DesfireGetFileIds_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetFileIds_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DesfireGetFileSetting_Api_I;
#pragma warning disable 0169
		static Delegate GetDesfireGetFileSetting_Api_IHandler ()
		{
			if (cb_DesfireGetFileSetting_Api_I == null)
				cb_DesfireGetFileSetting_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_DesfireGetFileSetting_Api_I));
			return cb_DesfireGetFileSetting_Api_I;
		}

		static IntPtr n_DesfireGetFileSetting_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.DesfireGetFileSetting_Api (p0));
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetFileSetting_Api_I;
		public unsafe global::Android.OS.Bundle? DesfireGetFileSetting_Api (int p0)
		{
			if (id_DesfireGetFileSetting_Api_I == IntPtr.Zero)
				id_DesfireGetFileSetting_Api_I = JNIEnv.GetMethodID (class_ref, "DesfireGetFileSetting_Api", "(I)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetFileSetting_Api_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DesfireGetFreeMemory_Api;
#pragma warning disable 0169
		static Delegate GetDesfireGetFreeMemory_ApiHandler ()
		{
			if (cb_DesfireGetFreeMemory_Api == null)
				cb_DesfireGetFreeMemory_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_DesfireGetFreeMemory_Api));
			return cb_DesfireGetFreeMemory_Api;
		}

		static int n_DesfireGetFreeMemory_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireGetFreeMemory_Api ();
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetFreeMemory_Api;
		public unsafe int DesfireGetFreeMemory_Api ()
		{
			if (id_DesfireGetFreeMemory_Api == IntPtr.Zero)
				id_DesfireGetFreeMemory_Api = JNIEnv.GetMethodID (class_ref, "DesfireGetFreeMemory_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetFreeMemory_Api);
		}

		static Delegate? cb_DesfireGetIsoFIDs_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetDesfireGetIsoFIDs_Api_arrayBHandler ()
		{
			if (cb_DesfireGetIsoFIDs_Api_arrayB == null)
				cb_DesfireGetIsoFIDs_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetIsoFIDs_Api_arrayB));
			return cb_DesfireGetIsoFIDs_Api_arrayB;
		}

		static int n_DesfireGetIsoFIDs_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireGetIsoFIDs_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetIsoFIDs_Api_arrayB;
		public unsafe int DesfireGetIsoFIDs_Api (byte[]? p0)
		{
			if (id_DesfireGetIsoFIDs_Api_arrayB == IntPtr.Zero)
				id_DesfireGetIsoFIDs_Api_arrayB = JNIEnv.GetMethodID (class_ref, "DesfireGetIsoFIDs_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetIsoFIDs_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DesfireGetKeySetting_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetDesfireGetKeySetting_Api_arrayBHandler ()
		{
			if (cb_DesfireGetKeySetting_Api_arrayB == null)
				cb_DesfireGetKeySetting_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetKeySetting_Api_arrayB));
			return cb_DesfireGetKeySetting_Api_arrayB;
		}

		static int n_DesfireGetKeySetting_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireGetKeySetting_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetKeySetting_Api_arrayB;
		public unsafe int DesfireGetKeySetting_Api (byte[]? p0)
		{
			if (id_DesfireGetKeySetting_Api_arrayB == IntPtr.Zero)
				id_DesfireGetKeySetting_Api_arrayB = JNIEnv.GetMethodID (class_ref, "DesfireGetKeySetting_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetKeySetting_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DesfireGetKeyVersion_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireGetKeyVersion_Api_IarrayBHandler ()
		{
			if (cb_DesfireGetKeyVersion_Api_IarrayB == null)
				cb_DesfireGetKeyVersion_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_DesfireGetKeyVersion_Api_IarrayB));
			return cb_DesfireGetKeyVersion_Api_IarrayB;
		}

		static int n_DesfireGetKeyVersion_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireGetKeyVersion_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetKeyVersion_Api_IarrayB;
		public unsafe int DesfireGetKeyVersion_Api (int p0, byte[]? p1)
		{
			if (id_DesfireGetKeyVersion_Api_IarrayB == IntPtr.Zero)
				id_DesfireGetKeyVersion_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "DesfireGetKeyVersion_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetKeyVersion_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_DesfireGetUid_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetDesfireGetUid_Api_arrayBHandler ()
		{
			if (cb_DesfireGetUid_Api_arrayB == null)
				cb_DesfireGetUid_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireGetUid_Api_arrayB));
			return cb_DesfireGetUid_Api_arrayB;
		}

		static int n_DesfireGetUid_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireGetUid_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetUid_Api_arrayB;
		public unsafe int DesfireGetUid_Api (byte[]? p0)
		{
			if (id_DesfireGetUid_Api_arrayB == IntPtr.Zero)
				id_DesfireGetUid_Api_arrayB = JNIEnv.GetMethodID (class_ref, "DesfireGetUid_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetUid_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DesfireGetValue_Api_IIarrayI;
#pragma warning disable 0169
		static Delegate GetDesfireGetValue_Api_IIarrayIHandler ()
		{
			if (cb_DesfireGetValue_Api_IIarrayI == null)
				cb_DesfireGetValue_Api_IIarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_DesfireGetValue_Api_IIarrayI));
			return cb_DesfireGetValue_Api_IIarrayI;
		}

		static int n_DesfireGetValue_Api_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (int[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.DesfireGetValue_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetValue_Api_IIarrayI;
		public unsafe int DesfireGetValue_Api (int p0, int p1, int[]? p2)
		{
			if (id_DesfireGetValue_Api_IIarrayI == IntPtr.Zero)
				id_DesfireGetValue_Api_IIarrayI = JNIEnv.GetMethodID (class_ref, "DesfireGetValue_Api", "(II[I)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetValue_Api_IIarrayI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_DesfireGetVersion_Api;
#pragma warning disable 0169
		static Delegate GetDesfireGetVersion_ApiHandler ()
		{
			if (cb_DesfireGetVersion_Api == null)
				cb_DesfireGetVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DesfireGetVersion_Api));
			return cb_DesfireGetVersion_Api;
		}

		static IntPtr n_DesfireGetVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.DesfireGetVersion_Api ());
		}
#pragma warning restore 0169

		IntPtr id_DesfireGetVersion_Api;
		public unsafe global::Android.OS.Bundle? DesfireGetVersion_Api ()
		{
			if (id_DesfireGetVersion_Api == IntPtr.Zero)
				id_DesfireGetVersion_Api = JNIEnv.GetMethodID (class_ref, "DesfireGetVersion_Api", "()Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DesfireGetVersion_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_DesfireLimitedCreditValue_Api_III;
#pragma warning disable 0169
		static Delegate GetDesfireLimitedCreditValue_Api_IIIHandler ()
		{
			if (cb_DesfireLimitedCreditValue_Api_III == null)
				cb_DesfireLimitedCreditValue_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_I (n_DesfireLimitedCreditValue_Api_III));
			return cb_DesfireLimitedCreditValue_Api_III;
		}

		static int n_DesfireLimitedCreditValue_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DesfireLimitedCreditValue_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_DesfireLimitedCreditValue_Api_III;
		public unsafe int DesfireLimitedCreditValue_Api (int p0, int p1, int p2)
		{
			if (id_DesfireLimitedCreditValue_Api_III == IntPtr.Zero)
				id_DesfireLimitedCreditValue_Api_III = JNIEnv.GetMethodID (class_ref, "DesfireLimitedCreditValue_Api", "(III)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireLimitedCreditValue_Api_III, __args);
		}

		static Delegate? cb_DesfireReadData_Api_CIIIarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireReadData_Api_CIIIarrayBHandler ()
		{
			if (cb_DesfireReadData_Api_CIIIarrayB == null)
				cb_DesfireReadData_Api_CIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPCIIIL_I (n_DesfireReadData_Api_CIIIarrayB));
			return cb_DesfireReadData_Api_CIIIarrayB;
		}

		static int n_DesfireReadData_Api_CIIIarrayB (IntPtr jnienv, IntPtr native__this, char p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireReadData_Api (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireReadData_Api_CIIIarrayB;
		public unsafe int DesfireReadData_Api (char p0, int p1, int p2, int p3, byte[]? p4)
		{
			if (id_DesfireReadData_Api_CIIIarrayB == IntPtr.Zero)
				id_DesfireReadData_Api_CIIIarrayB = JNIEnv.GetMethodID (class_ref, "DesfireReadData_Api", "(CIII[B)I");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireReadData_Api_CIIIarrayB, __args);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_DesfireReadRecord_Api_IIIIIarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireReadRecord_Api_IIIIIarrayBHandler ()
		{
			if (cb_DesfireReadRecord_Api_IIIIIarrayB == null)
				cb_DesfireReadRecord_Api_IIIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIIL_I (n_DesfireReadRecord_Api_IIIIIarrayB));
			return cb_DesfireReadRecord_Api_IIIIIarrayB;
		}

		static int n_DesfireReadRecord_Api_IIIIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireReadRecord_Api (p0, p1, p2, p3, p4, p5);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireReadRecord_Api_IIIIIarrayB;
		public unsafe int DesfireReadRecord_Api (int p0, int p1, int p2, int p3, int p4, byte[]? p5)
		{
			if (id_DesfireReadRecord_Api_IIIIIarrayB == IntPtr.Zero)
				id_DesfireReadRecord_Api_IIIIIarrayB = JNIEnv.GetMethodID (class_ref, "DesfireReadRecord_Api", "(IIIII[B)I");
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireReadRecord_Api_IIIIIarrayB, __args);
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_DesfireSelectApp_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetDesfireSelectApp_Api_arrayBHandler ()
		{
			if (cb_DesfireSelectApp_Api_arrayB == null)
				cb_DesfireSelectApp_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DesfireSelectApp_Api_arrayB));
			return cb_DesfireSelectApp_Api_arrayB;
		}

		static int n_DesfireSelectApp_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireSelectApp_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireSelectApp_Api_arrayB;
		public unsafe int DesfireSelectApp_Api (byte[]? p0)
		{
			if (id_DesfireSelectApp_Api_arrayB == IntPtr.Zero)
				id_DesfireSelectApp_Api_arrayB = JNIEnv.GetMethodID (class_ref, "DesfireSelectApp_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireSelectApp_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_DesfireWriteCrecord_Api_IIIIarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireWriteCrecord_Api_IIIIarrayBHandler ()
		{
			if (cb_DesfireWriteCrecord_Api_IIIIarrayB == null)
				cb_DesfireWriteCrecord_Api_IIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_DesfireWriteCrecord_Api_IIIIarrayB));
			return cb_DesfireWriteCrecord_Api_IIIIarrayB;
		}

		static int n_DesfireWriteCrecord_Api_IIIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireWriteCrecord_Api (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireWriteCrecord_Api_IIIIarrayB;
		public unsafe int DesfireWriteCrecord_Api (int p0, int p1, int p2, int p3, byte[]? p4)
		{
			if (id_DesfireWriteCrecord_Api_IIIIarrayB == IntPtr.Zero)
				id_DesfireWriteCrecord_Api_IIIIarrayB = JNIEnv.GetMethodID (class_ref, "DesfireWriteCrecord_Api", "(IIII[B)I");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireWriteCrecord_Api_IIIIarrayB, __args);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_DesfireWriteData_Api_IIIIarrayB;
#pragma warning disable 0169
		static Delegate GetDesfireWriteData_Api_IIIIarrayBHandler ()
		{
			if (cb_DesfireWriteData_Api_IIIIarrayB == null)
				cb_DesfireWriteData_Api_IIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIIL_I (n_DesfireWriteData_Api_IIIIarrayB));
			return cb_DesfireWriteData_Api_IIIIarrayB;
		}

		static int n_DesfireWriteData_Api_IIIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.DesfireWriteData_Api (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_DesfireWriteData_Api_IIIIarrayB;
		public unsafe int DesfireWriteData_Api (int p0, int p1, int p2, int p3, byte[]? p4)
		{
			if (id_DesfireWriteData_Api_IIIIarrayB == IntPtr.Zero)
				id_DesfireWriteData_Api_IIIIarrayB = JNIEnv.GetMethodID (class_ref, "DesfireWriteData_Api", "(IIII[B)I");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_DesfireWriteData_Api_IIIIarrayB, __args);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Cards.IDesfireHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
