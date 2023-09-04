using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// veritabanını oluşturmak için proje ismi.entity yazılır.
using System.Data.Entity;
using DataAccess1;
using Entity1Layer;
using Projects;
using codeFirstStok;


namespace Projects
{
    public partial class userRegister : Form
    {
        public userRegister()
        {
            InitializeComponent();
        }





        private void kullanıcıkayit_Load(object sender, EventArgs e)
        {


            kodolustur();
           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new Context();
                user u = new user();
                u.u_name = u_ad.Text;
                u.u_password = u_sifre.Text;
                u.u_authority = 0;

                context.users.Add(u);
                context.SaveChanges();

                if (txtdogrulama.Text == textBox1.Text)
                {
                    MessageBox.Show("Kayıt Başarıyla Tamamlandı");
                    this.Dispose();
                    userAuthorization kullaniciyetki = new userAuthorization();
                    kullaniciyetki.kullaniciaditasi = u_ad.Text;
                    kullaniciyetki.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen Doğrulama Kodunu Doğru Girdiğinizden Emin OLup Tekrar Deneyin");
                }

                //this.Hide();
                //userAuthorization kullaniciyetki = new userAuthorization();
                //kullaniciyetki.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void kodolustur()
        {
            Random randomsayi = new Random();
            int dogrulamakodu1 = randomsayi.Next(1000, 100000);
            txtdogrulama.Text = dogrulamakodu1.ToString();
        }
    }
}
