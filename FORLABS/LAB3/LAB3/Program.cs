using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
	class Program
	{
		public static double f1(double x)
		{
			return (1.0 + Math.Pow(x, 2) / 2) * Math.Atan(x) - (x / 2);
		}

		public static void Task1()
		{
			double xn = 0.1;
			double xk = 1;
			double h = (xk - xn) / 10;
			for (; xn < xk; xn += h)
			{
				Console.WriteLine(f1(xn));
			}
		}

		public static int Task2(int[] array)
		{
			int count = 0;
			for (int i = 0; i != array.Length; ++i)
			{
				if (array[i] < 0)
				{
					++count;
				}
			}
			return count;
		}

		static void Main(string[] args)
		{
			//Task1();
			int[] arr = new int[] { -1, -2, -5, -5, 6, 8, 10 };
			Console.WriteLine(Task2(arr));
		}
	}
}
