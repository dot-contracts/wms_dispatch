using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ciontek.Ciontekposservice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']"
	[Register ("com/ciontek/ciontekposservice/ICiontekPosService", "", "Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker")]
	public partial interface ICiontekPosService : global::Android.OS.IInterface {
		global::System.Collections.Generic.IList<string>? AppInstallWhiteList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='getAppInstallWhiteList' and count(parameter)=0]"
			[Register ("getAppInstallWhiteList", "()Ljava/util/List;", "GetGetAppInstallWhiteListHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
			get; 
		}

		global::System.Collections.Generic.IList<string>? AppUninstallBlackList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='getAppUninstallBlackList' and count(parameter)=0]"
			[Register ("getAppUninstallBlackList", "()Ljava/util/List;", "GetGetAppUninstallBlackListHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
			get; 
		}

		string? DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
			get; 
		}

		string? OSVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='getOSVersion' and count(parameter)=0]"
			[Register ("getOSVersion", "()Ljava/lang/String;", "GetGetOSVersionHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_GetRand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("Lib_GetRand", "([B)I", "GetLib_GetRand_arrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_GetRand (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_GetVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("Lib_GetVersion", "([B)I", "GetLib_GetVersion_arrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_GetVersion (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccCheck' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("Lib_IccCheck", "(B)I", "GetLib_IccCheck_BHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_IccCheck (sbyte p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccClose' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("Lib_IccClose", "(B)I", "GetLib_IccClose_BHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_IccClose (sbyte p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccCommand' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("Lib_IccCommand", "(B[B[B)I", "GetLib_IccCommand_BarrayBarrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_IccCommand (sbyte p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccOpen' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register ("Lib_IccOpen", "(BB[B)I", "GetLib_IccOpen_BBarrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_IccOpen (sbyte p0, sbyte p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_LogSwitch' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_LogSwitch", "(I)I", "GetLib_LogSwitch_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_LogSwitch (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrintCutQrCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("Lib_PrintCutQrCode", "(Ljava/lang/String;IILjava/lang/String;)I", "GetLib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrintCutQrCode (string? p0, int p1, int p2, string? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrintCutQrCodeStr' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register ("Lib_PrintCutQrCodeStr", "(Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)I", "GetLib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrintCutQrCodeStr (string? p0, string? p1, int p2, int p3, int p4, string? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnBarcode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("Lib_PrnBarcode", "(Ljava/lang/String;IILjava/lang/String;)I", "GetLib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnBarcode (string? p0, int p1, int p2, string? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnBmp' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("Lib_PrnBmp", "(Landroid/graphics/Bitmap;)I", "GetLib_PrnBmp_Landroid_graphics_Bitmap_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnBmp (global::Android.Graphics.Bitmap? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnCheckStatus' and count(parameter)=0]"
		[Register ("Lib_PrnCheckStatus", "()I", "GetLib_PrnCheckStatusHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnCheckStatus ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnFeedPaper' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnFeedPaper", "(I)I", "GetLib_PrnFeedPaper_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnFeedPaper (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnGetFont' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("Lib_PrnGetFont", "([B[B[B)I", "GetLib_PrnGetFont_arrayBarrayBarrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnGetFont (byte[]? p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnInit' and count(parameter)=0]"
		[Register ("Lib_PrnInit", "()I", "GetLib_PrnInitHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnInit ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnIsCharge' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnIsCharge", "(I)I", "GetLib_PrnIsCharge_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnIsCharge (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnLogo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("Lib_PrnLogo", "([B)I", "GetLib_PrnLogo_arrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnLogo (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetAlign' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetAlign", "(I)I", "GetLib_PrnSetAlign_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetAlign (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetBold' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetBold", "(I)I", "GetLib_PrnSetBold_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetBold (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetCharSpace' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetCharSpace", "(I)I", "GetLib_PrnSetCharSpace_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetCharSpace (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetFont' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
		[Register ("Lib_PrnSetFont", "(BBB)I", "GetLib_PrnSetFont_BBBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetFont (sbyte p0, sbyte p1, sbyte p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetGray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetGray", "(I)I", "GetLib_PrnSetGray_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetGray (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLeftIndent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetLeftIndent", "(I)I", "GetLib_PrnSetLeftIndent_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetLeftIndent (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLeftSpace' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetLeftSpace", "(I)I", "GetLib_PrnSetLeftSpace_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetLeftSpace (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLineSpace' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetLineSpace", "(I)I", "GetLib_PrnSetLineSpace_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetLineSpace (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetMode", "(I)I", "GetLib_PrnSetMode_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetMode (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetReverse' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetReverse", "(I)I", "GetLib_PrnSetReverse_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetReverse (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetSpace' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("Lib_PrnSetSpace", "(BB)I", "GetLib_PrnSetSpace_BBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetSpace (sbyte p0, sbyte p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetSpeed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetSpeed", "(I)I", "GetLib_PrnSetSpeed_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetSpeed (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetUnderline' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetUnderline", "(I)I", "GetLib_PrnSetUnderline_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetUnderline (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetVoltage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnSetVoltage", "(I)I", "GetLib_PrnSetVoltage_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnSetVoltage (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStart' and count(parameter)=0]"
		[Register ("Lib_PrnStart", "()I", "GetLib_PrnStartHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnStart ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Lib_PrnStep", "(I)I", "GetLib_PrnStep_IHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnStep (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("Lib_PrnStr", "(Ljava/lang/String;)I", "GetLib_PrnStr_Ljava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_PrnStr (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_ReadChipID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("Lib_ReadChipID", "([BI)I", "GetLib_ReadChipID_arrayBIHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_ReadChipID (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_ReadSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("Lib_ReadSN", "([B)I", "GetLib_ReadSN_arrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_ReadSN (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_SetLinPixelDis' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("Lib_SetLinPixelDis", "(C)I", "GetLib_SetLinPixelDis_CHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_SetLinPixelDis (char p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_Update_32550' and count(parameter)=0]"
		[Register ("Lib_Update_32550", "()I", "GetLib_Update_32550Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_Update_32550 ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_WriteSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("Lib_WriteSN", "([B)I", "GetLib_WriteSN_arrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int Lib_WriteSN (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='SC_ApduCmd' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("SC_ApduCmd", "(B[BI[B[B)I", "GetSC_ApduCmd_BarrayBIarrayBarrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int SC_ApduCmd (sbyte p0, byte[]? p1, int p2, byte[]? p3, byte[]? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='addAppToInstallWhiteList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addAppToInstallWhiteList", "(Ljava/lang/String;)Z", "GetAddAppToInstallWhiteList_Ljava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool AddAppToInstallWhiteList (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='addAppToUninstallBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addAppToUninstallBlackList", "(Ljava/lang/String;)Z", "GetAddAppToUninstallBlackList_Ljava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool AddAppToUninstallBlackList (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='delAppFromInstallWhiteList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delAppFromInstallWhiteList", "(Ljava/lang/String;)Z", "GetDelAppFromInstallWhiteList_Ljava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool DelAppFromInstallWhiteList (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='delAppFromUninstallBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delAppFromUninstallBlackList", "(Ljava/lang/String;)Z", "GetDelAppFromUninstallBlackList_Ljava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool DelAppFromUninstallBlackList (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='disableAppInstallWhiteList' and count(parameter)=0]"
		[Register ("disableAppInstallWhiteList", "()Z", "GetDisableAppInstallWhiteListHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool DisableAppInstallWhiteList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='disableAppUninstallBlackList' and count(parameter)=0]"
		[Register ("disableAppUninstallBlackList", "()Z", "GetDisableAppUninstallBlackListHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool DisableAppUninstallBlackList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='enableAppInstallWhiteList' and count(parameter)=0]"
		[Register ("enableAppInstallWhiteList", "()Z", "GetEnableAppInstallWhiteListHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool EnableAppInstallWhiteList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='enableAppUninstallBlackList' and count(parameter)=0]"
		[Register ("enableAppUninstallBlackList", "()Z", "GetEnableAppUninstallBlackListHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		bool EnableAppUninstallBlackList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalClose' and count(parameter)=0]"
		[Register ("fiscalClose", "()I", "GetFiscalCloseHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int FiscalClose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalOpen' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='char'] and parameter[5][@type='char']]"
		[Register ("fiscalOpen", "(IIICC)I", "GetFiscalOpen_IIICCHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int FiscalOpen (int p0, int p1, int p2, char p3, char p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalRead' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fiscalRead", "([BII)I", "GetFiscalRead_arrayBIIHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int FiscalRead (byte[]? p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalWrite' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("fiscalWrite", "([B)I", "GetFiscalWrite_arrayBHandler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int FiscalWrite (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='installRomPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("installRomPackage", "(Ljava/lang/String;)I", "GetInstallRomPackage_Ljava_lang_String_Handler:Com.Ciontek.Ciontekposservice.ICiontekPosServiceInvoker, AndroidPosSdk")]
		int InstallRomPackage (string? p0);

		/// <summary>Local-side IPC implementation stub class.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']"
		[global::Android.Runtime.Register ("com/ciontek/ciontekposservice/ICiontekPosService$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Ciontek.Ciontekposservice.ICiontekPosService {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ciontek/ciontekposservice/ICiontekPosService$Stub", typeof (Stub));

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

			/// <summary>Construct the stub at attach it to the interface.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/constructor[@name='ICiontekPosService.Stub' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/ciontek/ciontekposservice/ICiontekPosService;", "")]
			public static unsafe global::Com.Ciontek.Ciontekposservice.ICiontekPosService? AsInterface (global::Android.OS.IBinder? p0)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/ciontek/ciontekposservice/ICiontekPosService;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
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

			static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
			[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
			public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel? p1, global::Android.OS.Parcel? p2, int p3)
			{
				const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			static Delegate? cb_Lib_GetRand_arrayB;
#pragma warning disable 0169
			static Delegate GetLib_GetRand_arrayBHandler ()
			{
				if (cb_Lib_GetRand_arrayB == null)
					cb_Lib_GetRand_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_GetRand_arrayB));
				return cb_Lib_GetRand_arrayB;
			}

			static int n_Lib_GetRand_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_GetRand (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_GetRand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_GetRand", "([B)I", "GetLib_GetRand_arrayBHandler")]
			public abstract int Lib_GetRand (byte[]? p0);

			static Delegate? cb_Lib_GetVersion_arrayB;
#pragma warning disable 0169
			static Delegate GetLib_GetVersion_arrayBHandler ()
			{
				if (cb_Lib_GetVersion_arrayB == null)
					cb_Lib_GetVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_GetVersion_arrayB));
				return cb_Lib_GetVersion_arrayB;
			}

			static int n_Lib_GetVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_GetVersion (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_GetVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_GetVersion", "([B)I", "GetLib_GetVersion_arrayBHandler")]
			public abstract int Lib_GetVersion (byte[]? p0);

			static Delegate? cb_Lib_IccCheck_B;
#pragma warning disable 0169
			static Delegate GetLib_IccCheck_BHandler ()
			{
				if (cb_Lib_IccCheck_B == null)
					cb_Lib_IccCheck_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_Lib_IccCheck_B));
				return cb_Lib_IccCheck_B;
			}

			static int n_Lib_IccCheck_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_IccCheck (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccCheck' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("Lib_IccCheck", "(B)I", "GetLib_IccCheck_BHandler")]
			public abstract int Lib_IccCheck (sbyte p0);

			static Delegate? cb_Lib_IccClose_B;
#pragma warning disable 0169
			static Delegate GetLib_IccClose_BHandler ()
			{
				if (cb_Lib_IccClose_B == null)
					cb_Lib_IccClose_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_Lib_IccClose_B));
				return cb_Lib_IccClose_B;
			}

			static int n_Lib_IccClose_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_IccClose (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccClose' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("Lib_IccClose", "(B)I", "GetLib_IccClose_BHandler")]
			public abstract int Lib_IccClose (sbyte p0);

			static Delegate? cb_Lib_IccCommand_BarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetLib_IccCommand_BarrayBarrayBHandler ()
			{
				if (cb_Lib_IccCommand_BarrayBarrayB == null)
					cb_Lib_IccCommand_BarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLL_I (n_Lib_IccCommand_BarrayBarrayB));
				return cb_Lib_IccCommand_BarrayBarrayB;
			}

			static int n_Lib_IccCommand_BarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_IccCommand (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccCommand' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("Lib_IccCommand", "(B[B[B)I", "GetLib_IccCommand_BarrayBarrayBHandler")]
			public abstract int Lib_IccCommand (sbyte p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_Lib_IccOpen_BBarrayB;
#pragma warning disable 0169
			static Delegate GetLib_IccOpen_BBarrayBHandler ()
			{
				if (cb_Lib_IccOpen_BBarrayB == null)
					cb_Lib_IccOpen_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Lib_IccOpen_BBarrayB));
				return cb_Lib_IccOpen_BBarrayB;
			}

			static int n_Lib_IccOpen_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_IccOpen (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccOpen' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("Lib_IccOpen", "(BB[B)I", "GetLib_IccOpen_BBarrayBHandler")]
			public abstract int Lib_IccOpen (sbyte p0, sbyte p1, byte[]? p2);

			static Delegate? cb_Lib_LogSwitch_I;
#pragma warning disable 0169
			static Delegate GetLib_LogSwitch_IHandler ()
			{
				if (cb_Lib_LogSwitch_I == null)
					cb_Lib_LogSwitch_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_LogSwitch_I));
				return cb_Lib_LogSwitch_I;
			}

			static int n_Lib_LogSwitch_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_LogSwitch (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_LogSwitch' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_LogSwitch", "(I)I", "GetLib_LogSwitch_IHandler")]
			public abstract int Lib_LogSwitch (int p0);

			static Delegate? cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_Handler ()
			{
				if (cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ == null)
					cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIL_I (n_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_));
				return cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_;
			}

			static int n_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Lib_PrintCutQrCode (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrintCutQrCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
			[Register ("Lib_PrintCutQrCode", "(Ljava/lang/String;IILjava/lang/String;)I", "GetLib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_Handler")]
			public abstract int Lib_PrintCutQrCode (string? p0, int p1, int p2, string? p3);

			static Delegate? cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler ()
			{
				if (cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ == null)
					cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIIIL_I (n_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_));
				return cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
			}

			static int n_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Lib_PrintCutQrCodeStr (p0, p1, p2, p3, p4, p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrintCutQrCodeStr' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
			[Register ("Lib_PrintCutQrCodeStr", "(Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)I", "GetLib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler")]
			public abstract int Lib_PrintCutQrCodeStr (string? p0, string? p1, int p2, int p3, int p4, string? p5);

			static Delegate? cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_Handler ()
			{
				if (cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ == null)
					cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIL_I (n_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_));
				return cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_;
			}

			static int n_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Lib_PrnBarcode (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnBarcode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
			[Register ("Lib_PrnBarcode", "(Ljava/lang/String;IILjava/lang/String;)I", "GetLib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_Handler")]
			public abstract int Lib_PrnBarcode (string? p0, int p1, int p2, string? p3);

			static Delegate? cb_Lib_PrnBmp_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetLib_PrnBmp_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_Lib_PrnBmp_Landroid_graphics_Bitmap_ == null)
					cb_Lib_PrnBmp_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_PrnBmp_Landroid_graphics_Bitmap_));
				return cb_Lib_PrnBmp_Landroid_graphics_Bitmap_;
			}

			static int n_Lib_PrnBmp_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Lib_PrnBmp (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnBmp' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("Lib_PrnBmp", "(Landroid/graphics/Bitmap;)I", "GetLib_PrnBmp_Landroid_graphics_Bitmap_Handler")]
			public abstract int Lib_PrnBmp (global::Android.Graphics.Bitmap? p0);

			static Delegate? cb_Lib_PrnCheckStatus;
#pragma warning disable 0169
			static Delegate GetLib_PrnCheckStatusHandler ()
			{
				if (cb_Lib_PrnCheckStatus == null)
					cb_Lib_PrnCheckStatus = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_PrnCheckStatus));
				return cb_Lib_PrnCheckStatus;
			}

			static int n_Lib_PrnCheckStatus (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnCheckStatus ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnCheckStatus' and count(parameter)=0]"
			[Register ("Lib_PrnCheckStatus", "()I", "GetLib_PrnCheckStatusHandler")]
			public abstract int Lib_PrnCheckStatus ();

			static Delegate? cb_Lib_PrnFeedPaper_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnFeedPaper_IHandler ()
			{
				if (cb_Lib_PrnFeedPaper_I == null)
					cb_Lib_PrnFeedPaper_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnFeedPaper_I));
				return cb_Lib_PrnFeedPaper_I;
			}

			static int n_Lib_PrnFeedPaper_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnFeedPaper (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnFeedPaper' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnFeedPaper", "(I)I", "GetLib_PrnFeedPaper_IHandler")]
			public abstract int Lib_PrnFeedPaper (int p0);

			static Delegate? cb_Lib_PrnGetFont_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetLib_PrnGetFont_arrayBarrayBarrayBHandler ()
			{
				if (cb_Lib_PrnGetFont_arrayBarrayBarrayB == null)
					cb_Lib_PrnGetFont_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_Lib_PrnGetFont_arrayBarrayBarrayB));
				return cb_Lib_PrnGetFont_arrayBarrayBarrayB;
			}

			static int n_Lib_PrnGetFont_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_PrnGetFont (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnGetFont' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("Lib_PrnGetFont", "([B[B[B)I", "GetLib_PrnGetFont_arrayBarrayBarrayBHandler")]
			public abstract int Lib_PrnGetFont (byte[]? p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_Lib_PrnInit;
#pragma warning disable 0169
			static Delegate GetLib_PrnInitHandler ()
			{
				if (cb_Lib_PrnInit == null)
					cb_Lib_PrnInit = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_PrnInit));
				return cb_Lib_PrnInit;
			}

			static int n_Lib_PrnInit (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnInit ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnInit' and count(parameter)=0]"
			[Register ("Lib_PrnInit", "()I", "GetLib_PrnInitHandler")]
			public abstract int Lib_PrnInit ();

			static Delegate? cb_Lib_PrnIsCharge_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnIsCharge_IHandler ()
			{
				if (cb_Lib_PrnIsCharge_I == null)
					cb_Lib_PrnIsCharge_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnIsCharge_I));
				return cb_Lib_PrnIsCharge_I;
			}

			static int n_Lib_PrnIsCharge_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnIsCharge (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnIsCharge' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnIsCharge", "(I)I", "GetLib_PrnIsCharge_IHandler")]
			public abstract int Lib_PrnIsCharge (int p0);

			static Delegate? cb_Lib_PrnLogo_arrayB;
#pragma warning disable 0169
			static Delegate GetLib_PrnLogo_arrayBHandler ()
			{
				if (cb_Lib_PrnLogo_arrayB == null)
					cb_Lib_PrnLogo_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_PrnLogo_arrayB));
				return cb_Lib_PrnLogo_arrayB;
			}

			static int n_Lib_PrnLogo_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_PrnLogo (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnLogo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_PrnLogo", "([B)I", "GetLib_PrnLogo_arrayBHandler")]
			public abstract int Lib_PrnLogo (byte[]? p0);

			static Delegate? cb_Lib_PrnSetAlign_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetAlign_IHandler ()
			{
				if (cb_Lib_PrnSetAlign_I == null)
					cb_Lib_PrnSetAlign_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetAlign_I));
				return cb_Lib_PrnSetAlign_I;
			}

			static int n_Lib_PrnSetAlign_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetAlign (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetAlign' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetAlign", "(I)I", "GetLib_PrnSetAlign_IHandler")]
			public abstract int Lib_PrnSetAlign (int p0);

			static Delegate? cb_Lib_PrnSetBold_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetBold_IHandler ()
			{
				if (cb_Lib_PrnSetBold_I == null)
					cb_Lib_PrnSetBold_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetBold_I));
				return cb_Lib_PrnSetBold_I;
			}

			static int n_Lib_PrnSetBold_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetBold (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetBold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetBold", "(I)I", "GetLib_PrnSetBold_IHandler")]
			public abstract int Lib_PrnSetBold (int p0);

			static Delegate? cb_Lib_PrnSetCharSpace_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetCharSpace_IHandler ()
			{
				if (cb_Lib_PrnSetCharSpace_I == null)
					cb_Lib_PrnSetCharSpace_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetCharSpace_I));
				return cb_Lib_PrnSetCharSpace_I;
			}

			static int n_Lib_PrnSetCharSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetCharSpace (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetCharSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetCharSpace", "(I)I", "GetLib_PrnSetCharSpace_IHandler")]
			public abstract int Lib_PrnSetCharSpace (int p0);

			static Delegate? cb_Lib_PrnSetFont_BBB;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetFont_BBBHandler ()
			{
				if (cb_Lib_PrnSetFont_BBB == null)
					cb_Lib_PrnSetFont_BBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBB_I (n_Lib_PrnSetFont_BBB));
				return cb_Lib_PrnSetFont_BBB;
			}

			static int n_Lib_PrnSetFont_BBB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetFont (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetFont' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
			[Register ("Lib_PrnSetFont", "(BBB)I", "GetLib_PrnSetFont_BBBHandler")]
			public abstract int Lib_PrnSetFont (sbyte p0, sbyte p1, sbyte p2);

			static Delegate? cb_Lib_PrnSetGray_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetGray_IHandler ()
			{
				if (cb_Lib_PrnSetGray_I == null)
					cb_Lib_PrnSetGray_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetGray_I));
				return cb_Lib_PrnSetGray_I;
			}

			static int n_Lib_PrnSetGray_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetGray (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetGray' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetGray", "(I)I", "GetLib_PrnSetGray_IHandler")]
			public abstract int Lib_PrnSetGray (int p0);

			static Delegate? cb_Lib_PrnSetLeftIndent_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetLeftIndent_IHandler ()
			{
				if (cb_Lib_PrnSetLeftIndent_I == null)
					cb_Lib_PrnSetLeftIndent_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetLeftIndent_I));
				return cb_Lib_PrnSetLeftIndent_I;
			}

			static int n_Lib_PrnSetLeftIndent_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetLeftIndent (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLeftIndent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetLeftIndent", "(I)I", "GetLib_PrnSetLeftIndent_IHandler")]
			public abstract int Lib_PrnSetLeftIndent (int p0);

			static Delegate? cb_Lib_PrnSetLeftSpace_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetLeftSpace_IHandler ()
			{
				if (cb_Lib_PrnSetLeftSpace_I == null)
					cb_Lib_PrnSetLeftSpace_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetLeftSpace_I));
				return cb_Lib_PrnSetLeftSpace_I;
			}

			static int n_Lib_PrnSetLeftSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetLeftSpace (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLeftSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetLeftSpace", "(I)I", "GetLib_PrnSetLeftSpace_IHandler")]
			public abstract int Lib_PrnSetLeftSpace (int p0);

			static Delegate? cb_Lib_PrnSetLineSpace_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetLineSpace_IHandler ()
			{
				if (cb_Lib_PrnSetLineSpace_I == null)
					cb_Lib_PrnSetLineSpace_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetLineSpace_I));
				return cb_Lib_PrnSetLineSpace_I;
			}

			static int n_Lib_PrnSetLineSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetLineSpace (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLineSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetLineSpace", "(I)I", "GetLib_PrnSetLineSpace_IHandler")]
			public abstract int Lib_PrnSetLineSpace (int p0);

			static Delegate? cb_Lib_PrnSetMode_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetMode_IHandler ()
			{
				if (cb_Lib_PrnSetMode_I == null)
					cb_Lib_PrnSetMode_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetMode_I));
				return cb_Lib_PrnSetMode_I;
			}

			static int n_Lib_PrnSetMode_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetMode (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetMode", "(I)I", "GetLib_PrnSetMode_IHandler")]
			public abstract int Lib_PrnSetMode (int p0);

			static Delegate? cb_Lib_PrnSetReverse_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetReverse_IHandler ()
			{
				if (cb_Lib_PrnSetReverse_I == null)
					cb_Lib_PrnSetReverse_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetReverse_I));
				return cb_Lib_PrnSetReverse_I;
			}

			static int n_Lib_PrnSetReverse_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetReverse (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetReverse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetReverse", "(I)I", "GetLib_PrnSetReverse_IHandler")]
			public abstract int Lib_PrnSetReverse (int p0);

			static Delegate? cb_Lib_PrnSetSpace_BB;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetSpace_BBHandler ()
			{
				if (cb_Lib_PrnSetSpace_BB == null)
					cb_Lib_PrnSetSpace_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_Lib_PrnSetSpace_BB));
				return cb_Lib_PrnSetSpace_BB;
			}

			static int n_Lib_PrnSetSpace_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetSpace (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetSpace' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("Lib_PrnSetSpace", "(BB)I", "GetLib_PrnSetSpace_BBHandler")]
			public abstract int Lib_PrnSetSpace (sbyte p0, sbyte p1);

			static Delegate? cb_Lib_PrnSetSpeed_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetSpeed_IHandler ()
			{
				if (cb_Lib_PrnSetSpeed_I == null)
					cb_Lib_PrnSetSpeed_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetSpeed_I));
				return cb_Lib_PrnSetSpeed_I;
			}

			static int n_Lib_PrnSetSpeed_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetSpeed (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetSpeed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetSpeed", "(I)I", "GetLib_PrnSetSpeed_IHandler")]
			public abstract int Lib_PrnSetSpeed (int p0);

			static Delegate? cb_Lib_PrnSetUnderline_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetUnderline_IHandler ()
			{
				if (cb_Lib_PrnSetUnderline_I == null)
					cb_Lib_PrnSetUnderline_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetUnderline_I));
				return cb_Lib_PrnSetUnderline_I;
			}

			static int n_Lib_PrnSetUnderline_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetUnderline (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetUnderline' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetUnderline", "(I)I", "GetLib_PrnSetUnderline_IHandler")]
			public abstract int Lib_PrnSetUnderline (int p0);

			static Delegate? cb_Lib_PrnSetVoltage_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnSetVoltage_IHandler ()
			{
				if (cb_Lib_PrnSetVoltage_I == null)
					cb_Lib_PrnSetVoltage_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetVoltage_I));
				return cb_Lib_PrnSetVoltage_I;
			}

			static int n_Lib_PrnSetVoltage_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnSetVoltage (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetVoltage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetVoltage", "(I)I", "GetLib_PrnSetVoltage_IHandler")]
			public abstract int Lib_PrnSetVoltage (int p0);

			static Delegate? cb_Lib_PrnStart;
#pragma warning disable 0169
			static Delegate GetLib_PrnStartHandler ()
			{
				if (cb_Lib_PrnStart == null)
					cb_Lib_PrnStart = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_PrnStart));
				return cb_Lib_PrnStart;
			}

			static int n_Lib_PrnStart (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnStart ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStart' and count(parameter)=0]"
			[Register ("Lib_PrnStart", "()I", "GetLib_PrnStartHandler")]
			public abstract int Lib_PrnStart ();

			static Delegate? cb_Lib_PrnStep_I;
#pragma warning disable 0169
			static Delegate GetLib_PrnStep_IHandler ()
			{
				if (cb_Lib_PrnStep_I == null)
					cb_Lib_PrnStep_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnStep_I));
				return cb_Lib_PrnStep_I;
			}

			static int n_Lib_PrnStep_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_PrnStep (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStep' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnStep", "(I)I", "GetLib_PrnStep_IHandler")]
			public abstract int Lib_PrnStep (int p0);

			static Delegate? cb_Lib_PrnStr_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLib_PrnStr_Ljava_lang_String_Handler ()
			{
				if (cb_Lib_PrnStr_Ljava_lang_String_ == null)
					cb_Lib_PrnStr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_PrnStr_Ljava_lang_String_));
				return cb_Lib_PrnStr_Ljava_lang_String_;
			}

			static int n_Lib_PrnStr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Lib_PrnStr (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("Lib_PrnStr", "(Ljava/lang/String;)I", "GetLib_PrnStr_Ljava_lang_String_Handler")]
			public abstract int Lib_PrnStr (string? p0);

			static Delegate? cb_Lib_ReadChipID_arrayBI;
#pragma warning disable 0169
			static Delegate GetLib_ReadChipID_arrayBIHandler ()
			{
				if (cb_Lib_ReadChipID_arrayBI == null)
					cb_Lib_ReadChipID_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Lib_ReadChipID_arrayBI));
				return cb_Lib_ReadChipID_arrayBI;
			}

			static int n_Lib_ReadChipID_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_ReadChipID (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_ReadChipID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Lib_ReadChipID", "([BI)I", "GetLib_ReadChipID_arrayBIHandler")]
			public abstract int Lib_ReadChipID (byte[]? p0, int p1);

			static Delegate? cb_Lib_ReadSN_arrayB;
#pragma warning disable 0169
			static Delegate GetLib_ReadSN_arrayBHandler ()
			{
				if (cb_Lib_ReadSN_arrayB == null)
					cb_Lib_ReadSN_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_ReadSN_arrayB));
				return cb_Lib_ReadSN_arrayB;
			}

			static int n_Lib_ReadSN_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_ReadSN (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_ReadSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_ReadSN", "([B)I", "GetLib_ReadSN_arrayBHandler")]
			public abstract int Lib_ReadSN (byte[]? p0);

			static Delegate? cb_Lib_SetLinPixelDis_C;
#pragma warning disable 0169
			static Delegate GetLib_SetLinPixelDis_CHandler ()
			{
				if (cb_Lib_SetLinPixelDis_C == null)
					cb_Lib_SetLinPixelDis_C = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPC_I (n_Lib_SetLinPixelDis_C));
				return cb_Lib_SetLinPixelDis_C;
			}

			static int n_Lib_SetLinPixelDis_C (IntPtr jnienv, IntPtr native__this, char p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_SetLinPixelDis (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_SetLinPixelDis' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("Lib_SetLinPixelDis", "(C)I", "GetLib_SetLinPixelDis_CHandler")]
			public abstract int Lib_SetLinPixelDis (char p0);

			static Delegate? cb_Lib_Update_32550;
#pragma warning disable 0169
			static Delegate GetLib_Update_32550Handler ()
			{
				if (cb_Lib_Update_32550 == null)
					cb_Lib_Update_32550 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_Update_32550));
				return cb_Lib_Update_32550;
			}

			static int n_Lib_Update_32550 (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lib_Update_32550 ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_Update_32550' and count(parameter)=0]"
			[Register ("Lib_Update_32550", "()I", "GetLib_Update_32550Handler")]
			public abstract int Lib_Update_32550 ();

			static Delegate? cb_Lib_WriteSN_arrayB;
#pragma warning disable 0169
			static Delegate GetLib_WriteSN_arrayBHandler ()
			{
				if (cb_Lib_WriteSN_arrayB == null)
					cb_Lib_WriteSN_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_WriteSN_arrayB));
				return cb_Lib_WriteSN_arrayB;
			}

			static int n_Lib_WriteSN_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Lib_WriteSN (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_WriteSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_WriteSN", "([B)I", "GetLib_WriteSN_arrayBHandler")]
			public abstract int Lib_WriteSN (byte[]? p0);

			static Delegate? cb_SC_ApduCmd_BarrayBIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetSC_ApduCmd_BarrayBIarrayBarrayBHandler ()
			{
				if (cb_SC_ApduCmd_BarrayBIarrayBarrayB == null)
					cb_SC_ApduCmd_BarrayBIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLILL_I (n_SC_ApduCmd_BarrayBIarrayBarrayB));
				return cb_SC_ApduCmd_BarrayBIarrayBarrayB;
			}

			static int n_SC_ApduCmd_BarrayBIarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SC_ApduCmd (p0, p1, p2, p3, p4);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='SC_ApduCmd' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("SC_ApduCmd", "(B[BI[B[B)I", "GetSC_ApduCmd_BarrayBIarrayBarrayBHandler")]
			public abstract int SC_ApduCmd (sbyte p0, byte[]? p1, int p2, byte[]? p3, byte[]? p4);

			static Delegate? cb_addAppToInstallWhiteList_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddAppToInstallWhiteList_Ljava_lang_String_Handler ()
			{
				if (cb_addAppToInstallWhiteList_Ljava_lang_String_ == null)
					cb_addAppToInstallWhiteList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_AddAppToInstallWhiteList_Ljava_lang_String_));
				return cb_addAppToInstallWhiteList_Ljava_lang_String_;
			}

			static bool n_AddAppToInstallWhiteList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.AddAppToInstallWhiteList (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='addAppToInstallWhiteList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addAppToInstallWhiteList", "(Ljava/lang/String;)Z", "GetAddAppToInstallWhiteList_Ljava_lang_String_Handler")]
			public abstract bool AddAppToInstallWhiteList (string? p0);

			static Delegate? cb_addAppToUninstallBlackList_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddAppToUninstallBlackList_Ljava_lang_String_Handler ()
			{
				if (cb_addAppToUninstallBlackList_Ljava_lang_String_ == null)
					cb_addAppToUninstallBlackList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_AddAppToUninstallBlackList_Ljava_lang_String_));
				return cb_addAppToUninstallBlackList_Ljava_lang_String_;
			}

			static bool n_AddAppToUninstallBlackList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.AddAppToUninstallBlackList (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='addAppToUninstallBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addAppToUninstallBlackList", "(Ljava/lang/String;)Z", "GetAddAppToUninstallBlackList_Ljava_lang_String_Handler")]
			public abstract bool AddAppToUninstallBlackList (string? p0);

			static Delegate? cb_delAppFromInstallWhiteList_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDelAppFromInstallWhiteList_Ljava_lang_String_Handler ()
			{
				if (cb_delAppFromInstallWhiteList_Ljava_lang_String_ == null)
					cb_delAppFromInstallWhiteList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_DelAppFromInstallWhiteList_Ljava_lang_String_));
				return cb_delAppFromInstallWhiteList_Ljava_lang_String_;
			}

			static bool n_DelAppFromInstallWhiteList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DelAppFromInstallWhiteList (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='delAppFromInstallWhiteList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("delAppFromInstallWhiteList", "(Ljava/lang/String;)Z", "GetDelAppFromInstallWhiteList_Ljava_lang_String_Handler")]
			public abstract bool DelAppFromInstallWhiteList (string? p0);

			static Delegate? cb_delAppFromUninstallBlackList_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDelAppFromUninstallBlackList_Ljava_lang_String_Handler ()
			{
				if (cb_delAppFromUninstallBlackList_Ljava_lang_String_ == null)
					cb_delAppFromUninstallBlackList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_DelAppFromUninstallBlackList_Ljava_lang_String_));
				return cb_delAppFromUninstallBlackList_Ljava_lang_String_;
			}

			static bool n_DelAppFromUninstallBlackList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.DelAppFromUninstallBlackList (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='delAppFromUninstallBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("delAppFromUninstallBlackList", "(Ljava/lang/String;)Z", "GetDelAppFromUninstallBlackList_Ljava_lang_String_Handler")]
			public abstract bool DelAppFromUninstallBlackList (string? p0);

			static Delegate? cb_disableAppInstallWhiteList;
#pragma warning disable 0169
			static Delegate GetDisableAppInstallWhiteListHandler ()
			{
				if (cb_disableAppInstallWhiteList == null)
					cb_disableAppInstallWhiteList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_DisableAppInstallWhiteList));
				return cb_disableAppInstallWhiteList;
			}

			static bool n_DisableAppInstallWhiteList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DisableAppInstallWhiteList ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='disableAppInstallWhiteList' and count(parameter)=0]"
			[Register ("disableAppInstallWhiteList", "()Z", "GetDisableAppInstallWhiteListHandler")]
			public abstract bool DisableAppInstallWhiteList ();

			static Delegate? cb_disableAppUninstallBlackList;
#pragma warning disable 0169
			static Delegate GetDisableAppUninstallBlackListHandler ()
			{
				if (cb_disableAppUninstallBlackList == null)
					cb_disableAppUninstallBlackList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_DisableAppUninstallBlackList));
				return cb_disableAppUninstallBlackList;
			}

			static bool n_DisableAppUninstallBlackList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DisableAppUninstallBlackList ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='disableAppUninstallBlackList' and count(parameter)=0]"
			[Register ("disableAppUninstallBlackList", "()Z", "GetDisableAppUninstallBlackListHandler")]
			public abstract bool DisableAppUninstallBlackList ();

			static Delegate? cb_enableAppInstallWhiteList;
#pragma warning disable 0169
			static Delegate GetEnableAppInstallWhiteListHandler ()
			{
				if (cb_enableAppInstallWhiteList == null)
					cb_enableAppInstallWhiteList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_EnableAppInstallWhiteList));
				return cb_enableAppInstallWhiteList;
			}

			static bool n_EnableAppInstallWhiteList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.EnableAppInstallWhiteList ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='enableAppInstallWhiteList' and count(parameter)=0]"
			[Register ("enableAppInstallWhiteList", "()Z", "GetEnableAppInstallWhiteListHandler")]
			public abstract bool EnableAppInstallWhiteList ();

			static Delegate? cb_enableAppUninstallBlackList;
#pragma warning disable 0169
			static Delegate GetEnableAppUninstallBlackListHandler ()
			{
				if (cb_enableAppUninstallBlackList == null)
					cb_enableAppUninstallBlackList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_EnableAppUninstallBlackList));
				return cb_enableAppUninstallBlackList;
			}

			static bool n_EnableAppUninstallBlackList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.EnableAppUninstallBlackList ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='enableAppUninstallBlackList' and count(parameter)=0]"
			[Register ("enableAppUninstallBlackList", "()Z", "GetEnableAppUninstallBlackListHandler")]
			public abstract bool EnableAppUninstallBlackList ();

			static Delegate? cb_fiscalClose;
#pragma warning disable 0169
			static Delegate GetFiscalCloseHandler ()
			{
				if (cb_fiscalClose == null)
					cb_fiscalClose = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalClose));
				return cb_fiscalClose;
			}

			static int n_FiscalClose (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalClose ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalClose' and count(parameter)=0]"
			[Register ("fiscalClose", "()I", "GetFiscalCloseHandler")]
			public abstract int FiscalClose ();

			static Delegate? cb_fiscalOpen_IIICC;
#pragma warning disable 0169
			static Delegate GetFiscalOpen_IIICCHandler ()
			{
				if (cb_fiscalOpen_IIICC == null)
					cb_fiscalOpen_IIICC = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIICC_I (n_FiscalOpen_IIICC));
				return cb_fiscalOpen_IIICC;
			}

			static int n_FiscalOpen_IIICC (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, char p3, char p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FiscalOpen (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalOpen' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='char'] and parameter[5][@type='char']]"
			[Register ("fiscalOpen", "(IIICC)I", "GetFiscalOpen_IIICCHandler")]
			public abstract int FiscalOpen (int p0, int p1, int p2, char p3, char p4);

			static Delegate? cb_fiscalRead_arrayBII;
#pragma warning disable 0169
			static Delegate GetFiscalRead_arrayBIIHandler ()
			{
				if (cb_fiscalRead_arrayBII == null)
					cb_fiscalRead_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_FiscalRead_arrayBII));
				return cb_fiscalRead_arrayBII;
			}

			static int n_FiscalRead_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalRead (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalRead' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("fiscalRead", "([BII)I", "GetFiscalRead_arrayBIIHandler")]
			public abstract int FiscalRead (byte[]? p0, int p1, int p2);

			static Delegate? cb_fiscalWrite_arrayB;
#pragma warning disable 0169
			static Delegate GetFiscalWrite_arrayBHandler ()
			{
				if (cb_fiscalWrite_arrayB == null)
					cb_fiscalWrite_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalWrite_arrayB));
				return cb_fiscalWrite_arrayB;
			}

			static int n_FiscalWrite_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.FiscalWrite (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalWrite' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("fiscalWrite", "([B)I", "GetFiscalWrite_arrayBHandler")]
			public abstract int FiscalWrite (byte[]? p0);

			static Delegate? cb_installRomPackage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetInstallRomPackage_Ljava_lang_String_Handler ()
			{
				if (cb_installRomPackage_Ljava_lang_String_ == null)
					cb_installRomPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_InstallRomPackage_Ljava_lang_String_));
				return cb_installRomPackage_Ljava_lang_String_;
			}

			static int n_InstallRomPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.InstallRomPackage (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='installRomPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("installRomPackage", "(Ljava/lang/String;)I", "GetInstallRomPackage_Ljava_lang_String_Handler")]
			public abstract int InstallRomPackage (string? p0);

			static Delegate? cb_getAppInstallWhiteList;
#pragma warning disable 0169
			static Delegate GetGetAppInstallWhiteListHandler ()
			{
				if (cb_getAppInstallWhiteList == null)
					cb_getAppInstallWhiteList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAppInstallWhiteList));
				return cb_getAppInstallWhiteList;
			}

			static IntPtr n_GetAppInstallWhiteList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AppInstallWhiteList);
			}
