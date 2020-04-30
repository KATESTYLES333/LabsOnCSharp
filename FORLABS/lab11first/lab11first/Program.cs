using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11first
{

	class Program
	{
		static void Main(string[] args)
		{
			//Y y = new Y(3, 1, 2);
			//Console.WriteLine(y.Run());

			Rectangle reg = new Rectangle(4, 2);
			Console.WriteLine(reg.Square);
			Console.WriteLine(reg.Volume);

			Triangle tr = new Triangle(2, 3);
			Console.WriteLine(tr.Square);
			Console.WriteLine(tr.Volume);


			Console.ReadKey();
		}
	}
}
