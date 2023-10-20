using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Banco;

namespace WinFormsApp2.Entidades
{
    internal class Prova
    {
        public int ID_Prova { get; set; }
        public string Sexo{ get; set; }
        public string Estilo { get; set; }
        public short Distancia { get; set; }          
    }
}
