using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Famões_Clube_Atlético
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/famoes.c.a/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/famoesclubeatletico");
        }
    }
}
