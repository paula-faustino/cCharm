using System;
using System.Windows.Forms;

namespace Projeto.jeferson
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre o menu principal sem fechar o login
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string senha = textBox5.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validar.LoginValido(login, senha))
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Fecha o login
                Form1 form1 = new Form1();
                form1.Show();
            }
            else if (Validar.LoginClienteValido(login, senha))
            {
                MessageBox.Show("Login do cliente realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Fecha o login
                cadastrope cadastro = new cadastrope();
                cadastro.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}