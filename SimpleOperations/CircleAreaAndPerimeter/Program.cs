using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = radius * 2 * Math.PI;
            double area = Math.PI * radius * radius;
            Console.WriteLine("{0:0.00}", area);
            Console.WriteLine("{0:0.00}", perimeter);
        }
    }
}
