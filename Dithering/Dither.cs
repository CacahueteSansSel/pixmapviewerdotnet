using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightek.PBM.Dithering
{
    public static class Dither
    {
        public static void ApplyOn(Bitmap Bitmap, PixmapFormat Format)
        {
            if (Format == PixmapFormat.P3) return;

            for (int y = 0; y < Bitmap.Height; y++)
            {
                for (int x = 0; x < Bitmap.Width; x++)
                {
                    Color FromColor = Bitmap.GetPixel(x, y);
                    Color ToColor = ApplyPixel(FromColor, Format);
                    Bitmap.SetPixel(x, y, ToColor);
                }
            }
            Bitmap.Tag = Format.ToString();
        }

        public static Bitmap Apply(Bitmap Bitmap, PixmapFormat Format)
        {
            if (Format == PixmapFormat.P3) return Bitmap;

            Bitmap newBitmap = new Bitmap(Bitmap.Width, Bitmap.Height);
            for (int y = 0; y < Bitmap.Height; y++)
            {
                for (int x = 0; x < Bitmap.Width; x++)
                {
                    Color FromColor = Bitmap.GetPixel(x, y);
                    Color ToColor = ApplyPixel(FromColor, Format);
                    newBitmap.SetPixel(x, y, ToColor);
                }
            }

            newBitmap.Tag = Format.ToString();
            return newBitmap;
        }

        static Color ApplyPixel(Color Color, PixmapFormat Format)
        {
            switch (Format)
            {
                case PixmapFormat.P1:
                    return ApplyPixel_P1(Color);
                case PixmapFormat.P2:
                    return ApplyPixel_P2(Color);
                default:
                    return Color;
            }
        }

        static Color ApplyPixel_P1(Color FromColor)
            => FromColor.GetBrightness() > 0.5f && FromColor.A == 255 ? Color.White : Color.Black;
        static Color ApplyPixel_P2(Color FromColor)
        {
            byte sample = FromColor.A < 255 ? (byte)0 : (byte)(FromColor.GetBrightness() * 255);

            return Color.FromArgb(sample, sample, sample);
        }
    }
}
