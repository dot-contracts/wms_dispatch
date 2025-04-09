namespace wms_android.shared.Interfaces
{
    public interface IDeviceDetectionService
    {
        PosDeviceType DetectDevice();
        string GetDeviceModel();
        string GetDeviceManufacturer();
        string GetDeviceName();
        string GetDeviceVersion();
        string GetDevicePlatform();
    }
} 