namespace FirstAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Console.WriteLine("Nhap 3 so nguyen:");
               int a = int.Parse(Console.ReadLine());
               int b = int.Parse(Console.ReadLine());
               int c = int.Parse(Console.ReadLine());

               if (IsTriangle(a, b, c))
               {
                   Console.WriteLine("Ba so nay la ba canh cua mot tam giac");
               }
               else
               {
                   Console.WriteLine("Ba so nay khong phai ba canh cua mot tam giac");
               }
           }

           static bool IsTriangle(int a, int b, int c)
           {

               return a + b > c && b + c > a && c + a > b;
           */

            /*  Students student = new Students();
            //  student.Input();
              student.Display(); */


            Courses course = new Courses();
            OnlineCourse onlineCourse = new OnlineCourse();

            course.Input();
            Console.WriteLine("\nCourse Information:");
            course.Display();

            onlineCourse.Input();
            Console.WriteLine("\nOnline Course Information:");
            onlineCourse.Display();

            Console.ReadLine();
        }
    }
}
