using System;

namespace _003._Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            double evenMax = int.MinValue;
            double evenMin = int.MaxValue;
            double oddMax = int.MinValue;
            double oddMin = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
