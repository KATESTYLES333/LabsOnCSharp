using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    class SquareMatrix<T>
    {
        private T[,] data;
        public int Size { get; private set; }
        private int side;

        public SquareMatrix(ICollection<T> collection)
        {
            Size = collection.Count;
            side = (int)Math.Sqrt(Size);
            data = new T[side, side];
            int j = 0;
            foreach(var i in collection)
            {
                this.SetElementByRow(i, j++);
            }
        }

        public T this[int rowIndex, int columnIndex]
        {
            get
            {
                return data[rowIndex, columnIndex];
            }
            set
            {
                data[rowIndex, columnIndex] = value;
            }
        }

        public T this[int position]
        {
            get
            {
                return this.GetElement(position);
            }
            set
            {
                this.SetElementByColumn(value, position);
            }
        }

        public void SwapColumns(int fColumnIndex, int sColumnIndex)
        {
            for(int i = 0; i != side; ++i)
            {
                Util.Swap(ref data[i, fColumnIndex], ref data[i, sColumnIndex]);
            }
        }

        public void SetElementByColumn(T value, int position)
        {
            data[position / side, position % side] = value;
        }

        public void SetElementByRow(T value, int position)
        {
            data [position % side, position / side] = value;
        }

        public T GetElement(int position)
        {
            return data[position / side, position % side];
        }

        public SquareMatrix()
        {
            data = new T[1, 1];
        }

        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();
            for(int i = 0; i != side; ++i)
            {
                for(int j = 0; j != side; ++j)
                {
                    resultBuilder.Append(data[i, j]);
                    resultBuilder.Append(" ");
                }
                  resultBuilder.Append("\n");
            }
            return resultBuilder.ToString();
        }
    }
}
