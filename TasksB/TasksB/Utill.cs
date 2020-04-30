using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksB
{
    class Utill
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

        public int Min(int a, int b, int c)
        {
            return Min(Min(a, b), c);
        }

        public int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        public int Max(int a, int b, int c)
        {
            return Max(Max(a, b), c);
        }
    }
}
