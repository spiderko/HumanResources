using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DataAccess.Repositories
{
    public abstract class SqlRepository<T> : IGenericRepository<T>
        where T : class
    {

        private string _connectionString;


        public SqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByUid(Guid uid)
        {
            throw new NotImplementedException();
        }

        public IDbConnection GetOpenConnection()
        {
            throw new NotImplementedException();
        }
    }
}
