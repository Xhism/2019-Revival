using System;

namespace TimeIn15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 15;

            if(minutes >= 60)
            {
                minutes -= 60;
                hours += 1;
            }

            Console.WriteLine($"{hours % 24}:{minutes:D2}");
        }
    }
}
