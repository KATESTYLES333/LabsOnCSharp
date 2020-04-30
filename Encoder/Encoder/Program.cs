using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            
            //foreach(int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> list = new List<int>(arr);

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            int[] matr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            SquareMatrix<int> matrix = new SquareMatrix<int>(matr);
            Console.WriteLine(matrix.ToString());
            Console.ReadLine();

        }
    }
}
