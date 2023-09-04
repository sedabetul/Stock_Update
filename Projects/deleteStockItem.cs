using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess1;
using Entity1Layer;
using System.Data.Entity;
using Projects;
using codeFirstStok;


namespace Projects
{
    public partial class deleteStockItem : Form
    {
        public deleteStockItem()
        {
            InitializeComponent();
        }



        private void btnstoksil_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new Context();
                int Id = Convert.ToInt32(txtpcodes.Text);
                var urunId = context.stocks.Where(p => p.Id == Id).FirstOrDefault();


                if (urunId != null)
                {
                    urunId.p_name = txtpads.Text;
                    context.stocks.Remove(urunId);
                    context.SaveChanges();
                    MessageBox.Show("Ürün Başarıyla Silindi:)");
                    this.Hide();
                    adminAuthority adminyetki = new adminAuthority();
                    adminyetki.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
              
            }

        }

        private void stokurunsil_Load(object sender, EventArgs e)
        {

        }
    }
}
