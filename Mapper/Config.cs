using AutoMapper;
using Ggram.Data.Models;
using Ggram.Web.ViewModels.User;

namespace Mapper
{
    public class Config
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<ApplicationUser, UserViewModel>());
    }
}