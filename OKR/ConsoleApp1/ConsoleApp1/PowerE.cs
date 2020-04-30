using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class PowerE
	{
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		private double d;
		public double D
		{
			get
			{
				return d;
			}
			set
			{
				if (value < 0)
				{
					throw new Exception();
				}
				d = value;
			}
		}



		public PowerE() { }

		public PowerE(double a, double b, double c)
		{
			this.A = a;
			this.B = b;
			this.C = c;
			this.D = Math.Pow(B, 2) - 4 * A * C;
		}

		public void GetResult()
		{
			double x1 = (-B + Math.Sqrt(D)) / (2 * A);
			double x2 = (-B - Math.Sqrt(D)) / (2 * A);
			Console.WriteLine("First sqrt: " + x1);
			Console.WriteLine("Second sqrt: " + x2);
		}

		public override string ToString()
		{
			return A.ToString() + " " + B.ToString() + " " + C.ToString();
		}
	}
}
