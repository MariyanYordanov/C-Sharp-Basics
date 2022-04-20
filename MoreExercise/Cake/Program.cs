using System;

namespace _006.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int area = width * lenght;
            bool check = false;
            while (area > 0)
            {
                string piece = Console.ReadLine();

                if (piece == "STOP")
                {
                    check = true;
                    break;
                }
                int piecesInt = int.Parse(piece);
                area -= piecesInt;
            }
            if (check)
            {
                Console.WriteLine($"{area} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(area)} pieces more.");
            }
        }
    }
}
