namespace codeFirstStok
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.Label();
            this.u_sifre = new System.Windows.Forms.TextBox();
            this.u_ad = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnkaydet);
            this.panel1.Controls.Add(this.ad);
            this.panel1.Controls.Add(this.u_sifre);
            this.panel1.Controls.Add(this.u_ad);
            this.panel1.Controls.Add(this.sifre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 444);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(456, 319);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 38);
            this.btnkaydet.TabIndex = 16;
            this.btnkaydet.Text = "Giriş";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(424, 112);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(125, 21);
            this.ad.TabIndex = 15;
            this.ad.Text = "Kullanıcı Adı:";
            // 
            // u_sifre
            // 
            this.u_sifre.Location = new System.Drawing.Point(390, 261);
            this.u_sifre.Name = "u_sifre";
            this.u_sifre.Size = new System.Drawing.Size(194, 26);
            this.u_sifre.TabIndex = 14;
            this.u_sifre.UseSystemPasswordChar = true;
            // 
            // u_ad
            // 
            this.u_ad.Location = new System.Drawing.Point(390, 150);
            this.u_ad.Name = "u_ad";
            this.u_ad.Size = new System.Drawing.Size(194, 26);
            this.u_ad.TabIndex = 13;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(424, 225);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(138, 21);
            this.sifre.TabIndex = 12;
            this.sifre.Text = "Kullanıcı Şifre:";
            // 
            // userRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 444);
            this.Controls.Add(this.panel1);
            this.Name = "userRegister";
            this.Text = "User Register";
            this.Load += new System.EventHandler(this.kullanıcıkayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox u_sifre;
        private System.Windows.Forms.TextBox u_ad;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}