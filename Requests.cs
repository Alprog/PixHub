
namespace PixHub
{
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

    public struct SendTextRequest
    {
        public string Command;
        public int TextId;
        public int x;
        public int y;
        public int dir;
        public int font;
        public int TextWidth;
        public string TextString;
        public int speed;
        public string color;
        public HorizontalAlign align;
    }
}
