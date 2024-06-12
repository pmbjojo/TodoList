using TodoList.Shared.Domains;

namespace TodoList.Client.Services
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPosts();
        Task<Post> GetPost(int postId);
        Task<Post> AddPost(Post post);
        Task UpdatePost(Post post);
        Task DeletePost(int postId);
    }
}
