using Ggram.Contracts;
using Ggram.Data.Models;
using Ggram.Web.Data;
using Ggram.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext context;

        public PostService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task AddPostAsync(AddPostViewModel model)
        {
            var post = new Post()
            {
                Description = model.Description,
                Title = model.Title,
                UserId = model.UserId
            };

            await context.Posts.AddAsync(post);
            await context.SaveChangesAsync();
        }

        public async Task<List<PostViewModel>> GetPosts(string id)
        {
            var currUser = context.Users.FirstOrDefault(u => u.Id == id);

            var followedUsers = currUser.Followed;

            List<ApplicationUser> users = new List<ApplicationUser>();

            users.Add(currUser);

            foreach (var followed in followedUsers)
            {
                users.Add(context.Users.FirstOrDefault(u => u.Id == followed.FollowedId));
            }

            List<PostViewModel> posts = new List<PostViewModel>();

            foreach (var user in users)
            {
                user.Posts = await context.Posts.Where(p => p.UserId == user.Id).ToListAsync();
                foreach(var post in user.Posts)
                {
                    PostViewModel postViewModel = new PostViewModel()
                    {
                        Description = post.Description,
                        Title = post.Title,
                    };
                    posts.Add(postViewModel);
                }
            }

            return posts;
        }
    }
}
