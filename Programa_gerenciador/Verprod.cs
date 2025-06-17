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

            Verprod verprod = new Verprod();
            verprod.Close();
        }
    }
}
