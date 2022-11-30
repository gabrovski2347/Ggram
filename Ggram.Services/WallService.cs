using Ggram.Contracts;
using Ggram.Data.Models;
using Ggram.Web.Data;
using Ggram.Web.ViewModels.Post;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Services
{
    public class WallService : IWallService
    {
        private readonly ApplicationDbContext context;

        public WallService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<PostViewModel>> GetAllAsync()
        {
            var entities = await context.Posts
                .ToListAsync();

            return entities.Select(p => new PostViewModel
            {
                Description = p.Description,
                Title = p.Title
            });
        }

        public async Task AddPostAsync(PostViewModel model)
        {
            var entity = new Post()
            {
                Title = model.Title,
                Description = model.Description
            };

            await context.Posts.AddAsync(entity);
            await context.SaveChangesAsync();
        }
    }
}
