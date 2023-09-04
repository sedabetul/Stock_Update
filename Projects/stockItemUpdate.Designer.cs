namespace Projects
{
    partial class stockItemUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockItemUpdate));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtpkritikstokg = new TextBox();
            txtpstokg = new TextBox();
            txtpkategorig = new TextBox();
            txtpfiyatg = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnstokguncelle = new Button();
            urunkod = new Label();
            txtpadg = new TextBox();
            txtpcodeg = new TextBox();
            urunadi = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtpkritikstokg);
            panel1.Controls.Add(txtpstokg);
            panel1.Controls.Add(txtpkategorig);
            panel1.Controls.Add(txtpfiyatg);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnstokguncelle);
            panel1.Controls.Add(urunkod);
            panel1.Controls.Add(txtpadg);
            panel1.Controls.Add(txtpcodeg);
            panel1.Controls.Add(urunadi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 562);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // txtpkritikstokg
            // 
            txtpkritikstokg.Location = new Point(624, 369);
            txtpkritikstokg.Margin = new Padding(3, 4, 3, 4);
            txtpkritikstokg.Name = "txtpkritikstokg";
            txtpkritikstokg.Size = new Size(215, 31);
            txtpkritikstokg.TabIndex = 40;
            // 
            // txtpstokg
            // 
            txtpstokg.Location = new Point(624, 308);
            txtpstokg.Margin = new Padding(3, 4, 3, 4);
            txtpstokg.Name = "txtpstokg";
            txtpstokg.Size = new Size(215, 31);
            txtpstokg.TabIndex = 39;
            // 
            // txtpkategorig
            // 
            txtpkategorig.Location = new Point(624, 246);
            txtpkategorig.Margin = new Padding(3, 4, 3, 4);
            txtpkategorig.Name = "txtpkategorig";
            txtpkategorig.Size = new Size(215, 31);
            txtpkategorig.TabIndex = 38;
            // 
            // txtpfiyatg
            // 
            txtpfiyatg.Location = new Point(624, 185);
            txtpfiyatg.Margin = new Padding(3, 4, 3, 4);
            txtpfiyatg.Name = "txtpfiyatg";
            txtpfiyatg.Size = new Size(215, 31);
            txtpfiyatg.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(430, 191);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 36;
            label5.Text = "Ürün Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(430, 252);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 35;
            label4.Text = "Ürün Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(430, 375);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 34;
            label2.Text = "Kritik Stok:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(430, 314);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 33;
            label1.Text = "Stok:";
            // 
            // btnstokguncelle
            // 
            btnstokguncelle.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnstokguncelle.Location = new Point(589, 460);
            btnstokguncelle.Margin = new Padding(3, 4, 3, 4);
            btnstokguncelle.Name = "btnstokguncelle";
            btnstokguncelle.Size = new Size(109, 48);
            btnstokguncelle.TabIndex = 32;
            btnstokguncelle.Text = "Güncelle";
            btnstokguncelle.UseVisualStyleBackColor = true;
            btnstokguncelle.Click += btnstokguncelle_Click;
            // 
            // urunkod
            // 
            urunkod.AutoSize = true;
            urunkod.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            urunkod.Location = new Point(430, 75);
            urunkod.Name = "urunkod";
            urunkod.Size = new Size(110, 21);
            urunkod.TabIndex = 31;
            urunkod.Text = "Ürün Kodu:";
            // 
            // txtpadg
            // 
            txtpadg.Location = new Point(624, 130);
            txtpadg.Margin = new Padding(3, 4, 3, 4);
            txtpadg.Name = "txtpadg";
            txtpadg.Size = new Size(215, 31);
            txtpadg.TabIndex = 30;
            // 
            // txtpcodeg
            // 
            txtpcodeg.Location = new Point(624, 69);
            txtpcodeg.Margin = new Padding(3, 4, 3, 4);
            txtpcodeg.Name = "txtpcodeg";
            txtpcodeg.Size = new Size(215, 31);
            txtpcodeg.TabIndex = 29;
            // 
            // urunadi
            // 
            urunadi.AutoSize = true;
            urunadi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            urunadi.Location = new Point(430, 136);
            urunadi.Name = "urunadi";
            urunadi.Size = new Size(92, 21);
            urunadi.TabIndex = 28;
            urunadi.Text = "Ürün Adı:";
            // 
            // stockItemUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "stockItemUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Item Update";
            Load += stokurunguncelle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public PictureBox pictureBox1;
        public TextBox txtpkritikstokg;
        public TextBox txtpstokg;
        public TextBox txtpkategorig;
        public TextBox txtpfiyatg;
        public Label label5;
        public Label label4;
        public Label label2;
        public Label label1;
        public Button btnstokguncelle;
        public Label urunkod;
        public TextBox txtpadg;
        public TextBox txtpcodeg;
        public Label urunadi;
    }
}