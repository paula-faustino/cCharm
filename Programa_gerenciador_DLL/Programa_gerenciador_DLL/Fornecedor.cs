using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Programa_gerenciador_DLL
{
    public class Fornecedor
    {
        public void SalvarFornecedor(string nome, string cnpj, string telefone, string endereco, string email)
        {



            var strConexao = "server=localhost;uid=root;pwd=;database=trabaio;";
            using (var conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();

                var sql = @"INSERT INTO fornecedores
                (nome_forn, cnpj_forn, tel_forn, email_forn, endereco_forn)
                VALUES (@nome, @cnpj, @telefone, @email, @endereco)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@endereco", endereco);

                    cmd.ExecuteNonQuery();
                } 
            } 
        }
    }
}
