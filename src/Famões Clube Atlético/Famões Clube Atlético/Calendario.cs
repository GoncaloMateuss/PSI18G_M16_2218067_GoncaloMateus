using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Famões_Clube_Atlético
{
    public partial class Calendario : UserControl
    {
        private static String ConectionBD = "Server =127.0.0.1; Database = projetofinalgm;Uid = root;Pdw = ;";

        private static MySqlConnection db = new MySqlConnection(ConectionBD);
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            try
            {
                if (db.State == System.Data.ConnectionState.Closed)
                {
                    db.Open();
                }

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "select * from calendario";

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    DataSet ds = new DataSet();
                    DataTable dataTable = new DataTable("calendario");
                    ds.Tables.Add(dataTable);
                    ds.Load(dr, LoadOption.PreserveChanges, ds.Tables["calendario"]);
                    dataGridView1.DataSource = ds.Tables["calendario"];
                }

                dr.Dispose();
                cmd.Dispose();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro de Base de Dados!!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro geral!!", MessageBoxButtons.OK);
            }
            finally
            {
                if (db.State == System.Data.ConnectionState.Open)
                {
                    db.Close();
                    db.Dispose();
                }
            }
        }
    }
}
