using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.Ped {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']"
	[Register ("com/vanstone/appsdk/api/ped/PedHandler", "", "Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker")]
	public partial interface IPedHandler : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='KMS_TR31_DukptWriteTIK_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='int']]"
		[Register ("KMS_TR31_DukptWriteTIK_Api", "(III[B[B[B[BI)I", "GetKMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int KMS_TR31_DukptWriteTIK_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, int p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='KMS_TR31_MwriteKey_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("KMS_TR31_MwriteKey_Api", "(II[B[B[B)I", "GetKMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int KMS_TR31_MwriteKey_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDBigDataMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
		[Register ("PEDBigDataMac_Api", "(II[BI[BI)I", "GetPEDBigDataMac_Api_IIarrayBIarrayBIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDBigDataMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDDesCBC_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int'] and parameter[8][@type='byte[]']]"
		[Register ("PEDDesCBC_Api", "(III[BI[BI[B)I", "GetPEDDesCBC_Api_IIIarrayBIarrayBIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDDesCBC_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5, int p6, byte[]? p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDDes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
		[Register ("PEDDes_Api", "(III[BI[B)I", "GetPEDDes_Api_IIIarrayBIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDDes_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetDukpt_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetDukptPinListener']]"
		[Register ("PEDGetDukpt_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetDukptPinListener;)I", "GetPEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDGetDukpt_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetDukptPinListener? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetExpress_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
		[Register ("PEDGetExpress_Api", "(Ljava/lang/String;[BILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDGetExpress_Api (string? p0, byte[]? p1, int p2, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetHdSoft_Api' and count(parameter)=0]"
		[Register ("PEDGetHdSoft_Api", "()I", "GetPEDGetHdSoft_ApiHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDGetHdSoft_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetLastError_Api' and count(parameter)=0]"
		[Register ("PEDGetLastError_Api", "()Ljava/lang/String;", "GetPEDGetLastError_ApiHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		string? PEDGetLastError_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetPwd_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
		[Register ("PEDGetPwd_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDGetPwd_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
		[Register ("PEDMac_Api", "(II[BI[BI)I", "GetPEDMac_Api_IIarrayBIarrayBIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDReadPinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("PEDReadPinPadSn_Api", "([B)I", "GetPEDReadPinPadSn_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDReadPinPadSn_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSavePinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("PEDSavePinPadSn_Api", "([B)I", "GetPEDSavePinPadSn_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDSavePinPadSn_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetDesSmHdSoft_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("PEDSetDesSmHdSoft_Api", "(II)I", "GetPEDSetDesSmHdSoft_Api_IIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDSetDesSmHdSoft_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetHdSoft_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PEDSetHdSoft_Api", "(I)I", "GetPEDSetHdSoft_Api_IHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDSetHdSoft_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetKeyType_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PEDSetKeyType_Api", "(I)V", "GetPEDSetKeyType_Api_IHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void PEDSetKeyType_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSnMacOnly_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("PEDSnMacOnly_Api", "([BI[BI)I", "GetPEDSnMacOnly_Api_arrayBIarrayBIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDSnMacOnly_Api (byte[]? p0, int p1, byte[]? p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDStopPin' and count(parameter)=0]"
		[Register ("PEDStopPin", "()I", "GetPEDStopPinHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDStopPin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWrite21Key_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("PEDWrite21Key_Api", "(I[B)I", "GetPEDWrite21Key_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDWrite21Key_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteIcBcKeyWithType_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("PEDWriteIcBcKeyWithType_Api", "([BIIII)I", "GetPEDWriteIcBcKeyWithType_Api_arrayBIIIIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDWriteIcBcKeyWithType_Api (byte[]? p0, int p1, int p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteIcBcKey_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
		[Register ("PEDWriteIcBcKey_Api", "([BIIIII[B)I", "GetPEDWriteIcBcKey_Api_arrayBIIIIIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDWriteIcBcKey_Api (byte[]? p0, int p1, int p2, int p3, int p4, int p5, byte[]? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
		[Register ("PEDWriteKey_Api", "(II[BII[B)I", "GetPEDWriteKey_Api_IIarrayBIIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDWriteKey_Api (int p0, int p1, byte[]? p2, int p3, int p4, byte[]? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteMKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("PEDWriteMKey_Api", "(II[B)I", "GetPEDWriteMKey_Api_IIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDWriteMKey_Api (int p0, int p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteWKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("PEDWriteWKey_Api", "(III[B)I", "GetPEDWriteWKey_Api_IIIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PEDWriteWKey_Api (int p0, int p1, int p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedCalcDESDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
		[Register ("PedCalcDESDukpt_Api", "(BB[B[BB[B[B)I", "GetPedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PedCalcDESDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, sbyte p4, byte[]? p5, byte[]? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedCalcSymDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
		[Register ("PedCalcSymDukpt_Api", "(BB[B[BIB[B)I", "GetPedCalcSymDukpt_Api_BBarrayBarrayBIBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PedCalcSymDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, int p4, sbyte p5, byte[]? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedDukptIncreaseKsn_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("PedDukptIncreaseKsn_Api", "(B)I", "GetPedDukptIncreaseKsn_Api_BHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PedDukptIncreaseKsn_Api (sbyte p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedDukptWriteTIK_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
		[Register ("PedDukptWriteTIK_Api", "(BBB[B[BB[B)I", "GetPedDukptWriteTIK_Api_BBBarrayBarrayBBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PedDukptWriteTIK_Api (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, byte[]? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedEraseAll_Api' and count(parameter)=0]"
		[Register ("PedEraseAll_Api", "()Z", "GetPedEraseAll_ApiHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		bool PedEraseAll_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedErase_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("PedErase_Api", "(II)Z", "GetPedErase_Api_IIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		bool PedErase_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedGetDukptKSN_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("PedGetDukptKSN_Api", "(B[B)I", "GetPedGetDukptKSN_Api_BarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PedGetDukptKSN_Api (sbyte p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedGetMacDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte']]"
		[Register ("PedGetMacDukpt_Api", "(BB[BI[B[BB)I", "GetPedGetMacDukpt_Api_BBarrayBIarrayBarrayBBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PedGetMacDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5, sbyte p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedSelectPlace_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("PedSelectPlace_Api", "(Ljava/lang/String;)I", "GetPedSelectPlace_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int PedSelectPlace_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSAEnAndDe_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("RSAEnAndDe_Api", "(I[B[B[B)I", "GetRSAEnAndDe_Api_IarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int RSAEnAndDe_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSASign_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("RSASign_Api", "([B[B[B)I", "GetRSASign_Api_arrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int RSASign_Api (byte[]? p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSAVerify_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("RSAVerify_Api", "([B[B[B)I", "GetRSAVerify_Api_arrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int RSAVerify_Api (byte[]? p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='TR31_WriteKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("TR31_WriteKey_Api", "(I[B[B[B)I", "GetTR31_WriteKey_Api_IarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int TR31_WriteKey_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calAes_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
		[Register ("calAes_Api", "(II[BI[BI[B)I", "GetCalAes_Api_IIarrayBIarrayBIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int CalAes_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5, byte[]? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcAesDukpt' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]']]"
		[Register ("calcAesDukpt", "(BB[BI[BB[B[B)I", "GetCalcAesDukpt_BBarrayBIarrayBBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int CalcAesDukpt (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, sbyte p5, byte[]? p6, byte[]? p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAEx_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("calcRSAEx_Api", "(II[B[B[B)I", "GetCalcRSAEx_Api_IIarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int CalcRSAEx_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAPri_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("calcRSAPri_Api", "(III[B[B)I", "GetCalcRSAPri_Api_IIIarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int CalcRSAPri_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAPub_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("calcRSAPub_Api", "(III[B[B)I", "GetCalcRSAPub_Api_IIIarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int CalcRSAPub_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSA_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("calcRSA_Api", "(B[B[B[B)I", "GetCalcRSA_Api_BarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int CalcRSA_Api (sbyte p0, byte[]? p1, byte[]? p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getAesDukptKsn' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("getAesDukptKsn", "(B[B)I", "GetGetAesDukptKsn_BarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int GetAesDukptKsn (sbyte p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getKeyPairHdOrSoftg' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("getKeyPairHdOrSoftg", "(I[B[B)I", "GetGetKeyPairHdOrSoftg_IarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int GetKeyPairHdOrSoftg (int p0, byte[]? p1, byte[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getMacAesDukpt' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
		[Register ("getMacAesDukpt", "(BIB[B[B[B)I", "GetGetMacAesDukpt_BIBarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int GetMacAesDukpt (sbyte p0, int p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getPinAESDukptEx' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
		[Register ("getPinAESDukptEx", "(BBB[B[B[B[B)I", "GetGetPinAESDukptEx_BBBarrayBarrayBarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int GetPinAESDukptEx (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getPinDukptEx_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
		[Register ("getPinDukptEx_Api", "(BBLjava/lang/String;Ljava/lang/String;[B[B)I", "GetGetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int GetPinDukptEx_Api (sbyte p0, sbyte p1, string? p2, string? p3, byte[]? p4, byte[]? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getRSAKeyPair_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("getRSAKeyPair_Api", "(III[B)I", "GetGetRSAKeyPair_Api_IIIarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int GetRSAKeyPair_Api (int p0, int p1, int p2, byte[]? p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='isKeyExist_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("isKeyExist_Api", "(II)Z", "GetIsKeyExist_Api_IIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		bool IsKeyExist_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAmountColor", "(Ljava/lang/String;)V", "GetSetAmountColor_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetAmountColor (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAmountFont", "(Ljava/lang/String;)V", "GetSetAmountFont_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetAmountFont (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setAmountSize", "(F)V", "GetSetAmountSize_FHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetAmountSize (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomBtnText' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setBottomBtnText", "([Ljava/lang/String;)V", "GetSetBottomBtnText_arrayLjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetBottomBtnText (string[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBottomFont", "(Ljava/lang/String;)V", "GetSetBottomFont_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetBottomFont (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBottomTextColor", "(Ljava/lang/String;)V", "GetSetBottomTextColor_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetBottomTextColor (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBottomTextSize", "(F)V", "GetSetBottomTextSize_FHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetBottomTextSize (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setCardNo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCardNo", "(Ljava/lang/String;)V", "GetSetCardNo_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetCardNo (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setDispAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDispAmt", "(Ljava/lang/String;)V", "GetSetDispAmt_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetDispAmt (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNumColor", "(Ljava/lang/String;)V", "GetSetNumColor_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetNumColor (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNumFont", "(Ljava/lang/String;)V", "GetSetNumFont_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetNumFont (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setNumSize", "(F)V", "GetSetNumSize_FHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetNumSize (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardFixed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPinBoardFixed", "(Z)V", "GetSetPinBoardFixed_ZHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetPinBoardFixed (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardKey_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setPinBoardKey_Api", "(Landroid/os/Bundle;)I", "GetSetPinBoardKey_Api_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int SetPinBoardKey_Api (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardMsg' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setPinBoardMsg", "(Landroid/os/Bundle;)V", "GetSetPinBoardMsg_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetPinBoardMsg (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardSetting' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setPinBoardSetting", "(Landroid/os/Bundle;)V", "GetSetPinBoardSetting_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetPinBoardSetting (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPinBoardStyle", "(I)V", "GetSetPinBoardStyle_IHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetPinBoardStyle (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setStatusbarColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStatusbarColor", "(Ljava/lang/String;)V", "GetSetStatusbarColor_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetStatusbarColor (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setStatusbarHide' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStatusbarHide", "(Z)V", "GetSetStatusbarHide_ZHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetStatusbarHide (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTextColor", "(Ljava/lang/String;)V", "GetSetTextColor_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetTextColor (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTextFont", "(Ljava/lang/String;)V", "GetSetTextFont_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetTextFont (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTextSize", "(F)V", "GetSetTextSize_FHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetTextSize (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTitleBackGroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleBackGroundColor", "(Ljava/lang/String;)V", "GetSetTitleBackGroundColor_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		void SetTitleBackGroundColor (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeAesKey' and count(parameter)=9 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte'] and parameter[8][@type='byte'] and parameter[9][@type='byte[]']]"
		[Register ("writeAesKey", "(BIBIB[BBB[B)I", "GetWriteAesKey_BIBIBarrayBBBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int WriteAesKey (sbyte p0, int p1, sbyte p2, int p3, sbyte p4, byte[]? p5, sbyte p6, sbyte p7, byte[]? p8);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeAesTik' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte'] and parameter[8][@type='byte[]']]"
		[Register ("writeAesTik", "(BBB[B[BBB[B)I", "GetWriteAesTik_BBBarrayBarrayBBBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int WriteAesTik (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, sbyte p6, byte[]? p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeDerivedKey' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("writeDerivedKey", "(II[BI)I", "GetWriteDerivedKey_IIarrayBIHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int WriteDerivedKey (int p0, int p1, byte[]? p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeRSAKeyEx_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
		[Register ("writeRSAKeyEx_Api", "(II[BI[B[B)I", "GetWriteRSAKeyEx_Api_IIarrayBIarrayBarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int WriteRSAKeyEx_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeRSAKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("writeRSAKey_Api", "(B[B)I", "GetWriteRSAKey_Api_BarrayBHandler:Com.Vanstone.Appsdk.Api.Ped.IPedHandlerInvoker, VanstonePosSdk")]
		int WriteRSAKey_Api (sbyte p0, byte[]? p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/ped/PedHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/ped/PedHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/constructor[@name='PedHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetKMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBIHandler ()
			{
				if (cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI == null)
					cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILLLLI_I (n_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI));
				return cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI;
			}

			static int n_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, int GroupIdx, int mkindex, int SrcKeyIdx, IntPtr native_KBPK, IntPtr native_TR31Key, IntPtr native_IKSN, IntPtr native_Kcv, int iCheckMode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var KBPK = (byte[]?) JNIEnv.GetArray (native_KBPK, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var TR31Key = (byte[]?) JNIEnv.GetArray (native_TR31Key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var IKSN = (byte[]?) JNIEnv.GetArray (native_IKSN, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Kcv = (byte[]?) JNIEnv.GetArray (native_Kcv, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.KMS_TR31_DukptWriteTIK_Api (GroupIdx, mkindex, SrcKeyIdx, KBPK, TR31Key, IKSN, Kcv, iCheckMode);
				if (KBPK != null)
					JNIEnv.CopyArray (KBPK, native_KBPK);
				if (TR31Key != null)
					JNIEnv.CopyArray (TR31Key, native_TR31Key);
				if (IKSN != null)
					JNIEnv.CopyArray (IKSN, native_IKSN);
				if (Kcv != null)
					JNIEnv.CopyArray (Kcv, native_Kcv);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='KMS_TR31_DukptWriteTIK_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='int']]"
			[Register ("KMS_TR31_DukptWriteTIK_Api", "(III[B[B[B[BI)I", "GetKMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBIHandler")]
			public virtual unsafe int KMS_TR31_DukptWriteTIK_Api (int GroupIdx, int mkindex, int SrcKeyIdx, byte[]? KBPK, byte[]? TR31Key, byte[]? IKSN, byte[]? Kcv, int iCheckMode)
			{
				const string __id = "KMS_TR31_DukptWriteTIK_Api.(III[B[B[B[BI)I";
				IntPtr native_KBPK = JNIEnv.NewArray (KBPK);
				IntPtr native_TR31Key = JNIEnv.NewArray (TR31Key);
				IntPtr native_IKSN = JNIEnv.NewArray (IKSN);
				IntPtr native_Kcv = JNIEnv.NewArray (Kcv);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (GroupIdx);
					__args [1] = new JniArgumentValue (mkindex);
					__args [2] = new JniArgumentValue (SrcKeyIdx);
					__args [3] = new JniArgumentValue (native_KBPK);
					__args [4] = new JniArgumentValue (native_TR31Key);
					__args [5] = new JniArgumentValue (native_IKSN);
					__args [6] = new JniArgumentValue (native_Kcv);
					__args [7] = new JniArgumentValue (iCheckMode);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (KBPK != null) {
						JNIEnv.CopyArray (native_KBPK, KBPK);
						JNIEnv.DeleteLocalRef (native_KBPK);
					}
					if (TR31Key != null) {
						JNIEnv.CopyArray (native_TR31Key, TR31Key);
						JNIEnv.DeleteLocalRef (native_TR31Key);
					}
					if (IKSN != null) {
						JNIEnv.CopyArray (native_IKSN, IKSN);
						JNIEnv.DeleteLocalRef (native_IKSN);
					}
					if (Kcv != null) {
						JNIEnv.CopyArray (native_Kcv, Kcv);
						JNIEnv.DeleteLocalRef (native_Kcv);
					}
					global::System.GC.KeepAlive (KBPK);
					global::System.GC.KeepAlive (TR31Key);
					global::System.GC.KeepAlive (IKSN);
					global::System.GC.KeepAlive (Kcv);
				}
			}

			static Delegate? cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetKMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayBHandler ()
			{
				if (cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB == null)
					cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILLL_I (n_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB));
				return cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB;
			}

			static int n_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int mkindex, int mode, IntPtr native_KBPK, IntPtr native_TR31Key, IntPtr native_Kcv)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var KBPK = (byte[]?) JNIEnv.GetArray (native_KBPK, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var TR31Key = (byte[]?) JNIEnv.GetArray (native_TR31Key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Kcv = (byte[]?) JNIEnv.GetArray (native_Kcv, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.KMS_TR31_MwriteKey_Api (mkindex, mode, KBPK, TR31Key, Kcv);
				if (KBPK != null)
					JNIEnv.CopyArray (KBPK, native_KBPK);
				if (TR31Key != null)
					JNIEnv.CopyArray (TR31Key, native_TR31Key);
				if (Kcv != null)
					JNIEnv.CopyArray (Kcv, native_Kcv);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='KMS_TR31_MwriteKey_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("KMS_TR31_MwriteKey_Api", "(II[B[B[B)I", "GetKMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayBHandler")]
			public virtual unsafe int KMS_TR31_MwriteKey_Api (int mkindex, int mode, byte[]? KBPK, byte[]? TR31Key, byte[]? Kcv)
			{
				const string __id = "KMS_TR31_MwriteKey_Api.(II[B[B[B)I";
				IntPtr native_KBPK = JNIEnv.NewArray (KBPK);
				IntPtr native_TR31Key = JNIEnv.NewArray (TR31Key);
				IntPtr native_Kcv = JNIEnv.NewArray (Kcv);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (mkindex);
					__args [1] = new JniArgumentValue (mode);
					__args [2] = new JniArgumentValue (native_KBPK);
					__args [3] = new JniArgumentValue (native_TR31Key);
					__args [4] = new JniArgumentValue (native_Kcv);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (KBPK != null) {
						JNIEnv.CopyArray (native_KBPK, KBPK);
						JNIEnv.DeleteLocalRef (native_KBPK);
					}
					if (TR31Key != null) {
						JNIEnv.CopyArray (native_TR31Key, TR31Key);
						JNIEnv.DeleteLocalRef (native_TR31Key);
					}
					if (Kcv != null) {
						JNIEnv.CopyArray (native_Kcv, Kcv);
						JNIEnv.DeleteLocalRef (native_Kcv);
					}
					global::System.GC.KeepAlive (KBPK);
					global::System.GC.KeepAlive (TR31Key);
					global::System.GC.KeepAlive (Kcv);
				}
			}

			static Delegate? cb_PEDBigDataMac_Api_IIarrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetPEDBigDataMac_Api_IIarrayBIarrayBIHandler ()
			{
				if (cb_PEDBigDataMac_Api_IIarrayBIarrayBI == null)
					cb_PEDBigDataMac_Api_IIarrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILI_I (n_PEDBigDataMac_Api_IIarrayBIarrayBI));
				return cb_PEDBigDataMac_Api_IIarrayBIarrayBI;
			}

			static int n_PEDBigDataMac_Api_IIarrayBIarrayBI (IntPtr jnienv, IntPtr native__this, int wkindex, int mode, IntPtr native_data, int Len, IntPtr native_Out, int flag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Out = (byte[]?) JNIEnv.GetArray (native_Out, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDBigDataMac_Api (wkindex, mode, data, Len, Out, flag);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				if (Out != null)
					JNIEnv.CopyArray (Out, native_Out);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDBigDataMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("PEDBigDataMac_Api", "(II[BI[BI)I", "GetPEDBigDataMac_Api_IIarrayBIarrayBIHandler")]
			public virtual unsafe int PEDBigDataMac_Api (int wkindex, int mode, byte[]? data, int Len, byte[]? Out, int flag)
			{
				const string __id = "PEDBigDataMac_Api.(II[BI[BI)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				IntPtr native_Out = JNIEnv.NewArray (Out);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (wkindex);
					__args [1] = new JniArgumentValue (mode);
					__args [2] = new JniArgumentValue (native_data);
					__args [3] = new JniArgumentValue (Len);
					__args [4] = new JniArgumentValue (native_Out);
					__args [5] = new JniArgumentValue (flag);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					if (Out != null) {
						JNIEnv.CopyArray (native_Out, Out);
						JNIEnv.DeleteLocalRef (native_Out);
					}
					global::System.GC.KeepAlive (data);
					global::System.GC.KeepAlive (Out);
				}
			}

			static Delegate? cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDDesCBC_Api_IIIarrayBIarrayBIarrayBHandler ()
			{
				if (cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB == null)
					cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILILIL_I (n_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB));
				return cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB;
			}

			static int n_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int KeyIndex, int Mode, int MorWFlag, IntPtr native_ivIn, int ivLen, IntPtr native_DataIn, int DataInLen, IntPtr native_DataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ivIn = (byte[]?) JNIEnv.GetArray (native_ivIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var DataIn = (byte[]?) JNIEnv.GetArray (native_DataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var DataOut = (byte[]?) JNIEnv.GetArray (native_DataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDDesCBC_Api (KeyIndex, Mode, MorWFlag, ivIn, ivLen, DataIn, DataInLen, DataOut);
				if (ivIn != null)
					JNIEnv.CopyArray (ivIn, native_ivIn);
				if (DataIn != null)
					JNIEnv.CopyArray (DataIn, native_DataIn);
				if (DataOut != null)
					JNIEnv.CopyArray (DataOut, native_DataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDDesCBC_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int'] and parameter[8][@type='byte[]']]"
			[Register ("PEDDesCBC_Api", "(III[BI[BI[B)I", "GetPEDDesCBC_Api_IIIarrayBIarrayBIarrayBHandler")]
			public virtual unsafe int PEDDesCBC_Api (int KeyIndex, int Mode, int MorWFlag, byte[]? ivIn, int ivLen, byte[]? DataIn, int DataInLen, byte[]? DataOut)
			{
				const string __id = "PEDDesCBC_Api.(III[BI[BI[B)I";
				IntPtr native_ivIn = JNIEnv.NewArray (ivIn);
				IntPtr native_DataIn = JNIEnv.NewArray (DataIn);
				IntPtr native_DataOut = JNIEnv.NewArray (DataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (KeyIndex);
					__args [1] = new JniArgumentValue (Mode);
					__args [2] = new JniArgumentValue (MorWFlag);
					__args [3] = new JniArgumentValue (native_ivIn);
					__args [4] = new JniArgumentValue (ivLen);
					__args [5] = new JniArgumentValue (native_DataIn);
					__args [6] = new JniArgumentValue (DataInLen);
					__args [7] = new JniArgumentValue (native_DataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ivIn != null) {
						JNIEnv.CopyArray (native_ivIn, ivIn);
						JNIEnv.DeleteLocalRef (native_ivIn);
					}
					if (DataIn != null) {
						JNIEnv.CopyArray (native_DataIn, DataIn);
						JNIEnv.DeleteLocalRef (native_DataIn);
					}
					if (DataOut != null) {
						JNIEnv.CopyArray (native_DataOut, DataOut);
						JNIEnv.DeleteLocalRef (native_DataOut);
					}
					global::System.GC.KeepAlive (ivIn);
					global::System.GC.KeepAlive (DataIn);
					global::System.GC.KeepAlive (DataOut);
				}
			}

			static Delegate? cb_PEDDes_Api_IIIarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDDes_Api_IIIarrayBIarrayBHandler ()
			{
				if (cb_PEDDes_Api_IIIarrayBIarrayB == null)
					cb_PEDDes_Api_IIIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILIL_I (n_PEDDes_Api_IIIarrayBIarrayB));
				return cb_PEDDes_Api_IIIarrayBIarrayB;
			}

			static int n_PEDDes_Api_IIIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int KeyIndex, int Mode, int MorWFlag, IntPtr native_DataIn, int DataInLen, IntPtr native_DataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var DataIn = (byte[]?) JNIEnv.GetArray (native_DataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var DataOut = (byte[]?) JNIEnv.GetArray (native_DataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDDes_Api (KeyIndex, Mode, MorWFlag, DataIn, DataInLen, DataOut);
				if (DataIn != null)
					JNIEnv.CopyArray (DataIn, native_DataIn);
				if (DataOut != null)
					JNIEnv.CopyArray (DataOut, native_DataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDDes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("PEDDes_Api", "(III[BI[B)I", "GetPEDDes_Api_IIIarrayBIarrayBHandler")]
			public virtual unsafe int PEDDes_Api (int KeyIndex, int Mode, int MorWFlag, byte[]? DataIn, int DataInLen, byte[]? DataOut)
			{
				const string __id = "PEDDes_Api.(III[BI[B)I";
				IntPtr native_DataIn = JNIEnv.NewArray (DataIn);
				IntPtr native_DataOut = JNIEnv.NewArray (DataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (KeyIndex);
					__args [1] = new JniArgumentValue (Mode);
					__args [2] = new JniArgumentValue (MorWFlag);
					__args [3] = new JniArgumentValue (native_DataIn);
					__args [4] = new JniArgumentValue (DataInLen);
					__args [5] = new JniArgumentValue (native_DataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (DataIn != null) {
						JNIEnv.CopyArray (native_DataIn, DataIn);
						JNIEnv.DeleteLocalRef (native_DataIn);
					}
					if (DataOut != null) {
						JNIEnv.CopyArray (native_DataOut, DataOut);
						JNIEnv.DeleteLocalRef (native_DataOut);
					}
					global::System.GC.KeepAlive (DataIn);
					global::System.GC.KeepAlive (DataOut);
				}
			}

			static Delegate? cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_;
#pragma warning disable 0169
			static Delegate GetPEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_Handler ()
			{
				if (cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ == null)
					cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLILIIL_I (n_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_));
				return cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_;
			}

			static int n_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disMsg, IntPtr native_dataIn, int keyIndex, IntPtr native_pinLimit, int mode, int timeOut, IntPtr native_listenner)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var disMsg = JNIEnv.GetString (native_disMsg, JniHandleOwnership.DoNotTransfer);
				var dataIn = (byte[]?) JNIEnv.GetArray (native_dataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pinLimit = (byte[]?) JNIEnv.GetArray (native_pinLimit, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var listenner = (global::Com.Vanstone.Transex.Ped.IGetDukptPinListener?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetDukptPinListener> (native_listenner, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PEDGetDukpt_Api (disMsg, dataIn, keyIndex, pinLimit, mode, timeOut, listenner);
				if (dataIn != null)
					JNIEnv.CopyArray (dataIn, native_dataIn);
				if (pinLimit != null)
					JNIEnv.CopyArray (pinLimit, native_pinLimit);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDGetDukpt_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetDukptPinListener']]"
			[Register ("PEDGetDukpt_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetDukptPinListener;)I", "GetPEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_Handler")]
			public virtual unsafe int PEDGetDukpt_Api (string? disMsg, byte[]? dataIn, int keyIndex, byte[]? pinLimit, int mode, int timeOut, global::Com.Vanstone.Transex.Ped.IGetDukptPinListener? listenner)
			{
				const string __id = "PEDGetDukpt_Api.(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetDukptPinListener;)I";
				IntPtr native_disMsg = JNIEnv.NewString ((string?)disMsg);
				IntPtr native_dataIn = JNIEnv.NewArray (dataIn);
				IntPtr native_pinLimit = JNIEnv.NewArray (pinLimit);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_disMsg);
					__args [1] = new JniArgumentValue (native_dataIn);
					__args [2] = new JniArgumentValue (keyIndex);
					__args [3] = new JniArgumentValue (native_pinLimit);
					__args [4] = new JniArgumentValue (mode);
					__args [5] = new JniArgumentValue (timeOut);
					__args [6] = new JniArgumentValue ((listenner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenner).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_disMsg);
					if (dataIn != null) {
						JNIEnv.CopyArray (native_dataIn, dataIn);
						JNIEnv.DeleteLocalRef (native_dataIn);
					}
					if (pinLimit != null) {
						JNIEnv.CopyArray (native_pinLimit, pinLimit);
						JNIEnv.DeleteLocalRef (native_pinLimit);
					}
					global::System.GC.KeepAlive (dataIn);
					global::System.GC.KeepAlive (pinLimit);
					global::System.GC.KeepAlive (listenner);
				}
			}

			static Delegate? cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_;
#pragma warning disable 0169
			static Delegate GetPEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_Handler ()
			{
				if (cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ == null)
					cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIL_I (n_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_));
				return cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_;
			}

			static int n_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disMsg, IntPtr native_pinLimit, int timeOut, IntPtr native_listenner)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var disMsg = JNIEnv.GetString (native_disMsg, JniHandleOwnership.DoNotTransfer);
				var pinLimit = (byte[]?) JNIEnv.GetArray (native_pinLimit, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var listenner = (global::Com.Vanstone.Transex.Ped.IGetPinResultListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (native_listenner, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PEDGetExpress_Api (disMsg, pinLimit, timeOut, listenner);
				if (pinLimit != null)
					JNIEnv.CopyArray (pinLimit, native_pinLimit);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDGetExpress_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
			[Register ("PEDGetExpress_Api", "(Ljava/lang/String;[BILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_Handler")]
			public virtual unsafe int PEDGetExpress_Api (string? disMsg, byte[]? pinLimit, int timeOut, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? listenner)
			{
				const string __id = "PEDGetExpress_Api.(Ljava/lang/String;[BILcom/vanstone/transex/ped/IGetPinResultListenner;)I";
				IntPtr native_disMsg = JNIEnv.NewString ((string?)disMsg);
				IntPtr native_pinLimit = JNIEnv.NewArray (pinLimit);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_disMsg);
					__args [1] = new JniArgumentValue (native_pinLimit);
					__args [2] = new JniArgumentValue (timeOut);
					__args [3] = new JniArgumentValue ((listenner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenner).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_disMsg);
					if (pinLimit != null) {
						JNIEnv.CopyArray (native_pinLimit, pinLimit);
						JNIEnv.DeleteLocalRef (native_pinLimit);
					}
					global::System.GC.KeepAlive (pinLimit);
					global::System.GC.KeepAlive (listenner);
				}
			}

			static Delegate? cb_PEDGetHdSoft_Api;
#pragma warning disable 0169
			static Delegate GetPEDGetHdSoft_ApiHandler ()
			{
				if (cb_PEDGetHdSoft_Api == null)
					cb_PEDGetHdSoft_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PEDGetHdSoft_Api));
				return cb_PEDGetHdSoft_Api;
			}

			static int n_PEDGetHdSoft_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDGetHdSoft_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDGetHdSoft_Api' and count(parameter)=0]"
			[Register ("PEDGetHdSoft_Api", "()I", "GetPEDGetHdSoft_ApiHandler")]
			public virtual unsafe int PEDGetHdSoft_Api ()
			{
				const string __id = "PEDGetHdSoft_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PEDGetLastError_Api;
#pragma warning disable 0169
			static Delegate GetPEDGetLastError_ApiHandler ()
			{
				if (cb_PEDGetLastError_Api == null)
					cb_PEDGetLastError_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PEDGetLastError_Api));
				return cb_PEDGetLastError_Api;
			}

			static IntPtr n_PEDGetLastError_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.PEDGetLastError_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDGetLastError_Api' and count(parameter)=0]"
			[Register ("PEDGetLastError_Api", "()Ljava/lang/String;", "GetPEDGetLastError_ApiHandler")]
			public virtual unsafe string? PEDGetLastError_Api ()
			{
				const string __id = "PEDGetLastError_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_;
#pragma warning disable 0169
			static Delegate GetPEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_Handler ()
			{
				if (cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ == null)
					cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLILIIL_I (n_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_));
				return cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_;
			}

			static int n_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disMsg, IntPtr native_panBlock, int keyIndex, IntPtr native_pinLimit, int mode, int timeOut, IntPtr native_listenner)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var disMsg = JNIEnv.GetString (native_disMsg, JniHandleOwnership.DoNotTransfer);
				var panBlock = (byte[]?) JNIEnv.GetArray (native_panBlock, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pinLimit = (byte[]?) JNIEnv.GetArray (native_pinLimit, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var listenner = (global::Com.Vanstone.Transex.Ped.IGetPinResultListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (native_listenner, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PEDGetPwd_Api (disMsg, panBlock, keyIndex, pinLimit, mode, timeOut, listenner);
				if (panBlock != null)
					JNIEnv.CopyArray (panBlock, native_panBlock);
				if (pinLimit != null)
					JNIEnv.CopyArray (pinLimit, native_pinLimit);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDGetPwd_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
			[Register ("PEDGetPwd_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_Handler")]
			public virtual unsafe int PEDGetPwd_Api (string? disMsg, byte[]? panBlock, int keyIndex, byte[]? pinLimit, int mode, int timeOut, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? listenner)
			{
				const string __id = "PEDGetPwd_Api.(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetPinResultListenner;)I";
				IntPtr native_disMsg = JNIEnv.NewString ((string?)disMsg);
				IntPtr native_panBlock = JNIEnv.NewArray (panBlock);
				IntPtr native_pinLimit = JNIEnv.NewArray (pinLimit);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_disMsg);
					__args [1] = new JniArgumentValue (native_panBlock);
					__args [2] = new JniArgumentValue (keyIndex);
					__args [3] = new JniArgumentValue (native_pinLimit);
					__args [4] = new JniArgumentValue (mode);
					__args [5] = new JniArgumentValue (timeOut);
					__args [6] = new JniArgumentValue ((listenner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenner).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_disMsg);
					if (panBlock != null) {
						JNIEnv.CopyArray (native_panBlock, panBlock);
						JNIEnv.DeleteLocalRef (native_panBlock);
					}
					if (pinLimit != null) {
						JNIEnv.CopyArray (native_pinLimit, pinLimit);
						JNIEnv.DeleteLocalRef (native_pinLimit);
					}
					global::System.GC.KeepAlive (panBlock);
					global::System.GC.KeepAlive (pinLimit);
					global::System.GC.KeepAlive (listenner);
				}
			}

			static Delegate? cb_PEDMac_Api_IIarrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetPEDMac_Api_IIarrayBIarrayBIHandler ()
			{
				if (cb_PEDMac_Api_IIarrayBIarrayBI == null)
					cb_PEDMac_Api_IIarrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILI_I (n_PEDMac_Api_IIarrayBIarrayBI));
				return cb_PEDMac_Api_IIarrayBIarrayBI;
			}

			static int n_PEDMac_Api_IIarrayBIarrayBI (IntPtr jnienv, IntPtr native__this, int wkindex, int mode, IntPtr native_data, int Len, IntPtr native_Out, int flag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Out = (byte[]?) JNIEnv.GetArray (native_Out, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDMac_Api (wkindex, mode, data, Len, Out, flag);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				if (Out != null)
					JNIEnv.CopyArray (Out, native_Out);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("PEDMac_Api", "(II[BI[BI)I", "GetPEDMac_Api_IIarrayBIarrayBIHandler")]
			public virtual unsafe int PEDMac_Api (int wkindex, int mode, byte[]? data, int Len, byte[]? Out, int flag)
			{
				const string __id = "PEDMac_Api.(II[BI[BI)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				IntPtr native_Out = JNIEnv.NewArray (Out);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (wkindex);
					__args [1] = new JniArgumentValue (mode);
					__args [2] = new JniArgumentValue (native_data);
					__args [3] = new JniArgumentValue (Len);
					__args [4] = new JniArgumentValue (native_Out);
					__args [5] = new JniArgumentValue (flag);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					if (Out != null) {
						JNIEnv.CopyArray (native_Out, Out);
						JNIEnv.DeleteLocalRef (native_Out);
					}
					global::System.GC.KeepAlive (data);
					global::System.GC.KeepAlive (Out);
				}
			}

			static Delegate? cb_PEDReadPinPadSn_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetPEDReadPinPadSn_Api_arrayBHandler ()
			{
				if (cb_PEDReadPinPadSn_Api_arrayB == null)
					cb_PEDReadPinPadSn_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PEDReadPinPadSn_Api_arrayB));
				return cb_PEDReadPinPadSn_Api_arrayB;
			}

			static int n_PEDReadPinPadSn_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_Sn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Sn = (byte[]?) JNIEnv.GetArray (native_Sn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDReadPinPadSn_Api (Sn);
				if (Sn != null)
					JNIEnv.CopyArray (Sn, native_Sn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDReadPinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("PEDReadPinPadSn_Api", "([B)I", "GetPEDReadPinPadSn_Api_arrayBHandler")]
			public virtual unsafe int PEDReadPinPadSn_Api (byte[]? Sn)
			{
				const string __id = "PEDReadPinPadSn_Api.([B)I";
				IntPtr native_Sn = JNIEnv.NewArray (Sn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_Sn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Sn != null) {
						JNIEnv.CopyArray (native_Sn, Sn);
						JNIEnv.DeleteLocalRef (native_Sn);
					}
					global::System.GC.KeepAlive (Sn);
				}
			}

			static Delegate? cb_PEDSavePinPadSn_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetPEDSavePinPadSn_Api_arrayBHandler ()
			{
				if (cb_PEDSavePinPadSn_Api_arrayB == null)
					cb_PEDSavePinPadSn_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PEDSavePinPadSn_Api_arrayB));
				return cb_PEDSavePinPadSn_Api_arrayB;
			}

			static int n_PEDSavePinPadSn_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_Sn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Sn = (byte[]?) JNIEnv.GetArray (native_Sn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDSavePinPadSn_Api (Sn);
				if (Sn != null)
					JNIEnv.CopyArray (Sn, native_Sn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDSavePinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("PEDSavePinPadSn_Api", "([B)I", "GetPEDSavePinPadSn_Api_arrayBHandler")]
			public virtual unsafe int PEDSavePinPadSn_Api (byte[]? Sn)
			{
				const string __id = "PEDSavePinPadSn_Api.([B)I";
				IntPtr native_Sn = JNIEnv.NewArray (Sn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_Sn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Sn != null) {
						JNIEnv.CopyArray (native_Sn, Sn);
						JNIEnv.DeleteLocalRef (native_Sn);
					}
					global::System.GC.KeepAlive (Sn);
				}
			}

			static Delegate? cb_PEDSetDesSmHdSoft_Api_II;
#pragma warning disable 0169
			static Delegate GetPEDSetDesSmHdSoft_Api_IIHandler ()
			{
				if (cb_PEDSetDesSmHdSoft_Api_II == null)
					cb_PEDSetDesSmHdSoft_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_PEDSetDesSmHdSoft_Api_II));
				return cb_PEDSetDesSmHdSoft_Api_II;
			}

			static int n_PEDSetDesSmHdSoft_Api_II (IntPtr jnienv, IntPtr native__this, int DesSMMode, int HdOrSoft)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDSetDesSmHdSoft_Api (DesSMMode, HdOrSoft);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDSetDesSmHdSoft_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PEDSetDesSmHdSoft_Api", "(II)I", "GetPEDSetDesSmHdSoft_Api_IIHandler")]
			public virtual unsafe int PEDSetDesSmHdSoft_Api (int DesSMMode, int HdOrSoft)
			{
				const string __id = "PEDSetDesSmHdSoft_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (DesSMMode);
					__args [1] = new JniArgumentValue (HdOrSoft);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PEDSetHdSoft_Api_I;
#pragma warning disable 0169
			static Delegate GetPEDSetHdSoft_Api_IHandler ()
			{
				if (cb_PEDSetHdSoft_Api_I == null)
					cb_PEDSetHdSoft_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PEDSetHdSoft_Api_I));
				return cb_PEDSetHdSoft_Api_I;
			}

			static int n_PEDSetHdSoft_Api_I (IntPtr jnienv, IntPtr native__this, int HdOrSoft)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDSetHdSoft_Api (HdOrSoft);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDSetHdSoft_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PEDSetHdSoft_Api", "(I)I", "GetPEDSetHdSoft_Api_IHandler")]
			public virtual unsafe int PEDSetHdSoft_Api (int HdOrSoft)
			{
				const string __id = "PEDSetHdSoft_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (HdOrSoft);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PEDSetKeyType_Api_I;
#pragma warning disable 0169
			static Delegate GetPEDSetKeyType_Api_IHandler ()
			{
				if (cb_PEDSetKeyType_Api_I == null)
					cb_PEDSetKeyType_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PEDSetKeyType_Api_I));
				return cb_PEDSetKeyType_Api_I;
			}

			static void n_PEDSetKeyType_Api_I (IntPtr jnienv, IntPtr native__this, int keyType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PEDSetKeyType_Api (keyType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDSetKeyType_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PEDSetKeyType_Api", "(I)V", "GetPEDSetKeyType_Api_IHandler")]
			public virtual unsafe void PEDSetKeyType_Api (int keyType)
			{
				const string __id = "PEDSetKeyType_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (keyType);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_PEDSnMacOnly_Api_arrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetPEDSnMacOnly_Api_arrayBIarrayBIHandler ()
			{
				if (cb_PEDSnMacOnly_Api_arrayBIarrayBI == null)
					cb_PEDSnMacOnly_Api_arrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_I (n_PEDSnMacOnly_Api_arrayBIarrayBI));
				return cb_PEDSnMacOnly_Api_arrayBIarrayBI;
			}

			static int n_PEDSnMacOnly_Api_arrayBIarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int dataLen, IntPtr native_outs, int mode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var outs = (byte[]?) JNIEnv.GetArray (native_outs, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDSnMacOnly_Api (data, dataLen, outs, mode);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				if (outs != null)
					JNIEnv.CopyArray (outs, native_outs);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDSnMacOnly_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("PEDSnMacOnly_Api", "([BI[BI)I", "GetPEDSnMacOnly_Api_arrayBIarrayBIHandler")]
			public virtual unsafe int PEDSnMacOnly_Api (byte[]? data, int dataLen, byte[]? outs, int mode)
			{
				const string __id = "PEDSnMacOnly_Api.([BI[BI)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				IntPtr native_outs = JNIEnv.NewArray (outs);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_data);
					__args [1] = new JniArgumentValue (dataLen);
					__args [2] = new JniArgumentValue (native_outs);
					__args [3] = new JniArgumentValue (mode);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					if (outs != null) {
						JNIEnv.CopyArray (native_outs, outs);
						JNIEnv.DeleteLocalRef (native_outs);
					}
					global::System.GC.KeepAlive (data);
					global::System.GC.KeepAlive (outs);
				}
			}

			static Delegate? cb_PEDStopPin;
#pragma warning disable 0169
			static Delegate GetPEDStopPinHandler ()
			{
				if (cb_PEDStopPin == null)
					cb_PEDStopPin = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PEDStopPin));
				return cb_PEDStopPin;
			}

			static int n_PEDStopPin (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDStopPin ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDStopPin' and count(parameter)=0]"
			[Register ("PEDStopPin", "()I", "GetPEDStopPinHandler")]
			public virtual unsafe int PEDStopPin ()
			{
				const string __id = "PEDStopPin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PEDWrite21Key_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWrite21Key_Api_IarrayBHandler ()
			{
				if (cb_PEDWrite21Key_Api_IarrayB == null)
					cb_PEDWrite21Key_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_PEDWrite21Key_Api_IarrayB));
				return cb_PEDWrite21Key_Api_IarrayB;
			}

			static int n_PEDWrite21Key_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int mode, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWrite21Key_Api (mode, data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDWrite21Key_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("PEDWrite21Key_Api", "(I[B)I", "GetPEDWrite21Key_Api_IarrayBHandler")]
			public virtual unsafe int PEDWrite21Key_Api (int mode, byte[]? data)
			{
				const string __id = "PEDWrite21Key_Api.(I[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (mode);
					__args [1] = new JniArgumentValue (native_data);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			static Delegate? cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII;
#pragma warning disable 0169
			static Delegate GetPEDWriteIcBcKeyWithType_Api_arrayBIIIIHandler ()
			{
				if (cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII == null)
					cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIII_I (n_PEDWriteIcBcKeyWithType_Api_arrayBIIII));
				return cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII;
			}

			static int n_PEDWriteIcBcKeyWithType_Api_arrayBIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_Inbuf, int wkindex, int mkindex, int keyType, int akeyindex)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Inbuf = (byte[]?) JNIEnv.GetArray (native_Inbuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteIcBcKeyWithType_Api (Inbuf, wkindex, mkindex, keyType, akeyindex);
				if (Inbuf != null)
					JNIEnv.CopyArray (Inbuf, native_Inbuf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDWriteIcBcKeyWithType_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("PEDWriteIcBcKeyWithType_Api", "([BIIII)I", "GetPEDWriteIcBcKeyWithType_Api_arrayBIIIIHandler")]
			public virtual unsafe int PEDWriteIcBcKeyWithType_Api (byte[]? Inbuf, int wkindex, int mkindex, int keyType, int akeyindex)
			{
				const string __id = "PEDWriteIcBcKeyWithType_Api.([BIIII)I";
				IntPtr native_Inbuf = JNIEnv.NewArray (Inbuf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_Inbuf);
					__args [1] = new JniArgumentValue (wkindex);
					__args [2] = new JniArgumentValue (mkindex);
					__args [3] = new JniArgumentValue (keyType);
					__args [4] = new JniArgumentValue (akeyindex);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Inbuf != null) {
						JNIEnv.CopyArray (native_Inbuf, Inbuf);
						JNIEnv.DeleteLocalRef (native_Inbuf);
					}
					global::System.GC.KeepAlive (Inbuf);
				}
			}

			static Delegate? cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteIcBcKey_Api_arrayBIIIIIarrayBHandler ()
			{
				if (cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB == null)
					cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIIIIL_I (n_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB));
				return cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB;
			}

			static int n_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_inbuf, int AKeyIndes, int MasteKeyIndes, int MacKeyIndes, int PinKeyIndes, int Flag28, IntPtr native_BitMap)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var inbuf = (byte[]?) JNIEnv.GetArray (native_inbuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var BitMap = (byte[]?) JNIEnv.GetArray (native_BitMap, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteIcBcKey_Api (inbuf, AKeyIndes, MasteKeyIndes, MacKeyIndes, PinKeyIndes, Flag28, BitMap);
				if (inbuf != null)
					JNIEnv.CopyArray (inbuf, native_inbuf);
				if (BitMap != null)
					JNIEnv.CopyArray (BitMap, native_BitMap);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDWriteIcBcKey_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
			[Register ("PEDWriteIcBcKey_Api", "([BIIIII[B)I", "GetPEDWriteIcBcKey_Api_arrayBIIIIIarrayBHandler")]
			public virtual unsafe int PEDWriteIcBcKey_Api (byte[]? inbuf, int AKeyIndes, int MasteKeyIndes, int MacKeyIndes, int PinKeyIndes, int Flag28, byte[]? BitMap)
			{
				const string __id = "PEDWriteIcBcKey_Api.([BIIIII[B)I";
				IntPtr native_inbuf = JNIEnv.NewArray (inbuf);
				IntPtr native_BitMap = JNIEnv.NewArray (BitMap);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_inbuf);
					__args [1] = new JniArgumentValue (AKeyIndes);
					__args [2] = new JniArgumentValue (MasteKeyIndes);
					__args [3] = new JniArgumentValue (MacKeyIndes);
					__args [4] = new JniArgumentValue (PinKeyIndes);
					__args [5] = new JniArgumentValue (Flag28);
					__args [6] = new JniArgumentValue (native_BitMap);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (inbuf != null) {
						JNIEnv.CopyArray (native_inbuf, inbuf);
						JNIEnv.DeleteLocalRef (native_inbuf);
					}
					if (BitMap != null) {
						JNIEnv.CopyArray (native_BitMap, BitMap);
						JNIEnv.DeleteLocalRef (native_BitMap);
					}
					global::System.GC.KeepAlive (inbuf);
					global::System.GC.KeepAlive (BitMap);
				}
			}

			static Delegate? cb_PEDWriteKey_Api_IIarrayBIIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteKey_Api_IIarrayBIIarrayBHandler ()
			{
				if (cb_PEDWriteKey_Api_IIarrayBIIarrayB == null)
					cb_PEDWriteKey_Api_IIarrayBIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILIIL_I (n_PEDWriteKey_Api_IIarrayBIIarrayB));
				return cb_PEDWriteKey_Api_IIarrayBIIarrayB;
			}

			static int n_PEDWriteKey_Api_IIarrayBIIarrayB (IntPtr jnienv, IntPtr native__this, int SKeyIndex, int DKeyIndex, IntPtr native_DKey, int DKeyType, int mode, IntPtr native_KVRData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var DKey = (byte[]?) JNIEnv.GetArray (native_DKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var KVRData = (byte[]?) JNIEnv.GetArray (native_KVRData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteKey_Api (SKeyIndex, DKeyIndex, DKey, DKeyType, mode, KVRData);
				if (DKey != null)
					JNIEnv.CopyArray (DKey, native_DKey);
				if (KVRData != null)
					JNIEnv.CopyArray (KVRData, native_KVRData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDWriteKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("PEDWriteKey_Api", "(II[BII[B)I", "GetPEDWriteKey_Api_IIarrayBIIarrayBHandler")]
			public virtual unsafe int PEDWriteKey_Api (int SKeyIndex, int DKeyIndex, byte[]? DKey, int DKeyType, int mode, byte[]? KVRData)
			{
				const string __id = "PEDWriteKey_Api.(II[BII[B)I";
				IntPtr native_DKey = JNIEnv.NewArray (DKey);
				IntPtr native_KVRData = JNIEnv.NewArray (KVRData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (SKeyIndex);
					__args [1] = new JniArgumentValue (DKeyIndex);
					__args [2] = new JniArgumentValue (native_DKey);
					__args [3] = new JniArgumentValue (DKeyType);
					__args [4] = new JniArgumentValue (mode);
					__args [5] = new JniArgumentValue (native_KVRData);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (DKey != null) {
						JNIEnv.CopyArray (native_DKey, DKey);
						JNIEnv.DeleteLocalRef (native_DKey);
					}
					if (KVRData != null) {
						JNIEnv.CopyArray (native_KVRData, KVRData);
						JNIEnv.DeleteLocalRef (native_KVRData);
					}
					global::System.GC.KeepAlive (DKey);
					global::System.GC.KeepAlive (KVRData);
				}
			}

			static Delegate? cb_PEDWriteMKey_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteMKey_Api_IIarrayBHandler ()
			{
				if (cb_PEDWriteMKey_Api_IIarrayB == null)
					cb_PEDWriteMKey_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_PEDWriteMKey_Api_IIarrayB));
				return cb_PEDWriteMKey_Api_IIarrayB;
			}

			static int n_PEDWriteMKey_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int mkindex, int mode, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteMKey_Api (mkindex, mode, data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDWriteMKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("PEDWriteMKey_Api", "(II[B)I", "GetPEDWriteMKey_Api_IIarrayBHandler")]
			public virtual unsafe int PEDWriteMKey_Api (int mkindex, int mode, byte[]? data)
			{
				const string __id = "PEDWriteMKey_Api.(II[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (mkindex);
					__args [1] = new JniArgumentValue (mode);
					__args [2] = new JniArgumentValue (native_data);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			static Delegate? cb_PEDWriteWKey_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteWKey_Api_IIIarrayBHandler ()
			{
				if (cb_PEDWriteWKey_Api_IIIarrayB == null)
					cb_PEDWriteWKey_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_PEDWriteWKey_Api_IIIarrayB));
				return cb_PEDWriteWKey_Api_IIIarrayB;
			}

			static int n_PEDWriteWKey_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int MkeyIndex, int WkeyIndex, int mode, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteWKey_Api (MkeyIndex, WkeyIndex, mode, data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PEDWriteWKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("PEDWriteWKey_Api", "(III[B)I", "GetPEDWriteWKey_Api_IIIarrayBHandler")]
			public virtual unsafe int PEDWriteWKey_Api (int MkeyIndex, int WkeyIndex, int mode, byte[]? data)
			{
				const string __id = "PEDWriteWKey_Api.(III[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (MkeyIndex);
					__args [1] = new JniArgumentValue (WkeyIndex);
					__args [2] = new JniArgumentValue (mode);
					__args [3] = new JniArgumentValue (native_data);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			static Delegate? cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetPedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayBHandler ()
			{
				if (cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB == null)
					cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLBLL_I (n_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB));
				return cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB;
			}

			static int n_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte GroupIdx, sbyte KeyVarType, IntPtr native_KpucIV, IntPtr native_DataIn, sbyte Mode, IntPtr native_DataOut, IntPtr native_KsnOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var KpucIV = (byte[]?) JNIEnv.GetArray (native_KpucIV, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var DataIn = (byte[]?) JNIEnv.GetArray (native_DataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var DataOut = (byte[]?) JNIEnv.GetArray (native_DataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var KsnOut = (byte[]?) JNIEnv.GetArray (native_KsnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedCalcDESDukpt_Api (GroupIdx, KeyVarType, KpucIV, DataIn, Mode, DataOut, KsnOut);
				if (KpucIV != null)
					JNIEnv.CopyArray (KpucIV, native_KpucIV);
				if (DataIn != null)
					JNIEnv.CopyArray (DataIn, native_DataIn);
				if (DataOut != null)
					JNIEnv.CopyArray (DataOut, native_DataOut);
				if (KsnOut != null)
					JNIEnv.CopyArray (KsnOut, native_KsnOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedCalcDESDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
			[Register ("PedCalcDESDukpt_Api", "(BB[B[BB[B[B)I", "GetPedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayBHandler")]
			public virtual unsafe int PedCalcDESDukpt_Api (sbyte GroupIdx, sbyte KeyVarType, byte[]? KpucIV, byte[]? DataIn, sbyte Mode, byte[]? DataOut, byte[]? KsnOut)
			{
				const string __id = "PedCalcDESDukpt_Api.(BB[B[BB[B[B)I";
				IntPtr native_KpucIV = JNIEnv.NewArray (KpucIV);
				IntPtr native_DataIn = JNIEnv.NewArray (DataIn);
				IntPtr native_DataOut = JNIEnv.NewArray (DataOut);
				IntPtr native_KsnOut = JNIEnv.NewArray (KsnOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (GroupIdx);
					__args [1] = new JniArgumentValue (KeyVarType);
					__args [2] = new JniArgumentValue (native_KpucIV);
					__args [3] = new JniArgumentValue (native_DataIn);
					__args [4] = new JniArgumentValue (Mode);
					__args [5] = new JniArgumentValue (native_DataOut);
					__args [6] = new JniArgumentValue (native_KsnOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (KpucIV != null) {
						JNIEnv.CopyArray (native_KpucIV, KpucIV);
						JNIEnv.DeleteLocalRef (native_KpucIV);
					}
					if (DataIn != null) {
						JNIEnv.CopyArray (native_DataIn, DataIn);
						JNIEnv.DeleteLocalRef (native_DataIn);
					}
					if (DataOut != null) {
						JNIEnv.CopyArray (native_DataOut, DataOut);
						JNIEnv.DeleteLocalRef (native_DataOut);
					}
					if (KsnOut != null) {
						JNIEnv.CopyArray (native_KsnOut, KsnOut);
						JNIEnv.DeleteLocalRef (native_KsnOut);
					}
					global::System.GC.KeepAlive (KpucIV);
					global::System.GC.KeepAlive (DataIn);
					global::System.GC.KeepAlive (DataOut);
					global::System.GC.KeepAlive (KsnOut);
				}
			}

			static Delegate? cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB;
#pragma warning disable 0169
			static Delegate GetPedCalcSymDukpt_Api_BBarrayBarrayBIBarrayBHandler ()
			{
				if (cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB == null)
					cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLIBL_I (n_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB));
				return cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB;
			}

			static int n_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB (IntPtr jnienv, IntPtr native__this, sbyte GroupIdx, sbyte KeyVarType, IntPtr native_KpucIV, IntPtr native_Data, int Inc, sbyte Mode, IntPtr native_KsnOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var KpucIV = (byte[]?) JNIEnv.GetArray (native_KpucIV, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var Data = (byte[]?) JNIEnv.GetArray (native_Data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var KsnOut = (byte[]?) JNIEnv.GetArray (native_KsnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedCalcSymDukpt_Api (GroupIdx, KeyVarType, KpucIV, Data, Inc, Mode, KsnOut);
				if (KpucIV != null)
					JNIEnv.CopyArray (KpucIV, native_KpucIV);
				if (Data != null)
					JNIEnv.CopyArray (Data, native_Data);
				if (KsnOut != null)
					JNIEnv.CopyArray (KsnOut, native_KsnOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedCalcSymDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
			[Register ("PedCalcSymDukpt_Api", "(BB[B[BIB[B)I", "GetPedCalcSymDukpt_Api_BBarrayBarrayBIBarrayBHandler")]
			public virtual unsafe int PedCalcSymDukpt_Api (sbyte GroupIdx, sbyte KeyVarType, byte[]? KpucIV, byte[]? Data, int Inc, sbyte Mode, byte[]? KsnOut)
			{
				const string __id = "PedCalcSymDukpt_Api.(BB[B[BIB[B)I";
				IntPtr native_KpucIV = JNIEnv.NewArray (KpucIV);
				IntPtr native_Data = JNIEnv.NewArray (Data);
				IntPtr native_KsnOut = JNIEnv.NewArray (KsnOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (GroupIdx);
					__args [1] = new JniArgumentValue (KeyVarType);
					__args [2] = new JniArgumentValue (native_KpucIV);
					__args [3] = new JniArgumentValue (native_Data);
					__args [4] = new JniArgumentValue (Inc);
					__args [5] = new JniArgumentValue (Mode);
					__args [6] = new JniArgumentValue (native_KsnOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (KpucIV != null) {
						JNIEnv.CopyArray (native_KpucIV, KpucIV);
						JNIEnv.DeleteLocalRef (native_KpucIV);
					}
					if (Data != null) {
						JNIEnv.CopyArray (native_Data, Data);
						JNIEnv.DeleteLocalRef (native_Data);
					}
					if (KsnOut != null) {
						JNIEnv.CopyArray (native_KsnOut, KsnOut);
						JNIEnv.DeleteLocalRef (native_KsnOut);
					}
					global::System.GC.KeepAlive (KpucIV);
					global::System.GC.KeepAlive (Data);
					global::System.GC.KeepAlive (KsnOut);
				}
			}

			static Delegate? cb_PedDukptIncreaseKsn_Api_B;
#pragma warning disable 0169
			static Delegate GetPedDukptIncreaseKsn_Api_BHandler ()
			{
				if (cb_PedDukptIncreaseKsn_Api_B == null)
					cb_PedDukptIncreaseKsn_Api_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_PedDukptIncreaseKsn_Api_B));
				return cb_PedDukptIncreaseKsn_Api_B;
			}

			static int n_PedDukptIncreaseKsn_Api_B (IntPtr jnienv, IntPtr native__this, sbyte GroupIdx)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PedDukptIncreaseKsn_Api (GroupIdx);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedDukptIncreaseKsn_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("PedDukptIncreaseKsn_Api", "(B)I", "GetPedDukptIncreaseKsn_Api_BHandler")]
			public virtual unsafe int PedDukptIncreaseKsn_Api (sbyte GroupIdx)
			{
				const string __id = "PedDukptIncreaseKsn_Api.(B)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (GroupIdx);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB;
#pragma warning disable 0169
			static Delegate GetPedDukptWriteTIK_Api_BBBarrayBarrayBBarrayBHandler ()
			{
				if (cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB == null)
					cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLBL_I (n_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB));
				return cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB;
			}

			static int n_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte GroupIdx, sbyte SrcKeyIdx, sbyte KeyLen, IntPtr native_KeyValueIn, IntPtr native_KsnIn, sbyte iCheckMode, IntPtr native_aucCheckBuf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var KeyValueIn = (byte[]?) JNIEnv.GetArray (native_KeyValueIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var KsnIn = (byte[]?) JNIEnv.GetArray (native_KsnIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var aucCheckBuf = (byte[]?) JNIEnv.GetArray (native_aucCheckBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedDukptWriteTIK_Api (GroupIdx, SrcKeyIdx, KeyLen, KeyValueIn, KsnIn, iCheckMode, aucCheckBuf);
				if (KeyValueIn != null)
					JNIEnv.CopyArray (KeyValueIn, native_KeyValueIn);
				if (KsnIn != null)
					JNIEnv.CopyArray (KsnIn, native_KsnIn);
				if (aucCheckBuf != null)
					JNIEnv.CopyArray (aucCheckBuf, native_aucCheckBuf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedDukptWriteTIK_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
			[Register ("PedDukptWriteTIK_Api", "(BBB[B[BB[B)I", "GetPedDukptWriteTIK_Api_BBBarrayBarrayBBarrayBHandler")]
			public virtual unsafe int PedDukptWriteTIK_Api (sbyte GroupIdx, sbyte SrcKeyIdx, sbyte KeyLen, byte[]? KeyValueIn, byte[]? KsnIn, sbyte iCheckMode, byte[]? aucCheckBuf)
			{
				const string __id = "PedDukptWriteTIK_Api.(BBB[B[BB[B)I";
				IntPtr native_KeyValueIn = JNIEnv.NewArray (KeyValueIn);
				IntPtr native_KsnIn = JNIEnv.NewArray (KsnIn);
				IntPtr native_aucCheckBuf = JNIEnv.NewArray (aucCheckBuf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (GroupIdx);
					__args [1] = new JniArgumentValue (SrcKeyIdx);
					__args [2] = new JniArgumentValue (KeyLen);
					__args [3] = new JniArgumentValue (native_KeyValueIn);
					__args [4] = new JniArgumentValue (native_KsnIn);
					__args [5] = new JniArgumentValue (iCheckMode);
					__args [6] = new JniArgumentValue (native_aucCheckBuf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (KeyValueIn != null) {
						JNIEnv.CopyArray (native_KeyValueIn, KeyValueIn);
						JNIEnv.DeleteLocalRef (native_KeyValueIn);
					}
					if (KsnIn != null) {
						JNIEnv.CopyArray (native_KsnIn, KsnIn);
						JNIEnv.DeleteLocalRef (native_KsnIn);
					}
					if (aucCheckBuf != null) {
						JNIEnv.CopyArray (native_aucCheckBuf, aucCheckBuf);
						JNIEnv.DeleteLocalRef (native_aucCheckBuf);
					}
					global::System.GC.KeepAlive (KeyValueIn);
					global::System.GC.KeepAlive (KsnIn);
					global::System.GC.KeepAlive (aucCheckBuf);
				}
			}

			static Delegate? cb_PedEraseAll_Api;
#pragma warning disable 0169
			static Delegate GetPedEraseAll_ApiHandler ()
			{
				if (cb_PedEraseAll_Api == null)
					cb_PedEraseAll_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_PedEraseAll_Api));
				return cb_PedEraseAll_Api;
			}

			static bool n_PedEraseAll_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PedEraseAll_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedEraseAll_Api' and count(parameter)=0]"
			[Register ("PedEraseAll_Api", "()Z", "GetPedEraseAll_ApiHandler")]
			public virtual unsafe bool PedEraseAll_Api ()
			{
				const string __id = "PedEraseAll_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PedErase_Api_II;
#pragma warning disable 0169
			static Delegate GetPedErase_Api_IIHandler ()
			{
				if (cb_PedErase_Api_II == null)
					cb_PedErase_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_PedErase_Api_II));
				return cb_PedErase_Api_II;
			}

			static bool n_PedErase_Api_II (IntPtr jnienv, IntPtr native__this, int KeyType, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PedErase_Api (KeyType, index);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedErase_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PedErase_Api", "(II)Z", "GetPedErase_Api_IIHandler")]
			public virtual unsafe bool PedErase_Api (int KeyType, int index)
			{
				const string __id = "PedErase_Api.(II)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (KeyType);
					__args [1] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_PedGetDukptKSN_Api_BarrayB;
#pragma warning disable 0169
			static Delegate GetPedGetDukptKSN_Api_BarrayBHandler ()
			{
				if (cb_PedGetDukptKSN_Api_BarrayB == null)
					cb_PedGetDukptKSN_Api_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_PedGetDukptKSN_Api_BarrayB));
				return cb_PedGetDukptKSN_Api_BarrayB;
			}

			static int n_PedGetDukptKSN_Api_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte GroupIdx, IntPtr native_KsnOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var KsnOut = (byte[]?) JNIEnv.GetArray (native_KsnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedGetDukptKSN_Api (GroupIdx, KsnOut);
				if (KsnOut != null)
					JNIEnv.CopyArray (KsnOut, native_KsnOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedGetDukptKSN_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("PedGetDukptKSN_Api", "(B[B)I", "GetPedGetDukptKSN_Api_BarrayBHandler")]
			public virtual unsafe int PedGetDukptKSN_Api (sbyte GroupIdx, byte[]? KsnOut)
			{
				const string __id = "PedGetDukptKSN_Api.(B[B)I";
				IntPtr native_KsnOut = JNIEnv.NewArray (KsnOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (GroupIdx);
					__args [1] = new JniArgumentValue (native_KsnOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (KsnOut != null) {
						JNIEnv.CopyArray (native_KsnOut, KsnOut);
						JNIEnv.DeleteLocalRef (native_KsnOut);
					}
					global::System.GC.KeepAlive (KsnOut);
				}
			}

			static Delegate? cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB;
#pragma warning disable 0169
			static Delegate GetPedGetMacDukpt_Api_BBarrayBIarrayBarrayBBHandler ()
			{
				if (cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB == null)
					cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLILLB_I (n_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB));
				return cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB;
			}

			static int n_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB (IntPtr jnienv, IntPtr native__this, sbyte GroupIdx, sbyte Increase, IntPtr native_DataIn, int DataInLen, IntPtr native_MacOut, IntPtr native_KsnOut, sbyte Mode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var DataIn = (byte[]?) JNIEnv.GetArray (native_DataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var MacOut = (byte[]?) JNIEnv.GetArray (native_MacOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var KsnOut = (byte[]?) JNIEnv.GetArray (native_KsnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedGetMacDukpt_Api (GroupIdx, Increase, DataIn, DataInLen, MacOut, KsnOut, Mode);
				if (DataIn != null)
					JNIEnv.CopyArray (DataIn, native_DataIn);
				if (MacOut != null)
					JNIEnv.CopyArray (MacOut, native_MacOut);
				if (KsnOut != null)
					JNIEnv.CopyArray (KsnOut, native_KsnOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedGetMacDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte']]"
			[Register ("PedGetMacDukpt_Api", "(BB[BI[B[BB)I", "GetPedGetMacDukpt_Api_BBarrayBIarrayBarrayBBHandler")]
			public virtual unsafe int PedGetMacDukpt_Api (sbyte GroupIdx, sbyte Increase, byte[]? DataIn, int DataInLen, byte[]? MacOut, byte[]? KsnOut, sbyte Mode)
			{
				const string __id = "PedGetMacDukpt_Api.(BB[BI[B[BB)I";
				IntPtr native_DataIn = JNIEnv.NewArray (DataIn);
				IntPtr native_MacOut = JNIEnv.NewArray (MacOut);
				IntPtr native_KsnOut = JNIEnv.NewArray (KsnOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (GroupIdx);
					__args [1] = new JniArgumentValue (Increase);
					__args [2] = new JniArgumentValue (native_DataIn);
					__args [3] = new JniArgumentValue (DataInLen);
					__args [4] = new JniArgumentValue (native_MacOut);
					__args [5] = new JniArgumentValue (native_KsnOut);
					__args [6] = new JniArgumentValue (Mode);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (DataIn != null) {
						JNIEnv.CopyArray (native_DataIn, DataIn);
						JNIEnv.DeleteLocalRef (native_DataIn);
					}
					if (MacOut != null) {
						JNIEnv.CopyArray (native_MacOut, MacOut);
						JNIEnv.DeleteLocalRef (native_MacOut);
					}
					if (KsnOut != null) {
						JNIEnv.CopyArray (native_KsnOut, KsnOut);
						JNIEnv.DeleteLocalRef (native_KsnOut);
					}
					global::System.GC.KeepAlive (DataIn);
					global::System.GC.KeepAlive (MacOut);
					global::System.GC.KeepAlive (KsnOut);
				}
			}

			static Delegate? cb_PedSelectPlace_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPedSelectPlace_Api_Ljava_lang_String_Handler ()
			{
				if (cb_PedSelectPlace_Api_Ljava_lang_String_ == null)
					cb_PedSelectPlace_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PedSelectPlace_Api_Ljava_lang_String_));
				return cb_PedSelectPlace_Api_Ljava_lang_String_;
			}

			static int n_PedSelectPlace_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_Place)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Place = JNIEnv.GetString (native_Place, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PedSelectPlace_Api (Place);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='PedSelectPlace_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("PedSelectPlace_Api", "(Ljava/lang/String;)I", "GetPedSelectPlace_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int PedSelectPlace_Api (string? Place)
			{
				const string __id = "PedSelectPlace_Api.(Ljava/lang/String;)I";
				IntPtr native_Place = JNIEnv.NewString ((string?)Place);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_Place);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_Place);
				}
			}

			static Delegate? cb_RSAEnAndDe_Api_IarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetRSAEnAndDe_Api_IarrayBarrayBarrayBHandler ()
			{
				if (cb_RSAEnAndDe_Api_IarrayBarrayBarrayB == null)
					cb_RSAEnAndDe_Api_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_RSAEnAndDe_Api_IarrayBarrayBarrayB));
				return cb_RSAEnAndDe_Api_IarrayBarrayBarrayB;
			}

			static int n_RSAEnAndDe_Api_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int mode, IntPtr native_Key, IntPtr native_content, IntPtr native_outdata)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Key = (byte[]?) JNIEnv.GetArray (native_Key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var content = (byte[]?) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var outdata = (byte[]?) JNIEnv.GetArray (native_outdata, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.RSAEnAndDe_Api (mode, Key, content, outdata);
				if (Key != null)
					JNIEnv.CopyArray (Key, native_Key);
				if (content != null)
					JNIEnv.CopyArray (content, native_content);
				if (outdata != null)
					JNIEnv.CopyArray (outdata, native_outdata);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='RSAEnAndDe_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("RSAEnAndDe_Api", "(I[B[B[B)I", "GetRSAEnAndDe_Api_IarrayBarrayBarrayBHandler")]
			public virtual unsafe int RSAEnAndDe_Api (int mode, byte[]? Key, byte[]? content, byte[]? outdata)
			{
				const string __id = "RSAEnAndDe_Api.(I[B[B[B)I";
				IntPtr native_Key = JNIEnv.NewArray (Key);
				IntPtr native_content = JNIEnv.NewArray (content);
				IntPtr native_outdata = JNIEnv.NewArray (outdata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (mode);
					__args [1] = new JniArgumentValue (native_Key);
					__args [2] = new JniArgumentValue (native_content);
					__args [3] = new JniArgumentValue (native_outdata);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (Key != null) {
						JNIEnv.CopyArray (native_Key, Key);
						JNIEnv.DeleteLocalRef (native_Key);
					}
					if (content != null) {
						JNIEnv.CopyArray (native_content, content);
						JNIEnv.DeleteLocalRef (native_content);
					}
					if (outdata != null) {
						JNIEnv.CopyArray (native_outdata, outdata);
						JNIEnv.DeleteLocalRef (native_outdata);
					}
					global::System.GC.KeepAlive (Key);
					global::System.GC.KeepAlive (content);
					global::System.GC.KeepAlive (outdata);
				}
			}

			static Delegate? cb_RSASign_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetRSASign_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_RSASign_Api_arrayBarrayBarrayB == null)
					cb_RSASign_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_RSASign_Api_arrayBarrayBarrayB));
				return cb_RSASign_Api_arrayBarrayBarrayB;
			}

			static int n_RSASign_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_privateKey, IntPtr native_content, IntPtr native_outdata)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var privateKey = (byte[]?) JNIEnv.GetArray (native_privateKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var content = (byte[]?) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var outdata = (byte[]?) JNIEnv.GetArray (native_outdata, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.RSASign_Api (privateKey, content, outdata);
				if (privateKey != null)
					JNIEnv.CopyArray (privateKey, native_privateKey);
				if (content != null)
					JNIEnv.CopyArray (content, native_content);
				if (outdata != null)
					JNIEnv.CopyArray (outdata, native_outdata);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='RSASign_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("RSASign_Api", "([B[B[B)I", "GetRSASign_Api_arrayBarrayBarrayBHandler")]
			public virtual unsafe int RSASign_Api (byte[]? privateKey, byte[]? content, byte[]? outdata)
			{
				const string __id = "RSASign_Api.([B[B[B)I";
				IntPtr native_privateKey = JNIEnv.NewArray (privateKey);
				IntPtr native_content = JNIEnv.NewArray (content);
				IntPtr native_outdata = JNIEnv.NewArray (outdata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_privateKey);
					__args [1] = new JniArgumentValue (native_content);
					__args [2] = new JniArgumentValue (native_outdata);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (privateKey != null) {
						JNIEnv.CopyArray (native_privateKey, privateKey);
						JNIEnv.DeleteLocalRef (native_privateKey);
					}
					if (content != null) {
						JNIEnv.CopyArray (native_content, content);
						JNIEnv.DeleteLocalRef (native_content);
					}
					if (outdata != null) {
						JNIEnv.CopyArray (native_outdata, outdata);
						JNIEnv.DeleteLocalRef (native_outdata);
					}
					global::System.GC.KeepAlive (privateKey);
					global::System.GC.KeepAlive (content);
					global::System.GC.KeepAlive (outdata);
				}
			}

			static Delegate? cb_RSAVerify_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetRSAVerify_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_RSAVerify_Api_arrayBarrayBarrayB == null)
					cb_RSAVerify_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_RSAVerify_Api_arrayBarrayBarrayB));
				return cb_RSAVerify_Api_arrayBarrayBarrayB;
			}

			static int n_RSAVerify_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_publicKey, IntPtr native_content, IntPtr native_sign)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var publicKey = (byte[]?) JNIEnv.GetArray (native_publicKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var content = (byte[]?) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var sign = (byte[]?) JNIEnv.GetArray (native_sign, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.RSAVerify_Api (publicKey, content, sign);
				if (publicKey != null)
					JNIEnv.CopyArray (publicKey, native_publicKey);
				if (content != null)
					JNIEnv.CopyArray (content, native_content);
				if (sign != null)
					JNIEnv.CopyArray (sign, native_sign);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='RSAVerify_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("RSAVerify_Api", "([B[B[B)I", "GetRSAVerify_Api_arrayBarrayBarrayBHandler")]
			public virtual unsafe int RSAVerify_Api (byte[]? publicKey, byte[]? content, byte[]? sign)
			{
				const string __id = "RSAVerify_Api.([B[B[B)I";
				IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
				IntPtr native_content = JNIEnv.NewArray (content);
				IntPtr native_sign = JNIEnv.NewArray (sign);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_publicKey);
					__args [1] = new JniArgumentValue (native_content);
					__args [2] = new JniArgumentValue (native_sign);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (publicKey != null) {
						JNIEnv.CopyArray (native_publicKey, publicKey);
						JNIEnv.DeleteLocalRef (native_publicKey);
					}
					if (content != null) {
						JNIEnv.CopyArray (native_content, content);
						JNIEnv.DeleteLocalRef (native_content);
					}
					if (sign != null) {
						JNIEnv.CopyArray (native_sign, sign);
						JNIEnv.DeleteLocalRef (native_sign);
					}
					global::System.GC.KeepAlive (publicKey);
					global::System.GC.KeepAlive (content);
					global::System.GC.KeepAlive (sign);
				}
			}

			static Delegate? cb_TR31_WriteKey_Api_IarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetTR31_WriteKey_Api_IarrayBarrayBarrayBHandler ()
			{
				if (cb_TR31_WriteKey_Api_IarrayBarrayBarrayB == null)
					cb_TR31_WriteKey_Api_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_TR31_WriteKey_Api_IarrayBarrayBarrayB));
				return cb_TR31_WriteKey_Api_IarrayBarrayBarrayB;
			}

			static int n_TR31_WriteKey_Api_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int mkindex, IntPtr native_KBPK, IntPtr native_TR31Key, IntPtr native_head)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var KBPK = (byte[]?) JNIEnv.GetArray (native_KBPK, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var TR31Key = (byte[]?) JNIEnv.GetArray (native_TR31Key, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var head = (byte[]?) JNIEnv.GetArray (native_head, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.TR31_WriteKey_Api (mkindex, KBPK, TR31Key, head);
				if (KBPK != null)
					JNIEnv.CopyArray (KBPK, native_KBPK);
				if (TR31Key != null)
					JNIEnv.CopyArray (TR31Key, native_TR31Key);
				if (head != null)
					JNIEnv.CopyArray (head, native_head);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='TR31_WriteKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("TR31_WriteKey_Api", "(I[B[B[B)I", "GetTR31_WriteKey_Api_IarrayBarrayBarrayBHandler")]
			public virtual unsafe int TR31_WriteKey_Api (int mkindex, byte[]? KBPK, byte[]? TR31Key, byte[]? head)
			{
				const string __id = "TR31_WriteKey_Api.(I[B[B[B)I";
				IntPtr native_KBPK = JNIEnv.NewArray (KBPK);
				IntPtr native_TR31Key = JNIEnv.NewArray (TR31Key);
				IntPtr native_head = JNIEnv.NewArray (head);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (mkindex);
					__args [1] = new JniArgumentValue (native_KBPK);
					__args [2] = new JniArgumentValue (native_TR31Key);
					__args [3] = new JniArgumentValue (native_head);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (KBPK != null) {
						JNIEnv.CopyArray (native_KBPK, KBPK);
						JNIEnv.DeleteLocalRef (native_KBPK);
					}
					if (TR31Key != null) {
						JNIEnv.CopyArray (native_TR31Key, TR31Key);
						JNIEnv.DeleteLocalRef (native_TR31Key);
					}
					if (head != null) {
						JNIEnv.CopyArray (native_head, head);
						JNIEnv.DeleteLocalRef (native_head);
					}
					global::System.GC.KeepAlive (KBPK);
					global::System.GC.KeepAlive (TR31Key);
					global::System.GC.KeepAlive (head);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_calAes_Api_IIarrayBIarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetCalAes_Api_IIarrayBIarrayBIarrayBHandler ()
			{
				if (cb_calAes_Api_IIarrayBIarrayBIarrayB == null)
					cb_calAes_Api_IIarrayBIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILIL_I (n_CalAes_Api_IIarrayBIarrayBIarrayB));
				return cb_calAes_Api_IIarrayBIarrayBIarrayB;
			}

			static int n_CalAes_Api_IIarrayBIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int KeyIndex, int Mode, IntPtr native_ivIn, int ivLen, IntPtr native_DataIn, int DataInLen, IntPtr native_DataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ivIn = (byte[]?) JNIEnv.GetArray (native_ivIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var DataIn = (byte[]?) JNIEnv.GetArray (native_DataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var DataOut = (byte[]?) JNIEnv.GetArray (native_DataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalAes_Api (KeyIndex, Mode, ivIn, ivLen, DataIn, DataInLen, DataOut);
				if (ivIn != null)
					JNIEnv.CopyArray (ivIn, native_ivIn);
				if (DataIn != null)
					JNIEnv.CopyArray (DataIn, native_DataIn);
				if (DataOut != null)
					JNIEnv.CopyArray (DataOut, native_DataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='calAes_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
			[Register ("calAes_Api", "(II[BI[BI[B)I", "GetCalAes_Api_IIarrayBIarrayBIarrayBHandler")]
			public virtual unsafe int CalAes_Api (int KeyIndex, int Mode, byte[]? ivIn, int ivLen, byte[]? DataIn, int DataInLen, byte[]? DataOut)
			{
				const string __id = "calAes_Api.(II[BI[BI[B)I";
				IntPtr native_ivIn = JNIEnv.NewArray (ivIn);
				IntPtr native_DataIn = JNIEnv.NewArray (DataIn);
				IntPtr native_DataOut = JNIEnv.NewArray (DataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (KeyIndex);
					__args [1] = new JniArgumentValue (Mode);
					__args [2] = new JniArgumentValue (native_ivIn);
					__args [3] = new JniArgumentValue (ivLen);
					__args [4] = new JniArgumentValue (native_DataIn);
					__args [5] = new JniArgumentValue (DataInLen);
					__args [6] = new JniArgumentValue (native_DataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ivIn != null) {
						JNIEnv.CopyArray (native_ivIn, ivIn);
						JNIEnv.DeleteLocalRef (native_ivIn);
					}
					if (DataIn != null) {
						JNIEnv.CopyArray (native_DataIn, DataIn);
						JNIEnv.DeleteLocalRef (native_DataIn);
					}
					if (DataOut != null) {
						JNIEnv.CopyArray (native_DataOut, DataOut);
						JNIEnv.DeleteLocalRef (native_DataOut);
					}
					global::System.GC.KeepAlive (ivIn);
					global::System.GC.KeepAlive (DataIn);
					global::System.GC.KeepAlive (DataOut);
				}
			}

			static Delegate? cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcAesDukpt_BBarrayBIarrayBBarrayBarrayBHandler ()
			{
				if (cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB == null)
					cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLILBLL_I (n_CalcAesDukpt_BBarrayBIarrayBBarrayBarrayB));
				return cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB;
			}

			static int n_CalcAesDukpt_BBarrayBIarrayBBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte groupIdx, sbyte keyVarType, IntPtr native_pucIV, int dataInLen, IntPtr native_dataIn, sbyte mode, IntPtr native_ksnOut, IntPtr native_dataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pucIV = (byte[]?) JNIEnv.GetArray (native_pucIV, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var dataIn = (byte[]?) JNIEnv.GetArray (native_dataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var ksnOut = (byte[]?) JNIEnv.GetArray (native_ksnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var dataOut = (byte[]?) JNIEnv.GetArray (native_dataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcAesDukpt (groupIdx, keyVarType, pucIV, dataInLen, dataIn, mode, ksnOut, dataOut);
				if (pucIV != null)
					JNIEnv.CopyArray (pucIV, native_pucIV);
				if (dataIn != null)
					JNIEnv.CopyArray (dataIn, native_dataIn);
				if (ksnOut != null)
					JNIEnv.CopyArray (ksnOut, native_ksnOut);
				if (dataOut != null)
					JNIEnv.CopyArray (dataOut, native_dataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='calcAesDukpt' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]']]"
			[Register ("calcAesDukpt", "(BB[BI[BB[B[B)I", "GetCalcAesDukpt_BBarrayBIarrayBBarrayBarrayBHandler")]
			public virtual unsafe int CalcAesDukpt (sbyte groupIdx, sbyte keyVarType, byte[]? pucIV, int dataInLen, byte[]? dataIn, sbyte mode, byte[]? ksnOut, byte[]? dataOut)
			{
				const string __id = "calcAesDukpt.(BB[BI[BB[B[B)I";
				IntPtr native_pucIV = JNIEnv.NewArray (pucIV);
				IntPtr native_dataIn = JNIEnv.NewArray (dataIn);
				IntPtr native_ksnOut = JNIEnv.NewArray (ksnOut);
				IntPtr native_dataOut = JNIEnv.NewArray (dataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (groupIdx);
					__args [1] = new JniArgumentValue (keyVarType);
					__args [2] = new JniArgumentValue (native_pucIV);
					__args [3] = new JniArgumentValue (dataInLen);
					__args [4] = new JniArgumentValue (native_dataIn);
					__args [5] = new JniArgumentValue (mode);
					__args [6] = new JniArgumentValue (native_ksnOut);
					__args [7] = new JniArgumentValue (native_dataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pucIV != null) {
						JNIEnv.CopyArray (native_pucIV, pucIV);
						JNIEnv.DeleteLocalRef (native_pucIV);
					}
					if (dataIn != null) {
						JNIEnv.CopyArray (native_dataIn, dataIn);
						JNIEnv.DeleteLocalRef (native_dataIn);
					}
					if (ksnOut != null) {
						JNIEnv.CopyArray (native_ksnOut, ksnOut);
						JNIEnv.DeleteLocalRef (native_ksnOut);
					}
					if (dataOut != null) {
						JNIEnv.CopyArray (native_dataOut, dataOut);
						JNIEnv.DeleteLocalRef (native_dataOut);
					}
					global::System.GC.KeepAlive (pucIV);
					global::System.GC.KeepAlive (dataIn);
					global::System.GC.KeepAlive (ksnOut);
					global::System.GC.KeepAlive (dataOut);
				}
			}

			static Delegate? cb_calcRSAEx_Api_IIarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSAEx_Api_IIarrayBarrayBarrayBHandler ()
			{
				if (cb_calcRSAEx_Api_IIarrayBarrayBarrayB == null)
					cb_calcRSAEx_Api_IIarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILLL_I (n_CalcRSAEx_Api_IIarrayBarrayBarrayB));
				return cb_calcRSAEx_Api_IIarrayBarrayBarrayB;
			}

			static int n_CalcRSAEx_Api_IIarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int RSAKeyIndex, int pucDataInLen, IntPtr native_pucDataIn, IntPtr native_pucDataOut, IntPtr native_pucKeyInfoOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pucDataIn = (byte[]?) JNIEnv.GetArray (native_pucDataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pucDataOut = (byte[]?) JNIEnv.GetArray (native_pucDataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pucKeyInfoOut = (byte[]?) JNIEnv.GetArray (native_pucKeyInfoOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSAEx_Api (RSAKeyIndex, pucDataInLen, pucDataIn, pucDataOut, pucKeyInfoOut);
				if (pucDataIn != null)
					JNIEnv.CopyArray (pucDataIn, native_pucDataIn);
				if (pucDataOut != null)
					JNIEnv.CopyArray (pucDataOut, native_pucDataOut);
				if (pucKeyInfoOut != null)
					JNIEnv.CopyArray (pucKeyInfoOut, native_pucKeyInfoOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='calcRSAEx_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAEx_Api", "(II[B[B[B)I", "GetCalcRSAEx_Api_IIarrayBarrayBarrayBHandler")]
			public virtual unsafe int CalcRSAEx_Api (int RSAKeyIndex, int pucDataInLen, byte[]? pucDataIn, byte[]? pucDataOut, byte[]? pucKeyInfoOut)
			{
				const string __id = "calcRSAEx_Api.(II[B[B[B)I";
				IntPtr native_pucDataIn = JNIEnv.NewArray (pucDataIn);
				IntPtr native_pucDataOut = JNIEnv.NewArray (pucDataOut);
				IntPtr native_pucKeyInfoOut = JNIEnv.NewArray (pucKeyInfoOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (RSAKeyIndex);
					__args [1] = new JniArgumentValue (pucDataInLen);
					__args [2] = new JniArgumentValue (native_pucDataIn);
					__args [3] = new JniArgumentValue (native_pucDataOut);
					__args [4] = new JniArgumentValue (native_pucKeyInfoOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pucDataIn != null) {
						JNIEnv.CopyArray (native_pucDataIn, pucDataIn);
						JNIEnv.DeleteLocalRef (native_pucDataIn);
					}
					if (pucDataOut != null) {
						JNIEnv.CopyArray (native_pucDataOut, pucDataOut);
						JNIEnv.DeleteLocalRef (native_pucDataOut);
					}
					if (pucKeyInfoOut != null) {
						JNIEnv.CopyArray (native_pucKeyInfoOut, pucKeyInfoOut);
						JNIEnv.DeleteLocalRef (native_pucKeyInfoOut);
					}
					global::System.GC.KeepAlive (pucDataIn);
					global::System.GC.KeepAlive (pucDataOut);
					global::System.GC.KeepAlive (pucKeyInfoOut);
				}
			}

			static Delegate? cb_calcRSAPri_Api_IIIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSAPri_Api_IIIarrayBarrayBHandler ()
			{
				if (cb_calcRSAPri_Api_IIIarrayBarrayB == null)
					cb_calcRSAPri_Api_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILL_I (n_CalcRSAPri_Api_IIIarrayBarrayB));
				return cb_calcRSAPri_Api_IIIarrayBarrayB;
			}

			static int n_CalcRSAPri_Api_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int mode, int privateKeyIndex, int pucDataInLen, IntPtr native_pucDataIn, IntPtr native_pucDataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pucDataIn = (byte[]?) JNIEnv.GetArray (native_pucDataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pucDataOut = (byte[]?) JNIEnv.GetArray (native_pucDataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSAPri_Api (mode, privateKeyIndex, pucDataInLen, pucDataIn, pucDataOut);
				if (pucDataIn != null)
					JNIEnv.CopyArray (pucDataIn, native_pucDataIn);
				if (pucDataOut != null)
					JNIEnv.CopyArray (pucDataOut, native_pucDataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='calcRSAPri_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAPri_Api", "(III[B[B)I", "GetCalcRSAPri_Api_IIIarrayBarrayBHandler")]
			public virtual unsafe int CalcRSAPri_Api (int mode, int privateKeyIndex, int pucDataInLen, byte[]? pucDataIn, byte[]? pucDataOut)
			{
				const string __id = "calcRSAPri_Api.(III[B[B)I";
				IntPtr native_pucDataIn = JNIEnv.NewArray (pucDataIn);
				IntPtr native_pucDataOut = JNIEnv.NewArray (pucDataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (mode);
					__args [1] = new JniArgumentValue (privateKeyIndex);
					__args [2] = new JniArgumentValue (pucDataInLen);
					__args [3] = new JniArgumentValue (native_pucDataIn);
					__args [4] = new JniArgumentValue (native_pucDataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pucDataIn != null) {
						JNIEnv.CopyArray (native_pucDataIn, pucDataIn);
						JNIEnv.DeleteLocalRef (native_pucDataIn);
					}
					if (pucDataOut != null) {
						JNIEnv.CopyArray (native_pucDataOut, pucDataOut);
						JNIEnv.DeleteLocalRef (native_pucDataOut);
					}
					global::System.GC.KeepAlive (pucDataIn);
					global::System.GC.KeepAlive (pucDataOut);
				}
			}

			static Delegate? cb_calcRSAPub_Api_IIIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSAPub_Api_IIIarrayBarrayBHandler ()
			{
				if (cb_calcRSAPub_Api_IIIarrayBarrayB == null)
					cb_calcRSAPub_Api_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILL_I (n_CalcRSAPub_Api_IIIarrayBarrayB));
				return cb_calcRSAPub_Api_IIIarrayBarrayB;
			}

			static int n_CalcRSAPub_Api_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int mode, int publicKeyIndex, int pucDataInLen, IntPtr native_pucDataIn, IntPtr native_pucDataOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pucDataIn = (byte[]?) JNIEnv.GetArray (native_pucDataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pucDataOut = (byte[]?) JNIEnv.GetArray (native_pucDataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSAPub_Api (mode, publicKeyIndex, pucDataInLen, pucDataIn, pucDataOut);
				if (pucDataIn != null)
					JNIEnv.CopyArray (pucDataIn, native_pucDataIn);
				if (pucDataOut != null)
					JNIEnv.CopyArray (pucDataOut, native_pucDataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='calcRSAPub_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAPub_Api", "(III[B[B)I", "GetCalcRSAPub_Api_IIIarrayBarrayBHandler")]
			public virtual unsafe int CalcRSAPub_Api (int mode, int publicKeyIndex, int pucDataInLen, byte[]? pucDataIn, byte[]? pucDataOut)
			{
				const string __id = "calcRSAPub_Api.(III[B[B)I";
				IntPtr native_pucDataIn = JNIEnv.NewArray (pucDataIn);
				IntPtr native_pucDataOut = JNIEnv.NewArray (pucDataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (mode);
					__args [1] = new JniArgumentValue (publicKeyIndex);
					__args [2] = new JniArgumentValue (pucDataInLen);
					__args [3] = new JniArgumentValue (native_pucDataIn);
					__args [4] = new JniArgumentValue (native_pucDataOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pucDataIn != null) {
						JNIEnv.CopyArray (native_pucDataIn, pucDataIn);
						JNIEnv.DeleteLocalRef (native_pucDataIn);
					}
					if (pucDataOut != null) {
						JNIEnv.CopyArray (native_pucDataOut, pucDataOut);
						JNIEnv.DeleteLocalRef (native_pucDataOut);
					}
					global::System.GC.KeepAlive (pucDataIn);
					global::System.GC.KeepAlive (pucDataOut);
				}
			}

			static Delegate? cb_calcRSA_Api_BarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSA_Api_BarrayBarrayBarrayBHandler ()
			{
				if (cb_calcRSA_Api_BarrayBarrayBarrayB == null)
					cb_calcRSA_Api_BarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLLL_I (n_CalcRSA_Api_BarrayBarrayBarrayB));
				return cb_calcRSA_Api_BarrayBarrayBarrayB;
			}

			static int n_CalcRSA_Api_BarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte RSAKeyIndex, IntPtr native_pucDataIn, IntPtr native_pucDataOut, IntPtr native_pucKeyInfoOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pucDataIn = (byte[]?) JNIEnv.GetArray (native_pucDataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pucDataOut = (byte[]?) JNIEnv.GetArray (native_pucDataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pucKeyInfoOut = (byte[]?) JNIEnv.GetArray (native_pucKeyInfoOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSA_Api (RSAKeyIndex, pucDataIn, pucDataOut, pucKeyInfoOut);
				if (pucDataIn != null)
					JNIEnv.CopyArray (pucDataIn, native_pucDataIn);
				if (pucDataOut != null)
					JNIEnv.CopyArray (pucDataOut, native_pucDataOut);
				if (pucKeyInfoOut != null)
					JNIEnv.CopyArray (pucKeyInfoOut, native_pucKeyInfoOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='calcRSA_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("calcRSA_Api", "(B[B[B[B)I", "GetCalcRSA_Api_BarrayBarrayBarrayBHandler")]
			public virtual unsafe int CalcRSA_Api (sbyte RSAKeyIndex, byte[]? pucDataIn, byte[]? pucDataOut, byte[]? pucKeyInfoOut)
			{
				const string __id = "calcRSA_Api.(B[B[B[B)I";
				IntPtr native_pucDataIn = JNIEnv.NewArray (pucDataIn);
				IntPtr native_pucDataOut = JNIEnv.NewArray (pucDataOut);
				IntPtr native_pucKeyInfoOut = JNIEnv.NewArray (pucKeyInfoOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (RSAKeyIndex);
					__args [1] = new JniArgumentValue (native_pucDataIn);
					__args [2] = new JniArgumentValue (native_pucDataOut);
					__args [3] = new JniArgumentValue (native_pucKeyInfoOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pucDataIn != null) {
						JNIEnv.CopyArray (native_pucDataIn, pucDataIn);
						JNIEnv.DeleteLocalRef (native_pucDataIn);
					}
					if (pucDataOut != null) {
						JNIEnv.CopyArray (native_pucDataOut, pucDataOut);
						JNIEnv.DeleteLocalRef (native_pucDataOut);
					}
					if (pucKeyInfoOut != null) {
						JNIEnv.CopyArray (native_pucKeyInfoOut, pucKeyInfoOut);
						JNIEnv.DeleteLocalRef (native_pucKeyInfoOut);
					}
					global::System.GC.KeepAlive (pucDataIn);
					global::System.GC.KeepAlive (pucDataOut);
					global::System.GC.KeepAlive (pucKeyInfoOut);
				}
			}

			static Delegate? cb_getAesDukptKsn_BarrayB;
#pragma warning disable 0169
			static Delegate GetGetAesDukptKsn_BarrayBHandler ()
			{
				if (cb_getAesDukptKsn_BarrayB == null)
					cb_getAesDukptKsn_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_GetAesDukptKsn_BarrayB));
				return cb_getAesDukptKsn_BarrayB;
			}

			static int n_GetAesDukptKsn_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte groupIdx, IntPtr native_ksnOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ksnOut = (byte[]?) JNIEnv.GetArray (native_ksnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetAesDukptKsn (groupIdx, ksnOut);
				if (ksnOut != null)
					JNIEnv.CopyArray (ksnOut, native_ksnOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='getAesDukptKsn' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("getAesDukptKsn", "(B[B)I", "GetGetAesDukptKsn_BarrayBHandler")]
			public virtual unsafe int GetAesDukptKsn (sbyte groupIdx, byte[]? ksnOut)
			{
				const string __id = "getAesDukptKsn.(B[B)I";
				IntPtr native_ksnOut = JNIEnv.NewArray (ksnOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (groupIdx);
					__args [1] = new JniArgumentValue (native_ksnOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ksnOut != null) {
						JNIEnv.CopyArray (native_ksnOut, ksnOut);
						JNIEnv.DeleteLocalRef (native_ksnOut);
					}
					global::System.GC.KeepAlive (ksnOut);
				}
			}

			static Delegate? cb_getKeyPairHdOrSoftg_IarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetKeyPairHdOrSoftg_IarrayBarrayBHandler ()
			{
				if (cb_getKeyPairHdOrSoftg_IarrayBarrayB == null)
					cb_getKeyPairHdOrSoftg_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_GetKeyPairHdOrSoftg_IarrayBarrayB));
				return cb_getKeyPairHdOrSoftg_IarrayBarrayB;
			}

			static int n_GetKeyPairHdOrSoftg_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int keysize, IntPtr native_PrivateKeyOut, IntPtr native_publicKeyOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var PrivateKeyOut = (byte[]?) JNIEnv.GetArray (native_PrivateKeyOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var publicKeyOut = (byte[]?) JNIEnv.GetArray (native_publicKeyOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetKeyPairHdOrSoftg (keysize, PrivateKeyOut, publicKeyOut);
				if (PrivateKeyOut != null)
					JNIEnv.CopyArray (PrivateKeyOut, native_PrivateKeyOut);
				if (publicKeyOut != null)
					JNIEnv.CopyArray (publicKeyOut, native_publicKeyOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='getKeyPairHdOrSoftg' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("getKeyPairHdOrSoftg", "(I[B[B)I", "GetGetKeyPairHdOrSoftg_IarrayBarrayBHandler")]
			public virtual unsafe int GetKeyPairHdOrSoftg (int keysize, byte[]? PrivateKeyOut, byte[]? publicKeyOut)
			{
				const string __id = "getKeyPairHdOrSoftg.(I[B[B)I";
				IntPtr native_PrivateKeyOut = JNIEnv.NewArray (PrivateKeyOut);
				IntPtr native_publicKeyOut = JNIEnv.NewArray (publicKeyOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (keysize);
					__args [1] = new JniArgumentValue (native_PrivateKeyOut);
					__args [2] = new JniArgumentValue (native_publicKeyOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (PrivateKeyOut != null) {
						JNIEnv.CopyArray (native_PrivateKeyOut, PrivateKeyOut);
						JNIEnv.DeleteLocalRef (native_PrivateKeyOut);
					}
					if (publicKeyOut != null) {
						JNIEnv.CopyArray (native_publicKeyOut, publicKeyOut);
						JNIEnv.DeleteLocalRef (native_publicKeyOut);
					}
					global::System.GC.KeepAlive (PrivateKeyOut);
					global::System.GC.KeepAlive (publicKeyOut);
				}
			}

			static Delegate? cb_getMacAesDukpt_BIBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetMacAesDukpt_BIBarrayBarrayBarrayBHandler ()
			{
				if (cb_getMacAesDukpt_BIBarrayBarrayBarrayB == null)
					cb_getMacAesDukpt_BIBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBIBLLL_I (n_GetMacAesDukpt_BIBarrayBarrayBarrayB));
				return cb_getMacAesDukpt_BIBarrayBarrayBarrayB;
			}

			static int n_GetMacAesDukpt_BIBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte groupIdx, int dataInLen, sbyte mode, IntPtr native_dataIn, IntPtr native_ksnOut, IntPtr native_macOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var dataIn = (byte[]?) JNIEnv.GetArray (native_dataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var ksnOut = (byte[]?) JNIEnv.GetArray (native_ksnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var macOut = (byte[]?) JNIEnv.GetArray (native_macOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetMacAesDukpt (groupIdx, dataInLen, mode, dataIn, ksnOut, macOut);
				if (dataIn != null)
					JNIEnv.CopyArray (dataIn, native_dataIn);
				if (ksnOut != null)
					JNIEnv.CopyArray (ksnOut, native_ksnOut);
				if (macOut != null)
					JNIEnv.CopyArray (macOut, native_macOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='getMacAesDukpt' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("getMacAesDukpt", "(BIB[B[B[B)I", "GetGetMacAesDukpt_BIBarrayBarrayBarrayBHandler")]
			public virtual unsafe int GetMacAesDukpt (sbyte groupIdx, int dataInLen, sbyte mode, byte[]? dataIn, byte[]? ksnOut, byte[]? macOut)
			{
				const string __id = "getMacAesDukpt.(BIB[B[B[B)I";
				IntPtr native_dataIn = JNIEnv.NewArray (dataIn);
				IntPtr native_ksnOut = JNIEnv.NewArray (ksnOut);
				IntPtr native_macOut = JNIEnv.NewArray (macOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (groupIdx);
					__args [1] = new JniArgumentValue (dataInLen);
					__args [2] = new JniArgumentValue (mode);
					__args [3] = new JniArgumentValue (native_dataIn);
					__args [4] = new JniArgumentValue (native_ksnOut);
					__args [5] = new JniArgumentValue (native_macOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (dataIn != null) {
						JNIEnv.CopyArray (native_dataIn, dataIn);
						JNIEnv.DeleteLocalRef (native_dataIn);
					}
					if (ksnOut != null) {
						JNIEnv.CopyArray (native_ksnOut, ksnOut);
						JNIEnv.DeleteLocalRef (native_ksnOut);
					}
					if (macOut != null) {
						JNIEnv.CopyArray (native_macOut, macOut);
						JNIEnv.DeleteLocalRef (native_macOut);
					}
					global::System.GC.KeepAlive (dataIn);
					global::System.GC.KeepAlive (ksnOut);
					global::System.GC.KeepAlive (macOut);
				}
			}

			static Delegate? cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetPinAESDukptEx_BBBarrayBarrayBarrayBarrayBHandler ()
			{
				if (cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB == null)
					cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLLL_I (n_GetPinAESDukptEx_BBBarrayBarrayBarrayBarrayB));
				return cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB;
			}

			static int n_GetPinAESDukptEx_BBBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte groupIdx, sbyte mode, sbyte pinLen, IntPtr native_plainPin, IntPtr native_dataIn, IntPtr native_ksnOut, IntPtr native_pinBlock)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var plainPin = (byte[]?) JNIEnv.GetArray (native_plainPin, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var dataIn = (byte[]?) JNIEnv.GetArray (native_dataIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var ksnOut = (byte[]?) JNIEnv.GetArray (native_ksnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var pinBlock = (byte[]?) JNIEnv.GetArray (native_pinBlock, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetPinAESDukptEx (groupIdx, mode, pinLen, plainPin, dataIn, ksnOut, pinBlock);
				if (plainPin != null)
					JNIEnv.CopyArray (plainPin, native_plainPin);
				if (dataIn != null)
					JNIEnv.CopyArray (dataIn, native_dataIn);
				if (ksnOut != null)
					JNIEnv.CopyArray (ksnOut, native_ksnOut);
				if (pinBlock != null)
					JNIEnv.CopyArray (pinBlock, native_pinBlock);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='getPinAESDukptEx' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
			[Register ("getPinAESDukptEx", "(BBB[B[B[B[B)I", "GetGetPinAESDukptEx_BBBarrayBarrayBarrayBarrayBHandler")]
			public virtual unsafe int GetPinAESDukptEx (sbyte groupIdx, sbyte mode, sbyte pinLen, byte[]? plainPin, byte[]? dataIn, byte[]? ksnOut, byte[]? pinBlock)
			{
				const string __id = "getPinAESDukptEx.(BBB[B[B[B[B)I";
				IntPtr native_plainPin = JNIEnv.NewArray (plainPin);
				IntPtr native_dataIn = JNIEnv.NewArray (dataIn);
				IntPtr native_ksnOut = JNIEnv.NewArray (ksnOut);
				IntPtr native_pinBlock = JNIEnv.NewArray (pinBlock);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (groupIdx);
					__args [1] = new JniArgumentValue (mode);
					__args [2] = new JniArgumentValue (pinLen);
					__args [3] = new JniArgumentValue (native_plainPin);
					__args [4] = new JniArgumentValue (native_dataIn);
					__args [5] = new JniArgumentValue (native_ksnOut);
					__args [6] = new JniArgumentValue (native_pinBlock);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (plainPin != null) {
						JNIEnv.CopyArray (native_plainPin, plainPin);
						JNIEnv.DeleteLocalRef (native_plainPin);
					}
					if (dataIn != null) {
						JNIEnv.CopyArray (native_dataIn, dataIn);
						JNIEnv.DeleteLocalRef (native_dataIn);
					}
					if (ksnOut != null) {
						JNIEnv.CopyArray (native_ksnOut, ksnOut);
						JNIEnv.DeleteLocalRef (native_ksnOut);
					}
					if (pinBlock != null) {
						JNIEnv.CopyArray (native_pinBlock, pinBlock);
						JNIEnv.DeleteLocalRef (native_pinBlock);
					}
					global::System.GC.KeepAlive (plainPin);
					global::System.GC.KeepAlive (dataIn);
					global::System.GC.KeepAlive (ksnOut);
					global::System.GC.KeepAlive (pinBlock);
				}
			}

			static Delegate? cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayBHandler ()
			{
				if (cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB == null)
					cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLLL_I (n_GetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB));
				return cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB;
			}

			static int n_GetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte GroupIdx, sbyte mode, IntPtr native_pin, IntPtr native_data, IntPtr native_pinBlockOut, IntPtr native_ksnOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pin = JNIEnv.GetString (native_pin, JniHandleOwnership.DoNotTransfer);
				var data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
				var pinBlockOut = (byte[]?) JNIEnv.GetArray (native_pinBlockOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var ksnOut = (byte[]?) JNIEnv.GetArray (native_ksnOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetPinDukptEx_Api (GroupIdx, mode, pin, data, pinBlockOut, ksnOut);
				if (pinBlockOut != null)
					JNIEnv.CopyArray (pinBlockOut, native_pinBlockOut);
				if (ksnOut != null)
					JNIEnv.CopyArray (ksnOut, native_ksnOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='getPinDukptEx_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("getPinDukptEx_Api", "(BBLjava/lang/String;Ljava/lang/String;[B[B)I", "GetGetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayBHandler")]
			public virtual unsafe int GetPinDukptEx_Api (sbyte GroupIdx, sbyte mode, string? pin, string? data, byte[]? pinBlockOut, byte[]? ksnOut)
			{
				const string __id = "getPinDukptEx_Api.(BBLjava/lang/String;Ljava/lang/String;[B[B)I";
				IntPtr native_pin = JNIEnv.NewString ((string?)pin);
				IntPtr native_data = JNIEnv.NewString ((string?)data);
				IntPtr native_pinBlockOut = JNIEnv.NewArray (pinBlockOut);
				IntPtr native_ksnOut = JNIEnv.NewArray (ksnOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (GroupIdx);
					__args [1] = new JniArgumentValue (mode);
					__args [2] = new JniArgumentValue (native_pin);
					__args [3] = new JniArgumentValue (native_data);
					__args [4] = new JniArgumentValue (native_pinBlockOut);
					__args [5] = new JniArgumentValue (native_ksnOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_pin);
					JNIEnv.DeleteLocalRef (native_data);
					if (pinBlockOut != null) {
						JNIEnv.CopyArray (native_pinBlockOut, pinBlockOut);
						JNIEnv.DeleteLocalRef (native_pinBlockOut);
					}
					if (ksnOut != null) {
						JNIEnv.CopyArray (native_ksnOut, ksnOut);
						JNIEnv.DeleteLocalRef (native_ksnOut);
					}
					global::System.GC.KeepAlive (pinBlockOut);
					global::System.GC.KeepAlive (ksnOut);
				}
			}

			static Delegate? cb_getRSAKeyPair_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetGetRSAKeyPair_Api_IIIarrayBHandler ()
			{
				if (cb_getRSAKeyPair_Api_IIIarrayB == null)
					cb_getRSAKeyPair_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_GetRSAKeyPair_Api_IIIarrayB));
				return cb_getRSAKeyPair_Api_IIIarrayB;
			}

			static int n_GetRSAKeyPair_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int publicKeyIndex, int privateKeyIndex, int keyModulusLen, IntPtr native_publicModulusData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var publicModulusData = (byte[]?) JNIEnv.GetArray (native_publicModulusData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetRSAKeyPair_Api (publicKeyIndex, privateKeyIndex, keyModulusLen, publicModulusData);
				if (publicModulusData != null)
					JNIEnv.CopyArray (publicModulusData, native_publicModulusData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='getRSAKeyPair_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("getRSAKeyPair_Api", "(III[B)I", "GetGetRSAKeyPair_Api_IIIarrayBHandler")]
			public virtual unsafe int GetRSAKeyPair_Api (int publicKeyIndex, int privateKeyIndex, int keyModulusLen, byte[]? publicModulusData)
			{
				const string __id = "getRSAKeyPair_Api.(III[B)I";
				IntPtr native_publicModulusData = JNIEnv.NewArray (publicModulusData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (publicKeyIndex);
					__args [1] = new JniArgumentValue (privateKeyIndex);
					__args [2] = new JniArgumentValue (keyModulusLen);
					__args [3] = new JniArgumentValue (native_publicModulusData);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (publicModulusData != null) {
						JNIEnv.CopyArray (native_publicModulusData, publicModulusData);
						JNIEnv.DeleteLocalRef (native_publicModulusData);
					}
					global::System.GC.KeepAlive (publicModulusData);
				}
			}

			static Delegate? cb_isKeyExist_Api_II;
#pragma warning disable 0169
			static Delegate GetIsKeyExist_Api_IIHandler ()
			{
				if (cb_isKeyExist_Api_II == null)
					cb_isKeyExist_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_IsKeyExist_Api_II));
				return cb_isKeyExist_Api_II;
			}

			static bool n_IsKeyExist_Api_II (IntPtr jnienv, IntPtr native__this, int keyType, int keyIndex)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsKeyExist_Api (keyType, keyIndex);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='isKeyExist_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("isKeyExist_Api", "(II)Z", "GetIsKeyExist_Api_IIHandler")]
			public virtual unsafe bool IsKeyExist_Api (int keyType, int keyIndex)
			{
				const string __id = "isKeyExist_Api.(II)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (keyType);
					__args [1] = new JniArgumentValue (keyIndex);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_setAmountColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAmountColor_Ljava_lang_String_Handler ()
			{
				if (cb_setAmountColor_Ljava_lang_String_ == null)
					cb_setAmountColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAmountColor_Ljava_lang_String_));
				return cb_setAmountColor_Ljava_lang_String_;
			}

			static void n_SetAmountColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_amountColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var amountColor = JNIEnv.GetString (native_amountColor, JniHandleOwnership.DoNotTransfer);
				__this.SetAmountColor (amountColor);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setAmountColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountColor", "(Ljava/lang/String;)V", "GetSetAmountColor_Ljava_lang_String_Handler")]
			public virtual unsafe void SetAmountColor (string? amountColor)
			{
				const string __id = "setAmountColor.(Ljava/lang/String;)V";
				IntPtr native_amountColor = JNIEnv.NewString ((string?)amountColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_amountColor);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_amountColor);
				}
			}

			static Delegate? cb_setAmountFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAmountFont_Ljava_lang_String_Handler ()
			{
				if (cb_setAmountFont_Ljava_lang_String_ == null)
					cb_setAmountFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAmountFont_Ljava_lang_String_));
				return cb_setAmountFont_Ljava_lang_String_;
			}

			static void n_SetAmountFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_amountFont)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var amountFont = JNIEnv.GetString (native_amountFont, JniHandleOwnership.DoNotTransfer);
				__this.SetAmountFont (amountFont);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setAmountFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountFont", "(Ljava/lang/String;)V", "GetSetAmountFont_Ljava_lang_String_Handler")]
			public virtual unsafe void SetAmountFont (string? amountFont)
			{
				const string __id = "setAmountFont.(Ljava/lang/String;)V";
				IntPtr native_amountFont = JNIEnv.NewString ((string?)amountFont);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_amountFont);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_amountFont);
				}
			}

			static Delegate? cb_setAmountSize_F;
#pragma warning disable 0169
			static Delegate GetSetAmountSize_FHandler ()
			{
				if (cb_setAmountSize_F == null)
					cb_setAmountSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetAmountSize_F));
				return cb_setAmountSize_F;
			}

			static void n_SetAmountSize_F (IntPtr jnienv, IntPtr native__this, float amountSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetAmountSize (amountSize);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setAmountSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAmountSize", "(F)V", "GetSetAmountSize_FHandler")]
			public virtual unsafe void SetAmountSize (float amountSize)
			{
				const string __id = "setAmountSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (amountSize);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setBottomBtnText_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBottomBtnText_arrayLjava_lang_String_Handler ()
			{
				if (cb_setBottomBtnText_arrayLjava_lang_String_ == null)
					cb_setBottomBtnText_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomBtnText_arrayLjava_lang_String_));
				return cb_setBottomBtnText_arrayLjava_lang_String_;
			}

			static void n_SetBottomBtnText_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var array = (string[]?) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (string));
				__this.SetBottomBtnText (array);
				if (array != null)
					JNIEnv.CopyArray (array, native_array);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setBottomBtnText' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("setBottomBtnText", "([Ljava/lang/String;)V", "GetSetBottomBtnText_arrayLjava_lang_String_Handler")]
			public virtual unsafe void SetBottomBtnText (string[]? array)
			{
				const string __id = "setBottomBtnText.([Ljava/lang/String;)V";
				IntPtr native_array = JNIEnv.NewArray (array);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_array);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (array != null) {
						JNIEnv.CopyArray (native_array, array);
						JNIEnv.DeleteLocalRef (native_array);
					}
					global::System.GC.KeepAlive (array);
				}
			}

			static Delegate? cb_setBottomFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBottomFont_Ljava_lang_String_Handler ()
			{
				if (cb_setBottomFont_Ljava_lang_String_ == null)
					cb_setBottomFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomFont_Ljava_lang_String_));
				return cb_setBottomFont_Ljava_lang_String_;
			}

			static void n_SetBottomFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomFont)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bottomFont = JNIEnv.GetString (native_bottomFont, JniHandleOwnership.DoNotTransfer);
				__this.SetBottomFont (bottomFont);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setBottomFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBottomFont", "(Ljava/lang/String;)V", "GetSetBottomFont_Ljava_lang_String_Handler")]
			public virtual unsafe void SetBottomFont (string? bottomFont)
			{
				const string __id = "setBottomFont.(Ljava/lang/String;)V";
				IntPtr native_bottomFont = JNIEnv.NewString ((string?)bottomFont);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_bottomFont);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_bottomFont);
				}
			}

			static Delegate? cb_setBottomTextColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBottomTextColor_Ljava_lang_String_Handler ()
			{
				if (cb_setBottomTextColor_Ljava_lang_String_ == null)
					cb_setBottomTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomTextColor_Ljava_lang_String_));
				return cb_setBottomTextColor_Ljava_lang_String_;
			}

			static void n_SetBottomTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomTextColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bottomTextColor = JNIEnv.GetString (native_bottomTextColor, JniHandleOwnership.DoNotTransfer);
				__this.SetBottomTextColor (bottomTextColor);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setBottomTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBottomTextColor", "(Ljava/lang/String;)V", "GetSetBottomTextColor_Ljava_lang_String_Handler")]
			public virtual unsafe void SetBottomTextColor (string? bottomTextColor)
			{
				const string __id = "setBottomTextColor.(Ljava/lang/String;)V";
				IntPtr native_bottomTextColor = JNIEnv.NewString ((string?)bottomTextColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_bottomTextColor);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_bottomTextColor);
				}
			}

			static Delegate? cb_setBottomTextSize_F;
#pragma warning disable 0169
			static Delegate GetSetBottomTextSize_FHandler ()
			{
				if (cb_setBottomTextSize_F == null)
					cb_setBottomTextSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetBottomTextSize_F));
				return cb_setBottomTextSize_F;
			}

			static void n_SetBottomTextSize_F (IntPtr jnienv, IntPtr native__this, float bottomTextSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetBottomTextSize (bottomTextSize);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setBottomTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBottomTextSize", "(F)V", "GetSetBottomTextSize_FHandler")]
			public virtual unsafe void SetBottomTextSize (float bottomTextSize)
			{
				const string __id = "setBottomTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bottomTextSize);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setCardNo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCardNo_Ljava_lang_String_Handler ()
			{
				if (cb_setCardNo_Ljava_lang_String_ == null)
					cb_setCardNo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCardNo_Ljava_lang_String_));
				return cb_setCardNo_Ljava_lang_String_;
			}

			static void n_SetCardNo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardNo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var cardNo = JNIEnv.GetString (native_cardNo, JniHandleOwnership.DoNotTransfer);
				__this.SetCardNo (cardNo);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setCardNo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardNo", "(Ljava/lang/String;)V", "GetSetCardNo_Ljava_lang_String_Handler")]
			public virtual unsafe void SetCardNo (string? cardNo)
			{
				const string __id = "setCardNo.(Ljava/lang/String;)V";
				IntPtr native_cardNo = JNIEnv.NewString ((string?)cardNo);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cardNo);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_cardNo);
				}
			}

			static Delegate? cb_setDispAmt_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDispAmt_Ljava_lang_String_Handler ()
			{
				if (cb_setDispAmt_Ljava_lang_String_ == null)
					cb_setDispAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetDispAmt_Ljava_lang_String_));
				return cb_setDispAmt_Ljava_lang_String_;
			}

			static void n_SetDispAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disAmt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var disAmt = JNIEnv.GetString (native_disAmt, JniHandleOwnership.DoNotTransfer);
				__this.SetDispAmt (disAmt);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setDispAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDispAmt", "(Ljava/lang/String;)V", "GetSetDispAmt_Ljava_lang_String_Handler")]
			public virtual unsafe void SetDispAmt (string? disAmt)
			{
				const string __id = "setDispAmt.(Ljava/lang/String;)V";
				IntPtr native_disAmt = JNIEnv.NewString ((string?)disAmt);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_disAmt);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_disAmt);
				}
			}

			static Delegate? cb_setNumColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNumColor_Ljava_lang_String_Handler ()
			{
				if (cb_setNumColor_Ljava_lang_String_ == null)
					cb_setNumColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNumColor_Ljava_lang_String_));
				return cb_setNumColor_Ljava_lang_String_;
			}

			static void n_SetNumColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_numColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var numColor = JNIEnv.GetString (native_numColor, JniHandleOwnership.DoNotTransfer);
				__this.SetNumColor (numColor);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setNumColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNumColor", "(Ljava/lang/String;)V", "GetSetNumColor_Ljava_lang_String_Handler")]
			public virtual unsafe void SetNumColor (string? numColor)
			{
				const string __id = "setNumColor.(Ljava/lang/String;)V";
				IntPtr native_numColor = JNIEnv.NewString ((string?)numColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_numColor);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_numColor);
				}
			}

			static Delegate? cb_setNumFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNumFont_Ljava_lang_String_Handler ()
			{
				if (cb_setNumFont_Ljava_lang_String_ == null)
					cb_setNumFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNumFont_Ljava_lang_String_));
				return cb_setNumFont_Ljava_lang_String_;
			}

			static void n_SetNumFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_numFont)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var numFont = JNIEnv.GetString (native_numFont, JniHandleOwnership.DoNotTransfer);
				__this.SetNumFont (numFont);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setNumFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNumFont", "(Ljava/lang/String;)V", "GetSetNumFont_Ljava_lang_String_Handler")]
			public virtual unsafe void SetNumFont (string? numFont)
			{
				const string __id = "setNumFont.(Ljava/lang/String;)V";
				IntPtr native_numFont = JNIEnv.NewString ((string?)numFont);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_numFont);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_numFont);
				}
			}

			static Delegate? cb_setNumSize_F;
#pragma warning disable 0169
			static Delegate GetSetNumSize_FHandler ()
			{
				if (cb_setNumSize_F == null)
					cb_setNumSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetNumSize_F));
				return cb_setNumSize_F;
			}

			static void n_SetNumSize_F (IntPtr jnienv, IntPtr native__this, float numSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetNumSize (numSize);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setNumSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setNumSize", "(F)V", "GetSetNumSize_FHandler")]
			public virtual unsafe void SetNumSize (float numSize)
			{
				const string __id = "setNumSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (numSize);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setPinBoardFixed_Z;
#pragma warning disable 0169
			static Delegate GetSetPinBoardFixed_ZHandler ()
			{
				if (cb_setPinBoardFixed_Z == null)
					cb_setPinBoardFixed_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetPinBoardFixed_Z));
				return cb_setPinBoardFixed_Z;
			}

			static void n_SetPinBoardFixed_Z (IntPtr jnienv, IntPtr native__this, bool @fixed)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetPinBoardFixed (@fixed);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setPinBoardFixed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPinBoardFixed", "(Z)V", "GetSetPinBoardFixed_ZHandler")]
			public virtual unsafe void SetPinBoardFixed (bool @fixed)
			{
				const string __id = "setPinBoardFixed.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (@fixed);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setPinBoardKey_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetPinBoardKey_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_setPinBoardKey_Api_Landroid_os_Bundle_ == null)
					cb_setPinBoardKey_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetPinBoardKey_Api_Landroid_os_Bundle_));
				return cb_setPinBoardKey_Api_Landroid_os_Bundle_;
			}

			static int n_SetPinBoardKey_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_Bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var Bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_Bundle, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetPinBoardKey_Api (Bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setPinBoardKey_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardKey_Api", "(Landroid/os/Bundle;)I", "GetSetPinBoardKey_Api_Landroid_os_Bundle_Handler")]
			public virtual unsafe int SetPinBoardKey_Api (global::Android.OS.Bundle? Bundle)
			{
				const string __id = "setPinBoardKey_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((Bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (Bundle);
				}
			}

			static Delegate? cb_setPinBoardMsg_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetPinBoardMsg_Landroid_os_Bundle_Handler ()
			{
				if (cb_setPinBoardMsg_Landroid_os_Bundle_ == null)
					cb_setPinBoardMsg_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPinBoardMsg_Landroid_os_Bundle_));
				return cb_setPinBoardMsg_Landroid_os_Bundle_;
			}

			static void n_SetPinBoardMsg_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				__this.SetPinBoardMsg (bundle);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setPinBoardMsg' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardMsg", "(Landroid/os/Bundle;)V", "GetSetPinBoardMsg_Landroid_os_Bundle_Handler")]
			public virtual unsafe void SetPinBoardMsg (global::Android.OS.Bundle? bundle)
			{
				const string __id = "setPinBoardMsg.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_setPinBoardSetting_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetPinBoardSetting_Landroid_os_Bundle_Handler ()
			{
				if (cb_setPinBoardSetting_Landroid_os_Bundle_ == null)
					cb_setPinBoardSetting_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPinBoardSetting_Landroid_os_Bundle_));
				return cb_setPinBoardSetting_Landroid_os_Bundle_;
			}

			static void n_SetPinBoardSetting_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				__this.SetPinBoardSetting (bundle);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setPinBoardSetting' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardSetting", "(Landroid/os/Bundle;)V", "GetSetPinBoardSetting_Landroid_os_Bundle_Handler")]
			public virtual unsafe void SetPinBoardSetting (global::Android.OS.Bundle? bundle)
			{
				const string __id = "setPinBoardSetting.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_setPinBoardStyle_I;
#pragma warning disable 0169
			static Delegate GetSetPinBoardStyle_IHandler ()
			{
				if (cb_setPinBoardStyle_I == null)
					cb_setPinBoardStyle_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetPinBoardStyle_I));
				return cb_setPinBoardStyle_I;
			}

			static void n_SetPinBoardStyle_I (IntPtr jnienv, IntPtr native__this, int PinBoardType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetPinBoardStyle (PinBoardType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setPinBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPinBoardStyle", "(I)V", "GetSetPinBoardStyle_IHandler")]
			public virtual unsafe void SetPinBoardStyle (int PinBoardType)
			{
				const string __id = "setPinBoardStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (PinBoardType);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setStatusbarColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetStatusbarColor_Ljava_lang_String_Handler ()
			{
				if (cb_setStatusbarColor_Ljava_lang_String_ == null)
					cb_setStatusbarColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetStatusbarColor_Ljava_lang_String_));
				return cb_setStatusbarColor_Ljava_lang_String_;
			}

			static void n_SetStatusbarColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_statusbarColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var statusbarColor = JNIEnv.GetString (native_statusbarColor, JniHandleOwnership.DoNotTransfer);
				__this.SetStatusbarColor (statusbarColor);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setStatusbarColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusbarColor", "(Ljava/lang/String;)V", "GetSetStatusbarColor_Ljava_lang_String_Handler")]
			public virtual unsafe void SetStatusbarColor (string? statusbarColor)
			{
				const string __id = "setStatusbarColor.(Ljava/lang/String;)V";
				IntPtr native_statusbarColor = JNIEnv.NewString ((string?)statusbarColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_statusbarColor);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_statusbarColor);
				}
			}

			static Delegate? cb_setStatusbarHide_Z;
#pragma warning disable 0169
			static Delegate GetSetStatusbarHide_ZHandler ()
			{
				if (cb_setStatusbarHide_Z == null)
					cb_setStatusbarHide_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetStatusbarHide_Z));
				return cb_setStatusbarHide_Z;
			}

			static void n_SetStatusbarHide_Z (IntPtr jnienv, IntPtr native__this, bool isHide)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetStatusbarHide (isHide);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setStatusbarHide' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStatusbarHide", "(Z)V", "GetSetStatusbarHide_ZHandler")]
			public virtual unsafe void SetStatusbarHide (bool isHide)
			{
				const string __id = "setStatusbarHide.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isHide);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setTextColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTextColor_Ljava_lang_String_Handler ()
			{
				if (cb_setTextColor_Ljava_lang_String_ == null)
					cb_setTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTextColor_Ljava_lang_String_));
				return cb_setTextColor_Ljava_lang_String_;
			}

			static void n_SetTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var textColor = JNIEnv.GetString (native_textColor, JniHandleOwnership.DoNotTransfer);
				__this.SetTextColor (textColor);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextColor", "(Ljava/lang/String;)V", "GetSetTextColor_Ljava_lang_String_Handler")]
			public virtual unsafe void SetTextColor (string? textColor)
			{
				const string __id = "setTextColor.(Ljava/lang/String;)V";
				IntPtr native_textColor = JNIEnv.NewString ((string?)textColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_textColor);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_textColor);
				}
			}

			static Delegate? cb_setTextFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTextFont_Ljava_lang_String_Handler ()
			{
				if (cb_setTextFont_Ljava_lang_String_ == null)
					cb_setTextFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTextFont_Ljava_lang_String_));
				return cb_setTextFont_Ljava_lang_String_;
			}

			static void n_SetTextFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textFont)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var textFont = JNIEnv.GetString (native_textFont, JniHandleOwnership.DoNotTransfer);
				__this.SetTextFont (textFont);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setTextFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextFont", "(Ljava/lang/String;)V", "GetSetTextFont_Ljava_lang_String_Handler")]
			public virtual unsafe void SetTextFont (string? textFont)
			{
				const string __id = "setTextFont.(Ljava/lang/String;)V";
				IntPtr native_textFont = JNIEnv.NewString ((string?)textFont);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_textFont);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_textFont);
				}
			}

			static Delegate? cb_setTextSize_F;
#pragma warning disable 0169
			static Delegate GetSetTextSize_FHandler ()
			{
				if (cb_setTextSize_F == null)
					cb_setTextSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetTextSize_F));
				return cb_setTextSize_F;
			}

			static void n_SetTextSize_F (IntPtr jnienv, IntPtr native__this, float textSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetTextSize (textSize);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTextSize", "(F)V", "GetSetTextSize_FHandler")]
			public virtual unsafe void SetTextSize (float textSize)
			{
				const string __id = "setTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (textSize);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setTitleBackGroundColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTitleBackGroundColor_Ljava_lang_String_Handler ()
			{
				if (cb_setTitleBackGroundColor_Ljava_lang_String_ == null)
					cb_setTitleBackGroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTitleBackGroundColor_Ljava_lang_String_));
				return cb_setTitleBackGroundColor_Ljava_lang_String_;
			}

			static void n_SetTitleBackGroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_titleBackGroundColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var titleBackGroundColor = JNIEnv.GetString (native_titleBackGroundColor, JniHandleOwnership.DoNotTransfer);
				__this.SetTitleBackGroundColor (titleBackGroundColor);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='setTitleBackGroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitleBackGroundColor", "(Ljava/lang/String;)V", "GetSetTitleBackGroundColor_Ljava_lang_String_Handler")]
			public virtual unsafe void SetTitleBackGroundColor (string? titleBackGroundColor)
			{
				const string __id = "setTitleBackGroundColor.(Ljava/lang/String;)V";
				IntPtr native_titleBackGroundColor = JNIEnv.NewString ((string?)titleBackGroundColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_titleBackGroundColor);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_titleBackGroundColor);
				}
			}

			static Delegate? cb_writeAesKey_BIBIBarrayBBBarrayB;
#pragma warning disable 0169
			static Delegate GetWriteAesKey_BIBIBarrayBBBarrayBHandler ()
			{
				if (cb_writeAesKey_BIBIBarrayBBBarrayB == null)
					cb_writeAesKey_BIBIBarrayBBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBIBIBLBBL_I (n_WriteAesKey_BIBIBarrayBBBarrayB));
				return cb_writeAesKey_BIBIBarrayBBBarrayB;
			}

			static int n_WriteAesKey_BIBIBarrayBBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte ucSrcKeyType, int ucSrcKeyIdx, sbyte ucDstKeyType, int ucDstKeyIdx, sbyte iDstKeyLen, IntPtr native_aucDstKeyValue, sbyte ucMode, sbyte iCheckMode, IntPtr native_aucCheckBuf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aucDstKeyValue = (byte[]?) JNIEnv.GetArray (native_aucDstKeyValue, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var aucCheckBuf = (byte[]?) JNIEnv.GetArray (native_aucCheckBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteAesKey (ucSrcKeyType, ucSrcKeyIdx, ucDstKeyType, ucDstKeyIdx, iDstKeyLen, aucDstKeyValue, ucMode, iCheckMode, aucCheckBuf);
				if (aucDstKeyValue != null)
					JNIEnv.CopyArray (aucDstKeyValue, native_aucDstKeyValue);
				if (aucCheckBuf != null)
					JNIEnv.CopyArray (aucCheckBuf, native_aucCheckBuf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='writeAesKey' and count(parameter)=9 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte'] and parameter[8][@type='byte'] and parameter[9][@type='byte[]']]"
			[Register ("writeAesKey", "(BIBIB[BBB[B)I", "GetWriteAesKey_BIBIBarrayBBBarrayBHandler")]
			public virtual unsafe int WriteAesKey (sbyte ucSrcKeyType, int ucSrcKeyIdx, sbyte ucDstKeyType, int ucDstKeyIdx, sbyte iDstKeyLen, byte[]? aucDstKeyValue, sbyte ucMode, sbyte iCheckMode, byte[]? aucCheckBuf)
			{
				const string __id = "writeAesKey.(BIBIB[BBB[B)I";
				IntPtr native_aucDstKeyValue = JNIEnv.NewArray (aucDstKeyValue);
				IntPtr native_aucCheckBuf = JNIEnv.NewArray (aucCheckBuf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [9];
					__args [0] = new JniArgumentValue (ucSrcKeyType);
					__args [1] = new JniArgumentValue (ucSrcKeyIdx);
					__args [2] = new JniArgumentValue (ucDstKeyType);
					__args [3] = new JniArgumentValue (ucDstKeyIdx);
					__args [4] = new JniArgumentValue (iDstKeyLen);
					__args [5] = new JniArgumentValue (native_aucDstKeyValue);
					__args [6] = new JniArgumentValue (ucMode);
					__args [7] = new JniArgumentValue (iCheckMode);
					__args [8] = new JniArgumentValue (native_aucCheckBuf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (aucDstKeyValue != null) {
						JNIEnv.CopyArray (native_aucDstKeyValue, aucDstKeyValue);
						JNIEnv.DeleteLocalRef (native_aucDstKeyValue);
					}
					if (aucCheckBuf != null) {
						JNIEnv.CopyArray (native_aucCheckBuf, aucCheckBuf);
						JNIEnv.DeleteLocalRef (native_aucCheckBuf);
					}
					global::System.GC.KeepAlive (aucDstKeyValue);
					global::System.GC.KeepAlive (aucCheckBuf);
				}
			}

			static Delegate? cb_writeAesTik_BBBarrayBarrayBBBarrayB;
#pragma warning disable 0169
			static Delegate GetWriteAesTik_BBBarrayBarrayBBBarrayBHandler ()
			{
				if (cb_writeAesTik_BBBarrayBarrayBBBarrayB == null)
					cb_writeAesTik_BBBarrayBarrayBBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLBBL_I (n_WriteAesTik_BBBarrayBarrayBBBarrayB));
				return cb_writeAesTik_BBBarrayBarrayBBBarrayB;
			}

			static int n_WriteAesTik_BBBarrayBarrayBBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte groupIdx, sbyte srcKeyIdx, sbyte keyLen, IntPtr native_keyValueIn, IntPtr native_ksnIn, sbyte ucMode, sbyte iCheckMode, IntPtr native_aucCheckBuf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var keyValueIn = (byte[]?) JNIEnv.GetArray (native_keyValueIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var ksnIn = (byte[]?) JNIEnv.GetArray (native_ksnIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var aucCheckBuf = (byte[]?) JNIEnv.GetArray (native_aucCheckBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteAesTik (groupIdx, srcKeyIdx, keyLen, keyValueIn, ksnIn, ucMode, iCheckMode, aucCheckBuf);
				if (keyValueIn != null)
					JNIEnv.CopyArray (keyValueIn, native_keyValueIn);
				if (ksnIn != null)
					JNIEnv.CopyArray (ksnIn, native_ksnIn);
				if (aucCheckBuf != null)
					JNIEnv.CopyArray (aucCheckBuf, native_aucCheckBuf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='writeAesTik' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte'] and parameter[8][@type='byte[]']]"
			[Register ("writeAesTik", "(BBB[B[BBB[B)I", "GetWriteAesTik_BBBarrayBarrayBBBarrayBHandler")]
			public virtual unsafe int WriteAesTik (sbyte groupIdx, sbyte srcKeyIdx, sbyte keyLen, byte[]? keyValueIn, byte[]? ksnIn, sbyte ucMode, sbyte iCheckMode, byte[]? aucCheckBuf)
			{
				const string __id = "writeAesTik.(BBB[B[BBB[B)I";
				IntPtr native_keyValueIn = JNIEnv.NewArray (keyValueIn);
				IntPtr native_ksnIn = JNIEnv.NewArray (ksnIn);
				IntPtr native_aucCheckBuf = JNIEnv.NewArray (aucCheckBuf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (groupIdx);
					__args [1] = new JniArgumentValue (srcKeyIdx);
					__args [2] = new JniArgumentValue (keyLen);
					__args [3] = new JniArgumentValue (native_keyValueIn);
					__args [4] = new JniArgumentValue (native_ksnIn);
					__args [5] = new JniArgumentValue (ucMode);
					__args [6] = new JniArgumentValue (iCheckMode);
					__args [7] = new JniArgumentValue (native_aucCheckBuf);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (keyValueIn != null) {
						JNIEnv.CopyArray (native_keyValueIn, keyValueIn);
						JNIEnv.DeleteLocalRef (native_keyValueIn);
					}
					if (ksnIn != null) {
						JNIEnv.CopyArray (native_ksnIn, ksnIn);
						JNIEnv.DeleteLocalRef (native_ksnIn);
					}
					if (aucCheckBuf != null) {
						JNIEnv.CopyArray (native_aucCheckBuf, aucCheckBuf);
						JNIEnv.DeleteLocalRef (native_aucCheckBuf);
					}
					global::System.GC.KeepAlive (keyValueIn);
					global::System.GC.KeepAlive (ksnIn);
					global::System.GC.KeepAlive (aucCheckBuf);
				}
			}

			static Delegate? cb_writeDerivedKey_IIarrayBI;
#pragma warning disable 0169
			static Delegate GetWriteDerivedKey_IIarrayBIHandler ()
			{
				if (cb_writeDerivedKey_IIarrayBI == null)
					cb_writeDerivedKey_IIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILI_I (n_WriteDerivedKey_IIarrayBI));
				return cb_writeDerivedKey_IIarrayBI;
			}

			static int n_WriteDerivedKey_IIarrayBI (IntPtr jnienv, IntPtr native__this, int workKeyIndex, int randomKeyIndex, IntPtr native_randomData, int randomDataLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var randomData = (byte[]?) JNIEnv.GetArray (native_randomData, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteDerivedKey (workKeyIndex, randomKeyIndex, randomData, randomDataLen);
				if (randomData != null)
					JNIEnv.CopyArray (randomData, native_randomData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='writeDerivedKey' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("writeDerivedKey", "(II[BI)I", "GetWriteDerivedKey_IIarrayBIHandler")]
			public virtual unsafe int WriteDerivedKey (int workKeyIndex, int randomKeyIndex, byte[]? randomData, int randomDataLen)
			{
				const string __id = "writeDerivedKey.(II[BI)I";
				IntPtr native_randomData = JNIEnv.NewArray (randomData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (workKeyIndex);
					__args [1] = new JniArgumentValue (randomKeyIndex);
					__args [2] = new JniArgumentValue (native_randomData);
					__args [3] = new JniArgumentValue (randomDataLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (randomData != null) {
						JNIEnv.CopyArray (native_randomData, randomData);
						JNIEnv.DeleteLocalRef (native_randomData);
					}
					global::System.GC.KeepAlive (randomData);
				}
			}

			static Delegate? cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetWriteRSAKeyEx_Api_IIarrayBIarrayBarrayBHandler ()
			{
				if (cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB == null)
					cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILL_I (n_WriteRSAKeyEx_Api_IIarrayBIarrayBarrayB));
				return cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB;
			}

			static int n_WriteRSAKeyEx_Api_IIarrayBIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int RSAKeyIndex, int iModulusLen, IntPtr native_aucModulus, int iExponentLen, IntPtr native_aucExponent, IntPtr native_aucKeyInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var aucModulus = (byte[]?) JNIEnv.GetArray (native_aucModulus, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var aucExponent = (byte[]?) JNIEnv.GetArray (native_aucExponent, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var aucKeyInfo = (byte[]?) JNIEnv.GetArray (native_aucKeyInfo, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteRSAKeyEx_Api (RSAKeyIndex, iModulusLen, aucModulus, iExponentLen, aucExponent, aucKeyInfo);
				if (aucModulus != null)
					JNIEnv.CopyArray (aucModulus, native_aucModulus);
				if (aucExponent != null)
					JNIEnv.CopyArray (aucExponent, native_aucExponent);
				if (aucKeyInfo != null)
					JNIEnv.CopyArray (aucKeyInfo, native_aucKeyInfo);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='writeRSAKeyEx_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("writeRSAKeyEx_Api", "(II[BI[B[B)I", "GetWriteRSAKeyEx_Api_IIarrayBIarrayBarrayBHandler")]
			public virtual unsafe int WriteRSAKeyEx_Api (int RSAKeyIndex, int iModulusLen, byte[]? aucModulus, int iExponentLen, byte[]? aucExponent, byte[]? aucKeyInfo)
			{
				const string __id = "writeRSAKeyEx_Api.(II[BI[B[B)I";
				IntPtr native_aucModulus = JNIEnv.NewArray (aucModulus);
				IntPtr native_aucExponent = JNIEnv.NewArray (aucExponent);
				IntPtr native_aucKeyInfo = JNIEnv.NewArray (aucKeyInfo);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (RSAKeyIndex);
					__args [1] = new JniArgumentValue (iModulusLen);
					__args [2] = new JniArgumentValue (native_aucModulus);
					__args [3] = new JniArgumentValue (iExponentLen);
					__args [4] = new JniArgumentValue (native_aucExponent);
					__args [5] = new JniArgumentValue (native_aucKeyInfo);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (aucModulus != null) {
						JNIEnv.CopyArray (native_aucModulus, aucModulus);
						JNIEnv.DeleteLocalRef (native_aucModulus);
					}
					if (aucExponent != null) {
						JNIEnv.CopyArray (native_aucExponent, aucExponent);
						JNIEnv.DeleteLocalRef (native_aucExponent);
					}
					if (aucKeyInfo != null) {
						JNIEnv.CopyArray (native_aucKeyInfo, aucKeyInfo);
						JNIEnv.DeleteLocalRef (native_aucKeyInfo);
					}
					global::System.GC.KeepAlive (aucModulus);
					global::System.GC.KeepAlive (aucExponent);
					global::System.GC.KeepAlive (aucKeyInfo);
				}
			}

			static Delegate? cb_writeRSAKey_Api_BarrayB;
#pragma warning disable 0169
			static Delegate GetWriteRSAKey_Api_BarrayBHandler ()
			{
				if (cb_writeRSAKey_Api_BarrayB == null)
					cb_writeRSAKey_Api_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_WriteRSAKey_Api_BarrayB));
				return cb_writeRSAKey_Api_BarrayB;
			}

			static int n_WriteRSAKey_Api_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte RSAKeyIndex, IntPtr native_pstRsakeyIn)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pstRsakeyIn = (byte[]?) JNIEnv.GetArray (native_pstRsakeyIn, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteRSAKey_Api (RSAKeyIndex, pstRsakeyIn);
				if (pstRsakeyIn != null)
					JNIEnv.CopyArray (pstRsakeyIn, native_pstRsakeyIn);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Default']/method[@name='writeRSAKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("writeRSAKey_Api", "(B[B)I", "GetWriteRSAKey_Api_BarrayBHandler")]
			public virtual unsafe int WriteRSAKey_Api (sbyte RSAKeyIndex, byte[]? pstRsakeyIn)
			{
				const string __id = "writeRSAKey_Api.(B[B)I";
				IntPtr native_pstRsakeyIn = JNIEnv.NewArray (pstRsakeyIn);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (RSAKeyIndex);
					__args [1] = new JniArgumentValue (native_pstRsakeyIn);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (pstRsakeyIn != null) {
						JNIEnv.CopyArray (native_pstRsakeyIn, pstRsakeyIn);
						JNIEnv.DeleteLocalRef (native_pstRsakeyIn);
					}
					global::System.GC.KeepAlive (pstRsakeyIn);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/ped/PedHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/ped/PedHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Stub']/constructor[@name='PedHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/ped/PedHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/ped/PedHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/ped/PedHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/ped/PedHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/class[@name='PedHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.ped.PedHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/ped/PedHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/ped/PedHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI;
#pragma warning disable 0169
			static Delegate GetKMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBIHandler ()
			{
				if (cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI == null)
					cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILLLLI_I (n_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI));
				return cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI;
			}

			static int n_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, int p7)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.KMS_TR31_DukptWriteTIK_Api (p0, p1, p2, p3, p4, p5, p6, p7);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='KMS_TR31_DukptWriteTIK_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='int']]"
			[Register ("KMS_TR31_DukptWriteTIK_Api", "(III[B[B[B[BI)I", "GetKMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBIHandler")]
			public abstract int KMS_TR31_DukptWriteTIK_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, int p7);

			static Delegate? cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetKMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayBHandler ()
			{
				if (cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB == null)
					cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILLL_I (n_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB));
				return cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB;
			}

			static int n_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.KMS_TR31_MwriteKey_Api (p0, p1, p2, p3, p4);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='KMS_TR31_MwriteKey_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("KMS_TR31_MwriteKey_Api", "(II[B[B[B)I", "GetKMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayBHandler")]
			public abstract int KMS_TR31_MwriteKey_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4);

			static Delegate? cb_PEDBigDataMac_Api_IIarrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetPEDBigDataMac_Api_IIarrayBIarrayBIHandler ()
			{
				if (cb_PEDBigDataMac_Api_IIarrayBIarrayBI == null)
					cb_PEDBigDataMac_Api_IIarrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILI_I (n_PEDBigDataMac_Api_IIarrayBIarrayBI));
				return cb_PEDBigDataMac_Api_IIarrayBIarrayBI;
			}

			static int n_PEDBigDataMac_Api_IIarrayBIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDBigDataMac_Api (p0, p1, p2, p3, p4, p5);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDBigDataMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("PEDBigDataMac_Api", "(II[BI[BI)I", "GetPEDBigDataMac_Api_IIarrayBIarrayBIHandler")]
			public abstract int PEDBigDataMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5);

			static Delegate? cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDDesCBC_Api_IIIarrayBIarrayBIarrayBHandler ()
			{
				if (cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB == null)
					cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILILIL_I (n_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB));
				return cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB;
			}

			static int n_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, int p4, IntPtr native_p5, int p6, IntPtr native_p7)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDDesCBC_Api (p0, p1, p2, p3, p4, p5, p6, p7);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				if (p7 != null)
					JNIEnv.CopyArray (p7, native_p7);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDDesCBC_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int'] and parameter[8][@type='byte[]']]"
			[Register ("PEDDesCBC_Api", "(III[BI[BI[B)I", "GetPEDDesCBC_Api_IIIarrayBIarrayBIarrayBHandler")]
			public abstract int PEDDesCBC_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5, int p6, byte[]? p7);

			static Delegate? cb_PEDDes_Api_IIIarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDDes_Api_IIIarrayBIarrayBHandler ()
			{
				if (cb_PEDDes_Api_IIIarrayBIarrayB == null)
					cb_PEDDes_Api_IIIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILIL_I (n_PEDDes_Api_IIIarrayBIarrayB));
				return cb_PEDDes_Api_IIIarrayBIarrayB;
			}

			static int n_PEDDes_Api_IIIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, int p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDDes_Api (p0, p1, p2, p3, p4, p5);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDDes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("PEDDes_Api", "(III[BI[B)I", "GetPEDDes_Api_IIIarrayBIarrayBHandler")]
			public abstract int PEDDes_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5);

			static Delegate? cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_;
#pragma warning disable 0169
			static Delegate GetPEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_Handler ()
			{
				if (cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ == null)
					cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLILIIL_I (n_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_));
				return cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_;
			}

			static int n_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, int p4, int p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (global::Com.Vanstone.Transex.Ped.IGetDukptPinListener?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetDukptPinListener> (native_p6, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PEDGetDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetDukpt_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetDukptPinListener']]"
			[Register ("PEDGetDukpt_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetDukptPinListener;)I", "GetPEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_Handler")]
			public abstract int PEDGetDukpt_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetDukptPinListener? p6);

			static Delegate? cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_;
#pragma warning disable 0169
			static Delegate GetPEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_Handler ()
			{
				if (cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ == null)
					cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIL_I (n_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_));
				return cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_;
			}

			static int n_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (global::Com.Vanstone.Transex.Ped.IGetPinResultListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (native_p3, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PEDGetExpress_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetExpress_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
			[Register ("PEDGetExpress_Api", "(Ljava/lang/String;[BILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_Handler")]
			public abstract int PEDGetExpress_Api (string? p0, byte[]? p1, int p2, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p3);

			static Delegate? cb_PEDGetHdSoft_Api;
#pragma warning disable 0169
			static Delegate GetPEDGetHdSoft_ApiHandler ()
			{
				if (cb_PEDGetHdSoft_Api == null)
					cb_PEDGetHdSoft_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PEDGetHdSoft_Api));
				return cb_PEDGetHdSoft_Api;
			}

			static int n_PEDGetHdSoft_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDGetHdSoft_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetHdSoft_Api' and count(parameter)=0]"
			[Register ("PEDGetHdSoft_Api", "()I", "GetPEDGetHdSoft_ApiHandler")]
			public abstract int PEDGetHdSoft_Api ();

			static Delegate? cb_PEDGetLastError_Api;
#pragma warning disable 0169
			static Delegate GetPEDGetLastError_ApiHandler ()
			{
				if (cb_PEDGetLastError_Api == null)
					cb_PEDGetLastError_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PEDGetLastError_Api));
				return cb_PEDGetLastError_Api;
			}

			static IntPtr n_PEDGetLastError_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.PEDGetLastError_Api ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetLastError_Api' and count(parameter)=0]"
			[Register ("PEDGetLastError_Api", "()Ljava/lang/String;", "GetPEDGetLastError_ApiHandler")]
			public abstract string? PEDGetLastError_Api ();

			static Delegate? cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_;
#pragma warning disable 0169
			static Delegate GetPEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_Handler ()
			{
				if (cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ == null)
					cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLILIIL_I (n_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_));
				return cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_;
			}

			static int n_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, int p4, int p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (global::Com.Vanstone.Transex.Ped.IGetPinResultListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (native_p6, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PEDGetPwd_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetPwd_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
			[Register ("PEDGetPwd_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_Handler")]
			public abstract int PEDGetPwd_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p6);

			static Delegate? cb_PEDMac_Api_IIarrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetPEDMac_Api_IIarrayBIarrayBIHandler ()
			{
				if (cb_PEDMac_Api_IIarrayBIarrayBI == null)
					cb_PEDMac_Api_IIarrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILI_I (n_PEDMac_Api_IIarrayBIarrayBI));
				return cb_PEDMac_Api_IIarrayBIarrayBI;
			}

			static int n_PEDMac_Api_IIarrayBIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDMac_Api (p0, p1, p2, p3, p4, p5);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("PEDMac_Api", "(II[BI[BI)I", "GetPEDMac_Api_IIarrayBIarrayBIHandler")]
			public abstract int PEDMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5);

			static Delegate? cb_PEDReadPinPadSn_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetPEDReadPinPadSn_Api_arrayBHandler ()
			{
				if (cb_PEDReadPinPadSn_Api_arrayB == null)
					cb_PEDReadPinPadSn_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PEDReadPinPadSn_Api_arrayB));
				return cb_PEDReadPinPadSn_Api_arrayB;
			}

			static int n_PEDReadPinPadSn_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDReadPinPadSn_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDReadPinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("PEDReadPinPadSn_Api", "([B)I", "GetPEDReadPinPadSn_Api_arrayBHandler")]
			public abstract int PEDReadPinPadSn_Api (byte[]? p0);

			static Delegate? cb_PEDSavePinPadSn_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetPEDSavePinPadSn_Api_arrayBHandler ()
			{
				if (cb_PEDSavePinPadSn_Api_arrayB == null)
					cb_PEDSavePinPadSn_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PEDSavePinPadSn_Api_arrayB));
				return cb_PEDSavePinPadSn_Api_arrayB;
			}

			static int n_PEDSavePinPadSn_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDSavePinPadSn_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSavePinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("PEDSavePinPadSn_Api", "([B)I", "GetPEDSavePinPadSn_Api_arrayBHandler")]
			public abstract int PEDSavePinPadSn_Api (byte[]? p0);

			static Delegate? cb_PEDSetDesSmHdSoft_Api_II;
#pragma warning disable 0169
			static Delegate GetPEDSetDesSmHdSoft_Api_IIHandler ()
			{
				if (cb_PEDSetDesSmHdSoft_Api_II == null)
					cb_PEDSetDesSmHdSoft_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_PEDSetDesSmHdSoft_Api_II));
				return cb_PEDSetDesSmHdSoft_Api_II;
			}

			static int n_PEDSetDesSmHdSoft_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDSetDesSmHdSoft_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetDesSmHdSoft_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PEDSetDesSmHdSoft_Api", "(II)I", "GetPEDSetDesSmHdSoft_Api_IIHandler")]
			public abstract int PEDSetDesSmHdSoft_Api (int p0, int p1);

			static Delegate? cb_PEDSetHdSoft_Api_I;
#pragma warning disable 0169
			static Delegate GetPEDSetHdSoft_Api_IHandler ()
			{
				if (cb_PEDSetHdSoft_Api_I == null)
					cb_PEDSetHdSoft_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PEDSetHdSoft_Api_I));
				return cb_PEDSetHdSoft_Api_I;
			}

			static int n_PEDSetHdSoft_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDSetHdSoft_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetHdSoft_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PEDSetHdSoft_Api", "(I)I", "GetPEDSetHdSoft_Api_IHandler")]
			public abstract int PEDSetHdSoft_Api (int p0);

			static Delegate? cb_PEDSetKeyType_Api_I;
#pragma warning disable 0169
			static Delegate GetPEDSetKeyType_Api_IHandler ()
			{
				if (cb_PEDSetKeyType_Api_I == null)
					cb_PEDSetKeyType_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PEDSetKeyType_Api_I));
				return cb_PEDSetKeyType_Api_I;
			}

			static void n_PEDSetKeyType_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.PEDSetKeyType_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetKeyType_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PEDSetKeyType_Api", "(I)V", "GetPEDSetKeyType_Api_IHandler")]
			public abstract void PEDSetKeyType_Api (int p0);

			static Delegate? cb_PEDSnMacOnly_Api_arrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetPEDSnMacOnly_Api_arrayBIarrayBIHandler ()
			{
				if (cb_PEDSnMacOnly_Api_arrayBIarrayBI == null)
					cb_PEDSnMacOnly_Api_arrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_I (n_PEDSnMacOnly_Api_arrayBIarrayBI));
				return cb_PEDSnMacOnly_Api_arrayBIarrayBI;
			}

			static int n_PEDSnMacOnly_Api_arrayBIarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDSnMacOnly_Api (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSnMacOnly_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("PEDSnMacOnly_Api", "([BI[BI)I", "GetPEDSnMacOnly_Api_arrayBIarrayBIHandler")]
			public abstract int PEDSnMacOnly_Api (byte[]? p0, int p1, byte[]? p2, int p3);

			static Delegate? cb_PEDStopPin;
#pragma warning disable 0169
			static Delegate GetPEDStopPinHandler ()
			{
				if (cb_PEDStopPin == null)
					cb_PEDStopPin = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PEDStopPin));
				return cb_PEDStopPin;
			}

			static int n_PEDStopPin (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PEDStopPin ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDStopPin' and count(parameter)=0]"
			[Register ("PEDStopPin", "()I", "GetPEDStopPinHandler")]
			public abstract int PEDStopPin ();

			static Delegate? cb_PEDWrite21Key_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWrite21Key_Api_IarrayBHandler ()
			{
				if (cb_PEDWrite21Key_Api_IarrayB == null)
					cb_PEDWrite21Key_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_PEDWrite21Key_Api_IarrayB));
				return cb_PEDWrite21Key_Api_IarrayB;
			}

			static int n_PEDWrite21Key_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWrite21Key_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWrite21Key_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("PEDWrite21Key_Api", "(I[B)I", "GetPEDWrite21Key_Api_IarrayBHandler")]
			public abstract int PEDWrite21Key_Api (int p0, byte[]? p1);

			static Delegate? cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII;
#pragma warning disable 0169
			static Delegate GetPEDWriteIcBcKeyWithType_Api_arrayBIIIIHandler ()
			{
				if (cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII == null)
					cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIII_I (n_PEDWriteIcBcKeyWithType_Api_arrayBIIII));
				return cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII;
			}

			static int n_PEDWriteIcBcKeyWithType_Api_arrayBIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteIcBcKeyWithType_Api (p0, p1, p2, p3, p4);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteIcBcKeyWithType_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("PEDWriteIcBcKeyWithType_Api", "([BIIII)I", "GetPEDWriteIcBcKeyWithType_Api_arrayBIIIIHandler")]
			public abstract int PEDWriteIcBcKeyWithType_Api (byte[]? p0, int p1, int p2, int p3, int p4);

			static Delegate? cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteIcBcKey_Api_arrayBIIIIIarrayBHandler ()
			{
				if (cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB == null)
					cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIIIIL_I (n_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB));
				return cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB;
			}

			static int n_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteIcBcKey_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteIcBcKey_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
			[Register ("PEDWriteIcBcKey_Api", "([BIIIII[B)I", "GetPEDWriteIcBcKey_Api_arrayBIIIIIarrayBHandler")]
			public abstract int PEDWriteIcBcKey_Api (byte[]? p0, int p1, int p2, int p3, int p4, int p5, byte[]? p6);

			static Delegate? cb_PEDWriteKey_Api_IIarrayBIIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteKey_Api_IIarrayBIIarrayBHandler ()
			{
				if (cb_PEDWriteKey_Api_IIarrayBIIarrayB == null)
					cb_PEDWriteKey_Api_IIarrayBIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILIIL_I (n_PEDWriteKey_Api_IIarrayBIIarrayB));
				return cb_PEDWriteKey_Api_IIarrayBIIarrayB;
			}

			static int n_PEDWriteKey_Api_IIarrayBIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteKey_Api (p0, p1, p2, p3, p4, p5);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("PEDWriteKey_Api", "(II[BII[B)I", "GetPEDWriteKey_Api_IIarrayBIIarrayBHandler")]
			public abstract int PEDWriteKey_Api (int p0, int p1, byte[]? p2, int p3, int p4, byte[]? p5);

			static Delegate? cb_PEDWriteMKey_Api_IIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteMKey_Api_IIarrayBHandler ()
			{
				if (cb_PEDWriteMKey_Api_IIarrayB == null)
					cb_PEDWriteMKey_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_PEDWriteMKey_Api_IIarrayB));
				return cb_PEDWriteMKey_Api_IIarrayB;
			}

			static int n_PEDWriteMKey_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteMKey_Api (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteMKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("PEDWriteMKey_Api", "(II[B)I", "GetPEDWriteMKey_Api_IIarrayBHandler")]
			public abstract int PEDWriteMKey_Api (int p0, int p1, byte[]? p2);

			static Delegate? cb_PEDWriteWKey_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetPEDWriteWKey_Api_IIIarrayBHandler ()
			{
				if (cb_PEDWriteWKey_Api_IIIarrayB == null)
					cb_PEDWriteWKey_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_PEDWriteWKey_Api_IIIarrayB));
				return cb_PEDWriteWKey_Api_IIIarrayB;
			}

			static int n_PEDWriteWKey_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PEDWriteWKey_Api (p0, p1, p2, p3);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteWKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("PEDWriteWKey_Api", "(III[B)I", "GetPEDWriteWKey_Api_IIIarrayBHandler")]
			public abstract int PEDWriteWKey_Api (int p0, int p1, int p2, byte[]? p3);

			static Delegate? cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetPedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayBHandler ()
			{
				if (cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB == null)
					cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLBLL_I (n_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB));
				return cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB;
			}

			static int n_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, sbyte p4, IntPtr native_p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedCalcDESDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedCalcDESDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
			[Register ("PedCalcDESDukpt_Api", "(BB[B[BB[B[B)I", "GetPedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayBHandler")]
			public abstract int PedCalcDESDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, sbyte p4, byte[]? p5, byte[]? p6);

			static Delegate? cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB;
#pragma warning disable 0169
			static Delegate GetPedCalcSymDukpt_Api_BBarrayBarrayBIBarrayBHandler ()
			{
				if (cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB == null)
					cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLIBL_I (n_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB));
				return cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB;
			}

			static int n_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, int p4, sbyte p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedCalcSymDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedCalcSymDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
			[Register ("PedCalcSymDukpt_Api", "(BB[B[BIB[B)I", "GetPedCalcSymDukpt_Api_BBarrayBarrayBIBarrayBHandler")]
			public abstract int PedCalcSymDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, int p4, sbyte p5, byte[]? p6);

			static Delegate? cb_PedDukptIncreaseKsn_Api_B;
#pragma warning disable 0169
			static Delegate GetPedDukptIncreaseKsn_Api_BHandler ()
			{
				if (cb_PedDukptIncreaseKsn_Api_B == null)
					cb_PedDukptIncreaseKsn_Api_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_PedDukptIncreaseKsn_Api_B));
				return cb_PedDukptIncreaseKsn_Api_B;
			}

			static int n_PedDukptIncreaseKsn_Api_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PedDukptIncreaseKsn_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedDukptIncreaseKsn_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("PedDukptIncreaseKsn_Api", "(B)I", "GetPedDukptIncreaseKsn_Api_BHandler")]
			public abstract int PedDukptIncreaseKsn_Api (sbyte p0);

			static Delegate? cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB;
#pragma warning disable 0169
			static Delegate GetPedDukptWriteTIK_Api_BBBarrayBarrayBBarrayBHandler ()
			{
				if (cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB == null)
					cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLBL_I (n_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB));
				return cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB;
			}

			static int n_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, sbyte p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedDukptWriteTIK_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedDukptWriteTIK_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
			[Register ("PedDukptWriteTIK_Api", "(BBB[B[BB[B)I", "GetPedDukptWriteTIK_Api_BBBarrayBarrayBBarrayBHandler")]
			public abstract int PedDukptWriteTIK_Api (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, byte[]? p6);

			static Delegate? cb_PedEraseAll_Api;
#pragma warning disable 0169
			static Delegate GetPedEraseAll_ApiHandler ()
			{
				if (cb_PedEraseAll_Api == null)
					cb_PedEraseAll_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_PedEraseAll_Api));
				return cb_PedEraseAll_Api;
			}

			static bool n_PedEraseAll_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PedEraseAll_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedEraseAll_Api' and count(parameter)=0]"
			[Register ("PedEraseAll_Api", "()Z", "GetPedEraseAll_ApiHandler")]
			public abstract bool PedEraseAll_Api ();

			static Delegate? cb_PedErase_Api_II;
