using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Appsdk.Api.System {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']"
	[Register ("com/vanstone/appsdk/api/system/SystemHandler", "", "Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker")]
	public partial interface ISystemHandler : global::Android.OS.IInterface {
		string? AdminPassword_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getAdminPassword_Api' and count(parameter)=0]"
			[Register ("getAdminPassword_Api", "()Ljava/lang/String;", "GetGetAdminPassword_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::Android.OS.Bundle? AllVersion_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GetAllVersion_Api' and count(parameter)=0]"
			[Register ("GetAllVersion_Api", "()Landroid/os/Bundle;", "GetGetAllVersion_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? AndroidKernelVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getAndroidKernelVersion' and count(parameter)=0]"
			[Register ("getAndroidKernelVersion", "()Ljava/lang/String;", "GetGetAndroidKernelVersionHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		int AntennaState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getAntennaState' and count(parameter)=0]"
			[Register ("getAntennaState", "()I", "GetGetAntennaStateHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		bool AutoTimeState_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getAutoTimeState_Api' and count(parameter)=0]"
			[Register ("getAutoTimeState_Api", "()Z", "GetGetAutoTimeState_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		bool AutoTimeZoneState_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getAutoTimeZoneState_Api' and count(parameter)=0]"
			[Register ("getAutoTimeZoneState_Api", "()Z", "GetGetAutoTimeZoneState_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? CSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getCSN' and count(parameter)=0]"
			[Register ("getCSN", "()Ljava/lang/String;", "GetGetCSNHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		bool DebuggableStatus_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getDebuggableStatus_Api' and count(parameter)=0]"
			[Register ("getDebuggableStatus_Api", "()Z", "GetGetDebuggableStatus_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? DefaultDataSIM_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getDefaultDataSIM_Api' and count(parameter)=0]"
			[Register ("getDefaultDataSIM_Api", "()Ljava/lang/String;", "GetGetDefaultDataSIM_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getFirmwareVersion' and count(parameter)=0]"
			[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? HardwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getHardwareVersion' and count(parameter)=0]"
			[Register ("getHardwareVersion", "()Ljava/lang/String;", "GetGetHardwareVersionHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? Imei {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getImei' and count(parameter)=0]"
			[Register ("getImei", "()Ljava/lang/String;", "GetGetImeiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		bool IsDebug_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='isDebug_Api' and count(parameter)=0]"
			[Register ("isDebug_Api", "()Z", "GetIsDebug_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		int LastShutdownCause_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getLastShutdownCause_Api' and count(parameter)=0]"
			[Register ("getLastShutdownCause_Api", "()I", "GetGetLastShutdownCause_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::Android.OS.Bundle? LifeInform_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getLifeInform_Api' and count(parameter)=0]"
			[Register ("getLifeInform_Api", "()Landroid/os/Bundle;", "GetGetLifeInform_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? MachineType_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getMachineType_Api' and count(parameter)=0]"
			[Register ("getMachineType_Api", "()Ljava/lang/String;", "GetGetMachineType_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::Android.OS.Bundle? ModuleSupport_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getModuleSupport_Api' and count(parameter)=0]"
			[Register ("getModuleSupport_Api", "()Landroid/os/Bundle;", "GetGetModuleSupport_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? NtpServer_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getNtpServer_Api' and count(parameter)=0]"
			[Register ("getNtpServer_Api", "()Ljava/lang/String;", "GetGetNtpServer_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? ROMVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getROMVersion' and count(parameter)=0]"
			[Register ("getROMVersion", "()Ljava/lang/String;", "GetGetROMVersionHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? ResumeRechargeValue_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getResumeRechargeValue_Api' and count(parameter)=0]"
			[Register ("getResumeRechargeValue_Api", "()Ljava/lang/String;", "GetGetResumeRechargeValue_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? RootCertName_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getRootCertName_Api' and count(parameter)=0]"
			[Register ("getRootCertName_Api", "()Ljava/lang/String;", "GetGetRootCertName_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? RootCertVersion_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getRootCertVersion_Api' and count(parameter)=0]"
			[Register ("getRootCertVersion_Api", "()Ljava/lang/String;", "GetGetRootCertVersion_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? SettingsPWD_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSettingsPWD_Api' and count(parameter)=0]"
			[Register ("getSettingsPWD_Api", "()Ljava/lang/String;", "GetGetSettingsPWD_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::Android.Content.Intent? SysHWMaintainIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSysHWMaintainIntent' and count(parameter)=0]"
			[Register ("getSysHWMaintainIntent", "()Landroid/content/Intent;", "GetGetSysHWMaintainIntentHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? SysOTAVerison_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSysOTAVerison_Api' and count(parameter)=0]"
			[Register ("getSysOTAVerison_Api", "()Ljava/lang/String;", "GetGetSysOTAVerison_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::Android.Content.Intent? SysgHWDetectionIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSysgHWDetectionIntent' and count(parameter)=0]"
			[Register ("getSysgHWDetectionIntent", "()Landroid/content/Intent;", "GetGetSysgHWDetectionIntentHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::Android.OS.Bundle? SystemInform_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSystemInform_Api' and count(parameter)=0]"
			[Register ("getSystemInform_Api", "()Landroid/os/Bundle;", "GetGetSystemInform_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		string? TimeZone_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getTimeZone_Api' and count(parameter)=0]"
			[Register ("getTimeZone_Api", "()Ljava/lang/String;", "GetGetTimeZone_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		global::System.Collections.Generic.IList<string>? UndeletableAppList_Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getUndeletableAppList_Api' and count(parameter)=0]"
			[Register ("getUndeletableAppList_Api", "()Ljava/util/List;", "GetGetUndeletableAppList_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='BackUpByPackage_Api' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("BackUpByPackage_Api", "(Ljava/util/List;Ljava/lang/String;)I", "GetBackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int BackUpByPackage_Api (global::System.Collections.Generic.IList<string>? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='Beef_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("Beef_Api", "(II)V", "GetBeef_Api_IIHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void Beef_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='Beep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Beep_Api", "(I)V", "GetBeep_Api_IHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void Beep_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='CheckModuleStatue_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("CheckModuleStatue_Api", "(I)I", "GetCheckModuleStatue_Api_IHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int CheckModuleStatue_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GateClose_Api' and count(parameter)=0]"
		[Register ("GateClose_Api", "()I", "GetGateClose_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int GateClose_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GateOpen_Api' and count(parameter)=0]"
		[Register ("GateOpen_Api", "()I", "GetGateOpen_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int GateOpen_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GetVersion_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("GetVersion_Api", "([B[B)I", "GetGetVersion_Api_arrayBarrayBHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int GetVersion_Api (byte[]? p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='IsHandleOnBase_Api' and count(parameter)=0]"
		[Register ("IsHandleOnBase_Api", "()I", "GetIsHandleOnBase_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int IsHandleOnBase_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='ReadPosSn' and count(parameter)=0]"
		[Register ("ReadPosSn", "()Ljava/lang/String;", "GetReadPosSnHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		string? ReadPosSn ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='RestoreDatda_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("RestoreDatda_Api", "(Ljava/lang/String;)I", "GetRestoreDatda_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int RestoreDatda_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='RestoreFactory_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("RestoreFactory_Api", "(Z)V", "GetRestoreFactory_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void RestoreFactory_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetAdbEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetAdbEnable_Api", "(Z)Z", "GetSetAdbEnable_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetAdbEnable_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetBaseBroadcast_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetBaseBroadcast_Api", "(Z)V", "GetSetBaseBroadcast_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void SetBaseBroadcast_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetBluetoothEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetBluetoothEnable_Api", "(Z)Z", "GetSetBluetoothEnable_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetBluetoothEnable_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetOtgEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetOtgEnable_Api", "(Z)Z", "GetSetOtgEnable_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetOtgEnable_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetSetScreenOffTimeout_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetSetScreenOffTimeout_Api", "(I)Z", "GetSetSetScreenOffTimeout_Api_IHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetSetScreenOffTimeout_Api (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetTime_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetTime_Api", "(Ljava/lang/String;)I", "GetSetTime_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int SetTime_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetWifiAddNetworkEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetWifiAddNetworkEnable_Api", "(Z)Z", "GetSetWifiAddNetworkEnable_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetWifiAddNetworkEnable_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SystemPowerOff_Api' and count(parameter)=0]"
		[Register ("SystemPowerOff_Api", "()V", "GetSystemPowerOff_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void SystemPowerOff_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SystemReboot_Api' and count(parameter)=0]"
		[Register ("SystemReboot_Api", "()V", "GetSystemReboot_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void SystemReboot_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='catchMainLog_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("catchMainLog_Api", "(Ljava/lang/String;)Z", "GetCatchMainLog_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool CatchMainLog_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteFileInSe_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFileInSe_Api", "(Ljava/lang/String;)I", "GetDeleteFileInSe_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int DeleteFileInSe_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("deleteFlashData_Api", "(II)I", "GetDeleteFlashData_Api_IIHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int DeleteFlashData_Api (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteRsakey_Api' and count(parameter)=0]"
		[Register ("deleteRsakey_Api", "()Z", "GetDeleteRsakey_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool DeleteRsakey_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getFileListInSe_Api' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getFileListInSe_Api", "(Ljava/util/List;)I", "GetGetFileListInSe_Api_Ljava_util_List_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int GetFileListInSe_Api (global::System.Collections.Generic.IList<string>? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getSmartPosID", "([B)I", "GetGetSmartPosID_arrayBHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int GetSmartPosID (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getTrafficStats_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getTrafficStats_Api", "(Ljava/lang/String;Ljava/lang/String;)Lcom/vanstone/appsdk/api/struct/AidlTrafficStats;", "GetGetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats? GetTrafficStats_Api (string? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='isForeground_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isForeground_Api", "(Ljava/lang/String;)Z", "GetIsForeground_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool IsForeground_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='isdeviceEnabled_Api' and count(parameter)=0]"
		[Register ("isdeviceEnabled_Api", "()Z", "GetIsdeviceEnabled_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool IsdeviceEnabled_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readFileFromSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readFileFromSE_Api", "(Ljava/lang/String;[BII)I", "GetReadFileFromSE_Api_Ljava_lang_String_arrayBIIHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int ReadFileFromSE_Api (string? p0, byte[]? p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("readFlashData_Api", "(I[B)I", "GetReadFlashData_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int ReadFlashData_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("readNvRamFile_Api", "(I[BI)I", "GetReadNvRamFile_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int ReadNvRamFile_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("readRsaKey_Api", "([B)I", "GetReadRsaKey_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int ReadRsaKey_Api (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='registerTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
		[Register ("registerTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetRegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool RegisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAdminPassword_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAdminPassword_Api", "(Ljava/lang/String;)I", "GetSetAdminPassword_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int SetAdminPassword_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setApplicationType_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setApplicationType_Api", "(Z)V", "GetSetApplicationType_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void SetApplicationType_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAutoTimeZone_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoTimeZone_Api", "(Z)Z", "GetSetAutoTimeZone_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetAutoTimeZone_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAutoTime_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoTime_Api", "(Z)Z", "GetSetAutoTime_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetAutoTime_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setDataEnabled_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDataEnabled_Api", "(Z)Z", "GetSetDataEnabled_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetDataEnabled_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setLauncherApp_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setLauncherApp_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetLauncherApp_Api (string? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setNtpServer_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNtpServer_Api", "(Ljava/lang/String;)Z", "GetSetNtpServer_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetNtpServer_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setResumeRechargeValue_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setResumeRechargeValue_Api", "(Ljava/lang/String;)Z", "GetSetResumeRechargeValue_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetResumeRechargeValue_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSettingsPWD_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSettingsPWD_Api", "(Ljava/lang/String;)I", "GetSetSettingsPWD_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int SetSettingsPWD_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSgnCheckEnable_Api' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSgnCheckEnable_Api", "(ZLjava/lang/String;)I", "GetSetSgnCheckEnable_Api_ZLjava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int SetSgnCheckEnable_Api (bool p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setSmartPosID", "([B)I", "GetSetSmartPosID_arrayBHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int SetSmartPosID (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSystemFunction' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setSystemFunction", "(Landroid/os/Bundle;)Z", "GetSetSystemFunction_Landroid_os_Bundle_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetSystemFunction (global::Android.OS.Bundle? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setTimeZone_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTimeZone_Api", "(Ljava/lang/String;)Z", "GetSetTimeZone_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetTimeZone_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setTrustedBluetoothMAC_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTrustedBluetoothMAC_Api", "(Ljava/lang/String;)Z", "GetSetTrustedBluetoothMAC_Api_Ljava_lang_String_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SetTrustedBluetoothMAC_Api (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='silentInstallApk_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IApkInstallResultAIDL']]"
		[Register ("silentInstallApk_Api", "(Ljava/lang/String;Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkInstallResultAIDL;)V", "GetSilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void SilentInstallApk_Api (string? p0, string? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='silentUnInstallApk_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IApkUnInstallResultAIDL']]"
		[Register ("silentUnInstallApk_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkUnInstallResultAIDL;)V", "GetSilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void SilentUnInstallApk_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='stopBeep_api' and count(parameter)=0]"
		[Register ("stopBeep_api", "()V", "GetStopBeep_apiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void StopBeep_api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='stopCatch_Api' and count(parameter)=0]"
		[Register ("stopCatch_Api", "()Z", "GetStopCatch_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool StopCatch_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchAppEnable_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("switchAppEnable_Api", "(Ljava/lang/String;Z)Z", "GetSwitchAppEnable_Api_Ljava_lang_String_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SwitchAppEnable_Api (string? p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchChargeOnRS232_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("switchChargeOnRS232_Api", "(Z)Z", "GetSwitchChargeOnRS232_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SwitchChargeOnRS232_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchDefaultDataSIM_Api' and count(parameter)=0]"
		[Register ("switchDefaultDataSIM_Api", "()Z", "GetSwitchDefaultDataSIM_ApiHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SwitchDefaultDataSIM_Api ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchGPS_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("switchGPS_Api", "(Z)Z", "GetSwitchGPS_Api_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool SwitchGPS_Api (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='unregisterTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
		[Register ("unregisterTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetUnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool UnregisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='updateSystem_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.ISystemUpdate']]"
		[Register ("updateSystem_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/ISystemUpdate;)I", "GetUpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_Handler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int UpdateSystem_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='validatePermission' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("validatePermission", "(Z)V", "GetValidatePermission_ZHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		void ValidatePermission (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeFileToSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeFileToSE_Api", "(Ljava/lang/String;[BII)I", "GetWriteFileToSE_Api_Ljava_lang_String_arrayBIIHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int WriteFileToSE_Api (string? p0, byte[]? p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("writeFlashData_Api", "(I[B)I", "GetWriteFlashData_Api_IarrayBHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int WriteFlashData_Api (int p0, byte[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("writeNvRamFile_Api", "(I[BI)I", "GetWriteNvRamFile_Api_IarrayBIHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		int WriteNvRamFile_Api (int p0, byte[]? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeRsaKey_Api", "([B)Z", "GetWriteRsaKey_Api_arrayBHandler:Com.Vanstone.Appsdk.Api.System.ISystemHandlerInvoker, VanstonePosSdk")]
		bool WriteRsaKey_Api (byte[]? p0);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/system/SystemHandler$Default", DoNotGenerateAcw=true)]
		public partial class Default : global::Java.Lang.Object, global::Com.Vanstone.Appsdk.Api.System.ISystemHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/system/SystemHandler$Default", typeof (Default));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/constructor[@name='SystemHandler.Default' and count(parameter)=0]"
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

			static Delegate? cb_getAdminPassword_Api;
#pragma warning disable 0169
			static Delegate GetGetAdminPassword_ApiHandler ()
			{
				if (cb_getAdminPassword_Api == null)
					cb_getAdminPassword_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdminPassword_Api));
				return cb_getAdminPassword_Api;
			}

			static IntPtr n_GetAdminPassword_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.AdminPassword_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? AdminPassword_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getAdminPassword_Api' and count(parameter)=0]"
				[Register ("getAdminPassword_Api", "()Ljava/lang/String;", "GetGetAdminPassword_ApiHandler")]
				get {
					const string __id = "getAdminPassword_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_GetAllVersion_Api;
#pragma warning disable 0169
			static Delegate GetGetAllVersion_ApiHandler ()
			{
				if (cb_GetAllVersion_Api == null)
					cb_GetAllVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAllVersion_Api));
				return cb_GetAllVersion_Api;
			}

			static IntPtr n_GetAllVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AllVersion_Api);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.OS.Bundle? AllVersion_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='GetAllVersion_Api' and count(parameter)=0]"
				[Register ("GetAllVersion_Api", "()Landroid/os/Bundle;", "GetGetAllVersion_ApiHandler")]
				get {
					const string __id = "GetAllVersion_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getAndroidKernelVersion;
#pragma warning disable 0169
			static Delegate GetGetAndroidKernelVersionHandler ()
			{
				if (cb_getAndroidKernelVersion == null)
					cb_getAndroidKernelVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAndroidKernelVersion));
				return cb_getAndroidKernelVersion;
			}

			static IntPtr n_GetAndroidKernelVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.AndroidKernelVersion);
			}
#pragma warning restore 0169

			public virtual unsafe string? AndroidKernelVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getAndroidKernelVersion' and count(parameter)=0]"
				[Register ("getAndroidKernelVersion", "()Ljava/lang/String;", "GetGetAndroidKernelVersionHandler")]
				get {
					const string __id = "getAndroidKernelVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getAntennaState;
#pragma warning disable 0169
			static Delegate GetGetAntennaStateHandler ()
			{
				if (cb_getAntennaState == null)
					cb_getAntennaState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetAntennaState));
				return cb_getAntennaState;
			}

			static int n_GetAntennaState (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.AntennaState;
			}
#pragma warning restore 0169

			public virtual unsafe int AntennaState {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getAntennaState' and count(parameter)=0]"
				[Register ("getAntennaState", "()I", "GetGetAntennaStateHandler")]
				get {
					const string __id = "getAntennaState.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getAutoTimeState_Api;
#pragma warning disable 0169
			static Delegate GetGetAutoTimeState_ApiHandler ()
			{
				if (cb_getAutoTimeState_Api == null)
					cb_getAutoTimeState_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetAutoTimeState_Api));
				return cb_getAutoTimeState_Api;
			}

			static bool n_GetAutoTimeState_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.AutoTimeState_Api;
			}
#pragma warning restore 0169

			public virtual unsafe bool AutoTimeState_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getAutoTimeState_Api' and count(parameter)=0]"
				[Register ("getAutoTimeState_Api", "()Z", "GetGetAutoTimeState_ApiHandler")]
				get {
					const string __id = "getAutoTimeState_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getAutoTimeZoneState_Api;
#pragma warning disable 0169
			static Delegate GetGetAutoTimeZoneState_ApiHandler ()
			{
				if (cb_getAutoTimeZoneState_Api == null)
					cb_getAutoTimeZoneState_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetAutoTimeZoneState_Api));
				return cb_getAutoTimeZoneState_Api;
			}

			static bool n_GetAutoTimeZoneState_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.AutoTimeZoneState_Api;
			}
#pragma warning restore 0169

			public virtual unsafe bool AutoTimeZoneState_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getAutoTimeZoneState_Api' and count(parameter)=0]"
				[Register ("getAutoTimeZoneState_Api", "()Z", "GetGetAutoTimeZoneState_ApiHandler")]
				get {
					const string __id = "getAutoTimeZoneState_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getCSN;
#pragma warning disable 0169
			static Delegate GetGetCSNHandler ()
			{
				if (cb_getCSN == null)
					cb_getCSN = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCSN));
				return cb_getCSN;
			}

			static IntPtr n_GetCSN (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.CSN);
			}
#pragma warning restore 0169

			public virtual unsafe string? CSN {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getCSN' and count(parameter)=0]"
				[Register ("getCSN", "()Ljava/lang/String;", "GetGetCSNHandler")]
				get {
					const string __id = "getCSN.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getDebuggableStatus_Api;
#pragma warning disable 0169
			static Delegate GetGetDebuggableStatus_ApiHandler ()
			{
				if (cb_getDebuggableStatus_Api == null)
					cb_getDebuggableStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetDebuggableStatus_Api));
				return cb_getDebuggableStatus_Api;
			}

			static bool n_GetDebuggableStatus_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DebuggableStatus_Api;
			}
#pragma warning restore 0169

			public virtual unsafe bool DebuggableStatus_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getDebuggableStatus_Api' and count(parameter)=0]"
				[Register ("getDebuggableStatus_Api", "()Z", "GetGetDebuggableStatus_ApiHandler")]
				get {
					const string __id = "getDebuggableStatus_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getDefaultDataSIM_Api;
#pragma warning disable 0169
			static Delegate GetGetDefaultDataSIM_ApiHandler ()
			{
				if (cb_getDefaultDataSIM_Api == null)
					cb_getDefaultDataSIM_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDefaultDataSIM_Api));
				return cb_getDefaultDataSIM_Api;
			}

			static IntPtr n_GetDefaultDataSIM_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DefaultDataSIM_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? DefaultDataSIM_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getDefaultDataSIM_Api' and count(parameter)=0]"
				[Register ("getDefaultDataSIM_Api", "()Ljava/lang/String;", "GetGetDefaultDataSIM_ApiHandler")]
				get {
					const string __id = "getDefaultDataSIM_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getFirmwareVersion;
#pragma warning disable 0169
			static Delegate GetGetFirmwareVersionHandler ()
			{
				if (cb_getFirmwareVersion == null)
					cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFirmwareVersion));
				return cb_getFirmwareVersion;
			}

			static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.FirmwareVersion);
			}
#pragma warning restore 0169

			public virtual unsafe string? FirmwareVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getFirmwareVersion' and count(parameter)=0]"
				[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler")]
				get {
					const string __id = "getFirmwareVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getHardwareVersion;
#pragma warning disable 0169
			static Delegate GetGetHardwareVersionHandler ()
			{
				if (cb_getHardwareVersion == null)
					cb_getHardwareVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHardwareVersion));
				return cb_getHardwareVersion;
			}

			static IntPtr n_GetHardwareVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.HardwareVersion);
			}
#pragma warning restore 0169

			public virtual unsafe string? HardwareVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getHardwareVersion' and count(parameter)=0]"
				[Register ("getHardwareVersion", "()Ljava/lang/String;", "GetGetHardwareVersionHandler")]
				get {
					const string __id = "getHardwareVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getImei;
#pragma warning disable 0169
			static Delegate GetGetImeiHandler ()
			{
				if (cb_getImei == null)
					cb_getImei = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetImei));
				return cb_getImei;
			}

			static IntPtr n_GetImei (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Imei);
			}
#pragma warning restore 0169

			public virtual unsafe string? Imei {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getImei' and count(parameter)=0]"
				[Register ("getImei", "()Ljava/lang/String;", "GetGetImeiHandler")]
				get {
					const string __id = "getImei.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_isDebug_Api;
#pragma warning disable 0169
			static Delegate GetIsDebug_ApiHandler ()
			{
				if (cb_isDebug_Api == null)
					cb_isDebug_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsDebug_Api));
				return cb_isDebug_Api;
			}

			static bool n_IsDebug_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsDebug_Api;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsDebug_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='isDebug_Api' and count(parameter)=0]"
				[Register ("isDebug_Api", "()Z", "GetIsDebug_ApiHandler")]
				get {
					const string __id = "isDebug_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getLastShutdownCause_Api;
#pragma warning disable 0169
			static Delegate GetGetLastShutdownCause_ApiHandler ()
			{
				if (cb_getLastShutdownCause_Api == null)
					cb_getLastShutdownCause_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetLastShutdownCause_Api));
				return cb_getLastShutdownCause_Api;
			}

			static int n_GetLastShutdownCause_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LastShutdownCause_Api;
			}
#pragma warning restore 0169

			public virtual unsafe int LastShutdownCause_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getLastShutdownCause_Api' and count(parameter)=0]"
				[Register ("getLastShutdownCause_Api", "()I", "GetGetLastShutdownCause_ApiHandler")]
				get {
					const string __id = "getLastShutdownCause_Api.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getLifeInform_Api;
#pragma warning disable 0169
			static Delegate GetGetLifeInform_ApiHandler ()
			{
				if (cb_getLifeInform_Api == null)
					cb_getLifeInform_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLifeInform_Api));
				return cb_getLifeInform_Api;
			}

			static IntPtr n_GetLifeInform_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.LifeInform_Api);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.OS.Bundle? LifeInform_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getLifeInform_Api' and count(parameter)=0]"
				[Register ("getLifeInform_Api", "()Landroid/os/Bundle;", "GetGetLifeInform_ApiHandler")]
				get {
					const string __id = "getLifeInform_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getMachineType_Api;
#pragma warning disable 0169
			static Delegate GetGetMachineType_ApiHandler ()
			{
				if (cb_getMachineType_Api == null)
					cb_getMachineType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMachineType_Api));
				return cb_getMachineType_Api;
			}

			static IntPtr n_GetMachineType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.MachineType_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? MachineType_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getMachineType_Api' and count(parameter)=0]"
				[Register ("getMachineType_Api", "()Ljava/lang/String;", "GetGetMachineType_ApiHandler")]
				get {
					const string __id = "getMachineType_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getModuleSupport_Api;
#pragma warning disable 0169
			static Delegate GetGetModuleSupport_ApiHandler ()
			{
				if (cb_getModuleSupport_Api == null)
					cb_getModuleSupport_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetModuleSupport_Api));
				return cb_getModuleSupport_Api;
			}

			static IntPtr n_GetModuleSupport_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ModuleSupport_Api);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.OS.Bundle? ModuleSupport_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getModuleSupport_Api' and count(parameter)=0]"
				[Register ("getModuleSupport_Api", "()Landroid/os/Bundle;", "GetGetModuleSupport_ApiHandler")]
				get {
					const string __id = "getModuleSupport_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getNtpServer_Api;
#pragma warning disable 0169
			static Delegate GetGetNtpServer_ApiHandler ()
			{
				if (cb_getNtpServer_Api == null)
					cb_getNtpServer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNtpServer_Api));
				return cb_getNtpServer_Api;
			}

			static IntPtr n_GetNtpServer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.NtpServer_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? NtpServer_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getNtpServer_Api' and count(parameter)=0]"
				[Register ("getNtpServer_Api", "()Ljava/lang/String;", "GetGetNtpServer_ApiHandler")]
				get {
					const string __id = "getNtpServer_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getROMVersion;
#pragma warning disable 0169
			static Delegate GetGetROMVersionHandler ()
			{
				if (cb_getROMVersion == null)
					cb_getROMVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetROMVersion));
				return cb_getROMVersion;
			}

			static IntPtr n_GetROMVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.ROMVersion);
			}
#pragma warning restore 0169

			public virtual unsafe string? ROMVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getROMVersion' and count(parameter)=0]"
				[Register ("getROMVersion", "()Ljava/lang/String;", "GetGetROMVersionHandler")]
				get {
					const string __id = "getROMVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getResumeRechargeValue_Api;
#pragma warning disable 0169
			static Delegate GetGetResumeRechargeValue_ApiHandler ()
			{
				if (cb_getResumeRechargeValue_Api == null)
					cb_getResumeRechargeValue_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResumeRechargeValue_Api));
				return cb_getResumeRechargeValue_Api;
			}

			static IntPtr n_GetResumeRechargeValue_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.ResumeRechargeValue_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? ResumeRechargeValue_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getResumeRechargeValue_Api' and count(parameter)=0]"
				[Register ("getResumeRechargeValue_Api", "()Ljava/lang/String;", "GetGetResumeRechargeValue_ApiHandler")]
				get {
					const string __id = "getResumeRechargeValue_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getRootCertName_Api;
#pragma warning disable 0169
			static Delegate GetGetRootCertName_ApiHandler ()
			{
				if (cb_getRootCertName_Api == null)
					cb_getRootCertName_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRootCertName_Api));
				return cb_getRootCertName_Api;
			}

			static IntPtr n_GetRootCertName_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.RootCertName_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? RootCertName_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getRootCertName_Api' and count(parameter)=0]"
				[Register ("getRootCertName_Api", "()Ljava/lang/String;", "GetGetRootCertName_ApiHandler")]
				get {
					const string __id = "getRootCertName_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getRootCertVersion_Api;
#pragma warning disable 0169
			static Delegate GetGetRootCertVersion_ApiHandler ()
			{
				if (cb_getRootCertVersion_Api == null)
					cb_getRootCertVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRootCertVersion_Api));
				return cb_getRootCertVersion_Api;
			}

			static IntPtr n_GetRootCertVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.RootCertVersion_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? RootCertVersion_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getRootCertVersion_Api' and count(parameter)=0]"
				[Register ("getRootCertVersion_Api", "()Ljava/lang/String;", "GetGetRootCertVersion_ApiHandler")]
				get {
					const string __id = "getRootCertVersion_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSettingsPWD_Api;
#pragma warning disable 0169
			static Delegate GetGetSettingsPWD_ApiHandler ()
			{
				if (cb_getSettingsPWD_Api == null)
					cb_getSettingsPWD_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSettingsPWD_Api));
				return cb_getSettingsPWD_Api;
			}

			static IntPtr n_GetSettingsPWD_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.SettingsPWD_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? SettingsPWD_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getSettingsPWD_Api' and count(parameter)=0]"
				[Register ("getSettingsPWD_Api", "()Ljava/lang/String;", "GetGetSettingsPWD_ApiHandler")]
				get {
					const string __id = "getSettingsPWD_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSysHWMaintainIntent;
#pragma warning disable 0169
			static Delegate GetGetSysHWMaintainIntentHandler ()
			{
				if (cb_getSysHWMaintainIntent == null)
					cb_getSysHWMaintainIntent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysHWMaintainIntent));
				return cb_getSysHWMaintainIntent;
			}

			static IntPtr n_GetSysHWMaintainIntent (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SysHWMaintainIntent);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Content.Intent? SysHWMaintainIntent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getSysHWMaintainIntent' and count(parameter)=0]"
				[Register ("getSysHWMaintainIntent", "()Landroid/content/Intent;", "GetGetSysHWMaintainIntentHandler")]
				get {
					const string __id = "getSysHWMaintainIntent.()Landroid/content/Intent;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSysOTAVerison_Api;
#pragma warning disable 0169
			static Delegate GetGetSysOTAVerison_ApiHandler ()
			{
				if (cb_getSysOTAVerison_Api == null)
					cb_getSysOTAVerison_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysOTAVerison_Api));
				return cb_getSysOTAVerison_Api;
			}

			static IntPtr n_GetSysOTAVerison_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.SysOTAVerison_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? SysOTAVerison_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getSysOTAVerison_Api' and count(parameter)=0]"
				[Register ("getSysOTAVerison_Api", "()Ljava/lang/String;", "GetGetSysOTAVerison_ApiHandler")]
				get {
					const string __id = "getSysOTAVerison_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSysgHWDetectionIntent;
#pragma warning disable 0169
			static Delegate GetGetSysgHWDetectionIntentHandler ()
			{
				if (cb_getSysgHWDetectionIntent == null)
					cb_getSysgHWDetectionIntent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysgHWDetectionIntent));
				return cb_getSysgHWDetectionIntent;
			}

			static IntPtr n_GetSysgHWDetectionIntent (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SysgHWDetectionIntent);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Content.Intent? SysgHWDetectionIntent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getSysgHWDetectionIntent' and count(parameter)=0]"
				[Register ("getSysgHWDetectionIntent", "()Landroid/content/Intent;", "GetGetSysgHWDetectionIntentHandler")]
				get {
					const string __id = "getSysgHWDetectionIntent.()Landroid/content/Intent;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getSystemInform_Api;
#pragma warning disable 0169
			static Delegate GetGetSystemInform_ApiHandler ()
			{
				if (cb_getSystemInform_Api == null)
					cb_getSystemInform_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSystemInform_Api));
				return cb_getSystemInform_Api;
			}

			static IntPtr n_GetSystemInform_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SystemInform_Api);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.OS.Bundle? SystemInform_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getSystemInform_Api' and count(parameter)=0]"
				[Register ("getSystemInform_Api", "()Landroid/os/Bundle;", "GetGetSystemInform_ApiHandler")]
				get {
					const string __id = "getSystemInform_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getTimeZone_Api;
#pragma warning disable 0169
			static Delegate GetGetTimeZone_ApiHandler ()
			{
				if (cb_getTimeZone_Api == null)
					cb_getTimeZone_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTimeZone_Api));
				return cb_getTimeZone_Api;
			}

			static IntPtr n_GetTimeZone_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.TimeZone_Api);
			}
#pragma warning restore 0169

			public virtual unsafe string? TimeZone_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getTimeZone_Api' and count(parameter)=0]"
				[Register ("getTimeZone_Api", "()Ljava/lang/String;", "GetGetTimeZone_ApiHandler")]
				get {
					const string __id = "getTimeZone_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getUndeletableAppList_Api;
#pragma warning disable 0169
			static Delegate GetGetUndeletableAppList_ApiHandler ()
			{
				if (cb_getUndeletableAppList_Api == null)
					cb_getUndeletableAppList_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetUndeletableAppList_Api));
				return cb_getUndeletableAppList_Api;
			}

			static IntPtr n_GetUndeletableAppList_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UndeletableAppList_Api);
			}
#pragma warning restore 0169

			public virtual unsafe global::System.Collections.Generic.IList<string>? UndeletableAppList_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getUndeletableAppList_Api' and count(parameter)=0]"
				[Register ("getUndeletableAppList_Api", "()Ljava/util/List;", "GetGetUndeletableAppList_ApiHandler")]
				get {
					const string __id = "getUndeletableAppList_Api.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_Handler ()
			{
				if (cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ == null)
					cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_));
				return cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_;
			}

			static int n_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_PackageNames_In, IntPtr native_Path_Out)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var PackageNames_In = global::Android.Runtime.JavaList<string>.FromJniHandle (native_PackageNames_In, JniHandleOwnership.DoNotTransfer);
				var Path_Out = JNIEnv.GetString (native_Path_Out, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.BackUpByPackage_Api (PackageNames_In, Path_Out);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='BackUpByPackage_Api' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
			[Register ("BackUpByPackage_Api", "(Ljava/util/List;Ljava/lang/String;)I", "GetBackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_Handler")]
			public virtual unsafe int BackUpByPackage_Api (global::System.Collections.Generic.IList<string>? PackageNames_In, string? Path_Out)
			{
				const string __id = "BackUpByPackage_Api.(Ljava/util/List;Ljava/lang/String;)I";
				IntPtr native_PackageNames_In = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (PackageNames_In);
				IntPtr native_Path_Out = JNIEnv.NewString ((string?)Path_Out);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_PackageNames_In);
					__args [1] = new JniArgumentValue (native_Path_Out);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_PackageNames_In);
					JNIEnv.DeleteLocalRef (native_Path_Out);
					global::System.GC.KeepAlive (PackageNames_In);
				}
			}

			static Delegate? cb_Beef_Api_II;
#pragma warning disable 0169
			static Delegate GetBeef_Api_IIHandler ()
			{
				if (cb_Beef_Api_II == null)
					cb_Beef_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_Beef_Api_II));
				return cb_Beef_Api_II;
			}

			static void n_Beef_Api_II (IntPtr jnienv, IntPtr native__this, int ucMode, int DlyTime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.Beef_Api (ucMode, DlyTime);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='Beef_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("Beef_Api", "(II)V", "GetBeef_Api_IIHandler")]
			public virtual unsafe void Beef_Api (int ucMode, int DlyTime)
			{
				const string __id = "Beef_Api.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (ucMode);
					__args [1] = new JniArgumentValue (DlyTime);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_Beep_Api_I;
#pragma warning disable 0169
			static Delegate GetBeep_Api_IHandler ()
			{
				if (cb_Beep_Api_I == null)
					cb_Beep_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Beep_Api_I));
				return cb_Beep_Api_I;
			}

			static void n_Beep_Api_I (IntPtr jnienv, IntPtr native__this, int flag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.Beep_Api (flag);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='Beep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Beep_Api", "(I)V", "GetBeep_Api_IHandler")]
			public virtual unsafe void Beep_Api (int flag)
			{
				const string __id = "Beep_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (flag);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_CheckModuleStatue_Api_I;
#pragma warning disable 0169
			static Delegate GetCheckModuleStatue_Api_IHandler ()
			{
				if (cb_CheckModuleStatue_Api_I == null)
					cb_CheckModuleStatue_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_CheckModuleStatue_Api_I));
				return cb_CheckModuleStatue_Api_I;
			}

			static int n_CheckModuleStatue_Api_I (IntPtr jnienv, IntPtr native__this, int moduleId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CheckModuleStatue_Api (moduleId);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='CheckModuleStatue_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("CheckModuleStatue_Api", "(I)I", "GetCheckModuleStatue_Api_IHandler")]
			public virtual unsafe int CheckModuleStatue_Api (int moduleId)
			{
				const string __id = "CheckModuleStatue_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (moduleId);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_GateClose_Api;
#pragma warning disable 0169
			static Delegate GetGateClose_ApiHandler ()
			{
				if (cb_GateClose_Api == null)
					cb_GateClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GateClose_Api));
				return cb_GateClose_Api;
			}

			static int n_GateClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GateClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='GateClose_Api' and count(parameter)=0]"
			[Register ("GateClose_Api", "()I", "GetGateClose_ApiHandler")]
			public virtual unsafe int GateClose_Api ()
			{
				const string __id = "GateClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_GateOpen_Api;
#pragma warning disable 0169
			static Delegate GetGateOpen_ApiHandler ()
			{
				if (cb_GateOpen_Api == null)
					cb_GateOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GateOpen_Api));
				return cb_GateOpen_Api;
			}

			static int n_GateOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GateOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='GateOpen_Api' and count(parameter)=0]"
			[Register ("GateOpen_Api", "()I", "GetGateOpen_ApiHandler")]
			public virtual unsafe int GateOpen_Api ()
			{
				const string __id = "GateOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_GetVersion_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetVersion_Api_arrayBarrayBHandler ()
			{
				if (cb_GetVersion_Api_arrayBarrayB == null)
					cb_GetVersion_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_GetVersion_Api_arrayBarrayB));
				return cb_GetVersion_Api_arrayBarrayB;
			}

			static int n_GetVersion_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_lpOut, IntPtr native_VersionNum)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var lpOut = (byte[]?) JNIEnv.GetArray (native_lpOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var VersionNum = (byte[]?) JNIEnv.GetArray (native_VersionNum, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetVersion_Api (lpOut, VersionNum);
				if (lpOut != null)
					JNIEnv.CopyArray (lpOut, native_lpOut);
				if (VersionNum != null)
					JNIEnv.CopyArray (VersionNum, native_VersionNum);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='GetVersion_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("GetVersion_Api", "([B[B)I", "GetGetVersion_Api_arrayBarrayBHandler")]
			public virtual unsafe int GetVersion_Api (byte[]? lpOut, byte[]? VersionNum)
			{
				const string __id = "GetVersion_Api.([B[B)I";
				IntPtr native_lpOut = JNIEnv.NewArray (lpOut);
				IntPtr native_VersionNum = JNIEnv.NewArray (VersionNum);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_lpOut);
					__args [1] = new JniArgumentValue (native_VersionNum);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (lpOut != null) {
						JNIEnv.CopyArray (native_lpOut, lpOut);
						JNIEnv.DeleteLocalRef (native_lpOut);
					}
					if (VersionNum != null) {
						JNIEnv.CopyArray (native_VersionNum, VersionNum);
						JNIEnv.DeleteLocalRef (native_VersionNum);
					}
					global::System.GC.KeepAlive (lpOut);
					global::System.GC.KeepAlive (VersionNum);
				}
			}

			static Delegate? cb_IsHandleOnBase_Api;
#pragma warning disable 0169
			static Delegate GetIsHandleOnBase_ApiHandler ()
			{
				if (cb_IsHandleOnBase_Api == null)
					cb_IsHandleOnBase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_IsHandleOnBase_Api));
				return cb_IsHandleOnBase_Api;
			}

			static int n_IsHandleOnBase_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsHandleOnBase_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='IsHandleOnBase_Api' and count(parameter)=0]"
			[Register ("IsHandleOnBase_Api", "()I", "GetIsHandleOnBase_ApiHandler")]
			public virtual unsafe int IsHandleOnBase_Api ()
			{
				const string __id = "IsHandleOnBase_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_ReadPosSn;
#pragma warning disable 0169
			static Delegate GetReadPosSnHandler ()
			{
				if (cb_ReadPosSn == null)
					cb_ReadPosSn = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ReadPosSn));
				return cb_ReadPosSn;
			}

			static IntPtr n_ReadPosSn (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.ReadPosSn ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='ReadPosSn' and count(parameter)=0]"
			[Register ("ReadPosSn", "()Ljava/lang/String;", "GetReadPosSnHandler")]
			public virtual unsafe string? ReadPosSn ()
			{
				const string __id = "ReadPosSn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_RestoreDatda_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRestoreDatda_Api_Ljava_lang_String_Handler ()
			{
				if (cb_RestoreDatda_Api_Ljava_lang_String_ == null)
					cb_RestoreDatda_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_RestoreDatda_Api_Ljava_lang_String_));
				return cb_RestoreDatda_Api_Ljava_lang_String_;
			}

			static int n_RestoreDatda_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_FilePath_In)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var FilePath_In = JNIEnv.GetString (native_FilePath_In, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.RestoreDatda_Api (FilePath_In);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='RestoreDatda_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("RestoreDatda_Api", "(Ljava/lang/String;)I", "GetRestoreDatda_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int RestoreDatda_Api (string? FilePath_In)
			{
				const string __id = "RestoreDatda_Api.(Ljava/lang/String;)I";
				IntPtr native_FilePath_In = JNIEnv.NewString ((string?)FilePath_In);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_FilePath_In);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_FilePath_In);
				}
			}

			static Delegate? cb_RestoreFactory_Api_Z;
#pragma warning disable 0169
			static Delegate GetRestoreFactory_Api_ZHandler ()
			{
				if (cb_RestoreFactory_Api_Z == null)
					cb_RestoreFactory_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_RestoreFactory_Api_Z));
				return cb_RestoreFactory_Api_Z;
			}

			static void n_RestoreFactory_Api_Z (IntPtr jnienv, IntPtr native__this, bool IsWarning)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.RestoreFactory_Api (IsWarning);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='RestoreFactory_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("RestoreFactory_Api", "(Z)V", "GetRestoreFactory_Api_ZHandler")]
			public virtual unsafe void RestoreFactory_Api (bool IsWarning)
			{
				const string __id = "RestoreFactory_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (IsWarning);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_SetAdbEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetAdbEnable_Api_ZHandler ()
			{
				if (cb_SetAdbEnable_Api_Z == null)
					cb_SetAdbEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAdbEnable_Api_Z));
				return cb_SetAdbEnable_Api_Z;
			}

			static bool n_SetAdbEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool enable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetAdbEnable_Api (enable);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SetAdbEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetAdbEnable_Api", "(Z)Z", "GetSetAdbEnable_Api_ZHandler")]
			public virtual unsafe bool SetAdbEnable_Api (bool enable)
			{
				const string __id = "SetAdbEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SetBaseBroadcast_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetBaseBroadcast_Api_ZHandler ()
			{
				if (cb_SetBaseBroadcast_Api_Z == null)
					cb_SetBaseBroadcast_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetBaseBroadcast_Api_Z));
				return cb_SetBaseBroadcast_Api_Z;
			}

			static void n_SetBaseBroadcast_Api_Z (IntPtr jnienv, IntPtr native__this, bool open)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetBaseBroadcast_Api (open);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SetBaseBroadcast_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetBaseBroadcast_Api", "(Z)V", "GetSetBaseBroadcast_Api_ZHandler")]
			public virtual unsafe void SetBaseBroadcast_Api (bool open)
			{
				const string __id = "SetBaseBroadcast_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (open);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_SetBluetoothEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetBluetoothEnable_Api_ZHandler ()
			{
				if (cb_SetBluetoothEnable_Api_Z == null)
					cb_SetBluetoothEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetBluetoothEnable_Api_Z));
				return cb_SetBluetoothEnable_Api_Z;
			}

			static bool n_SetBluetoothEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool enable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetBluetoothEnable_Api (enable);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SetBluetoothEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetBluetoothEnable_Api", "(Z)Z", "GetSetBluetoothEnable_Api_ZHandler")]
			public virtual unsafe bool SetBluetoothEnable_Api (bool enable)
			{
				const string __id = "SetBluetoothEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SetOtgEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetOtgEnable_Api_ZHandler ()
			{
				if (cb_SetOtgEnable_Api_Z == null)
					cb_SetOtgEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetOtgEnable_Api_Z));
				return cb_SetOtgEnable_Api_Z;
			}

			static bool n_SetOtgEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool enable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetOtgEnable_Api (enable);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SetOtgEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetOtgEnable_Api", "(Z)Z", "GetSetOtgEnable_Api_ZHandler")]
			public virtual unsafe bool SetOtgEnable_Api (bool enable)
			{
				const string __id = "SetOtgEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SetSetScreenOffTimeout_Api_I;
#pragma warning disable 0169
			static Delegate GetSetSetScreenOffTimeout_Api_IHandler ()
			{
				if (cb_SetSetScreenOffTimeout_Api_I == null)
					cb_SetSetScreenOffTimeout_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_SetSetScreenOffTimeout_Api_I));
				return cb_SetSetScreenOffTimeout_Api_I;
			}

			static bool n_SetSetScreenOffTimeout_Api_I (IntPtr jnienv, IntPtr native__this, int time)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetSetScreenOffTimeout_Api (time);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SetSetScreenOffTimeout_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetSetScreenOffTimeout_Api", "(I)Z", "GetSetSetScreenOffTimeout_Api_IHandler")]
			public virtual unsafe bool SetSetScreenOffTimeout_Api (int time)
			{
				const string __id = "SetSetScreenOffTimeout_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (time);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SetTime_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTime_Api_Ljava_lang_String_Handler ()
			{
				if (cb_SetTime_Api_Ljava_lang_String_ == null)
					cb_SetTime_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetTime_Api_Ljava_lang_String_));
				return cb_SetTime_Api_Ljava_lang_String_;
			}

			static int n_SetTime_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var dt = JNIEnv.GetString (native_dt, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetTime_Api (dt);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SetTime_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetTime_Api", "(Ljava/lang/String;)I", "GetSetTime_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int SetTime_Api (string? dt)
			{
				const string __id = "SetTime_Api.(Ljava/lang/String;)I";
				IntPtr native_dt = JNIEnv.NewString ((string?)dt);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_dt);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_dt);
				}
			}

			static Delegate? cb_SetWifiAddNetworkEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetWifiAddNetworkEnable_Api_ZHandler ()
			{
				if (cb_SetWifiAddNetworkEnable_Api_Z == null)
					cb_SetWifiAddNetworkEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetWifiAddNetworkEnable_Api_Z));
				return cb_SetWifiAddNetworkEnable_Api_Z;
			}

			static bool n_SetWifiAddNetworkEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool enable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetWifiAddNetworkEnable_Api (enable);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SetWifiAddNetworkEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetWifiAddNetworkEnable_Api", "(Z)Z", "GetSetWifiAddNetworkEnable_Api_ZHandler")]
			public virtual unsafe bool SetWifiAddNetworkEnable_Api (bool enable)
			{
				const string __id = "SetWifiAddNetworkEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_SystemPowerOff_Api;
#pragma warning disable 0169
			static Delegate GetSystemPowerOff_ApiHandler ()
			{
				if (cb_SystemPowerOff_Api == null)
					cb_SystemPowerOff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SystemPowerOff_Api));
				return cb_SystemPowerOff_Api;
			}

			static void n_SystemPowerOff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SystemPowerOff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SystemPowerOff_Api' and count(parameter)=0]"
			[Register ("SystemPowerOff_Api", "()V", "GetSystemPowerOff_ApiHandler")]
			public virtual unsafe void SystemPowerOff_Api ()
			{
				const string __id = "SystemPowerOff_Api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_SystemReboot_Api;
#pragma warning disable 0169
			static Delegate GetSystemReboot_ApiHandler ()
			{
				if (cb_SystemReboot_Api == null)
					cb_SystemReboot_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SystemReboot_Api));
				return cb_SystemReboot_Api;
			}

			static void n_SystemReboot_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SystemReboot_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='SystemReboot_Api' and count(parameter)=0]"
			[Register ("SystemReboot_Api", "()V", "GetSystemReboot_ApiHandler")]
			public virtual unsafe void SystemReboot_Api ()
			{
				const string __id = "SystemReboot_Api.()V";
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate? cb_catchMainLog_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCatchMainLog_Api_Ljava_lang_String_Handler ()
			{
				if (cb_catchMainLog_Api_Ljava_lang_String_ == null)
					cb_catchMainLog_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_CatchMainLog_Api_Ljava_lang_String_));
				return cb_catchMainLog_Api_Ljava_lang_String_;
			}

			static bool n_CatchMainLog_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkgName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pkgName = JNIEnv.GetString (native_pkgName, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.CatchMainLog_Api (pkgName);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='catchMainLog_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("catchMainLog_Api", "(Ljava/lang/String;)Z", "GetCatchMainLog_Api_Ljava_lang_String_Handler")]
			public virtual unsafe bool CatchMainLog_Api (string? pkgName)
			{
				const string __id = "catchMainLog_Api.(Ljava/lang/String;)Z";
				IntPtr native_pkgName = JNIEnv.NewString ((string?)pkgName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_pkgName);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_pkgName);
				}
			}

			static Delegate? cb_deleteFileInSe_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteFileInSe_Api_Ljava_lang_String_Handler ()
			{
				if (cb_deleteFileInSe_Api_Ljava_lang_String_ == null)
					cb_deleteFileInSe_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DeleteFileInSe_Api_Ljava_lang_String_));
				return cb_deleteFileInSe_Api_Ljava_lang_String_;
			}

			static int n_DeleteFileInSe_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DeleteFileInSe_Api (fileName);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='deleteFileInSe_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteFileInSe_Api", "(Ljava/lang/String;)I", "GetDeleteFileInSe_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int DeleteFileInSe_Api (string? fileName)
			{
				const string __id = "deleteFileInSe_Api.(Ljava/lang/String;)I";
				IntPtr native_fileName = JNIEnv.NewString ((string?)fileName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_fileName);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_fileName);
				}
			}

			static Delegate? cb_deleteFlashData_Api_II;
#pragma warning disable 0169
			static Delegate GetDeleteFlashData_Api_IIHandler ()
			{
				if (cb_deleteFlashData_Api_II == null)
					cb_deleteFlashData_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_DeleteFlashData_Api_II));
				return cb_deleteFlashData_Api_II;
			}

			static int n_DeleteFlashData_Api_II (IntPtr jnienv, IntPtr native__this, int addr, int deleteLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DeleteFlashData_Api (addr, deleteLen);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='deleteFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("deleteFlashData_Api", "(II)I", "GetDeleteFlashData_Api_IIHandler")]
			public virtual unsafe int DeleteFlashData_Api (int addr, int deleteLen)
			{
				const string __id = "deleteFlashData_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (addr);
					__args [1] = new JniArgumentValue (deleteLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_deleteRsakey_Api;
#pragma warning disable 0169
			static Delegate GetDeleteRsakey_ApiHandler ()
			{
				if (cb_deleteRsakey_Api == null)
					cb_deleteRsakey_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_DeleteRsakey_Api));
				return cb_deleteRsakey_Api;
			}

			static bool n_DeleteRsakey_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DeleteRsakey_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='deleteRsakey_Api' and count(parameter)=0]"
			[Register ("deleteRsakey_Api", "()Z", "GetDeleteRsakey_ApiHandler")]
			public virtual unsafe bool DeleteRsakey_Api ()
			{
				const string __id = "deleteRsakey_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_getFileListInSe_Api_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetGetFileListInSe_Api_Ljava_util_List_Handler ()
			{
				if (cb_getFileListInSe_Api_Ljava_util_List_ == null)
					cb_getFileListInSe_Api_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFileListInSe_Api_Ljava_util_List_));
				return cb_getFileListInSe_Api_Ljava_util_List_;
			}

			static int n_GetFileListInSe_Api_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileList)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var fileList = global::Android.Runtime.JavaList<string>.FromJniHandle (native_fileList, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetFileListInSe_Api (fileList);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getFileListInSe_Api' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("getFileListInSe_Api", "(Ljava/util/List;)I", "GetGetFileListInSe_Api_Ljava_util_List_Handler")]
			public virtual unsafe int GetFileListInSe_Api (global::System.Collections.Generic.IList<string>? fileList)
			{
				const string __id = "getFileListInSe_Api.(Ljava/util/List;)I";
				IntPtr native_fileList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (fileList);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_fileList);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_fileList);
					global::System.GC.KeepAlive (fileList);
				}
			}

			static Delegate? cb_getSmartPosID_arrayB;
#pragma warning disable 0169
			static Delegate GetGetSmartPosID_arrayBHandler ()
			{
				if (cb_getSmartPosID_arrayB == null)
					cb_getSmartPosID_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetSmartPosID_arrayB));
				return cb_getSmartPosID_arrayB;
			}

			static int n_GetSmartPosID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buffer = (byte[]?) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetSmartPosID (buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("getSmartPosID", "([B)I", "GetGetSmartPosID_arrayBHandler")]
			public virtual unsafe int GetSmartPosID (byte[]? buffer)
			{
				const string __id = "getSmartPosID.([B)I";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_buffer);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
					global::System.GC.KeepAlive (buffer);
				}
			}

			static Delegate? cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_));
				return cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_GetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_start, IntPtr native_end)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var start = JNIEnv.GetString (native_start, JniHandleOwnership.DoNotTransfer);
				var end = JNIEnv.GetString (native_end, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTrafficStats_Api (start, end));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='getTrafficStats_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getTrafficStats_Api", "(Ljava/lang/String;Ljava/lang/String;)Lcom/vanstone/appsdk/api/struct/AidlTrafficStats;", "GetGetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats? GetTrafficStats_Api (string? start, string? end)
			{
				const string __id = "getTrafficStats_Api.(Ljava/lang/String;Ljava/lang/String;)Lcom/vanstone/appsdk/api/struct/AidlTrafficStats;";
				IntPtr native_start = JNIEnv.NewString ((string?)start);
				IntPtr native_end = JNIEnv.NewString ((string?)end);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_start);
					__args [1] = new JniArgumentValue (native_end);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_start);
					JNIEnv.DeleteLocalRef (native_end);
				}
			}

			static Delegate? cb_isForeground_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIsForeground_Api_Ljava_lang_String_Handler ()
			{
				if (cb_isForeground_Api_Ljava_lang_String_ == null)
					cb_isForeground_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsForeground_Api_Ljava_lang_String_));
				return cb_isForeground_Api_Ljava_lang_String_;
			}

			static bool n_IsForeground_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsForeground_Api (packageName);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='isForeground_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isForeground_Api", "(Ljava/lang/String;)Z", "GetIsForeground_Api_Ljava_lang_String_Handler")]
			public virtual unsafe bool IsForeground_Api (string? packageName)
			{
				const string __id = "isForeground_Api.(Ljava/lang/String;)Z";
				IntPtr native_packageName = JNIEnv.NewString ((string?)packageName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_packageName);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_packageName);
				}
			}

			static Delegate? cb_isdeviceEnabled_Api;
