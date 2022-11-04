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
                .Include(u => u.Wall)
                .ThenInclude(w => w.Posts)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            return user;
        }

        public async Task<IEnumerable<ApplicationUser>> FindUserAsync(string keyword)
        {
            var users = await context.Users
                .Where(u => u.UserName.Contains(keyword))
                .Take(10)
                .ToListAsync();

            return users;
        }

        public Task SignOutAsync()
        {
            return signInManager.SignOutAsync();
        }

        public Task<UserViewModel> GetUser()
        {
            throw new ArgumentException();
        }

        public UserViewModel CreateModel(ApplicationUser user)
        {
            var posts = new List<PostViewModel>();

            foreach (var p in user.Wall.Posts)
            {
                posts.Add(new PostViewModel()
                {
                    Title = p.Title,
                    Description = p.Description
                });
            }

            var wall = new WallViewModel()
            {
                Posts = posts
            };

            var model = new UserViewModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Wall = wall
            };

            return model;
        }

        public async Task<IdentityResult> RegisterUserAsync(RegisterViewModel model)
        {
            string userId = Guid.NewGuid().ToString();
            var wall = new Wall()
            {
                Id = Guid.NewGuid().ToString(),
                OwnerId = userId
            };

            var user = new ApplicationUser()
            {
                Id = userId,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Email = model.Email,
                UserName = model.UserName,
                Wall = wall,
                WallId = wall.Id
            };

            var result = await userManager.CreateAsync(user, model.Password);

            return result;
        }
    }
}
