using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Courses() { }

        public Courses(int id, string name, string code)
        {
            Id = id;
            Name = name;
            Code = code;
        }

        public virtual void Input()
        {
            Console.Write("Enter course ID: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Enter course Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter course Code: ");
            Code = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Code: {Code}");
        }
    }
}

