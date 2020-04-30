using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var1
	{
		int day { get; set; }
		int month { get; set; }
		int year { get; set; }

		public Var1() { }
		//static Date( ){ }
		public Var1(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}
		~Var1()
		{
			Console.WriteLine("Destructor");
		}

		public bool IsLeapYear1()
		{
			if (year % 4 == 0)
			{
				return true;
			}
			return false;
		}

		public void AddDay()
		{
			if (day + 5 >= 31)
			{
				day += 5 - 31;
			}
			day += 5;
		}
		

		public override string ToString()
		{
			return day.ToString() + " " + month.ToString() + " " + year.ToString();
		}
	}
}
