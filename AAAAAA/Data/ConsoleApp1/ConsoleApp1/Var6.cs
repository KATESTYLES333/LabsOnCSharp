using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Var6
	{
		private int hour;
		public int Hour
		{
			get
			{
				return hour;
			}
			set
			{
				if (value < 24 && value >= 0)
				{
					hour = value;
				}
				else
				{
					while (value > 24)
					{
						value -= 24;
					}
					hour = value;
				}
			}
		}
		private int minute;
		public int Minute
		{
			get
			{
				return minute;
			}
			set
			{
				if (value < 60 && value >= 0)
				{
					minute = value;
				}
				else
				{
					while (value > 60)
					{
						value -= 60;
						++hour;
					}
					minute = value;

				}
			}
		}

		private int second;
		public int Second
		{
			get
			{
				return second;
			}
			set
			{
				if (value < 60 && value >= 60)
				{
					second = value;
				}
				else
				{
					while (value > 60)
					{
						value -= 60;
						++minute;
					}
					minute = value;
				}
			}
		}


		Var6() { }

		public Var6(int hour, int minute, int second)
		{
			this.Hour = hour;
			this.Minute = minute;
			this.Second = second;
		}

		~Var6() { }

		public int ToPolunochi()
		{
			return ((24 - this.Hour) * 60) + (60 - this.Minute);
		}

		public void AddHours()
		{
			minute += 100;
			while(minute > 60)
			{
				minute -= 60;
				++hour;
			}
		}

		public override string ToString()
		{
			return hour.ToString() + " " + minute.ToString() + " " + second.ToString();
		}

	}
}
