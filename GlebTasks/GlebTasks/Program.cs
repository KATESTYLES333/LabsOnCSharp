using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlebTasks
{
    public class Gleb
    {
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        public static int LCM(int a, int b)
        {
            int num1;
            int num2;
            if (a > b)
            {
                num1 = a;
                num2 = b;
            }
            else
            {
                num1 = b;
                num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }

            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 13;
            int c = 11;

            int res = Gleb.GCD(a, Gleb.GCD(b, c));
            int result = Gleb.LCM(a, Gleb.LCM(b, c));

            Console.WriteLine(res);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
