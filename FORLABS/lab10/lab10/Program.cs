using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab10
{
	[Serializable]
	public class SomeClass
	{
		public double num1;
		public double num2;

		public double FindMin()
		{
			return Math.Min(num1, num2);
		}

		public double Equation(double x, double y, double z)
		{
			double result = Math.Abs(Math.Min(5 * Math.Pow(x, 2), y) - Math.Max(y, z));
			return Convert.ToDouble(result / 2);
		}

	}
	class Program
	{
		static void Main(string[] args)
		{

			//Console.WriteLine("First value:");
			//someClass.num1 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Second value:");
			//someClass.num2 = Convert.ToDouble(Console.ReadLine());
			//double res = someClass.FindMin();
			//Console.WriteLine("Min element is: ");
			//Console.WriteLine(res);

			SomeClass someClass = new SomeClass();

			BinaryFormatter bf = new BinaryFormatter();
			SoapFormatter sf = new SoapFormatter();
			XmlSerializer xml = new XmlSerializer(typeof(SomeClass));

			FileStream strSoap = new FileStream("./Someclass.dat", FileMode.OpenOrCreate);
			FileStream strXml = new FileStream("./XXml.xml", FileMode.OpenOrCreate);
			FileStream strBf = new FileStream("./Some.dat", FileMode.OpenOrCreate);

			bf.Serialize(strBf, someClass);
			sf.Serialize(strSoap, someClass);
			xml.Serialize(strXml, someClass);

			strSoap.Close();
			strXml.Close();
			strBf.Close();

			//Console.WriteLine(" Get x:");
			//double val1 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Get y:");
			//double val2 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Get z:");
			//double val3 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Res is:");
			//double result = someClass.Equation(x: val1, y: val2, z: val3);
			//Console.WriteLine(result);

			Console.ReadKey(true);
		}
	}
}
