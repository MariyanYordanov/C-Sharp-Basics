using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int pointsRed = 0;
            int pointsOrange = 0;
            int pointsYeiiow = 0;
            int pointsWhite = 0;
            int other = 0;
            int counter = 0;
            int points = 0;
            
            for (int i = 0; i < N; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        points += 5;
                        pointsRed++;
                        break;
                    case "orange":
                        points += 10;
                        pointsOrange++;
                        break;
                    case "yellow":
                        points += 15;
                        pointsYeiiow++;
                        break;
                    case "white":
                        points += 20;
                        pointsWhite++;
                        break;
                    case "black":
                        points /= 2;
                        counter++;
                        break;
                    default:
                        if (color != "red" || color != "orange" || color != "yellow" || color != "white" || color != "black")
                        {
                            other++;
                        }
                        break;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {pointsRed}");
            Console.WriteLine($"Points from orange balls: {pointsOrange}");
            Console.WriteLine($"Points from yellow balls: {pointsYeiiow}");
            Console.WriteLine($"Points from white balls: {pointsWhite}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {counter}");
        }
    }
}
