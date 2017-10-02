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
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
        }

        private void drawHistogram()
        {
            int[] histogram_R = new int[256];
            int[] histogram_G = new int[256];
            int[] histogram_B = new int[256];
            int[] histogram_GREY = new int[256];
            Bitmap normalBMP = Form1.normalBMP;
            float maxR = 0,maxG=0,maxB=0,maxGREY=0;
            for (int i = 0; i < normalBMP.Width; i++)
            {
                for (int j = 0; j < normalBMP.Height; j++)
                {
                    Color pixel = normalBMP.GetPixel(i, j);
                    int redValue =pixel.R;
                    int greenValue = pixel.G;
                    int blueValue = pixel.B;
                    int greyValue = (pixel.R + pixel.G + pixel.B) / 3;
                    histogram_R[redValue]++;
                    histogram_G[greenValue]++;
                    histogram_B[blueValue]++;
                    histogram_GREY[greyValue]++;
                    if (maxR < histogram_R[redValue])
                        maxR = histogram_R[redValue];

                    if (maxG < histogram_G[greenValue])
                        maxG = histogram_G[greenValue];

                    if (maxB < histogram_B[blueValue])
                        maxB = histogram_B[blueValue];

                    if (maxGREY < histogram_GREY[greyValue])
                        maxGREY = histogram_GREY[greyValue];
                }
            }

            int histHeight = 128;

           Bitmap img = new Bitmap(256, histHeight + 10);

            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < histogram_GREY.Length; i++)
                {
                    float pct = histogram_GREY[i] / maxGREY;   // What percentage of the max is this value?
                    g.DrawLine(Pens.Gray,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                        );
                }
            }
            pictureBox1.Size = new Size(256, 138);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Image = img;
            /****/
            img = new Bitmap(256, histHeight + 10);

            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < histogram_R.Length; i++)
                {
                    float pct = histogram_R[i] / maxR;   // What percentage of the max is this value?
                    g.DrawLine(Pens.Red,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                        );
                }
            }
            pictureBox2.Size = new Size(256, 138);
            pictureBox2.Location = new Point(0, 138);
            pictureBox2.Image = img;

            /***/
            img = new Bitmap(256, histHeight + 10);

            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < histogram_G.Length; i++)
                {
                    float pct = histogram_G[i] / maxG;   // What percentage of the max is this value?
                    g.DrawLine(Pens.Green,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                        );
                }
            }
            pictureBox3.Size = new Size(256, 138);
            pictureBox3.Location = new Point(0, 276);
            pictureBox3.Image = img;
            /***/
            img = new Bitmap(256, histHeight + 10);

            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < histogram_B.Length; i++)
                {
                    float pct = histogram_B[i] / maxR;   // What percentage of the max is this value?
                    g.DrawLine(Pens.Blue,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                        );
                }
            }
            pictureBox4.Size = new Size(256, 138);
            pictureBox4.Location = new Point(0, 414);
            pictureBox4.Image = img;
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            drawHistogram();
        }
    }
}
