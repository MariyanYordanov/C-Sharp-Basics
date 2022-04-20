using System;

namespace _004._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                sum += steps;
                if (sum >= 10000)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                int overSteps = int.Parse(Console.ReadLine());
                sum += overSteps;
            }
            if (sum < 10000)
            {
                Console.WriteLine($"{10000 - sum} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sum - 10000} steps over the goal!");
            }
        }
    }
}
