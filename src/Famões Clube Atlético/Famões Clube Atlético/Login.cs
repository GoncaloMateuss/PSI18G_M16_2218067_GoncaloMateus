using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Famões_Clube_Atlético
{
    public partial class Login : Form
    {
        private static String ConnectionBD = "Server =127.0.0.1; Database = projetofinalgm;Uid = root;Pdw = ;";

        private static MySqlConnection db = new MySqlConnection(ConnectionBD);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "" && txtpass.Text != "")
            {
                try
                {
                    db.Open();

                    MySqlCommand cmduser = new MySqlCommand();
                    cmduser.Connection = db;

                    cmduser.CommandText = "SELECT * FROM administrador WHERE user=@nomeuser AND password=@palavrapasse";

                    cmduser.Parameters.Add("@nomeuser", MySqlDbType.VarChar).Value = txtuser.Text;
                    cmduser.Parameters.Add("@palavrapasse", MySqlDbType.VarChar).Value = txtpass.Text;

                    MySqlDataReader verificaruser = cmduser.ExecuteReader();

                    if (verificaruser.Read())
                    {
                        verificaruser.Close();

                        FormAdmin form = new FormAdmin();
                        this.Close();
                        form.Show();
                    }

                    else
                    {
                        MessageBox.Show("O seu username/password estão incorretas!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    if (db.State == System.Data.ConnectionState.Open)
                    {
                        db.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrocarPassword trocar = new TrocarPassword();
            trocar.Show();
        }
    }
}
