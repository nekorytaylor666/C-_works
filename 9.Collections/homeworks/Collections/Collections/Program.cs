using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Создать коллекцию List<int>.Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции.Вывести на экран сумму элементов на четных позичиях.

namespace Collections
{
    class Program
    {
        static List<int> numbers = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
        };

        static int GetSecondMax()
        {
            int max2 = 0;

            int max = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (max < numbers[i])
                {
                    max2 = max;
                    max = numbers[i];
                }
            }
            
            return max2;
        }

        static int GetEvenSum()
        {
            int sum=0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(i%2==0)
                    sum += numbers[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {

            
            Console.WriteLine(GetSecondMax());

            Console.WriteLine(GetEvenSum());

        }
    }
}
