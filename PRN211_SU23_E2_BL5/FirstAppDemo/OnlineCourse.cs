using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{
    public class OnlineCourse : Courses
    {
        public string urlMeet { get; set; }

        public OnlineCourse() { }

        public OnlineCourse(int id, string name, string code, string urlMeet) : base(id, name, code)
        {
            this.urlMeet = urlMeet;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Enter URL for online meeting: ");
            urlMeet = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"URL for online meeting: {urlMeet}");
        }
    }
}
