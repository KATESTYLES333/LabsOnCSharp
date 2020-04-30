using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozd
{
	public class B 
	{
		public void f()
		{
			Console.WriteLine("fck you");
		}
	}	
	public class D : B
	{
		public void f()
		{	
			Console.WriteLine("sasdasd");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			B b = new D();
			((D)b).f();
			Console.ReadLine();
		}
	}
}
