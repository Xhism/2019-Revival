using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            string inputLine = "";
            while (totalSteps < 10000)
            {
                inputLine = Console.ReadLine();
                if(inputLine == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    if(totalSteps < 10000)
                    {
                        Console.WriteLine($"{10000-totalSteps} more steps to reach goal.");
                    }
                    break;
                }
                else
                {
                    totalSteps += int.Parse(inputLine);
                }

            }
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
