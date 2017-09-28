﻿using System;
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
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Bitmap normalBMP;
        public Boolean didUserClickMirror = false;
        Color[][] colorMatrix;
        public Bitmap rotatedPic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mirrorImage()
        {
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

            for (int i = 0; i < normalBMP.Width; i++)
            {
                //colorMatrix[i] = new Color[height];
                for (int j = 0; j < normalBMP.Height; j++)
                {
                    //colorMatrix[i][j] = bmp.GetPixel(i,j);
                    rotatedPic.SetPixel(i, j, colorMatrix[i][j]);
                }
            }
            pictureBox2.Size = new Size(normalBMP.Width, normalBMP.Height);
            pictureBox2.Image = rotatedPic;
            didUserClickMirror = true;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if(!didUserClickMirror)
            mirrorImage();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           invertImage();
        }

        private void invertImage()
        {
           // Color[][] rotatedPicMatrix = new Color[normalBMP.Width][];
           // int x = 0,y=0 ;
            for (int i =0; i < normalBMP.Width; i++)
            {
                //rotatedPicMatrix[x] = new Color[normalBMP.Height];
           
                for (int j = 0; j < normalBMP.Height; j++)
                {
                   normalBMP.SetPixel(i, j,(Color.FromArgb(255 - normalBMP.GetPixel(i,j).R, 255 - normalBMP.GetPixel(i, j).G, 255 - normalBMP.GetPixel(i, j).B)));
                   if(didUserClickMirror)
                        rotatedPic.SetPixel(i, j, (Color.FromArgb(255 - rotatedPic.GetPixel(i, j).R, 255 - rotatedPic.GetPixel(i, j).G, 255 - rotatedPic.GetPixel(i, j).B)));

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
           
            pictureBox1.Image = normalBMP;
            pictureBox2.Image = rotatedPic;
        }
        Bitmap firstLoadPic;
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Image<Bgr, byte> imgInput = new Image<Bgr, byte>(ofd.FileName);
                    normalBMP = new Bitmap(ofd.FileName);
                    firstLoadPic = new Bitmap(ofd.FileName);
                    //normalBMP = imgInput.Bitmap;
                    int height = normalBMP.Height;
                    int width = normalBMP.Width;
                    colorMatrix = new Color[width][];
                    pictureBox1.Size = new Size(width, height);
                    pictureBox1.Location = new Point(0, 0);
                    pictureBox2.Location = new Point(pictureBox1.Width, 0);
                    pictureBox1.Image = normalBMP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            didUserClickMirror = false;
            rotatedPic = firstLoadPic;
            normalBMP = firstLoadPic;
            pictureBox1.Image = firstLoadPic;
        }
    }
}
