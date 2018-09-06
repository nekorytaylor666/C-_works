using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//вычисления значения функции y = 7x^2-3x+4  при любом значении x;
//2.	Дан радиус окружности.Найти длину окружности и площадь круга.
/*	Дано расстояние в сантиметрах.Найти число полных метров в нем.*/
/*.	С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период?*/
//4.	Дано двузначное число.Найти:

namespace Task1_
{
    class Program
    {
        const double PI_NUMBER = 3.14;
        static int FirstTask(int x)
        {
            return 7 * (int)Math.Pow(x,2) - 3 * x + 4; 
        }

        static double SecondTaskCircuitLength(int radius)
        {

            return 2 * PI_NUMBER * radius;
        }

        static double SecondTaskAreaCircle(int radius)
        {
            return PI_NUMBER * Math.Pow(radius, 2);
        }

        static int ThirdTask(double ValueInSM)
        {
            return (int)ValueInSM / 100;
        }

        static int ThirdTaskATask(int CountDays)
        {
            return (int)CountDays / 7;
        }

        //a.число десятков в нем;
        //b.число единиц в нем;
        //c.сумму его цифр;
        //d.произведение его цифр

        static int getCountsOfDigits(long number)
        {
            int count = (number == 0) ? 1 : 0;
            while (number != 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        static int FourthTask_A(int value)
        {
            value /= 10;
            int desyatki = value % 10;
            return desyatki;
        }
        static int FourthTask_B(int value)
        {
            int edinici = value % 10;
            return edinici;
        }

        static int FourthTask_C(int value)
        {
            int sum = 0;
            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }
            return sum;
        }

        static int FourthTask_D(int value)
        {
            int result = 0;
            while (value != 0)
            {
                result *= value % 10;
                value /= 10;
            }
            return result;
        }

        static int GetSotki(int value)
        {
            return value % 100 / 10;
        }
            //5.	В трехзначном числе x зачеркнули его вторую цифру.
            //Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.
        static int FifthTask(int value)
        {
            int edinici = FourthTask_B(value);
            int sotki = GetSotki(value);
            int desyatki = FourthTask_A(value);

            return 100 * sotki + 10 * edinici + desyatki;
        }
          
        static void SixTask(bool x, bool y)
        {
            bool result = !x && !y;
            Console.WriteLine($"not X and not Y= {result}");
            result = x || (!x && y);
            Console.WriteLine($"X or (not X and Y= {result}");
            result = (!x && y) && y;
            Console.WriteLine($"(not X and Y) or Y = {result}");
        }
        static void Main(string[] args)
        {
            
            Console.Read();
        }
    }
}
