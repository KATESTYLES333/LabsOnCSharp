using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
	public class Fraction
	{
		public int Num { get; set; }
		public int Denum { get; set; }

		public Fraction() { }

		public Fraction(int num, int denum)
		{
			this.Num = num;
			this.Denum = denum;
		}

		public override string ToString()
		{
			return Num.ToString() + " " + Denum.ToString();
		}

		public int GCD()
		{
			int a = Num;
			int b = Denum;
			while (a != 0 && b != 0)
			{
				if (a > b)
					a %= b;
				else
					b %= a;
			}

			return a == 0 ? b : a;
		}

		public Fraction Simplify()
		{
			int gcd = GCD();
			return new Fraction(this.Num / gcd, this.Denum);
		}

		public Fraction Sum(Fraction fraction)
		{
			return new Fraction(fraction.Num + this.Num, fraction.Denum + this.Denum);
		}

		public Fraction Sub(Fraction fraction)
		{
			return new Fraction(fraction.Num - this.Num, fraction.Denum - this.Denum);
		}

		public Fraction Mul(Fraction fraction)
		{
			return new Fraction(fraction.Num * this.Num, fraction.Denum * Denum);
		}

		public Fraction Div(Fraction fraction)
		{
			return new Fraction(fraction.Num / this.Num, fraction.Denum / Denum);
		}
	}
}
