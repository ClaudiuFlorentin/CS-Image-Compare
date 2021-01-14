using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace fingerprint_imgcompare
{
    public partial class Form1 : Form
    {
        Point lastPoint;

        Bitmap bitmapPic1, bitmapPic2;
        bool[] buttonPressed = new bool[2];

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void buttonOpenAction1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png,*.tif)|*.BMP;*.JPG;*.JPEG;*.PNG;*.TIF";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                path1.Text = openFile.FileName;
                pictureBoxImg1.Image = Image.FromFile(openFile.FileName);
                bitmapPic1 = new Bitmap(openFile.FileName);
            }

            buttonPressed[0] = true;
        }

        private void buttonOpenAction2(object sender, EventArgs e)
        {
            OpenFileDialog openFile2 = new OpenFileDialog();

            openFile2.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png,*.tif)|*.BMP;*.JPG;*.JPEG;*.PNG;*.TIF";

            if(openFile2.ShowDialog() == DialogResult.OK)
            {
                path2.Text = openFile2.FileName;
                pictureBoxImg2.Image = Image.FromFile(openFile2.FileName);
                bitmapPic2 = new Bitmap(openFile2.FileName);
            }

            buttonPressed[1] = true;
        }

        private void buttonCompareAction(object sender, EventArgs e)
        {
            if (buttonPressed[0] == true && buttonPressed[1] == true)
            {
                bool compare = ImageCompareString(bitmapPic1, bitmapPic2);

                if (compare == true)
                {
                    msgInfoMatch m = new msgInfoMatch();
                    m.Show();
                }
                else
                {
                    msgInfoNotMatch m = new msgInfoNotMatch();
                    m.Show();
                }
            }
            else
            {
                msgWarning m = new msgWarning();
                m.Show();
            }
        }

        private bool ImageCompareString(Bitmap bitmapPic11, Bitmap bitmapPic22)
        {
            MemoryStream ms = new MemoryStream();
            bitmapPic11.Save(ms, ImageFormat.Png);
            string firstbitmap = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;
            bitmapPic22.Save(ms, ImageFormat.Png);
            string secondbitmap = Convert.ToBase64String(ms.ToArray());

            if(firstbitmap.Equals(secondbitmap)) return true;
            else return false;
        }

        private void buttonMinimizeAction(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExitAction(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void headerBar_Down(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void headerBar_Move(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
