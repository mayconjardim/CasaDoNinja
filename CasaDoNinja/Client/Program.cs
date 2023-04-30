global using CasaDoNinja.Shared;
global using CasaDoNinja.Shared.Dtos;
global using System.Net.Http.Json;
global using CasaDoNinja.Client.Services.ProductService;
global using CasaDoNinja.Client.Services.CategoryService;
global using CasaDoNinja.Client.Services.CartService;
global using CasaDoNinja.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;


using CasaDoNinja.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();



await builder.Build().RunAsync();
