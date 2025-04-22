using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']"
	[Register ("com/vanstone/appsdk/api/printer/PrinterHandler", "", "Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker")]
	public partial interface IPrinterHandler : global::Android.OS.IInterface {
		int Lang_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='GetLang_Api' and count(parameter)=0]"
			[Register ("GetLang_Api", "()I", "GetGetLang_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		int PrintState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='GetPrintState' and count(parameter)=0]"
			[Register ("GetPrintState", "()I", "GetGetPrintStateHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnCheckPrnData_Api' and count(parameter)=0]"
		[Register ("PrnCheckPrnData_Api", "()I", "GetPrnCheckPrnData_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnCheckPrnData_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnClose_Api' and count(parameter)=0]"
		[Register ("PrnClose_Api", "()V", "GetPrnClose_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnClrBuff_Api' and count(parameter)=0]"
		[Register ("PrnClrBuff_Api", "()V", "GetPrnClrBuff_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnClrBuff_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnCut_Api' and count(parameter)=0]"
		[Register ("PrnCut_Api", "()V", "GetPrnCut_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnCut_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnFontSet_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("PrnFontSet_Api", "(III)V", "GetPrnFontSet_Api_IIIHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnFontSet_Api (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnGetModuleInfo_Api' and count(parameter)=0]"
		[Register ("PrnGetModuleInfo_Api", "()Landroid/os/Bundle;", "GetPrnGetModuleInfo_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		global::Android.OS.Bundle? PrnGetModuleInfo_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnGetSupportModule_Api' and count(parameter)=0]"
		[Register ("PrnGetSupportModule_Api", "()[Ljava/lang/String;", "GetPrnGetSupportModule_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		string[]? PrnGetSupportModule_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnHTSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnHTSet_Api", "(I)V", "GetPrnHTSet_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnHTSet_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLeftIndSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnLeftIndSet_Api", "(I)V", "GetPrnLeftIndSet_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnLeftIndSet_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLineSpaceSet_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("PrnLineSpaceSet_Api", "(II)V", "GetPrnLineSpaceSet_Api_IIHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnLineSpaceSet_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLogoBuf_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("PrnLogoBuf_Api", "([BI)I", "GetPrnLogoBuf_Api_arrayBIHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnLogoBuf_Api (byte[]? p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLogo_Api' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("PrnLogo_Api", "(Landroid/graphics/Bitmap;)I", "GetPrnLogo_Api_Landroid_graphics_Bitmap_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnLogo_Api (global::Android.Graphics.Bitmap? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnOpen_Api' and count(parameter)=0]"
		[Register ("PrnOpen_Api", "()I", "GetPrnOpen_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnReleaseModule_Api' and count(parameter)=0]"
		[Register ("PrnReleaseModule_Api", "()V", "GetPrnReleaseModule_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnReleaseModule_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSelectModule_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("PrnSelectModule_Api", "(Ljava/lang/String;Landroid/os/Bundle;)I", "GetPrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnSelectModule_Api (string? p0, global::Android.OS.Bundle? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetFont_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("PrnSetFont_Api", "(II)I", "GetPrnSetFont_Api_IIHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnSetFont_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnSetGray_Api", "(I)I", "GetPrnSetGray_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnSetGray_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("PrnSetParams_Api", "(Landroid/os/Bundle;)V", "GetPrnSetParams_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnSetParams_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetQuality_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnSetQuality_Api", "(I)I", "GetPrnSetQuality_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnSetQuality_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSpeedSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnSpeedSet_Api", "(I)V", "GetPrnSpeedSet_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrnSpeedSet_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStart_Api' and count(parameter)=0]"
		[Register ("PrnStart_Api", "()I", "GetPrnStart_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnStart_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStatus_Api' and count(parameter)=0]"
		[Register ("PrnStatus_Api", "()I", "GetPrnStatus_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnStatus_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnStep_Api", "(I)I", "GetPrnStep_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnStep_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStr_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("PrnStr_Api", "(Ljava/lang/String;)I", "GetPrnStr_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrnStr_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='SetLang_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("SetLang_Api", "(II)V", "GetSetLang_Api_IIHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void SetLang_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddBarCode_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
		[Register ("printAddBarCode_Api", "(IIIZLjava/lang/String;)V", "GetPrintAddBarCode_Api_IIIZLjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddImage_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("printAddImage_Api", "(III[B)V", "GetPrintAddImage_Api_IIIarrayBHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintAddImage_Api (int p0, int p1, int p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddQrCode_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("printAddQrCode_Api", "(IILjava/lang/String;)V", "GetPrintAddQrCode_Api_IILjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintAddQrCode_Api (int p0, int p1, string? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddQrCodes_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("printAddQrCodes_Api", "(ILjava/lang/String;I)V", "GetPrintAddQrCodes_Api_ILjava_lang_String_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintAddQrCodes_Api (int p0, string? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddText_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("printAddText_Api", "(IILjava/lang/String;)V", "GetPrintAddText_Api_IILjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintAddText_Api (int p0, int p1, string? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printEnd_Api' and count(parameter)=0]"
		[Register ("printEnd_Api", "()I", "GetPrintEnd_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrintEnd_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printFeedLine_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("printFeedLine_Api", "(I)V", "GetPrintFeedLine_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintFeedLine_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printGetTextSize_Api' and count(parameter)=0]"
		[Register ("printGetTextSize_Api", "()I", "GetPrintGetTextSize_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrintGetTextSize_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printPaperFeed_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("printPaperFeed_Api", "(I)I", "GetPrintPaperFeed_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrintPaperFeed_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printQueryStatus_Api' and count(parameter)=0]"
		[Register ("printQueryStatus_Api", "()I", "GetPrintQueryStatus_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrintQueryStatus_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetAlign_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("printSetAlign_Api", "(I)V", "GetPrintSetAlign_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintSetAlign_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetBlodText_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("printSetBlodText_Api", "(Z)V", "GetPrintSetBlodText_Api_ZHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintSetBlodText_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("printSetGray_Api", "(I)V", "GetPrintSetGray_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintSetGray_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetInvert_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("printSetInvert_Api", "(Z)V", "GetPrintSetInvert_Api_ZHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintSetInvert_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetItalic_Api' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("printSetItalic_Api", "(F)V", "GetPrintSetItalic_Api_FHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintSetItalic_Api (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetLineThrough_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("printSetLineThrough_Api", "(Z)V", "GetPrintSetLineThrough_Api_ZHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintSetLineThrough_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetTextSize_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("printSetTextSize_Api", "(I)I", "GetPrintSetTextSize_Api_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int PrintSetTextSize_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printStartPrint_Api' and count(parameter)=0]"
		[Register ("printStartPrint_Api", "()V", "GetPrintStartPrint_ApiHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrintStartPrint_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printerAddBarCode_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("printerAddBarCode_Api", "(IIIZLjava/lang/String;Ljava/lang/String;)V", "GetPrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrinterAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4, string? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printerAddBarCodes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
		[Register ("printerAddBarCodes_Api", "(IIZLjava/lang/String;Ljava/lang/String;I)V", "GetPrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_IHandler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		void PrinterAddBarCodes_Api (int p0, int p1, bool p2, string? p3, string? p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='setFontName_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFontName_Api", "(Ljava/lang/String;)I", "GetSetFontName_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Printer.IPrinterHandlerInvoker, VanstonePosSdk")]
		int SetFontName_Api (string? p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/printer/PrinterHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/printer/PrinterHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/constructor[@name='PrinterHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_GetLang_Api;
#pragma warning disable 0169
			static Delegate GetGetLang_ApiHandler ()
			{
				if (cb_GetLang_Api == null)
					cb_GetLang_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetLang_Api));
				return cb_GetLang_Api;
			}

			static int n_GetLang_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lang_Api;
			}
#pragma warning restore 0169

			public virtual unsafe int Lang_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='GetLang_Api' and count(parameter)=0]"
				[Register ("GetLang_Api", "()I", "GetGetLang_ApiHandler")]
				get {
					const string __id = "GetLang_Api.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_GetPrintState;
#pragma warning disable 0169
			static Delegate GetGetPrintStateHandler ()
			{
				if (cb_GetPrintState == null)
					cb_GetPrintState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetPrintState));
				return cb_GetPrintState;
			}

			static int n_GetPrintState (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintState;
			}
#pragma warning restore 0169

			public virtual unsafe int PrintState {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='GetPrintState' and count(parameter)=0]"
				[Register ("GetPrintState", "()I", "GetGetPrintStateHandler")]
				get {
					const string __id = "GetPrintState.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_PrnCheckPrnData_Api;
#pragma warning disable 0169
			static Delegate GetPrnCheckPrnData_ApiHandler ()
			{
				if (cb_PrnCheckPrnData_Api == null)
					cb_PrnCheckPrnData_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnCheckPrnData_Api));
				return cb_PrnCheckPrnData_Api;
			}

			static int n_PrnCheckPrnData_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnCheckPrnData_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnCheckPrnData_Api' and count(parameter)=0]"
			[Register ("PrnCheckPrnData_Api", "()I", "GetPrnCheckPrnData_ApiHandler")]
			public virtual unsafe int PrnCheckPrnData_Api ()
			{
				const string __id = "PrnCheckPrnData_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnClose_Api;
#pragma warning disable 0169
			static Delegate GetPrnClose_ApiHandler ()
			{
				if (cb_PrnClose_Api == null)
					cb_PrnClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnClose_Api));
				return cb_PrnClose_Api;
			}

			static void n_PrnClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnClose_Api' and count(parameter)=0]"
			[Register ("PrnClose_Api", "()V", "GetPrnClose_ApiHandler")]
			public virtual unsafe void PrnClose_Api ()
			{
				const string __id = "PrnClose_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_PrnClrBuff_Api;
#pragma warning disable 0169
			static Delegate GetPrnClrBuff_ApiHandler ()
			{
				if (cb_PrnClrBuff_Api == null)
					cb_PrnClrBuff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnClrBuff_Api));
				return cb_PrnClrBuff_Api;
			}

			static void n_PrnClrBuff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnClrBuff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnClrBuff_Api' and count(parameter)=0]"
			[Register ("PrnClrBuff_Api", "()V", "GetPrnClrBuff_ApiHandler")]
			public virtual unsafe void PrnClrBuff_Api ()
			{
				const string __id = "PrnClrBuff_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_PrnCut_Api;
#pragma warning disable 0169
			static Delegate GetPrnCut_ApiHandler ()
			{
				if (cb_PrnCut_Api == null)
					cb_PrnCut_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnCut_Api));
				return cb_PrnCut_Api;
			}

			static void n_PrnCut_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnCut_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnCut_Api' and count(parameter)=0]"
			[Register ("PrnCut_Api", "()V", "GetPrnCut_ApiHandler")]
			public virtual unsafe void PrnCut_Api ()
			{
				const string __id = "PrnCut_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_PrnFontSet_Api_III;
#pragma warning disable 0169
			static Delegate GetPrnFontSet_Api_IIIHandler ()
			{
				if (cb_PrnFontSet_Api_III == null)
					cb_PrnFontSet_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_V (n_PrnFontSet_Api_III));
				return cb_PrnFontSet_Api_III;
			}

			static void n_PrnFontSet_Api_III (IntPtr jnienv, IntPtr native__this, int Ascii, int CFont, int Zoom)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnFontSet_Api (Ascii, CFont, Zoom);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnFontSet_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("PrnFontSet_Api", "(III)V", "GetPrnFontSet_Api_IIIHandler")]
			public virtual unsafe void PrnFontSet_Api (int Ascii, int CFont, int Zoom)
			{
				const string __id = "PrnFontSet_Api.(III)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (Ascii);
					__args [1] = new JniArgumentValue (CFont);
					__args [2] = new JniArgumentValue (Zoom);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_PrnGetModuleInfo_Api;
#pragma warning disable 0169
			static Delegate GetPrnGetModuleInfo_ApiHandler ()
			{
				if (cb_PrnGetModuleInfo_Api == null)
					cb_PrnGetModuleInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PrnGetModuleInfo_Api));
				return cb_PrnGetModuleInfo_Api;
			}

			static IntPtr n_PrnGetModuleInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PrnGetModuleInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnGetModuleInfo_Api' and count(parameter)=0]"
			[Register ("PrnGetModuleInfo_Api", "()Landroid/os/Bundle;", "GetPrnGetModuleInfo_ApiHandler")]
			public virtual unsafe global::Android.OS.Bundle? PrnGetModuleInfo_Api ()
			{
				const string __id = "PrnGetModuleInfo_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_PrnGetSupportModule_Api;
#pragma warning disable 0169
			static Delegate GetPrnGetSupportModule_ApiHandler ()
			{
				if (cb_PrnGetSupportModule_Api == null)
					cb_PrnGetSupportModule_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PrnGetSupportModule_Api));
				return cb_PrnGetSupportModule_Api;
			}

			static IntPtr n_PrnGetSupportModule_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.PrnGetSupportModule_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnGetSupportModule_Api' and count(parameter)=0]"
			[Register ("PrnGetSupportModule_Api", "()[Ljava/lang/String;", "GetPrnGetSupportModule_ApiHandler")]
			public virtual unsafe string[]? PrnGetSupportModule_Api ()
			{
				const string __id = "PrnGetSupportModule_Api.()[Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate? cb_PrnHTSet_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnHTSet_Api_IHandler ()
			{
				if (cb_PrnHTSet_Api_I == null)
					cb_PrnHTSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnHTSet_Api_I));
				return cb_PrnHTSet_Api_I;
			}

			static void n_PrnHTSet_Api_I (IntPtr jnienv, IntPtr native__this, int HT)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnHTSet_Api (HT);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnHTSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnHTSet_Api", "(I)V", "GetPrnHTSet_Api_IHandler")]
			public virtual unsafe void PrnHTSet_Api (int HT)
			{
				const string __id = "PrnHTSet_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (HT);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_PrnLeftIndSet_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnLeftIndSet_Api_IHandler ()
			{
				if (cb_PrnLeftIndSet_Api_I == null)
					cb_PrnLeftIndSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnLeftIndSet_Api_I));
				return cb_PrnLeftIndSet_Api_I;
			}

			static void n_PrnLeftIndSet_Api_I (IntPtr jnienv, IntPtr native__this, int usLeftIndent)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnLeftIndSet_Api (usLeftIndent);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnLeftIndSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnLeftIndSet_Api", "(I)V", "GetPrnLeftIndSet_Api_IHandler")]
			public virtual unsafe void PrnLeftIndSet_Api (int usLeftIndent)
			{
				const string __id = "PrnLeftIndSet_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (usLeftIndent);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_PrnLineSpaceSet_Api_II;
#pragma warning disable 0169
			static Delegate GetPrnLineSpaceSet_Api_IIHandler ()
			{
				if (cb_PrnLineSpaceSet_Api_II == null)
					cb_PrnLineSpaceSet_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_PrnLineSpaceSet_Api_II));
				return cb_PrnLineSpaceSet_Api_II;
			}

			static void n_PrnLineSpaceSet_Api_II (IntPtr jnienv, IntPtr native__this, int ucLineSpace, int ucCharSpace)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnLineSpaceSet_Api (ucLineSpace, ucCharSpace);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnLineSpaceSet_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PrnLineSpaceSet_Api", "(II)V", "GetPrnLineSpaceSet_Api_IIHandler")]
			public virtual unsafe void PrnLineSpaceSet_Api (int ucLineSpace, int ucCharSpace)
			{
				const string __id = "PrnLineSpaceSet_Api.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (ucLineSpace);
					__args [1] = new JniArgumentValue (ucCharSpace);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_PrnLogoBuf_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetPrnLogoBuf_Api_arrayBIHandler ()
			{
				if (cb_PrnLogoBuf_Api_arrayBI == null)
					cb_PrnLogoBuf_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_PrnLogoBuf_Api_arrayBI));
				return cb_PrnLogoBuf_Api_arrayBI;
			}

			static int n_PrnLogoBuf_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_Logo, int ArorFnFlag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Logo = (byte[]?) JNIEnv.GetArray (native_Logo, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PrnLogoBuf_Api (Logo, ArorFnFlag);
				if (Logo != null)
					JNIEnv.CopyArray (Logo, native_Logo);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnLogoBuf_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("PrnLogoBuf_Api", "([BI)I", "GetPrnLogoBuf_Api_arrayBIHandler")]
			public virtual unsafe int PrnLogoBuf_Api (byte[]? Logo, int ArorFnFlag)
			{
				const string __id = "PrnLogoBuf_Api.([BI)I";
				IntPtr native_Logo = JNIEnv.NewArray (Logo);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_Logo);
					__args [1] = new JniArgumentValue (ArorFnFlag);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Logo != null) {
						JNIEnv.CopyArray (native_Logo, Logo);
						JNIEnv.DeleteLocalRef (native_Logo);
					}
					global::System.GC.KeepAlive (Logo);
				}
			}

			static Delegate? cb_PrnLogo_Api_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetPrnLogo_Api_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_PrnLogo_Api_Landroid_graphics_Bitmap_ == null)
					cb_PrnLogo_Api_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PrnLogo_Api_Landroid_graphics_Bitmap_));
				return cb_PrnLogo_Api_Landroid_graphics_Bitmap_;
			}

			static int n_PrnLogo_Api_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PrnLogo_Api (bitmap);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnLogo_Api' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("PrnLogo_Api", "(Landroid/graphics/Bitmap;)I", "GetPrnLogo_Api_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe int PrnLogo_Api (global::Android.Graphics.Bitmap? bitmap)
			{
				const string __id = "PrnLogo_Api.(Landroid/graphics/Bitmap;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bitmap);
				}
			}

			static Delegate? cb_PrnOpen_Api;
#pragma warning disable 0169
			static Delegate GetPrnOpen_ApiHandler ()
			{
				if (cb_PrnOpen_Api == null)
					cb_PrnOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnOpen_Api));
				return cb_PrnOpen_Api;
			}

			static int n_PrnOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnOpen_Api' and count(parameter)=0]"
			[Register ("PrnOpen_Api", "()I", "GetPrnOpen_ApiHandler")]
			public virtual unsafe int PrnOpen_Api ()
			{
				const string __id = "PrnOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnReleaseModule_Api;
#pragma warning disable 0169
			static Delegate GetPrnReleaseModule_ApiHandler ()
			{
				if (cb_PrnReleaseModule_Api == null)
					cb_PrnReleaseModule_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnReleaseModule_Api));
				return cb_PrnReleaseModule_Api;
			}

			static void n_PrnReleaseModule_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnReleaseModule_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnReleaseModule_Api' and count(parameter)=0]"
			[Register ("PrnReleaseModule_Api", "()V", "GetPrnReleaseModule_ApiHandler")]
			public virtual unsafe void PrnReleaseModule_Api ()
			{
				const string __id = "PrnReleaseModule_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetPrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_Handler ()
			{
				if (cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ == null)
					cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_));
				return cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_;
			}

			static int n_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_moduleName, IntPtr native_param)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var moduleName = JNIEnv.GetString (native_moduleName, JniHandleOwnership.DoNotTransfer);
				var param = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_param, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PrnSelectModule_Api (moduleName, param);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnSelectModule_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("PrnSelectModule_Api", "(Ljava/lang/String;Landroid/os/Bundle;)I", "GetPrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_Handler")]
			public virtual unsafe int PrnSelectModule_Api (string? moduleName, global::Android.OS.Bundle? param)
			{
				const string __id = "PrnSelectModule_Api.(Ljava/lang/String;Landroid/os/Bundle;)I";
				IntPtr native_moduleName = JNIEnv.NewString ((string?)moduleName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_moduleName);
					__args [1] = new JniArgumentValue ((param == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_moduleName);
					global::System.GC.KeepAlive (param);
				}
			}

			static Delegate? cb_PrnSetFont_Api_II;
#pragma warning disable 0169
			static Delegate GetPrnSetFont_Api_IIHandler ()
			{
				if (cb_PrnSetFont_Api_II == null)
					cb_PrnSetFont_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_PrnSetFont_Api_II));
				return cb_PrnSetFont_Api_II;
			}

			static int n_PrnSetFont_Api_II (IntPtr jnienv, IntPtr native__this, int font, int style)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnSetFont_Api (font, style);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnSetFont_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PrnSetFont_Api", "(II)I", "GetPrnSetFont_Api_IIHandler")]
			public virtual unsafe int PrnSetFont_Api (int font, int style)
			{
				const string __id = "PrnSetFont_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (font);
					__args [1] = new JniArgumentValue (style);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnSetGray_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnSetGray_Api_IHandler ()
			{
				if (cb_PrnSetGray_Api_I == null)
					cb_PrnSetGray_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnSetGray_Api_I));
				return cb_PrnSetGray_Api_I;
			}

			static int n_PrnSetGray_Api_I (IntPtr jnienv, IntPtr native__this, int Gray)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnSetGray_Api (Gray);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSetGray_Api", "(I)I", "GetPrnSetGray_Api_IHandler")]
			public virtual unsafe int PrnSetGray_Api (int Gray)
			{
				const string __id = "PrnSetGray_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (Gray);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnSetParams_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetPrnSetParams_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_PrnSetParams_Api_Landroid_os_Bundle_ == null)
					cb_PrnSetParams_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PrnSetParams_Api_Landroid_os_Bundle_));
				return cb_PrnSetParams_Api_Landroid_os_Bundle_;
			}

			static void n_PrnSetParams_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				__this.PrnSetParams_Api (bundle);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnSetParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("PrnSetParams_Api", "(Landroid/os/Bundle;)V", "GetPrnSetParams_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe void PrnSetParams_Api (global::Android.OS.Bundle? bundle)
			{
				const string __id = "PrnSetParams_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_PrnSetQuality_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnSetQuality_Api_IHandler ()
			{
				if (cb_PrnSetQuality_Api_I == null)
					cb_PrnSetQuality_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnSetQuality_Api_I));
				return cb_PrnSetQuality_Api_I;
			}

			static int n_PrnSetQuality_Api_I (IntPtr jnienv, IntPtr native__this, int quality)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnSetQuality_Api (quality);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnSetQuality_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSetQuality_Api", "(I)I", "GetPrnSetQuality_Api_IHandler")]
			public virtual unsafe int PrnSetQuality_Api (int quality)
			{
				const string __id = "PrnSetQuality_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (quality);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnSpeedSet_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnSpeedSet_Api_IHandler ()
			{
				if (cb_PrnSpeedSet_Api_I == null)
					cb_PrnSpeedSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnSpeedSet_Api_I));
				return cb_PrnSpeedSet_Api_I;
			}

			static void n_PrnSpeedSet_Api_I (IntPtr jnienv, IntPtr native__this, int ucSpeed)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnSpeedSet_Api (ucSpeed);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnSpeedSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSpeedSet_Api", "(I)V", "GetPrnSpeedSet_Api_IHandler")]
			public virtual unsafe void PrnSpeedSet_Api (int ucSpeed)
			{
				const string __id = "PrnSpeedSet_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (ucSpeed);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_PrnStart_Api;
#pragma warning disable 0169
			static Delegate GetPrnStart_ApiHandler ()
			{
				if (cb_PrnStart_Api == null)
					cb_PrnStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnStart_Api));
				return cb_PrnStart_Api;
			}

			static int n_PrnStart_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnStart_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnStart_Api' and count(parameter)=0]"
			[Register ("PrnStart_Api", "()I", "GetPrnStart_ApiHandler")]
			public virtual unsafe int PrnStart_Api ()
			{
				const string __id = "PrnStart_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnStatus_Api;
#pragma warning disable 0169
			static Delegate GetPrnStatus_ApiHandler ()
			{
				if (cb_PrnStatus_Api == null)
					cb_PrnStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnStatus_Api));
				return cb_PrnStatus_Api;
			}

			static int n_PrnStatus_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnStatus_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnStatus_Api' and count(parameter)=0]"
			[Register ("PrnStatus_Api", "()I", "GetPrnStatus_ApiHandler")]
			public virtual unsafe int PrnStatus_Api ()
			{
				const string __id = "PrnStatus_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnStep_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnStep_Api_IHandler ()
			{
				if (cb_PrnStep_Api_I == null)
					cb_PrnStep_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnStep_Api_I));
				return cb_PrnStep_Api_I;
			}

			static int n_PrnStep_Api_I (IntPtr jnienv, IntPtr native__this, int pixel)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnStep_Api (pixel);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnStep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnStep_Api", "(I)I", "GetPrnStep_Api_IHandler")]
			public virtual unsafe int PrnStep_Api (int pixel)
			{
				const string __id = "PrnStep_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (pixel);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PrnStr_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrnStr_Api_Ljava_lang_String_Handler ()
			{
				if (cb_PrnStr_Api_Ljava_lang_String_ == null)
					cb_PrnStr_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PrnStr_Api_Ljava_lang_String_));
				return cb_PrnStr_Api_Ljava_lang_String_;
			}

			static int n_PrnStr_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strIn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var strIn = JNIEnv.GetString (native_strIn, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PrnStr_Api (strIn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='PrnStr_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("PrnStr_Api", "(Ljava/lang/String;)I", "GetPrnStr_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int PrnStr_Api (string? strIn)
			{
				const string __id = "PrnStr_Api.(Ljava/lang/String;)I";
				IntPtr native_strIn = JNIEnv.NewString ((string?)strIn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_strIn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_strIn);
				}
			}

			static Delegate? cb_SetLang_Api_II;
#pragma warning disable 0169
			static Delegate GetSetLang_Api_IIHandler ()
			{
				if (cb_SetLang_Api_II == null)
					cb_SetLang_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_SetLang_Api_II));
				return cb_SetLang_Api_II;
			}

			static void n_SetLang_Api_II (IntPtr jnienv, IntPtr native__this, int lang, int encodeType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetLang_Api (lang, encodeType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='SetLang_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("SetLang_Api", "(II)V", "GetSetLang_Api_IIHandler")]
			public virtual unsafe void SetLang_Api (int lang, int encodeType)
			{
				const string __id = "SetLang_Api.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (lang);
					__args [1] = new JniArgumentValue (encodeType);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_printAddBarCode_Api_IIIZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrintAddBarCode_Api_IIIZLjava_lang_String_Handler ()
			{
				if (cb_printAddBarCode_Api_IIIZLjava_lang_String_ == null)
					cb_printAddBarCode_Api_IIIZLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIZL_V (n_PrintAddBarCode_Api_IIIZLjava_lang_String_));
				return cb_printAddBarCode_Api_IIIZLjava_lang_String_;
			}

			static void n_PrintAddBarCode_Api_IIIZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int align, int width, int height, bool isShowtext, IntPtr native_barcode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var barcode = JNIEnv.GetString (native_barcode, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddBarCode_Api (align, width, height, isShowtext, barcode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printAddBarCode_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
			[Register ("printAddBarCode_Api", "(IIIZLjava/lang/String;)V", "GetPrintAddBarCode_Api_IIIZLjava_lang_String_Handler")]
			public virtual unsafe void PrintAddBarCode_Api (int align, int width, int height, bool isShowtext, string? barcode)
			{
				const string __id = "printAddBarCode_Api.(IIIZLjava/lang/String;)V";
				IntPtr native_barcode = JNIEnv.NewString ((string?)barcode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (align);
					__args [1] = new JniArgumentValue (width);
					__args [2] = new JniArgumentValue (height);
					__args [3] = new JniArgumentValue (isShowtext);
					__args [4] = new JniArgumentValue (native_barcode);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_barcode);
				}
			}

			static Delegate? cb_printAddImage_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetPrintAddImage_Api_IIIarrayBHandler ()
			{
				if (cb_printAddImage_Api_IIIarrayB == null)
					cb_printAddImage_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_V (n_PrintAddImage_Api_IIIarrayB));
				return cb_printAddImage_Api_IIIarrayB;
			}

			static void n_PrintAddImage_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int offset, int width, int height, IntPtr native_imageData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var imageData = (byte[]?) JNIEnv.GetArray (native_imageData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.PrintAddImage_Api (offset, width, height, imageData);
				if (imageData != null)
					JNIEnv.CopyArray (imageData, native_imageData);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printAddImage_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("printAddImage_Api", "(III[B)V", "GetPrintAddImage_Api_IIIarrayBHandler")]
			public virtual unsafe void PrintAddImage_Api (int offset, int width, int height, byte[]? imageData)
			{
				const string __id = "printAddImage_Api.(III[B)V";
				IntPtr native_imageData = JNIEnv.NewArray (imageData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (width);
					__args [2] = new JniArgumentValue (height);
					__args [3] = new JniArgumentValue (native_imageData);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (imageData != null) {
						JNIEnv.CopyArray (native_imageData, imageData);
						JNIEnv.DeleteLocalRef (native_imageData);
					}
					global::System.GC.KeepAlive (imageData);
				}
			}

			static Delegate? cb_printAddQrCode_Api_IILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrintAddQrCode_Api_IILjava_lang_String_Handler ()
			{
				if (cb_printAddQrCode_Api_IILjava_lang_String_ == null)
					cb_printAddQrCode_Api_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_V (n_PrintAddQrCode_Api_IILjava_lang_String_));
				return cb_printAddQrCode_Api_IILjava_lang_String_;
			}

			static void n_PrintAddQrCode_Api_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int align, int height, IntPtr native_qrCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var qrCode = JNIEnv.GetString (native_qrCode, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddQrCode_Api (align, height, qrCode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printAddQrCode_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("printAddQrCode_Api", "(IILjava/lang/String;)V", "GetPrintAddQrCode_Api_IILjava_lang_String_Handler")]
			public virtual unsafe void PrintAddQrCode_Api (int align, int height, string? qrCode)
			{
				const string __id = "printAddQrCode_Api.(IILjava/lang/String;)V";
				IntPtr native_qrCode = JNIEnv.NewString ((string?)qrCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (align);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (native_qrCode);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_qrCode);
				}
			}

			static Delegate? cb_printAddQrCodes_Api_ILjava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetPrintAddQrCodes_Api_ILjava_lang_String_IHandler ()
			{
				if (cb_printAddQrCodes_Api_ILjava_lang_String_I == null)
					cb_printAddQrCodes_Api_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_V (n_PrintAddQrCodes_Api_ILjava_lang_String_I));
				return cb_printAddQrCodes_Api_ILjava_lang_String_I;
			}

			static void n_PrintAddQrCodes_Api_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int height, IntPtr native_qrCode, int OffSet)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var qrCode = JNIEnv.GetString (native_qrCode, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddQrCodes_Api (height, qrCode, OffSet);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printAddQrCodes_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("printAddQrCodes_Api", "(ILjava/lang/String;I)V", "GetPrintAddQrCodes_Api_ILjava_lang_String_IHandler")]
			public virtual unsafe void PrintAddQrCodes_Api (int height, string? qrCode, int OffSet)
			{
				const string __id = "printAddQrCodes_Api.(ILjava/lang/String;I)V";
				IntPtr native_qrCode = JNIEnv.NewString ((string?)qrCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (height);
					__args [1] = new JniArgumentValue (native_qrCode);
					__args [2] = new JniArgumentValue (OffSet);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_qrCode);
				}
			}

			static Delegate? cb_printAddText_Api_IILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrintAddText_Api_IILjava_lang_String_Handler ()
			{
				if (cb_printAddText_Api_IILjava_lang_String_ == null)
					cb_printAddText_Api_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_V (n_PrintAddText_Api_IILjava_lang_String_));
				return cb_printAddText_Api_IILjava_lang_String_;
			}

			static void n_PrintAddText_Api_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int font, int align, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddText_Api (font, align, text);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printAddText_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("printAddText_Api", "(IILjava/lang/String;)V", "GetPrintAddText_Api_IILjava_lang_String_Handler")]
			public virtual unsafe void PrintAddText_Api (int font, int align, string? text)
			{
				const string __id = "printAddText_Api.(IILjava/lang/String;)V";
				IntPtr native_text = JNIEnv.NewString ((string?)text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (font);
					__args [1] = new JniArgumentValue (align);
					__args [2] = new JniArgumentValue (native_text);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

			static Delegate? cb_printEnd_Api;
#pragma warning disable 0169
			static Delegate GetPrintEnd_ApiHandler ()
			{
				if (cb_printEnd_Api == null)
					cb_printEnd_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintEnd_Api));
				return cb_printEnd_Api;
			}

			static int n_PrintEnd_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintEnd_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printEnd_Api' and count(parameter)=0]"
			[Register ("printEnd_Api", "()I", "GetPrintEnd_ApiHandler")]
			public virtual unsafe int PrintEnd_Api ()
			{
				const string __id = "printEnd_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_printFeedLine_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintFeedLine_Api_IHandler ()
			{
				if (cb_printFeedLine_Api_I == null)
					cb_printFeedLine_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintFeedLine_Api_I));
				return cb_printFeedLine_Api_I;
			}

			static void n_PrintFeedLine_Api_I (IntPtr jnienv, IntPtr native__this, int lines)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintFeedLine_Api (lines);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printFeedLine_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printFeedLine_Api", "(I)V", "GetPrintFeedLine_Api_IHandler")]
			public virtual unsafe void PrintFeedLine_Api (int lines)
			{
				const string __id = "printFeedLine_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (lines);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_printGetTextSize_Api;
#pragma warning disable 0169
			static Delegate GetPrintGetTextSize_ApiHandler ()
			{
				if (cb_printGetTextSize_Api == null)
					cb_printGetTextSize_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintGetTextSize_Api));
				return cb_printGetTextSize_Api;
			}

			static int n_PrintGetTextSize_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintGetTextSize_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printGetTextSize_Api' and count(parameter)=0]"
			[Register ("printGetTextSize_Api", "()I", "GetPrintGetTextSize_ApiHandler")]
			public virtual unsafe int PrintGetTextSize_Api ()
			{
				const string __id = "printGetTextSize_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_printPaperFeed_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintPaperFeed_Api_IHandler ()
			{
				if (cb_printPaperFeed_Api_I == null)
					cb_printPaperFeed_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrintPaperFeed_Api_I));
				return cb_printPaperFeed_Api_I;
			}

			static int n_PrintPaperFeed_Api_I (IntPtr jnienv, IntPtr native__this, int pixel)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintPaperFeed_Api (pixel);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printPaperFeed_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printPaperFeed_Api", "(I)I", "GetPrintPaperFeed_Api_IHandler")]
			public virtual unsafe int PrintPaperFeed_Api (int pixel)
			{
				const string __id = "printPaperFeed_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (pixel);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_printQueryStatus_Api;
#pragma warning disable 0169
			static Delegate GetPrintQueryStatus_ApiHandler ()
			{
				if (cb_printQueryStatus_Api == null)
					cb_printQueryStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintQueryStatus_Api));
				return cb_printQueryStatus_Api;
			}

			static int n_PrintQueryStatus_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintQueryStatus_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printQueryStatus_Api' and count(parameter)=0]"
			[Register ("printQueryStatus_Api", "()I", "GetPrintQueryStatus_ApiHandler")]
			public virtual unsafe int PrintQueryStatus_Api ()
			{
				const string __id = "printQueryStatus_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_printSetAlign_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintSetAlign_Api_IHandler ()
			{
				if (cb_printSetAlign_Api_I == null)
					cb_printSetAlign_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintSetAlign_Api_I));
				return cb_printSetAlign_Api_I;
			}

			static void n_PrintSetAlign_Api_I (IntPtr jnienv, IntPtr native__this, int value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetAlign_Api (value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printSetAlign_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetAlign_Api", "(I)V", "GetPrintSetAlign_Api_IHandler")]
			public virtual unsafe void PrintSetAlign_Api (int value)
			{
				const string __id = "printSetAlign_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_printSetBlodText_Api_Z;
#pragma warning disable 0169
			static Delegate GetPrintSetBlodText_Api_ZHandler ()
			{
				if (cb_printSetBlodText_Api_Z == null)
					cb_printSetBlodText_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetBlodText_Api_Z));
				return cb_printSetBlodText_Api_Z;
			}

			static void n_PrintSetBlodText_Api_Z (IntPtr jnienv, IntPtr native__this, bool isBold)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetBlodText_Api (isBold);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printSetBlodText_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetBlodText_Api", "(Z)V", "GetPrintSetBlodText_Api_ZHandler")]
			public virtual unsafe void PrintSetBlodText_Api (bool isBold)
			{
				const string __id = "printSetBlodText_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isBold);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_printSetGray_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintSetGray_Api_IHandler ()
			{
				if (cb_printSetGray_Api_I == null)
					cb_printSetGray_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintSetGray_Api_I));
				return cb_printSetGray_Api_I;
			}

			static void n_PrintSetGray_Api_I (IntPtr jnienv, IntPtr native__this, int gray)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetGray_Api (gray);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetGray_Api", "(I)V", "GetPrintSetGray_Api_IHandler")]
			public virtual unsafe void PrintSetGray_Api (int gray)
			{
				const string __id = "printSetGray_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (gray);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_printSetInvert_Api_Z;
#pragma warning disable 0169
			static Delegate GetPrintSetInvert_Api_ZHandler ()
			{
				if (cb_printSetInvert_Api_Z == null)
					cb_printSetInvert_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetInvert_Api_Z));
				return cb_printSetInvert_Api_Z;
			}

			static void n_PrintSetInvert_Api_Z (IntPtr jnienv, IntPtr native__this, bool isInvert)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetInvert_Api (isInvert);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printSetInvert_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetInvert_Api", "(Z)V", "GetPrintSetInvert_Api_ZHandler")]
			public virtual unsafe void PrintSetInvert_Api (bool isInvert)
			{
				const string __id = "printSetInvert_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isInvert);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_printSetItalic_Api_F;
#pragma warning disable 0169
			static Delegate GetPrintSetItalic_Api_FHandler ()
			{
				if (cb_printSetItalic_Api_F == null)
					cb_printSetItalic_Api_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_PrintSetItalic_Api_F));
				return cb_printSetItalic_Api_F;
			}

			static void n_PrintSetItalic_Api_F (IntPtr jnienv, IntPtr native__this, float value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetItalic_Api (value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printSetItalic_Api' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("printSetItalic_Api", "(F)V", "GetPrintSetItalic_Api_FHandler")]
			public virtual unsafe void PrintSetItalic_Api (float value)
			{
				const string __id = "printSetItalic_Api.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_printSetLineThrough_Api_Z;
#pragma warning disable 0169
			static Delegate GetPrintSetLineThrough_Api_ZHandler ()
			{
				if (cb_printSetLineThrough_Api_Z == null)
					cb_printSetLineThrough_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetLineThrough_Api_Z));
				return cb_printSetLineThrough_Api_Z;
			}

			static void n_PrintSetLineThrough_Api_Z (IntPtr jnienv, IntPtr native__this, bool isLineThrough)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetLineThrough_Api (isLineThrough);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printSetLineThrough_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetLineThrough_Api", "(Z)V", "GetPrintSetLineThrough_Api_ZHandler")]
			public virtual unsafe void PrintSetLineThrough_Api (bool isLineThrough)
			{
				const string __id = "printSetLineThrough_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isLineThrough);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_printSetTextSize_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintSetTextSize_Api_IHandler ()
			{
				if (cb_printSetTextSize_Api_I == null)
					cb_printSetTextSize_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrintSetTextSize_Api_I));
				return cb_printSetTextSize_Api_I;
			}

			static int n_PrintSetTextSize_Api_I (IntPtr jnienv, IntPtr native__this, int textSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintSetTextSize_Api (textSize);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printSetTextSize_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetTextSize_Api", "(I)I", "GetPrintSetTextSize_Api_IHandler")]
			public virtual unsafe int PrintSetTextSize_Api (int textSize)
			{
				const string __id = "printSetTextSize_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (textSize);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_printStartPrint_Api;
#pragma warning disable 0169
			static Delegate GetPrintStartPrint_ApiHandler ()
			{
				if (cb_printStartPrint_Api == null)
					cb_printStartPrint_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrintStartPrint_Api));
				return cb_printStartPrint_Api;
			}

			static void n_PrintStartPrint_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintStartPrint_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printStartPrint_Api' and count(parameter)=0]"
			[Register ("printStartPrint_Api", "()V", "GetPrintStartPrint_ApiHandler")]
			public virtual unsafe void PrintStartPrint_Api ()
			{
				const string __id = "printStartPrint_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ == null)
					cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIZLL_V (n_PrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_));
				return cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_;
			}

			static void n_PrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int align, int width, int height, bool isShowtext, IntPtr native_barcode, IntPtr native_code)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var barcode = JNIEnv.GetString (native_barcode, JniHandleOwnership.DoNotTransfer);
				var code = JNIEnv.GetString (native_code, JniHandleOwnership.DoNotTransfer);
				__this.PrinterAddBarCode_Api (align, width, height, isShowtext, barcode, code);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printerAddBarCode_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
			[Register ("printerAddBarCode_Api", "(IIIZLjava/lang/String;Ljava/lang/String;)V", "GetPrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void PrinterAddBarCode_Api (int align, int width, int height, bool isShowtext, string? barcode, string? code)
			{
				const string __id = "printerAddBarCode_Api.(IIIZLjava/lang/String;Ljava/lang/String;)V";
				IntPtr native_barcode = JNIEnv.NewString ((string?)barcode);
				IntPtr native_code = JNIEnv.NewString ((string?)code);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (align);
					__args [1] = new JniArgumentValue (width);
					__args [2] = new JniArgumentValue (height);
					__args [3] = new JniArgumentValue (isShowtext);
					__args [4] = new JniArgumentValue (native_barcode);
					__args [5] = new JniArgumentValue (native_code);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_barcode);
					JNIEnv.DeleteLocalRef (native_code);
				}
			}

			static Delegate? cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetPrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_IHandler ()
			{
				if (cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I == null)
					cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIZLLI_V (n_PrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I));
				return cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I;
			}

			static void n_PrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, int align, int height, bool isShowtext, IntPtr native_barcode, IntPtr native_code, int codeCell)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var barcode = JNIEnv.GetString (native_barcode, JniHandleOwnership.DoNotTransfer);
				var code = JNIEnv.GetString (native_code, JniHandleOwnership.DoNotTransfer);
				__this.PrinterAddBarCodes_Api (align, height, isShowtext, barcode, code, codeCell);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='printerAddBarCodes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
			[Register ("printerAddBarCodes_Api", "(IIZLjava/lang/String;Ljava/lang/String;I)V", "GetPrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_IHandler")]
			public virtual unsafe void PrinterAddBarCodes_Api (int align, int height, bool isShowtext, string? barcode, string? code, int codeCell)
			{
				const string __id = "printerAddBarCodes_Api.(IIZLjava/lang/String;Ljava/lang/String;I)V";
				IntPtr native_barcode = JNIEnv.NewString ((string?)barcode);
				IntPtr native_code = JNIEnv.NewString ((string?)code);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (align);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (isShowtext);
					__args [3] = new JniArgumentValue (native_barcode);
					__args [4] = new JniArgumentValue (native_code);
					__args [5] = new JniArgumentValue (codeCell);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_barcode);
					JNIEnv.DeleteLocalRef (native_code);
				}
			}

			static Delegate? cb_setFontName_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFontName_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setFontName_Api_Ljava_lang_String_ == null)
					cb_setFontName_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetFontName_Api_Ljava_lang_String_));
				return cb_setFontName_Api_Ljava_lang_String_;
			}

			static int n_SetFontName_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fontPath)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var fontPath = JNIEnv.GetString (native_fontPath, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetFontName_Api (fontPath);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Default']/method[@name='setFontName_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFontName_Api", "(Ljava/lang/String;)I", "GetSetFontName_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int SetFontName_Api (string? fontPath)
			{
				const string __id = "setFontName_Api.(Ljava/lang/String;)I";
				IntPtr native_fontPath = JNIEnv.NewString ((string?)fontPath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_fontPath);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_fontPath);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/printer/PrinterHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/printer/PrinterHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/constructor[@name='PrinterHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/printer/PrinterHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/printer/PrinterHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/printer/PrinterHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/printer/PrinterHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.printer.PrinterHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/printer/PrinterHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/printer/PrinterHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_PrnCheckPrnData_Api;
#pragma warning disable 0169
			static Delegate GetPrnCheckPrnData_ApiHandler ()
			{
				if (cb_PrnCheckPrnData_Api == null)
					cb_PrnCheckPrnData_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnCheckPrnData_Api));
				return cb_PrnCheckPrnData_Api;
			}

			static int n_PrnCheckPrnData_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnCheckPrnData_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnCheckPrnData_Api' and count(parameter)=0]"
			[Register ("PrnCheckPrnData_Api", "()I", "GetPrnCheckPrnData_ApiHandler")]
			public abstract int PrnCheckPrnData_Api ();

			static Delegate? cb_PrnClose_Api;
