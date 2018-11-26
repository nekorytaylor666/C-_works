using System;
using System.Collections.Generic;
using System.Text;

namespace ExamLOl
{
    class ValueContainer
    {
        public int A { get; set; }

        public int B { get; set; }
        
        public void Print()
        {
            Console.WriteLine($"Значение A = {A}");
            Console.WriteLine($"Значение B = {B}");
        }

        public int Bigger()
        {
            return A > B ? A : B;
        }

        public int Sum()
        {
            return A + B;
        }
    }
}
