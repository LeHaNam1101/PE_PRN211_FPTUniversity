using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{
    public class Students
    {
        private string name;
        private int age;
        private double grade;

        public void Input()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Grade: ");
            grade = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Students: {name} - {age} years old: {grade}");
        }

    }
}
