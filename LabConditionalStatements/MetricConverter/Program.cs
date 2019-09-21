using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double unit = double.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();

            double result = unit;

            if (convertFrom == "mm")
            {
                if (convertTo == "cm")
                {
                    result = result * 0.1;
                }
                else if (convertTo == "m")
                {
                    result = result * 0.001;
                }
            }
            else if (convertFrom == "cm")
            {
                if (convertTo == "mm")
                {
                    result = result * 10;
                }
                else if (convertTo == "m")
                {
                    result = result * 0.01;
                }
            }
            else if (convertFrom == "m")
            {
                if (convertTo == "mm")
                {
                    result = result * 1000;
                }
                else if (convertTo == "cm")
                {
                    result = result * 100;
                }
            }

            Console.WriteLine($"{result:F3}");
        }
    }
}
