using System;

namespace _0008._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxDiff = int.MinValue;
            bool check = false;
            int diff = 0;
            for (int i = 1; i <= number; i++)
            {
                
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                sum = a + b;
                if (number == 1)
                {
                    check = true;
                }
                if (sum == maxDiff)
                {
                    check = true;
                    diff = sum;
                }
                if (maxDiff > sum)
                {
                    check = false;
                    diff = maxDiff - sum;
                }
                if (maxDiff < sum)
                {
                    check = false;
                    diff = sum - maxDiff;
                }
                diff += maxDiff;
            }
            if (check == true)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");   
            }
        }
    }
}
