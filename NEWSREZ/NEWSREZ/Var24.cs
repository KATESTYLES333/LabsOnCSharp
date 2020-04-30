using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var24
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public string NameFrom { get; set; }

		Var24() { }
		~Var24() { }
		public Var24(string name, double price, string nameFrom)
		{
			this.Name = name;
			this.Price = price;
			this.NameFrom = nameFrom;
		}

		public double DollarPrice(double rates)
		{
			return Price * rates;
		}

	}
}
