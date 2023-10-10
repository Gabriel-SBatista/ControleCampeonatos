using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string builder = "Server=DESKTOP-GRKC4AG; Database=CBDA; User=SA; Password=17081981Lasb; TrustServerCertificate=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscaEstilos_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                listBox1.Items.Clear();

                string sql = "SELECT * FROM Estilos";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listBox1.Items.Add(reader.GetByte(reader.GetOrdinal("ID_Estilo")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Nome")));
                            }
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnBuscaEstiloID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {

                string sql = "SELECT * from Estilos WHERE ID_Estilo=@ID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.TinyInt).Value = textBoxBuscaEstilo.Text;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show(reader.GetByte(reader.GetOrdinal("ID_Estilo")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Nome")));
                            }
                        }
                        connection.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }            
            }
        }

        private void btnCriaEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                

                string sql = "INSERT INTO Estilos(Nome) VALUES (@Nome)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar, 15).Value = textBoxCriaEstilo.Text;

                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Estilo inserido com sucesso!");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }         
            }
        }

        private void btnAtualizaEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                string sql = "UPDATE Estilos SET Nome= @Nome WHERE ID_Estilo= @ID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar, 15).Value = textBoxAlteraEstiloEstilo.Text;
                    cmd.Parameters.Add("@ID", SqlDbType.SmallInt).Value = textBoxAlteraEstiloID.Text;

                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            MessageBox.Show("Estilo alterado com sucesso!");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnExcluiEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                string sql = "DELETE from Estilos WHERE ID_Estilo=@ID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.SmallInt).Value = textBoxExcluiEstilo.Text;
                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            MessageBox.Show("Estilo removido com sucesso!");
                        connection.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnCriaTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                

                string sql = "INSERT INTO Tipos_Telefones (Tipo) VALUES (@Tipo)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar, 15).Value = textBoxCriaTipoTelefone.Text;

                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Tipo de Telefone inserido com sucesso");
                        connection.Close();
                    }
                    catch( Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAtualizaTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                string sql = "UPDATE Tipos_Telefones SET Tipo=@Tipo WHERE ID_Tipo_Telefone=@ID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar, 15).Value = textBoxAlteraTipoTelefoneTipo.Text;
                    cmd.Parameters.Add("@ID", SqlDbType.TinyInt).Value = textBoxAlteraTipoTelefoneID.Text;

                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            MessageBox.Show("Estilo de prova alterado com sucesso");
                        connection.Close();
                    }
                    catch ( Exception ex )
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnExcluirTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                string sql = "DELETE from Tipos_Telefones WHERE ID_Tipo_Telefone=@ID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.TinyInt).Value = textBoxExcluiTipoTelefone.Text;

                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            MessageBox.Show("Tipo removido com sucesso!");
                        connection.Close();
                    }
                    catch ( Exception ex )
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnBuscaTipoTelefoneID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                string sql = "SELECT * from Tipos_Telefones WHERE ID_Tipo_Telefone=@ID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.TinyInt).Value = textBoxBuscaTipoTelefone.Text;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                MessageBox.Show(reader.GetByte(reader.GetOrdinal("ID_Tipo_Telefone")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Tipo")));
                            }
                        }
                        connection.Close();
                    }
                    catch ( Exception ex )
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnBuscaTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                listBox3.Items.Clear();

                string sql = "SELECT * FROM Tipos_Telefones";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                listBox3.Items.Add(reader.GetByte(reader.GetOrdinal("ID_Tipo_Telefone")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Tipo")));
                            }
                        }
                        connection.Close();
                    }
                    catch( Exception ex )
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}