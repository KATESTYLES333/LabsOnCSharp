using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LastSrez
{
	class Goods
	{
		public string Name { get; set; }
		private double cost;
		public double Cost
		{
			get
			{
				return cost;
			}
			set
			{
				if (value > 0)
				{
					cost = value;
				}
				else
				{
					throw new Exception("Dibil");
				}
			}

		}
		public string WorkName { get; set; }

		public Goods() { }

		~Goods() { Console.WriteLine("Destructor"); }

		public Goods(string name, double cost, string workName)
		{
			this.Name = name;
			this.Cost = cost;
			this.WorkName = workName;
		}

		public double GetPrice(int course)
		{
			return cost / course;
		}

		public double AddPrice(int course)
		{
			double res = cost / course;
			Regex reg = new Regex(@"[Tt]oyota");
			if(reg.IsMatch(Name))
			{ 
				++res;
			}
			return res;
		}

	}
}
