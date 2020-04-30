using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var13
	{
		string surname { get; set; }
		int salary { get; set; }
		DateTime workYear { get; set; }
		DateTime bdTear { get; set; }

		Var13() { }

		~Var13() { Console.WriteLine("destruct"); }

		public Var13(string surname, int salary, DateTime workYear, DateTime bddate)
		{
			this.surname = surname;
			this.salary = salary;
			this.workYear = workYear;
			this.bdTear = bddate;
		}

		public override string ToString()
		{
			return surname.ToString() + " " + salary.ToString() + " " + bdTear.ToString();
		}

		public int CountToFifty()
		{
			DateTime t = bdTear.AddYears(50);
			//TimeSpan time = t - DateTime.Now;
			return t.Subtract(DateTime.Now).Days;
			//return time.Days;
		}

		public int YearWork() 
		{
			return workYear.Year - DateTime.Now.Year;
		}

		public int F1()
		{
			return (DateTime.Now - workYear).Days;
		}
	}
}
