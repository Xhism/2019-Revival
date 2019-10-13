using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowerPrice = 0;

            if (flowerType == "Roses")
            {
                if (flowerCount > 80)
                {
                    flowerPrice = 0.9 * 5 * flowerCount;
                }
                else
                {
                    flowerPrice = 5 * flowerCount;
                }
            }
            else if (flowerType == "Dahlias")
            {
                if (flowerCount > 90)
                {
                    flowerPrice = 0.85 * 3.8 * flowerCount;
                }
                else
                {
                    flowerPrice = 3.8 * flowerCount;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (flowerCount > 80)
                {
                    flowerPrice = 0.85 * 2.8 * flowerCount;
                }
                else
                {
                    flowerPrice = 2.8 * flowerCount;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (flowerCount < 120)
                {
                    flowerPrice = 1.15 * 3 * flowerCount;
                }
                else
                {
                    flowerPrice = 3 * flowerCount;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (flowerCount < 80)
                {
                    flowerPrice = 1.2 * 2.5 * flowerCount;
                }
                else
                {
                    flowerPrice = 2.5 * flowerCount;
                }
            }

            if (budget >= flowerPrice)
            {
                double amountLeft = budget - flowerPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {amountLeft:F2} leva left.");
            }
            else
            {
                double insufficientAmount = flowerPrice - budget;
                Console.WriteLine($"Not enough money, you need {insufficientAmount:F2} leva more.");
            }
        }
    }
}
