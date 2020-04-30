using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llllll
{
	interface ISomeInterface
	{
		void SomeF();
		void SomeF2();
	}

	public class SomeInter : ISomeInterface
	{
		public void SomeF()
		{

		}

		public void SomeF2()
		{

		}

	}

	abstract class A
	{
		public abstract void Show();
	}

	class D : A
	{
		public override void Show()
		{
			Console.WriteLine("Show message");
		}
	}


	class Program
	{
		static void F(ISomeInterface obj)
		{
			obj.SomeF();
			obj.SomeF2();
		}

		static void Main(string[] args)
		{
		}
	}
}
