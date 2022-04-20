using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string number = Console.ReadLine();
            string pass = Console.ReadLine();

            while (pass != number)
            {
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
