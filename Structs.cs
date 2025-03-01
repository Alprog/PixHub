
using System.Collections.Generic;

namespace PixHub
{
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

    public struct SimpleRequest
    {
        public string Command;
    }

    public struct SetBrightnessRequest
    {
        public string Command;
        public int Brightness;
    }

    public struct SendAnimationRequest
    {
        public string Command;
        public int PicNum;
        public int PicWidth;
        public int PicOffset;
        public int PicID;
        public int PicSpeed;
        public string PicData;
    }

    public struct RegularResponse
    {
        public int error_code;
    }
}
