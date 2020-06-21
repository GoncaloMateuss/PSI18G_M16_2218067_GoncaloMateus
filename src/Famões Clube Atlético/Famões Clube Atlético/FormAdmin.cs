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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            painellat.Height = button1.Height;
            painellat.Top = button1.Top;
            paginaInicial1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            painellat.Height = button1.Height;
            painellat.Top = button1.Top;
            paginaInicial1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/famoes.c.a/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/famoesclubeatletico");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            painellat.Height = button2.Height;
            painellat.Top = button2.Top;
            escaloes1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            painellat.Height = button3.Height;
            painellat.Top = button3.Top;
            inscricoesAdmin1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            painellat.Height = button4.Height;
            painellat.Top = button4.Top;
            calendarioAdmin1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.Show();
        }
    }
}
