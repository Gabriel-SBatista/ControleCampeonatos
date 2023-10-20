using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Banco
{
    internal class ConexaoBanco
    {
        public string Builder { get; private set; }

        public SqlConnection IniciaConexao()
        {
            Builder = "Server=DESKTOP-GRKC4AG; Database=CBDA; User=SA; Password=17081981Lasb; TrustServerCertificate=true";
            SqlConnection connection = new SqlConnection(Builder);
            return connection;
        }
    }
}
