using System;

namespace SecretPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();

            if (input == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
