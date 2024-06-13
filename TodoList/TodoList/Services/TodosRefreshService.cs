using TodoList.Shared.Contracts.Services;

namespace TodoList.Services
{
    public class TodosRefreshService
    {
        public Func<Task> OnTodosModified { get; set; } = default!;

        public async Task NotifyTodosModified()
        {
            Console.WriteLine("NotifyTodosModified");
            if (OnTodosModified != null)
            {
                await OnTodosModified.Invoke();
            }
        }
    }
}
