using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luuiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtCadastrar_Click(object sender, EventArgs e)
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

        private void txtVoltar_Click(object sender, EventArgs e)
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
