using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double shnaps = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double shnapsPrice = whiskeyPrice / 2;
            double winePrice = shnapsPrice * 6 / 10;
            double beerPrice = shnapsPrice * 2 / 10;

            double moneyNeeded = whiskey * whiskeyPrice + beer * beerPrice + shnaps * shnapsPrice + wine * winePrice;

            Console.WriteLine("{0:0.00}", moneyNeeded);
        }
    }
}