#pragma warning disable 0169
			static Delegate GetPrnClose_ApiHandler ()
			{
				if (cb_PrnClose_Api == null)
					cb_PrnClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnClose_Api));
				return cb_PrnClose_Api;
			}

			static void n_PrnClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnClose_Api' and count(parameter)=0]"
			[Register ("PrnClose_Api", "()V", "GetPrnClose_ApiHandler")]
			public abstract void PrnClose_Api ();

			static Delegate? cb_PrnClrBuff_Api;
#pragma warning disable 0169
			static Delegate GetPrnClrBuff_ApiHandler ()
			{
				if (cb_PrnClrBuff_Api == null)
					cb_PrnClrBuff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnClrBuff_Api));
				return cb_PrnClrBuff_Api;
			}

			static void n_PrnClrBuff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnClrBuff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnClrBuff_Api' and count(parameter)=0]"
			[Register ("PrnClrBuff_Api", "()V", "GetPrnClrBuff_ApiHandler")]
			public abstract void PrnClrBuff_Api ();

			static Delegate? cb_PrnCut_Api;
#pragma warning disable 0169
			static Delegate GetPrnCut_ApiHandler ()
			{
				if (cb_PrnCut_Api == null)
					cb_PrnCut_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnCut_Api));
				return cb_PrnCut_Api;
			}

			static void n_PrnCut_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnCut_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnCut_Api' and count(parameter)=0]"
			[Register ("PrnCut_Api", "()V", "GetPrnCut_ApiHandler")]
			public abstract void PrnCut_Api ();

			static Delegate? cb_PrnFontSet_Api_III;
