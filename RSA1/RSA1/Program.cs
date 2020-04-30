using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA1
{
	class Program
	{
		private bool IsTheNumberSimple(long n)
		{
			if (n < 2)
				return false;

			if (n == 2)
				return true;

			for (long i = 2; i < n; i++)
				if (n % i == 0)
					return false;

			return true;
		}

		private long Calculate_d(long m)
		{
			long d = m - 1;

			for (long i = 2; i <= m; i++)
				if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
				{
					d--;
					i = 1;
				}

			return d;
		}

		private long Calculate_e(long d, long m)
		{
			long e = 10;

			while (true)
			{
				if ((e * d) % m == 1)
					break;
				else
					e++;
			}

			return e;
		}

		static void Main(string[] args)
		{
		}
	}
}
