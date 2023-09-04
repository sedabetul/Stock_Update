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

namespace codeFirstStok
{
    public partial class userAuthorization : Form
    {
        public userAuthorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login(); 
            l.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank c= new bank();
            c.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            homePage anasayfa = new homePage();
            anasayfa.ShowDialog();
        }

        private void kullaniciyetki_Load(object sender, EventArgs e)
        {

        }
    }
}
