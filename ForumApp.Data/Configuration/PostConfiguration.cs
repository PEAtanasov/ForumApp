using ForumApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForumApp.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(GenerateInitalPosts());
        }

        private ICollection<Post> GenerateInitalPosts()
        {
            ICollection<Post> posts = new List<Post>();
            
            Post post;

            post = new Post()
            {
                Title = "First Post",
                Content = "Firste sit amet faucibus velit, in facilisis neque. Quisque posuere ex quis tincidunt porta. Curabitur.\r\n\r\n"
            };
            posts.Add(post);

            post = new Post()
            {
                Title = "Second Post",
                Content = "Seconde sit amet faucibus velit, in facilisis neque. Quisque posuere ex quis tincidunt porta. Curabitur.\r\n\r\n"
            };
            posts.Add(post);

            post = new Post()
            {
                Title = "Third Post",
                Content = "Thirde sit amet faucibus velit, in facilisis neque. Quisque posuere ex quis tincidunt porta. Curabitur.\r\n\r\n"
            };
            posts.Add(post);

            return posts;
        }
    }
}
