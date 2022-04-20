using System;

namespace _06._Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int pontsMax = 0;
            string winner = string.Empty;

            while (name != "Stop")
            {
                int points = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    int playerDigit = int.Parse(Console.ReadLine());
                    char digit = name[i];
                    if (digit == playerDigit)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }
                
                if (points > pontsMax)
                {
                    pontsMax = points;
                    winner = name;
                }
                if (points == pontsMax)
                {
                    winner = name;
                }
                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {pontsMax} points!");
        }
    }
}
