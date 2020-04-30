using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newDelegats
{
    public class Test
    {
        public delegate void Del();
        public delegate bool UnaryPredicate(int a);
        public delegate int UnaryPred(int a);
        public static void printPhrase()
        {
            Console.WriteLine("Heeeell yeah");
        }

        public static void f(Del d)
        {
            d();
        }

        public static int FindIf(int []arr, int first, int last, UnaryPredicate op)
        {
            for(;first != last; ++first)
            {
                if(op(arr[first]))
                {
                    return first;
                }
            }
            return -1;
        }

        public static int FindCounerIf(int[] arr, int first, int last, UnaryPredicate op)
        {
            int counter = 0;
            for (; first != last; ++first)
            {
                if (op(arr[first]))
                {
                    ++counter;
                }
            }
            return counter;
        }

        public static int[] Map(int[] arr, UnaryPred op)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i != arr.Length; ++i)
            {
                newArr[i] = op(arr[i]);
            }
            return newArr;
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            Test.f(Test.printPhrase);

            Console.ReadLine();
        }
    }
}
