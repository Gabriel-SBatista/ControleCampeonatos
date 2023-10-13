using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormAtualiza : Form
    {
        private string builder = "Server=DESKTOP-GRKC4AG; Database=CBDA; User=SA; Password=17081981Lasb; TrustServerCertificate=true";
        public FormAtualiza()
        {
            InitializeComponent();
        }

        private void FormAtualiza_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder))
            {
                string sql = "SELECT Nome from Estilos";

                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxEstilo.Items.Add(reader.GetString(0));
                        }
                    }
                }

                sql = "SELECT Sexo from Sexos";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxSexo.Items.Add(reader.GetString(0));
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(btnSalvar.Text == "Salvar")
            {
                string sql = "UPDATE Provas SET ID_Sexo = @Sexo, ID_Estilo = @Estilo, Distancia = @Distancia WHERE ID_Prova = @Id";
                string buscaIdSexo = "SELECT ID_Sexo FROM Sexos WHERE Sexo = @Sexo";
                string buscaIdEstilo = "SELECT ID_Estilo FROM Estilos WHERE Nome = @Estilo";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    connection.Open();
                    byte idSexo = 0;
                    byte idEstilo = 0;

                    using(SqlCommand command = new SqlCommand(buscaIdSexo, connection))
                    {
                        command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = comboBoxSexo.Text;

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            idSexo = reader.GetByte(0);
                        }
                    }

                    using (SqlCommand command = new SqlCommand(buscaIdEstilo, connection))
                    {
                        command.Parameters.Add("@Estilo", SqlDbType.NVarChar, 20).Value = comboBoxEstilo.Text;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            idEstilo = reader.GetByte(0);
                        }
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Sexo", SqlDbType.TinyInt).Value = idSexo;
                        command.Parameters.Add("@Estilo", SqlDbType.SmallInt).Value = idEstilo;
                        command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = textBoxDistancia.Text;
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;

                        int i = command.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Prova atualizada com sucesso!!");
                        }

                    }

                    connection.Close();
                    
                    this.Close();
                }

            }
            else
            {
                string sql = "INSERT INTO Provas(ID_Sexo, ID_Estilo, Distancia) VALUES (@Sexo, @Estilo, @Distancia)";
                string buscaIdSexo = "SELECT ID_Sexo FROM Sexos WHERE Sexo = @Sexo";
                string buscaIdEstilo = "SELECT ID_Estilo FROM Estilos WHERE Nome = @Estilo";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    connection.Open();
                    byte idSexo = 0;
                    byte idEstilo = 0;

                    using (SqlCommand command = new SqlCommand(buscaIdSexo, connection))
                    {
                        command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = comboBoxSexo.Text;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            idSexo = reader.GetByte(0);
                        }
                    }

                    using (SqlCommand command = new SqlCommand(buscaIdEstilo, connection))
                    {
                        command.Parameters.Add("@Estilo", SqlDbType.NVarChar, 20).Value = comboBoxEstilo.Text;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            idEstilo = reader.GetByte(0);
                        }
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Sexo", SqlDbType.TinyInt).Value = idSexo;
                        command.Parameters.Add("@Estilo", SqlDbType.SmallInt).Value = idEstilo;
                        command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = textBoxDistancia.Text;

                        int i = command.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Prova criada com sucesso!!");
                        }

                    }
                    connection.Close();

                    this.Close();
                }
            }

        }
    }
}
