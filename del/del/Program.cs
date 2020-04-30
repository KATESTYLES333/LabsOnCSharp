using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del
{
    public class Test 
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            Console.WriteLine(Test.sumAllOf(arr, new Test.BinaryPred(Test.sum)));
            Console.ReadLine();
        }
    }
}
