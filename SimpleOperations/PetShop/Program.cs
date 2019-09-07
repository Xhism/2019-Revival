using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int restCount = int.Parse(Console.ReadLine());
            double foodPrice = dogCount * 2.5 + restCount * 4;
            Console.WriteLine("{0:0.00} lv.", foodPrice);
        }
    }
}
