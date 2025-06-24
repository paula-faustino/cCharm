using MySql.Data.MySqlClient;

namespace Programa_gerenciador_DLL
{
    public class FuncionarioDLL
    {
        public void SalvarFuncionario(string nome, string cpf, string sexo, string telefone, string endereco)
        {
            var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
            using (var conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();

                var sql = @"INSERT INTO funcionario
                        (nome_func, cpf_func, sexo_func, tel_func, endereco_func)
                        VALUES (@nome_func, @cpf_func, @sexo_func, @tel_func, @endereco_func)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome_func", nome);
                    cmd.Parameters.AddWithValue("@cpf_func", cpf);
                    cmd.Parameters.AddWithValue("@sexo_func", sexo);
                    cmd.Parameters.AddWithValue("@tel_func", telefone);
                    cmd.Parameters.AddWithValue("@endereco_func", endereco);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
