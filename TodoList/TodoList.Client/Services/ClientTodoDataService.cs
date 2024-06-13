using System.Text.Json;
using TodoList.Shared.Contracts.Services;

using TodoList.Shared.Domains;

namespace TodoList.Client.Services
{
    public class ClientTodoDataService : ITodoDataService
    {
        private readonly HttpClient _httpClient;
        public ClientTodoDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<Todo> AddTodo(Todo Todo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Todo>> GetAllTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<Todo> GetTodoById(int TodoId)
        {
            Console.WriteLine($"Getting Todo with id {TodoId}");
            var todo = await JsonSerializer.DeserializeAsync<Todo>(
                await _httpClient.GetStreamAsync($"/api/todos/{TodoId}"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return todo;
        }

        public Task UpdateTodo(Todo Todo)
        {
            throw new NotImplementedException();
        }
    }
}
