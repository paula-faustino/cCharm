using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto.jeferson
{
    public static class Validar
    {
        public static bool LoginValido(string login, string senha)
        {
            try
            {
                using (MySqlConnection conn = new Conexao().Abrir())
                {
                    string query = "SELECT COUNT(*) FROM usuarios WHERE login = @login AND senha = @senha AND ativo = TRUE";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar login: " + ex.Message);
                return false;
            }
        }

        public static bool LoginClienteValido(string cpfCnpj, string senha)
        {
            try
            {
                using (MySqlConnection conn = new Conexao().Abrir())
                {
                    string query = "SELECT COUNT(*) FROM clietes WHERE (cpf = @cpf OR cnpj = @cpf) AND senha_cliente = @senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cpf", cpfCnpj);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar cliente: " + ex.Message);
                return false;
            }
        }
    }
}