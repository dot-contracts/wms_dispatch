namespace wms_android.shared.Interfaces
{
    public interface IPrinterServiceFactory
    {
        IPrinterService CreatePrinterService(PosDeviceType deviceType);
    }

    public enum PosDeviceType
    {
        Unknown,
        CS30,
        A90
    }
} 