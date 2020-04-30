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
			//Var6 v6 = new Var6(12, 40, 30);
			//Console.WriteLine(v6.ToPolunochi());
			//v6.AddHours();
			//Console.WriteLine(v6);

			Var1 v1 = new Var1(01, 01, 2000);
			//Console.WriteLine(v1.AddDate());
			//Console.WriteLine(v1.IsLeap());
			//Console.WriteLine(v1.AddYear());
			Console.WriteLine(v1.SubDate());
			//Console.WriteLine(v1.F1());
			//Console.WriteLine(v1.F2());
			Console.WriteLine(v1);
		}
	}
}
