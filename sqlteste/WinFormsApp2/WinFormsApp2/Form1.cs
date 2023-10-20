using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Tracing;
using WinFormsApp2.Entidades;
using WinFormsApp2.Repository;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SexoRepo sexo = new SexoRepo();
            EstiloRepo estilo = new EstiloRepo();
            Estilo todosEstilos = new Estilo();
            Sexo todosSexos = new Sexo();

            todosSexos.Genero = "Todos";
            todosSexos.IdSexo = 0;

            todosEstilos.Nome = "Todos";
            todosEstilos.IdEstilo = 0;

            var sexos = new List<Sexo>();
            var estilos = new List<Estilo>();

            sexos = sexo.BuscaSexo();
            estilos = estilo.BuscaEstilo();

            sexos.Insert(0, todosSexos);
            estilos.Insert(0, todosEstilos);

            comboBoxSexo.DisplayMember = "Genero";
            comboBoxSexo.ValueMember = "IdSexo";
            comboBoxSexo.DataSource = sexos;

            comboBoxEstilos.DisplayMember = "Nome";
            comboBoxEstilos.ValueMember = "IdEstilo";
            comboBoxEstilos.DataSource = estilos;

            comboBoxEstilos.Text = "";
            comboBoxSexo.Text = "";

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
            ProvaRepo provaRepo = new ProvaRepo();
            var provas = new List<Prova>();
            int i = 0;

            if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)") && (comboBoxEstilos.Text != "" && comboBoxEstilos.Text != "Todos") && (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos"))
            {
                provas = provaRepo.BuscaProvas(Int32.Parse(comboBoxEstilos.SelectedValue.ToString()),
                    Int32.Parse(comboBoxSexo.SelectedValue.ToString()),
                    Int32.Parse(textBoxDistancia.Text));
                foreach (Prova prova in provas)
                {
                    if (prova.Estilo == comboBoxEstilos.Text
                        && prova.Sexo == comboBoxSexo.Text
                        && prova.Distancia.ToString() == textBoxDistancia.Text)
                    {
                        dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                        dataGridViewProvas[4, i].Value = "Editar";
                        dataGridViewProvas[5, i].Value = "Excluir";
                        i++;
                    }
                }
            }
            else if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)") && (comboBoxEstilos.Text != "" && comboBoxEstilos.Text != "Todos"))
            {
                provas = provaRepo.BuscaProvas(Int32.Parse(comboBoxEstilos.SelectedValue.ToString()), 0,
                    Int32.Parse(textBoxDistancia.Text));
                foreach (Prova prova in provas)
                {
                    if (prova.Estilo == comboBoxEstilos.Text && prova.Distancia.ToString() == textBoxDistancia.Text)
                    {
                        dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                        dataGridViewProvas[4, i].Value = "Editar";
                        dataGridViewProvas[5, i].Value = "Excluir";
                        i++;
                    }
                }
            }
            else if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)") && (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos"))
            {
                foreach (Prova prova in provas)
                {
                    provas = provaRepo.BuscaProvas(0, Int32.Parse(comboBoxSexo.SelectedValue.ToString()),
                    Int32.Parse(textBoxDistancia.Text));
                    if (prova.Sexo == comboBoxSexo.Text && prova.Distancia.ToString() == textBoxDistancia.Text)
                    {
                        dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                        dataGridViewProvas[4, i].Value = "Editar";
                        dataGridViewProvas[5, i].Value = "Excluir";
                        i++;
                    }
                }
            }
            else if ((textBoxDistancia.Text != "" && textBoxDistancia.Text != "Distancia (m)"))
            {
                foreach (Prova prova in provas)
                {
                    provas = provaRepo.BuscaProvas(0, 0, Int32.Parse(textBoxDistancia.Text));
                    if (prova.Distancia.ToString() == textBoxDistancia.Text)
                    {
                        dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                        dataGridViewProvas[4, i].Value = "Editar";
                        dataGridViewProvas[5, i].Value = "Excluir";
                        i++;
                    }
                }
            }
            else if ((comboBoxEstilos.Text != "" && comboBoxEstilos.Text != "Todos") && (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos"))
            {
                provas = provaRepo.BuscaProvas(Int32.Parse(comboBoxEstilos.SelectedValue.ToString()),
                                    Int32.Parse(comboBoxSexo.SelectedValue.ToString()), 0);
                foreach (Prova prova in provas)
                {
                    if (prova.Estilo == comboBoxEstilos.Text && prova.Sexo == comboBoxSexo.Text)
                    {
                        dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                        dataGridViewProvas[4, i].Value = "Editar";
                        dataGridViewProvas[5, i].Value = "Excluir";
                        i++;
                    }
                }
            }
            else if (comboBoxEstilos.Text != "" && comboBoxEstilos.Text != "Todos")
            {
                MessageBox.Show(comboBoxEstilos.SelectedValue.ToString());
                provas = provaRepo.BuscaProvas(Int32.Parse(comboBoxEstilos.SelectedValue.ToString()), 0, 0);

                foreach (Prova prova in provas)
                {
                    if (prova.Estilo == comboBoxEstilos.Text)
                    {
                        dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                        dataGridViewProvas[4, i].Value = "Editar";
                        dataGridViewProvas[5, i].Value = "Excluir";
                        i++;
                    }
                }
            }
            else if (comboBoxSexo.Text != "" && comboBoxSexo.Text != "Todos")
            {
                provas = provaRepo.BuscaProvas(0, Int32.Parse(comboBoxSexo.SelectedValue.ToString()), 0);

                foreach (Prova prova in provas)
                {
                    if (prova.Sexo == comboBoxSexo.Text)
                    {
                        dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                        dataGridViewProvas[4, i].Value = "Editar";
                        dataGridViewProvas[5, i].Value = "Excluir";
                        i++;
                    }
                }
            }
            else
            {
                provas = provaRepo.BuscaProvas(0, 0, 0);
                foreach (Prova prova in provas)
                {
                    dataGridViewProvas.Rows.Add(prova.IdProva, prova.Sexo, prova.Estilo, prova.Distancia);
                    dataGridViewProvas[4, i].Value = "Editar";
                    dataGridViewProvas[5, i].Value = "Excluir";
                    i++;
                }
            }
        }

        private void dataGridViewProvas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProvaRepo provaRepo = new ProvaRepo();
            Prova prova = new Prova();

            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                var form = new FormAtualiza();

                form.IdProva = Int32.Parse(dataGridViewProvas[0, e.RowIndex].Value.ToString());
                form.textBoxDistancia.Text = dataGridViewProvas[3, e.RowIndex].Value.ToString();
                form.Sexo = dataGridViewProvas[1, e.RowIndex].Value.ToString();
                form.Estilo = dataGridViewProvas[2, e.RowIndex].Value.ToString();
                form.ShowDialog();

                prova = provaRepo.BuscaProva(Int32.Parse(dataGridViewProvas[0, e.RowIndex].Value.ToString()));
                dataGridViewProvas[3, e.RowIndex].Value = prova.Distancia;
                dataGridViewProvas[1, e.RowIndex].Value = prova.Sexo;
                dataGridViewProvas[2, e.RowIndex].Value = prova.Estilo;
            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var confirmaExclusao = MessageBox.Show("Tem certeza que deseja excluir permanentemente essa prova?", "Excluir",
                MessageBoxButtons.YesNo);
                if (confirmaExclusao == DialogResult.Yes)
                {
                    provaRepo.ExcluiProva(Int32.Parse(dataGridViewProvas[0, e.RowIndex].Value.ToString()));
                    dataGridViewProvas.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new FormAtualiza();

            form.btnSalvar.Text = "Criar";

            form.ShowDialog();
        }

        private void textBoxDistancia_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (textBoxDistancia.Text == String.Empty) ;
            else if (!int.TryParse(textBoxDistancia.Text, out x))
            {
                MessageBox.Show("Distancia aceita apenas numeros positivos");
                textBoxDistancia.Text = String.Empty;
            }
        }
    }
}