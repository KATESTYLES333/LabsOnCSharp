using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17ss
{
	class Toy : IComparable
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public int AgeMin { get; set; }
		public int AgeMax { get; set; }

		public Toy() { }

		public Toy(string n, double p, int min, int max)
		{
			Name = n;
			Price = p;
			AgeMin = min;
			AgeMax = max;
		}

		public int CompareTo(object obj)
		{
			Toy toy = (Toy)obj;
			return Price.CompareTo(toy.Price);
		}

		public override string ToString()
		{
			return Name + " !price: " + Price.ToString() + " " + AgeMin.ToString() + "-" + AgeMax.ToString();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Toy> list = new List<Toy>();

			Toy toyfirst = new Toy
			{
				Name = "Pizdec and his friends",
				Price = 20,
				AgeMax = 18,
				AgeMin = 12
			};

			Toy toysecond = new Toy
			{
				Name = "Ebychie laby and enchanting fck",
				Price = 10,
				AgeMax = 18,
				AgeMin = 12
			};

			Toy toythird = new Toy
			{
				Name = "Can I survive?",
				Price = 100,
				AgeMax = 18,
				AgeMin = 10
			};

			list.Add(toyfirst);
			list.Add(toysecond);
			list.Add(toythird);

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Write min range:");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write max range:");
			int m = Convert.ToInt32(Console.ReadLine());

			var lt = (from toy in list
					  where toy.AgeMin == n
					  where toy.AgeMax == m
					  select toy).ToList();
			lt.Sort();

			Console.WriteLine("After sorting: ");
			foreach (var item in lt)
			{
				Console.WriteLine(item);
			}

			using (StreamWriter sw = new StreamWriter("output.txt"))
			{
				foreach (var item in lt)
				{
					sw.WriteLine(item.ToString());
				}
			}

			Console.ReadLine();
		}
	}
}