#pragma warning disable 0169
			static Delegate GetPedErase_Api_IIHandler ()
			{
				if (cb_PedErase_Api_II == null)
					cb_PedErase_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_PedErase_Api_II));
				return cb_PedErase_Api_II;
			}

			static bool n_PedErase_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.PedErase_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedErase_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PedErase_Api", "(II)Z", "GetPedErase_Api_IIHandler")]
			public abstract bool PedErase_Api (int p0, int p1);

			static Delegate? cb_PedGetDukptKSN_Api_BarrayB;
#pragma warning disable 0169
			static Delegate GetPedGetDukptKSN_Api_BarrayBHandler ()
			{
				if (cb_PedGetDukptKSN_Api_BarrayB == null)
					cb_PedGetDukptKSN_Api_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_PedGetDukptKSN_Api_BarrayB));
				return cb_PedGetDukptKSN_Api_BarrayB;
			}

			static int n_PedGetDukptKSN_Api_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedGetDukptKSN_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedGetDukptKSN_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("PedGetDukptKSN_Api", "(B[B)I", "GetPedGetDukptKSN_Api_BarrayBHandler")]
			public abstract int PedGetDukptKSN_Api (sbyte p0, byte[]? p1);

			static Delegate? cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB;
#pragma warning disable 0169
			static Delegate GetPedGetMacDukpt_Api_BBarrayBIarrayBarrayBBHandler ()
			{
				if (cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB == null)
					cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLILLB_I (n_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB));
				return cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB;
			}

			static int n_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5, sbyte p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.PedGetMacDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedGetMacDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte']]"
			[Register ("PedGetMacDukpt_Api", "(BB[BI[B[BB)I", "GetPedGetMacDukpt_Api_BBarrayBIarrayBarrayBBHandler")]
			public abstract int PedGetMacDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5, sbyte p6);

			static Delegate? cb_PedSelectPlace_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPedSelectPlace_Api_Ljava_lang_String_Handler ()
			{
				if (cb_PedSelectPlace_Api_Ljava_lang_String_ == null)
					cb_PedSelectPlace_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PedSelectPlace_Api_Ljava_lang_String_));
				return cb_PedSelectPlace_Api_Ljava_lang_String_;
			}

			static int n_PedSelectPlace_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PedSelectPlace_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedSelectPlace_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("PedSelectPlace_Api", "(Ljava/lang/String;)I", "GetPedSelectPlace_Api_Ljava_lang_String_Handler")]
			public abstract int PedSelectPlace_Api (string? p0);

			static Delegate? cb_RSAEnAndDe_Api_IarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetRSAEnAndDe_Api_IarrayBarrayBarrayBHandler ()
			{
				if (cb_RSAEnAndDe_Api_IarrayBarrayBarrayB == null)
					cb_RSAEnAndDe_Api_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_RSAEnAndDe_Api_IarrayBarrayBarrayB));
				return cb_RSAEnAndDe_Api_IarrayBarrayBarrayB;
			}

			static int n_RSAEnAndDe_Api_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.RSAEnAndDe_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSAEnAndDe_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("RSAEnAndDe_Api", "(I[B[B[B)I", "GetRSAEnAndDe_Api_IarrayBarrayBarrayBHandler")]
			public abstract int RSAEnAndDe_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3);

			static Delegate? cb_RSASign_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetRSASign_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_RSASign_Api_arrayBarrayBarrayB == null)
					cb_RSASign_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_RSASign_Api_arrayBarrayBarrayB));
				return cb_RSASign_Api_arrayBarrayBarrayB;
			}

			static int n_RSASign_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.RSASign_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSASign_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("RSASign_Api", "([B[B[B)I", "GetRSASign_Api_arrayBarrayBarrayBHandler")]
			public abstract int RSASign_Api (byte[]? p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_RSAVerify_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetRSAVerify_Api_arrayBarrayBarrayBHandler ()
			{
				if (cb_RSAVerify_Api_arrayBarrayBarrayB == null)
					cb_RSAVerify_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_RSAVerify_Api_arrayBarrayBarrayB));
				return cb_RSAVerify_Api_arrayBarrayBarrayB;
			}

			static int n_RSAVerify_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.RSAVerify_Api (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSAVerify_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("RSAVerify_Api", "([B[B[B)I", "GetRSAVerify_Api_arrayBarrayBarrayBHandler")]
			public abstract int RSAVerify_Api (byte[]? p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_TR31_WriteKey_Api_IarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetTR31_WriteKey_Api_IarrayBarrayBarrayBHandler ()
			{
				if (cb_TR31_WriteKey_Api_IarrayBarrayBarrayB == null)
					cb_TR31_WriteKey_Api_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_TR31_WriteKey_Api_IarrayBarrayBarrayB));
				return cb_TR31_WriteKey_Api_IarrayBarrayBarrayB;
			}

			static int n_TR31_WriteKey_Api_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.TR31_WriteKey_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='TR31_WriteKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("TR31_WriteKey_Api", "(I[B[B[B)I", "GetTR31_WriteKey_Api_IarrayBarrayBarrayBHandler")]
			public abstract int TR31_WriteKey_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3);

			static Delegate? cb_calAes_Api_IIarrayBIarrayBIarrayB;
