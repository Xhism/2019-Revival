using System;

namespace RadToDeg
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;

            Console.WriteLine("{0:0}", deg);
        }
    }
}
