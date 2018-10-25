using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractice
{
    class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public double GetAvgGrade()
        {
            return Grades.Average();
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }

        public int this[int index]
        {
            get { return Grades[index]; }
            set { Grades[index] = value; }
        }
    }
}
