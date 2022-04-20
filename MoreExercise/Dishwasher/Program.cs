using System;

namespace _0001._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottle = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int quantity = 750 * bottle;
            int counter = 0;
            int washDishes = 0;
            int washPots = 0;
            bool check = true;
            while (input != "End")
            {
                int forWash = int.Parse(input);
                counter++;
                if (counter == 3)
                {
                    quantity -= forWash * 15;
                    washPots += forWash;
                    counter = 0;
                }
                else
                {
                    quantity -= forWash * 5;
                    washDishes += forWash;
                }
                
                if (quantity < 0)
                {
                    check = false;
                    break;
                }
                input = Console.ReadLine();
            }
            if (check)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{washDishes} dishes and {washPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {quantity} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(quantity)} ml. more necessary!"); 
            }
        }
    }
}
