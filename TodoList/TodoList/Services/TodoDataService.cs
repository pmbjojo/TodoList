using TodoList.Contracts.Repositories;
using TodoList.Shared.Contracts.Services;
using TodoList.Shared.Domains;

namespace TodoList.Services
{
    public class TodoDataService : ITodoDataService
    {
        private readonly ITodoRepository _TodoRepository;
        public TodoDataService(ITodoRepository TodoRepository)
        {
            _TodoRepository = TodoRepository;
        }

        public async Task<Todo> AddTodo(Todo Todo)
        {
            return await _TodoRepository.AddTodo(Todo) ;
        }

        public async Task DeleteTodo(Todo todo)
        {
            await _TodoRepository.DeleteTodo(todo);
        }

        public async Task<IEnumerable<Todo>> GetAllTodos()
        {
            var Todos = await _TodoRepository.GetAllTodos();
            return Todos;
        }

        public async Task<Todo> GetTodoById(int TodoId)
        {
            return await _TodoRepository.GetTodoById(TodoId);
        }

        public async Task UpdateTodo(Todo Todo)
        {
            await _TodoRepository.UpdateTodo(Todo);
        }
    }
}
