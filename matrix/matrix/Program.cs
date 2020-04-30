using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {

        static int FiveMaxEl(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i != 5; ++i)
            {
                for (int j = 0; j != arr.Length; ++j)
                {
                    if (max < arr[j])
                    {
                        max = arr[j];
                    }
                }
            }
            return max;
        }

        static int[] IntersectionMatr(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(arr, 0);
            arr2.CopyTo(arr, arr1.Length);
            return arr;

        }

        static int[] MatrSort(int[] arr, int[] arr2)
        {
            int[] res = IntersectionMatr(arr, arr2);
            Array.Sort(res);
            return res;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
