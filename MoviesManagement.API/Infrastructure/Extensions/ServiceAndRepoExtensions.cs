using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Data.Ef;
using MoviesManagement.Data.Ef.Repositories;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Implementations;

namespace MoviesManagement.API.Infrastructure.Extensions
{
    public static class ServiceAndRepoExtensions
    {
        public static void AddServicesAndRepos(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJWTService, JWTService>();
            services.AddScoped<ITicketService, TicketService>();

            //repos
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ITicketRepository, TicketRepository>();
        }
    }
}
