using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            int cal = int.Parse(Console.ReadLine());

            int totalCalsBurned = walks * minutes * 5;
            int fifty = cal / 2;

            if (totalCalsBurned >= fifty)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalsBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalsBurned}.");
            }
            
        }
    }
}
