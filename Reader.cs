﻿using System;
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
			List<Sale> values = File.ReadAllLines("/Users/ryankojan/Desktop/Spring2017/cs340/cs162hw01salesData01.csv")
									.Skip(1)
			                        .Select(x => Sale.FromCsv(x))
									.ToList();

			_allSales = values;

			this.DisplaySales();
		}

		public int AvaragePurchaseAmount() {
			int averageAmount = 0;

			return averageAmount;
		}

		public int AmandaCount() {
			int count = 0;


			return count;
		}

		private void AddToList(Sale sale) {
			_allSales.Add(sale);
		}

		private void DisplaySales() {

			foreach (Sale sale in _allSales) {
				
				Console.WriteLine(sale.TransactionDate);
				Console.Write(sale.Product);
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

			}
		}
	}
}
