using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightek.PBM.FormatProcessors
{
    public class P2FormatProcessor : IFormatProcessor
    {
        public string FormatIdentifier => "P2";

        public string FormatIdentifierLarge => "RGB-0255-1x (P2/.pgm)";

        public void Process(string[] TokensArray, int Offset, Bitmap Bitmap)
        {
            int x = 0;
            int y = 0;
            for (int i = Offset; i < TokensArray.Length; i++)
            {
                if (i - Offset >= Bitmap.Width * Bitmap.Height) continue;
                byte value = byte.Parse(TokensArray[i]);
                Bitmap.SetPixel(x, y, Color.FromArgb(value, value, value));

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
