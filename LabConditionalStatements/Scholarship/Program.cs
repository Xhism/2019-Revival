using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double familyIncome = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            if(averageGrade < 4.5 || (averageGrade < 5.5 && familyIncome >= minimalWage))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                double socialScholarship = minimalWage * 0.35;
                double excellenceScholarship = averageGrade * 25;

                if(averageGrade < 5.5 || excellenceScholarship < socialScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {(int) socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {(int) excellenceScholarship} BGN");
                }
            }
        }
    }
}
