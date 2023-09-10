using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
	public class Customer
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Address Address { get; set; }

		private string Wealth;

		public void SayHello()
		{
			throw new NotImplementedException();
		}

		private void CalculateNetWealth()
		{
			throw new NotImplementedException();
		}
	}
}
