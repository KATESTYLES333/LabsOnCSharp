using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegate
{
    public enum Functions
    {
        mul, sum, sub, div
    }

    public class Algoritm
    {
        public delegate int BinaryOperation(int a, int b);
        public static int Accumulate(int [] arr, int first, int last, BinaryOperation op, int result)
        {
            for(;first != last; ++first)
            {
                result = op(result, arr[first]);
            }
            return result;
        }
        public static BinaryOperation Factory(Functions choice)
        {
            switch(choice)
            {
            case Functions.mul: return (int a, int b) => a*b; ;
            case Functions.sum: return (int a, int b) => a+b;
            case Functions.sub: return (int a, int b) => a-b;
            case Functions.div: return (int a, int b) => a/b;
            default: return null;
            }
        }

        public delegate bool UnaryPridicate(int a);

        public delegate void StringPredicate();

        public static bool AllOf(int [] arr, int first, int last, UnaryPridicate op)
        {
            for (; first != last; ++first)
            {
                if(!op(arr[first]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Algoritm.BinaryOperation Bin = Algoritm.Factory(Functions.div);
            Console.WriteLine(Bin(4, 2));
            Console.ReadLine();
        }
    }
}
