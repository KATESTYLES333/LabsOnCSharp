using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
	class Program
	{
		public static int Min(int[] arr)
		{
			int minEl = arr[0];
			int minIndex = 0;
			for (int i = 0; i != arr.Length; ++i)
			{
				if (minEl > arr[i])
				{
					minEl = arr[i];
					minIndex = i;
				}
			}
			return minIndex;
		}

		//Составить программу нахождения минимального (максимального) элемента массива и места его расположения в массиве (номера строки и номера столбца)

		public static void Task1(int[] arr)
		{
			int ind = Min(arr);
			Console.WriteLine(arr[ind]);
			Console.WriteLine(ind);
		}

		public static void Task11(int[] arr)
		{
			int maxEl = arr[0];
			int maxIndex = 0;
			for (int i = 0; i != arr.Length; ++i)
			{
				if (maxEl < arr[i])
				{
					maxEl = arr[i];
					maxIndex = i;
				}
			}
			Console.WriteLine(maxEl);
			Console.WriteLine(maxIndex);
		}

		//Сумму элементов массива, расположенных до минимального элемента
		public static void Task2(int[] arr)
		{
			int sum = 0;
			for (int i = 0; i < Min(arr); i++)
			{
				sum += arr[i];
			}
			Console.WriteLine(sum);
		}

		static void Main(string[] args)
		{
			int[] array = new int[] { 1, 2, 3, 2, -7, -1, 4, 5 };
			//Task1(array);
			//Task11(array);
			Task2(array);
		}
	}
}
