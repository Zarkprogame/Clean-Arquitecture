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
		public static IServiceCollection AddNorthWindServices(
			this IServiceCollection services)
		{
			services.AddDebugWritter();
			services.AddServices();
			return services;
		}
	}
}
