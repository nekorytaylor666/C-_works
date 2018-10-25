using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    public abstract class Person 
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public Person(int id, string fullName, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
        }

        public string ReturnFullInfo()
        {
            return $"{FullName}, {BirthDate}";
        }
        
        public virtual int ReturnId()
        {
            return Id;
        }

        public abstract void ShowInfo();

    }
}
