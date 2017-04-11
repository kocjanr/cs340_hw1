// Homework 1 
// CS340
// Ryan Kocjan
//

using System;

namespace Homework_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string FileA = "/Users/ryankojan/Desktop/Spring2017/cs340/cs162hw01salesData01.csv";
			string FileB = "/Users/ryankojan/Desktop/Spring2017/cs340/cs162hw01salesData02.csv";

			Reader read = new Reader(FileA);

			int AmandaCount = read.AmandaCount();
			Console.WriteLine("There are {0} records for Amanda.", AmandaCount);
			int AveragePrice = Convert.ToInt32(read.AvaragePurchaseAmount());
			Console.WriteLine("Average price amount: ${0}.", AveragePrice);
			read.UpdateCountryName("United States", "USA");

			//This file doesn't read in properly since it has differnt columns than the first file
			Reader readB = new Reader(FileB);

		}
	}
}
