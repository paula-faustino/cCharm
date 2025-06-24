using MySql.Data.MySqlClient;

namespace Programa_gerenciador_DLL
{
    public class ProdutosDLL
    {
        public void SalvarProduto(string nome, string categoria, int quantidade, decimal preco)
        {
            var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
            using (var conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();

                var sql = @"INSERT INTO produtos
                        (nome_prod, categoria_prod, qtd_prod, preco_prod)
                        VALUES (@nome, @categoria, @quantidade, @preco)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@preco", preco);

                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}