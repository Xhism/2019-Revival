using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneySaved = double.Parse(Console.ReadLine());
            string spendOrSave = "";
            double moneyModifier = 0.0;
            int daysCounter = 0;
            int spendOnlyCounter = 0;
            bool hasSpentFiveDays = false;

            while(moneyNeeded > moneySaved)
            {
                spendOrSave = Console.ReadLine();
                moneyModifier = double.Parse(Console.ReadLine());
                daysCounter++;

                if(spendOrSave == "spend")
                {
                    moneySaved -= moneyModifier;
                    if(moneySaved < 0)
                    {
                        moneySaved = 0;
                    }
                    spendOnlyCounter++;
                    if (spendOnlyCounter == 5)
                    {
                        hasSpentFiveDays = true;
                        break;
                    }
                }

                else if(spendOrSave == "save")
                {
                    moneySaved += moneyModifier;
                    spendOnlyCounter = 0;
                }
            }

            if(hasSpentFiveDays == true)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }

            if(moneySaved >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
