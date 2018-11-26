using System;

namespace ExamLOl
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueContainer value = new ValueContainer();
            value.A = 5;
            value.B = 6;

            value.Print();
            Console.WriteLine($"Сумма переменных = {value.Sum()}");
            Console.WriteLine($"Большее из них = {value.Bigger()}");
        }
    }
}
