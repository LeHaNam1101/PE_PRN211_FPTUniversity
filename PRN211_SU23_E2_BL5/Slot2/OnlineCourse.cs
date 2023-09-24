using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2
{
    public class OnlineCourse: Course
    {
        public string UrlMeet { get; set; }

        public OnlineCourse()
        {
            Input();
        }

        public OnlineCourse(string name, string code, string urlMeet) : base(name, code)
        {
            UrlMeet = urlMeet;
        }

        public override void Input()
        {
            base.Input();

            Console.WriteLine("Enter URL Meet:");
            UrlMeet = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $", URL Meet: {UrlMeet}";
        }
    }
}
