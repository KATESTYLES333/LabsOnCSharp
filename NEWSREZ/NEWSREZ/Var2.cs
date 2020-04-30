using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var2
	{
		int day { get; set; }
		int month { get; set; }
		int year { get; set; }

		Var2() { }

		~Var2() { Console.WriteLine("Destructor"); }

		public Var2(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public void AddYear()
		{
			year += 1;
		}

		public void SubDate()
		{
			day -= 2;
		}
		public override string ToString()
		{
			return day.ToString() + " " + month.ToString() + " " + year.ToString();
		}
	}
}
