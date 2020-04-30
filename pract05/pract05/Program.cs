using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract05
{
    class Program
    {
        static int LastDigit(int a)
        {
            return (a >> 1) & 1;
        }

        static bool IsPow(int a)
        {
            return LastDigit(a) == 0;
        }

        static bool BoolLastDigit(int a)
        {
            return !Convert.ToBoolean((a - 1) & 1);
        }

        static int[] Intersection(int[] arr, int[] arr1)
        {
            HashSet<int> firstArr = new HashSet<int>(arr);
            HashSet<int> lastArr = new HashSet<int>(arr1);
            List<int> arrRes = new List<int>();
            foreach (var i in arr)
            {
                if (firstArr.Contains(i))
                {
                    arrRes.Add(i);
                }
            }
            return arrRes.ToArray();
        }

        static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

        static int[] TwoInOne(int[] arr, int[] arr2)
        {
            int[] res = new int[arr.Length + arr2.Length];
            arr.CopyTo(res, 0);
            arr2.CopyTo(res, arr.Length);
			//return res;
			Array.Sort(res);
			return res;
        }


        static int[] DeleteSecEl(int[] arrFIrst, int[] arrSecond)
        {
            int[] result = TwoInOne(arrFIrst, arrSecond).Except(arrSecond).ToArray();
            return result;
        }

        static List<int> SwapElem(int[] arr1)
        {
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();
            List<int> result3 = new List<int>();
            foreach (int item in arr1)
            {
                if (item > 0)
                {
                    result1.Add(item);
                }
                if (item < 0)
                {
                    result2.Add(item);
                }
                else
                {
                    result3.Add(item);
                }
            }
            return result1.Concat(result2).Concat(result3).ToList();
        }

        static int[] RowsIncrease(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int temp = 0;
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        static List<int> MonotoneProgression(int[] arr)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> tempList = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempList.Add(arr[i]);
                }
                else
                {
                    res.Add(tempList);
                    tempList = new List<int>();
                }
            }

            if (res.Count == 0)
            {
                return null;
            }

            List<int> maxLenList = res[0];

            res.ForEach((List<int> item) =>
            {
                if (maxLenList.Count < item.Count)
                {
                    maxLenList = item;
                }
            });

            return maxLenList;
        }


        static void Main(string[] args)
        {
            var r = MonotoneProgression(new int[] { 1, 2, 3, 4, 4, 4, 4, 5, 5, 6, 6, 6, 7, 8, 8 });

            foreach (int item in r)
            {
                Console.WriteLine(r);
            }

            Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
