using Ggram.Contracts;
using Ggram.Data.Models;
using Ggram.Web.Data;
using Ggram.Web.ViewModels;
using Ggram.Web.ViewModels.Post;
using Ggram.Web.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        private readonly ApplicationDbContext context;

        public UserService(ApplicationDbContext _context,
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager)
        {
            context = _context;
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public async Task<ApplicationUser> ReadUserAsync(string userId)
        {
            var user = await context.Users
                .Where(u => u.Id == userId)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            return user;
        }

        public Task SignOutAsync()
        {
            return signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> RegisterUserAsync(RegisterViewModel model)
        {
            string userId = Guid.NewGuid().ToString();

            var user = new ApplicationUser()
            {
                Id = userId,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Email = model.Email,
                UserName = model.UserName,
            };

            var result = await userManager.CreateAsync(user, model.Password);

            return result;
        }

        public async Task<List<UserViewModel>> GetUsers()
        {
            var users = await context
                .Users
                .Select(u => new UserViewModel
                {
                    Nickname = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Description = u.Description,
                })
                .ToListAsync();

            if (users == null)
            {
                throw new ArgumentException("No Users");
            }

            return users;
        }

        public async Task<List<UserViewModel>> FindUsersAsync(string searchValue, int page)
        {
            if (string.IsNullOrEmpty(searchValue))
            {
                return null;
            }

            var users = await context
                .Users
                .Where(u => u.NormalizedUserName.ToLower().Contains(searchValue.ToLower()))
                .Skip((page-1) * 10)
                .Take(10)
                .Select(u => new UserViewModel()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Nickname = u.UserName
                })
                .ToListAsync();

            return users;
        }

        public async Task<int> GetUsersCountAsync(string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
            {
                return 0;
            }

            var count = await context
                .Users
                .Where(u => u.UserName.ToLower().Contains(searchValue.ToLower()))
                .CountAsync();

            return count;
        }
    }
}
