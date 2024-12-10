using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using NorthWind.Writters;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();
using var AppHost = Builder.Build();

IAppLogger logger = AppHost.Services.GetRequiredService<IAppLogger>();
logger.WriteLog("Application Started");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar");