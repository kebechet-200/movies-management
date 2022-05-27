using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Repository_Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllActiveAsync();
        Task<List<Movie>> GetAllNonActiveAsync();
        Task<List<Movie>> GetAllAsync();
        Task<Movie> GetActiveAsync(int id);
        Task MakeActive(int id);
        Task<Movie> GetAsync(int id);
        Task<DateTime> MovieStartDate(int id);

        Task CreateAsync(Movie movie);

        Task UpdateAsync(Movie movie);

        Task DeleteAsync(int id);

        Task MovieExpiration();
    }
}
