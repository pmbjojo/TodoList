using Microsoft.EntityFrameworkCore.ChangeTracking;
using TodoList.Shared.Domains;

namespace TodoList.Contracts.Repositories
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetAllTodos();
        Task<Todo?> GetTodoById(int TodoId);
        Task<Todo> AddTodo(Todo Todo);
        Task UpdateTodo(Todo Todo);
        Task DeleteTodo(int TodoId);
    }
}
