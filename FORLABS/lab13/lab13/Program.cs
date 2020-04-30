using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
	class A : Exception
	{ }

	class B : A
	{ }

	class C : B
	{ }

	class Program
	{
		static void Main(string[] args)
		{

			//lab13first lr = new lab13first();
			////Console.WriteLine(RadiusOfCircle(1, 2, 2, 1));
			//int[,] array = new int[3, 3] { { 9, 4, 3 }, { 3, 2, 1 }, { 0, 3, 8 } };
			//for (int i = 0; i < array.GetLength(0); i++)
			//{
			//	for (int j = 0; j < array.GetLength(1); j++)
			//	{
			//		Console.Write(array[i, j] + " ");
			//	}
			//	Console.WriteLine();
			//}
			////Console.WriteLine(Min(array));
			//lr.Result(array);
			//Console.ReadLine();

			List<Person> p = new List<Person>();

			p.Add(new Person(" ", "Fcddk", 12, "gen", new DateTime(2002, 12, 3), new DateTime(2004, 11, 5)));
			p.Add(new Person("Asdasd", "Pidffd", 6, "ska", new DateTime(2000, 12, 1), new DateTime(2007, 02, 15)));
			p.Add(new Person("Qweqwe", "Shtsdvs", 10, "aaa", new DateTime(2006, 03, 27), new DateTime(2010, 11, 5)));
			p.Add(new Person("Zzcxxc", "Psdsvs", 3, "fck", new DateTime(2002, 04, 25), new DateTime(2004, 07, 3)));

			p.Sort((a, b) => b.GetExperience().CompareTo(a.GetExperience()));

			//Person person = p[0];
			foreach (var item in p)
			{
				Console.WriteLine(item);
			}

			//Console.WriteLine(person);

			Console.ReadKey(true);
		}
	}
}
