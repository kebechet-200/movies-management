using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.PersistanceDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Ef
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); // table checking in runtime
        }

        public IQueryable<T> Table => _dbSet; // assign table object to property

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            _context.SaveChanges();
            
        }

        public async Task<bool> AnyAsync(Expression<Func<T,bool>> expression) =>
            await _dbSet.AnyAsync(expression); // takes an expression as a parameter, derived class decides how to find an entity.

        public async Task<List<T>> GetAllAsync() =>
            await _dbSet.ToListAsync();

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression) =>
            await _dbSet.SingleOrDefaultAsync(expression);

        public async Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null) return;

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
