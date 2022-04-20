using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double sum = 0;

                while  (minBudget > sum) 
                {
                    double save = double.Parse(Console.ReadLine());
                    sum += save;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
