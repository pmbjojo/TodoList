using Blazorise;
using Microsoft.EntityFrameworkCore;
using TodoList.Components;
using TodoList.Contracts.Repositories;
using TodoList.Data;
using TodoList.Repositories;
using TodoList.Services;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Mvc;
using TodoList.Shared.Contracts.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

builder.Services.AddHttpClient();
builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));
builder.Services.AddScoped<ITodoDataService, TodoDataService>();
builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<TodosRefreshService, TodosRefreshService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(TodoList.Client._Imports).Assembly);

app.MapGet("/api/todos", async (ITodoDataService todosDataService) =>
{
    return await todosDataService.GetAllTodos();
});

app.MapGet("/api/todos/{id}", async ([FromRoute] int id, [FromServices] ITodoDataService todosDataService) =>
{
    return await todosDataService.GetTodoById(id);
});

app.Run();
