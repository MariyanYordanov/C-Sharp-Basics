using System;

namespace FluelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFluel = Console.ReadLine();
            int litters = int.Parse(Console.ReadLine());

            if ((typeFluel == "Diesel") || (typeFluel == "Gasoline") || (typeFluel == "Gas"))
            {
                if (litters >= 25)
                {
                    Console.WriteLine($"You have enough {typeFluel.ToLower()}.");
                }
                else if (litters < 25)
                {
                    Console.WriteLine($"Fill your tank with {typeFluel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }

        }
    }
}
