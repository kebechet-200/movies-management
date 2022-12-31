using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MoviesManagement.Data.Ef.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private IBaseRepository<Movie> _repo;

        public MovieRepository(IBaseRepository<Movie> repo)
        {
            _repo = repo;
        }

        public async Task<List<Movie>> GetAllActiveAsync()
        {
            return await _repo.Table.Where(x => x.IsActive && !x.IsExpired).ToListAsync();
        }

        public async Task<List<Movie>> GetAllAsync() =>
            await _repo.Table.Where(x => !x.IsExpired).ToListAsync();

        public async Task<DateTime> MovieStartDate(int id)
        {
            var movie = await _repo.Table.SingleOrDefaultAsync(x => x.Id == id);
            return movie.StartDate;
        }

        public async Task<Movie> GetAsync(int id) =>
            await _repo.Table.Include(x => x.Tickets).SingleOrDefaultAsync(x => x.Id == id && !x.IsExpired);

        public async Task<Movie> GetActiveAsync(int id) =>
             await _repo.Table.Include(x => x.Tickets).SingleOrDefaultAsync(x => x.Id == id && x.IsActive && !x.IsExpired);

        public async Task MovieExpiration()
        {
            var movies = _repo.Table.
                Include(x => x.Tickets).
                AsNoTracking().
                Where(x => DateTime.Now >= x.StartDate);

            foreach (var movie in movies)
            {
                movie.IsExpired = true;
                await _repo.UpdateAsync(movie);
            }
        }

        public async Task UpdateAsync(Movie movie) =>
            await _repo.UpdateAsync(movie);

        public async Task<List<Movie>> GetAllNonActiveAsync() =>
            await _repo.Table.Where(x => !x.IsActive && !x.IsExpired).ToListAsync();

        public async Task DeleteAsync(int id)
        {
            var movie = await this.GetAsync(id);
            await _repo.RemoveAsync(movie);
        }

        public async Task CreateAsync(Movie movie) =>
            await _repo.AddAsync(movie);

        public async Task MakeActive(int id)
        {
            var movie = await this.GetAsync(id);
            movie.IsActive = true;
            await _repo.UpdateAsync(movie);
        }
    }
}
