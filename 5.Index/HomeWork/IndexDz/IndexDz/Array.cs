using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexDz
{
    class Array
    {
        private int[] array;
        private Random random;

        public Array(int size)
        {
            random = new Random();
            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10);
            }
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = (int)Math.Pow(value,2); }
        }
    }
}
