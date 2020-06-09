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
        static string RemoveDuplicatedSpaces(string s)
        {
            string result = "";
            bool WasSpaceBefore = false;

            foreach (char c in s)
            {
                if (c == ' ' && WasSpaceBefore)
                    continue;

                if (c == ' ')
                {
                    WasSpaceBefore = true;
                }

                if (c != ' ')
                    WasSpaceBefore = false;
                result += c;
            }

            return result;
        }

        static void RemoveLineBreaks(string[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].EndsWith(Environment.NewLine))
                    Array[i].Substring(Array[i].Length - Environment.NewLine.Length);
            }
        }

        public static Bitmap ToBitmap(string PBMFilename)
        {
            string fileData = File.ReadAllText(PBMFilename);

            string[] tokens = RemoveDuplicatedSpaces(fileData.Replace((char)13, ' ').Replace("\n", Environment.NewLine).Replace(Environment.NewLine, " ")).Split(' ');

            RemoveLineBreaks(tokens);
            Console.WriteLine(string.Join(";", tokens));

            string format = tokens[0];
            int width = int.Parse(tokens[1]);
            int height = int.Parse(tokens[2]);

            Bitmap bmp = new Bitmap(width, height);

            var proc = FormatProcessor.GetForFormat(format);
            proc.Process(tokens, format == "P1" ? 3 : 4, bmp);
            bmp.Tag = proc.FormatIdentifierLarge;

            return bmp;
        }
    }
}
