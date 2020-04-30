using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace lab18
{
	class Program
	{
		static void Main(string[] args)
		{
			Fraction f = new Fraction(12, 3);
			Console.WriteLine(f.Div(f));
		}
	}
}
