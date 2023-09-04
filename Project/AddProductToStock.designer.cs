namespace codeFirstStok
{
    partial class AddProductToStock
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
            panel1 = new Panel();
            pic = new PictureBox();
            txtpkritikstok = new TextBox();
            txtpstok = new TextBox();
            txtpkategori = new TextBox();
            txtpfiyat = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnstokkaydet = new Button();
            urunkod = new Label();
            txtpad = new TextBox();
            txtpcode = new TextBox();
            urunadi = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(pic);
            panel1.Controls.Add(txtpkritikstok);
            panel1.Controls.Add(txtpstok);
            panel1.Controls.Add(txtpkategori);
            panel1.Controls.Add(txtpfiyat);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnstokkaydet);
            panel1.Controls.Add(urunkod);
            panel1.Controls.Add(txtpad);
            panel1.Controls.Add(txtpcode);
            panel1.Controls.Add(urunadi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 612);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pic
            // 
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Dock = DockStyle.Left;
            pic.Location = new Point(0, 0);
            pic.Margin = new Padding(3, 4, 3, 4);
            pic.Name = "pic";
            pic.Size = new Size(405, 553);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 29;
            pic.TabStop = false;
            pic.Click += pic_Click;
            // 
            // txtpkritikstok
            // 
            txtpkritikstok.Location = new Point(630, 408);
            txtpkritikstok.Margin = new Padding(3, 4, 3, 4);
            txtpkritikstok.Name = "txtpkritikstok";
            txtpkritikstok.Size = new Size(215, 31);
            txtpkritikstok.TabIndex = 27;
            // 
            // txtpstok
            // 
            txtpstok.Location = new Point(630, 346);
            txtpstok.Margin = new Padding(3, 4, 3, 4);
            txtpstok.Name = "txtpstok";
            txtpstok.Size = new Size(215, 31);
            txtpstok.TabIndex = 26;
            // 
            // txtpkategori
            // 
            txtpkategori.Location = new Point(630, 285);
            txtpkategori.Margin = new Padding(3, 4, 3, 4);
            txtpkategori.Name = "txtpkategori";
            txtpkategori.Size = new Size(215, 31);
            txtpkategori.TabIndex = 25;
            // 
            // txtpfiyat
            // 
            txtpfiyat.Location = new Point(630, 224);
            txtpfiyat.Margin = new Padding(3, 4, 3, 4);
            txtpfiyat.Name = "txtpfiyat";
            txtpfiyat.Size = new Size(215, 31);
            txtpfiyat.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(436, 230);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 23;
            label5.Text = "Ürün Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(436, 291);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 22;
            label4.Text = "Ürün Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(436, 414);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 20;
            label2.Text = "Kritik Stok:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(436, 352);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 19;
            label1.Text = "Stok:";
            // 
            // btnstokkaydet
            // 
            btnstokkaydet.Dock = DockStyle.Bottom;
            btnstokkaydet.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnstokkaydet.Location = new Point(0, 553);
            btnstokkaydet.Margin = new Padding(3, 4, 3, 4);
            btnstokkaydet.Name = "btnstokkaydet";
            btnstokkaydet.Size = new Size(889, 59);
            btnstokkaydet.TabIndex = 17;
            btnstokkaydet.Text = "Ekle";
            btnstokkaydet.UseVisualStyleBackColor = true;
            btnstokkaydet.Click += btnstokkaydet_Click;
            // 
            // urunkod
            // 
            urunkod.AutoSize = true;
            urunkod.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            urunkod.Location = new Point(436, 114);
            urunkod.Name = "urunkod";
            urunkod.Size = new Size(110, 21);
            urunkod.TabIndex = 16;
            urunkod.Text = "Ürün Kodu:";
            // 
            // txtpad
            // 
            txtpad.Location = new Point(630, 169);
            txtpad.Margin = new Padding(3, 4, 3, 4);
            txtpad.Name = "txtpad";
            txtpad.Size = new Size(215, 31);
            txtpad.TabIndex = 15;
            // 
            // txtpcode
            // 
            txtpcode.Location = new Point(630, 108);
            txtpcode.Margin = new Padding(3, 4, 3, 4);
            txtpcode.Name = "txtpcode";
            txtpcode.Size = new Size(215, 31);
            txtpcode.TabIndex = 14;
            // 
            // urunadi
            // 
            urunadi.AutoSize = true;
            urunadi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            urunadi.Location = new Point(436, 175);
            urunadi.Name = "urunadi";
            urunadi.Size = new Size(92, 21);
            urunadi.TabIndex = 13;
            urunadi.Text = "Ürün Adı:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddProductToStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 612);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddProductToStock";
            Text = "Add Product To Stock";
            Load += stokurunekle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnstokkaydet;
        private Label urunkod;
        private TextBox txtpad;
        private TextBox txtpcode;
        private Label urunadi;
        private TextBox txtpkritikstok;
        private TextBox txtpstok;
        private TextBox txtpkategori;
        private TextBox txtpfiyat;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pic;
    }
}