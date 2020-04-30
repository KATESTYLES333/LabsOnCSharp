using SmbTasks.MyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmbTasks
{
	class Cube : IParam, IShowInf
	{
		private double a;
		public double A
		{
			get
			{
				return a;
			}
			set
			{
				if (value < 0)
				{
					throw new Exception("Your fckng dibil");
				}
				else
				{
					a = value;
				}
			}
		}

		public Cube() { }

		public Cube(double a)
		{
			this.A = a;
		}

		public double GetAreaofCube()
		{
			return 6 * Math.Pow(a, 2);
		}

		public double GetPerimeterofCube()
		{
			return 12 * a;
		}

		public double GetDiagonalofCube()
		{
			return Math.Sqrt(3) * a;
		}

		public void ShowInfo()
		{
			Console.WriteLine("Side: " + a);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите сторону: ");
			double a = Convert.ToDouble(Console.ReadLine().Replace('.', ',')); //changes the dot to a comma
			Cube c = new Cube(a);
			c.ShowInfo();
			Console.WriteLine("Perimeter is: " + c.GetPerimeterofCube());
			Console.WriteLine("Diagonal is: " + c.GetDiagonalofCube());
			Console.WriteLine("Area is: " + c.GetAreaofCube());

			Console.ReadLine();
		}
	}
}