#pragma warning disable 0169
			static Delegate GetIsdeviceEnabled_ApiHandler ()
			{
				if (cb_isdeviceEnabled_Api == null)
					cb_isdeviceEnabled_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsdeviceEnabled_Api));
				return cb_isdeviceEnabled_Api;
			}

			static bool n_IsdeviceEnabled_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsdeviceEnabled_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='isdeviceEnabled_Api' and count(parameter)=0]"
			[Register ("isdeviceEnabled_Api", "()Z", "GetIsdeviceEnabled_ApiHandler")]
			public virtual unsafe bool IsdeviceEnabled_Api ()
			{
				const string __id = "isdeviceEnabled_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_readFileFromSE_Api_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
			static Delegate GetReadFileFromSE_Api_Ljava_lang_String_arrayBIIHandler ()
			{
				if (cb_readFileFromSE_Api_Ljava_lang_String_arrayBII == null)
					cb_readFileFromSE_Api_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_I (n_ReadFileFromSE_Api_Ljava_lang_String_arrayBII));
				return cb_readFileFromSE_Api_Ljava_lang_String_arrayBII;
			}

			static int n_ReadFileFromSE_Api_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_dataOut, int offset, int dataLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
				var dataOut = (byte[]?) JNIEnv.GetArray (native_dataOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadFileFromSE_Api (fileName, dataOut, offset, dataLen);
				if (dataOut != null)
					JNIEnv.CopyArray (dataOut, native_dataOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='readFileFromSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("readFileFromSE_Api", "(Ljava/lang/String;[BII)I", "GetReadFileFromSE_Api_Ljava_lang_String_arrayBIIHandler")]
			public virtual unsafe int ReadFileFromSE_Api (string? fileName, byte[]? dataOut, int offset, int dataLen)
			{
				const string __id = "readFileFromSE_Api.(Ljava/lang/String;[BII)I";
				IntPtr native_fileName = JNIEnv.NewString ((string?)fileName);
				IntPtr native_dataOut = JNIEnv.NewArray (dataOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_fileName);
					__args [1] = new JniArgumentValue (native_dataOut);
					__args [2] = new JniArgumentValue (offset);
					__args [3] = new JniArgumentValue (dataLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_fileName);
					if (dataOut != null) {
						JNIEnv.CopyArray (native_dataOut, dataOut);
						JNIEnv.DeleteLocalRef (native_dataOut);
					}
					global::System.GC.KeepAlive (dataOut);
				}
			}

			static Delegate? cb_readFlashData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetReadFlashData_Api_IarrayBHandler ()
			{
				if (cb_readFlashData_Api_IarrayB == null)
					cb_readFlashData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_ReadFlashData_Api_IarrayB));
				return cb_readFlashData_Api_IarrayB;
			}

			static int n_ReadFlashData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int addr, IntPtr native_buffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buffer = (byte[]?) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadFlashData_Api (addr, buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='readFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("readFlashData_Api", "(I[B)I", "GetReadFlashData_Api_IarrayBHandler")]
			public virtual unsafe int ReadFlashData_Api (int addr, byte[]? buffer)
			{
				const string __id = "readFlashData_Api.(I[B)I";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (addr);
					__args [1] = new JniArgumentValue (native_buffer);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
					global::System.GC.KeepAlive (buffer);
				}
			}

			static Delegate? cb_readNvRamFile_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetReadNvRamFile_Api_IarrayBIHandler ()
			{
				if (cb_readNvRamFile_Api_IarrayBI == null)
					cb_readNvRamFile_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_ReadNvRamFile_Api_IarrayBI));
				return cb_readNvRamFile_Api_IarrayBI;
			}

			static int n_ReadNvRamFile_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int offset, IntPtr native_buf, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadNvRamFile_Api (offset, buf, len);
				if (buf != null)
					JNIEnv.CopyArray (buf, native_buf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='readNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("readNvRamFile_Api", "(I[BI)I", "GetReadNvRamFile_Api_IarrayBIHandler")]
			public virtual unsafe int ReadNvRamFile_Api (int offset, byte[]? buf, int len)
			{
				const string __id = "readNvRamFile_Api.(I[BI)I";
				IntPtr native_buf = JNIEnv.NewArray (buf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (native_buf);
					__args [2] = new JniArgumentValue (len);
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

			static Delegate? cb_readRsaKey_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetReadRsaKey_Api_arrayBHandler ()
			{
				if (cb_readRsaKey_Api_arrayB == null)
					cb_readRsaKey_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_ReadRsaKey_Api_arrayB));
				return cb_readRsaKey_Api_arrayB;
			}

			static int n_ReadRsaKey_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_ReadRsaKeyOut)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ReadRsaKeyOut = (byte[]?) JNIEnv.GetArray (native_ReadRsaKeyOut, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadRsaKey_Api (ReadRsaKeyOut);
				if (ReadRsaKeyOut != null)
					JNIEnv.CopyArray (ReadRsaKeyOut, native_ReadRsaKeyOut);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='readRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("readRsaKey_Api", "([B)I", "GetReadRsaKey_Api_arrayBHandler")]
			public virtual unsafe int ReadRsaKey_Api (byte[]? ReadRsaKeyOut)
			{
				const string __id = "readRsaKey_Api.([B)I";
				IntPtr native_ReadRsaKeyOut = JNIEnv.NewArray (ReadRsaKeyOut);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ReadRsaKeyOut);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (ReadRsaKeyOut != null) {
						JNIEnv.CopyArray (native_ReadRsaKeyOut, ReadRsaKeyOut);
						JNIEnv.DeleteLocalRef (native_ReadRsaKeyOut);
					}
					global::System.GC.KeepAlive (ReadRsaKeyOut);
				}
			}

			static Delegate? cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
