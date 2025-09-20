using Microsoft.Extensions.Hosting;
using WindowsFormsLifetime;

using Infrastructure;
using UserInterface;

var builder = Host.CreateApplicationBuilder(args);
builder.UseWindowsFormsLifetime<MainWindow>();

builder.AddInfratructure(builder.Configuration);

var app = builder.Build();
await app.RunAsync();
