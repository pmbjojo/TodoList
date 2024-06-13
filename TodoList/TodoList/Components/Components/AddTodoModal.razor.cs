using Microsoft.AspNetCore.Components;
using TodoList.Components.Pages;

namespace TodoList.Components.Components
{
    public partial class AddTodoModal
    {
        [Parameter]
        public bool isOpen { get; set; }
        
        public void Close()
        {
            isOpen = false;
        }
    }
}
