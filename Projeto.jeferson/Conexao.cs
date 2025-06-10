using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.jeferson
{
    class Conexao
    {
       
            private MySqlConnection conn;

            public Conexao()
            {
                string connectionString = "server=localhost;database=trabalho;user=root;password=;";
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


