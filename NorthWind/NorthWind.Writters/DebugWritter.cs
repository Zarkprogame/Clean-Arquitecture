using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writters 
{
	internal class DebugWritter : IUserActionWritter
	{
		public void Write(UserAction action)
		{
			Debug.WriteLine("Console Writter: {0}, {1}, {2}", action.CreatedDateTime, action.User, action.Descripcion);
		}
	}
}
