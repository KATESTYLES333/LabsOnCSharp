using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2task
{
	public class Point
	{
		int x;
		int y;
		int z;
	}
	public interface Figure
	{
		 double Volume { get; }
		 double Square { get; }
		 double Perimetr { get; }
	}

	public class Cube : Figure
	{
		public double lenghtReb { get; set; }
		Point startPoint;

		public double Volume
		{
			get
			{
				return Math.Pow(lenghtReb, 3);
			}
		}

		public double Perimetr
		{
			get
			{
				return 12 * lenghtReb;
			}
		}

		public double Square
		{
			get
			{
				return 6 * Math.Pow(lenghtReb, 2);
			}
		}


	}


	class Program
	{
		static void Main(string[] args)
		{
			Cube c = new Cube() { lenghtReb = 3 };
			Console.WriteLine(c.Perimetr);
			Console.WriteLine(c.Square);
			Console.WriteLine(c.Volume);
	
		}
	}
}
