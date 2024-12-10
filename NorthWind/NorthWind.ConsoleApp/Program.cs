﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using NorthWind.Writters;

var Builder = Host.CreateApplicationBuilder();

Builder.Services.AddSingleton<IUserActionWritter, DebugWritter>();
Builder.Services.AddSingleton <AppLogger>();
Builder.Services.AddSingleton <ProductService>();

using var AppHost = Builder.Build();

AppLogger logger = AppHost.Services.GetRequiredService<AppLogger>();
logger.WriteLog("Application Started");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azucar");
