using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixes
{
    class Matrix
    {
        int[,] matrix;

        public int Columns
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public int Rows
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int this[int row, int column]
        {
            get
            {
                return matrix[row, column];
            }
            set
            {
                matrix[row, column] = value;
            }
        }

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
    }

    class Program
    {
        public static int TwoSameInMatrix(Matrix arr)
        {
            int counter = 0;
            for(int i = 0; i != arr.Columns; ++i)
            {
                for(int j =i+1; j != arr.Rows; ++j)
                {
                    if(arr[i,j] == arr[i+1,j])
                    {
                        ++counter;
                    }
                }
            }
            return counter;
        }

        public static void SwapColumns(Matrix arr)
        {
            for(int i = 0; i != arr.Columns; ++i)
            {
                int MaxIndex = i;
                for (int j = i + 1; j != arr.Columns; ++j)
                {
                    if (arr[0, j] < arr[0, MaxIndex])
                    {
                        MaxIndex = j;
                    }
                }
            }
        }


        public static int[] DeleteDublicateElem(List<List<int>> arr)
        {
            foreach (var item in arr)
            {
                item.Sort();
            }
            
        }

        public static int[] DeleteDublicateElem2(int[] arr)
        {
            return arr.Distinct().ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 2, 3, 4, 5, 3 };
            arr = DeleteDublicateElem(arr);
            foreach ( int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
