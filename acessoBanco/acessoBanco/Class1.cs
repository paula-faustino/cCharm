using System;
using System.Data;
using System.Data.SqlClient;

namespace Banco
{
    public class Conexao
    {
        private readonly string _stringConexao;
        public SqlConnection Con { get; private set; }

        public Conexao(string stringConexao)
        {
            _stringConexao = stringConexao;
            Con = new SqlConnection(_stringConexao);
        }

        public void Abrir()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }

        public void Fechar()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }
    }

    public class Comandos
    {
        private readonly SqlConnection _conexao;

        public Comandos(SqlConnection conexao)
        {
            _conexao = conexao;
        }

        public int ExecutarComando(string sql, params SqlParameter[] parametros)
        {
            using (SqlCommand cmd = new SqlCommand(sql, _conexao))
            {
                cmd.Parameters.AddRange(parametros);
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable ExecutarConsulta(string sql, params SqlParameter[] parametros)
        {
            using (SqlCommand cmd = new SqlCommand(sql, _conexao))
            {
                cmd.Parameters.AddRange(parametros);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }
    }
}