#pragma warning disable 0169
			static Delegate GetRegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler ()
			{
				if (cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == null)
					cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_RegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_));
				return cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
			}

			static bool n_RegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RegisterTouchListener_Api (listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='registerTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
			[Register ("registerTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetRegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler")]
			public virtual unsafe bool RegisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? listener)
			{
				const string __id = "registerTouchListener_Api.(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_setAdminPassword_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAdminPassword_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setAdminPassword_Api_Ljava_lang_String_ == null)
					cb_setAdminPassword_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetAdminPassword_Api_Ljava_lang_String_));
				return cb_setAdminPassword_Api_Ljava_lang_String_;
			}

			static int n_SetAdminPassword_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pwd)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pwd = JNIEnv.GetString (native_pwd, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetAdminPassword_Api (pwd);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setAdminPassword_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdminPassword_Api", "(Ljava/lang/String;)I", "GetSetAdminPassword_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int SetAdminPassword_Api (string? pwd)
			{
				const string __id = "setAdminPassword_Api.(Ljava/lang/String;)I";
				IntPtr native_pwd = JNIEnv.NewString ((string?)pwd);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_pwd);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_pwd);
				}
			}

			static Delegate? cb_setApplicationType_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetApplicationType_Api_ZHandler ()
			{
				if (cb_setApplicationType_Api_Z == null)
					cb_setApplicationType_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetApplicationType_Api_Z));
				return cb_setApplicationType_Api_Z;
			}

			static void n_SetApplicationType_Api_Z (IntPtr jnienv, IntPtr native__this, bool isSpecialType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetApplicationType_Api (isSpecialType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setApplicationType_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setApplicationType_Api", "(Z)V", "GetSetApplicationType_Api_ZHandler")]
			public virtual unsafe void SetApplicationType_Api (bool isSpecialType)
			{
				const string __id = "setApplicationType_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isSpecialType);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_setAutoTimeZone_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetAutoTimeZone_Api_ZHandler ()
			{
				if (cb_setAutoTimeZone_Api_Z == null)
					cb_setAutoTimeZone_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAutoTimeZone_Api_Z));
				return cb_setAutoTimeZone_Api_Z;
			}

			static bool n_SetAutoTimeZone_Api_Z (IntPtr jnienv, IntPtr native__this, bool state)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetAutoTimeZone_Api (state);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setAutoTimeZone_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoTimeZone_Api", "(Z)Z", "GetSetAutoTimeZone_Api_ZHandler")]
			public virtual unsafe bool SetAutoTimeZone_Api (bool state)
			{
				const string __id = "setAutoTimeZone_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (state);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_setAutoTime_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetAutoTime_Api_ZHandler ()
			{
				if (cb_setAutoTime_Api_Z == null)
					cb_setAutoTime_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAutoTime_Api_Z));
				return cb_setAutoTime_Api_Z;
			}

			static bool n_SetAutoTime_Api_Z (IntPtr jnienv, IntPtr native__this, bool state)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetAutoTime_Api (state);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setAutoTime_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoTime_Api", "(Z)Z", "GetSetAutoTime_Api_ZHandler")]
			public virtual unsafe bool SetAutoTime_Api (bool state)
			{
				const string __id = "setAutoTime_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (state);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_setDataEnabled_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetDataEnabled_Api_ZHandler ()
			{
				if (cb_setDataEnabled_Api_Z == null)
					cb_setDataEnabled_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetDataEnabled_Api_Z));
				return cb_setDataEnabled_Api_Z;
			}

			static bool n_SetDataEnabled_Api_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetDataEnabled_Api (enabled);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setDataEnabled_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDataEnabled_Api", "(Z)Z", "GetSetDataEnabled_Api_ZHandler")]
			public virtual unsafe bool SetDataEnabled_Api (bool enabled)
			{
				const string __id = "setDataEnabled_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_SetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_));
				return cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_;
			}

			static bool n_SetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName, IntPtr native_activityName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
				var activityName = JNIEnv.GetString (native_activityName, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetLauncherApp_Api (packageName, activityName);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setLauncherApp_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setLauncherApp_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe bool SetLauncherApp_Api (string? packageName, string? activityName)
			{
				const string __id = "setLauncherApp_Api.(Ljava/lang/String;Ljava/lang/String;)Z";
				IntPtr native_packageName = JNIEnv.NewString ((string?)packageName);
				IntPtr native_activityName = JNIEnv.NewString ((string?)activityName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_packageName);
					__args [1] = new JniArgumentValue (native_activityName);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_packageName);
					JNIEnv.DeleteLocalRef (native_activityName);
				}
			}

			static Delegate? cb_setNtpServer_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNtpServer_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setNtpServer_Api_Ljava_lang_String_ == null)
					cb_setNtpServer_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetNtpServer_Api_Ljava_lang_String_));
				return cb_setNtpServer_Api_Ljava_lang_String_;
			}

			static bool n_SetNtpServer_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ntpServer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ntpServer = JNIEnv.GetString (native_ntpServer, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetNtpServer_Api (ntpServer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setNtpServer_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNtpServer_Api", "(Ljava/lang/String;)Z", "GetSetNtpServer_Api_Ljava_lang_String_Handler")]
			public virtual unsafe bool SetNtpServer_Api (string? ntpServer)
			{
				const string __id = "setNtpServer_Api.(Ljava/lang/String;)Z";
				IntPtr native_ntpServer = JNIEnv.NewString ((string?)ntpServer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ntpServer);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_ntpServer);
				}
			}

			static Delegate? cb_setResumeRechargeValue_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetResumeRechargeValue_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setResumeRechargeValue_Api_Ljava_lang_String_ == null)
					cb_setResumeRechargeValue_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetResumeRechargeValue_Api_Ljava_lang_String_));
				return cb_setResumeRechargeValue_Api_Ljava_lang_String_;
			}

			static bool n_SetResumeRechargeValue_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetResumeRechargeValue_Api (value);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setResumeRechargeValue_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResumeRechargeValue_Api", "(Ljava/lang/String;)Z", "GetSetResumeRechargeValue_Api_Ljava_lang_String_Handler")]
			public virtual unsafe bool SetResumeRechargeValue_Api (string? value)
			{
				const string __id = "setResumeRechargeValue_Api.(Ljava/lang/String;)Z";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate? cb_setSettingsPWD_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSettingsPWD_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setSettingsPWD_Api_Ljava_lang_String_ == null)
					cb_setSettingsPWD_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetSettingsPWD_Api_Ljava_lang_String_));
				return cb_setSettingsPWD_Api_Ljava_lang_String_;
			}

			static int n_SetSettingsPWD_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pwd)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pwd = JNIEnv.GetString (native_pwd, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetSettingsPWD_Api (pwd);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setSettingsPWD_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSettingsPWD_Api", "(Ljava/lang/String;)I", "GetSetSettingsPWD_Api_Ljava_lang_String_Handler")]
			public virtual unsafe int SetSettingsPWD_Api (string? pwd)
			{
				const string __id = "setSettingsPWD_Api.(Ljava/lang/String;)I";
				IntPtr native_pwd = JNIEnv.NewString ((string?)pwd);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_pwd);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_pwd);
				}
			}

			static Delegate? cb_setSgnCheckEnable_Api_ZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSgnCheckEnable_Api_ZLjava_lang_String_Handler ()
			{
				if (cb_setSgnCheckEnable_Api_ZLjava_lang_String_ == null)
					cb_setSgnCheckEnable_Api_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZL_I (n_SetSgnCheckEnable_Api_ZLjava_lang_String_));
				return cb_setSgnCheckEnable_Api_ZLjava_lang_String_;
			}

			static int n_SetSgnCheckEnable_Api_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool enable, IntPtr native_pwd)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pwd = JNIEnv.GetString (native_pwd, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetSgnCheckEnable_Api (enable, pwd);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setSgnCheckEnable_Api' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("setSgnCheckEnable_Api", "(ZLjava/lang/String;)I", "GetSetSgnCheckEnable_Api_ZLjava_lang_String_Handler")]
			public virtual unsafe int SetSgnCheckEnable_Api (bool enable, string? pwd)
			{
				const string __id = "setSgnCheckEnable_Api.(ZLjava/lang/String;)I";
				IntPtr native_pwd = JNIEnv.NewString ((string?)pwd);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (enable);
					__args [1] = new JniArgumentValue (native_pwd);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_pwd);
				}
			}

			static Delegate? cb_setSmartPosID_arrayB;
#pragma warning disable 0169
			static Delegate GetSetSmartPosID_arrayBHandler ()
			{
				if (cb_setSmartPosID_arrayB == null)
					cb_setSmartPosID_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetSmartPosID_arrayB));
				return cb_setSmartPosID_arrayB;
			}

			static int n_SetSmartPosID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SetSmartPosID (data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setSmartPosID", "([B)I", "GetSetSmartPosID_arrayBHandler")]
			public virtual unsafe int SetSmartPosID (byte[]? data)
			{
				const string __id = "setSmartPosID.([B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_data);
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

			static Delegate? cb_setSystemFunction_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetSystemFunction_Landroid_os_Bundle_Handler ()
			{
				if (cb_setSystemFunction_Landroid_os_Bundle_ == null)
					cb_setSystemFunction_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetSystemFunction_Landroid_os_Bundle_));
				return cb_setSystemFunction_Landroid_os_Bundle_;
			}

			static bool n_SetSystemFunction_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetSystemFunction (bundle);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setSystemFunction' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setSystemFunction", "(Landroid/os/Bundle;)Z", "GetSetSystemFunction_Landroid_os_Bundle_Handler")]
			public virtual unsafe bool SetSystemFunction (global::Android.OS.Bundle? bundle)
			{
				const string __id = "setSystemFunction.(Landroid/os/Bundle;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (bundle);
				}
			}

			static Delegate? cb_setTimeZone_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTimeZone_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setTimeZone_Api_Ljava_lang_String_ == null)
					cb_setTimeZone_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetTimeZone_Api_Ljava_lang_String_));
				return cb_setTimeZone_Api_Ljava_lang_String_;
			}

			static bool n_SetTimeZone_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_timeZone)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var timeZone = JNIEnv.GetString (native_timeZone, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetTimeZone_Api (timeZone);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setTimeZone_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTimeZone_Api", "(Ljava/lang/String;)Z", "GetSetTimeZone_Api_Ljava_lang_String_Handler")]
			public virtual unsafe bool SetTimeZone_Api (string? timeZone)
			{
				const string __id = "setTimeZone_Api.(Ljava/lang/String;)Z";
				IntPtr native_timeZone = JNIEnv.NewString ((string?)timeZone);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_timeZone);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_timeZone);
				}
			}

			static Delegate? cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTrustedBluetoothMAC_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_ == null)
					cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetTrustedBluetoothMAC_Api_Ljava_lang_String_));
				return cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_;
			}

			static bool n_SetTrustedBluetoothMAC_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_addr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var addr = JNIEnv.GetString (native_addr, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetTrustedBluetoothMAC_Api (addr);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='setTrustedBluetoothMAC_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrustedBluetoothMAC_Api", "(Ljava/lang/String;)Z", "GetSetTrustedBluetoothMAC_Api_Ljava_lang_String_Handler")]
			public virtual unsafe bool SetTrustedBluetoothMAC_Api (string? addr)
			{
				const string __id = "setTrustedBluetoothMAC_Api.(Ljava/lang/String;)Z";
				IntPtr native_addr = JNIEnv.NewString ((string?)addr);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_addr);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_addr);
				}
			}

			static Delegate? cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_;
#pragma warning disable 0169
			static Delegate GetSilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_Handler ()
			{
				if (cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ == null)
					cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_SilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_));
				return cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_;
			}

			static void n_SilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filePath, IntPtr native_pkgName, IntPtr native_result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var filePath = JNIEnv.GetString (native_filePath, JniHandleOwnership.DoNotTransfer);
				var pkgName = JNIEnv.GetString (native_pkgName, JniHandleOwnership.DoNotTransfer);
				var result = (global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.SilentInstallApk_Api (filePath, pkgName, result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='silentInstallApk_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IApkInstallResultAIDL']]"
			[Register ("silentInstallApk_Api", "(Ljava/lang/String;Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkInstallResultAIDL;)V", "GetSilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_Handler")]
			public virtual unsafe void SilentInstallApk_Api (string? filePath, string? pkgName, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL? result)
			{
				const string __id = "silentInstallApk_Api.(Ljava/lang/String;Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkInstallResultAIDL;)V";
				IntPtr native_filePath = JNIEnv.NewString ((string?)filePath);
				IntPtr native_pkgName = JNIEnv.NewString ((string?)pkgName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_filePath);
					__args [1] = new JniArgumentValue (native_pkgName);
					__args [2] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_filePath);
					JNIEnv.DeleteLocalRef (native_pkgName);
					global::System.GC.KeepAlive (result);
				}
			}

			static Delegate? cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_;
#pragma warning disable 0169
			static Delegate GetSilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_Handler ()
			{
				if (cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ == null)
					cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_));
				return cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_;
			}

			static void n_SilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkgName, IntPtr native_result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var pkgName = JNIEnv.GetString (native_pkgName, JniHandleOwnership.DoNotTransfer);
				var result = (global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.SilentUnInstallApk_Api (pkgName, result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='silentUnInstallApk_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IApkUnInstallResultAIDL']]"
			[Register ("silentUnInstallApk_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkUnInstallResultAIDL;)V", "GetSilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_Handler")]
			public virtual unsafe void SilentUnInstallApk_Api (string? pkgName, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL? result)
			{
				const string __id = "silentUnInstallApk_Api.(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkUnInstallResultAIDL;)V";
				IntPtr native_pkgName = JNIEnv.NewString ((string?)pkgName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_pkgName);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_pkgName);
					global::System.GC.KeepAlive (result);
				}
			}

			static Delegate? cb_stopBeep_api;
#pragma warning disable 0169
			static Delegate GetStopBeep_apiHandler ()
			{
				if (cb_stopBeep_api == null)
					cb_stopBeep_api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StopBeep_api));
				return cb_stopBeep_api;
			}

			static void n_StopBeep_api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.StopBeep_api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='stopBeep_api' and count(parameter)=0]"
			[Register ("stopBeep_api", "()V", "GetStopBeep_apiHandler")]
			public virtual unsafe void StopBeep_api ()
			{
				const string __id = "stopBeep_api.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_stopCatch_Api;
#pragma warning disable 0169
			static Delegate GetStopCatch_ApiHandler ()
			{
				if (cb_stopCatch_Api == null)
					cb_stopCatch_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_StopCatch_Api));
				return cb_stopCatch_Api;
			}

			static bool n_StopCatch_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.StopCatch_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='stopCatch_Api' and count(parameter)=0]"
			[Register ("stopCatch_Api", "()Z", "GetStopCatch_ApiHandler")]
			public virtual unsafe bool StopCatch_Api ()
			{
				const string __id = "stopCatch_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_switchAppEnable_Api_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetSwitchAppEnable_Api_Ljava_lang_String_ZHandler ()
			{
				if (cb_switchAppEnable_Api_Ljava_lang_String_Z == null)
					cb_switchAppEnable_Api_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_Z (n_SwitchAppEnable_Api_Ljava_lang_String_Z));
				return cb_switchAppEnable_Api_Ljava_lang_String_Z;
			}

			static bool n_SwitchAppEnable_Api_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName, bool enable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SwitchAppEnable_Api (packageName, enable);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='switchAppEnable_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register ("switchAppEnable_Api", "(Ljava/lang/String;Z)Z", "GetSwitchAppEnable_Api_Ljava_lang_String_ZHandler")]
			public virtual unsafe bool SwitchAppEnable_Api (string? packageName, bool enable)
			{
				const string __id = "switchAppEnable_Api.(Ljava/lang/String;Z)Z";
				IntPtr native_packageName = JNIEnv.NewString ((string?)packageName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_packageName);
					__args [1] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_packageName);
				}
			}

			static Delegate? cb_switchChargeOnRS232_Api_Z;
#pragma warning disable 0169
			static Delegate GetSwitchChargeOnRS232_Api_ZHandler ()
			{
				if (cb_switchChargeOnRS232_Api_Z == null)
					cb_switchChargeOnRS232_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SwitchChargeOnRS232_Api_Z));
				return cb_switchChargeOnRS232_Api_Z;
			}

			static bool n_SwitchChargeOnRS232_Api_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SwitchChargeOnRS232_Api (enabled);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='switchChargeOnRS232_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("switchChargeOnRS232_Api", "(Z)Z", "GetSwitchChargeOnRS232_Api_ZHandler")]
			public virtual unsafe bool SwitchChargeOnRS232_Api (bool enabled)
			{
				const string __id = "switchChargeOnRS232_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_switchDefaultDataSIM_Api;
#pragma warning disable 0169
			static Delegate GetSwitchDefaultDataSIM_ApiHandler ()
			{
				if (cb_switchDefaultDataSIM_Api == null)
					cb_switchDefaultDataSIM_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_SwitchDefaultDataSIM_Api));
				return cb_switchDefaultDataSIM_Api;
			}

			static bool n_SwitchDefaultDataSIM_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SwitchDefaultDataSIM_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='switchDefaultDataSIM_Api' and count(parameter)=0]"
			[Register ("switchDefaultDataSIM_Api", "()Z", "GetSwitchDefaultDataSIM_ApiHandler")]
			public virtual unsafe bool SwitchDefaultDataSIM_Api ()
			{
				const string __id = "switchDefaultDataSIM_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_switchGPS_Api_Z;
#pragma warning disable 0169
			static Delegate GetSwitchGPS_Api_ZHandler ()
			{
				if (cb_switchGPS_Api_Z == null)
					cb_switchGPS_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SwitchGPS_Api_Z));
				return cb_switchGPS_Api_Z;
			}

			static bool n_SwitchGPS_Api_Z (IntPtr jnienv, IntPtr native__this, bool enable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SwitchGPS_Api (enable);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='switchGPS_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("switchGPS_Api", "(Z)Z", "GetSwitchGPS_Api_ZHandler")]
			public virtual unsafe bool SwitchGPS_Api (bool enable)
			{
				const string __id = "switchGPS_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate? cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
#pragma warning disable 0169
			static Delegate GetUnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler ()
			{
				if (cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == null)
					cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_UnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_));
				return cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
			}

			static bool n_UnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var listener = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL> (native_listener, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.UnregisterTouchListener_Api (listener);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='unregisterTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
			[Register ("unregisterTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetUnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler")]
			public virtual unsafe bool UnregisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? listener)
			{
				const string __id = "unregisterTouchListener_Api.(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate? cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_;
#pragma warning disable 0169
			static Delegate GetUpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_Handler ()
			{
				if (cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ == null)
					cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_UpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_));
				return cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_;
			}

			static int n_UpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filePaths, IntPtr native_systemUpdate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var filePaths = JNIEnv.GetString (native_filePaths, JniHandleOwnership.DoNotTransfer);
				var systemUpdate = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate> (native_systemUpdate, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.UpdateSystem_Api (filePaths, systemUpdate);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='updateSystem_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.ISystemUpdate']]"
			[Register ("updateSystem_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/ISystemUpdate;)I", "GetUpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_Handler")]
			public virtual unsafe int UpdateSystem_Api (string? filePaths, global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate? systemUpdate)
			{
				const string __id = "updateSystem_Api.(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/ISystemUpdate;)I";
				IntPtr native_filePaths = JNIEnv.NewString ((string?)filePaths);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_filePaths);
					__args [1] = new JniArgumentValue ((systemUpdate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) systemUpdate).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_filePaths);
					global::System.GC.KeepAlive (systemUpdate);
				}
			}

			static Delegate? cb_validatePermission_Z;
#pragma warning disable 0169
			static Delegate GetValidatePermission_ZHandler ()
			{
				if (cb_validatePermission_Z == null)
					cb_validatePermission_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_ValidatePermission_Z));
				return cb_validatePermission_Z;
			}

			static void n_ValidatePermission_Z (IntPtr jnienv, IntPtr native__this, bool checkFlag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.ValidatePermission (checkFlag);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='validatePermission' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("validatePermission", "(Z)V", "GetValidatePermission_ZHandler")]
			public virtual unsafe void ValidatePermission (bool checkFlag)
			{
				const string __id = "validatePermission.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (checkFlag);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_writeFileToSE_Api_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
			static Delegate GetWriteFileToSE_Api_Ljava_lang_String_arrayBIIHandler ()
			{
				if (cb_writeFileToSE_Api_Ljava_lang_String_arrayBII == null)
					cb_writeFileToSE_Api_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_I (n_WriteFileToSE_Api_Ljava_lang_String_arrayBII));
				return cb_writeFileToSE_Api_Ljava_lang_String_arrayBII;
			}

			static int n_WriteFileToSE_Api_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_data, int offset, int dataLen)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteFileToSE_Api (fileName, data, offset, dataLen);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='writeFileToSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("writeFileToSE_Api", "(Ljava/lang/String;[BII)I", "GetWriteFileToSE_Api_Ljava_lang_String_arrayBIIHandler")]
			public virtual unsafe int WriteFileToSE_Api (string? fileName, byte[]? data, int offset, int dataLen)
			{
				const string __id = "writeFileToSE_Api.(Ljava/lang/String;[BII)I";
				IntPtr native_fileName = JNIEnv.NewString ((string?)fileName);
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_fileName);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (offset);
					__args [3] = new JniArgumentValue (dataLen);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_fileName);
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			static Delegate? cb_writeFlashData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetWriteFlashData_Api_IarrayBHandler ()
			{
				if (cb_writeFlashData_Api_IarrayB == null)
					cb_writeFlashData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_WriteFlashData_Api_IarrayB));
				return cb_writeFlashData_Api_IarrayB;
			}

			static int n_WriteFlashData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int addr, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteFlashData_Api (addr, data);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='writeFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("writeFlashData_Api", "(I[B)I", "GetWriteFlashData_Api_IarrayBHandler")]
			public virtual unsafe int WriteFlashData_Api (int addr, byte[]? data)
			{
				const string __id = "writeFlashData_Api.(I[B)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (addr);
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

			static Delegate? cb_writeNvRamFile_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetWriteNvRamFile_Api_IarrayBIHandler ()
			{
				if (cb_writeNvRamFile_Api_IarrayBI == null)
					cb_writeNvRamFile_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_WriteNvRamFile_Api_IarrayBI));
				return cb_writeNvRamFile_Api_IarrayBI;
			}

			static int n_WriteNvRamFile_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int offset, IntPtr native_data, int len)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteNvRamFile_Api (offset, data, len);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='writeNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("writeNvRamFile_Api", "(I[BI)I", "GetWriteNvRamFile_Api_IarrayBIHandler")]
			public virtual unsafe int WriteNvRamFile_Api (int offset, byte[]? data, int len)
			{
				const string __id = "writeNvRamFile_Api.(I[BI)I";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (native_data);
					__args [2] = new JniArgumentValue (len);
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

			static Delegate? cb_writeRsaKey_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetWriteRsaKey_Api_arrayBHandler ()
			{
				if (cb_writeRsaKey_Api_arrayB == null)
					cb_writeRsaKey_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_WriteRsaKey_Api_arrayB));
				return cb_writeRsaKey_Api_arrayB;
			}

			static bool n_WriteRsaKey_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Default> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var buffer = (byte[]?) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.WriteRsaKey_Api (buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Default']/method[@name='writeRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("writeRsaKey_Api", "([B)Z", "GetWriteRsaKey_Api_arrayBHandler")]
			public virtual unsafe bool WriteRsaKey_Api (byte[]? buffer)
			{
				const string __id = "writeRsaKey_Api.([B)Z";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_buffer);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
					global::System.GC.KeepAlive (buffer);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']"
		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/system/SystemHandler$Stub", DoNotGenerateAcw=true)]
		public abstract partial class Stub : global::Android.OS.Binder, global::Com.Vanstone.Appsdk.Api.System.ISystemHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/system/SystemHandler$Stub", typeof (Stub));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/constructor[@name='SystemHandler.Stub' and count(parameter)=0]"
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

			public static unsafe global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? DefaultImpl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
				[Register ("getDefaultImpl", "()Lcom/vanstone/appsdk/api/system/SystemHandler;", "")]
				get {
					const string __id = "getDefaultImpl.()Lcom/vanstone/appsdk/api/system/SystemHandler;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
			[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/system/SystemHandler;", "")]
			public static unsafe global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? AsInterface (global::Android.OS.IBinder? obj)
			{
				const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/vanstone/appsdk/api/system/SystemHandler;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
				var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTransact (code, data, reply, flags);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.system.SystemHandler']]"
			[Register ("setDefaultImpl", "(Lcom/vanstone/appsdk/api/system/SystemHandler;)Z", "")]
			public static unsafe bool SetDefaultImpl (global::Com.Vanstone.Appsdk.Api.System.ISystemHandler? impl)
			{
				const string __id = "setDefaultImpl.(Lcom/vanstone/appsdk/api/system/SystemHandler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (impl);
				}
			}

			static Delegate? cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_Handler ()
			{
				if (cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ == null)
					cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_));
				return cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_;
			}

			static int n_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.BackUpByPackage_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='BackUpByPackage_Api' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
			[Register ("BackUpByPackage_Api", "(Ljava/util/List;Ljava/lang/String;)I", "GetBackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_Handler")]
			public abstract int BackUpByPackage_Api (global::System.Collections.Generic.IList<string>? p0, string? p1);

			static Delegate? cb_Beef_Api_II;
