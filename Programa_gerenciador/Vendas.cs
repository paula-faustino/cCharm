using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programa_gerenciador
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // quatidade Vendas
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ID pro textBox2 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // data textBox3
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //id_cli textBox4
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int cod_prod = int.Parse(textBox2.Text);
                DateTime data_venda = DateTime.Now;
                int cliente_id = int.Parse(textBox4.Text);
                decimal valor = decimal.Parse(textBox4.Text);

                // String de conexão com o banco
                string strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string sql = @"INSERT INTO vendas 
                (cod_prod, data_vend, cliente_id, valor_vend)
                VALUES (@cod_prod, @data_vend, @cliente_id, @valor_vend)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@cod_prod", cod_prod);
                        cmd.Parameters.AddWithValue("@data_vend", data_venda);
                        cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
                        cmd.Parameters.AddWithValue("@valor_vend", valor);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venda salva com sucesso!");
                LimparCamposVenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a venda: " + ex.Message);
            }
            VendasTotal vendasTotal = new VendasTotal();
            vendasTotal.ShowDialog();
        }
        private void LimparCamposVenda()
        {
            textBox2.Clear();
            textBox4.Clear(); 
            textBox4.Clear();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

