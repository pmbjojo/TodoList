using Microsoft.EntityFrameworkCore;
using TodoList.Contracts.Repositories;
using TodoList.Data;
using TodoList.Shared.Domains;

namespace TodoList.Repositories
{
    public class PostRepository : IPostRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;
        public PostRepository(IDbContextFactory< AppDbContext> DbFactory)
        {
            _appDbContext = DbFactory.CreateDbContext();
        }
        public async Task AddPost(Post post)
        {
            await _appDbContext.Posts.AddAsync(post);
        }

        public Task DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _appDbContext.Posts.ToListAsync();
        }

        public async Task<Post?> GetPostById(int postId)
        {
            return await _appDbContext.Posts.FirstOrDefaultAsync(p => p.PostId == postId);
        }

        public Task UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
