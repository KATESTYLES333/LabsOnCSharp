using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
	class lab13first
	{
		//Задан треугольник со сторонами a,b,c.Радиус описанной окружности равен R.
		//Найти его площадь.

		static double RadiusOfCircle(double a, double b, double c, double R)
		{
			if ((a <= 0 || b <= 0 || c <= 0 || R <= 0) || ((a + b - c) * (a - b + c) * (a + c - b)) == 0)
			{
				throw new Exception("You dibil");
			}
			return (a * b * c) / (4 * R);
		}

		//Задана целочисленная матрица размера nxn.Найти сумму элементов того столбца,
		//в котором находится наименьший элемент матрицы.

		public static int Min(int[,] arr)
		{
			int minEl = arr[0, 0];
			int minIndex = 0;

			for (int i = 0; i != arr.GetLength(0); ++i)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (minEl > arr[i, j])
					{
						minEl = arr[i, j];
						minIndex = j;
					}
				}
			}

			return minIndex;
		}

		public static int AccumulateColumn(int[,] arr, int colIndex)
		{
			int countRows = arr.GetLength(0);
			int sum = 0;
			for (int i = 0; i < countRows; i++)
			{
				sum += arr[i, colIndex];
			}
			return sum;
		}

		public void Result(int[,] array)
		{
			int minEl = Min(array);
			int sum = AccumulateColumn(array, minEl);
			Console.WriteLine("Min element in column: " + minEl);
			Console.WriteLine("Sum of column, where min element is: " + sum);
		}
	}
}
