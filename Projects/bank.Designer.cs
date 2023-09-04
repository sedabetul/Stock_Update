namespace Projects
{
    partial class bank
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bank));
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtid = new TextBox();
            txtprice = new TextBox();
            txtname = new TextBox();
            btnsepetekle = new Button();
            btnsepetsil = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnanasayfa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(800, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 1;
            label1.Text = "Ürün barkodu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 101);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 154);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 3;
            label3.Text = "Ürün Fiyatı:";
            // 
            // txtid
            // 
            txtid.Location = new Point(182, 43);
            txtid.Name = "txtid";
            txtid.Size = new Size(150, 31);
            txtid.TabIndex = 4;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(182, 148);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(150, 31);
            txtprice.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.Location = new Point(182, 95);
            txtname.Name = "txtname";
            txtname.Size = new Size(150, 31);
            txtname.TabIndex = 6;
            // 
            // btnsepetekle
            // 
            btnsepetekle.Location = new Point(380, 70);
            btnsepetekle.Name = "btnsepetekle";
            btnsepetekle.Size = new Size(168, 34);
            btnsepetekle.TabIndex = 7;
            btnsepetekle.Text = "Ürünü Sepete Ekle";
            btnsepetekle.UseVisualStyleBackColor = true;
            btnsepetekle.Click += btnsepetekle_Click;
            // 
            // btnsepetsil
            // 
            btnsepetsil.Location = new Point(380, 120);
            btnsepetsil.Name = "btnsepetsil";
            btnsepetsil.Size = new Size(168, 34);
            btnsepetsil.TabIndex = 8;
            btnsepetsil.Text = "Ürünü Sil";
            btnsepetsil.UseVisualStyleBackColor = true;
            btnsepetsil.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(607, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btnanasayfa);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnsepetsil);
            panel1.Controls.Add(btnsepetekle);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(txtprice);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 454);
            panel1.TabIndex = 0;
            // 
            // btnanasayfa
            // 
            btnanasayfa.Location = new Point(380, 170);
            btnanasayfa.Name = "btnanasayfa";
            btnanasayfa.Size = new Size(168, 34);
            btnanasayfa.TabIndex = 10;
            btnanasayfa.Text = "Anasayfaya Dön";
            btnanasayfa.UseVisualStyleBackColor = true;
            btnanasayfa.Click += btnanasayfa_Click;
            // 
            // bank
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 454);
            Controls.Add(panel1);
            Name = "bank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bank";
            Load += bank_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtid;
        private TextBox txtprice;
        private TextBox txtname;
        private Button btnsepetekle;
        private Button btnsepetsil;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnanasayfa;
    }
}