using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PixHub
{
    internal class Program
    {

        static async Task<PixooDevice> Connect()
        {
            var client = new HttpClient();
            string url = "https://app.divoom-gz.com/Device/ReturnSameLANDevice";
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            string responseText = await responseMessage.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { IncludeFields = true };
            var response = JsonSerializer.Deserialize<FindDeviceResponse>(responseText, options);
            return new PixooDevice(response.DeviceList[0]);
        }

        static async Task Main(string[] args)
        {
            var device = await Connect();


            device.SetBrightness(50);

            device.SendAnimation();
        }

    }
}