using Infrastructure;
using Microsoft.Extensions.Hosting;
using UserInterface.Forms;
using WindowsFormsLifetime;

var builder = Host.CreateApplicationBuilder(args);
builder.UseWindowsFormsLifetime<MainWindow>();

await builder.AddInfrastructure();

var app = builder.Build();
await app.RunAsync();