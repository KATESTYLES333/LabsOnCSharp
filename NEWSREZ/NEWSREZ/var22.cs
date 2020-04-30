using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	public class Var22
	{
		int x { get; set; }
		int y { get; set; }
		int z { get; set; }
		Var22() { }

		~Var22()
		{
			Console.WriteLine("Destructor");
		}

		public double AverGeom()
		{
			return Math.Pow(x * y * z, 1.0 / 3.0);
		}

		public int CountDigitsInSum()
		{
			int count = 0;
			int res = Convert.ToInt32(x + y + z);
			while (res != 0)
			{
				res /= 10;
				++count;
			}
			return count;
		}

		public Var22(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public override string ToString()
		{
			return x.ToString() + " " + y.ToString() + " " + z.ToString();
		}
	}
}
