using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.API.Models.DTO;
using MoviesManagement.API.Models.Request;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Implementations;
using MoviesManagement.Services.Models;

namespace MoviesManagement.API.Infrastructure.Mapping
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

            TypeAdapterConfig<MovieModel, MovieDTO>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<AccountRegisterDTO, UserModel>
                .NewConfig();

            TypeAdapterConfig<AccountLoginDTO, UserModel>
                .NewConfig();

            TypeAdapterConfig<TicketModel, Ticket>
                .NewConfig();

            TypeAdapterConfig<TicketRequestDTO, TicketModel>
                .NewConfig();
        }
    }
}
