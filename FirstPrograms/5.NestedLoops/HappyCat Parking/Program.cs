using System;

namespace _0011._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;
            double sumDay = 0;

            for (int i = 1; i <= days; i++)
            {
                counter++;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        sum += 2.50;
                        sumDay += 2.50;
                    }
                    else if (j % 2 == 0 && i % 2 != 0)
                    {
                        sum += 1.25;
                        sumDay += 1.25;
                    }
                    else
                    {
                        sum += 1.00;
                        sumDay += 1.00;
                    }
                }
                Console.WriteLine($"Day: {counter} - {sumDay:f2} leva");
                sumDay = 0;
            }
            Console.WriteLine($"Total: {sum:f2} leva");
        }
    }
}
