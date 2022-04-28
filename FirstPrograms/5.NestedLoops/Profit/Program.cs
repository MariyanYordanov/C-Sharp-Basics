using System;

namespace _0010._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int oneSum = 0;
            for (int i = 0; i <= one; i++)
            {
                int twoSum = 0;
                for (int j = 0; j <= two; j++)
                {
                    int fiveSum = 0;
                    for (int k = 0; k <= five; k++)
                    {
                        if (oneSum + twoSum + fiveSum == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                            break;
                        }
                        if (sum > fiveSum)
                        {
                            fiveSum += 5;
                        }
                    }
                    if (sum > twoSum)
                    {
                        twoSum += 2;
                    }
                }
                if (sum > oneSum)
                {
                    oneSum += 1;
                }
            }
        }
    }
}
