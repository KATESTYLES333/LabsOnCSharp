using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Var1
	{
		private int date;
		public int Date
		{
			get
			{
				return date;
			}
			set
			{
				if(value < 32 && value > 0)
				{
					date = value;
				}
				else
				{
					throw new Exception();
				}
			}
		}

		private int month;
		public int Month
		{
			get
			{
				return month;
			}
			set
			{ 
				if(value < 13 && value > 0)
				{
					month = value;
				}
				else
				{
					throw new Exception();
				}
			}
		}
		public int Year { get; set; }

		Var1() { }

		~Var1() { }

		public Var1(int date, int month, int year)
		{
			this.Date = date;
			this.Month = month;
			this.Year = year;
		}

		public bool IsLeap()
		{
			return Year % 4 == 0;
		}

		public int AddDate()
		{
			return Date += 5;
		}

		public int AddYear()
		{
			return Year += 1;
		}

		public int SubDate()
		{
			return Date - 2;
		}

		public bool F1()
		{
			return this.Date == this.Month;
		}

		public bool F2()
		{
			return date == month;
		}

		public override string ToString()
		{
			return Date.ToString() + " " + Month.ToString() + " " + Year.ToString();
		}
	}
}
