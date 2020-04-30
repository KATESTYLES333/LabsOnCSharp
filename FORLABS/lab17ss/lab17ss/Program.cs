using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab17ss
{
	//Дан файл, содержащий информацию о сотрудниках фирмы: фамилия, имя,
	//отчество, пол, возраст, размер зарплаты.За один просмотр файла напечатать элементы
	//файла в следующем порядке: сначала все данные о сотрудниках, зарплата которых
	//меньше 10000, потом данные об остальных сотрудниках, сохраняя исходный порядок в
	//каждой группе сотрудников.
	//Queue & StreamReader!!!!!!!!!!
	class Person
	{
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronymic { get; set; }
		public string Sex { get; set; }
		public int Age { get; set; }
		public double Salary { get; set; }

		public Person() { }
		public Person(string s, string n, string p, string sex, int a, double sal)
		{
			Surname = s;
			Name = n;
			Patronymic = p;
			Sex = sex;
			Age = a;
			Salary = sal;
		}
		public override string ToString()
		{
			return Surname + " " + Name + " " + Patronymic + " " + Sex + " " + Salary + " " + Age.ToString();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Queue<Person> people = new Queue<Person>();

			people.Enqueue(new Person
			{
				Surname = "Skaaaa",
				Name = "Oleg",
				Patronymic = "Olegovnich",
				Sex = "women",
				Age = 14,
				Salary = 14.2
			});

			people.Enqueue(new Person
			{
				Surname = "Cherkun",
				Name = "Vovan",
				Patronymic = "Vladimirovnich",
				Sex = "men",
				Age = 17,
				Salary = 100
			});
			
			people.Enqueue(new Person
			{
				Surname = "QWerty",
				Name = "ASDads",
				Patronymic = "PSpspaadc",
				Sex = "men",
				Age = 20,
				Salary = 1111150
			});

			Console.WriteLine("Salary min 10000: ");
			foreach (var person in people)
			{
				if (person.Salary < 10000)
				{
					Console.WriteLine(person);
				}
			}
			Console.WriteLine();
			Console.WriteLine("Other: ");
			foreach (var person in people)
			{
				if (person.Salary > 10000)
				{
					Console.WriteLine(person);
				}
			}

		

			using (StreamWriter sw = new StreamWriter("output.txt"))
			{
				foreach (var item in people)
				{
					sw.WriteLine(item.ToString());
				}
			}
			Console.ReadLine();

		}
	}
}
