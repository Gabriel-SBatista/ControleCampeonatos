using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Banco;
using WinFormsApp2.Entidades;

namespace WinFormsApp2.Repository
{
    internal class SexoRepo
    {
        public List<Sexo> BuscaSexo()
        {
            ConexaoBanco conexao = new ConexaoBanco();
            SqlConnection conn = conexao.IniciaConexao();

            string sql = "SELECT * FROM Sexos";

            conn.Open();

            var sexos = new List<Sexo>();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sexo sexo = new Sexo();
                        sexo.ID_Sexo = reader.GetByte(reader.GetOrdinal("ID_Sexo"));
                        sexo.Genero = reader.GetString(reader.GetOrdinal("Sexo"));
                        sexos.Add(sexo);
                    }
                }
            }

            conn.Close();

            return sexos;
        }
    }
}
