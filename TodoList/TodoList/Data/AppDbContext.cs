using Microsoft.EntityFrameworkCore;
using TodoList.Shared.Domains;

namespace TodoList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Todo> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 1,
                Author = "Admin",
                Description = "This is a sample post 1",
                Title = "Sample Post 1",
                Status = Status.PUBLISHED
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 2,
                Author = "Admin",
                Description = "This is a sample post 2",
                Title = "Sample Post 2",
                Status = Status.PUBLISHED
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 3,

                Author = "Admin",
                Description = "This is a sample post 3",
                Title = "Sample Post 3",
                Status = Status.PUBLISHED
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 4,

                Author = "Admin",
                Description = "This is a sample post 4",
                Title = "Sample Post 4",
                Status = Status.PUBLISHED
            });
        }
    }
}