#pragma warning disable 0169
			static Delegate GetPrnFontSet_Api_IIIHandler ()
			{
				if (cb_PrnFontSet_Api_III == null)
					cb_PrnFontSet_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_V (n_PrnFontSet_Api_III));
				return cb_PrnFontSet_Api_III;
			}

			static void n_PrnFontSet_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnFontSet_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnFontSet_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("PrnFontSet_Api", "(III)V", "GetPrnFontSet_Api_IIIHandler")]
			public abstract void PrnFontSet_Api (int p0, int p1, int p2);

			static Delegate? cb_PrnGetModuleInfo_Api;
#pragma warning disable 0169
			static Delegate GetPrnGetModuleInfo_ApiHandler ()
			{
				if (cb_PrnGetModuleInfo_Api == null)
					cb_PrnGetModuleInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PrnGetModuleInfo_Api));
				return cb_PrnGetModuleInfo_Api;
			}

			static IntPtr n_PrnGetModuleInfo_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.PrnGetModuleInfo_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnGetModuleInfo_Api' and count(parameter)=0]"
			[Register ("PrnGetModuleInfo_Api", "()Landroid/os/Bundle;", "GetPrnGetModuleInfo_ApiHandler")]
			public abstract global::Android.OS.Bundle? PrnGetModuleInfo_Api ();

			static Delegate? cb_PrnGetSupportModule_Api;
