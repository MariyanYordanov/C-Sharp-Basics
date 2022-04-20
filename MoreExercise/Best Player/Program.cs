using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            
            int max = 0;
            bool hattrick = false;
            bool best = false;
            string bestPlayer = " ";
            while (player != "END")
            {
                int numGoals = int.Parse(Console.ReadLine());
                if (numGoals > max)
                {
                    best = true;
                    bestPlayer = player;
                    max = numGoals; 
                }

                if (numGoals >= 3)
                {
                    hattrick = true;
                }

                if (numGoals >= 10)
                {
                    break;
                }
                
                player = Console.ReadLine();
            }
            if (best)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
            }
            if (hattrick)
            {
                Console.WriteLine($"He has scored {max} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {max} goals.");
            }
        }
    }
}