#pragma warning restore 0169

			public abstract global::System.Collections.Generic.IList<string>? AppInstallWhiteList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getAppInstallWhiteList' and count(parameter)=0]"
				[Register ("getAppInstallWhiteList", "()Ljava/util/List;", "GetGetAppInstallWhiteListHandler")]
				get; 
			}

			static Delegate? cb_getAppUninstallBlackList;
#pragma warning disable 0169
			static Delegate GetGetAppUninstallBlackListHandler ()
			{
				if (cb_getAppUninstallBlackList == null)
					cb_getAppUninstallBlackList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAppUninstallBlackList));
				return cb_getAppUninstallBlackList;
			}

			static IntPtr n_GetAppUninstallBlackList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AppUninstallBlackList);
			}
#pragma warning restore 0169

			public abstract global::System.Collections.Generic.IList<string>? AppUninstallBlackList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getAppUninstallBlackList' and count(parameter)=0]"
				[Register ("getAppUninstallBlackList", "()Ljava/util/List;", "GetGetAppUninstallBlackListHandler")]
				get; 
			}

			static Delegate? cb_getDeviceId;
#pragma warning disable 0169
			static Delegate GetGetDeviceIdHandler ()
			{
				if (cb_getDeviceId == null)
					cb_getDeviceId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDeviceId));
				return cb_getDeviceId;
			}

			static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DeviceId);
			}
