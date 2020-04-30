using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSREZ
{
	class Var5
	{
		int min { get; set; }
		int hour { get; set; }
		int sec { get; set; }

		Var5(){ }

		~Var5(){ }

		public Var5(int min, int hour, int sec)
		{
			this.min = min;
			this.hour = hour;
			this.sec = sec;
		}

		public override string ToString()
		{
			return min.ToString() + " " + hour.ToString() + " " + sec.ToString();
		}

		public int FullMin()
		{
			return (hour * 3600) + (60 * min) + sec;
		}

		public int SubTen()
		{
			return min - 10;
		}
	}
}
