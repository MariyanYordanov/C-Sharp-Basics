using System;

namespace _055._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tim = Console.ReadLine();

            double games = double.Parse(Console.ReadLine());
            double points = 0;
            double wins = 0;
            double draw = 0;
            double loses = 0;

            if (games < 1)
            {
                Console.WriteLine($"{tim} hasn't played any games during this season.");
                return;
            }
            for (int i = 0; i < games; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    wins++;
                    points += 3;
                }
                else if (result == "D")
                {
                    draw++;
                    points += 1;
                }
                else if (result == "L")
                {
                    loses++;
                }
            }
            double porcentWins = wins / games * 100; 
            Console.WriteLine($"{tim} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {draw}");
            Console.WriteLine($"## L: {loses}");
            Console.WriteLine($"Win rate: {porcentWins:f2}%");
        }
    }
}
