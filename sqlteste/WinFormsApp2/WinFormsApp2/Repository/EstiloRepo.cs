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
    internal class EstiloRepo
    {
        public List<Estilo> BuscaEstilo()
        {
            ConexaoBanco connection = new ConexaoBanco();
            SqlConnection conn = connection.IniciaConexao();

            string sql = "Select * from Estilos";

            conn.Open();

            var estilos = new List<Estilo>();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Estilo estilo = new Estilo();
                        estilo.ID_Estilo = reader.GetByte(reader.GetOrdinal("ID_Estilo"));
                        estilo.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                        estilos.Add(estilo);
                    }
                }
            }

            conn.Close();

            return estilos;
        }
    }
}
