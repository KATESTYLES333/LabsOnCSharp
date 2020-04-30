using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    public class del<RetType> where RetType : new()
    {
        private List<Func<RetType>> methods = new List<Func<RetType>>();

        public del(Func<RetType> fMethod)
        {
            methods.Add(fMethod);
        }

        public void AddMethod(Func<RetType> method)
        {
            methods.Add(method);
        }

        public RetType Invoke()
        {
            RetType res = new RetType();

            foreach (var method in methods)
            {
                res = method.Invoke();
            }

            return res;
        }

        public static del<RetType> operator +(del<RetType> del, Func<RetType> method)
        {
            del.AddMethod(method);
            return del;
        }
    }


    class Program
    {
        static object TestMethod()
        {
            return 10;
        }

        static object TestMethod2()
        {
            return 11;
        }

        static void Main(string[] args)
        {
            del<object> del = new del<object>(TestMethod);
            del += TestMethod2;
            Console.WriteLine(del.Invoke());

            Console.ReadLine();
        }
    }
}
