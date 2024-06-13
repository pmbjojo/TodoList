using Microsoft.AspNetCore.Components;
using TodoList.Contracts.Services;
using TodoList.Shared.Domains;

namespace TodoList.Components
{
    public partial class Posts
    {
        public List<Post> PostsList { get; set; } = new List<Post> { new Post
            {
                PostId = 5,
                Author = "Admin",
                Description = "This is a sample post 5",
                Title = "Sample Post 5",
                Status = Status.PUBLISHED
            }};

        [Inject]
        public IPostDataService PostDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //await PostDataService.AddPost(new Post
            //{
            //    PostId = 5,
            //    Author = "Admin",
            //    Description = "This is a sample post 5",
            //    Title = "Sample Post 5",
            //    Status = Status.PUBLISHED
            //});
            PostsList = (await PostDataService.GetAllPosts()).ToList();
        }
    }
}
