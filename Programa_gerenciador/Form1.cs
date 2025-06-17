using MySql.Data.MySqlClient;

namespace Programa_gerenciador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrocli cadastroClientes = new Cadastrocli();
            cadastroClientes.ShowDialog();

        }

        private void cadastroDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrofunc cadastrofunc = new Cadastrofunc();
            cadastrofunc.ShowDialog();
        }

        private void materiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materiais materiais = new Materiais();
            materiais.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;pwd=root;database=trabaio;";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro ao conectar ao BD:" + ex.Message);

            }
        }
    }
}
