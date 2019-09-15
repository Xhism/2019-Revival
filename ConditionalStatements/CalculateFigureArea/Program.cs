using System;

namespace CalculateFigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            String figureType = Console.ReadLine();
            double area = 0;

            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = side * side;
            }

            else if (figureType == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                area = sideA * sideB;
            }

            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = radius * radius * Math.PI;
            }

            else if (figureType == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                area = sideA * sideB / 2;
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
