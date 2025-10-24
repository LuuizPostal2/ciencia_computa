using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Luuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente

            {
                Nome = txtNome.Text,
                Endereço = txtEndereço.Text,
                CPF = txtCPF.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,

            };
            string caminho = "cliente.txt";

            try
            {
                File.AppendAllText(caminho, cliente.ToString() + Environment.NewLine);
                MessageBox.Show("Cliente salvo com sucesso!");
            }

            catch (Exception ex)
            {
                {
                    MessageBox.Show("Erro ao salvar!" + ex.Message);


                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form3 Form3 = Application.OpenForms["Form3"] as Form3;
            if (Form3 != null)
            {
                Form3.Show(); 
            }

            this.Close(); 
        }
    }
}
 

       
