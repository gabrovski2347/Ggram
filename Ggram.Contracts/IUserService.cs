using Ggram.Data.Models;
using Ggram.Web.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Contracts
{
    public interface IUserService
    {
        Task<ApplicationUser> ReadUserAsync(string userId);

        Task<IEnumerable<ApplicationUser>> FindUserAsync(string keyword);

        Task SignOutAsync();

        Task<UserViewModel> GetUser();

        UserViewModel CreateModel(ApplicationUser user);

        Task<IdentityResult> RegisterUserAsync(RegisterViewModel model);
    }
}
