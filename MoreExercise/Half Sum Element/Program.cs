using System;

namespace _002._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num; 
                }
            }
            int diff = sum - max;
            if (diff == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {diff}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - diff)}");
            }
        }
    }
}
