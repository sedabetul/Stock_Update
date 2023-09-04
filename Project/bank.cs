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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

using System.Collections;
using DataAccess1;
using Entity1Layer;

namespace codeFirstStok
{


    public partial class bank : Form
    {
        public bank()
        {
            InitializeComponent();


        }

       

 List<stock> sepet = new List<stock>();



        private void cuzdan_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
      
        
       
        private void btnsepetekle_Click(object sender, EventArgs e)  
        {

            var context = new Context();

            string urunAdi=txtname.Text;
            int fiyat=Convert.ToInt32(txtprice.Text);
            int Id= Convert.ToInt32(txtid.Text);


            stock yeniOge = new stock
            {
                p_name = urunAdi,
                p_price = fiyat,
                Id = Id
            };

            sepet.Add(yeniOge);

            dataGridView1.DataSource= sepet.ToList();




        }


    



        private void btnsepetsil_Click(object sender, EventArgs e)
        {
           
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



       








        

    }
}
    
