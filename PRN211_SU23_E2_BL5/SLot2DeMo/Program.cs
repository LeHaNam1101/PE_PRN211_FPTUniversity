namespace SLot2DeMo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
            new Person { FirstName = "Le", LastName = "Ha Nam", Age = 22 },
            new Person { FirstName = "Nguyen", LastName = "Thi Van", Age = 21 },
            new Person { FirstName = "Lisa", LastName = "Simpson", Age = 19 },
            new Person { FirstName = "Jack", LastName = "Simpson", Age = 16 }
            };
            
            Console.WriteLine("Item in list: {0}", people.Count);
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}