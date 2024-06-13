using Microsoft.AspNetCore.Components;
using TodoList.Contracts.Services;
using TodoList.Shared.Domains;

namespace TodoList.Components.Pages
{
    public partial class Todos
    {

        public bool isAddTodoModalOpen { get; set; } = false;

        public void OpenAddTodoModal()
        {
            isAddTodoModalOpen = true;
            StateHasChanged();
            Console.WriteLine("OpenAddTodoModal", isAddTodoModalOpen);
        }
        [Parameter]
        public EventCallback<bool> OnAddTodo { get; set; }

        public List<Todo> TodosList { get; set; } = default!;

        [Inject]
        public ITodoDataService TodoDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            TodosList = (await TodoDataService.GetAllTodos()).ToList();
            Console.WriteLine("TodosList: " + TodosList.Count);
        }

        public async Task AddTodo()
        {
            Console.WriteLine("AddTodo");
            await TodoDataService.AddTodo(new Todo
            {
                Title = "Sample Todo 5",
                Description = "This is a sample todo 5",
                Author = "Admin",
                DeadLine = DateTime.Now.AddDays(1),
            });
            TodosList = (await TodoDataService.GetAllTodos()).ToList();
            StateHasChanged();
        }
    }
}
