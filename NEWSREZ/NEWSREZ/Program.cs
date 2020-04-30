using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Program
	{
		static void Main(string[] args)
		{
			//Var22 v22 = new Var22(-12, 11, 4);
			//Console.WriteLine(v22.AverGeom());
			//Console.WriteLine(v22.CountDigitsInSum());
			//Console.WriteLine(v22);

			//Var6 v6 = new Var6(12, 10, 30);
			//v6.AddMinutes();
			//Console.WriteLine(v6);

			//Var20 v20 = new Var20(3, 4, 6);
			//Console.WriteLine(v20.SquareUp());
			//Console.WriteLine(v20.SumParall());
			//Console.WriteLine(v20);

			//Var15 v15 = new Var15(1, 2, 8, 4);
			//Console.WriteLine(v15.LengthVect());
			//Console.WriteLine(v15.Square());
			//Console.WriteLine(v15);

			//Regex rx = new Regex(@"Иван[а-я]*");
			//Var28 v28 = new Var28("Ивано", "инженер", 12);
			//Console.WriteLine(v28.F1(13));
			//v28.SurnReg(rx);
			//Console.WriteLine(v28);

			//Var1 v1 = new Var1(12, 1, 2000);
			//v1.AddDay();
			//Console.WriteLine(v1.IsLeapYear1());
			//Console.WriteLine(v1);
			//Console.WriteLine();


			//Var2 v2 = new Var2(11, 1, 2010);
			//v2.AddYear();
			//v2.SubDate();
			//Console.WriteLine(v2);

			//Var3 v3 = new Var3(12, 4, 2002);
			//v3.AddMonth();
			//Console.WriteLine(v3.SameDayMonth(12, 12));
			//Console.WriteLine(v3);


			//Var5 v5 = new Var5(12, 3, 10);
			//Console.WriteLine(v5.FullMin());
			//Console.WriteLine(v5.SubTen());
			//Console.WriteLine(v5);

			//Var10 v10 = new Var10(1, 2, 1, 3);
			//v10.Multiply();
			//Console.WriteLine(v10);

			//Var13 v13 = new Var13("asd", 123, new DateTime(2002, 1, 3), new DateTime(2000, 3, 3));
			//Console.WriteLine(v13.CountToFifty());
			//Console.WriteLine(v13);

			//Var13 v13 = new Var13("asd", 123, new DateTime(2002, 1, 3), new DateTime(2000, 3, 3));
			//Console.WriteLine(v13.CountToFifty());
			//Console.WriteLine(v13);

			Var26 v26 = new Var26("Программирование жопы", 12, 24.0);
			//Console.WriteLine(v26.AddPages());
			//Console.WriteLine(v26.AverageCost());
			Console.WriteLine(v26.AddCost());
			//Console.WriteLine(v26.GetPrice());
			Console.WriteLine(v26);
		}
	}
}
