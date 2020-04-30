using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srez
{	class MyClass
	{
		public int myField;
		public void SomeMethod()
		{
			int value = default(int);
			Console.WriteLine(myField);
			Console.WriteLine(value);
		}
	}

	public class Fraction : IConvertible
	{
		double num;
		double denum;

		public Fraction(){}
		public Fraction(int num, int denum)
		{
			this.num = num;
			this.denum = denum;
		}

		public static int GCD(int a, int b)
		{
			while (a != 0 && b != 0)
			{
				if (a > b)
					a %= b;
				else
					b %= a;
			}

			return a == 0 ? b : a;
		}

		public void Div(int num, int denum)
		{
			num = num / GCD(num, denum);
			denum = denum / GCD(num, denum);
		}

		public TypeCode GetTypeCode()
		{
			throw new NotImplementedException();
		}

		public bool ToBoolean(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public byte ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(num / denum);
		}

		public char ToChar(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public DateTime ToDateTime(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public decimal ToDecimal(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public double ToDouble(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public short ToInt16(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public int ToInt32(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public long ToInt64(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public sbyte ToSByte(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public float ToSingle(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public string ToString(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public object ToType(Type conversionType, IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public ushort ToUInt16(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public uint ToUInt32(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public ulong ToUInt64(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
		//создание одномерного
			int[] arr = new int[1];
			int[] arr1 = { 1, 2, 3, 4 };
			var arr2 = new int[1];
			int[] arr3 = (new List<int>() { 1, 2, 3, 4 }).ToArray();
			Array a = new Array();

			//создание двумерного массива
			int[,] arr4 = new int[1, 2];
			int[][] arr5 = new int[2][2];
			List<List<int>> list = new List<List<int>>();

			int value = 12;
			switch (value)
			{
				case 1:
					Console.WriteLine("dibil?");
					break;
				case 3:
					Console.WriteLine("Not bad");
					break;
				case 2:
					Console.WriteLine("Soon");
					break;
				default:
					Console.WriteLine("default");
					break;
			}

			IEnumerable<int> someCollection = null;
			List<int> list1 = someCollection as List<int>;// первый тип приведения
			List<int> list2 = (List<int>)someCollection;// второй тип приведения
		}
	}
}
