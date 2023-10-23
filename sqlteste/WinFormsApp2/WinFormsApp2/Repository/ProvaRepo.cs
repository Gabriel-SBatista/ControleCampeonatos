using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Banco;
using WinFormsApp2.Entidades;

namespace WinFormsApp2.Repository
{
    internal class ProvaRepo
    {
        public List<Prova> BuscaProvas(int idEstilo, int idSexo, int distancia)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            SqlConnection conn = conexao.IniciaConexao();

            string sql = @"select P.ID_Prova, E.Nome, S.Sexo, P.Distancia 
                            from Provas P 
                                inner join Estilos E 
                                    on E.ID_Estilo = P.ID_Estilo
                                inner join Sexos S 
                                    on S.ID_Sexo = P.ID_Sexo 
                                where (@IdEstilo = 0 or P.ID_Estilo = @IdEstilo) 
                                    and (@IdSexo = 0 or P.ID_Sexo = @IdSexo) 
                                    and (@Distancia = 0 or P.Distancia = @Distancia) 
                                order by ID_Prova";

            var provas = new List<Prova>();

            conn.Open();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add("@IdEstilo", SqlDbType.TinyInt).Value  = idEstilo;
                command.Parameters.Add("@IdSexo", SqlDbType.TinyInt).Value = idSexo;
                command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = distancia; 

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Prova prova = new Prova();
                        prova.IdProva = reader.GetInt32(reader.GetOrdinal("ID_Prova"));
                        prova.Estilo = reader.GetString(reader.GetOrdinal("Nome"));
                        prova.Sexo = reader.GetString(reader.GetOrdinal("Sexo"));
                        prova.Distancia = reader.GetInt16(reader.GetOrdinal("Distancia"));
                        provas.Add(prova);
                    }
                }
            }

            conn.Close();

            return provas;
        }

        public Prova BuscaProva(int id)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            SqlConnection conn = conexao.IniciaConexao();
            Prova prova = new Prova();

            string sql = "select P.ID_Prova, E.Nome, S.Sexo, P.Distancia " +
                            "from Provas P " +
                                "inner join Estilos E " +
                                    "on E.ID_Estilo = P.ID_Estilo " +
                                "inner join Sexos S " +
                                    "on S.ID_Sexo = P.ID_Sexo " +
                             "where P.ID_Prova = @ID";

            conn.Open();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();                   
                    prova.IdProva = reader.GetInt32(reader.GetOrdinal("ID_Prova"));
                    prova.Estilo = reader.GetString(reader.GetOrdinal("Nome"));
                    prova.Sexo = reader.GetString(reader.GetOrdinal("Sexo"));
                    prova.Distancia = reader.GetInt16(reader.GetOrdinal("Distancia"));
                }
            }

            conn.Close();

            return prova;
        }
        public void AtualizaProva(int idProva, int idSexo, int idEstilo, int distancia)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            SqlConnection conn = conexao.IniciaConexao();

            string sql = "UPDATE Provas SET ID_Sexo = @ID_Sexo, ID_Estilo = @ID_Estilo, Distancia = @Distancia WHERE ID_Prova = @ID_Prova";

            conn.Open();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add("@ID_Sexo", SqlDbType.TinyInt).Value = idSexo;
                command.Parameters.Add("@ID_Estilo", SqlDbType.SmallInt).Value = idEstilo;
                command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = distancia;
                command.Parameters.Add("@ID_Prova", SqlDbType.Int).Value = idProva;

                int i = command.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Prova atualizada com sucesso!!");
                }
            }

            conn.Close();
        }

        public void ExcluiProva(int id)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            SqlConnection conn = conexao.IniciaConexao();

            string sql = "DELETE from Provas WHERE ID_Prova = @Id";

            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Prova removida com sucesso!!");
                }
            }
            conn.Close();
        }

        public void CriaProva(int idSexo, int idEstilo, int distancia)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            SqlConnection conn = conexao.IniciaConexao();

            string sql = "INSERT INTO Provas(ID_Sexo, ID_Estilo, Distancia) VALUES (@ID_Sexo, @ID_Estilo, @Distancia)";

            conn.Open();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add("@ID_Sexo", SqlDbType.TinyInt).Value = idSexo;
                command.Parameters.Add("@ID_Estilo", SqlDbType.SmallInt).Value = idEstilo;
                command.Parameters.Add("@Distancia", SqlDbType.SmallInt).Value = distancia;

                int i = command.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Prova criada com sucesso!!");
                }

            }
            conn.Close();
        }
    }
}
