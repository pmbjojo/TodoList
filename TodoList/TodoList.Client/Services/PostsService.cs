using System.Text.Json;
using TodoList.Shared.Domains;

namespace TodoList.Client.Services
{
    public class PostsService : IPostService
    {
        private readonly HttpClient? _httpClient;
        public PostsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Post> AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPost(int postId)
        {
            var posts = await JsonSerializer.DeserializeAsync<IEnumerable<Post>>
        (await _httpClient.GetStreamAsync("api/posts"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return posts;

        }

        public Task UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
