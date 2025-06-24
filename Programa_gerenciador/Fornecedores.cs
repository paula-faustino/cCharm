using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa_gerenciador_DLL;


namespace Programa_gerenciador
{
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //nome
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //cnpj label3
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // nome textBox3
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // cnpj textBox1
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // maskedTextBox2
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // email textBox2
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // endereço textBox4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = textBox3.Text;
                var cnpj = textBox1.Text;
                var telefone = maskedTextBox2.Text;
                var email = textBox2.Text;
                var endereco = textBox4.Text;

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cnpj))
                {
                    MessageBox.Show("Preencha pelo menos o nome e o CNPJ do fornecedor.");
                    return;
                }

                Fornecedor fornecedorDLL = new Fornecedor();
                fornecedorDLL.SalvarFornecedor(nome, cnpj, telefone, email, endereco);

                MessageBox.Show("Fornecedor salvo com sucesso!");
                LimparCamposFornecedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o fornecedor: " + ex.Message);
            }
        }
            private void LimparCamposFornecedor()
        {
            textBox3.Clear();
            textBox1.Clear();
            maskedTextBox2.Clear(); 
            textBox2.Clear(); 
            textBox4.Clear(); 
        }
    
    }
}
