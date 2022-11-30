using Ggram.Web.ViewModels.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Contracts
{
    public interface IWallService
    {
        Task<IEnumerable<PostViewModel>> GetAllAsync();

        Task AddPostAsync(PostViewModel model);
    }
}
