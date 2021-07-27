using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MVCrelations.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> Select(
                Expression<Func<T, bool>> filter,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
                string includes
        );
        Task<T> Find(object id);
        Task Insert(T entity);
        Task<bool> Delete(object id);
        Task Update(T entityToUpdate, byte[] rowVersion);

       // IEnumerable<T> NativeSQL(string query, params object[] parameters);
    }
}
