using ForumApp.Core.ViewModels;
using ForumApp.Data.Models;

namespace ForumApp.Core.Services.Interfaces;

public interface IPostService
{
    Task<IEnumerable<PostViewModel>> GettAllAsync();

    PostViewModel GetPostFormModel();

    Task CreateAsync(PostViewModel model);

    Task<PostViewModel> GetByIdAsync(Guid id);

    Task EditAsync(PostViewModel model);

    Task DeleteAsync(PostViewModel model);

}