#pragma warning disable 0169
			static Delegate GetBeef_Api_IIHandler ()
			{
				if (cb_Beef_Api_II == null)
					cb_Beef_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_Beef_Api_II));
				return cb_Beef_Api_II;
			}

			static void n_Beef_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.Beef_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='Beef_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("Beef_Api", "(II)V", "GetBeef_Api_IIHandler")]
			public abstract void Beef_Api (int p0, int p1);

			static Delegate? cb_Beep_Api_I;
#pragma warning disable 0169
			static Delegate GetBeep_Api_IHandler ()
			{
				if (cb_Beep_Api_I == null)
					cb_Beep_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Beep_Api_I));
				return cb_Beep_Api_I;
			}

			static void n_Beep_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.Beep_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='Beep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Beep_Api", "(I)V", "GetBeep_Api_IHandler")]
			public abstract void Beep_Api (int p0);

			static Delegate? cb_CheckModuleStatue_Api_I;
#pragma warning disable 0169
			static Delegate GetCheckModuleStatue_Api_IHandler ()
			{
				if (cb_CheckModuleStatue_Api_I == null)
					cb_CheckModuleStatue_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_CheckModuleStatue_Api_I));
				return cb_CheckModuleStatue_Api_I;
			}

			static int n_CheckModuleStatue_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.CheckModuleStatue_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='CheckModuleStatue_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("CheckModuleStatue_Api", "(I)I", "GetCheckModuleStatue_Api_IHandler")]
			public abstract int CheckModuleStatue_Api (int p0);

			static Delegate? cb_GateClose_Api;
#pragma warning disable 0169
			static Delegate GetGateClose_ApiHandler ()
			{
				if (cb_GateClose_Api == null)
					cb_GateClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GateClose_Api));
				return cb_GateClose_Api;
			}

			static int n_GateClose_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GateClose_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GateClose_Api' and count(parameter)=0]"
			[Register ("GateClose_Api", "()I", "GetGateClose_ApiHandler")]
			public abstract int GateClose_Api ();

			static Delegate? cb_GateOpen_Api;
#pragma warning disable 0169
			static Delegate GetGateOpen_ApiHandler ()
			{
				if (cb_GateOpen_Api == null)
					cb_GateOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GateOpen_Api));
				return cb_GateOpen_Api;
			}

			static int n_GateOpen_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.GateOpen_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GateOpen_Api' and count(parameter)=0]"
			[Register ("GateOpen_Api", "()I", "GetGateOpen_ApiHandler")]
			public abstract int GateOpen_Api ();

			static Delegate? cb_GetVersion_Api_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetGetVersion_Api_arrayBarrayBHandler ()
			{
				if (cb_GetVersion_Api_arrayBarrayB == null)
					cb_GetVersion_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_GetVersion_Api_arrayBarrayB));
				return cb_GetVersion_Api_arrayBarrayB;
			}

			static int n_GetVersion_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetVersion_Api (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GetVersion_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("GetVersion_Api", "([B[B)I", "GetGetVersion_Api_arrayBarrayBHandler")]
			public abstract int GetVersion_Api (byte[]? p0, byte[]? p1);

			static Delegate? cb_IsHandleOnBase_Api;
#pragma warning disable 0169
			static Delegate GetIsHandleOnBase_ApiHandler ()
			{
				if (cb_IsHandleOnBase_Api == null)
					cb_IsHandleOnBase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_IsHandleOnBase_Api));
				return cb_IsHandleOnBase_Api;
			}

			static int n_IsHandleOnBase_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsHandleOnBase_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='IsHandleOnBase_Api' and count(parameter)=0]"
			[Register ("IsHandleOnBase_Api", "()I", "GetIsHandleOnBase_ApiHandler")]
			public abstract int IsHandleOnBase_Api ();

			static Delegate? cb_ReadPosSn;
#pragma warning disable 0169
			static Delegate GetReadPosSnHandler ()
			{
				if (cb_ReadPosSn == null)
					cb_ReadPosSn = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ReadPosSn));
				return cb_ReadPosSn;
			}

			static IntPtr n_ReadPosSn (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.ReadPosSn ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='ReadPosSn' and count(parameter)=0]"
			[Register ("ReadPosSn", "()Ljava/lang/String;", "GetReadPosSnHandler")]
			public abstract string? ReadPosSn ();

			static Delegate? cb_RestoreDatda_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRestoreDatda_Api_Ljava_lang_String_Handler ()
			{
				if (cb_RestoreDatda_Api_Ljava_lang_String_ == null)
					cb_RestoreDatda_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_RestoreDatda_Api_Ljava_lang_String_));
				return cb_RestoreDatda_Api_Ljava_lang_String_;
			}

			static int n_RestoreDatda_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.RestoreDatda_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='RestoreDatda_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("RestoreDatda_Api", "(Ljava/lang/String;)I", "GetRestoreDatda_Api_Ljava_lang_String_Handler")]
			public abstract int RestoreDatda_Api (string? p0);

			static Delegate? cb_RestoreFactory_Api_Z;
#pragma warning disable 0169
			static Delegate GetRestoreFactory_Api_ZHandler ()
			{
				if (cb_RestoreFactory_Api_Z == null)
					cb_RestoreFactory_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_RestoreFactory_Api_Z));
				return cb_RestoreFactory_Api_Z;
			}

			static void n_RestoreFactory_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.RestoreFactory_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='RestoreFactory_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("RestoreFactory_Api", "(Z)V", "GetRestoreFactory_Api_ZHandler")]
			public abstract void RestoreFactory_Api (bool p0);

			static Delegate? cb_SetAdbEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetAdbEnable_Api_ZHandler ()
			{
				if (cb_SetAdbEnable_Api_Z == null)
					cb_SetAdbEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAdbEnable_Api_Z));
				return cb_SetAdbEnable_Api_Z;
			}

			static bool n_SetAdbEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetAdbEnable_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetAdbEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetAdbEnable_Api", "(Z)Z", "GetSetAdbEnable_Api_ZHandler")]
			public abstract bool SetAdbEnable_Api (bool p0);

			static Delegate? cb_SetBaseBroadcast_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetBaseBroadcast_Api_ZHandler ()
			{
				if (cb_SetBaseBroadcast_Api_Z == null)
					cb_SetBaseBroadcast_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetBaseBroadcast_Api_Z));
				return cb_SetBaseBroadcast_Api_Z;
			}

			static void n_SetBaseBroadcast_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetBaseBroadcast_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetBaseBroadcast_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetBaseBroadcast_Api", "(Z)V", "GetSetBaseBroadcast_Api_ZHandler")]
			public abstract void SetBaseBroadcast_Api (bool p0);

			static Delegate? cb_SetBluetoothEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetBluetoothEnable_Api_ZHandler ()
			{
				if (cb_SetBluetoothEnable_Api_Z == null)
					cb_SetBluetoothEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetBluetoothEnable_Api_Z));
				return cb_SetBluetoothEnable_Api_Z;
			}

			static bool n_SetBluetoothEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetBluetoothEnable_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetBluetoothEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetBluetoothEnable_Api", "(Z)Z", "GetSetBluetoothEnable_Api_ZHandler")]
			public abstract bool SetBluetoothEnable_Api (bool p0);

			static Delegate? cb_SetOtgEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetOtgEnable_Api_ZHandler ()
			{
				if (cb_SetOtgEnable_Api_Z == null)
					cb_SetOtgEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetOtgEnable_Api_Z));
				return cb_SetOtgEnable_Api_Z;
			}

			static bool n_SetOtgEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetOtgEnable_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetOtgEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetOtgEnable_Api", "(Z)Z", "GetSetOtgEnable_Api_ZHandler")]
			public abstract bool SetOtgEnable_Api (bool p0);

			static Delegate? cb_SetSetScreenOffTimeout_Api_I;
#pragma warning disable 0169
			static Delegate GetSetSetScreenOffTimeout_Api_IHandler ()
			{
				if (cb_SetSetScreenOffTimeout_Api_I == null)
					cb_SetSetScreenOffTimeout_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_SetSetScreenOffTimeout_Api_I));
				return cb_SetSetScreenOffTimeout_Api_I;
			}

			static bool n_SetSetScreenOffTimeout_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetSetScreenOffTimeout_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetSetScreenOffTimeout_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetSetScreenOffTimeout_Api", "(I)Z", "GetSetSetScreenOffTimeout_Api_IHandler")]
			public abstract bool SetSetScreenOffTimeout_Api (int p0);

			static Delegate? cb_SetTime_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTime_Api_Ljava_lang_String_Handler ()
			{
				if (cb_SetTime_Api_Ljava_lang_String_ == null)
					cb_SetTime_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetTime_Api_Ljava_lang_String_));
				return cb_SetTime_Api_Ljava_lang_String_;
			}

			static int n_SetTime_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetTime_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetTime_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetTime_Api", "(Ljava/lang/String;)I", "GetSetTime_Api_Ljava_lang_String_Handler")]
			public abstract int SetTime_Api (string? p0);

			static Delegate? cb_SetWifiAddNetworkEnable_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetWifiAddNetworkEnable_Api_ZHandler ()
			{
				if (cb_SetWifiAddNetworkEnable_Api_Z == null)
					cb_SetWifiAddNetworkEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetWifiAddNetworkEnable_Api_Z));
				return cb_SetWifiAddNetworkEnable_Api_Z;
			}

			static bool n_SetWifiAddNetworkEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetWifiAddNetworkEnable_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetWifiAddNetworkEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetWifiAddNetworkEnable_Api", "(Z)Z", "GetSetWifiAddNetworkEnable_Api_ZHandler")]
			public abstract bool SetWifiAddNetworkEnable_Api (bool p0);

			static Delegate? cb_SystemPowerOff_Api;
#pragma warning disable 0169
			static Delegate GetSystemPowerOff_ApiHandler ()
			{
				if (cb_SystemPowerOff_Api == null)
					cb_SystemPowerOff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SystemPowerOff_Api));
				return cb_SystemPowerOff_Api;
			}

			static void n_SystemPowerOff_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SystemPowerOff_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SystemPowerOff_Api' and count(parameter)=0]"
			[Register ("SystemPowerOff_Api", "()V", "GetSystemPowerOff_ApiHandler")]
			public abstract void SystemPowerOff_Api ();

			static Delegate? cb_SystemReboot_Api;
#pragma warning disable 0169
			static Delegate GetSystemReboot_ApiHandler ()
			{
				if (cb_SystemReboot_Api == null)
					cb_SystemReboot_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SystemReboot_Api));
				return cb_SystemReboot_Api;
			}

			static void n_SystemReboot_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SystemReboot_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SystemReboot_Api' and count(parameter)=0]"
			[Register ("SystemReboot_Api", "()V", "GetSystemReboot_ApiHandler")]
			public abstract void SystemReboot_Api ();

			static Delegate? cb_catchMainLog_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCatchMainLog_Api_Ljava_lang_String_Handler ()
			{
				if (cb_catchMainLog_Api_Ljava_lang_String_ == null)
					cb_catchMainLog_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_CatchMainLog_Api_Ljava_lang_String_));
				return cb_catchMainLog_Api_Ljava_lang_String_;
			}

			static bool n_CatchMainLog_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.CatchMainLog_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='catchMainLog_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("catchMainLog_Api", "(Ljava/lang/String;)Z", "GetCatchMainLog_Api_Ljava_lang_String_Handler")]
			public abstract bool CatchMainLog_Api (string? p0);

			static Delegate? cb_deleteFileInSe_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteFileInSe_Api_Ljava_lang_String_Handler ()
			{
				if (cb_deleteFileInSe_Api_Ljava_lang_String_ == null)
					cb_deleteFileInSe_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DeleteFileInSe_Api_Ljava_lang_String_));
				return cb_deleteFileInSe_Api_Ljava_lang_String_;
			}

			static int n_DeleteFileInSe_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DeleteFileInSe_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteFileInSe_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteFileInSe_Api", "(Ljava/lang/String;)I", "GetDeleteFileInSe_Api_Ljava_lang_String_Handler")]
			public abstract int DeleteFileInSe_Api (string? p0);

			static Delegate? cb_deleteFlashData_Api_II;
#pragma warning disable 0169
			static Delegate GetDeleteFlashData_Api_IIHandler ()
			{
				if (cb_deleteFlashData_Api_II == null)
					cb_deleteFlashData_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_DeleteFlashData_Api_II));
				return cb_deleteFlashData_Api_II;
			}

			static int n_DeleteFlashData_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DeleteFlashData_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("deleteFlashData_Api", "(II)I", "GetDeleteFlashData_Api_IIHandler")]
			public abstract int DeleteFlashData_Api (int p0, int p1);

			static Delegate? cb_deleteRsakey_Api;
#pragma warning disable 0169
			static Delegate GetDeleteRsakey_ApiHandler ()
			{
				if (cb_deleteRsakey_Api == null)
					cb_deleteRsakey_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_DeleteRsakey_Api));
				return cb_deleteRsakey_Api;
			}

			static bool n_DeleteRsakey_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DeleteRsakey_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteRsakey_Api' and count(parameter)=0]"
			[Register ("deleteRsakey_Api", "()Z", "GetDeleteRsakey_ApiHandler")]
			public abstract bool DeleteRsakey_Api ();

			static Delegate? cb_getFileListInSe_Api_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetGetFileListInSe_Api_Ljava_util_List_Handler ()
			{
				if (cb_getFileListInSe_Api_Ljava_util_List_ == null)
					cb_getFileListInSe_Api_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFileListInSe_Api_Ljava_util_List_));
				return cb_getFileListInSe_Api_Ljava_util_List_;
			}

			static int n_GetFileListInSe_Api_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetFileListInSe_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getFileListInSe_Api' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("getFileListInSe_Api", "(Ljava/util/List;)I", "GetGetFileListInSe_Api_Ljava_util_List_Handler")]
			public abstract int GetFileListInSe_Api (global::System.Collections.Generic.IList<string>? p0);

			static Delegate? cb_getSmartPosID_arrayB;
#pragma warning disable 0169
			static Delegate GetGetSmartPosID_arrayBHandler ()
			{
				if (cb_getSmartPosID_arrayB == null)
					cb_getSmartPosID_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetSmartPosID_arrayB));
				return cb_getSmartPosID_arrayB;
			}

			static int n_GetSmartPosID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.GetSmartPosID (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("getSmartPosID", "([B)I", "GetGetSmartPosID_arrayBHandler")]
			public abstract int GetSmartPosID (byte[]? p0);

			static Delegate? cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_));
				return cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_GetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTrafficStats_Api (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getTrafficStats_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getTrafficStats_Api", "(Ljava/lang/String;Ljava/lang/String;)Lcom/vanstone/appsdk/api/struct/AidlTrafficStats;", "GetGetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public abstract global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats? GetTrafficStats_Api (string? p0, string? p1);

			static Delegate? cb_isForeground_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIsForeground_Api_Ljava_lang_String_Handler ()
			{
				if (cb_isForeground_Api_Ljava_lang_String_ == null)
					cb_isForeground_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsForeground_Api_Ljava_lang_String_));
				return cb_isForeground_Api_Ljava_lang_String_;
			}

			static bool n_IsForeground_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsForeground_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='isForeground_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isForeground_Api", "(Ljava/lang/String;)Z", "GetIsForeground_Api_Ljava_lang_String_Handler")]
			public abstract bool IsForeground_Api (string? p0);

			static Delegate? cb_isdeviceEnabled_Api;
#pragma warning disable 0169
			static Delegate GetIsdeviceEnabled_ApiHandler ()
			{
				if (cb_isdeviceEnabled_Api == null)
					cb_isdeviceEnabled_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsdeviceEnabled_Api));
				return cb_isdeviceEnabled_Api;
			}

			static bool n_IsdeviceEnabled_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsdeviceEnabled_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='isdeviceEnabled_Api' and count(parameter)=0]"
			[Register ("isdeviceEnabled_Api", "()Z", "GetIsdeviceEnabled_ApiHandler")]
			public abstract bool IsdeviceEnabled_Api ();

			static Delegate? cb_readFileFromSE_Api_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
			static Delegate GetReadFileFromSE_Api_Ljava_lang_String_arrayBIIHandler ()
			{
				if (cb_readFileFromSE_Api_Ljava_lang_String_arrayBII == null)
					cb_readFileFromSE_Api_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_I (n_ReadFileFromSE_Api_Ljava_lang_String_arrayBII));
				return cb_readFileFromSE_Api_Ljava_lang_String_arrayBII;
			}

			static int n_ReadFileFromSE_Api_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadFileFromSE_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readFileFromSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("readFileFromSE_Api", "(Ljava/lang/String;[BII)I", "GetReadFileFromSE_Api_Ljava_lang_String_arrayBIIHandler")]
			public abstract int ReadFileFromSE_Api (string? p0, byte[]? p1, int p2, int p3);

			static Delegate? cb_readFlashData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetReadFlashData_Api_IarrayBHandler ()
			{
				if (cb_readFlashData_Api_IarrayB == null)
					cb_readFlashData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_ReadFlashData_Api_IarrayB));
				return cb_readFlashData_Api_IarrayB;
			}

			static int n_ReadFlashData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadFlashData_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("readFlashData_Api", "(I[B)I", "GetReadFlashData_Api_IarrayBHandler")]
			public abstract int ReadFlashData_Api (int p0, byte[]? p1);

			static Delegate? cb_readNvRamFile_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetReadNvRamFile_Api_IarrayBIHandler ()
			{
				if (cb_readNvRamFile_Api_IarrayBI == null)
					cb_readNvRamFile_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_ReadNvRamFile_Api_IarrayBI));
				return cb_readNvRamFile_Api_IarrayBI;
			}

			static int n_ReadNvRamFile_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadNvRamFile_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("readNvRamFile_Api", "(I[BI)I", "GetReadNvRamFile_Api_IarrayBIHandler")]
			public abstract int ReadNvRamFile_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_readRsaKey_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetReadRsaKey_Api_arrayBHandler ()
			{
				if (cb_readRsaKey_Api_arrayB == null)
					cb_readRsaKey_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_ReadRsaKey_Api_arrayB));
				return cb_readRsaKey_Api_arrayB;
			}

			static int n_ReadRsaKey_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadRsaKey_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("readRsaKey_Api", "([B)I", "GetReadRsaKey_Api_arrayBHandler")]
			public abstract int ReadRsaKey_Api (byte[]? p0);

			static Delegate? cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
#pragma warning disable 0169
			static Delegate GetRegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler ()
			{
				if (cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == null)
					cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_RegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_));
				return cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
			}

			static bool n_RegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RegisterTouchListener_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='registerTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
			[Register ("registerTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetRegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler")]
			public abstract bool RegisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0);

			static Delegate? cb_setAdminPassword_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAdminPassword_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setAdminPassword_Api_Ljava_lang_String_ == null)
					cb_setAdminPassword_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetAdminPassword_Api_Ljava_lang_String_));
				return cb_setAdminPassword_Api_Ljava_lang_String_;
			}

			static int n_SetAdminPassword_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetAdminPassword_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAdminPassword_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdminPassword_Api", "(Ljava/lang/String;)I", "GetSetAdminPassword_Api_Ljava_lang_String_Handler")]
			public abstract int SetAdminPassword_Api (string? p0);

			static Delegate? cb_setApplicationType_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetApplicationType_Api_ZHandler ()
			{
				if (cb_setApplicationType_Api_Z == null)
					cb_setApplicationType_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetApplicationType_Api_Z));
				return cb_setApplicationType_Api_Z;
			}

			static void n_SetApplicationType_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.SetApplicationType_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setApplicationType_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setApplicationType_Api", "(Z)V", "GetSetApplicationType_Api_ZHandler")]
			public abstract void SetApplicationType_Api (bool p0);

			static Delegate? cb_setAutoTimeZone_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetAutoTimeZone_Api_ZHandler ()
			{
				if (cb_setAutoTimeZone_Api_Z == null)
					cb_setAutoTimeZone_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAutoTimeZone_Api_Z));
				return cb_setAutoTimeZone_Api_Z;
			}

			static bool n_SetAutoTimeZone_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetAutoTimeZone_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAutoTimeZone_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoTimeZone_Api", "(Z)Z", "GetSetAutoTimeZone_Api_ZHandler")]
			public abstract bool SetAutoTimeZone_Api (bool p0);

			static Delegate? cb_setAutoTime_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetAutoTime_Api_ZHandler ()
			{
				if (cb_setAutoTime_Api_Z == null)
					cb_setAutoTime_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAutoTime_Api_Z));
				return cb_setAutoTime_Api_Z;
			}

			static bool n_SetAutoTime_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetAutoTime_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAutoTime_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoTime_Api", "(Z)Z", "GetSetAutoTime_Api_ZHandler")]
			public abstract bool SetAutoTime_Api (bool p0);

			static Delegate? cb_setDataEnabled_Api_Z;
#pragma warning disable 0169
			static Delegate GetSetDataEnabled_Api_ZHandler ()
			{
				if (cb_setDataEnabled_Api_Z == null)
					cb_setDataEnabled_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetDataEnabled_Api_Z));
				return cb_setDataEnabled_Api_Z;
			}

			static bool n_SetDataEnabled_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SetDataEnabled_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setDataEnabled_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDataEnabled_Api", "(Z)Z", "GetSetDataEnabled_Api_ZHandler")]
			public abstract bool SetDataEnabled_Api (bool p0);

			static Delegate? cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_SetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_));
				return cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_;
			}

			static bool n_SetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetLauncherApp_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setLauncherApp_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setLauncherApp_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public abstract bool SetLauncherApp_Api (string? p0, string? p1);

			static Delegate? cb_setNtpServer_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNtpServer_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setNtpServer_Api_Ljava_lang_String_ == null)
					cb_setNtpServer_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetNtpServer_Api_Ljava_lang_String_));
				return cb_setNtpServer_Api_Ljava_lang_String_;
			}

			static bool n_SetNtpServer_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetNtpServer_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setNtpServer_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNtpServer_Api", "(Ljava/lang/String;)Z", "GetSetNtpServer_Api_Ljava_lang_String_Handler")]
			public abstract bool SetNtpServer_Api (string? p0);

			static Delegate? cb_setResumeRechargeValue_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetResumeRechargeValue_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setResumeRechargeValue_Api_Ljava_lang_String_ == null)
					cb_setResumeRechargeValue_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetResumeRechargeValue_Api_Ljava_lang_String_));
				return cb_setResumeRechargeValue_Api_Ljava_lang_String_;
			}

			static bool n_SetResumeRechargeValue_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetResumeRechargeValue_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setResumeRechargeValue_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResumeRechargeValue_Api", "(Ljava/lang/String;)Z", "GetSetResumeRechargeValue_Api_Ljava_lang_String_Handler")]
			public abstract bool SetResumeRechargeValue_Api (string? p0);

			static Delegate? cb_setSettingsPWD_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSettingsPWD_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setSettingsPWD_Api_Ljava_lang_String_ == null)
					cb_setSettingsPWD_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetSettingsPWD_Api_Ljava_lang_String_));
				return cb_setSettingsPWD_Api_Ljava_lang_String_;
			}

			static int n_SetSettingsPWD_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetSettingsPWD_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSettingsPWD_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSettingsPWD_Api", "(Ljava/lang/String;)I", "GetSetSettingsPWD_Api_Ljava_lang_String_Handler")]
			public abstract int SetSettingsPWD_Api (string? p0);

			static Delegate? cb_setSgnCheckEnable_Api_ZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSgnCheckEnable_Api_ZLjava_lang_String_Handler ()
			{
				if (cb_setSgnCheckEnable_Api_ZLjava_lang_String_ == null)
					cb_setSgnCheckEnable_Api_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZL_I (n_SetSgnCheckEnable_Api_ZLjava_lang_String_));
				return cb_setSgnCheckEnable_Api_ZLjava_lang_String_;
			}

			static int n_SetSgnCheckEnable_Api_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetSgnCheckEnable_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSgnCheckEnable_Api' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("setSgnCheckEnable_Api", "(ZLjava/lang/String;)I", "GetSetSgnCheckEnable_Api_ZLjava_lang_String_Handler")]
			public abstract int SetSgnCheckEnable_Api (bool p0, string? p1);

			static Delegate? cb_setSmartPosID_arrayB;
#pragma warning disable 0169
			static Delegate GetSetSmartPosID_arrayBHandler ()
			{
				if (cb_setSmartPosID_arrayB == null)
					cb_setSmartPosID_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetSmartPosID_arrayB));
				return cb_setSmartPosID_arrayB;
			}

			static int n_SetSmartPosID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.SetSmartPosID (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setSmartPosID", "([B)I", "GetSetSmartPosID_arrayBHandler")]
			public abstract int SetSmartPosID (byte[]? p0);

			static Delegate? cb_setSystemFunction_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSetSystemFunction_Landroid_os_Bundle_Handler ()
			{
				if (cb_setSystemFunction_Landroid_os_Bundle_ == null)
					cb_setSystemFunction_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetSystemFunction_Landroid_os_Bundle_));
				return cb_setSystemFunction_Landroid_os_Bundle_;
			}

			static bool n_SetSystemFunction_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetSystemFunction (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSystemFunction' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setSystemFunction", "(Landroid/os/Bundle;)Z", "GetSetSystemFunction_Landroid_os_Bundle_Handler")]
			public abstract bool SetSystemFunction (global::Android.OS.Bundle? p0);

			static Delegate? cb_setTimeZone_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTimeZone_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setTimeZone_Api_Ljava_lang_String_ == null)
					cb_setTimeZone_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetTimeZone_Api_Ljava_lang_String_));
				return cb_setTimeZone_Api_Ljava_lang_String_;
			}

			static bool n_SetTimeZone_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetTimeZone_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setTimeZone_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTimeZone_Api", "(Ljava/lang/String;)Z", "GetSetTimeZone_Api_Ljava_lang_String_Handler")]
			public abstract bool SetTimeZone_Api (string? p0);

			static Delegate? cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTrustedBluetoothMAC_Api_Ljava_lang_String_Handler ()
			{
				if (cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_ == null)
					cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetTrustedBluetoothMAC_Api_Ljava_lang_String_));
				return cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_;
			}

			static bool n_SetTrustedBluetoothMAC_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetTrustedBluetoothMAC_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setTrustedBluetoothMAC_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrustedBluetoothMAC_Api", "(Ljava/lang/String;)Z", "GetSetTrustedBluetoothMAC_Api_Ljava_lang_String_Handler")]
			public abstract bool SetTrustedBluetoothMAC_Api (string? p0);

			static Delegate? cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_;
#pragma warning disable 0169
			static Delegate GetSilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_Handler ()
			{
				if (cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ == null)
					cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_SilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_));
				return cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_;
			}

			static void n_SilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.SilentInstallApk_Api (p0, p1, p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='silentInstallApk_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IApkInstallResultAIDL']]"
			[Register ("silentInstallApk_Api", "(Ljava/lang/String;Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkInstallResultAIDL;)V", "GetSilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_Handler")]
			public abstract void SilentInstallApk_Api (string? p0, string? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL? p2);

			static Delegate? cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_;
#pragma warning disable 0169
			static Delegate GetSilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_Handler ()
			{
				if (cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ == null)
					cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_));
				return cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_;
			}

			static void n_SilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SilentUnInstallApk_Api (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='silentUnInstallApk_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IApkUnInstallResultAIDL']]"
			[Register ("silentUnInstallApk_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkUnInstallResultAIDL;)V", "GetSilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_Handler")]
			public abstract void SilentUnInstallApk_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL? p1);

			static Delegate? cb_stopBeep_api;
#pragma warning disable 0169
			static Delegate GetStopBeep_apiHandler ()
			{
				if (cb_stopBeep_api == null)
					cb_stopBeep_api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StopBeep_api));
				return cb_stopBeep_api;
			}

			static void n_StopBeep_api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.StopBeep_api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='stopBeep_api' and count(parameter)=0]"
			[Register ("stopBeep_api", "()V", "GetStopBeep_apiHandler")]
			public abstract void StopBeep_api ();

			static Delegate? cb_stopCatch_Api;
#pragma warning disable 0169
			static Delegate GetStopCatch_ApiHandler ()
			{
				if (cb_stopCatch_Api == null)
					cb_stopCatch_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_StopCatch_Api));
				return cb_stopCatch_Api;
			}

			static bool n_StopCatch_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.StopCatch_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='stopCatch_Api' and count(parameter)=0]"
			[Register ("stopCatch_Api", "()Z", "GetStopCatch_ApiHandler")]
			public abstract bool StopCatch_Api ();

			static Delegate? cb_switchAppEnable_Api_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetSwitchAppEnable_Api_Ljava_lang_String_ZHandler ()
			{
				if (cb_switchAppEnable_Api_Ljava_lang_String_Z == null)
					cb_switchAppEnable_Api_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_Z (n_SwitchAppEnable_Api_Ljava_lang_String_Z));
				return cb_switchAppEnable_Api_Ljava_lang_String_Z;
			}

			static bool n_SwitchAppEnable_Api_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SwitchAppEnable_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchAppEnable_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register ("switchAppEnable_Api", "(Ljava/lang/String;Z)Z", "GetSwitchAppEnable_Api_Ljava_lang_String_ZHandler")]
			public abstract bool SwitchAppEnable_Api (string? p0, bool p1);

			static Delegate? cb_switchChargeOnRS232_Api_Z;
