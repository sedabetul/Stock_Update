namespace Projects
{
    partial class homePage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox6 = new GroupBox();
            button2 = new Button();
            btnbeyazyap = new Button();
            btnsiyahyap = new Button();
            button8 = new Button();
            button10 = new Button();
            button9 = new Button();
            label3 = new Label();
            label2 = new Label();
            txtbulad = new TextBox();
            txtbulId = new TextBox();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 807);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 434);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1222, 373);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Rol Belirleme";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Location = new Point(650, 75);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(222, 277);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Admin";
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkRed;
            button6.Location = new Point(23, 214);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(181, 45);
            button6.TabIndex = 4;
            button6.Text = "Ayarlar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 42);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(304, 75);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(222, 277);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcı";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(21, 214);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(181, 45);
            button1.TabIndex = 2;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 42);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button2);
            groupBox6.Controls.Add(btnbeyazyap);
            groupBox6.Controls.Add(btnsiyahyap);
            groupBox6.Controls.Add(button8);
            groupBox6.Controls.Add(button10);
            groupBox6.Controls.Add(button9);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(txtbulad);
            groupBox6.Controls.Add(txtbulId);
            groupBox6.Controls.Add(button7);
            groupBox6.Controls.Add(dataGridView1);
            groupBox6.Dock = DockStyle.Top;
            groupBox6.Location = new Point(0, 0);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(1222, 443);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Filtrele";
            groupBox6.Enter += groupBox6_Enter;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkRed;
            button2.Location = new Point(23, 300);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(171, 45);
            button2.TabIndex = 27;
            button2.Text = "Buton Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnbeyazyap
            // 
            btnbeyazyap.BackColor = Color.White;
            btnbeyazyap.Image = (Image)resources.GetObject("btnbeyazyap.Image");
            btnbeyazyap.Location = new Point(332, 253);
            btnbeyazyap.Name = "btnbeyazyap";
            btnbeyazyap.Size = new Size(60, 60);
            btnbeyazyap.TabIndex = 26;
            btnbeyazyap.UseVisualStyleBackColor = false;
            btnbeyazyap.Click += btnbeyazyap_Click;
            // 
            // btnsiyahyap
            // 
            btnsiyahyap.BackColor = Color.Black;
            btnsiyahyap.Image = (Image)resources.GetObject("btnsiyahyap.Image");
            btnsiyahyap.Location = new Point(237, 253);
            btnsiyahyap.Name = "btnsiyahyap";
            btnsiyahyap.Size = new Size(60, 60);
            btnsiyahyap.TabIndex = 25;
            btnsiyahyap.UseVisualStyleBackColor = false;
            btnsiyahyap.Click += btnsiyah_Click_1;
            // 
            // button8
            // 
            button8.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkRed;
            button8.Location = new Point(23, 234);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(171, 45);
            button8.TabIndex = 20;
            button8.Text = "Minimum Fiyat";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.DarkRed;
            button10.Location = new Point(23, 100);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(171, 45);
            button10.TabIndex = 19;
            button10.Text = "Sırala(A-->Z)";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.DarkRed;
            button9.Location = new Point(23, 166);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(171, 45);
            button9.TabIndex = 18;
            button9.Text = "Maximum Fiyat";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 172);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 16;
            label3.Text = "Ürün Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 90);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 15;
            label2.Text = "Ürün Id:";
            // 
            // txtbulad
            // 
            txtbulad.Location = new Point(237, 200);
            txtbulad.Margin = new Padding(3, 4, 3, 4);
            txtbulad.Name = "txtbulad";
            txtbulad.Size = new Size(153, 31);
            txtbulad.TabIndex = 14;
            // 
            // txtbulId
            // 
            txtbulId.Location = new Point(237, 122);
            txtbulId.Margin = new Padding(3, 4, 3, 4);
            txtbulId.Name = "txtbulId";
            txtbulId.Size = new Size(153, 31);
            txtbulId.TabIndex = 12;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkRed;
            button7.Location = new Point(23, 36);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(171, 45);
            button7.TabIndex = 4;
            button7.Text = "Bul";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(418, 36);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(797, 289);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1222, 807);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "homePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox6;
        private Button button7;
        private TextBox txtbulad;
        private TextBox txtbulId;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Button button10;
        private Button button9;
        private Button button8;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button6;
        private Button btnbeyazyap;
        private Button btnsiyahyap;
        private Button button2;
    }
}

