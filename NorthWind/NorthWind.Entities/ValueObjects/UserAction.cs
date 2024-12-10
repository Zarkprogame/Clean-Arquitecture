using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjects
{
	public class UserAction(String user, string descripcion)
	{
		public DateTime CreatedDateTime { get; } = DateTime.Now;
		public string User => user;
		public string Descripcion => descripcion;
	}
}
