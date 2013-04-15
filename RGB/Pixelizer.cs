using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RGB
{
    class Pixelizer
    {
        public static int progress;

        public static Bitmap convert(Bitmap input, int pixelSize)
        {
            try
            {
                if (pixelSize == 0) { progress = 100;  return input; }
                Bitmap output = new Bitmap(input.Width * pixelSize, input.Height * pixelSize);
                for (int x = 0; x < output.Width; x++)
                {
                    for (int y = 0; y < output.Height; y++)
                    {
                        if (x / (pixelSize / 3) % 3 == 0)
                            output.SetPixel(x, y, Color.FromArgb(input.GetPixel((x / pixelSize), (y / pixelSize)).A, input.GetPixel((x / pixelSize), (y / pixelSize)).R, 0, 0));
                        if (x / (pixelSize / 3) % 3 == 1)
                            output.SetPixel(x, y, Color.FromArgb(input.GetPixel((x / pixelSize), (y / pixelSize)).A, 0, input.GetPixel(x / pixelSize, y / pixelSize).G, 0));
                        if (x / (pixelSize / 3) % 3 == 2)
                            output.SetPixel(x, y, Color.FromArgb(input.GetPixel((x / pixelSize), (y / pixelSize)).A, 0, 0, input.GetPixel(x / pixelSize, y / pixelSize).B));
                        progress = (int)(1.0 * x / output.Width * 100.0 + 0.5);
                    }
                }
                progress = 100;
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return null;
        }
    }
}
