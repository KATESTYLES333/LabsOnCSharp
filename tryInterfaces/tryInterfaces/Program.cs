using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryInterfaces
{
	public interface IBinaryOperation
	{
		int Call(int a, int b);
	}

	public interface IUnaryPredicate
	{
		int Call(int a);
	}

	public class Mul : IBinaryOperation
	{
		public int Call(int a, int b)
		{
			return a * b;
		}

	}

	public class IsEven : IUnaryPredicate
	{
		public bool Call(int a)
		{
			return a % 2 == 0;
		}

		int IUnaryPredicate.Call(int a)
		{
			throw new NotImplementedException();
		}
	}

	public class test : IBinaryOperation
	{
		public static int AccumulateWI(int[] arr, int result, IBinaryOperation bp)
		{
			for (int i = 0; i != arr.Length; ++i)
			{
				result = bp.Call(result, arr[i]);
			}
			return result;
		}

		public static int FindIf(int[] arr, IBinaryOperation bo)
		{
			for (int i = 0; i != arr.Length; ++i)
			{
				if (bo.Call(arr[i]))
				{
					return i;
				}
			}
			return -1;
		}

		public static int[] Map(int[] arr, IUnaryPredicate up)
		{
			int[] newArr = new int[arr.Length];
			foreach (int i in arr)
			{
				newArr[i] = up.Call(arr[i]);
			}
			return newArr;
		}


		public delegate int BinaryOperation(int a, int b);

		public static int Accumulate(int[] arr, int result, BinaryOperation op)
		{
			for (int i = 0; i != arr.Length; ++i)
			{
				result = op(result, arr[i]);
			}
			return result;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3 };
			//Console.WriteLine(test.FindIf(arr, );

		}
	}
}
