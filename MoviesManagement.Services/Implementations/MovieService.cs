using Mapster;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Exceptions;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Implementations
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _repo;

        public MovieService(IMovieRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<MovieModel>> GetAllActiveAsync()
        {
            var movies = await _repo.GetAllActiveAsync();
            return movies.Adapt<List<MovieModel>>();
        }


        public async Task<MovieModel> GetActiveAsync(int id)
        {
            var model =  await _repo.GetActiveAsync(id);
            if (model == null)
                throw new MovieIsNotAvailableAtCinema("თქვენ მიერ არჩეული ფილმი ამ დროისთვის მიუწვდომელია");
            return model.Adapt<MovieModel>();// adapt
        }

        public async Task<List<MovieModel>> GetAllAsync()
        {
            var movies = await _repo.GetAllAsync();
            if (movies == null)
                throw new MovieIsNotAvailableAtCinema("ფილმები ვერ მოიძებნა");
            return movies.Adapt<List<MovieModel>>();
        }

        public async Task<MovieModel> GetAsync(int id)
        {
            var movie = await _repo.GetAsync(id);
            if (movie == null)
                throw new MovieIsNotAvailableAtCinema("თქვენ მიერ არჩეული ფილმი ამ დროისთვის მიუწვდომელია");

            return movie.Adapt<MovieModel>();
        }

        public async Task UpdateAsync(MovieModel model) =>
            await _repo.UpdateAsync(model.Adapt<Movie>());

        public async Task DeleteAsync(int id) =>
            await _repo.DeleteAsync(id);

        public async Task CreateAsync(MovieModel model) =>
            await _repo.CreateAsync(model.Adapt<Movie>());

        public async Task<List<MovieModel>> GetAllNonActiveAsync()
        {
            var nonActiveMovies =  await _repo.GetAllNonActiveAsync();
            return nonActiveMovies.Adapt<List<MovieModel>>();
        }

        public async Task MakeActive(int id) =>
            await _repo.MakeActive(id);
    }
}
