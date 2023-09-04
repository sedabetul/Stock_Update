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
using Projects;

namespace Projects
{
    public partial class adminAuthority : Form
    {
        public adminAuthority()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductToStock addProductToStock = new AddProductToStock();
            addProductToStock.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockItemUpdate sIu = new stockItemUpdate();
            sIu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteStockItem deleteStockItem = new deleteStockItem();
            deleteStockItem.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank b = new bank();
            b.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            hp.ShowDialog();
        }

        private void adminAuthority_Load(object sender, EventArgs e)
        {

        }
    }
}
