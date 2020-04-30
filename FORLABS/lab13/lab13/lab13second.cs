using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
	class MyException : Exception
	{
		public MyException(string message) : base(message)
		{
		}
	}
	//Информация о сотрудниках предприятия содержит ФИО, номер отдела,
	//должность, дату начала работы.Вывести список сотрудников заданного отдела в
	//порядке убывания стажа.
	class Person
	{
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (value == " ")
				{
					throw new MyException("Must be full");
				}
			}
		}

		public string Surname;

		public int numDepart;

		public string position;
		public DateTime startWork;

		public DateTime endWork;

		public Person() { }

		public Person(string name, string surname, int num, string pos, DateTime stw, DateTime enw)
		{
			Name = name;
			Surname = surname;
			numDepart = num;
			position = pos;
			startWork = stw;
			endWork = enw;
		}

		public override string ToString()
		{
			return Name + " " + Surname + " " + startWork.Year.ToString() + " " + endWork.Year.ToString() + " ";
		}

		public int GetExperience()
		{
			return (endWork.Year - startWork.Year);
		}
	}


}

