using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[5];
            for(int i=0; i < notebooks.Length; i++)
            {
                notebooks[i] = new Notebook();
            }
            notebooks[1].SetMark("high hopes");
            Console.WriteLine(notebooks[1].GetMark());
            Console.Read();
        }
    }
}
