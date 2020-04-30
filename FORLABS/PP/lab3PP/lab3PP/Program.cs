using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5PP
{

	public class Rectangle
	{
		public double X { get; set; }
		public double Y { get; set; }
		public double A { get; set; }
		public double B { get; set; }

		public Rectangle() { }

		public Rectangle(double x, double y, double a, double b)
		{
			X = x;
			Y = y;
			A = a;
			B = b;
		}

		public override string ToString()
		{
			return X.ToString() + " " + Y.ToString() + " " + A.ToString() + " " + B.ToString();
		}

		public void MoveRectangle(double x1, double y1)
		{
			X += x1;
			Y += y1;
		}

		public void ResizeRectangle(double a1, double b1)
		{
			A += a1;
			B += b1;
		}

		public static Rectangle MakeRectangle(Rectangle first, Rectangle second)
		{
			double left = Math.Max(first.X, second.X);
			double top = Math.Min(first.Y + first.A, second.Y + second.A);
			double right = Math.Min(first.X, second.X);
			double bottom = Math.Max(first.Y - first.B + first.A, second.A - second.B + second.A);

			double width = right - left;
			double height = top - bottom;

			return new Rectangle(right, left, height, width);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//double x;
			//double y;
			//double a;
			//double b;

			//x = Convert.ToDouble(Console.ReadLine());
			//y = Convert.ToDouble(Console.ReadLine());
			//a = Convert.ToDouble(Console.ReadLine());
			//b = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Не так ввел значение!!!");

	


			//Rectangle r = new Rectangle(x, y, a, b);
			//Console.WriteLine(r);
			//r.MoveRectangle(a, b);
			//Console.WriteLine();
			//r.ResizeRectangle(a, b);
			//Console.WriteLine(Rectangle.MakeRectangle(r, new Rectangle(12, 2, 3, 10)));
		}
	}
}

