using System;

namespace _005._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    int counter1 = 96;

                    for (int k = 1; k <= l; k++)
                    {
                        int counter2 = 96;
                        counter1++;

                        for (int m = 1; m <= l; m++)
                        {
                            counter2++;
                            
                            for (int w = Math.Max(i,j) + 1 ; w <= n; w++)
                            {
                                char letter1 = Convert.ToChar(counter1);
                                char letter2 = Convert.ToChar(counter2);

                                Console.Write($"{i}{j}{letter1}{letter2}{w}" + " ");
                            }
                        } 
                    }
                }
            }
        }
    }
}
