using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functStatic
{
	class Govno
	{
		public int a;

		public int F()
		{
			return a;
		}

		public static int F1(int _a)
		{
			return _a;
		}
	}

	abstract class Animal
	{
		public string Name { get; set; }

		public Animal(string name)
		{
			this.Name = name;
		}

		public void F()
		{
			Console.WriteLine("SHIT FUCK");
		}
	}

	class Belugina : Animal
	{
		public string Res{ get; set; }

		public Belugina(string res, string name) : base(name)
		{
			this.Res = res;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Belugina b = new Belugina("Suka", "Tupaya");
			b.F();

			Govno g = new Govno();
			Govno.F1(12);
			Console.WriteLine(g.F());
		}
	}
}