#pragma warning restore 0169

			public abstract string? DeviceId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getDeviceId' and count(parameter)=0]"
				[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
				get; 
			}

			static Delegate? cb_getOSVersion;
#pragma warning disable 0169
			static Delegate GetGetOSVersionHandler ()
			{
				if (cb_getOSVersion == null)
					cb_getOSVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetOSVersion));
				return cb_getOSVersion;
			}

			static IntPtr n_GetOSVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.OSVersion);
			}
#pragma warning restore 0169

			public abstract string? OSVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getOSVersion' and count(parameter)=0]"
				[Register ("getOSVersion", "()Ljava/lang/String;", "GetGetOSVersionHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/ciontek/ciontekposservice/ICiontekPosService$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ciontek/ciontekposservice/ICiontekPosService$Stub", typeof (StubInvoker));

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

			public override unsafe global::System.Collections.Generic.IList<string>? AppInstallWhiteList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getAppInstallWhiteList' and count(parameter)=0]"
				[Register ("getAppInstallWhiteList", "()Ljava/util/List;", "GetGetAppInstallWhiteListHandler")]
				get {
					const string __id = "getAppInstallWhiteList.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::System.Collections.Generic.IList<string>? AppUninstallBlackList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getAppUninstallBlackList' and count(parameter)=0]"
				[Register ("getAppUninstallBlackList", "()Ljava/util/List;", "GetGetAppUninstallBlackListHandler")]
				get {
					const string __id = "getAppUninstallBlackList.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? DeviceId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getDeviceId' and count(parameter)=0]"
				[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
				get {
					const string __id = "getDeviceId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? OSVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/class[@name='ICiontekPosService.Stub']/method[@name='getOSVersion' and count(parameter)=0]"
				[Register ("getOSVersion", "()Ljava/lang/String;", "GetGetOSVersionHandler")]
				get {
					const string __id = "getOSVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_GetRand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_GetRand", "([B)I", "GetLib_GetRand_arrayBHandler")]
			public override unsafe int Lib_GetRand (byte[]? p0)
			{
				const string __id = "Lib_GetRand.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_GetVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_GetVersion", "([B)I", "GetLib_GetVersion_arrayBHandler")]
			public override unsafe int Lib_GetVersion (byte[]? p0)
			{
				const string __id = "Lib_GetVersion.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccCheck' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("Lib_IccCheck", "(B)I", "GetLib_IccCheck_BHandler")]
			public override unsafe int Lib_IccCheck (sbyte p0)
			{
				const string __id = "Lib_IccCheck.(B)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccClose' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("Lib_IccClose", "(B)I", "GetLib_IccClose_BHandler")]
			public override unsafe int Lib_IccClose (sbyte p0)
			{
				const string __id = "Lib_IccClose.(B)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccCommand' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("Lib_IccCommand", "(B[B[B)I", "GetLib_IccCommand_BarrayBarrayBHandler")]
			public override unsafe int Lib_IccCommand (sbyte p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "Lib_IccCommand.(B[B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_IccOpen' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
			[Register ("Lib_IccOpen", "(BB[B)I", "GetLib_IccOpen_BBarrayBHandler")]
			public override unsafe int Lib_IccOpen (sbyte p0, sbyte p1, byte[]? p2)
			{
				const string __id = "Lib_IccOpen.(BB[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_LogSwitch' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_LogSwitch", "(I)I", "GetLib_LogSwitch_IHandler")]
			public override unsafe int Lib_LogSwitch (int p0)
			{
				const string __id = "Lib_LogSwitch.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrintCutQrCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
			[Register ("Lib_PrintCutQrCode", "(Ljava/lang/String;IILjava/lang/String;)I", "GetLib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_Handler")]
			public override unsafe int Lib_PrintCutQrCode (string? p0, int p1, int p2, string? p3)
			{
				const string __id = "Lib_PrintCutQrCode.(Ljava/lang/String;IILjava/lang/String;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrintCutQrCodeStr' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
			[Register ("Lib_PrintCutQrCodeStr", "(Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)I", "GetLib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler")]
			public override unsafe int Lib_PrintCutQrCodeStr (string? p0, string? p1, int p2, int p3, int p4, string? p5)
			{
				const string __id = "Lib_PrintCutQrCodeStr.(Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnBarcode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
			[Register ("Lib_PrnBarcode", "(Ljava/lang/String;IILjava/lang/String;)I", "GetLib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_Handler")]
			public override unsafe int Lib_PrnBarcode (string? p0, int p1, int p2, string? p3)
			{
				const string __id = "Lib_PrnBarcode.(Ljava/lang/String;IILjava/lang/String;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnBmp' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("Lib_PrnBmp", "(Landroid/graphics/Bitmap;)I", "GetLib_PrnBmp_Landroid_graphics_Bitmap_Handler")]
			public override unsafe int Lib_PrnBmp (global::Android.Graphics.Bitmap? p0)
			{
				const string __id = "Lib_PrnBmp.(Landroid/graphics/Bitmap;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnCheckStatus' and count(parameter)=0]"
			[Register ("Lib_PrnCheckStatus", "()I", "GetLib_PrnCheckStatusHandler")]
			public override unsafe int Lib_PrnCheckStatus ()
			{
				const string __id = "Lib_PrnCheckStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnFeedPaper' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnFeedPaper", "(I)I", "GetLib_PrnFeedPaper_IHandler")]
			public override unsafe int Lib_PrnFeedPaper (int p0)
			{
				const string __id = "Lib_PrnFeedPaper.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnGetFont' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("Lib_PrnGetFont", "([B[B[B)I", "GetLib_PrnGetFont_arrayBarrayBarrayBHandler")]
			public override unsafe int Lib_PrnGetFont (byte[]? p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "Lib_PrnGetFont.([B[B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnInit' and count(parameter)=0]"
			[Register ("Lib_PrnInit", "()I", "GetLib_PrnInitHandler")]
			public override unsafe int Lib_PrnInit ()
			{
				const string __id = "Lib_PrnInit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnIsCharge' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnIsCharge", "(I)I", "GetLib_PrnIsCharge_IHandler")]
			public override unsafe int Lib_PrnIsCharge (int p0)
			{
				const string __id = "Lib_PrnIsCharge.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnLogo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_PrnLogo", "([B)I", "GetLib_PrnLogo_arrayBHandler")]
			public override unsafe int Lib_PrnLogo (byte[]? p0)
			{
				const string __id = "Lib_PrnLogo.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetAlign' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetAlign", "(I)I", "GetLib_PrnSetAlign_IHandler")]
			public override unsafe int Lib_PrnSetAlign (int p0)
			{
				const string __id = "Lib_PrnSetAlign.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetBold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetBold", "(I)I", "GetLib_PrnSetBold_IHandler")]
			public override unsafe int Lib_PrnSetBold (int p0)
			{
				const string __id = "Lib_PrnSetBold.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetCharSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetCharSpace", "(I)I", "GetLib_PrnSetCharSpace_IHandler")]
			public override unsafe int Lib_PrnSetCharSpace (int p0)
			{
				const string __id = "Lib_PrnSetCharSpace.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetFont' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
			[Register ("Lib_PrnSetFont", "(BBB)I", "GetLib_PrnSetFont_BBBHandler")]
			public override unsafe int Lib_PrnSetFont (sbyte p0, sbyte p1, sbyte p2)
			{
				const string __id = "Lib_PrnSetFont.(BBB)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetGray' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetGray", "(I)I", "GetLib_PrnSetGray_IHandler")]
			public override unsafe int Lib_PrnSetGray (int p0)
			{
				const string __id = "Lib_PrnSetGray.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLeftIndent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetLeftIndent", "(I)I", "GetLib_PrnSetLeftIndent_IHandler")]
			public override unsafe int Lib_PrnSetLeftIndent (int p0)
			{
				const string __id = "Lib_PrnSetLeftIndent.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLeftSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetLeftSpace", "(I)I", "GetLib_PrnSetLeftSpace_IHandler")]
			public override unsafe int Lib_PrnSetLeftSpace (int p0)
			{
				const string __id = "Lib_PrnSetLeftSpace.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetLineSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetLineSpace", "(I)I", "GetLib_PrnSetLineSpace_IHandler")]
			public override unsafe int Lib_PrnSetLineSpace (int p0)
			{
				const string __id = "Lib_PrnSetLineSpace.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetMode", "(I)I", "GetLib_PrnSetMode_IHandler")]
			public override unsafe int Lib_PrnSetMode (int p0)
			{
				const string __id = "Lib_PrnSetMode.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetReverse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetReverse", "(I)I", "GetLib_PrnSetReverse_IHandler")]
			public override unsafe int Lib_PrnSetReverse (int p0)
			{
				const string __id = "Lib_PrnSetReverse.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetSpace' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
			[Register ("Lib_PrnSetSpace", "(BB)I", "GetLib_PrnSetSpace_BBHandler")]
			public override unsafe int Lib_PrnSetSpace (sbyte p0, sbyte p1)
			{
				const string __id = "Lib_PrnSetSpace.(BB)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetSpeed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetSpeed", "(I)I", "GetLib_PrnSetSpeed_IHandler")]
			public override unsafe int Lib_PrnSetSpeed (int p0)
			{
				const string __id = "Lib_PrnSetSpeed.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetUnderline' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetUnderline", "(I)I", "GetLib_PrnSetUnderline_IHandler")]
			public override unsafe int Lib_PrnSetUnderline (int p0)
			{
				const string __id = "Lib_PrnSetUnderline.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnSetVoltage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnSetVoltage", "(I)I", "GetLib_PrnSetVoltage_IHandler")]
			public override unsafe int Lib_PrnSetVoltage (int p0)
			{
				const string __id = "Lib_PrnSetVoltage.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStart' and count(parameter)=0]"
			[Register ("Lib_PrnStart", "()I", "GetLib_PrnStartHandler")]
			public override unsafe int Lib_PrnStart ()
			{
				const string __id = "Lib_PrnStart.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStep' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Lib_PrnStep", "(I)I", "GetLib_PrnStep_IHandler")]
			public override unsafe int Lib_PrnStep (int p0)
			{
				const string __id = "Lib_PrnStep.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_PrnStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("Lib_PrnStr", "(Ljava/lang/String;)I", "GetLib_PrnStr_Ljava_lang_String_Handler")]
			public override unsafe int Lib_PrnStr (string? p0)
			{
				const string __id = "Lib_PrnStr.(Ljava/lang/String;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_ReadChipID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("Lib_ReadChipID", "([BI)I", "GetLib_ReadChipID_arrayBIHandler")]
			public override unsafe int Lib_ReadChipID (byte[]? p0, int p1)
			{
				const string __id = "Lib_ReadChipID.([BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_ReadSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_ReadSN", "([B)I", "GetLib_ReadSN_arrayBHandler")]
			public override unsafe int Lib_ReadSN (byte[]? p0)
			{
				const string __id = "Lib_ReadSN.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_SetLinPixelDis' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("Lib_SetLinPixelDis", "(C)I", "GetLib_SetLinPixelDis_CHandler")]
			public override unsafe int Lib_SetLinPixelDis (char p0)
			{
				const string __id = "Lib_SetLinPixelDis.(C)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_Update_32550' and count(parameter)=0]"
			[Register ("Lib_Update_32550", "()I", "GetLib_Update_32550Handler")]
			public override unsafe int Lib_Update_32550 ()
			{
				const string __id = "Lib_Update_32550.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='Lib_WriteSN' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Lib_WriteSN", "([B)I", "GetLib_WriteSN_arrayBHandler")]
			public override unsafe int Lib_WriteSN (byte[]? p0)
			{
				const string __id = "Lib_WriteSN.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='SC_ApduCmd' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("SC_ApduCmd", "(B[BI[B[B)I", "GetSC_ApduCmd_BarrayBIarrayBarrayBHandler")]
			public override unsafe int SC_ApduCmd (sbyte p0, byte[]? p1, int p2, byte[]? p3, byte[]? p4)
			{
				const string __id = "SC_ApduCmd.(B[BI[B[B)I";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='addAppToInstallWhiteList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addAppToInstallWhiteList", "(Ljava/lang/String;)Z", "GetAddAppToInstallWhiteList_Ljava_lang_String_Handler")]
			public override unsafe bool AddAppToInstallWhiteList (string? p0)
			{
				const string __id = "addAppToInstallWhiteList.(Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='addAppToUninstallBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addAppToUninstallBlackList", "(Ljava/lang/String;)Z", "GetAddAppToUninstallBlackList_Ljava_lang_String_Handler")]
			public override unsafe bool AddAppToUninstallBlackList (string? p0)
			{
				const string __id = "addAppToUninstallBlackList.(Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='delAppFromInstallWhiteList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("delAppFromInstallWhiteList", "(Ljava/lang/String;)Z", "GetDelAppFromInstallWhiteList_Ljava_lang_String_Handler")]
			public override unsafe bool DelAppFromInstallWhiteList (string? p0)
			{
				const string __id = "delAppFromInstallWhiteList.(Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='delAppFromUninstallBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("delAppFromUninstallBlackList", "(Ljava/lang/String;)Z", "GetDelAppFromUninstallBlackList_Ljava_lang_String_Handler")]
			public override unsafe bool DelAppFromUninstallBlackList (string? p0)
			{
				const string __id = "delAppFromUninstallBlackList.(Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='disableAppInstallWhiteList' and count(parameter)=0]"
			[Register ("disableAppInstallWhiteList", "()Z", "GetDisableAppInstallWhiteListHandler")]
			public override unsafe bool DisableAppInstallWhiteList ()
			{
				const string __id = "disableAppInstallWhiteList.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='disableAppUninstallBlackList' and count(parameter)=0]"
			[Register ("disableAppUninstallBlackList", "()Z", "GetDisableAppUninstallBlackListHandler")]
			public override unsafe bool DisableAppUninstallBlackList ()
			{
				const string __id = "disableAppUninstallBlackList.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='enableAppInstallWhiteList' and count(parameter)=0]"
			[Register ("enableAppInstallWhiteList", "()Z", "GetEnableAppInstallWhiteListHandler")]
			public override unsafe bool EnableAppInstallWhiteList ()
			{
				const string __id = "enableAppInstallWhiteList.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='enableAppUninstallBlackList' and count(parameter)=0]"
			[Register ("enableAppUninstallBlackList", "()Z", "GetEnableAppUninstallBlackListHandler")]
			public override unsafe bool EnableAppUninstallBlackList ()
			{
				const string __id = "enableAppUninstallBlackList.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalClose' and count(parameter)=0]"
			[Register ("fiscalClose", "()I", "GetFiscalCloseHandler")]
			public override unsafe int FiscalClose ()
			{
				const string __id = "fiscalClose.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalOpen' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='char'] and parameter[5][@type='char']]"
			[Register ("fiscalOpen", "(IIICC)I", "GetFiscalOpen_IIICCHandler")]
			public override unsafe int FiscalOpen (int p0, int p1, int p2, char p3, char p4)
			{
				const string __id = "fiscalOpen.(IIICC)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalRead' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("fiscalRead", "([BII)I", "GetFiscalRead_arrayBIIHandler")]
			public override unsafe int FiscalRead (byte[]? p0, int p1, int p2)
			{
				const string __id = "fiscalRead.([BII)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='fiscalWrite' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("fiscalWrite", "([B)I", "GetFiscalWrite_arrayBHandler")]
			public override unsafe int FiscalWrite (byte[]? p0)
			{
				const string __id = "fiscalWrite.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ciontek.ciontekposservice']/interface[@name='ICiontekPosService']/method[@name='installRomPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("installRomPackage", "(Ljava/lang/String;)I", "GetInstallRomPackage_Ljava_lang_String_Handler")]
			public override unsafe int InstallRomPackage (string? p0)
			{
				const string __id = "installRomPackage.(Ljava/lang/String;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ciontek/ciontekposservice/ICiontekPosService", DoNotGenerateAcw=true)]
	internal partial class ICiontekPosServiceInvoker : global::Java.Lang.Object, ICiontekPosService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ciontek/ciontekposservice/ICiontekPosService", typeof (ICiontekPosServiceInvoker));

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

		public static ICiontekPosService? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICiontekPosService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ciontek.ciontekposservice.ICiontekPosService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICiontekPosServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getAppInstallWhiteList;
#pragma warning disable 0169
		static Delegate GetGetAppInstallWhiteListHandler ()
		{
			if (cb_getAppInstallWhiteList == null)
				cb_getAppInstallWhiteList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAppInstallWhiteList));
			return cb_getAppInstallWhiteList;
		}

		static IntPtr n_GetAppInstallWhiteList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AppInstallWhiteList);
		}
#pragma warning restore 0169

		IntPtr id_getAppInstallWhiteList;
		public unsafe global::System.Collections.Generic.IList<string>? AppInstallWhiteList {
			get {
				if (id_getAppInstallWhiteList == IntPtr.Zero)
					id_getAppInstallWhiteList = JNIEnv.GetMethodID (class_ref, "getAppInstallWhiteList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppInstallWhiteList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getAppUninstallBlackList;
#pragma warning disable 0169
		static Delegate GetGetAppUninstallBlackListHandler ()
		{
			if (cb_getAppUninstallBlackList == null)
				cb_getAppUninstallBlackList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAppUninstallBlackList));
			return cb_getAppUninstallBlackList;
		}

		static IntPtr n_GetAppUninstallBlackList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AppUninstallBlackList);
		}
#pragma warning restore 0169

		IntPtr id_getAppUninstallBlackList;
		public unsafe global::System.Collections.Generic.IList<string>? AppUninstallBlackList {
			get {
				if (id_getAppUninstallBlackList == IntPtr.Zero)
					id_getAppUninstallBlackList = JNIEnv.GetMethodID (class_ref, "getAppUninstallBlackList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppUninstallBlackList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDeviceId));
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceId;
		public unsafe string? DeviceId {
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getOSVersion;
#pragma warning disable 0169
		static Delegate GetGetOSVersionHandler ()
		{
			if (cb_getOSVersion == null)
				cb_getOSVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetOSVersion));
			return cb_getOSVersion;
		}

		static IntPtr n_GetOSVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.OSVersion);
		}
#pragma warning restore 0169

		IntPtr id_getOSVersion;
		public unsafe string? OSVersion {
			get {
				if (id_getOSVersion == IntPtr.Zero)
					id_getOSVersion = JNIEnv.GetMethodID (class_ref, "getOSVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOSVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_Lib_GetRand_arrayB;
#pragma warning disable 0169
		static Delegate GetLib_GetRand_arrayBHandler ()
		{
			if (cb_Lib_GetRand_arrayB == null)
				cb_Lib_GetRand_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_GetRand_arrayB));
			return cb_Lib_GetRand_arrayB;
		}

		static int n_Lib_GetRand_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_GetRand (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_GetRand_arrayB;
		public unsafe int Lib_GetRand (byte[]? p0)
		{
			if (id_Lib_GetRand_arrayB == IntPtr.Zero)
				id_Lib_GetRand_arrayB = JNIEnv.GetMethodID (class_ref, "Lib_GetRand", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_GetRand_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_Lib_GetVersion_arrayB;
#pragma warning disable 0169
		static Delegate GetLib_GetVersion_arrayBHandler ()
		{
			if (cb_Lib_GetVersion_arrayB == null)
				cb_Lib_GetVersion_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_GetVersion_arrayB));
			return cb_Lib_GetVersion_arrayB;
		}

		static int n_Lib_GetVersion_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_GetVersion (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_GetVersion_arrayB;
		public unsafe int Lib_GetVersion (byte[]? p0)
		{
			if (id_Lib_GetVersion_arrayB == IntPtr.Zero)
				id_Lib_GetVersion_arrayB = JNIEnv.GetMethodID (class_ref, "Lib_GetVersion", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_GetVersion_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_Lib_IccCheck_B;
#pragma warning disable 0169
		static Delegate GetLib_IccCheck_BHandler ()
		{
			if (cb_Lib_IccCheck_B == null)
				cb_Lib_IccCheck_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_Lib_IccCheck_B));
			return cb_Lib_IccCheck_B;
		}

		static int n_Lib_IccCheck_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_IccCheck (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_IccCheck_B;
		public unsafe int Lib_IccCheck (sbyte p0)
		{
			if (id_Lib_IccCheck_B == IntPtr.Zero)
				id_Lib_IccCheck_B = JNIEnv.GetMethodID (class_ref, "Lib_IccCheck", "(B)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_IccCheck_B, __args);
		}

		static Delegate? cb_Lib_IccClose_B;
#pragma warning disable 0169
		static Delegate GetLib_IccClose_BHandler ()
		{
			if (cb_Lib_IccClose_B == null)
				cb_Lib_IccClose_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_Lib_IccClose_B));
			return cb_Lib_IccClose_B;
		}

		static int n_Lib_IccClose_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_IccClose (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_IccClose_B;
		public unsafe int Lib_IccClose (sbyte p0)
		{
			if (id_Lib_IccClose_B == IntPtr.Zero)
				id_Lib_IccClose_B = JNIEnv.GetMethodID (class_ref, "Lib_IccClose", "(B)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_IccClose_B, __args);
		}

		static Delegate? cb_Lib_IccCommand_BarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLib_IccCommand_BarrayBarrayBHandler ()
		{
			if (cb_Lib_IccCommand_BarrayBarrayB == null)
				cb_Lib_IccCommand_BarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLL_I (n_Lib_IccCommand_BarrayBarrayB));
			return cb_Lib_IccCommand_BarrayBarrayB;
		}

		static int n_Lib_IccCommand_BarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_IccCommand (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_IccCommand_BarrayBarrayB;
		public unsafe int Lib_IccCommand (sbyte p0, byte[]? p1, byte[]? p2)
		{
			if (id_Lib_IccCommand_BarrayBarrayB == IntPtr.Zero)
				id_Lib_IccCommand_BarrayBarrayB = JNIEnv.GetMethodID (class_ref, "Lib_IccCommand", "(B[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_IccCommand_BarrayBarrayB, __args);
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

		static Delegate? cb_Lib_IccOpen_BBarrayB;
#pragma warning disable 0169
		static Delegate GetLib_IccOpen_BBarrayBHandler ()
		{
			if (cb_Lib_IccOpen_BBarrayB == null)
				cb_Lib_IccOpen_BBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBL_I (n_Lib_IccOpen_BBarrayB));
			return cb_Lib_IccOpen_BBarrayB;
		}

		static int n_Lib_IccOpen_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_IccOpen (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_IccOpen_BBarrayB;
		public unsafe int Lib_IccOpen (sbyte p0, sbyte p1, byte[]? p2)
		{
			if (id_Lib_IccOpen_BBarrayB == IntPtr.Zero)
				id_Lib_IccOpen_BBarrayB = JNIEnv.GetMethodID (class_ref, "Lib_IccOpen", "(BB[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_IccOpen_BBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_Lib_LogSwitch_I;
#pragma warning disable 0169
		static Delegate GetLib_LogSwitch_IHandler ()
		{
			if (cb_Lib_LogSwitch_I == null)
				cb_Lib_LogSwitch_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_LogSwitch_I));
			return cb_Lib_LogSwitch_I;
		}

		static int n_Lib_LogSwitch_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_LogSwitch (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_LogSwitch_I;
		public unsafe int Lib_LogSwitch (int p0)
		{
			if (id_Lib_LogSwitch_I == IntPtr.Zero)
				id_Lib_LogSwitch_I = JNIEnv.GetMethodID (class_ref, "Lib_LogSwitch", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_LogSwitch_I, __args);
		}

		static Delegate? cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_Handler ()
		{
			if (cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ == null)
				cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIL_I (n_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_));
			return cb_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_;
		}

		static int n_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Lib_PrintCutQrCode (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_;
		public unsafe int Lib_PrintCutQrCode (string? p0, int p1, int p2, string? p3)
		{
			if (id_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
				id_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Lib_PrintCutQrCode", "(Ljava/lang/String;IILjava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrintCutQrCode_Ljava_lang_String_IILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate? cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler ()
		{
			if (cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ == null)
				cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIIIL_I (n_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_));
			return cb_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
		}

		static int n_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Lib_PrintCutQrCodeStr (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
		public unsafe int Lib_PrintCutQrCodeStr (string? p0, string? p1, int p2, int p3, int p4, string? p5)
		{
			if (id_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ == IntPtr.Zero)
				id_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Lib_PrintCutQrCodeStr", "(Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrintCutQrCodeStr_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p5);
			return __ret;
		}

		static Delegate? cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_Handler ()
		{
			if (cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ == null)
				cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIL_I (n_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_));
			return cb_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_;
		}

		static int n_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Lib_PrnBarcode (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_;
		public unsafe int Lib_PrnBarcode (string? p0, int p1, int p2, string? p3)
		{
			if (id_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
				id_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Lib_PrnBarcode", "(Ljava/lang/String;IILjava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnBarcode_Ljava_lang_String_IILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate? cb_Lib_PrnBmp_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetLib_PrnBmp_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_Lib_PrnBmp_Landroid_graphics_Bitmap_ == null)
				cb_Lib_PrnBmp_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_PrnBmp_Landroid_graphics_Bitmap_));
			return cb_Lib_PrnBmp_Landroid_graphics_Bitmap_;
		}

		static int n_Lib_PrnBmp_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Lib_PrnBmp (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnBmp_Landroid_graphics_Bitmap_;
		public unsafe int Lib_PrnBmp (global::Android.Graphics.Bitmap? p0)
		{
			if (id_Lib_PrnBmp_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_Lib_PrnBmp_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "Lib_PrnBmp", "(Landroid/graphics/Bitmap;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnBmp_Landroid_graphics_Bitmap_, __args);
			return __ret;
		}

		static Delegate? cb_Lib_PrnCheckStatus;
#pragma warning disable 0169
		static Delegate GetLib_PrnCheckStatusHandler ()
		{
			if (cb_Lib_PrnCheckStatus == null)
				cb_Lib_PrnCheckStatus = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_PrnCheckStatus));
			return cb_Lib_PrnCheckStatus;
		}

		static int n_Lib_PrnCheckStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnCheckStatus ();
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnCheckStatus;
		public unsafe int Lib_PrnCheckStatus ()
		{
			if (id_Lib_PrnCheckStatus == IntPtr.Zero)
				id_Lib_PrnCheckStatus = JNIEnv.GetMethodID (class_ref, "Lib_PrnCheckStatus", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnCheckStatus);
		}

		static Delegate? cb_Lib_PrnFeedPaper_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnFeedPaper_IHandler ()
		{
			if (cb_Lib_PrnFeedPaper_I == null)
				cb_Lib_PrnFeedPaper_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnFeedPaper_I));
			return cb_Lib_PrnFeedPaper_I;
		}

		static int n_Lib_PrnFeedPaper_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnFeedPaper (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnFeedPaper_I;
		public unsafe int Lib_PrnFeedPaper (int p0)
		{
			if (id_Lib_PrnFeedPaper_I == IntPtr.Zero)
				id_Lib_PrnFeedPaper_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnFeedPaper", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnFeedPaper_I, __args);
		}

		static Delegate? cb_Lib_PrnGetFont_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLib_PrnGetFont_arrayBarrayBarrayBHandler ()
		{
			if (cb_Lib_PrnGetFont_arrayBarrayBarrayB == null)
				cb_Lib_PrnGetFont_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_Lib_PrnGetFont_arrayBarrayBarrayB));
			return cb_Lib_PrnGetFont_arrayBarrayBarrayB;
		}

		static int n_Lib_PrnGetFont_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_PrnGetFont (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnGetFont_arrayBarrayBarrayB;
		public unsafe int Lib_PrnGetFont (byte[]? p0, byte[]? p1, byte[]? p2)
		{
			if (id_Lib_PrnGetFont_arrayBarrayBarrayB == IntPtr.Zero)
				id_Lib_PrnGetFont_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "Lib_PrnGetFont", "([B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnGetFont_arrayBarrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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

		static Delegate? cb_Lib_PrnInit;
#pragma warning disable 0169
		static Delegate GetLib_PrnInitHandler ()
		{
			if (cb_Lib_PrnInit == null)
				cb_Lib_PrnInit = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_PrnInit));
			return cb_Lib_PrnInit;
		}

		static int n_Lib_PrnInit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnInit ();
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnInit;
		public unsafe int Lib_PrnInit ()
		{
			if (id_Lib_PrnInit == IntPtr.Zero)
				id_Lib_PrnInit = JNIEnv.GetMethodID (class_ref, "Lib_PrnInit", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnInit);
		}

		static Delegate? cb_Lib_PrnIsCharge_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnIsCharge_IHandler ()
		{
			if (cb_Lib_PrnIsCharge_I == null)
				cb_Lib_PrnIsCharge_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnIsCharge_I));
			return cb_Lib_PrnIsCharge_I;
		}

		static int n_Lib_PrnIsCharge_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnIsCharge (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnIsCharge_I;
		public unsafe int Lib_PrnIsCharge (int p0)
		{
			if (id_Lib_PrnIsCharge_I == IntPtr.Zero)
				id_Lib_PrnIsCharge_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnIsCharge", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnIsCharge_I, __args);
		}

		static Delegate? cb_Lib_PrnLogo_arrayB;
#pragma warning disable 0169
		static Delegate GetLib_PrnLogo_arrayBHandler ()
		{
			if (cb_Lib_PrnLogo_arrayB == null)
				cb_Lib_PrnLogo_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_PrnLogo_arrayB));
			return cb_Lib_PrnLogo_arrayB;
		}

		static int n_Lib_PrnLogo_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_PrnLogo (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnLogo_arrayB;
		public unsafe int Lib_PrnLogo (byte[]? p0)
		{
			if (id_Lib_PrnLogo_arrayB == IntPtr.Zero)
				id_Lib_PrnLogo_arrayB = JNIEnv.GetMethodID (class_ref, "Lib_PrnLogo", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnLogo_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_Lib_PrnSetAlign_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetAlign_IHandler ()
		{
			if (cb_Lib_PrnSetAlign_I == null)
				cb_Lib_PrnSetAlign_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetAlign_I));
			return cb_Lib_PrnSetAlign_I;
		}

		static int n_Lib_PrnSetAlign_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetAlign (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetAlign_I;
		public unsafe int Lib_PrnSetAlign (int p0)
		{
			if (id_Lib_PrnSetAlign_I == IntPtr.Zero)
				id_Lib_PrnSetAlign_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetAlign", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetAlign_I, __args);
		}

		static Delegate? cb_Lib_PrnSetBold_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetBold_IHandler ()
		{
			if (cb_Lib_PrnSetBold_I == null)
				cb_Lib_PrnSetBold_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetBold_I));
			return cb_Lib_PrnSetBold_I;
		}

		static int n_Lib_PrnSetBold_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetBold (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetBold_I;
		public unsafe int Lib_PrnSetBold (int p0)
		{
			if (id_Lib_PrnSetBold_I == IntPtr.Zero)
				id_Lib_PrnSetBold_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetBold", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetBold_I, __args);
		}

		static Delegate? cb_Lib_PrnSetCharSpace_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetCharSpace_IHandler ()
		{
			if (cb_Lib_PrnSetCharSpace_I == null)
				cb_Lib_PrnSetCharSpace_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetCharSpace_I));
			return cb_Lib_PrnSetCharSpace_I;
		}

		static int n_Lib_PrnSetCharSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetCharSpace (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetCharSpace_I;
		public unsafe int Lib_PrnSetCharSpace (int p0)
		{
			if (id_Lib_PrnSetCharSpace_I == IntPtr.Zero)
				id_Lib_PrnSetCharSpace_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetCharSpace", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetCharSpace_I, __args);
		}

		static Delegate? cb_Lib_PrnSetFont_BBB;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetFont_BBBHandler ()
		{
			if (cb_Lib_PrnSetFont_BBB == null)
				cb_Lib_PrnSetFont_BBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBB_I (n_Lib_PrnSetFont_BBB));
			return cb_Lib_PrnSetFont_BBB;
		}

		static int n_Lib_PrnSetFont_BBB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetFont (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetFont_BBB;
		public unsafe int Lib_PrnSetFont (sbyte p0, sbyte p1, sbyte p2)
		{
			if (id_Lib_PrnSetFont_BBB == IntPtr.Zero)
				id_Lib_PrnSetFont_BBB = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetFont", "(BBB)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetFont_BBB, __args);
		}

		static Delegate? cb_Lib_PrnSetGray_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetGray_IHandler ()
		{
			if (cb_Lib_PrnSetGray_I == null)
				cb_Lib_PrnSetGray_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetGray_I));
			return cb_Lib_PrnSetGray_I;
		}

		static int n_Lib_PrnSetGray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetGray (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetGray_I;
		public unsafe int Lib_PrnSetGray (int p0)
		{
			if (id_Lib_PrnSetGray_I == IntPtr.Zero)
				id_Lib_PrnSetGray_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetGray", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetGray_I, __args);
		}

		static Delegate? cb_Lib_PrnSetLeftIndent_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetLeftIndent_IHandler ()
		{
			if (cb_Lib_PrnSetLeftIndent_I == null)
				cb_Lib_PrnSetLeftIndent_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetLeftIndent_I));
			return cb_Lib_PrnSetLeftIndent_I;
		}

		static int n_Lib_PrnSetLeftIndent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetLeftIndent (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetLeftIndent_I;
		public unsafe int Lib_PrnSetLeftIndent (int p0)
		{
			if (id_Lib_PrnSetLeftIndent_I == IntPtr.Zero)
				id_Lib_PrnSetLeftIndent_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetLeftIndent", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetLeftIndent_I, __args);
		}

		static Delegate? cb_Lib_PrnSetLeftSpace_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetLeftSpace_IHandler ()
		{
			if (cb_Lib_PrnSetLeftSpace_I == null)
				cb_Lib_PrnSetLeftSpace_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetLeftSpace_I));
			return cb_Lib_PrnSetLeftSpace_I;
		}

		static int n_Lib_PrnSetLeftSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetLeftSpace (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetLeftSpace_I;
		public unsafe int Lib_PrnSetLeftSpace (int p0)
		{
			if (id_Lib_PrnSetLeftSpace_I == IntPtr.Zero)
				id_Lib_PrnSetLeftSpace_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetLeftSpace", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetLeftSpace_I, __args);
		}

		static Delegate? cb_Lib_PrnSetLineSpace_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetLineSpace_IHandler ()
		{
			if (cb_Lib_PrnSetLineSpace_I == null)
				cb_Lib_PrnSetLineSpace_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetLineSpace_I));
			return cb_Lib_PrnSetLineSpace_I;
		}

		static int n_Lib_PrnSetLineSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetLineSpace (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetLineSpace_I;
		public unsafe int Lib_PrnSetLineSpace (int p0)
		{
			if (id_Lib_PrnSetLineSpace_I == IntPtr.Zero)
				id_Lib_PrnSetLineSpace_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetLineSpace", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetLineSpace_I, __args);
		}

		static Delegate? cb_Lib_PrnSetMode_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetMode_IHandler ()
		{
			if (cb_Lib_PrnSetMode_I == null)
				cb_Lib_PrnSetMode_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetMode_I));
			return cb_Lib_PrnSetMode_I;
		}

		static int n_Lib_PrnSetMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetMode (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetMode_I;
		public unsafe int Lib_PrnSetMode (int p0)
		{
			if (id_Lib_PrnSetMode_I == IntPtr.Zero)
				id_Lib_PrnSetMode_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetMode", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetMode_I, __args);
		}

		static Delegate? cb_Lib_PrnSetReverse_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetReverse_IHandler ()
		{
			if (cb_Lib_PrnSetReverse_I == null)
				cb_Lib_PrnSetReverse_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetReverse_I));
			return cb_Lib_PrnSetReverse_I;
		}

		static int n_Lib_PrnSetReverse_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetReverse (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetReverse_I;
		public unsafe int Lib_PrnSetReverse (int p0)
		{
			if (id_Lib_PrnSetReverse_I == IntPtr.Zero)
				id_Lib_PrnSetReverse_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetReverse", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetReverse_I, __args);
		}

		static Delegate? cb_Lib_PrnSetSpace_BB;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetSpace_BBHandler ()
		{
			if (cb_Lib_PrnSetSpace_BB == null)
				cb_Lib_PrnSetSpace_BB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBB_I (n_Lib_PrnSetSpace_BB));
			return cb_Lib_PrnSetSpace_BB;
		}

		static int n_Lib_PrnSetSpace_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetSpace (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetSpace_BB;
		public unsafe int Lib_PrnSetSpace (sbyte p0, sbyte p1)
		{
			if (id_Lib_PrnSetSpace_BB == IntPtr.Zero)
				id_Lib_PrnSetSpace_BB = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetSpace", "(BB)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetSpace_BB, __args);
		}

		static Delegate? cb_Lib_PrnSetSpeed_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetSpeed_IHandler ()
		{
			if (cb_Lib_PrnSetSpeed_I == null)
				cb_Lib_PrnSetSpeed_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetSpeed_I));
			return cb_Lib_PrnSetSpeed_I;
		}

		static int n_Lib_PrnSetSpeed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetSpeed (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetSpeed_I;
		public unsafe int Lib_PrnSetSpeed (int p0)
		{
			if (id_Lib_PrnSetSpeed_I == IntPtr.Zero)
				id_Lib_PrnSetSpeed_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetSpeed", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetSpeed_I, __args);
		}

		static Delegate? cb_Lib_PrnSetUnderline_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetUnderline_IHandler ()
		{
			if (cb_Lib_PrnSetUnderline_I == null)
				cb_Lib_PrnSetUnderline_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetUnderline_I));
			return cb_Lib_PrnSetUnderline_I;
		}

		static int n_Lib_PrnSetUnderline_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetUnderline (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetUnderline_I;
		public unsafe int Lib_PrnSetUnderline (int p0)
		{
			if (id_Lib_PrnSetUnderline_I == IntPtr.Zero)
				id_Lib_PrnSetUnderline_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetUnderline", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetUnderline_I, __args);
		}

		static Delegate? cb_Lib_PrnSetVoltage_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnSetVoltage_IHandler ()
		{
			if (cb_Lib_PrnSetVoltage_I == null)
				cb_Lib_PrnSetVoltage_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnSetVoltage_I));
			return cb_Lib_PrnSetVoltage_I;
		}

		static int n_Lib_PrnSetVoltage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnSetVoltage (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnSetVoltage_I;
		public unsafe int Lib_PrnSetVoltage (int p0)
		{
			if (id_Lib_PrnSetVoltage_I == IntPtr.Zero)
				id_Lib_PrnSetVoltage_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnSetVoltage", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnSetVoltage_I, __args);
		}

		static Delegate? cb_Lib_PrnStart;
#pragma warning disable 0169
		static Delegate GetLib_PrnStartHandler ()
		{
			if (cb_Lib_PrnStart == null)
				cb_Lib_PrnStart = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_PrnStart));
			return cb_Lib_PrnStart;
		}

		static int n_Lib_PrnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnStart ();
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnStart;
		public unsafe int Lib_PrnStart ()
		{
			if (id_Lib_PrnStart == IntPtr.Zero)
				id_Lib_PrnStart = JNIEnv.GetMethodID (class_ref, "Lib_PrnStart", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnStart);
		}

		static Delegate? cb_Lib_PrnStep_I;
#pragma warning disable 0169
		static Delegate GetLib_PrnStep_IHandler ()
		{
			if (cb_Lib_PrnStep_I == null)
				cb_Lib_PrnStep_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Lib_PrnStep_I));
			return cb_Lib_PrnStep_I;
		}

		static int n_Lib_PrnStep_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_PrnStep (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnStep_I;
		public unsafe int Lib_PrnStep (int p0)
		{
			if (id_Lib_PrnStep_I == IntPtr.Zero)
				id_Lib_PrnStep_I = JNIEnv.GetMethodID (class_ref, "Lib_PrnStep", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnStep_I, __args);
		}

		static Delegate? cb_Lib_PrnStr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLib_PrnStr_Ljava_lang_String_Handler ()
		{
			if (cb_Lib_PrnStr_Ljava_lang_String_ == null)
				cb_Lib_PrnStr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_PrnStr_Ljava_lang_String_));
			return cb_Lib_PrnStr_Ljava_lang_String_;
		}

		static int n_Lib_PrnStr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Lib_PrnStr (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_PrnStr_Ljava_lang_String_;
		public unsafe int Lib_PrnStr (string? p0)
		{
			if (id_Lib_PrnStr_Ljava_lang_String_ == IntPtr.Zero)
				id_Lib_PrnStr_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Lib_PrnStr", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_PrnStr_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_Lib_ReadChipID_arrayBI;
#pragma warning disable 0169
		static Delegate GetLib_ReadChipID_arrayBIHandler ()
		{
			if (cb_Lib_ReadChipID_arrayBI == null)
				cb_Lib_ReadChipID_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Lib_ReadChipID_arrayBI));
			return cb_Lib_ReadChipID_arrayBI;
		}

		static int n_Lib_ReadChipID_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_ReadChipID (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_ReadChipID_arrayBI;
		public unsafe int Lib_ReadChipID (byte[]? p0, int p1)
		{
			if (id_Lib_ReadChipID_arrayBI == IntPtr.Zero)
				id_Lib_ReadChipID_arrayBI = JNIEnv.GetMethodID (class_ref, "Lib_ReadChipID", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_ReadChipID_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_Lib_ReadSN_arrayB;
#pragma warning disable 0169
		static Delegate GetLib_ReadSN_arrayBHandler ()
		{
			if (cb_Lib_ReadSN_arrayB == null)
				cb_Lib_ReadSN_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_ReadSN_arrayB));
			return cb_Lib_ReadSN_arrayB;
		}

		static int n_Lib_ReadSN_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_ReadSN (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_ReadSN_arrayB;
		public unsafe int Lib_ReadSN (byte[]? p0)
		{
			if (id_Lib_ReadSN_arrayB == IntPtr.Zero)
				id_Lib_ReadSN_arrayB = JNIEnv.GetMethodID (class_ref, "Lib_ReadSN", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_ReadSN_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_Lib_SetLinPixelDis_C;
#pragma warning disable 0169
		static Delegate GetLib_SetLinPixelDis_CHandler ()
		{
			if (cb_Lib_SetLinPixelDis_C == null)
				cb_Lib_SetLinPixelDis_C = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPC_I (n_Lib_SetLinPixelDis_C));
			return cb_Lib_SetLinPixelDis_C;
		}

		static int n_Lib_SetLinPixelDis_C (IntPtr jnienv, IntPtr native__this, char p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_SetLinPixelDis (p0);
		}
#pragma warning restore 0169

		IntPtr id_Lib_SetLinPixelDis_C;
		public unsafe int Lib_SetLinPixelDis (char p0)
		{
			if (id_Lib_SetLinPixelDis_C == IntPtr.Zero)
				id_Lib_SetLinPixelDis_C = JNIEnv.GetMethodID (class_ref, "Lib_SetLinPixelDis", "(C)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_SetLinPixelDis_C, __args);
		}

		static Delegate? cb_Lib_Update_32550;
#pragma warning disable 0169
		static Delegate GetLib_Update_32550Handler ()
		{
			if (cb_Lib_Update_32550 == null)
				cb_Lib_Update_32550 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Lib_Update_32550));
			return cb_Lib_Update_32550;
		}

		static int n_Lib_Update_32550 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lib_Update_32550 ();
		}
#pragma warning restore 0169

		IntPtr id_Lib_Update_32550;
		public unsafe int Lib_Update_32550 ()
		{
			if (id_Lib_Update_32550 == IntPtr.Zero)
				id_Lib_Update_32550 = JNIEnv.GetMethodID (class_ref, "Lib_Update_32550", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_Update_32550);
		}

		static Delegate? cb_Lib_WriteSN_arrayB;
#pragma warning disable 0169
		static Delegate GetLib_WriteSN_arrayBHandler ()
		{
			if (cb_Lib_WriteSN_arrayB == null)
				cb_Lib_WriteSN_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_Lib_WriteSN_arrayB));
			return cb_Lib_WriteSN_arrayB;
		}

		static int n_Lib_WriteSN_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Lib_WriteSN (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Lib_WriteSN_arrayB;
		public unsafe int Lib_WriteSN (byte[]? p0)
		{
			if (id_Lib_WriteSN_arrayB == IntPtr.Zero)
				id_Lib_WriteSN_arrayB = JNIEnv.GetMethodID (class_ref, "Lib_WriteSN", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Lib_WriteSN_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_SC_ApduCmd_BarrayBIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSC_ApduCmd_BarrayBIarrayBarrayBHandler ()
		{
			if (cb_SC_ApduCmd_BarrayBIarrayBarrayB == null)
				cb_SC_ApduCmd_BarrayBIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLILL_I (n_SC_ApduCmd_BarrayBIarrayBarrayB));
			return cb_SC_ApduCmd_BarrayBIarrayBarrayB;
		}

		static int n_SC_ApduCmd_BarrayBIarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SC_ApduCmd (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SC_ApduCmd_BarrayBIarrayBarrayB;
		public unsafe int SC_ApduCmd (sbyte p0, byte[]? p1, int p2, byte[]? p3, byte[]? p4)
		{
			if (id_SC_ApduCmd_BarrayBIarrayBarrayB == IntPtr.Zero)
				id_SC_ApduCmd_BarrayBIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "SC_ApduCmd", "(B[BI[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SC_ApduCmd_BarrayBIarrayBarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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

		static Delegate? cb_addAppToInstallWhiteList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAppToInstallWhiteList_Ljava_lang_String_Handler ()
		{
			if (cb_addAppToInstallWhiteList_Ljava_lang_String_ == null)
				cb_addAppToInstallWhiteList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_AddAppToInstallWhiteList_Ljava_lang_String_));
			return cb_addAppToInstallWhiteList_Ljava_lang_String_;
		}

		static bool n_AddAppToInstallWhiteList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAppToInstallWhiteList (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addAppToInstallWhiteList_Ljava_lang_String_;
		public unsafe bool AddAppToInstallWhiteList (string? p0)
		{
			if (id_addAppToInstallWhiteList_Ljava_lang_String_ == IntPtr.Zero)
				id_addAppToInstallWhiteList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAppToInstallWhiteList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addAppToInstallWhiteList_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_addAppToUninstallBlackList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAppToUninstallBlackList_Ljava_lang_String_Handler ()
		{
			if (cb_addAppToUninstallBlackList_Ljava_lang_String_ == null)
				cb_addAppToUninstallBlackList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_AddAppToUninstallBlackList_Ljava_lang_String_));
			return cb_addAppToUninstallBlackList_Ljava_lang_String_;
		}

		static bool n_AddAppToUninstallBlackList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAppToUninstallBlackList (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addAppToUninstallBlackList_Ljava_lang_String_;
		public unsafe bool AddAppToUninstallBlackList (string? p0)
		{
			if (id_addAppToUninstallBlackList_Ljava_lang_String_ == IntPtr.Zero)
				id_addAppToUninstallBlackList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAppToUninstallBlackList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addAppToUninstallBlackList_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_delAppFromInstallWhiteList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelAppFromInstallWhiteList_Ljava_lang_String_Handler ()
		{
			if (cb_delAppFromInstallWhiteList_Ljava_lang_String_ == null)
				cb_delAppFromInstallWhiteList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_DelAppFromInstallWhiteList_Ljava_lang_String_));
			return cb_delAppFromInstallWhiteList_Ljava_lang_String_;
		}

		static bool n_DelAppFromInstallWhiteList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DelAppFromInstallWhiteList (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_delAppFromInstallWhiteList_Ljava_lang_String_;
		public unsafe bool DelAppFromInstallWhiteList (string? p0)
		{
			if (id_delAppFromInstallWhiteList_Ljava_lang_String_ == IntPtr.Zero)
				id_delAppFromInstallWhiteList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delAppFromInstallWhiteList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_delAppFromInstallWhiteList_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_delAppFromUninstallBlackList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelAppFromUninstallBlackList_Ljava_lang_String_Handler ()
		{
			if (cb_delAppFromUninstallBlackList_Ljava_lang_String_ == null)
				cb_delAppFromUninstallBlackList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_DelAppFromUninstallBlackList_Ljava_lang_String_));
			return cb_delAppFromUninstallBlackList_Ljava_lang_String_;
		}

		static bool n_DelAppFromUninstallBlackList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DelAppFromUninstallBlackList (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_delAppFromUninstallBlackList_Ljava_lang_String_;
		public unsafe bool DelAppFromUninstallBlackList (string? p0)
		{
			if (id_delAppFromUninstallBlackList_Ljava_lang_String_ == IntPtr.Zero)
				id_delAppFromUninstallBlackList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delAppFromUninstallBlackList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_delAppFromUninstallBlackList_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_disableAppInstallWhiteList;
#pragma warning disable 0169
		static Delegate GetDisableAppInstallWhiteListHandler ()
		{
			if (cb_disableAppInstallWhiteList == null)
				cb_disableAppInstallWhiteList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_DisableAppInstallWhiteList));
			return cb_disableAppInstallWhiteList;
		}

		static bool n_DisableAppInstallWhiteList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DisableAppInstallWhiteList ();
		}
#pragma warning restore 0169

		IntPtr id_disableAppInstallWhiteList;
		public unsafe bool DisableAppInstallWhiteList ()
		{
			if (id_disableAppInstallWhiteList == IntPtr.Zero)
				id_disableAppInstallWhiteList = JNIEnv.GetMethodID (class_ref, "disableAppInstallWhiteList", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_disableAppInstallWhiteList);
		}

		static Delegate? cb_disableAppUninstallBlackList;
#pragma warning disable 0169
		static Delegate GetDisableAppUninstallBlackListHandler ()
		{
			if (cb_disableAppUninstallBlackList == null)
				cb_disableAppUninstallBlackList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_DisableAppUninstallBlackList));
			return cb_disableAppUninstallBlackList;
		}

		static bool n_DisableAppUninstallBlackList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DisableAppUninstallBlackList ();
		}
#pragma warning restore 0169

		IntPtr id_disableAppUninstallBlackList;
		public unsafe bool DisableAppUninstallBlackList ()
		{
			if (id_disableAppUninstallBlackList == IntPtr.Zero)
				id_disableAppUninstallBlackList = JNIEnv.GetMethodID (class_ref, "disableAppUninstallBlackList", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_disableAppUninstallBlackList);
		}

		static Delegate? cb_enableAppInstallWhiteList;
#pragma warning disable 0169
		static Delegate GetEnableAppInstallWhiteListHandler ()
		{
			if (cb_enableAppInstallWhiteList == null)
				cb_enableAppInstallWhiteList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_EnableAppInstallWhiteList));
			return cb_enableAppInstallWhiteList;
		}

		static bool n_EnableAppInstallWhiteList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.EnableAppInstallWhiteList ();
		}
#pragma warning restore 0169

		IntPtr id_enableAppInstallWhiteList;
		public unsafe bool EnableAppInstallWhiteList ()
		{
			if (id_enableAppInstallWhiteList == IntPtr.Zero)
				id_enableAppInstallWhiteList = JNIEnv.GetMethodID (class_ref, "enableAppInstallWhiteList", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_enableAppInstallWhiteList);
		}

		static Delegate? cb_enableAppUninstallBlackList;
#pragma warning disable 0169
		static Delegate GetEnableAppUninstallBlackListHandler ()
		{
			if (cb_enableAppUninstallBlackList == null)
				cb_enableAppUninstallBlackList = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_EnableAppUninstallBlackList));
			return cb_enableAppUninstallBlackList;
		}

		static bool n_EnableAppUninstallBlackList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.EnableAppUninstallBlackList ();
		}
