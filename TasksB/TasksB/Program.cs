using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksB
{
    class IComporatorLess : IComparer
    {
        public int Compare(object x, object y)
        {
            return (int)y - (int)x;
        }
    }

    class IComporatorGreater : IComparer
    {
        public int Compare(object x, object y)
        {
            return (int)x - (int)y;
        }
    }

    class Program
    { 

        static void Main(string[] args)
        {
          
            int a = 4;
            int b = 3;
            int c = 7;
            int d = 5;

            Console.WriteLine(a + " " + b);
            Utill.Swap(ref a, ref b);
            Console.WriteLine(a + " " + b);

            Tasks.Task12(ref a, ref b, ref c, ref d, new IComporatorLess());
            Console.WriteLine(a + " " + b + " " + c);

            Tasks.PrintNumbers(456);
            Console.WriteLine(Tasks.AllDifferent(new int[] { 1, 1, 1 }));
            Console.WriteLine(Tasks.CountRepeated(101));
            Console.ReadKey();

        }
    }
}
