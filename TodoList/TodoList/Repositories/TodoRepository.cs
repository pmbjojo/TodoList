﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TodoList.Contracts.Repositories;
using TodoList.Data;
using TodoList.Shared.Domains;

namespace TodoList.Repositories
{
    public class TodoRepository: ITodoRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;
        public TodoRepository(IDbContextFactory<AppDbContext> DbFactory)
        {
            _appDbContext = DbFactory.CreateDbContext();
        }
        public async Task<Todo> AddTodo(Todo Todo)
        {
            await _appDbContext.Todos.AddAsync(Todo);
            await _appDbContext.SaveChangesAsync();
            return Todo;
        }

        public Task DeleteTodo(int TodoId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Todo>> GetAllTodos()
        {
            return await _appDbContext.Todos.ToListAsync();
        }

        public async Task<Todo?> GetTodoById(int TodoId)
        {
            return await _appDbContext.Todos.FirstOrDefaultAsync(p => p.TodoId == TodoId);
        }

        public Task UpdateTodo(Todo Todo)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
