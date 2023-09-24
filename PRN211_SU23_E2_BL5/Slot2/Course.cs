using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2
{
    public class Course
    {
        private static int nextId = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Course()
        {
            Id = nextId;
            nextId++;
            Input();
        }

        public Course(string name, string code)
        {
            Id = nextId;
            nextId++;
            Name = name;
            Code = code;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter Name Course:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Code Course:");
            Code = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name Course: {Name}, Code Course: {Code}";
        }
    }
}
