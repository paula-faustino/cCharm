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

namespace Programa_gerenciador
{
    public partial class Cadastrofunc : Form
    {
        public Cadastrofunc()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = textBox1.Text;
                var cpf = maskedTextBox1.Text;
                var sexo = comboBox1.Text;
                var telefone = maskedTextBox2.Text;
                var endereco = maskedTextBox2.Text;


                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf))
                {
                    MessageBox.Show("Preencha pelo menos nome e CPF.");
                    return;
                }

                var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    var sql = @"INSERT INTO funcionario
                        (nome_func, cpf_func, sexo_func, tel_func, endereco_func)
                        VALUES (@nome_func, @cpf_func, @sexo_func, @tel_func, @endereco_func)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome_func", nome);
                        cmd.Parameters.AddWithValue("@cpf_func", cpf);
                        cmd.Parameters.AddWithValue("@sexo_func", sexo);
                        cmd.Parameters.AddWithValue("@tel_func", telefone);
                        cmd.Parameters.AddWithValue("@endereco_func", endereco);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funcionario salvo com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o fucionario: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            maskedTextBox2.Clear();
            maskedTextBox2.Clear();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // nome textBox1
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // cpf maskedTextBox1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sexo comboBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // endereço textBox2
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // numero maskedTextBox2
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
