using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var7
	{
		public int x1 { get; set; }
		public int y1 { get; set; }
		public int x2 { get; set; }
		public int y2 { get; set; }
		~Var7() { }
		public Var7() { }
		public Var7(int x1, int y1, int x2, int y2)
		{
			this.x1 = x1;
			this.y1 = y1;
			this.x2 = x2;
			this.y2 = y2;
		}

		public override string ToString()
		{
			return x1.ToString() + " " + x2.ToString() + " " + y1.ToString() + " " + y2.ToString()  ;
		}
		public int F1()
		{
			return (x2 - x1) * (y2 - y1);
		}
		public bool F2()
		{
			return (x2 - x1) == (y2 - y1);
		}
	}
}
