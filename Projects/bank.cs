using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using codeFirstStok;  // veritabanını oluşturmak için proje ismi.entity yazılır.
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using DataAccess1;
using Entity1Layer;
using Projects;
using System.Xml.Linq;

namespace Projects
{
    public partial class bank : Form
    {
        public bank()
        {
            InitializeComponent();
        }


        List<stock> sepet = new List<stock>();




        private void btnsepetekle_Click(object sender, EventArgs e)
        {
            var context = new Context();

            string urunAdi = txtname.Text;
            int fiyat = Convert.ToInt32(txtprice.Text);
            int Id = Convert.ToInt32(txtid.Text);


            stock yeniOge = new stock
            {
                p_name = urunAdi,
                p_price = fiyat,
                Id = Id
            };

            sepet.Add(yeniOge);
            dataGridView1.DataSource = sepet;

          //  dataGridView1.DataSource =context.stocks.Where(src => src.p_name == urunAdi && src.Id == Id).ToList();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            string urunAdi = txtname.Text;
            int fiyat = Convert.ToInt32(txtprice.Text);
            int Id = Convert.ToInt32(txtid.Text);



            var oge = sepet.FirstOrDefault(x => x.Id == Id);

            if (oge != null)
            {

                sepet.Remove(oge);
              dataGridView1.DataSource = sepet.ToList();
              
            }
        }

        private void bank_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                pictureBox1.BackColor = Color.Tomato;
            }
            else
            {
                pictureBox1.BackColor = Color.WhiteSmoke;
            }
            if (sayac == 10)
            {
                sayac = 0;
            }
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
           
            homePage homePage = new homePage();
            homePage.Show();
        }
    }
}
