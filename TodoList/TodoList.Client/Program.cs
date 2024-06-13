using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TodoList.Client.Services;
using TodoList.Shared.Contracts.Services;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddScoped<ITodoDataService, ClientTodoDataService>();
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

await builder.Build().RunAsync();
