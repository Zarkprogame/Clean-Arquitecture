using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

IUserActionWritter Writter = default;

AppLogger Logger = new AppLogger(Writter);
Logger.WriteLog("Application Starded.");