using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nightek.PBM.FormatProcessors
{
    public interface IFormatProcessor
    {
        string FormatIdentifier { get; }
        string FormatIdentifierLarge { get; }
        void Process(string[] TokensArray, int Offset, Bitmap Bitmap);
    }

    public static class FormatProcessor
    {
        static List<IFormatProcessor> processors = new List<IFormatProcessor>();

        public static void LoadAll()
        {
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.GetInterface(nameof(IFormatProcessor)) != null)
                {
                    processors.Add((IFormatProcessor)Activator.CreateInstance(t));
                }
            }
        }

        public static IFormatProcessor GetForFormat(string Format)
        {
            foreach (IFormatProcessor proc in processors)
            {
                if (proc.FormatIdentifier == Format)
                    return proc;
            }
            return null;
        }
    }
}
