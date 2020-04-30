using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksB
{

    class Test : ICloneable
    {
        public int value;
        public object Clone()
        {
            return this;
        }

    }
    


    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.value = 10;
            Test t2 = (Test)t1.Clone();
            Console.WriteLine(t2.value);
            Console.ReadLine();
        }
    }
}
