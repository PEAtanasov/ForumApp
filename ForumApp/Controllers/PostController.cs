using ForumApp.Core.Services.Interfaces;
using ForumApp.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private IPostService postService;
        public PostController(IPostService postService)
        {
            this.postService=postService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> All() 
        {
            var model = await postService.GettAllAsync();

            return View(model);
        }

        
        public async Task<IActionResult> Add() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostViewModel model)
        {
            if (ModelState.IsValid)
            {            
                try
                {
                    await postService.CreateAsync(model);
                    return RedirectToAction("All");
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await postService.GetByIdAsync(id);

            string @break = "breal";

            return View(model);
        }

        [HttpPost] 
        public async Task<IActionResult> Edit(PostViewModel model) 
        {
            await postService.EditAsync(model);

            return RedirectToAction(nameof(All));
        }

       [HttpPost]
       public async Task<IActionResult> Delete(Guid Id)
        {
            var modelToDelete = await postService.GetByIdAsync(Id);
            await postService.DeleteAsync(modelToDelete);

            return RedirectToAction("All");
        }
    }
}
