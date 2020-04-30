using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LastSrez
{
	class B
	{
		public int W { get; set; }
		virtual public void F()
		{
			Console.WriteLine("Zhopa");
		}
	}

	class Person
	{
		private string name;
		public string Name{ get; set; }

		public Person (string name)
		{
			this.Name = name;
		}
		public void F()
		{
			Console.WriteLine(Name);
		}
	}

	class Animal : Person
	{
		public string Dura { get; set; }

		public Animal(string dura, string name1) : base(name: "Zhopa")
		{
			Console.WriteLine(dura);
		}
	}

	class D : B
	{
		public int W1 { get; set; }
		override public void F()
		{
			int somecase = 4;
			switch (somecase)
			{
				case 1:
					Console.WriteLine("Zopa");
					break;
				case 2:
					Console.WriteLine("Pidor");
					break;
				default:
					Console.WriteLine("super");
					break;
			}
			Regex r = new Regex(@"\d{3}-\d{2}-\d{2}");
			Console.WriteLine("Pizda");
		}
	}



	class Program
	{
		static void Main(string[] args)
		{
			//B b = new B();
			//b.F();

			Goods g = new Goods("Suka Toyota", 12, "ska");
			Console.WriteLine(g.GetPrice(2));
			Console.WriteLine(g.AddPrice(2));
		}
	}
}
