using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Ar
	{
		private int[] array;
		public int Size
		{
			get
			{
				return array.Length;
			}
		}

		public Ar() { }

		public Ar(int[] arr)
		{
			this.array = arr;
		}

		public bool InArray(int num)
		{
			return Array.IndexOf(array, num) != -1;
		}
	}
}