#pragma warning disable 0169
			static Delegate GetPrnGetSupportModule_ApiHandler ()
			{
				if (cb_PrnGetSupportModule_Api == null)
					cb_PrnGetSupportModule_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PrnGetSupportModule_Api));
				return cb_PrnGetSupportModule_Api;
			}

			static IntPtr n_PrnGetSupportModule_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.PrnGetSupportModule_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnGetSupportModule_Api' and count(parameter)=0]"
			[Register ("PrnGetSupportModule_Api", "()[Ljava/lang/String;", "GetPrnGetSupportModule_ApiHandler")]
			public abstract string[]? PrnGetSupportModule_Api ();

			static Delegate? cb_PrnHTSet_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnHTSet_Api_IHandler ()
			{
				if (cb_PrnHTSet_Api_I == null)
					cb_PrnHTSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnHTSet_Api_I));
				return cb_PrnHTSet_Api_I;
			}

			static void n_PrnHTSet_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnHTSet_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnHTSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnHTSet_Api", "(I)V", "GetPrnHTSet_Api_IHandler")]
			public abstract void PrnHTSet_Api (int p0);

			static Delegate? cb_PrnLeftIndSet_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnLeftIndSet_Api_IHandler ()
			{
				if (cb_PrnLeftIndSet_Api_I == null)
					cb_PrnLeftIndSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnLeftIndSet_Api_I));
				return cb_PrnLeftIndSet_Api_I;
			}

			static void n_PrnLeftIndSet_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnLeftIndSet_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLeftIndSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnLeftIndSet_Api", "(I)V", "GetPrnLeftIndSet_Api_IHandler")]
			public abstract void PrnLeftIndSet_Api (int p0);

			static Delegate? cb_PrnLineSpaceSet_Api_II;
#pragma warning disable 0169
			static Delegate GetPrnLineSpaceSet_Api_IIHandler ()
			{
				if (cb_PrnLineSpaceSet_Api_II == null)
					cb_PrnLineSpaceSet_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_PrnLineSpaceSet_Api_II));
				return cb_PrnLineSpaceSet_Api_II;
			}

			static void n_PrnLineSpaceSet_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnLineSpaceSet_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLineSpaceSet_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PrnLineSpaceSet_Api", "(II)V", "GetPrnLineSpaceSet_Api_IIHandler")]
			public abstract void PrnLineSpaceSet_Api (int p0, int p1);

			static Delegate? cb_PrnLogoBuf_Api_arrayBI;
#pragma warning disable 0169
			static Delegate GetPrnLogoBuf_Api_arrayBIHandler ()
			{
				if (cb_PrnLogoBuf_Api_arrayBI == null)
					cb_PrnLogoBuf_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_PrnLogoBuf_Api_arrayBI));
				return cb_PrnLogoBuf_Api_arrayBI;
			}

			static int n_PrnLogoBuf_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PrnLogoBuf_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLogoBuf_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("PrnLogoBuf_Api", "([BI)I", "GetPrnLogoBuf_Api_arrayBIHandler")]
			public abstract int PrnLogoBuf_Api (byte[]? p0, int p1);

			static Delegate? cb_PrnLogo_Api_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetPrnLogo_Api_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_PrnLogo_Api_Landroid_graphics_Bitmap_ == null)
					cb_PrnLogo_Api_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PrnLogo_Api_Landroid_graphics_Bitmap_));
				return cb_PrnLogo_Api_Landroid_graphics_Bitmap_;
			}

			static int n_PrnLogo_Api_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PrnLogo_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLogo_Api' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("PrnLogo_Api", "(Landroid/graphics/Bitmap;)I", "GetPrnLogo_Api_Landroid_graphics_Bitmap_Handler")]
			public abstract int PrnLogo_Api (global::Android.Graphics.Bitmap? p0);

			static Delegate? cb_PrnOpen_Api;
#pragma warning disable 0169
			static Delegate GetPrnOpen_ApiHandler ()
			{
				if (cb_PrnOpen_Api == null)
					cb_PrnOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnOpen_Api));
				return cb_PrnOpen_Api;
			}

			static int n_PrnOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnOpen_Api' and count(parameter)=0]"
			[Register ("PrnOpen_Api", "()I", "GetPrnOpen_ApiHandler")]
			public abstract int PrnOpen_Api ();

			static Delegate? cb_PrnReleaseModule_Api;
#pragma warning disable 0169
			static Delegate GetPrnReleaseModule_ApiHandler ()
			{
				if (cb_PrnReleaseModule_Api == null)
					cb_PrnReleaseModule_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnReleaseModule_Api));
				return cb_PrnReleaseModule_Api;
			}

			static void n_PrnReleaseModule_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnReleaseModule_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnReleaseModule_Api' and count(parameter)=0]"
			[Register ("PrnReleaseModule_Api", "()V", "GetPrnReleaseModule_ApiHandler")]
			public abstract void PrnReleaseModule_Api ();

			static Delegate? cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetPrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_Handler ()
			{
				if (cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ == null)
					cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_));
				return cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_;
			}

			static int n_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PrnSelectModule_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSelectModule_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("PrnSelectModule_Api", "(Ljava/lang/String;Landroid/os/Bundle;)I", "GetPrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_Handler")]
			public abstract int PrnSelectModule_Api (string? p0, global::Android.OS.Bundle? p1);

			static Delegate? cb_PrnSetFont_Api_II;
#pragma warning disable 0169
			static Delegate GetPrnSetFont_Api_IIHandler ()
			{
				if (cb_PrnSetFont_Api_II == null)
					cb_PrnSetFont_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_PrnSetFont_Api_II));
				return cb_PrnSetFont_Api_II;
			}

			static int n_PrnSetFont_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnSetFont_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetFont_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PrnSetFont_Api", "(II)I", "GetPrnSetFont_Api_IIHandler")]
			public abstract int PrnSetFont_Api (int p0, int p1);

			static Delegate? cb_PrnSetGray_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnSetGray_Api_IHandler ()
			{
				if (cb_PrnSetGray_Api_I == null)
					cb_PrnSetGray_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnSetGray_Api_I));
				return cb_PrnSetGray_Api_I;
			}

			static int n_PrnSetGray_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnSetGray_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSetGray_Api", "(I)I", "GetPrnSetGray_Api_IHandler")]
			public abstract int PrnSetGray_Api (int p0);

			static Delegate? cb_PrnSetParams_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetPrnSetParams_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_PrnSetParams_Api_Landroid_os_Bundle_ == null)
					cb_PrnSetParams_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PrnSetParams_Api_Landroid_os_Bundle_));
				return cb_PrnSetParams_Api_Landroid_os_Bundle_;
			}

			static void n_PrnSetParams_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PrnSetParams_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("PrnSetParams_Api", "(Landroid/os/Bundle;)V", "GetPrnSetParams_Api_Landroid_os_Bundle_Handler")]
			public abstract void PrnSetParams_Api (global::Android.OS.Bundle? p0);

			static Delegate? cb_PrnSetQuality_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnSetQuality_Api_IHandler ()
			{
				if (cb_PrnSetQuality_Api_I == null)
					cb_PrnSetQuality_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnSetQuality_Api_I));
				return cb_PrnSetQuality_Api_I;
			}

			static int n_PrnSetQuality_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnSetQuality_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetQuality_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSetQuality_Api", "(I)I", "GetPrnSetQuality_Api_IHandler")]
			public abstract int PrnSetQuality_Api (int p0);

			static Delegate? cb_PrnSpeedSet_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnSpeedSet_Api_IHandler ()
			{
				if (cb_PrnSpeedSet_Api_I == null)
					cb_PrnSpeedSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnSpeedSet_Api_I));
				return cb_PrnSpeedSet_Api_I;
			}

			static void n_PrnSpeedSet_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrnSpeedSet_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSpeedSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSpeedSet_Api", "(I)V", "GetPrnSpeedSet_Api_IHandler")]
			public abstract void PrnSpeedSet_Api (int p0);

			static Delegate? cb_PrnStart_Api;
#pragma warning disable 0169
			static Delegate GetPrnStart_ApiHandler ()
			{
				if (cb_PrnStart_Api == null)
					cb_PrnStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnStart_Api));
				return cb_PrnStart_Api;
			}

			static int n_PrnStart_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnStart_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStart_Api' and count(parameter)=0]"
			[Register ("PrnStart_Api", "()I", "GetPrnStart_ApiHandler")]
			public abstract int PrnStart_Api ();

			static Delegate? cb_PrnStatus_Api;
#pragma warning disable 0169
			static Delegate GetPrnStatus_ApiHandler ()
			{
				if (cb_PrnStatus_Api == null)
					cb_PrnStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnStatus_Api));
				return cb_PrnStatus_Api;
			}

			static int n_PrnStatus_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnStatus_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStatus_Api' and count(parameter)=0]"
			[Register ("PrnStatus_Api", "()I", "GetPrnStatus_ApiHandler")]
			public abstract int PrnStatus_Api ();

			static Delegate? cb_PrnStep_Api_I;
#pragma warning disable 0169
			static Delegate GetPrnStep_Api_IHandler ()
			{
				if (cb_PrnStep_Api_I == null)
					cb_PrnStep_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnStep_Api_I));
				return cb_PrnStep_Api_I;
			}

			static int n_PrnStep_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrnStep_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnStep_Api", "(I)I", "GetPrnStep_Api_IHandler")]
			public abstract int PrnStep_Api (int p0);

			static Delegate? cb_PrnStr_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrnStr_Api_Ljava_lang_String_Handler ()
			{
				if (cb_PrnStr_Api_Ljava_lang_String_ == null)
					cb_PrnStr_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PrnStr_Api_Ljava_lang_String_));
				return cb_PrnStr_Api_Ljava_lang_String_;
			}

			static int n_PrnStr_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PrnStr_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStr_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("PrnStr_Api", "(Ljava/lang/String;)I", "GetPrnStr_Api_Ljava_lang_String_Handler")]
			public abstract int PrnStr_Api (string? p0);

			static Delegate? cb_SetLang_Api_II;