#pragma warning disable 0169
			static Delegate GetSwitchChargeOnRS232_Api_ZHandler ()
			{
				if (cb_switchChargeOnRS232_Api_Z == null)
					cb_switchChargeOnRS232_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SwitchChargeOnRS232_Api_Z));
				return cb_switchChargeOnRS232_Api_Z;
			}

			static bool n_SwitchChargeOnRS232_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SwitchChargeOnRS232_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchChargeOnRS232_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("switchChargeOnRS232_Api", "(Z)Z", "GetSwitchChargeOnRS232_Api_ZHandler")]
			public abstract bool SwitchChargeOnRS232_Api (bool p0);

			static Delegate? cb_switchDefaultDataSIM_Api;
#pragma warning disable 0169
			static Delegate GetSwitchDefaultDataSIM_ApiHandler ()
			{
				if (cb_switchDefaultDataSIM_Api == null)
					cb_switchDefaultDataSIM_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_SwitchDefaultDataSIM_Api));
				return cb_switchDefaultDataSIM_Api;
			}

			static bool n_SwitchDefaultDataSIM_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SwitchDefaultDataSIM_Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchDefaultDataSIM_Api' and count(parameter)=0]"
			[Register ("switchDefaultDataSIM_Api", "()Z", "GetSwitchDefaultDataSIM_ApiHandler")]
			public abstract bool SwitchDefaultDataSIM_Api ();

			static Delegate? cb_switchGPS_Api_Z;
#pragma warning disable 0169
			static Delegate GetSwitchGPS_Api_ZHandler ()
			{
				if (cb_switchGPS_Api_Z == null)
					cb_switchGPS_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SwitchGPS_Api_Z));
				return cb_switchGPS_Api_Z;
			}

			static bool n_SwitchGPS_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.SwitchGPS_Api (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchGPS_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("switchGPS_Api", "(Z)Z", "GetSwitchGPS_Api_ZHandler")]
			public abstract bool SwitchGPS_Api (bool p0);

			static Delegate? cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
#pragma warning disable 0169
			static Delegate GetUnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler ()
			{
				if (cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == null)
					cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_UnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_));
				return cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
			}

			static bool n_UnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.UnregisterTouchListener_Api (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='unregisterTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
			[Register ("unregisterTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetUnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler")]
			public abstract bool UnregisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0);

			static Delegate? cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_;
#pragma warning disable 0169
			static Delegate GetUpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_Handler ()
			{
				if (cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ == null)
					cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_UpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_));
				return cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_;
			}

			static int n_UpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.UpdateSystem_Api (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='updateSystem_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.ISystemUpdate']]"
			[Register ("updateSystem_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/ISystemUpdate;)I", "GetUpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_Handler")]
			public abstract int UpdateSystem_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate? p1);

			static Delegate? cb_validatePermission_Z;
#pragma warning disable 0169
			static Delegate GetValidatePermission_ZHandler ()
			{
				if (cb_validatePermission_Z == null)
					cb_validatePermission_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_ValidatePermission_Z));
				return cb_validatePermission_Z;
			}

			static void n_ValidatePermission_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.ValidatePermission (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='validatePermission' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("validatePermission", "(Z)V", "GetValidatePermission_ZHandler")]
			public abstract void ValidatePermission (bool p0);

			static Delegate? cb_writeFileToSE_Api_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
			static Delegate GetWriteFileToSE_Api_Ljava_lang_String_arrayBIIHandler ()
			{
				if (cb_writeFileToSE_Api_Ljava_lang_String_arrayBII == null)
					cb_writeFileToSE_Api_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_I (n_WriteFileToSE_Api_Ljava_lang_String_arrayBII));
				return cb_writeFileToSE_Api_Ljava_lang_String_arrayBII;
			}

			static int n_WriteFileToSE_Api_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteFileToSE_Api (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeFileToSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("writeFileToSE_Api", "(Ljava/lang/String;[BII)I", "GetWriteFileToSE_Api_Ljava_lang_String_arrayBIIHandler")]
			public abstract int WriteFileToSE_Api (string? p0, byte[]? p1, int p2, int p3);

			static Delegate? cb_writeFlashData_Api_IarrayB;
#pragma warning disable 0169
			static Delegate GetWriteFlashData_Api_IarrayBHandler ()
			{
				if (cb_writeFlashData_Api_IarrayB == null)
					cb_writeFlashData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_WriteFlashData_Api_IarrayB));
				return cb_writeFlashData_Api_IarrayB;
			}

			static int n_WriteFlashData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteFlashData_Api (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("writeFlashData_Api", "(I[B)I", "GetWriteFlashData_Api_IarrayBHandler")]
			public abstract int WriteFlashData_Api (int p0, byte[]? p1);

			static Delegate? cb_writeNvRamFile_Api_IarrayBI;
#pragma warning disable 0169
			static Delegate GetWriteNvRamFile_Api_IarrayBIHandler ()
			{
				if (cb_writeNvRamFile_Api_IarrayBI == null)
					cb_writeNvRamFile_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_WriteNvRamFile_Api_IarrayBI));
				return cb_writeNvRamFile_Api_IarrayBI;
			}

			static int n_WriteNvRamFile_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.WriteNvRamFile_Api (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("writeNvRamFile_Api", "(I[BI)I", "GetWriteNvRamFile_Api_IarrayBIHandler")]
			public abstract int WriteNvRamFile_Api (int p0, byte[]? p1, int p2);

			static Delegate? cb_writeRsaKey_Api_arrayB;
#pragma warning disable 0169
			static Delegate GetWriteRsaKey_Api_arrayBHandler ()
			{
				if (cb_writeRsaKey_Api_arrayB == null)
					cb_writeRsaKey_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_WriteRsaKey_Api_arrayB));
				return cb_writeRsaKey_Api_arrayB;
			}

			static bool n_WriteRsaKey_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.WriteRsaKey_Api (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("writeRsaKey_Api", "([B)Z", "GetWriteRsaKey_Api_arrayBHandler")]
			public abstract bool WriteRsaKey_Api (byte[]? p0);

			static Delegate? cb_getAdminPassword_Api;
#pragma warning disable 0169
			static Delegate GetGetAdminPassword_ApiHandler ()
			{
				if (cb_getAdminPassword_Api == null)
					cb_getAdminPassword_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdminPassword_Api));
				return cb_getAdminPassword_Api;
			}

			static IntPtr n_GetAdminPassword_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.AdminPassword_Api);
			}
#pragma warning restore 0169

			public abstract string? AdminPassword_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAdminPassword_Api' and count(parameter)=0]"
				[Register ("getAdminPassword_Api", "()Ljava/lang/String;", "GetGetAdminPassword_ApiHandler")]
				get; 
			}

			static Delegate? cb_GetAllVersion_Api;
#pragma warning disable 0169
			static Delegate GetGetAllVersion_ApiHandler ()
			{
				if (cb_GetAllVersion_Api == null)
					cb_GetAllVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAllVersion_Api));
				return cb_GetAllVersion_Api;
			}

			static IntPtr n_GetAllVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.AllVersion_Api);
			}
#pragma warning restore 0169

			public abstract global::Android.OS.Bundle? AllVersion_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='GetAllVersion_Api' and count(parameter)=0]"
				[Register ("GetAllVersion_Api", "()Landroid/os/Bundle;", "GetGetAllVersion_ApiHandler")]
				get; 
			}

			static Delegate? cb_getAndroidKernelVersion;
#pragma warning disable 0169
			static Delegate GetGetAndroidKernelVersionHandler ()
			{
				if (cb_getAndroidKernelVersion == null)
					cb_getAndroidKernelVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAndroidKernelVersion));
				return cb_getAndroidKernelVersion;
			}

			static IntPtr n_GetAndroidKernelVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.AndroidKernelVersion);
			}
#pragma warning restore 0169

			public abstract string? AndroidKernelVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAndroidKernelVersion' and count(parameter)=0]"
				[Register ("getAndroidKernelVersion", "()Ljava/lang/String;", "GetGetAndroidKernelVersionHandler")]
				get; 
			}

			static Delegate? cb_getAntennaState;
#pragma warning disable 0169
			static Delegate GetGetAntennaStateHandler ()
			{
				if (cb_getAntennaState == null)
					cb_getAntennaState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetAntennaState));
				return cb_getAntennaState;
			}

			static int n_GetAntennaState (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.AntennaState;
			}
#pragma warning restore 0169

			public abstract int AntennaState {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAntennaState' and count(parameter)=0]"
				[Register ("getAntennaState", "()I", "GetGetAntennaStateHandler")]
				get; 
			}

			static Delegate? cb_getAutoTimeState_Api;
#pragma warning disable 0169
			static Delegate GetGetAutoTimeState_ApiHandler ()
			{
				if (cb_getAutoTimeState_Api == null)
					cb_getAutoTimeState_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetAutoTimeState_Api));
				return cb_getAutoTimeState_Api;
			}

			static bool n_GetAutoTimeState_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.AutoTimeState_Api;
			}
#pragma warning restore 0169

			public abstract bool AutoTimeState_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAutoTimeState_Api' and count(parameter)=0]"
				[Register ("getAutoTimeState_Api", "()Z", "GetGetAutoTimeState_ApiHandler")]
				get; 
			}

			static Delegate? cb_getAutoTimeZoneState_Api;
#pragma warning disable 0169
			static Delegate GetGetAutoTimeZoneState_ApiHandler ()
			{
				if (cb_getAutoTimeZoneState_Api == null)
					cb_getAutoTimeZoneState_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetAutoTimeZoneState_Api));
				return cb_getAutoTimeZoneState_Api;
			}

			static bool n_GetAutoTimeZoneState_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.AutoTimeZoneState_Api;
			}
#pragma warning restore 0169

			public abstract bool AutoTimeZoneState_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAutoTimeZoneState_Api' and count(parameter)=0]"
				[Register ("getAutoTimeZoneState_Api", "()Z", "GetGetAutoTimeZoneState_ApiHandler")]
				get; 
			}

			static Delegate? cb_getCSN;
#pragma warning disable 0169
			static Delegate GetGetCSNHandler ()
			{
				if (cb_getCSN == null)
					cb_getCSN = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCSN));
				return cb_getCSN;
			}

			static IntPtr n_GetCSN (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.CSN);
			}
#pragma warning restore 0169

			public abstract string? CSN {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getCSN' and count(parameter)=0]"
				[Register ("getCSN", "()Ljava/lang/String;", "GetGetCSNHandler")]
				get; 
			}

			static Delegate? cb_getDebuggableStatus_Api;
#pragma warning disable 0169
			static Delegate GetGetDebuggableStatus_ApiHandler ()
			{
				if (cb_getDebuggableStatus_Api == null)
					cb_getDebuggableStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetDebuggableStatus_Api));
				return cb_getDebuggableStatus_Api;
			}

			static bool n_GetDebuggableStatus_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.DebuggableStatus_Api;
			}
#pragma warning restore 0169

			public abstract bool DebuggableStatus_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getDebuggableStatus_Api' and count(parameter)=0]"
				[Register ("getDebuggableStatus_Api", "()Z", "GetGetDebuggableStatus_ApiHandler")]
				get; 
			}

			static Delegate? cb_getDefaultDataSIM_Api;
#pragma warning disable 0169
			static Delegate GetGetDefaultDataSIM_ApiHandler ()
			{
				if (cb_getDefaultDataSIM_Api == null)
					cb_getDefaultDataSIM_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDefaultDataSIM_Api));
				return cb_getDefaultDataSIM_Api;
			}

			static IntPtr n_GetDefaultDataSIM_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.DefaultDataSIM_Api);
			}
#pragma warning restore 0169

			public abstract string? DefaultDataSIM_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getDefaultDataSIM_Api' and count(parameter)=0]"
				[Register ("getDefaultDataSIM_Api", "()Ljava/lang/String;", "GetGetDefaultDataSIM_ApiHandler")]
				get; 
			}

			static Delegate? cb_getFirmwareVersion;
#pragma warning disable 0169
			static Delegate GetGetFirmwareVersionHandler ()
			{
				if (cb_getFirmwareVersion == null)
					cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFirmwareVersion));
				return cb_getFirmwareVersion;
			}

			static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.FirmwareVersion);
			}
#pragma warning restore 0169

			public abstract string? FirmwareVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getFirmwareVersion' and count(parameter)=0]"
				[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler")]
				get; 
			}

			static Delegate? cb_getHardwareVersion;
#pragma warning disable 0169
			static Delegate GetGetHardwareVersionHandler ()
			{
				if (cb_getHardwareVersion == null)
					cb_getHardwareVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHardwareVersion));
				return cb_getHardwareVersion;
			}

			static IntPtr n_GetHardwareVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.HardwareVersion);
			}
#pragma warning restore 0169

			public abstract string? HardwareVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getHardwareVersion' and count(parameter)=0]"
				[Register ("getHardwareVersion", "()Ljava/lang/String;", "GetGetHardwareVersionHandler")]
				get; 
			}

			static Delegate? cb_getImei;
#pragma warning disable 0169
			static Delegate GetGetImeiHandler ()
			{
				if (cb_getImei == null)
					cb_getImei = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetImei));
				return cb_getImei;
			}

			static IntPtr n_GetImei (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Imei);
			}
#pragma warning restore 0169

			public abstract string? Imei {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getImei' and count(parameter)=0]"
				[Register ("getImei", "()Ljava/lang/String;", "GetGetImeiHandler")]
				get; 
			}

			static Delegate? cb_isDebug_Api;
#pragma warning disable 0169
			static Delegate GetIsDebug_ApiHandler ()
			{
				if (cb_isDebug_Api == null)
					cb_isDebug_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsDebug_Api));
				return cb_isDebug_Api;
			}

			static bool n_IsDebug_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsDebug_Api;
			}
#pragma warning restore 0169

			public abstract bool IsDebug_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='isDebug_Api' and count(parameter)=0]"
				[Register ("isDebug_Api", "()Z", "GetIsDebug_ApiHandler")]
				get; 
			}

			static Delegate? cb_getLastShutdownCause_Api;
#pragma warning disable 0169
			static Delegate GetGetLastShutdownCause_ApiHandler ()
			{
				if (cb_getLastShutdownCause_Api == null)
					cb_getLastShutdownCause_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetLastShutdownCause_Api));
				return cb_getLastShutdownCause_Api;
			}

			static int n_GetLastShutdownCause_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.LastShutdownCause_Api;
			}
#pragma warning restore 0169

			public abstract int LastShutdownCause_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getLastShutdownCause_Api' and count(parameter)=0]"
				[Register ("getLastShutdownCause_Api", "()I", "GetGetLastShutdownCause_ApiHandler")]
				get; 
			}

			static Delegate? cb_getLifeInform_Api;
#pragma warning disable 0169
			static Delegate GetGetLifeInform_ApiHandler ()
			{
				if (cb_getLifeInform_Api == null)
					cb_getLifeInform_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLifeInform_Api));
				return cb_getLifeInform_Api;
			}

			static IntPtr n_GetLifeInform_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.LifeInform_Api);
			}
#pragma warning restore 0169

			public abstract global::Android.OS.Bundle? LifeInform_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getLifeInform_Api' and count(parameter)=0]"
				[Register ("getLifeInform_Api", "()Landroid/os/Bundle;", "GetGetLifeInform_ApiHandler")]
				get; 
			}

			static Delegate? cb_getMachineType_Api;
#pragma warning disable 0169
			static Delegate GetGetMachineType_ApiHandler ()
			{
				if (cb_getMachineType_Api == null)
					cb_getMachineType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMachineType_Api));
				return cb_getMachineType_Api;
			}

			static IntPtr n_GetMachineType_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.MachineType_Api);
			}
#pragma warning restore 0169

			public abstract string? MachineType_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getMachineType_Api' and count(parameter)=0]"
				[Register ("getMachineType_Api", "()Ljava/lang/String;", "GetGetMachineType_ApiHandler")]
				get; 
			}

			static Delegate? cb_getModuleSupport_Api;
#pragma warning disable 0169
			static Delegate GetGetModuleSupport_ApiHandler ()
			{
				if (cb_getModuleSupport_Api == null)
					cb_getModuleSupport_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetModuleSupport_Api));
				return cb_getModuleSupport_Api;
			}

			static IntPtr n_GetModuleSupport_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ModuleSupport_Api);
			}
#pragma warning restore 0169

			public abstract global::Android.OS.Bundle? ModuleSupport_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getModuleSupport_Api' and count(parameter)=0]"
				[Register ("getModuleSupport_Api", "()Landroid/os/Bundle;", "GetGetModuleSupport_ApiHandler")]
				get; 
			}

			static Delegate? cb_getNtpServer_Api;
#pragma warning disable 0169
			static Delegate GetGetNtpServer_ApiHandler ()
			{
				if (cb_getNtpServer_Api == null)
					cb_getNtpServer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNtpServer_Api));
				return cb_getNtpServer_Api;
			}

			static IntPtr n_GetNtpServer_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.NtpServer_Api);
			}
#pragma warning restore 0169

			public abstract string? NtpServer_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getNtpServer_Api' and count(parameter)=0]"
				[Register ("getNtpServer_Api", "()Ljava/lang/String;", "GetGetNtpServer_ApiHandler")]
				get; 
			}

			static Delegate? cb_getROMVersion;
#pragma warning disable 0169
			static Delegate GetGetROMVersionHandler ()
			{
				if (cb_getROMVersion == null)
					cb_getROMVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetROMVersion));
				return cb_getROMVersion;
			}

			static IntPtr n_GetROMVersion (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.ROMVersion);
			}
#pragma warning restore 0169

			public abstract string? ROMVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getROMVersion' and count(parameter)=0]"
				[Register ("getROMVersion", "()Ljava/lang/String;", "GetGetROMVersionHandler")]
				get; 
			}

			static Delegate? cb_getResumeRechargeValue_Api;
#pragma warning disable 0169
			static Delegate GetGetResumeRechargeValue_ApiHandler ()
			{
				if (cb_getResumeRechargeValue_Api == null)
					cb_getResumeRechargeValue_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResumeRechargeValue_Api));
				return cb_getResumeRechargeValue_Api;
			}

			static IntPtr n_GetResumeRechargeValue_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.ResumeRechargeValue_Api);
			}
#pragma warning restore 0169

			public abstract string? ResumeRechargeValue_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getResumeRechargeValue_Api' and count(parameter)=0]"
				[Register ("getResumeRechargeValue_Api", "()Ljava/lang/String;", "GetGetResumeRechargeValue_ApiHandler")]
				get; 
			}

			static Delegate? cb_getRootCertName_Api;
#pragma warning disable 0169
			static Delegate GetGetRootCertName_ApiHandler ()
			{
				if (cb_getRootCertName_Api == null)
					cb_getRootCertName_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRootCertName_Api));
				return cb_getRootCertName_Api;
			}

			static IntPtr n_GetRootCertName_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.RootCertName_Api);
			}
#pragma warning restore 0169

			public abstract string? RootCertName_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getRootCertName_Api' and count(parameter)=0]"
				[Register ("getRootCertName_Api", "()Ljava/lang/String;", "GetGetRootCertName_ApiHandler")]
				get; 
			}

			static Delegate? cb_getRootCertVersion_Api;
#pragma warning disable 0169
			static Delegate GetGetRootCertVersion_ApiHandler ()
			{
				if (cb_getRootCertVersion_Api == null)
					cb_getRootCertVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRootCertVersion_Api));
				return cb_getRootCertVersion_Api;
			}

			static IntPtr n_GetRootCertVersion_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.RootCertVersion_Api);
			}
#pragma warning restore 0169

			public abstract string? RootCertVersion_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getRootCertVersion_Api' and count(parameter)=0]"
				[Register ("getRootCertVersion_Api", "()Ljava/lang/String;", "GetGetRootCertVersion_ApiHandler")]
				get; 
			}

			static Delegate? cb_getSettingsPWD_Api;
#pragma warning disable 0169
			static Delegate GetGetSettingsPWD_ApiHandler ()
			{
				if (cb_getSettingsPWD_Api == null)
					cb_getSettingsPWD_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSettingsPWD_Api));
				return cb_getSettingsPWD_Api;
			}

			static IntPtr n_GetSettingsPWD_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.SettingsPWD_Api);
			}
#pragma warning restore 0169

			public abstract string? SettingsPWD_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSettingsPWD_Api' and count(parameter)=0]"
				[Register ("getSettingsPWD_Api", "()Ljava/lang/String;", "GetGetSettingsPWD_ApiHandler")]
				get; 
			}

			static Delegate? cb_getSysHWMaintainIntent;
#pragma warning disable 0169
			static Delegate GetGetSysHWMaintainIntentHandler ()
			{
				if (cb_getSysHWMaintainIntent == null)
					cb_getSysHWMaintainIntent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysHWMaintainIntent));
				return cb_getSysHWMaintainIntent;
			}

			static IntPtr n_GetSysHWMaintainIntent (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SysHWMaintainIntent);
			}
#pragma warning restore 0169

			public abstract global::Android.Content.Intent? SysHWMaintainIntent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSysHWMaintainIntent' and count(parameter)=0]"
				[Register ("getSysHWMaintainIntent", "()Landroid/content/Intent;", "GetGetSysHWMaintainIntentHandler")]
				get; 
			}

			static Delegate? cb_getSysOTAVerison_Api;
#pragma warning disable 0169
			static Delegate GetGetSysOTAVerison_ApiHandler ()
			{
				if (cb_getSysOTAVerison_Api == null)
					cb_getSysOTAVerison_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysOTAVerison_Api));
				return cb_getSysOTAVerison_Api;
			}

			static IntPtr n_GetSysOTAVerison_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.SysOTAVerison_Api);
			}
#pragma warning restore 0169

			public abstract string? SysOTAVerison_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSysOTAVerison_Api' and count(parameter)=0]"
				[Register ("getSysOTAVerison_Api", "()Ljava/lang/String;", "GetGetSysOTAVerison_ApiHandler")]
				get; 
			}

			static Delegate? cb_getSysgHWDetectionIntent;
#pragma warning disable 0169
			static Delegate GetGetSysgHWDetectionIntentHandler ()
			{
				if (cb_getSysgHWDetectionIntent == null)
					cb_getSysgHWDetectionIntent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysgHWDetectionIntent));
				return cb_getSysgHWDetectionIntent;
			}

			static IntPtr n_GetSysgHWDetectionIntent (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SysgHWDetectionIntent);
			}
#pragma warning restore 0169

			public abstract global::Android.Content.Intent? SysgHWDetectionIntent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSysgHWDetectionIntent' and count(parameter)=0]"
				[Register ("getSysgHWDetectionIntent", "()Landroid/content/Intent;", "GetGetSysgHWDetectionIntentHandler")]
				get; 
			}

			static Delegate? cb_getSystemInform_Api;
#pragma warning disable 0169
			static Delegate GetGetSystemInform_ApiHandler ()
			{
				if (cb_getSystemInform_Api == null)
					cb_getSystemInform_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSystemInform_Api));
				return cb_getSystemInform_Api;
			}

			static IntPtr n_GetSystemInform_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SystemInform_Api);
			}
#pragma warning restore 0169

			public abstract global::Android.OS.Bundle? SystemInform_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSystemInform_Api' and count(parameter)=0]"
				[Register ("getSystemInform_Api", "()Landroid/os/Bundle;", "GetGetSystemInform_ApiHandler")]
				get; 
			}

			static Delegate? cb_getTimeZone_Api;
#pragma warning disable 0169
			static Delegate GetGetTimeZone_ApiHandler ()
			{
				if (cb_getTimeZone_Api == null)
					cb_getTimeZone_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTimeZone_Api));
				return cb_getTimeZone_Api;
			}

			static IntPtr n_GetTimeZone_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.TimeZone_Api);
			}
#pragma warning restore 0169

			public abstract string? TimeZone_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getTimeZone_Api' and count(parameter)=0]"
				[Register ("getTimeZone_Api", "()Ljava/lang/String;", "GetGetTimeZone_ApiHandler")]
				get; 
			}

			static Delegate? cb_getUndeletableAppList_Api;
#pragma warning disable 0169
			static Delegate GetGetUndeletableAppList_ApiHandler ()
			{
				if (cb_getUndeletableAppList_Api == null)
					cb_getUndeletableAppList_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetUndeletableAppList_Api));
				return cb_getUndeletableAppList_Api;
			}

			static IntPtr n_GetUndeletableAppList_Api (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler.Stub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UndeletableAppList_Api);
			}
