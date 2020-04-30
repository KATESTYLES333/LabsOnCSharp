using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
	class Program
	{
		public delegate double MyDelegate(double x); 

		static double func(MyDelegate deleg, double x)
		{
			return deleg(x);
		}

		public void SolutofFunction(MyDelegate d)
		{
			for (int x = 0; x <= 1; x += 7)
			{
				Console.WriteLine(x, func(Math.Atan, x), func(Math.Atan2, x));
			}
		}


		static void Main(string[] args)
		{
			//string s = "123sdfsf1er";
			//int sum = 0;
			//foreach (char item in s)
			//{
			//	if (Char.IsDigit(item))
			//	{
			//		++sum;
			//	}
			//}
			//Console.WriteLine(sum);
		}
	}
}