#pragma warning disable 0169
			static Delegate GetSetLang_Api_IIHandler ()
			{
				if (cb_SetLang_Api_II == null)
					cb_SetLang_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_SetLang_Api_II));
				return cb_SetLang_Api_II;
			}

			static void n_SetLang_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetLang_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='SetLang_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("SetLang_Api", "(II)V", "GetSetLang_Api_IIHandler")]
			public abstract void SetLang_Api (int p0, int p1);

			static Delegate? cb_printAddBarCode_Api_IIIZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrintAddBarCode_Api_IIIZLjava_lang_String_Handler ()
			{
				if (cb_printAddBarCode_Api_IIIZLjava_lang_String_ == null)
					cb_printAddBarCode_Api_IIIZLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIZL_V (n_PrintAddBarCode_Api_IIIZLjava_lang_String_));
				return cb_printAddBarCode_Api_IIIZLjava_lang_String_;
			}

			static void n_PrintAddBarCode_Api_IIIZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, bool p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddBarCode_Api (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddBarCode_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
			[Register ("printAddBarCode_Api", "(IIIZLjava/lang/String;)V", "GetPrintAddBarCode_Api_IIIZLjava_lang_String_Handler")]
			public abstract void PrintAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4);

			static Delegate? cb_printAddImage_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetPrintAddImage_Api_IIIarrayBHandler ()
			{
				if (cb_printAddImage_Api_IIIarrayB == null)
					cb_printAddImage_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_V (n_PrintAddImage_Api_IIIarrayB));
				return cb_printAddImage_Api_IIIarrayB;
			}

			static void n_PrintAddImage_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.PrintAddImage_Api (p0, p1, p2, p3);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddImage_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("printAddImage_Api", "(III[B)V", "GetPrintAddImage_Api_IIIarrayBHandler")]
			public abstract void PrintAddImage_Api (int p0, int p1, int p2, byte[]? p3);

			static Delegate? cb_printAddQrCode_Api_IILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrintAddQrCode_Api_IILjava_lang_String_Handler ()
			{
				if (cb_printAddQrCode_Api_IILjava_lang_String_ == null)
					cb_printAddQrCode_Api_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_V (n_PrintAddQrCode_Api_IILjava_lang_String_));
				return cb_printAddQrCode_Api_IILjava_lang_String_;
			}

			static void n_PrintAddQrCode_Api_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddQrCode_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddQrCode_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("printAddQrCode_Api", "(IILjava/lang/String;)V", "GetPrintAddQrCode_Api_IILjava_lang_String_Handler")]
			public abstract void PrintAddQrCode_Api (int p0, int p1, string? p2);

			static Delegate? cb_printAddQrCodes_Api_ILjava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetPrintAddQrCodes_Api_ILjava_lang_String_IHandler ()
			{
				if (cb_printAddQrCodes_Api_ILjava_lang_String_I == null)
					cb_printAddQrCodes_Api_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_V (n_PrintAddQrCodes_Api_ILjava_lang_String_I));
				return cb_printAddQrCodes_Api_ILjava_lang_String_I;
			}

			static void n_PrintAddQrCodes_Api_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddQrCodes_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddQrCodes_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("printAddQrCodes_Api", "(ILjava/lang/String;I)V", "GetPrintAddQrCodes_Api_ILjava_lang_String_IHandler")]
			public abstract void PrintAddQrCodes_Api (int p0, string? p1, int p2);

			static Delegate? cb_printAddText_Api_IILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrintAddText_Api_IILjava_lang_String_Handler ()
			{
				if (cb_printAddText_Api_IILjava_lang_String_ == null)
					cb_printAddText_Api_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_V (n_PrintAddText_Api_IILjava_lang_String_));
				return cb_printAddText_Api_IILjava_lang_String_;
			}

			static void n_PrintAddText_Api_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.PrintAddText_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddText_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("printAddText_Api", "(IILjava/lang/String;)V", "GetPrintAddText_Api_IILjava_lang_String_Handler")]
			public abstract void PrintAddText_Api (int p0, int p1, string? p2);

			static Delegate? cb_printEnd_Api;
#pragma warning disable 0169
			static Delegate GetPrintEnd_ApiHandler ()
			{
				if (cb_printEnd_Api == null)
					cb_printEnd_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintEnd_Api));
				return cb_printEnd_Api;
			}

			static int n_PrintEnd_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintEnd_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printEnd_Api' and count(parameter)=0]"
			[Register ("printEnd_Api", "()I", "GetPrintEnd_ApiHandler")]
			public abstract int PrintEnd_Api ();

			static Delegate? cb_printFeedLine_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintFeedLine_Api_IHandler ()
			{
				if (cb_printFeedLine_Api_I == null)
					cb_printFeedLine_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintFeedLine_Api_I));
				return cb_printFeedLine_Api_I;
			}

			static void n_PrintFeedLine_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintFeedLine_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printFeedLine_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printFeedLine_Api", "(I)V", "GetPrintFeedLine_Api_IHandler")]
			public abstract void PrintFeedLine_Api (int p0);

			static Delegate? cb_printGetTextSize_Api;
#pragma warning disable 0169
			static Delegate GetPrintGetTextSize_ApiHandler ()
			{
				if (cb_printGetTextSize_Api == null)
					cb_printGetTextSize_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintGetTextSize_Api));
				return cb_printGetTextSize_Api;
			}

			static int n_PrintGetTextSize_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintGetTextSize_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printGetTextSize_Api' and count(parameter)=0]"
			[Register ("printGetTextSize_Api", "()I", "GetPrintGetTextSize_ApiHandler")]
			public abstract int PrintGetTextSize_Api ();

			static Delegate? cb_printPaperFeed_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintPaperFeed_Api_IHandler ()
			{
				if (cb_printPaperFeed_Api_I == null)
					cb_printPaperFeed_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrintPaperFeed_Api_I));
				return cb_printPaperFeed_Api_I;
			}

			static int n_PrintPaperFeed_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintPaperFeed_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printPaperFeed_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printPaperFeed_Api", "(I)I", "GetPrintPaperFeed_Api_IHandler")]
			public abstract int PrintPaperFeed_Api (int p0);

			static Delegate? cb_printQueryStatus_Api;
#pragma warning disable 0169
			static Delegate GetPrintQueryStatus_ApiHandler ()
			{
				if (cb_printQueryStatus_Api == null)
					cb_printQueryStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintQueryStatus_Api));
				return cb_printQueryStatus_Api;
			}

			static int n_PrintQueryStatus_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintQueryStatus_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printQueryStatus_Api' and count(parameter)=0]"
			[Register ("printQueryStatus_Api", "()I", "GetPrintQueryStatus_ApiHandler")]
			public abstract int PrintQueryStatus_Api ();

			static Delegate? cb_printSetAlign_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintSetAlign_Api_IHandler ()
			{
				if (cb_printSetAlign_Api_I == null)
					cb_printSetAlign_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintSetAlign_Api_I));
				return cb_printSetAlign_Api_I;
			}

			static void n_PrintSetAlign_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetAlign_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetAlign_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetAlign_Api", "(I)V", "GetPrintSetAlign_Api_IHandler")]
			public abstract void PrintSetAlign_Api (int p0);

			static Delegate? cb_printSetBlodText_Api_Z;
#pragma warning disable 0169
			static Delegate GetPrintSetBlodText_Api_ZHandler ()
			{
				if (cb_printSetBlodText_Api_Z == null)
					cb_printSetBlodText_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetBlodText_Api_Z));
				return cb_printSetBlodText_Api_Z;
			}

			static void n_PrintSetBlodText_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetBlodText_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetBlodText_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetBlodText_Api", "(Z)V", "GetPrintSetBlodText_Api_ZHandler")]
			public abstract void PrintSetBlodText_Api (bool p0);

			static Delegate? cb_printSetGray_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintSetGray_Api_IHandler ()
			{
				if (cb_printSetGray_Api_I == null)
					cb_printSetGray_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintSetGray_Api_I));
				return cb_printSetGray_Api_I;
			}

			static void n_PrintSetGray_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetGray_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetGray_Api", "(I)V", "GetPrintSetGray_Api_IHandler")]
			public abstract void PrintSetGray_Api (int p0);

			static Delegate? cb_printSetInvert_Api_Z;
#pragma warning disable 0169
			static Delegate GetPrintSetInvert_Api_ZHandler ()
			{
				if (cb_printSetInvert_Api_Z == null)
					cb_printSetInvert_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetInvert_Api_Z));
				return cb_printSetInvert_Api_Z;
			}

			static void n_PrintSetInvert_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetInvert_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetInvert_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetInvert_Api", "(Z)V", "GetPrintSetInvert_Api_ZHandler")]
			public abstract void PrintSetInvert_Api (bool p0);

			static Delegate? cb_printSetItalic_Api_F;
#pragma warning disable 0169
			static Delegate GetPrintSetItalic_Api_FHandler ()
			{
				if (cb_printSetItalic_Api_F == null)
					cb_printSetItalic_Api_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_PrintSetItalic_Api_F));
				return cb_printSetItalic_Api_F;
			}

			static void n_PrintSetItalic_Api_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetItalic_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetItalic_Api' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("printSetItalic_Api", "(F)V", "GetPrintSetItalic_Api_FHandler")]
			public abstract void PrintSetItalic_Api (float p0);

			static Delegate? cb_printSetLineThrough_Api_Z;
#pragma warning disable 0169
			static Delegate GetPrintSetLineThrough_Api_ZHandler ()
			{
				if (cb_printSetLineThrough_Api_Z == null)
					cb_printSetLineThrough_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetLineThrough_Api_Z));
				return cb_printSetLineThrough_Api_Z;
			}

			static void n_PrintSetLineThrough_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintSetLineThrough_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetLineThrough_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetLineThrough_Api", "(Z)V", "GetPrintSetLineThrough_Api_ZHandler")]
			public abstract void PrintSetLineThrough_Api (bool p0);

			static Delegate? cb_printSetTextSize_Api_I;
#pragma warning disable 0169
			static Delegate GetPrintSetTextSize_Api_IHandler ()
			{
				if (cb_printSetTextSize_Api_I == null)
					cb_printSetTextSize_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrintSetTextSize_Api_I));
				return cb_printSetTextSize_Api_I;
			}

			static int n_PrintSetTextSize_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintSetTextSize_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetTextSize_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetTextSize_Api", "(I)I", "GetPrintSetTextSize_Api_IHandler")]
			public abstract int PrintSetTextSize_Api (int p0);

			static Delegate? cb_printStartPrint_Api;
#pragma warning disable 0169
			static Delegate GetPrintStartPrint_ApiHandler ()
			{
				if (cb_printStartPrint_Api == null)
					cb_printStartPrint_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrintStartPrint_Api));
				return cb_printStartPrint_Api;
			}

			static void n_PrintStartPrint_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PrintStartPrint_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printStartPrint_Api' and count(parameter)=0]"
			[Register ("printStartPrint_Api", "()V", "GetPrintStartPrint_ApiHandler")]
			public abstract void PrintStartPrint_Api ();

			static Delegate? cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ == null)
					cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIZLL_V (n_PrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_));
				return cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_;
			}

			static void n_PrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, bool p3, IntPtr native_p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
				var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
				__this.PrinterAddBarCode_Api (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printerAddBarCode_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
			[Register ("printerAddBarCode_Api", "(IIIZLjava/lang/String;Ljava/lang/String;)V", "GetPrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_Handler")]
			public abstract void PrinterAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4, string? p5);

			static Delegate? cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetPrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_IHandler ()
			{
				if (cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I == null)
					cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIZLLI_V (n_PrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I));
				return cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I;
			}

			static void n_PrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2, IntPtr native_p3, IntPtr native_p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
				var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.PrinterAddBarCodes_Api (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printerAddBarCodes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
			[Register ("printerAddBarCodes_Api", "(IIZLjava/lang/String;Ljava/lang/String;I)V", "GetPrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_IHandler")]
			public abstract void PrinterAddBarCodes_Api (int p0, int p1, bool p2, string? p3, string? p4, int p5);

			static Delegate? cb_setFontName_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFontName_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setFontName_Api_Ljava_lang_String_ == null)
					cb_setFontName_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetFontName_Api_Ljava_lang_String_));
				return cb_setFontName_Api_Ljava_lang_String_;
			}

			static int n_SetFontName_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetFontName_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='setFontName_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFontName_Api", "(Ljava/lang/String;)I", "GetSetFontName_Api_Ljava_lang_String_Handler")]
			public abstract int SetFontName_Api (string? p0);

			static Delegate? cb_GetLang_Api;
#pragma warning disable 0169
			static Delegate GetGetLang_ApiHandler ()
			{
				if (cb_GetLang_Api == null)
					cb_GetLang_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetLang_Api));
				return cb_GetLang_Api;
			}

			static int n_GetLang_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Lang_Api;
			}
#pragma warning restore 0169

			public abstract int Lang_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='GetLang_Api' and count(parameter)=0]"
				[Register ("GetLang_Api", "()I", "GetGetLang_ApiHandler")]
				get; 
			}

			static Delegate? cb_GetPrintState;
#pragma warning disable 0169
			static Delegate GetGetPrintStateHandler ()
			{
				if (cb_GetPrintState == null)
					cb_GetPrintState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetPrintState));
				return cb_GetPrintState;
			}

			static int n_GetPrintState (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PrintState;
			}
