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
using codeFirstStok;
using Projects;

namespace Projects
{
    public partial class userAuthorization : Form
    {
        public userAuthorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login l = new login();
            l.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Dispose();
            bank b = new bank();
            b.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            homePage anasayfa = new homePage();
            anasayfa.ShowDialog(); 
           
        }

        public string kullaniciaditasi;
        private void kullaniciyetki_Load(object sender, EventArgs e)
        {
            lblad.Text = kullaniciaditasi;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
