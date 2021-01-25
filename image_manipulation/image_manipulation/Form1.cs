using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_manipulation
{
    public partial class Form1 : Form
    {
        bool isRotated_Left = false;
        bool isRotated_Right = false;
        bool isBlue = false;
        bool isRed = false;
        bool isGreen = false;
        //0 - orginal colours; 1 - RED, 2 - GREEN, 3 - BLUE
        int colours = 0;
        private Bitmap imgOriginal = null;
        string filename = "";

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Open Image";
                dialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
       + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgOriginal = new Bitmap(dialog.FileName);
                    this.pictureBox1.Image = imgOriginal;

                    GC.Collect();

                    foreach(Control ctrl in this.Controls)
                    {
                        this.controlEnabler(ctrl);
                    }
                    this.controlUnchecker();

                    this.colours = 0;
                    isRotated_Left = false;
                    isRotated_Right = false;
                    isBlue = false;
                    isRed = false;
                    isGreen = false;

                    filename = dialog.FileName;
                    this.filenameStrip.Text = string.Format("Plik: {0}", filename);
                }
            }
        }

        private void rotate180Check_CheckedChanged(object sender, EventArgs e)
        {
            imgOriginal.RotateFlip(RotateFlipType.Rotate180FlipNone);
            rgbChanger();
        }

        private void rotate90_leftCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isRotated_Left == false)
            {
                imgOriginal.RotateFlip(RotateFlipType.Rotate270FlipNone);
                this.isRotated_Left = true;
            }
            else
            {
                imgOriginal.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.isRotated_Left = false;
            }
            rgbChanger();
        }

        private void rotate90_rightCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isRotated_Right == false)
            {
                imgOriginal.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.isRotated_Right = true;
            }
            else
            {
                imgOriginal.RotateFlip(RotateFlipType.Rotate270FlipNone);
                this.isRotated_Right = false;
            }
            rgbChanger();
        }

        private void mirrorCheck_CheckedChanged(object sender, EventArgs e)
        {
            imgOriginal.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rgbChanger();
        }

        private void invertCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Visible = true;
            this.toolStripProgressBar1.Minimum = 0;
            this.toolStripProgressBar1.Maximum = imgOriginal.Height;
            this.toolStripProgressBar1.Step = 1;

            for (int y = 0; y < imgOriginal.Height; y++)
            {
                for (int x = 0; x < imgOriginal.Width; x++)
                {
                    Color pixel = imgOriginal.GetPixel(x, y);
                    pixel = Color.FromArgb(255, (255 - pixel.R), (255 - pixel.G), (255 - pixel.B));
                    imgOriginal.SetPixel(x, y, pixel);
                }
                this.toolStripProgressBar1.PerformStep();
            }
            rgbChanger();

            this.toolStripProgressBar1.Value = 0;
            this.toolStripProgressBar1.Visible = false;
            GC.Collect();
        }

        Image Zoom(Image img, Size size)
        {
            try
            {
                Bitmap bmp = new Bitmap(img, (img.Width * size.Width / (trackBar1.Maximum / 2)), (img.Height * size.Height / (trackBar1.Maximum / 2)));
                Graphics g = Graphics.FromImage(bmp);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                // pictureBox1.Image.Dispose();
                return bmp;
            }
            catch(ArgumentException e)
            {
                Bitmap bmp = new Bitmap(img, (img.Width * size.Width / (trackBar1.Maximum / 2)) + 1, (img.Height * size.Height / (trackBar1.Maximum / 2)) + 1);
                return bmp;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                GC.Collect();
                //pictureBox1.Image = null;
                pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var bitmap1 = (Bitmap)this.pictureBox1.Image;
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Save Image";
                dialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
       + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName != "")
                    {
                        System.IO.FileStream stream = (System.IO.FileStream)dialog.OpenFile();
                        switch (dialog.FilterIndex)
                        {
                            case 1:
                                bitmap1.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            case 2:
                                bitmap1.Save(stream, System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                            case 3:
                                bitmap1.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case 4:
                                bitmap1.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case 5:
                                bitmap1.Save(stream, System.Drawing.Imaging.ImageFormat.Tiff);
                                break;
                        }
                        stream.Close();

                    }
                }
            }
        }

        private void controlEnabler (Control control)
        {
            if(control != null)
            {
                control.Enabled = true;
                foreach(Control c in control.Controls)
                {
                    controlEnabler(c);
                }
            }    
        }

        private void controlUnchecker()
        {
            foreach (CheckBox checks in this.actionsBox.Controls.OfType<CheckBox>())
            {
                checks.Checked = false;
            }
        }

        private void rgbChanger()
        {
            this.toolStripProgressBar1.Visible = true;
            this.toolStripProgressBar1.Minimum = 0;
            this.toolStripProgressBar1.Maximum = imgOriginal.Height;
            this.toolStripProgressBar1.Step = 1;

            var bitmap1 = new Bitmap(imgOriginal);
            if(this.colours == 0)
            {
                this.pictureBox1.Image = imgOriginal;
            }
            else if (colours == 3)
            {
                for (int y = 0; y < bitmap1.Height; y++)
                {
                    for (int x = 0; x < bitmap1.Width; x++)
                    {
                        Color pixel = bitmap1.GetPixel(x, y);
                        // old 100 200 90
                        if (pixel.R >= 100 || pixel.G >= 80 || pixel.B <= 127)
                            pixel = Color.FromArgb(255, 255, 255);
                        bitmap1.SetPixel(x, y, pixel);
                    }
                    this.toolStripProgressBar1.PerformStep();
                }
                this.pictureBox1.Image = bitmap1;
            }
            else if (colours == 2)
            {
                for (int y = 0; y < bitmap1.Height; y++)
                {
                    for (int x = 0; x < bitmap1.Width; x++)
                    {
                        Color pixel = bitmap1.GetPixel(x, y);
                        // old 180 80 140
                        if (pixel.R >= 100 || pixel.G <= 120 || pixel.B >= 100)
                            pixel = Color.FromArgb(255, 255, 255);
                        bitmap1.SetPixel(x, y, pixel);
                    }
                    this.toolStripProgressBar1.PerformStep();
                }
                this.pictureBox1.Image = bitmap1;
            }
            else if (colours == 1)
            {
                for (int y = 0; y < bitmap1.Height; y++)
                {
                    for (int x = 0; x < bitmap1.Width; x++)
                    {
                        Color pixel = bitmap1.GetPixel(x, y);
                        // old 80 110 110
                        if (pixel.R <= 127 || pixel.G >= 40 || pixel.B >= 50)
                            pixel = Color.FromArgb(255, 255, 255);
                        bitmap1.SetPixel(x, y, pixel);
                    }
                    this.toolStripProgressBar1.PerformStep();
                }
                this.pictureBox1.Image = bitmap1;
            }

            this.toolStripProgressBar1.Value = 0;
            this.toolStripProgressBar1.Visible = false;
        }

        private void blueCheck_Click(object sender, EventArgs e)
        {
            if(this.isBlue)
            {
                this.colours = 0;
                this.isBlue = false;
            }
            else
            {
                this.colours = 3;
                this.isBlue = true;
                this.isRed = false;
                this.isGreen = false;
            }
            this.redCheck.Checked = false;
            this.greenCheck.Checked = false;
            rgbChanger();
        }

        private void redCheck_Click(object sender, EventArgs e)
        {
            if (this.isRed)
            {
                this.colours = 0;
                this.isRed = false;
            }
            else
            {
                this.colours = 1;
                this.isRed = true;
                this.isBlue = false;
                this.isGreen = false;
            }
            this.blueCheck.Checked = false;
            this.greenCheck.Checked = false;
            rgbChanger();
        }

        private void greenCheck_Click(object sender, EventArgs e)
        {
            if (this.isGreen)
            {
                this.colours = 0;
                this.isGreen = false;
            }
            else
            {
                this.colours = 2;
                this.isRed = false;
                this.isBlue = false;
                this.isGreen = true;
            }
            this.blueCheck.Checked = false;
            this.redCheck.Checked = false;
            rgbChanger();
        }
    }
}
