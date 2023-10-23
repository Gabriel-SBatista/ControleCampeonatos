namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void textBoxCEP_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCEP.Text.Length >= 8)
            {
                EnderecoRequest enderecoRequest = new EnderecoRequest();
                Endereco endereco = await enderecoRequest.GetEndereco(textBoxCEP.Text);

                textBoxRua.Text = endereco.street;
                textBoxCidade.Text = endereco.city;
                textBoxBairro.Text = endereco.neighborhood;
                textBoxEstado.Text = endereco.state;
            }
        }
    }
}