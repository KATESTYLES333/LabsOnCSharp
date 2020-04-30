using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram
{
    public interface IFigure
    {
        int square { get; set; }
        int perimentr { get; set; }
        int color { get; set; }
    }

    class Rectangle : IFigure
    {
        public int square { get; set; }
        public int perimentr { get; set; }
        public int color { get; set; }
    }

    class Triangle : IFigure
    {
        public int square { get; set; }
        public int perimentr { get; set; }
        public int color { get; set; }
    }

    class Sphere : IFigure
    {
        public int square { get; set; }
        public int perimentr { get; set; }
        public int color { get; set; }
    }

    class Base
    {
        virtual public int f()
        {
            Console.WriteLine("Vantuz daun");
            return 0;
        }

    }

    class Derrived : Base
    {
        override public int f()
        {
            Console.WriteLine("Vantuz pi");
            return 0;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
