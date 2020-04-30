using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Var14
	{
		public string Surname { get; set; }
		public int Salary { get; set; }
		public DateTime BdYear { get; set; }


		Var14() { }

		public Var14 (string surname, int salary, DateTime bdday)
		{
			this.Surname = surname;
			this.Salary = salary;
			this.BdYear = bdday;
		}

		~Var14(){ }

		public int Age()
		{
			return DateTime.Now.Year - BdYear.Year;
		}

		public int DayToFifty()
		{
			DateTime fiftyBd = BdYear.AddYears(50);
			TimeSpan span = fiftyBd - DateTime.Now;
			return span.Days;
		}

		public override string ToString()
		{
			return Surname + " " + Salary.ToString() + " " + BdYear.ToString();
		}
	}

}
