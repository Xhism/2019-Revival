using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tableCount = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double clothArea = tableCount * (tableLength + 0.6) * (tableWidth + 0.6);
            double squaresArea = tableCount * tableLength / 2 * tableLength / 2;

            double usd = clothArea * 7 + squaresArea * 9;
            double bgn = usd * 1.85;

            Console.WriteLine("{0:0.00} USD", usd);
            Console.WriteLine("{0:0.00} BGN", bgn);
        }
    }
}
