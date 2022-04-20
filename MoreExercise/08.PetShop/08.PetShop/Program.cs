using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double dogFood = 2.50;
            double otherAnimalsFood = 4;

            double dogsNeeds = dogFood * dogsCount;
            double otherAnimalsNeeds = otherAnimalsFood * otherAnimals;

            double sum = dogsNeeds + otherAnimalsNeeds;

            Console.WriteLine($"{sum} lv.");

        }
    }
}
