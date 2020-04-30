using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Square
	{
		private int a;
		public int A
		{
			get
			{
				return a;
			}
			set
			{
				if (value < 0)
				{
					throw new Exception("Make value positive");
				}
				a = value;
			}
		}

		public Square() { }
		public Square(int a)
		{
			this.A = a;
		}

		public override string ToString()
		{
			return a.ToString();
		}
	}
}
