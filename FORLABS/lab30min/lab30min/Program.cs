using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab30min
{
	class Program
	{
		public static int FindMin(int[] arr)
		{
			int min = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > 0 && arr[i] < min)
				{
					min = arr[i];
				}
			}
			return min;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Write size of array:");
			int n = Convert.ToInt32(Console.ReadLine());
			Random random = new Random();
			int[] array = new int[n];

			//заполнение случайными значениями от 100 до 300
			for (int i = 0; i < n; ++i)
			{
				array[i] = random.Next(100, 300);
			}

			Console.WriteLine("Random Elements:");
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}

			//потому что четных номеров половина
			List<int> res = new List<int>();
			//+=2 так как нужны четные
			for (int i = 0; i < n; i += 2)
			{
				res.Add(array[i]);
			}

			Console.WriteLine("In result array:");
			foreach (var it in res)
			{
				Console.WriteLine(it);
			}

			Console.WriteLine("Min element is:" + FindMin(res.ToArray()));
			Console.ReadLine();

		}
	}
}
