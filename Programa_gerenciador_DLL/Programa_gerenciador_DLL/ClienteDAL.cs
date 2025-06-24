using MySql.Data.MySqlClient;

namespace Programa_gerenciador_DLL
{
    public class ClienteDAL
    {
        public void SalvarCliente(string id, string nome, string cpf, string sexo, string telefone, string endereco)
        {
            var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
            using (var conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();

                var sql = @"INSERT INTO clientes 
                    (id_cliente, nome_cli, cpf_cli, sexo_cli, tel_cli, endereco_cli)
                    VALUES (@id, @nome_cli, @cpf_cli, @sexo_cli, @tel_cli, @endereco_cli)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome_cli", nome);
                    cmd.Parameters.AddWithValue("@cpf_cli", cpf);
                    cmd.Parameters.AddWithValue("@sexo_cli", sexo);
                    cmd.Parameters.AddWithValue("@tel_cli", telefone);
                    cmd.Parameters.AddWithValue("@endereco_cli", endereco);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}