#pragma warning restore 0169

			public abstract global::System.Collections.Generic.IList<string>? UndeletableAppList_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getUndeletableAppList_Api' and count(parameter)=0]"
				[Register ("getUndeletableAppList_Api", "()Ljava/util/List;", "GetGetUndeletableAppList_ApiHandler")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("com/vanstone/appsdk/api/system/SystemHandler$Stub", DoNotGenerateAcw=true)]
		internal partial class StubInvoker : Stub {
			public StubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/system/SystemHandler$Stub", typeof (StubInvoker));

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

			public override unsafe string? AdminPassword_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAdminPassword_Api' and count(parameter)=0]"
				[Register ("getAdminPassword_Api", "()Ljava/lang/String;", "GetGetAdminPassword_ApiHandler")]
				get {
					const string __id = "getAdminPassword_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Android.OS.Bundle? AllVersion_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='GetAllVersion_Api' and count(parameter)=0]"
				[Register ("GetAllVersion_Api", "()Landroid/os/Bundle;", "GetGetAllVersion_ApiHandler")]
				get {
					const string __id = "GetAllVersion_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? AndroidKernelVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAndroidKernelVersion' and count(parameter)=0]"
				[Register ("getAndroidKernelVersion", "()Ljava/lang/String;", "GetGetAndroidKernelVersionHandler")]
				get {
					const string __id = "getAndroidKernelVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe int AntennaState {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAntennaState' and count(parameter)=0]"
				[Register ("getAntennaState", "()I", "GetGetAntennaStateHandler")]
				get {
					const string __id = "getAntennaState.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe bool AutoTimeState_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAutoTimeState_Api' and count(parameter)=0]"
				[Register ("getAutoTimeState_Api", "()Z", "GetGetAutoTimeState_ApiHandler")]
				get {
					const string __id = "getAutoTimeState_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe bool AutoTimeZoneState_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getAutoTimeZoneState_Api' and count(parameter)=0]"
				[Register ("getAutoTimeZoneState_Api", "()Z", "GetGetAutoTimeZoneState_ApiHandler")]
				get {
					const string __id = "getAutoTimeZoneState_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe string? CSN {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getCSN' and count(parameter)=0]"
				[Register ("getCSN", "()Ljava/lang/String;", "GetGetCSNHandler")]
				get {
					const string __id = "getCSN.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe bool DebuggableStatus_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getDebuggableStatus_Api' and count(parameter)=0]"
				[Register ("getDebuggableStatus_Api", "()Z", "GetGetDebuggableStatus_ApiHandler")]
				get {
					const string __id = "getDebuggableStatus_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe string? DefaultDataSIM_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getDefaultDataSIM_Api' and count(parameter)=0]"
				[Register ("getDefaultDataSIM_Api", "()Ljava/lang/String;", "GetGetDefaultDataSIM_ApiHandler")]
				get {
					const string __id = "getDefaultDataSIM_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? FirmwareVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getFirmwareVersion' and count(parameter)=0]"
				[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler")]
				get {
					const string __id = "getFirmwareVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? HardwareVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getHardwareVersion' and count(parameter)=0]"
				[Register ("getHardwareVersion", "()Ljava/lang/String;", "GetGetHardwareVersionHandler")]
				get {
					const string __id = "getHardwareVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? Imei {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getImei' and count(parameter)=0]"
				[Register ("getImei", "()Ljava/lang/String;", "GetGetImeiHandler")]
				get {
					const string __id = "getImei.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe bool IsDebug_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='isDebug_Api' and count(parameter)=0]"
				[Register ("isDebug_Api", "()Z", "GetIsDebug_ApiHandler")]
				get {
					const string __id = "isDebug_Api.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe int LastShutdownCause_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getLastShutdownCause_Api' and count(parameter)=0]"
				[Register ("getLastShutdownCause_Api", "()I", "GetGetLastShutdownCause_ApiHandler")]
				get {
					const string __id = "getLastShutdownCause_Api.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public override unsafe global::Android.OS.Bundle? LifeInform_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getLifeInform_Api' and count(parameter)=0]"
				[Register ("getLifeInform_Api", "()Landroid/os/Bundle;", "GetGetLifeInform_ApiHandler")]
				get {
					const string __id = "getLifeInform_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? MachineType_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getMachineType_Api' and count(parameter)=0]"
				[Register ("getMachineType_Api", "()Ljava/lang/String;", "GetGetMachineType_ApiHandler")]
				get {
					const string __id = "getMachineType_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Android.OS.Bundle? ModuleSupport_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getModuleSupport_Api' and count(parameter)=0]"
				[Register ("getModuleSupport_Api", "()Landroid/os/Bundle;", "GetGetModuleSupport_ApiHandler")]
				get {
					const string __id = "getModuleSupport_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? NtpServer_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getNtpServer_Api' and count(parameter)=0]"
				[Register ("getNtpServer_Api", "()Ljava/lang/String;", "GetGetNtpServer_ApiHandler")]
				get {
					const string __id = "getNtpServer_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? ROMVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getROMVersion' and count(parameter)=0]"
				[Register ("getROMVersion", "()Ljava/lang/String;", "GetGetROMVersionHandler")]
				get {
					const string __id = "getROMVersion.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? ResumeRechargeValue_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getResumeRechargeValue_Api' and count(parameter)=0]"
				[Register ("getResumeRechargeValue_Api", "()Ljava/lang/String;", "GetGetResumeRechargeValue_ApiHandler")]
				get {
					const string __id = "getResumeRechargeValue_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? RootCertName_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getRootCertName_Api' and count(parameter)=0]"
				[Register ("getRootCertName_Api", "()Ljava/lang/String;", "GetGetRootCertName_ApiHandler")]
				get {
					const string __id = "getRootCertName_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? RootCertVersion_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getRootCertVersion_Api' and count(parameter)=0]"
				[Register ("getRootCertVersion_Api", "()Ljava/lang/String;", "GetGetRootCertVersion_ApiHandler")]
				get {
					const string __id = "getRootCertVersion_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? SettingsPWD_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSettingsPWD_Api' and count(parameter)=0]"
				[Register ("getSettingsPWD_Api", "()Ljava/lang/String;", "GetGetSettingsPWD_ApiHandler")]
				get {
					const string __id = "getSettingsPWD_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Android.Content.Intent? SysHWMaintainIntent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSysHWMaintainIntent' and count(parameter)=0]"
				[Register ("getSysHWMaintainIntent", "()Landroid/content/Intent;", "GetGetSysHWMaintainIntentHandler")]
				get {
					const string __id = "getSysHWMaintainIntent.()Landroid/content/Intent;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? SysOTAVerison_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSysOTAVerison_Api' and count(parameter)=0]"
				[Register ("getSysOTAVerison_Api", "()Ljava/lang/String;", "GetGetSysOTAVerison_ApiHandler")]
				get {
					const string __id = "getSysOTAVerison_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Android.Content.Intent? SysgHWDetectionIntent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSysgHWDetectionIntent' and count(parameter)=0]"
				[Register ("getSysgHWDetectionIntent", "()Landroid/content/Intent;", "GetGetSysgHWDetectionIntentHandler")]
				get {
					const string __id = "getSysgHWDetectionIntent.()Landroid/content/Intent;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::Android.OS.Bundle? SystemInform_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getSystemInform_Api' and count(parameter)=0]"
				[Register ("getSystemInform_Api", "()Landroid/os/Bundle;", "GetGetSystemInform_ApiHandler")]
				get {
					const string __id = "getSystemInform_Api.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe string? TimeZone_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getTimeZone_Api' and count(parameter)=0]"
				[Register ("getTimeZone_Api", "()Ljava/lang/String;", "GetGetTimeZone_ApiHandler")]
				get {
					const string __id = "getTimeZone_Api.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public override unsafe global::System.Collections.Generic.IList<string>? UndeletableAppList_Api {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/class[@name='SystemHandler.Stub']/method[@name='getUndeletableAppList_Api' and count(parameter)=0]"
				[Register ("getUndeletableAppList_Api", "()Ljava/util/List;", "GetGetUndeletableAppList_ApiHandler")]
				get {
					const string __id = "getUndeletableAppList_Api.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='BackUpByPackage_Api' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
			[Register ("BackUpByPackage_Api", "(Ljava/util/List;Ljava/lang/String;)I", "GetBackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_Handler")]
			public override unsafe int BackUpByPackage_Api (global::System.Collections.Generic.IList<string>? p0, string? p1)
			{
				const string __id = "BackUpByPackage_Api.(Ljava/util/List;Ljava/lang/String;)I";
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='Beef_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("Beef_Api", "(II)V", "GetBeef_Api_IIHandler")]
			public override unsafe void Beef_Api (int p0, int p1)
			{
				const string __id = "Beef_Api.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='Beep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("Beep_Api", "(I)V", "GetBeep_Api_IHandler")]
			public override unsafe void Beep_Api (int p0)
			{
				const string __id = "Beep_Api.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='CheckModuleStatue_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("CheckModuleStatue_Api", "(I)I", "GetCheckModuleStatue_Api_IHandler")]
			public override unsafe int CheckModuleStatue_Api (int p0)
			{
				const string __id = "CheckModuleStatue_Api.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GateClose_Api' and count(parameter)=0]"
			[Register ("GateClose_Api", "()I", "GetGateClose_ApiHandler")]
			public override unsafe int GateClose_Api ()
			{
				const string __id = "GateClose_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GateOpen_Api' and count(parameter)=0]"
			[Register ("GateOpen_Api", "()I", "GetGateOpen_ApiHandler")]
			public override unsafe int GateOpen_Api ()
			{
				const string __id = "GateOpen_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='GetVersion_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("GetVersion_Api", "([B[B)I", "GetGetVersion_Api_arrayBarrayBHandler")]
			public override unsafe int GetVersion_Api (byte[]? p0, byte[]? p1)
			{
				const string __id = "GetVersion_Api.([B[B)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
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
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='IsHandleOnBase_Api' and count(parameter)=0]"
			[Register ("IsHandleOnBase_Api", "()I", "GetIsHandleOnBase_ApiHandler")]
			public override unsafe int IsHandleOnBase_Api ()
			{
				const string __id = "IsHandleOnBase_Api.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='ReadPosSn' and count(parameter)=0]"
			[Register ("ReadPosSn", "()Ljava/lang/String;", "GetReadPosSnHandler")]
			public override unsafe string? ReadPosSn ()
			{
				const string __id = "ReadPosSn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='RestoreDatda_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("RestoreDatda_Api", "(Ljava/lang/String;)I", "GetRestoreDatda_Api_Ljava_lang_String_Handler")]
			public override unsafe int RestoreDatda_Api (string? p0)
			{
				const string __id = "RestoreDatda_Api.(Ljava/lang/String;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='RestoreFactory_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("RestoreFactory_Api", "(Z)V", "GetRestoreFactory_Api_ZHandler")]
			public override unsafe void RestoreFactory_Api (bool p0)
			{
				const string __id = "RestoreFactory_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetAdbEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetAdbEnable_Api", "(Z)Z", "GetSetAdbEnable_Api_ZHandler")]
			public override unsafe bool SetAdbEnable_Api (bool p0)
			{
				const string __id = "SetAdbEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetBaseBroadcast_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetBaseBroadcast_Api", "(Z)V", "GetSetBaseBroadcast_Api_ZHandler")]
			public override unsafe void SetBaseBroadcast_Api (bool p0)
			{
				const string __id = "SetBaseBroadcast_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetBluetoothEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetBluetoothEnable_Api", "(Z)Z", "GetSetBluetoothEnable_Api_ZHandler")]
			public override unsafe bool SetBluetoothEnable_Api (bool p0)
			{
				const string __id = "SetBluetoothEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetOtgEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetOtgEnable_Api", "(Z)Z", "GetSetOtgEnable_Api_ZHandler")]
			public override unsafe bool SetOtgEnable_Api (bool p0)
			{
				const string __id = "SetOtgEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetSetScreenOffTimeout_Api' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetSetScreenOffTimeout_Api", "(I)Z", "GetSetSetScreenOffTimeout_Api_IHandler")]
			public override unsafe bool SetSetScreenOffTimeout_Api (int p0)
			{
				const string __id = "SetSetScreenOffTimeout_Api.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetTime_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetTime_Api", "(Ljava/lang/String;)I", "GetSetTime_Api_Ljava_lang_String_Handler")]
			public override unsafe int SetTime_Api (string? p0)
			{
				const string __id = "SetTime_Api.(Ljava/lang/String;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SetWifiAddNetworkEnable_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetWifiAddNetworkEnable_Api", "(Z)Z", "GetSetWifiAddNetworkEnable_Api_ZHandler")]
			public override unsafe bool SetWifiAddNetworkEnable_Api (bool p0)
			{
				const string __id = "SetWifiAddNetworkEnable_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SystemPowerOff_Api' and count(parameter)=0]"
			[Register ("SystemPowerOff_Api", "()V", "GetSystemPowerOff_ApiHandler")]
			public override unsafe void SystemPowerOff_Api ()
			{
				const string __id = "SystemPowerOff_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='SystemReboot_Api' and count(parameter)=0]"
			[Register ("SystemReboot_Api", "()V", "GetSystemReboot_ApiHandler")]
			public override unsafe void SystemReboot_Api ()
			{
				const string __id = "SystemReboot_Api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='catchMainLog_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("catchMainLog_Api", "(Ljava/lang/String;)Z", "GetCatchMainLog_Api_Ljava_lang_String_Handler")]
			public override unsafe bool CatchMainLog_Api (string? p0)
			{
				const string __id = "catchMainLog_Api.(Ljava/lang/String;)Z";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteFileInSe_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteFileInSe_Api", "(Ljava/lang/String;)I", "GetDeleteFileInSe_Api_Ljava_lang_String_Handler")]
			public override unsafe int DeleteFileInSe_Api (string? p0)
			{
				const string __id = "deleteFileInSe_Api.(Ljava/lang/String;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("deleteFlashData_Api", "(II)I", "GetDeleteFlashData_Api_IIHandler")]
			public override unsafe int DeleteFlashData_Api (int p0, int p1)
			{
				const string __id = "deleteFlashData_Api.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='deleteRsakey_Api' and count(parameter)=0]"
			[Register ("deleteRsakey_Api", "()Z", "GetDeleteRsakey_ApiHandler")]
			public override unsafe bool DeleteRsakey_Api ()
			{
				const string __id = "deleteRsakey_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getFileListInSe_Api' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("getFileListInSe_Api", "(Ljava/util/List;)I", "GetGetFileListInSe_Api_Ljava_util_List_Handler")]
			public override unsafe int GetFileListInSe_Api (global::System.Collections.Generic.IList<string>? p0)
			{
				const string __id = "getFileListInSe_Api.(Ljava/util/List;)I";
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("getSmartPosID", "([B)I", "GetGetSmartPosID_arrayBHandler")]
			public override unsafe int GetSmartPosID (byte[]? p0)
			{
				const string __id = "getSmartPosID.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='getTrafficStats_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getTrafficStats_Api", "(Ljava/lang/String;Ljava/lang/String;)Lcom/vanstone/appsdk/api/struct/AidlTrafficStats;", "GetGetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public override unsafe global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats? GetTrafficStats_Api (string? p0, string? p1)
			{
				const string __id = "getTrafficStats_Api.(Ljava/lang/String;Ljava/lang/String;)Lcom/vanstone/appsdk/api/struct/AidlTrafficStats;";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='isForeground_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isForeground_Api", "(Ljava/lang/String;)Z", "GetIsForeground_Api_Ljava_lang_String_Handler")]
			public override unsafe bool IsForeground_Api (string? p0)
			{
				const string __id = "isForeground_Api.(Ljava/lang/String;)Z";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='isdeviceEnabled_Api' and count(parameter)=0]"
			[Register ("isdeviceEnabled_Api", "()Z", "GetIsdeviceEnabled_ApiHandler")]
			public override unsafe bool IsdeviceEnabled_Api ()
			{
				const string __id = "isdeviceEnabled_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readFileFromSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("readFileFromSE_Api", "(Ljava/lang/String;[BII)I", "GetReadFileFromSE_Api_Ljava_lang_String_arrayBIIHandler")]
			public override unsafe int ReadFileFromSE_Api (string? p0, byte[]? p1, int p2, int p3)
			{
				const string __id = "readFileFromSE_Api.(Ljava/lang/String;[BII)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("readFlashData_Api", "(I[B)I", "GetReadFlashData_Api_IarrayBHandler")]
			public override unsafe int ReadFlashData_Api (int p0, byte[]? p1)
			{
				const string __id = "readFlashData_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("readNvRamFile_Api", "(I[BI)I", "GetReadNvRamFile_Api_IarrayBIHandler")]
			public override unsafe int ReadNvRamFile_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "readNvRamFile_Api.(I[BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='readRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("readRsaKey_Api", "([B)I", "GetReadRsaKey_Api_arrayBHandler")]
			public override unsafe int ReadRsaKey_Api (byte[]? p0)
			{
				const string __id = "readRsaKey_Api.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='registerTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
			[Register ("registerTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetRegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler")]
			public override unsafe bool RegisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0)
			{
				const string __id = "registerTouchListener_Api.(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAdminPassword_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdminPassword_Api", "(Ljava/lang/String;)I", "GetSetAdminPassword_Api_Ljava_lang_String_Handler")]
			public override unsafe int SetAdminPassword_Api (string? p0)
			{
				const string __id = "setAdminPassword_Api.(Ljava/lang/String;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setApplicationType_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setApplicationType_Api", "(Z)V", "GetSetApplicationType_Api_ZHandler")]
			public override unsafe void SetApplicationType_Api (bool p0)
			{
				const string __id = "setApplicationType_Api.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAutoTimeZone_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoTimeZone_Api", "(Z)Z", "GetSetAutoTimeZone_Api_ZHandler")]
			public override unsafe bool SetAutoTimeZone_Api (bool p0)
			{
				const string __id = "setAutoTimeZone_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setAutoTime_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoTime_Api", "(Z)Z", "GetSetAutoTime_Api_ZHandler")]
			public override unsafe bool SetAutoTime_Api (bool p0)
			{
				const string __id = "setAutoTime_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setDataEnabled_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDataEnabled_Api", "(Z)Z", "GetSetDataEnabled_Api_ZHandler")]
			public override unsafe bool SetDataEnabled_Api (bool p0)
			{
				const string __id = "setDataEnabled_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setLauncherApp_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setLauncherApp_Api", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_Handler")]
			public override unsafe bool SetLauncherApp_Api (string? p0, string? p1)
			{
				const string __id = "setLauncherApp_Api.(Ljava/lang/String;Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setNtpServer_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNtpServer_Api", "(Ljava/lang/String;)Z", "GetSetNtpServer_Api_Ljava_lang_String_Handler")]
			public override unsafe bool SetNtpServer_Api (string? p0)
			{
				const string __id = "setNtpServer_Api.(Ljava/lang/String;)Z";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setResumeRechargeValue_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResumeRechargeValue_Api", "(Ljava/lang/String;)Z", "GetSetResumeRechargeValue_Api_Ljava_lang_String_Handler")]
			public override unsafe bool SetResumeRechargeValue_Api (string? p0)
			{
				const string __id = "setResumeRechargeValue_Api.(Ljava/lang/String;)Z";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSettingsPWD_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSettingsPWD_Api", "(Ljava/lang/String;)I", "GetSetSettingsPWD_Api_Ljava_lang_String_Handler")]
			public override unsafe int SetSettingsPWD_Api (string? p0)
			{
				const string __id = "setSettingsPWD_Api.(Ljava/lang/String;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSgnCheckEnable_Api' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("setSgnCheckEnable_Api", "(ZLjava/lang/String;)I", "GetSetSgnCheckEnable_Api_ZLjava_lang_String_Handler")]
			public override unsafe int SetSgnCheckEnable_Api (bool p0, string? p1)
			{
				const string __id = "setSgnCheckEnable_Api.(ZLjava/lang/String;)I";
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSmartPosID' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setSmartPosID", "([B)I", "GetSetSmartPosID_arrayBHandler")]
			public override unsafe int SetSmartPosID (byte[]? p0)
			{
				const string __id = "setSmartPosID.([B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setSystemFunction' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setSystemFunction", "(Landroid/os/Bundle;)Z", "GetSetSystemFunction_Landroid_os_Bundle_Handler")]
			public override unsafe bool SetSystemFunction (global::Android.OS.Bundle? p0)
			{
				const string __id = "setSystemFunction.(Landroid/os/Bundle;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setTimeZone_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTimeZone_Api", "(Ljava/lang/String;)Z", "GetSetTimeZone_Api_Ljava_lang_String_Handler")]
			public override unsafe bool SetTimeZone_Api (string? p0)
			{
				const string __id = "setTimeZone_Api.(Ljava/lang/String;)Z";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='setTrustedBluetoothMAC_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrustedBluetoothMAC_Api", "(Ljava/lang/String;)Z", "GetSetTrustedBluetoothMAC_Api_Ljava_lang_String_Handler")]
			public override unsafe bool SetTrustedBluetoothMAC_Api (string? p0)
			{
				const string __id = "setTrustedBluetoothMAC_Api.(Ljava/lang/String;)Z";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='silentInstallApk_Api' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vanstone.appsdk.api.interfaces.IApkInstallResultAIDL']]"
			[Register ("silentInstallApk_Api", "(Ljava/lang/String;Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkInstallResultAIDL;)V", "GetSilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_Handler")]
			public override unsafe void SilentInstallApk_Api (string? p0, string? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL? p2)
			{
				const string __id = "silentInstallApk_Api.(Ljava/lang/String;Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkInstallResultAIDL;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='silentUnInstallApk_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.IApkUnInstallResultAIDL']]"
			[Register ("silentUnInstallApk_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkUnInstallResultAIDL;)V", "GetSilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_Handler")]
			public override unsafe void SilentUnInstallApk_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL? p1)
			{
				const string __id = "silentUnInstallApk_Api.(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkUnInstallResultAIDL;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='stopBeep_api' and count(parameter)=0]"
			[Register ("stopBeep_api", "()V", "GetStopBeep_apiHandler")]
			public override unsafe void StopBeep_api ()
			{
				const string __id = "stopBeep_api.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='stopCatch_Api' and count(parameter)=0]"
			[Register ("stopCatch_Api", "()Z", "GetStopCatch_ApiHandler")]
			public override unsafe bool StopCatch_Api ()
			{
				const string __id = "stopCatch_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchAppEnable_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register ("switchAppEnable_Api", "(Ljava/lang/String;Z)Z", "GetSwitchAppEnable_Api_Ljava_lang_String_ZHandler")]
			public override unsafe bool SwitchAppEnable_Api (string? p0, bool p1)
			{
				const string __id = "switchAppEnable_Api.(Ljava/lang/String;Z)Z";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchChargeOnRS232_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("switchChargeOnRS232_Api", "(Z)Z", "GetSwitchChargeOnRS232_Api_ZHandler")]
			public override unsafe bool SwitchChargeOnRS232_Api (bool p0)
			{
				const string __id = "switchChargeOnRS232_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchDefaultDataSIM_Api' and count(parameter)=0]"
			[Register ("switchDefaultDataSIM_Api", "()Z", "GetSwitchDefaultDataSIM_ApiHandler")]
			public override unsafe bool SwitchDefaultDataSIM_Api ()
			{
				const string __id = "switchDefaultDataSIM_Api.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='switchGPS_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("switchGPS_Api", "(Z)Z", "GetSwitchGPS_Api_ZHandler")]
			public override unsafe bool SwitchGPS_Api (bool p0)
			{
				const string __id = "switchGPS_Api.(Z)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='unregisterTouchListener_Api' and count(parameter)=1 and parameter[1][@type='com.vanstone.appsdk.api.interfaces.IAidlTouchListenerAIDL']]"
			[Register ("unregisterTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z", "GetUnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler")]
			public override unsafe bool UnregisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0)
			{
				const string __id = "unregisterTouchListener_Api.(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='updateSystem_Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vanstone.appsdk.api.interfaces.ISystemUpdate']]"
			[Register ("updateSystem_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/ISystemUpdate;)I", "GetUpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_Handler")]
			public override unsafe int UpdateSystem_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate? p1)
			{
				const string __id = "updateSystem_Api.(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/ISystemUpdate;)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='validatePermission' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("validatePermission", "(Z)V", "GetValidatePermission_ZHandler")]
			public override unsafe void ValidatePermission (bool p0)
			{
				const string __id = "validatePermission.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeFileToSE_Api' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("writeFileToSE_Api", "(Ljava/lang/String;[BII)I", "GetWriteFileToSE_Api_Ljava_lang_String_arrayBIIHandler")]
			public override unsafe int WriteFileToSE_Api (string? p0, byte[]? p1, int p2, int p3)
			{
				const string __id = "writeFileToSE_Api.(Ljava/lang/String;[BII)I";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeFlashData_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("writeFlashData_Api", "(I[B)I", "GetWriteFlashData_Api_IarrayBHandler")]
			public override unsafe int WriteFlashData_Api (int p0, byte[]? p1)
			{
				const string __id = "writeFlashData_Api.(I[B)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeNvRamFile_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register ("writeNvRamFile_Api", "(I[BI)I", "GetWriteNvRamFile_Api_IarrayBIHandler")]
			public override unsafe int WriteNvRamFile_Api (int p0, byte[]? p1, int p2)
			{
				const string __id = "writeNvRamFile_Api.(I[BI)I";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.appsdk.api.system']/interface[@name='SystemHandler']/method[@name='writeRsaKey_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("writeRsaKey_Api", "([B)Z", "GetWriteRsaKey_Api_arrayBHandler")]
			public override unsafe bool WriteRsaKey_Api (byte[]? p0)
			{
				const string __id = "writeRsaKey_Api.([B)Z";
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

		}

	}

	[global::Android.Runtime.Register ("com/vanstone/appsdk/api/system/SystemHandler", DoNotGenerateAcw=true)]
	internal partial class ISystemHandlerInvoker : global::Java.Lang.Object, ISystemHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/appsdk/api/system/SystemHandler", typeof (ISystemHandlerInvoker));

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

		public static ISystemHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISystemHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.vanstone.appsdk.api.system.SystemHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISystemHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getAdminPassword_Api;
#pragma warning disable 0169
		static Delegate GetGetAdminPassword_ApiHandler ()
		{
			if (cb_getAdminPassword_Api == null)
				cb_getAdminPassword_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdminPassword_Api));
			return cb_getAdminPassword_Api;
		}

		static IntPtr n_GetAdminPassword_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AdminPassword_Api);
		}
#pragma warning restore 0169

		IntPtr id_getAdminPassword_Api;
		public unsafe string? AdminPassword_Api {
			get {
				if (id_getAdminPassword_Api == IntPtr.Zero)
					id_getAdminPassword_Api = JNIEnv.GetMethodID (class_ref, "getAdminPassword_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdminPassword_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_GetAllVersion_Api;
#pragma warning disable 0169
		static Delegate GetGetAllVersion_ApiHandler ()
		{
			if (cb_GetAllVersion_Api == null)
				cb_GetAllVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAllVersion_Api));
			return cb_GetAllVersion_Api;
		}

		static IntPtr n_GetAllVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AllVersion_Api);
		}
#pragma warning restore 0169

		IntPtr id_GetAllVersion_Api;
		public unsafe global::Android.OS.Bundle? AllVersion_Api {
			get {
				if (id_GetAllVersion_Api == IntPtr.Zero)
					id_GetAllVersion_Api = JNIEnv.GetMethodID (class_ref, "GetAllVersion_Api", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetAllVersion_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getAndroidKernelVersion;
#pragma warning disable 0169
		static Delegate GetGetAndroidKernelVersionHandler ()
		{
			if (cb_getAndroidKernelVersion == null)
				cb_getAndroidKernelVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAndroidKernelVersion));
			return cb_getAndroidKernelVersion;
		}

		static IntPtr n_GetAndroidKernelVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AndroidKernelVersion);
		}
#pragma warning restore 0169

		IntPtr id_getAndroidKernelVersion;
		public unsafe string? AndroidKernelVersion {
			get {
				if (id_getAndroidKernelVersion == IntPtr.Zero)
					id_getAndroidKernelVersion = JNIEnv.GetMethodID (class_ref, "getAndroidKernelVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAndroidKernelVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getAntennaState;
#pragma warning disable 0169
		static Delegate GetGetAntennaStateHandler ()
		{
			if (cb_getAntennaState == null)
				cb_getAntennaState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetAntennaState));
			return cb_getAntennaState;
		}

		static int n_GetAntennaState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.AntennaState;
		}
#pragma warning restore 0169

		IntPtr id_getAntennaState;
		public unsafe int AntennaState {
			get {
				if (id_getAntennaState == IntPtr.Zero)
					id_getAntennaState = JNIEnv.GetMethodID (class_ref, "getAntennaState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAntennaState);
			}
		}

		static Delegate? cb_getAutoTimeState_Api;
#pragma warning disable 0169
		static Delegate GetGetAutoTimeState_ApiHandler ()
		{
			if (cb_getAutoTimeState_Api == null)
				cb_getAutoTimeState_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetAutoTimeState_Api));
			return cb_getAutoTimeState_Api;
		}

		static bool n_GetAutoTimeState_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.AutoTimeState_Api;
		}
#pragma warning restore 0169

		IntPtr id_getAutoTimeState_Api;
		public unsafe bool AutoTimeState_Api {
			get {
				if (id_getAutoTimeState_Api == IntPtr.Zero)
					id_getAutoTimeState_Api = JNIEnv.GetMethodID (class_ref, "getAutoTimeState_Api", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoTimeState_Api);
			}
		}

		static Delegate? cb_getAutoTimeZoneState_Api;
#pragma warning disable 0169
		static Delegate GetGetAutoTimeZoneState_ApiHandler ()
		{
			if (cb_getAutoTimeZoneState_Api == null)
				cb_getAutoTimeZoneState_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetAutoTimeZoneState_Api));
			return cb_getAutoTimeZoneState_Api;
		}

		static bool n_GetAutoTimeZoneState_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.AutoTimeZoneState_Api;
		}
#pragma warning restore 0169

		IntPtr id_getAutoTimeZoneState_Api;
		public unsafe bool AutoTimeZoneState_Api {
			get {
				if (id_getAutoTimeZoneState_Api == IntPtr.Zero)
					id_getAutoTimeZoneState_Api = JNIEnv.GetMethodID (class_ref, "getAutoTimeZoneState_Api", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoTimeZoneState_Api);
			}
		}

		static Delegate? cb_getCSN;
#pragma warning disable 0169
		static Delegate GetGetCSNHandler ()
		{
			if (cb_getCSN == null)
				cb_getCSN = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCSN));
			return cb_getCSN;
		}

		static IntPtr n_GetCSN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CSN);
		}
#pragma warning restore 0169

		IntPtr id_getCSN;
		public unsafe string? CSN {
			get {
				if (id_getCSN == IntPtr.Zero)
					id_getCSN = JNIEnv.GetMethodID (class_ref, "getCSN", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCSN), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getDebuggableStatus_Api;
#pragma warning disable 0169
		static Delegate GetGetDebuggableStatus_ApiHandler ()
		{
			if (cb_getDebuggableStatus_Api == null)
				cb_getDebuggableStatus_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetDebuggableStatus_Api));
			return cb_getDebuggableStatus_Api;
		}

		static bool n_GetDebuggableStatus_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DebuggableStatus_Api;
		}
#pragma warning restore 0169

		IntPtr id_getDebuggableStatus_Api;
		public unsafe bool DebuggableStatus_Api {
			get {
				if (id_getDebuggableStatus_Api == IntPtr.Zero)
					id_getDebuggableStatus_Api = JNIEnv.GetMethodID (class_ref, "getDebuggableStatus_Api", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getDebuggableStatus_Api);
			}
		}

		static Delegate? cb_getDefaultDataSIM_Api;
#pragma warning disable 0169
		static Delegate GetGetDefaultDataSIM_ApiHandler ()
		{
			if (cb_getDefaultDataSIM_Api == null)
				cb_getDefaultDataSIM_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDefaultDataSIM_Api));
			return cb_getDefaultDataSIM_Api;
		}

		static IntPtr n_GetDefaultDataSIM_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DefaultDataSIM_Api);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultDataSIM_Api;
		public unsafe string? DefaultDataSIM_Api {
			get {
				if (id_getDefaultDataSIM_Api == IntPtr.Zero)
					id_getDefaultDataSIM_Api = JNIEnv.GetMethodID (class_ref, "getDefaultDataSIM_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultDataSIM_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetFirmwareVersionHandler ()
		{
			if (cb_getFirmwareVersion == null)
				cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFirmwareVersion));
			return cb_getFirmwareVersion;
		}

		static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.FirmwareVersion);
		}
#pragma warning restore 0169

		IntPtr id_getFirmwareVersion;
		public unsafe string? FirmwareVersion {
			get {
				if (id_getFirmwareVersion == IntPtr.Zero)
					id_getFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getFirmwareVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirmwareVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getHardwareVersion;
#pragma warning disable 0169
		static Delegate GetGetHardwareVersionHandler ()
		{
			if (cb_getHardwareVersion == null)
				cb_getHardwareVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHardwareVersion));
			return cb_getHardwareVersion;
		}

		static IntPtr n_GetHardwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.HardwareVersion);
		}
#pragma warning restore 0169

		IntPtr id_getHardwareVersion;
		public unsafe string? HardwareVersion {
			get {
				if (id_getHardwareVersion == IntPtr.Zero)
					id_getHardwareVersion = JNIEnv.GetMethodID (class_ref, "getHardwareVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHardwareVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getImei;
#pragma warning disable 0169
		static Delegate GetGetImeiHandler ()
		{
			if (cb_getImei == null)
				cb_getImei = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetImei));
			return cb_getImei;
		}

		static IntPtr n_GetImei (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Imei);
		}
#pragma warning restore 0169

		IntPtr id_getImei;
		public unsafe string? Imei {
			get {
				if (id_getImei == IntPtr.Zero)
					id_getImei = JNIEnv.GetMethodID (class_ref, "getImei", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImei), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_isDebug_Api;
#pragma warning disable 0169
		static Delegate GetIsDebug_ApiHandler ()
		{
			if (cb_isDebug_Api == null)
				cb_isDebug_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsDebug_Api));
			return cb_isDebug_Api;
		}

		static bool n_IsDebug_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsDebug_Api;
		}
#pragma warning restore 0169

		IntPtr id_isDebug_Api;
		public unsafe bool IsDebug_Api {
			get {
				if (id_isDebug_Api == IntPtr.Zero)
					id_isDebug_Api = JNIEnv.GetMethodID (class_ref, "isDebug_Api", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDebug_Api);
			}
		}

		static Delegate? cb_getLastShutdownCause_Api;
#pragma warning disable 0169
		static Delegate GetGetLastShutdownCause_ApiHandler ()
		{
			if (cb_getLastShutdownCause_Api == null)
				cb_getLastShutdownCause_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetLastShutdownCause_Api));
			return cb_getLastShutdownCause_Api;
		}

		static int n_GetLastShutdownCause_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LastShutdownCause_Api;
		}
#pragma warning restore 0169

		IntPtr id_getLastShutdownCause_Api;
		public unsafe int LastShutdownCause_Api {
			get {
				if (id_getLastShutdownCause_Api == IntPtr.Zero)
					id_getLastShutdownCause_Api = JNIEnv.GetMethodID (class_ref, "getLastShutdownCause_Api", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastShutdownCause_Api);
			}
		}

		static Delegate? cb_getLifeInform_Api;
#pragma warning disable 0169
		static Delegate GetGetLifeInform_ApiHandler ()
		{
			if (cb_getLifeInform_Api == null)
				cb_getLifeInform_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLifeInform_Api));
			return cb_getLifeInform_Api;
		}

		static IntPtr n_GetLifeInform_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LifeInform_Api);
		}
#pragma warning restore 0169

		IntPtr id_getLifeInform_Api;
		public unsafe global::Android.OS.Bundle? LifeInform_Api {
			get {
				if (id_getLifeInform_Api == IntPtr.Zero)
					id_getLifeInform_Api = JNIEnv.GetMethodID (class_ref, "getLifeInform_Api", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLifeInform_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getMachineType_Api;
#pragma warning disable 0169
		static Delegate GetGetMachineType_ApiHandler ()
		{
			if (cb_getMachineType_Api == null)
				cb_getMachineType_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMachineType_Api));
			return cb_getMachineType_Api;
		}

		static IntPtr n_GetMachineType_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.MachineType_Api);
		}
#pragma warning restore 0169

		IntPtr id_getMachineType_Api;
		public unsafe string? MachineType_Api {
			get {
				if (id_getMachineType_Api == IntPtr.Zero)
					id_getMachineType_Api = JNIEnv.GetMethodID (class_ref, "getMachineType_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMachineType_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getModuleSupport_Api;
#pragma warning disable 0169
		static Delegate GetGetModuleSupport_ApiHandler ()
		{
			if (cb_getModuleSupport_Api == null)
				cb_getModuleSupport_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetModuleSupport_Api));
			return cb_getModuleSupport_Api;
		}

		static IntPtr n_GetModuleSupport_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ModuleSupport_Api);
		}
#pragma warning restore 0169

		IntPtr id_getModuleSupport_Api;
		public unsafe global::Android.OS.Bundle? ModuleSupport_Api {
			get {
				if (id_getModuleSupport_Api == IntPtr.Zero)
					id_getModuleSupport_Api = JNIEnv.GetMethodID (class_ref, "getModuleSupport_Api", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModuleSupport_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getNtpServer_Api;
#pragma warning disable 0169
		static Delegate GetGetNtpServer_ApiHandler ()
		{
			if (cb_getNtpServer_Api == null)
				cb_getNtpServer_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNtpServer_Api));
			return cb_getNtpServer_Api;
		}

		static IntPtr n_GetNtpServer_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.NtpServer_Api);
		}
#pragma warning restore 0169

		IntPtr id_getNtpServer_Api;
		public unsafe string? NtpServer_Api {
			get {
				if (id_getNtpServer_Api == IntPtr.Zero)
					id_getNtpServer_Api = JNIEnv.GetMethodID (class_ref, "getNtpServer_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNtpServer_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getROMVersion;
#pragma warning disable 0169
		static Delegate GetGetROMVersionHandler ()
		{
			if (cb_getROMVersion == null)
				cb_getROMVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetROMVersion));
			return cb_getROMVersion;
		}

		static IntPtr n_GetROMVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ROMVersion);
		}
#pragma warning restore 0169

		IntPtr id_getROMVersion;
		public unsafe string? ROMVersion {
			get {
				if (id_getROMVersion == IntPtr.Zero)
					id_getROMVersion = JNIEnv.GetMethodID (class_ref, "getROMVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getROMVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getResumeRechargeValue_Api;
#pragma warning disable 0169
		static Delegate GetGetResumeRechargeValue_ApiHandler ()
		{
			if (cb_getResumeRechargeValue_Api == null)
				cb_getResumeRechargeValue_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResumeRechargeValue_Api));
			return cb_getResumeRechargeValue_Api;
		}

		static IntPtr n_GetResumeRechargeValue_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ResumeRechargeValue_Api);
		}
#pragma warning restore 0169

		IntPtr id_getResumeRechargeValue_Api;
		public unsafe string? ResumeRechargeValue_Api {
			get {
				if (id_getResumeRechargeValue_Api == IntPtr.Zero)
					id_getResumeRechargeValue_Api = JNIEnv.GetMethodID (class_ref, "getResumeRechargeValue_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResumeRechargeValue_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getRootCertName_Api;
#pragma warning disable 0169
		static Delegate GetGetRootCertName_ApiHandler ()
		{
			if (cb_getRootCertName_Api == null)
				cb_getRootCertName_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRootCertName_Api));
			return cb_getRootCertName_Api;
		}

		static IntPtr n_GetRootCertName_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.RootCertName_Api);
		}
#pragma warning restore 0169

		IntPtr id_getRootCertName_Api;
		public unsafe string? RootCertName_Api {
			get {
				if (id_getRootCertName_Api == IntPtr.Zero)
					id_getRootCertName_Api = JNIEnv.GetMethodID (class_ref, "getRootCertName_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRootCertName_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getRootCertVersion_Api;
#pragma warning disable 0169
		static Delegate GetGetRootCertVersion_ApiHandler ()
		{
			if (cb_getRootCertVersion_Api == null)
				cb_getRootCertVersion_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRootCertVersion_Api));
			return cb_getRootCertVersion_Api;
		}

		static IntPtr n_GetRootCertVersion_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.RootCertVersion_Api);
		}
#pragma warning restore 0169

		IntPtr id_getRootCertVersion_Api;
		public unsafe string? RootCertVersion_Api {
			get {
				if (id_getRootCertVersion_Api == IntPtr.Zero)
					id_getRootCertVersion_Api = JNIEnv.GetMethodID (class_ref, "getRootCertVersion_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRootCertVersion_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSettingsPWD_Api;
#pragma warning disable 0169
		static Delegate GetGetSettingsPWD_ApiHandler ()
		{
			if (cb_getSettingsPWD_Api == null)
				cb_getSettingsPWD_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSettingsPWD_Api));
			return cb_getSettingsPWD_Api;
		}

		static IntPtr n_GetSettingsPWD_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SettingsPWD_Api);
		}
#pragma warning restore 0169

		IntPtr id_getSettingsPWD_Api;
		public unsafe string? SettingsPWD_Api {
			get {
				if (id_getSettingsPWD_Api == IntPtr.Zero)
					id_getSettingsPWD_Api = JNIEnv.GetMethodID (class_ref, "getSettingsPWD_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSettingsPWD_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSysHWMaintainIntent;
#pragma warning disable 0169
		static Delegate GetGetSysHWMaintainIntentHandler ()
		{
			if (cb_getSysHWMaintainIntent == null)
				cb_getSysHWMaintainIntent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysHWMaintainIntent));
			return cb_getSysHWMaintainIntent;
		}

		static IntPtr n_GetSysHWMaintainIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SysHWMaintainIntent);
		}
#pragma warning restore 0169

		IntPtr id_getSysHWMaintainIntent;
		public unsafe global::Android.Content.Intent? SysHWMaintainIntent {
			get {
				if (id_getSysHWMaintainIntent == IntPtr.Zero)
					id_getSysHWMaintainIntent = JNIEnv.GetMethodID (class_ref, "getSysHWMaintainIntent", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSysHWMaintainIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSysOTAVerison_Api;
#pragma warning disable 0169
		static Delegate GetGetSysOTAVerison_ApiHandler ()
		{
			if (cb_getSysOTAVerison_Api == null)
				cb_getSysOTAVerison_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysOTAVerison_Api));
			return cb_getSysOTAVerison_Api;
		}

		static IntPtr n_GetSysOTAVerison_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SysOTAVerison_Api);
		}
#pragma warning restore 0169

		IntPtr id_getSysOTAVerison_Api;
		public unsafe string? SysOTAVerison_Api {
			get {
				if (id_getSysOTAVerison_Api == IntPtr.Zero)
					id_getSysOTAVerison_Api = JNIEnv.GetMethodID (class_ref, "getSysOTAVerison_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSysOTAVerison_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSysgHWDetectionIntent;
#pragma warning disable 0169
		static Delegate GetGetSysgHWDetectionIntentHandler ()
		{
			if (cb_getSysgHWDetectionIntent == null)
				cb_getSysgHWDetectionIntent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSysgHWDetectionIntent));
			return cb_getSysgHWDetectionIntent;
		}

		static IntPtr n_GetSysgHWDetectionIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SysgHWDetectionIntent);
		}
#pragma warning restore 0169

		IntPtr id_getSysgHWDetectionIntent;
		public unsafe global::Android.Content.Intent? SysgHWDetectionIntent {
			get {
				if (id_getSysgHWDetectionIntent == IntPtr.Zero)
					id_getSysgHWDetectionIntent = JNIEnv.GetMethodID (class_ref, "getSysgHWDetectionIntent", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSysgHWDetectionIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSystemInform_Api;
#pragma warning disable 0169
		static Delegate GetGetSystemInform_ApiHandler ()
		{
			if (cb_getSystemInform_Api == null)
				cb_getSystemInform_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSystemInform_Api));
			return cb_getSystemInform_Api;
		}

		static IntPtr n_GetSystemInform_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SystemInform_Api);
		}
#pragma warning restore 0169

		IntPtr id_getSystemInform_Api;
		public unsafe global::Android.OS.Bundle? SystemInform_Api {
			get {
				if (id_getSystemInform_Api == IntPtr.Zero)
					id_getSystemInform_Api = JNIEnv.GetMethodID (class_ref, "getSystemInform_Api", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSystemInform_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getTimeZone_Api;
#pragma warning disable 0169
		static Delegate GetGetTimeZone_ApiHandler ()
		{
			if (cb_getTimeZone_Api == null)
				cb_getTimeZone_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTimeZone_Api));
			return cb_getTimeZone_Api;
		}

		static IntPtr n_GetTimeZone_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.TimeZone_Api);
		}
#pragma warning restore 0169

		IntPtr id_getTimeZone_Api;
		public unsafe string? TimeZone_Api {
			get {
				if (id_getTimeZone_Api == IntPtr.Zero)
					id_getTimeZone_Api = JNIEnv.GetMethodID (class_ref, "getTimeZone_Api", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeZone_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getUndeletableAppList_Api;
#pragma warning disable 0169
		static Delegate GetGetUndeletableAppList_ApiHandler ()
		{
			if (cb_getUndeletableAppList_Api == null)
				cb_getUndeletableAppList_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetUndeletableAppList_Api));
			return cb_getUndeletableAppList_Api;
		}

		static IntPtr n_GetUndeletableAppList_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UndeletableAppList_Api);
		}
#pragma warning restore 0169

		IntPtr id_getUndeletableAppList_Api;
		public unsafe global::System.Collections.Generic.IList<string>? UndeletableAppList_Api {
			get {
				if (id_getUndeletableAppList_Api == IntPtr.Zero)
					id_getUndeletableAppList_Api = JNIEnv.GetMethodID (class_ref, "getUndeletableAppList_Api", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUndeletableAppList_Api), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ == null)
				cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_));
			return cb_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_;
		}

		static int n_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.BackUpByPackage_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_;
		public unsafe int BackUpByPackage_Api (global::System.Collections.Generic.IList<string>? p0, string? p1)
		{
			if (id_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "BackUpByPackage_Api", "(Ljava/util/List;Ljava/lang/String;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BackUpByPackage_Api_Ljava_util_List_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_Beef_Api_II;
#pragma warning disable 0169
		static Delegate GetBeef_Api_IIHandler ()
		{
			if (cb_Beef_Api_II == null)
				cb_Beef_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_Beef_Api_II));
			return cb_Beef_Api_II;
		}

		static void n_Beef_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Beef_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_Beef_Api_II;
		public unsafe void Beef_Api (int p0, int p1)
		{
			if (id_Beef_Api_II == IntPtr.Zero)
				id_Beef_Api_II = JNIEnv.GetMethodID (class_ref, "Beef_Api", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Beef_Api_II, __args);
		}

		static Delegate? cb_Beep_Api_I;
#pragma warning disable 0169
		static Delegate GetBeep_Api_IHandler ()
		{
			if (cb_Beep_Api_I == null)
				cb_Beep_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Beep_Api_I));
			return cb_Beep_Api_I;
		}

		static void n_Beep_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Beep_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_Beep_Api_I;
		public unsafe void Beep_Api (int p0)
		{
			if (id_Beep_Api_I == IntPtr.Zero)
				id_Beep_Api_I = JNIEnv.GetMethodID (class_ref, "Beep_Api", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Beep_Api_I, __args);
		}

		static Delegate? cb_CheckModuleStatue_Api_I;
#pragma warning disable 0169
		static Delegate GetCheckModuleStatue_Api_IHandler ()
		{
			if (cb_CheckModuleStatue_Api_I == null)
				cb_CheckModuleStatue_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_CheckModuleStatue_Api_I));
			return cb_CheckModuleStatue_Api_I;
		}

		static int n_CheckModuleStatue_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CheckModuleStatue_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_CheckModuleStatue_Api_I;
		public unsafe int CheckModuleStatue_Api (int p0)
		{
			if (id_CheckModuleStatue_Api_I == IntPtr.Zero)
				id_CheckModuleStatue_Api_I = JNIEnv.GetMethodID (class_ref, "CheckModuleStatue_Api", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_CheckModuleStatue_Api_I, __args);
		}

		static Delegate? cb_GateClose_Api;
#pragma warning disable 0169
		static Delegate GetGateClose_ApiHandler ()
		{
			if (cb_GateClose_Api == null)
				cb_GateClose_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GateClose_Api));
			return cb_GateClose_Api;
		}

		static int n_GateClose_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GateClose_Api ();
		}
#pragma warning restore 0169

		IntPtr id_GateClose_Api;
		public unsafe int GateClose_Api ()
		{
			if (id_GateClose_Api == IntPtr.Zero)
				id_GateClose_Api = JNIEnv.GetMethodID (class_ref, "GateClose_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GateClose_Api);
		}

		static Delegate? cb_GateOpen_Api;
#pragma warning disable 0169
		static Delegate GetGateOpen_ApiHandler ()
		{
			if (cb_GateOpen_Api == null)
				cb_GateOpen_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GateOpen_Api));
			return cb_GateOpen_Api;
		}

		static int n_GateOpen_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GateOpen_Api ();
		}
#pragma warning restore 0169

		IntPtr id_GateOpen_Api;
		public unsafe int GateOpen_Api ()
		{
			if (id_GateOpen_Api == IntPtr.Zero)
				id_GateOpen_Api = JNIEnv.GetMethodID (class_ref, "GateOpen_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GateOpen_Api);
		}

		static Delegate? cb_GetVersion_Api_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetVersion_Api_arrayBarrayBHandler ()
		{
			if (cb_GetVersion_Api_arrayBarrayB == null)
				cb_GetVersion_Api_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_GetVersion_Api_arrayBarrayB));
			return cb_GetVersion_Api_arrayBarrayB;
		}

		static int n_GetVersion_Api_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetVersion_Api (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_GetVersion_Api_arrayBarrayB;
		public unsafe int GetVersion_Api (byte[]? p0, byte[]? p1)
		{
			if (id_GetVersion_Api_arrayBarrayB == IntPtr.Zero)
				id_GetVersion_Api_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "GetVersion_Api", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetVersion_Api_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_IsHandleOnBase_Api;
#pragma warning disable 0169
		static Delegate GetIsHandleOnBase_ApiHandler ()
		{
			if (cb_IsHandleOnBase_Api == null)
				cb_IsHandleOnBase_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_IsHandleOnBase_Api));
			return cb_IsHandleOnBase_Api;
		}

		static int n_IsHandleOnBase_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsHandleOnBase_Api ();
		}
#pragma warning restore 0169

		IntPtr id_IsHandleOnBase_Api;
		public unsafe int IsHandleOnBase_Api ()
		{
			if (id_IsHandleOnBase_Api == IntPtr.Zero)
				id_IsHandleOnBase_Api = JNIEnv.GetMethodID (class_ref, "IsHandleOnBase_Api", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_IsHandleOnBase_Api);
		}

		static Delegate? cb_ReadPosSn;
#pragma warning disable 0169
		static Delegate GetReadPosSnHandler ()
		{
			if (cb_ReadPosSn == null)
				cb_ReadPosSn = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ReadPosSn));
			return cb_ReadPosSn;
		}

		static IntPtr n_ReadPosSn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ReadPosSn ());
		}
