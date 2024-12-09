using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using NorthWind.Writters;

IUserActionWritter Writter = new DebugWritter();

AppLogger Logger = new AppLogger(Writter);
Logger.WriteLog("Application Starded.");

ProductService Service = new ProductService(Writter);
Service.Add("Demo", "Azucar Refinada");