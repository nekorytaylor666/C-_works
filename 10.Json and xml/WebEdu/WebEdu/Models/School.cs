using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchoolApi.Models
{
    [Serializable]
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Language { get; set; }
        public string Principal { get; set; }
        public string PhoneNumber { get; set; }
        private Double averageBall;

        public string AverageBall
        {
            get { return averageBall.ToString(); }
            set {
                averageBall = Double.Parse(value.Replace('.',',')); }
        }
    }
}
