using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Bitmap setRGBChannels(Bitmap pic,int x)
        {
          
            if (x == 0) // RED CHANNEL
            for (int i = 0; i < pic.Width; i++)
            {
                for (int j = 0; j < pic.Height; j++)
                {
                    Color pixelColor = pic.GetPixel(i, j);
                        //int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        int g =Convert.ToInt32(255 * Math.Pow(pixelColor.R / 255,2.0));
                        Color newColor = Color.FromArgb(pixelColor.A,pixelColor.R,pixelColor.R,pixelColor.R);
                       // red[i, j] = pixelColor.R;
                        pic.SetPixel(i, j, newColor);
                        
                }
            }

            if (x == 1) // GREEN CHANNEL
            {
                for (int i = 0; i < pic.Width; i++)
                {
                    for (int j = 0; j < pic.Height; j++)
                    {
                        Color pixelColor = pic.GetPixel(i, j);
                        int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        Color newColor = Color.FromArgb(pixelColor.A, pixelColor.G, pixelColor.G, pixelColor.G);
                        pic.SetPixel(i, j, newColor);
                    }
                }
             }
                
            if (x == 2) // BLUE CHANNEL
                for (int i = 0; i < pic.Width; i++)
                {
                    for (int j = 0; j < pic.Height; j++)
                    {
                        Color pixelColor = pic.GetPixel(i, j);
                        int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        Color newColor = Color.FromArgb(pixelColor.A,pixelColor.B, pixelColor.B, pixelColor.B);
                        pic.SetPixel(i, j, newColor);
                    }
                }



            return pic;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(0, 0);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(250, 250);
            label2.Location = new Point(250, 0);
            pictureBox2.Location = new Point(250, 0);
            pictureBox2.Size = new Size(250, 250);
            label3.Location = new Point(0, 250);
            pictureBox3.Location = new Point(0, 250);
            pictureBox3.Size = new Size(250, 250);
            label4.Location = new Point(250, 250);
            pictureBox4.Location = new Point(250, 250);
            pictureBox4.Size = new Size(250, 250);
            Form1 form1 = new Form1();
            Bitmap bmp = form1.NormalBMP;
            pictureBox1.Image = new Bitmap(bmp);
          //new Bitmap(bmp);
           // bmp = Form1.normalBMP;
            pictureBox2.Image = setRGBChannels(new Bitmap(bmp),0); //Red
            //bmp = Form1.normalBMP;
            pictureBox3.Image = setRGBChannels(new Bitmap(bmp), 1); //Green
            //bmp = Form1.normalBMP;
            pictureBox4.Image = setRGBChannels(new Bitmap(bmp), 2); //Blue
        }
    }
}
