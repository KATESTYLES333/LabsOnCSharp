using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11first
{
	class Pair
	{
		public int first;
		public int second;

		public override bool Equals(object obj)
		{
			if (!(obj is Pair))
			{
				return false;
			}

			Pair other = (Pair)obj;
			return first == other.first && second == other.second;
		}

		public int Sub()
		{
			return 0;
		}
	}

	class RationalFraction : Pair
	{
		public int mun;
		public int denum;

		RationalFraction(){ }

		
	
	}

}
