using DarkUI.Forms;
using Nightek.PBM.FormatProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightek.PBM
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormatProcessor.LoadAll();
            Application.Run(new Form1());
        }
    }
}
