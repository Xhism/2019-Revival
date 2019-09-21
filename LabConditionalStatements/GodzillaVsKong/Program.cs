using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double startingBudget = double.Parse(Console.ReadLine());
            int idleCount = int.Parse(Console.ReadLine());
            double pricePerIdle = double.Parse(Console.ReadLine());

            double actualBudget = startingBudget * 0.9;
            double idleTotalPrice = idleCount * pricePerIdle;

            if (idleCount > 150)
            {
                idleTotalPrice = idleTotalPrice * 0.9;
            }

            if(actualBudget < idleTotalPrice)
            {
                double insufficientMoney = idleTotalPrice - actualBudget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {insufficientMoney:F2} leva more.");
            }
            else
            {
                double extraMoney = actualBudget - idleTotalPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {extraMoney:F2} leva left.");
            }
        }
    }
}
