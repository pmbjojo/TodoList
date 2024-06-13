using TodoList.Contracts.Repositories;
using TodoList.Contracts.Services;
using TodoList.Shared.Domains;

namespace TodoList.Services
{
    public class PostDataService : IPostDataService
    {
        private readonly IPostRepository _postRepository;
        public PostDataService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task AddPost(Post post)
        {
            await _postRepository.AddPost(post);
        }

        public Task DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            var posts = await _postRepository.GetAllPosts();
            return posts;
        }

        public Task<Post> GetPostById(int postId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
