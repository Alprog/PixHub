
using System.Collections.Generic;

namespace PixHub
{
    public class SimpleRequest
    {
        public string Command;
    }

    public class SetBrightnessRequest
    {
        public string Command = "Channel/SetBrightness";
        public int Brightness;
    }

    public class SetHighLigitMode
    {
        public string Command = "Device/SetHighLightMode";
        public Flag Mode;
    }

    public class SendAnimationRequest
    {
        public string Command = "Draw/SendHttpGif";
        public int PicNum;
        public int PicWidth;
        public int PicOffset;
        public int PicID;
        public int PicSpeed;
        public string PicData;
    }

    public class SendTextRequest
    {
        public string Command = "Draw/SendHttpText";
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

    public class ItemDesc
    {
        public int TextId;
        public ItemType type;
        public int x;
        public int y;
        public int dir;
        public int font;
        public int TextWidth;
        public int Textheight;
        public string TextString;
        public int speed;
        public string color;
        public HorizontalAlign align;
        public int update_time;
    }

    public class SendItemListRequest
    {
        public string Command = "Draw/SendHttpItemList";
        public List<ItemDesc> ItemList;
    }

}
