using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var26
	{
		public string Name { get; set; }
		public int Pages { get; set; }
		private double cost;
		public double Cost
		{
			get
			{
				return cost;
			}

			set
			{
				if (value <= 0)
				{
					throw new Exception("Kate blyat' pizdec");
				}
				cost = value;
			}

		}

		public Var26() { }

		public Var26(string name, int pages, double cost)
		{
			this.Name = name;
			this.Pages = pages;
			this.Cost = cost;
		}

		~Var26() { Console.WriteLine("Destructor"); }

		//public int AddPages()
		//{
		//	return this.Pages + 10;
		//}

		public double AverageCost()
		{
			return Cost / Pages;
		}

		public double AddCost()
		{
			Regex reg = new Regex(@"^Программирование");
			if(reg.IsMatch(Name))
			{
				Cost *= 2;
			}
			return Cost;
		}

		//public double GetPrice()
		//{
		//	if (Pages > 100)
		//	{
		//		Cost /= 2;
		//	}
		//	return Cost;
		//}

		public override string ToString()
		{
			return Name.ToString() + " " + Pages.ToString() + " " + Cost.ToString();
		}
	}
}
