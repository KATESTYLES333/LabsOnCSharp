using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11first
{
	class X
	{
		public int X1 { get; set; }
		public int X2 { get; set; }

		public X() { }

		public X(int x1, int x2)
		{
			this.X1 = x1;
			this.X2 = x2;
		}
	}

	class Y : X
	{
		public int Y1 { get; set; }
		public Y() { }

		public Y(int y, int x1, int x2) : base(x1, x2)
		{
			this.Y1 = y;
		}

		public double Run()
		{
			return (X1 * Y1) + X2;
		}

	}
}
