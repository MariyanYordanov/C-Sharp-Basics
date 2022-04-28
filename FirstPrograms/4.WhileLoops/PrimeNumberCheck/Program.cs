using System;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool check = true;
            int divider = 2;
            int dividerMax = (int)Math.Sqrt(number);
            
            while (check && (divider <= dividerMax))
            {
                if (number % divider == 0)
                {
                    check = false;
                }
                divider++;
            }
            if (check)
            {
                Console.WriteLine($"Number {number} is a prime.");
            }
            else
            {
                Console.WriteLine($"Number {number} is not a prime.");
            }
        }
    }
}
