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
			List<Sale> values = File.ReadAllLines("")
									.Skip(1)
			                        .Select(x => Sale.FromCsv(x))
									.ToList();

			_allSales = values;
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
