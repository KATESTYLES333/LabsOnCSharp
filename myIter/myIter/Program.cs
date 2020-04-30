
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myIter
{
    class MyIterator : IEnumerator<int>
    {
        private int[] data;
        private int current = 1;

        public int Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public bool HasNext()
        {
            return current < data.Length;
        }

        public int GetNext()
        {
            ++current;
            return data[current];
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
