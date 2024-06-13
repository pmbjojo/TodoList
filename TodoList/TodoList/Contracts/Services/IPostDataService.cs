using TodoList.Shared.Domains;

namespace TodoList.Contracts.Services
{
    public interface IPostDataService
    {       
        Task<IEnumerable<Post>> GetAllPosts();
        Task<Post> GetPostById(int postId);
        Task AddPost(Post post);
        Task UpdatePost(Post post);
        Task DeletePost(int postId);
    }
}
