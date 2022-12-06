using Ggram.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Ggram.Services;
using Ggram.Web.ViewModels.User;
using Ggram.Contracts;
using Ggram.Web.ViewModels.Post;
using Ggram.Web.Data;

namespace Ggram.Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IUserService userService;
        private readonly ApplicationDbContext context;

        public UserController(
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager,
            IUserService _userService,
            ApplicationDbContext _context)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            userService = _userService;
            context = _context;
        }

        //public async Task<IActionResult> Index(string searchString)
        //{ 
        //    var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

        //    var user = await userService.ReadUserAsync(userId);

        //    UserViewModel model = await userService.CreateModel(user);

        //    return View(model);
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "User");
            }

            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await userService.RegisterUserAsync(model);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "User");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await userService.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> All()
        {
            List<UserViewModel> users = await userService.GetUsers();

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchValue, int page)
        {
            var model = new UserSearchViewModel();
            model.SearchValue = searchValue;
            model.Page = page;
            model.AllMatchesCount = await userService.GetUsersCountAsync(searchValue);

            if (page == 0 || page < 1)
            {
                return RedirectToAction(nameof(Search), new { searchValue, page = 1 });
            }

            var users = await userService.FindUsersAsync(searchValue, page);

            if ((users?.Count() ?? 0) == 0 && page > 1)
            {
                return RedirectToAction(nameof(Search), new { searchValue, page = page - 1 });
            }

            if (users != null)
            {
                model.Users = users.ToList();
            }

            ViewBag.ReturnUrl = $"/User/Search?searchValue={searchValue}&page={page}";

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(UserSearchViewModel model)
        {
            return RedirectToAction("Search", "User", new { searchValue = model.SearchValue });
        }
    }
}
