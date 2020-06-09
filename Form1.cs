using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightek.PBM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (Environment.GetCommandLineArgs().Count(file => File.Exists(file) && !file.EndsWith(".exe")) > 0)
            {
                string[] paths = Environment.GetCommandLineArgs().Where(file => File.Exists(file) && !file.EndsWith(".exe")).ToArray();

                SetFile(paths.First());
            }
        }

        public void SetFile(string Filename)
        {
            this.Text = Path.GetFileName(Filename) + " - PixmapViewer.NET";
            Preview.SetBitmap(PBM.ToBitmap(Filename));
        }

        private void OpenItemClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Black or white pixmap (0-1/P1)|*.pbm|Grayshade pixmap (0-255/P2)|*.pgm|RGB pixmap (0-255/P3)|*.ppm";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            SetFile(ofd.FileName);
        }

        private void PixelPerfectItem_CheckedChanged(object sender, EventArgs e)
        {
            Preview.PixelPerfect = PixelPerfectItem.Checked;
            Preview.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog();
        }
    }
}
