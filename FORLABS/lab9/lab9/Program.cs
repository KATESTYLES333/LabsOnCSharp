using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
	class Sportsmen
	{
		public string countryName;
		public string teamName;
		public string fullName;
		public int gameNumber;
		public int age;
		public double height;
		public double weightl;

		public override string ToString()
		{
			string res = "";
			res += countryName + " " + teamName + " " + fullName + " " + gameNumber + " " + age + " " + height + " " + weightl;
			return res;
		}
	}

	class DreamTeam
	{
		public List<Sportsmen> sportsmens = new List<Sportsmen>();

		public double GetAverAge()
		{
			int sum = 0;
			foreach (Sportsmen i in sportsmens)
			{
				sum += i.age;
			}
			return (double)sum / (double)sportsmens.Count;
		}

		public override string ToString()
		{
			string res = "";

			foreach (Sportsmen item in sportsmens)
			{
				res += item.ToString() + "\n";
			}
			return res;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			List<DreamTeam> dreamTeams = new List<DreamTeam>();

			DreamTeam dt = new DreamTeam();
			dt.sportsmens.Add(new Sportsmen() { countryName = "Zopa", teamName = "Super", fullName = "asdasd asdasd", gameNumber = 5, age = 100, height = 70, weightl = 180 });
			dt.sportsmens.Add(new Sportsmen() { countryName = "Zopa", teamName = "Super", fullName = "qwe qwe", gameNumber = 10, age = 110, height = 90, weightl = 180 });


			DreamTeam dt2 = new DreamTeam();
			dt2.sportsmens.Add(new Sportsmen() { countryName = "Dadada", teamName = "SAGGG", fullName = "asgasg asg", gameNumber = 20, age = 70, height = 90, weightl = 190 });
			dt2.sportsmens.Add(new Sportsmen() { countryName = "Dadada", teamName = "SAGGG ", fullName = "qwry aqwertysg", gameNumber =230, age = 80, height = 90, weightl = 190 });


			DreamTeam dt3 = new DreamTeam();
			dt3.sportsmens.Add(new Sportsmen() { countryName = "BAELE", teamName = "Qwerty", fullName = "qwe qwe qwer", gameNumber = 10, age = 110, height = 90, weightl = 180 });
			dt3.sportsmens.Add(new Sportsmen() { countryName = "BAELE", teamName = "Qwerty", fullName = "qweadfdac qwerdcd", gameNumber = 13, age = 90, height = 90, weightl = 180 });


			dreamTeams.Add(dt);
			dreamTeams.Add(dt2);
			dreamTeams.Add(dt3);

			dreamTeams.Sort((a, b) => a.GetAverAge().CompareTo(b.GetAverAge()));

			DreamTeam dreamTeam = dreamTeams[0];
			Console.WriteLine(dreamTeam);

			Console.ReadLine();
		}
	}
}
