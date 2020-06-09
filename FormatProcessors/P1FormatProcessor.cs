using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightek.PBM.FormatProcessors
{
    public class P1FormatProcessor : IFormatProcessor
    {
        public string FormatIdentifier => "P1";
        public string FormatIdentifierLarge => "RGB-01 (P1/.pbm)";
        public void Process(string[] TokensArray, int Offset, Bitmap Bitmap)
        {
            int x = 0;
            int y = 0; 
            for (int i = Offset; i < TokensArray.Length; i++)
            {
                if (i - Offset >= Bitmap.Width * Bitmap.Height) continue;
                Bitmap.SetPixel(x, y, TokensArray[i] == "0" ? Color.White : Color.Black);

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
