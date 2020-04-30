using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Square square = new Square(-3);
			//Console.WriteLine(square);

			//GeometryVector vector = new GeometryVector(3, 5);
			//GeometryVector vector1 = new GeometryVector();
			//Console.WriteLine(vector.SumofVectors(vector1));
			//Console.WriteLine(vector.MulVectors(vector1));
			//Console.WriteLine(vector);

			//Complex complex = new Complex(3, 2);
			//Complex complex1 = new Complex(3, 4);
			//Console.WriteLine(complex.GetSum(complex1));
			//Console.WriteLine(complex.GetSub(complex1));
			//Console.WriteLine(complex.MulComp(complex1));
			//Console.WriteLine(complex);

			//Fraction fraction = new Fraction(3, 6);
			//Fraction fr = new Fraction();
			//Console.WriteLine(fraction.Sum(fr));
			//Console.WriteLine(fraction);

			//PowerE power = new PowerE(3, -14, -5);
			//Console.WriteLine(power);
			//power.GetResult();


			int[] array = new int[]{1,2};
			Ar ar = new Ar(array);
			Console.WriteLine(ar.InArray(3));

			Console.ReadKey();
		}
	}
}
