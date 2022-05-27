using Microsoft.AspNetCore.Identity;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Abstractions
{
    public interface IUserService
    {
        Task<RegisterStatus> CreateAsync(UserModel user);
        Task<string> AuthenticateAsync(UserModel user);
        Task SignoutAsync();
        Task<List<UserModel>> GetAllAsync();
        Task<UserModel> GetAsync(string id);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string id);
        Task<List<UserWithRolesModel>> GetAllUserWithRoles();
        Task<List<string>> GetUserRolesAsync(string userId);
        Task<UserModel> GetUserWithTicketsAsync(string id);

        Task<List<RolesModel>> GetAllRolesAsync();
        Task<bool> IsInRole(string userName, string roleName);

        Task<IdentityResult> DeleteUserRoles(string userName, IEnumerable<string> roles);
        Task<IdentityResult> AddToRolesAsync(string username, IEnumerable<string> roles);
        Task<string> GetUserName(string id);
    }
}
