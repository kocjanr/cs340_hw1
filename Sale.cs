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
	}
}
