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
using static System.Net.Mime.MediaTypeNames;

namespace Programa_gerenciador
{
    public partial class Cadastrocli : Form
    {
        public Cadastrocli()
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
                var id = txtid.Text;
                var nome_cli = nometxt.Text;
                var cpf = maskedTextBox1.Text;
                var sexo = comboBox1.Text;
                var telefone = maskedTextBox2.Text;
                var endereco = maskedTextBox2.Text;

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nome_cli) || string.IsNullOrWhiteSpace(cpf))
                {
                    MessageBox.Show("Preencha pelo menos o ID, nome e CPF.");
                    return;
                }

                var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    var sql = @"INSERT INTO clientes 
                        (id_cliente, nome_cli, cpf_cli, sexo_cli, tel_cli, endereco_cli)
                        VALUES (@id, @nome_cli, @cpf_cli, @sexo_cli, @tel_cli, @endereco_cli)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nome_cli", nome_cli);
                        cmd.Parameters.AddWithValue("@cpf_cli", cpf);
                        cmd.Parameters.AddWithValue("@sexo_cli", sexo);
                        cmd.Parameters.AddWithValue("@tel_cli", telefone);
                        cmd.Parameters.AddWithValue("@endereco_cli", endereco);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cliente salvo com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cliente: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtid.Clear();
            nometxt.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            maskedTextBox2.Clear();
            maskedTextBox2.Clear();
        }



        private void txtid_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cadastrocli_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputReject(object sender, EventArgs e)
        {

        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
