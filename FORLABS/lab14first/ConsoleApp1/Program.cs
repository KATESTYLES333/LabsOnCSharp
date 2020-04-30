using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class WorkwDeleg
	{
		delegate double MyDelegate(double x);
		void LimitFunct(MyDelegate at, MyDelegate at2)
		{
			for (double i = 0; i <= 1; i += 7)
			{
				Console.WriteLine("Athan is: " + at(i) + "  "+ "Athan2 is: " + at2(i));

			}
		}

		void WorkwMathem()
		{
			LimitFunct(new MyDelegate((double i) =>  Math.Atan(i) ), delegate (double i) { return Math.Cos(i); });
		}

		static void Main(string[] args)
		{
			new WorkwDeleg().WorkwMathem();
			Console.ReadKey(true);
		}
	}
}
