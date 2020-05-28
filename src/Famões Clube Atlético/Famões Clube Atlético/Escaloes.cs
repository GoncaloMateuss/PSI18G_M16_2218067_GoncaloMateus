using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Famões_Clube_Atlético
{
    public partial class Escaloes : UserControl
    {
        public Escaloes()
        {
            InitializeComponent();
        }

        private void Escaloes_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string escaloes = Convert.ToString(comboBox1.Text);
            if (escaloes == "1999" || escaloes == "2000")
            {
                label3.Text = "Juniores B";
            }
            else if (escaloes == "2001" || escaloes == "2002")
            {
                label3.Text = "Juniores A";
            }
            else if (escaloes == "2003")
            {
                label3.Text = "Juvenis";
            }
            else if (escaloes == "2004")
            {
                label3.Text = "Cadetes";
            }
            else if (escaloes == "2005")
            {
                label3.Text = "Iniciados";
            }
            else if (escaloes == "2006")
            {
                label3.Text = "Infantis";
            }
            else if (escaloes == "2007" || escaloes == "2008")
            {
                label3.Text = "Minis B";
            }
            else if (escaloes == "+2009")
            {
                label3.Text = "Minis A";
            }
            else
            {
                label3.Text = "Seniores";
            }
        }
    }
}
