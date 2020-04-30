using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using someNewProj;

namespace someProj
{
    public interface X
    {
        int V1 { get; set; }
        int V { get; set; }
    }
    class A:X
    {
        private int v;
        public int V
        {
            get
            {
                return v;
            }
            set
            {
                v = value;
            }
        }

        public int V1 { get; set; }
    }

    class B:X
    {
        public int a;

        public int V1 { get; set; }
        public int V { get; set; }
    }

    class C:X
    {
        public int a;

        int X.V1 { get; set; }
        int X.V { get; set; }
    }


    class Program
    {
        public static X getSomething(string choice)
        {
            switch (choice)
            {
                case "A": return new A();
                case "B": return new B();
                default: return new C();
            }
        }
        static void Main(string[] args)
        {
            MyLib myLib = new MyLib();

            X temp = getSomething("A");
            temp.V = 4;
            Console.WriteLine(temp.GetType().ToString());
            Console.ReadLine();

        }
    }
}
