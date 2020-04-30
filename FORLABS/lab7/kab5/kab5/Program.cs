using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kab5
{
	class Program
	{
		public static String Task1(String s, char c)
		{
			StringBuilder message = new StringBuilder(s);
			return message.Replace(c.ToString(), "").ToString();
		}

		public static string Task2(string message, char c)
		{
			return message.Replace(c.ToString(), c.ToString() + c.ToString());
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Task2("asdasdasd", 'a'));
		}
	}
}
