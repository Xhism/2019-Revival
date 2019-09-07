using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double centimeter = inch * 2.54;
            Console.WriteLine(String.Format("{0:0.00}", centimeter));
        }
    }
}
