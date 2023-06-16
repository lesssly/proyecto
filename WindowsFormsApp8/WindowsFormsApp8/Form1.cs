using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Carga una imagen y la muestra desde un PictureBox
            openFileDialog1.Filter = "Archivos JPG |*.jpg|Archivos BMP|*.bmp|Todos los archivos|*.*";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int rm, gm, bm;
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
            {
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    rm = 0; gm = 0; bm = 0;
                    for (int im = i; im < i + 10; im++)
                    {
                        for (int jm = j; jm < j + 10; jm++)
                        {
                            c = bmp1.GetPixel(i, j);
                            rm = rm + c.R;
                            gm = gm + c.G;
                            bm = bm + c.B;
                        }
                    }
                    rm = rm / 100;
                    gm = gm / 100;
                    bm = bm / 100;
                    if ((rm >= 55 && rm <= 160) && (gm >= 55 && gm <= 150) && (bm >= 55 && bm <= 140))
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                bmp3.SetPixel(im, jm, Color.FromArgb(118, 060, 040));
                            }
                        }
                    }
                    else
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                c = bmp1.GetPixel(im, jm);
                                bmp3.SetPixel(im, jm, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }
                    pictureBox1.Image = bmp3;
                }
            }
        }

        // if ((blue >= 30 && blue <= 72)&&(green>=33 && green<=108) &&(red>=33 && red<=166))



        private void button3_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int rm, gm, bm;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
            {
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    rm = 0; gm = 0; bm = 0;
                    for (int im = i; im < i + 5; im++)
                    {
                        for (int jm = j; jm < j + 5; jm++)
                        {
                            c = bmp1.GetPixel(i, j);
                            rm = rm + c.R;
                            gm = gm + c.G;
                            bm = bm + c.B;
                        }
                    }
                    rm = rm / 25;
                    gm = gm / 25;
                    bm = bm / 25;
                    if ((rm >= 2 && rm <= 40) && (gm >= 26 && gm <= 70) && (bm >= 12 && bm <= 60))
                    {
                        for (int im = i; im < i + 5; im++)
                        {
                            for (int jm = j; jm < j + 5; jm++)
                            {
                                bmp3.SetPixel(im, jm, Color.FromArgb(045, 087, 044));
                            }
                        }
                    }
                    else
                    {
                        for (int im = i; im < i + 5; im++)
                        {
                            for (int jm = j; jm < j + 5; jm++)
                            {
                                c = bmp1.GetPixel(im, jm);
                                bmp3.SetPixel(im, jm, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }
                    pictureBox1.Image = bmp3;
                }
            }
        }
//azul
        private void button4_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int rm, gm, bm;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
            {
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    rm = 0; gm = 0; bm = 0;
                    for (int im = i; im < i + 5; im++)
                    {
                        for (int jm = j; jm < j + 5; jm++)
                        {
                            c = bmp1.GetPixel(i, j);
                            rm = rm + c.R;
                            gm = gm + c.G;
                            bm = bm + c.B;
                        }
                    }
                    rm = rm / 25;
                    gm = gm / 25;
                    bm = bm / 25;
                    if ((rm >= 1 && rm <= 64) && (gm >= 5 && gm <= 65) && (bm >= 62 && bm <= 206))
                    {
                        for (int im = i; im < i + 5; im++)
                        {
                            for (int jm = j; jm < j + 5; jm++)
                            {
                                bmp3.SetPixel(im, jm, Color.FromArgb(034, 113, 179));
                            }
                        }
                    }
                    else
                    {
                        for (int im = i; im < i + 5; im++)
                        {
                            for (int jm = j; jm < j + 5; jm++)
                            {
                                c = bmp1.GetPixel(im, jm);
                                bmp3.SetPixel(im, jm, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }
                    pictureBox1.Image = bmp3;
                }
            }

           
        }



    }
}
