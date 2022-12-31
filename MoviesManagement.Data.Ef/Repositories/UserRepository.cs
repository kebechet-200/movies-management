using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Ef.Repositories
{
    public  class UserRepository : IUserRepository
    {
        private readonly IBaseRepository<User> _baseRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRepository(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager, IBaseRepository<User> baseRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _baseRepository = baseRepository;
        }

        public async Task<bool> CreateAsync(User user, string password)
        {
            user.Id = Guid.NewGuid().ToString();
            var register = await _userManager.CreateAsync(user, password);

            if (register.Succeeded)
            {
                var defaultrole = await _roleManager.FindByNameAsync("Customer");
                if (defaultrole != null)
                {
                    IdentityResult roleresult = await _userManager.AddToRoleAsync(user, defaultrole.Name);
                    if (roleresult.Succeeded)
                        return true;
                }
                return true;
            }
            return false;   
        }

        public async Task<bool> Exists(string userId) =>
            await _userManager.FindByIdAsync(userId) != null;

        public async Task<bool> ExistsName(string username) =>
            await _userManager.FindByNameAsync(username) != null;

        public async Task<(bool isRegistered,string UserId)> LoginAsync(User user, string password)
        {

            var entity = await _userManager.FindByNameAsync(user.UserName);

            if (entity == null)
                return (false, null);// exception user could not found.
            
            var signInResult = await _signInManager.PasswordSignInAsync(entity, password, true, false);

            if (!signInResult.Succeeded)
                return (false, null);

            return (true,entity.Id);
        }

        public async Task SignoutAsync() =>
            await _signInManager.SignOutAsync();

        public async Task<List<User>> GetAllAsync() =>
            await _baseRepository.Table.ToListAsync();

        public async Task<List<UserRoles>> GetAllUserWithRoles()
        {
            var users = await this.GetAllAsync();
            var userRoles = new List<UserRoles>();
            

            foreach (var user in users)
            {
                var tempUserRoles = new UserRoles();
                tempUserRoles.Id = user.Id;
                tempUserRoles.UserName = user.UserName;
                tempUserRoles.Roles = await this.GetUserRolesAsync(user.Id);

                userRoles.Add(tempUserRoles);
            }

            return userRoles;

        }

        public async Task<List<string>> GetUserRolesAsync(string userId)
        {
            if(userId == null)
                return null;

            var user = await _baseRepository.GetAsync(x => x.Id == userId);
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        public async Task<User> GetAsync(string id) =>
            await _baseRepository.Table.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);

        public async Task<User> GetUserWithTicketsAsync(string id)
        {
            return await _baseRepository.Table.AsNoTracking()
                .Include(x => x.Tickets).ThenInclude(x => x.Movie)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(User user) =>
            await _baseRepository.UpdateAsync(user);

        public async Task DeleteAsync(string id)
        {
            var user = await this.GetAsync(id);
            if (user != null)
                await _baseRepository.RemoveAsync(user);
        }

        public async Task<List<IdentityRole>> GetRoles() =>
            await _roleManager.Roles.ToListAsync();
        public async Task<bool> IsInRole(string userName, string roleName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            return await _userManager.IsInRoleAsync(user, roleName);
        }

        public async Task<IdentityResult> DeleteUserRoles(string userName, IEnumerable<string> roles)
        {

            var user = await _userManager.FindByNameAsync(userName);

            return await _userManager.RemoveFromRolesAsync(user, roles); 
        }

        public async Task<IdentityResult> AddToRolesAsync(string userName, IEnumerable<string> roles)
        {
            var user = await _userManager.FindByNameAsync(userName);

            return await _userManager.AddToRolesAsync(user, roles);
        }

        public async Task<string> GetUserName(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return user.UserName;
        }
    }
}
