using Ggram.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Contracts
{
    public interface IPostService
    {
        Task AddPostAsync(AddPostViewModel model);
        Task<List<PostViewModel>> GetPosts(string id);
    }
}
