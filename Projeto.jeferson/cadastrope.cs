using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto.jeferson
{
    public partial class cadastrope : Form
    {
        public cadastrope()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string cnpj = txtCNPJ.Text;
            string telefone = txtTelefone.Text;
            string endereco = txtEndereco.Text;

            try
            {
                using (MySqlConnection conn = new Conexao().Abrir())
                {
                    string query = @"INSERT INTO clietes 
                                    (nome, tipo, cpf, cnpj, telefone, endereco, senha_cliente) 
                                    VALUES 
                                    (@nome, 'PF', @cpf, @cnpj, @telefone, @endereco, '123456')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@cnpj", string.IsNullOrEmpty(cnpj) ? DBNull.Value : (object)cnpj);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@endereco", endereco);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtCNPJ.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            // Pode ser usado para validações em tempo real
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Pode ser removido se não for usado
        }
    }
}