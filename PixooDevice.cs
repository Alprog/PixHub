using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PixHub
{
    public class PixooDevice
    {
        public DeviceInfo Info;
        public HttpClient Client;

        public string RequestUrl;
        public int PicID = 1;

        public PixooDevice(DeviceInfo info)
        {
            Info = info;
            RequestUrl = String.Format("http://{0}:80/post", Info.DevicePrivateIP);
            Client = new HttpClient();
        }

        public static JsonSerializerOptions SerializationOptions = new JsonSerializerOptions { IncludeFields = true };


        public async Task PostAsync(Object requestObject)
        {
            var jsonText = JsonSerializer.Serialize(requestObject, SerializationOptions);
            var content = new StringContent(jsonText, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(RequestUrl, content);
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<SimpleResponse>(responseText, SerializationOptions);
        }

        public void Post(Object requestObject)
        {
            PostAsync(requestObject).Wait();
        }

        public void SetBrightness(int value)
        {
            var request = new SetBrightnessRequest
            {
                Brightness = value
            };

            Post(request);
        }

        public void ResetPicId()
        {
            var request = new SimpleRequest
            {
                Command = "Draw/ResetHttpGifId"
            };

            Post(request);
        }

        public void SendImage(Bitmap bitmap)
        {
            var imageSize = bitmap.Size.Width;
            Debug.Assert(imageSize == 16 || imageSize == 32 || imageSize == 64);
            Debug.Assert(imageSize == bitmap.Size.Height);

            var request = new SendAnimationRequest
            {
                PicNum = 1,
                PicWidth = imageSize,
                PicOffset = 0,
                PicID = PicID++,
                PicSpeed = 100,
                PicData = Utils.BitmapToBase64(bitmap)
            };

            Post(request);
        }

        public void SendImage(string filePath)
        {
            var bitmap = new Bitmap(filePath);
            SendImage(bitmap);
        }

        public void SendText(string text)
        {
            var request = new SendTextRequest
            {
                TextId = 4,
                x = 0,
                y = 0,
                dir = 0,
                font = 7,
                TextWidth = 64,
                speed = 1,
                TextString = text,
                color = "#0000FF",
                align = HorizontalAlign.Left
            };

            Post(request);
        }

        public void AddClock()
        {
            var request = new SendItemListRequest();
            request.ItemList = new List<ItemDesc>();
            request.ItemList.Add(new ItemDesc
            {
                TextId = 2,
                type = ItemType.DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_HOUR_MIN_SEC,
                x = 0,
                y = 40,
                dir = 0,
                font = 18,
                TextWidth = 64,
                Textheight = 16,
                speed = 1,
                align = HorizontalAlign.Middle,
                color = "#000000"
            });

            Post(request);
        }
    }
}
