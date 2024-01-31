using ForumApp.Core.Services.Interfaces;
using ForumApp.Core.ViewModels;
using ForumApp.Data.Models;
using ForumApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Core.Services;

public class PostService : IPostService
{
    private readonly IRepository repository;

    public PostService(IRepository Repository)
    {
        this.repository = Repository;
    }

    public async Task CreateAsync(PostViewModel model)
    {
        Post post = new Post()
        {
            Title = model.Title,
            Content = model.Content,
        };
        
        await repository.AddAsync(post);
        await repository.SaveChangesAsync();
    }

    public async Task<PostViewModel> GetByIdAsync(Guid id)
    {
        var post = await repository.GetByIdAsync<Post>(id);

        var postModel = new PostViewModel()
        {
            Id = post.Id,
            Title = post.Title,
            Content = post.Content,
        };

        return postModel;
    }

    public PostViewModel GetPostFormModel()
    {
        var model = new PostViewModel();
        return model;
    }

    public async Task<IEnumerable<PostViewModel>> GettAllAsync()
    {
        var models = await repository.GetAllAsReadOnly<Post>()
            .Select(p => new PostViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content
            })
            .ToListAsync();

        return models;
    }

    public async Task EditAsync(PostViewModel model)
    {
        Post? baseModel = await repository.GetAllAsync<Post>().FirstOrDefaultAsync(p=>p.Id==model.Id);

        if (baseModel == null)
        {
            throw new ArgumentException("The post could not be found.");
        }
        baseModel.Title=model.Title;
        baseModel.Content=model.Content;

        await repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(PostViewModel model)
    {
        Post? baseModel = await repository.GetAllAsync<Post>().FirstOrDefaultAsync(p => p.Id == model.Id);

        if (baseModel==null)
        {
            throw new ArgumentException("Error ocured while deleting model");
        }
        else
        {
            repository.DeleteAsync(baseModel);
            await repository.SaveChangesAsync();

        }
    }
}
