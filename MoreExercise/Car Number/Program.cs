using System;

namespace _0004._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    for (int k = n1; k <= n2; k++)
                    {
                        for (int m = n1; m <= n2; m++)
                        {
                            if ((i % 2 == 0 && m % 2 != 0 && i > m && ((j + k) % 2 ==0)) || (i % 2 != 0 && m % 2 == 0 && i > m && ((j + k) % 2 == 0)))
                            {
                                Console.Write($"{i}{j}{k}{m}" + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
