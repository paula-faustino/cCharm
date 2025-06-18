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

namespace Programa_gerenciador
{
    public partial class Verprod : Form
    {
        public Verprod()
        {
            InitializeComponent();
        }

        private void Verprod_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;pwd=root;database=trabaio;";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("conexão ok");


            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro ao conectar ao BD:" + ex.Message);

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
            using (var conexao = new MySqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();
                    string sql = @"SELECT cod_prod, nome_prod, tipo_prod, peso_prod, preco_unitario, validade_prod 
                       FROM produtos";

                    using (var da = new MySqlDataAdapter(sql, conexao))
                    {
                        DataTable tabela = new DataTable();
                        da.Fill(tabela);
                        dataGridView1.DataSource = tabela;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
