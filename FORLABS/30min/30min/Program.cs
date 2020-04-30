using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30min
{
	class Student
	{
		private string name;
		public string Name { get => name; set => value = name; }
		private int group;
		public int Group { get => group; set => value = group; }
		private int mark;
		public int Mark { get => mark; set => value = mark; }

		public Student(string name, int group, int mark)
		{
			this.name = name;
			this.group = group;
			this.mark = mark;
		}



		class Program
		{


			static void Main(string[] args)
			{

				Console.ReadLine();
			}
		}
	}
}


