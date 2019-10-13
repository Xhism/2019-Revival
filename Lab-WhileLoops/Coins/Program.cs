using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputMoney = double.Parse(Console.ReadLine());
            int moneyToInt = (int) (inputMoney * 100);
            int coinCount = 0;

            while(moneyToInt > 0)
            {
                if (moneyToInt >= 200)
                {
                    coinCount += moneyToInt / 200;
                    moneyToInt %= 200;
                }
                else if (moneyToInt >= 100)
                {
                    coinCount += moneyToInt / 100;
                    moneyToInt %= 100;
                }
                else if (moneyToInt >= 50)
                {
                    coinCount += moneyToInt / 50;
                    moneyToInt %= 50;
                }
                else if (moneyToInt >= 20)
                {
                    coinCount += moneyToInt / 20;
                    moneyToInt %= 20;
                }
                else if (moneyToInt >= 10)
                {
                    coinCount += moneyToInt / 10;
                    moneyToInt %= 10;
                }
                else if (moneyToInt >= 5)
                {
                    coinCount += moneyToInt / 5;
                    moneyToInt %= 5;
                }
                else if (moneyToInt >= 2)
                {
                    coinCount += moneyToInt / 2;
                    moneyToInt %= 2;
                }
                else if (moneyToInt >= 1)
                {
                    coinCount++;
                    moneyToInt--;
                }
            }

            Console.WriteLine(coinCount);
        }
    }
}
