using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double totalSeconds = distance * secondsPerMeter;

            if(distance >= 15)
            {
                totalSeconds += 12.5 * ((int) distance / 15);
            }

            if(totalSeconds < currentRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:F2} seconds.");
            }
            else
            {
                double secondsSlower = totalSeconds - currentRecord;
                Console.WriteLine($"No, he failed! He was {secondsSlower:F2} seconds slower.");
            }
        }
    }
}
