using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            if (age > 15 && age < 20)
            {
                Console.WriteLine("Du får delta i tävlingen!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du får inte delta i tävlingen.");
            }

        }

    }
}