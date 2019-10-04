using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string weekday = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0;

            if(weekday == "Monday" || weekday == "Tuesday" || weekday == "Wednesday" || weekday == "Thursday" || weekday == "Friday")
            {
                if (fruit == "banana")
                {
                    price = count * 2.5;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "apple")
                {
                    price = count * 1.2;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "orange")
                {
                    price = count * 0.85;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = count * 1.45;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "kiwi")
                {
                    price = count * 2.7;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "pineapple")
                {
                    price = count * 5.5;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapes")
                {
                    price = count * 3.85;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(weekday == "Saturday" || weekday == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = count * 2.7;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "apple")
                {
                    price = count * 1.25;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "orange")
                {
                    price = count * 0.9;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = count * 1.6;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "kiwi")
                {
                    price = count * 3;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "pineapple")
                {
                    price = count * 5.6;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapes")
                {
                    price = count * 4.2;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
