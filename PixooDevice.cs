using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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


        public async Task Post(Object requestObject)
        {
            var jsonText = JsonSerializer.Serialize(requestObject, SerializationOptions);
            var content = new StringContent(jsonText, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(RequestUrl, content);
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<SimpleResponse>(responseText, SerializationOptions);
        }

        public void SetBrightness(int value)
        {
            var Request = new SetBrightnessRequest
            {
                Command = "Channel/SetBrightness",
                Brightness = value
            };

            var task = Post(Request);
            task.Wait();
        }

        public void ResetPicId()
        {
            var Request = new SimpleRequest
            {
                Command = "Draw/ResetHttpGifId"
            };

            var task = Post(Request);
            task.Wait();
        }

        public void SendImage(Bitmap bitmap)
        {
            var imageSize = bitmap.Size.Width;
            Debug.Assert(imageSize == 16 || imageSize == 32 || imageSize == 64);
            Debug.Assert(imageSize == bitmap.Size.Height);

            var Request = new SendAnimationRequest
            {
                Command = "Draw/SendHttpGif",
                PicNum = 1,
                PicWidth = imageSize,
                PicOffset = 0,
                PicID = PicID++,
                PicSpeed = 100,
                PicData = Utils.BitmapToBase64(bitmap)
            };

            var task = Post(Request);
            task.Wait();
        }

        public void SendImage(string filePath)
        {
            var bitmap = new Bitmap(filePath);
            SendImage(bitmap);
        }

        public void SendText(string text)
        {
            var Request = new SendTextRequest
            {
                Command = "Draw/SendHttpText",
                TextId = 4,
                x = 0,
                y = 0,
                dir = 0,
                font = 4,
                TextWidth = 64,
                speed = 1,
                TextString = text,
                color = "#FFFF00",
                align = HorizontalAlign.Left
            };

            var task = Post(Request);
            task.Wait();
        }
    }
}
