using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryF
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string [] arr = { "appropriate", "accomplishment", "arrange"};
            Console.WriteLine(arr[new Random().Next(0, arr.Length)]);
            Console.ReadLine();
        }
    }
}
