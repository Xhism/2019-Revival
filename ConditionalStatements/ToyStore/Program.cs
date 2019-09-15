using System;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            int toysTotal = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            double salesSum = puzzleCount * 2.6 + dollCount * 3 + bearCount * 4.1 + minionCount * 8.2 + truckCount * 2;
            
            if(toysTotal >= 50)
            {
                salesSum = salesSum * 3 / 4;
            }

            double totalProfit = salesSum * 9 / 10;

            if(totalProfit >= vacationPrice)
            {
                double moneyOver = totalProfit - vacationPrice;
                Console.WriteLine($"Yes! {moneyOver:F2} lv left.");
            }

            else
            {
                double moneyNeeded = vacationPrice - totalProfit;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
