using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess1;  // veritabanını oluşturmak için proje ismi.entity yazılır.
using Entity1Layer;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Projects;
using codeFirstStok;






namespace Projects
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           Context c = new Context();     // veritabanını oluşturmak için
            if (!c.Database.Exists())        //Veritabanının sunucuda var olup olmadığını denetler.
            {
                c.Database.Create();
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProductToStock sue = new AddProductToStock();
            sue.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stockItemUpdate sug = new stockItemUpdate();
            sug.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            deleteStockItem sus = new deleteStockItem();
            sus.ShowDialog();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button7_Click(object sender, EventArgs e)
        {
            var context = new Context();
            string aranan = txtbulad.Text;
          

            dataGridView1.DataSource = context.stocks.Where(item =>item.p_name.StartsWith(aranan)).ToList();

            txtbulad.Text =string.Empty;
            txtbulId.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new Context();
                //List<stock> list1 = context.stocks.OrderBy(p => p.p_name).ToList();
                //dataGridView1.DataSource = list1;
                //dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
                //dataGridView1.Columns[6].Visible = false;
                //dataGridView1.Columns[7].Visible = false;
                //dataGridView1.Columns[8].Visible = false;
                //dataGridView1.Columns[9].Visible = false;
                //dataGridView1.Columns[10].Visible = false;

                
                dataGridView1.DataSource = context.stocks.OrderBy(item => item.p_name).ToList();
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);  //Stack trace, kodun hangi sıralamada hangi yöntemlerin çağrıldığını ve hangi dosya ve satırlarda hatalı durumun meydana geldiğini gösteren bir dizi bilgidir.
            }




        }

        private void button9_Click(object sender, EventArgs e)
        {
            var context = new Context();
            //var maxfiyat = context.stocks.Max(p => p.p_price);
            //MessageBox.Show(maxfiyat.ToString());


            MessageBox.Show(context.stocks.Max(item=>item.p_price).ToString());

       
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var context = new Context();
            //var maxfiyat = context.stocks.Min(p => p.p_price);
            //MessageBox.Show(maxfiyat.ToString());

            MessageBox.Show(context.stocks.Min(item=>item.p_price).ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userAuthorization ky = new userAuthorization();
            ky.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            login ay = new login();
            ay.ShowDialog();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnbeyaz_Click(object sender, EventArgs e)
        {


        }




        public void btnsiyah_Click(object sender, EventArgs e)
        {


        }

        private void btnsiyah_Click_1(object sender, EventArgs e)
        {

            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.WhiteSmoke;
            pictureBox1.BackColor = Color.WhiteSmoke;

        }

        private void btnbeyazyap_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
            panel1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbulId.Text = string.Empty;
            txtbulad.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbulId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbulad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
