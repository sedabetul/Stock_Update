
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataAccess1;
using Entity1Layer;
using Projects;
using codeFirstStok;
using System.Runtime.CompilerServices;

namespace Projects
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }


        public enum UserRole
        {
            User,
            Admin
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {









        }

        private void login_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnkaydet_Click_1(object sender, EventArgs e)
        {

            //    // Kullanıcı giriş işlemi
            string username = u_ad.Text;
            string password = u_sifre.Text;


            if (AuthenticateUser(username, password))
            {

                UserRole userRole = GetUserRole(username);

                OpenAppropriateForm(userRole);//kullanıcı rolüne uygun sayfayı açar

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }

        }

        private bool AuthenticateUser(string username, string password)
        {
            return (username == "admin" && password == "admin123") || (username == "user" && password == "user123");
        }

        private UserRole GetUserRole(string username)
        {

            if (username == "admin")
                return UserRole.Admin;


            else
                return UserRole.User;

        }

        public void OpenAppropriateForm(UserRole userRole)
        {

            if (userRole == UserRole.Admin)
            {

                adminAuthority admin = new adminAuthority();

                admin.ShowDialog();



            }
            else if (userRole == UserRole.User)

            {
                userRegister kk = new userRegister();



                kk.Show();

            }





        }


        private void ad_Click(object sender, EventArgs e)
        {

        }

        public void btnbeyaz_Click(object sender, EventArgs e)
        {
            beyaztema();




        }

        public void btnsiyah_Click(object sender, EventArgs e)
        {
            siyahtema();
            //  temadegistir(ActiveForm);


        }

        public void beyaztema()
        {
            panel1.BackColor = Color.WhiteSmoke;
            panel1.ForeColor = Color.Black;



        }

        public void siyahtema()
        {
            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.WhiteSmoke;
            pictureBox1.BackColor = Color.WhiteSmoke;
            btnkaydet.BackColor = Color.LightCoral;

            //temadegistir(ActiveForm);

        }
        public void temadegistir(Form form)
        {
            form.BackColor = Color.FromArgb(26, 27, 22);

            foreach (Control panel1 in form.Controls)
            {
                if (panel1.GetType() == typeof(Panel))
                {
                    panel1.BackColor = Color.FromArgb(43, 64, 53);
                }
            }



            foreach (Control button in form.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    button.BackColor = Color.FromArgb(43, 64, 53);
                    button.ForeColor = Color.WhiteSmoke;
                }
            }



            foreach (Control label in form.Controls)
            {
                if (label.GetType() == typeof(Label))
                {
                    label.ForeColor = Color.WhiteSmoke;
                }
            }

        }

    }
}












