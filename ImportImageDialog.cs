using Nightek.PBM.Dithering;
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
    public partial class ImportImageDialog : Form
    {
        public string Filename { get; private set; }

        public Bitmap ResultingBitmap { get; set; }
        public PixmapFormat ChosenPixmapFormat => FormatBox.SelectedIndex < 0 ? PixmapFormat.P3 : (PixmapFormat)FormatBox.SelectedIndex;

        public ImportImageDialog(string DefaultFilename)
        {
            InitializeComponent();

            foreach (var e in Enum.GetValues(typeof(PixmapFormat)))
                FormatBox.Items.Add(e.ToString());
            SetFilename(DefaultFilename);
        }

        void ApplyPreview()
        {
            PreviewBox.Image = Dither.Apply(ResultingBitmap, ChosenPixmapFormat);
            PreviewBox.Refresh();
        }

        public void SetFilename(string Filename)
        {
            ResultingBitmap = (Bitmap)Image.FromFile(Filename);
            PreviewBox.Image = ResultingBitmap;
            ImagePathBox.Text = Filename;
            Text = "Import an image - " + Path.GetFileName(Filename);
            ApplyPreview();
        }

        private void ChangePathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Image|*.jpg;*.jpeg|PNG Image|*.png";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            SetFilename(ofd.FileName);
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            Dither.ApplyOn(ResultingBitmap, ChosenPixmapFormat);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormatBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyPreview();
        }
    }
}
