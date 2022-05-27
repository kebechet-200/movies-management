using Mapster;
using Microsoft.AspNetCore.Identity;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Exceptions;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<IdentityResult> AddToRolesAsync(string userName, IEnumerable<string> roles)
        {
            return await _repo.AddToRolesAsync(userName, roles);
        }

        public async Task<string> AuthenticateAsync(UserModel user)
        {
            var userEntity = user.Adapt<User>();
            if (!await _repo.ExistsName(userEntity.UserName))
                throw new UserDoesNotExist("მომხმარებელი ვერ მოიძებნა");
            
            var entity = await _repo.LoginAsync(userEntity, user.Password);

            if (!entity.isRegistered)
                throw new InvalidLoginAttemptException("იუზერნეიმი ან პაროლი არასწორია.");

            return entity.UserId;
        }

        

        public async Task<RegisterStatus> CreateAsync(UserModel user)
        {
            var entity = user.Adapt<User>();
            if (!await _repo.CreateAsync(entity, user.Password))
                return RegisterStatus.RegisterFailed;

            return RegisterStatus.RegisteredSuccessfully;
        }

        public async Task DeleteAsync(string id)
        {
            if (id == null || !await _repo.Exists(id))
                throw new UserDoesNotExist("მომხმარებელი ვერ მოიძებნა");

            await _repo.DeleteAsync(id);
        }

        public async Task<IdentityResult> DeleteUserRoles(string userName, IEnumerable<string> roles)
        {
            return await _repo.DeleteUserRoles(userName, roles);
        }

        public async Task<List<UserModel>> GetAllAsync()
        {
            var users = await _repo.GetAllAsync();
            if (users == null)
                throw new UserDoesNotExist("მომხმარებლები ვერ მოიძებნა");
            return users.Adapt<List<UserModel>>();
        }

        public async Task<List<RolesModel>> GetAllRolesAsync()
        {
            var roles = await _repo.GetRoles();
            if (roles == null)
                throw new RolesNotFoundException("როლები ვერ იძებნება");
            return roles.Adapt<List<RolesModel>>();
        }

        public async Task<List<UserWithRolesModel>> GetAllUserWithRoles()
        {
            var usersWithRoles = await _repo.GetAllUserWithRoles();
            if (usersWithRoles == null)
                throw new UserDoesNotExist("მომხმარებლები ვერ მოიძებნა");

            return usersWithRoles.Adapt<List<UserWithRolesModel>>();
        }

        public async Task<UserModel> GetAsync(string id)
        {
            if (id == null || !await _repo.Exists(id))
                throw new UserDoesNotExist($"შემოწოდებული id {id} მომხმარებელი ვერ იძებნება");

            var user = await _repo.GetAsync(id);

            return user.Adapt<UserModel>();
        }

        public async Task<string> GetUserName(string id)
        {
            return await _repo.GetUserName(id);
        }

        public async Task<List<string>> GetUserRolesAsync(string userId)
        {
            return await _repo.GetUserRolesAsync(userId);
        }

        public async Task<UserModel> GetUserWithTicketsAsync(string id)
        {
            if (id == null || !await _repo.Exists(id))
                throw new UserDoesNotExist("მომხმარებელი ვერ იძებნება");

            var usersWithTickets = await _repo.GetUserWithTicketsAsync(id);

            return usersWithTickets.Adapt<UserModel>();
        }

        public async Task<bool> IsInRole(string userName, string roleName)
        {
            return await _repo.IsInRole(userName, roleName);
        }

        public async Task SignoutAsync()
        {
            await _repo.SignoutAsync();
        }

        public async Task UpdateAsync(UserModel user)
        {
            if (user == null || !await _repo.Exists(user.Id))
                throw new UserDoesNotExist("მომხმარებელი ვერ მოიძებნა");

            await _repo.UpdateAsync(user.Adapt<User>());
        }
    }
}
