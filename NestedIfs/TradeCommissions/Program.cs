using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if(sales > 0)
            {
                if (sales <= 500)
                {
                    if (city == "Sofia")
                    {
                        commission = sales / 100 * 5;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales / 100 * 4.5;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales / 100 * 5.5;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (sales <= 1000)
                {
                    if (city == "Sofia")
                    {
                        commission = sales / 100 * 7;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales / 100 * 7.5;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales / 100 * 8;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (sales <= 10000)
                {
                    if (city == "Sofia")
                    {
                        commission = sales / 100 * 8;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales / 100 * 10;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales / 100 * 12;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    if (city == "Sofia")
                    {
                        commission = sales / 100 * 12;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales / 100 * 13;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales / 100 * 14.5;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
