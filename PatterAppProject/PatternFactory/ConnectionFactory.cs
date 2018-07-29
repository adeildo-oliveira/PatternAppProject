using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PatterAppProject.PatternFactory
{
    public class ConnectionFactory : IConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection(new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").
            Build().GetConnectionString("DefaultConnection"));

            return conexao;
        }
    }
}