#pragma warning restore 0169

			public abstract int PrintState {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='GetPrintState' and count(parameter)=0]"
				[Register ("GetPrintState", "()I", "GetGetPrintStateHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/printer/PrinterHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/printer/PrinterHandler$Stub", typeof (StubInvoker));

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

			public override unsafe int Lang_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='GetLang_Api' and count(parameter)=0]"
				[Register ("GetLang_Api", "()I", "GetGetLang_ApiHandler")]
				get {
					const string __id = "GetLang_Api.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe int PrintState {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/class[@name='PrinterHandler.Stub']/method[@name='GetPrintState' and count(parameter)=0]"
				[Register ("GetPrintState", "()I", "GetGetPrintStateHandler")]
				get {
					const string __id = "GetPrintState.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnCheckPrnData_Api' and count(parameter)=0]"
			[Register ("PrnCheckPrnData_Api", "()I", "GetPrnCheckPrnData_ApiHandler")]
			public override unsafe int PrnCheckPrnData_Api ()
			{
				const string __id = "PrnCheckPrnData_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnClose_Api' and count(parameter)=0]"
			[Register ("PrnClose_Api", "()V", "GetPrnClose_ApiHandler")]
			public override unsafe void PrnClose_Api ()
			{
				const string __id = "PrnClose_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnClrBuff_Api' and count(parameter)=0]"
			[Register ("PrnClrBuff_Api", "()V", "GetPrnClrBuff_ApiHandler")]
			public override unsafe void PrnClrBuff_Api ()
			{
				const string __id = "PrnClrBuff_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnCut_Api' and count(parameter)=0]"
			[Register ("PrnCut_Api", "()V", "GetPrnCut_ApiHandler")]
			public override unsafe void PrnCut_Api ()
			{
				const string __id = "PrnCut_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnFontSet_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("PrnFontSet_Api", "(III)V", "GetPrnFontSet_Api_IIIHandler")]
			public override unsafe void PrnFontSet_Api (int p0, int p1, int p2)
			{
				const string __id = "PrnFontSet_Api.(III)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnGetModuleInfo_Api' and count(parameter)=0]"
			[Register ("PrnGetModuleInfo_Api", "()Landroid/os/Bundle;", "GetPrnGetModuleInfo_ApiHandler")]
			public override unsafe global::Android.OS.Bundle? PrnGetModuleInfo_Api ()
			{
				const string __id = "PrnGetModuleInfo_Api.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnGetSupportModule_Api' and count(parameter)=0]"
			[Register ("PrnGetSupportModule_Api", "()[Ljava/lang/String;", "GetPrnGetSupportModule_ApiHandler")]
			public override unsafe string[]? PrnGetSupportModule_Api ()
			{
				const string __id = "PrnGetSupportModule_Api.()[Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnHTSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnHTSet_Api", "(I)V", "GetPrnHTSet_Api_IHandler")]
			public override unsafe void PrnHTSet_Api (int p0)
			{
				const string __id = "PrnHTSet_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLeftIndSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnLeftIndSet_Api", "(I)V", "GetPrnLeftIndSet_Api_IHandler")]
			public override unsafe void PrnLeftIndSet_Api (int p0)
			{
				const string __id = "PrnLeftIndSet_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLineSpaceSet_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PrnLineSpaceSet_Api", "(II)V", "GetPrnLineSpaceSet_Api_IIHandler")]
			public override unsafe void PrnLineSpaceSet_Api (int p0, int p1)
			{
				const string __id = "PrnLineSpaceSet_Api.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLogoBuf_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("PrnLogoBuf_Api", "([BI)I", "GetPrnLogoBuf_Api_arrayBIHandler")]
			public override unsafe int PrnLogoBuf_Api (byte[]? p0, int p1)
			{
				const string __id = "PrnLogoBuf_Api.([BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnLogo_Api' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("PrnLogo_Api", "(Landroid/graphics/Bitmap;)I", "GetPrnLogo_Api_Landroid_graphics_Bitmap_Handler")]
			public override unsafe int PrnLogo_Api (global::Android.Graphics.Bitmap? p0)
			{
				const string __id = "PrnLogo_Api.(Landroid/graphics/Bitmap;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnOpen_Api' and count(parameter)=0]"
			[Register ("PrnOpen_Api", "()I", "GetPrnOpen_ApiHandler")]
			public override unsafe int PrnOpen_Api ()
			{
				const string __id = "PrnOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnReleaseModule_Api' and count(parameter)=0]"
			[Register ("PrnReleaseModule_Api", "()V", "GetPrnReleaseModule_ApiHandler")]
			public override unsafe void PrnReleaseModule_Api ()
			{
				const string __id = "PrnReleaseModule_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSelectModule_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("PrnSelectModule_Api", "(Ljava/lang/String;Landroid/os/Bundle;)I", "GetPrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_Handler")]
			public override unsafe int PrnSelectModule_Api (string? p0, global::Android.OS.Bundle? p1)
			{
				const string __id = "PrnSelectModule_Api.(Ljava/lang/String;Landroid/os/Bundle;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetFont_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PrnSetFont_Api", "(II)I", "GetPrnSetFont_Api_IIHandler")]
			public override unsafe int PrnSetFont_Api (int p0, int p1)
			{
				const string __id = "PrnSetFont_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSetGray_Api", "(I)I", "GetPrnSetGray_Api_IHandler")]
			public override unsafe int PrnSetGray_Api (int p0)
			{
				const string __id = "PrnSetGray_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetParams_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("PrnSetParams_Api", "(Landroid/os/Bundle;)V", "GetPrnSetParams_Api_Landroid_os_Bundle_Handler")]
			public override unsafe void PrnSetParams_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "PrnSetParams_Api.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSetQuality_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSetQuality_Api", "(I)I", "GetPrnSetQuality_Api_IHandler")]
			public override unsafe int PrnSetQuality_Api (int p0)
			{
				const string __id = "PrnSetQuality_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnSpeedSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnSpeedSet_Api", "(I)V", "GetPrnSpeedSet_Api_IHandler")]
			public override unsafe void PrnSpeedSet_Api (int p0)
			{
				const string __id = "PrnSpeedSet_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStart_Api' and count(parameter)=0]"
			[Register ("PrnStart_Api", "()I", "GetPrnStart_ApiHandler")]
			public override unsafe int PrnStart_Api ()
			{
				const string __id = "PrnStart_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStatus_Api' and count(parameter)=0]"
			[Register ("PrnStatus_Api", "()I", "GetPrnStatus_ApiHandler")]
			public override unsafe int PrnStatus_Api ()
			{
				const string __id = "PrnStatus_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PrnStep_Api", "(I)I", "GetPrnStep_Api_IHandler")]
			public override unsafe int PrnStep_Api (int p0)
			{
				const string __id = "PrnStep_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='PrnStr_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("PrnStr_Api", "(Ljava/lang/String;)I", "GetPrnStr_Api_Ljava_lang_String_Handler")]
			public override unsafe int PrnStr_Api (string? p0)
			{
				const string __id = "PrnStr_Api.(Ljava/lang/String;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='SetLang_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("SetLang_Api", "(II)V", "GetSetLang_Api_IIHandler")]
			public override unsafe void SetLang_Api (int p0, int p1)
			{
				const string __id = "SetLang_Api.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddBarCode_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
			[Register ("printAddBarCode_Api", "(IIIZLjava/lang/String;)V", "GetPrintAddBarCode_Api_IIIZLjava_lang_String_Handler")]
			public override unsafe void PrintAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4)
			{
				const string __id = "printAddBarCode_Api.(IIIZLjava/lang/String;)V";
				IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddImage_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("printAddImage_Api", "(III[B)V", "GetPrintAddImage_Api_IIIarrayBHandler")]
			public override unsafe void PrintAddImage_Api (int p0, int p1, int p2, byte[]? p3)
			{
				const string __id = "printAddImage_Api.(III[B)V";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddQrCode_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("printAddQrCode_Api", "(IILjava/lang/String;)V", "GetPrintAddQrCode_Api_IILjava_lang_String_Handler")]
			public override unsafe void PrintAddQrCode_Api (int p0, int p1, string? p2)
			{
				const string __id = "printAddQrCode_Api.(IILjava/lang/String;)V";
				IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddQrCodes_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("printAddQrCodes_Api", "(ILjava/lang/String;I)V", "GetPrintAddQrCodes_Api_ILjava_lang_String_IHandler")]
			public override unsafe void PrintAddQrCodes_Api (int p0, string? p1, int p2)
			{
				const string __id = "printAddQrCodes_Api.(ILjava/lang/String;I)V";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printAddText_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("printAddText_Api", "(IILjava/lang/String;)V", "GetPrintAddText_Api_IILjava_lang_String_Handler")]
			public override unsafe void PrintAddText_Api (int p0, int p1, string? p2)
			{
				const string __id = "printAddText_Api.(IILjava/lang/String;)V";
				IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printEnd_Api' and count(parameter)=0]"
			[Register ("printEnd_Api", "()I", "GetPrintEnd_ApiHandler")]
			public override unsafe int PrintEnd_Api ()
			{
				const string __id = "printEnd_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printFeedLine_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printFeedLine_Api", "(I)V", "GetPrintFeedLine_Api_IHandler")]
			public override unsafe void PrintFeedLine_Api (int p0)
			{
				const string __id = "printFeedLine_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printGetTextSize_Api' and count(parameter)=0]"
			[Register ("printGetTextSize_Api", "()I", "GetPrintGetTextSize_ApiHandler")]
			public override unsafe int PrintGetTextSize_Api ()
			{
				const string __id = "printGetTextSize_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printPaperFeed_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printPaperFeed_Api", "(I)I", "GetPrintPaperFeed_Api_IHandler")]
			public override unsafe int PrintPaperFeed_Api (int p0)
			{
				const string __id = "printPaperFeed_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printQueryStatus_Api' and count(parameter)=0]"
			[Register ("printQueryStatus_Api", "()I", "GetPrintQueryStatus_ApiHandler")]
			public override unsafe int PrintQueryStatus_Api ()
			{
				const string __id = "printQueryStatus_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetAlign_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetAlign_Api", "(I)V", "GetPrintSetAlign_Api_IHandler")]
			public override unsafe void PrintSetAlign_Api (int p0)
			{
				const string __id = "printSetAlign_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetBlodText_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetBlodText_Api", "(Z)V", "GetPrintSetBlodText_Api_ZHandler")]
			public override unsafe void PrintSetBlodText_Api (bool p0)
			{
				const string __id = "printSetBlodText_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetGray_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetGray_Api", "(I)V", "GetPrintSetGray_Api_IHandler")]
			public override unsafe void PrintSetGray_Api (int p0)
			{
				const string __id = "printSetGray_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetInvert_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetInvert_Api", "(Z)V", "GetPrintSetInvert_Api_ZHandler")]
			public override unsafe void PrintSetInvert_Api (bool p0)
			{
				const string __id = "printSetInvert_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetItalic_Api' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("printSetItalic_Api", "(F)V", "GetPrintSetItalic_Api_FHandler")]
			public override unsafe void PrintSetItalic_Api (float p0)
			{
				const string __id = "printSetItalic_Api.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetLineThrough_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("printSetLineThrough_Api", "(Z)V", "GetPrintSetLineThrough_Api_ZHandler")]
			public override unsafe void PrintSetLineThrough_Api (bool p0)
			{
				const string __id = "printSetLineThrough_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printSetTextSize_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("printSetTextSize_Api", "(I)I", "GetPrintSetTextSize_Api_IHandler")]
			public override unsafe int PrintSetTextSize_Api (int p0)
			{
				const string __id = "printSetTextSize_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printStartPrint_Api' and count(parameter)=0]"
			[Register ("printStartPrint_Api", "()V", "GetPrintStartPrint_ApiHandler")]
			public override unsafe void PrintStartPrint_Api ()
			{
				const string __id = "printStartPrint_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printerAddBarCode_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
			[Register ("printerAddBarCode_Api", "(IIIZLjava/lang/String;Ljava/lang/String;)V", "GetPrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_Handler")]
			public override unsafe void PrinterAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4, string? p5)
			{
				const string __id = "printerAddBarCode_Api.(IIIZLjava/lang/String;Ljava/lang/String;)V";
				IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
				IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p4);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='printerAddBarCodes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
			[Register ("printerAddBarCodes_Api", "(IIZLjava/lang/String;Ljava/lang/String;I)V", "GetPrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_IHandler")]
			public override unsafe void PrinterAddBarCodes_Api (int p0, int p1, bool p2, string? p3, string? p4, int p5)
			{
				const string __id = "printerAddBarCodes_Api.(IIZLjava/lang/String;Ljava/lang/String;I)V";
				IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
				IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p3);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.printer']/interface[@name='PrinterHandler']/method[@name='setFontName_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFontName_Api", "(Ljava/lang/String;)I", "GetSetFontName_Api_Ljava_lang_String_Handler")]
			public override unsafe int SetFontName_Api (string? p0)
			{
				const string __id = "setFontName_Api.(Ljava/lang/String;)I";
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

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/printer/PrinterHandler", DoNotGenerateAcw=true)]
	internal partial class IPrinterHandlerInvoker : global::Java.Lang.Object, IPrinterHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/printer/PrinterHandler", typeof (IPrinterHandlerInvoker));

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

		public static IPrinterHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPrinterHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.printer.PrinterHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPrinterHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_GetLang_Api;
#pragma warning disable 0169
		static Delegate GetGetLang_ApiHandler ()
		{
			if (cb_GetLang_Api == null)
				cb_GetLang_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetLang_Api));
			return cb_GetLang_Api;
		}

		static int n_GetLang_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Lang_Api;
		}
#pragma warning restore 0169

		IntPtr id_GetLang_Api;
		public unsafe int Lang_Api {
			get {
				if (id_GetLang_Api == IntPtr.Zero)
					id_GetLang_Api = JNIEnv.GetMethodID (class_ref, "GetLang_Api", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetLang_Api);
			}
		}

		static Delegate? cb_GetPrintState;
#pragma warning disable 0169
		static Delegate GetGetPrintStateHandler ()
		{
			if (cb_GetPrintState == null)
				cb_GetPrintState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetPrintState));
			return cb_GetPrintState;
		}

		static int n_GetPrintState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrintState;
		}
#pragma warning restore 0169

		IntPtr id_GetPrintState;
		public unsafe int PrintState {
			get {
				if (id_GetPrintState == IntPtr.Zero)
					id_GetPrintState = JNIEnv.GetMethodID (class_ref, "GetPrintState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetPrintState);
			}
		}

		static Delegate? cb_PrnCheckPrnData_Api;
#pragma warning disable 0169
		static Delegate GetPrnCheckPrnData_ApiHandler ()
		{
			if (cb_PrnCheckPrnData_Api == null)
				cb_PrnCheckPrnData_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnCheckPrnData_Api));
			return cb_PrnCheckPrnData_Api;
		}

		static int n_PrnCheckPrnData_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnCheckPrnData_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnCheckPrnData_Api;
		public unsafe int PrnCheckPrnData_Api ()
		{
			if (id_PrnCheckPrnData_Api == IntPtr.Zero)
				id_PrnCheckPrnData_Api = JNIEnv.GetMethodID (class_ref, "PrnCheckPrnData_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnCheckPrnData_Api);
		}

		static Delegate? cb_PrnClose_Api;
#pragma warning disable 0169
		static Delegate GetPrnClose_ApiHandler ()
		{
			if (cb_PrnClose_Api == null)
				cb_PrnClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnClose_Api));
			return cb_PrnClose_Api;
		}

		static void n_PrnClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnClose_Api;
		public unsafe void PrnClose_Api ()
		{
			if (id_PrnClose_Api == IntPtr.Zero)
				id_PrnClose_Api = JNIEnv.GetMethodID (class_ref, "PrnClose_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnClose_Api);
		}

		static Delegate? cb_PrnClrBuff_Api;
#pragma warning disable 0169
		static Delegate GetPrnClrBuff_ApiHandler ()
		{
			if (cb_PrnClrBuff_Api == null)
				cb_PrnClrBuff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnClrBuff_Api));
			return cb_PrnClrBuff_Api;
		}

		static void n_PrnClrBuff_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnClrBuff_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnClrBuff_Api;
		public unsafe void PrnClrBuff_Api ()
		{
			if (id_PrnClrBuff_Api == IntPtr.Zero)
				id_PrnClrBuff_Api = JNIEnv.GetMethodID (class_ref, "PrnClrBuff_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnClrBuff_Api);
		}

		static Delegate? cb_PrnCut_Api;
#pragma warning disable 0169
		static Delegate GetPrnCut_ApiHandler ()
		{
			if (cb_PrnCut_Api == null)
				cb_PrnCut_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnCut_Api));
			return cb_PrnCut_Api;
		}

		static void n_PrnCut_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnCut_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnCut_Api;
		public unsafe void PrnCut_Api ()
		{
			if (id_PrnCut_Api == IntPtr.Zero)
				id_PrnCut_Api = JNIEnv.GetMethodID (class_ref, "PrnCut_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnCut_Api);
		}

		static Delegate? cb_PrnFontSet_Api_III;
#pragma warning disable 0169
		static Delegate GetPrnFontSet_Api_IIIHandler ()
		{
			if (cb_PrnFontSet_Api_III == null)
				cb_PrnFontSet_Api_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_V (n_PrnFontSet_Api_III));
			return cb_PrnFontSet_Api_III;
		}

		static void n_PrnFontSet_Api_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnFontSet_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_PrnFontSet_Api_III;
		public unsafe void PrnFontSet_Api (int p0, int p1, int p2)
		{
			if (id_PrnFontSet_Api_III == IntPtr.Zero)
				id_PrnFontSet_Api_III = JNIEnv.GetMethodID (class_ref, "PrnFontSet_Api", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnFontSet_Api_III, __args);
		}

		static Delegate? cb_PrnGetModuleInfo_Api;
#pragma warning disable 0169
		static Delegate GetPrnGetModuleInfo_ApiHandler ()
		{
			if (cb_PrnGetModuleInfo_Api == null)
				cb_PrnGetModuleInfo_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PrnGetModuleInfo_Api));
			return cb_PrnGetModuleInfo_Api;
		}

		static IntPtr n_PrnGetModuleInfo_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PrnGetModuleInfo_Api ());
		}