#pragma warning disable 0169
			static Delegate GetCalAes_Api_IIarrayBIarrayBIarrayBHandler ()
			{
				if (cb_calAes_Api_IIarrayBIarrayBIarrayB == null)
					cb_calAes_Api_IIarrayBIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILIL_I (n_CalAes_Api_IIarrayBIarrayBIarrayB));
				return cb_calAes_Api_IIarrayBIarrayBIarrayB;
			}

			static int n_CalAes_Api_IIarrayBIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalAes_Api (p0, p1, p2, p3, p4, p5, p6);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calAes_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
			[Register ("calAes_Api", "(II[BI[BI[B)I", "GetCalAes_Api_IIarrayBIarrayBIarrayBHandler")]
			public abstract int CalAes_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5, byte[]? p6);

			static Delegate? cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcAesDukpt_BBarrayBIarrayBBarrayBarrayBHandler ()
			{
				if (cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB == null)
					cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLILBLL_I (n_CalcAesDukpt_BBarrayBIarrayBBarrayBarrayB));
				return cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB;
			}

			static int n_CalcAesDukpt_BBarrayBIarrayBBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3, IntPtr native_p4, sbyte p5, IntPtr native_p6, IntPtr native_p7)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcAesDukpt (p0, p1, p2, p3, p4, p5, p6, p7);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				if (p7 != null)
					JNIEnv.CopyArray (p7, native_p7);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcAesDukpt' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]']]"
			[Register ("calcAesDukpt", "(BB[BI[BB[B[B)I", "GetCalcAesDukpt_BBarrayBIarrayBBarrayBarrayBHandler")]
			public abstract int CalcAesDukpt (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, sbyte p5, byte[]? p6, byte[]? p7);

			static Delegate? cb_calcRSAEx_Api_IIarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSAEx_Api_IIarrayBarrayBarrayBHandler ()
			{
				if (cb_calcRSAEx_Api_IIarrayBarrayBarrayB == null)
					cb_calcRSAEx_Api_IIarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILLL_I (n_CalcRSAEx_Api_IIarrayBarrayBarrayB));
				return cb_calcRSAEx_Api_IIarrayBarrayBarrayB;
			}

			static int n_CalcRSAEx_Api_IIarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSAEx_Api (p0, p1, p2, p3, p4);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAEx_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAEx_Api", "(II[B[B[B)I", "GetCalcRSAEx_Api_IIarrayBarrayBarrayBHandler")]
			public abstract int CalcRSAEx_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4);

			static Delegate? cb_calcRSAPri_Api_IIIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSAPri_Api_IIIarrayBarrayBHandler ()
			{
				if (cb_calcRSAPri_Api_IIIarrayBarrayB == null)
					cb_calcRSAPri_Api_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILL_I (n_CalcRSAPri_Api_IIIarrayBarrayB));
				return cb_calcRSAPri_Api_IIIarrayBarrayB;
			}

			static int n_CalcRSAPri_Api_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSAPri_Api (p0, p1, p2, p3, p4);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAPri_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAPri_Api", "(III[B[B)I", "GetCalcRSAPri_Api_IIIarrayBarrayBHandler")]
			public abstract int CalcRSAPri_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4);

			static Delegate? cb_calcRSAPub_Api_IIIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSAPub_Api_IIIarrayBarrayBHandler ()
			{
				if (cb_calcRSAPub_Api_IIIarrayBarrayB == null)
					cb_calcRSAPub_Api_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILL_I (n_CalcRSAPub_Api_IIIarrayBarrayB));
				return cb_calcRSAPub_Api_IIIarrayBarrayB;
			}

			static int n_CalcRSAPub_Api_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSAPub_Api (p0, p1, p2, p3, p4);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAPub_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAPub_Api", "(III[B[B)I", "GetCalcRSAPub_Api_IIIarrayBarrayBHandler")]
			public abstract int CalcRSAPub_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4);

			static Delegate? cb_calcRSA_Api_BarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetCalcRSA_Api_BarrayBarrayBarrayBHandler ()
			{
				if (cb_calcRSA_Api_BarrayBarrayBarrayB == null)
					cb_calcRSA_Api_BarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLLL_I (n_CalcRSA_Api_BarrayBarrayBarrayB));
				return cb_calcRSA_Api_BarrayBarrayBarrayB;
			}

			static int n_CalcRSA_Api_BarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.CalcRSA_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSA_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("calcRSA_Api", "(B[B[B[B)I", "GetCalcRSA_Api_BarrayBarrayBarrayBHandler")]
			public abstract int CalcRSA_Api (sbyte p0, byte[]? p1, byte[]? p2, byte[]? p3);

			static Delegate? cb_getAesDukptKsn_BarrayB;
