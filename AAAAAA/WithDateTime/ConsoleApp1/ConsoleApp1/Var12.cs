using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Var12
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public DateTime Year { get; set; }

		Var12() { }
		public Var12(string name, string author, DateTime year)
		{
			this.Name = name;
			this.Author = author;
			this.Year = year;
		}

		~Var12() { Console.WriteLine("Destructor"); }

		public int BookYear()
		{
			return DateTime.Now.Year - Year.Year;
			
		}

		public int GetDays()
		{
			return (DateTime.Now - Year).Days; 
		}

		public override string ToString()
		{
			return Name + " " + Author + " " + Year.ToString();
		}

	}
}
