using System;
using System.Drawing;

namespace PixHub
{
    internal static class Utils
    {
        public static string BitmapToBase64(Bitmap bitmap)
        {
            int pixelCount = bitmap.Width * bitmap.Height;

            var bytes = new byte[pixelCount * 3];

            int index = 0;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var color = bitmap.GetPixel(x, y);
                    bytes[index++] = color.R;
                    bytes[index++] = color.G;
                    bytes[index++] = color.B;
                }
            }

            return Convert.ToBase64String(bytes);
        }
    }
}
