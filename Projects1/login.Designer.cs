namespace codeFirstStok
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ad = new Label();
            sifre = new Label();
            u_ad = new TextBox();
            u_sifre = new TextBox();
            btnkaydet = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
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
            panel1.Size = new Size(778, 562);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 40);
            label1.Name = "label1";
            label1.Size = new Size(426, 25);
            label1.TabIndex = 13;
            label1.Text = "Lütfen Kullanıcı Türünüzü Belirlemek İçin Giriş Yapınız:\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ad.Location = new Point(489, 158);
            ad.Name = "ad";
            ad.Size = new Size(125, 21);
            ad.TabIndex = 10;
            ad.Text = "Kullanıcı Adı:";
            // 
            // sifre
            // 
            sifre.AutoSize = true;
            sifre.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sifre.Location = new Point(489, 290);
            sifre.Name = "sifre";
            sifre.Size = new Size(138, 21);
            sifre.TabIndex = 7;
            sifre.Text = "Kullanıcı Şifre:";
            // 
            // u_ad
            // 
            u_ad.Location = new Point(442, 194);
            u_ad.Name = "u_ad";
            u_ad.Size = new Size(215, 31);
            u_ad.TabIndex = 14;
            u_ad.TextChanged += textBox1_TextChanged;
            // 
            // u_sifre
            // 
            u_sifre.Location = new Point(442, 314);
            u_sifre.Name = "u_sifre";
            u_sifre.Size = new Size(215, 31);
            u_sifre.TabIndex = 15;
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnkaydet.Location = new Point(511, 410);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(83, 41);
            btnkaydet.TabIndex = 16;
            btnkaydet.Text = "Giriş";
            btnkaydet.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 562);
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
    }
}