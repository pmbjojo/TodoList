using TodoList.Shared.Domains;

namespace TodoList.Contracts.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPosts();
        Task<Post?> GetPostById(int postId);
        Task AddPost(Post post);
        Task UpdatePost(Post post);
        Task DeletePost(int postId);
    }
}
