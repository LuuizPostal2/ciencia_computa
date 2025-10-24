namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCadastrar_Click_1(object sender, EventArgs e)
        {
            Produtos produto = new Produtos

            {
                ID = txtID.Text,
                Nome = txtNome.Text,
                Entrada = txtEntrada.Text,
                Categoria = txtCategoria.Text,
                Preço = txtPreço.Text,

            };
            string caminho = "cliente.txt";

            try
            {
                File.AppendAllText(caminho, produto.ToString() + Environment.NewLine);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }

            catch (Exception ex)
            {
                {
                    MessageBox.Show("Erro ao salvar!" + ex.Message);


                }
            }
        }
    }
}
