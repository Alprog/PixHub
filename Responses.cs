using System.Collections.Generic;

namespace PixHub
{
    public class SimpleResponse
    {
        public int error_code;
    }

    public class DeviceInfo
    {
        public string DeviceName;
        public int DeviceId;
        public string DevicePrivateIP;
        public string DeviceMac;
    }

    public class FindDeviceResponse
    {
        public int ReturnCode;
        public string ReturnMessage;
        public List<DeviceInfo> DeviceList;
    }
}
