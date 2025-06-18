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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programa_gerenciador
{
    public partial class CasProdutos : Form
    {
        public CasProdutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nome textBox1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tipo comboBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //peso textBox2
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //preço  textBox3
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //data dateTimePicker1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sair
            Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            // salvar 

            try
            {
                var nome = textBox1.Text;
                var tipo = comboBox1.Text;
                var peso = textBox2.Text;
                var preco = textBox3.Text;
                var validade = dateTimePicker1.Value.Date;

                if (string.IsNullOrWhiteSpace(nome) )
                {
                    MessageBox.Show("Preencha o nome");
                    return;
                }

                var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    var sql = @"INSERT INTO produtos
                (nome_prod, tipo_prod, peso_prod, preco_unitario, validade_prod)
                VALUES (@nome, @tipo, @peso, @preco, @validade)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@validade", validade);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto salvo com sucesso!");
                LimparCamposProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o produto: " + ex.Message);
            }
        }

        private void LimparCamposProduto()
        {
         
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
