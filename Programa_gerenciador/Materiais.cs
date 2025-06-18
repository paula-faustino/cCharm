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
    public partial class Materiais : Form
    {
        public Materiais()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Id fornecedor textBox2
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // nome da materia textBox1
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // quantidade maskedTextBox2
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // validade dateTimePicker1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Salvar button1
            try
            {
                string nome = textBox1.Text; 
                DateTime validade = dateTimePicker1.Value.Date;
                decimal quantidade = 0;

                if (!decimal.TryParse(maskedTextBox2.Text.Replace(",", "."), out quantidade))
                {
                    MessageBox.Show("Quantidade inválida.");
                    return;
                }

                if (!int.TryParse(textBox2.Text, out int fornecedorId))
                {
                    MessageBox.Show("ID do fornecedor inválido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("Preencha o nome do material.");
                    return;
                }

                string strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string sql = @"INSERT INTO materiais 
                           (nome_mat, validade_mat, fornecedor_id, qtd_estoque) 
                           VALUES (@nome, @validade, @fornecedor_id, @quantidade)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@validade", validade);
                        cmd.Parameters.AddWithValue("@fornecedor_id", fornecedorId);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Material salvo com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar material: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            textBox1.Clear();          
            maskedTextBox2.Clear();    
            textBox2.Clear();          
            dateTimePicker1.Value = DateTime.Now; 
        }




    }

}
