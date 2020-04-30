using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
	class Program
	{
		//public static bool isS(int num)
		//{
		//	if (num == 0 || num == 1)
		//	{
		//		return false;
		//	}
		//	return true;
		//}
		public static bool isSimple(int num)
		{
			if (num == 0 || num == 1)
			{
				return false;
			}
			for (int i = 2; i != num/2; ++i)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		static int MaxEl(int[,] arr)
		{
			int maxI = 0;
			int maxJ = 0;
			int max = arr[0, 0];
			for (int i = 0; i != arr.GetLength(0); ++i)
			{
				for (int j = 0; j != arr.GetLength(1); ++j)
				{
					if (max < arr[i, j])
					{
						max = arr[i, j];
						maxI = i;
						maxJ = j;
					}
				}
			}
			Console.WriteLine("Row:{0}", maxI);
			Console.WriteLine("Column:{0}", maxJ);
			Console.WriteLine("Max element:{0}", max);
			return max;
		}

		public delegate bool FindEl(int a, int b);
		public static int MinEl(int[] arr, FindEl el)
		{
			int min = arr[0];
			for (int i = 0; i != arr.Length; ++i)
			{
				for (int j = 0; j != arr.Length; ++j)
				{
					if (min > arr[j])
					{
						min = arr[j];
					}
				}
			}
			return min;
		}
			   		 	  
		static void Main(string[] args)
		{
			int[,] arr = {
			{1,2,3,4},
			{3,5,8,5},
			{3,5,10,4}
			};
			//Console.WriteLine(isSimple(12));
			Console.WriteLine(MaxEl(arr));
		}

		//public override string ToString()
		//{
		//	string res = "a1: " + a1.ToString() +
		//	"\n a2: " + a2.ToString();

		//	return res;
		//}
	}
}
