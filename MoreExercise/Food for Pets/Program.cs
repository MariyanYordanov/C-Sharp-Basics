using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double quantityBiskets = 0;
            double cat = 0;
            double dog = 0;
            double totalEaten = 0;
            for (int i = 1; i <= days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());

                dog += dogFood;
                cat += catFood;
                totalEaten += dogFood + catFood;
                if (i % 3 == 0)
                {
                    quantityBiskets += (dogFood + catFood) * 0.1;
                }
            }

            double porcentTotalEaten = totalEaten / food * 100;
            double porcentDogEaten = dog / totalEaten * 100;
            double porcentCatEaten = cat / totalEaten * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(quantityBiskets)}gr.");
            Console.WriteLine($"{porcentTotalEaten:f2}% of the food has been eaten.");
            Console.WriteLine($"{porcentDogEaten:f2}% eaten from the dog.");
            Console.WriteLine($"{porcentCatEaten:f2}% eaten from the cat.");

        }
    }
}
