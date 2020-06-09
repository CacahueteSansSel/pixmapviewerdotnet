using Nightek.PBM.FormatProcessors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightek.PBM
{
    public static class PBM
    {
        public static Bitmap ToBitmap(string PBMFilename)
        {
            string fileData = File.ReadAllText(PBMFilename);
            string[] tokens = Utilities.RemoveDuplicatedSpaces(fileData.Replace((char)13, ' ').Replace("\n", Environment.NewLine).Replace(Environment.NewLine, " ")).Split(' ');

            Utilities.RemoveLineBreaks(tokens);

            string format = tokens[0];
            int width = int.Parse(tokens[1]);
            int height = int.Parse(tokens[2]);

            Bitmap bmp = new Bitmap(width, height);
            var proc = FormatProcessor.GetForFormat(format);
            proc.Process(tokens, format == "P1" ? 3 : 4, bmp);
            bmp.Tag = format;

            return bmp;
        }

        public static string ToPBM(Bitmap Bitmap, PixmapFormat Format)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(Format.ToString());
            builder.AppendLine($"{Bitmap.Width} {Bitmap.Height}");
            if (Format > PixmapFormat.P1)
                builder.AppendLine("255");

            for (int y = 0; y < Bitmap.Height; y++)
            {
                for (int x = 0; x < Bitmap.Width; x++)
                {
                    Color color = Bitmap.GetPixel(x, y);
                    switch (Format)
                    {
                        case PixmapFormat.P1:
                            builder.AppendLine(color.GetBrightness() > 0.5f ? "1" : "0");
                            break;
                        case PixmapFormat.P2:
                            builder.AppendLine((color.GetBrightness() * 255).ToString());
                            break;
                        case PixmapFormat.P3:
                            builder.AppendLine($"{color.R} {color.G} {color.B}");
                            break;
                        case PixmapFormat.P5:
                            //Not supported
                            break;
                        default:
                            break;
                    }
                }
            }

            return builder.ToString();
        }
    }
}
