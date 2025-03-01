using System.Collections.Generic;

namespace PixHub
{
    public struct SimpleResponse
    {
        public int error_code;
    }

    public struct DeviceInfo
    {
        public string DeviceName;
        public int DeviceId;
        public string DevicePrivateIP;
        public string DeviceMac;
    }

    public struct FindDeviceResponse
    {
        public int ReturnCode;
        public string ReturnMessage;
        public List<DeviceInfo> DeviceList;
    }
}
