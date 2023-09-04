namespace Projects
{
    partial class deleteStockItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteStockItem));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnstoksil = new Button();
            urunkod = new Label();
            txtpads = new TextBox();
            txtpcodes = new TextBox();
            urunadi = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnstoksil);
            panel1.Controls.Add(urunkod);
            panel1.Controls.Add(txtpads);
            panel1.Controls.Add(txtpcodes);
            panel1.Controls.Add(urunadi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 492);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 492);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // btnstoksil
            // 
            btnstoksil.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnstoksil.Location = new Point(580, 304);
            btnstoksil.Margin = new Padding(3, 4, 3, 4);
            btnstoksil.Name = "btnstoksil";
            btnstoksil.Size = new Size(128, 48);
            btnstoksil.TabIndex = 32;
            btnstoksil.Text = "Sil";
            btnstoksil.UseVisualStyleBackColor = true;
            btnstoksil.Click += btnstoksil_Click;
            // 
            // urunkod
            // 
            urunkod.AutoSize = true;
            urunkod.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            urunkod.Location = new Point(438, 154);
            urunkod.Name = "urunkod";
            urunkod.Size = new Size(110, 21);
            urunkod.TabIndex = 31;
            urunkod.Text = "Ürün Kodu:";
            // 
            // txtpads
            // 
            txtpads.Location = new Point(600, 209);
            txtpads.Margin = new Padding(3, 4, 3, 4);
            txtpads.Name = "txtpads";
            txtpads.Size = new Size(215, 31);
            txtpads.TabIndex = 30;
            // 
            // txtpcodes
            // 
            txtpcodes.Location = new Point(600, 148);
            txtpcodes.Margin = new Padding(3, 4, 3, 4);
            txtpcodes.Name = "txtpcodes";
            txtpcodes.Size = new Size(215, 31);
            txtpcodes.TabIndex = 29;
            // 
            // urunadi
            // 
            urunadi.AutoSize = true;
            urunadi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            urunadi.Location = new Point(438, 215);
            urunadi.Name = "urunadi";
            urunadi.Size = new Size(92, 21);
            urunadi.TabIndex = 28;
            urunadi.Text = "Ürün Adı:";
            // 
            // deleteStockItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 492);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "deleteStockItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Stock Item";
            Load += stokurunsil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnstoksil;
        private Label urunkod;
        private TextBox txtpads;
        private TextBox txtpcodes;
        private Label urunadi;
    }
}