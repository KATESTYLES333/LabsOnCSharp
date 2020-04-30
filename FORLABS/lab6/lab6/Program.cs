using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
	class Program
	{
		//Считайте текущее время с точностью до секунд.Вычислите количество секунд, оставшихся до конца суток.
		public static void Task1()
		{
			Console.WriteLine(DateTime.Now);
		}

		public static void LastSeconds()
		{
			DateTime date = new DateTime(2019, 11, 27);
			Console.WriteLine(date.Subtract(DateTime.Now).TotalSeconds);
		}

		//Task2 Задан размер вклада в банке, процентная ставка и количество лет, на которое был произведен вклад. 
		//Посчитать итоговую сумму и вывести ее в денежном формате.

		public static double TotalSum(double So, double p, double n)
		{
			double res =  So * Math.Pow((1 + (p / 100)), n);
			return res;
		}

		static void Main(string[] args)
		{
			//Task1();
			Console.WriteLine(TotalSum(12, 10, 2) + " rub");
			//LastSeconds();
		}
	}
}