#pragma warning restore 0169

		IntPtr id_enableAppUninstallBlackList;
		public unsafe bool EnableAppUninstallBlackList ()
		{
			if (id_enableAppUninstallBlackList == IntPtr.Zero)
				id_enableAppUninstallBlackList = JNIEnv.GetMethodID (class_ref, "enableAppUninstallBlackList", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_enableAppUninstallBlackList);
		}

		static Delegate? cb_fiscalClose;
#pragma warning disable 0169
		static Delegate GetFiscalCloseHandler ()
		{
			if (cb_fiscalClose == null)
				cb_fiscalClose = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_FiscalClose));
			return cb_fiscalClose;
		}

		static int n_FiscalClose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalClose ();
		}
#pragma warning restore 0169

		IntPtr id_fiscalClose;
		public unsafe int FiscalClose ()
		{
			if (id_fiscalClose == IntPtr.Zero)
				id_fiscalClose = JNIEnv.GetMethodID (class_ref, "fiscalClose", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_fiscalClose);
		}

		static Delegate? cb_fiscalOpen_IIICC;
#pragma warning disable 0169
		static Delegate GetFiscalOpen_IIICCHandler ()
		{
			if (cb_fiscalOpen_IIICC == null)
				cb_fiscalOpen_IIICC = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIICC_I (n_FiscalOpen_IIICC));
			return cb_fiscalOpen_IIICC;
		}

		static int n_FiscalOpen_IIICC (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, char p3, char p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FiscalOpen (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_fiscalOpen_IIICC;
		public unsafe int FiscalOpen (int p0, int p1, int p2, char p3, char p4)
		{
			if (id_fiscalOpen_IIICC == IntPtr.Zero)
				id_fiscalOpen_IIICC = JNIEnv.GetMethodID (class_ref, "fiscalOpen", "(IIICC)I");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_fiscalOpen_IIICC, __args);
		}

		static Delegate? cb_fiscalRead_arrayBII;
#pragma warning disable 0169
		static Delegate GetFiscalRead_arrayBIIHandler ()
		{
			if (cb_fiscalRead_arrayBII == null)
				cb_fiscalRead_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_FiscalRead_arrayBII));
			return cb_fiscalRead_arrayBII;
		}

		static int n_FiscalRead_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalRead (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_fiscalRead_arrayBII;
		public unsafe int FiscalRead (byte[]? p0, int p1, int p2)
		{
			if (id_fiscalRead_arrayBII == IntPtr.Zero)
				id_fiscalRead_arrayBII = JNIEnv.GetMethodID (class_ref, "fiscalRead", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_fiscalRead_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_fiscalWrite_arrayB;
#pragma warning disable 0169
		static Delegate GetFiscalWrite_arrayBHandler ()
		{
			if (cb_fiscalWrite_arrayB == null)
				cb_fiscalWrite_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_FiscalWrite_arrayB));
			return cb_fiscalWrite_arrayB;
		}

		static int n_FiscalWrite_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FiscalWrite (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_fiscalWrite_arrayB;
		public unsafe int FiscalWrite (byte[]? p0)
		{
			if (id_fiscalWrite_arrayB == IntPtr.Zero)
				id_fiscalWrite_arrayB = JNIEnv.GetMethodID (class_ref, "fiscalWrite", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_fiscalWrite_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_installRomPackage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInstallRomPackage_Ljava_lang_String_Handler ()
		{
			if (cb_installRomPackage_Ljava_lang_String_ == null)
				cb_installRomPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_InstallRomPackage_Ljava_lang_String_));
			return cb_installRomPackage_Ljava_lang_String_;
		}

		static int n_InstallRomPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.InstallRomPackage (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_installRomPackage_Ljava_lang_String_;
		public unsafe int InstallRomPackage (string? p0)
		{
			if (id_installRomPackage_Ljava_lang_String_ == IntPtr.Zero)
				id_installRomPackage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "installRomPackage", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_installRomPackage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ciontek.Ciontekposservice.ICiontekPosService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
