using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbanutiyTranslation
{
	class Program
	{
		public static string Translation(string message)
		{
			string res = message.Replace("П", "Б")
				.Replace("п", "б")
				.Replace("к", "г")
				.Replace("К", "Г")
				.Replace("ф", "в")
				.Replace("Ф", "В")
				.Replace("т", "д")
				.Replace("Т", "Д")
				.Replace("ш", "ж")
				.Replace("Ш", "Ж")
				.Replace("с", "з")
				.Replace("С", "З");
			return res;
		}

		static void Main(string[] args)
		{
			Console.Write("Your text:");
			string text = Console.ReadLine();
			string trtext = Translation(text);
			Console.WriteLine(trtext);
			Console.WriteLine();
		}
	}
}
