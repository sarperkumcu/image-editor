using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Emgu.CV;
//using Emgu.CV.Structure;
//using Emgu;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public static Bitmap normalBMP;
        public Boolean didUserClickMirror = false;
        Color[][] colorMatrix;
        public Bitmap rotatedPic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            ToolTip rgpchannelToolTip = new ToolTip();
            ToolTip histogramToolTip = new ToolTip();
            ToolTip resizeToolTip = new ToolTip();
            //ToolTip rgpchannelToolTip = new ToolTip();

            this.Text = "Empty File";
            this.BackColor = Color.FromArgb(27, 26, 26);
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(pictureBox1);
            this.panel2.BackColor = Color.FromArgb(25, 18, 18);
            rgpchannelToolTip.SetToolTip(rgbchannel, "RGB Channels");
            histogramToolTip.SetToolTip(histogram, "Histogram");
            resizeToolTip.SetToolTip(resize, "Scale");

            //this.panel1.AutoScrollMinSize = new Size(formWh*2, formHei*2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mirrorImage()
        {
            if (normalBMP == null)
            {
                MessageBox.Show("Error");
                return;
            }

            int x = 0;
            int y = 0;
          //  didUserClickMirror = true;
            colorMatrix = new Color[normalBMP.Width][];
            for (int i = normalBMP.Width - 1; i >= 0; i--)
            {
                colorMatrix[x] = new Color[normalBMP.Height];
                y = 0;
                for (int j = 0; j < normalBMP.Height; j++)
                {
                    colorMatrix[x][y] = normalBMP.GetPixel(i, j);
                    y++;
                }
                x++;
            }


            rotatedPic = new Bitmap(normalBMP.Width, normalBMP.Height);
            y = 0;
            x = normalBMP.Width;
            processList.Add(normalBMP);
            int z = x -1 ;
            for (int i = 0; i < normalBMP.Width; i++)
            {
                y = 0;
                //colorMatrix[i] = new Color[height];
                for (int j = 0; j < normalBMP.Height; j++)
                {
                    //colorMatrix[i][j] = bmp.GetPixel(i,j);
                   // rotatedPic.SetPixel(i, j, normalBMP.GetPixel(i,j));
                    rotatedPic.SetPixel(i, j, normalBMP.GetPixel(z,j));
                    y++;
                }
                x++;
                z--;
            }
            
          /*  for (int i = normalBMP.Width - 1; i >= 0; i--)
            {
               // colorMatrix[x] = new Color[normalBMP.Height];
                y =0;
                for (int j = 0; j < normalBMP.Height; j++)
                {
                    rotatedPic.SetPixel(x,y,normalBMP.GetPixel(i, j));
                    y++;
                }
                x++;
            }*/

            //pictureBox2.Size = new Size(normalBMP.Width, normalBMP.Height);
            //pictureBox2.Image = rotatedPic;
            /*rotatedPic = autoResize(rotatedPic);
             pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (rotatedPic.Width / 2),
                               (pictureBox1.Parent.ClientSize.Height / 2) - (rotatedPic.Height / 2));
             pictureBox1.Refresh();
             pictureBox1.Size = new Size(rotatedPic.Width, rotatedPic.Height);*/
             normalBMP = rotatedPic;
             pictureBox1.Image = normalBMP;
           // didUserClickMirror = true;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
           // if(!didUserClickMirror)
            mirrorImage();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (normalBMP == null)
            {
                MessageBox.Show("Error");
                return;
            }
            processList.Add(normalBMP);
            invertImage();
        }

        private void invertImage()
        {
            // Color[][] rotatedPicMatrix = new Color[normalBMP.Width][];
            // int x = 0,y=0 ;
            Bitmap invertedPic = normalBMP;
            for (int i =0; i < normalBMP.Width; i++)
            {
                //rotatedPicMatrix[x] = new Color[normalBMP.Height];
           
                for (int j = 0; j < normalBMP.Height; j++)
                {
                   invertedPic.SetPixel(i, j,(Color.FromArgb(255 - normalBMP.GetPixel(i,j).R, 255 - normalBMP.GetPixel(i, j).G, 255 - normalBMP.GetPixel(i, j).B)));
                  /* if(didUserClickMirror)
                        rotatedPic.SetPixel(i, j, (Color.FromArgb(255 - rotatedPic.GetPixel(i, j).R, 255 - rotatedPic.GetPixel(i, j).G, 255 - rotatedPic.GetPixel(i, j).B)));
*/
                }

            }

          //  Bitmap newPic= normalBMP;
            /*for (int i = 0; i < normalBMP.Width; i++)
            {
                //colorMatrix[i] = new Color[height];
                for (int j = 0; j < normalBMP.Height; j++)
                {
                   newPic.SetPixel(i, j, rotatedPicMatrix[i][j]);
                }
            }*/
           
            pictureBox1.Image = invertedPic;
            normalBMP = invertedPic;
            //if(didUserClickMirror)
           // pictureBox2.Image = rotatedPic;
        }
        public static String filename;
        public static OpenFileDialog ofd;
        private Bitmap autoResize(String fileName)
        {
            Bitmap image = new Bitmap(fileName);
            double wh=image.Width, hei=image.Height;
            if (wh > formWh || hei > formHei)
            {
                autoScaledAtFirst = true;
                while (wh  > formWh || hei  > formHei)
             {
                wh /= 1.001;
                hei /= 1.001;
             }
            }
            
            image = new Bitmap(image, new Size((int)wh, (int)hei));
            return image;
        }
        public bool autoScaledAtFirst = false;
        private Bitmap autoResize(Bitmap im)
        {
            Bitmap image =im ;
            double wh = image.Width, hei = image.Height;
            if((wh > formWh || hei > formHei))
            {
                while (wh > formWh || hei > formHei)
                     {
                          wh /= 1.001;
                          hei /= 1.001;
                     }
            }
            
            else
            {
                if(!((wh >= mainPicWh) && (hei >= mainPicHei)) && autoScaledAtFirst == true)
                while ((wh  < formWh && hei < formHei))
                     {
                          wh *= 1.001;
                          hei *= 1.001;
                     }
            }
            Bitmap newPic = new Bitmap((int)wh,(int) hei);
            using (Graphics gr = Graphics.FromImage(newPic))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gr.DrawImage(im, new Rectangle(0, 0, (int)wh, (int)hei));
            }
            image = newPic;
            resized = true;
            return image;
        }
        bool resized = false;
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("openFileTool");
            try
            {
                ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Image<Bgr, byte> imgInput = new Image<Bgr, byte>(ofd.FileName);
                     normalBMP = autoResize(ofd.FileName);
                    filename = ofd.FileName;
                    //normalBMP = new Bitmap(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBox1.Anchor = AnchorStyles.None;
                    pictureBox1.Image = normalBMP;
                    pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (normalBMP.Width / 2),
                                                (pictureBox1.Parent.ClientSize.Height / 2) - (normalBMP.Height / 2));
                    pictureBox1.Refresh();
                    //firstLoadPic = new Bitmap(ofd.FileName);
                    //normalBMP = imgInput.Bitmap;
                    int height = mainPicHei = normalBMP.Height;
                    int width = mainPicWh = normalBMP.Width;
                    
                    colorMatrix = new Color[width][];
                   // pictureBox1.Size = new Size(width, height);
                   // pictureBox1.Location = new Point(0, 0);
                   // pictureBox2.Location = new Point(pictureBox1.Width, 0);
                    pictureBox1.Image = normalBMP;
                    this.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (normalBMP == null)
            {
                MessageBox.Show("Error");
                return;
            }
            autoScaledAtFirst = false;
            //Image<Bgr, byte> imgInput = new Image<Bgr, byte>(ofd.FileName);
            // normalBMP = autoResize(ofd.FileName);
            normalBMP = autoResize(filename);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = normalBMP;
            pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (normalBMP.Width / 2),
                                        (pictureBox1.Parent.ClientSize.Height / 2) - (normalBMP.Height / 2));
            pictureBox1.Refresh();
            //firstLoadPic = new Bitmap(ofd.FileName);
            //normalBMP = imgInput.Bitmap;
            int height = normalBMP.Height;
            int width = normalBMP.Width;
            colorMatrix = new Color[width][];
            // pictureBox1.Size = new Size(width, height);
            // pictureBox1.Location = new Point(0, 0);
            // pictureBox2.Location = new Point(pictureBox1.Width, 0);
            pictureBox1.Image = normalBMP;
            this.Text = ofd.FileName;
        }

        private void rotation_Click(object sender, EventArgs e)
        {

        }

        int formWh = 1474;
        int formHei = 766;
        int mainPicWh;
        int mainPicHei;
        private void grayscale_Click(object sender, EventArgs e)
        {
            //Bitmap grayPht = new Bitmap(ofd.FileName);
            if (normalBMP == null)
            {
                MessageBox.Show("Error");
                return;
            }
            processList.Add(normalBMP);

            int a, b;
            for (a = 0; a < normalBMP.Width; a++)
            {
                for (b = 0; b < normalBMP.Height; b++)
                {
                    Color pixelColor = normalBMP.GetPixel(a, b);
                    int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color newColor = Color.FromArgb(avg, avg, avg);
                    normalBMP.SetPixel(a, b, newColor);
                }
            }
            pictureBox1.Image = normalBMP;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.P)
            {
                MessageBox.Show("Hello");
            }
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
           
                
            
        }

        private void rotateRight()
        {
            if (normalBMP == null)
            {
                MessageBox.Show("Error");
                return;
            }

            int x = 0, y = 0;
            Bitmap newBMP = new Bitmap(normalBMP.Height, normalBMP.Width);
            for (int a = 0; a < normalBMP.Width; a++)
            {
                x = 0;
                for (int b = normalBMP.Height - 1; b >= 0; b--)
                {
                    newBMP.SetPixel(x, y, normalBMP.GetPixel(a, b));
                    x++;
                }
                y++;
            }
            normalBMP = newBMP = autoResize(newBMP);

            pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (newBMP.Width / 2),
                         (pictureBox1.Parent.ClientSize.Height / 2) - (newBMP.Height / 2));
            pictureBox1.Size = newBMP.Size;
            //pictureBox1.Location = new Point(0, 0);
            pictureBox1.Image = normalBMP;
            pictureBox1.Refresh();

        }

        private void rotateLeft()
        {
            if (normalBMP == null)
            {
                MessageBox.Show("Error");
                return;
            }

            int x = 0, y = 0;
            Bitmap newBMP = new Bitmap(normalBMP.Height, normalBMP.Width);
            for (int a = normalBMP.Width - 1; a >= 0; a--)
            {
                x = 0;
                for (int b = 0; b < normalBMP.Height; b++)
                {
                    newBMP.SetPixel(x, y, normalBMP.GetPixel(a, b));
                    x++;
                }
                y++;
            }
            normalBMP = newBMP = autoResize(newBMP);

            pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (newBMP.Width / 2),
                         (pictureBox1.Parent.ClientSize.Height / 2) - (newBMP.Height / 2));
            pictureBox1.Refresh();
            pictureBox1.Size = newBMP.Size;
            //pictureBox1.Location = new Point(0, 0);
            pictureBox1.Image = normalBMP;

        }

        private void keyPress(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Add)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            if(e.Control && e.KeyCode == Keys.D)
            {
                processList.Add(normalBMP);

                rotateRight();
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                processList.Add(normalBMP);

                rotateLeft();
            }

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (normalBMP.Width > formWh || normalBMP.Height > formHei)
            {
                if (e.KeyCode == Keys.A)
                {
                    x += 10;
                    pictureBox1.Location = new Point(x, y);

                }
                else if (e.KeyCode == Keys.D) { x -= 10; pictureBox1.Location = new Point(x, y); }
                else if (e.KeyCode == Keys.S) { y -= 10; pictureBox1.Location = new Point(x, y); }
                else if (e.KeyCode == Keys.W) { y += 10; pictureBox1.Location = new Point(x, y); }
                }

            if(e.Control && e.KeyCode == Keys.Z)
            {
                if(processList.Count > 0)
                {
                    if (normalBMP.Equals(processList.ElementAt(processList.Count - 1)))
                        Console.WriteLine("TEEST");
                    normalBMP = processList.ElementAt(processList.Count-1);
                    processList.RemoveAt(processList.Count-1);
                    pictureBox1.Image = null;
                    pictureBox1.Size = new Size(normalBMP.Width, normalBMP.Height);
                    pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (normalBMP.Width / 2),
                                     (pictureBox1.Parent.ClientSize.Height / 2) - (normalBMP.Height / 2));
                    pictureBox1.Image = normalBMP;
                    pictureBox1.Refresh();
                    Console.WriteLine(processList.Count);
                }


            }
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram();
            if (normalBMP != null)
                histogram.Show();
            else
                MessageBox.Show("Error");
            
           
        }

        private void rgbchannel_Click(object sender, EventArgs e)
        {
            Form2 rgb = new Form2();
            if (normalBMP != null)
                rgb.Show();
            else
                MessageBox.Show("Error");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        List<Bitmap> processList = new List<Bitmap>();
        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            if(normalBMP == null)
                MessageBox.Show("Error");
            processList.Add(normalBMP);
            rotateLeft();
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            if (normalBMP == null)
                MessageBox.Show("Error");
            processList.Add(normalBMP);
            rotateRight();
        }

        private void resize_Click(object sender, EventArgs e)
        {
            if(normalBMP == null)
            {
                MessageBox.Show("Error");
                return;
            }
            Bitmap image = normalBMP;
            String whS = "" + image.Width;
            String heiS = "" + image.Height;
                     
            whS = Interaction.InputBox("Width", "Yeniden Boyutlandır", "", 0, 0);
            //MessageBox.Show("Girilen isim: " + wh);
            heiS = Interaction.InputBox("Height", "Yeniden Boyutlandır", "", 0, 0);
            int wh = Int32.Parse(whS);
            int hei = Int32.Parse(heiS);
            Bitmap newPic = new Bitmap(wh, hei);
            using (Graphics gr = Graphics.FromImage(newPic))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gr.DrawImage(normalBMP, new Rectangle(0, 0, wh, hei));
            }
            normalBMP = newPic;
            pictureBox1.Size = new Size(normalBMP.Width, normalBMP.Height);
            pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (normalBMP.Width / 2),
                             (pictureBox1.Parent.ClientSize.Height / 2) - (normalBMP.Height / 2));
            pictureBox1.Refresh();
            pictureBox1.Image = normalBMP;
        }
    }
}
