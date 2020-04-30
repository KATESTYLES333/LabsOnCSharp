using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class MySorts
    {
        public static void Swap<T>(ref T value, ref T value1)
        {
            T temp = value;
            value = value1;
            value1 = temp;
        }

        public static int BinarySearch(int[] arr, int key)
        {
            int start = 0;
            int end = arr.Length - 1;
            int middle = (start + end) / 2;

            while (start < end)
            {
                middle = (start + end) / 2;
                if (arr[middle] == key)
                {
                    return middle + 1;
                }
                else if (arr[middle] > key)
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }

            return -1;
        }

        public static void InsertSort(int[] arr)
        {
            for (int i = 0; i != arr.Length - 1; ++i)
            {
                for (int j = i + 1; j > 0; --j)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap<int>(ref arr[j - 1], ref arr[j]);
                    }
                }
            }
        }

        public static void SelectSort(int[] arr)
        {
            for (int i = 0; i != arr.Length; ++i)
            {
                for (int j = 2; arr[j] != arr[j + 1]; --j)
                {
                    Swap<int>(ref arr[j], ref arr[j + 1]);
                }
            }
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 3, 9, 0, 2 };
            Console.WriteLine(MySorts.BinarySearch(arr, 13));
            Console.ReadLine();
        }
    }
}
