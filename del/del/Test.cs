using System;

namespace del
{
    public class Test
    {
        public delegate int BinaryPred(int a, int b);

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int sumAllOf(int[] arr, BinaryPred bp)
        {
            int res = 0;
            for (int i = 0; i != arr.Length; ++i)
            {
                res = bp(res, arr[i]);
            }
            return res;
        }
    }
}