#pragma warning restore 0169

		IntPtr id_ReadPosSn;
		public unsafe string? ReadPosSn ()
		{
			if (id_ReadPosSn == IntPtr.Zero)
				id_ReadPosSn = JNIEnv.GetMethodID (class_ref, "ReadPosSn", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ReadPosSn), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_RestoreDatda_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRestoreDatda_Api_Ljava_lang_String_Handler ()
		{
			if (cb_RestoreDatda_Api_Ljava_lang_String_ == null)
				cb_RestoreDatda_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_RestoreDatda_Api_Ljava_lang_String_));
			return cb_RestoreDatda_Api_Ljava_lang_String_;
		}

		static int n_RestoreDatda_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RestoreDatda_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_RestoreDatda_Api_Ljava_lang_String_;
		public unsafe int RestoreDatda_Api (string? p0)
		{
			if (id_RestoreDatda_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_RestoreDatda_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "RestoreDatda_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_RestoreDatda_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_RestoreFactory_Api_Z;
#pragma warning disable 0169
		static Delegate GetRestoreFactory_Api_ZHandler ()
		{
			if (cb_RestoreFactory_Api_Z == null)
				cb_RestoreFactory_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_RestoreFactory_Api_Z));
			return cb_RestoreFactory_Api_Z;
		}

		static void n_RestoreFactory_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.RestoreFactory_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_RestoreFactory_Api_Z;
		public unsafe void RestoreFactory_Api (bool p0)
		{
			if (id_RestoreFactory_Api_Z == IntPtr.Zero)
				id_RestoreFactory_Api_Z = JNIEnv.GetMethodID (class_ref, "RestoreFactory_Api", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RestoreFactory_Api_Z, __args);
		}

		static Delegate? cb_SetAdbEnable_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetAdbEnable_Api_ZHandler ()
		{
			if (cb_SetAdbEnable_Api_Z == null)
				cb_SetAdbEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAdbEnable_Api_Z));
			return cb_SetAdbEnable_Api_Z;
		}

		static bool n_SetAdbEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetAdbEnable_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_SetAdbEnable_Api_Z;
		public unsafe bool SetAdbEnable_Api (bool p0)
		{
			if (id_SetAdbEnable_Api_Z == IntPtr.Zero)
				id_SetAdbEnable_Api_Z = JNIEnv.GetMethodID (class_ref, "SetAdbEnable_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetAdbEnable_Api_Z, __args);
		}

		static Delegate? cb_SetBaseBroadcast_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetBaseBroadcast_Api_ZHandler ()
		{
			if (cb_SetBaseBroadcast_Api_Z == null)
				cb_SetBaseBroadcast_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetBaseBroadcast_Api_Z));
			return cb_SetBaseBroadcast_Api_Z;
		}

		static void n_SetBaseBroadcast_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetBaseBroadcast_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_SetBaseBroadcast_Api_Z;
		public unsafe void SetBaseBroadcast_Api (bool p0)
		{
			if (id_SetBaseBroadcast_Api_Z == IntPtr.Zero)
				id_SetBaseBroadcast_Api_Z = JNIEnv.GetMethodID (class_ref, "SetBaseBroadcast_Api", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetBaseBroadcast_Api_Z, __args);
		}

		static Delegate? cb_SetBluetoothEnable_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetBluetoothEnable_Api_ZHandler ()
		{
			if (cb_SetBluetoothEnable_Api_Z == null)
				cb_SetBluetoothEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetBluetoothEnable_Api_Z));
			return cb_SetBluetoothEnable_Api_Z;
		}

		static bool n_SetBluetoothEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetBluetoothEnable_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_SetBluetoothEnable_Api_Z;
		public unsafe bool SetBluetoothEnable_Api (bool p0)
		{
			if (id_SetBluetoothEnable_Api_Z == IntPtr.Zero)
				id_SetBluetoothEnable_Api_Z = JNIEnv.GetMethodID (class_ref, "SetBluetoothEnable_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetBluetoothEnable_Api_Z, __args);
		}

		static Delegate? cb_SetOtgEnable_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetOtgEnable_Api_ZHandler ()
		{
			if (cb_SetOtgEnable_Api_Z == null)
				cb_SetOtgEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetOtgEnable_Api_Z));
			return cb_SetOtgEnable_Api_Z;
		}

		static bool n_SetOtgEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetOtgEnable_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_SetOtgEnable_Api_Z;
		public unsafe bool SetOtgEnable_Api (bool p0)
		{
			if (id_SetOtgEnable_Api_Z == IntPtr.Zero)
				id_SetOtgEnable_Api_Z = JNIEnv.GetMethodID (class_ref, "SetOtgEnable_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetOtgEnable_Api_Z, __args);
		}

		static Delegate? cb_SetSetScreenOffTimeout_Api_I;
#pragma warning disable 0169
		static Delegate GetSetSetScreenOffTimeout_Api_IHandler ()
		{
			if (cb_SetSetScreenOffTimeout_Api_I == null)
				cb_SetSetScreenOffTimeout_Api_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_SetSetScreenOffTimeout_Api_I));
			return cb_SetSetScreenOffTimeout_Api_I;
		}

		static bool n_SetSetScreenOffTimeout_Api_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetSetScreenOffTimeout_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_SetSetScreenOffTimeout_Api_I;
		public unsafe bool SetSetScreenOffTimeout_Api (int p0)
		{
			if (id_SetSetScreenOffTimeout_Api_I == IntPtr.Zero)
				id_SetSetScreenOffTimeout_Api_I = JNIEnv.GetMethodID (class_ref, "SetSetScreenOffTimeout_Api", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetSetScreenOffTimeout_Api_I, __args);
		}

		static Delegate? cb_SetTime_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTime_Api_Ljava_lang_String_Handler ()
		{
			if (cb_SetTime_Api_Ljava_lang_String_ == null)
				cb_SetTime_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetTime_Api_Ljava_lang_String_));
			return cb_SetTime_Api_Ljava_lang_String_;
		}

		static int n_SetTime_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetTime_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_SetTime_Api_Ljava_lang_String_;
		public unsafe int SetTime_Api (string? p0)
		{
			if (id_SetTime_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_SetTime_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetTime_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SetTime_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_SetWifiAddNetworkEnable_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetWifiAddNetworkEnable_Api_ZHandler ()
		{
			if (cb_SetWifiAddNetworkEnable_Api_Z == null)
				cb_SetWifiAddNetworkEnable_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetWifiAddNetworkEnable_Api_Z));
			return cb_SetWifiAddNetworkEnable_Api_Z;
		}

		static bool n_SetWifiAddNetworkEnable_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetWifiAddNetworkEnable_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_SetWifiAddNetworkEnable_Api_Z;
		public unsafe bool SetWifiAddNetworkEnable_Api (bool p0)
		{
			if (id_SetWifiAddNetworkEnable_Api_Z == IntPtr.Zero)
				id_SetWifiAddNetworkEnable_Api_Z = JNIEnv.GetMethodID (class_ref, "SetWifiAddNetworkEnable_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetWifiAddNetworkEnable_Api_Z, __args);
		}

		static Delegate? cb_SystemPowerOff_Api;
#pragma warning disable 0169
		static Delegate GetSystemPowerOff_ApiHandler ()
		{
			if (cb_SystemPowerOff_Api == null)
				cb_SystemPowerOff_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SystemPowerOff_Api));
			return cb_SystemPowerOff_Api;
		}

		static void n_SystemPowerOff_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SystemPowerOff_Api ();
		}
#pragma warning restore 0169

		IntPtr id_SystemPowerOff_Api;
		public unsafe void SystemPowerOff_Api ()
		{
			if (id_SystemPowerOff_Api == IntPtr.Zero)
				id_SystemPowerOff_Api = JNIEnv.GetMethodID (class_ref, "SystemPowerOff_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SystemPowerOff_Api);
		}

		static Delegate? cb_SystemReboot_Api;
#pragma warning disable 0169
		static Delegate GetSystemReboot_ApiHandler ()
		{
			if (cb_SystemReboot_Api == null)
				cb_SystemReboot_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SystemReboot_Api));
			return cb_SystemReboot_Api;
		}

		static void n_SystemReboot_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SystemReboot_Api ();
		}
#pragma warning restore 0169

		IntPtr id_SystemReboot_Api;
		public unsafe void SystemReboot_Api ()
		{
			if (id_SystemReboot_Api == IntPtr.Zero)
				id_SystemReboot_Api = JNIEnv.GetMethodID (class_ref, "SystemReboot_Api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SystemReboot_Api);
		}

		static Delegate? cb_catchMainLog_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCatchMainLog_Api_Ljava_lang_String_Handler ()
		{
			if (cb_catchMainLog_Api_Ljava_lang_String_ == null)
				cb_catchMainLog_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_CatchMainLog_Api_Ljava_lang_String_));
			return cb_catchMainLog_Api_Ljava_lang_String_;
		}

		static bool n_CatchMainLog_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CatchMainLog_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_catchMainLog_Api_Ljava_lang_String_;
		public unsafe bool CatchMainLog_Api (string? p0)
		{
			if (id_catchMainLog_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_catchMainLog_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "catchMainLog_Api", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_catchMainLog_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_deleteFileInSe_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFileInSe_Api_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFileInSe_Api_Ljava_lang_String_ == null)
				cb_deleteFileInSe_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_DeleteFileInSe_Api_Ljava_lang_String_));
			return cb_deleteFileInSe_Api_Ljava_lang_String_;
		}

		static int n_DeleteFileInSe_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteFileInSe_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deleteFileInSe_Api_Ljava_lang_String_;
		public unsafe int DeleteFileInSe_Api (string? p0)
		{
			if (id_deleteFileInSe_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteFileInSe_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteFileInSe_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteFileInSe_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_deleteFlashData_Api_II;
#pragma warning disable 0169
		static Delegate GetDeleteFlashData_Api_IIHandler ()
		{
			if (cb_deleteFlashData_Api_II == null)
				cb_deleteFlashData_Api_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_DeleteFlashData_Api_II));
			return cb_deleteFlashData_Api_II;
		}

		static int n_DeleteFlashData_Api_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DeleteFlashData_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_deleteFlashData_Api_II;
		public unsafe int DeleteFlashData_Api (int p0, int p1)
		{
			if (id_deleteFlashData_Api_II == IntPtr.Zero)
				id_deleteFlashData_Api_II = JNIEnv.GetMethodID (class_ref, "deleteFlashData_Api", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteFlashData_Api_II, __args);
		}

		static Delegate? cb_deleteRsakey_Api;
