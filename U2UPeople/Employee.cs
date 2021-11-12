using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2UPeople
{
    public class Employee : Person
    {
        public Employee(string name, int age, GenderType gender, string company) : base(name, age, gender)
        {
            Company = company;
        }

        public Employee(string name, int age, string company): base(name, age)
        {
            Company = company;
        }
        public string Company { get; set; }

        public override string GetInfo()
        {
            return $"Name: {Name} - Age: {Age} - Gender: {Gender} - IsRetired?: {IsRetired} - Company: {Company}";
        }
    }
}
