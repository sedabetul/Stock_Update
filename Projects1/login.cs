
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
using codeFirstStok;

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

            // Kullanıcı giriş işlemi
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

        private void OpenAppropriateForm(UserRole userRole)
        {

            if (userRole == UserRole.Admin)
            {

                // admin sayfama yönlendiriyor
                adminAuthority ay = new adminAuthority();
                ay.Show();
            }
            else if (userRole == UserRole.User)

            {

                //Kullanıcı sayfamı açmak için
                userRegister kk = new userRegister();
                kk.Show();
            }


            this.Hide();









        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
