using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
	class Program
	{
		static int Priority(string c)
		{
			if (c == "^")
			{
				return 3;
			}
			else if (c == "*" || c == "/")
			{
				return 2;
			}
			else if (c == "+" || c == "-")
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
		static bool IsOperator(string c)
		{
			if (c == "+" || c == "-" || c == "*" || c == "/" || c == "^")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		static void Main(string[] args)
		{
			string infix = "11 - 3  / 2";
			string[] res = infix.Split(' ');

			Stack<string> s = new Stack<string>();
			List<string> list = new List<string>();

			foreach (string item in res)
			{
				if (int.TryParse(item.ToString(), out int result))
				{
					list.Add(item);
				}
				if (item == "(")
				{
					s.Push(item);
				}
				if (item == ")")
				{
					while (s.Count != 0 && s.Peek() != "(")
					{
						list.Add(s.Pop());
					}
					s.Pop();
				}
				if (IsOperator(item) == true)
				{
					while (s.Count != 0 && Priority(s.Peek()) >= Priority(item))
					{
						list.Add(s.Pop());
					}
					s.Push(item);
				}
			}
			while (s.Count != 0)//if any operators remain in the stack, pop all & add to output list until stack is empty 
			{
				list.Add(s.Pop());
			}
			for (int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i]);
			}

			Console.ReadLine();
		}


	}

}
