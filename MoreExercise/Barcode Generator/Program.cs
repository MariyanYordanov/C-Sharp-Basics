using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int units1 = num1 % 10;
            int tens1 = (num1 / 10) % 10;
            int hundreds1 = (num1 / 100) % 10;
            int tousends1 = num1 / 1000;

            int units2 = num2 % 10;
            int tens2 = (num2 / 10) % 10;
            int hundreds2 = (num2 / 100) % 10;
            int tousends2 = num2 / 1000;

            for (int i = tousends1; i <= tousends2; i++)
            {
                for (int j = hundreds1; j <= hundreds2; j++)
                {
                    for (int k = tens1; k <= tens2; k++)
                    {
                        for (int m = units1; m <= units2; m++)
                        {
                            if ((i % 2 != 0) && (j % 2 != 0) && (k % 2 != 0) && (m % 2 != 0))
                            {
                                Console.Write($"{i}{j}{k}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
