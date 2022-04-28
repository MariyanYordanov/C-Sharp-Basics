using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtuleFood = double.Parse(Console.ReadLine());

            double dogNeeds = dogFood * days;
            double catNeeds = catFood * days;
            double turtuleNeeds = (turtuleFood * 0.001)* days;
            double totalNeeds = dogNeeds + catNeeds + turtuleNeeds;

            if (food >= totalNeeds)
            {
                Console.WriteLine($"{Math.Floor(food - totalNeeds)} kilos of food left.");
            }
            else if (food < totalNeeds)
            {
                Console.WriteLine($"{Math.Ceiling(totalNeeds - food)} more kilos of food are needed.");
            }
        }
    }
}
