using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();

            int volume = width * length * height;
            
            while (number != "Done")
            {
                int boxes = int.Parse(number);
                volume -= boxes;
                if (volume <= 0)
                {
                    break;
                }
                number = Console.ReadLine();
            }
            if (volume <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            
        }
    }
}
