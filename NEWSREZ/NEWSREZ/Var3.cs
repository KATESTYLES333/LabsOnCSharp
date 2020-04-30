using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var3
	{
		int day { get; set; }
		int month { get; set; }
		int year { get; set; }

		Var3() { }

		~Var3() { }

		public Var3(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public bool SameDayMonth(int day, int month)
		{
			if (day == month)
			{
				return true;
			}
			return false;
		}

		public void AddMonth()
		{
			if (month + 1 >= 12)
			{
				month += 1 - 13;
			}
			month += 1;
		}

		public override string ToString()
		{
			return day.ToString() + " " + month.ToString() + " " + year.ToString();
		}
	}
}
