using System;
using System.Windows.Forms;
using Banco;
using MySql.Data.MySqlClient;

namespace Projeto.jeferson
{
    public partial class cadastrope : Form
    {
        public cadastrope()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        { 
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string cpf = txtcpf.Text;
            string senha = txtsenha.Text;

            string conexaoString = "Server=localhost;3306;Database=trabaio_jef;Uid=seuUsuario;Pwd=suaSenha;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sql = "INSERT INTO usuarios (nome, cpf, senha) VALUES (@nome, @cpf, @senha)";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@cpf", cpf);
                        comando.Parameters.AddWithValue("@senha", senha);

                        int resultado = comando.ExecuteNonQuery();

                        if (resultado > 0)
                            MessageBox.Show("Usuário cadastrado com sucesso!");
                        else
                            MessageBox.Show("Erro ao cadastrar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }
        }
    }
}
