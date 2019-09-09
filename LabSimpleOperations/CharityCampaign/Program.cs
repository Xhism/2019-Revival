using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int cookCount = int.Parse(Console.ReadLine());
            int cakeCount = int.Parse(Console.ReadLine());
            int waffleCount = int.Parse(Console.ReadLine());
            int pancakeCount = int.Parse(Console.ReadLine());

            double sumPerCook = cakeCount * 45 + waffleCount * 5.80 + pancakeCount * 3.20;
            double sumPerDay = sumPerCook * cookCount;
            double overallSum = sumPerDay * dayCount;
            double sumPostCosts = overallSum - (overallSum / 8);

            Console.WriteLine("{0:0.00}", sumPostCosts);
        }
    }
}
