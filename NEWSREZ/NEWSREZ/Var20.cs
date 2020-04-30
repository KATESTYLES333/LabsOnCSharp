
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var20
	{
		int a { get; set; }
		int b { get; set; }
		int c { get; set; }

		Var20() { }
		public Var20(int a, int b, int c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}

		~Var20() { Console.WriteLine("destr"); }
		public override string ToString()
		{
			return a.ToString() + " " + b.ToString() + " " + c.ToString();
		}

		public int SquareUp()
		{
			return 2 * ((a * b) + (b * c) + (a * c));
		}

		public int SumParall()
		{
			return 4 * (a + b + c);
		}
	}
}
