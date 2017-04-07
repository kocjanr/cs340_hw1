using System;
namespace Homework_1
{
	public class Sale
	{
		public DateTime TransactionDate { get; set;}
		public string Product { get; set; }
		public int Price { get; set;}
		public string PaymentType { get; set;}
		public string City { get; set;}
		public string State { get; set;}
		public string Country { get; set; }
		public string Name { get; set; }
		public DateTime AccountCreated { get; set; }
		public DateTime LastLogin { get; set; }
		public float Latitude { get; set; }
		public float Longitude { get; set; }

		public static Sale FromCsv(String CsvLine)
		{
			string[] values = CsvLine.Split(',');
			Sale temp = new Sale();
			temp.TransactionDate = Convert.ToDateTime(values[0]);
			temp.Product = Convert.ToString(values[1]);
			temp.Price = Convert.ToInt32(values[2]);
			temp.PaymentType = Convert.ToString(values[3]);
			temp.City = Convert.ToString(values[4]);
			temp.State = Convert.ToString(values[5]);
			temp.Country = Convert.ToString(values[6]);
			temp.Name = Convert.ToString(values[7]);
			temp.AccountCreated = Convert.ToDateTime(values[8]);
			temp.LastLogin = Convert.ToDateTime(values[9]);
			temp.Latitude = Convert.ToSingle(values[10]);
			temp.Longitude = Convert.ToSingle(values[11]);                                      

			return temp;
		}
	}
}
