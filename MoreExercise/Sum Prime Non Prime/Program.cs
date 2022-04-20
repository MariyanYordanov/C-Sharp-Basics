using System;

namespace _003._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (num != "stop")
            {
                int number = int.Parse(num);

                if (number >= 0)
                {
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
                        sumPrime += number;
                    }
                    else if (!check)
                    {
                        sumNonPrime += number;
                    }

                }
                else
                {
                    Console.WriteLine($"Number is negative.");
                }

                num = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
