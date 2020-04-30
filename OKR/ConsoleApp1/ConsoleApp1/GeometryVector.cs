using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class GeometryVector
	{
		private double x;
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				if (value == y)
				{
					throw new Exception();
				}
				x = value;
			}
		}
		private double y;
		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				if (value == x)
				{
					throw new Exception();
				}
				y = value;
			}
		}

		public GeometryVector() { }

		public GeometryVector(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		public GeometryVector SumofVectors(GeometryVector vector)
		{
			return new GeometryVector(this.X + vector.X, this.Y + vector.Y);
		}

		public double MulVectors(GeometryVector vector)
		{
			return (this.X * vector.X) + (this.Y * vector.Y);
		}

		public override string ToString()
		{
			return x.ToString() + " " + y.ToString();
		}
	}
}
