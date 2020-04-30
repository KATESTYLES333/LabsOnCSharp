using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var15
	{
		int x1 { get; set; }
		int x2 { get; set; }
		int y1 { get; set; }
		int y2 { get; set; }

		Var15() { }
		~Var15() { }
		public Var15(int x1, int x2, int y1, int y2)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.y1 = y1;
			this.y2 = y2;
		}

		public override string ToString()
		{
			return x1.ToString() + " " + x2.ToString() + " " + y1.ToString() + "" + y2.ToString();
		}
		public int LengthVect()
		{
			return (int)(Math.Sqrt(Math.Pow((x1 - x2), 2) + (Math.Pow((y1 - y2), 2))));
		}

		public double Square()
		{
			return ((x2-x1) * (y2-y1))/2;
		}
	}
}
