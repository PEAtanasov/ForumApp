using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data.Repositories;

public class Repository : IRepository
{
    private readonly ForumAppDbContext dbcontext;

    public Repository(ForumAppDbContext dbcontext)
    {
        this.dbcontext = dbcontext;
    }

    public async Task AddAsync<T>(T entity) where T : class
    {
        await dbcontext.AddAsync(entity);
    }

    public void DeleteAsync<T>(T entity) where T : class
    {
         dbcontext.Remove(entity);
    }

    public IQueryable<T> GetAllAsync<T>() where T : class
    {
        return dbcontext.Set<T>();
    }

    public IQueryable<T> GetAllAsReadOnly<T>() where T : class
    {
        return dbcontext.Set<T>().AsNoTracking();
    }

    public async Task<T?> GetByIdAsync<T>(Guid id) where T : class
    {
        T? model = await dbcontext.Set<T>().FindAsync(id);
        return model;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbcontext.SaveChangesAsync();
    }
}
