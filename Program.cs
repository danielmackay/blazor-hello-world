using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorHelloWorld;
using Serilog;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.BrowserConsole()
    .CreateLogger();

await builder.Build().RunAsync();
