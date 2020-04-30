using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Complex
	{
		public int Active { get; set; }
		public int Passive { get; set; }

		public Complex() { }

		public Complex(int a, int p)
		{
			this.Active = a;
			this.Passive = p;
		}

		public Complex GetSum(Complex complex)
		{
			return new Complex(this.Active + complex.Active, this.Passive + complex.Passive);
		}

		public Complex GetSub(Complex complex)
		{
			return new Complex(this.Active - complex.Active, this.Passive - complex.Passive);
		}

		public Complex MulComp(Complex com)
		{
			return new Complex((this.Active * com.Active) + (this.Active * com.Passive), (this.Passive * com.Passive) + (this.Passive * com.Active));
		}

		public override string ToString()
		{
			return Active.ToString() + " " + Passive.ToString();
		}
	}
}
