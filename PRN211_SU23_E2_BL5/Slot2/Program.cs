namespace Slot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Add new Course  (C) or  OnlineCourse (O)");
                Console.WriteLine("2: Remove 1 Course");
                Console.WriteLine("3: List all Course");
                Console.WriteLine("0: Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Add Course or OnlineCourse? (C/O)");
                        string courseType = Console.ReadLine();

                        if (courseType.ToUpper() == "C")
                        {
                            courses.Add(new Course());
                        }
                        else if (courseType.ToUpper() == "O")
                        {
                            courses.Add(new OnlineCourse());
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter ID  remove:");
                        int courseId = Convert.ToInt32(Console.ReadLine());

                        foreach (var course in courses)
                        {
                            if (course.Id == courseId)
                            {
                                courses.Remove(course);
                                break;
                            }
                        }
                        break;

                    case "3":
                        foreach (var course in courses)
                        {
                            Console.WriteLine(course);
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Error!Vui long chon lai");
                        break;
                }
            }
        }
    }
 }