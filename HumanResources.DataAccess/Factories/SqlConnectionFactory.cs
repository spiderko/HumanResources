using System.Data;
using System.Data.SqlClient;

namespace HumanResources.DataAccess.Factories
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection GetConnection(string connectionString)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
