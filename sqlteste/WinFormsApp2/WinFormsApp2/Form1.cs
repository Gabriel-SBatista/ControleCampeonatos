using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Tracing;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string builder = "Server=DESKTOP-GRKC4AG; Database=CBDA; User=SA; Password=17081981Lasb; TrustServerCertificate=true";
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSexo.Items.Add("M");
            comboBoxSexo.Items.Add("F");
            comboBoxSexo.Items.Add("Todos");
            comboBoxEstilos.Items.Add("");

            using (SqlConnection connection = new SqlConnection(builder))
            {
                string sql = "Select Nome from Estilos";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxEstilos.Items.Add(reader.GetString(0));
                        }
                    }
                    connection.Close();
                }
            }

            dataGridViewProvas.ColumnCount = 4;
            dataGridViewProvas.Columns[0].Name = "Id";
            dataGridViewProvas.Columns[1].Name = "Tipo";
            dataGridViewProvas.Columns[2].Name = "Sexo";
            dataGridViewProvas.Columns[3].Name = "Distancia";
            dataGridViewProvas.Columns.Add(new DataGridViewButtonColumn());
            dataGridViewProvas.Columns.Add(new DataGridViewButtonColumn());
            dataGridViewProvas[4, 0].Value = "Editar";
            dataGridViewProvas[5, 0].Value = "Excluir";
        }

        private void textBoxDistancia_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBoxDistancia.Clear();
                textBoxDistancia.ForeColor = SystemColors.ControlText;
                i = 1;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewProvas.Rows.Clear();

            if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)") && comboBoxEstilos.Text != "" && (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos"))
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "where P.Distancia = @Distancia " +
                                    "and E.Nome = @Estilo " +
                                    "and S.Sexo = @Sexo " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = textBoxDistancia.Text;
                        command.Parameters.Add("@Estilo", SqlDbType.NVarChar, 20).Value = comboBoxEstilos.Text;
                        if (comboBoxSexo.Text == "M")
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Masculino";
                        else
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Feminino";



                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }
            }
            else if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)") && comboBoxEstilos.Text != "")
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "where P.Distancia = @Distancia " +
                                    "and E.Nome = @Estilo " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = textBoxDistancia.Text;
                        command.Parameters.Add("@Estilo", SqlDbType.NVarChar, 20).Value = comboBoxEstilos.Text;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }

            }
            else if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)") && (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos"))
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "where P.Distancia = @Distancia " +
                                "and S.Sexo = @Sexo " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = textBoxDistancia.Text;
                        if (comboBoxSexo.Text == "M")
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Masculino";
                        else
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Feminino";

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }
            }
            else if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)"))
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "where P.Distancia = @Distancia " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = textBoxDistancia.Text;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }
            }
            else if (comboBoxEstilos.Text != "" && (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos"))
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "where E.Nome = @Estilo " +
                                    "and S.Sexo = @Sexo " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Estilo", SqlDbType.NVarChar, 20).Value = comboBoxEstilos.Text;
                        if (comboBoxSexo.Text == "M")
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Masculino";
                        else
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Feminino";

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }
            }
            else if (comboBoxEstilos.Text != "")
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "where E.Nome = @Estilo " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Estilo", SqlDbType.NVarChar, 20).Value = comboBoxEstilos.Text;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }
            }
            else if (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos")
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "where S.Sexo = @Sexo " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (comboBoxSexo.Text == "M")
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Masculino";
                        else
                            command.Parameters.Add("@Sexo", SqlDbType.NVarChar, 15).Value = "Feminino";

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }
            }
            else
            {
                string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                                "order by ID_Prova";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var rows = new List<string[]>();

                            while (reader.Read())
                            {
                                string[] row = new string[] {reader.GetInt32(reader.GetOrdinal("ID_Prova")).ToString(),
                                reader.GetString(reader.GetOrdinal("Nome")), reader.GetString(reader.GetOrdinal("Sexo")),
                                reader.GetInt16(reader.GetOrdinal("Distancia")).ToString(), "Editar", "Excluir"};
                                rows.Add(row);
                            }

                            foreach (string[] rowArray in rows)
                            {
                                dataGridViewProvas.Rows.Add(rowArray);
                            }
                        }

                        connection.Close();
                    }
                }
            }
        }

        private void dataGridViewProvas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[4] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var form = new FormAtualiza();

                form.Id = Int32.Parse(dataGridViewProvas[0, e.RowIndex].Value.ToString());
                form.textBoxDistancia.Text = dataGridViewProvas[3, e.RowIndex].Value.ToString();
                form.comboBoxEstilo.Text = dataGridViewProvas[1, e.RowIndex].Value.ToString();
                form.comboBoxSexo.Text = dataGridViewProvas[2, e.RowIndex].Value.ToString();
                form.Show();
            }

            else if (dgv.Columns[5] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string sql = "DELETE from Provas WHERE ID_Prova = @Id";

                using (SqlConnection connection = new SqlConnection(builder))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = dataGridViewProvas[0, e.RowIndex].Value;
                        MessageBox.Show("" + dataGridViewProvas[0, e.RowIndex].Value);

                        connection.Open();
                        int i = command.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Prova removida com sucesso!!");
                            dataGridViewProvas.Rows.RemoveAt(e.RowIndex);
                        }
                        connection.Close();
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new FormAtualiza();

            form.btnSalvar.Text = "Criar";

            form.Show();
        }
    }
}