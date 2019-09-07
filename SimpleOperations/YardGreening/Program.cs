using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double overallPrice = area * 7.61;
            double discount = overallPrice * 0.18;
            double finalPrice = overallPrice - discount;
            Console.WriteLine("The final price is: {0:0.00} lv.", finalPrice);
            Console.WriteLine("The discount is: {0:0.00} lv.", discount);
        }
    }
}
