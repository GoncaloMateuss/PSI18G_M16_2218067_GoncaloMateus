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
    public partial class Inscricoes : UserControl
    {
        private static String ConectionBD = "Server =127.0.0.1; Database = projetofinalgm;Uid = root;Pdw = ;";

        private static MySqlConnection db = new MySqlConnection(ConectionBD);
        public Inscricoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "" && txtcartaoc.Text != "")
            {
                try
                {
                    
                    db.Open();
                    MySqlCommand VerificarInscricao = new MySqlCommand();
                    VerificarInscricao.Connection = db;
                    VerificarInscricao.CommandText = "SELECT * FROM inscricoes WHERE cartaoc=@cartaoc";
                    VerificarInscricao.Parameters.Add("@cartaoc", MySqlDbType.VarChar).Value = txtcartaoc.Text;
                    MySqlDataReader listinscricao = VerificarInscricao.ExecuteReader();

                    if (!listinscricao.HasRows)
                    {
                        listinscricao.Close();
                        MySqlCommand verificaremail = new MySqlCommand();
                        verificaremail.Connection = db;
                        verificaremail.CommandText = "SELECT * FROM inscricoes WHERE email = @email";
                        verificaremail.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtemail.Text;
                        MySqlDataReader listemail = verificaremail.ExecuteReader();

                        if (!listemail.HasRows)
                        {
                            listemail.Close();
                            MySqlCommand cmdInsert = new MySqlCommand();
                            cmdInsert.Connection = db;
                            cmdInsert.CommandText = "INSERT INTO inscricoes(nome, escalaoatleta, contacto, email, cartaoc, datanascimento) Values (@nome, @escalaoatleta, @contacto, @email, @cartaoc, @datanascimento)";
                            cmdInsert.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtnome.Text;
                            cmdInsert.Parameters.Add("@escalaoatleta", MySqlDbType.VarChar).Value = txtescalaoatleta.Text;
                            cmdInsert.Parameters.Add("@contacto", MySqlDbType.VarChar).Value = txtcontacto.Text;
                            cmdInsert.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtemail.Text;
                            cmdInsert.Parameters.Add("@cartaoc", MySqlDbType.VarChar).Value = txtcartaoc.Text;
                            cmdInsert.Parameters.Add("@datanascimento", MySqlDbType.VarChar).Value = txtdatanascimento.Text;
                            int recAfetados = cmdInsert.ExecuteNonQuery();
                            string message = "Você foi inscrito";
                            string title = "Inscrição no Clube";
                            MessageBox.Show(message,title);
                            Form1 form = new Form1();
                            form.Show();
                        }

                        else
                        {
                            string message = "O seu email já está inscrito, experimente usar outro";
                            MessageBox.Show(message);
                        }
                    }

                    else
                    {
                        string message = "O seu cartão de cidadão já foi usado para uma inscrição";
                        MessageBox.Show(message);
                    }

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
    }
}
