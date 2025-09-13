using Microsoft.Extensions.Hosting;
using WindowsFormsLifetime;

using UserInterface;

var builder = Host.CreateApplicationBuilder(args);
builder.UseWindowsFormsLifetime<MainWindow>();

var app = builder.Build();
await app.RunAsync();

