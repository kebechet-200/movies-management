using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Repository_Interfaces
{
    public interface IBaseRepository<T> where T : class
    {

        public IQueryable<T> Table { get; }
        Task<List<T>> GetAllAsync();

        Task<T> GetAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        Task RemoveAsync(T entity);

        Task UpdateAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    }
}
