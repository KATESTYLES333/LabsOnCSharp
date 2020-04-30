using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksB
{
    class Tasks
    {
        public static void Task12(ref int x, ref int y, ref int z, ref int k, IComparer comp)
        {
            int[] temp = new int[] { x, y, z, k };
            Array.Sort(temp, comp);
            x = temp[0];
            y = temp[1];
            z = temp[2];
            k = temp[3];
        }

        int ReverseNumber(int a)
        {
            int temp = 0;
            for (; a != 0; a /= 10)
            {
                temp = temp * 10;
                temp = temp + a % 10;
            }
            return temp;
        }

        bool IsPalindrom(int a)
        {
            return ReverseNumber(a) == a;
        }

        int BeforeLastDigit(int a, int n)
        {
            return (int)(a / Math.Pow(10, n)) % 10;
        }

        public static void PrintNumbers(int a)
        {
            for (; a != 0; a /= 10)
            {
                Console.WriteLine(a % 10);
            }
        }

        public static bool AllDifferent(int[] arr)
        {
            for (int i = 0; i != arr.Length; ++i)
            {
                for (int j = i + 1; j != arr.Length; ++j)
                {
                    if (arr[i] == arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int SumOfDigit(int a)
        {
            int temp = 0;
            for (; a != 0; a /= 10)
            {
                temp += a % 10;
            }
            return temp;
        }

        public static int Accumulate(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i != arr.Length; ++i)
            {
                temp += arr[i];
            }
            return temp;
        }

        public static bool AllDiffElemArray(int value)
        {
            for (int i = value; value != 0; i = i / 10)
            {
                for (int j = i; j != 0; j = j / 10)
                {
                    if (i % 10 == j % 10)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int CountRepeated(int a)
        {
            int count = 0;
            for (int i = a; i != 0; i /= 10)
            {
                for (int j = i / 10; j != 0; j /= 10)
                {
                    if (i % 10 == j % 10)
                    {
                        ++count;
                    }
                }
            }
            return count;
        }

        public static bool Is(int a, int n)
        {
            return CountRepeated(a) == n;
        }
    }
}
