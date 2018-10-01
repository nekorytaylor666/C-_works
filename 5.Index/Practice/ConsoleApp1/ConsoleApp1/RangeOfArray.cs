using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RangeOfArray
    {
        private int[] array;
        public int FirstIndex { get; private set; }
        Random random = new Random();
        public int Size { get; private set; }

        public RangeOfArray(int firstIndex, int size)
        {
            FirstIndex = firstIndex;

            Size = size;

            array = new int[Size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }
        }

        public int this[int index]
        {
            get
            {
                if ((index - FirstIndex)<Size)
                {
                    return array[index - FirstIndex];
                }
                else
                {
                    return array[Size-1];
                }
            }
            set
            {
                if ((index - FirstIndex) < Size)
                {
                    array[index - FirstIndex] = value;
                }
                else
                {
                    array[FirstIndex + Size - 1] = value;
                }
            }
        }
    }
}
