using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Var13
	{
		public string Surname { get; set; }
		public int Salary{ get; set; }
		public DateTime Year { get; set; }

		Var13(){ }
		public Var13(string surname, int salary, DateTime year)
		{
			this.Surname = surname;
			this.Salary = salary;
			this.Year = year;
		}

		~Var13() { }

		public int Stazh()
		{
			return DateTime.Now.Year - Year.Year;
		}
		
		public int StazhDays()
		{
			return (DateTime.Now - Year).Days;
		}

		public override string ToString()
		{
			return Surname + " " + Salary.ToString() + " " + Year.ToString();
		}
	}
}
