namespace ForumApp.Data.Repositories;

public interface IRepository
{
    IQueryable<T> GetAllAsync<T>() where T : class;
    IQueryable<T> GetAllAsReadOnly<T>() where T : class;

    Task<T?> GetByIdAsync<T>(Guid id) where T : class;

    Task AddAsync<T>(T entity) where T : class;

    void DeleteAsync<T>(T entity) where T : class;

    Task<int> SaveChangesAsync();

}
