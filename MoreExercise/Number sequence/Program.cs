using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumbers = int.MinValue;
            int minNumbers = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                
                if (numbers > maxNumbers)
                {
                    maxNumbers = numbers;
                }
                if (numbers < minNumbers)
                {
                    minNumbers = numbers;
                }
            }
            Console.WriteLine($"Max number: {maxNumbers}");
            Console.WriteLine($"Min number: {minNumbers}");
        }
    }
}
