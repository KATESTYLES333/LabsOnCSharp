using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Program
	{
		static double Task1(double x)
		{
			if (x <= -1)
			{
				return 1.0 + Math.Abs(x) / (Math.Pow(1.0 + x + Math.Pow(x, 2), 1.0 / 3.0));
			}
			else if (x > -1 & x < 0)
			{
				return (2.0 * Math.Log10(1 + Math.Pow(x, 2))) + 1.0 + (Math.Pow(Math.Cos(x), 4) / (3.0 * (2.0 + x)));
			}
			else
			{
				return Math.Pow(1 + x, 3.0 / 5.0);
			}
		}

		static bool IsSimple(int num)
		{
			if (num == 0 || num == 1)
			{
				return false;
			}
			for (int i = 2; i != num; ++i)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			//Console.WriteLine(Task1(-3.5));
			Console.WriteLine(IsSimple(11));
		}
	}
}
