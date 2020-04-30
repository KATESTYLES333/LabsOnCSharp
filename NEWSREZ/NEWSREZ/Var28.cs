using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var28
	{
		string surname { get; set; }
		string position{ get; set; }
		int salary { get; set; }

		Var28(){ }

		~Var28(){ }

		public override string ToString()
		{
			return surname.ToString() + " " + position.ToString() + " " + salary.ToString();
		}

		public Var28(string surname, string position, int salary)
		{
			this.surname = surname;
			this.position = position;
			this.salary = salary;
		}

		public double F1(double percent)
		{
			 return salary * percent;
		}

		public void SurnReg(Regex regex)
		{
			if(regex.IsMatch(surname))
			{
				position = "инженер";
			}
		}

	}
}