#pragma warning disable 0169
			static Delegate GetGetAesDukptKsn_BarrayBHandler ()
			{
				if (cb_getAesDukptKsn_BarrayB == null)
					cb_getAesDukptKsn_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_GetAesDukptKsn_BarrayB));
				return cb_getAesDukptKsn_BarrayB;
			}

			static int n_GetAesDukptKsn_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetAesDukptKsn (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getAesDukptKsn' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("getAesDukptKsn", "(B[B)I", "GetGetAesDukptKsn_BarrayBHandler")]
			public abstract int GetAesDukptKsn (sbyte p0, byte[]? p1);

			static Delegate? cb_getKeyPairHdOrSoftg_IarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetKeyPairHdOrSoftg_IarrayBarrayBHandler ()
			{
				if (cb_getKeyPairHdOrSoftg_IarrayBarrayB == null)
					cb_getKeyPairHdOrSoftg_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_GetKeyPairHdOrSoftg_IarrayBarrayB));
				return cb_getKeyPairHdOrSoftg_IarrayBarrayB;
			}

			static int n_GetKeyPairHdOrSoftg_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetKeyPairHdOrSoftg (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getKeyPairHdOrSoftg' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("getKeyPairHdOrSoftg", "(I[B[B)I", "GetGetKeyPairHdOrSoftg_IarrayBarrayBHandler")]
			public abstract int GetKeyPairHdOrSoftg (int p0, byte[]? p1, byte[]? p2);

			static Delegate? cb_getMacAesDukpt_BIBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetMacAesDukpt_BIBarrayBarrayBarrayBHandler ()
			{
				if (cb_getMacAesDukpt_BIBarrayBarrayBarrayB == null)
					cb_getMacAesDukpt_BIBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBIBLLL_I (n_GetMacAesDukpt_BIBarrayBarrayBarrayB));
				return cb_getMacAesDukpt_BIBarrayBarrayBarrayB;
			}

			static int n_GetMacAesDukpt_BIBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, int p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetMacAesDukpt (p0, p1, p2, p3, p4, p5);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getMacAesDukpt' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("getMacAesDukpt", "(BIB[B[B[B)I", "GetGetMacAesDukpt_BIBarrayBarrayBarrayBHandler")]
			public abstract int GetMacAesDukpt (sbyte p0, int p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5);

			static Delegate? cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetPinAESDukptEx_BBBarrayBarrayBarrayBarrayBHandler ()
			{
				if (cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB == null)
					cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLLL_I (n_GetPinAESDukptEx_BBBarrayBarrayBarrayBarrayB));
				return cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB;
			}

			static int n_GetPinAESDukptEx_BBBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetPinAESDukptEx (p0, p1, p2, p3, p4, p5, p6);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				if (p6 != null)
					JNIEnv.CopyArray (p6, native_p6);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getPinAESDukptEx' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
			[Register ("getPinAESDukptEx", "(BBB[B[B[B[B)I", "GetGetPinAESDukptEx_BBBarrayBarrayBarrayBarrayBHandler")]
			public abstract int GetPinAESDukptEx (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6);

			static Delegate? cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayBHandler ()
			{
				if (cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB == null)
					cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLLL_I (n_GetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB));
				return cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB;
			}

			static int n_GetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetPinDukptEx_Api (p0, p1, p2, p3, p4, p5);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getPinDukptEx_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("getPinDukptEx_Api", "(BBLjava/lang/String;Ljava/lang/String;[B[B)I", "GetGetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayBHandler")]
			public abstract int GetPinDukptEx_Api (sbyte p0, sbyte p1, string? p2, string? p3, byte[]? p4, byte[]? p5);

			static Delegate? cb_getRSAKeyPair_Api_IIIarrayB;
