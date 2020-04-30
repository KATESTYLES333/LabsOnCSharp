using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var6
	{
		int minute { get; set; }
		int hour { get; set; }
		int second { get; set; }

		Var6() { }

		~Var6() { Console.WriteLine("Destructor"); }

		public Var6(int minute, int hour, int second)
		{
			this.minute = minute;
			this.hour = hour;
			this.second = second;
		}

		public void AddMinutes()
		{
			this.minute += 100;
		}

		public int MinutesCount()
		{
			if (hour < 0)
			{
				throw new Exception("Dibil");
			}
			int res = hour * 60 + minute;
			return (24 * 60) - res;
		}

		public override string ToString()
		{
			return minute.ToString() + " " + hour.ToString() + " " + second.ToString();
		}

	}
}
