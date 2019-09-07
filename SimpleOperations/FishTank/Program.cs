using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentageUsed = double.Parse(Console.ReadLine());
            double size = length * width * height;
            double sizeInLiters = size / 1000;
            double litersNeeded = sizeInLiters * (1 - percentageUsed / 100);
            Console.WriteLine("{0:0.000}", litersNeeded);
        }
    }
}
