using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Admin.Models;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Models;

namespace MoviesManagement.Admin.Infrastructure.Mapping
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<MovieModel, Movie>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<MovieViewModel, MovieModel>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<UserModel, User>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<UserModel, UserWithTicketsViewModel>
                .NewConfig()
                .TwoWays();

            //TypeAdapterConfig<MovieModel, MovieViewModel>
            //    .NewConfig()
            //    .TwoWays();

            TypeAdapterConfig<LoginViewModel, UserModel>
                .NewConfig();

            TypeAdapterConfig<TicketModel, Ticket>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<TicketViewModel, TicketModel>
                .NewConfig()
                .TwoWays();

            //TypeAdapterConfig<TicketRequestViewModel, TicketModel>
            //    .NewConfig();


            TypeAdapterConfig<UserWithRolesModel, GetUserWithRolesViewModel>
                .NewConfig()
                .TwoWays();
                
            TypeAdapterConfig<UserRoles, UserWithRolesModel>
                .NewConfig()
                .TwoWays();
                

            TypeAdapterConfig<IdentityRole, RolesModel>
                .NewConfig();
        }
    }
}
