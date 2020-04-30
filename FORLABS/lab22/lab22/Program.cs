using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22
{
	class Program
	{
		static List<string> fTeam = new List<string>();
		static List<string> sTeam = new List<string>();

		static readonly object obj1 = new object();
		static readonly object obj2 = new object();

		static List<string> FirstTeam
		{
			get
			{
				lock (obj1)
				{
					return fTeam;
				}
			}
		}

		static List<string> SecondTeam
		{
			get
			{
				lock (obj2)
				{
					return sTeam;
				}
			}
		}

		static public void AddPlayers()
		{
			Random r = new Random();
			int fCount = r.Next(5, 100);
			int sCount = r.Next(5, 100);

			for (int i = 0; i < fCount; i++)
			{
				fTeam.Add("Somebody");
			}
			for (int i = 0; i < sCount; i++)
			{
				sTeam.Add("Somebody1");
			}
		}

		static public void RemovePlayers()
		{
			Random r = new Random();
			int firstCount = r.Next(1, 50);
			int secondCount = r.Next(1, 50);

			for (int i = 0; i < firstCount; i++)
			{
				fTeam.Add("Some2");
			}
			for (int i = 0; i < secondCount; i++)
			{
				sTeam.Add("Some3");
			}

		}

		static void Main(string[] args)
		{
		}
	}
}
