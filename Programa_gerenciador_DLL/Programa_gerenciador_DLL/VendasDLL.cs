using MySql.Data.MySqlClient;
using System;

namespace Programa_gerenciador_DLL
{
    public class VendasDLL
    {
        public void RegistrarVenda(int codProduto, int clienteId, decimal valor)
        {
            var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
            using (var conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();

                var sql = @"INSERT INTO vendas 
                            (cod_prod, data_vend, cliente_id, valor_vend)
                            VALUES (@cod_prod, @data_vend, @cliente_id, @valor_vend)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@cod_prod", codProduto);
                    cmd.Parameters.AddWithValue("@data_vend", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cliente_id", clienteId);
                    cmd.Parameters.AddWithValue("@valor_vend", valor);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


}