#pragma warning disable 0169
			static Delegate GetGetRSAKeyPair_Api_IIIarrayBHandler ()
			{
				if (cb_getRSAKeyPair_Api_IIIarrayB == null)
					cb_getRSAKeyPair_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_GetRSAKeyPair_Api_IIIarrayB));
				return cb_getRSAKeyPair_Api_IIIarrayB;
			}

			static int n_GetRSAKeyPair_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetRSAKeyPair_Api (p0, p1, p2, p3);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getRSAKeyPair_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("getRSAKeyPair_Api", "(III[B)I", "GetGetRSAKeyPair_Api_IIIarrayBHandler")]
			public abstract int GetRSAKeyPair_Api (int p0, int p1, int p2, byte[]? p3);

			static Delegate? cb_isKeyExist_Api_II;
#pragma warning disable 0169
			static Delegate GetIsKeyExist_Api_IIHandler ()
			{
				if (cb_isKeyExist_Api_II == null)
					cb_isKeyExist_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_IsKeyExist_Api_II));
				return cb_isKeyExist_Api_II;
			}

			static bool n_IsKeyExist_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsKeyExist_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='isKeyExist_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("isKeyExist_Api", "(II)Z", "GetIsKeyExist_Api_IIHandler")]
			public abstract bool IsKeyExist_Api (int p0, int p1);

			static Delegate? cb_setAmountColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAmountColor_Ljava_lang_String_Handler ()
			{
				if (cb_setAmountColor_Ljava_lang_String_ == null)
					cb_setAmountColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAmountColor_Ljava_lang_String_));
				return cb_setAmountColor_Ljava_lang_String_;
			}

			static void n_SetAmountColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetAmountColor (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountColor", "(Ljava/lang/String;)V", "GetSetAmountColor_Ljava_lang_String_Handler")]
			public abstract void SetAmountColor (string? p0);

			static Delegate? cb_setAmountFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAmountFont_Ljava_lang_String_Handler ()
			{
				if (cb_setAmountFont_Ljava_lang_String_ == null)
					cb_setAmountFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAmountFont_Ljava_lang_String_));
				return cb_setAmountFont_Ljava_lang_String_;
			}

			static void n_SetAmountFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetAmountFont (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountFont", "(Ljava/lang/String;)V", "GetSetAmountFont_Ljava_lang_String_Handler")]
			public abstract void SetAmountFont (string? p0);

			static Delegate? cb_setAmountSize_F;
#pragma warning disable 0169
			static Delegate GetSetAmountSize_FHandler ()
			{
				if (cb_setAmountSize_F == null)
					cb_setAmountSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetAmountSize_F));
				return cb_setAmountSize_F;
			}

			static void n_SetAmountSize_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetAmountSize (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAmountSize", "(F)V", "GetSetAmountSize_FHandler")]
			public abstract void SetAmountSize (float p0);

			static Delegate? cb_setBottomBtnText_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBottomBtnText_arrayLjava_lang_String_Handler ()
			{
				if (cb_setBottomBtnText_arrayLjava_lang_String_ == null)
					cb_setBottomBtnText_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomBtnText_arrayLjava_lang_String_));
				return cb_setBottomBtnText_arrayLjava_lang_String_;
			}

			static void n_SetBottomBtnText_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (string[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				__this.SetBottomBtnText (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomBtnText' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("setBottomBtnText", "([Ljava/lang/String;)V", "GetSetBottomBtnText_arrayLjava_lang_String_Handler")]
			public abstract void SetBottomBtnText (string[]? p0);

			static Delegate? cb_setBottomFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBottomFont_Ljava_lang_String_Handler ()
			{
				if (cb_setBottomFont_Ljava_lang_String_ == null)
					cb_setBottomFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomFont_Ljava_lang_String_));
				return cb_setBottomFont_Ljava_lang_String_;
			}

			static void n_SetBottomFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetBottomFont (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBottomFont", "(Ljava/lang/String;)V", "GetSetBottomFont_Ljava_lang_String_Handler")]
			public abstract void SetBottomFont (string? p0);

			static Delegate? cb_setBottomTextColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBottomTextColor_Ljava_lang_String_Handler ()
			{
				if (cb_setBottomTextColor_Ljava_lang_String_ == null)
					cb_setBottomTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomTextColor_Ljava_lang_String_));
				return cb_setBottomTextColor_Ljava_lang_String_;
			}

			static void n_SetBottomTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetBottomTextColor (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBottomTextColor", "(Ljava/lang/String;)V", "GetSetBottomTextColor_Ljava_lang_String_Handler")]
			public abstract void SetBottomTextColor (string? p0);

			static Delegate? cb_setBottomTextSize_F;
#pragma warning disable 0169
			static Delegate GetSetBottomTextSize_FHandler ()
			{
				if (cb_setBottomTextSize_F == null)
					cb_setBottomTextSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetBottomTextSize_F));
				return cb_setBottomTextSize_F;
			}

			static void n_SetBottomTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetBottomTextSize (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBottomTextSize", "(F)V", "GetSetBottomTextSize_FHandler")]
			public abstract void SetBottomTextSize (float p0);

			static Delegate? cb_setCardNo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCardNo_Ljava_lang_String_Handler ()
			{
				if (cb_setCardNo_Ljava_lang_String_ == null)
					cb_setCardNo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCardNo_Ljava_lang_String_));
				return cb_setCardNo_Ljava_lang_String_;
			}

			static void n_SetCardNo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetCardNo (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setCardNo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardNo", "(Ljava/lang/String;)V", "GetSetCardNo_Ljava_lang_String_Handler")]
			public abstract void SetCardNo (string? p0);

			static Delegate? cb_setDispAmt_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDispAmt_Ljava_lang_String_Handler ()
			{
				if (cb_setDispAmt_Ljava_lang_String_ == null)
					cb_setDispAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetDispAmt_Ljava_lang_String_));
				return cb_setDispAmt_Ljava_lang_String_;
			}

			static void n_SetDispAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetDispAmt (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setDispAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDispAmt", "(Ljava/lang/String;)V", "GetSetDispAmt_Ljava_lang_String_Handler")]
			public abstract void SetDispAmt (string? p0);

			static Delegate? cb_setNumColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNumColor_Ljava_lang_String_Handler ()
			{
				if (cb_setNumColor_Ljava_lang_String_ == null)
					cb_setNumColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNumColor_Ljava_lang_String_));
				return cb_setNumColor_Ljava_lang_String_;
			}

			static void n_SetNumColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetNumColor (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNumColor", "(Ljava/lang/String;)V", "GetSetNumColor_Ljava_lang_String_Handler")]
			public abstract void SetNumColor (string? p0);

			static Delegate? cb_setNumFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNumFont_Ljava_lang_String_Handler ()
			{
				if (cb_setNumFont_Ljava_lang_String_ == null)
					cb_setNumFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNumFont_Ljava_lang_String_));
				return cb_setNumFont_Ljava_lang_String_;
			}

			static void n_SetNumFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetNumFont (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNumFont", "(Ljava/lang/String;)V", "GetSetNumFont_Ljava_lang_String_Handler")]
			public abstract void SetNumFont (string? p0);

			static Delegate? cb_setNumSize_F;
#pragma warning disable 0169
			static Delegate GetSetNumSize_FHandler ()
			{
				if (cb_setNumSize_F == null)
					cb_setNumSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetNumSize_F));
				return cb_setNumSize_F;
			}

			static void n_SetNumSize_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetNumSize (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setNumSize", "(F)V", "GetSetNumSize_FHandler")]
			public abstract void SetNumSize (float p0);

			static Delegate? cb_setPinBoardFixed_Z;
#pragma warning disable 0169
			static Delegate GetSetPinBoardFixed_ZHandler ()
			{
				if (cb_setPinBoardFixed_Z == null)
					cb_setPinBoardFixed_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetPinBoardFixed_Z));
				return cb_setPinBoardFixed_Z;
			}

			static void n_SetPinBoardFixed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetPinBoardFixed (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardFixed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPinBoardFixed", "(Z)V", "GetSetPinBoardFixed_ZHandler")]
			public abstract void SetPinBoardFixed (bool p0);

			static Delegate? cb_setPinBoardKey_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetPinBoardKey_Api_Landroid_os_Bundle_Handler ()
			{
				if (cb_setPinBoardKey_Api_Landroid_os_Bundle_ == null)
					cb_setPinBoardKey_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetPinBoardKey_Api_Landroid_os_Bundle_));
				return cb_setPinBoardKey_Api_Landroid_os_Bundle_;
			}

			static int n_SetPinBoardKey_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetPinBoardKey_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardKey_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardKey_Api", "(Landroid/os/Bundle;)I", "GetSetPinBoardKey_Api_Landroid_os_Bundle_Handler")]
			public abstract int SetPinBoardKey_Api (global::Android.OS.Bundle? p0);

			static Delegate? cb_setPinBoardMsg_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetPinBoardMsg_Landroid_os_Bundle_Handler ()
			{
				if (cb_setPinBoardMsg_Landroid_os_Bundle_ == null)
					cb_setPinBoardMsg_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPinBoardMsg_Landroid_os_Bundle_));
				return cb_setPinBoardMsg_Landroid_os_Bundle_;
			}

			static void n_SetPinBoardMsg_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetPinBoardMsg (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardMsg' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardMsg", "(Landroid/os/Bundle;)V", "GetSetPinBoardMsg_Landroid_os_Bundle_Handler")]
			public abstract void SetPinBoardMsg (global::Android.OS.Bundle? p0);

			static Delegate? cb_setPinBoardSetting_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetPinBoardSetting_Landroid_os_Bundle_Handler ()
			{
				if (cb_setPinBoardSetting_Landroid_os_Bundle_ == null)
					cb_setPinBoardSetting_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPinBoardSetting_Landroid_os_Bundle_));
				return cb_setPinBoardSetting_Landroid_os_Bundle_;
			}

			static void n_SetPinBoardSetting_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetPinBoardSetting (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardSetting' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardSetting", "(Landroid/os/Bundle;)V", "GetSetPinBoardSetting_Landroid_os_Bundle_Handler")]
			public abstract void SetPinBoardSetting (global::Android.OS.Bundle? p0);

			static Delegate? cb_setPinBoardStyle_I;
#pragma warning disable 0169
			static Delegate GetSetPinBoardStyle_IHandler ()
			{
				if (cb_setPinBoardStyle_I == null)
					cb_setPinBoardStyle_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetPinBoardStyle_I));
				return cb_setPinBoardStyle_I;
			}

			static void n_SetPinBoardStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetPinBoardStyle (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPinBoardStyle", "(I)V", "GetSetPinBoardStyle_IHandler")]
			public abstract void SetPinBoardStyle (int p0);

			static Delegate? cb_setStatusbarColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetStatusbarColor_Ljava_lang_String_Handler ()
			{
				if (cb_setStatusbarColor_Ljava_lang_String_ == null)
					cb_setStatusbarColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetStatusbarColor_Ljava_lang_String_));
				return cb_setStatusbarColor_Ljava_lang_String_;
			}

			static void n_SetStatusbarColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetStatusbarColor (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setStatusbarColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusbarColor", "(Ljava/lang/String;)V", "GetSetStatusbarColor_Ljava_lang_String_Handler")]
			public abstract void SetStatusbarColor (string? p0);

			static Delegate? cb_setStatusbarHide_Z;
#pragma warning disable 0169
			static Delegate GetSetStatusbarHide_ZHandler ()
			{
				if (cb_setStatusbarHide_Z == null)
					cb_setStatusbarHide_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetStatusbarHide_Z));
				return cb_setStatusbarHide_Z;
			}

			static void n_SetStatusbarHide_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetStatusbarHide (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setStatusbarHide' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStatusbarHide", "(Z)V", "GetSetStatusbarHide_ZHandler")]
			public abstract void SetStatusbarHide (bool p0);

			static Delegate? cb_setTextColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTextColor_Ljava_lang_String_Handler ()
			{
				if (cb_setTextColor_Ljava_lang_String_ == null)
					cb_setTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTextColor_Ljava_lang_String_));
				return cb_setTextColor_Ljava_lang_String_;
			}

			static void n_SetTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetTextColor (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextColor", "(Ljava/lang/String;)V", "GetSetTextColor_Ljava_lang_String_Handler")]
			public abstract void SetTextColor (string? p0);

			static Delegate? cb_setTextFont_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTextFont_Ljava_lang_String_Handler ()
			{
				if (cb_setTextFont_Ljava_lang_String_ == null)
					cb_setTextFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTextFont_Ljava_lang_String_));
				return cb_setTextFont_Ljava_lang_String_;
			}

			static void n_SetTextFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetTextFont (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextFont", "(Ljava/lang/String;)V", "GetSetTextFont_Ljava_lang_String_Handler")]
			public abstract void SetTextFont (string? p0);

			static Delegate? cb_setTextSize_F;
#pragma warning disable 0169
			static Delegate GetSetTextSize_FHandler ()
			{
				if (cb_setTextSize_F == null)
					cb_setTextSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetTextSize_F));
				return cb_setTextSize_F;
			}

			static void n_SetTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetTextSize (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTextSize", "(F)V", "GetSetTextSize_FHandler")]
			public abstract void SetTextSize (float p0);

			static Delegate? cb_setTitleBackGroundColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTitleBackGroundColor_Ljava_lang_String_Handler ()
			{
				if (cb_setTitleBackGroundColor_Ljava_lang_String_ == null)
					cb_setTitleBackGroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTitleBackGroundColor_Ljava_lang_String_));
				return cb_setTitleBackGroundColor_Ljava_lang_String_;
			}

			static void n_SetTitleBackGroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetTitleBackGroundColor (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTitleBackGroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitleBackGroundColor", "(Ljava/lang/String;)V", "GetSetTitleBackGroundColor_Ljava_lang_String_Handler")]
			public abstract void SetTitleBackGroundColor (string? p0);

			static Delegate? cb_writeAesKey_BIBIBarrayBBBarrayB;
#pragma warning disable 0169
			static Delegate GetWriteAesKey_BIBIBarrayBBBarrayBHandler ()
			{
				if (cb_writeAesKey_BIBIBarrayBBBarrayB == null)
					cb_writeAesKey_BIBIBarrayBBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBIBIBLBBL_I (n_WriteAesKey_BIBIBarrayBBBarrayB));
				return cb_writeAesKey_BIBIBarrayBBBarrayB;
			}

			static int n_WriteAesKey_BIBIBarrayBBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, int p1, sbyte p2, int p3, sbyte p4, IntPtr native_p5, sbyte p6, sbyte p7, IntPtr native_p8)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p8 = (byte[]?) JNIEnv.GetArray (native_p8, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteAesKey (p0, p1, p2, p3, p4, p5, p6, p7, p8);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				if (p8 != null)
					JNIEnv.CopyArray (p8, native_p8);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeAesKey' and count(parameter)=9 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte'] and parameter[8][@type='byte'] and parameter[9][@type='byte[]']]"
			[Register ("writeAesKey", "(BIBIB[BBB[B)I", "GetWriteAesKey_BIBIBarrayBBBarrayBHandler")]
			public abstract int WriteAesKey (sbyte p0, int p1, sbyte p2, int p3, sbyte p4, byte[]? p5, sbyte p6, sbyte p7, byte[]? p8);

			static Delegate? cb_writeAesTik_BBBarrayBarrayBBBarrayB;
