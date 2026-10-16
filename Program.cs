using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpriteSync;
using SpriteSync.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<CartStateService>(); // Injected Shared State

await builder.Build().RunAsync();