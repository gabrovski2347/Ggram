using Ggram.Contracts;
using Ggram.Services;
using Ggram.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;

namespace Ggram.Web.Controllers
{
    public class WallController : Controller
    {
        private readonly IWallService wallService;

        public WallController(IWallService _wallService)
        {
            this.wallService = _wallService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await wallService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new PostViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await wallService.AddPostAsync(model);

                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
