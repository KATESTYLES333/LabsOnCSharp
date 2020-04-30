using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTest
{
    class Test
    {
        public bool IsPalindrome(string message)
        {
            string value = new string(message.ToCharArray().Reverse().ToArray());
            return message.Equals(value);
        }

		

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Test().IsPalindrome("123321"));
            Console.ReadLine();
        }
    }
}
