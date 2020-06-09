using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Nightek.PBM.FormatProcessors
{
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
            => processors.Where(proc => proc.FormatIdentifier == Format).FirstOrDefault();
    }
}
