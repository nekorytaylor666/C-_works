using System;


namespace Notebook
{
    public partial class Notebook
    {
         public void PrintMark()
         {
            Console.WriteLine($"This is a {this.GetMark()}");
         }
    }
}