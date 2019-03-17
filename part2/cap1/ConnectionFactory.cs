using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            // conexao.ConnectionString = new LeitorDeConfiguracao().LerConnectionString;
            conexao.ConnectionString = "User Id = root; Password=;Server=localhost;Database=bancothiago";
            conexao.Open();
            return conexao;
        }
    }
}