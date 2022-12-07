using Ggram.Contracts;
using Ggram.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Ggram.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService _postService)
        {
            postService = _postService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddPostViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            await postService.AddPostAsync(model);

            return RedirectToAction("All", "Post");
        }

        public async Task<IActionResult> All()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<PostViewModel> posts = await postService.GetPosts(id);

            return View(posts);
        }
    }
}
