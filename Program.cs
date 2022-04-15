using System;

namespace _01._Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fats = int.Parse(Console.ReadLine());
            double proteins = int.Parse(Console.ReadLine());
            double carbohydrates = int.Parse(Console.ReadLine());
            double calories = int.Parse(Console.ReadLine());
            double water = int.Parse(Console.ReadLine());

            double fatsGrams = (fats / 100 * calories) / 9;
            double proteinsGrams = (proteins / 100 * calories) / 4;
            double carbohydratesGrams = (carbohydrates / 100 * calories) / 4;
            double food = fatsGrams + proteinsGrams + carbohydratesGrams;
            double caloriesInGram = calories / food;
            double caloriesWithoutWater = ((100 - water) / 100 * caloriesInGram);
            Console.WriteLine($"{caloriesWithoutWater:f4}");
        }
    }
}
