﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.ConsoleApp.Services;

internal class AppLogger(IEnumerable<IUserActionWritter> writters)
{
	public void WriteLog(string messagge)
	{
		UserAction Log = new UserAction("System", messagge);
		foreach (var writter in writters)
			writter.Write(Log);
	}
}
