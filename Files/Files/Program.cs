using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
	class Program
	{

		public static void WriteBin()
		{
			string path = @"D:\file.dat";
			using(BinaryWriter writer = new BinaryWriter(File.Create(path)))
			{
				writer.Write(10);
				writer.Write("pip");
			}
		}

		public static void WriteText()
		{
			string path = @"D:\file.txt";
			using (StreamWriter writer = new StreamWriter(File.Create(path)))
			{
				writer.Write(10);
				writer.Write("pip");
			}
		}
		static void Main(string[] args)
		{
			WriteBin();
		}
	}
}