#pragma warning restore 0169

		IntPtr id_PrnGetModuleInfo_Api;
		public unsafe global::Android.OS.Bundle? PrnGetModuleInfo_Api ()
		{
			if (id_PrnGetModuleInfo_Api == IntPtr.Zero)
				id_PrnGetModuleInfo_Api = JNIEnv.GetMethodID (class_ref, "PrnGetModuleInfo_Api", "()Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_PrnGetModuleInfo_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_PrnGetSupportModule_Api;
#pragma warning disable 0169
		static Delegate GetPrnGetSupportModule_ApiHandler ()
		{
			if (cb_PrnGetSupportModule_Api == null)
				cb_PrnGetSupportModule_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PrnGetSupportModule_Api));
			return cb_PrnGetSupportModule_Api;
		}

		static IntPtr n_PrnGetSupportModule_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.PrnGetSupportModule_Api ());
		}
#pragma warning restore 0169

		IntPtr id_PrnGetSupportModule_Api;
		public unsafe string[]? PrnGetSupportModule_Api ()
		{
			if (id_PrnGetSupportModule_Api == IntPtr.Zero)
				id_PrnGetSupportModule_Api = JNIEnv.GetMethodID (class_ref, "PrnGetSupportModule_Api", "()[Ljava/lang/String;");
			return (string[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_PrnGetSupportModule_Api), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate? cb_PrnHTSet_Api_I;
#pragma warning disable 0169
		static Delegate GetPrnHTSet_Api_IHandler ()
		{
			if (cb_PrnHTSet_Api_I == null)
				cb_PrnHTSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnHTSet_Api_I));
			return cb_PrnHTSet_Api_I;
		}

		static void n_PrnHTSet_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnHTSet_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PrnHTSet_Api_I;
		public unsafe void PrnHTSet_Api (int p0)
		{
			if (id_PrnHTSet_Api_I == IntPtr.Zero)
				id_PrnHTSet_Api_I = JNIEnv.GetMethodID (class_ref, "PrnHTSet_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnHTSet_Api_I, __args);
		}

		static Delegate? cb_PrnLeftIndSet_Api_I;
#pragma warning disable 0169
		static Delegate GetPrnLeftIndSet_Api_IHandler ()
		{
			if (cb_PrnLeftIndSet_Api_I == null)
				cb_PrnLeftIndSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnLeftIndSet_Api_I));
			return cb_PrnLeftIndSet_Api_I;
		}

		static void n_PrnLeftIndSet_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnLeftIndSet_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PrnLeftIndSet_Api_I;
		public unsafe void PrnLeftIndSet_Api (int p0)
		{
			if (id_PrnLeftIndSet_Api_I == IntPtr.Zero)
				id_PrnLeftIndSet_Api_I = JNIEnv.GetMethodID (class_ref, "PrnLeftIndSet_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnLeftIndSet_Api_I, __args);
		}

		static Delegate? cb_PrnLineSpaceSet_Api_II;
#pragma warning disable 0169
		static Delegate GetPrnLineSpaceSet_Api_IIHandler ()
		{
			if (cb_PrnLineSpaceSet_Api_II == null)
				cb_PrnLineSpaceSet_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_PrnLineSpaceSet_Api_II));
			return cb_PrnLineSpaceSet_Api_II;
		}

		static void n_PrnLineSpaceSet_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnLineSpaceSet_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_PrnLineSpaceSet_Api_II;
		public unsafe void PrnLineSpaceSet_Api (int p0, int p1)
		{
			if (id_PrnLineSpaceSet_Api_II == IntPtr.Zero)
				id_PrnLineSpaceSet_Api_II = JNIEnv.GetMethodID (class_ref, "PrnLineSpaceSet_Api", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnLineSpaceSet_Api_II, __args);
		}

		static Delegate? cb_PrnLogoBuf_Api_arrayBI;
#pragma warning disable 0169
		static Delegate GetPrnLogoBuf_Api_arrayBIHandler ()
		{
			if (cb_PrnLogoBuf_Api_arrayBI == null)
				cb_PrnLogoBuf_Api_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_PrnLogoBuf_Api_arrayBI));
			return cb_PrnLogoBuf_Api_arrayBI;
		}

		static int n_PrnLogoBuf_Api_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PrnLogoBuf_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PrnLogoBuf_Api_arrayBI;
		public unsafe int PrnLogoBuf_Api (byte[]? p0, int p1)
		{
			if (id_PrnLogoBuf_Api_arrayBI == IntPtr.Zero)
				id_PrnLogoBuf_Api_arrayBI = JNIEnv.GetMethodID (class_ref, "PrnLogoBuf_Api", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnLogoBuf_Api_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_PrnLogo_Api_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPrnLogo_Api_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_PrnLogo_Api_Landroid_graphics_Bitmap_ == null)
				cb_PrnLogo_Api_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PrnLogo_Api_Landroid_graphics_Bitmap_));
			return cb_PrnLogo_Api_Landroid_graphics_Bitmap_;
		}

		static int n_PrnLogo_Api_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PrnLogo_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PrnLogo_Api_Landroid_graphics_Bitmap_;
		public unsafe int PrnLogo_Api (global::Android.Graphics.Bitmap? p0)
		{
			if (id_PrnLogo_Api_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_PrnLogo_Api_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "PrnLogo_Api", "(Landroid/graphics/Bitmap;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnLogo_Api_Landroid_graphics_Bitmap_, __args);
			return __ret;
		}

		static Delegate? cb_PrnOpen_Api;
#pragma warning disable 0169
		static Delegate GetPrnOpen_ApiHandler ()
		{
			if (cb_PrnOpen_Api == null)
				cb_PrnOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnOpen_Api));
			return cb_PrnOpen_Api;
		}

		static int n_PrnOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnOpen_Api;
		public unsafe int PrnOpen_Api ()
		{
			if (id_PrnOpen_Api == IntPtr.Zero)
				id_PrnOpen_Api = JNIEnv.GetMethodID (class_ref, "PrnOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnOpen_Api);
		}

		static Delegate? cb_PrnReleaseModule_Api;
#pragma warning disable 0169
		static Delegate GetPrnReleaseModule_ApiHandler ()
		{
			if (cb_PrnReleaseModule_Api == null)
				cb_PrnReleaseModule_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrnReleaseModule_Api));
			return cb_PrnReleaseModule_Api;
		}

		static void n_PrnReleaseModule_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnReleaseModule_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnReleaseModule_Api;
		public unsafe void PrnReleaseModule_Api ()
		{
			if (id_PrnReleaseModule_Api == IntPtr.Zero)
				id_PrnReleaseModule_Api = JNIEnv.GetMethodID (class_ref, "PrnReleaseModule_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnReleaseModule_Api);
		}

		static Delegate? cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetPrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_));
			return cb_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static int n_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PrnSelectModule_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe int PrnSelectModule_Api (string? p0, global::Android.OS.Bundle? p1)
		{
			if (id_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "PrnSelectModule_Api", "(Ljava/lang/String;Landroid/os/Bundle;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnSelectModule_Api_Ljava_lang_String_Landroid_os_Bundle_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_PrnSetFont_Api_II;
#pragma warning disable 0169
		static Delegate GetPrnSetFont_Api_IIHandler ()
		{
			if (cb_PrnSetFont_Api_II == null)
				cb_PrnSetFont_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_PrnSetFont_Api_II));
			return cb_PrnSetFont_Api_II;
		}

		static int n_PrnSetFont_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnSetFont_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_PrnSetFont_Api_II;
		public unsafe int PrnSetFont_Api (int p0, int p1)
		{
			if (id_PrnSetFont_Api_II == IntPtr.Zero)
				id_PrnSetFont_Api_II = JNIEnv.GetMethodID (class_ref, "PrnSetFont_Api", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnSetFont_Api_II, __args);
		}

		static Delegate? cb_PrnSetGray_Api_I;
#pragma warning disable 0169
		static Delegate GetPrnSetGray_Api_IHandler ()
		{
			if (cb_PrnSetGray_Api_I == null)
				cb_PrnSetGray_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnSetGray_Api_I));
			return cb_PrnSetGray_Api_I;
		}

		static int n_PrnSetGray_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnSetGray_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PrnSetGray_Api_I;
		public unsafe int PrnSetGray_Api (int p0)
		{
			if (id_PrnSetGray_Api_I == IntPtr.Zero)
				id_PrnSetGray_Api_I = JNIEnv.GetMethodID (class_ref, "PrnSetGray_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnSetGray_Api_I, __args);
		}

		static Delegate? cb_PrnSetParams_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetPrnSetParams_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_PrnSetParams_Api_Landroid_os_Bundle_ == null)
				cb_PrnSetParams_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PrnSetParams_Api_Landroid_os_Bundle_));
			return cb_PrnSetParams_Api_Landroid_os_Bundle_;
		}

		static void n_PrnSetParams_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrnSetParams_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PrnSetParams_Api_Landroid_os_Bundle_;
		public unsafe void PrnSetParams_Api (global::Android.OS.Bundle? p0)
		{
			if (id_PrnSetParams_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_PrnSetParams_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "PrnSetParams_Api", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnSetParams_Api_Landroid_os_Bundle_, __args);
		}

		static Delegate? cb_PrnSetQuality_Api_I;
#pragma warning disable 0169
		static Delegate GetPrnSetQuality_Api_IHandler ()
		{
			if (cb_PrnSetQuality_Api_I == null)
				cb_PrnSetQuality_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnSetQuality_Api_I));
			return cb_PrnSetQuality_Api_I;
		}

		static int n_PrnSetQuality_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnSetQuality_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PrnSetQuality_Api_I;
		public unsafe int PrnSetQuality_Api (int p0)
		{
			if (id_PrnSetQuality_Api_I == IntPtr.Zero)
				id_PrnSetQuality_Api_I = JNIEnv.GetMethodID (class_ref, "PrnSetQuality_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnSetQuality_Api_I, __args);
		}

		static Delegate? cb_PrnSpeedSet_Api_I;
#pragma warning disable 0169
		static Delegate GetPrnSpeedSet_Api_IHandler ()
		{
			if (cb_PrnSpeedSet_Api_I == null)
				cb_PrnSpeedSet_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrnSpeedSet_Api_I));
			return cb_PrnSpeedSet_Api_I;
		}

		static void n_PrnSpeedSet_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrnSpeedSet_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PrnSpeedSet_Api_I;
		public unsafe void PrnSpeedSet_Api (int p0)
		{
			if (id_PrnSpeedSet_Api_I == IntPtr.Zero)
				id_PrnSpeedSet_Api_I = JNIEnv.GetMethodID (class_ref, "PrnSpeedSet_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrnSpeedSet_Api_I, __args);
		}

		static Delegate? cb_PrnStart_Api;
#pragma warning disable 0169
		static Delegate GetPrnStart_ApiHandler ()
		{
			if (cb_PrnStart_Api == null)
				cb_PrnStart_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnStart_Api));
			return cb_PrnStart_Api;
		}

		static int n_PrnStart_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnStart_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnStart_Api;
		public unsafe int PrnStart_Api ()
		{
			if (id_PrnStart_Api == IntPtr.Zero)
				id_PrnStart_Api = JNIEnv.GetMethodID (class_ref, "PrnStart_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnStart_Api);
		}

		static Delegate? cb_PrnStatus_Api;
#pragma warning disable 0169
		static Delegate GetPrnStatus_ApiHandler ()
		{
			if (cb_PrnStatus_Api == null)
				cb_PrnStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrnStatus_Api));
			return cb_PrnStatus_Api;
		}

		static int n_PrnStatus_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnStatus_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PrnStatus_Api;
		public unsafe int PrnStatus_Api ()
		{
			if (id_PrnStatus_Api == IntPtr.Zero)
				id_PrnStatus_Api = JNIEnv.GetMethodID (class_ref, "PrnStatus_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnStatus_Api);
		}

		static Delegate? cb_PrnStep_Api_I;
#pragma warning disable 0169
		static Delegate GetPrnStep_Api_IHandler ()
		{
			if (cb_PrnStep_Api_I == null)
				cb_PrnStep_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrnStep_Api_I));
			return cb_PrnStep_Api_I;
		}

		static int n_PrnStep_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrnStep_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PrnStep_Api_I;
		public unsafe int PrnStep_Api (int p0)
		{
			if (id_PrnStep_Api_I == IntPtr.Zero)
				id_PrnStep_Api_I = JNIEnv.GetMethodID (class_ref, "PrnStep_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnStep_Api_I, __args);
		}

		static Delegate? cb_PrnStr_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrnStr_Api_Ljava_lang_String_Handler ()
		{
			if (cb_PrnStr_Api_Ljava_lang_String_ == null)
				cb_PrnStr_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PrnStr_Api_Ljava_lang_String_));
			return cb_PrnStr_Api_Ljava_lang_String_;
		}

		static int n_PrnStr_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PrnStr_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PrnStr_Api_Ljava_lang_String_;
		public unsafe int PrnStr_Api (string? p0)
		{
			if (id_PrnStr_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_PrnStr_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "PrnStr_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PrnStr_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_SetLang_Api_II;
#pragma warning disable 0169
		static Delegate GetSetLang_Api_IIHandler ()
		{
			if (cb_SetLang_Api_II == null)
				cb_SetLang_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_SetLang_Api_II));
			return cb_SetLang_Api_II;
		}

		static void n_SetLang_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetLang_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_SetLang_Api_II;
		public unsafe void SetLang_Api (int p0, int p1)
		{
			if (id_SetLang_Api_II == IntPtr.Zero)
				id_SetLang_Api_II = JNIEnv.GetMethodID (class_ref, "SetLang_Api", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetLang_Api_II, __args);
		}

		static Delegate? cb_printAddBarCode_Api_IIIZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintAddBarCode_Api_IIIZLjava_lang_String_Handler ()
		{
			if (cb_printAddBarCode_Api_IIIZLjava_lang_String_ == null)
				cb_printAddBarCode_Api_IIIZLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIZL_V (n_PrintAddBarCode_Api_IIIZLjava_lang_String_));
			return cb_printAddBarCode_Api_IIIZLjava_lang_String_;
		}

		static void n_PrintAddBarCode_Api_IIIZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, bool p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.PrintAddBarCode_Api (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_printAddBarCode_Api_IIIZLjava_lang_String_;
		public unsafe void PrintAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4)
		{
			if (id_printAddBarCode_Api_IIIZLjava_lang_String_ == IntPtr.Zero)
				id_printAddBarCode_Api_IIIZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "printAddBarCode_Api", "(IIIZLjava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printAddBarCode_Api_IIIZLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate? cb_printAddImage_Api_IIIarrayB;
#pragma warning disable 0169
		static Delegate GetPrintAddImage_Api_IIIarrayBHandler ()
		{
			if (cb_printAddImage_Api_IIIarrayB == null)
				cb_printAddImage_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_V (n_PrintAddImage_Api_IIIarrayB));
			return cb_printAddImage_Api_IIIarrayB;
		}

		static void n_PrintAddImage_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PrintAddImage_Api (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_printAddImage_Api_IIIarrayB;
		public unsafe void PrintAddImage_Api (int p0, int p1, int p2, byte[]? p3)
		{
			if (id_printAddImage_Api_IIIarrayB == IntPtr.Zero)
				id_printAddImage_Api_IIIarrayB = JNIEnv.GetMethodID (class_ref, "printAddImage_Api", "(III[B)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printAddImage_Api_IIIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate? cb_printAddQrCode_Api_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintAddQrCode_Api_IILjava_lang_String_Handler ()
		{
			if (cb_printAddQrCode_Api_IILjava_lang_String_ == null)
				cb_printAddQrCode_Api_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_V (n_PrintAddQrCode_Api_IILjava_lang_String_));
			return cb_printAddQrCode_Api_IILjava_lang_String_;
		}

		static void n_PrintAddQrCode_Api_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintAddQrCode_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_printAddQrCode_Api_IILjava_lang_String_;
		public unsafe void PrintAddQrCode_Api (int p0, int p1, string? p2)
		{
			if (id_printAddQrCode_Api_IILjava_lang_String_ == IntPtr.Zero)
				id_printAddQrCode_Api_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "printAddQrCode_Api", "(IILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printAddQrCode_Api_IILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate? cb_printAddQrCodes_Api_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPrintAddQrCodes_Api_ILjava_lang_String_IHandler ()
		{
			if (cb_printAddQrCodes_Api_ILjava_lang_String_I == null)
				cb_printAddQrCodes_Api_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_V (n_PrintAddQrCodes_Api_ILjava_lang_String_I));
			return cb_printAddQrCodes_Api_ILjava_lang_String_I;
		}

		static void n_PrintAddQrCodes_Api_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintAddQrCodes_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_printAddQrCodes_Api_ILjava_lang_String_I;
		public unsafe void PrintAddQrCodes_Api (int p0, string? p1, int p2)
		{
			if (id_printAddQrCodes_Api_ILjava_lang_String_I == IntPtr.Zero)
				id_printAddQrCodes_Api_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "printAddQrCodes_Api", "(ILjava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printAddQrCodes_Api_ILjava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_printAddText_Api_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintAddText_Api_IILjava_lang_String_Handler ()
		{
			if (cb_printAddText_Api_IILjava_lang_String_ == null)
				cb_printAddText_Api_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_V (n_PrintAddText_Api_IILjava_lang_String_));
			return cb_printAddText_Api_IILjava_lang_String_;
		}

		static void n_PrintAddText_Api_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintAddText_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_printAddText_Api_IILjava_lang_String_;
		public unsafe void PrintAddText_Api (int p0, int p1, string? p2)
		{
			if (id_printAddText_Api_IILjava_lang_String_ == IntPtr.Zero)
				id_printAddText_Api_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "printAddText_Api", "(IILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printAddText_Api_IILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate? cb_printEnd_Api;
#pragma warning disable 0169
		static Delegate GetPrintEnd_ApiHandler ()
		{
			if (cb_printEnd_Api == null)
				cb_printEnd_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintEnd_Api));
			return cb_printEnd_Api;
		}

		static int n_PrintEnd_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrintEnd_Api ();
		}
