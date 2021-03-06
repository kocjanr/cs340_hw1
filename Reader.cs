﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Homework_1
{
	public class Reader
	{
		private List<Sale> _allSales = new List<Sale>();

		public Reader(string filePath) {
			this.ReadInFile(filePath);
		}

		//This function was written with help from lots of StackOverflow posts on C# file IO
		public void ReadInFile(string path) {
			List<Sale> values = File.ReadAllLines(path)
									.Skip(1)
			                        .Select(x => Sale.FromCsv(x))
									.ToList();

			_allSales = values;

			this.DisplaySales();
		}

		public double AvaragePurchaseAmount() {
			double averageAmount = 0;
			List<Sale> AllSales = _allSales;
			List<string> priceStrings = AllSales.Select(x => x.Price).ToList();
			List<int> priceInts = new List<int>();

			for (int i = 0; i < priceStrings.Count(); i++){
				string tempPriceString = priceStrings[i];
				int temp = 0;

				Int32.TryParse(tempPriceString, out temp);
				priceInts.Add(temp);
			}

			averageAmount = priceInts.Average();

			return averageAmount;
		}

		public int AmandaCount() {
			IEnumerable<Sale> Person = _allSales.Where(x => x.Name == "Amanda" || x.Name == "amanda");
			int count = Person.Count();

			return count;
		}

		public void UpdateCountryName(string oldCountryName, string newCountryName) {
			int numberOfUpdates = 0;
			List<Sale> oldName = _allSales.Where(x => x.Country == oldCountryName).ToList();
			numberOfUpdates = oldName.Count();

			for (int i = 0; i < numberOfUpdates; i++) {
				oldName[i].Country = newCountryName;
			}

			Console.WriteLine("{0} records updated.", numberOfUpdates);
			CreateCSVFile(oldName);
		}

		private void CreateCSVFile(IEnumerable<Sale> sales) { 
		
		}

		private void DisplaySales() {
			foreach (Sale sale in _allSales) {
				
				Console.WriteLine(sale.TransactionDate);
				Console.Write(sale.Product);
				Console.WriteLine("");
				Console.WriteLine(sale.Price);
				Console.WriteLine(sale.PaymentType);
				Console.WriteLine(sale.City);
				Console.WriteLine(sale.State);
				Console.WriteLine(sale.Country);
				Console.WriteLine(sale.Name);
				Console.WriteLine(sale.AccountCreated);
				Console.WriteLine(sale.LastLogin);
				Console.WriteLine(sale.Latitude);
				Console.WriteLine(sale.Longitude);
				Console.WriteLine("");

			}
		}

	}
}
