namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.grayscale = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.rotateRightButton = new System.Windows.Forms.Button();
            this.rotateLeftButton = new System.Windows.Forms.Button();
            this.rgbchannel = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPress);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.reopenToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // reopenToolStripMenuItem
            // 
            this.reopenToolStripMenuItem.Name = "reopenToolStripMenuItem";
            this.reopenToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.reopenToolStripMenuItem.Text = "Reopen";
            this.reopenToolStripMenuItem.Click += new System.EventHandler(this.reopenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(82, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 482);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "invert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grayscale
            // 
            this.grayscale.Location = new System.Drawing.Point(3, 189);
            this.grayscale.Name = "grayscale";
            this.grayscale.Size = new System.Drawing.Size(75, 56);
            this.grayscale.TabIndex = 5;
            this.grayscale.Text = "Grayscale";
            this.grayscale.UseVisualStyleBackColor = true;
            this.grayscale.Click += new System.EventHandler(this.grayscale_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.resize);
            this.panel2.Controls.Add(this.rotateRightButton);
            this.panel2.Controls.Add(this.grayscale);
            this.panel2.Controls.Add(this.rotateLeftButton);
            this.panel2.Controls.Add(this.rgbchannel);
            this.panel2.Controls.Add(this.histogram);
            this.panel2.Location = new System.Drawing.Point(-2, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 482);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Image = global::Test.Properties.Resources.if_mirror_298828;
            this.button1.Location = new System.Drawing.Point(2, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 55);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // resize
            // 
            this.resize.AutoSize = true;
            this.resize.Image = ((System.Drawing.Image)(resources.GetObject("resize.Image")));
            this.resize.Location = new System.Drawing.Point(2, 127);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(73, 56);
            this.resize.TabIndex = 4;
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Image = global::Test.Properties.Resources.rotateR;
            this.rotateRightButton.Location = new System.Drawing.Point(39, 251);
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(36, 35);
            this.rotateRightButton.TabIndex = 9;
            this.rotateRightButton.UseVisualStyleBackColor = true;
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Image = global::Test.Properties.Resources.rotateL;
            this.rotateLeftButton.Location = new System.Drawing.Point(3, 251);
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(33, 35);
            this.rotateLeftButton.TabIndex = 8;
            this.rotateLeftButton.UseVisualStyleBackColor = true;
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // rgbchannel
            // 
            this.rgbchannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.rgbchannel.Image = global::Test.Properties.Resources.red_green_blue_three_rgb_circles_symbol;
            this.rgbchannel.Location = new System.Drawing.Point(2, 292);
            this.rgbchannel.Name = "rgbchannel";
            this.rgbchannel.Size = new System.Drawing.Size(73, 44);
            this.rgbchannel.TabIndex = 7;
            this.rgbchannel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rgbchannel.UseVisualStyleBackColor = true;
            this.rgbchannel.Click += new System.EventHandler(this.rgbchannel_Click);
            // 
            // histogram
            // 
            this.histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.histogram.Image = ((System.Drawing.Image)(resources.GetObject("histogram.Image")));
            this.histogram.Location = new System.Drawing.Point(2, 342);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(73, 45);
            this.histogram.TabIndex = 6;
            this.histogram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 371);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPress);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reopenToolStripMenuItem;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button grayscale;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button rgbchannel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button rotateRightButton;
        private System.Windows.Forms.Button rotateLeftButton;
    }
}