#pragma warning disable 0169
			static Delegate GetWriteAesTik_BBBarrayBarrayBBBarrayBHandler ()
			{
				if (cb_writeAesTik_BBBarrayBarrayBBBarrayB == null)
					cb_writeAesTik_BBBarrayBarrayBBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLBBL_I (n_WriteAesTik_BBBarrayBarrayBBBarrayB));
				return cb_writeAesTik_BBBarrayBarrayBBBarrayB;
			}

			static int n_WriteAesTik_BBBarrayBarrayBBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, sbyte p5, sbyte p6, IntPtr native_p7)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteAesTik (p0, p1, p2, p3, p4, p5, p6, p7);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p7 != null)
					JNIEnv.CopyArray (p7, native_p7);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeAesTik' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte'] and parameter[8][@type='byte[]']]"
			[Register ("writeAesTik", "(BBB[B[BBB[B)I", "GetWriteAesTik_BBBarrayBarrayBBBarrayBHandler")]
			public abstract int WriteAesTik (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, sbyte p6, byte[]? p7);

			static Delegate? cb_writeDerivedKey_IIarrayBI;
#pragma warning disable 0169
			static Delegate GetWriteDerivedKey_IIarrayBIHandler ()
			{
				if (cb_writeDerivedKey_IIarrayBI == null)
					cb_writeDerivedKey_IIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILI_I (n_WriteDerivedKey_IIarrayBI));
				return cb_writeDerivedKey_IIarrayBI;
			}

			static int n_WriteDerivedKey_IIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteDerivedKey (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeDerivedKey' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("writeDerivedKey", "(II[BI)I", "GetWriteDerivedKey_IIarrayBIHandler")]
			public abstract int WriteDerivedKey (int p0, int p1, byte[]? p2, int p3);

			static Delegate? cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetWriteRSAKeyEx_Api_IIarrayBIarrayBarrayBHandler ()
			{
				if (cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB == null)
					cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILL_I (n_WriteRSAKeyEx_Api_IIarrayBIarrayBarrayB));
				return cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB;
			}

			static int n_WriteRSAKeyEx_Api_IIarrayBIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteRSAKeyEx_Api (p0, p1, p2, p3, p4, p5);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				if (p4 != null)
					JNIEnv.CopyArray (p4, native_p4);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeRSAKeyEx_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("writeRSAKeyEx_Api", "(II[BI[B[B)I", "GetWriteRSAKeyEx_Api_IIarrayBIarrayBarrayBHandler")]
			public abstract int WriteRSAKeyEx_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5);

			static Delegate? cb_writeRSAKey_Api_BarrayB;
