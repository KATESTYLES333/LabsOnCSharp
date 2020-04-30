using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
	public class Time : ICloneable, IComparable<Time>
	{
		private int hours;
		public int Hour
		{
			get
			{
				return hours;
			}
			set
			{
				if (value < 24 && value >= 0)
				{
					hours = value;
				}
				else
				{
					while (value > 24)
					{
						value -= 24;
					}
					hours = value;
				}
			}
		}

		private int minutes;
		public int Minutes
		{
			get
			{
				return minutes;
			}
			set
			{
				if (value > 60 && value >= 0)
				{
					minutes = value;
				}
				else
				{
					while (value > 60)
					{
						value -= 60;
						++Hour;
					}
					minutes = value;
				}
			}
		}

		private int seconds;
		public int Seconds
		{
			get
			{
				return seconds;
			}
			set
			{
				if (value < 60 && value >= 0)
				{
					seconds = value;
				}
				else
				{
					while (value > 60)
					{
						value -= 60;
						++Minutes;
					}
					seconds = value;
				}
			}
		}

		public Time() { }

		public Time(int h, int m, int s)
		{
			this.Hour = h;
			this.Minutes = m;
			this.Seconds = s;
		}

		~Time() { Console.WriteLine("Destr"); }

		public override string ToString()
		{
			return "hours: " + hours.ToString() + ", minutes: " + minutes.ToString() + ", seconds: " + seconds.ToString();
		}

		public object Clone()
		{
			return new Time(Hour, Minutes, Seconds);
		}

		public int CompareTo(Time other)
		{
			//return hours.CompareTo(other.hours);
			//return minutes.CompareTo(other.minutes);
			return seconds.CompareTo(other.seconds);

		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			//Time t = new Time(12, 11, 70);
			//Console.WriteLine(t);

			var arr = new Time[] { new Time(12, 30, 24),
									new Time(3, 50, 54),
									new Time(6, 28, 50)};


			Array.Sort(arr);

			foreach (Time item in arr)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}
	}
}
