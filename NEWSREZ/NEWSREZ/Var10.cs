using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var10
	{
		int a1 { get; set; }
		int a2 { get; set; }
		int b1 { get; set; }
		int b2 { get; set; }

		Var10() { }
		~Var10() { }
		public Var10(int a1, int a2, int b1, int b2)
		{
			this.a1 = a1;
			this.a2 = a2;
			this.b1 = b1;
			this.b2 = b2;
		}

		public override string ToString()
		{
			return a1.ToString() + " " + a2.ToString() + "" + b1.ToString() + " " + b2.ToString();
		}

		public void Multiply()
		{
			Console.WriteLine(((a1 * a2) - (b1 * b2)) + ((a1 * b2) + (b1 * a2)));
		}
	}
}
