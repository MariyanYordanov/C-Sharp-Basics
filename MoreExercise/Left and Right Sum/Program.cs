using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRitgh = 0;
            for (int i = 1; i <= (2 * n); i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    sumLeft += num;
                }
                else
                {
                    sumRitgh += num;
                }
            }
            if (sumRitgh == sumLeft)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRitgh)}");
            }
        }
    }
}