#pragma warning disable 0169
		static Delegate GetDeleteRsakey_ApiHandler ()
		{
			if (cb_deleteRsakey_Api == null)
				cb_deleteRsakey_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_DeleteRsakey_Api));
			return cb_deleteRsakey_Api;
		}

		static bool n_DeleteRsakey_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DeleteRsakey_Api ();
		}
#pragma warning restore 0169

		IntPtr id_deleteRsakey_Api;
		public unsafe bool DeleteRsakey_Api ()
		{
			if (id_deleteRsakey_Api == IntPtr.Zero)
				id_deleteRsakey_Api = JNIEnv.GetMethodID (class_ref, "deleteRsakey_Api", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteRsakey_Api);
		}

		static Delegate? cb_getFileListInSe_Api_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetFileListInSe_Api_Ljava_util_List_Handler ()
		{
			if (cb_getFileListInSe_Api_Ljava_util_List_ == null)
				cb_getFileListInSe_Api_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetFileListInSe_Api_Ljava_util_List_));
			return cb_getFileListInSe_Api_Ljava_util_List_;
		}

		static int n_GetFileListInSe_Api_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetFileListInSe_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFileListInSe_Api_Ljava_util_List_;
		public unsafe int GetFileListInSe_Api (global::System.Collections.Generic.IList<string>? p0)
		{
			if (id_getFileListInSe_Api_Ljava_util_List_ == IntPtr.Zero)
				id_getFileListInSe_Api_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getFileListInSe_Api", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFileListInSe_Api_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_getSmartPosID_arrayB;
#pragma warning disable 0169
		static Delegate GetGetSmartPosID_arrayBHandler ()
		{
			if (cb_getSmartPosID_arrayB == null)
				cb_getSmartPosID_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetSmartPosID_arrayB));
			return cb_getSmartPosID_arrayB;
		}

		static int n_GetSmartPosID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetSmartPosID (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSmartPosID_arrayB;
		public unsafe int GetSmartPosID (byte[]? p0)
		{
			if (id_getSmartPosID_arrayB == IntPtr.Zero)
				id_getSmartPosID_arrayB = JNIEnv.GetMethodID (class_ref, "getSmartPosID", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSmartPosID_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_));
			return cb_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTrafficStats_Api (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats? GetTrafficStats_Api (string? p0, string? p1)
		{
			if (id_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTrafficStats_Api", "(Ljava/lang/String;Ljava/lang/String;)Lcom/vanstone/appsdk/api/struct/AidlTrafficStats;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Struct.AidlTrafficStats> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrafficStats_Api_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_isForeground_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsForeground_Api_Ljava_lang_String_Handler ()
		{
			if (cb_isForeground_Api_Ljava_lang_String_ == null)
				cb_isForeground_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsForeground_Api_Ljava_lang_String_));
			return cb_isForeground_Api_Ljava_lang_String_;
		}

		static bool n_IsForeground_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsForeground_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isForeground_Api_Ljava_lang_String_;
		public unsafe bool IsForeground_Api (string? p0)
		{
			if (id_isForeground_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_isForeground_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isForeground_Api", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isForeground_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_isdeviceEnabled_Api;
#pragma warning disable 0169
		static Delegate GetIsdeviceEnabled_ApiHandler ()
		{
			if (cb_isdeviceEnabled_Api == null)
				cb_isdeviceEnabled_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsdeviceEnabled_Api));
			return cb_isdeviceEnabled_Api;
		}

		static bool n_IsdeviceEnabled_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsdeviceEnabled_Api ();
		}
#pragma warning restore 0169

		IntPtr id_isdeviceEnabled_Api;
		public unsafe bool IsdeviceEnabled_Api ()
		{
			if (id_isdeviceEnabled_Api == IntPtr.Zero)
				id_isdeviceEnabled_Api = JNIEnv.GetMethodID (class_ref, "isdeviceEnabled_Api", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isdeviceEnabled_Api);
		}

		static Delegate? cb_readFileFromSE_Api_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
		static Delegate GetReadFileFromSE_Api_Ljava_lang_String_arrayBIIHandler ()
		{
			if (cb_readFileFromSE_Api_Ljava_lang_String_arrayBII == null)
				cb_readFileFromSE_Api_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_I (n_ReadFileFromSE_Api_Ljava_lang_String_arrayBII));
			return cb_readFileFromSE_Api_Ljava_lang_String_arrayBII;
		}

		static int n_ReadFileFromSE_Api_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadFileFromSE_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readFileFromSE_Api_Ljava_lang_String_arrayBII;
		public unsafe int ReadFileFromSE_Api (string? p0, byte[]? p1, int p2, int p3)
		{
			if (id_readFileFromSE_Api_Ljava_lang_String_arrayBII == IntPtr.Zero)
				id_readFileFromSE_Api_Ljava_lang_String_arrayBII = JNIEnv.GetMethodID (class_ref, "readFileFromSE_Api", "(Ljava/lang/String;[BII)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readFileFromSE_Api_Ljava_lang_String_arrayBII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_readFlashData_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetReadFlashData_Api_IarrayBHandler ()
		{
			if (cb_readFlashData_Api_IarrayB == null)
				cb_readFlashData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_ReadFlashData_Api_IarrayB));
			return cb_readFlashData_Api_IarrayB;
		}

		static int n_ReadFlashData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadFlashData_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readFlashData_Api_IarrayB;
		public unsafe int ReadFlashData_Api (int p0, byte[]? p1)
		{
			if (id_readFlashData_Api_IarrayB == IntPtr.Zero)
				id_readFlashData_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "readFlashData_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readFlashData_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_readNvRamFile_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetReadNvRamFile_Api_IarrayBIHandler ()
		{
			if (cb_readNvRamFile_Api_IarrayBI == null)
				cb_readNvRamFile_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_ReadNvRamFile_Api_IarrayBI));
			return cb_readNvRamFile_Api_IarrayBI;
		}

		static int n_ReadNvRamFile_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadNvRamFile_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readNvRamFile_Api_IarrayBI;
		public unsafe int ReadNvRamFile_Api (int p0, byte[]? p1, int p2)
		{
			if (id_readNvRamFile_Api_IarrayBI == IntPtr.Zero)
				id_readNvRamFile_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "readNvRamFile_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readNvRamFile_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_readRsaKey_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetReadRsaKey_Api_arrayBHandler ()
		{
			if (cb_readRsaKey_Api_arrayB == null)
				cb_readRsaKey_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_ReadRsaKey_Api_arrayB));
			return cb_readRsaKey_Api_arrayB;
		}

		static int n_ReadRsaKey_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadRsaKey_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readRsaKey_Api_arrayB;
		public unsafe int ReadRsaKey_Api (byte[]? p0)
		{
			if (id_readRsaKey_Api_arrayB == IntPtr.Zero)
				id_readRsaKey_Api_arrayB = JNIEnv.GetMethodID (class_ref, "readRsaKey_Api", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readRsaKey_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
#pragma warning disable 0169
		static Delegate GetRegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler ()
		{
			if (cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == null)
				cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_RegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_));
			return cb_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
		}

		static bool n_RegisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterTouchListener_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
		public unsafe bool RegisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0)
		{
			if (id_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == IntPtr.Zero)
				id_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNIEnv.GetMethodID (class_ref, "registerTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_registerTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_setAdminPassword_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdminPassword_Api_Ljava_lang_String_Handler ()
		{
			if (cb_setAdminPassword_Api_Ljava_lang_String_ == null)
				cb_setAdminPassword_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetAdminPassword_Api_Ljava_lang_String_));
			return cb_setAdminPassword_Api_Ljava_lang_String_;
		}

		static int n_SetAdminPassword_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetAdminPassword_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setAdminPassword_Api_Ljava_lang_String_;
		public unsafe int SetAdminPassword_Api (string? p0)
		{
			if (id_setAdminPassword_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_setAdminPassword_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdminPassword_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setAdminPassword_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_setApplicationType_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetApplicationType_Api_ZHandler ()
		{
			if (cb_setApplicationType_Api_Z == null)
				cb_setApplicationType_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetApplicationType_Api_Z));
			return cb_setApplicationType_Api_Z;
		}

		static void n_SetApplicationType_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetApplicationType_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_setApplicationType_Api_Z;
		public unsafe void SetApplicationType_Api (bool p0)
		{
			if (id_setApplicationType_Api_Z == IntPtr.Zero)
				id_setApplicationType_Api_Z = JNIEnv.GetMethodID (class_ref, "setApplicationType_Api", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationType_Api_Z, __args);
		}

		static Delegate? cb_setAutoTimeZone_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoTimeZone_Api_ZHandler ()
		{
			if (cb_setAutoTimeZone_Api_Z == null)
				cb_setAutoTimeZone_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAutoTimeZone_Api_Z));
			return cb_setAutoTimeZone_Api_Z;
		}

		static bool n_SetAutoTimeZone_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetAutoTimeZone_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAutoTimeZone_Api_Z;
		public unsafe bool SetAutoTimeZone_Api (bool p0)
		{
			if (id_setAutoTimeZone_Api_Z == IntPtr.Zero)
				id_setAutoTimeZone_Api_Z = JNIEnv.GetMethodID (class_ref, "setAutoTimeZone_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setAutoTimeZone_Api_Z, __args);
		}

		static Delegate? cb_setAutoTime_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoTime_Api_ZHandler ()
		{
			if (cb_setAutoTime_Api_Z == null)
				cb_setAutoTime_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetAutoTime_Api_Z));
			return cb_setAutoTime_Api_Z;
		}

		static bool n_SetAutoTime_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetAutoTime_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAutoTime_Api_Z;
		public unsafe bool SetAutoTime_Api (bool p0)
		{
			if (id_setAutoTime_Api_Z == IntPtr.Zero)
				id_setAutoTime_Api_Z = JNIEnv.GetMethodID (class_ref, "setAutoTime_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setAutoTime_Api_Z, __args);
		}

		static Delegate? cb_setDataEnabled_Api_Z;
#pragma warning disable 0169
		static Delegate GetSetDataEnabled_Api_ZHandler ()
		{
			if (cb_setDataEnabled_Api_Z == null)
				cb_setDataEnabled_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SetDataEnabled_Api_Z));
			return cb_setDataEnabled_Api_Z;
		}

		static bool n_SetDataEnabled_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetDataEnabled_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDataEnabled_Api_Z;
		public unsafe bool SetDataEnabled_Api (bool p0)
		{
			if (id_setDataEnabled_Api_Z == IntPtr.Zero)
				id_setDataEnabled_Api_Z = JNIEnv.GetMethodID (class_ref, "setDataEnabled_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setDataEnabled_Api_Z, __args);
		}

		static Delegate? cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_SetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_));
			return cb_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SetLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetLauncherApp_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool SetLauncherApp_Api (string? p0, string? p1)
		{
			if (id_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLauncherApp_Api", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setLauncherApp_Api_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_setNtpServer_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNtpServer_Api_Ljava_lang_String_Handler ()
		{
			if (cb_setNtpServer_Api_Ljava_lang_String_ == null)
				cb_setNtpServer_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetNtpServer_Api_Ljava_lang_String_));
			return cb_setNtpServer_Api_Ljava_lang_String_;
		}

		static bool n_SetNtpServer_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetNtpServer_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setNtpServer_Api_Ljava_lang_String_;
		public unsafe bool SetNtpServer_Api (string? p0)
		{
			if (id_setNtpServer_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_setNtpServer_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNtpServer_Api", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setNtpServer_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_setResumeRechargeValue_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResumeRechargeValue_Api_Ljava_lang_String_Handler ()
		{
			if (cb_setResumeRechargeValue_Api_Ljava_lang_String_ == null)
				cb_setResumeRechargeValue_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetResumeRechargeValue_Api_Ljava_lang_String_));
			return cb_setResumeRechargeValue_Api_Ljava_lang_String_;
		}

		static bool n_SetResumeRechargeValue_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetResumeRechargeValue_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setResumeRechargeValue_Api_Ljava_lang_String_;
		public unsafe bool SetResumeRechargeValue_Api (string? p0)
		{
			if (id_setResumeRechargeValue_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_setResumeRechargeValue_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResumeRechargeValue_Api", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setResumeRechargeValue_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_setSettingsPWD_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSettingsPWD_Api_Ljava_lang_String_Handler ()
		{
			if (cb_setSettingsPWD_Api_Ljava_lang_String_ == null)
				cb_setSettingsPWD_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetSettingsPWD_Api_Ljava_lang_String_));
			return cb_setSettingsPWD_Api_Ljava_lang_String_;
		}

		static int n_SetSettingsPWD_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetSettingsPWD_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setSettingsPWD_Api_Ljava_lang_String_;
		public unsafe int SetSettingsPWD_Api (string? p0)
		{
			if (id_setSettingsPWD_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_setSettingsPWD_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSettingsPWD_Api", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setSettingsPWD_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_setSgnCheckEnable_Api_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSgnCheckEnable_Api_ZLjava_lang_String_Handler ()
		{
			if (cb_setSgnCheckEnable_Api_ZLjava_lang_String_ == null)
				cb_setSgnCheckEnable_Api_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZL_I (n_SetSgnCheckEnable_Api_ZLjava_lang_String_));
			return cb_setSgnCheckEnable_Api_ZLjava_lang_String_;
		}

		static int n_SetSgnCheckEnable_Api_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetSgnCheckEnable_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setSgnCheckEnable_Api_ZLjava_lang_String_;
		public unsafe int SetSgnCheckEnable_Api (bool p0, string? p1)
		{
			if (id_setSgnCheckEnable_Api_ZLjava_lang_String_ == IntPtr.Zero)
				id_setSgnCheckEnable_Api_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSgnCheckEnable_Api", "(ZLjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setSgnCheckEnable_Api_ZLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_setSmartPosID_arrayB;
#pragma warning disable 0169
		static Delegate GetSetSmartPosID_arrayBHandler ()
		{
			if (cb_setSmartPosID_arrayB == null)
				cb_setSmartPosID_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_SetSmartPosID_arrayB));
			return cb_setSmartPosID_arrayB;
		}

		static int n_SetSmartPosID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SetSmartPosID (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setSmartPosID_arrayB;
		public unsafe int SetSmartPosID (byte[]? p0)
		{
			if (id_setSmartPosID_arrayB == IntPtr.Zero)
				id_setSmartPosID_arrayB = JNIEnv.GetMethodID (class_ref, "setSmartPosID", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setSmartPosID_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_setSystemFunction_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetSystemFunction_Landroid_os_Bundle_Handler ()
		{
			if (cb_setSystemFunction_Landroid_os_Bundle_ == null)
				cb_setSystemFunction_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetSystemFunction_Landroid_os_Bundle_));
			return cb_setSystemFunction_Landroid_os_Bundle_;
		}

		static bool n_SetSystemFunction_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSystemFunction (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setSystemFunction_Landroid_os_Bundle_;
		public unsafe bool SetSystemFunction (global::Android.OS.Bundle? p0)
		{
			if (id_setSystemFunction_Landroid_os_Bundle_ == IntPtr.Zero)
				id_setSystemFunction_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setSystemFunction", "(Landroid/os/Bundle;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSystemFunction_Landroid_os_Bundle_, __args);
			return __ret;
		}

		static Delegate? cb_setTimeZone_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTimeZone_Api_Ljava_lang_String_Handler ()
		{
			if (cb_setTimeZone_Api_Ljava_lang_String_ == null)
				cb_setTimeZone_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetTimeZone_Api_Ljava_lang_String_));
			return cb_setTimeZone_Api_Ljava_lang_String_;
		}

		static bool n_SetTimeZone_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetTimeZone_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTimeZone_Api_Ljava_lang_String_;
		public unsafe bool SetTimeZone_Api (string? p0)
		{
			if (id_setTimeZone_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_setTimeZone_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTimeZone_Api", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setTimeZone_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrustedBluetoothMAC_Api_Ljava_lang_String_Handler ()
		{
			if (cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_ == null)
				cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_SetTrustedBluetoothMAC_Api_Ljava_lang_String_));
			return cb_setTrustedBluetoothMAC_Api_Ljava_lang_String_;
		}

		static bool n_SetTrustedBluetoothMAC_Api_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetTrustedBluetoothMAC_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTrustedBluetoothMAC_Api_Ljava_lang_String_;
		public unsafe bool SetTrustedBluetoothMAC_Api (string? p0)
		{
			if (id_setTrustedBluetoothMAC_Api_Ljava_lang_String_ == IntPtr.Zero)
				id_setTrustedBluetoothMAC_Api_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrustedBluetoothMAC_Api", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setTrustedBluetoothMAC_Api_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_;
#pragma warning disable 0169
		static Delegate GetSilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_Handler ()
		{
			if (cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ == null)
				cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_SilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_));
			return cb_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_;
		}

		static void n_SilentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SilentInstallApk_Api (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_;
		public unsafe void SilentInstallApk_Api (string? p0, string? p1, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkInstallResultAIDL? p2)
		{
			if (id_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ == IntPtr.Zero)
				id_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_ = JNIEnv.GetMethodID (class_ref, "silentInstallApk_Api", "(Ljava/lang/String;Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkInstallResultAIDL;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_silentInstallApk_Api_Ljava_lang_String_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkInstallResultAIDL_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_;
#pragma warning disable 0169
		static Delegate GetSilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_Handler ()
		{
			if (cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ == null)
				cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_));
			return cb_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_;
		}

		static void n_SilentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SilentUnInstallApk_Api (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_;
		public unsafe void SilentUnInstallApk_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.IApkUnInstallResultAIDL? p1)
		{
			if (id_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ == IntPtr.Zero)
				id_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_ = JNIEnv.GetMethodID (class_ref, "silentUnInstallApk_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/IApkUnInstallResultAIDL;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_silentUnInstallApk_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_IApkUnInstallResultAIDL_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_stopBeep_api;
#pragma warning disable 0169
		static Delegate GetStopBeep_apiHandler ()
		{
			if (cb_stopBeep_api == null)
				cb_stopBeep_api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StopBeep_api));
			return cb_stopBeep_api;
		}

		static void n_StopBeep_api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.StopBeep_api ();
		}
#pragma warning restore 0169

		IntPtr id_stopBeep_api;
		public unsafe void StopBeep_api ()
		{
			if (id_stopBeep_api == IntPtr.Zero)
				id_stopBeep_api = JNIEnv.GetMethodID (class_ref, "stopBeep_api", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopBeep_api);
		}

		static Delegate? cb_stopCatch_Api;
#pragma warning disable 0169
		static Delegate GetStopCatch_ApiHandler ()
		{
			if (cb_stopCatch_Api == null)
				cb_stopCatch_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_StopCatch_Api));
			return cb_stopCatch_Api;
		}

		static bool n_StopCatch_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.StopCatch_Api ();
		}
#pragma warning restore 0169

		IntPtr id_stopCatch_Api;
		public unsafe bool StopCatch_Api ()
		{
			if (id_stopCatch_Api == IntPtr.Zero)
				id_stopCatch_Api = JNIEnv.GetMethodID (class_ref, "stopCatch_Api", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stopCatch_Api);
		}

		static Delegate? cb_switchAppEnable_Api_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSwitchAppEnable_Api_Ljava_lang_String_ZHandler ()
		{
			if (cb_switchAppEnable_Api_Ljava_lang_String_Z == null)
				cb_switchAppEnable_Api_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_Z (n_SwitchAppEnable_Api_Ljava_lang_String_Z));
			return cb_switchAppEnable_Api_Ljava_lang_String_Z;
		}

		static bool n_SwitchAppEnable_Api_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SwitchAppEnable_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_switchAppEnable_Api_Ljava_lang_String_Z;
		public unsafe bool SwitchAppEnable_Api (string? p0, bool p1)
		{
			if (id_switchAppEnable_Api_Ljava_lang_String_Z == IntPtr.Zero)
				id_switchAppEnable_Api_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "switchAppEnable_Api", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_switchAppEnable_Api_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_switchChargeOnRS232_Api_Z;
#pragma warning disable 0169
		static Delegate GetSwitchChargeOnRS232_Api_ZHandler ()
		{
			if (cb_switchChargeOnRS232_Api_Z == null)
				cb_switchChargeOnRS232_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SwitchChargeOnRS232_Api_Z));
			return cb_switchChargeOnRS232_Api_Z;
		}

		static bool n_SwitchChargeOnRS232_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SwitchChargeOnRS232_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_switchChargeOnRS232_Api_Z;
		public unsafe bool SwitchChargeOnRS232_Api (bool p0)
		{
			if (id_switchChargeOnRS232_Api_Z == IntPtr.Zero)
				id_switchChargeOnRS232_Api_Z = JNIEnv.GetMethodID (class_ref, "switchChargeOnRS232_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_switchChargeOnRS232_Api_Z, __args);
		}

		static Delegate? cb_switchDefaultDataSIM_Api;
#pragma warning disable 0169
		static Delegate GetSwitchDefaultDataSIM_ApiHandler ()
		{
			if (cb_switchDefaultDataSIM_Api == null)
				cb_switchDefaultDataSIM_Api = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_SwitchDefaultDataSIM_Api));
			return cb_switchDefaultDataSIM_Api;
		}

		static bool n_SwitchDefaultDataSIM_Api (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SwitchDefaultDataSIM_Api ();
		}
#pragma warning restore 0169

		IntPtr id_switchDefaultDataSIM_Api;
		public unsafe bool SwitchDefaultDataSIM_Api ()
		{
			if (id_switchDefaultDataSIM_Api == IntPtr.Zero)
				id_switchDefaultDataSIM_Api = JNIEnv.GetMethodID (class_ref, "switchDefaultDataSIM_Api", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_switchDefaultDataSIM_Api);
		}

		static Delegate? cb_switchGPS_Api_Z;
#pragma warning disable 0169
		static Delegate GetSwitchGPS_Api_ZHandler ()
		{
			if (cb_switchGPS_Api_Z == null)
				cb_switchGPS_Api_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_Z (n_SwitchGPS_Api_Z));
			return cb_switchGPS_Api_Z;
		}

		static bool n_SwitchGPS_Api_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SwitchGPS_Api (p0);
		}
#pragma warning restore 0169

		IntPtr id_switchGPS_Api_Z;
		public unsafe bool SwitchGPS_Api (bool p0)
		{
			if (id_switchGPS_Api_Z == IntPtr.Zero)
				id_switchGPS_Api_Z = JNIEnv.GetMethodID (class_ref, "switchGPS_Api", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_switchGPS_Api_Z, __args);
		}

		static Delegate? cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
#pragma warning disable 0169
		static Delegate GetUnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_Handler ()
		{
			if (cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == null)
				cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_UnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_));
			return cb_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
		}

		static bool n_UnregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnregisterTouchListener_Api (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_;
		public unsafe bool UnregisterTouchListener_Api (global::Com.Vanstone.Appsdk.Api.Interfaces.IAidlTouchListenerAIDL? p0)
		{
			if (id_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ == IntPtr.Zero)
				id_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_ = JNIEnv.GetMethodID (class_ref, "unregisterTouchListener_Api", "(Lcom/vanstone/appsdk/api/interfaces/IAidlTouchListenerAIDL;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_unregisterTouchListener_Api_Lcom_vanstone_appsdk_api_interfaces_IAidlTouchListenerAIDL_, __args);
			return __ret;
		}

		static Delegate? cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_;
#pragma warning disable 0169
		static Delegate GetUpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_Handler ()
		{
			if (cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ == null)
				cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_UpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_));
			return cb_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_;
		}

		static int n_UpdateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate?)global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateSystem_Api (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_;
		public unsafe int UpdateSystem_Api (string? p0, global::Com.Vanstone.Appsdk.Api.Interfaces.ISystemUpdate? p1)
		{
			if (id_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ == IntPtr.Zero)
				id_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_ = JNIEnv.GetMethodID (class_ref, "updateSystem_Api", "(Ljava/lang/String;Lcom/vanstone/appsdk/api/interfaces/ISystemUpdate;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateSystem_Api_Ljava_lang_String_Lcom_vanstone_appsdk_api_interfaces_ISystemUpdate_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_validatePermission_Z;
#pragma warning disable 0169
		static Delegate GetValidatePermission_ZHandler ()
		{
			if (cb_validatePermission_Z == null)
				cb_validatePermission_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_ValidatePermission_Z));
			return cb_validatePermission_Z;
		}

		static void n_ValidatePermission_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ValidatePermission (p0);
		}
#pragma warning restore 0169

		IntPtr id_validatePermission_Z;
		public unsafe void ValidatePermission (bool p0)
		{
			if (id_validatePermission_Z == IntPtr.Zero)
				id_validatePermission_Z = JNIEnv.GetMethodID (class_ref, "validatePermission", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validatePermission_Z, __args);
		}

		static Delegate? cb_writeFileToSE_Api_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteFileToSE_Api_Ljava_lang_String_arrayBIIHandler ()
		{
			if (cb_writeFileToSE_Api_Ljava_lang_String_arrayBII == null)
				cb_writeFileToSE_Api_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_I (n_WriteFileToSE_Api_Ljava_lang_String_arrayBII));
			return cb_writeFileToSE_Api_Ljava_lang_String_arrayBII;
		}

		static int n_WriteFileToSE_Api_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteFileToSE_Api (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeFileToSE_Api_Ljava_lang_String_arrayBII;
		public unsafe int WriteFileToSE_Api (string? p0, byte[]? p1, int p2, int p3)
		{
			if (id_writeFileToSE_Api_Ljava_lang_String_arrayBII == IntPtr.Zero)
				id_writeFileToSE_Api_Ljava_lang_String_arrayBII = JNIEnv.GetMethodID (class_ref, "writeFileToSE_Api", "(Ljava/lang/String;[BII)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeFileToSE_Api_Ljava_lang_String_arrayBII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_writeFlashData_Api_IarrayB;
#pragma warning disable 0169
		static Delegate GetWriteFlashData_Api_IarrayBHandler ()
		{
			if (cb_writeFlashData_Api_IarrayB == null)
				cb_writeFlashData_Api_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_WriteFlashData_Api_IarrayB));
			return cb_writeFlashData_Api_IarrayB;
		}

		static int n_WriteFlashData_Api_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteFlashData_Api (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeFlashData_Api_IarrayB;
		public unsafe int WriteFlashData_Api (int p0, byte[]? p1)
		{
			if (id_writeFlashData_Api_IarrayB == IntPtr.Zero)
				id_writeFlashData_Api_IarrayB = JNIEnv.GetMethodID (class_ref, "writeFlashData_Api", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeFlashData_Api_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_writeNvRamFile_Api_IarrayBI;
#pragma warning disable 0169
		static Delegate GetWriteNvRamFile_Api_IarrayBIHandler ()
		{
			if (cb_writeNvRamFile_Api_IarrayBI == null)
				cb_writeNvRamFile_Api_IarrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILI_I (n_WriteNvRamFile_Api_IarrayBI));
			return cb_writeNvRamFile_Api_IarrayBI;
		}

		static int n_WriteNvRamFile_Api_IarrayBI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteNvRamFile_Api (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeNvRamFile_Api_IarrayBI;
		public unsafe int WriteNvRamFile_Api (int p0, byte[]? p1, int p2)
		{
			if (id_writeNvRamFile_Api_IarrayBI == IntPtr.Zero)
				id_writeNvRamFile_Api_IarrayBI = JNIEnv.GetMethodID (class_ref, "writeNvRamFile_Api", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeNvRamFile_Api_IarrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_writeRsaKey_Api_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteRsaKey_Api_arrayBHandler ()
		{
			if (cb_writeRsaKey_Api_arrayB == null)
				cb_writeRsaKey_Api_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_WriteRsaKey_Api_arrayB));
			return cb_writeRsaKey_Api_arrayB;
		}

		static bool n_WriteRsaKey_Api_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.WriteRsaKey_Api (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeRsaKey_Api_arrayB;
		public unsafe bool WriteRsaKey_Api (byte[]? p0)
		{
			if (id_writeRsaKey_Api_arrayB == IntPtr.Zero)
				id_writeRsaKey_Api_arrayB = JNIEnv.GetMethodID (class_ref, "writeRsaKey_Api", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_writeRsaKey_Api_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Appsdk.Api.System.ISystemHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
