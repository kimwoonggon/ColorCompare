using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ColorCompare
{
    public partial class Form1 : Form
    {
        private Mat img1, img2, img3;
        private Mat img1Original, img2Original, img3Original;

        public Form1()
        {
            InitializeComponent();

            // Enable drag-and-drop for the picture boxes
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;

            // Set up event handlers for drag-and-drop
            pictureBox1.DragEnter += new DragEventHandler(PictureBox_DragEnter);
            pictureBox2.DragEnter += new DragEventHandler(PictureBox_DragEnter);
            pictureBox3.DragEnter += new DragEventHandler(PictureBox_DragEnter);

            pictureBox1.DragDrop += new DragEventHandler(PictureBox_DragDrop);
            pictureBox2.DragDrop += new DragEventHandler(PictureBox_DragDrop);
            pictureBox3.DragDrop += new DragEventHandler(PictureBox_DragDrop);
        }

        private void btnUploadImage1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    img1 = Cv2.ImRead(openFileDialog.FileName);
                    img1Original = img1.Clone();
                    pictureBox1.Image = BitmapConverter.ToBitmap(img1);
                }
            }
        }

        private void btnUploadImage2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    img2 = Cv2.ImRead(openFileDialog.FileName);
                    img2Original = img2.Clone();
                    pictureBox2.Image = BitmapConverter.ToBitmap(img2);
                }
            }
        }

        private void btnUploadImage3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    img3 = Cv2.ImRead(openFileDialog.FileName);
                    img3Original = img3.Clone();
                    pictureBox3.Image = BitmapConverter.ToBitmap(img3);
                }
            }
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    PictureBox pictureBox = sender as PictureBox;
                    Mat img = Cv2.ImRead(filePath);

                    if (pictureBox == pictureBox1)
                    {
                        img1 = img;
                        img1Original = img.Clone();
                        pictureBox1.Image = BitmapConverter.ToBitmap(img1);
                    }
                    else if (pictureBox == pictureBox2)
                    {
                        img2 = img;
                        img2Original = img.Clone();
                        pictureBox2.Image = BitmapConverter.ToBitmap(img2);
                    }
                    else if (pictureBox == pictureBox3)
                    {
                        img3 = img;
                        img3Original = img.Clone();
                        pictureBox3.Image = BitmapConverter.ToBitmap(img3);
                    }
                }
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Image != null)
            {
                Mat img = pictureBox == pictureBox1 ? img1 : (pictureBox == pictureBox2 ? img2 : img3);
                Mat imgOriginal = pictureBox == pictureBox1 ? img1Original : (pictureBox == pictureBox2 ? img2Original : img3Original);

                if (img != null && imgOriginal != null)
                {
                    float imageAspectRatio = (float)img.Width / img.Height;
                    float pictureBoxAspectRatio = (float)pictureBox.Width / pictureBox.Height;

                    float scaleFactor;
                    float offsetX = 0, offsetY = 0;

                    if (imageAspectRatio > pictureBoxAspectRatio)
                    {
                        // Image is wider than PictureBox
                        scaleFactor = (float)pictureBox.Width / img.Width;
                        offsetY = (pictureBox.Height - img.Height * scaleFactor) / 2;
                    }
                    else
                    {
                        // Image is taller than PictureBox
                        scaleFactor = (float)pictureBox.Height / img.Height;
                        offsetX = (pictureBox.Width - img.Width * scaleFactor) / 2;
                    }

                    // Adjust coordinates
                    int x = (int)((e.X - offsetX) / scaleFactor);
                    int y = (int)((e.Y - offsetY) / scaleFactor);

                    if (x < 0 || y < 0 || x >= img.Width || y >= img.Height)
                        return;

                    Vec3b pixel = img.At<Vec3b>(y, x);
                    int r = pixel.Item2;
                    int g = pixel.Item1;
                    int b = pixel.Item0;

                    // Convert RGB to HSV
                    Mat pixelMat = new Mat(1, 1, MatType.CV_8UC3, new Scalar(b, g, r));
                    Mat hsvMat = new Mat();
                    Cv2.CvtColor(pixelMat, hsvMat, ColorConversionCodes.BGR2HSV);
                    Vec3b hsvPixel = hsvMat.At<Vec3b>(0, 0);
                    int h = hsvPixel.Item0;
                    int s = hsvPixel.Item1;
                    int v = hsvPixel.Item2;

                    // Clone the original image to keep it intact
                    Mat imgCopy = imgOriginal.Clone();

                    // Draw a circle at the clicked point
                    Cv2.Circle(imgCopy, new OpenCvSharp.Point(x, y), 5, new Scalar(255, 0, 0), -1);

                    // Draw text on the image at the click position
                    Cv2.PutText(imgCopy, $"RGB: ({r}, {g}, {b})", new OpenCvSharp.Point(x, y - 20), HersheyFonts.HersheySimplex, 0.5, Scalar.Green, 1);
                    Cv2.PutText(imgCopy, $"HSV: ({h}, {s}, {v})", new OpenCvSharp.Point(x, y), HersheyFonts.HersheySimplex, 0.5, Scalar.Green, 1);
                    Cv2.PutText(imgCopy, $"X: {x}, Y: {y}", new OpenCvSharp.Point(x, y + 20), HersheyFonts.HersheySimplex, 0.5, Scalar.Green, 1);

                    pictureBox.Image = BitmapConverter.ToBitmap(imgCopy);

                    // Save the updated image back to the original
                    if (pictureBox == pictureBox1)
                        img1 = imgCopy;
                    else if (pictureBox == pictureBox2)
                        img2 = imgCopy;
                    else
                        img3 = imgCopy;

                    labelPixelInfo.Text = $"X: {x}, Y: {y}, RGB: ({r}, {g}, {b}), HSV: ({h}, {s}, {v})";
                }
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            // Restore the original images
            if (img1Original != null)
            {
                img1 = img1Original.Clone();
                pictureBox1.Image = BitmapConverter.ToBitmap(img1);
            }

            if (img2Original != null)
            {
                img2 = img2Original.Clone();
                pictureBox2.Image = BitmapConverter.ToBitmap(img2);
            }

            if (img3Original != null)
            {
                img3 = img3Original.Clone();
                pictureBox3.Image = BitmapConverter.ToBitmap(img3);
            }

            labelPixelInfo.Text = "Pixel Info: ";
        }

        private void btnDeleteImage1_Click(object sender, EventArgs e)
        {
            img1 = null;
            img1Original = null;
            pictureBox1.Image = null;
        }

        private void btnDeleteImage2_Click(object sender, EventArgs e)
        {
            img2 = null;
            img2Original = null;
            pictureBox2.Image = null;
        }

        private void btnDeleteImage3_Click(object sender, EventArgs e)
        {
            img3 = null;
            img3Original = null;
            pictureBox3.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseClick += pictureBox_MouseClick;
            pictureBox2.MouseClick += pictureBox_MouseClick;
            pictureBox3.MouseClick += pictureBox_MouseClick;
            btnErase.Click += btnErase_Click;
            btnDeleteImage1.Click += btnDeleteImage1_Click;
            btnDeleteImage2.Click += btnDeleteImage2_Click;
            btnDeleteImage3.Click += btnDeleteImage3_Click;
        }
    }
}
