using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int bookAmount = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isBookFound = false;

            string nextBook = Console.ReadLine();

            while(counter < bookAmount)
            {
                if(nextBook == favouriteBook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBook = Console.ReadLine();
            }

            if(isBookFound == true)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookAmount} books.");
            }
        }
    }
}
