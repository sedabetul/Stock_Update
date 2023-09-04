namespace Projects
{
    partial class userRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userRegister));
            panel1 = new Panel();
            txtdogrulama = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnkaydet = new Button();
            ad = new Label();
            u_sifre = new TextBox();
            u_ad = new TextBox();
            sifre = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(txtdogrulama);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnkaydet);
            panel1.Controls.Add(ad);
            panel1.Controls.Add(u_sifre);
            panel1.Controls.Add(u_ad);
            panel1.Controls.Add(sifre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 555);
            panel1.TabIndex = 0;
            // 
            // txtdogrulama
            // 
            txtdogrulama.Location = new Point(663, 350);
            txtdogrulama.Margin = new Padding(3, 4, 3, 4);
            txtdogrulama.Name = "txtdogrulama";
            txtdogrulama.Size = new Size(102, 31);
            txtdogrulama.TabIndex = 20;
            txtdogrulama.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(547, 350);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 31);
            textBox1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(378, 356);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 18;
            label1.Text = "Doğrulama Kodu:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnkaydet.Location = new Point(451, 441);
            btnkaydet.Margin = new Padding(3, 4, 3, 4);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(234, 48);
            btnkaydet.TabIndex = 5;
            btnkaydet.Text = "Giriş";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ad.Location = new Point(378, 150);
            ad.Name = "ad";
            ad.Size = new Size(125, 21);
            ad.TabIndex = 1;
            ad.Text = "Kullanıcı Adı:";
            // 
            // u_sifre
            // 
            u_sifre.Location = new Point(547, 244);
            u_sifre.Margin = new Padding(3, 4, 3, 4);
            u_sifre.Name = "u_sifre";
            u_sifre.Size = new Size(218, 31);
            u_sifre.TabIndex = 4;
            u_sifre.UseSystemPasswordChar = true;
            // 
            // u_ad
            // 
            u_ad.Location = new Point(547, 144);
            u_ad.Margin = new Padding(3, 4, 3, 4);
            u_ad.Name = "u_ad";
            u_ad.Size = new Size(218, 31);
            u_ad.TabIndex = 2;
            // 
            // sifre
            // 
            sifre.AutoSize = true;
            sifre.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sifre.Location = new Point(378, 254);
            sifre.Name = "sifre";
            sifre.Size = new Size(138, 21);
            sifre.TabIndex = 3;
            sifre.Text = "Kullanıcı Şifre:";
            // 
            // userRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 555);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "userRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Register";
            Load += kullanıcıkayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnkaydet;
        private Label ad;
        private TextBox u_sifre;
        private TextBox u_ad;
        private Label sifre;
        private PictureBox pictureBox1;
        private TextBox txtdogrulama;
        private TextBox textBox1;
        private Label label1;
    }
}