using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practis
{
	//class Program
	//{
	//	public static int Accumulate(int[] arr, int k)
	//	{
	//		int temp = 0;
	//		for (int i = 0; i != k; ++i)
	//		{
	//			temp += arr[i];
	//		}
	//		return temp;
	//	}

	//	public static int[] newArr(int[] arr, int k)
	//	{
	//		int[] newArr = new int[arr.Length];
	//		for (int i = 0; i != arr.Length; ++i)
	//		{
	//			newArr[i] = Accumulate(arr, k);
	//		}
	//		return newArr;
	//	}
	//	public static int v7(int[,] arr)
	//	{
	//		int res = 0;
	//		int start = 0;
	//		int end = arr.GetLength(0);
	//		for (int i = 0; i < arr.GetLength(0); i++)
	//		{
	//			for (int j = start; j < end; j++)
	//			{
	//				res += arr[i, j];
	//			}
	//			if (i <= (arr.GetLength(1) - 1) / 2)
	//			{
	//				start++;
	//				end--;
	//			}
	//			else
	//			{
	//				start--;
	//				end++;
	//			}
	//		}
	//		return res;
	//	}

	//	public static int Qwerty(int[,] arr)
	//	{
	//		int res = 0;
	//		int start = 0;
	//		int end = arr.GetLength(0);
	//		for (int i = 0; i < arr.GetLength(0); i++)
	//		{
	//			for (int j = start; j < end; j++)
	//			{
	//				res += arr[i, j];
	//			}
	//			if (i <= (arr.GetLength(1) - 1) / 2)
	//			{
	//				start++;
	//				end--;
	//			}
	//			else
	//			{
	//				start--;
	//				end++;
	//			}
	//		}
	//		return res;
	//	}
	//	public static string GetReverse(string s)
	//	{
	//		string t1 = "";
	//		string t2 = "";
	//		for (int i = 0; i < s.Length; i++)
	//		{
	//			if (i % 2 == 0)
	//			{
	//				t1 += s[i];
	//			}
	//			else
	//			{
	//				t2 += s[i];
	//			}
	//		}
	//		return t1 + t2;
	//	}

	//	public static void Task1()
	//	{
	//		Console.WriteLine("Task 1");
	//		string text = "3-1 1.2 * 33 3 + 2 3 + 2";
	//		Regex reg = new Regex(@"-?\d\.?\d?\s?[-+\/*]\s?-?\d\.?\d?");
	//		MatchCollection matches = reg.Matches(text);
	//		foreach (Match m in matches)
	//		{
	//			Console.WriteLine(m.Value);
	//		}
	//	}
	//	public static string ReplaceMethod(Match m)
	//	{
	//		return " ";
	//	}
	//	public static void Task2()
	//	{
	//		Console.WriteLine("Task 2");
	//		string words = "cat dog laba cat cat fefeefe";
	//		string pattern = @"laba\s";
	//		MatchEvaluator evaluator = new MatchEvaluator(ReplaceMethod);
	//		Console.WriteLine("ORIGINAL STRING ---> " + words);
	//		Console.WriteLine(Regex.Replace(words, pattern, evaluator, RegexOptions.IgnorePatternWhitespace, TimeSpan.FromSeconds(.25)));
	//	}
	//	Struct class Shop
	//	{
	//		public string NameShop;
	//		public Shop(string NameShop)
	//		{
	//			this.NameShop = NameShop;
	//		}
	//		public string nameShop { get { return NameShop; } }
	//	}

	//	public class Stelaz : Shop
	//	{
	//		int row;
	//		int pow;
	//		public int Row { get { return row; } }
	//		public int Pow { get { return pow; } }
	//		public Stelaz(int row, int pow, string NameShop) : base(NameShop)
	//		{
	//			this.row = row;
	//			this.pow = pow;
	//		}
	//	}
	//	public class Polka : Stelaz
	//	{
	//		int kg;
	//		int Wmestimost;
	//		public int wmestimost { get { return Wmestimost; } }
	//		public Polka(string NameShop, int row, int pow, int kg, int Wmestimost) : base(row, pow, NameShop)
	//		{
	//			this.kg = kg;
	//			this.Wmestimost = Wmestimost;
	//		}
	//		public int Kg { get { return kg; } }
	//	}

	//	static void ShowInfo(Polka[] arr)
	//	{
	//		for (int i = 0; i < arr.Length; i++)
	//		{
	//			Console.WriteLine(arr[i].NameShop + " " + "Столбец " + arr[i].Row + " " + "Строка " + arr[i].Pow + " " + "Кило " + arr[i].Kg + " " + "Вместимость " + arr[i].wmestimost);
	//		}
	//	}

	//	public static void CoolWmestimosti(Polka[] arr)
	//	{
	//		for (int i = 0; i < arr.Length; i++)
	//		{
	//			int temp = arr[i].Row * arr[i].Pow;
	//			int Rezult = temp * arr[i].wmestimost;
	//			Console.WriteLine("Количество " + Rezult);
	//		}
	//	}
	//}

	//class Program
	//{
	//	[Serializable]
	//	abstract class Worker : Salary, Sxof, SalaryDayMaFaq
	//	{
	//		public delegate void SharikDel(string mes);
	//		public event SharikDel SharikDidMount = (message) => { Console.WriteLine(message); };
	//		protected string Name;
	//		protected string LastName;
	//		protected int Salary;
	//		protected int Chas;
	//		public string name { get { return Name; } }
	//		public string lastName { get { return LastName; } }
	//		public int salary
	//		{
	//			set
	//			{
	//				if (Salary > 0)
	//				{
	//					Salary = value;
	//				}
	//				else
	//				{
	//					Salary = 0;
	//				}
	//			}
	//			get
	//			{
	//				return Salary;
	//			}
	//		}
	//		public int chas
	//		{
	//			set
	//			{
	//				if (Chas > 0)
	//				{
	//					Chas = value;
	//				}
	//				else
	//					Chas = 0;
	//			}
	//			get
	//			{
	//				return Chas;
	//			}
	//		}
	//		public void ShowInfo()
	//		{
	//			Console.WriteLine("Имя " + name + "  " + "Фамилия " + lastName + " " + "Сколько Работает в час " + " " + chas + " " + "ЗП в Час" + Salary);
	//		}

	//		public abstract double SalaryPerHoure();
	//		public abstract double SalaryPerMouthe();
	//		public abstract double SalaryYear();
	//	}

	//	Struct class Shop
	//	{
	//		public string NameShop;
	//		public Shop(string NameShop)
	//		{
	//			this.NameShop = NameShop;
	//		}
	//		public string nameShop { get { return NameShop; } }
	//	}
	//	public class Stelaz : Shop
	//	{
	//		int row;
	//		int pow;

	//		public int Row { get { return row; } }
	//		public int Pow { get { return pow; } }
	//		public Stelaz(int row, int pow, string NameShop) : base(NameShop)
	//		{
	//			this.row = row;
	//			this.pow = pow;
	//		}
	//	}
	//	public class Polka : Stelaz
	//	{
	//		int kg;
	//		int Wmestimost;
	//		public int wmestimost { get { return Wmestimost; } }
	//		public Polka(string NameShop, int row, int pow, int kg, int Wmestimost) : base(row, pow, NameShop)
	//		{
	//			this.kg = kg;
	//			this.Wmestimost = Wmestimost;
	//		}
	//		public int Kg { get { return kg; } }

	//	}
	//	static void ShowInfo(Polka[] arr)
	//	{
	//		for (int i = 0; i < arr.Length; i++)
	//		{
	//			Console.WriteLine(arr[i].NameShop + " " + "Столбец " + arr[i].Row + " " + "Строка " + arr[i].Pow + " " + "Кило " + arr[i].Kg + " " + "Вместимость " + arr[i].wmestimost);
	//		}
	//	}

	//}
	//public static void CoolWmestimosti(Polka[] arr)
	//{
	//	for (int i = 0; i < arr.Length; i++)
	//	{
	//		int temp = arr[i].Row * arr[i].Pow;
	//		int Rezult = temp * arr[i].wmestimost;
	//		Console.WriteLine("Количество " + Rezult);

	//	}
	//}
	internal interface SalaryDayMaFaq
	{
	}

	internal interface Sxof
	{
	}

	public class Salary
	{
	}

	public class Worker : Salary, Sxof, SalaryDayMaFaq
	{
		public delegate void MyBallDel(string mes);
		//public event Del MyBallDidMount = (message) => { Console.WriteLine(message); };
		protected string Name;
		protected string LastName;
		protected int Salary;
		protected int Hour;

		public string name
		{
			get
			{
				return Name;
			}
		}
		public string lastName
		{
			get
			{
				return LastName;
			}
		}
		public int salary
		{
			set
			{
				if (Salary > 0)
				{
					Salary = value;
				}
				else
					Salary = 0;
			}
			get
			{
				return Salary;
			}
		}
		public int chas
		{
			set
			{
				if (Hour > 0)
				{
					Hour = value;
				}
				else
					Hour = 0;
			}
			get
			{
				return Hour;
			}
		}


		public void SalaryPerHoure() { }

		public void SalaryPerMouthe() { }
	}

}


class Program
{
	static void Main(string[] args)
	{
		int[,] arr = new int[,] { { 1, 2, 3, 4 }, { 2, 5, 6, 8 } };
		//Console.WriteLine(Accumulate(arr, 6));
		//Console.WriteLine(Qwerty(arr));
		//Console.WriteLine(GetReverse("ABCDEFGHI"));
		Console.WriteLine("Евген Шумович 12 2");
		Console.WriteLine("Темиа Маловчи 24 8");
		//Task2();
		Console.ReadKey(true);
	}
}

