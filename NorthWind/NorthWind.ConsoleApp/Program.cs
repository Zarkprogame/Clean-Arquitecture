using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using NorthWind.Writters;

IUserActionWritter Writter = new ConsoleWritter();

AppLogger Logger = new AppLogger(Writter);
Logger.WriteLog("Application Starded.");