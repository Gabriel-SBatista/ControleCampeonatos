using Microsoft.Data.SqlClient;

namespace sqltest
{
    class Program
    {
        static void Main(string[] args)
        {
            int idProva = 1;

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.ConnectionString = "Server=DESKTOP-GRKC4AG; Database=CBDA; User=SA; Password=17081981Lasb; TrustServerCertificate=true";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    buscarEstiloProva(idProva, connection);
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
        }

        private static void inserirEstiloProva(string estiloProva, SqlConnection connection)
        {
            connection.Open();

            string sql = "INSERT INTO Estilos(Nome)" + "VALUES ('" + estiloProva + "')";

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Estilo inserido com sucesso!");
                }
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void buscarEstilosProvas(SqlConnection connection)
        {
            connection.Open();

            string sql = "SELECT nome FROM Estilos";

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader.GetString(0));
                    }
                }
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void alterarEstiloProva(string novoEstilo, int IdEstilo, SqlConnection connection)
        {
            connection.Open();

            string sql = "UPDATE Estilos SET Nome= '" + novoEstilo + "' WHERE ID_Estilo=" + IdEstilo;

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    Console.WriteLine("Estilo alterado com sucesso!");
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void deletarEstiloProva(int idProva, SqlConnection connection)
        {
            connection.Open();

            string sql = "DELETE from Estilos WHERE ID_Estilo=" + idProva;

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    Console.WriteLine("Estilo removido com sucesso!");
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void buscarEstiloProva(int idProva, SqlConnection connection)
        {
            connection.Open();

            string sql = "SELECT nome from Estilos WHERE ID_Estilo=" + idProva;

            using (SqlCommand cmd = new SqlCommand(sql,connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }
                }
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void inserirTipoTelefone(string tipoTelefone, SqlConnection connection)
        {
            connection.Open();

            string sql = "INSERT INTO Tipos_Telefones (Tipo)" + "VALUES ('" + tipoTelefone + "')";

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Console.WriteLine("Tipo de Telefone inserido com sucesso");
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void buscarTiposTelefones(SqlConnection connection)
        {
            connection.Open();

            string sql = "SELECT tipo FROM Tipos_Telefones";

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader.GetString(0));
                    }
                }
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void alterarTipoTelefone(string novoTipo, int idTelefone, SqlConnection connection)
        {
            connection.Open();

            string sql = "UPDATE Tipos_Telefones SET Tipo= '" + novoTipo + "' WHERE ID_Tipo_Telefone=" + idTelefone;

            using(SqlCommand cmd = new SqlCommand(sql, connection))
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    Console.WriteLine("Estilo de prova alterado com sucesso");
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void deletarTipoTelefone(int idTelefone, SqlConnection connection)
        {
            connection.Open();

            string sql = "DELETE from Tipos_Telefones WHERE ID_Tipo_Telefone=" + idTelefone;

            using(SqlCommand cmd = new SqlCommand(sql, connection))
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    Console.WriteLine("Tipo removido com sucesso!");
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }

        private static void buscarTipoTelefone(int idTelefone, SqlConnection connection)
        {
            connection.Open();

            string sql = "SELECT tipo from Tipos_Telefones WHERE ID_Tipo_Telefone=" + idTelefone;

            using(SqlCommand cmd = new SqlCommand(sql,connection))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader.GetString(0));
                    }
                }
            }

            connection.Close();

            Console.WriteLine("\n=========================================\n");
        }
    }
}