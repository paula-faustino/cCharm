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
    public partial class VendasTotal : Form
    {
        public VendasTotal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
            using (var conexao = new MySqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();
                    string sql = @"SELECT v.id_vend, v.cod_prod, p.nome_prod, v.data_vend, v.cliente_id, c.nome_cli, v.valor_vend
                                   FROM vendas v
                                   JOIN produtos p ON v.cod_prod = p.cod_prod
                                   JOIN clientes c ON v.cliente_id = c.id_cliente";

                    using (var da = new MySqlDataAdapter(sql, conexao))
                    {
                        DataTable tabela = new DataTable();
                        da.Fill(tabela);
                        dataGridView1.DataSource = tabela;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar as vendas: " + ex.Message);
                }
            }
        }
   

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
