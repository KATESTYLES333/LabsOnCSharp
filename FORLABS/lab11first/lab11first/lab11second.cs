using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11first
{
	//public interface IOperations
	//{
	//	double Ssquare(int a, int b, int c, int h);
	//	double Periment(int a, int b, int c);
	//}
	abstract class Figure
	{
		public int A { get; set; }
		public int B { get; set; }
		public int H { get; set; }

		public abstract double Square { get; }

		public abstract double Volume { get; }

		//	public double Periment(int a, int b, int c)
		//	{
		//		return 0;
		//	}

		//	public double Ssquare(int a, int b, int c, int h)
		//	{
		//		return 0;
		//	}
		//}

		class Rectangle : Figure
		{
			public override double Square
			{
				get
				{
					return A * B;
				}
			}

			public override double Volume
			{
				get
				{
					return 0;
				}
			}

			//public double Periment(int a, int b, int c)
			//{
			//	return a + b;
			//}

			//public double Ssquare(int a, int b, int c, int h)
			//{
			//	return a * b;
			//}
		}

		class Triangle : Figure
		{
			public Triangle(int a, int h)
			{
				this.A = a;
				this.H = h;
			}

			public override double Square
			{
				get
				{
					return ((1.0 / 2.0) * A) * H;
				}
			}
			public override double Volume
			{
				get
				{
					return 0;
				}
			}
		}
	}
}
