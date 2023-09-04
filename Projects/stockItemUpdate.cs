using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Projects;
using codeFirstStok;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess1;
using Entity1Layer;


namespace Projects
{
    public partial class stockItemUpdate : Form
    {
        public stockItemUpdate()
        {
            InitializeComponent();
        }

        private void stokurunguncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnstokguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new Context();
                int Id = Convert.ToInt32(txtpcodeg.Text);


                var urunId = context.stocks.Where(p => p.Id == Id).FirstOrDefault();


                if (urunId != null)
                {
                    urunId.p_name = txtpadg.Text;
                    urunId.p_price = Convert.ToInt32(txtpfiyatg.Text);
                    urunId.p_category = txtpkategorig.Text;
                    urunId.p_stok = Convert.ToInt32(txtpstokg.Text);
                    urunId.critical_stock = Convert.ToInt32(txtpkritikstokg.Text);
                    context.SaveChanges();
                    MessageBox.Show("Ürün Başarıyla Güncellendi :)");
                }
                this.Dispose();
                adminAuthority adminyetki = new adminAuthority();
                adminyetki.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }


        }
    }
}
