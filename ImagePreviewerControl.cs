using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightek.PBM
{
    public partial class ImagePreviewerControl : UserControl
    {
        Rectangle ImageRect;
        public Bitmap Bitmap { get; private set; }
        float ZoomFactor = 1f;
        bool Holding = false;
        Point LastPos;
        Rectangle ImageRectOld;

        public Point MousePosition { get; private set; }
        public Point MousePositionCanvas
            => new Point((int)(ImageRect.X + MousePosition.X / ZoomFactor), (int)(ImageRect.Y + MousePosition.Y / ZoomFactor));
        public bool PixelPerfect { get; set; } = true;

        public ImagePreviewerControl()
        {
            InitializeComponent();

            MouseWheel += EventMouseWheel;
            MouseMove += EventMouseMove;
            MouseDown += (e, f) =>
            {
                ImageRectOld = ImageRect;
                LastPos = f.Location;
                Holding = true;
                Cursor = Cursors.SizeAll;
            };
            MouseUp += (e, f) =>
            {
                Holding = false;
                Cursor = Cursors.Default;
            };

            ImageRect = new Rectangle(0, 0, 320, 240);
            Centerize();
        }

        private void EventMouseMove(object sender, MouseEventArgs e)
        {
            MousePosition = e.Location;
            if (!Holding) return;

            Point delta = new Point(e.X - LastPos.X, e.Y - LastPos.Y);
            Point p = new Point(ImageRectOld.X + delta.X, ImageRectOld.Y + delta.Y);

            ImageRect = new Rectangle(p.X, p.Y, ImageRect.Width, ImageRect.Height);
            Refresh();
        }

        private void EventMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                ZoomFactor -= 0.5f;
            } else if (e.Delta > 0)
            {
                ZoomFactor += 0.5f;
            }
            if (ZoomFactor < 0.1f)
                ZoomFactor = 0.1f;

            Centerize();
            Refresh();
        }

        public void Centerize()
        {
            ImageRect.X = Width / 2 - (int)(ImageRect.Width * ZoomFactor) / 2;
            ImageRect.Y = Height / 2 - (int)(ImageRect.Height * ZoomFactor) / 2;
        }

        public void SetBitmap(Bitmap Bitmap)
        {
            this.Bitmap = Bitmap;
            ImageRect.Width = Bitmap.Width;
            ImageRect.Height = Bitmap.Height;
            ImageRect.X = Width / 2 - Bitmap.Width / 2;
            ImageRect.Y = Height / 2 - Bitmap.Height / 2;

            Refresh();
        }

        string GetDetailsLine()
            => Bitmap == null ? "No image loaded" : ($"{Bitmap.Width}x{Bitmap.Height}" + (Bitmap.Tag is string ? " " + Bitmap.Tag.ToString() : ""));

        private void ImagePreviewerControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            var scaledRect = new Rectangle(ImageRect.X, ImageRect.Y, (int)(ImageRect.Width * ZoomFactor), (int)(ImageRect.Height * ZoomFactor));
            var scaledRectMin = new Rectangle(ImageRect.X, ImageRect.Y, (int)(ImageRect.Width * ZoomFactor), (int)(ImageRect.Height * ZoomFactor));

            if (Bitmap != null)
            {
                if (PixelPerfect)
                {
                    for (int y = 0; y < Bitmap.Height; y++)
                    {
                        for (int x = 0; x < Bitmap.Width; x++)
                        {
                            using (SolidBrush brush = new SolidBrush(Bitmap.GetPixel(x, y)))
                            {
                                e.Graphics.FillRectangle(brush, new RectangleF(ImageRect.X + x * ZoomFactor, ImageRect.Y + y * ZoomFactor, ZoomFactor, ZoomFactor));
                            }
                        }
                    }
                } else
                {
                    e.Graphics.DrawImage(Bitmap, scaledRect);
                }
            }
            e.Graphics.DrawRectangle(Pens.Gray, scaledRectMin);
            e.Graphics.DrawString(GetDetailsLine(), Font, Brushes.White, scaledRect.X, scaledRect.Y - e.Graphics.MeasureString(GetDetailsLine(), Font).Height - 5);
        }
    }
}