#pragma warning disable 0169
			static Delegate GetWriteRSAKey_Api_BarrayBHandler ()
			{
				if (cb_writeRSAKey_Api_BarrayB == null)
					cb_writeRSAKey_Api_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_WriteRSAKey_Api_BarrayB));
				return cb_writeRSAKey_Api_BarrayB;
			}

			static int n_WriteRSAKey_Api_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteRSAKey_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeRSAKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("writeRSAKey_Api", "(B[B)I", "GetWriteRSAKey_Api_BarrayBHandler")]
			public abstract int WriteRSAKey_Api (sbyte p0, byte[]? p1);

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/ped/PedHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/ped/PedHandler$Stub", typeof (StubInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='KMS_TR31_DukptWriteTIK_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='int']]"
			[Register ("KMS_TR31_DukptWriteTIK_Api", "(III[B[B[B[BI)I", "GetKMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBIHandler")]
			public override unsafe int KMS_TR31_DukptWriteTIK_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, int p7)
			{
				const string __id = "KMS_TR31_DukptWriteTIK_Api.(III[B[B[B[BI)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (native_p6);
					__args [7] = new JniArgumentValue (p7);
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
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='KMS_TR31_MwriteKey_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("KMS_TR31_MwriteKey_Api", "(II[B[B[B)I", "GetKMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayBHandler")]
			public override unsafe int KMS_TR31_MwriteKey_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4)
			{
				const string __id = "KMS_TR31_MwriteKey_Api.(II[B[B[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDBigDataMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("PEDBigDataMac_Api", "(II[BI[BI)I", "GetPEDBigDataMac_Api_IIarrayBIarrayBIHandler")]
			public override unsafe int PEDBigDataMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5)
			{
				const string __id = "PEDBigDataMac_Api.(II[BI[BI)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDDesCBC_Api' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int'] and parameter[8][@type='byte[]']]"
			[Register ("PEDDesCBC_Api", "(III[BI[BI[B)I", "GetPEDDesCBC_Api_IIIarrayBIarrayBIarrayBHandler")]
			public override unsafe int PEDDesCBC_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5, int p6, byte[]? p7)
			{
				const string __id = "PEDDesCBC_Api.(III[BI[BI[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				IntPtr native_p7 = JNIEnv.NewArray (p7);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (p6);
					__args [7] = new JniArgumentValue (native_p7);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					if (p7 != null) {
						JNIEnv.CopyArray (native_p7, p7);
						JNIEnv.DeleteLocalRef (native_p7);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p5);
					global::System.GC.KeepAlive (p7);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDDes_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("PEDDes_Api", "(III[BI[B)I", "GetPEDDes_Api_IIIarrayBIarrayBHandler")]
			public override unsafe int PEDDes_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5)
			{
				const string __id = "PEDDes_Api.(III[BI[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetDukpt_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetDukptPinListener']]"
			[Register ("PEDGetDukpt_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetDukptPinListener;)I", "GetPEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_Handler")]
			public override unsafe int PEDGetDukpt_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetDukptPinListener? p6)
			{
				const string __id = "PEDGetDukpt_Api.(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetDukptPinListener;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetExpress_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
			[Register ("PEDGetExpress_Api", "(Ljava/lang/String;[BILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_Handler")]
			public override unsafe int PEDGetExpress_Api (string? p0, byte[]? p1, int p2, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p3)
			{
				const string __id = "PEDGetExpress_Api.(Ljava/lang/String;[BILcom/vanstone/transex/ped/IGetPinResultListenner;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p3);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetHdSoft_Api' and count(parameter)=0]"
			[Register ("PEDGetHdSoft_Api", "()I", "GetPEDGetHdSoft_ApiHandler")]
			public override unsafe int PEDGetHdSoft_Api ()
			{
				const string __id = "PEDGetHdSoft_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetLastError_Api' and count(parameter)=0]"
			[Register ("PEDGetLastError_Api", "()Ljava/lang/String;", "GetPEDGetLastError_ApiHandler")]
			public override unsafe string? PEDGetLastError_Api ()
			{
				const string __id = "PEDGetLastError_Api.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDGetPwd_Api' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vanstone.transex.ped.IGetPinResultListenner']]"
			[Register ("PEDGetPwd_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetPinResultListenner;)I", "GetPEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_Handler")]
			public override unsafe int PEDGetPwd_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p6)
			{
				const string __id = "PEDGetPwd_Api.(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetPinResultListenner;)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDMac_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
			[Register ("PEDMac_Api", "(II[BI[BI)I", "GetPEDMac_Api_IIarrayBIarrayBIHandler")]
			public override unsafe int PEDMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5)
			{
				const string __id = "PEDMac_Api.(II[BI[BI)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDReadPinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("PEDReadPinPadSn_Api", "([B)I", "GetPEDReadPinPadSn_Api_arrayBHandler")]
			public override unsafe int PEDReadPinPadSn_Api (byte[]? p0)
			{
				const string __id = "PEDReadPinPadSn_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSavePinPadSn_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("PEDSavePinPadSn_Api", "([B)I", "GetPEDSavePinPadSn_Api_arrayBHandler")]
			public override unsafe int PEDSavePinPadSn_Api (byte[]? p0)
			{
				const string __id = "PEDSavePinPadSn_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetDesSmHdSoft_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PEDSetDesSmHdSoft_Api", "(II)I", "GetPEDSetDesSmHdSoft_Api_IIHandler")]
			public override unsafe int PEDSetDesSmHdSoft_Api (int p0, int p1)
			{
				const string __id = "PEDSetDesSmHdSoft_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetHdSoft_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PEDSetHdSoft_Api", "(I)I", "GetPEDSetHdSoft_Api_IHandler")]
			public override unsafe int PEDSetHdSoft_Api (int p0)
			{
				const string __id = "PEDSetHdSoft_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSetKeyType_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("PEDSetKeyType_Api", "(I)V", "GetPEDSetKeyType_Api_IHandler")]
			public override unsafe void PEDSetKeyType_Api (int p0)
			{
				const string __id = "PEDSetKeyType_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDSnMacOnly_Api' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("PEDSnMacOnly_Api", "([BI[BI)I", "GetPEDSnMacOnly_Api_arrayBIarrayBIHandler")]
			public override unsafe int PEDSnMacOnly_Api (byte[]? p0, int p1, byte[]? p2, int p3)
			{
				const string __id = "PEDSnMacOnly_Api.([BI[BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDStopPin' and count(parameter)=0]"
			[Register ("PEDStopPin", "()I", "GetPEDStopPinHandler")]
			public override unsafe int PEDStopPin ()
			{
				const string __id = "PEDStopPin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWrite21Key_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("PEDWrite21Key_Api", "(I[B)I", "GetPEDWrite21Key_Api_IarrayBHandler")]
			public override unsafe int PEDWrite21Key_Api (int p0, byte[]? p1)
			{
				const string __id = "PEDWrite21Key_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteIcBcKeyWithType_Api' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("PEDWriteIcBcKeyWithType_Api", "([BIIII)I", "GetPEDWriteIcBcKeyWithType_Api_arrayBIIIIHandler")]
			public override unsafe int PEDWriteIcBcKeyWithType_Api (byte[]? p0, int p1, int p2, int p3, int p4)
			{
				const string __id = "PEDWriteIcBcKeyWithType_Api.([BIIII)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteIcBcKey_Api' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
			[Register ("PEDWriteIcBcKey_Api", "([BIIIII[B)I", "GetPEDWriteIcBcKey_Api_arrayBIIIIIarrayBHandler")]
			public override unsafe int PEDWriteIcBcKey_Api (byte[]? p0, int p1, int p2, int p3, int p4, int p5, byte[]? p6)
			{
				const string __id = "PEDWriteIcBcKey_Api.([BIIIII[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (native_p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteKey_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
			[Register ("PEDWriteKey_Api", "(II[BII[B)I", "GetPEDWriteKey_Api_IIarrayBIIarrayBHandler")]
			public override unsafe int PEDWriteKey_Api (int p0, int p1, byte[]? p2, int p3, int p4, byte[]? p5)
			{
				const string __id = "PEDWriteKey_Api.(II[BII[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteMKey_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("PEDWriteMKey_Api", "(II[B)I", "GetPEDWriteMKey_Api_IIarrayBHandler")]
			public override unsafe int PEDWriteMKey_Api (int p0, int p1, byte[]? p2)
			{
				const string __id = "PEDWriteMKey_Api.(II[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PEDWriteWKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("PEDWriteWKey_Api", "(III[B)I", "GetPEDWriteWKey_Api_IIIarrayBHandler")]
			public override unsafe int PEDWriteWKey_Api (int p0, int p1, int p2, byte[]? p3)
			{
				const string __id = "PEDWriteWKey_Api.(III[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedCalcDESDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
			[Register ("PedCalcDESDukpt_Api", "(BB[B[BB[B[B)I", "GetPedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayBHandler")]
			public override unsafe int PedCalcDESDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, sbyte p4, byte[]? p5, byte[]? p6)
			{
				const string __id = "PedCalcDESDukpt_Api.(BB[B[BB[B[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (native_p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p5);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedCalcSymDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
			[Register ("PedCalcSymDukpt_Api", "(BB[B[BIB[B)I", "GetPedCalcSymDukpt_Api_BBarrayBarrayBIBarrayBHandler")]
			public override unsafe int PedCalcSymDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, int p4, sbyte p5, byte[]? p6)
			{
				const string __id = "PedCalcSymDukpt_Api.(BB[B[BIB[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (native_p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedDukptIncreaseKsn_Api' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("PedDukptIncreaseKsn_Api", "(B)I", "GetPedDukptIncreaseKsn_Api_BHandler")]
			public override unsafe int PedDukptIncreaseKsn_Api (sbyte p0)
			{
				const string __id = "PedDukptIncreaseKsn_Api.(B)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedDukptWriteTIK_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]']]"
			[Register ("PedDukptWriteTIK_Api", "(BBB[B[BB[B)I", "GetPedDukptWriteTIK_Api_BBBarrayBarrayBBarrayBHandler")]
			public override unsafe int PedDukptWriteTIK_Api (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, byte[]? p6)
			{
				const string __id = "PedDukptWriteTIK_Api.(BBB[B[BB[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (native_p6);
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
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedEraseAll_Api' and count(parameter)=0]"
			[Register ("PedEraseAll_Api", "()Z", "GetPedEraseAll_ApiHandler")]
			public override unsafe bool PedEraseAll_Api ()
			{
				const string __id = "PedEraseAll_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedErase_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("PedErase_Api", "(II)Z", "GetPedErase_Api_IIHandler")]
			public override unsafe bool PedErase_Api (int p0, int p1)
			{
				const string __id = "PedErase_Api.(II)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedGetDukptKSN_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("PedGetDukptKSN_Api", "(B[B)I", "GetPedGetDukptKSN_Api_BarrayBHandler")]
			public override unsafe int PedGetDukptKSN_Api (sbyte p0, byte[]? p1)
			{
				const string __id = "PedGetDukptKSN_Api.(B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedGetMacDukpt_Api' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte']]"
			[Register ("PedGetMacDukpt_Api", "(BB[BI[B[BB)I", "GetPedGetMacDukpt_Api_BBarrayBIarrayBarrayBBHandler")]
			public override unsafe int PedGetMacDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5, sbyte p6)
			{
				const string __id = "PedGetMacDukpt_Api.(BB[BI[B[BB)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='PedSelectPlace_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("PedSelectPlace_Api", "(Ljava/lang/String;)I", "GetPedSelectPlace_Api_Ljava_lang_String_Handler")]
			public override unsafe int PedSelectPlace_Api (string? p0)
			{
				const string __id = "PedSelectPlace_Api.(Ljava/lang/String;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSAEnAndDe_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("RSAEnAndDe_Api", "(I[B[B[B)I", "GetRSAEnAndDe_Api_IarrayBarrayBarrayBHandler")]
			public override unsafe int RSAEnAndDe_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3)
			{
				const string __id = "RSAEnAndDe_Api.(I[B[B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSASign_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("RSASign_Api", "([B[B[B)I", "GetRSASign_Api_arrayBarrayBarrayBHandler")]
			public override unsafe int RSASign_Api (byte[]? p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "RSASign_Api.([B[B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='RSAVerify_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("RSAVerify_Api", "([B[B[B)I", "GetRSAVerify_Api_arrayBarrayBarrayBHandler")]
			public override unsafe int RSAVerify_Api (byte[]? p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "RSAVerify_Api.([B[B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='TR31_WriteKey_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("TR31_WriteKey_Api", "(I[B[B[B)I", "GetTR31_WriteKey_Api_IarrayBarrayBarrayBHandler")]
			public override unsafe int TR31_WriteKey_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3)
			{
				const string __id = "TR31_WriteKey_Api.(I[B[B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calAes_Api' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
			[Register ("calAes_Api", "(II[BI[BI[B)I", "GetCalAes_Api_IIarrayBIarrayBIarrayBHandler")]
			public override unsafe int CalAes_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5, byte[]? p6)
			{
				const string __id = "calAes_Api.(II[BI[BI[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (native_p6);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcAesDukpt' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte[]'] and parameter[8][@type='byte[]']]"
			[Register ("calcAesDukpt", "(BB[BI[BB[B[B)I", "GetCalcAesDukpt_BBarrayBIarrayBBarrayBarrayBHandler")]
			public override unsafe int CalcAesDukpt (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, sbyte p5, byte[]? p6, byte[]? p7)
			{
				const string __id = "calcAesDukpt.(BB[BI[BB[B[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				IntPtr native_p7 = JNIEnv.NewArray (p7);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (native_p6);
					__args [7] = new JniArgumentValue (native_p7);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					if (p7 != null) {
						JNIEnv.CopyArray (native_p7, p7);
						JNIEnv.DeleteLocalRef (native_p7);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p6);
					global::System.GC.KeepAlive (p7);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAEx_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAEx_Api", "(II[B[B[B)I", "GetCalcRSAEx_Api_IIarrayBarrayBarrayBHandler")]
			public override unsafe int CalcRSAEx_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4)
			{
				const string __id = "calcRSAEx_Api.(II[B[B[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAPri_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAPri_Api", "(III[B[B)I", "GetCalcRSAPri_Api_IIIarrayBarrayBHandler")]
			public override unsafe int CalcRSAPri_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4)
			{
				const string __id = "calcRSAPri_Api.(III[B[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSAPub_Api' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
			[Register ("calcRSAPub_Api", "(III[B[B)I", "GetCalcRSAPub_Api_IIIarrayBarrayBHandler")]
			public override unsafe int CalcRSAPub_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4)
			{
				const string __id = "calcRSAPub_Api.(III[B[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='calcRSA_Api' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
			[Register ("calcRSA_Api", "(B[B[B[B)I", "GetCalcRSA_Api_BarrayBarrayBarrayBHandler")]
			public override unsafe int CalcRSA_Api (sbyte p0, byte[]? p1, byte[]? p2, byte[]? p3)
			{
				const string __id = "calcRSA_Api.(B[B[B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getAesDukptKsn' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("getAesDukptKsn", "(B[B)I", "GetGetAesDukptKsn_BarrayBHandler")]
			public override unsafe int GetAesDukptKsn (sbyte p0, byte[]? p1)
			{
				const string __id = "getAesDukptKsn.(B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getKeyPairHdOrSoftg' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("getKeyPairHdOrSoftg", "(I[B[B)I", "GetGetKeyPairHdOrSoftg_IarrayBarrayBHandler")]
			public override unsafe int GetKeyPairHdOrSoftg (int p0, byte[]? p1, byte[]? p2)
			{
				const string __id = "getKeyPairHdOrSoftg.(I[B[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getMacAesDukpt' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("getMacAesDukpt", "(BIB[B[B[B)I", "GetGetMacAesDukpt_BIBarrayBarrayBarrayBHandler")]
			public override unsafe int GetMacAesDukpt (sbyte p0, int p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5)
			{
				const string __id = "getMacAesDukpt.(BIB[B[B[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
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
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getPinAESDukptEx' and count(parameter)=7 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]']]"
			[Register ("getPinAESDukptEx", "(BBB[B[B[B[B)I", "GetGetPinAESDukptEx_BBBarrayBarrayBarrayBarrayBHandler")]
			public override unsafe int GetPinAESDukptEx (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6)
			{
				const string __id = "getPinAESDukptEx.(BBB[B[B[B[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				IntPtr native_p6 = JNIEnv.NewArray (p6);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (native_p6);
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
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					if (p6 != null) {
						JNIEnv.CopyArray (native_p6, p6);
						JNIEnv.DeleteLocalRef (native_p6);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
					global::System.GC.KeepAlive (p6);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getPinDukptEx_Api' and count(parameter)=6 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("getPinDukptEx_Api", "(BBLjava/lang/String;Ljava/lang/String;[B[B)I", "GetGetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayBHandler")]
			public override unsafe int GetPinDukptEx_Api (sbyte p0, sbyte p1, string? p2, string? p3, byte[]? p4, byte[]? p5)
			{
				const string __id = "getPinDukptEx_Api.(BBLjava/lang/String;Ljava/lang/String;[B[B)I";
				IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
				IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='getRSAKeyPair_Api' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register ("getRSAKeyPair_Api", "(III[B)I", "GetGetRSAKeyPair_Api_IIIarrayBHandler")]
			public override unsafe int GetRSAKeyPair_Api (int p0, int p1, int p2, byte[]? p3)
			{
				const string __id = "getRSAKeyPair_Api.(III[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='isKeyExist_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("isKeyExist_Api", "(II)Z", "GetIsKeyExist_Api_IIHandler")]
			public override unsafe bool IsKeyExist_Api (int p0, int p1)
			{
				const string __id = "isKeyExist_Api.(II)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountColor", "(Ljava/lang/String;)V", "GetSetAmountColor_Ljava_lang_String_Handler")]
			public override unsafe void SetAmountColor (string? p0)
			{
				const string __id = "setAmountColor.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountFont", "(Ljava/lang/String;)V", "GetSetAmountFont_Ljava_lang_String_Handler")]
			public override unsafe void SetAmountFont (string? p0)
			{
				const string __id = "setAmountFont.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setAmountSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAmountSize", "(F)V", "GetSetAmountSize_FHandler")]
			public override unsafe void SetAmountSize (float p0)
			{
				const string __id = "setAmountSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomBtnText' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("setBottomBtnText", "([Ljava/lang/String;)V", "GetSetBottomBtnText_arrayLjava_lang_String_Handler")]
			public override unsafe void SetBottomBtnText (string[]? p0)
			{
				const string __id = "setBottomBtnText.([Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBottomFont", "(Ljava/lang/String;)V", "GetSetBottomFont_Ljava_lang_String_Handler")]
			public override unsafe void SetBottomFont (string? p0)
			{
				const string __id = "setBottomFont.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBottomTextColor", "(Ljava/lang/String;)V", "GetSetBottomTextColor_Ljava_lang_String_Handler")]
			public override unsafe void SetBottomTextColor (string? p0)
			{
				const string __id = "setBottomTextColor.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setBottomTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBottomTextSize", "(F)V", "GetSetBottomTextSize_FHandler")]
			public override unsafe void SetBottomTextSize (float p0)
			{
				const string __id = "setBottomTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setCardNo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardNo", "(Ljava/lang/String;)V", "GetSetCardNo_Ljava_lang_String_Handler")]
			public override unsafe void SetCardNo (string? p0)
			{
				const string __id = "setCardNo.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setDispAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDispAmt", "(Ljava/lang/String;)V", "GetSetDispAmt_Ljava_lang_String_Handler")]
			public override unsafe void SetDispAmt (string? p0)
			{
				const string __id = "setDispAmt.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNumColor", "(Ljava/lang/String;)V", "GetSetNumColor_Ljava_lang_String_Handler")]
			public override unsafe void SetNumColor (string? p0)
			{
				const string __id = "setNumColor.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNumFont", "(Ljava/lang/String;)V", "GetSetNumFont_Ljava_lang_String_Handler")]
			public override unsafe void SetNumFont (string? p0)
			{
				const string __id = "setNumFont.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setNumSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setNumSize", "(F)V", "GetSetNumSize_FHandler")]
			public override unsafe void SetNumSize (float p0)
			{
				const string __id = "setNumSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardFixed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPinBoardFixed", "(Z)V", "GetSetPinBoardFixed_ZHandler")]
			public override unsafe void SetPinBoardFixed (bool p0)
			{
				const string __id = "setPinBoardFixed.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardKey_Api' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardKey_Api", "(Landroid/os/Bundle;)I", "GetSetPinBoardKey_Api_Landroid_os_Bundle_Handler")]
			public override unsafe int SetPinBoardKey_Api (global::Android.OS.Bundle? p0)
			{
				const string __id = "setPinBoardKey_Api.(Landroid/os/Bundle;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardMsg' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardMsg", "(Landroid/os/Bundle;)V", "GetSetPinBoardMsg_Landroid_os_Bundle_Handler")]
			public override unsafe void SetPinBoardMsg (global::Android.OS.Bundle? p0)
			{
				const string __id = "setPinBoardMsg.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardSetting' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setPinBoardSetting", "(Landroid/os/Bundle;)V", "GetSetPinBoardSetting_Landroid_os_Bundle_Handler")]
			public override unsafe void SetPinBoardSetting (global::Android.OS.Bundle? p0)
			{
				const string __id = "setPinBoardSetting.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setPinBoardStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPinBoardStyle", "(I)V", "GetSetPinBoardStyle_IHandler")]
			public override unsafe void SetPinBoardStyle (int p0)
			{
				const string __id = "setPinBoardStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setStatusbarColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusbarColor", "(Ljava/lang/String;)V", "GetSetStatusbarColor_Ljava_lang_String_Handler")]
			public override unsafe void SetStatusbarColor (string? p0)
			{
				const string __id = "setStatusbarColor.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setStatusbarHide' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStatusbarHide", "(Z)V", "GetSetStatusbarHide_ZHandler")]
			public override unsafe void SetStatusbarHide (bool p0)
			{
				const string __id = "setStatusbarHide.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextColor", "(Ljava/lang/String;)V", "GetSetTextColor_Ljava_lang_String_Handler")]
			public override unsafe void SetTextColor (string? p0)
			{
				const string __id = "setTextColor.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextFont' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextFont", "(Ljava/lang/String;)V", "GetSetTextFont_Ljava_lang_String_Handler")]
			public override unsafe void SetTextFont (string? p0)
			{
				const string __id = "setTextFont.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTextSize", "(F)V", "GetSetTextSize_FHandler")]
			public override unsafe void SetTextSize (float p0)
			{
				const string __id = "setTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='setTitleBackGroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitleBackGroundColor", "(Ljava/lang/String;)V", "GetSetTitleBackGroundColor_Ljava_lang_String_Handler")]
			public override unsafe void SetTitleBackGroundColor (string? p0)
			{
				const string __id = "setTitleBackGroundColor.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeAesKey' and count(parameter)=9 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='byte'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte'] and parameter[8][@type='byte'] and parameter[9][@type='byte[]']]"
			[Register ("writeAesKey", "(BIBIB[BBB[B)I", "GetWriteAesKey_BIBIBarrayBBBarrayBHandler")]
			public override unsafe int WriteAesKey (sbyte p0, int p1, sbyte p2, int p3, sbyte p4, byte[]? p5, sbyte p6, sbyte p7, byte[]? p8)
			{
				const string __id = "writeAesKey.(BIBIB[BBB[B)I";
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				IntPtr native_p8 = JNIEnv.NewArray (p8);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [9];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (native_p5);
					__args [6] = new JniArgumentValue (p6);
					__args [7] = new JniArgumentValue (p7);
					__args [8] = new JniArgumentValue (native_p8);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					if (p8 != null) {
						JNIEnv.CopyArray (native_p8, p8);
						JNIEnv.DeleteLocalRef (native_p8);
					}
					global::System.GC.KeepAlive (p5);
					global::System.GC.KeepAlive (p8);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeAesTik' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte'] and parameter[7][@type='byte'] and parameter[8][@type='byte[]']]"
			[Register ("writeAesTik", "(BBB[B[BBB[B)I", "GetWriteAesTik_BBBarrayBarrayBBBarrayBHandler")]
			public override unsafe int WriteAesTik (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, sbyte p6, byte[]? p7)
			{
				const string __id = "writeAesTik.(BBB[B[BBB[B)I";
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p7 = JNIEnv.NewArray (p7);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (p6);
					__args [7] = new JniArgumentValue (native_p7);
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
					if (p7 != null) {
						JNIEnv.CopyArray (native_p7, p7);
						JNIEnv.DeleteLocalRef (native_p7);
					}
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p7);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeDerivedKey' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("writeDerivedKey", "(II[BI)I", "GetWriteDerivedKey_IIarrayBIHandler")]
			public override unsafe int WriteDerivedKey (int p0, int p1, byte[]? p2, int p3)
			{
				const string __id = "writeDerivedKey.(II[BI)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeRSAKeyEx_Api' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
			[Register ("writeRSAKeyEx_Api", "(II[BI[B[B)I", "GetWriteRSAKeyEx_Api_IIarrayBIarrayBarrayBHandler")]
			public override unsafe int WriteRSAKeyEx_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5)
			{
				const string __id = "writeRSAKeyEx_Api.(II[BI[B[B)I";
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (native_p5);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
					if (p5 != null) {
						JNIEnv.CopyArray (native_p5, p5);
						JNIEnv.DeleteLocalRef (native_p5);
					}
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p4);
					global::System.GC.KeepAlive (p5);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.ped']/interface[@name='PedHandler']/method[@name='writeRSAKey_Api' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
			[Register ("writeRSAKey_Api", "(B[B)I", "GetWriteRSAKey_Api_BarrayBHandler")]
			public override unsafe int WriteRSAKey_Api (sbyte p0, byte[]? p1)
			{
				const string __id = "writeRSAKey_Api.(B[B)I";
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

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/ped/PedHandler", DoNotGenerateAcw=true)]
	internal partial class IPedHandlerInvoker : global::Java.Lang.Object, IPedHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/ped/PedHandler", typeof (IPedHandlerInvoker));

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

		public static IPedHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPedHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.ped.PedHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPedHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetKMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBIHandler ()
		{
			if (cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI == null)
				cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILLLLI_I (n_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI));
			return cb_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI;
		}

		static int n_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, int p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.KMS_TR31_DukptWriteTIK_Api (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI;
		public unsafe int KMS_TR31_DukptWriteTIK_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6, int p7)
		{
			if (id_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI == IntPtr.Zero)
				id_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI = JNIEnv.GetMethodID (class_ref, "KMS_TR31_DukptWriteTIK_Api", "(III[B[B[B[BI)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (p7);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_KMS_TR31_DukptWriteTIK_Api_IIIarrayBarrayBarrayBarrayBI, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate? cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetKMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayBHandler ()
		{
			if (cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB == null)
				cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILLL_I (n_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB));
			return cb_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB;
		}

		static int n_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.KMS_TR31_MwriteKey_Api (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB;
		public unsafe int KMS_TR31_MwriteKey_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4)
		{
			if (id_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB == IntPtr.Zero)
				id_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "KMS_TR31_MwriteKey_Api", "(II[B[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_KMS_TR31_MwriteKey_Api_IIarrayBarrayBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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

		static Delegate? cb_PEDBigDataMac_Api_IIarrayBIarrayBI;
#pragma warning disable 0169
		static Delegate GetPEDBigDataMac_Api_IIarrayBIarrayBIHandler ()
		{
			if (cb_PEDBigDataMac_Api_IIarrayBIarrayBI == null)
				cb_PEDBigDataMac_Api_IIarrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILI_I (n_PEDBigDataMac_Api_IIarrayBIarrayBI));
			return cb_PEDBigDataMac_Api_IIarrayBIarrayBI;
		}

		static int n_PEDBigDataMac_Api_IIarrayBIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDBigDataMac_Api (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDBigDataMac_Api_IIarrayBIarrayBI;
		public unsafe int PEDBigDataMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5)
		{
			if (id_PEDBigDataMac_Api_IIarrayBIarrayBI == IntPtr.Zero)
				id_PEDBigDataMac_Api_IIarrayBIarrayBI = JNIEnv.GetMethodID (class_ref, "PEDBigDataMac_Api", "(II[BI[BI)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDBigDataMac_Api_IIarrayBIarrayBI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetPEDDesCBC_Api_IIIarrayBIarrayBIarrayBHandler ()
		{
			if (cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB == null)
				cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILILIL_I (n_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB));
			return cb_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB;
		}

		static int n_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, int p4, IntPtr native_p5, int p6, IntPtr native_p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDDesCBC_Api (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB;
		public unsafe int PEDDesCBC_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5, int p6, byte[]? p7)
		{
			if (id_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB == IntPtr.Zero)
				id_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB = JNIEnv.GetMethodID (class_ref, "PEDDesCBC_Api", "(III[BI[BI[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			__args [7] = new JValue (native_p7);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDDesCBC_Api_IIIarrayBIarrayBIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			if (p7 != null) {
				JNIEnv.CopyArray (native_p7, p7);
				JNIEnv.DeleteLocalRef (native_p7);
			}
			return __ret;
		}

		static Delegate? cb_PEDDes_Api_IIIarrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetPEDDes_Api_IIIarrayBIarrayBHandler ()
		{
			if (cb_PEDDes_Api_IIIarrayBIarrayB == null)
				cb_PEDDes_Api_IIIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILIL_I (n_PEDDes_Api_IIIarrayBIarrayB));
			return cb_PEDDes_Api_IIIarrayBIarrayB;
		}

		static int n_PEDDes_Api_IIIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, int p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDDes_Api (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDDes_Api_IIIarrayBIarrayB;
		public unsafe int PEDDes_Api (int p0, int p1, int p2, byte[]? p3, int p4, byte[]? p5)
		{
			if (id_PEDDes_Api_IIIarrayBIarrayB == IntPtr.Zero)
				id_PEDDes_Api_IIIarrayBIarrayB = JNIEnv.GetMethodID (class_ref, "PEDDes_Api", "(III[BI[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDDes_Api_IIIarrayBIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_;
#pragma warning disable 0169
		static Delegate GetPEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_Handler ()
		{
			if (cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ == null)
				cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLILIIL_I (n_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_));
			return cb_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_;
		}

		static int n_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, int p4, int p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (global::Com.Vanstone.Transex.Ped.IGetDukptPinListener?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetDukptPinListener> (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PEDGetDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_;
		public unsafe int PEDGetDukpt_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetDukptPinListener? p6)
		{
			if (id_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ == IntPtr.Zero)
				id_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_ = JNIEnv.GetMethodID (class_ref, "PEDGetDukpt_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetDukptPinListener;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDGetDukpt_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetDukptPinListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_;
#pragma warning disable 0169
		static Delegate GetPEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_Handler ()
		{
			if (cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ == null)
				cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIL_I (n_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_));
			return cb_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_;
		}

		static int n_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (global::Com.Vanstone.Transex.Ped.IGetPinResultListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PEDGetExpress_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_;
		public unsafe int PEDGetExpress_Api (string? p0, byte[]? p1, int p2, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p3)
		{
			if (id_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ == IntPtr.Zero)
				id_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNIEnv.GetMethodID (class_ref, "PEDGetExpress_Api", "(Ljava/lang/String;[BILcom/vanstone/transex/ped/IGetPinResultListenner;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDGetExpress_Api_Ljava_lang_String_arrayBILcom_vanstone_transex_ped_IGetPinResultListenner_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_PEDGetHdSoft_Api;
#pragma warning disable 0169
		static Delegate GetPEDGetHdSoft_ApiHandler ()
		{
			if (cb_PEDGetHdSoft_Api == null)
				cb_PEDGetHdSoft_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PEDGetHdSoft_Api));
			return cb_PEDGetHdSoft_Api;
		}

		static int n_PEDGetHdSoft_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PEDGetHdSoft_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PEDGetHdSoft_Api;
		public unsafe int PEDGetHdSoft_Api ()
		{
			if (id_PEDGetHdSoft_Api == IntPtr.Zero)
				id_PEDGetHdSoft_Api = JNIEnv.GetMethodID (class_ref, "PEDGetHdSoft_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDGetHdSoft_Api);
		}

		static Delegate? cb_PEDGetLastError_Api;
#pragma warning disable 0169
		static Delegate GetPEDGetLastError_ApiHandler ()
		{
			if (cb_PEDGetLastError_Api == null)
				cb_PEDGetLastError_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_PEDGetLastError_Api));
			return cb_PEDGetLastError_Api;
		}

		static IntPtr n_PEDGetLastError_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PEDGetLastError_Api ());
		}
#pragma warning restore 0169

		IntPtr id_PEDGetLastError_Api;
		public unsafe string? PEDGetLastError_Api ()
		{
			if (id_PEDGetLastError_Api == IntPtr.Zero)
				id_PEDGetLastError_Api = JNIEnv.GetMethodID (class_ref, "PEDGetLastError_Api", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_PEDGetLastError_Api), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_;
#pragma warning disable 0169
		static Delegate GetPEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_Handler ()
		{
			if (cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ == null)
				cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLILIIL_I (n_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_));
			return cb_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_;
		}

		static int n_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, int p4, int p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (global::Com.Vanstone.Transex.Ped.IGetPinResultListenner?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Transex.Ped.IGetPinResultListenner> (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PEDGetPwd_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_;
		public unsafe int PEDGetPwd_Api (string? p0, byte[]? p1, int p2, byte[]? p3, int p4, int p5, global::Com.Vanstone.Transex.Ped.IGetPinResultListenner? p6)
		{
			if (id_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ == IntPtr.Zero)
				id_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_ = JNIEnv.GetMethodID (class_ref, "PEDGetPwd_Api", "(Ljava/lang/String;[BI[BIILcom/vanstone/transex/ped/IGetPinResultListenner;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDGetPwd_Api_Ljava_lang_String_arrayBIarrayBIILcom_vanstone_transex_ped_IGetPinResultListenner_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_PEDMac_Api_IIarrayBIarrayBI;
#pragma warning disable 0169
		static Delegate GetPEDMac_Api_IIarrayBIarrayBIHandler ()
		{
			if (cb_PEDMac_Api_IIarrayBIarrayBI == null)
				cb_PEDMac_Api_IIarrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILI_I (n_PEDMac_Api_IIarrayBIarrayBI));
			return cb_PEDMac_Api_IIarrayBIarrayBI;
		}

		static int n_PEDMac_Api_IIarrayBIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDMac_Api (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDMac_Api_IIarrayBIarrayBI;
		public unsafe int PEDMac_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5)
		{
			if (id_PEDMac_Api_IIarrayBIarrayBI == IntPtr.Zero)
				id_PEDMac_Api_IIarrayBIarrayBI = JNIEnv.GetMethodID (class_ref, "PEDMac_Api", "(II[BI[BI)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDMac_Api_IIarrayBIarrayBI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate? cb_PEDReadPinPadSn_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetPEDReadPinPadSn_Api_arrayBHandler ()
		{
			if (cb_PEDReadPinPadSn_Api_arrayB == null)
				cb_PEDReadPinPadSn_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PEDReadPinPadSn_Api_arrayB));
			return cb_PEDReadPinPadSn_Api_arrayB;
		}

		static int n_PEDReadPinPadSn_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDReadPinPadSn_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDReadPinPadSn_Api_arrayB;
		public unsafe int PEDReadPinPadSn_Api (byte[]? p0)
		{
			if (id_PEDReadPinPadSn_Api_arrayB == IntPtr.Zero)
				id_PEDReadPinPadSn_Api_arrayB = JNIEnv.GetMethodID (class_ref, "PEDReadPinPadSn_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDReadPinPadSn_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_PEDSavePinPadSn_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetPEDSavePinPadSn_Api_arrayBHandler ()
		{
			if (cb_PEDSavePinPadSn_Api_arrayB == null)
				cb_PEDSavePinPadSn_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PEDSavePinPadSn_Api_arrayB));
			return cb_PEDSavePinPadSn_Api_arrayB;
		}

		static int n_PEDSavePinPadSn_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDSavePinPadSn_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDSavePinPadSn_Api_arrayB;
		public unsafe int PEDSavePinPadSn_Api (byte[]? p0)
		{
			if (id_PEDSavePinPadSn_Api_arrayB == IntPtr.Zero)
				id_PEDSavePinPadSn_Api_arrayB = JNIEnv.GetMethodID (class_ref, "PEDSavePinPadSn_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDSavePinPadSn_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_PEDSetDesSmHdSoft_Api_II;
#pragma warning disable 0169
		static Delegate GetPEDSetDesSmHdSoft_Api_IIHandler ()
		{
			if (cb_PEDSetDesSmHdSoft_Api_II == null)
				cb_PEDSetDesSmHdSoft_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_PEDSetDesSmHdSoft_Api_II));
			return cb_PEDSetDesSmHdSoft_Api_II;
		}

		static int n_PEDSetDesSmHdSoft_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PEDSetDesSmHdSoft_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_PEDSetDesSmHdSoft_Api_II;
		public unsafe int PEDSetDesSmHdSoft_Api (int p0, int p1)
		{
			if (id_PEDSetDesSmHdSoft_Api_II == IntPtr.Zero)
				id_PEDSetDesSmHdSoft_Api_II = JNIEnv.GetMethodID (class_ref, "PEDSetDesSmHdSoft_Api", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDSetDesSmHdSoft_Api_II, __args);
		}

		static Delegate? cb_PEDSetHdSoft_Api_I;
#pragma warning disable 0169
		static Delegate GetPEDSetHdSoft_Api_IHandler ()
		{
			if (cb_PEDSetHdSoft_Api_I == null)
				cb_PEDSetHdSoft_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_PEDSetHdSoft_Api_I));
			return cb_PEDSetHdSoft_Api_I;
		}

		static int n_PEDSetHdSoft_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PEDSetHdSoft_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PEDSetHdSoft_Api_I;
		public unsafe int PEDSetHdSoft_Api (int p0)
		{
			if (id_PEDSetHdSoft_Api_I == IntPtr.Zero)
				id_PEDSetHdSoft_Api_I = JNIEnv.GetMethodID (class_ref, "PEDSetHdSoft_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDSetHdSoft_Api_I, __args);
		}

		static Delegate? cb_PEDSetKeyType_Api_I;
#pragma warning disable 0169
		static Delegate GetPEDSetKeyType_Api_IHandler ()
		{
			if (cb_PEDSetKeyType_Api_I == null)
				cb_PEDSetKeyType_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_PEDSetKeyType_Api_I));
			return cb_PEDSetKeyType_Api_I;
		}

		static void n_PEDSetKeyType_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PEDSetKeyType_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PEDSetKeyType_Api_I;
		public unsafe void PEDSetKeyType_Api (int p0)
		{
			if (id_PEDSetKeyType_Api_I == IntPtr.Zero)
				id_PEDSetKeyType_Api_I = JNIEnv.GetMethodID (class_ref, "PEDSetKeyType_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PEDSetKeyType_Api_I, __args);
		}

		static Delegate? cb_PEDSnMacOnly_Api_arrayBIarrayBI;
#pragma warning disable 0169
		static Delegate GetPEDSnMacOnly_Api_arrayBIarrayBIHandler ()
		{
			if (cb_PEDSnMacOnly_Api_arrayBIarrayBI == null)
				cb_PEDSnMacOnly_Api_arrayBIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_I (n_PEDSnMacOnly_Api_arrayBIarrayBI));
			return cb_PEDSnMacOnly_Api_arrayBIarrayBI;
		}

		static int n_PEDSnMacOnly_Api_arrayBIarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDSnMacOnly_Api (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDSnMacOnly_Api_arrayBIarrayBI;
		public unsafe int PEDSnMacOnly_Api (byte[]? p0, int p1, byte[]? p2, int p3)
		{
			if (id_PEDSnMacOnly_Api_arrayBIarrayBI == IntPtr.Zero)
				id_PEDSnMacOnly_Api_arrayBIarrayBI = JNIEnv.GetMethodID (class_ref, "PEDSnMacOnly_Api", "([BI[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDSnMacOnly_Api_arrayBIarrayBI, __args);
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

		static Delegate? cb_PEDStopPin;
#pragma warning disable 0169
		static Delegate GetPEDStopPinHandler ()
		{
			if (cb_PEDStopPin == null)
				cb_PEDStopPin = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_PEDStopPin));
			return cb_PEDStopPin;
		}

		static int n_PEDStopPin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PEDStopPin ();
		}
#pragma warning restore 0169

		IntPtr id_PEDStopPin;
		public unsafe int PEDStopPin ()
		{
			if (id_PEDStopPin == IntPtr.Zero)
				id_PEDStopPin = JNIEnv.GetMethodID (class_ref, "PEDStopPin", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDStopPin);
		}

		static Delegate? cb_PEDWrite21Key_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetPEDWrite21Key_Api_IarrayBHandler ()
		{
			if (cb_PEDWrite21Key_Api_IarrayB == null)
				cb_PEDWrite21Key_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_PEDWrite21Key_Api_IarrayB));
			return cb_PEDWrite21Key_Api_IarrayB;
		}

		static int n_PEDWrite21Key_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDWrite21Key_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDWrite21Key_Api_IarrayB;
		public unsafe int PEDWrite21Key_Api (int p0, byte[]? p1)
		{
			if (id_PEDWrite21Key_Api_IarrayB == IntPtr.Zero)
				id_PEDWrite21Key_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "PEDWrite21Key_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDWrite21Key_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII;
#pragma warning disable 0169
		static Delegate GetPEDWriteIcBcKeyWithType_Api_arrayBIIIIHandler ()
		{
			if (cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII == null)
				cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIII_I (n_PEDWriteIcBcKeyWithType_Api_arrayBIIII));
			return cb_PEDWriteIcBcKeyWithType_Api_arrayBIIII;
		}

		static int n_PEDWriteIcBcKeyWithType_Api_arrayBIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDWriteIcBcKeyWithType_Api (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDWriteIcBcKeyWithType_Api_arrayBIIII;
		public unsafe int PEDWriteIcBcKeyWithType_Api (byte[]? p0, int p1, int p2, int p3, int p4)
		{
			if (id_PEDWriteIcBcKeyWithType_Api_arrayBIIII == IntPtr.Zero)
				id_PEDWriteIcBcKeyWithType_Api_arrayBIIII = JNIEnv.GetMethodID (class_ref, "PEDWriteIcBcKeyWithType_Api", "([BIIII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDWriteIcBcKeyWithType_Api_arrayBIIII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB;
#pragma warning disable 0169
		static Delegate GetPEDWriteIcBcKey_Api_arrayBIIIIIarrayBHandler ()
		{
			if (cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB == null)
				cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIIIIL_I (n_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB));
			return cb_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB;
		}

		static int n_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDWriteIcBcKey_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB;
		public unsafe int PEDWriteIcBcKey_Api (byte[]? p0, int p1, int p2, int p3, int p4, int p5, byte[]? p6)
		{
			if (id_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB == IntPtr.Zero)
				id_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB = JNIEnv.GetMethodID (class_ref, "PEDWriteIcBcKey_Api", "([BIIIII[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDWriteIcBcKey_Api_arrayBIIIIIarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate? cb_PEDWriteKey_Api_IIarrayBIIarrayB;
#pragma warning disable 0169
		static Delegate GetPEDWriteKey_Api_IIarrayBIIarrayBHandler ()
		{
			if (cb_PEDWriteKey_Api_IIarrayBIIarrayB == null)
				cb_PEDWriteKey_Api_IIarrayBIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILIIL_I (n_PEDWriteKey_Api_IIarrayBIIarrayB));
			return cb_PEDWriteKey_Api_IIarrayBIIarrayB;
		}

		static int n_PEDWriteKey_Api_IIarrayBIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDWriteKey_Api (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDWriteKey_Api_IIarrayBIIarrayB;
		public unsafe int PEDWriteKey_Api (int p0, int p1, byte[]? p2, int p3, int p4, byte[]? p5)
		{
			if (id_PEDWriteKey_Api_IIarrayBIIarrayB == IntPtr.Zero)
				id_PEDWriteKey_Api_IIarrayBIIarrayB = JNIEnv.GetMethodID (class_ref, "PEDWriteKey_Api", "(II[BII[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDWriteKey_Api_IIarrayBIIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_PEDWriteMKey_Api_IIarrayB;
#pragma warning disable 0169
		static Delegate GetPEDWriteMKey_Api_IIarrayBHandler ()
		{
			if (cb_PEDWriteMKey_Api_IIarrayB == null)
				cb_PEDWriteMKey_Api_IIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_I (n_PEDWriteMKey_Api_IIarrayB));
			return cb_PEDWriteMKey_Api_IIarrayB;
		}

		static int n_PEDWriteMKey_Api_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDWriteMKey_Api (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDWriteMKey_Api_IIarrayB;
		public unsafe int PEDWriteMKey_Api (int p0, int p1, byte[]? p2)
		{
			if (id_PEDWriteMKey_Api_IIarrayB == IntPtr.Zero)
				id_PEDWriteMKey_Api_IIarrayB = JNIEnv.GetMethodID (class_ref, "PEDWriteMKey_Api", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDWriteMKey_Api_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_PEDWriteWKey_Api_IIIarrayB;
#pragma warning disable 0169
		static Delegate GetPEDWriteWKey_Api_IIIarrayBHandler ()
		{
			if (cb_PEDWriteWKey_Api_IIIarrayB == null)
				cb_PEDWriteWKey_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_PEDWriteWKey_Api_IIIarrayB));
			return cb_PEDWriteWKey_Api_IIIarrayB;
		}

		static int n_PEDWriteWKey_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PEDWriteWKey_Api (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PEDWriteWKey_Api_IIIarrayB;
		public unsafe int PEDWriteWKey_Api (int p0, int p1, int p2, byte[]? p3)
		{
			if (id_PEDWriteWKey_Api_IIIarrayB == IntPtr.Zero)
				id_PEDWriteWKey_Api_IIIarrayB = JNIEnv.GetMethodID (class_ref, "PEDWriteWKey_Api", "(III[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PEDWriteWKey_Api_IIIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetPedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayBHandler ()
		{
			if (cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB == null)
				cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLBLL_I (n_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB));
			return cb_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB;
		}

		static int n_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, sbyte p4, IntPtr native_p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PedCalcDESDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB;
		public unsafe int PedCalcDESDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, sbyte p4, byte[]? p5, byte[]? p6)
		{
			if (id_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB == IntPtr.Zero)
				id_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "PedCalcDESDukpt_Api", "(BB[B[BB[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PedCalcDESDukpt_Api_BBarrayBarrayBBarrayBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate? cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB;
#pragma warning disable 0169
		static Delegate GetPedCalcSymDukpt_Api_BBarrayBarrayBIBarrayBHandler ()
		{
			if (cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB == null)
				cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLIBL_I (n_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB));
			return cb_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB;
		}

		static int n_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, int p4, sbyte p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PedCalcSymDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB;
		public unsafe int PedCalcSymDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, byte[]? p3, int p4, sbyte p5, byte[]? p6)
		{
			if (id_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB == IntPtr.Zero)
				id_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB = JNIEnv.GetMethodID (class_ref, "PedCalcSymDukpt_Api", "(BB[B[BIB[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PedCalcSymDukpt_Api_BBarrayBarrayBIBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate? cb_PedDukptIncreaseKsn_Api_B;
#pragma warning disable 0169
		static Delegate GetPedDukptIncreaseKsn_Api_BHandler ()
		{
			if (cb_PedDukptIncreaseKsn_Api_B == null)
				cb_PedDukptIncreaseKsn_Api_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_I (n_PedDukptIncreaseKsn_Api_B));
			return cb_PedDukptIncreaseKsn_Api_B;
		}

		static int n_PedDukptIncreaseKsn_Api_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PedDukptIncreaseKsn_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_PedDukptIncreaseKsn_Api_B;
		public unsafe int PedDukptIncreaseKsn_Api (sbyte p0)
		{
			if (id_PedDukptIncreaseKsn_Api_B == IntPtr.Zero)
				id_PedDukptIncreaseKsn_Api_B = JNIEnv.GetMethodID (class_ref, "PedDukptIncreaseKsn_Api", "(B)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PedDukptIncreaseKsn_Api_B, __args);
		}

		static Delegate? cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB;
#pragma warning disable 0169
		static Delegate GetPedDukptWriteTIK_Api_BBBarrayBarrayBBarrayBHandler ()
		{
			if (cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB == null)
				cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLBL_I (n_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB));
			return cb_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB;
		}

		static int n_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, sbyte p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PedDukptWriteTIK_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB;
		public unsafe int PedDukptWriteTIK_Api (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, byte[]? p6)
		{
			if (id_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB == IntPtr.Zero)
				id_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB = JNIEnv.GetMethodID (class_ref, "PedDukptWriteTIK_Api", "(BBB[B[BB[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PedDukptWriteTIK_Api_BBBarrayBarrayBBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate? cb_PedEraseAll_Api;
#pragma warning disable 0169
		static Delegate GetPedEraseAll_ApiHandler ()
		{
			if (cb_PedEraseAll_Api == null)
				cb_PedEraseAll_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_PedEraseAll_Api));
			return cb_PedEraseAll_Api;
		}

		static bool n_PedEraseAll_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PedEraseAll_Api ();
		}
#pragma warning restore 0169

		IntPtr id_PedEraseAll_Api;
		public unsafe bool PedEraseAll_Api ()
		{
			if (id_PedEraseAll_Api == IntPtr.Zero)
				id_PedEraseAll_Api = JNIEnv.GetMethodID (class_ref, "PedEraseAll_Api", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_PedEraseAll_Api);
		}

		static Delegate? cb_PedErase_Api_II;
#pragma warning disable 0169
		static Delegate GetPedErase_Api_IIHandler ()
		{
			if (cb_PedErase_Api_II == null)
				cb_PedErase_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_PedErase_Api_II));
			return cb_PedErase_Api_II;
		}

		static bool n_PedErase_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.PedErase_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_PedErase_Api_II;
		public unsafe bool PedErase_Api (int p0, int p1)
		{
			if (id_PedErase_Api_II == IntPtr.Zero)
				id_PedErase_Api_II = JNIEnv.GetMethodID (class_ref, "PedErase_Api", "(II)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_PedErase_Api_II, __args);
		}

		static Delegate? cb_PedGetDukptKSN_Api_BarrayB;
#pragma warning disable 0169
		static Delegate GetPedGetDukptKSN_Api_BarrayBHandler ()
		{
			if (cb_PedGetDukptKSN_Api_BarrayB == null)
				cb_PedGetDukptKSN_Api_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_PedGetDukptKSN_Api_BarrayB));
			return cb_PedGetDukptKSN_Api_BarrayB;
		}

		static int n_PedGetDukptKSN_Api_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PedGetDukptKSN_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PedGetDukptKSN_Api_BarrayB;
		public unsafe int PedGetDukptKSN_Api (sbyte p0, byte[]? p1)
		{
			if (id_PedGetDukptKSN_Api_BarrayB == IntPtr.Zero)
				id_PedGetDukptKSN_Api_BarrayB = JNIEnv.GetMethodID (class_ref, "PedGetDukptKSN_Api", "(B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PedGetDukptKSN_Api_BarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB;
#pragma warning disable 0169
		static Delegate GetPedGetMacDukpt_Api_BBarrayBIarrayBarrayBBHandler ()
		{
			if (cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB == null)
				cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLILLB_I (n_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB));
			return cb_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB;
		}

		static int n_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5, sbyte p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PedGetMacDukpt_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB;
		public unsafe int PedGetMacDukpt_Api (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5, sbyte p6)
		{
			if (id_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB == IntPtr.Zero)
				id_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB = JNIEnv.GetMethodID (class_ref, "PedGetMacDukpt_Api", "(BB[BI[B[BB)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PedGetMacDukpt_Api_BBarrayBIarrayBarrayBB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_PedSelectPlace_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPedSelectPlace_Api_Ljava_lang_String_Handler ()
		{
			if (cb_PedSelectPlace_Api_Ljava_lang_String_ == null)
				cb_PedSelectPlace_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_PedSelectPlace_Api_Ljava_lang_String_));
			return cb_PedSelectPlace_Api_Ljava_lang_String_;
		}

		static int n_PedSelectPlace_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PedSelectPlace_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_PedSelectPlace_Api_Ljava_lang_String_;
		public unsafe int PedSelectPlace_Api (string? p0)
		{
			if (id_PedSelectPlace_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_PedSelectPlace_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "PedSelectPlace_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_PedSelectPlace_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_RSAEnAndDe_Api_IarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRSAEnAndDe_Api_IarrayBarrayBarrayBHandler ()
		{
			if (cb_RSAEnAndDe_Api_IarrayBarrayBarrayB == null)
				cb_RSAEnAndDe_Api_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_RSAEnAndDe_Api_IarrayBarrayBarrayB));
			return cb_RSAEnAndDe_Api_IarrayBarrayBarrayB;
		}

		static int n_RSAEnAndDe_Api_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RSAEnAndDe_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_RSAEnAndDe_Api_IarrayBarrayBarrayB;
		public unsafe int RSAEnAndDe_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3)
		{
			if (id_RSAEnAndDe_Api_IarrayBarrayBarrayB == IntPtr.Zero)
				id_RSAEnAndDe_Api_IarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "RSAEnAndDe_Api", "(I[B[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_RSAEnAndDe_Api_IarrayBarrayBarrayB, __args);
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

		static Delegate? cb_RSASign_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRSASign_Api_arrayBarrayBarrayBHandler ()
		{
			if (cb_RSASign_Api_arrayBarrayBarrayB == null)
				cb_RSASign_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_RSASign_Api_arrayBarrayBarrayB));
			return cb_RSASign_Api_arrayBarrayBarrayB;
		}

		static int n_RSASign_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RSASign_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_RSASign_Api_arrayBarrayBarrayB;
		public unsafe int RSASign_Api (byte[]? p0, byte[]? p1, byte[]? p2)
		{
			if (id_RSASign_Api_arrayBarrayBarrayB == IntPtr.Zero)
				id_RSASign_Api_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "RSASign_Api", "([B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_RSASign_Api_arrayBarrayBarrayB, __args);
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

		static Delegate? cb_RSAVerify_Api_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRSAVerify_Api_arrayBarrayBarrayBHandler ()
		{
			if (cb_RSAVerify_Api_arrayBarrayBarrayB == null)
				cb_RSAVerify_Api_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_I (n_RSAVerify_Api_arrayBarrayBarrayB));
			return cb_RSAVerify_Api_arrayBarrayBarrayB;
		}

		static int n_RSAVerify_Api_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RSAVerify_Api (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_RSAVerify_Api_arrayBarrayBarrayB;
		public unsafe int RSAVerify_Api (byte[]? p0, byte[]? p1, byte[]? p2)
		{
			if (id_RSAVerify_Api_arrayBarrayBarrayB == IntPtr.Zero)
				id_RSAVerify_Api_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "RSAVerify_Api", "([B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_RSAVerify_Api_arrayBarrayBarrayB, __args);
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

		static Delegate? cb_TR31_WriteKey_Api_IarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetTR31_WriteKey_Api_IarrayBarrayBarrayBHandler ()
		{
			if (cb_TR31_WriteKey_Api_IarrayBarrayBarrayB == null)
				cb_TR31_WriteKey_Api_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_TR31_WriteKey_Api_IarrayBarrayBarrayB));
			return cb_TR31_WriteKey_Api_IarrayBarrayBarrayB;
		}

		static int n_TR31_WriteKey_Api_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TR31_WriteKey_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_TR31_WriteKey_Api_IarrayBarrayBarrayB;
		public unsafe int TR31_WriteKey_Api (int p0, byte[]? p1, byte[]? p2, byte[]? p3)
		{
			if (id_TR31_WriteKey_Api_IarrayBarrayBarrayB == IntPtr.Zero)
				id_TR31_WriteKey_Api_IarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "TR31_WriteKey_Api", "(I[B[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_TR31_WriteKey_Api_IarrayBarrayBarrayB, __args);
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

		static Delegate? cb_calAes_Api_IIarrayBIarrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetCalAes_Api_IIarrayBIarrayBIarrayBHandler ()
		{
			if (cb_calAes_Api_IIarrayBIarrayBIarrayB == null)
				cb_calAes_Api_IIarrayBIarrayBIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILIL_I (n_CalAes_Api_IIarrayBIarrayBIarrayB));
			return cb_calAes_Api_IIarrayBIarrayBIarrayB;
		}

		static int n_CalAes_Api_IIarrayBIarrayBIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CalAes_Api (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calAes_Api_IIarrayBIarrayBIarrayB;
		public unsafe int CalAes_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, int p5, byte[]? p6)
		{
			if (id_calAes_Api_IIarrayBIarrayBIarrayB == IntPtr.Zero)
				id_calAes_Api_IIarrayBIarrayBIarrayB = JNIEnv.GetMethodID (class_ref, "calAes_Api", "(II[BI[BI[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calAes_Api_IIarrayBIarrayBIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate? cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetCalcAesDukpt_BBarrayBIarrayBBarrayBarrayBHandler ()
		{
			if (cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB == null)
				cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLILBLL_I (n_CalcAesDukpt_BBarrayBIarrayBBarrayBarrayB));
			return cb_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB;
		}

		static int n_CalcAesDukpt_BBarrayBIarrayBBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, int p3, IntPtr native_p4, sbyte p5, IntPtr native_p6, IntPtr native_p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CalcAesDukpt (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB;
		public unsafe int CalcAesDukpt (sbyte p0, sbyte p1, byte[]? p2, int p3, byte[]? p4, sbyte p5, byte[]? p6, byte[]? p7)
		{
			if (id_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB == IntPtr.Zero)
				id_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "calcAesDukpt", "(BB[BI[BB[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (native_p7);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcAesDukpt_BBarrayBIarrayBBarrayBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			if (p7 != null) {
				JNIEnv.CopyArray (native_p7, p7);
				JNIEnv.DeleteLocalRef (native_p7);
			}
			return __ret;
		}

		static Delegate? cb_calcRSAEx_Api_IIarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetCalcRSAEx_Api_IIarrayBarrayBarrayBHandler ()
		{
			if (cb_calcRSAEx_Api_IIarrayBarrayBarrayB == null)
				cb_calcRSAEx_Api_IIarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILLL_I (n_CalcRSAEx_Api_IIarrayBarrayBarrayB));
			return cb_calcRSAEx_Api_IIarrayBarrayBarrayB;
		}

		static int n_CalcRSAEx_Api_IIarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CalcRSAEx_Api (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calcRSAEx_Api_IIarrayBarrayBarrayB;
		public unsafe int CalcRSAEx_Api (int p0, int p1, byte[]? p2, byte[]? p3, byte[]? p4)
		{
			if (id_calcRSAEx_Api_IIarrayBarrayBarrayB == IntPtr.Zero)
				id_calcRSAEx_Api_IIarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "calcRSAEx_Api", "(II[B[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcRSAEx_Api_IIarrayBarrayBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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

		static Delegate? cb_calcRSAPri_Api_IIIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetCalcRSAPri_Api_IIIarrayBarrayBHandler ()
		{
			if (cb_calcRSAPri_Api_IIIarrayBarrayB == null)
				cb_calcRSAPri_Api_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILL_I (n_CalcRSAPri_Api_IIIarrayBarrayB));
			return cb_calcRSAPri_Api_IIIarrayBarrayB;
		}

		static int n_CalcRSAPri_Api_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CalcRSAPri_Api (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calcRSAPri_Api_IIIarrayBarrayB;
		public unsafe int CalcRSAPri_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4)
		{
			if (id_calcRSAPri_Api_IIIarrayBarrayB == IntPtr.Zero)
				id_calcRSAPri_Api_IIIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "calcRSAPri_Api", "(III[B[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcRSAPri_Api_IIIarrayBarrayB, __args);
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

		static Delegate? cb_calcRSAPub_Api_IIIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetCalcRSAPub_Api_IIIarrayBarrayBHandler ()
		{
			if (cb_calcRSAPub_Api_IIIarrayBarrayB == null)
				cb_calcRSAPub_Api_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIILL_I (n_CalcRSAPub_Api_IIIarrayBarrayB));
			return cb_calcRSAPub_Api_IIIarrayBarrayB;
		}

		static int n_CalcRSAPub_Api_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CalcRSAPub_Api (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calcRSAPub_Api_IIIarrayBarrayB;
		public unsafe int CalcRSAPub_Api (int p0, int p1, int p2, byte[]? p3, byte[]? p4)
		{
			if (id_calcRSAPub_Api_IIIarrayBarrayB == IntPtr.Zero)
				id_calcRSAPub_Api_IIIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "calcRSAPub_Api", "(III[B[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcRSAPub_Api_IIIarrayBarrayB, __args);
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

		static Delegate? cb_calcRSA_Api_BarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetCalcRSA_Api_BarrayBarrayBarrayBHandler ()
		{
			if (cb_calcRSA_Api_BarrayBarrayBarrayB == null)
				cb_calcRSA_Api_BarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBLLL_I (n_CalcRSA_Api_BarrayBarrayBarrayB));
			return cb_calcRSA_Api_BarrayBarrayBarrayB;
		}

		static int n_CalcRSA_Api_BarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.CalcRSA_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calcRSA_Api_BarrayBarrayBarrayB;
		public unsafe int CalcRSA_Api (sbyte p0, byte[]? p1, byte[]? p2, byte[]? p3)
		{
			if (id_calcRSA_Api_BarrayBarrayBarrayB == IntPtr.Zero)
				id_calcRSA_Api_BarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "calcRSA_Api", "(B[B[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcRSA_Api_BarrayBarrayBarrayB, __args);
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

		static Delegate? cb_getAesDukptKsn_BarrayB;
#pragma warning disable 0169
		static Delegate GetGetAesDukptKsn_BarrayBHandler ()
		{
			if (cb_getAesDukptKsn_BarrayB == null)
				cb_getAesDukptKsn_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_GetAesDukptKsn_BarrayB));
			return cb_getAesDukptKsn_BarrayB;
		}

		static int n_GetAesDukptKsn_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetAesDukptKsn (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAesDukptKsn_BarrayB;
		public unsafe int GetAesDukptKsn (sbyte p0, byte[]? p1)
		{
			if (id_getAesDukptKsn_BarrayB == IntPtr.Zero)
				id_getAesDukptKsn_BarrayB = JNIEnv.GetMethodID (class_ref, "getAesDukptKsn", "(B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAesDukptKsn_BarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_getKeyPairHdOrSoftg_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetKeyPairHdOrSoftg_IarrayBarrayBHandler ()
		{
			if (cb_getKeyPairHdOrSoftg_IarrayBarrayB == null)
				cb_getKeyPairHdOrSoftg_IarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_I (n_GetKeyPairHdOrSoftg_IarrayBarrayB));
			return cb_getKeyPairHdOrSoftg_IarrayBarrayB;
		}

		static int n_GetKeyPairHdOrSoftg_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetKeyPairHdOrSoftg (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getKeyPairHdOrSoftg_IarrayBarrayB;
		public unsafe int GetKeyPairHdOrSoftg (int p0, byte[]? p1, byte[]? p2)
		{
			if (id_getKeyPairHdOrSoftg_IarrayBarrayB == IntPtr.Zero)
				id_getKeyPairHdOrSoftg_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "getKeyPairHdOrSoftg", "(I[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKeyPairHdOrSoftg_IarrayBarrayB, __args);
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

		static Delegate? cb_getMacAesDukpt_BIBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetMacAesDukpt_BIBarrayBarrayBarrayBHandler ()
		{
			if (cb_getMacAesDukpt_BIBarrayBarrayBarrayB == null)
				cb_getMacAesDukpt_BIBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBIBLLL_I (n_GetMacAesDukpt_BIBarrayBarrayBarrayB));
			return cb_getMacAesDukpt_BIBarrayBarrayBarrayB;
		}

		static int n_GetMacAesDukpt_BIBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, int p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetMacAesDukpt (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMacAesDukpt_BIBarrayBarrayBarrayB;
		public unsafe int GetMacAesDukpt (sbyte p0, int p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5)
		{
			if (id_getMacAesDukpt_BIBarrayBarrayBarrayB == IntPtr.Zero)
				id_getMacAesDukpt_BIBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "getMacAesDukpt", "(BIB[B[B[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMacAesDukpt_BIBarrayBarrayBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetPinAESDukptEx_BBBarrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB == null)
				cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLLL_I (n_GetPinAESDukptEx_BBBarrayBarrayBarrayBarrayB));
			return cb_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB;
		}

		static int n_GetPinAESDukptEx_BBBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]?) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetPinAESDukptEx (p0, p1, p2, p3, p4, p5, p6);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB;
		public unsafe int GetPinAESDukptEx (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, byte[]? p5, byte[]? p6)
		{
			if (id_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "getPinAESDukptEx", "(BBB[B[B[B[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPinAESDukptEx_BBBarrayBarrayBarrayBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate? cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayBHandler ()
		{
			if (cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB == null)
				cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBLLLL_I (n_GetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB));
			return cb_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB;
		}

		static int n_GetPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetPinDukptEx_Api (p0, p1, p2, p3, p4, p5);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB;
		public unsafe int GetPinDukptEx_Api (sbyte p0, sbyte p1, string? p2, string? p3, byte[]? p4, byte[]? p5)
		{
			if (id_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB == IntPtr.Zero)
				id_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "getPinDukptEx_Api", "(BBLjava/lang/String;Ljava/lang/String;[B[B)I");
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPinDukptEx_Api_BBLjava_lang_String_Ljava_lang_String_arrayBarrayB, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_getRSAKeyPair_Api_IIIarrayB;
#pragma warning disable 0169
		static Delegate GetGetRSAKeyPair_Api_IIIarrayBHandler ()
		{
			if (cb_getRSAKeyPair_Api_IIIarrayB == null)
				cb_getRSAKeyPair_Api_IIIarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIIL_I (n_GetRSAKeyPair_Api_IIIarrayB));
			return cb_getRSAKeyPair_Api_IIIarrayB;
		}

		static int n_GetRSAKeyPair_Api_IIIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetRSAKeyPair_Api (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRSAKeyPair_Api_IIIarrayB;
		public unsafe int GetRSAKeyPair_Api (int p0, int p1, int p2, byte[]? p3)
		{
			if (id_getRSAKeyPair_Api_IIIarrayB == IntPtr.Zero)
				id_getRSAKeyPair_Api_IIIarrayB = JNIEnv.GetMethodID (class_ref, "getRSAKeyPair_Api", "(III[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRSAKeyPair_Api_IIIarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate? cb_isKeyExist_Api_II;
#pragma warning disable 0169
		static Delegate GetIsKeyExist_Api_IIHandler ()
		{
			if (cb_isKeyExist_Api_II == null)
				cb_isKeyExist_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_Z (n_IsKeyExist_Api_II));
			return cb_isKeyExist_Api_II;
		}

		static bool n_IsKeyExist_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsKeyExist_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_isKeyExist_Api_II;
		public unsafe bool IsKeyExist_Api (int p0, int p1)
		{
			if (id_isKeyExist_Api_II == IntPtr.Zero)
				id_isKeyExist_Api_II = JNIEnv.GetMethodID (class_ref, "isKeyExist_Api", "(II)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKeyExist_Api_II, __args);
		}

		static Delegate? cb_setAmountColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmountColor_Ljava_lang_String_Handler ()
		{
			if (cb_setAmountColor_Ljava_lang_String_ == null)
				cb_setAmountColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAmountColor_Ljava_lang_String_));
			return cb_setAmountColor_Ljava_lang_String_;
		}

		static void n_SetAmountColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAmountColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAmountColor_Ljava_lang_String_;
		public unsafe void SetAmountColor (string? p0)
		{
			if (id_setAmountColor_Ljava_lang_String_ == IntPtr.Zero)
				id_setAmountColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAmountColor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAmountColor_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setAmountFont_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmountFont_Ljava_lang_String_Handler ()
		{
			if (cb_setAmountFont_Ljava_lang_String_ == null)
				cb_setAmountFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAmountFont_Ljava_lang_String_));
			return cb_setAmountFont_Ljava_lang_String_;
		}

		static void n_SetAmountFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAmountFont (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAmountFont_Ljava_lang_String_;
		public unsafe void SetAmountFont (string? p0)
		{
			if (id_setAmountFont_Ljava_lang_String_ == IntPtr.Zero)
				id_setAmountFont_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAmountFont", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAmountFont_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setAmountSize_F;
#pragma warning disable 0169
		static Delegate GetSetAmountSize_FHandler ()
		{
			if (cb_setAmountSize_F == null)
				cb_setAmountSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetAmountSize_F));
			return cb_setAmountSize_F;
		}

		static void n_SetAmountSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetAmountSize (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAmountSize_F;
		public unsafe void SetAmountSize (float p0)
		{
			if (id_setAmountSize_F == IntPtr.Zero)
				id_setAmountSize_F = JNIEnv.GetMethodID (class_ref, "setAmountSize", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAmountSize_F, __args);
		}

		static Delegate? cb_setBottomBtnText_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBottomBtnText_arrayLjava_lang_String_Handler ()
		{
			if (cb_setBottomBtnText_arrayLjava_lang_String_ == null)
				cb_setBottomBtnText_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomBtnText_arrayLjava_lang_String_));
			return cb_setBottomBtnText_arrayLjava_lang_String_;
		}

		static void n_SetBottomBtnText_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (string[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetBottomBtnText (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setBottomBtnText_arrayLjava_lang_String_;
		public unsafe void SetBottomBtnText (string[]? p0)
		{
			if (id_setBottomBtnText_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setBottomBtnText_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBottomBtnText", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBottomBtnText_arrayLjava_lang_String_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_setBottomFont_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBottomFont_Ljava_lang_String_Handler ()
		{
			if (cb_setBottomFont_Ljava_lang_String_ == null)
				cb_setBottomFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomFont_Ljava_lang_String_));
			return cb_setBottomFont_Ljava_lang_String_;
		}

		static void n_SetBottomFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBottomFont (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBottomFont_Ljava_lang_String_;
		public unsafe void SetBottomFont (string? p0)
		{
			if (id_setBottomFont_Ljava_lang_String_ == IntPtr.Zero)
				id_setBottomFont_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBottomFont", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBottomFont_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setBottomTextColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBottomTextColor_Ljava_lang_String_Handler ()
		{
			if (cb_setBottomTextColor_Ljava_lang_String_ == null)
				cb_setBottomTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBottomTextColor_Ljava_lang_String_));
			return cb_setBottomTextColor_Ljava_lang_String_;
		}

		static void n_SetBottomTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBottomTextColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBottomTextColor_Ljava_lang_String_;
		public unsafe void SetBottomTextColor (string? p0)
		{
			if (id_setBottomTextColor_Ljava_lang_String_ == IntPtr.Zero)
				id_setBottomTextColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBottomTextColor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBottomTextColor_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setBottomTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetBottomTextSize_FHandler ()
		{
			if (cb_setBottomTextSize_F == null)
				cb_setBottomTextSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetBottomTextSize_F));
			return cb_setBottomTextSize_F;
		}

		static void n_SetBottomTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetBottomTextSize (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBottomTextSize_F;
		public unsafe void SetBottomTextSize (float p0)
		{
			if (id_setBottomTextSize_F == IntPtr.Zero)
				id_setBottomTextSize_F = JNIEnv.GetMethodID (class_ref, "setBottomTextSize", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBottomTextSize_F, __args);
		}

		static Delegate? cb_setCardNo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardNo_Ljava_lang_String_Handler ()
		{
			if (cb_setCardNo_Ljava_lang_String_ == null)
				cb_setCardNo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCardNo_Ljava_lang_String_));
			return cb_setCardNo_Ljava_lang_String_;
		}

		static void n_SetCardNo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCardNo (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCardNo_Ljava_lang_String_;
		public unsafe void SetCardNo (string? p0)
		{
			if (id_setCardNo_Ljava_lang_String_ == IntPtr.Zero)
				id_setCardNo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardNo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardNo_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setDispAmt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDispAmt_Ljava_lang_String_Handler ()
		{
			if (cb_setDispAmt_Ljava_lang_String_ == null)
				cb_setDispAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetDispAmt_Ljava_lang_String_));
			return cb_setDispAmt_Ljava_lang_String_;
		}

		static void n_SetDispAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDispAmt (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDispAmt_Ljava_lang_String_;
		public unsafe void SetDispAmt (string? p0)
		{
			if (id_setDispAmt_Ljava_lang_String_ == IntPtr.Zero)
				id_setDispAmt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDispAmt", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDispAmt_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setNumColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNumColor_Ljava_lang_String_Handler ()
		{
			if (cb_setNumColor_Ljava_lang_String_ == null)
				cb_setNumColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNumColor_Ljava_lang_String_));
			return cb_setNumColor_Ljava_lang_String_;
		}

		static void n_SetNumColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setNumColor_Ljava_lang_String_;
		public unsafe void SetNumColor (string? p0)
		{
			if (id_setNumColor_Ljava_lang_String_ == IntPtr.Zero)
				id_setNumColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNumColor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumColor_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setNumFont_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNumFont_Ljava_lang_String_Handler ()
		{
			if (cb_setNumFont_Ljava_lang_String_ == null)
				cb_setNumFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNumFont_Ljava_lang_String_));
			return cb_setNumFont_Ljava_lang_String_;
		}

		static void n_SetNumFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumFont (p0);
		}
#pragma warning restore 0169

		IntPtr id_setNumFont_Ljava_lang_String_;
		public unsafe void SetNumFont (string? p0)
		{
			if (id_setNumFont_Ljava_lang_String_ == IntPtr.Zero)
				id_setNumFont_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNumFont", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumFont_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setNumSize_F;
#pragma warning disable 0169
		static Delegate GetSetNumSize_FHandler ()
		{
			if (cb_setNumSize_F == null)
				cb_setNumSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetNumSize_F));
			return cb_setNumSize_F;
		}

		static void n_SetNumSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetNumSize (p0);
		}
#pragma warning restore 0169

		IntPtr id_setNumSize_F;
		public unsafe void SetNumSize (float p0)
		{
			if (id_setNumSize_F == IntPtr.Zero)
				id_setNumSize_F = JNIEnv.GetMethodID (class_ref, "setNumSize", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumSize_F, __args);
		}

		static Delegate? cb_setPinBoardFixed_Z;
#pragma warning disable 0169
		static Delegate GetSetPinBoardFixed_ZHandler ()
		{
			if (cb_setPinBoardFixed_Z == null)
				cb_setPinBoardFixed_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetPinBoardFixed_Z));
			return cb_setPinBoardFixed_Z;
		}

		static void n_SetPinBoardFixed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetPinBoardFixed (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPinBoardFixed_Z;
		public unsafe void SetPinBoardFixed (bool p0)
		{
			if (id_setPinBoardFixed_Z == IntPtr.Zero)
				id_setPinBoardFixed_Z = JNIEnv.GetMethodID (class_ref, "setPinBoardFixed", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPinBoardFixed_Z, __args);
		}

		static Delegate? cb_setPinBoardKey_Api_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetPinBoardKey_Api_Landroid_os_Bundle_Handler ()
		{
			if (cb_setPinBoardKey_Api_Landroid_os_Bundle_ == null)
				cb_setPinBoardKey_Api_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetPinBoardKey_Api_Landroid_os_Bundle_));
			return cb_setPinBoardKey_Api_Landroid_os_Bundle_;
		}

		static int n_SetPinBoardKey_Api_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPinBoardKey_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setPinBoardKey_Api_Landroid_os_Bundle_;
		public unsafe int SetPinBoardKey_Api (global::Android.OS.Bundle? p0)
		{
			if (id_setPinBoardKey_Api_Landroid_os_Bundle_ == IntPtr.Zero)
				id_setPinBoardKey_Api_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setPinBoardKey_Api", "(Landroid/os/Bundle;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setPinBoardKey_Api_Landroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_setPinBoardMsg_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetPinBoardMsg_Landroid_os_Bundle_Handler ()
		{
			if (cb_setPinBoardMsg_Landroid_os_Bundle_ == null)
				cb_setPinBoardMsg_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPinBoardMsg_Landroid_os_Bundle_));
			return cb_setPinBoardMsg_Landroid_os_Bundle_;
		}

		static void n_SetPinBoardMsg_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPinBoardMsg (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPinBoardMsg_Landroid_os_Bundle_;
		public unsafe void SetPinBoardMsg (global::Android.OS.Bundle? p0)
		{
			if (id_setPinBoardMsg_Landroid_os_Bundle_ == IntPtr.Zero)
				id_setPinBoardMsg_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setPinBoardMsg", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPinBoardMsg_Landroid_os_Bundle_, __args);
		}

		static Delegate? cb_setPinBoardSetting_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetPinBoardSetting_Landroid_os_Bundle_Handler ()
		{
			if (cb_setPinBoardSetting_Landroid_os_Bundle_ == null)
				cb_setPinBoardSetting_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPinBoardSetting_Landroid_os_Bundle_));
			return cb_setPinBoardSetting_Landroid_os_Bundle_;
		}

		static void n_SetPinBoardSetting_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPinBoardSetting (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPinBoardSetting_Landroid_os_Bundle_;
		public unsafe void SetPinBoardSetting (global::Android.OS.Bundle? p0)
		{
			if (id_setPinBoardSetting_Landroid_os_Bundle_ == IntPtr.Zero)
				id_setPinBoardSetting_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setPinBoardSetting", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPinBoardSetting_Landroid_os_Bundle_, __args);
		}

		static Delegate? cb_setPinBoardStyle_I;
#pragma warning disable 0169
		static Delegate GetSetPinBoardStyle_IHandler ()
		{
			if (cb_setPinBoardStyle_I == null)
				cb_setPinBoardStyle_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_SetPinBoardStyle_I));
			return cb_setPinBoardStyle_I;
		}

		static void n_SetPinBoardStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetPinBoardStyle (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPinBoardStyle_I;
		public unsafe void SetPinBoardStyle (int p0)
		{
			if (id_setPinBoardStyle_I == IntPtr.Zero)
				id_setPinBoardStyle_I = JNIEnv.GetMethodID (class_ref, "setPinBoardStyle", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPinBoardStyle_I, __args);
		}

		static Delegate? cb_setStatusbarColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatusbarColor_Ljava_lang_String_Handler ()
		{
			if (cb_setStatusbarColor_Ljava_lang_String_ == null)
				cb_setStatusbarColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetStatusbarColor_Ljava_lang_String_));
			return cb_setStatusbarColor_Ljava_lang_String_;
		}

		static void n_SetStatusbarColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusbarColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setStatusbarColor_Ljava_lang_String_;
		public unsafe void SetStatusbarColor (string? p0)
		{
			if (id_setStatusbarColor_Ljava_lang_String_ == IntPtr.Zero)
				id_setStatusbarColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatusbarColor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatusbarColor_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setStatusbarHide_Z;
#pragma warning disable 0169
		static Delegate GetSetStatusbarHide_ZHandler ()
		{
			if (cb_setStatusbarHide_Z == null)
				cb_setStatusbarHide_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetStatusbarHide_Z));
			return cb_setStatusbarHide_Z;
		}

		static void n_SetStatusbarHide_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetStatusbarHide (p0);
		}
#pragma warning restore 0169

		IntPtr id_setStatusbarHide_Z;
		public unsafe void SetStatusbarHide (bool p0)
		{
			if (id_setStatusbarHide_Z == IntPtr.Zero)
				id_setStatusbarHide_Z = JNIEnv.GetMethodID (class_ref, "setStatusbarHide", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatusbarHide_Z, __args);
		}

		static Delegate? cb_setTextColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTextColor_Ljava_lang_String_Handler ()
		{
			if (cb_setTextColor_Ljava_lang_String_ == null)
				cb_setTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTextColor_Ljava_lang_String_));
			return cb_setTextColor_Ljava_lang_String_;
		}

		static void n_SetTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTextColor_Ljava_lang_String_;
		public unsafe void SetTextColor (string? p0)
		{
			if (id_setTextColor_Ljava_lang_String_ == IntPtr.Zero)
				id_setTextColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTextColor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setTextFont_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTextFont_Ljava_lang_String_Handler ()
		{
			if (cb_setTextFont_Ljava_lang_String_ == null)
				cb_setTextFont_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTextFont_Ljava_lang_String_));
			return cb_setTextFont_Ljava_lang_String_;
		}

		static void n_SetTextFont_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTextFont (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTextFont_Ljava_lang_String_;
		public unsafe void SetTextFont (string? p0)
		{
			if (id_setTextFont_Ljava_lang_String_ == IntPtr.Zero)
				id_setTextFont_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTextFont", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextFont_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_setTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetTextSize_FHandler ()
		{
			if (cb_setTextSize_F == null)
				cb_setTextSize_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetTextSize_F));
			return cb_setTextSize_F;
		}

		static void n_SetTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetTextSize (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTextSize_F;
		public unsafe void SetTextSize (float p0)
		{
			if (id_setTextSize_F == IntPtr.Zero)
				id_setTextSize_F = JNIEnv.GetMethodID (class_ref, "setTextSize", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextSize_F, __args);
		}

		static Delegate? cb_setTitleBackGroundColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleBackGroundColor_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleBackGroundColor_Ljava_lang_String_ == null)
				cb_setTitleBackGroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTitleBackGroundColor_Ljava_lang_String_));
			return cb_setTitleBackGroundColor_Ljava_lang_String_;
		}

		static void n_SetTitleBackGroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleBackGroundColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTitleBackGroundColor_Ljava_lang_String_;
		public unsafe void SetTitleBackGroundColor (string? p0)
		{
			if (id_setTitleBackGroundColor_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitleBackGroundColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitleBackGroundColor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitleBackGroundColor_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_writeAesKey_BIBIBarrayBBBarrayB;
#pragma warning disable 0169
		static Delegate GetWriteAesKey_BIBIBarrayBBBarrayBHandler ()
		{
			if (cb_writeAesKey_BIBIBarrayBBBarrayB == null)
				cb_writeAesKey_BIBIBarrayBBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBIBIBLBBL_I (n_WriteAesKey_BIBIBarrayBBBarrayB));
			return cb_writeAesKey_BIBIBarrayBBBarrayB;
		}

		static int n_WriteAesKey_BIBIBarrayBBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, int p1, sbyte p2, int p3, sbyte p4, IntPtr native_p5, sbyte p6, sbyte p7, IntPtr native_p8)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p8 = (byte[]?) JNIEnv.GetArray (native_p8, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteAesKey (p0, p1, p2, p3, p4, p5, p6, p7, p8);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p8 != null)
				JNIEnv.CopyArray (p8, native_p8);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeAesKey_BIBIBarrayBBBarrayB;
		public unsafe int WriteAesKey (sbyte p0, int p1, sbyte p2, int p3, sbyte p4, byte[]? p5, sbyte p6, sbyte p7, byte[]? p8)
		{
			if (id_writeAesKey_BIBIBarrayBBBarrayB == IntPtr.Zero)
				id_writeAesKey_BIBIBarrayBBBarrayB = JNIEnv.GetMethodID (class_ref, "writeAesKey", "(BIBIB[BBB[B)I");
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			JValue* __args = stackalloc JValue [9];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			__args [7] = new JValue (p7);
			__args [8] = new JValue (native_p8);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeAesKey_BIBIBarrayBBBarrayB, __args);
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			if (p8 != null) {
				JNIEnv.CopyArray (native_p8, p8);
				JNIEnv.DeleteLocalRef (native_p8);
			}
			return __ret;
		}

		static Delegate? cb_writeAesTik_BBBarrayBarrayBBBarrayB;
#pragma warning disable 0169
		static Delegate GetWriteAesTik_BBBarrayBarrayBBBarrayBHandler ()
		{
			if (cb_writeAesTik_BBBarrayBarrayBBBarrayB == null)
				cb_writeAesTik_BBBarrayBarrayBBBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBBBLLBBL_I (n_WriteAesTik_BBBarrayBarrayBBBarrayB));
			return cb_writeAesTik_BBBarrayBarrayBBBarrayB;
		}

		static int n_WriteAesTik_BBBarrayBarrayBBBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, sbyte p2, IntPtr native_p3, IntPtr native_p4, sbyte p5, sbyte p6, IntPtr native_p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p3 = (byte[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p7 = (byte[]?) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteAesTik (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeAesTik_BBBarrayBarrayBBBarrayB;
		public unsafe int WriteAesTik (sbyte p0, sbyte p1, sbyte p2, byte[]? p3, byte[]? p4, sbyte p5, sbyte p6, byte[]? p7)
		{
			if (id_writeAesTik_BBBarrayBarrayBBBarrayB == IntPtr.Zero)
				id_writeAesTik_BBBarrayBarrayBBBarrayB = JNIEnv.GetMethodID (class_ref, "writeAesTik", "(BBB[B[BBB[B)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (p6);
			__args [7] = new JValue (native_p7);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeAesTik_BBBarrayBarrayBBBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p7 != null) {
				JNIEnv.CopyArray (native_p7, p7);
				JNIEnv.DeleteLocalRef (native_p7);
			}
			return __ret;
		}

		static Delegate? cb_writeDerivedKey_IIarrayBI;
#pragma warning disable 0169
		static Delegate GetWriteDerivedKey_IIarrayBIHandler ()
		{
			if (cb_writeDerivedKey_IIarrayBI == null)
				cb_writeDerivedKey_IIarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILI_I (n_WriteDerivedKey_IIarrayBI));
			return cb_writeDerivedKey_IIarrayBI;
		}

		static int n_WriteDerivedKey_IIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteDerivedKey (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeDerivedKey_IIarrayBI;
		public unsafe int WriteDerivedKey (int p0, int p1, byte[]? p2, int p3)
		{
			if (id_writeDerivedKey_IIarrayBI == IntPtr.Zero)
				id_writeDerivedKey_IIarrayBI = JNIEnv.GetMethodID (class_ref, "writeDerivedKey", "(II[BI)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeDerivedKey_IIarrayBI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate? cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetWriteRSAKeyEx_Api_IIarrayBIarrayBarrayBHandler ()
		{
			if (cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB == null)
				cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIILILL_I (n_WriteRSAKeyEx_Api_IIarrayBIarrayBarrayB));
			return cb_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB;
		}

		static int n_WriteRSAKeyEx_Api_IIarrayBIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]?) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]?) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteRSAKeyEx_Api (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB;
		public unsafe int WriteRSAKeyEx_Api (int p0, int p1, byte[]? p2, int p3, byte[]? p4, byte[]? p5)
		{
			if (id_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB == IntPtr.Zero)
				id_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "writeRSAKeyEx_Api", "(II[BI[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeRSAKeyEx_Api_IIarrayBIarrayBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate? cb_writeRSAKey_Api_BarrayB;
#pragma warning disable 0169
		static Delegate GetWriteRSAKey_Api_BarrayBHandler ()
		{
			if (cb_writeRSAKey_Api_BarrayB == null)
				cb_writeRSAKey_Api_BarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPBL_I (n_WriteRSAKey_Api_BarrayB));
			return cb_writeRSAKey_Api_BarrayB;
		}

		static int n_WriteRSAKey_Api_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteRSAKey_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeRSAKey_Api_BarrayB;
		public unsafe int WriteRSAKey_Api (sbyte p0, byte[]? p1)
		{
			if (id_writeRSAKey_Api_BarrayB == IntPtr.Zero)
				id_writeRSAKey_Api_BarrayB = JNIEnv.GetMethodID (class_ref, "writeRSAKey_Api", "(B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeRSAKey_Api_BarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Ped.IPedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
