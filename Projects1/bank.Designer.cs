namespace codeFirstStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bank));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnsepetsil = new Button();
            btnsepetekle = new Button();
            txtname = new TextBox();
            txtprice = new TextBox();
            txtid = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnsepetsil);
            panel1.Controls.Add(btnsepetekle);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(txtprice);
            panel1.Controls.Add(txtid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 546);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(577, 70);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 287);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(804, 259);
            dataGridView1.TabIndex = 8;
            // 
            // btnsepetsil
            // 
            btnsepetsil.Location = new Point(239, 191);
            btnsepetsil.Margin = new Padding(3, 4, 3, 4);
            btnsepetsil.Name = "btnsepetsil";
            btnsepetsil.Size = new Size(156, 48);
            btnsepetsil.TabIndex = 5;
            btnsepetsil.Text = "Sepeti Sil";
            btnsepetsil.UseVisualStyleBackColor = true;
            btnsepetsil.Click += btnsepetsil_Click;
            // 
            // btnsepetekle
            // 
            btnsepetekle.Location = new Point(239, 86);
            btnsepetekle.Margin = new Padding(3, 4, 3, 4);
            btnsepetekle.Name = "btnsepetekle";
            btnsepetekle.Size = new Size(156, 48);
            btnsepetekle.TabIndex = 4;
            btnsepetekle.Text = "Sepete Ekle";
            btnsepetekle.UseVisualStyleBackColor = true;
            btnsepetekle.Click += btnsepetekle_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(59, 140);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(111, 31);
            txtname.TabIndex = 3;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(59, 222);
            txtprice.Margin = new Padding(3, 4, 3, 4);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(111, 31);
            txtprice.TabIndex = 2;
            // 
            // txtid
            // 
            txtid.Location = new Point(59, 52);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(111, 31);
            txtid.TabIndex = 1;
            // 
            // bank
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 546);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "bank";
            Text = "Hamper";
            Load += cuzdan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnsepetekle;
        private TextBox txtname;
        private TextBox txtprice;
        private TextBox txtid;
        private Button btnsepetsil;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}