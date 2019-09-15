using System;

namespace IdentifyAnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();

            if (input == "dog")
            {
                Console.WriteLine("mammal");
            }

            else if (input == "crocodile" || input == "snake" || input == "tortoise")
            {
                Console.WriteLine("reptile");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
