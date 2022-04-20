using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKilos = int.Parse(Console.ReadLine());
            string foodInGrams = Console.ReadLine();
            bool check = false;
            double total = foodInKilos * 1000;
            while (foodInGrams != "Adopted")
            {
                int grams = int.Parse(foodInGrams);
                total -= grams;
                if (total >= 0 )
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                foodInGrams = Console.ReadLine();
            }
            if (check)
            {
                Console.WriteLine($"Food is enough! Leftovers: {total} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(total)} grams more.");
            }
        }
    }
}
