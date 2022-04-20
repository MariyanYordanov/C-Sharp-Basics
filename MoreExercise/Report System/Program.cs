using System;

namespace _0002._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double goal = double.Parse(Console.ReadLine());
            string priceProduct = Console.ReadLine();
            double sum1 = 0;
            double sum2 = 0;
            
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            bool check = false;
            while (priceProduct != "End")
            {
                int price = int.Parse(priceProduct);
                counter++;
                if (counter % 2 != 0)
                {
                    if (price > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sum1 += price;
                        counter1++;
                    }
                }
                else if (counter % 2 == 0)
                {
                    if (price < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sum2 += price;
                        counter2++;
                    }    
                }
                double sum = sum1 + sum2;
                if (sum >= goal)
                {
                    check = true;
                    break;
                }
                priceProduct = Console.ReadLine();
            }
            double CS = sum1 / counter1;
            double CC = sum2 / counter2;
            if (check)
            {
                Console.WriteLine($"Average CS: {CS:f2}");
                Console.WriteLine($"Average CC: {CC:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
