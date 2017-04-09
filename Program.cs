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

			int count = read.AmandaCount();
			Console.WriteLine(count);
			Console.WriteLine("Averages ");
			read.AvaragePurchaseAmount();

			Reader readB = new Reader(FileB);

		}
	}
}
