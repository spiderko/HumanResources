using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HumanResources.DataAccess.Factories
{
    public interface IDbConnectionFactory
    {
        public IDbConnection GetConnection(string connectionString);
    }
}
