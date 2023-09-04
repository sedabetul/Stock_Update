namespace codeFirstStok
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnstoksil = new System.Windows.Forms.Button();
            this.urunkod = new System.Windows.Forms.Label();
            this.txtpads = new System.Windows.Forms.TextBox();
            this.txtpcodes = new System.Windows.Forms.TextBox();
            this.urunadi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnstoksil);
            this.panel1.Controls.Add(this.urunkod);
            this.panel1.Controls.Add(this.txtpads);
            this.panel1.Controls.Add(this.txtpcodes);
            this.panel1.Controls.Add(this.urunadi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 394);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnstoksil
            // 
            this.btnstoksil.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstoksil.Location = new System.Drawing.Point(522, 243);
            this.btnstoksil.Name = "btnstoksil";
            this.btnstoksil.Size = new System.Drawing.Size(75, 38);
            this.btnstoksil.TabIndex = 32;
            this.btnstoksil.Text = "Sil";
            this.btnstoksil.UseVisualStyleBackColor = true;
            this.btnstoksil.Click += new System.EventHandler(this.btnstoksil_Click);
            // 
            // urunkod
            // 
            this.urunkod.AutoSize = true;
            this.urunkod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunkod.Location = new System.Drawing.Point(394, 123);
            this.urunkod.Name = "urunkod";
            this.urunkod.Size = new System.Drawing.Size(110, 21);
            this.urunkod.TabIndex = 31;
            this.urunkod.Text = "Ürün Kodu:";
            // 
            // txtpads
            // 
            this.txtpads.Location = new System.Drawing.Point(540, 167);
            this.txtpads.Name = "txtpads";
            this.txtpads.Size = new System.Drawing.Size(194, 26);
            this.txtpads.TabIndex = 30;
            // 
            // txtpcodes
            // 
            this.txtpcodes.Location = new System.Drawing.Point(540, 118);
            this.txtpcodes.Name = "txtpcodes";
            this.txtpcodes.Size = new System.Drawing.Size(194, 26);
            this.txtpcodes.TabIndex = 29;
            // 
            // urunadi
            // 
            this.urunadi.AutoSize = true;
            this.urunadi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunadi.Location = new System.Drawing.Point(394, 172);
            this.urunadi.Name = "urunadi";
            this.urunadi.Size = new System.Drawing.Size(92, 21);
            this.urunadi.TabIndex = 28;
            this.urunadi.Text = "Ürün Adı:";
            // 
            // deleteStockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 394);
            this.Controls.Add(this.panel1);
            this.Name = "deleteStockItem";
            this.Text = "Delete Stock Item";
            this.Load += new System.EventHandler(this.stokurunsil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnstoksil;
        private System.Windows.Forms.Label urunkod;
        private System.Windows.Forms.TextBox txtpads;
        private System.Windows.Forms.TextBox txtpcodes;
        private System.Windows.Forms.Label urunadi;
    }
}