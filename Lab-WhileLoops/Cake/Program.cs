using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLeft = cakeWidth * cakeLength;
            string input = "";

            while(cakeLeft > 0)
            {
                input = Console.ReadLine();
                if(input == "STOP")
                {
                    Console.WriteLine($"{cakeLeft} pieces are left.");
                    break;
                }
                else
                {
                    cakeLeft -= int.Parse(input);
                }
            }

            if (cakeLeft < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeLeft)} pieces more.");
            }
        }
    }
}
