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
using WinFormsApp2.Entidades;
using WinFormsApp2.Repository;

namespace WinFormsApp2
{
    public partial class FormAtualiza : Form
    {
        public FormAtualiza()
        {
            InitializeComponent();
        }

        private void FormAtualiza_Load(object sender, EventArgs e)
        {
            SexoRepo sexoRepo = new SexoRepo();
            EstiloRepo estiloRepo = new EstiloRepo();

            var sexos = new List<Sexo>();
            var estilos = new List<Estilo>();

            sexos = sexoRepo.BuscaSexo();
            estilos = estiloRepo.BuscaEstilo();

            comboBoxSexo.DisplayMember = "Genero";
            comboBoxSexo.ValueMember = "ID_Sexo";
            comboBoxSexo.DataSource = sexos;

            comboBoxEstilo.DisplayMember = "Nome";
            comboBoxEstilo.ValueMember = "ID_Estilo";
            comboBoxEstilo.DataSource = estilos;

            comboBoxSexo.Text = this.Sexo;
            comboBoxEstilo.Text = this.Estilo;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProvaRepo provaRepo = new ProvaRepo();

            if (btnSalvar.Text == "Salvar")
            {
                provaRepo.AtualizaProva(this.IdProva, Int32.Parse(comboBoxSexo.SelectedValue.ToString()), Int32.Parse(comboBoxEstilo.SelectedValue.ToString()), Int32.Parse(textBoxDistancia.Text));

                this.Close();
            }
            else
            {
                provaRepo.CriaProva(Int32.Parse(comboBoxSexo.SelectedValue.ToString()), Int32.Parse(comboBoxEstilo.SelectedValue.ToString()), Int32.Parse(textBoxDistancia.Text));

                this.Close();
                
            }

        }
    }
}
