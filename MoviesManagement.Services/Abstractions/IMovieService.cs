using MoviesManagement.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Abstractions
{
    public interface IMovieService
    {
        Task<List<MovieModel>> GetAllActiveAsync();
        Task<MovieModel> GetActiveAsync(int id);
        Task<MovieModel> GetAsync(int id);
        Task<List<MovieModel>> GetAllAsync();

        Task UpdateAsync(MovieModel model);

        Task DeleteAsync(int id);

        Task CreateAsync(MovieModel model);

        Task MakeActive(int id);

        Task<List<MovieModel>> GetAllNonActiveAsync();
    }
}
