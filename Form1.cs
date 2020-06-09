using DarkUI.Forms;
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

            UpdateRecent();
            if (Environment.GetCommandLineArgs().Count(file => File.Exists(file) && !file.EndsWith(".exe")) > 0)
            {
                string[] paths = Environment.GetCommandLineArgs().Where(file => File.Exists(file) && !file.EndsWith(".exe")).ToArray();

                if (!RecentFilesFetcher.Contains(paths.First()))
                    RecentFilesFetcher.Append(paths.First());
                UpdateRecent();
                SetFile(paths.First());
            }
        }

        void UpdateRecent()
        {
            OpenRecentItem.DropDownItems.Clear();
            foreach (string path in RecentFilesFetcher.Fetch())
            {
                var item = OpenRecentItem.DropDownItems.Add(Path.GetFileName(path));
                item.Tag = path;
                item.Image = Properties.Resources.Image_16x;
                item.Click += (e, f) =>
                {
                    string tag = ((ToolStripItem)e).Tag.ToString();
                    SetFile(tag);
                };
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
            ofd.Filter = FilePatterns.PIXMAPS;
            if (ofd.ShowDialog() != DialogResult.OK) return;

            if (!RecentFilesFetcher.Contains(ofd.FileName))
                RecentFilesFetcher.Append(ofd.FileName);

            UpdateRecent();
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

        private void CopyItem_Click(object sender, EventArgs e)
        {
            if (Preview.Bitmap == null)
                return;

            Clipboard.SetImage(Preview.Bitmap);
        }

        private void PNGItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            Preview.Bitmap.Save(sfd.FileName);
        }

        private void JPEGItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Image|*.jpg;*.jpeg";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            Preview.Bitmap.Save(sfd.FileName);
        }

        private void ImportItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = FilePatterns.IMAGE_FILES_STANDARD;
            if (ofd.ShowDialog() != DialogResult.OK) return;

            var impDialog = new ImportImageDialog(ofd.FileName);
            if (impDialog.ShowDialog() != DialogResult.OK) return;

            this.Text = Path.GetFileNameWithoutExtension(ofd.FileName) + " - PixmapViewer.NET";
            impDialog.ResultingBitmap.Tag = impDialog.ChosenPixmapFormat.ToString();
            Preview.SetBitmap(impDialog.ResultingBitmap);
        }

        private void SaveItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = FilePatterns.PIXMAPS;
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            PixmapFormat format = (PixmapFormat)Enum.Parse(typeof(PixmapFormat), Preview.Bitmap.Tag.ToString());
            File.WriteAllText(sfd.FileName, PBM.ToPBM(Preview.Bitmap, format));
            this.Text = Path.GetFileName(sfd.FileName) + " - PixmapViewer.NET";
        }
    }
}
