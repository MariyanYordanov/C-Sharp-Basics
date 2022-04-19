using System;

namespace _044._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double windows = double.Parse(Console.ReadLine());
            string paint = Console.ReadLine();
            double area = height * width * 4;
            double totalArea = Math.Ceiling(area - (area * (windows / 100)));
            double painted = 0;
            bool check = false;

            while (paint != "Tired!")
            {
                double litters = double.Parse(paint);
                painted += litters;
                if (painted >= totalArea)
                {
                    check = true;
                    break;
                }
                paint = Console.ReadLine();
            }

            if (paint == "Tired!")
            {
                Console.WriteLine($"{totalArea - painted} quadratic m left.");
            }
            
            if (painted == totalArea)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
            else if (check)
            {
                Console.WriteLine($"All walls are painted and you have {painted - totalArea} l paint left!");
            }
        }
    }
}
