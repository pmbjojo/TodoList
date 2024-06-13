using Microsoft.EntityFrameworkCore.ChangeTracking;
using TodoList.Contracts.Repositories;
using TodoList.Contracts.Services;
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

        public Task DeleteTodo(int TodoId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Todo>> GetAllTodos()
        {
            var Todos = await _TodoRepository.GetAllTodos();
            return Todos;
        }

        public Task<Todo> GetTodoById(int TodoId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodo(Todo Todo)
        {
            throw new NotImplementedException();
        }
    }
}
