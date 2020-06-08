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
    public partial class CalendarioAdmin : UserControl
    {
        private static String ConectionBD = "Server =127.0.0.1; Database = projetofinalgm;Uid = root;Pdw = ;";

        private static MySqlConnection db = new MySqlConnection(ConectionBD);
        public CalendarioAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdia.Text != "" && txthora.Text != "")
            {
                try
                {

                    db.Open();
                    MySqlCommand cmdInsert = new MySqlCommand();
                    cmdInsert.Connection = db;
                    cmdInsert.CommandText = "INSERT INTO calendario(dia, horas, localizacao, escalaoo) Values (@dia, @horas, @localizacao, @escalaoo)";
                    cmdInsert.Parameters.Add("@dia", MySqlDbType.VarChar).Value = txtdia.Text;
                    cmdInsert.Parameters.Add("@horas", MySqlDbType.VarChar).Value = txthora.Text;
                    cmdInsert.Parameters.Add("@localizacao", MySqlDbType.VarChar).Value = txtlocal.Text;
                    cmdInsert.Parameters.Add("@escalaoo", MySqlDbType.VarChar).Value = txtescalao.Text;
                    int recAfetados = cmdInsert.ExecuteNonQuery();
                    string message = "Você agendou um jogo com sucesso";
                    string title = "Agendar jogos no calendário";
                    MessageBox.Show(message, title);
                    FormAdmin form = new FormAdmin();
                    form.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    db.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalendarioAdmin_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                try
                {
                    if (db.State == System.Data.ConnectionState.Closed)
                    {
                        db.Open();
                    }

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "delete from calendario where dia=@dia AND escalaoo=@escalaoo";
                    cmd.Parameters.Add("@dia", MySqlDbType.VarChar).Value = Convert.ToString((dataGridView1.DataSource as DataTable).Rows[item.Index]["dia"]);
                    cmd.Parameters.Add("@escalaoo", MySqlDbType.VarChar).Value = Convert.ToString((dataGridView1.DataSource as DataTable).Rows[item.Index]["escalaoo"]);
                    cmd.ExecuteNonQuery();

                    (dataGridView1.DataSource as DataTable).Rows.RemoveAt(item.Index);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Message}", "Erro de Base de Dados!!", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Erro Geral!!", MessageBoxButtons.OK);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
