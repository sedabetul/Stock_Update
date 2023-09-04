using codeFirstStok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess1;
using Entity1Layer;
using Projects;
using System.Runtime.CompilerServices;

namespace Projects
{
    public partial class adminAuthority : Form
    {
        public adminAuthority()
        {
            InitializeComponent();

        }



        private void adminAuthority_Load(object sender, EventArgs e)
        {

        }

        private void btnstokurunekle_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AddProductToStock addProductToStock = new AddProductToStock();
            addProductToStock.ShowDialog();

        }

        private void btnstokguncelle_Click(object sender, EventArgs e)
        {
            this.Dispose();
            stockItemUpdate sIu = new stockItemUpdate();
            sIu.ShowDialog();
        }

        private void btnstoksil_Click(object sender, EventArgs e)
        {
            this.Dispose();
            deleteStockItem deleteStockItem = new deleteStockItem();
            deleteStockItem.ShowDialog();
        }

        private void btnsepet_Click(object sender, EventArgs e)
        {

            bank bank = new bank();
            bank.Show();

        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            this.Dispose();
            homePage hp = new homePage();
            hp.ShowDialog();
        }

        private void adminAuthority_Load_1(object sender, EventArgs e)
        {

        }

        private void btnsiyah_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox6.BackColor = Color.WhiteSmoke;

        }

        private void btnbeyaz_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.WhiteSmoke;
            groupBox1.BackColor = Color.PowderBlue;
            groupBox3.BackColor = Color.PowderBlue;
            groupBox6.BackColor = Color.PowderBlue;
        }





    }
}
