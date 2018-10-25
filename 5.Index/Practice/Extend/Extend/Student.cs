using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    public sealed class Student : Person
    {
        public int Stage { get; set; }

        public Student(int id, string fullName, DateTime birthDate, int stage) : base(id, fullName, birthDate)
        {
            Stage = stage;
        }

        public string GroupName { get; set; }

        public double AverageMark { get; set; }

        public new string ReturnFullInfo()
        {
            return $"{FullName}, {BirthDate}";
        }

        public override int ReturnId()
        {
            return Id;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
