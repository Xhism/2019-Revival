using System;

namespace ArchitectProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int hours = count * 3;
            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, hours, count);
        }
    }
}
