using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Point
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Point() { }

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
	}

	class ColorPoint : Point
	{
		public byte R { get; set; }
		public byte G { get; set; }
		public byte B { get; set; }

		public ColorPoint() { }

		public ColorPoint(byte r, byte g, byte b)
		{
			this.R = r;
			this.G = g;
			this.B = b;
		}
		
		public byte GetR()
		{
			return R;
		}
	}
}
