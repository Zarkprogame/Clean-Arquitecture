﻿using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writters
{
	public class FileWritter : IUserActionWritter
	{
		public void Write(UserAction action)
		{
			File.AppendAllText("AppLogs.txt", string.Format("FileWriter: {0}, {1}, {2}",
				action.CreatedDateTime, action.User, action.Descripcion));
		}
	}
}
