using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.5 * count);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.8 * count);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.2 * count);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * count);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.6 * count);
                }
            }

            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.4 * count);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * count);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * count);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.3 * count);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.5 * count);
                }
            }

            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * count);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * count);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.1 * count);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * count);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * count);
                }
            }
        }
    }
}
