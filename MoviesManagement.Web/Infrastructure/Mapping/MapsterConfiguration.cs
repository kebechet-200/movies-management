using Mapster;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Models;
using MoviesManagement.Web.Models;

namespace MoviesManagement.Web.Infrastructure.Mapping
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

            TypeAdapterConfig<MovieModel, MovieViewModel>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<AccountRegisterViewModel, UserModel>
                .NewConfig();

            TypeAdapterConfig<AccountLoginViewModel, UserModel>
                .NewConfig();

            TypeAdapterConfig<TicketModel, Ticket>
                .NewConfig()
                .TwoWays();
                

            TypeAdapterConfig<TicketRequestViewModel, TicketModel>
                .NewConfig();

            TypeAdapterConfig<UserRoles, UserWithRolesModel>
                .NewConfig()
                .TwoWays();
        }
    }
}
