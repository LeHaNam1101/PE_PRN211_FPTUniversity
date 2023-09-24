using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLot2DeMo
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public Person() { }
        public override string ToString()
        {
            return $"Fullname: {FirstName} {LastName}: {Age}";
        }
    }
}
