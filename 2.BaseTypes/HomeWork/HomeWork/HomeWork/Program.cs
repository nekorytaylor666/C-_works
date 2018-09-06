using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

namespace HomeWork
{
    class Program
    {
        static void Task1()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            Console.WriteLine("Задание номер один:\n\nВведите первое число");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1: " + firstNumber + "  2: " + secondNumber + "  3: " + thirdNumber);

            Console.ReadLine();
        }

        static void Task2()
        {
            Console.WriteLine("1 число: 5\n2 число: 10\n3 число: 21");
            Console.ReadLine();
        }
        //3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        static int Task3(double ValueInSM)
        {
            return (int)ValueInSM / 100;
        }

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
        static int Task5A(int value)
        {
            value /= 10;
            int desyatki = value % 10;
            return desyatki;
        }
        static int Task5B(int value)
        {
            int edinici = value % 10;
            return edinici;
        }

        static int Task5C(int value)
        {
            int sum = 0;
            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }
            return sum;
        }

        static int Task5D(int value)
        {
            int result = 0;
            while (value != 0)
            {
                result *= value % 10;
                value /= 10;
            }
            return result;
        }

//        6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
//a.А или В; 
//b.А и В; 
//c.В или С.
        static void Task6() {
            bool a = true;
            bool b = false;
            bool c = false;
            bool result = a || b;
            Console.WriteLine($"A or B = {result}");
            result = a && b;
            Console.WriteLine($"A and B = {result}");
            result = b || c;
            Console.WriteLine($"B or C = {result}");
        }

        static void Task7(int radius, int side)
        {
            int areaSquare = (int)Math.Pow(side, 2);
            double areaCircle = Math.PI * Math.Pow(radius, 2);
            bool result = areaSquare > areaCircle;
            Console.WriteLine($"Площадь квадрата ({areaSquare}) больше площади круга ({areaCircle})?\n {result}");
        }

        static void Task8(double weight1, double volume1, double weight2, double volume2)
        {
            double density1 = volume1 / weight1;
            double density2 = volume2 / weight2;
            Console.WriteLine($"Плотность первой фигуры({density1}) больше плотности второй фигуры ({density2}) ? {density1 > density2}");
        }

        static void Task9(double resistance1, double voltage1, double resistance2, double voltage2)
        {
            double amperage1 = voltage1 / resistance1;
            double amperage2 = voltage2 / resistance2;
            Console.WriteLine($"Сила тока первой система({amperage1}) больше силы тока второй система ({amperage2}) ? {amperage1 > amperage2}");

        }
        //a.все целые числа от 20 до 35;
        static void Task10A()
        {
            for (int i = 20; i < 35; i++){
                Console.WriteLine(i);
            }
        }
        static void Task10B(int b)
        {
            if (b > 10)
            {
                for (int i = 10; i < b; i++)
                {
                    Console.WriteLine($"Квадрат {i} = {Math.Pow(i, 2)}");
                }
            }
        }

        static void Task10C( int a)
        {
            if (a < 50)
            {
                for (int i = a; i < 50; i++)
                {
                    Console.WriteLine($"Квадрат {i} = {Math.Pow(i, 3)}");
                }
            }
        }

        static void Task10D(int a, int b)
        {
            if (b > a)
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
