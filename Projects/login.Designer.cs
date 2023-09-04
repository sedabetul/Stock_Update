namespace Projects
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            btnbeyaz = new Button();
            btnsiyah = new Button();
            btnkaydet = new Button();
            u_sifre = new TextBox();
            u_ad = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ad = new Label();
            sifre = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btnbeyaz);
            panel1.Controls.Add(btnsiyah);
            panel1.Controls.Add(btnkaydet);
            panel1.Controls.Add(u_sifre);
            panel1.Controls.Add(u_ad);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ad);
            panel1.Controls.Add(sifre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 457);
            panel1.TabIndex = 0;
            // 
            // btnbeyaz
            // 
            btnbeyaz.BackColor = Color.White;
            btnbeyaz.Image = (Image)resources.GetObject("btnbeyaz.Image");
            btnbeyaz.Location = new Point(708, 394);
            btnbeyaz.Name = "btnbeyaz";
            btnbeyaz.Size = new Size(60, 60);
            btnbeyaz.TabIndex = 24;
            btnbeyaz.UseVisualStyleBackColor = false;
            btnbeyaz.Click += btnbeyaz_Click;
            // 
            // btnsiyah
            // 
            btnsiyah.BackColor = Color.Black;
            btnsiyah.Image = (Image)resources.GetObject("btnsiyah.Image");
            btnsiyah.Location = new Point(642, 394);
            btnsiyah.Name = "btnsiyah";
            btnsiyah.Size = new Size(60, 60);
            btnsiyah.TabIndex = 23;
            btnsiyah.UseVisualStyleBackColor = false;
            btnsiyah.Click += btnsiyah_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnkaydet.Location = new Point(527, 342);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(83, 41);
            btnkaydet.TabIndex = 3;
            btnkaydet.Text = "Giriş";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click_1;
            // 
            // u_sifre
            // 
            u_sifre.Location = new Point(459, 270);
            u_sifre.Name = "u_sifre";
            u_sifre.Size = new Size(215, 31);
            u_sifre.TabIndex = 2;
            u_sifre.UseSystemPasswordChar = true;
            // 
            // u_ad
            // 
            u_ad.Location = new Point(459, 183);
            u_ad.Name = "u_ad";
            u_ad.Size = new Size(215, 31);
            u_ad.TabIndex = 1;
            u_ad.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 43);
            label1.Name = "label1";
            label1.Size = new Size(426, 25);
            label1.TabIndex = 6;
            label1.Text = "Lütfen Kullanıcı Türünüzü Belirlemek İçin Giriş Yapınız:\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ad.Location = new Point(506, 147);
            ad.Name = "ad";
            ad.Size = new Size(125, 21);
            ad.TabIndex = 4;
            ad.Text = "Kullanıcı Adı:";
            ad.Click += ad_Click;
            // 
            // sifre
            // 
            sifre.AutoSize = true;
            sifre.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sifre.Location = new Point(506, 246);
            sifre.Name = "sifre";
            sifre.Size = new Size(138, 21);
            sifre.TabIndex = 5;
            sifre.Text = "Kullanıcı Şifre:";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(778, 457);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label ad;
        private Label sifre;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox u_sifre;
        private TextBox u_ad;
        private Button btnkaydet;
        private Button btnbeyaz;
        private Button btnsiyah;
    }
}