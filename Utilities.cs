using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightek.PBM
{
    public static class Utilities
    {
        public static string RemoveDuplicatedSpaces(string s)
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

        public static void RemoveLineBreaks(string[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].EndsWith(Environment.NewLine))
                    Array[i].Substring(Array[i].Length - Environment.NewLine.Length);
            }
        }
    }
}
