using System;

namespace _0002._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i == third || j == third || k == third)
                        {
                            continue;
                        }
                        else
                        {
                            counter++;
                            Console.Write($"{i}{j}{k}" + " ");
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
