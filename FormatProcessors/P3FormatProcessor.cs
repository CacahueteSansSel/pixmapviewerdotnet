using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightek.PBM.FormatProcessors
{
    public class P3FormatProcessor : IFormatProcessor
    {
        public string FormatIdentifier => "P3";
        public string FormatIdentifierLarge => "RGB-0255-4x (P3/.ppm)";
        public void Process(string[] TokensArray, int Offset, Bitmap Bitmap)
        {
            int x = 0;
            int y = 0;
            for (int i = Offset; i < TokensArray.Length; i += 3)
            {
                if ((i - Offset) / 3 >= Bitmap.Width * Bitmap.Height) continue;
                byte R = byte.Parse(TokensArray[i]);
                byte G = byte.Parse(TokensArray[i + 1]);
                byte B = byte.Parse(TokensArray[i + 2]);
                Bitmap.SetPixel(x, y, Color.FromArgb(R, G, B));

                x++;
                if (x >= Bitmap.Width)
                {
                    y++;
                    x = 0;
                }
            }
        }
    }
}
