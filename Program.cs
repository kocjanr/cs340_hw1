﻿using System;

namespace Homework_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Reader read = new Reader();

			int count = read.AmandaCount();
			Console.WriteLine(count);
		}
	}
}
