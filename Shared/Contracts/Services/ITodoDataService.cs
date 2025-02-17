﻿using TodoList.Shared.Domains;

namespace TodoList.Shared.Contracts.Services
{
    public interface ITodoDataService
    {
        Task<IEnumerable<Todo>> GetAllTodos();
        Task<Todo> GetTodoById(int TodoId);
        Task<Todo> AddTodo(Todo Todo);
        Task UpdateTodo(Todo Todo);
        Task DeleteTodo(Todo todo);
    }
}
