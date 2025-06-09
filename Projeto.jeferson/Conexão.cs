using MySql.Data.MySqlClient;

namespace Projeto.jeferson
{
    public class Conexao
    {
        private MySqlConnection conn;

        public Conexao()
        {
            string connectionString = "server=localhost;database=trabaio;user=root;password=;";
            conn = new MySqlConnection(connectionString);
        }

        public MySqlConnection Abrir()
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            return conn;
        }

        public MySqlConnection Fechar()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
            return conn;
        }
    }
}