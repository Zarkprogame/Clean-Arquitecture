using Microsoft.Extensions.DependencyInjection;
using NorthWind.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writters
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddConsoleWritter(this IServiceCollection services)
		{
			services.AddSingleton<IUserActionWritter, ConsoleWritter>();
			return services;
		}
		public static IServiceCollection AddDebugWritter(this IServiceCollection services)
		{
			services.AddSingleton<IUserActionWritter, DebugWritter>();
			return services;
		}

		public static IServiceCollection AddFileWritter(this IServiceCollection services)
		{
			services.AddSingleton<IUserActionWritter, FileWritter>();
			return services;
		}
	}
}
