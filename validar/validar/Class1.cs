using System;
using System.Data.SqlClient;

namespace ValidarBanco
{
    public static class Validar
    {

        private static string connectionString = "Data Source=SEU_SERVIDOR;Initial Catalog=SEU_BANCO;Integrated Security=True";

        public static bool UsuarioExiste(string nome)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE nome = @nome";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool CpfExiste(string cpf)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE cpf = @cpf";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool LoginValido(string nome, string senha)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE nome = @nome AND senha = @senha";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool CadastrarUsuario(string nome, string cpf, string senha)
        {
            if (UsuarioExiste(nome) || CpfExiste(cpf))
                return false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO usuarios (nome, cpf, senha) VALUES (@nome, @cpf, @senha)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
