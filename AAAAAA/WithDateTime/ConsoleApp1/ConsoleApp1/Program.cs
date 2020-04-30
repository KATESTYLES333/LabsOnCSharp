using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Var12 v12 = new Var12("Жопа", "Жопшный", new DateTime(2000, 12, 2));
			//Console.WriteLine(v12.BookYear());
			//Console.WriteLine(v12.GetDays());
			//Console.WriteLine(v12);

			//Var13 v13 = new Var13("Жопа", 12, new DateTime(2000, 12, 2));
			//Console.WriteLine(v13.Stazh());
			//Console.WriteLine(v13.StazhDays());
			//Console.WriteLine(v13);

			Var14 v14 = new Var14("Жопа", 12, new DateTime(2000, 12, 2));
			Console.WriteLine(v14.DayToFifty());
			Console.WriteLine(v14.Age());
			Console.WriteLine(v14);
		}
	}
}
