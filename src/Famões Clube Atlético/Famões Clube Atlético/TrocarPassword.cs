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
    public partial class TrocarPassword : Form
    {
        private static String ConnectionBD = "Server =127.0.0.1; Database = projetofinalgm;Uid = root;Pdw = ;";

        private static MySqlConnection db = new MySqlConnection(ConnectionBD);
        public TrocarPassword()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/famoesclubeatletico");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/famoes.c.a/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "" && txtpass.Text != "")
            {
                try
                {
                    db.Open();
                    MySqlCommand cmdrecuperar = new MySqlCommand();
                    cmdrecuperar.Connection = db;
                    cmdrecuperar.CommandText = "UPDATE administrador SET password = @password WHERE user=@user;";

                    cmdrecuperar.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtpass.Text;
                    cmdrecuperar.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtuser.Text;
                    cmdrecuperar.ExecuteNonQuery();
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
                        Login form = new Login();
                        this.Close();
                        form.Show();

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Close();
            form.Show();
        }
    }
}
