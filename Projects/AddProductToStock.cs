using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projects;
using System.Data.Entity;
using codeFirstStok;
using System.Collections;
using DataAccess1;
using Entity1Layer;




namespace Projects

{
    public partial class AddProductToStock : Form
    {
        public AddProductToStock()
        {
            InitializeComponent();


        }


        private void btnstokkaydet_Click(object sender, EventArgs e)
        {
            try
            {
              
                 var context = new Context();
                stock s = new stock();
                s.Id = Convert.ToInt32(txtpcode.Text);  //p_code du
                s.p_name = txtpad.Text;
                s.p_price = Convert.ToInt32(txtpfiyat.Text);
                s.p_category = txtpkategori.Text;
                s.p_stok = Convert.ToInt32(txtpstok.Text);
                s.p_pic = resimPath;
            
                s.critical_stock = Convert.ToInt32(txtpkritikstok.Text);
                context.stocks.Add(s);
                context.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Kaydedildi :)");
                this.Dispose();
                adminAuthority ay = new adminAuthority();
                ay.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stokurunekle_Load(object sender, EventArgs e)
        {

        }

        private void txturunresmi_TextChanged(object sender, EventArgs e)
        {

        }



        private void urunresim_Click(object sender, EventArgs e)
        {

        }

        private void btnresimekle_Click(object sender, EventArgs e)
        {


        }
        string resimPath = string.Empty;
        private void pic_Click(object sender, EventArgs e)
        {
            var context= new Context();
            stock s= new stock();
            openFileDialog1.Title = "Resim Seçme Kutusu";
            openFileDialog1.FileName = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|PNG Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(openFileDialog1.FileName);
               resimPath = openFileDialog1.FileName.ToString();
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                s.p_pic = resimPath;
                context.stocks.Add(s);
                context.SaveChanges();

            }
        }
    }
}