#pragma warning restore 0169

		IntPtr id_printEnd_Api;
		public unsafe int PrintEnd_Api ()
		{
			if (id_printEnd_Api == IntPtr.Zero)
				id_printEnd_Api = JNIEnv.GetMethodID (class_ref, "printEnd_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_printEnd_Api);
		}

		static Delegate? cb_printFeedLine_Api_I;
#pragma warning disable 0169
		static Delegate GetPrintFeedLine_Api_IHandler ()
		{
			if (cb_printFeedLine_Api_I == null)
				cb_printFeedLine_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintFeedLine_Api_I));
			return cb_printFeedLine_Api_I;
		}

		static void n_PrintFeedLine_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintFeedLine_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printFeedLine_Api_I;
		public unsafe void PrintFeedLine_Api (int p0)
		{
			if (id_printFeedLine_Api_I == IntPtr.Zero)
				id_printFeedLine_Api_I = JNIEnv.GetMethodID (class_ref, "printFeedLine_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printFeedLine_Api_I, __args);
		}

		static Delegate? cb_printGetTextSize_Api;
#pragma warning disable 0169
		static Delegate GetPrintGetTextSize_ApiHandler ()
		{
			if (cb_printGetTextSize_Api == null)
				cb_printGetTextSize_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintGetTextSize_Api));
			return cb_printGetTextSize_Api;
		}

		static int n_PrintGetTextSize_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrintGetTextSize_Api ();
		}
#pragma warning restore 0169

		IntPtr id_printGetTextSize_Api;
		public unsafe int PrintGetTextSize_Api ()
		{
			if (id_printGetTextSize_Api == IntPtr.Zero)
				id_printGetTextSize_Api = JNIEnv.GetMethodID (class_ref, "printGetTextSize_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_printGetTextSize_Api);
		}

		static Delegate? cb_printPaperFeed_Api_I;
#pragma warning disable 0169
		static Delegate GetPrintPaperFeed_Api_IHandler ()
		{
			if (cb_printPaperFeed_Api_I == null)
				cb_printPaperFeed_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrintPaperFeed_Api_I));
			return cb_printPaperFeed_Api_I;
		}

		static int n_PrintPaperFeed_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrintPaperFeed_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printPaperFeed_Api_I;
		public unsafe int PrintPaperFeed_Api (int p0)
		{
			if (id_printPaperFeed_Api_I == IntPtr.Zero)
				id_printPaperFeed_Api_I = JNIEnv.GetMethodID (class_ref, "printPaperFeed_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_printPaperFeed_Api_I, __args);
		}

		static Delegate? cb_printQueryStatus_Api;
#pragma warning disable 0169
		static Delegate GetPrintQueryStatus_ApiHandler ()
		{
			if (cb_printQueryStatus_Api == null)
				cb_printQueryStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PrintQueryStatus_Api));
			return cb_printQueryStatus_Api;
		}

		static int n_PrintQueryStatus_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrintQueryStatus_Api ();
		}
#pragma warning restore 0169

		IntPtr id_printQueryStatus_Api;
		public unsafe int PrintQueryStatus_Api ()
		{
			if (id_printQueryStatus_Api == IntPtr.Zero)
				id_printQueryStatus_Api = JNIEnv.GetMethodID (class_ref, "printQueryStatus_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_printQueryStatus_Api);
		}

		static Delegate? cb_printSetAlign_Api_I;
#pragma warning disable 0169
		static Delegate GetPrintSetAlign_Api_IHandler ()
		{
			if (cb_printSetAlign_Api_I == null)
				cb_printSetAlign_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintSetAlign_Api_I));
			return cb_printSetAlign_Api_I;
		}

		static void n_PrintSetAlign_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintSetAlign_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printSetAlign_Api_I;
		public unsafe void PrintSetAlign_Api (int p0)
		{
			if (id_printSetAlign_Api_I == IntPtr.Zero)
				id_printSetAlign_Api_I = JNIEnv.GetMethodID (class_ref, "printSetAlign_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printSetAlign_Api_I, __args);
		}

		static Delegate? cb_printSetBlodText_Api_Z;
#pragma warning disable 0169
		static Delegate GetPrintSetBlodText_Api_ZHandler ()
		{
			if (cb_printSetBlodText_Api_Z == null)
				cb_printSetBlodText_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetBlodText_Api_Z));
			return cb_printSetBlodText_Api_Z;
		}

		static void n_PrintSetBlodText_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintSetBlodText_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printSetBlodText_Api_Z;
		public unsafe void PrintSetBlodText_Api (bool p0)
		{
			if (id_printSetBlodText_Api_Z == IntPtr.Zero)
				id_printSetBlodText_Api_Z = JNIEnv.GetMethodID (class_ref, "printSetBlodText_Api", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printSetBlodText_Api_Z, __args);
		}

		static Delegate? cb_printSetGray_Api_I;
#pragma warning disable 0169
		static Delegate GetPrintSetGray_Api_IHandler ()
		{
			if (cb_printSetGray_Api_I == null)
				cb_printSetGray_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PrintSetGray_Api_I));
			return cb_printSetGray_Api_I;
		}

		static void n_PrintSetGray_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintSetGray_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printSetGray_Api_I;
		public unsafe void PrintSetGray_Api (int p0)
		{
			if (id_printSetGray_Api_I == IntPtr.Zero)
				id_printSetGray_Api_I = JNIEnv.GetMethodID (class_ref, "printSetGray_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printSetGray_Api_I, __args);
		}

		static Delegate? cb_printSetInvert_Api_Z;
#pragma warning disable 0169
		static Delegate GetPrintSetInvert_Api_ZHandler ()
		{
			if (cb_printSetInvert_Api_Z == null)
				cb_printSetInvert_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetInvert_Api_Z));
			return cb_printSetInvert_Api_Z;
		}

		static void n_PrintSetInvert_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintSetInvert_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printSetInvert_Api_Z;
		public unsafe void PrintSetInvert_Api (bool p0)
		{
			if (id_printSetInvert_Api_Z == IntPtr.Zero)
				id_printSetInvert_Api_Z = JNIEnv.GetMethodID (class_ref, "printSetInvert_Api", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printSetInvert_Api_Z, __args);
		}

		static Delegate? cb_printSetItalic_Api_F;
#pragma warning disable 0169
		static Delegate GetPrintSetItalic_Api_FHandler ()
		{
			if (cb_printSetItalic_Api_F == null)
				cb_printSetItalic_Api_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_PrintSetItalic_Api_F));
			return cb_printSetItalic_Api_F;
		}

		static void n_PrintSetItalic_Api_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintSetItalic_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printSetItalic_Api_F;
		public unsafe void PrintSetItalic_Api (float p0)
		{
			if (id_printSetItalic_Api_F == IntPtr.Zero)
				id_printSetItalic_Api_F = JNIEnv.GetMethodID (class_ref, "printSetItalic_Api", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printSetItalic_Api_F, __args);
		}

		static Delegate? cb_printSetLineThrough_Api_Z;
#pragma warning disable 0169
		static Delegate GetPrintSetLineThrough_Api_ZHandler ()
		{
			if (cb_printSetLineThrough_Api_Z == null)
				cb_printSetLineThrough_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_PrintSetLineThrough_Api_Z));
			return cb_printSetLineThrough_Api_Z;
		}

		static void n_PrintSetLineThrough_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintSetLineThrough_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printSetLineThrough_Api_Z;
		public unsafe void PrintSetLineThrough_Api (bool p0)
		{
			if (id_printSetLineThrough_Api_Z == IntPtr.Zero)
				id_printSetLineThrough_Api_Z = JNIEnv.GetMethodID (class_ref, "printSetLineThrough_Api", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printSetLineThrough_Api_Z, __args);
		}

		static Delegate? cb_printSetTextSize_Api_I;
#pragma warning disable 0169
		static Delegate GetPrintSetTextSize_Api_IHandler ()
		{
			if (cb_printSetTextSize_Api_I == null)
				cb_printSetTextSize_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PrintSetTextSize_Api_I));
			return cb_printSetTextSize_Api_I;
		}

		static int n_PrintSetTextSize_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PrintSetTextSize_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_printSetTextSize_Api_I;
		public unsafe int PrintSetTextSize_Api (int p0)
		{
			if (id_printSetTextSize_Api_I == IntPtr.Zero)
				id_printSetTextSize_Api_I = JNIEnv.GetMethodID (class_ref, "printSetTextSize_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_printSetTextSize_Api_I, __args);
		}

		static Delegate? cb_printStartPrint_Api;
#pragma warning disable 0169
		static Delegate GetPrintStartPrint_ApiHandler ()
		{
			if (cb_printStartPrint_Api == null)
				cb_printStartPrint_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PrintStartPrint_Api));
			return cb_printStartPrint_Api;
		}

		static void n_PrintStartPrint_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintStartPrint_Api ();
		}
#pragma warning restore 0169

		IntPtr id_printStartPrint_Api;
		public unsafe void PrintStartPrint_Api ()
		{
			if (id_printStartPrint_Api == IntPtr.Zero)
				id_printStartPrint_Api = JNIEnv.GetMethodID (class_ref, "printStartPrint_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printStartPrint_Api);
		}

		static Delegate? cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ == null)
				cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIZLL_V (n_PrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_));
			return cb_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_;
		}

		static void n_PrinterAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, bool p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.PrinterAddBarCode_Api (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_;
		public unsafe void PrinterAddBarCode_Api (int p0, int p1, int p2, bool p3, string? p4, string? p5)
		{
			if (id_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "printerAddBarCode_Api", "(IIIZLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printerAddBarCode_Api_IIIZLjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate? cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I == null)
				cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIZLLI_V (n_PrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I));
			return cb_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I;
		}

		static void n_PrinterAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2, IntPtr native_p3, IntPtr native_p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.PrinterAddBarCodes_Api (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I;
		public unsafe void PrinterAddBarCodes_Api (int p0, int p1, bool p2, string? p3, string? p4, int p5)
		{
			if (id_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "printerAddBarCodes_Api", "(IIZLjava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printerAddBarCodes_Api_IIZLjava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate? cb_setFontName_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFontName_Api_Ljava_lang_String_Handler ()
		{
			if (cb_setFontName_Api_Ljava_lang_String_ == null)
				cb_setFontName_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetFontName_Api_Ljava_lang_String_));
			return cb_setFontName_Api_Ljava_lang_String_;
		}

		static int n_SetFontName_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetFontName_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setFontName_Api_Ljava_lang_String_;
		public unsafe int SetFontName_Api (string? p0)
		{
			if (id_setFontName_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_setFontName_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFontName_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setFontName_Api_Ljava_lang_String_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Printer.IPrinterHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
