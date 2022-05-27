using Mapster;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Identity.Models;
using MoviesManagement.Services.Models;

namespace MoviesManagement.Identity.Infrastructure.Mapster
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection service)
        {
            TypeAdapterConfig<MovieModel, Movie>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<UserModel, User>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<RegistrationRequestViewModel, UserModel>
                .NewConfig();

            TypeAdapterConfig<LoginRequestViewModel, UserModel>
                .NewConfig();
        }
    }
}
