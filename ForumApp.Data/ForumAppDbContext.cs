using ForumApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data;

public class ForumAppDbContext : DbContext
{
    /// <summary>
    /// Constructor initializing the AppDbContext
    /// </summary>
    /// <param name="options"></param>
    public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
        : base(options)
    {
        
    }
    /// <summary>
    /// Set of post entities
    /// </summary>
    public DbSet<Post> Posts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ForumAppDbContext).Assembly);

    }
}
