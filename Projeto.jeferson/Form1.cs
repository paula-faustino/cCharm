namespace Projeto.jeferson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ShowDialog serve para criar uma pagina
        private void button4_Click(object sender, EventArgs e)
        {
            cadastrope cadastro = new cadastrope();
            cadastro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrarpro cadastrarProduto = new Cadastrarpro();
            cadastrarProduto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selecionar selecionar = new Selecionar();
            selecionar.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
