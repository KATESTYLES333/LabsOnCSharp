using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab10second
{
	[Serializable]
	//[XmlInclude(typeof(StudentGroup)), XmlType]
	public class Student
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime Date { get; set; }


		public Student(string name, string surname, DateTime date)
		{
			this.Name = name;
			this.Surname = surname;
			this.Date = date;
		}

		public Student()
		{
		}

		public override string ToString()
		{
			return Name + " " + Surname + " " + Date.ToString();
		}
	}

	[Serializable]
	public class StudentGroup : ICollection<Student>
	{
		public List<Student> s = new List<Student>();

		public int Count => s.Count;

		public bool IsReadOnly => false;

		public Student FindStudent(string key)
		{
			for (int i = 0; i != s.Count; ++i)
			{
				if (s[i].Surname == key || s[i].Name == key)
				{
					return s[i];
				}
			}
			return new Student();
		}

		public void Add(string name, string surname, DateTime date)
		{
			Student student = new Student(name, surname, date);
			s.Add(student);
		}

		//public void RemoveCertainStudent(string name, string surname, DateTime date)
		//{
		//	Student student = new Student(name, surname, date);
		//	s.Remove(student);
		//}


		public void RemoveByIndex(int index)
		{
			s.RemoveAt(index);
		}

		public IEnumerator GetEnumerator()
		{
			return s.GetEnumerator();
		}

		public void Add(Student item)
		{
			s.Add(item);
		}

		public void Add(object obj)
		{
			if (obj is Student)
			{
				s.Add((Student)obj);
			}
		}

		public void Clear()
		{
			
		}

		public bool Contains(Student item)
		{
			return s.Contains(item);
		}

		public void CopyTo(Student[] array, int arrayIndex)
		{
			
		}

		public bool Remove(Student item)
		{
			return s.Remove(item);
		}

		IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
		{
			return s.GetEnumerator();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			StudentGroup group = new StudentGroup();
			group.Add("sss", "www", new DateTime(2003, 01, 04));
			group.Add("qqq", "zzz", new DateTime(2002, 03, 03));
			group.Add("rrr", "xxx", new DateTime(2001, 9, 01));
			group.Add("aaa", "ccc", new DateTime(2002, 10, 18));

			//group.RemoveByIndex(2);

			group.s.Sort((f, s) =>
			{
				return f.Date.CompareTo(s.Date);
			});

			foreach (var i in group)
			{
				Console.WriteLine(i);
			}

			BinaryFormatter bf = new BinaryFormatter();
			SoapFormatter sf = new SoapFormatter();
			XmlSerializer xml = new XmlSerializer(typeof(Student));

			
			//FileStream strBin = new FileStream("./Bin.dat", FileMode.OpenOrCreate);
			//FileStream strXml = new FileStream("./XXml.xml", FileMode.OpenOrCreate);

			using (FileStream strBin = new FileStream("./Bin.dat", FileMode.OpenOrCreate))
			using (FileStream strXml = new FileStream("./XXml.xml", FileMode.OpenOrCreate))
			using (FileStream strSoap = new FileStream("./Soap.dat", FileMode.OpenOrCreate))
			{
				foreach (var item in group)
				{
					sf.Serialize(strSoap, item);
					bf.Serialize(strBin, item);
					xml.Serialize(strXml, item);
				}
			}
		}
	}
}
