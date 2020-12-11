using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DataAccess.Repositories
{
    public interface IGenericRepository<T>
    {
        IDbConnection GetOpenConnection();
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByUid(Guid uid);
    }
}
