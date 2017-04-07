using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Homework_1
{
	public class Reader
	{
		private List<Sale> _allSales = new List<Sale>();

		public Reader() {
			this.ReadInFile();
		}

		public void ReadInFile() {
			Sale temp = new Sale();

			using (var filePath = File.OpenRead(@"/Users/ryankojan/Desktop/Spring2017/cs340/cs162hw01salesData01.csv"))
			using (var reader = new StreamReader(filePath))
			{
				List<DateTime> TransactionDates = new List<DateTime>();
				List<string> Products = new List<string>();
				List<int> Prices = new List<int>();
				List<string> Cities = new List<string>();
				List<string> States = new List<string>();
				List<string> Countries = new List<string>();
				List<string> Names = new List<string>();
				List<DateTime> AccountCreated = new List<DateTime>();
				List<DateTime> LastLogin = new List<DateTime>();
				List<float> Latitudes = new List<float>();
				List<float> Longitudes = new List<float>();
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(',');

					TransactionDates.Add(Convert.ToDateTime(values[0]));
					Products.Add(values[1]);
					Prices.Add(Convert.ToInt32(values[2]));
					Cities.Add(values[3]);
					States.Add(values[4]);
					Countries.Add(values[5]);
					Names.Add(values[6]);
					AccountCreated.Add(Convert.ToDateTime(values[7]));
					LastLogin.Add(Convert.ToDateTime(values[8]));
					Latitudes.Add(Convert.ToSingle(values[9]));
					Longitudes.Add(Convert.ToSingle(values[10]));

					Console.WriteLine(values[1]);
				}
			}

		}

		public int AvaragePurchaseAmount() {
			int temp = 0;

			return temp;
		}

		private void AddToList(Sale sale) {
			_allSales.Add(sale);
		}

		private void DisplaySales() {

			foreach (Sale sale in _allSales) {

				Console.WriteLine(sale);
			}
		}
	}
}
