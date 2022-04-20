using System;

namespace _06._Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            
            double sumTotal = 0;

            for (int i = 1; i <= days; i++)
            {
                double sumPerDay = 0;
                
                for (int j = 1; j <= hours; j++)
                {
                    double tax = 0;
                    
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        tax = 2.50;
                    }
                    else if (j % 2 == 0 && i % 2 != 0)
                    {
                        tax = 1.25;
                    }
                    else
                    {
                        tax = 1;
                    }
                    sumPerDay += tax;
                }
                sumTotal += sumPerDay;
                Console.WriteLine($"Day: {i} - {sumPerDay:f2} leva");
            }
            Console.WriteLine($"Total: {sumTotal:f2} leva");
        }
    }
}
