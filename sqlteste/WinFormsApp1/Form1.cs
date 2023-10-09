using Microsoft.Data.SqlClient;

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

                connection.Open();

                string sql = "SELECT * FROM Estilos";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader.GetByte(reader.GetOrdinal("ID_Estilo")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Nome")));
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnBuscaEstiloID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "SELECT * from Estilos WHERE ID_Estilo=" + textBoxBuscaEstilo.Text;

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetByte(reader.GetOrdinal("ID_Estilo")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Nome")));
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnCriaEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "INSERT INTO Estilos(Nome)" + "VALUES ('" + textBoxCriaEstilo.Text + "')";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Estilo inserido com sucesso!");
                    }
                }

                connection.Close();
            }
        }

        private void btnAtualizaEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "UPDATE Estilos SET Nome= '" + textBoxAlteraEstiloEstilo.Text + "' WHERE ID_Estilo=" + textBoxAlteraEstiloID.Text;

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Estilo alterado com sucesso!");
                }


                connection.Close();
            }
        }

        private void btnExcluiEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "DELETE from Estilos WHERE ID_Estilo=" + textBoxExcluiEstilo.Text;

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Estilo removido com sucesso!");
                }

                connection.Close();
            }
        }

        private void btnCriaTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "INSERT INTO Tipos_Telefones (Tipo)" + "VALUES ('" + textBoxCriaTipoTelefone.Text + "')";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Tipo de Telefone inserido com sucesso");
                }

                connection.Close();
            }
        }

        private void btnAtualizaTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "UPDATE Tipos_Telefones SET Tipo= '" + textBoxAlteraTipoTelefoneTipo.Text + "' WHERE ID_Tipo_Telefone=" + textBoxAlteraTipoTelefoneID.Text;

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Estilo de prova alterado com sucesso");
                }

                connection.Close();
            }
        }

        private void btnExcluirTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "DELETE from Tipos_Telefones WHERE ID_Tipo_Telefone=" + textBoxExcluiTipoTelefone.Text;

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Tipo removido com sucesso!");
                }

                connection.Close();
            }
        }

        private void btnBuscaTipoTelefoneID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                connection.Open();

                string sql = "SELECT * from Tipos_Telefones WHERE ID_Tipo_Telefone=" + textBoxBuscaTipoTelefone.Text;

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetByte(reader.GetOrdinal("ID_Tipo_Telefone")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Tipo")));
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnBuscaTipoTelefone_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                listBox3.Items.Clear();

                connection.Open();

                string sql = "SELECT * FROM Tipos_Telefones";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            listBox3.Items.Add(reader.GetByte(reader.GetOrdinal("ID_Tipo_Telefone")).ToString() + " - " + reader.GetString(reader.GetOrdinal("Tipo")));
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}